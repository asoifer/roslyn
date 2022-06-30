// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.Emit
{
internal sealed class DeltaMetadataWriter : MetadataWriter
{
private readonly EmitBaseline _previousGeneration;

private readonly Guid _encId;

private readonly DefinitionMap _definitionMap;

private readonly SymbolChanges _changes;

private readonly DefinitionIndex<ITypeDefinition> _typeDefs;

private readonly DefinitionIndex<IEventDefinition> _eventDefs;

private readonly DefinitionIndex<IFieldDefinition> _fieldDefs;

private readonly DefinitionIndex<IMethodDefinition> _methodDefs;

private readonly DefinitionIndex<IPropertyDefinition> _propertyDefs;

private readonly ParameterDefinitionIndex _parameterDefs;

private readonly List<KeyValuePair<IMethodDefinition, IParameterDefinition>> _parameterDefList;

private readonly GenericParameterIndex _genericParameters;

private readonly EventOrPropertyMapIndex _eventMap;

private readonly EventOrPropertyMapIndex _propertyMap;

private readonly MethodImplIndex _methodImpls;

private readonly HeapOrReferenceIndex<AssemblyIdentity> _assemblyRefIndex;

private readonly HeapOrReferenceIndex<string> _moduleRefIndex;

private readonly InstanceAndStructuralReferenceIndex<ITypeMemberReference> _memberRefIndex;

private readonly InstanceAndStructuralReferenceIndex<IGenericMethodInstanceReference> _methodSpecIndex;

private readonly TypeReferenceIndex _typeRefIndex;

private readonly InstanceAndStructuralReferenceIndex<ITypeReference> _typeSpecIndex;

private readonly HeapOrReferenceIndex<BlobHandle> _standAloneSignatureIndex;

private readonly Dictionary<IMethodDefinition, AddedOrChangedMethodInfo> _addedOrChangedMethods;

public DeltaMetadataWriter(
            EmitContext context,
            CommonMessageProvider messageProvider,
            EmitBaseline previousGeneration,
            Guid encId,
            DefinitionMap definitionMap,
            SymbolChanges changes,
            CancellationToken cancellationToken)
:base(metadata: f_758_2798_2845_C(f_758_2808_2845(previousGeneration)) ,                   debugMetadataOpt: (DynAbs.Tracing.TraceSender.Conditional_F1(758, 2885, 2962)||(((f_758_2886_2923(context.Module)== DebugInformationFormat.PortablePdb) &&DynAbs.Tracing.TraceSender.Conditional_F2(758, 2965, 2986))||DynAbs.Tracing.TraceSender.Conditional_F3(758, 2989, 2993)))?f_758_2965_2986():null,                   dynamicAnalysisDataWriterOpt: null,                   context: context,                   messageProvider: messageProvider,                   metadataOnly: false,                   deterministic: false,                   emitTestCoverageData: false,                   cancellationToken: cancellationToken)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(758,2465,6298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,781,800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,881,895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,937,945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1008,1017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1079,1089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1151,1161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1224,1235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1300,1313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1366,1380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1468,1485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1535,1553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1605,1614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1666,1678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1722,1734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1803,1820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1877,1892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,1978,1993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,2090,2106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,2153,2166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,2246,2260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,2321,2346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,2430,2452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3357,3398);

f_758_3357_3397(previousGeneration != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3412,3449);

f_758_3412_3448(encId != default(Guid));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3463,3511);

f_758_3463_3510(encId != previousGeneration.EncId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3525,3612);

f_758_3525_3611(f_758_3538_3575(context.Module)!= DebugInformationFormat.Embedded);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3628,3669);

_previousGeneration = previousGeneration;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3683,3698);

_encId = encId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3712,3743);

_definitionMap = definitionMap;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3757,3776);

_changes = changes;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3792,3834);

var 
sizes = previousGeneration.TableSizes
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3850,3964);

_typeDefs = f_758_3862_3963(this.TryGetExistingTypeDefIndex, sizes[(int)TableIndex.TypeDef]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,3978,4093);

_eventDefs = f_758_3991_4092(this.TryGetExistingEventDefIndex, sizes[(int)TableIndex.Event]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,4107,4222);

_fieldDefs = f_758_4120_4221(this.TryGetExistingFieldDefIndex, sizes[(int)TableIndex.Field]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,4236,4358);

_methodDefs = f_758_4250_4357(this.TryGetExistingMethodDefIndex, sizes[(int)TableIndex.MethodDef]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,4372,4499);

_propertyDefs = f_758_4388_4498(this.TryGetExistingPropertyDefIndex, sizes[(int)TableIndex.Property]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,4513,4589);

_parameterDefs = f_758_4530_4588(sizes[(int)TableIndex.Param]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,4603,4689);

_parameterDefList = f_758_4623_4688();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,4703,4787);

_genericParameters = f_758_4724_4786(sizes[(int)TableIndex.GenericParam]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,4801,4908);

_eventMap = f_758_4813_4907(this.TryGetExistingEventMapIndex, sizes[(int)TableIndex.EventMap]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,4922,5038);

_propertyMap = f_758_4937_5037(this.TryGetExistingPropertyMapIndex, sizes[(int)TableIndex.PropertyMap]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,5052,5128);

_methodImpls = f_758_5067_5127(this, sizes[(int)TableIndex.MethodImpl]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,5144,5260);

_assemblyRefIndex = f_758_5164_5259(this, lastRowId: sizes[(int)TableIndex.AssemblyRef]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,5274,5376);

_moduleRefIndex = f_758_5292_5375(this, lastRowId: sizes[(int)TableIndex.ModuleRef]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,5390,5550);

_memberRefIndex = f_758_5408_5549(this, f_758_5476_5503(this), lastRowId: sizes[(int)TableIndex.MemberRef]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,5564,5738);

_methodSpecIndex = f_758_5583_5737(this, f_758_5662_5690(this), lastRowId: sizes[(int)TableIndex.MethodSpec]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,5752,5840);

_typeRefIndex = f_758_5768_5839(this, lastRowId: sizes[(int)TableIndex.TypeRef]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,5854,6005);

_typeSpecIndex = f_758_5871_6004(this, f_758_5933_5959(this), lastRowId: sizes[(int)TableIndex.TypeSpec]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,6019,6139);

_standAloneSignatureIndex = f_758_6047_6138(this, lastRowId: sizes[(int)TableIndex.StandAloneSig]);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,6155,6287);

_addedOrChangedMethods = f_758_6180_6286(Cci.SymbolEquivalentEqualityComparer.Instance);
DynAbs.Tracing.TraceSender.TraceExitConstructor(758,2465,6298);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,2465,6298);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,2465,6298);
}
		}

private static MetadataBuilder MakeTablesBuilder(EmitBaseline previousGeneration)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(758,6310,6679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,6416,6668);

return f_758_6423_6667(f_758_6461_6502(previousGeneration), f_758_6521_6558(previousGeneration), f_758_6577_6612(previousGeneration), f_758_6631_6666(previousGeneration));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(758,6310,6679);

int
f_758_6461_6502(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.UserStringStreamLength;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 6461, 6502);
return return_v;
}


int
f_758_6521_6558(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.StringStreamLength;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 6521, 6558);
return return_v;
}


int
f_758_6577_6612(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.BlobStreamLength;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 6577, 6612);
return return_v;
}


int
f_758_6631_6666(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.GuidStreamLength;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 6631, 6666);
return return_v;
}


System.Reflection.Metadata.Ecma335.MetadataBuilder
f_758_6423_6667(int
userStringHeapStartOffset,int
stringHeapStartOffset,int
blobHeapStartOffset,int
guidHeapStartOffset)
{
var return_v = new System.Reflection.Metadata.Ecma335.MetadataBuilder( userStringHeapStartOffset, stringHeapStartOffset, blobHeapStartOffset, guidHeapStartOffset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 6423, 6667);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,6310,6679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,6310,6679);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ImmutableArray<int> GetDeltaTableSizes(ImmutableArray<int> rowCounts)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,6691,8269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,6793,6840);

var 
sizes = new int[MetadataTokens.TableCount]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,6856,6880);

rowCounts.CopyTo(sizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,6896,6954);

sizes[(int)TableIndex.TypeRef] = f_758_6929_6953(f_758_6929_6947(_typeRefIndex));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,6968,7028);

sizes[(int)TableIndex.TypeDef] = f_758_7001_7027(f_758_7001_7021(_typeDefs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7042,7101);

sizes[(int)TableIndex.Field] = f_758_7073_7100(f_758_7073_7094(_fieldDefs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7115,7179);

sizes[(int)TableIndex.MethodDef] = f_758_7150_7178(f_758_7150_7172(_methodDefs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7193,7256);

sizes[(int)TableIndex.Param] = f_758_7224_7255(f_758_7224_7249(_parameterDefs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7270,7332);

sizes[(int)TableIndex.MemberRef] = f_758_7305_7331(f_758_7305_7325(_memberRefIndex));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7346,7422);

sizes[(int)TableIndex.StandAloneSig] = f_758_7385_7421(f_758_7385_7415(_standAloneSignatureIndex));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7436,7497);

sizes[(int)TableIndex.EventMap] = f_758_7470_7496(f_758_7470_7490(_eventMap));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7511,7570);

sizes[(int)TableIndex.Event] = f_758_7542_7569(f_758_7542_7563(_eventDefs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7584,7651);

sizes[(int)TableIndex.PropertyMap] = f_758_7621_7650(f_758_7621_7644(_propertyMap));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7665,7730);

sizes[(int)TableIndex.Property] = f_758_7699_7729(f_758_7699_7723(_propertyDefs));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7744,7810);

sizes[(int)TableIndex.MethodImpl] = f_758_7780_7809(f_758_7780_7803(_methodImpls));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7824,7886);

sizes[(int)TableIndex.ModuleRef] = f_758_7859_7885(f_758_7859_7879(_moduleRefIndex));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7900,7960);

sizes[(int)TableIndex.TypeSpec] = f_758_7934_7959(f_758_7934_7953(_typeSpecIndex));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,7974,8040);

sizes[(int)TableIndex.AssemblyRef] = f_758_8011_8039(f_758_8011_8033(_assemblyRefIndex));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8054,8128);

sizes[(int)TableIndex.GenericParam] = f_758_8092_8127(f_758_8092_8121(_genericParameters));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8142,8206);

sizes[(int)TableIndex.MethodSpec] = f_758_8178_8205(f_758_8178_8199(_methodSpecIndex));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8222,8258);

return f_758_8229_8257(sizes);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,6691,8269);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
f_758_6929_6947(Microsoft.Cci.MetadataWriter.TypeReferenceIndex
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 6929, 6947);
return return_v;
}


int
f_758_6929_6953(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 6929, 6953);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
f_758_7001_7021(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7001, 7021);
return return_v;
}


int
f_758_7001_7027(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7001, 7027);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
f_758_7073_7094(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7073, 7094);
return return_v;
}


int
f_758_7073_7100(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7073, 7100);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
f_758_7150_7172(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7150, 7172);
return return_v;
}


int
f_758_7150_7178(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7150, 7178);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IParameterDefinition, int>
f_758_7224_7249(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.ParameterDefinitionIndex
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7224, 7249);
return return_v;
}


int
f_758_7224_7255(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IParameterDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7224, 7255);
return return_v;
}


System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeMemberReference>
f_758_7305_7325(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7305, 7325);
return return_v;
}


int
f_758_7305_7331(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeMemberReference>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7305, 7331);
return return_v;
}


System.Collections.Generic.IReadOnlyList<System.Reflection.Metadata.BlobHandle>
f_758_7385_7415(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7385, 7415);
return return_v;
}


int
f_758_7385_7421(System.Collections.Generic.IReadOnlyList<System.Reflection.Metadata.BlobHandle>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7385, 7421);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<int, int>
f_758_7470_7490(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7470, 7490);
return return_v;
}


int
f_758_7470_7496(System.Collections.Generic.IReadOnlyDictionary<int, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7470, 7496);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
f_758_7542_7563(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7542, 7563);
return return_v;
}


int
f_758_7542_7569(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7542, 7569);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<int, int>
f_758_7621_7644(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7621, 7644);
return return_v;
}


int
f_758_7621_7650(System.Collections.Generic.IReadOnlyDictionary<int, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7621, 7650);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
f_758_7699_7723(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7699, 7723);
return return_v;
}


int
f_758_7699_7729(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7699, 7729);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
f_758_7780_7803(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.MethodImplIndex
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 7780, 7803);
return return_v;
}


int
f_758_7780_7809(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7780, 7809);
return return_v;
}


System.Collections.Generic.IReadOnlyList<string>
f_758_7859_7879(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7859, 7879);
return return_v;
}


int
f_758_7859_7885(System.Collections.Generic.IReadOnlyList<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7859, 7885);
return return_v;
}


System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
f_758_7934_7953(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7934, 7953);
return return_v;
}


int
f_758_7934_7959(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 7934, 7959);
return return_v;
}


System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.AssemblyIdentity>
f_758_8011_8033(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 8011, 8033);
return return_v;
}


int
f_758_8011_8039(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.AssemblyIdentity>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 8011, 8039);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IGenericParameter, int>
f_758_8092_8121(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.GenericParameterIndex
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 8092, 8121);
return return_v;
}


int
f_758_8092_8127(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IGenericParameter, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 8092, 8127);
return return_v;
}


System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IGenericMethodInstanceReference>
f_758_8178_8199(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 8178, 8199);
return return_v;
}


int
f_758_8178_8205(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IGenericMethodInstanceReference>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 8178, 8205);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_758_8229_8257(params int[]
items)
{
var return_v = ImmutableArray.Create( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 8229, 8257);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,6691,8269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,6691,8269);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal EmitBaseline GetDelta(EmitBaseline baseline, Compilation compilation, Guid encId, MetadataSizes metadataSizes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,8281,12069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8425,8508);

var 
addedOrChangedMethodsByIndex = f_758_8460_8507()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8522,8725);
foreach(var pair in f_758_8543_8565_I(_addedOrChangedMethods) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,8522,8725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8599,8710);

f_758_8599_8709(                addedOrChangedMethodsByIndex, f_758_8632_8696(f_758_8660_8695(this, pair.Key)), pair.Value);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,8522,8725);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,204);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,204);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8741,8804);

var 
previousTableSizes = _previousGeneration.TableEntriesAdded
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8818,8884);

var 
deltaTableSizes = f_758_8840_8883(this, f_758_8859_8882(metadataSizes))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8898,8950);

var 
tableSizes = new int[MetadataTokens.TableCount]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8975,8980);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,8966,9116) || true) && (i < f_758_8986_9003(tableSizes))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,9005,9008)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(758,8966,9116))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,8966,9116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,9042,9101);

tableSizes[i] = previousTableSizes[i] + deltaTableSizes[i];
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,151);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,151);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,9366,9481);

var 
synthesizedMembers = (DynAbs.Tracing.TraceSender.Conditional_F1(758, 9391, 9414)||(((baseline.Ordinal == 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(758, 9417, 9450))||DynAbs.Tracing.TraceSender.Conditional_F3(758, 9453, 9480)))?f_758_9417_9450(module):baseline.SynthesizedMembers
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,9497,12058);

return f_758_9504_12057(baseline, compilation, module, baseline.Ordinal + 1, encId, typesAdded: f_758_9666_9785(_previousGeneration.TypesAdded, f_758_9707_9727(_typeDefs), comparer: Cci.SymbolEquivalentEqualityComparer.Instance), eventsAdded: f_758_9817_9938(_previousGeneration.EventsAdded, f_758_9859_9880(_eventDefs), comparer: Cci.SymbolEquivalentEqualityComparer.Instance), fieldsAdded: f_758_9970_10091(_previousGeneration.FieldsAdded, f_758_10012_10033(_fieldDefs), comparer: Cci.SymbolEquivalentEqualityComparer.Instance), methodsAdded: f_758_10124_10247(_previousGeneration.MethodsAdded, f_758_10167_10189(_methodDefs), comparer: Cci.SymbolEquivalentEqualityComparer.Instance), propertiesAdded: f_758_10283_10411(_previousGeneration.PropertiesAdded, f_758_10329_10353(_propertyDefs), comparer: Cci.SymbolEquivalentEqualityComparer.Instance), eventMapAdded: f_758_10445_10510(_previousGeneration.EventMapAdded, f_758_10489_10509(_eventMap)), propertyMapAdded: f_758_10547_10618(_previousGeneration.PropertyMapAdded, f_758_10594_10617(_propertyMap)), methodImplsAdded: f_758_10655_10726(_previousGeneration.MethodImplsAdded, f_758_10702_10725(_methodImpls)), tableEntriesAdded: f_758_10764_10797(tableSizes), blobStreamLengthAdded: f_758_10896_10944(metadataSizes, HeapIndex.Blob)+ _previousGeneration.BlobStreamLengthAdded, stringStreamLengthAdded: f_758_11093_11116(metadataSizes)[(int)HeapIndex.String] + _previousGeneration.StringStreamLengthAdded, userStringStreamLengthAdded: f_758_11296_11350(metadataSizes, HeapIndex.UserString)+ _previousGeneration.UserStringStreamLengthAdded, guidStreamLengthAdded: f_758_11573_11596(metadataSizes)[(int)HeapIndex.Guid], anonymousTypeMap: f_758_11654_11709(((IPEDeltaAssemblyBuilder)module)), synthesizedMembers: synthesizedMembers, addedOrChangedMethods: f_758_11808_11904(_previousGeneration.AddedOrChangedMethods, addedOrChangedMethodsByIndex, replace: true), debugInformationProvider: baseline.DebugInformationProvider, localSignatureProvider: baseline.LocalSignatureProvider);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,8281,12069);

System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
f_758_8460_8507()
{
var return_v = new System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 8460, 8507);
return return_v;
}


System.Reflection.Metadata.MethodDefinitionHandle
f_758_8660_8695(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.Cci.IMethodDefinition
def)
{
var return_v = this_param.GetMethodDefinitionHandle( def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 8660, 8695);
return return_v;
}


int
f_758_8632_8696(System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 8632, 8696);
return return_v;
}


int
f_758_8599_8709(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
this_param,int
key,Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 8599, 8709);
return 0;
}


