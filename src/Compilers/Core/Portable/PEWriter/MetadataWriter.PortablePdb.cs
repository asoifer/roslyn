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
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.DiaSymReader;
using Roslyn.Utilities;

namespace Microsoft.Cci
{
    internal partial class MetadataWriter
    {
        internal sealed class ImportScopeEqualityComparer : IEqualityComparer<IImportScope>
        {
            public static readonly ImportScopeEqualityComparer Instance;

            public bool Equals(IImportScope x, IImportScope y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 1350, 1612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 1433, 1597);

                    return (object)x == y || (DynAbs.Tracing.TraceSender.Expression_False(501, 1440, 1596) || x != null && (DynAbs.Tracing.TraceSender.Expression_True(501, 1482, 1504) && y != null) && (DynAbs.Tracing.TraceSender.Expression_True(501, 1482, 1534) && f_501_1508_1534(this, f_501_1515_1523(x), f_501_1525_1533(y))) && (DynAbs.Tracing.TraceSender.Expression_True(501, 1482, 1596) && f_501_1538_1559(x).SequenceEqual(f_501_1574_1595(y))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(501, 1350, 1612);

                    Microsoft.Cci.IImportScope
                    f_501_1515_1523(Microsoft.Cci.IImportScope
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 1515, 1523);
                        return return_v;
                    }


                    Microsoft.Cci.IImportScope
                    f_501_1525_1533(Microsoft.Cci.IImportScope
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 1525, 1533);
                        return return_v;
                    }


                    bool
                    f_501_1508_1534(Microsoft.Cci.MetadataWriter.ImportScopeEqualityComparer
                    this_param, Microsoft.Cci.IImportScope
                    x, Microsoft.Cci.IImportScope
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 1508, 1534);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                    f_501_1538_1559(Microsoft.Cci.IImportScope
                    this_param)
                    {
                        var return_v = this_param.GetUsedNamespaces();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 1538, 1559);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                    f_501_1574_1595(Microsoft.Cci.IImportScope
                    this_param)
                    {
                        var return_v = this_param.GetUsedNamespaces();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 1574, 1595);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 1350, 1612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 1350, 1612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(IImportScope obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 1628, 1831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 1701, 1816);

                    return f_501_1708_1815(f_501_1721_1764(f_501_1740_1763(obj)), (DynAbs.Tracing.TraceSender.Conditional_F1(501, 1766, 1784) || ((f_501_1766_1776(obj) != null && DynAbs.Tracing.TraceSender.Conditional_F2(501, 1787, 1810)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 1813, 1814))) ? f_501_1787_1810(this, f_501_1799_1809(obj)) : 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(501, 1628, 1831);

                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                    f_501_1740_1763(Microsoft.Cci.IImportScope
                    this_param)
                    {
                        var return_v = this_param.GetUsedNamespaces();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 1740, 1763);
                        return return_v;
                    }


                    int
                    f_501_1721_1764(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                    values)
                    {
                        var return_v = Hash.CombineValues(values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 1721, 1764);
                        return return_v;
                    }


                    Microsoft.Cci.IImportScope
                    f_501_1766_1776(Microsoft.Cci.IImportScope
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 1766, 1776);
                        return return_v;
                    }


                    Microsoft.Cci.IImportScope
                    f_501_1799_1809(Microsoft.Cci.IImportScope
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 1799, 1809);
                        return return_v;
                    }


                    int
                    f_501_1787_1810(Microsoft.Cci.MetadataWriter.ImportScopeEqualityComparer
                    this_param, Microsoft.Cci.IImportScope
                    obj)
                    {
                        var return_v = this_param.GetHashCode(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 1787, 1810);
                        return return_v;
                    }


