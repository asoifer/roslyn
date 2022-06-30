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
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit
{
internal abstract class DefinitionMap
{
protected readonly struct MappedMethod
        {

public readonly IMethodSymbolInternal PreviousMethod;

public readonly Func<SyntaxNode, SyntaxNode> SyntaxMap;

public MappedMethod(IMethodSymbolInternal previousMethodOpt, Func<SyntaxNode, SyntaxNode> syntaxMap)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(757,865,1088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,998,1033);

PreviousMethod = previousMethodOpt;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,1051,1073);

SyntaxMap = syntaxMap;
DynAbs.Tracing.TraceSender.TraceExitConstructor(757,865,1088);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,865,1088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,865,1088);
}
		}
static MappedMethod(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(757,664,1099);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(757,664,1099);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,664,1099);
}
        }

protected readonly IReadOnlyDictionary<IMethodSymbolInternal, MappedMethod> mappedMethods;

protected abstract SymbolMatcher MapToMetadataSymbolMatcher {get; }

protected abstract SymbolMatcher MapToPreviousSymbolMatcher {get; }

protected DefinitionMap(IEnumerable<SemanticEdit> edits)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(757,1369,1550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,1187,1200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,1450,1478);

f_757_1450_1477(edits != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,1494,1539);

this.mappedMethods = f_757_1515_1538(this, edits);
DynAbs.Tracing.TraceSender.TraceExitConstructor(757,1369,1550);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,1369,1550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,1369,1550);
}
		}

private IReadOnlyDictionary<IMethodSymbolInternal, MappedMethod> GetMappedMethods(IEnumerable<SemanticEdit> edits)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(757,1562,3994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,1701,1775);

var 
mappedMethods = f_757_1721_1774()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,1789,3946);
foreach(var edit in f_757_1810_1815_I(edits) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,1789,3946);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,3402,3931) || true) && (edit.Kind == SemanticEditKind.Update &&(DynAbs.Tracing.TraceSender.Expression_True(757, 3406, 3473)&&edit.PreserveLocalVariables))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,3402,3931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,3515,3597);

var 
newMethod = f_757_3531_3571(this, edit.NewSymbol)as IMethodSymbolInternal
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,3619,3701);

var 
oldMethod = f_757_3635_3675(this, edit.OldSymbol)as IMethodSymbolInternal
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,3723,3912) || true) && (newMethod != null &&(DynAbs.Tracing.TraceSender.Expression_True(757, 3727, 3765)&&oldMethod != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,3723,3912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,3815,3889);

f_757_3815_3888(                        mappedMethods, newMethod, f_757_3844_3887(oldMethod, edit.SyntaxMap));
DynAbs.Tracing.TraceSender.TraceExitCondition(757,3723,3912);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(757,3402,3931);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(757,1789,3946);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(757,1,2158);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(757,1,2158);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,3962,3983);

return mappedMethods;
DynAbs.Tracing.TraceSender.TraceExitMethod(757,1562,3994);

System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod>
f_757_1721_1774()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 1721, 1774);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal
f_757_3531_3571(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.CodeAnalysis.ISymbol?
symbol)
{
var return_v = this_param.GetISymbolInternalOrNull( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 3531, 3571);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal
f_757_3635_3675(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.CodeAnalysis.ISymbol?
symbol)
{
var return_v = this_param.GetISymbolInternalOrNull( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 3635, 3675);
return return_v;
}


Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod
f_757_3844_3887(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
previousMethodOpt,System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode?>?
syntaxMap)
{
var return_v = new Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod( previousMethodOpt, syntaxMap);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 3844, 3887);
return return_v;
}


int
f_757_3815_3888(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod>
this_param,Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
key,Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 3815, 3888);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_757_1810_1815_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 1810, 1815);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,1562,3994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,1562,3994);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract ISymbolInternal GetISymbolInternalOrNull(ISymbol symbol);

internal Cci.IDefinition MapDefinition(Cci.IDefinition definition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(757,4094,4400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,4185,4389);

return f_757_4192_4244(f_757_4192_4218(), definition)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.IDefinition>(757, 4192, 4388)??                   ((DynAbs.Tracing.TraceSender.Conditional_F1(757, 4269, 4325)||((f_757_4269_4295()!= f_757_4299_4325()&&DynAbs.Tracing.TraceSender.Conditional_F2(757, 4328, 4380))||DynAbs.Tracing.TraceSender.Conditional_F3(757, 4383, 4387)))?f_757_4328_4380(f_757_4328_4354(), definition):null));
DynAbs.Tracing.TraceSender.TraceExitMethod(757,4094,4400);

Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_4192_4218()
{
var return_v = MapToPreviousSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 4192, 4218);
return return_v;
}