System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
f_758_8543_8565_I(System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 8543, 8565);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_758_8859_8882(System.Reflection.Metadata.Ecma335.MetadataSizes
this_param)
{
var return_v = this_param.RowCounts;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 8859, 8882);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_758_8840_8883(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Collections.Immutable.ImmutableArray<int>
rowCounts)
{
var return_v = this_param.GetDeltaTableSizes( rowCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 8840, 8883);
return return_v;
}


int
f_758_8986_9003(int[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 8986, 9003);
return return_v;
}


System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
f_758_9417_9450(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param)
{
var return_v = this_param.GetAllSynthesizedMembers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 9417, 9450);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
f_758_9707_9727(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 9707, 9727);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
f_758_9666_9785(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
previous,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
current,Microsoft.Cci.SymbolEquivalentEqualityComparer
comparer)
{
var return_v = AddRange( previous, current, comparer: (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeDefinition>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 9666, 9785);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
f_758_9859_9880(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 9859, 9880);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
f_758_9817_9938(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
previous,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
current,Microsoft.Cci.SymbolEquivalentEqualityComparer
comparer)
{
var return_v = AddRange( previous, current, comparer: (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IEventDefinition>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 9817, 9938);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
f_758_10012_10033(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10012, 10033);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
f_758_9970_10091(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
previous,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
current,Microsoft.Cci.SymbolEquivalentEqualityComparer
comparer)
{
var return_v = AddRange( previous, current, comparer: (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IFieldDefinition>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 9970, 10091);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
f_758_10167_10189(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10167, 10189);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
f_758_10124_10247(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
previous,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
current,Microsoft.Cci.SymbolEquivalentEqualityComparer
comparer)
{
var return_v = AddRange( previous, current, comparer: (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IMethodDefinition>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10124, 10247);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
f_758_10329_10353(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10329, 10353);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
f_758_10283_10411(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
previous,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
current,Microsoft.Cci.SymbolEquivalentEqualityComparer
comparer)
{
var return_v = AddRange( previous, current, comparer: (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IPropertyDefinition>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10283, 10411);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<int, int>
f_758_10489_10509(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10489, 10509);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<int, int>
f_758_10445_10510(System.Collections.Generic.IReadOnlyDictionary<int, int>
previous,System.Collections.Generic.IReadOnlyDictionary<int, int>
current)
{
var return_v = AddRange( previous, current);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10445, 10510);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<int, int>
f_758_10594_10617(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10594, 10617);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<int, int>
f_758_10547_10618(System.Collections.Generic.IReadOnlyDictionary<int, int>
previous,System.Collections.Generic.IReadOnlyDictionary<int, int>
current)
{
var return_v = AddRange( previous, current);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10547, 10618);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
f_758_10702_10725(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.MethodImplIndex
this_param)
{
var return_v = this_param.GetAdded();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10702, 10725);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
f_758_10655_10726(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
previous,System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
current)
{
var return_v = AddRange( previous, current);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10655, 10726);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_758_10764_10797(params int[]
items)
{
var return_v = ImmutableArray.Create( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10764, 10797);
return return_v;
}


int
f_758_10896_10944(System.Reflection.Metadata.Ecma335.MetadataSizes
this_param,System.Reflection.Metadata.Ecma335.HeapIndex
index)
{
var return_v = this_param.GetAlignedHeapSize( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 10896, 10944);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_758_11093_11116(System.Reflection.Metadata.Ecma335.MetadataSizes
this_param)
{
var return_v = this_param.HeapSizes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 11093, 11116);
return return_v;
}


int
f_758_11296_11350(System.Reflection.Metadata.Ecma335.MetadataSizes
this_param,System.Reflection.Metadata.Ecma335.HeapIndex
index)
{
var return_v = this_param.GetAlignedHeapSize( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 11296, 11350);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_758_11573_11596(System.Reflection.Metadata.Ecma335.MetadataSizes
this_param)
{
var return_v = this_param.HeapSizes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 11573, 11596);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
f_758_11654_11709(Microsoft.CodeAnalysis.Emit.IPEDeltaAssemblyBuilder
this_param)
{
var return_v = this_param.GetAnonymousTypeMap();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 11654, 11709);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
f_758_11808_11904(System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
previous,System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
current,bool
replace)
{
var return_v = AddRange( previous, (System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>)current, replace: replace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 11808, 11904);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_758_9504_12057(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param,Microsoft.CodeAnalysis.Compilation
compilation,Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
moduleBuilder,int
ordinal,System.Guid
encId,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
typesAdded,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
eventsAdded,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
fieldsAdded,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
methodsAdded,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
propertiesAdded,System.Collections.Generic.IReadOnlyDictionary<int, int>
eventMapAdded,System.Collections.Generic.IReadOnlyDictionary<int, int>
propertyMapAdded,System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
methodImplsAdded,System.Collections.Immutable.ImmutableArray<int>
tableEntriesAdded,int
blobStreamLengthAdded,int
stringStreamLengthAdded,int
userStringStreamLengthAdded,int
guidStreamLengthAdded,System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
anonymousTypeMap,System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
synthesizedMembers,System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
addedOrChangedMethods,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, System.Reflection.Metadata.StandaloneSignatureHandle>
localSignatureProvider)
{
var return_v = this_param.With( compilation, moduleBuilder, ordinal, encId, typesAdded: typesAdded, eventsAdded: eventsAdded, fieldsAdded: fieldsAdded, methodsAdded: methodsAdded, propertiesAdded: propertiesAdded, eventMapAdded: eventMapAdded, propertyMapAdded: propertyMapAdded, methodImplsAdded: methodImplsAdded, tableEntriesAdded: tableEntriesAdded, blobStreamLengthAdded: blobStreamLengthAdded, stringStreamLengthAdded: stringStreamLengthAdded, userStringStreamLengthAdded: userStringStreamLengthAdded, guidStreamLengthAdded: guidStreamLengthAdded, anonymousTypeMap: anonymousTypeMap, synthesizedMembers: synthesizedMembers, addedOrChangedMethods: addedOrChangedMethods, debugInformationProvider: debugInformationProvider, localSignatureProvider: localSignatureProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 9504, 12057);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,8281,12069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,8281,12069);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static IReadOnlyDictionary<K, V> AddRange<K, V>(IReadOnlyDictionary<K, V> previous, IReadOnlyDictionary<K, V> current, bool replace = false, IEqualityComparer<K> comparer = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(758,12081,12906);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12292,12379) || true) && (f_758_12296_12310(previous)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,12292,12379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12349,12364);

return current;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,12292,12379);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12395,12482) || true) && (f_758_12399_12412(current)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,12395,12482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12451,12467);

return previous;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,12395,12482);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12498,12542);

var 
result = f_758_12511_12541(comparer)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12556,12667);
foreach(var pair in f_758_12577_12585_I(previous) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,12556,12667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12619,12652);

f_758_12619_12651(                result, pair.Key, pair.Value);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,12556,12667);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,112);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,112);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12683,12865);
foreach(var pair in f_758_12704_12711_I(current) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,12683,12865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12745,12802);

f_758_12745_12801(replace ||(DynAbs.Tracing.TraceSender.Expression_False(758, 12758, 12800)||!f_758_12770_12800(previous, pair.Key)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12820,12850);

result[pair.Key] = pair.Value;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,12683,12865);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,183);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,183);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,12881,12895);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(758,12081,12906);

int
f_758_12296_12310(System.Collections.Generic.IReadOnlyDictionary<K, V>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 12296, 12310);
return return_v;
}


int
f_758_12399_12412(System.Collections.Generic.IReadOnlyDictionary<K, V>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 12399, 12412);
return return_v;
}


System.Collections.Generic.Dictionary<K, V>
f_758_12511_12541(System.Collections.Generic.IEqualityComparer<K>?
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<K, V>( comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 12511, 12541);
return return_v;
}


int
f_758_12619_12651(System.Collections.Generic.Dictionary<K, V>
this_param,K
key,V
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 12619, 12651);
return 0;
}


System.Collections.Generic.IReadOnlyDictionary<K, V>
f_758_12577_12585_I(System.Collections.Generic.IReadOnlyDictionary<K, V>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 12577, 12585);
return return_v;
}


bool
f_758_12770_12800(System.Collections.Generic.IReadOnlyDictionary<K, V>
this_param,K
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 12770, 12800);
return return_v;
}


int
f_758_12745_12801(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 12745, 12801);
return 0;
}


System.Collections.Generic.IReadOnlyDictionary<K, V>
f_758_12704_12711_I(System.Collections.Generic.IReadOnlyDictionary<K, V>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 12704, 12711);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,12081,12906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,12081,12906);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void GetMethodTokens(ICollection<MethodDefinitionHandle> methods)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,13029,13561);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,13126,13550);
foreach(var def in f_758_13146_13167_I(f_758_13146_13167(_methodDefs)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,13126,13550);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,13315,13535) || true) && (!f_758_13320_13354(_methodDefs, def)&&(DynAbs.Tracing.TraceSender.Expression_True(758, 13319, 13405)&&f_758_13358_13401_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_758_13358_13378(def, Context), 758, 13358, 13401)?.SequencePoints.Length)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,13315,13535);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,13447,13516);

f_758_13447_13515(                    methods, f_758_13459_13514(f_758_13497_13513(_methodDefs, def)));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,13315,13535);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(758,13126,13550);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,425);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,425);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,13029,13561);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IMethodDefinition>
f_758_13146_13167(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 13146, 13167);
return return_v;
}


bool
f_758_13320_13354(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param,Microsoft.Cci.IMethodDefinition
item)
{
var return_v = this_param.IsAddedNotChanged( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 13320, 13354);
return return_v;
}


Microsoft.Cci.IMethodBody?
f_758_13358_13378(Microsoft.Cci.IMethodDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param?.GetBody( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 13358, 13378);
return return_v;
}


int?
f_758_13358_13401_M(int?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 13358, 13401);
return return_v;
}


int
f_758_13497_13513(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param,Microsoft.Cci.IMethodDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 13497, 13513);
return return_v;
}


System.Reflection.Metadata.MethodDefinitionHandle
f_758_13459_13514(int
rowNumber)
{
var return_v = MetadataTokens.MethodDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 13459, 13514);
return return_v;
}


int
f_758_13447_13515(System.Collections.Generic.ICollection<System.Reflection.Metadata.MethodDefinitionHandle>
this_param,System.Reflection.Metadata.MethodDefinitionHandle
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 13447, 13515);
return 0;
}


System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IMethodDefinition>
f_758_13146_13167_I(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IMethodDefinition>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 13146, 13167);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,13029,13561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,13029,13561);
}
		}

protected override ushort Generation
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(758,13634,13691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,13640,13689);

return (ushort)(_previousGeneration.Ordinal + 1);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,13634,13691);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,13573,13702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,13573,13702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override Guid EncId
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(758,13768,13790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,13774,13788);

return _encId;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,13768,13790);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,13714,13801);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,13714,13801);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override Guid EncBaseId
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(758,13871,13912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,13877,13910);

return _previousGeneration.EncId;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,13871,13912);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,13813,13923);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,13813,13923);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override EventDefinitionHandle GetEventDefinitionHandle(IEventDefinition def)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,13935,14119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,14047,14108);

return f_758_14054_14107(f_758_14091_14106(_eventDefs, def));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,13935,14119);

int
f_758_14091_14106(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
this_param,Microsoft.Cci.IEventDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 14091, 14106);
return return_v;
}


System.Reflection.Metadata.EventDefinitionHandle
f_758_14054_14107(int
rowNumber)
{
var return_v = MetadataTokens.EventDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 14054, 14107);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,13935,14119);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,13935,14119);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<IEventDefinition> GetEventDefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,14131,14260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,14221,14249);

return f_758_14228_14248(_eventDefs);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,14131,14260);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IEventDefinition>
f_758_14228_14248(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 14228, 14248);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,14131,14260);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,14131,14260);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override FieldDefinitionHandle GetFieldDefinitionHandle(IFieldDefinition def)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,14272,14456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,14384,14445);

return f_758_14391_14444(f_758_14428_14443(_fieldDefs, def));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,14272,14456);

int
f_758_14428_14443(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
this_param,Microsoft.Cci.IFieldDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 14428, 14443);
return return_v;
}


System.Reflection.Metadata.FieldDefinitionHandle
f_758_14391_14444(int
rowNumber)
{
var return_v = MetadataTokens.FieldDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 14391, 14444);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,14272,14456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,14272,14456);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<IFieldDefinition> GetFieldDefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,14468,14597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,14558,14586);

return f_758_14565_14585(_fieldDefs);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,14468,14597);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IFieldDefinition>
f_758_14565_14585(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 14565, 14585);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,14468,14597);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,14468,14597);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool TryGetTypeDefinitionHandle(ITypeDefinition def, out TypeDefinitionHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,14609,14919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,14738,14748);

int 
index
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,14762,14814);

bool 
result = f_758_14776_14813(_typeDefs, def, out index)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,14828,14880);

handle = f_758_14837_14879(index);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,14894,14908);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,14609,14919);

bool
f_758_14776_14813(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param,Microsoft.Cci.ITypeDefinition
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 14776, 14813);
return return_v;
}


System.Reflection.Metadata.TypeDefinitionHandle
f_758_14837_14879(int
rowNumber)
{
var return_v = MetadataTokens.TypeDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 14837, 14879);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,14609,14919);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,14609,14919);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override TypeDefinitionHandle GetTypeDefinitionHandle(ITypeDefinition def)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,14931,15110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,15040,15099);

return f_758_15047_15098(f_758_15083_15097(_typeDefs, def));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,14931,15110);

int
f_758_15083_15097(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param,Microsoft.Cci.ITypeDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 15083, 15097);
return return_v;
}


System.Reflection.Metadata.TypeDefinitionHandle
f_758_15047_15098(int
rowNumber)
{
var return_v = MetadataTokens.TypeDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 15047, 15098);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,14931,15110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,14931,15110);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override ITypeDefinition GetTypeDef(TypeDefinitionHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,15122,15286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,15221,15275);

return f_758_15228_15274(_typeDefs, f_758_15238_15273(handle));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,15122,15286);

int
f_758_15238_15273(System.Reflection.Metadata.TypeDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 15238, 15273);
return return_v;
}


Microsoft.Cci.ITypeDefinition
f_758_15228_15274(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 15228, 15274);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,15122,15286);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,15122,15286);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<ITypeDefinition> GetTypeDefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,15298,15424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,15386,15413);

return f_758_15393_15412(_typeDefs);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,15298,15424);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeDefinition>
f_758_15393_15412(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 15393, 15412);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,15298,15424);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,15298,15424);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool TryGetMethodDefinitionHandle(IMethodDefinition def, out MethodDefinitionHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,15436,15756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,15571,15581);

int 
index
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,15595,15649);

bool 
result = f_758_15609_15648(_methodDefs, def, out index)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,15663,15717);

handle = f_758_15672_15716(index);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,15731,15745);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,15436,15756);

bool
f_758_15609_15648(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param,Microsoft.Cci.IMethodDefinition
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 15609, 15648);
return return_v;
}


System.Reflection.Metadata.MethodDefinitionHandle
f_758_15672_15716(int
rowNumber)
{
var return_v = MetadataTokens.MethodDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 15672, 15716);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,15436,15756);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,15436,15756);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override MethodDefinitionHandle GetMethodDefinitionHandle(IMethodDefinition def)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,15768,15957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,15883,15946);

return f_758_15890_15945(f_758_15928_15944(_methodDefs, def));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,15768,15957);

int
f_758_15928_15944(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param,Microsoft.Cci.IMethodDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 15928, 15944);
return return_v;
}


System.Reflection.Metadata.MethodDefinitionHandle
f_758_15890_15945(int
rowNumber)
{
var return_v = MetadataTokens.MethodDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 15890, 15945);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,15768,15957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,15768,15957);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IMethodDefinition GetMethodDef(MethodDefinitionHandle index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,15969,16139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,16073,16128);

return f_758_16080_16127(_methodDefs, f_758_16092_16126(index));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,15969,16139);

int
f_758_16092_16126(System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 16092, 16126);
return return_v;
}


Microsoft.Cci.IMethodDefinition
f_758_16080_16127(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 16080, 16127);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,15969,16139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,15969,16139);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<IMethodDefinition> GetMethodDefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,16151,16283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,16243,16272);

return f_758_16250_16271(_methodDefs);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,16151,16283);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IMethodDefinition>
f_758_16250_16271(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 16250, 16271);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,16151,16283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,16151,16283);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override PropertyDefinitionHandle GetPropertyDefIndex(IPropertyDefinition def)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,16295,16486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,16408,16475);

return f_758_16415_16474(f_758_16455_16473(_propertyDefs, def));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,16295,16486);

int
f_758_16455_16473(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
this_param,Microsoft.Cci.IPropertyDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 16455, 16473);
return return_v;
}


System.Reflection.Metadata.PropertyDefinitionHandle
f_758_16415_16474(int
rowNumber)
{
var return_v = MetadataTokens.PropertyDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 16415, 16474);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,16295,16486);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,16295,16486);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<IPropertyDefinition> GetPropertyDefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,16498,16636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,16594,16625);

return f_758_16601_16624(_propertyDefs);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,16498,16636);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IPropertyDefinition>
f_758_16601_16624(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 16601, 16624);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,16498,16636);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,16498,16636);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override ParameterHandle GetParameterHandle(IParameterDefinition def)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,16648,16822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,16752,16811);

return f_758_16759_16810(f_758_16790_16809(_parameterDefs, def));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,16648,16822);

int
f_758_16790_16809(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.ParameterDefinitionIndex
this_param,Microsoft.Cci.IParameterDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 16790, 16809);
return return_v;
}


System.Reflection.Metadata.ParameterHandle
f_758_16759_16810(int
rowNumber)
{
var return_v = MetadataTokens.ParameterHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 16759, 16810);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,16648,16822);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,16648,16822);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<IParameterDefinition> GetParameterDefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,16834,16975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,16932,16964);

