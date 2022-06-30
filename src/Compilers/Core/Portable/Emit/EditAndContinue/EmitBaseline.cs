// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit
{

internal struct MethodImplKey : IEquatable<MethodImplKey>
    {

internal MethodImplKey(int implementingMethod, int index)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(759,1208,1468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,1290,1327);

f_759_1290_1326(implementingMethod > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,1341,1365);

f_759_1341_1364(index > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,1379,1424);

this.ImplementingMethod = implementingMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,1438,1457);

this.Index = index;
DynAbs.Tracing.TraceSender.TraceExitConstructor(759,1208,1468);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,1208,1468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,1208,1468);
}
		}

internal readonly int ImplementingMethod;

internal readonly int Index;

public override bool Equals(object? obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(759,1571,1705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,1636,1694);

return obj is MethodImplKey &&(DynAbs.Tracing.TraceSender.Expression_True(759, 1643, 1693)&&Equals(obj));
DynAbs.Tracing.TraceSender.TraceExitMethod(759,1571,1705);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,1571,1705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,1571,1705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool Equals(MethodImplKey other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(759,1717,1897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,1781,1886);

return this.ImplementingMethod == other.ImplementingMethod &&(DynAbs.Tracing.TraceSender.Expression_True(759, 1788, 1885)&&                this.Index == other.Index);
DynAbs.Tracing.TraceSender.TraceExitMethod(759,1717,1897);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,1717,1897);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,1717,1897);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(759,1909,2035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,1967,2024);

return f_759_1974_2023(this.ImplementingMethod, this.Index);
DynAbs.Tracing.TraceSender.TraceExitMethod(759,1909,2035);

int
f_759_1974_2023(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 1974, 2023);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,1909,2035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,1909,2035);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static MethodImplKey(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(759,1134,2042);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(759,1134,2042);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,1134,2042);
}

static int
f_759_1290_1326(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 1290, 1326);
return 0;
}


static int
f_759_1341_1364(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 1341, 1364);
return 0;
}

    }
public sealed class EmitBaseline
{
private static readonly ImmutableArray<int> s_emptyTableSizes ;
internal sealed class MetadataSymbols
{
public readonly IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> AnonymousTypes;

public readonly ImmutableDictionary<AssemblyIdentity, AssemblyIdentity> AssemblyReferenceIdentityMap;

public readonly object MetadataDecoder;

public MetadataSymbols(IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> anonymousTypes, object metadataDecoder, ImmutableDictionary<AssemblyIdentity, AssemblyIdentity> assemblyReferenceIdentityMap)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(759,3020,3633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,2554,2568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,2920,2948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,2988,3003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,3259,3296);

f_759_3259_3295(anonymousTypes != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,3314,3352);

f_759_3314_3351(metadataDecoder != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,3370,3421);

f_759_3370_3420(assemblyReferenceIdentityMap != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,3441,3478);

this.AnonymousTypes = anonymousTypes;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,3496,3535);

this.MetadataDecoder = metadataDecoder;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,3553,3618);

this.AssemblyReferenceIdentityMap = assemblyReferenceIdentityMap;
DynAbs.Tracing.TraceSender.TraceExitConstructor(759,3020,3633);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,3020,3633);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,3020,3633);
}
		}

static MetadataSymbols()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(759,2418,3644);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(759,2418,3644);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,2418,3644);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(759,2418,3644);

static int
f_759_3259_3295(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 3259, 3295);
return 0;
}


static int
f_759_3314_3351(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 3314, 3351);
return 0;
}


static int
f_759_3370_3420(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 3370, 3420);
return 0;
}

}

public static EmitBaseline CreateInitialBaseline(ModuleMetadata module, Func<MethodDefinitionHandle, EditAndContinueMethodDebugInformation> debugInformationProvider)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(759,5135,6371);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,5325,5440) || true) && (module == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,5325,5440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,5377,5425);

throw f_759_5383_5424(nameof(module));
DynAbs.Tracing.TraceSender.TraceExitCondition(759,5325,5440);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,5456,5616) || true) && (f_759_5460_5480_M(!f_759_5461_5474(module).HasIL))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,5456,5616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,5514,5601);

throw f_759_5520_5600(f_759_5542_5583(), nameof(module));
DynAbs.Tracing.TraceSender.TraceExitCondition(759,5456,5616);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,5632,5739);

var 
hasPortablePdb = f_759_5653_5699(f_759_5653_5678(f_759_5653_5666(module))).Any(entry => entry.IsPortableCodeView)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,5755,6247);

var 
localSigProvider = new Func<MethodDefinitionHandle, StandaloneSignatureHandle>(methodHandle =>
            {
                try
                {
                    return module.Module.GetMethodBodyOrThrow(methodHandle)?.LocalSignature ?? default;
                }
                catch (Exception e) when (e is BadImageFormatException || e is IOException)
                {
                    throw new InvalidDataException(e.Message, e);
                }
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,6263,6360);

return f_759_6270_6359(module, debugInformationProvider, localSigProvider, hasPortablePdb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(759,5135,6371);

System.ArgumentNullException
f_759_5383_5424(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 5383, 5424);
return return_v;
}


Microsoft.CodeAnalysis.PEModule
f_759_5461_5474(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 5461, 5474);
return return_v;
}