Microsoft.Cci.IDefinition
f_757_4192_4244(Microsoft.CodeAnalysis.Emit.SymbolMatcher
this_param,Microsoft.Cci.IDefinition
definition)
{
var return_v = this_param.MapDefinition( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 4192, 4244);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_4269_4295()
{
var return_v = MapToMetadataSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 4269, 4295);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_4299_4325()
{
var return_v = MapToPreviousSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 4299, 4325);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_4328_4354()
{
var return_v = MapToMetadataSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 4328, 4354);
return return_v;
}


Microsoft.Cci.IDefinition
f_757_4328_4380(Microsoft.CodeAnalysis.Emit.SymbolMatcher
this_param,Microsoft.Cci.IDefinition
definition)
{
var return_v = this_param.MapDefinition( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 4328, 4380);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,4094,4400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,4094,4400);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal Cci.INamespace MapNamespace(Cci.INamespace @namespace)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(757,4412,4713);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,4500,4702);

return f_757_4507_4558(f_757_4507_4533(), @namespace)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.INamespace>(757, 4507, 4701)??                   ((DynAbs.Tracing.TraceSender.Conditional_F1(757, 4583, 4639)||((f_757_4583_4609()!= f_757_4613_4639()&&DynAbs.Tracing.TraceSender.Conditional_F2(757, 4642, 4693))||DynAbs.Tracing.TraceSender.Conditional_F3(757, 4696, 4700)))?f_757_4642_4693(f_757_4642_4668(), @namespace):null));
DynAbs.Tracing.TraceSender.TraceExitMethod(757,4412,4713);

Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_4507_4533()
{
var return_v = MapToPreviousSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 4507, 4533);
return return_v;
}


Microsoft.Cci.INamespace
f_757_4507_4558(Microsoft.CodeAnalysis.Emit.SymbolMatcher
this_param,Microsoft.Cci.INamespace
@namespace)
{
var return_v = this_param.MapNamespace( @namespace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 4507, 4558);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_4583_4609()
{
var return_v = MapToMetadataSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 4583, 4609);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_4613_4639()
{
var return_v = MapToPreviousSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 4613, 4639);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_4642_4668()
{
var return_v = MapToMetadataSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 4642, 4668);
return return_v;
}


Microsoft.Cci.INamespace
f_757_4642_4693(Microsoft.CodeAnalysis.Emit.SymbolMatcher
this_param,Microsoft.Cci.INamespace
@namespace)
{
var return_v = this_param.MapNamespace( @namespace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 4642, 4693);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,4412,4713);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,4412,4713);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool DefinitionExists(Cci.IDefinition definition)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(757,4797,4835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,4800,4835);
return f_757_4800_4825(this, definition)is object;DynAbs.Tracing.TraceSender.TraceExitMethod(757,4797,4835);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,4797,4835);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,4797,4835);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.Cci.IDefinition
f_757_4800_4825(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IDefinition
definition)
{
var return_v = this_param.MapDefinition( definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 4800, 4825);
return return_v;
}

		}

internal bool NamespaceExists(Cci.INamespace @namespace)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(757,4918,4955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,4921,4955);
return f_757_4921_4945(this, @namespace)is object;DynAbs.Tracing.TraceSender.TraceExitMethod(757,4918,4955);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,4918,4955);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,4918,4955);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.Cci.INamespace
f_757_4921_4945(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.INamespace
@namespace)
{
var return_v = this_param.MapNamespace( @namespace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 4921, 4945);
return return_v;
}

		}

internal abstract bool TryGetTypeHandle(Cci.ITypeDefinition def, out TypeDefinitionHandle handle);

internal abstract bool TryGetEventHandle(Cci.IEventDefinition def, out EventDefinitionHandle handle);

internal abstract bool TryGetFieldHandle(Cci.IFieldDefinition def, out FieldDefinitionHandle handle);

internal abstract bool TryGetMethodHandle(Cci.IMethodDefinition def, out MethodDefinitionHandle handle);

internal abstract bool TryGetPropertyHandle(Cci.IPropertyDefinition def, out PropertyDefinitionHandle handle);

internal abstract CommonMessageProvider MessageProvider {get; }

private bool TryGetMethodHandle(EmitBaseline baseline, Cci.IMethodDefinition def, out MethodDefinitionHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(757,5608,6371);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,5749,5854) || true) && (f_757_5753_5793(this, def, out handle))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,5749,5854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,5827,5839);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,5749,5854);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,5870,5950);