return f_758_16939_16963(_parameterDefs);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,16834,16975);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IParameterDefinition>
f_758_16939_16963(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.ParameterDefinitionIndex
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 16939, 16963);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,16834,16975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,16834,16975);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<IGenericParameter> GetGenericParameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,16987,17133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,17086,17122);

return f_758_17093_17121(_genericParameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,16987,17133);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IGenericParameter>
f_758_17093_17121(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.GenericParameterIndex
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 17093, 17121);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,16987,17133);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,16987,17133);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override FieldDefinitionHandle GetFirstFieldDefinitionHandle(INamedTypeDefinition typeDef)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,17145,17413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,17364,17402);

return default(FieldDefinitionHandle);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,17145,17413);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,17145,17413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,17145,17413);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override MethodDefinitionHandle GetFirstMethodDefinitionHandle(INamedTypeDefinition typeDef)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,17425,17697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,17647,17686);

return default(MethodDefinitionHandle);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,17425,17697);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,17425,17697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,17425,17697);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override ParameterHandle GetFirstParameterHandle(IMethodDefinition methodDef)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,17709,17964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,17921,17953);

return default(ParameterHandle);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,17709,17964);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,17709,17964);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,17709,17964);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override AssemblyReferenceHandle GetOrAddAssemblyReferenceHandle(IAssemblyReference reference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,17976,18551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,18105,18139);

var 
identity = f_758_18120_18138(reference)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,18153,18207);

var 
versionPattern = f_758_18174_18206(reference)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,18223,18440) || true) && ((object)versionPattern != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,18223,18440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,18291,18425);

identity = f_758_18302_18424(f_758_18302_18337(_previousGeneration).LazyMetadataSymbols.AssemblyReferenceIdentityMap, f_758_18387_18423(identity, versionPattern));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,18223,18440);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,18456,18540);

return f_758_18463_18539(f_758_18502_18538(_assemblyRefIndex, identity));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,17976,18551);

Microsoft.CodeAnalysis.AssemblyIdentity
f_758_18120_18138(Microsoft.Cci.IAssemblyReference
this_param)
{
var return_v = this_param.Identity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 18120, 18138);
return return_v;
}


System.Version?
f_758_18174_18206(Microsoft.Cci.IAssemblyReference
this_param)
{
var return_v = this_param.AssemblyVersionPattern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 18174, 18206);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_758_18302_18337(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.InitialBaseline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 18302, 18337);
return return_v;
}


Microsoft.CodeAnalysis.AssemblyIdentity
f_758_18387_18423(Microsoft.CodeAnalysis.AssemblyIdentity
this_param,System.Version
version)
{
var return_v = this_param.WithVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 18387, 18423);
return return_v;
}


Microsoft.CodeAnalysis.AssemblyIdentity
f_758_18302_18424(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>
this_param,Microsoft.CodeAnalysis.AssemblyIdentity
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 18302, 18424);
return return_v;
}


int
f_758_18502_18538(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>
this_param,Microsoft.CodeAnalysis.AssemblyIdentity
item)
{
var return_v = this_param.GetOrAdd( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 18502, 18538);
return return_v;
}


System.Reflection.Metadata.AssemblyReferenceHandle
f_758_18463_18539(int
rowNumber)
{
var return_v = MetadataTokens.AssemblyReferenceHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 18463, 18539);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,17976,18551);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,17976,18551);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<AssemblyIdentity> GetAssemblyRefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,18563,18697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,18656,18686);

return f_758_18663_18685(_assemblyRefIndex);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,18563,18697);

System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.AssemblyIdentity>
f_758_18663_18685(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 18663, 18685);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,18563,18697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,18563,18697);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override ModuleReferenceHandle GetOrAddModuleReferenceHandle(string reference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,18709,18914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,18822,18903);

return f_758_18829_18902(f_758_18866_18901(_moduleRefIndex, reference));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,18709,18914);

int
f_758_18866_18901(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>
this_param,string
item)
{
var return_v = this_param.GetOrAdd( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 18866, 18901);
return return_v;
}


System.Reflection.Metadata.ModuleReferenceHandle
f_758_18829_18902(int
rowNumber)
{
var return_v = MetadataTokens.ModuleReferenceHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 18829, 18902);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,18709,18914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,18709,18914);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<string> GetModuleRefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,18926,19046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,19007,19035);

return f_758_19014_19034(_moduleRefIndex);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,18926,19046);

System.Collections.Generic.IReadOnlyList<string>
f_758_19014_19034(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 19014, 19034);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,18926,19046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,18926,19046);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override MemberReferenceHandle GetOrAddMemberReferenceHandle(ITypeMemberReference reference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,19058,19277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,19185,19266);

return f_758_19192_19265(f_758_19229_19264(_memberRefIndex, reference));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,19058,19277);

int
f_758_19229_19264(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>
this_param,Microsoft.Cci.ITypeMemberReference
item)
{
var return_v = this_param.GetOrAdd( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 19229, 19264);
return return_v;
}


System.Reflection.Metadata.MemberReferenceHandle
f_758_19192_19265(int
rowNumber)
{
var return_v = MetadataTokens.MemberReferenceHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 19192, 19265);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,19058,19277);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,19058,19277);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<ITypeMemberReference> GetMemberRefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,19289,19423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,19384,19412);

return f_758_19391_19411(_memberRefIndex);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,19289,19423);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeMemberReference>
f_758_19391_19411(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 19391, 19411);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,19289,19423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,19289,19423);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override MethodSpecificationHandle GetOrAddMethodSpecificationHandle(IGenericMethodInstanceReference reference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,19435,19678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,19581,19667);

return f_758_19588_19666(f_758_19629_19665(_methodSpecIndex, reference));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,19435,19678);

int
f_758_19629_19665(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>
this_param,Microsoft.Cci.IGenericMethodInstanceReference
item)
{
var return_v = this_param.GetOrAdd( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 19629, 19665);
return return_v;
}


System.Reflection.Metadata.MethodSpecificationHandle
f_758_19588_19666(int
rowNumber)
{
var return_v = MetadataTokens.MethodSpecificationHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 19588, 19666);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,19435,19678);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,19435,19678);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<IGenericMethodInstanceReference> GetMethodSpecs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,19690,19837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,19797,19826);

return f_758_19804_19825(_methodSpecIndex);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,19690,19837);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.IGenericMethodInstanceReference>
f_758_19804_19825(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 19804, 19825);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,19690,19837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,19690,19837);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override int GreatestMethodDefIndex {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(758,19895,19919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,19898,19919);
return f_758_19898_19919(_methodDefs);DynAbs.Tracing.TraceSender.TraceExitMethod(758,19895,19919);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,19895,19919);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,19895,19919);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override bool TryGetTypeReferenceHandle(ITypeReference reference, out TypeReferenceHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,19932,20254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,20064,20074);

int 
index
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,20088,20150);

bool 
result = f_758_20102_20149(_typeRefIndex, reference, out index)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,20164,20215);

handle = f_758_20173_20214(index);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,20229,20243);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,19932,20254);

bool
f_758_20102_20149(Microsoft.Cci.MetadataWriter.TypeReferenceIndex
this_param,Microsoft.Cci.ITypeReference
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 20102, 20149);
return return_v;
}


System.Reflection.Metadata.TypeReferenceHandle
f_758_20173_20214(int
rowNumber)
{
var return_v = MetadataTokens.TypeReferenceHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 20173, 20214);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,19932,20254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,19932,20254);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override TypeReferenceHandle GetOrAddTypeReferenceHandle(ITypeReference reference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,20266,20471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,20383,20460);

return f_758_20390_20459(f_758_20425_20458(_typeRefIndex, reference));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,20266,20471);

int
f_758_20425_20458(Microsoft.Cci.MetadataWriter.TypeReferenceIndex
this_param,Microsoft.Cci.ITypeReference
item)
{
var return_v = this_param.GetOrAdd( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 20425, 20458);
return return_v;
}


System.Reflection.Metadata.TypeReferenceHandle
f_758_20390_20459(int
rowNumber)
{
var return_v = MetadataTokens.TypeReferenceHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 20390, 20459);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,20266,20471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,20266,20471);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<ITypeReference> GetTypeRefs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,20483,20607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,20570,20596);

return f_758_20577_20595(_typeRefIndex);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,20483,20607);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
f_758_20577_20595(Microsoft.Cci.MetadataWriter.TypeReferenceIndex
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 20577, 20595);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,20483,20607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,20483,20607);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override TypeSpecificationHandle GetOrAddTypeSpecificationHandle(ITypeReference reference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,20619,20837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,20744,20826);

return f_758_20751_20825(f_758_20790_20824(_typeSpecIndex, reference));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,20619,20837);

int
f_758_20790_20824(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>
this_param,Microsoft.Cci.ITypeReference
item)
{
var return_v = this_param.GetOrAdd( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 20790, 20824);
return return_v;
}


System.Reflection.Metadata.TypeSpecificationHandle
f_758_20751_20825(int
rowNumber)
{
var return_v = MetadataTokens.TypeSpecificationHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 20751, 20825);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,20619,20837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,20619,20837);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<ITypeReference> GetTypeSpecs()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,20849,20975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,20937,20964);

return f_758_20944_20963(_typeSpecIndex);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,20849,20975);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
f_758_20944_20963(Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 20944, 20963);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,20849,20975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,20849,20975);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override StandaloneSignatureHandle GetOrAddStandaloneSignatureHandle(BlobHandle blobIndex)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,20987,21218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21112,21207);

return f_758_21119_21206(f_758_21160_21205(_standAloneSignatureIndex, blobIndex));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,20987,21218);

int
f_758_21160_21205(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>
this_param,System.Reflection.Metadata.BlobHandle
item)
{
var return_v = this_param.GetOrAdd( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 21160, 21205);
return return_v;
}


System.Reflection.Metadata.StandaloneSignatureHandle
f_758_21119_21206(int
rowNumber)
{
var return_v = MetadataTokens.StandaloneSignatureHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 21119, 21206);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,20987,21218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,20987,21218);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override IReadOnlyList<BlobHandle> GetStandaloneSignatureBlobHandles()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,21230,21384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21335,21373);

return f_758_21342_21372(_standAloneSignatureIndex);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,21230,21384);

System.Collections.Generic.IReadOnlyList<System.Reflection.Metadata.BlobHandle>
f_758_21342_21372(Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>
this_param)
{
var return_v = this_param.Rows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 21342, 21372);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,21230,21384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,21230,21384);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void OnIndicesCreated()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,21396,21588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21463,21513);

var 
module = (IPEDeltaAssemblyBuilder)this.module
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21527,21577);

f_758_21527_21576(            module, this.Context.Diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,21396,21588);

int
f_758_21527_21576(Microsoft.CodeAnalysis.Emit.IPEDeltaAssemblyBuilder
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
this_param.OnCreatedIndices( diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 21527, 21576);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,21396,21588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,21396,21588);
}
		}

protected override void CreateIndicesForNonTypeMembers(ITypeDefinition typeDef)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,21600,26368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21704,21745);

var 
change = f_758_21717_21744(_changes, typeDef)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21759,22758);

switch (change)
            {

case SymbolChange.Added:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,21759,22758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21853,21876);

f_758_21853_21875(                    _typeDefs, typeDef);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21898,21963);

var 
typeParameters = f_758_21919_21962(this, typeDef)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,21985,22251) || true) && (typeParameters != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,21985,22251);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22061,22228);
foreach(var typeParameter in f_758_22091_22105_I(typeParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,22061,22228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22163,22201);

f_758_22163_22200(                            _genericParameters, typeParameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,22061,22228);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,168);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,168);
}DynAbs.Tracing.TraceSender.TraceExitCondition(758,21985,22251);
}
DynAbs.Tracing.TraceSender.TraceBreak(758,22273,22279);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,21759,22758);

case SymbolChange.Updated:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,21759,22758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22347,22377);

f_758_22347_22376(                    _typeDefs, typeDef);
DynAbs.Tracing.TraceSender.TraceBreak(758,22399,22405);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,21759,22758);

case SymbolChange.ContainsChanges:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,21759,22758);
DynAbs.Tracing.TraceSender.TraceBreak(758,22522,22528);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,21759,22758);

case SymbolChange.None:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,21759,22758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22637,22644);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,21759,22758);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,21759,22758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22694,22743);

throw f_758_22700_22742(change);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,21759,22758);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22774,22788);

int 
typeIndex
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22802,22857);

var 
ok = f_758_22811_22856(_typeDefs, typeDef, out typeIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22871,22888);

f_758_22871_22887(ok);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22904,23252);
foreach(var eventDef in f_758_22929_22960_I(f_758_22929_22960(typeDef, this.Context)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,22904,23252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,22994,23012);

int 
eventMapIndex
=default(int);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23030,23172) || true) && (!f_758_23035_23086(_eventMap, typeIndex, out eventMapIndex))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,23030,23172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23128,23153);

f_758_23128_23152(                    _eventMap, typeIndex);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,23030,23172);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23192,23237);

f_758_23192_23236(
                this, _eventDefs, eventDef);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,22904,23252);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,349);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,349);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23268,23418);
foreach(var fieldDef in f_758_23293_23324_I(f_758_23293_23324(typeDef, this.Context)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,23268,23418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23358,23403);

f_758_23358_23402(                this, _fieldDefs, fieldDef);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,23268,23418);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,151);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,151);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23434,24224);
foreach(var methodDef in f_758_23460_23492_I(f_758_23460_23492(typeDef, this.Context)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,23434,24224);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23526,24209) || true) && (f_758_23530_23576(this, _methodDefs, methodDef))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,23526,24209);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23618,23874);
foreach(var paramDef in f_758_23643_23678_I(f_758_23643_23678(this, methodDef)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,23618,23874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23728,23757);

f_758_23728_23756(                        _parameterDefs, paramDef);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23783,23851);

f_758_23783_23850(                        _parameterDefList, f_758_23805_23849(methodDef, paramDef));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,23618,23874);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,257);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,257);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23898,24190) || true) && (f_758_23902_23933(methodDef)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,23898,24190);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,23987,24167);
foreach(var typeParameter in f_758_24017_24044_I(f_758_24017_24044(methodDef)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,23987,24167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24102,24140);

f_758_24102_24139(                            _genericParameters, typeParameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,23987,24167);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,181);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,181);
}DynAbs.Tracing.TraceSender.TraceExitCondition(758,23898,24190);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(758,23526,24209);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(758,23434,24224);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,791);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,791);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24240,24613);
foreach(var propertyDef in f_758_24268_24303_I(f_758_24268_24303(typeDef, this.Context)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,24240,24613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24337,24358);

int 
propertyMapIndex
=default(int);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24376,24527) || true) && (!f_758_24381_24438(_propertyMap, typeIndex, out propertyMapIndex))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,24376,24527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24480,24508);

f_758_24480_24507(                    _propertyMap, typeIndex);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,24376,24527);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24547,24598);

f_758_24547_24597(
                this, _propertyDefs, propertyDef);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,24240,24613);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,374);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,374);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24629,24687);

var 
implementingMethods = f_758_24655_24686()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24790,25684);
foreach(var methodImpl in f_758_24817_24868_I(f_758_24817_24868(typeDef, Context)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,24790,25684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,24902,24994);

var 
methodDef = (IMethodDefinition)f_758_24937_24993(methodImpl.ImplementingMethod, this.Context)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25012,25031);

int 
methodDefIndex
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25049,25109);

ok = f_758_25054_25108(_methodDefs, methodDef, out methodDefIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25127,25144);

f_758_25127_25143(ok);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25345,25365);

int 
methodImplIndex
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25383,25437);

var 
key = f_758_25393_25436(methodDefIndex, index: 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25455,25669) || true) && (!f_758_25460_25510(_methodImpls, key, out methodImplIndex))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,25455,25669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25552,25592);

f_758_25552_25591(                    implementingMethods, methodDefIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25614,25650);

f_758_25614_25649(                    this.methodImplList, methodImpl);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,25455,25669);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(758,24790,25684);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,895);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,895);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25782,26314);
foreach(var methodDefIndex in f_758_25813_25832_I(implementingMethods) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,25782,26314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25866,25880);

int 
index = 1
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25898,26299) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,25898,26299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25951,25971);

int 
methodImplIndex
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,25993,26044);

var 
key = f_758_26003_26043(methodDefIndex, index)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26066,26248) || true) && (!f_758_26071_26121(_methodImpls, key, out methodImplIndex))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,26066,26248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26171,26193);

f_758_26171_26192(                        _methodImpls, key);
DynAbs.Tracing.TraceSender.TraceBreak(758,26219,26225);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,26066,26248);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26272,26280);

index++;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,25898,26299);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,25898,26299);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,25898,26299);
}DynAbs.Tracing.TraceSender.TraceExitCondition(758,25782,26314);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,533);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,533);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26330,26357);

f_758_26330_26356(
            implementingMethods);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,21600,26368);

Microsoft.CodeAnalysis.Emit.SymbolChange
f_758_21717_21744(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.Cci.ITypeDefinition
def)
{
var return_v = this_param.GetChange( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 21717, 21744);
return return_v;
}


int
f_758_21853_21875(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param,Microsoft.Cci.ITypeDefinition
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 21853, 21875);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
f_758_21919_21962(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.Cci.ITypeDefinition
typeDef)
{
var return_v = this_param.GetConsolidatedTypeParameters( typeDef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 21919, 21962);
return return_v;
}


int
f_758_22163_22200(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.GenericParameterIndex
this_param,Microsoft.Cci.IGenericTypeParameter
item)
{
this_param.Add( (Microsoft.Cci.IGenericParameter)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 22163, 22200);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
f_758_22091_22105_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 22091, 22105);
return return_v;
}


int
f_758_22347_22376(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param,Microsoft.Cci.ITypeDefinition
item)
{
this_param.AddUpdated( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 22347, 22376);
return 0;
}


System.Exception
f_758_22700_22742(Microsoft.CodeAnalysis.Emit.SymbolChange
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 22700, 22742);
return return_v;
}


bool
f_758_22811_22856(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param,Microsoft.Cci.ITypeDefinition
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 22811, 22856);
return return_v;
}


int
f_758_22871_22887(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 22871, 22887);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
f_758_22929_22960(Microsoft.Cci.ITypeDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetEvents( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 22929, 22960);
return return_v;
}