bool
f_759_5460_5480_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 5460, 5480);
return return_v;
}


string
f_759_5542_5583()
{
var return_v = CodeAnalysisResources.PEImageNotAvailable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 5542, 5583);
return return_v;
}


System.ArgumentException
f_759_5520_5600(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 5520, 5600);
return return_v;
}


Microsoft.CodeAnalysis.PEModule
f_759_5653_5666(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 5653, 5666);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_759_5653_5678(Microsoft.CodeAnalysis.PEModule
this_param)
{
var return_v = this_param.PEReaderOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 5653, 5678);
return return_v;
}


System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.DebugDirectoryEntry>
f_759_5653_5699(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.ReadDebugDirectory();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 5653, 5699);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_759_6270_6359(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, System.Reflection.Metadata.StandaloneSignatureHandle>
localSignatureProvider,bool
hasPortableDebugInformation)
{
var return_v = CreateInitialBaseline( module, debugInformationProvider, localSignatureProvider, hasPortableDebugInformation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 6270, 6359);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,5135,6371);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,5135,6371);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static EmitBaseline CreateInitialBaseline(
            ModuleMetadata module,
            Func<MethodDefinitionHandle, EditAndContinueMethodDebugInformation> debugInformationProvider,
            Func<MethodDefinitionHandle, StandaloneSignatureHandle> localSignatureProvider,
            bool hasPortableDebugInformation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(759,10105,12734);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,10462,10577) || true) && (module == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,10462,10577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,10514,10562);

throw f_759_10520_10561(nameof(module));
DynAbs.Tracing.TraceSender.TraceExitCondition(759,10462,10577);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,10593,10744) || true) && (debugInformationProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,10593,10744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,10663,10729);

throw f_759_10669_10728(nameof(debugInformationProvider));
DynAbs.Tracing.TraceSender.TraceExitCondition(759,10593,10744);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,10760,10907) || true) && (localSignatureProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,10760,10907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,10828,10892);

throw f_759_10834_10891(nameof(localSignatureProvider));
DynAbs.Tracing.TraceSender.TraceExitCondition(759,10760,10907);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,10923,10958);

var 
reader = f_759_10936_10957(module)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,10974,12723);

return f_759_10981_12722(null, module, compilation: null, moduleBuilder: null, moduleVersionId: f_759_11155_11182(module), ordinal: 0, encId: default, hasPortablePdb: hasPortableDebugInformation, typesAdded: f_759_11337_11379(), eventsAdded: f_759_11411_11454(), fieldsAdded: f_759_11486_11529(), methodsAdded: f_759_11562_11606(), propertiesAdded: f_759_11642_11688(), eventMapAdded: f_759_11722_11748(), propertyMapAdded: f_759_11785_11811(), methodImplsAdded: f_759_11848_11884(), tableEntriesAdded: s_emptyTableSizes, blobStreamLengthAdded: 0, stringStreamLengthAdded: 0, userStringStreamLengthAdded: 0, guidStreamLengthAdded: 0, anonymousTypeMap: null, synthesizedMembers: ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>>.Empty, methodsAddedOrChanged: f_759_12346_12393(), debugInformationProvider: debugInformationProvider, localSignatureProvider: localSignatureProvider, typeToEventMap: f_759_12562_12591(reader), typeToPropertyMap: f_759_12629_12661(reader), methodImpls: f_759_12693_12721(reader));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(759,10105,12734);

System.ArgumentNullException
f_759_10520_10561(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 10520, 10561);
return return_v;
}


System.ArgumentNullException
f_759_10669_10728(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 10669, 10728);
return return_v;
}


System.ArgumentNullException
f_759_10834_10891(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 10834, 10891);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_759_10936_10957(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 10936, 10957);
return return_v;
}


System.Guid
f_759_11155_11182(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.GetModuleVersionId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11155, 11182);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>
f_759_11337_11379()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11337, 11379);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.Cci.IEventDefinition, int>
f_759_11411_11454()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.IEventDefinition, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11411, 11454);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.Cci.IFieldDefinition, int>
f_759_11486_11529()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.IFieldDefinition, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11486, 11529);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, int>
f_759_11562_11606()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11562, 11606);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.Cci.IPropertyDefinition, int>
f_759_11642_11688()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.IPropertyDefinition, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11642, 11688);
return return_v;
}


System.Collections.Generic.Dictionary<int, int>
f_759_11722_11748()
{
var return_v = new System.Collections.Generic.Dictionary<int, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11722, 11748);
return return_v;
}


System.Collections.Generic.Dictionary<int, int>
f_759_11785_11811()
{
var return_v = new System.Collections.Generic.Dictionary<int, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11785, 11811);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
f_759_11848_11884()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 11848, 11884);
return return_v;
}


System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
f_759_12346_12393()
{
var return_v = new System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 12346, 12393);
return return_v;
}


System.Collections.Generic.Dictionary<int, int>
f_759_12562_12591(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = CalculateTypeEventMap( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 12562, 12591);
return return_v;
}


