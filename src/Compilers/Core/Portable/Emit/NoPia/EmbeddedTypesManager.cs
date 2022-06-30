// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using Cci = Microsoft.Cci;

namespace Microsoft.CodeAnalysis.Emit.NoPia
{
internal abstract class CommonEmbeddedTypesManager
{
public abstract bool IsFrozen {get; }

public abstract ImmutableArray<Cci.INamespaceTypeDefinition> GetTypes(DiagnosticBag diagnostics, HashSet<string> namesOfTopLevelTypes);

public CommonEmbeddedTypesManager()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(778,533,790);
DynAbs.Tracing.TraceSender.TraceExitConstructor(778,533,790);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778,533,790);
}


static CommonEmbeddedTypesManager()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(778,533,790);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(778,533,790);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778,533,790);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(778,533,790);
}
internal abstract partial class EmbeddedTypesManager<
        TPEModuleBuilder,
        TModuleCompilationState,
        TEmbeddedTypesManager,
        TSyntaxNode,
        TAttributeData,
        TSymbol,
        TAssemblySymbol,
        TNamedTypeSymbol,
        TFieldSymbol,
        TMethodSymbol,
        TEventSymbol,
        TPropertySymbol,
        TParameterSymbol,
        TTypeParameterSymbol,
        TEmbeddedType,
        TEmbeddedField,
        TEmbeddedMethod,
        TEmbeddedEvent,
        TEmbeddedProperty,
        TEmbeddedParameter,
        TEmbeddedTypeParameter> : CommonEmbeddedTypesManager
        where TPEModuleBuilder : CommonPEModuleBuilder
        where TModuleCompilationState : CommonModuleCompilationState
        where TEmbeddedTypesManager : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
        where TSyntaxNode : SyntaxNode
        where TAttributeData : AttributeData, Cci.ICustomAttribute
        where TAssemblySymbol : class
        where TNamedTypeSymbol : class, TSymbol, Cci.INamespaceTypeReference
        where TFieldSymbol : class, TSymbol, Cci.IFieldReference
        where TMethodSymbol : class, TSymbol, Cci.IMethodReference
        where TEventSymbol : class, TSymbol, Cci.ITypeMemberReference
        where TPropertySymbol : class, TSymbol, Cci.ITypeMemberReference
        where TParameterSymbol : class, TSymbol, Cci.IParameterListEntry, Cci.INamedEntity
        where TTypeParameterSymbol : class, TSymbol, Cci.IGenericMethodParameterReference
        where TEmbeddedType : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
        where TEmbeddedField : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedField
        where TEmbeddedMethod : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod
        where TEmbeddedEvent : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedEvent
        where TEmbeddedProperty : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedProperty
        where TEmbeddedParameter : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedParameter
        where TEmbeddedTypeParameter : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedTypeParameter
{
public readonly TPEModuleBuilder ModuleBeingBuilt;

public readonly ConcurrentDictionary<TNamedTypeSymbol, TEmbeddedType> EmbeddedTypesMap ;

public readonly ConcurrentDictionary<TFieldSymbol, TEmbeddedField> EmbeddedFieldsMap ;

public readonly ConcurrentDictionary<TMethodSymbol, TEmbeddedMethod> EmbeddedMethodsMap ;

public readonly ConcurrentDictionary<TPropertySymbol, TEmbeddedProperty> EmbeddedPropertiesMap ;

public readonly ConcurrentDictionary<TEventSymbol, TEmbeddedEvent> EmbeddedEventsMap ;

private ImmutableArray<TEmbeddedType> _frozen;

protected EmbeddedTypesManager(TPEModuleBuilder moduleBeingBuilt)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(778,6882,7024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,5827,5843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,5926,6038);
this.EmbeddedTypesMap = f_778_5945_6038(ReferenceEqualityComparer.Instance);DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,6116,6226);
this.EmbeddedFieldsMap = f_778_6136_6226(ReferenceEqualityComparer.Instance);DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,6306,6419);
this.EmbeddedMethodsMap = f_778_6327_6419(ReferenceEqualityComparer.Instance);DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,6503,6623);
this.EmbeddedPropertiesMap = f_778_6527_6623(ReferenceEqualityComparer.Instance);DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,6701,6811);
this.EmbeddedEventsMap = f_778_6721_6811(ReferenceEqualityComparer.Instance);DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,6972,7013);

this.ModuleBeingBuilt = moduleBeingBuilt;
DynAbs.Tracing.TraceSender.TraceExitConstructor(778,6882,7024);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778,6882,7024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778,6882,7024);
}
		}

public override bool IsFrozen
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(778,7090,7167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,7126,7152);

return f_778_7133_7151_M(!_frozen.IsDefault);
DynAbs.Tracing.TraceSender.TraceExitMethod(778,7090,7167);