def = (Cci.IMethodDefinition)f_757_5899_5949(f_757_5899_5930(this), def);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,5964,6276) || true) && (def != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,5964,6276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6013,6029);

int 
methodIndex
=default(int);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6047,6261) || true) && (f_757_6051_6106(baseline.MethodsAdded, def, out methodIndex))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,6047,6261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6148,6208);

handle = f_757_6157_6207(methodIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6230,6242);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,6047,6261);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(757,5964,6276);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6292,6333);

handle = default(MethodDefinitionHandle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6347,6360);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(757,5608,6371);

bool
f_757_5753_5793(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.Cci.IMethodDefinition
def,out System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = this_param.TryGetMethodHandle( def, out handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 5753, 5793);
return return_v;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_5899_5930(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param)
{
var return_v = this_param.MapToPreviousSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 5899, 5930);
return return_v;
}


Microsoft.Cci.IDefinition
f_757_5899_5949(Microsoft.CodeAnalysis.Emit.SymbolMatcher
this_param,Microsoft.Cci.IMethodDefinition
definition)
{
var return_v = this_param.MapDefinition( (Microsoft.Cci.IDefinition)definition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 5899, 5949);
return return_v;
}


bool
f_757_6051_6106(System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
this_param,Microsoft.Cci.IMethodDefinition
key,out int
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 6051, 6106);
return return_v;
}


System.Reflection.Metadata.MethodDefinitionHandle
f_757_6157_6207(int
rowNumber)
{
var return_v = MetadataTokens.MethodDefinitionHandle( rowNumber);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 6157, 6207);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,5608,6371);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,5608,6371);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected static IReadOnlyDictionary<SyntaxNode, int> CreateDeclaratorToSyntaxOrdinalMap(ImmutableArray<SyntaxNode> declarators)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(757,6383,6793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6536,6594);

var 
declaratorToIndex = f_757_6560_6593()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6617,6622);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6608,6741) || true) && (i < declarators.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6648,6651)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(757,6608,6741))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,6608,6741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6685,6726);

f_757_6685_6725(                declaratorToIndex, declarators[i], i);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(757,1,134);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(757,1,134);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,6757,6782);

return declaratorToIndex;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(757,6383,6793);

System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, int>
f_757_6560_6593()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 6560, 6593);
return return_v;
}


int
f_757_6685_6725(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, int>
this_param,Microsoft.CodeAnalysis.SyntaxNode
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 6685, 6725);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,6383,6793);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,6383,6793);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract void GetStateMachineFieldMapFromMetadata(
            ITypeSymbolInternal stateMachineType,
            ImmutableArray<LocalSlotDebugInfo> localSlotDebugInfo,
            out IReadOnlyDictionary<EncHoistedLocalInfo, int> hoistedLocalMap,
            out IReadOnlyDictionary<Cci.ITypeReference, int> awaiterMap,
            out int awaiterSlotCount);

protected abstract ImmutableArray<EncLocalInfo> GetLocalSlotMapFromMetadata(StandaloneSignatureHandle handle, EditAndContinueMethodDebugInformation debugInfo);

protected abstract ITypeSymbolInternal TryGetStateMachineType(EntityHandle methodHandle);

internal VariableSlotAllocator TryCreateVariableSlotAllocator(EmitBaseline baseline, Compilation compilation, IMethodSymbolInternal method, IMethodSymbolInternal topLevelMethod, DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(757,7460,16620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,7794,7820);

MappedMethod 
mappedMethod
=default(MappedMethod);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,7834,7959) || true) && (!f_757_7839_7898(mappedMethods, topLevelMethod, out mappedMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,7834,7959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,7932,7944);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,7834,7959);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8119,8157);

MethodDefinitionHandle 
previousHandle
=default(MethodDefinitionHandle);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8171,8422) || true) && (!f_757_8176_8271(this, baseline, f_757_8228_8250(method), out previousHandle))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,8171,8422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8395,8407);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,8171,8422);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8438,8482);

ImmutableArray<EncLocalInfo> 
previousLocals
=default(ImmutableArray<EncLocalInfo>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8496,8565);

IReadOnlyDictionary<EncHoistedLocalInfo, int> 
hoistedLocalMap = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8579,8642);

IReadOnlyDictionary<Cci.ITypeReference, int> 
awaiterMap = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8656,8726);

IReadOnlyDictionary<int, KeyValuePair<DebugId, int>> 
lambdaMap = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8740,8792);

IReadOnlyDictionary<int, DebugId> 
closureMap = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8808,8838);

int 
hoistedLocalSlotCount = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8852,8877);

int 
awaiterSlotCount = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8891,8929);