bool
f_758_23035_23086(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param,int
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23035, 23086);
return return_v;
}


int
f_758_23128_23152(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23128, 23152);
return 0;
}


bool
f_758_23192_23236(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
defIndex,Microsoft.Cci.IEventDefinition
def)
{
var return_v = this_param.AddDefIfNecessary<Microsoft.Cci.IEventDefinition>( defIndex, def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23192, 23236);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
f_758_22929_22960_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 22929, 22960);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
f_758_23293_23324(Microsoft.Cci.ITypeDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetFields( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23293, 23324);
return return_v;
}


bool
f_758_23358_23402(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
defIndex,Microsoft.Cci.IFieldDefinition
def)
{
var return_v = this_param.AddDefIfNecessary<Microsoft.Cci.IFieldDefinition>( defIndex, def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23358, 23402);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
f_758_23293_23324_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23293, 23324);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
f_758_23460_23492(Microsoft.Cci.ITypeDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetMethods( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23460, 23492);
return return_v;
}


bool
f_758_23530_23576(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
defIndex,Microsoft.Cci.IMethodDefinition
def)
{
var return_v = this_param.AddDefIfNecessary<Microsoft.Cci.IMethodDefinition>( defIndex, def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23530, 23576);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
f_758_23643_23678(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.Cci.IMethodDefinition
methodDef)
{
var return_v = this_param.GetParametersToEmit( methodDef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23643, 23678);
return return_v;
}


int
f_758_23728_23756(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.ParameterDefinitionIndex
this_param,Microsoft.Cci.IParameterDefinition
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23728, 23756);
return 0;
}


System.Collections.Generic.KeyValuePair<Microsoft.Cci.IMethodDefinition, Microsoft.Cci.IParameterDefinition>
f_758_23805_23849(Microsoft.Cci.IMethodDefinition
key,Microsoft.Cci.IParameterDefinition
value)
{
var return_v = KeyValuePairUtil.Create( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23805, 23849);
return return_v;
}


int
f_758_23783_23850(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.Cci.IMethodDefinition, Microsoft.Cci.IParameterDefinition>>
this_param,System.Collections.Generic.KeyValuePair<Microsoft.Cci.IMethodDefinition, Microsoft.Cci.IParameterDefinition>
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23783, 23850);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
f_758_23643_23678_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23643, 23678);
return return_v;
}


ushort
f_758_23902_23933(Microsoft.Cci.IMethodDefinition
this_param)
{
var return_v = this_param.GenericParameterCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 23902, 23933);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
f_758_24017_24044(Microsoft.Cci.IMethodDefinition
this_param)
{
var return_v = this_param.GenericParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 24017, 24044);
return return_v;
}


int
f_758_24102_24139(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.GenericParameterIndex
this_param,Microsoft.Cci.IGenericMethodParameter
item)
{
this_param.Add( (Microsoft.Cci.IGenericParameter)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24102, 24139);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
f_758_24017_24044_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24017, 24044);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
f_758_23460_23492_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 23460, 23492);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
f_758_24268_24303(Microsoft.Cci.ITypeDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetProperties( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24268, 24303);
return return_v;
}


bool
f_758_24381_24438(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param,int
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24381, 24438);
return return_v;
}


int
f_758_24480_24507(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24480, 24507);
return 0;
}


bool
f_758_24547_24597(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
defIndex,Microsoft.Cci.IPropertyDefinition
def)
{
var return_v = this_param.AddDefIfNecessary<Microsoft.Cci.IPropertyDefinition>( defIndex, def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24547, 24597);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
f_758_24268_24303_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24268, 24303);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
f_758_24655_24686()
{
var return_v = ArrayBuilder<int>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24655, 24686);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
f_758_24817_24868(Microsoft.Cci.ITypeDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetExplicitImplementationOverrides( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24817, 24868);
return return_v;
}


Microsoft.Cci.IDefinition?
f_758_24937_24993(Microsoft.Cci.IMethodDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.AsDefinition( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24937, 24993);
return return_v;
}


bool
f_758_25054_25108(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param,Microsoft.Cci.IMethodDefinition?
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 25054, 25108);
return return_v;
}


int
f_758_25127_25143(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 25127, 25143);
return 0;
}


Microsoft.CodeAnalysis.Emit.MethodImplKey
f_758_25393_25436(int
implementingMethod,int
index)
{
var return_v = new Microsoft.CodeAnalysis.Emit.MethodImplKey( implementingMethod, index: index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 25393, 25436);
return return_v;
}


bool
f_758_25460_25510(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.MethodImplIndex
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 25460, 25510);
return return_v;
}


int
f_758_25552_25591(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 25552, 25591);
return 0;
}


int
f_758_25614_25649(System.Collections.Generic.List<Microsoft.Cci.MethodImplementation>
this_param,Microsoft.Cci.MethodImplementation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 25614, 25649);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
f_758_24817_24868_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 24817, 24868);
return return_v;
}


Microsoft.CodeAnalysis.Emit.MethodImplKey
f_758_26003_26043(int
implementingMethod,int
index)
{
var return_v = new Microsoft.CodeAnalysis.Emit.MethodImplKey( implementingMethod, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 26003, 26043);
return return_v;
}


bool
f_758_26071_26121(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.MethodImplIndex
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 26071, 26121);
return return_v;
}


int
f_758_26171_26192(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.MethodImplIndex
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 26171, 26192);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
f_758_25813_25832_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 25813, 25832);
return return_v;
}


int
f_758_26330_26356(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 26330, 26356);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,21600,26368);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,21600,26368);
}
		}

private bool AddDefIfNecessary<T>(DefinitionIndex<T> defIndex, T def)
            where T : class, IDefinition
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,26380,27171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26516,27160);

switch (f_758_26524_26547(_changes, def))
            {

case SymbolChange.Added:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,26516,27160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26627,26645);

f_758_26627_26644(                    defIndex, def);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26667,26679);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,26516,27160);

case SymbolChange.Updated:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,26516,27160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26745,26770);

f_758_26745_26769(                    defIndex, def);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26792,26805);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,26516,27160);

case SymbolChange.ContainsChanges:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,26516,27160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,26879,26922);

f_758_26879_26921(def is INestedTypeDefinition);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27012,27025);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,26516,27160);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(758,26516,27160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27132,27145);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,26516,27160);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(758,26380,27171);

Microsoft.CodeAnalysis.Emit.SymbolChange
f_758_26524_26547(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,T
def)
{
var return_v = this_param.GetChange( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 26524, 26547);
return return_v;
}


int
f_758_26627_26644(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param,T
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 26627, 26644);
return 0;
}


int
f_758_26745_26769(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param,T
item)
{
this_param.AddUpdated( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 26745, 26769);
return 0;
}


int
f_758_26879_26921(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 26879, 26921);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,26380,27171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,26380,27171);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override ReferenceIndexer CreateReferenceVisitor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,27183,27318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27268,27307);

return f_758_27275_27306(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,27183,27318);

Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
f_758_27275_27306(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer( writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27275, 27306);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,27183,27318);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,27183,27318);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void ReportReferencesToAddedSymbols()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,27330,27734);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27411,27556);
foreach(var typeRef in f_758_27435_27448_I(f_758_27435_27448(this)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,27411,27556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27482,27541);

f_758_27482_27540(this, f_758_27512_27539(typeRef));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,27411,27556);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,146);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,146);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27572,27723);
foreach(var memberRef in f_758_27598_27613_I(f_758_27598_27613(this)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,27572,27723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27647,27708);

f_758_27647_27707(this, f_758_27677_27706(memberRef));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,27572,27723);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,152);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,152);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,27330,27734);

System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
f_758_27435_27448(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param)
{
var return_v = this_param.GetTypeRefs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27435, 27448);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
f_758_27512_27539(Microsoft.Cci.ITypeReference
this_param)
{
var return_v = this_param.GetInternalSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27512, 27539);
return return_v;
}


int
f_758_27482_27540(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
symbolOpt)
{
this_param.ReportReferencesToAddedSymbol( symbolOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27482, 27540);
return 0;
}


System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
f_758_27435_27448_I(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeReference>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27435, 27448);
return return_v;
}


System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeMemberReference>
f_758_27598_27613(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param)
{
var return_v = this_param.GetMemberRefs();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27598, 27613);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
f_758_27677_27706(Microsoft.Cci.ITypeMemberReference
this_param)
{
var return_v = this_param.GetInternalSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27677, 27706);
return return_v;
}


int
f_758_27647_27707(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
symbolOpt)
{
this_param.ReportReferencesToAddedSymbol( symbolOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27647, 27707);
return 0;
}


System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeMemberReference>
f_758_27598_27613_I(System.Collections.Generic.IReadOnlyList<Microsoft.Cci.ITypeMemberReference>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27598, 27613);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,27330,27734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,27330,27734);
}
		}

private void ReportReferencesToAddedSymbol(ISymbolInternal symbolOpt)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,27746,28251);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27840,28240) || true) && (symbolOpt != null &&(DynAbs.Tracing.TraceSender.Expression_True(758, 27844, 27905)&&f_758_27865_27905(_changes, f_758_27882_27904(symbolOpt))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,27840,28240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,27939,28225);

f_758_27939_28224(                this.Context.Diagnostics, f_758_27968_28223(this.messageProvider, f_758_28028_28078(this.messageProvider), f_758_28101_28129(symbolOpt), f_758_28152_28166(symbolOpt), f_758_28189_28222(f_758_28189_28217(symbolOpt))));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,27840,28240);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(758,27746,28251);

Microsoft.CodeAnalysis.ISymbol
f_758_27882_27904(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.GetISymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27882, 27904);
return return_v;
}


bool
f_758_27865_27905(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = this_param.IsAdded( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27865, 27905);
return return_v;
}


int
f_758_28028_28078(Microsoft.CodeAnalysis.CommonMessageProvider
this_param)
{
var return_v = this_param.ERR_EncReferenceToAddedMember;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 28028, 28078);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_758_28101_28129(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
symbolOpt)
{
var return_v = GetSymbolLocation( symbolOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 28101, 28129);
return return_v;
}


string
f_758_28152_28166(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 28152, 28166);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
f_758_28189_28217(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.ContainingAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 28189, 28217);
return return_v;
}


string
f_758_28189_28222(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 28189, 28222);
return return_v;
}


Microsoft.CodeAnalysis.Diagnostic
f_758_27968_28223(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,int
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = this_param.CreateDiagnostic( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27968, 28223);
return return_v;
}


int
f_758_27939_28224(Microsoft.CodeAnalysis.DiagnosticBag
this_param,Microsoft.CodeAnalysis.Diagnostic
diag)
{
this_param.Add( diag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 27939, 28224);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,27746,28251);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,27746,28251);
}
		}

protected override StandaloneSignatureHandle SerializeLocalVariablesSignature(IMethodBody body)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,28263,30267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28383,28430);

StandaloneSignatureHandle 
localSignatureHandle
=default(StandaloneSignatureHandle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28444,28485);

var 
localVariables = f_758_28465_28484(body)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28499,28555);

var 
encInfos = f_758_28514_28554()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28571,29756) || true) && (localVariables.Length > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,28571,29756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28634,28679);

var 
writer = f_758_28647_28678()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28697,28781);

var 
encoder = f_758_28711_28734(writer).LocalVariableSignature(localVariables.Length)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28801,29451);
foreach(ILocalDefinition local in f_758_28836_28850_I(localVariables) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,28801,29451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28892,28924);

var 
signature = f_758_28908_28923(local)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,28946,29357) || true) && (signature == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,28946,29357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29017,29042);

int 
start = f_758_29029_29041(writer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29068,29125);

f_758_29068_29124(this, encoder.AddVariable(), local);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29151,29207);

signature = f_758_29163_29206(writer, start, f_758_29185_29197(writer)- start);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,28946,29357);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,28946,29357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29305,29334);

f_758_29305_29333(                        writer, signature);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,28946,29357);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29381,29432);

f_758_29381_29431(
                    encInfos, f_758_29394_29430(this, local, signature));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,28801,29451);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,651);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,651);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29471,29524);

BlobHandle 
blobIndex = f_758_29494_29523(metadata, writer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29544,29612);

localSignatureHandle = f_758_29567_29611(this, blobIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29630,29644);

f_758_29630_29643(                writer);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,28571,29756);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,28571,29756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29710,29741);

localSignatureHandle = default;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,28571,29756);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,29772,30110);

var 
info = f_758_29783_30109(f_758_29830_29843(body), f_758_29862_29884(                encInfos), f_758_29903_29923(body), f_758_29942_29963(body), f_758_29982_30007(body), f_758_30026_30060(body), f_758_30079_30108(body))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30126,30182);

f_758_30126_30181(
            _addedOrChangedMethods, f_758_30153_30174(body), info);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30198,30214);

f_758_30198_30213(
            encInfos);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30228,30256);

return localSignatureHandle;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,28263,30267);

System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
f_758_28465_28484(Microsoft.Cci.IMethodBody
this_param)
{
var return_v = this_param.LocalVariables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 28465, 28484);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
f_758_28514_28554()
{
var return_v = ArrayBuilder<EncLocalInfo>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 28514, 28554);
return return_v;
}


Microsoft.Cci.PooledBlobBuilder
f_758_28647_28678()
{
var return_v = PooledBlobBuilder.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 28647, 28678);
return return_v;
}


System.Reflection.Metadata.Ecma335.BlobEncoder
f_758_28711_28734(Microsoft.Cci.PooledBlobBuilder
builder)
{
var return_v = new System.Reflection.Metadata.Ecma335.BlobEncoder( (System.Reflection.Metadata.BlobBuilder)builder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 28711, 28734);
return return_v;
}


byte[]?
f_758_28908_28923(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.Signature;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 28908, 28923);
return return_v;
}


int
f_758_29029_29041(Microsoft.Cci.PooledBlobBuilder
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 29029, 29041);
return return_v;
}


int
f_758_29068_29124(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.LocalVariableTypeEncoder
encoder,Microsoft.Cci.ILocalDefinition
local)
{
this_param.SerializeLocalVariableType( encoder, local);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29068, 29124);
return 0;
}


int
f_758_29185_29197(Microsoft.Cci.PooledBlobBuilder
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 29185, 29197);
return return_v;
}


byte[]
f_758_29163_29206(Microsoft.Cci.PooledBlobBuilder
this_param,int
start,int
byteCount)
{
var return_v = this_param.ToArray( start, byteCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29163, 29206);
return return_v;
}


int
f_758_29305_29333(Microsoft.Cci.PooledBlobBuilder
this_param,byte[]
buffer)
{
this_param.WriteBytes( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29305, 29333);
return 0;
}


Microsoft.CodeAnalysis.Emit.EncLocalInfo
f_758_29394_29430(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.Cci.ILocalDefinition
localDef,byte[]
signature)
{
var return_v = this_param.CreateEncLocalInfo( localDef, signature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29394, 29430);
return return_v;
}


int
f_758_29381_29431(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
this_param,Microsoft.CodeAnalysis.Emit.EncLocalInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29381, 29431);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
f_758_28836_28850_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 28836, 28850);
return return_v;
}


System.Reflection.Metadata.BlobHandle
f_758_29494_29523(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,Microsoft.Cci.PooledBlobBuilder
value)
{
var return_v = this_param.GetOrAddBlob( (System.Reflection.Metadata.BlobBuilder)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29494, 29523);
return return_v;
}


System.Reflection.Metadata.StandaloneSignatureHandle
f_758_29567_29611(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.BlobHandle
blobIndex)
{
var return_v = this_param.GetOrAddStandaloneSignatureHandle( blobIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29567, 29611);
return return_v;
}


int
f_758_29630_29643(Microsoft.Cci.PooledBlobBuilder
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29630, 29643);
return 0;
}


Microsoft.CodeAnalysis.CodeGen.DebugId
f_758_29830_29843(Microsoft.Cci.IMethodBody
this_param)
{
var return_v = this_param.MethodId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 29830, 29843);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
f_758_29862_29884(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29862, 29884);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
f_758_29903_29923(Microsoft.Cci.IMethodBody
this_param)
{
var return_v = this_param.LambdaDebugInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 29903, 29923);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
f_758_29942_29963(Microsoft.Cci.IMethodBody
this_param)
{
var return_v = this_param.ClosureDebugInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 29942, 29963);
return return_v;
}


string
f_758_29982_30007(Microsoft.Cci.IMethodBody
this_param)
{
var return_v = this_param.StateMachineTypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 29982, 30007);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
f_758_30026_30060(Microsoft.Cci.IMethodBody
this_param)
{
var return_v = this_param.StateMachineHoistedLocalSlots;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 30026, 30060);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
f_758_30079_30108(Microsoft.Cci.IMethodBody
this_param)
{
var return_v = this_param.StateMachineAwaiterSlots;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 30079, 30108);
return return_v;
}


Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo
f_758_29783_30109(Microsoft.CodeAnalysis.CodeGen.DebugId
methodId,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
lambdaDebugInfo,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
closureDebugInfo,string
stateMachineTypeNameOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
stateMachineHoistedLocalSlotsOpt,System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
stateMachineAwaiterSlotsOpt)
{
var return_v = new Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo( methodId, locals, lambdaDebugInfo, closureDebugInfo, stateMachineTypeNameOpt, stateMachineHoistedLocalSlotsOpt, stateMachineAwaiterSlotsOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 29783, 30109);
return return_v;
}


Microsoft.Cci.IMethodDefinition
f_758_30153_30174(Microsoft.Cci.IMethodBody
this_param)
{
var return_v = this_param.MethodDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 30153, 30174);
return return_v;
}


int
f_758_30126_30181(System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
this_param,Microsoft.Cci.IMethodDefinition
key,Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 30126, 30181);
return 0;
}


int
f_758_30198_30213(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 30198, 30213);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,28263,30267);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,28263,30267);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private EncLocalInfo CreateEncLocalInfo(ILocalDefinition localDef, byte[] signature)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,30279,31026);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30388,30503) || true) && (localDef.SlotInfo.Id.IsNone)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,30388,30503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30453,30488);

return f_758_30460_30487(signature);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,30388,30503);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30589,30635);