bool
f_778_7133_7151_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 7133, 7151);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778,7036,7178);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778,7036,7178);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

        public override ImmutableArray<Cci.INamespaceTypeDefinition> GetTypes(DiagnosticBag diagnostics, HashSet<string> namesOfTopLevelTypes)
        {
            if (_frozen.IsDefault)
            {
                var builder = ArrayBuilder<TEmbeddedType>.GetInstance();
                builder.AddRange(EmbeddedTypesMap.Values);
                builder.Sort(TypeComparer.Instance);

                if (ImmutableInterlocked.InterlockedInitialize(ref _frozen, builder.ToImmutableAndFree()))
                {
                    if (_frozen.Length > 0)
                    {
                        Cci.INamespaceTypeDefinition prev = _frozen[0];
                        bool reportedDuplicate = HasNameConflict(namesOfTopLevelTypes, _frozen[0], diagnostics);

                        for (int i = 1; i < _frozen.Length; i++)
                        {
                            Cci.INamespaceTypeDefinition current = _frozen[i];

                            if (prev.NamespaceName == current.NamespaceName &&
                                prev.Name == current.Name)
                            {
                                if (!reportedDuplicate)
                                {
                                    Debug.Assert(_frozen[i - 1] == prev);

                                    // ERR_DuplicateLocalTypes3/ERR_InteropTypesWithSameNameAndGuid
                                    ReportNameCollisionBetweenEmbeddedTypes(_frozen[i - 1], _frozen[i], diagnostics);
                                    reportedDuplicate = true;
                                }
                            }
                            else
                            {
                                prev = current;
                                reportedDuplicate = HasNameConflict(namesOfTopLevelTypes, _frozen[i], diagnostics);
                            }
                        }

                        OnGetTypesCompleted(_frozen, diagnostics);
                    }
                }
            }

            return StaticCast<Cci.INamespaceTypeDefinition>.From(_frozen);
        }

        private bool HasNameConflict(HashSet<string> namesOfTopLevelTypes, TEmbeddedType type, DiagnosticBag diagnostics)
        {
            Cci.INamespaceTypeDefinition def = type;

            if (namesOfTopLevelTypes.Contains(MetadataHelpers.BuildQualifiedName(def.NamespaceName, def.Name)))
            {
                // ERR_LocalTypeNameClash2/ERR_LocalTypeNameClash
                ReportNameCollisionWithAlreadyDeclaredType(type, diagnostics);
                return true;
            }

            return false;
        }

internal abstract int GetTargetAttributeSignatureIndex(TSymbol underlyingSymbol, TAttributeData attrData, AttributeDescription description);

        internal bool IsTargetAttribute(TSymbol underlyingSymbol, TAttributeData attrData, AttributeDescription description)
        {
            return GetTargetAttributeSignatureIndex(underlyingSymbol, attrData, description) != -1;
        }

internal abstract TAttributeData CreateSynthesizedAttribute(WellKnownMember constructor, TAttributeData attrData, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

internal abstract void ReportIndirectReferencesToLinkedAssemblies(TAssemblySymbol assembly, DiagnosticBag diagnostics);

protected abstract void OnGetTypesCompleted(ImmutableArray<TEmbeddedType> types, DiagnosticBag diagnostics);

protected abstract void ReportNameCollisionBetweenEmbeddedTypes(TEmbeddedType typeA, TEmbeddedType typeB, DiagnosticBag diagnostics);

protected abstract void ReportNameCollisionWithAlreadyDeclaredType(TEmbeddedType type, DiagnosticBag diagnostics);

protected abstract TAttributeData CreateCompilerGeneratedAttribute();
private sealed class TypeComparer : IComparer<TEmbeddedType>
{
public static readonly TypeComparer Instance ;

private TypeComparer()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(778,11238,11290);
DynAbs.Tracing.TraceSender.TraceExitConstructor(778,11238,11290);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778,11238,11290);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778,11238,11290);
}
		}

public int Compare(TEmbeddedType x, TEmbeddedType y)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(778,11306,12018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11391,11427);

Cci.INamespaceTypeDefinition 
dx = x
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11445,11481);

Cci.INamespaceTypeDefinition 
dy = y
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11501,11591);

int 
result = f_778_11514_11590(f_778_11529_11545(dx), f_778_11547_11563(dy), StringComparison.Ordinal)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11611,11969) || true) && (result == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(778,11611,11969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11668,11736);

result = f_778_11677_11735(f_778_11692_11699(dx), f_778_11701_11708(dy), StringComparison.Ordinal);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11760,11950) || true) && (result == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(778,11760,11950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11878,11927);

result = x.AssemblyRefIndex - y.AssemblyRefIndex;
DynAbs.Tracing.TraceSender.TraceExitCondition(778,11760,11950);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(778,11611,11969);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11989,12003);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(778,11306,12018);

string
f_778_11529_11545(Microsoft.Cci.INamespaceTypeDefinition
this_param)
{
var return_v = this_param.NamespaceName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11529, 11545);
return return_v;
}


string
f_778_11547_11563(Microsoft.Cci.INamespaceTypeDefinition
this_param)
{
var return_v = this_param.NamespaceName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11547, 11563);
return return_v;
}


int
f_778_11514_11590(string
strA,string
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 11514, 11590);
return return_v;
}