string 
stateMachineTypeNameOpt = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8943,8967);

SymbolMatcher 
symbolMap
=default(SymbolMatcher);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,8983,9045);

int 
methodIndex = f_757_9001_9044(previousHandle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,9059,9076);

DebugId 
methodId
=default(DebugId);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,9178,9224);

AddedOrChangedMethodInfo 
addedOrChangedMethod
=default(AddedOrChangedMethodInfo);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,9238,16103) || true) && (f_757_9242_9323(baseline.AddedOrChangedMethods, methodIndex, out addedOrChangedMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,9238,16103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,9357,9398);

methodId = addedOrChangedMethod.MethodId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,9418,9551);

f_757_9418_9550(addedOrChangedMethod.LambdaDebugInfo, addedOrChangedMethod.ClosureDebugInfo, out lambdaMap, out closureMap);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,9571,10708) || true) && (addedOrChangedMethod.StateMachineTypeNameOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,9571,10708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,9733,10023);

f_757_9733_10022(addedOrChangedMethod.StateMachineHoistedLocalSlotsOpt, addedOrChangedMethod.StateMachineAwaiterSlotsOpt, out hoistedLocalMap, out awaiterMap);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,10047,10132);

hoistedLocalSlotCount = addedOrChangedMethod.StateMachineHoistedLocalSlotsOpt.Length;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,10154,10229);

awaiterSlotCount = addedOrChangedMethod.StateMachineAwaiterSlotsOpt.Length;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,10415,10467);

previousLocals = ImmutableArray<EncLocalInfo>.Empty;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,10491,10562);

stateMachineTypeNameOpt = addedOrChangedMethod.StateMachineTypeNameOpt;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,9571,10708);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,9571,10708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,10644,10689);

previousLocals = addedOrChangedMethod.Locals;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,9571,10708);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,10991,11030);

symbolMap = f_757_11003_11029();
DynAbs.Tracing.TraceSender.TraceExitCondition(757,9238,16103);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,9238,16103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,11258,11306);

EditAndContinueMethodDebugInformation 
debugInfo
=default(EditAndContinueMethodDebugInformation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,11324,11365);

StandaloneSignatureHandle 
localSignature
=default(StandaloneSignatureHandle);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,11427,11489);

debugInfo = f_757_11439_11488(baseline, previousHandle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,11511,11576);

localSignature = f_757_11528_11575(baseline, previousHandle);
                }
                catch (Exception e) when (e is InvalidDataException ||(DynAbs.Tracing.TraceSender.Expression_False(757, 11639, 11684)||e is IOException))
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(757,11613,12119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,11726,12064);

f_757_11726_12063(                    diagnostics, f_757_11742_12062(f_757_11742_11757(), f_757_11801_11837(f_757_11801_11816()), method.Locations.First(), method, f_757_11948_11987(previousHandle), f_757_12014_12039(method)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12088,12100);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(757,11613,12119);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12139,12190);

methodId = f_757_12150_12189(debugInfo.MethodOrdinal, 0);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12210,12405) || true) && (f_757_12214_12249_M(!debugInfo.Lambdas.IsDefaultOrEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,12210,12405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12291,12386);

f_757_12291_12385(debugInfo.Lambdas, debugInfo.Closures, out lambdaMap, out closureMap);
DynAbs.Tracing.TraceSender.TraceExitCondition(757,12210,12405);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12425,12503);

ITypeSymbolInternal 
stateMachineType = f_757_12464_12502(this, previousHandle)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12521,16029) || true) && (stateMachineType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,12521,16029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12655,12715);

var 
localSlotDebugInfo = debugInfo.LocalSlots.NullToEmpty()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12737,12870);

f_757_12737_12869(this, stateMachineType, localSlotDebugInfo, out hoistedLocalMap, out awaiterMap, out awaiterSlotCount);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,12892,12942);

hoistedLocalSlotCount = localSlotDebugInfo.Length;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,13128,13180);

previousLocals = ImmutableArray<EncLocalInfo>.Empty;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,13204,13252);

stateMachineTypeNameOpt = f_757_13230_13251(stateMachineType);
DynAbs.Tracing.TraceSender.TraceExitCondition(757,12521,16029);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,12521,16029);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,14175,15143) || true) && (f_757_14179_14193(method))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,14175,15143);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,14243,14618) || true) && (f_757_14247_14369(compilation, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,14243,14618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,14435,14549);

f_757_14435_14548(this, diagnostics, method, AttributeDescription.AsyncStateMachineAttribute.FullName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,14579,14591);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,14243,14618);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(757,14175,15143);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,14175,15143);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,14668,15143) || true) && (f_757_14672_14689(method))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,14668,15143);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,14739,15120) || true) && (f_757_14743_14868(compilation, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,14739,15120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,14934,15051);

f_757_14934_15050(this, diagnostics, method, AttributeDescription.IteratorStateMachineAttribute.FullName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,15081,15093);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,14739,15120);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(757,14668,15143);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(757,14175,15143);
}

                    try
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,15219,15380);