ITypeReference 
translatedType = f_758_30621_30634(localDef)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30649,30740);

ITypeSymbolInternal 
typeSymbol = f_758_30682_30716(translatedType)as ITypeSymbolInternal
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30754,30907) || true) && (typeSymbol != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,30754,30907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30810,30892);

translatedType = f_758_30827_30891(Context.Module, typeSymbol, Context.Diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,30754,30907);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,30923,31015);

return f_758_30930_31014(f_758_30947_30964(localDef), translatedType, f_758_30982_31002(localDef), signature);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,30279,31026);

Microsoft.CodeAnalysis.Emit.EncLocalInfo
f_758_30460_30487(byte[]
signature)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EncLocalInfo( signature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 30460, 30487);
return return_v;
}


Microsoft.Cci.ITypeReference
f_758_30621_30634(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 30621, 30634);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
f_758_30682_30716(Microsoft.Cci.ITypeReference
this_param)
{
var return_v = this_param.GetInternalSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 30682, 30716);
return return_v;
}


Microsoft.Cci.ITypeReference
f_758_30827_30891(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param,Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
type,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.EncTranslateType( type, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 30827, 30891);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
f_758_30947_30964(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.SlotInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 30947, 30964);
return return_v;
}


Microsoft.CodeAnalysis.LocalSlotConstraints
f_758_30982_31002(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.Constraints;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 30982, 31002);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EncLocalInfo
f_758_30930_31014(Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
slotInfo,Microsoft.Cci.ITypeReference
type,Microsoft.CodeAnalysis.LocalSlotConstraints
constraints,byte[]
signature)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EncLocalInfo( slotInfo, type, constraints, signature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 30930, 31014);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,30279,31026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,30279,31026);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override void PopulateEncLogTableRows(ImmutableArray<int> rowCounts)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,31038,34093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31336,31387);

var 
previousSizes = _previousGeneration.TableSizes
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31401,31453);

var 
deltaSizes = f_758_31418_31452(this, rowCounts)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31469,31544);

f_758_31469_31543(this, TableIndex.AssemblyRef, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31558,31631);

f_758_31558_31630(this, TableIndex.ModuleRef, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31645,31718);

f_758_31645_31717(this, TableIndex.MemberRef, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31732,31806);

f_758_31732_31805(this, TableIndex.MethodSpec, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31820,31891);

f_758_31820_31890(this, TableIndex.TypeRef, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31905,31977);

f_758_31905_31976(this, TableIndex.TypeSpec, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,31991,32068);

f_758_31991_32067(this, TableIndex.StandAloneSig, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32084,32139);

f_758_32084_32138(this, _typeDefs, TableIndex.TypeDef);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32153,32225);

f_758_32153_32224(this, TableIndex.EventMap, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32239,32314);

f_758_32239_32313(this, TableIndex.PropertyMap, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32330,32465);

f_758_32330_32464(this, _eventDefs, TableIndex.Event, EditAndContinueOperation.AddEvent, _eventMap, TableIndex.EventMap);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32479,32579);

f_758_32479_32578(this, _fieldDefs, TableIndex.Field, EditAndContinueOperation.AddField);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32593,32699);

f_758_32593_32698(this, _methodDefs, TableIndex.MethodDef, EditAndContinueOperation.AddMethod);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32713,32863);

f_758_32713_32862(this, _propertyDefs, TableIndex.Property, EditAndContinueOperation.AddProperty, _propertyMap, TableIndex.PropertyMap);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32879,32911);

f_758_32879_32910(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,32927,32999);

f_758_32927_32998(this, TableIndex.Constant, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33013,33092);

f_758_33013_33091(this, TableIndex.CustomAttribute, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33106,33182);

f_758_33106_33181(this, TableIndex.DeclSecurity, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33196,33271);

f_758_33196_33270(this, TableIndex.ClassLayout, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33285,33360);

f_758_33285_33359(this, TableIndex.FieldLayout, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33374,33453);

f_758_33374_33452(this, TableIndex.MethodSemantics, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33467,33541);

f_758_33467_33540(this, TableIndex.MethodImpl, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33555,33626);

f_758_33555_33625(this, TableIndex.ImplMap, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33640,33712);

f_758_33640_33711(this, TableIndex.FieldRva, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33726,33801);

f_758_33726_33800(this, TableIndex.NestedClass, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33815,33891);

f_758_33815_33890(this, TableIndex.GenericParam, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33905,33982);

f_758_33905_33981(this, TableIndex.InterfaceImpl, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,33996,34082);

f_758_33996_34081(this, TableIndex.GenericParamConstraint, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,31038,34093);

System.Collections.Immutable.ImmutableArray<int>
f_758_31418_31452(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Collections.Immutable.ImmutableArray<int>
rowCounts)
{
var return_v = this_param.GetDeltaTableSizes( rowCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 31418, 31452);
return return_v;
}


int
f_758_31469_31543(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 31469, 31543);
return 0;
}


int
f_758_31558_31630(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 31558, 31630);
return 0;
}


int
f_758_31645_31717(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 31645, 31717);
return 0;
}


int
f_758_31732_31805(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 31732, 31805);
return 0;
}


int
f_758_31820_31890(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 31820, 31890);
return 0;
}


int
f_758_31905_31976(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 31905, 31976);
return 0;
}


int
f_758_31991_32067(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 31991, 32067);
return 0;
}


int
f_758_32084_32138(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
this_param.PopulateEncLogTableRows<Microsoft.Cci.ITypeDefinition>( index, tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32084, 32138);
return 0;
}


int
f_758_32153_32224(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32153, 32224);
return 0;
}


int
f_758_32239_32313(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32239, 32313);
return 0;
}


int
f_758_32330_32464(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
addCode,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
map,System.Reflection.Metadata.Ecma335.TableIndex
mapTable)
{
this_param.PopulateEncLogTableEventsOrProperties<Microsoft.Cci.IEventDefinition>( index, table, addCode, map, mapTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32330, 32464);
return 0;
}


int
f_758_32479_32578(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
addCode)
{
this_param.PopulateEncLogTableFieldsOrMethods<Microsoft.Cci.IFieldDefinition>( index, tableIndex, addCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32479, 32578);
return 0;
}


int
f_758_32593_32698(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
addCode)
{
this_param.PopulateEncLogTableFieldsOrMethods<Microsoft.Cci.IMethodDefinition>( index, tableIndex, addCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32593, 32698);
return 0;
}


int
f_758_32713_32862(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
addCode,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
map,System.Reflection.Metadata.Ecma335.TableIndex
mapTable)
{
this_param.PopulateEncLogTableEventsOrProperties<Microsoft.Cci.IPropertyDefinition>( index, table, addCode, map, mapTable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32713, 32862);
return 0;
}


int
f_758_32879_32910(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param)
{
this_param.PopulateEncLogTableParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32879, 32910);
return 0;
}


int
f_758_32927_32998(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 32927, 32998);
return 0;
}


int
f_758_33013_33091(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33013, 33091);
return 0;
}


int
f_758_33106_33181(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33106, 33181);
return 0;
}


int
f_758_33196_33270(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33196, 33270);
return 0;
}


int
f_758_33285_33359(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33285, 33359);
return 0;
}


int
f_758_33374_33452(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33374, 33452);
return 0;
}


int
f_758_33467_33540(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33467, 33540);
return 0;
}


int
f_758_33555_33625(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33555, 33625);
return 0;
}


int
f_758_33640_33711(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33640, 33711);
return 0;
}


int
f_758_33726_33800(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33726, 33800);
return 0;
}


int
f_758_33815_33890(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33815, 33890);
return 0;
}


int
f_758_33905_33981(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33905, 33981);
return 0;
}


int
f_758_33996_34081(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
this_param.PopulateEncLogTableRows( tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 33996, 34081);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,31038,34093);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,31038,34093);
}
		}

private void PopulateEncLogTableEventsOrProperties<T>(
            DefinitionIndex<T> index,
            TableIndex table,
            EditAndContinueOperation addCode,
            EventOrPropertyMapIndex map,
            TableIndex mapTable)
            where T : class, ITypeDefinitionMember
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,34105,35225);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,34429,35214);
foreach(var member in f_758_34452_34467_I(f_758_34452_34467(index)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,34429,35214);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,34501,35019) || true) && (f_758_34505_34536(index, member))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,34501,35019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,34578,34637);

int 
typeIndex = f_758_34594_34636(_typeDefs, f_758_34604_34635(member))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,34659,34687);

f_758_34659_34686(typeIndex > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,34711,34724);

int 
mapRowId
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,34746,34796);

var 
ok = f_758_34755_34795(map, typeIndex, out mapRowId)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,34818,34835);

f_758_34818_34834(ok);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,34859,35000);

f_758_34859_34999(
                    metadata, entity: f_758_34917_34958(mapTable, mapRowId), code: addCode);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,34501,35019);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,35039,35199);

f_758_35039_35198(
                metadata, entity: f_758_35093_35136(table, f_758_35122_35135(index, member)), code: EditAndContinueOperation.Default);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,34429,35214);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,786);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,786);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,34105,35225);

System.Collections.Generic.IReadOnlyList<T>
f_758_34452_34467(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 34452, 34467);
return return_v;
}


bool
f_758_34505_34536(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param,T
item)
{
var return_v = this_param.IsAddedNotChanged( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 34505, 34536);
return return_v;
}


Microsoft.Cci.ITypeDefinition
f_758_34604_34635(T
this_param)
{
var return_v = this_param.ContainingTypeDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 34604, 34635);
return return_v;
}


int
f_758_34594_34636(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param,Microsoft.Cci.ITypeDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 34594, 34636);
return return_v;
}


int
f_758_34659_34686(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 34659, 34686);
return 0;
}


bool
f_758_34755_34795(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param,int
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 34755, 34795);
return return_v;
}


int
f_758_34818_34834(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 34818, 34834);
return 0;
}


System.Reflection.Metadata.EntityHandle
f_758_34917_34958(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 34917, 34958);
return return_v;
}


int
f_758_34859_34999(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.EntityHandle
entity,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
code)
{
this_param.AddEncLogEntry( entity: entity, code: code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 34859, 34999);
return 0;
}


int
f_758_35122_35135(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param,T
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 35122, 35135);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_758_35093_35136(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35093, 35136);
return return_v;
}


int
f_758_35039_35198(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.EntityHandle
entity,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
code)
{
this_param.AddEncLogEntry( entity: entity, code: code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35039, 35198);
return 0;
}


System.Collections.Generic.IReadOnlyList<T>
f_758_34452_34467_I(System.Collections.Generic.IReadOnlyList<T>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 34452, 34467);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,34105,35225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,34105,35225);
}
		}

private void PopulateEncLogTableFieldsOrMethods<T>(
            DefinitionIndex<T> index,
            TableIndex tableIndex,
            EditAndContinueOperation addCode)
            where T : class, ITypeDefinitionMember
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,35237,36067);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,35487,36056);
foreach(var member in f_758_35510_35525_I(f_758_35510_35525(index)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,35487,36056);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,35559,35856) || true) && (f_758_35563_35594(index, member))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,35559,35856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,35636,35837);

f_758_35636_35836(                    metadata, entity: f_758_35694_35795(f_758_35730_35794(_typeDefs, (INamedTypeDefinition)f_758_35762_35793(member))), code: addCode);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,35559,35856);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,35876,36041);

f_758_35876_36040(
                metadata, entity: f_758_35930_35978(tableIndex, f_758_35964_35977(index, member)), code: EditAndContinueOperation.Default);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,35487,36056);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,570);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,570);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,35237,36067);

System.Collections.Generic.IReadOnlyList<T>
f_758_35510_35525(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35510, 35525);
return return_v;
}


bool
f_758_35563_35594(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param,T
item)
{
var return_v = this_param.IsAddedNotChanged( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35563, 35594);
return return_v;
}


Microsoft.Cci.ITypeDefinition
f_758_35762_35793(T
this_param)
{
var return_v = this_param.ContainingTypeDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 35762, 35793);
return return_v;
}


int
f_758_35730_35794(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
this_param,Microsoft.Cci.ITypeDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 35730, 35794);
return return_v;
}


System.Reflection.Metadata.TypeDefinitionHandle
f_758_35694_35795(int
rowNumber)
{
var return_v = MetadataTokens.TypeDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35694, 35795);
return return_v;
}


int
f_758_35636_35836(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.TypeDefinitionHandle
entity,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
code)
{
this_param.AddEncLogEntry( entity: (System.Reflection.Metadata.EntityHandle)entity, code: code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35636, 35836);
return 0;
}


int
f_758_35964_35977(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param,T
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 35964, 35977);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_758_35930_35978(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35930, 35978);
return return_v;
}


int
f_758_35876_36040(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.EntityHandle
entity,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
code)
{
this_param.AddEncLogEntry( entity: entity, code: code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35876, 36040);
return 0;
}


System.Collections.Generic.IReadOnlyList<T>
f_758_35510_35525_I(System.Collections.Generic.IReadOnlyList<T>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 35510, 35525);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,35237,36067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,35237,36067);
}
		}

private void PopulateEncLogTableParameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,36079,36752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36148,36197);

var 
parameterFirstId = f_758_36171_36196(_parameterDefs)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36220,36225);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36211,36741) || true) && (i < f_758_36231_36254(_parameterDefList))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36256,36259)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(758,36211,36741))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,36211,36741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36293,36334);

var 
methodDef = _parameterDefList[i].Key
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36354,36537);

f_758_36354_36536(
                metadata, entity: f_758_36408_36469(f_758_36446_36468(_methodDefs, methodDef)), code: EditAndContinueOperation.AddParameter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36557,36726);

f_758_36557_36725(
                metadata, entity: f_758_36611_36663(parameterFirstId + i), code: EditAndContinueOperation.Default);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,531);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,531);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,36079,36752);

int
f_758_36171_36196(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.ParameterDefinitionIndex
this_param)
{
var return_v = this_param.FirstRowId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 36171, 36196);
return return_v;
}


int
f_758_36231_36254(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.Cci.IMethodDefinition, Microsoft.Cci.IParameterDefinition>>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 36231, 36254);
return return_v;
}


int
f_758_36446_36468(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param,Microsoft.Cci.IMethodDefinition
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 36446, 36468);
return return_v;
}


System.Reflection.Metadata.MethodDefinitionHandle
f_758_36408_36469(int
rowNumber)
{
var return_v = MetadataTokens.MethodDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 36408, 36469);
return return_v;
}


int
f_758_36354_36536(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.MethodDefinitionHandle
entity,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
code)
{
this_param.AddEncLogEntry( entity: (System.Reflection.Metadata.EntityHandle)entity, code: code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 36354, 36536);
return 0;
}


System.Reflection.Metadata.ParameterHandle
f_758_36611_36663(int
rowNumber)
{
var return_v = MetadataTokens.ParameterHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 36611, 36663);
return return_v;
}


int
f_758_36557_36725(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.ParameterHandle
entity,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
code)
{
this_param.AddEncLogEntry( entity: (System.Reflection.Metadata.EntityHandle)entity, code: code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 36557, 36725);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,36079,36752);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,36079,36752);
}
		}

private void PopulateEncLogTableRows<T>(DefinitionIndex<T> index, TableIndex tableIndex)
            where T : class, IDefinition
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,36764,37182);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36919,37171);
foreach(var member in f_758_36942_36957_I(f_758_36942_36957(index)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,36919,37171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,36991,37156);

f_758_36991_37155(                metadata, entity: f_758_37045_37093(tableIndex, f_758_37079_37092(index, member)), code: EditAndContinueOperation.Default);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,36919,37171);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,253);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,253);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,36764,37182);

System.Collections.Generic.IReadOnlyList<T>
f_758_36942_36957(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 36942, 36957);
return return_v;
}


int
f_758_37079_37092(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param,T
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 37079, 37092);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_758_37045_37093(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 37045, 37093);
return return_v;
}


int
f_758_36991_37155(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.EntityHandle
entity,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
code)
{
this_param.AddEncLogEntry( entity: entity, code: code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 36991, 37155);
return 0;
}


System.Collections.Generic.IReadOnlyList<T>
f_758_36942_36957_I(System.Collections.Generic.IReadOnlyList<T>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 36942, 36957);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,36764,37182);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,36764,37182);
}
		}

private void PopulateEncLogTableRows(TableIndex tableIndex, ImmutableArray<int> previousSizes, ImmutableArray<int> deltaSizes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,37194,37457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,37345,37446);

f_758_37345_37445(this, tableIndex, previousSizes[(int)tableIndex] + 1, deltaSizes[(int)tableIndex]);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,37194,37457);

int
f_758_37345_37445(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
firstRowId,int
tokenCount)
{
this_param.PopulateEncLogTableRows( tableIndex, firstRowId, tokenCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 37345, 37445);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,37194,37457);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,37194,37457);
}
		}

private void PopulateEncLogTableRows(TableIndex tableIndex, int firstRowId, int tokenCount)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,37469,37846);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,37594,37599);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,37585,37835) || true) && (i < tokenCount)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,37617,37620)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(758,37585,37835))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,37585,37835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,37654,37820);

f_758_37654_37819(                metadata, entity: f_758_37708_37757(tableIndex, firstRowId + i), code: EditAndContinueOperation.Default);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,251);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,251);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,37469,37846);

System.Reflection.Metadata.EntityHandle
f_758_37708_37757(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 37708, 37757);
return return_v;
}


int
f_758_37654_37819(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.EntityHandle
entity,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
code)
{
this_param.AddEncLogEntry( entity: entity, code: code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 37654, 37819);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,37469,37846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,37469,37846);
}
		}

protected override void PopulateEncMapTableRows(ImmutableArray<int> rowCounts)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,37858,44202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38246,38300);

var 
tokens = f_758_38259_38299()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38314,38365);

var 
previousSizes = _previousGeneration.TableSizes
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38379,38431);

var 
deltaSizes = f_758_38396_38430(this, rowCounts)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38447,38526);

f_758_38447_38525(tokens, TableIndex.AssemblyRef, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38540,38617);

f_758_38540_38616(tokens, TableIndex.ModuleRef, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38631,38708);

f_758_38631_38707(tokens, TableIndex.MemberRef, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38722,38800);