System.Collections.Generic.Dictionary<int, int>
f_759_12629_12661(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = CalculateTypePropertyMap( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 12629, 12661);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
f_759_12693_12721(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = CalculateMethodImpls( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 12693, 12721);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_759_10981_12722(Microsoft.CodeAnalysis.Emit.EmitBaseline?
initialBaseline,Microsoft.CodeAnalysis.ModuleMetadata
module,Microsoft.CodeAnalysis.Compilation?
compilation,Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?
moduleBuilder,System.Guid
moduleVersionId,int
ordinal,System.Guid
encId,bool
hasPortablePdb,System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeDefinition, int>
typesAdded,System.Collections.Generic.Dictionary<Microsoft.Cci.IEventDefinition, int>
eventsAdded,System.Collections.Generic.Dictionary<Microsoft.Cci.IFieldDefinition, int>
fieldsAdded,System.Collections.Generic.Dictionary<Microsoft.Cci.IMethodDefinition, int>
methodsAdded,System.Collections.Generic.Dictionary<Microsoft.Cci.IPropertyDefinition, int>
propertiesAdded,System.Collections.Generic.Dictionary<int, int>
eventMapAdded,System.Collections.Generic.Dictionary<int, int>
propertyMapAdded,System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
methodImplsAdded,System.Collections.Immutable.ImmutableArray<int>
tableEntriesAdded,int
blobStreamLengthAdded,int
stringStreamLengthAdded,int
userStringStreamLengthAdded,int
guidStreamLengthAdded,System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>?
anonymousTypeMap,System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
synthesizedMembers,System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
methodsAddedOrChanged,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, System.Reflection.Metadata.StandaloneSignatureHandle>
localSignatureProvider,System.Collections.Generic.Dictionary<int, int>
typeToEventMap,System.Collections.Generic.Dictionary<int, int>
typeToPropertyMap,System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
methodImpls)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EmitBaseline( initialBaseline, module, compilation: compilation, moduleBuilder: moduleBuilder, moduleVersionId: moduleVersionId, ordinal: ordinal, encId: encId, hasPortablePdb: hasPortablePdb, typesAdded: (System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>)typesAdded, eventsAdded: (System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>)eventsAdded, fieldsAdded: (System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>)fieldsAdded, methodsAdded: (System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>)methodsAdded, propertiesAdded: (System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>)propertiesAdded, eventMapAdded: (System.Collections.Generic.IReadOnlyDictionary<int, int>)eventMapAdded, propertyMapAdded: (System.Collections.Generic.IReadOnlyDictionary<int, int>)propertyMapAdded, methodImplsAdded: (System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>)methodImplsAdded, tableEntriesAdded: tableEntriesAdded, blobStreamLengthAdded: blobStreamLengthAdded, stringStreamLengthAdded: stringStreamLengthAdded, userStringStreamLengthAdded: userStringStreamLengthAdded, guidStreamLengthAdded: guidStreamLengthAdded, anonymousTypeMap: anonymousTypeMap, synthesizedMembers: synthesizedMembers, methodsAddedOrChanged: (System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>)methodsAddedOrChanged, debugInformationProvider: debugInformationProvider, localSignatureProvider: localSignatureProvider, typeToEventMap: (System.Collections.Generic.IReadOnlyDictionary<int, int>)typeToEventMap, typeToPropertyMap: (System.Collections.Generic.IReadOnlyDictionary<int, int>)typeToPropertyMap, methodImpls: (System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>)methodImpls);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 10981, 12722);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,10105,12734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,10105,12734);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal EmitBaseline InitialBaseline {get; }

public ModuleMetadata OriginalMetadata {get; }

internal MetadataSymbols? LazyMetadataSymbols;

internal readonly Compilation? Compilation;

internal readonly CommonPEModuleBuilder? PEModuleBuilder;

internal readonly Guid ModuleVersionId;

internal readonly bool HasPortablePdb;

internal readonly int Ordinal;

internal readonly Guid EncId;

internal readonly IReadOnlyDictionary<Cci.ITypeDefinition, int> TypesAdded;

internal readonly IReadOnlyDictionary<Cci.IEventDefinition, int> EventsAdded;

internal readonly IReadOnlyDictionary<Cci.IFieldDefinition, int> FieldsAdded;

internal readonly IReadOnlyDictionary<Cci.IMethodDefinition, int> MethodsAdded;

internal readonly IReadOnlyDictionary<Cci.IPropertyDefinition, int> PropertiesAdded;

internal readonly IReadOnlyDictionary<int, int> EventMapAdded;

internal readonly IReadOnlyDictionary<int, int> PropertyMapAdded;

internal readonly IReadOnlyDictionary<MethodImplKey, int> MethodImplsAdded;

internal readonly ImmutableArray<int> TableEntriesAdded;

internal readonly int BlobStreamLengthAdded;

internal readonly int StringStreamLengthAdded;

internal readonly int UserStringStreamLengthAdded;

internal readonly int GuidStreamLengthAdded;

internal readonly IReadOnlyDictionary<int, AddedOrChangedMethodInfo> AddedOrChangedMethods;

internal readonly Func<MethodDefinitionHandle, EditAndContinueMethodDebugInformation> DebugInformationProvider;

internal readonly Func<MethodDefinitionHandle, StandaloneSignatureHandle> LocalSignatureProvider;

internal readonly ImmutableArray<int> TableSizes;

internal readonly IReadOnlyDictionary<int, int> TypeToEventMap;

internal readonly IReadOnlyDictionary<int, int> TypeToPropertyMap;