previousLocals = (DynAbs.Tracing.TraceSender.Conditional_F1(757, 15236, 15256)||((localSignature.IsNil &&DynAbs.Tracing.TraceSender.Conditional_F2(757, 15259, 15293))||DynAbs.Tracing.TraceSender.Conditional_F3(757, 15325, 15379)))?ImmutableArray<EncLocalInfo>.Empty :f_757_15325_15379(this, localSignature, debugInfo);
                    }
                    catch (Exception e) when (e is UnsupportedSignatureContent ||(DynAbs.Tracing.TraceSender.Expression_False(757, 15451, 15515)||e is BadImageFormatException )||(DynAbs.Tracing.TraceSender.Expression_False(757, 15451, 15535)||e is IOException))
                    {
DynAbs.Tracing.TraceSender.TraceEnterCatch(757,15425,16010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,15585,15947);

f_757_15585_15946(                        diagnostics, f_757_15601_15945(f_757_15601_15616(), f_757_15664_15700(f_757_15664_15679()), method.Locations.First(), method, f_757_15823_15862(localSignature), f_757_15893_15918(method)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,15975,15987);

return null;
DynAbs.Tracing.TraceSender.TraceExitCatch(757,15425,16010);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(757,12521,16029);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,16049,16088);

symbolMap = f_757_16061_16087();
DynAbs.Tracing.TraceSender.TraceExitCondition(757,9238,16103);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,16119,16609);

return f_757_16126_16608(symbolMap, mappedMethod.SyntaxMap, mappedMethod.PreviousMethod, methodId, previousLocals, lambdaMap, closureMap, stateMachineTypeNameOpt, hoistedLocalSlotCount, hoistedLocalMap, awaiterSlotCount, awaiterMap, f_757_16585_16607(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(757,7460,16620);

bool
f_757_7839_7898(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod>
this_param,Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
key,out Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 7839, 7898);
return return_v;
}


Microsoft.Cci.IReference
f_757_8228_8250(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
this_param)
{
var return_v = this_param.GetCciAdapter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 8228, 8250);
return return_v;
}


bool
f_757_8176_8271(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,Microsoft.Cci.IReference
def,out System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = this_param.TryGetMethodHandle( baseline, (Microsoft.Cci.IMethodDefinition)def, out handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 8176, 8271);
return return_v;
}


int
f_757_9001_9044(System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetRowNumber( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 9001, 9044);
return return_v;
}


bool
f_757_9242_9323(System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
this_param,int
key,out Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 9242, 9323);
return return_v;
}


int
f_757_9418_9550(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
lambdaDebugInfo,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
closureDebugInfo,out System.Collections.Generic.IReadOnlyDictionary<int, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>>
lambdaMap,out System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.CodeGen.DebugId>
closureMap)
{
MakeLambdaAndClosureMaps( lambdaDebugInfo, closureDebugInfo, out lambdaMap, out closureMap);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 9418, 9550);
return 0;
}


int
f_757_9733_10022(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo>
hoistedLocalSlots,System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
hoistedAwaiters,out System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>
hoistedLocalMap,out System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeReference, int>
awaiterMap)
{
GetStateMachineFieldMapFromPreviousCompilation( hoistedLocalSlots, hoistedAwaiters, out hoistedLocalMap, out awaiterMap);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 9733, 10022);
return 0;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_11003_11029()
{
var return_v = MapToPreviousSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 11003, 11029);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
f_757_11439_11488(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param,System.Reflection.Metadata.MethodDefinitionHandle
arg)
{
var return_v = this_param.DebugInformationProvider( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 11439, 11488);
return return_v;
}


System.Reflection.Metadata.StandaloneSignatureHandle
f_757_11528_11575(Microsoft.CodeAnalysis.Emit.EmitBaseline
this_param,System.Reflection.Metadata.MethodDefinitionHandle
arg)
{
var return_v = this_param.LocalSignatureProvider( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 11528, 11575);
return return_v;
}


Microsoft.CodeAnalysis.CommonMessageProvider
f_757_11742_11757()
{
var return_v = MessageProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 11742, 11757);
return return_v;
}


Microsoft.CodeAnalysis.CommonMessageProvider
f_757_11801_11816()
{
var return_v = MessageProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 11801, 11816);
return return_v;
}