f_758_38722_38799(tokens, TableIndex.MethodSpec, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38814,38889);

f_758_38814_38888(tokens, TableIndex.TypeRef, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38903,38979);

f_758_38903_38978(tokens, TableIndex.TypeSpec, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,38993,39074);

f_758_38993_39073(tokens, TableIndex.StandAloneSig, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39090,39149);

f_758_39090_39148(tokens, _typeDefs, TableIndex.TypeDef);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39163,39221);

f_758_39163_39220(tokens, _eventDefs, TableIndex.Event);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39235,39293);

f_758_39235_39292(tokens, _fieldDefs, TableIndex.Field);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39307,39370);

f_758_39307_39369(tokens, _methodDefs, TableIndex.MethodDef);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39384,39448);

f_758_39384_39447(tokens, _propertyDefs, TableIndex.Property);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39464,39537);

f_758_39464_39536(tokens, TableIndex.Param, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39551,39627);

f_758_39551_39626(tokens, TableIndex.Constant, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39641,39724);

f_758_39641_39723(tokens, TableIndex.CustomAttribute, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39738,39818);

f_758_39738_39817(tokens, TableIndex.DeclSecurity, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39832,39911);

f_758_39832_39910(tokens, TableIndex.ClassLayout, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,39925,40004);

f_758_39925_40003(tokens, TableIndex.FieldLayout, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40018,40094);

f_758_40018_40093(tokens, TableIndex.EventMap, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40108,40187);

f_758_40108_40186(tokens, TableIndex.PropertyMap, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40201,40284);

f_758_40201_40283(tokens, TableIndex.MethodSemantics, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40298,40376);

f_758_40298_40375(tokens, TableIndex.MethodImpl, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40390,40465);

f_758_40390_40464(tokens, TableIndex.ImplMap, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40479,40555);

f_758_40479_40554(tokens, TableIndex.FieldRva, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40569,40648);

f_758_40569_40647(tokens, TableIndex.NestedClass, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40662,40742);

f_758_40662_40741(tokens, TableIndex.GenericParam, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40756,40837);

f_758_40756_40836(tokens, TableIndex.InterfaceImpl, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40851,40941);

f_758_40851_40940(tokens, TableIndex.GenericParamConstraint, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,40957,40993);

f_758_40957_40992(
            tokens, f_758_40969_40991());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41055,41111);

f_758_41055_41110(f_758_41068_41093(f_758_41068_41085(tokens))== f_758_41097_41109(tokens));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41127,41235);
foreach(var token in f_758_41149_41155_I(tokens) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,41127,41235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41189,41220);

f_758_41189_41219(                metadata, token);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,41127,41235);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,109);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,109);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41251,41265);

f_758_41251_41264(
            tokens);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41429,42053) || true) && (_debugMetadataOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,41429,42053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41492,41551);

var 
debugTokens = f_758_41510_41550()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41569,41650);

f_758_41569_41649(debugTokens, _methodDefs, TableIndex.MethodDebugInformation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41668,41709);

f_758_41668_41708(                debugTokens, f_758_41685_41707());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41779,41845);

f_758_41779_41844(f_758_41792_41822(f_758_41792_41814(debugTokens))== f_758_41826_41843(debugTokens));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41865,41999);
foreach(var token in f_758_41887_41898_I(debugTokens) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,41865,41999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,41940,41980);

f_758_41940_41979(                    _debugMetadataOpt, token);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,41865,41999);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,135);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,135);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,42019,42038);

f_758_42019_42037(
                debugTokens);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,41429,42053);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,42221,43914);

var 
handledTables = new TableIndex[]
            {
                TableIndex.Module,
                TableIndex.TypeRef,
                TableIndex.TypeDef,
                TableIndex.Field,
                TableIndex.MethodDef,
                TableIndex.Param,
                TableIndex.MemberRef,
                TableIndex.Constant,
                TableIndex.CustomAttribute,
                TableIndex.DeclSecurity,
                TableIndex.ClassLayout,
                TableIndex.FieldLayout,
                TableIndex.StandAloneSig,
                TableIndex.EventMap,
                TableIndex.Event,
                TableIndex.PropertyMap,
                TableIndex.Property,
                TableIndex.MethodSemantics,
                TableIndex.MethodImpl,
                TableIndex.ModuleRef,
                TableIndex.TypeSpec,
                TableIndex.ImplMap,
                // FieldRva is not needed since we only emit fields with explicit mapping
                // for <PrivateImplementationDetails> and that class is not used in ENC.
                // If we need FieldRva in the future, we'll need a corresponding test.
                // (See EditAndContinueTests.FieldRva that was deleted in this change.)
                //TableIndex.FieldRva,
                TableIndex.EncLog,
                TableIndex.EncMap,
                TableIndex.Assembly,
                TableIndex.AssemblyRef,
                TableIndex.MethodSpec,
                TableIndex.NestedClass,
                TableIndex.GenericParam,
                TableIndex.InterfaceImpl,
                TableIndex.GenericParamConstraint,
            }
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,43939,43944);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,43930,44183) || true) && (i < rowCounts.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,43968,43971)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(758,43930,44183))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,43930,44183);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,44005,44116) || true) && (f_758_44009_44046(handledTables, i))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,44005,44116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,44088,44097);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,44005,44116);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,44136,44168);

f_758_44136_44167(rowCounts[i] == 0);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,254);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,254);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,37858,44202);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
f_758_38259_38299()
{
var return_v = ArrayBuilder<EntityHandle>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38259, 38299);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_758_38396_38430(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,System.Collections.Immutable.ImmutableArray<int>
rowCounts)
{
var return_v = this_param.GetDeltaTableSizes( rowCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38396, 38430);
return return_v;
}


int
f_758_38447_38525(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38447, 38525);
return 0;
}


int
f_758_38540_38616(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38540, 38616);
return 0;
}


int
f_758_38631_38707(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38631, 38707);
return 0;
}


int
f_758_38722_38799(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38722, 38799);
return 0;
}


int
f_758_38814_38888(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38814, 38888);
return 0;
}


int
f_758_38903_38978(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38903, 38978);
return 0;
}


int
f_758_38993_39073(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 38993, 39073);
return 0;
}


int
f_758_39090_39148(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
tokens,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
AddDefinitionTokens( tokens, index, tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39090, 39148);
return 0;
}


int
f_758_39163_39220(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
tokens,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
AddDefinitionTokens( tokens, index, tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39163, 39220);
return 0;
}


int
f_758_39235_39292(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
tokens,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
AddDefinitionTokens( tokens, index, tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39235, 39292);
return 0;
}


int
f_758_39307_39369(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
tokens,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
AddDefinitionTokens( tokens, index, tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39307, 39369);
return 0;
}


int
f_758_39384_39447(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
tokens,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
AddDefinitionTokens( tokens, index, tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39384, 39447);
return 0;
}


int
f_758_39464_39536(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39464, 39536);
return 0;
}


int
f_758_39551_39626(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39551, 39626);
return 0;
}


int
f_758_39641_39723(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39641, 39723);
return 0;
}


int
f_758_39738_39817(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39738, 39817);
return 0;
}


int
f_758_39832_39910(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39832, 39910);
return 0;
}


int
f_758_39925_40003(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 39925, 40003);
return 0;
}


int
f_758_40018_40093(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40018, 40093);
return 0;
}


int
f_758_40108_40186(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40108, 40186);
return 0;
}


int
f_758_40201_40283(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40201, 40283);
return 0;
}


int
f_758_40298_40375(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40298, 40375);
return 0;
}


int
f_758_40390_40464(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40390, 40464);
return 0;
}


int
f_758_40479_40554(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40479, 40554);
return 0;
}


int
f_758_40569_40647(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40569, 40647);
return 0;
}


int
f_758_40662_40741(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40662, 40741);
return 0;
}


int
f_758_40756_40836(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40756, 40836);
return 0;
}


int
f_758_40851_40940(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,System.Collections.Immutable.ImmutableArray<int>
previousSizes,System.Collections.Immutable.ImmutableArray<int>
deltaSizes)
{
AddReferencedTokens( builder, tableIndex, previousSizes, deltaSizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40851, 40940);
return 0;
}


System.Reflection.Metadata.HandleComparer
f_758_40969_40991()
{
var return_v = HandleComparer.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 40969, 40991);
return return_v;
}


int
f_758_40957_40992(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
this_param,System.Reflection.Metadata.HandleComparer
comparer)
{
this_param.Sort( (System.Collections.Generic.IComparer<System.Reflection.Metadata.EntityHandle>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 40957, 40992);
return 0;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
f_758_41068_41085(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
source)
{
var return_v = source.Distinct<System.Reflection.Metadata.EntityHandle>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41068, 41085);
return return_v;
}


int
f_758_41068_41093(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
source)
{
var return_v = source.Count<System.Reflection.Metadata.EntityHandle>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41068, 41093);
return return_v;
}


int
f_758_41097_41109(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 41097, 41109);
return return_v;
}


int
f_758_41055_41110(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41055, 41110);
return 0;
}


int
f_758_41189_41219(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.EntityHandle
entity)
{
this_param.AddEncMapEntry( entity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41189, 41219);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
f_758_41149_41155_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41149, 41155);
return return_v;
}


int
f_758_41251_41264(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41251, 41264);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
f_758_41510_41550()
{
var return_v = ArrayBuilder<EntityHandle>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41510, 41550);
return return_v;
}


int
f_758_41569_41649(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
tokens,Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
index,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
AddDefinitionTokens( tokens, index, tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41569, 41649);
return 0;
}


System.Reflection.Metadata.HandleComparer
f_758_41685_41707()
{
var return_v = HandleComparer.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 41685, 41707);
return return_v;
}


int
f_758_41668_41708(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
this_param,System.Reflection.Metadata.HandleComparer
comparer)
{
this_param.Sort( (System.Collections.Generic.IComparer<System.Reflection.Metadata.EntityHandle>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41668, 41708);
return 0;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
f_758_41792_41814(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
source)
{
var return_v = source.Distinct<System.Reflection.Metadata.EntityHandle>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41792, 41814);
return return_v;
}


int
f_758_41792_41822(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.EntityHandle>
source)
{
var return_v = source.Count<System.Reflection.Metadata.EntityHandle>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41792, 41822);
return return_v;
}


int
f_758_41826_41843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 41826, 41843);
return return_v;
}


int
f_758_41779_41844(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41779, 41844);
return 0;
}


int
f_758_41940_41979(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.EntityHandle
entity)
{
this_param.AddEncMapEntry( entity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41940, 41979);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
f_758_41887_41898_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 41887, 41898);
return return_v;
}


int
f_758_42019_42037(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 42019, 42037);
return 0;
}


bool
f_758_44009_44046(System.Reflection.Metadata.Ecma335.TableIndex[]
list,int
item)
{
var return_v = list.Contains<System.Reflection.Metadata.Ecma335.TableIndex>( (System.Reflection.Metadata.Ecma335.TableIndex)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 44009, 44046);
return return_v;
}


int
f_758_44136_44167(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 44136, 44167);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,37858,44202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,37858,44202);
}
		}

private static void AddReferencedTokens(
            ArrayBuilder<EntityHandle> builder,
            TableIndex tableIndex,
            ImmutableArray<int> previousSizes,
            ImmutableArray<int> deltaSizes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(758,44214,44574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,44457,44563);

f_758_44457_44562(builder, tableIndex, previousSizes[(int)tableIndex] + 1, deltaSizes[(int)tableIndex]);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(758,44214,44574);

int
f_758_44457_44562(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
builder,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
firstRowId,int
nTokens)
{
AddReferencedTokens( builder, tableIndex, firstRowId, nTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 44457, 44562);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,44214,44574);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,44214,44574);
}
		}

private static void AddReferencedTokens(ArrayBuilder<EntityHandle> builder, TableIndex tableIndex, int firstRowId, int nTokens)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(758,44586,44893);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,44747,44752);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,44738,44882) || true) && (i < nTokens)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,44767,44770)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(758,44738,44882))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,44738,44882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,44804,44867);

f_758_44804_44866(                builder, f_758_44816_44865(tableIndex, firstRowId + i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,145);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,145);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(758,44586,44893);

System.Reflection.Metadata.EntityHandle
f_758_44816_44865(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 44816, 44865);
return return_v;
}


int
f_758_44804_44866(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
this_param,System.Reflection.Metadata.EntityHandle
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 44804, 44866);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,44586,44893);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,44586,44893);
}
		}

private static void AddDefinitionTokens<T>(ArrayBuilder<EntityHandle> tokens, DefinitionIndex<T> index, TableIndex tableIndex)
            where T : class, IDefinition
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(758,44905,45257);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,45098,45246);
foreach(var member in f_758_45121_45136_I(f_758_45121_45136(index)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,45098,45246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,45170,45231);

f_758_45170_45230(                tokens, f_758_45181_45229(tableIndex, f_758_45215_45228(index, member)));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,45098,45246);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,149);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,149);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(758,44905,45257);

System.Collections.Generic.IReadOnlyList<T>
f_758_45121_45136(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45121, 45136);
return return_v;
}


int
f_758_45215_45228(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<T>
this_param,T
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 45215, 45228);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_758_45181_45229(System.Reflection.Metadata.Ecma335.TableIndex
tableIndex,int
rowNumber)
{
var return_v = MetadataTokens.Handle( tableIndex, rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45181, 45229);
return return_v;
}


int
f_758_45170_45230(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.Metadata.EntityHandle>
this_param,System.Reflection.Metadata.EntityHandle
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45170, 45230);
return 0;
}


System.Collections.Generic.IReadOnlyList<T>
f_758_45121_45136_I(System.Collections.Generic.IReadOnlyList<T>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45121, 45136);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,44905,45257);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,44905,45257);
}
		}

protected override void PopulateEventMapTableRows()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,45269,45639);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,45345,45628);
foreach(var typeId in f_758_45368_45387_I(f_758_45368_45387(_eventMap)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,45345,45628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,45421,45613);

f_758_45421_45612(                metadata, declaringType: f_758_45479_45522(typeId), eventList: f_758_45556_45611(f_758_45593_45610(_eventMap, typeId)));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,45345,45628);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,284);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,284);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,45269,45639);

System.Collections.Generic.IReadOnlyList<int>
f_758_45368_45387(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45368, 45387);
return return_v;
}


System.Reflection.Metadata.TypeDefinitionHandle
f_758_45479_45522(int
rowNumber)
{
var return_v = MetadataTokens.TypeDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45479, 45522);
return return_v;
}


int
f_758_45593_45610(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 45593, 45610);
return return_v;
}


System.Reflection.Metadata.EventDefinitionHandle
f_758_45556_45611(int
rowNumber)
{
var return_v = MetadataTokens.EventDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45556, 45611);
return return_v;
}


int
f_758_45421_45612(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.TypeDefinitionHandle
declaringType,System.Reflection.Metadata.EventDefinitionHandle
eventList)
{
this_param.AddEventMap( declaringType: declaringType, eventList: eventList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45421, 45612);
return 0;
}


System.Collections.Generic.IReadOnlyList<int>
f_758_45368_45387_I(System.Collections.Generic.IReadOnlyList<int>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45368, 45387);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,45269,45639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,45269,45639);
}
		}

protected override void PopulatePropertyMapTableRows()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,45651,46039);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,45730,46028);
foreach(var typeId in f_758_45753_45775_I(f_758_45753_45775(_propertyMap)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,45730,46028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,45809,46013);

f_758_45809_46012(                metadata, declaringType: f_758_45870_45913(typeId), propertyList: f_758_45950_46011(f_758_45990_46010(_propertyMap, typeId)));
DynAbs.Tracing.TraceSender.TraceExitCondition(758,45730,46028);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(758,1,299);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(758,1,299);
}DynAbs.Tracing.TraceSender.TraceExitMethod(758,45651,46039);

System.Collections.Generic.IReadOnlyList<int>
f_758_45753_45775(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param)
{
var return_v = this_param.GetRows();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45753, 45775);
return return_v;
}


System.Reflection.Metadata.TypeDefinitionHandle
f_758_45870_45913(int
rowNumber)
{
var return_v = MetadataTokens.TypeDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45870, 45913);
return return_v;
}


int
f_758_45990_46010(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 45990, 46010);
return return_v;
}


System.Reflection.Metadata.PropertyDefinitionHandle
f_758_45950_46011(int
rowNumber)
{
var return_v = MetadataTokens.PropertyDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45950, 46011);
return return_v;
}


int
f_758_45809_46012(System.Reflection.Metadata.Ecma335.MetadataBuilder
this_param,System.Reflection.Metadata.TypeDefinitionHandle
declaringType,System.Reflection.Metadata.PropertyDefinitionHandle
propertyList)
{
this_param.AddPropertyMap( declaringType: declaringType, propertyList: propertyList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45809, 46012);
return 0;
}


System.Collections.Generic.IReadOnlyList<int>
f_758_45753_45775_I(System.Collections.Generic.IReadOnlyList<int>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 45753, 45775);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,45651,46039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,45651,46039);
}
		}
private abstract class DefinitionIndexBase<T>
{
protected readonly Dictionary<T, int> added;

protected readonly List<T> rows;

private readonly int _firstRowId;

private bool _frozen;

public DefinitionIndexBase(int lastRowId, IEqualityComparer<T> comparer = null)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(758,46440,46703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46159,46164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46247,46251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46344,46355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46416,46423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46552,46598);

this.added = f_758_46565_46597<T>(comparer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46616,46642);

this.rows = f_758_46628_46641<T>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46660,46688);

_firstRowId = lastRowId + 1;
DynAbs.Tracing.TraceSender.TraceExitConstructor(758,46440,46703);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,46440,46703);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,46440,46703);
}
		}

public abstract bool TryGetValue(T item, out int index);

            public int this[T item]
            {

get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,46847,47251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46891,46901);

int 
token
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,46923,46957);

f_758_46923_46956(                    this, item, out token);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,47171,47195);

f_758_47171_47194(token > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,47219,47232);

return token;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,46847,47251);

bool
f_758_46923_46956(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndexBase<T>
this_param,T
item,out int
index)
{
var return_v = this_param.TryGetValue( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 46923, 46956);
return return_v;
}