internal readonly IReadOnlyDictionary<MethodImplKey, int> MethodImpls;

private readonly IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue>? _anonymousTypeMap;

internal readonly ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> SynthesizedMembers;

private EmitBaseline(
            EmitBaseline? initialBaseline,
            ModuleMetadata module,
            Compilation? compilation,
            CommonPEModuleBuilder? moduleBuilder,
            Guid moduleVersionId,
            int ordinal,
            Guid encId,
            bool hasPortablePdb,
            IReadOnlyDictionary<Cci.ITypeDefinition, int> typesAdded,
            IReadOnlyDictionary<Cci.IEventDefinition, int> eventsAdded,
            IReadOnlyDictionary<Cci.IFieldDefinition, int> fieldsAdded,
            IReadOnlyDictionary<Cci.IMethodDefinition, int> methodsAdded,
            IReadOnlyDictionary<Cci.IPropertyDefinition, int> propertiesAdded,
            IReadOnlyDictionary<int, int> eventMapAdded,
            IReadOnlyDictionary<int, int> propertyMapAdded,
            IReadOnlyDictionary<MethodImplKey, int> methodImplsAdded,
            ImmutableArray<int> tableEntriesAdded,
            int blobStreamLengthAdded,
            int stringStreamLengthAdded,
            int userStringStreamLengthAdded,
            int guidStreamLengthAdded,
            IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue>? anonymousTypeMap,
            ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> synthesizedMembers,
            IReadOnlyDictionary<int, AddedOrChangedMethodInfo> methodsAddedOrChanged,
            Func<MethodDefinitionHandle, EditAndContinueMethodDebugInformation> debugInformationProvider,
            Func<MethodDefinitionHandle, StandaloneSignatureHandle> localSignatureProvider,
            IReadOnlyDictionary<int, int> typeToEventMap,
            IReadOnlyDictionary<int, int> typeToPropertyMap,
            IReadOnlyDictionary<MethodImplKey, int> methodImpls)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(759,16915,22085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,12746,12792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,12901,12948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,13122,13141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,13185,13196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,13248,13263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,13346,13360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,13544,13551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,13805,13815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,13891,13902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,13978,13989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14066,14078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14157,14172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14231,14244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14303,14319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14388,14404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14507,14528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14561,14584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14617,14644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14677,14698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,14938,14959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,15664,15688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,16369,16391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,16511,16525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,16584,16601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,16670,16681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,16768,16785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,16884,16902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,18700,18729);

f_759_18700_18728(module != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,18743,18794);

f_759_18743_18793((ordinal == 0) == (encId == default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,18808,18866);

f_759_18808_18865((ordinal == 0) == (initialBaseline == null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,18880,18939);

f_759_18880_18938((ordinal == 0) == (anonymousTypeMap == null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,18953,19004);

f_759_18953_19003(encId != f_759_18975_19002(module));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19018,19065);

f_759_19018_19064(debugInformationProvider != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19079,19124);

f_759_19079_19123(localSignatureProvider != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19138,19175);

f_759_19138_19174(typeToEventMap != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19189,19229);

f_759_19189_19228(typeToPropertyMap != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19243,19284);

f_759_19243_19283(moduleVersionId != default);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19298,19359);

f_759_19298_19358(moduleVersionId == f_759_19330_19357(module));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19373,19414);

f_759_19373_19413(synthesizedMembers != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19430,19498);

f_759_19430_19497(tableEntriesAdded.Length == MetadataTokens.TableCount);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19864,19941);

f_759_19864_19940(tableEntriesAdded[(int)TableIndex.TypeDef] >= f_759_19923_19939(typesAdded));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,19955,20031);

f_759_19955_20030(tableEntriesAdded[(int)TableIndex.Event] >= f_759_20012_20029(eventsAdded));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20045,20121);

f_759_20045_20120(tableEntriesAdded[(int)TableIndex.Field] >= f_759_20102_20119(fieldsAdded));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20135,20216);

f_759_20135_20215(tableEntriesAdded[(int)TableIndex.MethodDef] >= f_759_20196_20214(methodsAdded));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20230,20313);

f_759_20230_20312(tableEntriesAdded[(int)TableIndex.Property] >= f_759_20290_20311(propertiesAdded));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20327,20408);

f_759_20327_20407(tableEntriesAdded[(int)TableIndex.EventMap] >= f_759_20387_20406(eventMapAdded));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20422,20509);

f_759_20422_20508(tableEntriesAdded[(int)TableIndex.PropertyMap] >= f_759_20485_20507(propertyMapAdded));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20525,20567);

var 
reader = f_759_20538_20566(f_759_20538_20551(module))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20583,20625);

InitialBaseline = initialBaseline ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Emit.EmitBaseline?>(759, 20601, 20624)??this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20639,20665);

OriginalMetadata = module;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20679,20705);

Compilation = compilation;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20719,20751);

PEModuleBuilder = moduleBuilder;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20765,20799);

ModuleVersionId = moduleVersionId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20813,20831);

Ordinal = ordinal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20845,20859);

EncId = encId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20873,20905);

HasPortablePdb = hasPortablePdb;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20921,20945);

TypesAdded = typesAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20959,20985);

EventsAdded = eventsAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,20999,21025);

FieldsAdded = fieldsAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21039,21067);