                    int
                    f_501_1708_1815(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 1708, 1815);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 1628, 1831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 1628, 1831);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImportScopeEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(501, 1130, 1842);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(501, 1130, 1842);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 1130, 1842);
            }


            static ImportScopeEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(501, 1130, 1842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 1289, 1333);
                Instance = f_501_1300_1333(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(501, 1130, 1842);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 1130, 1842);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(501, 1130, 1842);

            static Microsoft.Cci.MetadataWriter.ImportScopeEqualityComparer
            f_501_1300_1333()
            {
                var return_v = new Microsoft.Cci.MetadataWriter.ImportScopeEqualityComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 1300, 1333);
                return return_v;
            }

        }

        private readonly Dictionary<DebugSourceDocument, DocumentHandle> _documentIndex;

        private readonly Dictionary<IImportScope, ImportScopeHandle> _scopeIndex;

        private void SerializeMethodDebugInfo(IMethodBody bodyOpt, int methodRid, StandaloneSignatureHandle localSignatureHandleOpt, ref LocalVariableHandle lastLocalVariableHandle, ref LocalConstantHandle lastLocalConstantHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 2173, 7026);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2420, 2603) || true) && (bodyOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 2420, 2603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2473, 2563);

                    f_501_2473_2562(_debugMetadataOpt, default(DocumentHandle), default(BlobHandle));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2581, 2588);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 2420, 2603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2619, 2679);

                bool
                isKickoffMethod = f_501_2642_2670(bodyOpt) != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2693, 2765);

                bool
                emitDebugInfo = isKickoffMethod || (DynAbs.Tracing.TraceSender.Expression_False(501, 2714, 2764) || f_501_2733_2764_M(!bodyOpt.SequencePoints.IsEmpty))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2781, 2963) || true) && (!emitDebugInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 2781, 2963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2833, 2923);

                    f_501_2833_2922(_debugMetadataOpt, default(DocumentHandle), default(BlobHandle));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2941, 2948);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 2781, 2963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 2979, 3047);

                var
                methodHandle = f_501_2998_3046(methodRid)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 3063, 3105);

                var
                bodyImportScope = f_501_3085_3104(bodyOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 3119, 3250);

                var
                importScopeHandle = (DynAbs.Tracing.TraceSender.Conditional_F1(501, 3143, 3168) || (((bodyImportScope != null) && DynAbs.Tracing.TraceSender.Conditional_F2(501, 3171, 3220)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 3223, 3249))) ? f_501_3171_3220(this, bodyImportScope, _scopeIndex) : default(ImportScopeHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 3311, 3347);

                DocumentHandle
                singleDocumentHandle
                = default(DocumentHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 3361, 3508);

                BlobHandle
                sequencePointsBlob = f_501_3393_3507(this, localSignatureHandleOpt, f_501_3442_3464(bodyOpt), _documentIndex, out singleDocumentHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 3524, 3636);

                f_501_3524_3635(
                            _debugMetadataOpt, document: singleDocumentHandle, sequencePoints: sequencePointsBlob);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 3847, 6085) || true) && (bodyOpt.LocalScopes.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 3847, 6085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 4006, 4364);

                    f_501_4006_4363(                // TODO: the compiler should produce a scope for each debuggable method 
                                    _debugMetadataOpt, method: methodHandle, importScope: importScopeHandle, variableList: f_501_4170_4205(lastLocalVariableHandle), constantList: f_501_4242_4277(lastLocalConstantHandle), startOffset: 0, length: bodyOpt.IL.Length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 3847, 6085);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 3847, 6085);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 4430, 6070);
                        foreach (LocalScope scope in f_501_4459_4478_I(f_501_4459_4478(bodyOpt)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 4430, 6070);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 4520, 4913);

                            f_501_4520_4912(_debugMetadataOpt, method: methodHandle, importScope: importScopeHandle, variableList: f_501_4696_4731(lastLocalVariableHandle), constantList: f_501_4772_4807(lastLocalConstantHandle), startOffset: scope.StartOffset, length: scope.Length);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 4937, 5460);
                                foreach (ILocalDefinition local in f_501_4972_4987_I(scope.Variables))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 4937, 5460);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 5037, 5072);

                                    f_501_5037_5071(f_501_5050_5065(local) >= 0);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 5100, 5358);

                                    lastLocalVariableHandle = f_501_5126_5357(_debugMetadataOpt, attributes: f_501_5203_5222(local), index: f_501_5260_5275(local), name: f_501_5312_5356(_debugMetadataOpt, f_501_5345_5355(local)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 5386, 5437);

                                    f_501_5386_5436(this, local, lastLocalVariableHandle);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 4937, 5460);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 524);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 524);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 5484, 6051);
                                foreach (ILocalDefinition constant in f_501_5522_5537_I(scope.Constants))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 5484, 6051);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 5587, 5630);

                                    var
                                    mdConstant = f_501_5604_5629(constant)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 5656, 5689);

                                    f_501_5656_5688(mdConstant != null);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 5717, 5946);

                                    lastLocalConstantHandle = f_501_5743_5945(_debugMetadataOpt, name: f_501_5814_5861(_debugMetadataOpt, f_501_5847_5860(constant)), signature: f_501_5903_5944(this, constant));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 5974, 6028);

                                    f_501_5974_6027(this, constant, lastLocalConstantHandle);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 5484, 6051);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 568);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 568);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 4430, 6070);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 1641);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 1641);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 3847, 6085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 6101, 6149);

                var
                moveNextBodyInfo = f_501_6124_6148(bodyOpt)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 6163, 6626) || true) && (moveNextBodyInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 6163, 6626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 6225, 6412);

                    f_501_6225_6411(_debugMetadataOpt, moveNextMethod: methodHandle, kickoffMethod: f_501_6353_6410(this, moveNextBodyInfo.KickoffMethod));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 6432, 6611) || true) && (moveNextBodyInfo is AsyncMoveNextBodyDebugInfo asyncInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 6432, 6611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 6534, 6592);

                        f_501_6534_6591(this, asyncInfo, methodHandle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 6432, 6611);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 6163, 6626);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 6642, 6698);

                f_501_6642_6697(this, bodyOpt, methodHandle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 6824, 7015) || true) && (f_501_6828_6890(f_501_6828_6868(f_501_6828_6860(Context.Module))) && (DynAbs.Tracing.TraceSender.Expression_True(501, 6828, 6908) && f_501_6894_6908()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 6824, 7015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 6942, 7000);

                    f_501_6942_6999(this, bodyOpt, methodHandle);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 6824, 7015);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 2173, 7026);

                System.Reflection.Metadata.MethodDebugInformationHandle
                f_501_2473_2562(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.DocumentHandle
                document, System.Reflection.Metadata.BlobHandle
                sequencePoints)
                {
                    var return_v = this_param.AddMethodDebugInformation(document, sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 2473, 2562);
                    return return_v;
                }


                string
                f_501_2642_2670(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.StateMachineTypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 2642, 2670);
                    return return_v;
                }


                bool
                f_501_2733_2764_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 2733, 2764);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDebugInformationHandle
                f_501_2833_2922(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.DocumentHandle
                document, System.Reflection.Metadata.BlobHandle
                sequencePoints)
                {
                    var return_v = this_param.AddMethodDebugInformation(document, sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 2833, 2922);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_501_2998_3046(int
                rowNumber)
                {
                    var return_v = MetadataTokens.MethodDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 2998, 3046);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_501_3085_3104(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.ImportScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 3085, 3104);
                    return return_v;
                }


                System.Reflection.Metadata.ImportScopeHandle
                f_501_3171_3220(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IImportScope
                scope, System.Collections.Generic.Dictionary<Microsoft.Cci.IImportScope, System.Reflection.Metadata.ImportScopeHandle>
                scopeIndex)
                {
                    var return_v = this_param.GetImportScopeIndex(scope, scopeIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 3171, 3220);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
                f_501_3442_3464(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.SequencePoints;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 3442, 3464);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_3393_3507(Microsoft.Cci.MetadataWriter
                this_param, System.Reflection.Metadata.StandaloneSignatureHandle
                localSignatureHandleOpt, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
                sequencePoints, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, System.Reflection.Metadata.DocumentHandle>
                documentIndex, out System.Reflection.Metadata.DocumentHandle
                singleDocumentHandle)
                {
                    var return_v = this_param.SerializeSequencePoints(localSignatureHandleOpt, sequencePoints, documentIndex, out singleDocumentHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 3393, 3507);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDebugInformationHandle
                f_501_3524_3635(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.DocumentHandle
                document, System.Reflection.Metadata.BlobHandle
                sequencePoints)
                {
                    var return_v = this_param.AddMethodDebugInformation(document: document, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 3524, 3635);
                    return return_v;
                }


                System.Reflection.Metadata.LocalVariableHandle
                f_501_4170_4205(System.Reflection.Metadata.LocalVariableHandle
                handle)
                {
                    var return_v = NextHandle(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 4170, 4205);
                    return return_v;
                }


                System.Reflection.Metadata.LocalConstantHandle
                f_501_4242_4277(System.Reflection.Metadata.LocalConstantHandle
                handle)
                {
                    var return_v = NextHandle(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 4242, 4277);
                    return return_v;
                }


                System.Reflection.Metadata.LocalScopeHandle
                f_501_4006_4363(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                method, System.Reflection.Metadata.ImportScopeHandle
                importScope, System.Reflection.Metadata.LocalVariableHandle
                variableList, System.Reflection.Metadata.LocalConstantHandle
                constantList, int
                startOffset, int
                length)
                {
                    var return_v = this_param.AddLocalScope(method: method, importScope: importScope, variableList: variableList, constantList: constantList, startOffset: startOffset, length: length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 4006, 4363);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                f_501_4459_4478(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.LocalScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 4459, 4478);
                    return return_v;
                }


                System.Reflection.Metadata.LocalVariableHandle
                f_501_4696_4731(System.Reflection.Metadata.LocalVariableHandle
                handle)
                {
                    var return_v = NextHandle(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 4696, 4731);
                    return return_v;
                }


                System.Reflection.Metadata.LocalConstantHandle
                f_501_4772_4807(System.Reflection.Metadata.LocalConstantHandle
                handle)
                {
                    var return_v = NextHandle(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 4772, 4807);
                    return return_v;
                }


                System.Reflection.Metadata.LocalScopeHandle
                f_501_4520_4912(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                method, System.Reflection.Metadata.ImportScopeHandle
                importScope, System.Reflection.Metadata.LocalVariableHandle
                variableList, System.Reflection.Metadata.LocalConstantHandle
                constantList, int
                startOffset, int
                length)
                {
                    var return_v = this_param.AddLocalScope(method: method, importScope: importScope, variableList: variableList, constantList: constantList, startOffset: startOffset, length: length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 4520, 4912);
                    return return_v;
                }


                int
                f_501_5050_5065(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 5050, 5065);
                    return return_v;
                }


                int
                f_501_5037_5071(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5037, 5071);
                    return 0;
                }


                System.Reflection.Metadata.LocalVariableAttributes
                f_501_5203_5222(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.PdbAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 5203, 5222);
                    return return_v;
                }


                int
                f_501_5260_5275(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 5260, 5275);
                    return return_v;
                }


                string?
                f_501_5345_5355(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 5345, 5355);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle
                f_501_5312_5356(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string?
                value)
                {
                    var return_v = this_param.GetOrAddString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5312, 5356);
                    return return_v;
                }


                System.Reflection.Metadata.LocalVariableHandle
                f_501_5126_5357(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.LocalVariableAttributes
                attributes, int
                index, System.Reflection.Metadata.StringHandle
                name)
                {
                    var return_v = this_param.AddLocalVariable(attributes: attributes, index: index, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5126, 5357);
                    return return_v;
                }


                int
                f_501_5386_5436(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ILocalDefinition
                local, System.Reflection.Metadata.LocalVariableHandle
                parent)
                {
                    this_param.SerializeLocalInfo(local, (System.Reflection.Metadata.EntityHandle)parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5386, 5436);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_501_4972_4987_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 4972, 4987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_501_5604_5629(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.CompileTimeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 5604, 5629);
                    return return_v;
                }


                int
                f_501_5656_5688(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5656, 5688);
                    return 0;
                }


                string?
                f_501_5847_5860(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 5847, 5860);
                    return return_v;
                }


                System.Reflection.Metadata.StringHandle
                f_501_5814_5861(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string?
                value)
                {
                    var return_v = this_param.GetOrAddString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5814, 5861);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_5903_5944(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ILocalDefinition
                localConstant)
                {
                    var return_v = this_param.SerializeLocalConstantSignature(localConstant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5903, 5944);
                    return return_v;
                }


                System.Reflection.Metadata.LocalConstantHandle
                f_501_5743_5945(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.StringHandle
                name, System.Reflection.Metadata.BlobHandle
                signature)
                {
                    var return_v = this_param.AddLocalConstant(name: name, signature: signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5743, 5945);
                    return return_v;
                }


                int
                f_501_5974_6027(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ILocalDefinition
                local, System.Reflection.Metadata.LocalConstantHandle
                parent)
                {
                    this_param.SerializeLocalInfo(local, (System.Reflection.Metadata.EntityHandle)parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5974, 6027);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_501_5522_5537_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 5522, 5537);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                f_501_4459_4478_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 4459, 4478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.StateMachineMoveNextBodyDebugInfo
                f_501_6124_6148(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MoveNextBodyInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 6124, 6148);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_501_6353_6410(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodDefinition
                def)
                {
                    var return_v = this_param.GetMethodDefinitionHandle(def);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 6353, 6410);
                    return return_v;
                }


                int
                f_501_6225_6411(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                moveNextMethod, System.Reflection.Metadata.MethodDefinitionHandle
                kickoffMethod)
                {
                    this_param.AddStateMachineMethod(moveNextMethod: moveNextMethod, kickoffMethod: kickoffMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 6225, 6411);
                    return 0;
                }


                int
                f_501_6534_6591(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.CodeAnalysis.Emit.AsyncMoveNextBodyDebugInfo
                asyncInfo, System.Reflection.Metadata.MethodDefinitionHandle
                moveNextMethod)
                {
                    this_param.SerializeAsyncMethodSteppingInfo(asyncInfo, moveNextMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 6534, 6591);
                    return 0;
                }


                int
                f_501_6642_6697(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodBody
                methodBody, System.Reflection.Metadata.MethodDefinitionHandle
                method)
                {
                    this_param.SerializeStateMachineLocalScopes(methodBody, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 6642, 6697);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_6828_6860(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 6828, 6860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_501_6828_6868(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 6828, 6868);
                    return return_v;
                }


                bool
                f_501_6828_6890(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.EnableEditAndContinue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 6828, 6890);
                    return return_v;
                }


                bool
                f_501_6894_6908()
                {
                    var return_v = IsFullMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 6894, 6908);
                    return return_v;
                }


                int
                f_501_6942_6999(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IMethodBody
                methodBody, System.Reflection.Metadata.MethodDefinitionHandle
                method)
                {
                    this_param.SerializeEncMethodDebugInformation(methodBody, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 6942, 6999);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 2173, 7026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 2173, 7026);
            }
        }

        private static LocalVariableHandle NextHandle(LocalVariableHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 7112, 7203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7128, 7203);
                return f_501_7128_7203(f_501_7163_7198(handle) + 1); DynAbs.Tracing.TraceSender.TraceExitMethod(501, 7112, 7203);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 7112, 7203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 7112, 7203);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_501_7163_7198(System.Reflection.Metadata.LocalVariableHandle
            handle)
            {
                var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 7163, 7198);
                return return_v;
            }


            System.Reflection.Metadata.LocalVariableHandle
            f_501_7128_7203(int
            rowNumber)
            {
                var return_v = MetadataTokens.LocalVariableHandle(rowNumber);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 7128, 7203);
                return return_v;
            }

        }

        private static LocalConstantHandle NextHandle(LocalConstantHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 7290, 7381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7306, 7381);
                return f_501_7306_7381(f_501_7341_7376(handle) + 1); DynAbs.Tracing.TraceSender.TraceExitMethod(501, 7290, 7381);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 7290, 7381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 7290, 7381);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_501_7341_7376(System.Reflection.Metadata.LocalConstantHandle
            handle)
            {
                var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 7341, 7376);
                return return_v;
            }


            System.Reflection.Metadata.LocalConstantHandle
            f_501_7306_7381(int
            rowNumber)
            {
                var return_v = MetadataTokens.LocalConstantHandle(rowNumber);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 7306, 7381);
                return return_v;
            }

        }

        private BlobHandle SerializeLocalConstantSignature(ILocalDefinition localConstant)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 7394, 9933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7501, 7533);

                var
                builder = f_501_7515_7532()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7635, 7685);

                var
                encoder = f_501_7649_7684(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7699, 7764);

                f_501_7699_7763(this, encoder, f_501_7733_7762(localConstant));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7780, 7810);

                var
                type = f_501_7791_7809(localConstant)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7824, 7853);

                var
                typeCode = f_501_7839_7852(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7869, 7921);

                object
                value = f_501_7884_7920(f_501_7884_7914(localConstant))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 7987, 9859) || true) && (value is decimal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 7987, 9859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8041, 8094);

                    f_501_8041_8093(builder, SignatureTypeKind.ValueType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8112, 8195);

                    f_501_8112_8194(builder, f_501_8143_8193(f_501_8173_8192(this, type)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8215, 8252);

                    f_501_8215_8251(
                                    builder, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 7987, 9859);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 7987, 9859);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8286, 9859) || true) && (value is DateTime)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 8286, 9859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8341, 8394);

                        f_501_8341_8393(builder, SignatureTypeKind.ValueType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8412, 8495);

                        f_501_8412_8494(builder, f_501_8443_8493(f_501_8473_8492(this, type)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8515, 8554);

                        f_501_8515_8553(
                                        builder, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 8286, 9859);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 8286, 9859);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8588, 9859) || true) && (typeCode == PrimitiveTypeCode.String)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 8588, 9859);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8662, 8711);

                            f_501_8662_8710(builder, ConstantTypeCode.String);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8729, 8947) || true) && (value == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 8729, 8947);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8788, 8812);

                                f_501_8788_8811(builder, 0xff);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 8729, 8947);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 8729, 8947);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8894, 8928);

                                f_501_8894_8927(builder, value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 8729, 8947);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 8588, 9859);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 8588, 9859);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 8981, 9859) || true) && (value != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 8981, 9859);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9061, 9113);

                                f_501_9061_9112(                // TypeCode
                                                builder, f_501_9085_9111(value));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9159, 9188);

                                f_501_9159_9187(
                                                // Value
                                                builder, value);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9237, 9396) || true) && (f_501_9241_9252(type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 9237, 9396);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9294, 9377);

                                    f_501_9294_9376(builder, f_501_9325_9375(f_501_9355_9374(this, type)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 9237, 9396);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 8981, 9859);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 8981, 9859);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9430, 9859) || true) && (f_501_9434_9493(this.module, type, PlatformType.SystemObject))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 9430, 9859);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9527, 9577);

                                    f_501_9527_9576(builder, SignatureTypeCode.Object);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 9430, 9859);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 9430, 9859);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9643, 9743);

                                    f_501_9643_9742(builder, ((DynAbs.Tracing.TraceSender.Conditional_F1(501, 9668, 9684) || ((f_501_9668_9684(type) && DynAbs.Tracing.TraceSender.Conditional_F2(501, 9687, 9714)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 9717, 9740))) ? SignatureTypeKind.ValueType : SignatureTypeKind.Class));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9761, 9844);

                                    f_501_9761_9843(builder, f_501_9792_9842(f_501_9822_9841(this, type)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 9430, 9859);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 8981, 9859);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 8588, 9859);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 8286, 9859);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 7987, 9859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 9875, 9922);

                return f_501_9882_9921(_debugMetadataOpt, builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 7394, 9933);

                System.Reflection.Metadata.BlobBuilder
                f_501_7515_7532()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 7515, 7532);
                    return return_v;
                }


                System.Reflection.Metadata.Ecma335.CustomModifiersEncoder
                f_501_7649_7684(System.Reflection.Metadata.BlobBuilder
                builder)
                {
                    var return_v = new System.Reflection.Metadata.Ecma335.CustomModifiersEncoder(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 7649, 7684);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                f_501_7733_7762(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 7733, 7762);
                    return return_v;
                }


                int
                f_501_7699_7763(Microsoft.Cci.MetadataWriter
                this_param, System.Reflection.Metadata.Ecma335.CustomModifiersEncoder
                encoder, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                modifiers)
                {
                    this_param.SerializeCustomModifiers(encoder, modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 7699, 7763);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_501_7791_7809(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 7791, 7809);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_501_7839_7852(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.TypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 7839, 7852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_501_7884_7914(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.CompileTimeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 7884, 7914);
                    return return_v;
                }


                object?
                f_501_7884_7920(Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 7884, 7920);
                    return return_v;
                }


                int
                f_501_8041_8093(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.SignatureTypeKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8041, 8093);
                    return 0;
                }


                System.Reflection.Metadata.EntityHandle
                f_501_8173_8192(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeHandle(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8173, 8192);
                    return return_v;
                }


                int
                f_501_8143_8193(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = CodedIndex.TypeDefOrRefOrSpec(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8143, 8193);
                    return return_v;
                }


                int
                f_501_8112_8194(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8112, 8194);
                    return 0;
                }


                int
                f_501_8215_8251(System.Reflection.Metadata.BlobBuilder
                this_param, object
                value)
                {
                    this_param.WriteDecimal((decimal)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8215, 8251);
                    return 0;
                }


                int
                f_501_8341_8393(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.SignatureTypeKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8341, 8393);
                    return 0;
                }


                System.Reflection.Metadata.EntityHandle
                f_501_8473_8492(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeHandle(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8473, 8492);
                    return return_v;
                }


                int
                f_501_8443_8493(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = CodedIndex.TypeDefOrRefOrSpec(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8443, 8493);
                    return return_v;
                }


                int
                f_501_8412_8494(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8412, 8494);
                    return 0;
                }


                int
                f_501_8515_8553(System.Reflection.Metadata.BlobBuilder
                this_param, object
                value)
                {
                    this_param.WriteDateTime((System.DateTime)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8515, 8553);
                    return 0;
                }


                int
                f_501_8662_8710(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ConstantTypeCode
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8662, 8710);
                    return 0;
                }


                int
                f_501_8788_8811(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8788, 8811);
                    return 0;
                }


                int
                f_501_8894_8927(System.Reflection.Metadata.BlobBuilder
                this_param, object
                value)
                {
                    this_param.WriteUTF16((string)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 8894, 8927);
                    return 0;
                }


                System.Reflection.Metadata.SignatureTypeCode
                f_501_9085_9111(object
                value)
                {
                    var return_v = GetConstantTypeCode(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9085, 9111);
                    return return_v;
                }


                int
                f_501_9061_9112(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.SignatureTypeCode
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9061, 9112);
                    return 0;
                }


                int
                f_501_9159_9187(System.Reflection.Metadata.BlobBuilder
                this_param, object
                value)
                {
                    this_param.WriteConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9159, 9187);
                    return 0;
                }


                bool
                f_501_9241_9252(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 9241, 9252);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_501_9355_9374(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeHandle(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9355, 9374);
                    return return_v;
                }


                int
                f_501_9325_9375(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = CodedIndex.TypeDefOrRefOrSpec(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9325, 9375);
                    return return_v;
                }


                int
                f_501_9294_9376(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9294, 9376);
                    return 0;
                }


                bool
                f_501_9434_9493(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.Cci.ITypeReference
                typeRef, Microsoft.Cci.PlatformType
                platformType)
                {
                    var return_v = this_param.IsPlatformType(typeRef, platformType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9434, 9493);
                    return return_v;
                }


                int
                f_501_9527_9576(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.SignatureTypeCode
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9527, 9576);
                    return 0;
                }


                bool
                f_501_9668_9684(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 9668, 9684);
                    return return_v;
                }


                int
                f_501_9643_9742(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.SignatureTypeKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9643, 9742);
                    return 0;
                }


                System.Reflection.Metadata.EntityHandle
                f_501_9822_9841(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeHandle(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9822, 9841);
                    return return_v;
                }


                int
                f_501_9792_9842(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = CodedIndex.TypeDefOrRefOrSpec(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9792, 9842);
                    return return_v;
                }


                int
                f_501_9761_9843(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9761, 9843);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_9882_9921(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 9882, 9921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 7394, 9933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 7394, 9933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SignatureTypeCode GetConstantTypeCode(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(501, 9945, 12329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10036, 10275) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 10036, 10275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10210, 10260);

                    return (SignatureTypeCode)SignatureTypeKind.Class;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 10036, 10275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10291, 10343);

                f_501_10291_10342(f_501_10304_10341_M(!f_501_10305_10334(f_501_10305_10320(value)).IsEnum));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10563, 10677) || true) && (f_501_10567_10582(value) == typeof(int))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 10563, 10677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10631, 10662);

                    return SignatureTypeCode.Int32;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 10563, 10677);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10693, 10811) || true) && (f_501_10697_10712(value) == typeof(string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 10693, 10811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10764, 10796);

                    return SignatureTypeCode.String;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 10693, 10811);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10827, 10944) || true) && (f_501_10831_10846(value) == typeof(bool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 10827, 10944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10896, 10929);

                    return SignatureTypeCode.Boolean;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 10827, 10944);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 10960, 11074) || true) && (f_501_10964_10979(value) == typeof(char))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 10960, 11074);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11029, 11059);

                    return SignatureTypeCode.Char;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 10960, 11074);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11090, 11204) || true) && (f_501_11094_11109(value) == typeof(byte))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 11090, 11204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11159, 11189);

                    return SignatureTypeCode.Byte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 11090, 11204);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11220, 11335) || true) && (f_501_11224_11239(value) == typeof(long))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 11220, 11335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11289, 11320);

                    return SignatureTypeCode.Int64;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 11220, 11335);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11351, 11469) || true) && (f_501_11355_11370(value) == typeof(double))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 11351, 11469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11422, 11454);

                    return SignatureTypeCode.Double;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 11351, 11469);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11485, 11601) || true) && (f_501_11489_11504(value) == typeof(short))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 11485, 11601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11555, 11586);

                    return SignatureTypeCode.Int16;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 11485, 11601);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11617, 11735) || true) && (f_501_11621_11636(value) == typeof(ushort))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 11617, 11735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11688, 11720);

                    return SignatureTypeCode.UInt16;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 11617, 11735);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11751, 11867) || true) && (f_501_11755_11770(value) == typeof(uint))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 11751, 11867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11820, 11852);

                    return SignatureTypeCode.UInt32;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 11751, 11867);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11883, 11999) || true) && (f_501_11887_11902(value) == typeof(sbyte))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 11883, 11999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 11953, 11984);

                    return SignatureTypeCode.SByte;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 11883, 11999);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 12015, 12132) || true) && (f_501_12019_12034(value) == typeof(ulong))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 12015, 12132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 12085, 12117);

                    return SignatureTypeCode.UInt64;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 12015, 12132);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 12148, 12265) || true) && (f_501_12152_12167(value) == typeof(float))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 12148, 12265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 12218, 12250);

                    return SignatureTypeCode.Single;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 12148, 12265);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 12281, 12318);

                throw f_501_12287_12317();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(501, 9945, 12329);

                System.Type
                f_501_10305_10320(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 10305, 10320);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_501_10305_10334(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 10305, 10334);
                    return return_v;
                }


                bool
                f_501_10304_10341_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 10304, 10341);
                    return return_v;
                }


                int
                f_501_10291_10342(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 10291, 10342);
                    return 0;
                }


                System.Type
                f_501_10567_10582(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 10567, 10582);
                    return return_v;
                }


                System.Type
                f_501_10697_10712(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 10697, 10712);
                    return return_v;
                }


                System.Type
                f_501_10831_10846(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 10831, 10846);
                    return return_v;
                }


                System.Type
                f_501_10964_10979(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 10964, 10979);
                    return return_v;
                }


                System.Type
                f_501_11094_11109(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 11094, 11109);
                    return return_v;
                }


                System.Type
                f_501_11224_11239(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 11224, 11239);
                    return return_v;
                }


                System.Type
                f_501_11355_11370(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 11355, 11370);
                    return return_v;
                }


                System.Type
                f_501_11489_11504(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 11489, 11504);
                    return return_v;
                }


                System.Type
                f_501_11621_11636(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 11621, 11636);
                    return return_v;
                }


                System.Type
                f_501_11755_11770(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 11755, 11770);
                    return return_v;
                }


                System.Type
                f_501_11887_11902(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 11887, 11902);
                    return return_v;
                }


                System.Type
                f_501_12019_12034(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12019, 12034);
                    return return_v;
                }


                System.Type
                f_501_12152_12167(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12152, 12167);
                    return return_v;
                }


                System.Exception
                f_501_12287_12317()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 12287, 12317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 9945, 12329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 9945, 12329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ImportScopeHandle ModuleImportScopeHandle;

        private void SerializeImport(BlobBuilder writer, AssemblyReferenceAlias alias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 12488, 12992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 12669, 12737);

                f_501_12669_12736(            // <import> ::= AliasAssemblyReference <alias> <target-assembly>
                            writer, ImportDefinitionKind.AliasAssemblyReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 12751, 12859);

                f_501_12751_12858(writer, f_501_12781_12857(f_501_12810_12856(_debugMetadataOpt, alias.Name)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 12873, 12981);

                f_501_12873_12980(writer, f_501_12903_12979(f_501_12931_12978(this, alias.Assembly)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 12488, 12992);

                int
                f_501_12669_12736(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12669, 12736);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_12810_12856(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12810, 12856);
                    return return_v;
                }


                int
                f_501_12781_12857(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12781, 12857);
                    return return_v;
                }


                int
                f_501_12751_12858(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12751, 12858);
                    return 0;
                }


                System.Reflection.Metadata.AssemblyReferenceHandle
                f_501_12931_12978(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IAssemblyReference
                reference)
                {
                    var return_v = this_param.GetOrAddAssemblyReferenceHandle(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12931, 12978);
                    return return_v;
                }


                int
                f_501_12903_12979(System.Reflection.Metadata.AssemblyReferenceHandle
                handle)
                {
                    var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12903, 12979);
                    return return_v;
                }


                int
                f_501_12873_12980(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 12873, 12980);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 12488, 12992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 12488, 12992);
            }
        }

        private void SerializeImport(BlobBuilder writer, UsedNamespaceOrType import)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 13004, 17205);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13105, 17194) || true) && (import.TargetXmlNamespaceOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 13105, 17194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13179, 13227);

                    f_501_13179_13226(import.TargetNamespaceOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13245, 13292);

                    f_501_13245_13291(import.TargetAssemblyOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13310, 13353);

                    f_501_13310_13352(import.TargetTypeOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13452, 13516);

                    f_501_13452_13515(
                                    // <import> ::= ImportXmlNamespace <alias> <target-namespace>
                                    writer, ImportDefinitionKind.ImportXmlNamespace);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13534, 13647);

                    f_501_13534_13646(writer, f_501_13564_13645(f_501_13593_13644(_debugMetadataOpt, import.AliasOpt)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13665, 13791);

                    f_501_13665_13790(writer, f_501_13695_13789(f_501_13724_13788(_debugMetadataOpt, import.TargetXmlNamespaceOpt)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 13105, 17194);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 13105, 17194);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13825, 17194) || true) && (import.TargetTypeOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 13825, 17194);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13891, 13939);

                        f_501_13891_13938(import.TargetNamespaceOpt == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 13957, 14004);

                        f_501_13957_14003(import.TargetAssemblyOpt == null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 14024, 14571) || true) && (import.AliasOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 14024, 14571);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 14162, 14217);

                            f_501_14162_14216(                    // <import> ::= AliasType <alias> <target-type>
                                                writer, ImportDefinitionKind.AliasType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 14239, 14352);

                            f_501_14239_14351(writer, f_501_14269_14350(f_501_14298_14349(_debugMetadataOpt, import.AliasOpt)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 14024, 14571);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 14024, 14571);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 14496, 14552);

                            f_501_14496_14551(                    // <import> ::= ImportType <target-type>
                                                writer, ImportDefinitionKind.ImportType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 14024, 14571);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 14591, 14689);

                        f_501_14591_14688(
                                        writer, f_501_14621_14687(f_501_14651_14686(this, import.TargetTypeOpt)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 13825, 17194);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 13825, 17194);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 14755, 17194) || true) && (import.TargetNamespaceOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 14755, 17194);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 14826, 16444) || true) && (import.TargetAssemblyOpt != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 14826, 16444);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 14904, 15589) || true) && (import.AliasOpt != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 14904, 15589);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 15090, 15158);

                                    f_501_15090_15157(                        // <import> ::= AliasAssemblyNamespace <alias> <target-assembly> <target-namespace>
                                                            writer, ImportDefinitionKind.AliasAssemblyNamespace);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 15184, 15297);

                                    f_501_15184_15296(writer, f_501_15214_15295(f_501_15243_15294(_debugMetadataOpt, import.AliasOpt)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 14904, 15589);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 14904, 15589);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 15497, 15566);

                                    f_501_15497_15565(                        // <import> ::= ImportAssemblyNamespace <target-assembly> <target-namespace>
                                                            writer, ImportDefinitionKind.ImportAssemblyNamespace);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 14904, 15589);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 15613, 15726);

                                f_501_15613_15725(
                                                    writer, f_501_15643_15724(f_501_15671_15723(this, import.TargetAssemblyOpt)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 14826, 16444);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 14826, 16444);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 15808, 16425) || true) && (import.AliasOpt != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 15808, 16425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 15968, 16028);

                                    f_501_15968_16027(                        // <import> ::= AliasNamespace <alias> <target-namespace>
                                                            writer, ImportDefinitionKind.AliasNamespace);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 16054, 16167);

                                    f_501_16054_16166(writer, f_501_16084_16165(f_501_16113_16164(_debugMetadataOpt, import.AliasOpt)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 15808, 16425);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 15808, 16425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 16341, 16402);

                                    f_501_16341_16401(                        // <import> ::= ImportNamespace <target-namespace>
                                                            writer, ImportDefinitionKind.ImportNamespace);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 15808, 16425);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 14826, 16444);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 16497, 16594);

                            string
                            namespaceName = f_501_16520_16593(import.TargetNamespaceOpt)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 16612, 16723);

                            f_501_16612_16722(writer, f_501_16642_16721(f_501_16671_16720(_debugMetadataOpt, namespaceName)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 14755, 17194);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 14755, 17194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 16851, 16889);

                            f_501_16851_16888(import.AliasOpt != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 16907, 16954);

                            f_501_16907_16953(import.TargetAssemblyOpt == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 16974, 17048);

                            f_501_16974_17047(
                                            writer, ImportDefinitionKind.ImportAssemblyReferenceAlias);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17066, 17179);

                            f_501_17066_17178(writer, f_501_17096_17177(f_501_17125_17176(_debugMetadataOpt, import.AliasOpt)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 14755, 17194);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 13825, 17194);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 13105, 17194);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 13004, 17205);

                int
                f_501_13179_13226(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13179, 13226);
                    return 0;
                }


                int
                f_501_13245_13291(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13245, 13291);
                    return 0;
                }


                int
                f_501_13310_13352(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13310, 13352);
                    return 0;
                }


                int
                f_501_13452_13515(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13452, 13515);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_13593_13644(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string?
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13593, 13644);
                    return return_v;
                }


                int
                f_501_13564_13645(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13564, 13645);
                    return return_v;
                }


                int
                f_501_13534_13646(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13534, 13646);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_13724_13788(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13724, 13788);
                    return return_v;
                }


                int
                f_501_13695_13789(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13695, 13789);
                    return return_v;
                }


                int
                f_501_13665_13790(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13665, 13790);
                    return 0;
                }


                int
                f_501_13891_13938(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13891, 13938);
                    return 0;
                }


                int
                f_501_13957_14003(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 13957, 14003);
                    return 0;
                }


                int
                f_501_14162_14216(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 14162, 14216);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_14298_14349(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 14298, 14349);
                    return return_v;
                }


                int
                f_501_14269_14350(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 14269, 14350);
                    return return_v;
                }


                int
                f_501_14239_14351(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 14239, 14351);
                    return 0;
                }


                int
                f_501_14496_14551(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 14496, 14551);
                    return 0;
                }


                System.Reflection.Metadata.EntityHandle
                f_501_14651_14686(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.ITypeReference
                typeReference)
                {
                    var return_v = this_param.GetTypeHandle(typeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 14651, 14686);
                    return return_v;
                }


                int
                f_501_14621_14687(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = CodedIndex.TypeDefOrRefOrSpec(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 14621, 14687);
                    return return_v;
                }


                int
                f_501_14591_14688(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 14591, 14688);
                    return 0;
                }


                int
                f_501_15090_15157(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15090, 15157);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_15243_15294(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15243, 15294);
                    return return_v;
                }


                int
                f_501_15214_15295(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15214, 15295);
                    return return_v;
                }


                int
                f_501_15184_15296(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15184, 15296);
                    return 0;
                }


                int
                f_501_15497_15565(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15497, 15565);
                    return 0;
                }


                System.Reflection.Metadata.AssemblyReferenceHandle
                f_501_15671_15723(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IAssemblyReference
                assemblyReference)
                {
                    var return_v = this_param.GetAssemblyReferenceHandle(assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15671, 15723);
                    return return_v;
                }


                int
                f_501_15643_15724(System.Reflection.Metadata.AssemblyReferenceHandle
                handle)
                {
                    var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15643, 15724);
                    return return_v;
                }


                int
                f_501_15613_15725(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15613, 15725);
                    return 0;
                }


                int
                f_501_15968_16027(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 15968, 16027);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_16113_16164(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16113, 16164);
                    return return_v;
                }


                int
                f_501_16084_16165(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16084, 16165);
                    return return_v;
                }


                int
                f_501_16054_16166(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16054, 16166);
                    return 0;
                }


                int
                f_501_16341_16401(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16341, 16401);
                    return 0;
                }


                string
                f_501_16520_16593(Microsoft.Cci.INamespace
                @namespace)
                {
                    var return_v = TypeNameSerializer.BuildQualifiedNamespaceName(@namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16520, 16593);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_16671_16720(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16671, 16720);
                    return return_v;
                }


                int
                f_501_16642_16721(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16642, 16721);
                    return return_v;
                }


                int
                f_501_16612_16722(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16612, 16722);
                    return 0;
                }


                int
                f_501_16851_16888(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16851, 16888);
                    return 0;
                }


                int
                f_501_16907_16953(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16907, 16953);
                    return 0;
                }


                int
                f_501_16974_17047(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ImportDefinitionKind
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 16974, 17047);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_17125_17176(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17125, 17176);
                    return return_v;
                }


                int
                f_501_17096_17177(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17096, 17177);
                    return return_v;
                }


                int
                f_501_17066_17178(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17066, 17178);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 13004, 17205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 13004, 17205);
            }
        }

        private void DefineModuleImportScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 17217, 17995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17323, 17354);

                var
                writer = f_501_17336_17353()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17370, 17404);

                f_501_17370_17403(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17420, 17584);
                    foreach (AssemblyReferenceAlias alias in f_501_17461_17504_I(f_501_17461_17504(module, Context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 17420, 17584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17538, 17569);

                        f_501_17538_17568(this, writer, alias);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 17420, 17584);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 165);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17600, 17739);
                    foreach (UsedNamespaceOrType import in f_501_17639_17658_I(f_501_17639_17658(module)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 17600, 17739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17692, 17724);

                        f_501_17692_17723(this, writer, import);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 17600, 17739);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17755, 17923);

                var
                rid = f_501_17765_17922(_debugMetadataOpt, parentScope: default(ImportScopeHandle), imports: f_501_17883_17921(_debugMetadataOpt, writer))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 17939, 17984);

                f_501_17939_17983(rid == ModuleImportScopeHandle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 17217, 17995);

                System.Reflection.Metadata.BlobBuilder
                f_501_17336_17353()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17336, 17353);
                    return return_v;
                }


                int
                f_501_17370_17403(Microsoft.Cci.MetadataWriter
                this_param)
                {
                    this_param.SerializeModuleDefaultNamespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17370, 17403);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_501_17461_17504(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAssemblyReferenceAliases(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17461, 17504);
                    return return_v;
                }


                int
                f_501_17538_17568(Microsoft.Cci.MetadataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                writer, Microsoft.Cci.AssemblyReferenceAlias
                alias)
                {
                    this_param.SerializeImport(writer, alias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17538, 17568);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_501_17461_17504_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17461, 17504);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_501_17639_17658(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetImports();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17639, 17658);
                    return return_v;
                }


                int
                f_501_17692_17723(Microsoft.Cci.MetadataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                writer, Microsoft.Cci.UsedNamespaceOrType
                import)
                {
                    this_param.SerializeImport(writer, import);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17692, 17723);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_501_17639_17658_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17639, 17658);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_17883_17921(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17883, 17921);
                    return return_v;
                }


                System.Reflection.Metadata.ImportScopeHandle
                f_501_17765_17922(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.ImportScopeHandle
                parentScope, System.Reflection.Metadata.BlobHandle
                imports)
                {
                    var return_v = this_param.AddImportScope(parentScope: parentScope, imports: imports);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17765, 17922);
                    return return_v;
                }


                int
                f_501_17939_17983(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 17939, 17983);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 17217, 17995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 17217, 17995);
            }
        }

        private ImportScopeHandle GetImportScopeIndex(IImportScope scope, Dictionary<IImportScope, ImportScopeHandle> scopeIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 18007, 18784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18153, 18183);

                ImportScopeHandle
                scopeHandle
                = default(ImportScopeHandle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18197, 18361) || true) && (f_501_18201_18247(scopeIndex, scope, out scopeHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 18197, 18361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18327, 18346);

                    return scopeHandle;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 18197, 18361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18377, 18403);

                var
                parent = f_501_18390_18402(scope)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18417, 18532);

                var
                parentScopeHandle = (DynAbs.Tracing.TraceSender.Conditional_F1(501, 18441, 18457) || (((parent != null) && DynAbs.Tracing.TraceSender.Conditional_F2(501, 18460, 18505)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 18508, 18531))) ? f_501_18460_18505(this, f_501_18480_18492(scope), scopeIndex) : ModuleImportScopeHandle
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18548, 18699);

                var
                result = f_501_18561_18698(_debugMetadataOpt, parentScope: parentScopeHandle, imports: f_501_18670_18697(this, scope))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18715, 18745);

                f_501_18715_18744(
                            scopeIndex, scope, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18759, 18773);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 18007, 18784);

                bool
                f_501_18201_18247(System.Collections.Generic.Dictionary<Microsoft.Cci.IImportScope, System.Reflection.Metadata.ImportScopeHandle>
                this_param, Microsoft.Cci.IImportScope
                key, out System.Reflection.Metadata.ImportScopeHandle
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 18201, 18247);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_501_18390_18402(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 18390, 18402);
                    return return_v;
                }


                Microsoft.Cci.IImportScope
                f_501_18480_18492(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 18480, 18492);
                    return return_v;
                }


                System.Reflection.Metadata.ImportScopeHandle
                f_501_18460_18505(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IImportScope
                scope, System.Collections.Generic.Dictionary<Microsoft.Cci.IImportScope, System.Reflection.Metadata.ImportScopeHandle>
                scopeIndex)
                {
                    var return_v = this_param.GetImportScopeIndex(scope, scopeIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 18460, 18505);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_18670_18697(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.IImportScope
                scope)
                {
                    var return_v = this_param.SerializeImportsBlob(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 18670, 18697);
                    return return_v;
                }


                System.Reflection.Metadata.ImportScopeHandle
                f_501_18561_18698(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.ImportScopeHandle
                parentScope, System.Reflection.Metadata.BlobHandle
                imports)
                {
                    var return_v = this_param.AddImportScope(parentScope: parentScope, imports: imports);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 18561, 18698);
                    return return_v;
                }


                int
                f_501_18715_18744(System.Collections.Generic.Dictionary<Microsoft.Cci.IImportScope, System.Reflection.Metadata.ImportScopeHandle>
                this_param, Microsoft.Cci.IImportScope
                key, System.Reflection.Metadata.ImportScopeHandle
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 18715, 18744);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 18007, 18784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 18007, 18784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BlobHandle SerializeImportsBlob(IImportScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 18796, 19145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18880, 18911);

                var
                writer = f_501_18893_18910()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 18927, 19072);
                    foreach (UsedNamespaceOrType import in f_501_18966_18991_I(f_501_18966_18991(scope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 18927, 19072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 19025, 19057);

                        f_501_19025_19056(this, writer, import);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 18927, 19072);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 146);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 19088, 19134);

                return f_501_19095_19133(_debugMetadataOpt, writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 18796, 19145);

                System.Reflection.Metadata.BlobBuilder
                f_501_18893_18910()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 18893, 18910);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_501_18966_18991(Microsoft.Cci.IImportScope
                this_param)
                {
                    var return_v = this_param.GetUsedNamespaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 18966, 18991);
                    return return_v;
                }


                int
                f_501_19025_19056(Microsoft.Cci.MetadataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                writer, Microsoft.Cci.UsedNamespaceOrType
                import)
                {
                    this_param.SerializeImport(writer, import);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 19025, 19056);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                f_501_18966_18991_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.UsedNamespaceOrType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 18966, 18991);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_19095_19133(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 19095, 19133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 18796, 19145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 18796, 19145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SerializeModuleDefaultNamespace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 19157, 19730);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 19324, 19415) || true) && (f_501_19328_19351(module) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 19324, 19415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 19393, 19400);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 19324, 19415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 19431, 19719);

                f_501_19431_19718(
                            _debugMetadataOpt, parent: EntityHandle.ModuleDefinition, kind: f_501_19555_19632(_debugMetadataOpt, PortableCustomDebugInfoKinds.DefaultNamespace), value: f_501_19658_19717(_debugMetadataOpt, f_501_19693_19716(module)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 19157, 19730);

                string
                f_501_19328_19351(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DefaultNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 19328, 19351);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_19555_19632(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 19555, 19632);
                    return return_v;
                }


                string
                f_501_19693_19716(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DefaultNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 19693, 19716);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_19658_19717(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddBlobUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 19658, 19717);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_19431_19718(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.ModuleDefinitionHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 19431, 19718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 19157, 19730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 19157, 19730);
            }
        }

        private void SerializeLocalInfo(ILocalDefinition local, EntityHandle parent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 19790, 20902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 19891, 19938);

                var
                dynamicFlags = f_501_19910_19937(local)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 19952, 20351) || true) && (f_501_19956_19977_M(!dynamicFlags.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 19952, 20351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 20011, 20056);

                    var
                    value = f_501_20023_20055(dynamicFlags)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 20076, 20336);

                    f_501_20076_20335(
                                    _debugMetadataOpt, parent: parent, kind: f_501_20185_20267(_debugMetadataOpt, PortableCustomDebugInfoKinds.DynamicLocalVariables), value: f_501_20297_20334(_debugMetadataOpt, value));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 19952, 20351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 20367, 20415);

                var
                tupleElementNames = f_501_20391_20414(local)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 20429, 20891) || true) && (f_501_20433_20459_M(!tupleElementNames.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 20429, 20891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 20493, 20525);

                    var
                    builder = f_501_20507_20524()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 20543, 20598);

                    f_501_20543_20597(builder, tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 20618, 20876);

                    f_501_20618_20875(
                                    _debugMetadataOpt, parent: parent, kind: f_501_20727_20805(_debugMetadataOpt, PortableCustomDebugInfoKinds.TupleElementNames), value: f_501_20835_20874(_debugMetadataOpt, builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 20429, 20891);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 19790, 20902);

                System.Collections.Immutable.ImmutableArray<bool>
                f_501_19910_19937(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.DynamicTransformFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 19910, 19937);
                    return return_v;
                }


                bool
                f_501_19956_19977_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 19956, 19977);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_501_20023_20055(System.Collections.Immutable.ImmutableArray<bool>
                vector)
                {
                    var return_v = SerializeBitVector(vector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20023, 20055);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_20185_20267(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20185, 20267);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_20297_20334(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20297, 20334);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_20076_20335(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.EntityHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20076, 20335);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_501_20391_20414(Microsoft.Cci.ILocalDefinition
                this_param)
                {
                    var return_v = this_param.TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 20391, 20414);
                    return return_v;
                }


                bool
                f_501_20433_20459_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 20433, 20459);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_501_20507_20524()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20507, 20524);
                    return return_v;
                }


                int
                f_501_20543_20597(System.Reflection.Metadata.BlobBuilder
                builder, System.Collections.Immutable.ImmutableArray<string>
                names)
                {
                    SerializeTupleElementNames(builder, names);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20543, 20597);
                    return 0;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_20727_20805(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20727, 20805);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_20835_20874(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20835, 20874);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_20618_20875(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.EntityHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 20618, 20875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 19790, 20902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 19790, 20902);
            }
        }

        private static ImmutableArray<byte> SerializeBitVector(ImmutableArray<bool> vector)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(501, 20914, 22057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21022, 21069);

                var
                builder = f_501_21036_21068()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21085, 21095);

                int
                b = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21109, 21123);

                int
                shift = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21146, 21151);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21137, 21580) || true) && (i < vector.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21172, 21175)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(501, 21137, 21580))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 21137, 21580);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21209, 21299) || true) && (vector[i])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 21209, 21299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21264, 21280);

                            b |= 1 << shift;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 21209, 21299);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21319, 21565) || true) && (shift == 7)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 21319, 21565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21375, 21396);

                            f_501_21375_21395(builder, b);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21418, 21424);

                            b = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21446, 21456);

                            shift = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 21319, 21565);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 21319, 21565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21538, 21546);

                            shift++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 21319, 21565);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 444);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21596, 21994) || true) && (b != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 21596, 21994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21640, 21661);

                    f_501_21640_21660(builder, b);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 21596, 21994);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 21596, 21994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21768, 21804);

                    int
                    lastNonZero = f_501_21786_21799(builder) - 1
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21822, 21929) || true) && (f_501_21829_21849(builder, lastNonZero) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 21822, 21929);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21896, 21910);

                            lastNonZero--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 21822, 21929);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 21822, 21929);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(501, 21822, 21929);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 21949, 21979);

                    f_501_21949_21978(
                                    builder, lastNonZero + 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 21596, 21994);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 22010, 22046);

                return f_501_22017_22045(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(501, 20914, 22057);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                f_501_21036_21068()
                {
                    var return_v = ArrayBuilder<byte>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 21036, 21068);
                    return return_v;
                }


                int
                f_501_21375_21395(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, int
                item)
                {
                    this_param.Add((byte)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 21375, 21395);
                    return 0;
                }


                int
                f_501_21640_21660(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, int
                item)
                {
                    this_param.Add((byte)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 21640, 21660);
                    return 0;
                }


                int
                f_501_21786_21799(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 21786, 21799);
                    return return_v;
                }


                byte
                f_501_21829_21849(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 21829, 21849);
                    return return_v;
                }


                int
                f_501_21949_21978(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param, int
                limit)
                {
                    this_param.Clip(limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 21949, 21978);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_501_22017_22045(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 22017, 22045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 20914, 22057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 20914, 22057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void SerializeTupleElementNames(BlobBuilder builder, ImmutableArray<string> names)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(501, 22069, 22324);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 22191, 22313);
                    foreach (var name in f_501_22212_22217_I(names))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 22191, 22313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 22251, 22298);

                        f_501_22251_22297(builder, name ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(501, 22276, 22296) ?? string.Empty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 22191, 22313);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(501, 22069, 22324);

                int
                f_501_22251_22297(System.Reflection.Metadata.BlobBuilder
                builder, string
                str)
                {
                    WriteUtf8String(builder, str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 22251, 22297);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_501_22212_22217_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 22212, 22217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 22069, 22324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 22069, 22324);
            }
        }

        private static void WriteUtf8String(BlobBuilder builder, string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(501, 22439, 22601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 22532, 22555);

                f_501_22532_22554(builder, str);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 22569, 22590);

                f_501_22569_22589(builder, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(501, 22439, 22601);

                int
                f_501_22532_22554(System.Reflection.Metadata.BlobBuilder
                this_param, string
                value)
                {
                    this_param.WriteUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 22532, 22554);
                    return 0;
                }


                int
                f_501_22569_22589(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 22569, 22589);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 22439, 22601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 22439, 22601);
            }
        }

        private void SerializeAsyncMethodSteppingInfo(AsyncMoveNextBodyDebugInfo asyncInfo, MethodDefinitionHandle moveNextMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 22669, 23720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 22816, 22894);

                f_501_22816_22893(asyncInfo.ResumeOffsets.Length == asyncInfo.YieldOffsets.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 22908, 22957);

                f_501_22908_22956(asyncInfo.CatchHandlerOffset >= -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 22973, 23004);

                var
                writer = f_501_22986_23003()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23020, 23087);

                f_501_23020_23086(
                            writer, ((long)asyncInfo.CatchHandlerOffset + 1));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23112, 23117);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23103, 23423) || true) && (i < asyncInfo.ResumeOffsets.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23155, 23158)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(501, 23103, 23423))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 23103, 23423);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23192, 23244);

                        f_501_23192_23243(writer, asyncInfo.YieldOffsets[i]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23262, 23315);

                        f_501_23262_23314(writer, asyncInfo.ResumeOffsets[i]);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23333, 23408);

                        f_501_23333_23407(writer, f_501_23363_23406(moveNextMethod));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23439, 23709);

                f_501_23439_23708(
                            _debugMetadataOpt, parent: moveNextMethod, kind: f_501_23548_23643(_debugMetadataOpt, PortableCustomDebugInfoKinds.AsyncMethodSteppingInformationBlob), value: f_501_23669_23707(_debugMetadataOpt, writer));
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 22669, 23720);

                int
                f_501_22816_22893(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 22816, 22893);
                    return 0;
                }


                int
                f_501_22908_22956(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 22908, 22956);
                    return 0;
                }


                System.Reflection.Metadata.BlobBuilder
                f_501_22986_23003()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 22986, 23003);
                    return return_v;
                }


                int
                f_501_23020_23086(System.Reflection.Metadata.BlobBuilder
                this_param, long
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 23020, 23086);
                    return 0;
                }


                int
                f_501_23192_23243(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 23192, 23243);
                    return 0;
                }


                int
                f_501_23262_23314(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 23262, 23314);
                    return 0;
                }


                int
                f_501_23363_23406(System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 23363, 23406);
                    return return_v;
                }


                int
                f_501_23333_23407(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 23333, 23407);
                    return 0;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_23548_23643(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 23548, 23643);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_23669_23707(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 23669, 23707);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_23439_23708(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 23439, 23708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 22669, 23720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 22669, 23720);
            }
        }

        private void SerializeStateMachineLocalScopes(IMethodBody methodBody, MethodDefinitionHandle method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 23732, 24535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23857, 23912);

                var
                scopes = f_501_23870_23911(methodBody)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23926, 24009) || true) && (scopes.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 23926, 24009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 23987, 23994);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 23926, 24009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 24025, 24056);

                var
                writer = f_501_24038_24055()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 24072, 24250);
                    foreach (var scope in f_501_24094_24100_I(scopes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 24072, 24250);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 24134, 24178);

                        f_501_24134_24177(writer, scope.StartOffset);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 24196, 24235);

                        f_501_24196_24234(writer, scope.Length);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 24072, 24250);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 24266, 24524);

                f_501_24266_24523(
                            _debugMetadataOpt, parent: method, kind: f_501_24367_24458(_debugMetadataOpt, PortableCustomDebugInfoKinds.StateMachineHoistedLocalScopes), value: f_501_24484_24522(_debugMetadataOpt, writer));
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 23732, 24535);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                f_501_23870_23911(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.StateMachineHoistedLocalScopes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 23870, 23911);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_501_24038_24055()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 24038, 24055);
                    return return_v;
                }


                int
                f_501_24134_24177(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 24134, 24177);
                    return 0;
                }


                int
                f_501_24196_24234(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 24196, 24234);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                f_501_24094_24100_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 24094, 24100);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_24367_24458(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 24367, 24458);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_24484_24522(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 24484, 24522);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_24266_24523(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 24266, 24523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 23732, 24535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 23732, 24535);
            }
        }

        private BlobHandle SerializeSequencePoints(
                    StandaloneSignatureHandle localSignatureHandleOpt,
                    ImmutableArray<SequencePoint> sequencePoints,
                    Dictionary<DebugSourceDocument, DocumentHandle> documentIndex,
                    out DocumentHandle singleDocumentHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 24604, 27858);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 24925, 25096) || true) && (sequencePoints.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 24925, 25096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 24989, 25036);

                    singleDocumentHandle = default(DocumentHandle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25054, 25081);

                    return default(BlobHandle);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 24925, 25096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25112, 25143);

                var
                writer = f_501_25125_25142()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25159, 25195);

                int
                previousNonHiddenStartLine = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25209, 25247);

                int
                previousNonHiddenStartColumn = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25287, 25371);

                f_501_25287_25370(
                            // header:
                            writer, f_501_25317_25369(localSignatureHandleOpt));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25387, 25447);

                var
                previousDocument = f_501_25410_25446(sequencePoints)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25461, 25589);

                singleDocumentHandle = (DynAbs.Tracing.TraceSender.Conditional_F1(501, 25484, 25510) || (((previousDocument != null) && DynAbs.Tracing.TraceSender.Conditional_F2(501, 25513, 25562)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 25565, 25588))) ? f_501_25513_25562(this, previousDocument, documentIndex) : default(DocumentHandle);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25614, 25619);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25605, 27785) || true) && (i < sequencePoints.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25648, 25651)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(501, 25605, 27785))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 25605, 27785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25685, 25734);

                        var
                        currentDocument = sequencePoints[i].Document
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25752, 26308) || true) && (previousDocument != currentDocument)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 25752, 26308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25833, 25903);

                            var
                            documentHandle = f_501_25854_25902(this, currentDocument, documentIndex)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 25999, 26133) || true) && (previousDocument != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 25999, 26133);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26077, 26110);

                                f_501_26077_26109(writer, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 25999, 26133);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26157, 26232);

                            f_501_26157_26231(
                                                writer, f_501_26187_26230(documentHandle));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26254, 26289);

                            previousDocument = currentDocument;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 25752, 26308);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26365, 26660) || true) && (i > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 26365, 26660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26416, 26503);

                            f_501_26416_26502(writer, sequencePoints[i].Offset - sequencePoints[i - 1].Offset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 26365, 26660);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 26365, 26660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26585, 26641);

                            f_501_26585_26640(writer, sequencePoints[i].Offset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 26365, 26660);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26680, 26823) || true) && (sequencePoints[i].IsHidden)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 26680, 26823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26752, 26773);

                            f_501_26752_26772(writer, 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26795, 26804);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 26680, 26823);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 26886, 26943);

                        f_501_26886_26942(this, writer, sequencePoints[i]);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27012, 27614) || true) && (previousNonHiddenStartLine < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 27012, 27614);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27088, 27135);

                            f_501_27088_27134(previousNonHiddenStartColumn < 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27157, 27216);

                            f_501_27157_27215(writer, sequencePoints[i].StartLine);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27238, 27299);

                            f_501_27238_27298(writer, sequencePoints[i].StartColumn);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 27012, 27614);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 27012, 27614);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27381, 27475);

                            f_501_27381_27474(writer, sequencePoints[i].StartLine - previousNonHiddenStartLine);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27497, 27595);

                            f_501_27497_27594(writer, sequencePoints[i].StartColumn - previousNonHiddenStartColumn);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 27012, 27614);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27634, 27691);

                        previousNonHiddenStartLine = sequencePoints[i].StartLine;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27709, 27770);

                        previousNonHiddenStartColumn = sequencePoints[i].StartColumn;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 2181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 2181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27801, 27847);

                return f_501_27808_27846(_debugMetadataOpt, writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 24604, 27858);

                System.Reflection.Metadata.BlobBuilder
                f_501_25125_25142()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 25125, 25142);
                    return return_v;
                }


                int
                f_501_25317_25369(System.Reflection.Metadata.StandaloneSignatureHandle
                handle)
                {
                    var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 25317, 25369);
                    return return_v;
                }


                int
                f_501_25287_25370(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 25287, 25370);
                    return 0;
                }


                Microsoft.Cci.DebugSourceDocument
                f_501_25410_25446(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.SequencePoint>
                sequencePoints)
                {
                    var return_v = TryGetSingleDocument(sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 25410, 25446);
                    return return_v;
                }


                System.Reflection.Metadata.DocumentHandle
                f_501_25513_25562(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, System.Reflection.Metadata.DocumentHandle>
                index)
                {
                    var return_v = this_param.GetOrAddDocument(document, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 25513, 25562);
                    return return_v;
                }


                System.Reflection.Metadata.DocumentHandle
                f_501_25854_25902(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, System.Reflection.Metadata.DocumentHandle>
                index)
                {
                    var return_v = this_param.GetOrAddDocument(document, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 25854, 25902);
                    return return_v;
                }


                int
                f_501_26077_26109(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 26077, 26109);
                    return 0;
                }


                int
                f_501_26187_26230(System.Reflection.Metadata.DocumentHandle
                handle)
                {
                    var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 26187, 26230);
                    return return_v;
                }


                int
                f_501_26157_26231(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 26157, 26231);
                    return 0;
                }


                int
                f_501_26416_26502(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 26416, 26502);
                    return 0;
                }


                int
                f_501_26585_26640(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 26585, 26640);
                    return 0;
                }


                int
                f_501_26752_26772(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt16((short)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 26752, 26772);
                    return 0;
                }


                int
                f_501_26886_26942(Microsoft.Cci.MetadataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                writer, Microsoft.Cci.SequencePoint
                sequencePoint)
                {
                    this_param.SerializeDeltaLinesAndColumns(writer, sequencePoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 26886, 26942);
                    return 0;
                }


                int
                f_501_27088_27134(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 27088, 27134);
                    return 0;
                }


                int
                f_501_27157_27215(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 27157, 27215);
                    return 0;
                }


                int
                f_501_27238_27298(System.Reflection.Metadata.BlobBuilder
                this_param, ushort
                value)
                {
                    this_param.WriteCompressedInteger((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 27238, 27298);
                    return 0;
                }


                int
                f_501_27381_27474(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedSignedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 27381, 27474);
                    return 0;
                }


                int
                f_501_27497_27594(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedSignedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 27497, 27594);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_27808_27846(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 27808, 27846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 24604, 27858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 24604, 27858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static DebugSourceDocument TryGetSingleDocument(ImmutableArray<SequencePoint> sequencePoints)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(501, 27870, 28339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 27996, 28060);

                DebugSourceDocument
                singleDocument = sequencePoints[0].Document
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28083, 28088);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28074, 28290) || true) && (i < sequencePoints.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28117, 28120)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(501, 28074, 28290))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 28074, 28290);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28154, 28275) || true) && (sequencePoints[i].Document != singleDocument)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 28154, 28275);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28244, 28256);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 28154, 28275);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28306, 28328);

                return singleDocument;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(501, 27870, 28339);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 27870, 28339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 27870, 28339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SerializeDeltaLinesAndColumns(BlobBuilder writer, SequencePoint sequencePoint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 28351, 29083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28467, 28532);

                int
                deltaLines = sequencePoint.EndLine - sequencePoint.StartLine
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28546, 28617);

                int
                deltaColumns = sequencePoint.EndColumn - sequencePoint.StartColumn
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28693, 28770);

                f_501_28693_28769(deltaLines != 0 || (DynAbs.Tracing.TraceSender.Expression_False(501, 28706, 28742) || deltaColumns != 0) || (DynAbs.Tracing.TraceSender.Expression_False(501, 28706, 28768) || sequencePoint.IsHidden));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28786, 28828);

                f_501_28786_28827(
                            writer, deltaLines);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28844, 29072) || true) && (deltaLines == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 28844, 29072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 28897, 28941);

                    f_501_28897_28940(writer, deltaColumns);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 28844, 29072);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 28844, 29072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 29007, 29057);

                    f_501_29007_29056(writer, deltaColumns);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 28844, 29072);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 28351, 29083);

                int
                f_501_28693_28769(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 28693, 28769);
                    return 0;
                }


                int
                f_501_28786_28827(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 28786, 28827);
                    return 0;
                }


                int
                f_501_28897_28940(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 28897, 28940);
                    return 0;
                }


                int
                f_501_29007_29056(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedSignedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 29007, 29056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 28351, 29083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 28351, 29083);
            }
        }

        private DocumentHandle GetOrAddDocument(DebugSourceDocument document, Dictionary<DebugSourceDocument, DocumentHandle> index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 29146, 29484);
                System.Reflection.Metadata.DocumentHandle documentHandle = default(System.Reflection.Metadata.DocumentHandle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 29295, 29421) || true) && (f_501_29299_29350(index, document, out documentHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 29295, 29421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 29384, 29406);

                    return documentHandle;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 29295, 29421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 29437, 29473);

                return f_501_29444_29472(this, document, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 29146, 29484);

                bool
                f_501_29299_29350(System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, System.Reflection.Metadata.DocumentHandle>
                this_param, Microsoft.Cci.DebugSourceDocument
                key, out System.Reflection.Metadata.DocumentHandle
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 29299, 29350);
                    return return_v;
                }


                System.Reflection.Metadata.DocumentHandle
                f_501_29444_29472(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, System.Reflection.Metadata.DocumentHandle>
                index)
                {
                    var return_v = this_param.AddDocument(document, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 29444, 29472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 29146, 29484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 29146, 29484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DocumentHandle AddDocument(DebugSourceDocument document, Dictionary<DebugSourceDocument, DocumentHandle> index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 29496, 30688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 29640, 29670);

                DocumentHandle
                documentHandle
                = default(DocumentHandle);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 29684, 29732);

                DebugSourceInfo
                info = f_501_29707_29731(document)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 29748, 30212);

                documentHandle = f_501_29765_30211(_debugMetadataOpt, name: f_501_29819_29876(_debugMetadataOpt, f_501_29858_29875(document)), hashAlgorithm: (DynAbs.Tracing.TraceSender.Conditional_F1(501, 29910, 29933) || ((info.Checksum.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(501, 29936, 29955)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 29958, 30014))) ? default(GuidHandle) : f_501_29958_30014(_debugMetadataOpt, info.ChecksumAlgorithmId), hash: (DynAbs.Tracing.TraceSender.Conditional_F1(501, 30039, 30062) || ((info.Checksum.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(501, 30065, 30084)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 30087, 30132))) ? default(BlobHandle) : f_501_30087_30132(_debugMetadataOpt, info.Checksum), language: f_501_30161_30210(_debugMetadataOpt, f_501_30192_30209(document)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 30228, 30264);

                f_501_30228_30263(
                            index, document, documentHandle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 30280, 30639) || true) && (info.EmbeddedTextBlob != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 30280, 30639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 30347, 30624);

                    f_501_30347_30623(_debugMetadataOpt, parent: documentHandle, kind: f_501_30464_30539(_debugMetadataOpt, PortableCustomDebugInfoKinds.EmbeddedSource), value: f_501_30569_30622(_debugMetadataOpt, info.EmbeddedTextBlob));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 30280, 30639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 30655, 30677);

                return documentHandle;
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 29496, 30688);

                Microsoft.Cci.DebugSourceInfo
                f_501_29707_29731(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.GetSourceInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 29707, 29731);
                    return return_v;
                }


                string
                f_501_29858_29875(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 29858, 29875);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_29819_29876(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.GetOrAddDocumentName(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 29819, 29876);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_29958_30014(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 29958, 30014);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_30087_30132(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 30087, 30132);
                    return return_v;
                }


                System.Guid
                f_501_30192_30209(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 30192, 30209);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_30161_30210(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 30161, 30210);
                    return return_v;
                }


                System.Reflection.Metadata.DocumentHandle
                f_501_29765_30211(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobHandle
                name, System.Reflection.Metadata.GuidHandle
                hashAlgorithm, System.Reflection.Metadata.BlobHandle
                hash, System.Reflection.Metadata.GuidHandle
                language)
                {
                    var return_v = this_param.AddDocument(name: name, hashAlgorithm: hashAlgorithm, hash: hash, language: language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 29765, 30211);
                    return return_v;
                }


                int
                f_501_30228_30263(System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, System.Reflection.Metadata.DocumentHandle>
                this_param, Microsoft.Cci.DebugSourceDocument
                key, System.Reflection.Metadata.DocumentHandle
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 30228, 30263);
                    return 0;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_30464_30539(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 30464, 30539);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_30569_30622(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 30569, 30622);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_30347_30623(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.DocumentHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 30347, 30623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 29496, 30688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 29496, 30688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void AddRemainingDebugDocuments(IReadOnlyDictionary<string, DebugSourceDocument> documents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 31053, 31417);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 31176, 31406);
                    foreach (var kvp in f_501_31196_31318_I(f_501_31196_31318(f_501_31196_31276(documents
                    , kvp => !_documentIndex.ContainsKey(kvp.Value)), kvp => kvp.Key)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 31176, 31406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 31352, 31391);

                        f_501_31352_31390(this, kvp.Value, _documentIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 31176, 31406);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 231);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 31053, 31417);

                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                f_501_31196_31276(System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.DebugSourceDocument>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>, bool>
                predicate)
                {
                    var return_v = source.Where<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 31196, 31276);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                f_501_31196_31318(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>, string>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 31196, 31318);
                    return return_v;
                }


                System.Reflection.Metadata.DocumentHandle
                f_501_31352_31390(Microsoft.Cci.MetadataWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, System.Reflection.Metadata.DocumentHandle>
                index)
                {
                    var return_v = this_param.AddDocument(document, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 31352, 31390);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                f_501_31196_31318_I(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.DebugSourceDocument>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 31196, 31318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 31053, 31417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 31053, 31417);
            }
        }

        private void SerializeEncMethodDebugInformation(IMethodBody methodBody, MethodDefinitionHandle method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 31488, 32611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 31615, 31663);

                var
                encInfo = f_501_31629_31662(methodBody)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 31679, 32130) || true) && (f_501_31683_31719_M(!encInfo.LocalSlots.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 31679, 32130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 31753, 31784);

                    var
                    writer = f_501_31766_31783()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 31804, 31840);

                    encInfo.SerializeLocalSlots(writer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 31860, 32115);

                    f_501_31860_32114(
                                    _debugMetadataOpt, parent: method, kind: f_501_31969_32045(_debugMetadataOpt, PortableCustomDebugInfoKinds.EncLocalSlotMap), value: f_501_32075_32113(_debugMetadataOpt, writer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 31679, 32130);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 32146, 32600) || true) && (f_501_32150_32183_M(!encInfo.Lambdas.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 32146, 32600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 32217, 32248);

                    var
                    writer = f_501_32230_32247()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 32268, 32303);

                    encInfo.SerializeLambdaMap(writer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 32323, 32585);

                    f_501_32323_32584(
                                    _debugMetadataOpt, parent: method, kind: f_501_32432_32515(_debugMetadataOpt, PortableCustomDebugInfoKinds.EncLambdaAndClosureMap), value: f_501_32545_32583(_debugMetadataOpt, writer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 32146, 32600);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 31488, 32611);

                Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
                f_501_31629_31662(Microsoft.Cci.IMethodBody
                methodBody)
                {
                    var return_v = GetEncMethodDebugInfo(methodBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 31629, 31662);
                    return return_v;
                }


                bool
                f_501_31683_31719_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 31683, 31719);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_501_31766_31783()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 31766, 31783);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_31969_32045(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 31969, 32045);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_32075_32113(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 32075, 32113);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_31860_32114(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 31860, 32114);
                    return return_v;
                }


                bool
                f_501_32150_32183_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 32150, 32183);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_501_32230_32247()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 32230, 32247);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_32432_32515(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 32432, 32515);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_32545_32583(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 32545, 32583);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_32323_32584(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 32323, 32584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 31488, 32611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 31488, 32611);
            }
        }

        private void EmbedSourceLink(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 32645, 33285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 32713, 32726);

                byte[]
                bytes
                = default(byte[]);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 32778, 32808);

                    bytes = f_501_32786_32807(stream);
                }
                catch (Exception e) when (!(e is OperationCanceledException))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(501, 32837, 32998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 32931, 32983);

                    throw f_501_32937_32982(f_501_32969_32978(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(501, 32837, 32998);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 33014, 33274);

                f_501_33014_33273(
                            _debugMetadataOpt, parent: EntityHandle.ModuleDefinition, kind: f_501_33138_33209(_debugMetadataOpt, PortableCustomDebugInfoKinds.SourceLink), value: f_501_33235_33272(_debugMetadataOpt, bytes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 32645, 33285);

                byte[]
                f_501_32786_32807(System.IO.Stream
                stream)
                {
                    var return_v = stream.ReadAllBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 32786, 32807);
                    return return_v;
                }


                string
                f_501_32969_32978(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 32969, 32978);
                    return return_v;
                }


                Microsoft.DiaSymReader.SymUnmanagedWriterException
                f_501_32937_32982(string
                message, System.Exception
                innerException)
                {
                    var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 32937, 32982);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_33138_33209(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 33138, 33209);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_33235_33272(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, byte[]
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 33235, 33272);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_33014_33273(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.ModuleDefinitionHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 33014, 33273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 32645, 33285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 32645, 33285);
            }
        }

        public const int
        CompilationOptionsSchemaVersion = 1
        ;

        private void EmbedCompilationOptions(CommonPEModuleBuilder module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 33634, 36688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 33725, 33757);

                var
                builder = f_501_33739_33756()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 33773, 33905);

                var
                compilerVersion = f_501_33795_33904(f_501_33795_33883(f_501_33795_33823(typeof(Compilation))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 33919, 34024);

                f_501_33919_34023(CompilationOptionNames.CompilationOptionsVersion, f_501_33980_34022(CompilationOptionsSchemaVersion));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34038, 34106);

                f_501_34038_34105(CompilationOptionNames.CompilerVersion, compilerVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34122, 34209);

                f_501_34122_34208(CompilationOptionNames.Language, f_501_34166_34207(f_501_34166_34198(f_501_34166_34190(module))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34223, 34331);

                f_501_34223_34330(CompilationOptionNames.SourceFileCount, f_501_34274_34329(f_501_34274_34318(f_501_34274_34310(f_501_34274_34298(module)))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34347, 34560) || true) && (f_501_34351_34396(f_501_34351_34369(module)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 34347, 34560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34438, 34545);

                    f_501_34438_34544(CompilationOptionNames.FallbackEncoding, f_501_34490_34543(f_501_34490_34535(f_501_34490_34508(module))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 34347, 34560);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34576, 34786) || true) && (f_501_34580_34624(f_501_34580_34598(module)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 34576, 34786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34666, 34771);

                    f_501_34666_34770(CompilationOptionNames.DefaultEncoding, f_501_34717_34769(f_501_34717_34761(f_501_34717_34735(module))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 34576, 34786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34802, 34828);

                int
                portabilityPolicy = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34842, 35252) || true) && (f_501_34846_34903(f_501_34846_34878(f_501_34846_34870(module))) is DesktopAssemblyIdentityComparer identityComparer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 34842, 35252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 34989, 35103);

                    portabilityPolicy |= (DynAbs.Tracing.TraceSender.Conditional_F1(501, 35010, 35092) || ((identityComparer.PortabilityPolicy.SuppressSilverlightLibraryAssembliesPortability && DynAbs.Tracing.TraceSender.Conditional_F2(501, 35095, 35098)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 35101, 35102))) ? 0b1 : 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35121, 35237);

                    portabilityPolicy |= (DynAbs.Tracing.TraceSender.Conditional_F1(501, 35142, 35225) || ((identityComparer.PortabilityPolicy.SuppressSilverlightPlatformAssembliesPortability && DynAbs.Tracing.TraceSender.Conditional_F2(501, 35228, 35232)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 35235, 35236))) ? 0b10 : 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 34842, 35252);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35268, 35426) || true) && (portabilityPolicy != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 35268, 35426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35328, 35411);

                    f_501_35328_35410(CompilationOptionNames.PortabilityPolicy, f_501_35381_35409(portabilityPolicy));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 35268, 35426);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35442, 35517);

                var
                optimizationLevel = f_501_35466_35516(f_501_35466_35498(f_501_35466_35490(module)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35531, 35598);

                var
                debugPlusMode = f_501_35551_35597(f_501_35551_35583(f_501_35551_35575(module)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35612, 35830) || true) && (optimizationLevel != OptimizationLevel.Debug || (DynAbs.Tracing.TraceSender.Expression_False(501, 35616, 35677) || debugPlusMode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 35612, 35830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35711, 35815);

                    f_501_35711_35814(CompilationOptionNames.Optimization, f_501_35759_35813(optimizationLevel, debugPlusMode));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(501, 35612, 35830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35846, 35973);

                var
                runtimeVersion = f_501_35867_35972_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_501_35867_35950(f_501_35867_35890(typeof(object))), 501, 35867, 35972)?.InformationalVersion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 35987, 36053);

                f_501_35987_36052(CompilationOptionNames.RuntimeVersion, runtimeVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 36069, 36142);

                f_501_36069_36141(f_501_36069_36093(module), builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 36158, 36428);

                f_501_36158_36427(
                            _debugMetadataOpt, parent: EntityHandle.ModuleDefinition, kind: f_501_36282_36361(_debugMetadataOpt, PortableCustomDebugInfoKinds.CompilationOptions), value: f_501_36387_36426(_debugMetadataOpt, builder));

                void WriteValue(string key, string value)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 36444, 36677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 36518, 36541);

                        f_501_36518_36540(builder, key);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 36559, 36580);

                        f_501_36559_36579(builder, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 36598, 36623);

                        f_501_36598_36622(builder, value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 36641, 36662);

                        f_501_36641_36661(builder, 0);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(501, 36444, 36677);

                        int
                        f_501_36518_36540(System.Reflection.Metadata.BlobBuilder
                        this_param, string
                        value)
                        {
                            this_param.WriteUTF8(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 36518, 36540);
                            return 0;
                        }


                        int
                        f_501_36559_36579(System.Reflection.Metadata.BlobBuilder
                        this_param, int
                        value)
                        {
                            this_param.WriteByte((byte)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 36559, 36579);
                            return 0;
                        }


                        int
                        f_501_36598_36622(System.Reflection.Metadata.BlobBuilder
                        this_param, string
                        value)
                        {
                            this_param.WriteUTF8(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 36598, 36622);
                            return 0;
                        }


                        int
                        f_501_36641_36661(System.Reflection.Metadata.BlobBuilder
                        this_param, int
                        value)
                        {
                            this_param.WriteByte((byte)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 36641, 36661);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 36444, 36677);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 36444, 36677);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 33634, 36688);

                System.Reflection.Metadata.BlobBuilder
                f_501_33739_33756()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 33739, 33756);
                    return return_v;
                }


                System.Reflection.Assembly
                f_501_33795_33823(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 33795, 33823);
                    return return_v;
                }


                System.Reflection.AssemblyInformationalVersionAttribute?
                f_501_33795_33883(System.Reflection.Assembly
                element)
                {
                    var return_v = element.GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 33795, 33883);
                    return return_v;
                }


                string
                f_501_33795_33904(System.Reflection.AssemblyInformationalVersionAttribute?
                this_param)
                {
                    var return_v = this_param.InformationalVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 33795, 33904);
                    return return_v;
                }


                string
                f_501_33980_34022(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 33980, 34022);
                    return return_v;
                }


                int
                f_501_33919_34023(string
                key, string
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 33919, 34023);
                    return 0;
                }


                int
                f_501_34038_34105(string
                key, string
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 34038, 34105);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_34166_34190(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34166, 34190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_501_34166_34198(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34166, 34198);
                    return return_v;
                }


                string
                f_501_34166_34207(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34166, 34207);
                    return return_v;
                }


                int
                f_501_34122_34208(string
                key, string
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 34122, 34208);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_34274_34298(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34274, 34298);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_501_34274_34310(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34274, 34310);
                    return return_v;
                }


                int
                f_501_34274_34318(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 34274, 34318);
                    return return_v;
                }


                string
                f_501_34274_34329(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 34274, 34329);
                    return return_v;
                }


                int
                f_501_34223_34330(string
                key, string
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 34223, 34330);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_501_34351_34369(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.EmitOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34351, 34369);
                    return return_v;
                }


                System.Text.Encoding?
                f_501_34351_34396(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.FallbackSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34351, 34396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_501_34490_34508(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.EmitOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34490, 34508);
                    return return_v;
                }


                System.Text.Encoding
                f_501_34490_34535(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.FallbackSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34490, 34535);
                    return return_v;
                }


                string
                f_501_34490_34543(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.WebName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34490, 34543);
                    return return_v;
                }


                int
                f_501_34438_34544(string
                key, string
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 34438, 34544);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_501_34580_34598(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.EmitOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34580, 34598);
                    return return_v;
                }


                System.Text.Encoding?
                f_501_34580_34624(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.DefaultSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34580, 34624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_501_34717_34735(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.EmitOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34717, 34735);
                    return return_v;
                }


                System.Text.Encoding
                f_501_34717_34761(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.DefaultSourceFileEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34717, 34761);
                    return return_v;
                }


                string
                f_501_34717_34769(System.Text.Encoding
                this_param)
                {
                    var return_v = this_param.WebName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34717, 34769);
                    return return_v;
                }


                int
                f_501_34666_34770(string
                key, string
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 34666, 34770);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_34846_34870(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34846, 34870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_501_34846_34878(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34846, 34878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_501_34846_34903(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.AssemblyIdentityComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 34846, 34903);
                    return return_v;
                }


                string
                f_501_35381_35409(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 35381, 35409);
                    return return_v;
                }


                int
                f_501_35328_35410(string
                key, string
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 35328, 35410);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_35466_35490(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 35466, 35490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_501_35466_35498(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 35466, 35498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OptimizationLevel
                f_501_35466_35516(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OptimizationLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 35466, 35516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_35551_35575(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 35551, 35575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_501_35551_35583(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 35551, 35583);
                    return return_v;
                }


                bool
                f_501_35551_35597(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.DebugPlusMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 35551, 35597);
                    return return_v;
                }


                string
                f_501_35759_35813(Microsoft.CodeAnalysis.OptimizationLevel
                optimization, bool
                debugPlusMode)
                {
                    var return_v = optimization.ToPdbSerializedString(debugPlusMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 35759, 35813);
                    return return_v;
                }


                int
                f_501_35711_35814(string
                key, string
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 35711, 35814);
                    return 0;
                }


                System.Reflection.Assembly
                f_501_35867_35890(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 35867, 35890);
                    return return_v;
                }


                System.Reflection.AssemblyInformationalVersionAttribute?
                f_501_35867_35950(System.Reflection.Assembly
                element)
                {
                    var return_v = element.GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 35867, 35950);
                    return return_v;
                }


                string?
                f_501_35867_35972_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 35867, 35972);
                    return return_v;
                }


                int
                f_501_35987_36052(string
                key, string?
                value)
                {
                    WriteValue(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 35987, 36052);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_36069_36093(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 36069, 36093);
                    return return_v;
                }


                int
                f_501_36069_36141(Microsoft.CodeAnalysis.Compilation
                this_param, System.Reflection.Metadata.BlobBuilder
                builder)
                {
                    this_param.SerializePdbEmbeddedCompilationOptions(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 36069, 36141);
                    return 0;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_36282_36361(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 36282, 36361);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_36387_36426(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 36387, 36426);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_36158_36427(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.ModuleDefinitionHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 36158, 36427);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 33634, 36688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 33634, 36688);
            }
        }

        private void EmbedMetadataReferenceInformation(CommonPEModuleBuilder module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 36910, 40401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 37011, 37043);

                var
                builder = f_501_37025_37042()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 37457, 39708);
                    foreach (var metadataReference in f_501_37491_37534_I(f_501_37491_37534(f_501_37491_37515(module))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 37457, 39708);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 37568, 39693) || true) && (metadataReference is PortableExecutableReference portableReference && (DynAbs.Tracing.TraceSender.Expression_True(501, 37572, 37678) && f_501_37642_37668(portableReference) is object))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 37568, 39693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 37720, 37789);

                            var
                            fileName = f_501_37735_37788(f_501_37761_37787(portableReference))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 37811, 37897);

                            var
                            reference = f_501_37827_37896(f_501_37827_37851(module), portableReference)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 37919, 37955);

                            var
                            peReader = f_501_37934_37954(reference)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38085, 38141) || true) && (peReader is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 38085, 38141);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38132, 38141);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 38085, 38141);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38211, 38239);

                            f_501_38211_38238(
                                                // Write file name first
                                                builder, fileName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38320, 38341);

                            f_501_38320_38340(
                                                // Make sure to add null terminator
                                                builder, 0);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38402, 38549) || true) && (portableReference.Properties.Aliases.Any())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(501, 38402, 38549);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38475, 38549);

                                f_501_38475_38548(builder, f_501_38493_38547(",", portableReference.Properties.Aliases));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(501, 38402, 38549);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38641, 38662);

                            f_501_38641_38661(
                                                // Always null terminate the extern alias list
                                                builder, 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38686, 38836);

                            byte
                            kindAndEmbedInteropTypes = (byte)((DynAbs.Tracing.TraceSender.Conditional_F1(501, 38725, 38771) || ((portableReference.Properties.EmbedInteropTypes
                            && DynAbs.Tracing.TraceSender.Conditional_F2(501, 38799, 38803)) || DynAbs.Tracing.TraceSender.Conditional_F3(501, 38831, 38834))) ? 0b10
                            : 0b0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38860, 39195);

                            kindAndEmbedInteropTypes |= portableReference.Properties.Kind switch
                            {
                                MetadataImageKind.Assembly when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 38977, 39008) && DynAbs.Tracing.TraceSender.Expression_True(501, 38977, 39008))
        => 1,
                                MetadataImageKind.Module when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39035, 39064) && DynAbs.Tracing.TraceSender.Expression_True(501, 39035, 39064))
        => 0,
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39091, 39171) && DynAbs.Tracing.TraceSender.Expression_True(501, 39091, 39171))
        => throw f_501_39102_39171(portableReference.Properties.Kind)
                            };
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39219, 39263);

                            f_501_39219_39262(
                                                builder, kindAndEmbedInteropTypes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39285, 39349);

                            f_501_39285_39348(builder, f_501_39304_39347(f_501_39304_39333(f_501_39304_39322(peReader))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39371, 39431);

                            f_501_39371_39430(builder, f_501_39390_39429(f_501_39390_39417(f_501_39390_39408(peReader))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39455, 39505);

                            var
                            metadataReader = f_501_39476_39504(peReader)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39527, 39587);

                            var
                            moduleDefinition = f_501_39550_39586(metadataReader)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39609, 39674);

                            f_501_39609_39673(builder, f_501_39627_39672(metadataReader, moduleDefinition.Mvid));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(501, 37568, 39693);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(501, 37457, 39708);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(501, 1, 2252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(501, 1, 2252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 39724, 40005);

                f_501_39724_40004(
                            _debugMetadataOpt, parent: EntityHandle.ModuleDefinition, kind: f_501_39848_39938(_debugMetadataOpt, PortableCustomDebugInfoKinds.CompilationMetadataReferences), value: f_501_39964_40003(_debugMetadataOpt, builder));

                static PEReader GetReader(ISymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(501, 40080, 40389);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 40083, 40389);
                        return symbol switch
                        {
                            IAssemblySymbol assemblySymbol when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 40137, 40240) && DynAbs.Tracing.TraceSender.Expression_True(501, 40137, 40240))
        => f_501_40171_40240(f_501_40171_40228(f_501_40171_40213(f_501_40171_40199(assemblySymbol)))),
                            IModuleSymbol moduleSymbol when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 40263, 40338) && DynAbs.Tracing.TraceSender.Expression_True(501, 40263, 40338))
        => f_501_40293_40338(f_501_40293_40326(f_501_40293_40319(moduleSymbol))),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(501, 40361, 40370) && DynAbs.Tracing.TraceSender.Expression_True(501, 40361, 40370))
        => null
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(501, 40080, 40389);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 40080, 40389);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 40080, 40389);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(501, 36910, 40401);

                System.Reflection.Metadata.BlobBuilder
                f_501_37025_37042()
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 37025, 37042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_37491_37515(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 37491, 37515);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_501_37491_37534(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.ExternalReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 37491, 37534);
                    return return_v;
                }


                string?
                f_501_37642_37668(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 37642, 37668);
                    return return_v;
                }


                string
                f_501_37761_37787(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 37761, 37787);
                    return return_v;
                }


                string?
                f_501_37735_37788(string
                path)
                {
                    var return_v = PathUtilities.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 37735, 37788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_501_37827_37851(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 37827, 37851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_501_37827_37896(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                reference)
                {
                    var return_v = this_param.GetAssemblyOrModuleSymbol((Microsoft.CodeAnalysis.MetadataReference)reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 37827, 37896);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_501_37934_37954(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = GetReader(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 37934, 37954);
                    return return_v;
                }


                int
                f_501_38211_38238(System.Reflection.Metadata.BlobBuilder
                this_param, string
                value)
                {
                    this_param.WriteUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 38211, 38238);
                    return 0;
                }


                int
                f_501_38320_38340(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 38320, 38340);
                    return 0;
                }


                string
                f_501_38493_38547(string
                separator, System.Collections.Immutable.ImmutableArray<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 38493, 38547);
                    return return_v;
                }


                int
                f_501_38475_38548(System.Reflection.Metadata.BlobBuilder
                this_param, string
                value)
                {
                    this_param.WriteUTF8(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 38475, 38548);
                    return 0;
                }


                int
                f_501_38641_38661(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 38641, 38661);
                    return 0;
                }


                System.Exception
                f_501_39102_39171(Microsoft.CodeAnalysis.MetadataImageKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39102, 39171);
                    return return_v;
                }


                int
                f_501_39219_39262(System.Reflection.Metadata.BlobBuilder
                this_param, byte
                value)
                {
                    this_param.WriteByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39219, 39262);
                    return 0;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_501_39304_39322(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.PEHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 39304, 39322);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_501_39304_39333(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 39304, 39333);
                    return return_v;
                }


                int
                f_501_39304_39347(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.TimeDateStamp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 39304, 39347);
                    return return_v;
                }


                int
                f_501_39285_39348(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39285, 39348);
                    return 0;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_501_39390_39408(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.PEHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 39390, 39408);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeader?
                f_501_39390_39417(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 39390, 39417);
                    return return_v;
                }


                int
                f_501_39390_39429(System.Reflection.PortableExecutable.PEHeader?
                this_param)
                {
                    var return_v = this_param.SizeOfImage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 39390, 39429);
                    return return_v;
                }


                int
                f_501_39371_39430(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39371, 39430);
                    return 0;
                }


                System.Reflection.Metadata.MetadataReader
                f_501_39476_39504(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39476, 39504);
                    return return_v;
                }


                System.Reflection.Metadata.ModuleDefinition
                f_501_39550_39586(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.GetModuleDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39550, 39586);
                    return return_v;
                }


                System.Guid
                f_501_39627_39672(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GuidHandle
                handle)
                {
                    var return_v = this_param.GetGuid(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39627, 39672);
                    return return_v;
                }


                int
                f_501_39609_39673(System.Reflection.Metadata.BlobBuilder
                this_param, System.Guid
                value)
                {
                    this_param.WriteGuid(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39609, 39673);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_501_37491_37534_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 37491, 37534);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_501_39848_39938(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39848, 39938);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_501_39964_40003(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                value)
                {
                    var return_v = this_param.GetOrAddBlob(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39964, 40003);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandle
                f_501_39724_40004(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.ModuleDefinitionHandle
                parent, System.Reflection.Metadata.GuidHandle
                kind, System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.AddCustomDebugInformation(parent: (System.Reflection.Metadata.EntityHandle)parent, kind: kind, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 39724, 40004);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.AssemblyMetadata?
                f_501_40171_40199(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 40171, 40199);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.PEAssembly?
                f_501_40171_40213(Microsoft.CodeAnalysis.AssemblyMetadata?
                this_param)
                {
                    var return_v = this_param.GetAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 40171, 40213);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.PEModule
                f_501_40171_40228(Microsoft.CodeAnalysis.PEAssembly?
                this_param)
                {
                    var return_v = this_param.ManifestModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 40171, 40228);
                    return return_v;
                }


                static System.Reflection.PortableExecutable.PEReader
                f_501_40171_40240(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.PEReaderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 40171, 40240);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.ModuleMetadata?
                f_501_40293_40319(Microsoft.CodeAnalysis.IModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(501, 40293, 40319);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.PEModule
                f_501_40293_40326(Microsoft.CodeAnalysis.ModuleMetadata?
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 40293, 40326);
                    return return_v;
                }


                static System.Reflection.PortableExecutable.PEReader
                f_501_40293_40338(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.PEReaderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(501, 40293, 40338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(501, 36910, 40401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(501, 36910, 40401);
            }
        }
    }
}