int
f_757_11801_11837(Microsoft.CodeAnalysis.CommonMessageProvider
this_param)
{
var return_v = this_param.ERR_InvalidDebugInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 11801, 11837);
return return_v;
}


int
f_757_11948_11987(System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetToken( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 11948, 11987);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
f_757_12014_12039(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
this_param)
{
var return_v = this_param.ContainingAssembly
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 12014, 12039);
return return_v;
}


Microsoft.CodeAnalysis.Diagnostic
f_757_11742_12062(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,int
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = this_param.CreateDiagnostic( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 11742, 12062);
return return_v;
}


int
f_757_11726_12063(Microsoft.CodeAnalysis.DiagnosticBag
this_param,Microsoft.CodeAnalysis.Diagnostic
diag)
{
this_param.Add( diag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 11726, 12063);
return 0;
}


Microsoft.CodeAnalysis.CodeGen.DebugId
f_757_12150_12189(int
ordinal,int
generation)
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.DebugId( ordinal, generation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 12150, 12189);
return return_v;
}


bool
f_757_12214_12249_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 12214, 12249);
return return_v;
}


int
f_757_12291_12385(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
lambdaDebugInfo,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
closureDebugInfo,out System.Collections.Generic.IReadOnlyDictionary<int, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>>
lambdaMap,out System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.CodeGen.DebugId>
closureMap)
{
MakeLambdaAndClosureMaps( lambdaDebugInfo, closureDebugInfo, out lambdaMap, out closureMap);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 12291, 12385);
return 0;
}


Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
f_757_12464_12502(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,System.Reflection.Metadata.MethodDefinitionHandle
methodHandle)
{
var return_v = this_param.TryGetStateMachineType( (System.Reflection.Metadata.EntityHandle)methodHandle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 12464, 12502);
return return_v;
}


int
f_757_12737_12869(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
stateMachineType,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
localSlotDebugInfo,out System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>
hoistedLocalMap,out System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeReference, int>
awaiterMap,out int
awaiterSlotCount)
{
this_param.GetStateMachineFieldMapFromMetadata( stateMachineType, localSlotDebugInfo, out hoistedLocalMap, out awaiterMap, out awaiterSlotCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 12737, 12869);
return 0;
}


string
f_757_13230_13251(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 13230, 13251);
return return_v;
}


bool
f_757_14179_14193(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
this_param)
{
var return_v = this_param.IsAsync;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 14179, 14193);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
f_757_14247_14369(Microsoft.CodeAnalysis.Compilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.CommonGetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 14247, 14369);
return return_v;
}


int
f_757_14435_14548(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
method,string
stateMachineAttributeFullName)
{
this_param.ReportMissingStateMachineAttribute( diagnostics, method, stateMachineAttributeFullName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 14435, 14548);
return 0;
}


bool
f_757_14672_14689(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
this_param)
{
var return_v = this_param.IsIterator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 14672, 14689);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
f_757_14743_14868(Microsoft.CodeAnalysis.Compilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.CommonGetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 14743, 14868);
return return_v;
}


int
f_757_14934_15050(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
method,string
stateMachineAttributeFullName)
{
this_param.ReportMissingStateMachineAttribute( diagnostics, method, stateMachineAttributeFullName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 14934, 15050);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
f_757_15325_15379(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,System.Reflection.Metadata.StandaloneSignatureHandle
handle,Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
debugInfo)
{
var return_v = this_param.GetLocalSlotMapFromMetadata( handle, debugInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 15325, 15379);
return return_v;
}


Microsoft.CodeAnalysis.CommonMessageProvider
f_757_15601_15616()
{
var return_v = MessageProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 15601, 15616);
return return_v;
}


Microsoft.CodeAnalysis.CommonMessageProvider
f_757_15664_15679()
{
var return_v = MessageProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 15664, 15679);
return return_v;
}


int
f_757_15664_15700(Microsoft.CodeAnalysis.CommonMessageProvider
this_param)
{
var return_v = this_param.ERR_InvalidDebugInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 15664, 15700);
return return_v;
}


int
f_757_15823_15862(System.Reflection.Metadata.StandaloneSignatureHandle
handle)
{
var return_v = MetadataTokens.GetToken( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 15823, 15862);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
f_757_15893_15918(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
this_param)
{
var return_v = this_param.ContainingAssembly
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 15893, 15918);
return return_v;
}


Microsoft.CodeAnalysis.Diagnostic
f_757_15601_15945(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,int
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = this_param.CreateDiagnostic( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 15601, 15945);
return return_v;
}