MethodsAdded = methodsAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21081,21115);

PropertiesAdded = propertiesAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21129,21159);

EventMapAdded = eventMapAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21173,21209);

PropertyMapAdded = propertyMapAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21223,21259);

MethodImplsAdded = methodImplsAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21273,21311);

TableEntriesAdded = tableEntriesAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21325,21371);

BlobStreamLengthAdded = blobStreamLengthAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21385,21435);

StringStreamLengthAdded = stringStreamLengthAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21449,21507);

UserStringStreamLengthAdded = userStringStreamLengthAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21521,21567);

GuidStreamLengthAdded = guidStreamLengthAdded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21581,21618);

_anonymousTypeMap = anonymousTypeMap;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21632,21672);

SynthesizedMembers = synthesizedMembers;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21686,21732);

AddedOrChangedMethods = methodsAddedOrChanged;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21748,21800);

DebugInformationProvider = debugInformationProvider;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21814,21862);

LocalSignatureProvider = localSignatureProvider;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21876,21936);

TableSizes = f_759_21889_21935(reader, TableEntriesAdded);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21950,21982);

TypeToEventMap = typeToEventMap;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,21996,22034);

TypeToPropertyMap = typeToPropertyMap;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,22048,22074);

MethodImpls = methodImpls;
DynAbs.Tracing.TraceSender.TraceExitConstructor(759,16915,22085);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,16915,22085);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,16915,22085);
}
		}

internal EmitBaseline With(
            Compilation compilation,
            CommonPEModuleBuilder moduleBuilder,
            int ordinal,
            Guid encId,
            IReadOnlyDictionary<Cci.ITypeDefinition, int> typesAdded,
            IReadOnlyDictionary<Cci.IEventDefinition, int> eventsAdded,
            IReadOnlyDictionary<Cci.IFieldDefinition, int> fieldsAdded,
            IReadOnlyDictionary<Cci.IMethodDefinition, int> methodsAdded,
            IReadOnlyDictionary<Cci.IPropertyDefinition, int> propertiesAdded,
            IReadOnlyDictionary<int, int> eventMapAdded,
            IReadOnlyDictionary<int, int> propertyMapAdded,
            IReadOnlyDictionary<MethodImplKey, int> methodImplsAdded,
            ImmutableArray<int> tableEntriesAdded,
            int blobStreamLengthAdded,
            int stringStreamLengthAdded,
            int userStringStreamLengthAdded,
            int guidStreamLengthAdded,
            IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> anonymousTypeMap,
            ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> synthesizedMembers,
            IReadOnlyDictionary<int, AddedOrChangedMethodInfo> addedOrChangedMethods,
            Func<MethodDefinitionHandle, EditAndContinueMethodDebugInformation> debugInformationProvider,
            Func<MethodDefinitionHandle, StandaloneSignatureHandle> localSignatureProvider)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(759,22097,25038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,23549,23617);

f_759_23549_23616(_anonymousTypeMap == null ||(DynAbs.Tracing.TraceSender.Expression_False(759, 23562, 23615)||anonymousTypeMap != null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,23631,23724);

f_759_23631_23723(_anonymousTypeMap == null ||(DynAbs.Tracing.TraceSender.Expression_False(759, 23644, 23722)||f_759_23673_23695(anonymousTypeMap)>= f_759_23699_23722(_anonymousTypeMap)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,23740,25027);

return f_759_23747_25026(f_759_23782_23797(), f_759_23816_23832(), compilation, moduleBuilder, ModuleVersionId, ordinal, encId, HasPortablePdb, typesAdded, eventsAdded, fieldsAdded, methodsAdded, propertiesAdded, eventMapAdded, propertyMapAdded, methodImplsAdded, tableEntriesAdded, blobStreamLengthAdded: blobStreamLengthAdded, stringStreamLengthAdded: stringStreamLengthAdded, userStringStreamLengthAdded: userStringStreamLengthAdded, guidStreamLengthAdded: guidStreamLengthAdded, anonymousTypeMap: anonymousTypeMap, synthesizedMembers: synthesizedMembers, methodsAddedOrChanged: addedOrChangedMethods, debugInformationProvider: debugInformationProvider, localSignatureProvider: localSignatureProvider, typeToEventMap: TypeToEventMap, typeToPropertyMap: TypeToPropertyMap, methodImpls: MethodImpls);
DynAbs.Tracing.TraceSender.TraceExitMethod(759,22097,25038);

int
f_759_23549_23616(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 23549, 23616);
return 0;
}


int
f_759_23673_23695(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 23673, 23695);
return return_v;
}


int
f_759_23699_23722(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 23699, 23722);
return return_v;
}