int
f_758_47171_47194(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 47171, 47194);
return 0;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,46847,47251);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,46847,47251);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
            }

            // A method rather than a property since it freezes the table.
            public IReadOnlyDictionary<T, int> GetAdded()
            {
                this.Freeze();
                return this.added;
            }

            // A method rather than a property since it freezes the table.
            public IReadOnlyList<T> GetRows()
            {
                this.Freeze();
                return this.rows;
            }

public int FirstRowId
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(758,47793,47820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,47799,47818);

return _firstRowId;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,47793,47820);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,47739,47835);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,47739,47835);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public int NextRowId
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(758,47904,47950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,47910,47948);

return f_758_47917_47933(this.added)+ _firstRowId;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,47904,47950);

int
f_758_47917_47933(System.Collections.Generic.Dictionary<T, int>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 47917, 47933);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,47851,47965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,47851,47965);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool IsFrozen
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(758,48034,48057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,48040,48055);

return _frozen;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,48034,48057);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,47981,48072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,47981,48072);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

            protected virtual void OnFrozen()
            {
#if DEBUG
                // Verify the rows are sorted.
                int prev = 0;
                foreach (var row in this.rows)
                {
                    int next = this.added[row];
                    Debug.Assert(prev < next);
                    prev = next;
                }
#endif
            }

            private void Freeze()
            {
                if (!_frozen)
                {
                    _frozen = true;
                    this.OnFrozen();
                }
            }

static DefinitionIndexBase()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(758,46051,48688);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(758,46051,48688);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,46051,48688);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(758,46051,48688);

static System.Collections.Generic.Dictionary<T, int>
f_758_46565_46597<T>(System.Collections.Generic.IEqualityComparer<T>?
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<T, int>( comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 46565, 46597);
return return_v;
}


static System.Collections.Generic.List<T>
f_758_46628_46641<T>()
{
var return_v = new System.Collections.Generic.List<T>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 46628, 46641);
return return_v;
}

}
private sealed class DefinitionIndex<T> : DefinitionIndexBase<T> where T : class, IDefinition
{            public delegate bool TryGetExistingIndex(T item, out int index);

private readonly TryGetExistingIndex _tryGetExistingIndex;

private readonly Dictionary<int, T> _map;

public DefinitionIndex(TryGetExistingIndex tryGetExistingIndex, int lastRowId)
:base(f_758_49434_49443_C(lastRowId) ,ReferenceEqualityComparer.Instance)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(758,49331,49621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,48935,48955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,49310,49314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,49513,49556);

_tryGetExistingIndex = tryGetExistingIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,49574,49606);

_map = f_758_49581_49605<T>();
DynAbs.Tracing.TraceSender.TraceExitConstructor(758,49331,49621);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,49331,49621);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,49331,49621);
}
		}

            public override bool TryGetValue(T item, out int index)
            {
                if (this.added.TryGetValue(item, out index))
                {
                    return true;
                }

                if (_tryGetExistingIndex(item, out index))
                {
#if DEBUG
                    T other;
                    Debug.Assert(!_map.TryGetValue(index, out other) || ((object)other == (object)item));
#endif
                    _map[index] = item;
                    return true;
                }
                return false;
            }

            public T this[int rowId]
            {

get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,50291,50373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,50335,50354);

return f_758_50342_50353(_map, rowId);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,50291,50373);

T
f_758_50342_50353(System.Collections.Generic.Dictionary<int, T>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 50342, 50353);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,50291,50373);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,50291,50373);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
            }

            public void Add(T item)
            {
                Debug.Assert(!this.IsFrozen);

                int index = this.NextRowId;
                this.added.Add(item, index);
                _map[index] = item;
                this.rows.Add(item);
            }

            /// <summary>
            /// Add an item from a previous generation
            /// that has been updated in this generation.
            /// </summary>
            public void AddUpdated(T item)
            {
                Debug.Assert(!this.IsFrozen);
                this.rows.Add(item);
            }

            public bool IsAddedNotChanged(T item)
            {
                return this.added.ContainsKey(item);
            }

            protected override void OnFrozen()
            {
                this.rows.Sort(this.CompareRows);
            }

private int CompareRows(T x, T y)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,51287,51393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51353,51378);

return this[x] - this[y];
DynAbs.Tracing.TraceSender.TraceExitMethod(758,51287,51393);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,51287,51393);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,51287,51393);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static DefinitionIndex()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(758,48700,51404);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(758,48700,51404);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,48700,51404);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(758,48700,51404);

static System.Collections.Generic.Dictionary<int, T>
f_758_49581_49605<T>()where T : class, IDefinition

{
var return_v = new System.Collections.Generic.Dictionary<int, T>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 49581, 49605);
return return_v;
}


static int
f_758_49434_49443_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(758, 49331, 49621);
return return_v;
}

}

private bool TryGetExistingTypeDefIndex(ITypeDefinition item, out int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,51416,51981);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51517,51641) || true) && (f_758_51521_51580(_previousGeneration.TypesAdded, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,51517,51641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51614,51626);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,51517,51641);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51657,51685);

TypeDefinitionHandle 
handle
=default(TypeDefinitionHandle);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51699,51917) || true) && (f_758_51703_51752(_definitionMap, item, out handle))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,51699,51917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51786,51830);

index = f_758_51794_51829(handle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51848,51872);

f_758_51848_51871(index > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51890,51902);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,51699,51917);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51933,51943);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,51957,51970);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,51416,51981);

bool
f_758_51521_51580(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
this_param,Microsoft.Cci.ITypeDefinition
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 51521, 51580);
return return_v;
}


bool
f_758_51703_51752(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.ITypeDefinition
def,out System.Reflection.Metadata.TypeDefinitionHandle
handle)
{
var return_v = this_param.TryGetTypeHandle( def, out handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 51703, 51752);
return return_v;
}


int
f_758_51794_51829(System.Reflection.Metadata.TypeDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 51794, 51829);
return return_v;
}


int
f_758_51848_51871(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 51848, 51871);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,51416,51981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,51416,51981);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetExistingEventDefIndex(IEventDefinition item, out int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,51993,52563);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52096,52221) || true) && (f_758_52100_52160(_previousGeneration.EventsAdded, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,52096,52221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52194,52206);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,52096,52221);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52237,52266);

EventDefinitionHandle 
handle
=default(EventDefinitionHandle);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52280,52499) || true) && (f_758_52284_52334(_definitionMap, item, out handle))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,52280,52499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52368,52412);

index = f_758_52376_52411(handle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52430,52454);

f_758_52430_52453(index > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52472,52484);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,52280,52499);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52515,52525);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52539,52552);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,51993,52563);

bool
f_758_52100_52160(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
this_param,Microsoft.Cci.IEventDefinition
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 52100, 52160);
return return_v;
}


bool
f_758_52284_52334(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IEventDefinition
def,out System.Reflection.Metadata.EventDefinitionHandle
handle)
{
var return_v = this_param.TryGetEventHandle( def, out handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 52284, 52334);
return return_v;
}


int
f_758_52376_52411(System.Reflection.Metadata.EventDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 52376, 52411);
return return_v;
}


int
f_758_52430_52453(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 52430, 52453);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,51993,52563);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,51993,52563);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetExistingFieldDefIndex(IFieldDefinition item, out int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,52575,53145);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52678,52803) || true) && (f_758_52682_52742(_previousGeneration.FieldsAdded, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,52678,52803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52776,52788);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,52678,52803);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52819,52848);

FieldDefinitionHandle 
handle
=default(FieldDefinitionHandle);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52862,53081) || true) && (f_758_52866_52916(_definitionMap, item, out handle))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,52862,53081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,52950,52994);

index = f_758_52958_52993(handle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53012,53036);

f_758_53012_53035(index > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53054,53066);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,52862,53081);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53097,53107);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53121,53134);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,52575,53145);

bool
f_758_52682_52742(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
this_param,Microsoft.Cci.IFieldDefinition
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 52682, 52742);
return return_v;
}


bool
f_758_52866_52916(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IFieldDefinition
def,out System.Reflection.Metadata.FieldDefinitionHandle
handle)
{
var return_v = this_param.TryGetFieldHandle( def, out handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 52866, 52916);
return return_v;
}


int
f_758_52958_52993(System.Reflection.Metadata.FieldDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 52958, 52993);
return return_v;
}


int
f_758_53012_53035(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 53012, 53035);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,52575,53145);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,52575,53145);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetExistingMethodDefIndex(IMethodDefinition item, out int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,53157,53732);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53262,53388) || true) && (f_758_53266_53327(_previousGeneration.MethodsAdded, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,53262,53388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53361,53373);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,53262,53388);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53404,53434);

MethodDefinitionHandle 
handle
=default(MethodDefinitionHandle);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53448,53668) || true) && (f_758_53452_53503(_definitionMap, item, out handle))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,53448,53668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53537,53581);

index = f_758_53545_53580(handle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53599,53623);

f_758_53599_53622(index > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53641,53653);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,53448,53668);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53684,53694);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53708,53721);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,53157,53732);

bool
f_758_53266_53327(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
this_param,Microsoft.Cci.IMethodDefinition
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 53266, 53327);
return return_v;
}


bool
f_758_53452_53503(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IMethodDefinition
def,out System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = this_param.TryGetMethodHandle( def, out handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 53452, 53503);
return return_v;
}


int
f_758_53545_53580(System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 53545, 53580);
return return_v;
}


int
f_758_53599_53622(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 53599, 53622);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,53157,53732);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,53157,53732);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetExistingPropertyDefIndex(IPropertyDefinition item, out int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,53744,54330);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53853,53982) || true) && (f_758_53857_53921(_previousGeneration.PropertiesAdded, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,53853,53982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53955,53967);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,53853,53982);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,53998,54030);

PropertyDefinitionHandle 
handle
=default(PropertyDefinitionHandle);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54044,54266) || true) && (f_758_54048_54101(_definitionMap, item, out handle))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,54044,54266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54135,54179);

index = f_758_54143_54178(handle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54197,54221);

f_758_54197_54220(index > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54239,54251);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,54044,54266);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54282,54292);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54306,54319);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,53744,54330);

bool
f_758_53857_53921(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
this_param,Microsoft.Cci.IPropertyDefinition
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 53857, 53921);
return return_v;
}


bool
f_758_54048_54101(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IPropertyDefinition
def,out System.Reflection.Metadata.PropertyDefinitionHandle
handle)
{
var return_v = this_param.TryGetPropertyHandle( def, out handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 54048, 54101);
return return_v;
}


int
f_758_54143_54178(System.Reflection.Metadata.PropertyDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 54143, 54178);
return return_v;
}


int
f_758_54197_54220(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 54197, 54220);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,53744,54330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,53744,54330);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetExistingEventMapIndex(int item, out int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,54342,54767);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54432,54559) || true) && (f_758_54436_54498(_previousGeneration.EventMapAdded, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,54432,54559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54532,54544);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,54432,54559);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54575,54703) || true) && (f_758_54579_54642(_previousGeneration.TypeToEventMap, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,54575,54703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54676,54688);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,54575,54703);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54719,54729);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54743,54756);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,54342,54767);

bool
f_758_54436_54498(System.Collections.Generic.IReadOnlyDictionary<int, int>
this_param,int
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 54436, 54498);
return return_v;
}


bool
f_758_54579_54642(System.Collections.Generic.IReadOnlyDictionary<int, int>
this_param,int
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 54579, 54642);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,54342,54767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,54342,54767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetExistingPropertyMapIndex(int item, out int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,54779,55213);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54872,55002) || true) && (f_758_54876_54941(_previousGeneration.PropertyMapAdded, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,54872,55002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,54975,54987);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,54872,55002);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55018,55149) || true) && (f_758_55022_55088(_previousGeneration.TypeToPropertyMap, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,55018,55149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55122,55134);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,55018,55149);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55165,55175);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55189,55202);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,54779,55213);

bool
f_758_54876_54941(System.Collections.Generic.IReadOnlyDictionary<int, int>
this_param,int
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 54876, 54941);
return return_v;
}


bool
f_758_55022_55088(System.Collections.Generic.IReadOnlyDictionary<int, int>
this_param,int
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 55022, 55088);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,54779,55213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,54779,55213);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetExistingMethodImplIndex(MethodImplKey item, out int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,55225,55662);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55327,55457) || true) && (f_758_55331_55396(_previousGeneration.MethodImplsAdded, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,55327,55457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55430,55442);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,55327,55457);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55473,55598) || true) && (f_758_55477_55537(_previousGeneration.MethodImpls, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,55473,55598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55571,55583);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,55473,55598);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55614,55624);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,55638,55651);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,55225,55662);

bool
f_758_55331_55396(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 55331, 55396);
return return_v;
}


bool
f_758_55477_55537(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 55477, 55537);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,55225,55662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,55225,55662);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private sealed class ParameterDefinitionIndex : DefinitionIndexBase<IParameterDefinition>
{
public ParameterDefinitionIndex(int lastRowId)
:base(f_758_55859_55868_C(lastRowId) ,ReferenceEqualityComparer.Instance)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(758,55788,55935);
DynAbs.Tracing.TraceSender.TraceExitConstructor(758,55788,55935);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,55788,55935);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,55788,55935);
}
		}

public override bool TryGetValue(IParameterDefinition item, out int index)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,55951,56120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,56058,56105);

return f_758_56065_56104(this.added, item, out index);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,55951,56120);

bool
f_758_56065_56104(System.Collections.Generic.Dictionary<Microsoft.Cci.IParameterDefinition, int>
this_param,Microsoft.Cci.IParameterDefinition
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 56065, 56104);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,55951,56120);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,55951,56120);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Add(IParameterDefinition item)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,56136,56386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,56211,56240);

f_758_56211_56239(f_758_56224_56238_M(!this.IsFrozen));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,56260,56287);

int 
index = f_758_56272_56286(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,56305,56333);

f_758_56305_56332(                this.added, item, index);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,56351,56371);

f_758_56351_56370(                this.rows, item);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,56136,56386);

bool
f_758_56224_56238_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 56224, 56238);
return return_v;
}


int
f_758_56211_56239(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 56211, 56239);
return 0;
}


int
f_758_56272_56286(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.ParameterDefinitionIndex
this_param)
{
var return_v = this_param.NextRowId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 56272, 56286);
return return_v;
}


int
f_758_56305_56332(System.Collections.Generic.Dictionary<Microsoft.Cci.IParameterDefinition, int>
this_param,Microsoft.Cci.IParameterDefinition
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 56305, 56332);
return 0;
}


int
f_758_56351_56370(System.Collections.Generic.List<Microsoft.Cci.IParameterDefinition>
this_param,Microsoft.Cci.IParameterDefinition
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 56351, 56370);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,56136,56386);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,56136,56386);
}
		}

static ParameterDefinitionIndex()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(758,55674,56397);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(758,55674,56397);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,55674,56397);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(758,55674,56397);

static int
f_758_55859_55868_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(758, 55788, 55935);
return return_v;
}

}
private sealed class GenericParameterIndex : DefinitionIndexBase<IGenericParameter>
{
public GenericParameterIndex(int lastRowId)
:base(f_758_56585_56594_C(lastRowId) ,ReferenceEqualityComparer.Instance)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(758,56517,56661);
DynAbs.Tracing.TraceSender.TraceExitConstructor(758,56517,56661);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,56517,56661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,56517,56661);
}
		}

public override bool TryGetValue(IGenericParameter item, out int index)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,56677,56843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,56781,56828);

return f_758_56788_56827(this.added, item, out index);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,56677,56843);

bool
f_758_56788_56827(System.Collections.Generic.Dictionary<Microsoft.Cci.IGenericParameter, int>
this_param,Microsoft.Cci.IGenericParameter
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 56788, 56827);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,56677,56843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,56677,56843);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Add(IGenericParameter item)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,56859,57106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,56931,56960);

f_758_56931_56959(f_758_56944_56958_M(!this.IsFrozen));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,56980,57007);

int 
index = f_758_56992_57006(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57025,57053);

f_758_57025_57052(                this.added, item, index);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57071,57091);

f_758_57071_57090(                this.rows, item);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,56859,57106);

bool
f_758_56944_56958_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 56944, 56958);
return return_v;
}


int
f_758_56931_56959(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 56931, 56959);
return 0;
}


int
f_758_56992_57006(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.GenericParameterIndex
this_param)
{
var return_v = this_param.NextRowId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 56992, 57006);
return return_v;
}


int
f_758_57025_57052(System.Collections.Generic.Dictionary<Microsoft.Cci.IGenericParameter, int>
this_param,Microsoft.Cci.IGenericParameter
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 57025, 57052);
return 0;
}


int
f_758_57071_57090(System.Collections.Generic.List<Microsoft.Cci.IGenericParameter>
this_param,Microsoft.Cci.IGenericParameter
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 57071, 57090);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,56859,57106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,56859,57106);
}
		}

static GenericParameterIndex()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(758,56409,57117);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(758,56409,57117);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,56409,57117);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(758,56409,57117);

static int
f_758_56585_56594_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(758, 56517, 56661);
return return_v;
}

}
private sealed class EventOrPropertyMapIndex : DefinitionIndexBase<int>
{            public delegate bool TryGetExistingIndex(int item, out int index);

private readonly TryGetExistingIndex _tryGetExistingIndex;

public EventOrPropertyMapIndex(TryGetExistingIndex tryGetExistingIndex, int lastRowId)
:base(f_758_57492_57501_C(lastRowId) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(758,57381,57593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57344,57364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57535,57578);

_tryGetExistingIndex = tryGetExistingIndex;
DynAbs.Tracing.TraceSender.TraceExitConstructor(758,57381,57593);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,57381,57593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,57381,57593);
}
		}

public override bool TryGetValue(int item, out int index)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,57609,58025);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57699,57815) || true) && (f_758_57703_57742(this.added, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,57699,57815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57784,57796);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,57699,57815);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57835,57949) || true) && (f_758_57839_57876(this, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,57835,57949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57918,57930);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,57835,57949);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57969,57979);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,57997,58010);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,57609,58025);

bool
f_758_57703_57742(System.Collections.Generic.Dictionary<int, int>
this_param,int
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 57703, 57742);
return return_v;
}