int
f_757_15585_15946(Microsoft.CodeAnalysis.DiagnosticBag
this_param,Microsoft.CodeAnalysis.Diagnostic
diag)
{
this_param.Add( diag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 15585, 15946);
return 0;
}


Microsoft.CodeAnalysis.Emit.SymbolMatcher
f_757_16061_16087()
{
var return_v = MapToMetadataSymbolMatcher;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 16061, 16087);
return return_v;
}


Microsoft.CodeAnalysis.Emit.LambdaSyntaxFacts
f_757_16585_16607(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param)
{
var return_v = this_param.GetLambdaSyntaxFacts();
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 16585, 16607);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator
f_757_16126_16608(Microsoft.CodeAnalysis.Emit.SymbolMatcher
symbolMap,System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
syntaxMap,Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
previousTopLevelMethod,Microsoft.CodeAnalysis.CodeGen.DebugId
methodId,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.EncLocalInfo>
previousLocals,System.Collections.Generic.IReadOnlyDictionary<int, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>>?
lambdaMap,System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.CodeGen.DebugId>?
closureMap,string?
stateMachineTypeName,int
hoistedLocalSlotCount,System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>?
hoistedLocalSlots,int
awaiterCount,System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeReference, int>?
awaiterMap,Microsoft.CodeAnalysis.Emit.LambdaSyntaxFacts
lambdaSyntaxFacts)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EncVariableSlotAllocator( symbolMap, syntaxMap, previousTopLevelMethod, methodId, previousLocals, lambdaMap, closureMap, stateMachineTypeName, hoistedLocalSlotCount, hoistedLocalSlots, awaiterCount, awaiterMap, lambdaSyntaxFacts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 16126, 16608);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,7460,16620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,7460,16620);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract LambdaSyntaxFacts GetLambdaSyntaxFacts();

private void ReportMissingStateMachineAttribute(DiagnosticBag diagnostics, IMethodSymbolInternal method, string stateMachineAttributeFullName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(757,16704,17171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,16871,17160);

f_757_16871_17159(            diagnostics, f_757_16887_17158(f_757_16887_16902(), f_757_16938_16989(f_757_16938_16953()), method.Locations.First(), f_757_17051_17109(f_757_17051_17066(), f_757_17089_17108(method)), stateMachineAttributeFullName));
DynAbs.Tracing.TraceSender.TraceExitMethod(757,16704,17171);

Microsoft.CodeAnalysis.CommonMessageProvider
f_757_16887_16902()
{
var return_v = MessageProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 16887, 16902);
return return_v;
}


Microsoft.CodeAnalysis.CommonMessageProvider
f_757_16938_16953()
{
var return_v = MessageProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 16938, 16953);
return return_v;
}


int
f_757_16938_16989(Microsoft.CodeAnalysis.CommonMessageProvider
this_param)
{
var return_v = this_param.ERR_EncUpdateFailedMissingAttribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 16938, 16989);
return return_v;
}


Microsoft.CodeAnalysis.CommonMessageProvider
f_757_17051_17066()
{
var return_v = MessageProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(757, 17051, 17066);
return return_v;
}


Microsoft.CodeAnalysis.ISymbol
f_757_17089_17108(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
this_param)
{
var return_v = this_param.GetISymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 17089, 17108);
return return_v;
}


string
f_757_17051_17109(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = this_param.GetErrorDisplayString( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 17051, 17109);
return return_v;
}


Microsoft.CodeAnalysis.Diagnostic
f_757_16887_17158(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,int
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = this_param.CreateDiagnostic( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 16887, 17158);
return return_v;
}


int
f_757_16871_17159(Microsoft.CodeAnalysis.DiagnosticBag
this_param,Microsoft.CodeAnalysis.Diagnostic
diag)
{
this_param.Add( diag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 16871, 17159);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,16704,17171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,16704,17171);
}
		}

private static void MakeLambdaAndClosureMaps(
            ImmutableArray<LambdaDebugInfo> lambdaDebugInfo,
            ImmutableArray<ClosureDebugInfo> closureDebugInfo,
            out IReadOnlyDictionary<int, KeyValuePair<DebugId, int>> lambdaMap,
            out IReadOnlyDictionary<int, DebugId> closureMap)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(757,17183,18276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17523,17609);

var 
lambdas = f_757_17537_17608(lambdaDebugInfo.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17623,17692);

var 
closures = f_757_17638_17691(closureDebugInfo.Length)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17717,17722);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17708,17965) || true) && (i < lambdaDebugInfo.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17752,17755)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(757,17708,17965))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,17708,17965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17789,17825);

