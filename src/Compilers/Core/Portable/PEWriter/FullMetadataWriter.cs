// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    internal sealed class FullMetadataWriter : MetadataWriter
    {
        private readonly DefinitionIndex<ITypeDefinition> _typeDefs;

        private readonly DefinitionIndex<IEventDefinition> _eventDefs;

        private readonly DefinitionIndex<IFieldDefinition> _fieldDefs;

        private readonly DefinitionIndex<IMethodDefinition> _methodDefs;

        private readonly DefinitionIndex<IPropertyDefinition> _propertyDefs;

        private readonly DefinitionIndex<IParameterDefinition> _parameterDefs;

        private readonly DefinitionIndex<IGenericParameter> _genericParameters;

        private readonly Dictionary<ITypeDefinition, int> _fieldDefIndex;

        private readonly Dictionary<ITypeDefinition, int> _methodDefIndex;

        private readonly Dictionary<IMethodDefinition, int> _parameterListIndex;

        private readonly HeapOrReferenceIndex<AssemblyIdentity> _assemblyRefIndex;

        private readonly HeapOrReferenceIndex<string> _moduleRefIndex;

        private readonly InstanceAndStructuralReferenceIndex<ITypeMemberReference> _memberRefIndex;

        private readonly InstanceAndStructuralReferenceIndex<IGenericMethodInstanceReference> _methodSpecIndex;

        private readonly TypeReferenceIndex _typeRefIndex;

        private readonly InstanceAndStructuralReferenceIndex<ITypeReference> _typeSpecIndex;

        private readonly HeapOrReferenceIndex<BlobHandle> _standAloneSignatureIndex;

        public static MetadataWriter Create(
                    EmitContext context,
                    CommonMessageProvider messageProvider,
                    bool metadataOnly,
                    bool deterministic,
                    bool emitTestCoverageData,
                    bool hasPdbStream,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(487, 2036, 3435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 2370, 2406);

                var
                builder = f_487_2384_2405()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 2420, 2453);

                MetadataBuilder?
                debugBuilderOpt
                = default(MetadataBuilder?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 2467, 2983);

                switch (f_487_2475_2512(context.Module))
                {

                    case DebugInformationFormat.PortablePdb:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 2467, 2983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 2608, 2670);

                        debugBuilderOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(487, 2626, 2638) || ((hasPdbStream && DynAbs.Tracing.TraceSender.Conditional_F2(487, 2641, 2662)) || DynAbs.Tracing.TraceSender.Conditional_F3(487, 2665, 2669))) ? f_487_2641_2662() : null;
                        DynAbs.Tracing.TraceSender.TraceBreak(487, 2692, 2698);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 2467, 2983);

                    case DebugInformationFormat.Embedded:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 2467, 2983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 2777, 2839);

                        debugBuilderOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(487, 2795, 2807) || ((metadataOnly && DynAbs.Tracing.TraceSender.Conditional_F2(487, 2810, 2814)) || DynAbs.Tracing.TraceSender.Conditional_F3(487, 2817, 2838))) ? null : f_487_2817_2838();
                        DynAbs.Tracing.TraceSender.TraceBreak(487, 2861, 2867);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 2467, 2983);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 2467, 2983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 2917, 2940);

                        debugBuilderOpt = null;
                        DynAbs.Tracing.TraceSender.TraceBreak(487, 2962, 2968);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 2467, 2983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 2999, 3209);

                var
                dynamicAnalysisDataWriterOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(487, 3034, 3054) || ((emitTestCoverageData && DynAbs.Tracing.TraceSender.Conditional_F2(487, 3074, 3184)) || DynAbs.Tracing.TraceSender.Conditional_F3(487, 3204, 3208))) ? f_487_3074_3184(f_487_3104_3137(context.Module), f_487_3139_3183(context.Module)) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 3225, 3424);

                return f_487_3232_3423(context, builder, debugBuilderOpt, dynamicAnalysisDataWriterOpt, messageProvider, metadataOnly, deterministic, emitTestCoverageData, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(487, 2036, 3435);

                System.Reflection.Metadata.Ecma335.MetadataBuilder
                f_487_2384_2405()
                {
                    var return_v = new System.Reflection.Metadata.Ecma335.MetadataBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 2384, 2405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_487_2475_2512(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 2475, 2512);
                    return return_v;
                }


                System.Reflection.Metadata.Ecma335.MetadataBuilder
                f_487_2641_2662()
                {
                    var return_v = new System.Reflection.Metadata.Ecma335.MetadataBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 2641, 2662);
                    return return_v;
                }


                System.Reflection.Metadata.Ecma335.MetadataBuilder
                f_487_2817_2838()
                {
                    var return_v = new System.Reflection.Metadata.Ecma335.MetadataBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 2817, 2838);
                    return return_v;
                }


                int
                f_487_3104_3137(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.DebugDocumentCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 3104, 3137);
                    return return_v;
                }


                int
                f_487_3139_3183(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.HintNumberOfMethodDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 3139, 3183);
                    return return_v;
                }


                Microsoft.Cci.DynamicAnalysisDataWriter
                f_487_3074_3184(int
                documentCountEstimate, int
                methodCountEstimate)
                {
                    var return_v = new Microsoft.Cci.DynamicAnalysisDataWriter(documentCountEstimate, methodCountEstimate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 3074, 3184);
                    return return_v;
                }


                Microsoft.Cci.FullMetadataWriter
                f_487_3232_3423(Microsoft.CodeAnalysis.Emit.EmitContext
                context, System.Reflection.Metadata.Ecma335.MetadataBuilder
                builder, System.Reflection.Metadata.Ecma335.MetadataBuilder?
                debugBuilderOpt, Microsoft.Cci.DynamicAnalysisDataWriter?
                dynamicAnalysisDataWriterOpt, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                metadataOnly, bool
                deterministic, bool
                emitTestCoverageData, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.Cci.FullMetadataWriter(context, builder, debugBuilderOpt, dynamicAnalysisDataWriterOpt, messageProvider, metadataOnly, deterministic, emitTestCoverageData, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 3232, 3423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 2036, 3435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 2036, 3435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FullMetadataWriter(
                    EmitContext context,
                    MetadataBuilder builder,
                    MetadataBuilder? debugBuilderOpt,
                    DynamicAnalysisDataWriter? dynamicAnalysisDataWriterOpt,
                    CommonMessageProvider messageProvider,
                    bool metadataOnly,
                    bool deterministic,
                    bool emitTestCoverageData,
                    CancellationToken cancellationToken)
        : base(f_487_3891_3898_C(builder), debugBuilderOpt, dynamicAnalysisDataWriterOpt, context, messageProvider, metadataOnly, deterministic, emitTestCoverageData, cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(487, 3447, 6048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1239, 1253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1314, 1329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1392, 1411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1480, 1497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1554, 1569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1655, 1670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1767, 1783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1830, 1843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1923, 1937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 1998, 2023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4180, 4239);

                int
                numMethods = f_487_4197_4238(this.module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4253, 4291);

                int
                numTypeDefsGuess = numMethods / 6
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4305, 4350);

                int
                numFieldDefsGuess = numTypeDefsGuess * 4
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4364, 4406);

                int
                numPropertyDefsGuess = numMethods / 4
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4422, 4489);

                _typeDefs = f_487_4434_4488(numTypeDefsGuess);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4503, 4557);

                _eventDefs = f_487_4516_4556(0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4571, 4641);

                _fieldDefs = f_487_4584_4640(numFieldDefsGuess);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4655, 4720);

                _methodDefs = f_487_4669_4719(numMethods);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4734, 4813);

                _propertyDefs = f_487_4750_4812(numPropertyDefsGuess);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4827, 4898);

                _parameterDefs = f_487_4844_4897(numMethods);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4912, 4975);

                _genericParameters = f_487_4933_4974(0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 4991, 5099);

                _fieldDefIndex = f_487_5008_5098(numTypeDefsGuess, ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5113, 5222);

                _methodDefIndex = f_487_5131_5221(numTypeDefsGuess, ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5236, 5345);

                _parameterListIndex = f_487_5258_5344(numMethods, ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5361, 5430);

                _assemblyRefIndex = f_487_5381_5429(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5444, 5501);

                _moduleRefIndex = f_487_5462_5500(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5515, 5630);

                _memberRefIndex = f_487_5533_5629(this, f_487_5601_5628(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5644, 5772);

                _methodSpecIndex = f_487_5663_5771(this, f_487_5742_5770(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5786, 5831);

                _typeRefIndex = f_487_5802_5830(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5845, 5952);

                _typeSpecIndex = f_487_5862_5951(this, f_487_5924_5950(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 5966, 6037);

                _standAloneSignatureIndex = f_487_5994_6036(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(487, 3447, 6048);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 3447, 6048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 3447, 6048);
            }
        }

        protected override ushort Generation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 6121, 6138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6127, 6136);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(487, 6121, 6138);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 6060, 6149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 6060, 6149);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Guid EncId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 6215, 6241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6221, 6239);

                    return Guid.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(487, 6215, 6241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 6161, 6252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 6161, 6252);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override Guid EncBaseId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 6322, 6348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6328, 6346);

                    return Guid.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(487, 6322, 6348);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 6264, 6359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 6264, 6359);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool TryGetTypeDefinitionHandle(ITypeDefinition def, out TypeDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 6371, 6681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6500, 6510);

                int
                index
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6524, 6576);

                bool
                result = _typeDefs.TryGetValue(def, out index)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6590, 6642);

                handle = f_487_6599_6641(index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6656, 6670);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 6371, 6681);

                System.Reflection.Metadata.TypeDefinitionHandle
                f_487_6599_6641(int
                rowNumber)
                {
                    var return_v = MetadataTokens.TypeDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 6599, 6641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 6371, 6681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 6371, 6681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeDefinitionHandle GetTypeDefinitionHandle(ITypeDefinition def)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 6693, 6872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6802, 6861);

                return f_487_6809_6860(_typeDefs[def]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 6693, 6872);

                System.Reflection.Metadata.TypeDefinitionHandle
                f_487_6809_6860(int
                rowNumber)
                {
                    var return_v = MetadataTokens.TypeDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 6809, 6860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 6693, 6872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 6693, 6872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ITypeDefinition GetTypeDef(TypeDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 6884, 7048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 6983, 7037);

                return _typeDefs[f_487_7000_7035(handle)];
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 6884, 7048);

                int
                f_487_7000_7035(System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 7000, 7035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 6884, 7048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 6884, 7048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<ITypeDefinition> GetTypeDefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 7060, 7181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 7148, 7170);

                return _typeDefs.Rows;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 7060, 7181);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 7060, 7181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 7060, 7181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override EventDefinitionHandle GetEventDefinitionHandle(IEventDefinition def)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 7193, 7377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 7305, 7366);

                return f_487_7312_7365(_eventDefs[def]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 7193, 7377);

                System.Reflection.Metadata.EventDefinitionHandle
                f_487_7312_7365(int
                rowNumber)
                {
                    var return_v = MetadataTokens.EventDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 7312, 7365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 7193, 7377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 7193, 7377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<IEventDefinition> GetEventDefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 7389, 7513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 7479, 7502);

                return _eventDefs.Rows;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 7389, 7513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 7389, 7513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 7389, 7513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override FieldDefinitionHandle GetFieldDefinitionHandle(IFieldDefinition def)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 7525, 7709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 7637, 7698);

                return f_487_7644_7697(_fieldDefs[def]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 7525, 7709);

                System.Reflection.Metadata.FieldDefinitionHandle
                f_487_7644_7697(int
                rowNumber)
                {
                    var return_v = MetadataTokens.FieldDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 7644, 7697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 7525, 7709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 7525, 7709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<IFieldDefinition> GetFieldDefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 7721, 7845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 7811, 7834);

                return _fieldDefs.Rows;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 7721, 7845);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 7721, 7845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 7721, 7845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool TryGetMethodDefinitionHandle(IMethodDefinition def, out MethodDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 7857, 8177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 7992, 8002);

                int
                index
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 8016, 8070);

                bool
                result = _methodDefs.TryGetValue(def, out index)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 8084, 8138);

                handle = f_487_8093_8137(index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 8152, 8166);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 7857, 8177);

                System.Reflection.Metadata.MethodDefinitionHandle
                f_487_8093_8137(int
                rowNumber)
                {
                    var return_v = MetadataTokens.MethodDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 8093, 8137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 7857, 8177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 7857, 8177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override MethodDefinitionHandle GetMethodDefinitionHandle(IMethodDefinition def)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 8189, 8378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 8304, 8367);

                return f_487_8311_8366(_methodDefs[def]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 8189, 8378);

                System.Reflection.Metadata.MethodDefinitionHandle
                f_487_8311_8366(int
                rowNumber)
                {
                    var return_v = MetadataTokens.MethodDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 8311, 8366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 8189, 8378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 8189, 8378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IMethodDefinition GetMethodDef(MethodDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 8390, 8562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 8495, 8551);

                return _methodDefs[f_487_8514_8549(handle)];
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 8390, 8562);

                int
                f_487_8514_8549(System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = MetadataTokens.GetRowNumber((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 8514, 8549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 8390, 8562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 8390, 8562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<IMethodDefinition> GetMethodDefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 8574, 8701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 8666, 8690);

                return _methodDefs.Rows;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 8574, 8701);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 8574, 8701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 8574, 8701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override PropertyDefinitionHandle GetPropertyDefIndex(IPropertyDefinition def)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 8713, 8904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 8826, 8893);

                return f_487_8833_8892(_propertyDefs[def]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 8713, 8904);

                System.Reflection.Metadata.PropertyDefinitionHandle
                f_487_8833_8892(int
                rowNumber)
                {
                    var return_v = MetadataTokens.PropertyDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 8833, 8892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 8713, 8904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 8713, 8904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<IPropertyDefinition> GetPropertyDefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 8916, 9049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 9012, 9038);

                return _propertyDefs.Rows;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 8916, 9049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 8916, 9049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 8916, 9049);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ParameterHandle GetParameterHandle(IParameterDefinition def)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 9061, 9235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 9165, 9224);

                return f_487_9172_9223(_parameterDefs[def]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 9061, 9235);

                System.Reflection.Metadata.ParameterHandle
                f_487_9172_9223(int
                rowNumber)
                {
                    var return_v = MetadataTokens.ParameterHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 9172, 9223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 9061, 9235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 9061, 9235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<IParameterDefinition> GetParameterDefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 9247, 9383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 9345, 9372);

                return _parameterDefs.Rows;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 9247, 9383);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 9247, 9383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 9247, 9383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<IGenericParameter> GetGenericParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 9395, 9536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 9494, 9525);

                return _genericParameters.Rows;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 9395, 9536);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 9395, 9536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 9395, 9536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override FieldDefinitionHandle GetFirstFieldDefinitionHandle(INamedTypeDefinition typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 9548, 9753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 9673, 9742);

                return f_487_9680_9741(f_487_9717_9740(_fieldDefIndex, typeDef));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 9548, 9753);

                int
                f_487_9717_9740(System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>
                this_param, Microsoft.Cci.ITypeDefinition
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 9717, 9740);
                    return return_v;
                }


                System.Reflection.Metadata.FieldDefinitionHandle
                f_487_9680_9741(int
                rowNumber)
                {
                    var return_v = MetadataTokens.FieldDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 9680, 9741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 9548, 9753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 9548, 9753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override MethodDefinitionHandle GetFirstMethodDefinitionHandle(INamedTypeDefinition typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 9765, 9974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 9892, 9963);

                return f_487_9899_9962(f_487_9937_9961(_methodDefIndex, typeDef));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 9765, 9974);

                int
                f_487_9937_9961(System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>
                this_param, Microsoft.Cci.ITypeDefinition
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 9937, 9961);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_487_9899_9962(int
                rowNumber)
                {
                    var return_v = MetadataTokens.MethodDefinitionHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 9899, 9962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 9765, 9974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 9765, 9974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ParameterHandle GetFirstParameterHandle(IMethodDefinition methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 9986, 10179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 10098, 10168);

                return f_487_10105_10167(f_487_10136_10166(_parameterListIndex, methodDef));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 9986, 10179);

                int
                f_487_10136_10166(System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, int>
                this_param, Microsoft.Cci.IMethodDefinition
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 10136, 10166);
                    return return_v;
                }


                System.Reflection.Metadata.ParameterHandle
                f_487_10105_10167(int
                rowNumber)
                {
                    var return_v = MetadataTokens.ParameterHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 10105, 10167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 9986, 10179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 9986, 10179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override AssemblyReferenceHandle GetOrAddAssemblyReferenceHandle(IAssemblyReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 10191, 10425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 10320, 10414);

                return f_487_10327_10413(f_487_10366_10412(_assemblyRefIndex, f_487_10393_10411(reference)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 10191, 10425);

                Microsoft.CodeAnalysis.AssemblyIdentity
                f_487_10393_10411(Microsoft.Cci.IAssemblyReference
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 10393, 10411);
                    return return_v;
                }


                int
                f_487_10366_10412(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                item)
                {
                    var return_v = this_param.GetOrAdd(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 10366, 10412);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyReferenceHandle
                f_487_10327_10413(int
                rowNumber)
                {
                    var return_v = MetadataTokens.AssemblyReferenceHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 10327, 10413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 10191, 10425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 10191, 10425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<AssemblyIdentity> GetAssemblyRefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 10437, 10571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 10530, 10560);

                return f_487_10537_10559(_assemblyRefIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 10437, 10571);

                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_487_10537_10559(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 10537, 10559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 10437, 10571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 10437, 10571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ModuleReferenceHandle GetOrAddModuleReferenceHandle(string reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 10583, 10788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 10696, 10777);

                return f_487_10703_10776(f_487_10740_10775(_moduleRefIndex, reference));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 10583, 10788);

                int
                f_487_10740_10775(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>
                this_param, string
                item)
                {
                    var return_v = this_param.GetOrAdd(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 10740, 10775);
                    return return_v;
                }


                System.Reflection.Metadata.ModuleReferenceHandle
                f_487_10703_10776(int
                rowNumber)
                {
                    var return_v = MetadataTokens.ModuleReferenceHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 10703, 10776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 10583, 10788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 10583, 10788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<string> GetModuleRefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 10800, 10920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 10881, 10909);

                return f_487_10888_10908(_moduleRefIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 10800, 10920);

                System.Collections.Generic.IReadOnlyList<string>
                f_487_10888_10908(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 10888, 10908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 10800, 10920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 10800, 10920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override MemberReferenceHandle GetOrAddMemberReferenceHandle(ITypeMemberReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 10932, 11151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 11059, 11140);

                return f_487_11066_11139(f_487_11103_11138(_memberRefIndex, reference));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 10932, 11151);

                int
                f_487_11103_11138(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>
                this_param, Microsoft.Cci.ITypeMemberReference
                item)
                {
                    var return_v = this_param.GetOrAdd(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 11103, 11138);
                    return return_v;
                }


                System.Reflection.Metadata.MemberReferenceHandle
                f_487_11066_11139(int
                rowNumber)
                {
                    var return_v = MetadataTokens.MemberReferenceHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 11066, 11139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 10932, 11151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 10932, 11151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<ITypeMemberReference> GetMemberRefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 11163, 11297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 11258, 11286);

                return f_487_11265_11285(_memberRefIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 11163, 11297);

                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeMemberReference>
                f_487_11265_11285(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 11265, 11285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 11163, 11297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 11163, 11297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override MethodSpecificationHandle GetOrAddMethodSpecificationHandle(IGenericMethodInstanceReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 11309, 11552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 11455, 11541);

                return f_487_11462_11540(f_487_11503_11539(_methodSpecIndex, reference));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 11309, 11552);

                int
                f_487_11503_11539(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>
                this_param, Microsoft.Cci.IGenericMethodInstanceReference
                item)
                {
                    var return_v = this_param.GetOrAdd(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 11503, 11539);
                    return return_v;
                }


                System.Reflection.Metadata.MethodSpecificationHandle
                f_487_11462_11540(int
                rowNumber)
                {
                    var return_v = MetadataTokens.MethodSpecificationHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 11462, 11540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 11309, 11552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 11309, 11552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<IGenericMethodInstanceReference> GetMethodSpecs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 11564, 11711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 11671, 11700);

                return f_487_11678_11699(_methodSpecIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 11564, 11711);

                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IGenericMethodInstanceReference>
                f_487_11678_11699(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 11678, 11699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 11564, 11711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 11564, 11711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int GreatestMethodDefIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 11769, 11793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 11772, 11793);
                    return _methodDefs.NextRowId; DynAbs.Tracing.TraceSender.TraceExitMethod(487, 11769, 11793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 11769, 11793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 11769, 11793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override bool TryGetTypeReferenceHandle(ITypeReference reference, out TypeReferenceHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 11806, 12128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 11938, 11948);

                int
                index
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 11962, 12024);

                bool
                result = f_487_11976_12023(_typeRefIndex, reference, out index)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 12038, 12089);

                handle = f_487_12047_12088(index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 12103, 12117);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 11806, 12128);

                bool
                f_487_11976_12023(Microsoft.Cci.MetadataWriter.TypeReferenceIndex
                this_param, Microsoft.Cci.ITypeReference
                item, out int
                index)
                {
                    var return_v = this_param.TryGetValue(item, out index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 11976, 12023);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReferenceHandle
                f_487_12047_12088(int
                rowNumber)
                {
                    var return_v = MetadataTokens.TypeReferenceHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 12047, 12088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 11806, 12128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 11806, 12128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeReferenceHandle GetOrAddTypeReferenceHandle(ITypeReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 12140, 12345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 12257, 12334);

                return f_487_12264_12333(f_487_12299_12332(_typeRefIndex, reference));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 12140, 12345);

                int
                f_487_12299_12332(Microsoft.Cci.MetadataWriter.TypeReferenceIndex
                this_param, Microsoft.Cci.ITypeReference
                item)
                {
                    var return_v = this_param.GetOrAdd(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 12299, 12332);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReferenceHandle
                f_487_12264_12333(int
                rowNumber)
                {
                    var return_v = MetadataTokens.TypeReferenceHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 12264, 12333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 12140, 12345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 12140, 12345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<ITypeReference> GetTypeRefs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 12357, 12481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 12444, 12470);

                return f_487_12451_12469(_typeRefIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 12357, 12481);

                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
                f_487_12451_12469(Microsoft.Cci.MetadataWriter.TypeReferenceIndex
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 12451, 12469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 12357, 12481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 12357, 12481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TypeSpecificationHandle GetOrAddTypeSpecificationHandle(ITypeReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 12493, 12711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 12618, 12700);

                return f_487_12625_12699(f_487_12664_12698(_typeSpecIndex, reference));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 12493, 12711);

                int
                f_487_12664_12698(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>
                this_param, Microsoft.Cci.ITypeReference
                item)
                {
                    var return_v = this_param.GetOrAdd(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 12664, 12698);
                    return return_v;
                }


                System.Reflection.Metadata.TypeSpecificationHandle
                f_487_12625_12699(int
                rowNumber)
                {
                    var return_v = MetadataTokens.TypeSpecificationHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 12625, 12699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 12493, 12711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 12493, 12711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<ITypeReference> GetTypeSpecs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 12723, 12849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 12811, 12838);

                return f_487_12818_12837(_typeSpecIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 12723, 12849);

                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
                f_487_12818_12837(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 12818, 12837);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 12723, 12849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 12723, 12849);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override StandaloneSignatureHandle GetOrAddStandaloneSignatureHandle(BlobHandle blobIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 12861, 13092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 12986, 13081);

                return f_487_12993_13080(f_487_13034_13079(_standAloneSignatureIndex, blobIndex));
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 12861, 13092);

                int
                f_487_13034_13079(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>
                this_param, System.Reflection.Metadata.BlobHandle
                item)
                {
                    var return_v = this_param.GetOrAdd(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 13034, 13079);
                    return return_v;
                }


                System.Reflection.Metadata.StandaloneSignatureHandle
                f_487_12993_13080(int
                rowNumber)
                {
                    var return_v = MetadataTokens.StandaloneSignatureHandle(rowNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 12993, 13080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 12861, 13092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 12861, 13092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IReadOnlyList<BlobHandle> GetStandaloneSignatureBlobHandles()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 13104, 13258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 13209, 13247);

                return f_487_13216_13246(_standAloneSignatureIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 13104, 13258);

                System.Collections.Generic.IReadOnlyList<System.Reflection.Metadata.BlobHandle>
                f_487_13216_13246(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 13216, 13246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 13104, 13258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 13104, 13258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ReferenceIndexer CreateReferenceVisitor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 13270, 13404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 13355, 13393);

                return f_487_13362_13392(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 13270, 13404);

                Microsoft.Cci.FullMetadataWriter.FullReferenceIndexer
                f_487_13362_13392(Microsoft.Cci.FullMetadataWriter
                metadataWriter)
                {
                    var return_v = new Microsoft.Cci.FullMetadataWriter.FullReferenceIndexer((Microsoft.Cci.MetadataWriter)metadataWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 13362, 13392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 13270, 13404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 13270, 13404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ReportReferencesToAddedSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 13416, 13515);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 13416, 13515);
                // noop
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 13416, 13515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 13416, 13515);
            }
        }
        private sealed class FullReferenceIndexer : ReferenceIndexer
        {
            internal FullReferenceIndexer(MetadataWriter metadataWriter)
            : base(f_487_13697_13711_C(metadataWriter))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(487, 13612, 13742);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(487, 13612, 13742);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 13612, 13742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 13612, 13742);
                }
            }

            static FullReferenceIndexer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(487, 13527, 13753);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(487, 13527, 13753);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 13527, 13753);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(487, 13527, 13753);

            static Microsoft.Cci.MetadataWriter
            f_487_13697_13711_C(Microsoft.Cci.MetadataWriter
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(487, 13612, 13742);
                return return_v;
            }

        }

        protected override void PopulateEncLogTableRows(ImmutableArray<int> rowCounts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 13765, 13865);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 13765, 13865);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 13765, 13865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 13765, 13865);
            }
        }

        protected override void PopulateEncMapTableRows(ImmutableArray<int> rowCounts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 13877, 13977);
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 13877, 13977);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 13877, 13977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 13877, 13977);
            }
        }

        protected override void PopulateEventMapTableRows()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 13989, 14602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14065, 14100);

                ITypeDefinition?
                lastParent = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14114, 14591);
                    foreach (IEventDefinition eventDef in f_487_14152_14171_I(f_487_14152_14171(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 14114, 14591);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14205, 14326) || true) && (f_487_14209_14242(eventDef) == lastParent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 14205, 14326);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14298, 14307);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(487, 14205, 14326);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14346, 14393);

                        lastParent = f_487_14359_14392(eventDef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14413, 14576);

                        f_487_14413_14575(
                                        metadata, declaringType: f_487_14471_14506(this, lastParent), eventList: f_487_14540_14574(this, eventDef));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 14114, 14591);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 478);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 478);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 13989, 14602);

                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IEventDefinition>
                f_487_14152_14171(Microsoft.Cci.FullMetadataWriter
                this_param)
                {
                    var return_v = this_param.GetEventDefs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 14152, 14171);
                    return return_v;
                }


                Microsoft.Cci.ITypeDefinition
                f_487_14209_14242(Microsoft.Cci.IEventDefinition
                this_param)
                {
                    var return_v = this_param.ContainingTypeDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 14209, 14242);
                    return return_v;
                }


                Microsoft.Cci.ITypeDefinition
                f_487_14359_14392(Microsoft.Cci.IEventDefinition
                this_param)
                {
                    var return_v = this_param.ContainingTypeDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 14359, 14392);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_487_14471_14506(Microsoft.Cci.FullMetadataWriter
                this_param, Microsoft.Cci.ITypeDefinition
                def)
                {
                    var return_v = this_param.GetTypeDefinitionHandle(def);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 14471, 14506);
                    return return_v;
                }


                System.Reflection.Metadata.EventDefinitionHandle
                f_487_14540_14574(Microsoft.Cci.FullMetadataWriter
                this_param, Microsoft.Cci.IEventDefinition
                def)
                {
                    var return_v = this_param.GetEventDefinitionHandle(def);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 14540, 14574);
                    return return_v;
                }


                int
                f_487_14413_14575(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                declaringType, System.Reflection.Metadata.EventDefinitionHandle
                eventList)
                {
                    this_param.AddEventMap(declaringType: declaringType, eventList: eventList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 14413, 14575);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IEventDefinition>
                f_487_14152_14171_I(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IEventDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 14152, 14171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 13989, 14602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 13989, 14602);
            }
        }

        protected override void PopulatePropertyMapTableRows()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 14614, 15249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14693, 14728);

                ITypeDefinition?
                lastParent = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14742, 15238);
                    foreach (IPropertyDefinition propertyDef in f_487_14786_14808_I(f_487_14786_14808(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 14742, 15238);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14842, 14966) || true) && (f_487_14846_14882(propertyDef) == lastParent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 14842, 14966);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14938, 14947);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(487, 14842, 14966);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 14986, 15036);

                        lastParent = f_487_14999_15035(propertyDef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15056, 15223);

                        f_487_15056_15222(
                                        metadata, declaringType: f_487_15117_15152(this, lastParent), propertyList: f_487_15189_15221(this, propertyDef));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 14742, 15238);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 497);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 14614, 15249);

                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IPropertyDefinition>
                f_487_14786_14808(Microsoft.Cci.FullMetadataWriter
                this_param)
                {
                    var return_v = this_param.GetPropertyDefs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 14786, 14808);
                    return return_v;
                }


                Microsoft.Cci.ITypeDefinition
                f_487_14846_14882(Microsoft.Cci.IPropertyDefinition
                this_param)
                {
                    var return_v = this_param.ContainingTypeDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 14846, 14882);
                    return return_v;
                }


                Microsoft.Cci.ITypeDefinition
                f_487_14999_15035(Microsoft.Cci.IPropertyDefinition
                this_param)
                {
                    var return_v = this_param.ContainingTypeDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 14999, 15035);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandle
                f_487_15117_15152(Microsoft.Cci.FullMetadataWriter
                this_param, Microsoft.Cci.ITypeDefinition
                def)
                {
                    var return_v = this_param.GetTypeDefinitionHandle(def);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 15117, 15152);
                    return return_v;
                }


                System.Reflection.Metadata.PropertyDefinitionHandle
                f_487_15189_15221(Microsoft.Cci.FullMetadataWriter
                this_param, Microsoft.Cci.IPropertyDefinition
                def)
                {
                    var return_v = this_param.GetPropertyDefIndex(def);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 15189, 15221);
                    return return_v;
                }


                int
                f_487_15056_15222(System.Reflection.Metadata.Ecma335.MetadataBuilder
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                declaringType, System.Reflection.Metadata.PropertyDefinitionHandle
                propertyList)
                {
                    this_param.AddPropertyMap(declaringType: declaringType, propertyList: propertyList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 15056, 15222);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IPropertyDefinition>
                f_487_14786_14808_I(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IPropertyDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 14786, 14808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 14614, 15249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 14614, 15249);
            }
        }

        protected override void CreateIndicesForNonTypeMembers(ITypeDefinition typeDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 15261, 16801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15365, 15388);

                _typeDefs.Add(typeDef);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15404, 15500);

                IEnumerable<IGenericTypeParameter>
                typeParameters = f_487_15456_15499(this, typeDef)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15514, 15756) || true) && (typeParameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 15514, 15756);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15574, 15741);
                        foreach (IGenericTypeParameter genericParameter in f_487_15625_15639_I(typeParameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 15574, 15741);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15681, 15722);

                            _genericParameters.Add(genericParameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(487, 15574, 15741);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(487, 15514, 15756);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15772, 15972);
                    foreach (MethodImplementation methodImplementation in f_487_15826_15877_I(f_487_15826_15877(typeDef, Context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 15772, 15972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15911, 15957);

                        f_487_15911_15956(this.methodImplList, methodImplementation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 15772, 15972);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 201);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 15988, 16126);
                    foreach (IEventDefinition eventDef in f_487_16026_16052_I(f_487_16026_16052(typeDef, Context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 15988, 16126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16086, 16111);

                        _eventDefs.Add(eventDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 15988, 16126);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16142, 16192);

                f_487_16142_16191(
                            _fieldDefIndex, typeDef, _fieldDefs.NextRowId);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16206, 16344);
                    foreach (IFieldDefinition fieldDef in f_487_16244_16270_I(f_487_16244_16270(typeDef, Context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 16206, 16344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16304, 16329);

                        _fieldDefs.Add(fieldDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 16206, 16344);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16360, 16412);

                f_487_16360_16411(
                            _methodDefIndex, typeDef, _methodDefs.NextRowId);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16426, 16620);
                    foreach (IMethodDefinition methodDef in f_487_16466_16493_I(f_487_16466_16493(typeDef, Context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 16426, 16620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16527, 16560);

                        f_487_16527_16559(this, methodDef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16578, 16605);

                        _methodDefs.Add(methodDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 16426, 16620);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 195);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16636, 16790);
                    foreach (IPropertyDefinition propertyDef in f_487_16680_16710_I(f_487_16680_16710(typeDef, Context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 16636, 16790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16744, 16775);

                        _propertyDefs.Add(propertyDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 16636, 16790);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 15261, 16801);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
                f_487_15456_15499(Microsoft.Cci.FullMetadataWriter
                this_param, Microsoft.Cci.ITypeDefinition
                typeDef)
                {
                    var return_v = this_param.GetConsolidatedTypeParameters(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 15456, 15499);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
                f_487_15625_15639_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 15625, 15639);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                f_487_15826_15877(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetExplicitImplementationOverrides(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 15826, 15877);
                    return return_v;
                }


                int
                f_487_15911_15956(System.Collections.Generic.List<Microsoft.Cci.MethodImplementation>
                this_param, Microsoft.Cci.MethodImplementation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 15911, 15956);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                f_487_15826_15877_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 15826, 15877);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
                f_487_16026_16052(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetEvents(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16026, 16052);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
                f_487_16026_16052_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16026, 16052);
                    return return_v;
                }


                int
                f_487_16142_16191(System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>
                this_param, Microsoft.Cci.ITypeDefinition
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16142, 16191);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_487_16244_16270(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetFields(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16244, 16270);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_487_16244_16270_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16244, 16270);
                    return return_v;
                }


                int
                f_487_16360_16411(System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>
                this_param, Microsoft.Cci.ITypeDefinition
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16360, 16411);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_487_16466_16493(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetMethods(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16466, 16493);
                    return return_v;
                }


                int
                f_487_16527_16559(Microsoft.Cci.FullMetadataWriter
                this_param, Microsoft.Cci.IMethodDefinition
                methodDef)
                {
                    this_param.CreateIndicesFor(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16527, 16559);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_487_16466_16493_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16466, 16493);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                f_487_16680_16710(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetProperties(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16680, 16710);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                f_487_16680_16710_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16680, 16710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 15261, 16801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 15261, 16801);
            }
        }

        private void CreateIndicesFor(IMethodDefinition methodDef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 16813, 17408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16896, 16957);

                f_487_16896_16956(_parameterListIndex, methodDef, _parameterDefs.NextRowId);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 16973, 17111);
                    foreach (var paramDef in f_487_16998_17033_I(f_487_16998_17033(this, methodDef)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 16973, 17111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 17067, 17096);

                        _parameterDefs.Add(paramDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(487, 16973, 17111);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 139);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 17127, 17397) || true) && (f_487_17131_17162(methodDef) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 17127, 17397);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 17200, 17382);
                        foreach (IGenericMethodParameter genericParameter in f_487_17253_17280_I(f_487_17253_17280(methodDef)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(487, 17200, 17382);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 17322, 17363);

                            _genericParameters.Add(genericParameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(487, 17200, 17382);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(487, 1, 183);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(487, 1, 183);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(487, 17127, 17397);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(487, 16813, 17408);

                int
                f_487_16896_16956(System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, int>
                this_param, Microsoft.Cci.IMethodDefinition
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16896, 16956);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                f_487_16998_17033(Microsoft.Cci.FullMetadataWriter
                this_param, Microsoft.Cci.IMethodDefinition
                methodDef)
                {
                    var return_v = this_param.GetParametersToEmit(methodDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16998, 17033);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                f_487_16998_17033_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 16998, 17033);
                    return return_v;
                }


                ushort
                f_487_17131_17162(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.GenericParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 17131, 17162);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
                f_487_17253_17280(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.GenericParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 17253, 17280);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
                f_487_17253_17280_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 17253, 17280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 16813, 17408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 16813, 17408);
            }
        }

        private struct DefinitionIndex<T> where T : class, IReference
        {

            private readonly Dictionary<T, int> _index;

            private readonly List<T> _rows;

            public DefinitionIndex(int capacity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(487, 17646, 17856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 17715, 17793);

                    _index = f_487_17724_17792<T>(capacity, ReferenceEqualityComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 17811, 17841);

                    _rows = f_487_17819_17840<T>(capacity);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(487, 17646, 17856);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 17646, 17856);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 17646, 17856);
                }
            }

            public bool TryGetValue(T item, out int rowId)
            {
                return _index.TryGetValue(item, out rowId);
            }

            public int this[T item]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 18081, 18109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 18087, 18107);

                        return f_487_18094_18106(_index, item);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(487, 18081, 18109);

                        int
                        f_487_18094_18106(System.Collections.Generic.Dictionary<T, int>
                        this_param, T
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 18094, 18106);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 18081, 18109);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 18081, 18109);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public T this[int rowId]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 18197, 18229);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 18203, 18227);

                        return f_487_18210_18226(_rows, rowId - 1);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(487, 18197, 18229);

                        T
                        f_487_18210_18226(System.Collections.Generic.List<T>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 18210, 18226);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 18197, 18229);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 18197, 18229);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public IReadOnlyList<T> Rows
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 18321, 18342);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 18327, 18340);

                        return _rows;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(487, 18321, 18342);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 18260, 18357);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 18260, 18357);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int NextRowId
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(487, 18426, 18457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(487, 18432, 18455);

                        return f_487_18439_18450(_rows) + 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(487, 18426, 18457);

                        int
                        f_487_18439_18450(System.Collections.Generic.List<T>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 18439, 18450);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(487, 18373, 18472);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 18373, 18472);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void Add(T item)
            {
                _index.Add(item, NextRowId);
                _rows.Add(item);
            }
            static DefinitionIndex()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(487, 17420, 18632);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(487, 17420, 18632);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 17420, 18632);
            }

            static System.Collections.Generic.Dictionary<T, int>
            f_487_17724_17792<T>(int
            capacity, Roslyn.Utilities.ReferenceEqualityComparer
            comparer) where T : class, IReference

            {
                var return_v = new System.Collections.Generic.Dictionary<T, int>(capacity, (System.Collections.Generic.IEqualityComparer<T>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 17724, 17792);
                return return_v;
            }


            static System.Collections.Generic.List<T>
            f_487_17819_17840<T>(int
            capacity) where T : class, IReference

            {
                var return_v = new System.Collections.Generic.List<T>(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 17819, 17840);
                return return_v;
            }

        }

        static FullMetadataWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(487, 586, 18639);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(487, 586, 18639);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(487, 586, 18639);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(487, 586, 18639);

        static int
        f_487_4197_4238(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
        this_param)
        {
            var return_v = this_param.HintNumberOfMethodDefinitions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(487, 4197, 4238);
            return return_v;
        }


        static Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
        f_487_4434_4488(int
        capacity)
        {
            var return_v = new Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 4434, 4488);
            return return_v;
        }


        static Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
        f_487_4516_4556(int
        capacity)
        {
            var return_v = new Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 4516, 4556);
            return return_v;
        }


        static Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
        f_487_4584_4640(int
        capacity)
        {
            var return_v = new Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 4584, 4640);
            return return_v;
        }


        static Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
        f_487_4669_4719(int
        capacity)
        {
            var return_v = new Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 4669, 4719);
            return return_v;
        }


        static Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
        f_487_4750_4812(int
        capacity)
        {
            var return_v = new Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 4750, 4812);
            return return_v;
        }


        static Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IParameterDefinition>
        f_487_4844_4897(int
        capacity)
        {
            var return_v = new Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IParameterDefinition>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 4844, 4897);
            return return_v;
        }


        static Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IGenericParameter>
        f_487_4933_4974(int
        capacity)
        {
            var return_v = new Microsoft.Cci.FullMetadataWriter.DefinitionIndex<Microsoft.Cci.IGenericParameter>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 4933, 4974);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>
        f_487_5008_5098(int
        capacity, Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>(capacity, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeDefinition>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5008, 5098);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>
        f_487_5131_5221(int
        capacity, Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>(capacity, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeDefinition>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5131, 5221);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, int>
        f_487_5258_5344(int
        capacity, Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, int>(capacity, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IMethodDefinition>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5258, 5344);
            return return_v;
        }


        static Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>
        f_487_5381_5429(Microsoft.Cci.FullMetadataWriter
        writer)
        {
            var return_v = new Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>((Microsoft.Cci.MetadataWriter)writer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5381, 5429);
            return return_v;
        }


        static Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>
        f_487_5462_5500(Microsoft.Cci.FullMetadataWriter
        writer)
        {
            var return_v = new Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>((Microsoft.Cci.MetadataWriter)writer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5462, 5500);
            return return_v;
        }


        static Microsoft.Cci.MemberRefComparer
        f_487_5601_5628(Microsoft.Cci.FullMetadataWriter
        metadataWriter)
        {
            var return_v = new Microsoft.Cci.MemberRefComparer((Microsoft.Cci.MetadataWriter)metadataWriter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5601, 5628);
            return return_v;
        }


        static Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>
        f_487_5533_5629(Microsoft.Cci.FullMetadataWriter
        writer, Microsoft.Cci.MemberRefComparer
        structuralComparer)
        {
            var return_v = new Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>((Microsoft.Cci.MetadataWriter)writer, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeMemberReference>)structuralComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5533, 5629);
            return return_v;
        }


        static Microsoft.Cci.MethodSpecComparer
        f_487_5742_5770(Microsoft.Cci.FullMetadataWriter
        metadataWriter)
        {
            var return_v = new Microsoft.Cci.MethodSpecComparer((Microsoft.Cci.MetadataWriter)metadataWriter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5742, 5770);
            return return_v;
        }


        static Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>
        f_487_5663_5771(Microsoft.Cci.FullMetadataWriter
        writer, Microsoft.Cci.MethodSpecComparer
        structuralComparer)
        {
            var return_v = new Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>((Microsoft.Cci.MetadataWriter)writer, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IGenericMethodInstanceReference>)structuralComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5663, 5771);
            return return_v;
        }


        static Microsoft.Cci.MetadataWriter.TypeReferenceIndex
        f_487_5802_5830(Microsoft.Cci.FullMetadataWriter
        writer)
        {
            var return_v = new Microsoft.Cci.MetadataWriter.TypeReferenceIndex((Microsoft.Cci.MetadataWriter)writer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5802, 5830);
            return return_v;
        }


        static Microsoft.Cci.TypeSpecComparer
        f_487_5924_5950(Microsoft.Cci.FullMetadataWriter
        metadataWriter)
        {
            var return_v = new Microsoft.Cci.TypeSpecComparer((Microsoft.Cci.MetadataWriter)metadataWriter);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5924, 5950);
            return return_v;
        }


        static Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>
        f_487_5862_5951(Microsoft.Cci.FullMetadataWriter
        writer, Microsoft.Cci.TypeSpecComparer
        structuralComparer)
        {
            var return_v = new Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>((Microsoft.Cci.MetadataWriter)writer, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeReference>)structuralComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5862, 5951);
            return return_v;
        }


        static Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>
        f_487_5994_6036(Microsoft.Cci.FullMetadataWriter
        writer)
        {
            var return_v = new Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>((Microsoft.Cci.MetadataWriter)writer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(487, 5994, 6036);
            return return_v;
        }


        static System.Reflection.Metadata.Ecma335.MetadataBuilder
        f_487_3891_3898_C(System.Reflection.Metadata.Ecma335.MetadataBuilder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(487, 3447, 6048);
            return return_v;
        }

    }
}