string?
f_778_11692_11699(Microsoft.Cci.INamespaceTypeDefinition
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11692, 11699);
return return_v;
}


string?
f_778_11701_11708(Microsoft.Cci.INamespaceTypeDefinition
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11701, 11708);
return return_v;
}


int
f_778_11677_11735(string?
strA,string?
strB,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, strB, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 11677, 11735);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778,11306,12018);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778,11306,12018);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static TypeComparer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(778,11071,12029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(778,11192,11221);
Instance = f_778_11203_11221();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(778,11071,12029);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778,11071,12029);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(778,11071,12029);

static Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.TypeComparer
f_778_11203_11221()
{
var return_v = new Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.TypeComparer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 11203, 11221);
return return_v;
}

}

        protected void EmbedReferences(Cci.ITypeDefinitionMember embeddedMember, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            var noPiaIndexer = new Cci.TypeReferenceIndexer(new EmitContext(ModuleBeingBuilt, syntaxNodeOpt, diagnostics, metadataOnly: false, includePrivateMembers: true));
            noPiaIndexer.Visit(embeddedMember);
        }

protected abstract TEmbeddedType GetEmbeddedTypeForMember(TSymbol member, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

internal abstract TEmbeddedField EmbedField(TEmbeddedType type, TFieldSymbol field, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

internal abstract TEmbeddedMethod EmbedMethod(TEmbeddedType type, TMethodSymbol method, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

internal abstract TEmbeddedProperty EmbedProperty(TEmbeddedType type, TPropertySymbol property, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

internal abstract TEmbeddedEvent EmbedEvent(TEmbeddedType type, TEventSymbol @event, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, bool isUsedForComAwareEventBinding);

        internal Cci.IFieldReference EmbedFieldIfNeedTo(TFieldSymbol fieldSymbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            TEmbeddedType type = GetEmbeddedTypeForMember(fieldSymbol, syntaxNodeOpt, diagnostics);
            if (type != null)
            {
                return EmbedField(type, fieldSymbol, syntaxNodeOpt, diagnostics);
            }
            return fieldSymbol;
        }

        internal Cci.IMethodReference EmbedMethodIfNeedTo(TMethodSymbol methodSymbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            TEmbeddedType type = GetEmbeddedTypeForMember(methodSymbol, syntaxNodeOpt, diagnostics);
            if (type != null)
            {
                return EmbedMethod(type, methodSymbol, syntaxNodeOpt, diagnostics);
            }
            return methodSymbol;
        }

        internal void EmbedEventIfNeedTo(TEventSymbol eventSymbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, bool isUsedForComAwareEventBinding)
        {
            TEmbeddedType type = GetEmbeddedTypeForMember(eventSymbol, syntaxNodeOpt, diagnostics);
            if (type != null)
            {
                EmbedEvent(type, eventSymbol, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
            }
        }

        internal void EmbedPropertyIfNeedTo(TPropertySymbol propertySymbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            TEmbeddedType type = GetEmbeddedTypeForMember(propertySymbol, syntaxNodeOpt, diagnostics);
            if (type != null)
            {
                EmbedProperty(type, propertySymbol, syntaxNodeOpt, diagnostics);
            }
        }

System.Collections.Concurrent.ConcurrentDictionary<TNamedTypeSymbol, TEmbeddedType>
f_778_5945_6038(Roslyn.Utilities.ReferenceEqualityComparer
comparer)
{
var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TNamedTypeSymbol, TEmbeddedType>( (System.Collections.Generic.IEqualityComparer<TNamedTypeSymbol>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 5945, 6038);
return return_v;
}


System.Collections.Concurrent.ConcurrentDictionary<TFieldSymbol, TEmbeddedField>
f_778_6136_6226(Roslyn.Utilities.ReferenceEqualityComparer
comparer)
{
var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TFieldSymbol, TEmbeddedField>( (System.Collections.Generic.IEqualityComparer<TFieldSymbol>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 6136, 6226);
return return_v;
}


System.Collections.Concurrent.ConcurrentDictionary<TMethodSymbol, TEmbeddedMethod>
f_778_6327_6419(Roslyn.Utilities.ReferenceEqualityComparer
comparer)
{
var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TMethodSymbol, TEmbeddedMethod>( (System.Collections.Generic.IEqualityComparer<TMethodSymbol>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 6327, 6419);
return return_v;
}


System.Collections.Concurrent.ConcurrentDictionary<TPropertySymbol, TEmbeddedProperty>
f_778_6527_6623(Roslyn.Utilities.ReferenceEqualityComparer
comparer)
{
var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TPropertySymbol, TEmbeddedProperty>( (System.Collections.Generic.IEqualityComparer<TPropertySymbol>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 6527, 6623);
return return_v;
}


System.Collections.Concurrent.ConcurrentDictionary<TEventSymbol, TEmbeddedEvent>
f_778_6721_6811(Roslyn.Utilities.ReferenceEqualityComparer
comparer)
{
var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TEventSymbol, TEmbeddedEvent>( (System.Collections.Generic.IEqualityComparer<TEventSymbol>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 6721, 6811);
return return_v;
}

}
}