var 
lambdaInfo = lambdaDebugInfo[i]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17843,17950);

lambdas[lambdaInfo.SyntaxOffset] = f_757_17878_17949(lambdaInfo.LambdaId, lambdaInfo.ClosureOrdinal);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(757,1,258);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(757,1,258);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17990,17995);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,17981,18193) || true) && (i < closureDebugInfo.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18026,18029)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(757,17981,18193))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,17981,18193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18063,18101);

var 
closureInfo = closureDebugInfo[i]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18119,18178);

closures[closureInfo.SyntaxOffset] = closureInfo.ClosureId;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(757,1,213);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(757,1,213);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18209,18229);

lambdaMap = lambdas;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18243,18265);

closureMap = closures;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(757,17183,18276);

System.Collections.Generic.Dictionary<int, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>>
f_757_17537_17608(int
capacity)
{
var return_v = new System.Collections.Generic.Dictionary<int, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 17537, 17608);
return return_v;
}


System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.CodeGen.DebugId>
f_757_17638_17691(int
capacity)
{
var return_v = new System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.CodeGen.DebugId>( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 17638, 17691);
return return_v;
}


System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CodeGen.DebugId, int>
f_757_17878_17949(Microsoft.CodeAnalysis.CodeGen.DebugId
key,int
value)
{
var return_v = KeyValuePairUtil.Create( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 17878, 17949);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,17183,18276);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,17183,18276);
}
		}

private static void GetStateMachineFieldMapFromPreviousCompilation(
            ImmutableArray<EncHoistedLocalInfo> hoistedLocalSlots,
            ImmutableArray<Cci.ITypeReference> hoistedAwaiters,
            out IReadOnlyDictionary<EncHoistedLocalInfo, int> hoistedLocalMap,
            out IReadOnlyDictionary<Cci.ITypeReference, int> awaiterMap)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(757,18288,19685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18667,18730);

var 
hoistedLocals = f_757_18687_18729()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18744,18846);

var 
awaiters = f_757_18759_18845(Cci.SymbolEquivalentEqualityComparer.Instance)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18871,18884);

            for (int 
slotIndex = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18862,19222) || true) && (slotIndex < hoistedLocalSlots.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18924,18935)
,slotIndex++,DynAbs.Tracing.TraceSender.TraceExitCondition(757,18862,19222))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,18862,19222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,18969,19009);

var 
slot = hoistedLocalSlots[slotIndex]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19027,19152) || true) && (slot.IsUnused)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,19027,19152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19124,19133);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,19027,19152);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19172,19207);

f_757_19172_19206(
                hoistedLocals, slot, slotIndex);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(757,1,361);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(757,1,361);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19247,19260);

            for (int 
slotIndex = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19238,19590) || true) && (slotIndex < hoistedAwaiters.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19298,19309)
,slotIndex++,DynAbs.Tracing.TraceSender.TraceExitCondition(757,19238,19590))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,19238,19590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19343,19381);

var 
slot = hoistedAwaiters[slotIndex]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19399,19525) || true) && (slot == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(757,19399,19525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19497,19506);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(757,19399,19525);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19545,19575);

f_757_19545_19574(
                awaiters, slot, slotIndex);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(757,1,353);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(757,1,353);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19606,19638);

hoistedLocalMap = hoistedLocals;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(757,19652,19674);

awaiterMap = awaiters;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(757,18288,19685);

System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>
f_757_18687_18729()
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 18687, 18729);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeReference, int>
f_757_18759_18845(Microsoft.Cci.SymbolEquivalentEqualityComparer
comparer)
{
var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeReference, int>( (System.Collections.Generic.IEqualityComparer<Microsoft.Cci.ITypeReference>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 18759, 18845);
return return_v;
}


int
f_757_19172_19206(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo, int>
this_param,Microsoft.CodeAnalysis.Emit.EncHoistedLocalInfo
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 19172, 19206);
return 0;
}


int
f_757_19545_19574(System.Collections.Generic.Dictionary<Microsoft.Cci.ITypeReference, int>
this_param,Microsoft.Cci.ITypeReference
key,int
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 19545, 19574);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(757,18288,19685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,18288,19685);
}
		}

static DefinitionMap()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(757,610,19692);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(757,610,19692);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(757,610,19692);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(757,610,19692);

static int
f_757_1450_1477(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 1450, 1477);
return 0;
}


static System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.Emit.DefinitionMap.MappedMethod>
f_757_1515_1538(Microsoft.CodeAnalysis.Emit.DefinitionMap
this_param,System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = this_param.GetMappedMethods( edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(757, 1515, 1538);
return return_v;
}

}
}