int
f_759_23631_23723(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 23631, 23723);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_759_23782_23797()
{
var return_v = InitialBaseline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 23782, 23797);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_759_23816_23832()
{
var return_v = OriginalMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 23816, 23832);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_759_23747_25026(Microsoft.CodeAnalysis.Emit.EmitBaseline
initialBaseline,Microsoft.CodeAnalysis.ModuleMetadata
module,Microsoft.CodeAnalysis.Compilation
compilation,Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
moduleBuilder,System.Guid
moduleVersionId,int
ordinal,System.Guid
encId,bool
hasPortablePdb,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
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
methodsAddedOrChanged,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, System.Reflection.Metadata.StandaloneSignatureHandle>
localSignatureProvider,System.Collections.Generic.IReadOnlyDictionary<int, int>
typeToEventMap,System.Collections.Generic.IReadOnlyDictionary<int, int>
typeToPropertyMap,System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
methodImpls)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EmitBaseline( initialBaseline, module, compilation, moduleBuilder, moduleVersionId, ordinal, encId, hasPortablePdb, typesAdded, eventsAdded, fieldsAdded, methodsAdded, propertiesAdded, eventMapAdded, propertyMapAdded, methodImplsAdded, tableEntriesAdded, blobStreamLengthAdded: blobStreamLengthAdded, stringStreamLengthAdded: stringStreamLengthAdded, userStringStreamLengthAdded: userStringStreamLengthAdded, guidStreamLengthAdded: guidStreamLengthAdded, anonymousTypeMap: anonymousTypeMap, synthesizedMembers: synthesizedMembers, methodsAddedOrChanged: methodsAddedOrChanged, debugInformationProvider: debugInformationProvider, localSignatureProvider: localSignatureProvider, typeToEventMap: typeToEventMap, typeToPropertyMap: typeToPropertyMap, methodImpls: methodImpls);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 23747, 25026);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,22097,25038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,22097,25038);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> AnonymousTypeMap
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(759,25158,25496);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,25194,25359) || true) && (Ordinal > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,25194,25359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,25251,25293);

f_759_25251_25292(_anonymousTypeMap is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,25315,25340);

return _anonymousTypeMap;
DynAbs.Tracing.TraceSender.TraceExitCondition(759,25194,25359);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,25379,25421);

f_759_25379_25420(LazyMetadataSymbols != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,25439,25481);

return LazyMetadataSymbols.AnonymousTypes;
DynAbs.Tracing.TraceSender.TraceExitMethod(759,25158,25496);

int
f_759_25251_25292(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 25251, 25292);
return 0;
}


int
f_759_25379_25420(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 25379, 25420);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,25050,25507);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,25050,25507);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal MetadataReader MetadataReader
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(759,25582,25634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,25588,25632);

return f_759_25595_25631(f_759_25595_25616(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(759,25582,25634);

Microsoft.CodeAnalysis.ModuleMetadata
f_759_25595_25616(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.OriginalMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 25595, 25616);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_759_25595_25631(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 25595, 25631);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,25519,25645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,25519,25645);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal int BlobStreamLength
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(759,25711,25803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,25717,25801);

return this.BlobStreamLengthAdded + f_759_25753_25800(f_759_25753_25772(this), HeapIndex.Blob);
DynAbs.Tracing.TraceSender.TraceExitMethod(759,25711,25803);

System.Reflection.Metadata.MetadataReader
f_759_25753_25772(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 25753, 25772);
return return_v;
}


int
f_759_25753_25800(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.Ecma335.HeapIndex
heapIndex)
{
var return_v = reader.GetHeapSize( heapIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 25753, 25800);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,25657,25814);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,25657,25814);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal int StringStreamLength
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(759,25882,25978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,25888,25976);

return this.StringStreamLengthAdded + f_759_25926_25975(f_759_25926_25945(this), HeapIndex.String);
DynAbs.Tracing.TraceSender.TraceExitMethod(759,25882,25978);

System.Reflection.Metadata.MetadataReader
f_759_25926_25945(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 25926, 25945);
return return_v;
}


int
f_759_25926_25975(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.Ecma335.HeapIndex
heapIndex)
{
var return_v = reader.GetHeapSize( heapIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 25926, 25975);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,25826,25989);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,25826,25989);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal int UserStringStreamLength
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(759,26061,26165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26067,26163);

return this.UserStringStreamLengthAdded + f_759_26109_26162(f_759_26109_26128(this), HeapIndex.UserString);
DynAbs.Tracing.TraceSender.TraceExitMethod(759,26061,26165);

System.Reflection.Metadata.MetadataReader
f_759_26109_26128(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 26109, 26128);
return return_v;
}


int
f_759_26109_26162(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.Ecma335.HeapIndex
heapIndex)
{
var return_v = reader.GetHeapSize( heapIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 26109, 26162);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,26001,26176);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,26001,26176);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal int GuidStreamLength
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(759,26242,26334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26248,26332);

return this.GuidStreamLengthAdded + f_759_26284_26331(f_759_26284_26303(this), HeapIndex.Guid);
DynAbs.Tracing.TraceSender.TraceExitMethod(759,26242,26334);

System.Reflection.Metadata.MetadataReader
f_759_26284_26303(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 26284, 26303);
return return_v;
}


int
f_759_26284_26331(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.Ecma335.HeapIndex
heapIndex)
{
var return_v = reader.GetHeapSize( heapIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 26284, 26331);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,26188,26345);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,26188,26345);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private static ImmutableArray<int> CalculateTableSizes(MetadataReader reader, ImmutableArray<int> delta)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(759,26357,26759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26486,26533);

var 
sizes = new int[MetadataTokens.TableCount]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26558,26563);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26549,26696) || true) && (i < f_759_26569_26581(sizes))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26583,26586)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(759,26549,26696))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,26549,26696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26620,26681);

sizes[i] = f_759_26631_26669(reader, i)+ delta[i];
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(759,1,148);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(759,1,148);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26712,26748);