bool
f_758_57839_57876(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param,int
item,out int
index)
{
var return_v = this_param._tryGetExistingIndex( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 57839, 57876);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,57609,58025);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,57609,58025);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Add(int item)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,58041,58274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58099,58128);

f_758_58099_58127(f_758_58112_58126_M(!this.IsFrozen));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58148,58175);

int 
index = f_758_58160_58174(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58193,58221);

f_758_58193_58220(                this.added, item, index);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58239,58259);

f_758_58239_58258(                this.rows, item);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,58041,58274);

bool
f_758_58112_58126_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 58112, 58126);
return return_v;
}


int
f_758_58099_58127(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 58099, 58127);
return 0;
}


int
f_758_58160_58174(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
this_param)
{
var return_v = this_param.NextRowId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 58160, 58174);
return return_v;
}


int
f_758_58193_58220(System.Collections.Generic.Dictionary<int, int>
this_param,int
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 58193, 58220);
return 0;
}


int
f_758_58239_58258(System.Collections.Generic.List<int>
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 58239, 58258);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,58041,58274);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,58041,58274);
}
		}

static EventOrPropertyMapIndex()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(758,57129,58285);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(758,57129,58285);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,57129,58285);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(758,57129,58285);

static int
f_758_57492_57501_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(758, 57381, 57593);
return return_v;
}

}
private sealed class MethodImplIndex : DefinitionIndexBase<MethodImplKey>
{
private readonly DeltaMetadataWriter _writer;

public MethodImplIndex(DeltaMetadataWriter writer, int lastRowId)
:base(f_758_58546_58555_C(lastRowId) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(758,58456,58621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58432,58439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58589,58606);

_writer = writer;
DynAbs.Tracing.TraceSender.TraceExitConstructor(758,58456,58621);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,58456,58621);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,58456,58621);
}
		}

public override bool TryGetValue(MethodImplKey item, out int index)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,58637,59080);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58737,58853) || true) && (f_758_58741_58780(this.added, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,58737,58853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58822,58834);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,58737,58853);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58873,59004) || true) && (f_758_58877_58931(_writer, item, out index))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,58873,59004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,58973,58985);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(758,58873,59004);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59024,59034);

index = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59052,59065);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,58637,59080);

bool
f_758_58741_58780(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 58741, 58780);
return return_v;
}


bool
f_758_58877_58931(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
item,out int
index)
{
var return_v = this_param.TryGetExistingMethodImplIndex( item, out index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 58877, 58931);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,58637,59080);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,58637,59080);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void Add(MethodImplKey item)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,59096,59339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59164,59193);

f_758_59164_59192(f_758_59177_59191_M(!this.IsFrozen));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59213,59240);

int 
index = f_758_59225_59239(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59258,59286);

f_758_59258_59285(                this.added, item, index);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59304,59324);

f_758_59304_59323(                this.rows, item);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,59096,59339);

bool
f_758_59177_59191_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 59177, 59191);
return return_v;
}


int
f_758_59164_59192(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 59164, 59192);
return 0;
}


int
f_758_59225_59239(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.MethodImplIndex
this_param)
{
var return_v = this_param.NextRowId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 59225, 59239);
return return_v;
}


int
f_758_59258_59285(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 59258, 59285);
return 0;
}


int
f_758_59304_59323(System.Collections.Generic.List<Microsoft.CodeAnalysis.Emit.MethodImplKey>
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 59304, 59323);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,59096,59339);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,59096,59339);
}
		}

static MethodImplIndex()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(758,58297,59350);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(758,58297,59350);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,58297,59350);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(758,58297,59350);

static int
f_758_58546_58555_C(int
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(758, 58456, 58621);
return return_v;
}

}
private sealed class DeltaReferenceIndexer : ReferenceIndexer
{
private readonly SymbolChanges _changes;

public DeltaReferenceIndexer(DeltaMetadataWriter writer)
:base(f_758_59585_59591_C(writer) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(758,59504,59667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59479,59487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59625,59652);

_changes = writer._changes;
DynAbs.Tracing.TraceSender.TraceExitConstructor(758,59504,59667);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,59504,59667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,59504,59667);
}
		}

public override void Visit(CommonPEModuleBuilder module)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,59683,59852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59772,59837);

f_758_59772_59836(this, f_758_59778_59835(module, metadataWriter.Context));
DynAbs.Tracing.TraceSender.TraceExitMethod(758,59683,59852);

System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
f_758_59778_59835(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetTopLevelTypeDefinitions( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 59778, 59835);
return return_v;
}


int
f_758_59772_59836(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
types)
{
this_param.Visit( (System.Collections.Generic.IEnumerable<Microsoft.Cci.INamedTypeDefinition>)types);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 59772, 59836);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,59683,59852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,59683,59852);
}
		}

public override void Visit(IEventDefinition eventDefinition)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,59868,60070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,59961,60009);

f_758_59961_60008(f_758_59974_60007(this, eventDefinition));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,60027,60055);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(eventDefinition),758,60027,60054);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,59868,60070);

bool
f_758_59974_60007(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,Microsoft.Cci.IEventDefinition
def)
{
var return_v = this_param.ShouldVisit( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 59974, 60007);
return return_v;
}


int
f_758_59961_60008(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 59961, 60008);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,59868,60070);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,59868,60070);
}
		}

public override void Visit(IFieldDefinition fieldDefinition)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,60086,60288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,60179,60227);

f_758_60179_60226(f_758_60192_60225(this, fieldDefinition));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,60245,60273);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(fieldDefinition),758,60245,60272);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,60086,60288);

bool
f_758_60192_60225(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,Microsoft.Cci.IFieldDefinition
def)
{
var return_v = this_param.ShouldVisit( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 60192, 60225);
return return_v;
}


int
f_758_60179_60226(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 60179, 60226);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,60086,60288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,60086,60288);
}
		}

public override void Visit(ILocalDefinition localDefinition)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,60304,60538);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,60397,60523) || true) && (f_758_60401_60426(localDefinition)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,60397,60523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,60476,60504);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(localDefinition),758,60476,60503);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,60397,60523);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(758,60304,60538);

byte[]?
f_758_60401_60426(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.Signature ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 60401, 60426);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,60304,60538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,60304,60538);
}
		}

public override void Visit(IMethodDefinition method)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,60554,60730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,60639,60678);

f_758_60639_60677(f_758_60652_60676(this, method));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,60696,60715);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(method),758,60696,60714);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,60554,60730);

bool
f_758_60652_60676(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,Microsoft.Cci.IMethodDefinition
def)
{
var return_v = this_param.ShouldVisit( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 60652, 60676);
return return_v;
}


int
f_758_60639_60677(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 60639, 60677);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,60554,60730);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,60554,60730);
}
		}

public override void Visit(Cci.MethodImplementation methodImplementation)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,60746,61260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,60976,61078);

var 
methodDef = (IMethodDefinition)f_758_61011_61077(methodImplementation.ImplementingMethod, this.Context)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,61096,61245) || true) && (f_758_61100_61129(_changes, methodDef)== SymbolChange.Added)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,61096,61245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,61193,61226);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(methodImplementation),758,61193,61225);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,61096,61245);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(758,60746,61260);

Microsoft.Cci.IDefinition?
f_758_61011_61077(Microsoft.Cci.IMethodDefinition
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.AsDefinition( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 61011, 61077);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolChange
f_758_61100_61129(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.Cci.IMethodDefinition?
def)
{
var return_v = this_param.GetChange( (Microsoft.Cci.IDefinition?)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 61100, 61129);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,60746,61260);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,60746,61260);
}
		}

public override void Visit(INamespaceTypeDefinition namespaceTypeDefinition)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,61276,61510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,61385,61441);

f_758_61385_61440(f_758_61398_61439(this, namespaceTypeDefinition));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,61459,61495);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(namespaceTypeDefinition),758,61459,61494);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,61276,61510);

bool
f_758_61398_61439(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,Microsoft.Cci.INamespaceTypeDefinition
def)
{
var return_v = this_param.ShouldVisit( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 61398, 61439);
return return_v;
}


int
f_758_61385_61440(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 61385, 61440);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,61276,61510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,61276,61510);
}
		}

public override void Visit(INestedTypeDefinition nestedTypeDefinition)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,61526,61748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,61629,61682);

f_758_61629_61681(f_758_61642_61680(this, nestedTypeDefinition));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,61700,61733);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(nestedTypeDefinition),758,61700,61732);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,61526,61748);

bool
f_758_61642_61680(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,Microsoft.Cci.INestedTypeDefinition
def)
{
var return_v = this_param.ShouldVisit( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 61642, 61680);
return return_v;
}


int
f_758_61629_61681(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 61629, 61681);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,61526,61748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,61526,61748);
}
		}

public override void Visit(IPropertyDefinition propertyDefinition)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,61764,61978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,61863,61914);

f_758_61863_61913(f_758_61876_61912(this, propertyDefinition));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,61932,61963);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(propertyDefinition),758,61932,61962);
DynAbs.Tracing.TraceSender.TraceExitMethod(758,61764,61978);

bool
f_758_61876_61912(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,Microsoft.Cci.IPropertyDefinition
def)
{
var return_v = this_param.ShouldVisit( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 61876, 61912);
return return_v;
}


int
f_758_61863_61913(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 61863, 61913);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,61764,61978);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,61764,61978);
}
		}

public override void Visit(ITypeDefinition typeDefinition)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,61994,62224);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,62085,62209) || true) && (f_758_62089_62121(this, typeDefinition))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,62085,62209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,62163,62190);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(typeDefinition),758,62163,62189);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,62085,62209);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(758,61994,62224);

bool
f_758_62089_62121(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,Microsoft.Cci.ITypeDefinition
def)
{
var return_v = this_param.ShouldVisit( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 62089, 62121);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,61994,62224);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,61994,62224);
}
		}

public override void Visit(ITypeDefinitionMember typeMember)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,62240,62464);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,62333,62449) || true) && (f_758_62337_62365(this, typeMember))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(758,62333,62449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,62407,62430);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(typeMember),758,62407,62429);
DynAbs.Tracing.TraceSender.TraceExitCondition(758,62333,62449);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(758,62240,62464);

bool
f_758_62337_62365(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DeltaReferenceIndexer
this_param,Microsoft.Cci.ITypeDefinitionMember
def)
{
var return_v = this_param.ShouldVisit( (Microsoft.Cci.IDefinition)def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 62337, 62365);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,62240,62464);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,62240,62464);
}
		}

private bool ShouldVisit(IDefinition def)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(758,62480,62621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(758,62554,62606);

return f_758_62561_62584(_changes, def)!= SymbolChange.None;
DynAbs.Tracing.TraceSender.TraceExitMethod(758,62480,62621);

Microsoft.CodeAnalysis.Emit.SymbolChange
f_758_62561_62584(Microsoft.CodeAnalysis.Emit.SymbolChanges
this_param,Microsoft.Cci.IDefinition
def)
{
var return_v = this_param.GetChange( def);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 62561, 62584);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(758,62480,62621);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,62480,62621);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static DeltaReferenceIndexer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(758,59362,62632);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(758,59362,62632);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,59362,62632);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(758,59362,62632);

static Microsoft.Cci.MetadataWriter
f_758_59585_59591_C(Microsoft.Cci.MetadataWriter
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(758, 59504, 59667);
return return_v;
}

}

static DeltaMetadataWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(758,676,62639);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(758,676,62639);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(758,676,62639);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(758,676,62639);

static System.Reflection.Metadata.Ecma335.MetadataBuilder
f_758_2808_2845(Microsoft.CodeAnalysis.Emit.EmitBaseline
previousGeneration)
{
var return_v = MakeTablesBuilder( previousGeneration);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 2808, 2845);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DebugInformationFormat
f_758_2886_2923(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param)
{
var return_v = this_param.DebugInformationFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 2886, 2923);
return return_v;
}


static System.Reflection.Metadata.Ecma335.MetadataBuilder
f_758_2965_2986()
{
var return_v = new System.Reflection.Metadata.Ecma335.MetadataBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 2965, 2986);
return return_v;
}


static int
f_758_3357_3397(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 3357, 3397);
return 0;
}


static int
f_758_3412_3448(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 3412, 3448);
return 0;
}


static int
f_758_3463_3510(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 3463, 3510);
return 0;
}


static Microsoft.CodeAnalysis.Emit.DebugInformationFormat
f_758_3538_3575(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param)
{
var return_v = this_param.DebugInformationFormat ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 3538, 3575);
return return_v;
}


static int
f_758_3525_3611(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 3525, 3611);
return 0;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>
f_758_3862_3963(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>.TryGetExistingIndex
tryGetExistingIndex,int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.ITypeDefinition>( tryGetExistingIndex, lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 3862, 3963);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>
f_758_3991_4092(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>.TryGetExistingIndex
tryGetExistingIndex,int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IEventDefinition>( tryGetExistingIndex, lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 3991, 4092);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>
f_758_4120_4221(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>.TryGetExistingIndex
tryGetExistingIndex,int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IFieldDefinition>( tryGetExistingIndex, lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 4120, 4221);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
f_758_4250_4357(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>.TryGetExistingIndex
tryGetExistingIndex,int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>( tryGetExistingIndex, lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 4250, 4357);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>
f_758_4388_4498(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>.TryGetExistingIndex
tryGetExistingIndex,int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IPropertyDefinition>( tryGetExistingIndex, lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 4388, 4498);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.ParameterDefinitionIndex
f_758_4530_4588(int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.ParameterDefinitionIndex( lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 4530, 4588);
return return_v;
}


static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.Cci.IMethodDefinition, Microsoft.Cci.IParameterDefinition>>
f_758_4623_4688()
{
var return_v = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Microsoft.Cci.IMethodDefinition, Microsoft.Cci.IParameterDefinition>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 4623, 4688);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.GenericParameterIndex
f_758_4724_4786(int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.GenericParameterIndex( lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 4724, 4786);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
f_758_4813_4907(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex.TryGetExistingIndex
tryGetExistingIndex,int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex( tryGetExistingIndex, lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 4813, 4907);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex
f_758_4937_5037(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex.TryGetExistingIndex
tryGetExistingIndex,int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.EventOrPropertyMapIndex( tryGetExistingIndex, lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 4937, 5037);
return return_v;
}


static Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.MethodImplIndex
f_758_5067_5127(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer,int
lastRowId)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.MethodImplIndex( writer, lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5067, 5127);
return return_v;
}


static Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>
f_758_5164_5259(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer,int
lastRowId)
{
var return_v = new Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<Microsoft.CodeAnalysis.AssemblyIdentity>( (Microsoft.Cci.MetadataWriter)writer, lastRowId: lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5164, 5259);
return return_v;
}


static Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>
f_758_5292_5375(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer,int
lastRowId)
{
var return_v = new Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<string>( (Microsoft.Cci.MetadataWriter)writer, lastRowId: lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5292, 5375);
return return_v;
}


static Microsoft.Cci.MemberRefComparer
f_758_5476_5503(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
metadataWriter)
{
var return_v = new Microsoft.Cci.MemberRefComparer( (Microsoft.Cci.MetadataWriter)metadataWriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5476, 5503);
return return_v;
}


static Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>
f_758_5408_5549(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer,Microsoft.Cci.MemberRefComparer
structuralComparer,int
lastRowId)
{
var return_v = new Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeMemberReference>( (Microsoft.Cci.MetadataWriter)writer, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeMemberReference>)structuralComparer, lastRowId: lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5408, 5549);
return return_v;
}


static Microsoft.Cci.MethodSpecComparer
f_758_5662_5690(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
metadataWriter)
{
var return_v = new Microsoft.Cci.MethodSpecComparer( (Microsoft.Cci.MetadataWriter)metadataWriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5662, 5690);
return return_v;
}


static Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>
f_758_5583_5737(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer,Microsoft.Cci.MethodSpecComparer
structuralComparer,int
lastRowId)
{
var return_v = new Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.IGenericMethodInstanceReference>( (Microsoft.Cci.MetadataWriter)writer, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IGenericMethodInstanceReference>)structuralComparer, lastRowId: lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5583, 5737);
return return_v;
}


static Microsoft.Cci.MetadataWriter.TypeReferenceIndex
f_758_5768_5839(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer,int
lastRowId)
{
var return_v = new Microsoft.Cci.MetadataWriter.TypeReferenceIndex( (Microsoft.Cci.MetadataWriter)writer, lastRowId: lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5768, 5839);
return return_v;
}


static Microsoft.Cci.TypeSpecComparer
f_758_5933_5959(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
metadataWriter)
{
var return_v = new Microsoft.Cci.TypeSpecComparer( (Microsoft.Cci.MetadataWriter)metadataWriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5933, 5959);
return return_v;
}


static Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>
f_758_5871_6004(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer,Microsoft.Cci.TypeSpecComparer
structuralComparer,int
lastRowId)
{
var return_v = new Microsoft.Cci.MetadataWriter.InstanceAndStructuralReferenceIndex<Microsoft.Cci.ITypeReference>( (Microsoft.Cci.MetadataWriter)writer, (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeReference>)structuralComparer, lastRowId: lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 5871, 6004);
return return_v;
}


static Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>
f_758_6047_6138(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter
writer,int
lastRowId)
{
var return_v = new Microsoft.Cci.MetadataWriter.HeapOrReferenceIndex<System.Reflection.Metadata.BlobHandle>( (Microsoft.Cci.MetadataWriter)writer, lastRowId: lastRowId);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 6047, 6138);
return return_v;
}


static System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
f_758_6180_6286(Microsoft.Cci.SymbolEquivalentEqualityComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>( (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IMethodDefinition>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(758, 6180, 6286);
return return_v;
}


static System.Reflection.Metadata.Ecma335.MetadataBuilder
f_758_2798_2845_C(System.Reflection.Metadata.Ecma335.MetadataBuilder
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(758, 2465, 6298);
return return_v;
}


int
f_758_19898_19919(Microsoft.CodeAnalysis.Emit.DeltaMetadataWriter.DefinitionIndex<Microsoft.Cci.IMethodDefinition>
this_param)
{
var return_v = this_param.NextRowId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(758, 19898, 19919);
return return_v;
}

}
}