return f_759_26719_26747(sizes);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(759,26357,26759);

int
f_759_26569_26581(int[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 26569, 26581);
return return_v;
}


int
f_759_26631_26669(System.Reflection.Metadata.MetadataReader
reader,int
tableIndex)
{
var return_v = reader.GetTableRowCount( (System.Reflection.Metadata.Ecma335.TableIndex)tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 26631, 26669);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_759_26719_26747(params int[]
items)
{
var return_v = ImmutableArray.Create( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 26719, 26747);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,26357,26759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,26357,26759);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Dictionary<int, int> CalculateTypePropertyMap(MetadataReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(759,26771,27238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26879,26919);

var 
result = f_759_26892_26918()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26935,26949);

int 
rowId = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,26963,27197);
foreach(var parentType in f_759_26990_27021_I(f_759_26990_27021(reader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,26963,27197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27055,27087);

f_759_27055_27086(f_759_27068_27085_M(!parentType.IsNil));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27105,27156);

f_759_27105_27155(                result, reader.GetRowNumber(parentType), rowId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27174,27182);

rowId++;
DynAbs.Tracing.TraceSender.TraceExitCondition(759,26963,27197);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(759,1,235);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(759,1,235);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27213,27227);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(759,26771,27238);

System.Collections.Generic.Dictionary<int, int>
f_759_26892_26918()
{
var return_v = new System.Collections.Generic.Dictionary<int, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 26892, 26918);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>
f_759_26990_27021(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypesWithProperties();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 26990, 27021);
return return_v;
}


bool
f_759_27068_27085_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 27068, 27085);
return return_v;
}


int
f_759_27055_27086(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27055, 27086);
return 0;
}


int
f_759_27105_27155(System.Collections.Generic.Dictionary<int, int>
this_param,int
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27105, 27155);
return 0;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>
f_759_26990_27021_I(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 26990, 27021);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,26771,27238);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,26771,27238);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Dictionary<int, int> CalculateTypeEventMap(MetadataReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(759,27250,27710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27355,27395);

var 
result = f_759_27368_27394()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27411,27425);

int 
rowId = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27439,27669);
foreach(var parentType in f_759_27466_27493_I(f_759_27466_27493(reader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,27439,27669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27527,27559);

f_759_27527_27558(f_759_27540_27557_M(!parentType.IsNil));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27577,27628);

f_759_27577_27627(                result, reader.GetRowNumber(parentType), rowId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27646,27654);

rowId++;
DynAbs.Tracing.TraceSender.TraceExitCondition(759,27439,27669);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(759,1,231);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(759,1,231);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27685,27699);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(759,27250,27710);

System.Collections.Generic.Dictionary<int, int>
f_759_27368_27394()
{
var return_v = new System.Collections.Generic.Dictionary<int, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27368, 27394);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>
f_759_27466_27493(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypesWithEvents();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27466, 27493);
return return_v;
}


bool
f_759_27540_27557_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 27540, 27557);
return return_v;
}


int
f_759_27527_27558(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27527, 27558);
return 0;
}


int
f_759_27577_27627(System.Collections.Generic.Dictionary<int, int>
this_param,int
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27577, 27627);
return 0;
}


System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>
f_759_27466_27493_I(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.TypeDefinitionHandle>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27466, 27493);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,27250,27710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,27250,27710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Dictionary<MethodImplKey, int> CalculateMethodImpls(MetadataReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(759,27722,29031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27836,27886);

var 
result = f_759_27849_27885()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27900,27955);

int 
n = f_759_27908_27954(reader, TableIndex.MethodImpl)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27978,27985);
            for (int 
row = 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27969,28992) || true) && (row <= n)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,27997,28002)
,row++,DynAbs.Tracing.TraceSender.TraceExitCondition(759,27969,28992))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,27969,28992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,28036,28132);

var 
methodImpl = f_759_28053_28131(reader, f_759_28084_28130(row))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,28530,28600);

int 
methodDefRow = f_759_28549_28599(methodImpl.MethodBody)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,28618,28632);

int 
index = 1
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,28650,28977) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,28650,28977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,28703,28752);

var 
key = f_759_28713_28751(methodDefRow, index)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,28774,28928) || true) && (!f_759_28779_28802(result, key))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,28774,28928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,28852,28873);

f_759_28852_28872(                        result, key, row);
DynAbs.Tracing.TraceSender.TraceBreak(759,28899,28905);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(759,28774,28928);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,28950,28958);

index++;
DynAbs.Tracing.TraceSender.TraceExitCondition(759,28650,28977);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(759,28650,28977);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(759,28650,28977);
}}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(759,1,1024);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(759,1,1024);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29006,29020);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(759,27722,29031);

System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
f_759_27849_27885()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27849, 27885);
return return_v;
}


int
f_759_27908_27954(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
var return_v = reader.GetTableRowCount( tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 27908, 27954);
return return_v;
}


System.Reflection.Metadata.MethodImplementationHandle
f_759_28084_28130(int
rowNumber)
{
var return_v = MetadataTokens.MethodImplementationHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 28084, 28130);
return return_v;
}


System.Reflection.Metadata.MethodImplementation
f_759_28053_28131(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.MethodImplementationHandle
handle)
{
var return_v = this_param.GetMethodImplementation( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 28053, 28131);
return return_v;
}


int
f_759_28549_28599(System.Reflection.Metadata.EntityHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 28549, 28599);
return return_v;
}


Microsoft.CodeAnalysis.Emit.MethodImplKey
f_759_28713_28751(int
implementingMethod,int
index)
{
var return_v = new Microsoft.CodeAnalysis.Emit.MethodImplKey( implementingMethod, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 28713, 28751);
return return_v;
}


bool
f_759_28779_28802(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 28779, 28802);
return return_v;
}


int
f_759_28852_28872(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
this_param,Microsoft.CodeAnalysis.Emit.MethodImplKey
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 28852, 28872);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,27722,29031);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,27722,29031);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal int GetNextAnonymousTypeIndex(bool fromDelegates = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(759,29043,29587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29134,29152);

int 
nextIndex = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29166,29543);
foreach(var pair in f_759_29187_29208_I(f_759_29187_29208(this)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,29166,29543);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29242,29352) || true) && (fromDelegates != pair.Key.IsDelegate)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,29242,29352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29324,29333);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(759,29242,29352);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29370,29405);

int 
index = pair.Value.UniqueIndex
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29423,29528) || true) && (index >= nextIndex)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(759,29423,29528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29487,29509);

nextIndex = index + 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(759,29423,29528);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(759,29166,29543);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(759,1,378);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(759,1,378);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,29559,29576);

return nextIndex;
DynAbs.Tracing.TraceSender.TraceExitMethod(759,29043,29587);

System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
f_759_29187_29208(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param)
{
var return_v = this_param.AnonymousTypeMap;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 29187, 29208);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
f_759_29187_29208_I(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 29187, 29208);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(759,29043,29587);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,29043,29587);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static EmitBaseline()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(759,2235,29594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(759,2328,2405);
s_emptyTableSizes = f_759_2348_2405(new int[MetadataTokens.TableCount]);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(759,2235,29594);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(759,2235,29594);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(759,2235,29594);

static System.Collections.Immutable.ImmutableArray<int>
f_759_2348_2405(params int[]
items)
{
var return_v = ImmutableArray.Create( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 2348, 2405);
return return_v;
}


static int
f_759_18700_18728(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 18700, 18728);
return 0;
}


static int
f_759_18743_18793(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 18743, 18793);
return 0;
}


static int
f_759_18808_18865(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 18808, 18865);
return 0;
}


static int
f_759_18880_18938(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 18880, 18938);
return 0;
}


static System.Guid
f_759_18975_19002(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.GetModuleVersionId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 18975, 19002);
return return_v;
}


static int
f_759_18953_19003(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 18953, 19003);
return 0;
}


static int
f_759_19018_19064(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19018, 19064);
return 0;
}


static int
f_759_19079_19123(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19079, 19123);
return 0;
}


static int
f_759_19138_19174(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19138, 19174);
return 0;
}


static int
f_759_19189_19228(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19189, 19228);
return 0;
}


static int
f_759_19243_19283(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19243, 19283);
return 0;
}


static System.Guid
f_759_19330_19357(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.GetModuleVersionId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19330, 19357);
return return_v;
}


static int
f_759_19298_19358(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19298, 19358);
return 0;
}


static int
f_759_19373_19413(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19373, 19413);
return 0;
}


static int
f_759_19430_19497(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19430, 19497);
return 0;
}


static int
f_759_19923_19939(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 19923, 19939);
return return_v;
}


static int
f_759_19864_19940(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19864, 19940);
return 0;
}


static int
f_759_20012_20029(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 20012, 20029);
return return_v;
}


static int
f_759_19955_20030(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 19955, 20030);
return 0;
}


static int
f_759_20102_20119(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 20102, 20119);
return return_v;
}


static int
f_759_20045_20120(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 20045, 20120);
return 0;
}


static int
f_759_20196_20214(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 20196, 20214);
return return_v;
}


static int
f_759_20135_20215(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 20135, 20215);
return 0;
}


static int
f_759_20290_20311(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 20290, 20311);
return return_v;
}


static int
f_759_20230_20312(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 20230, 20312);
return 0;
}


static int
f_759_20387_20406(System.Collections.Generic.IReadOnlyDictionary<int, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 20387, 20406);
return return_v;
}


static int
f_759_20327_20407(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 20327, 20407);
return 0;
}


static int
f_759_20485_20507(System.Collections.Generic.IReadOnlyDictionary<int, int>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 20485, 20507);
return return_v;
}


static int
f_759_20422_20508(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 20422, 20508);
return 0;
}


static Microsoft.CodeAnalysis.PEModule
f_759_20538_20551(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 20538, 20551);
return return_v;
}


static System.Reflection.Metadata.MetadataReader
f_759_20538_20566(Microsoft.CodeAnalysis.PEModule
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(759, 20538, 20566);
return return_v;
}


static System.Collections.Immutable.ImmutableArray<int>
f_759_21889_21935(System.Reflection.Metadata.MetadataReader
reader,System.Collections.Immutable.ImmutableArray<int>
delta)
{
var return_v = CalculateTableSizes( reader, delta);
DynAbs.Tracing.TraceSender.TraceEndInvocation(759, 21889, 21935);
return return_v;
}

}
}
