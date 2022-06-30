// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.Emit.NoPia
{
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
        TEmbeddedTypeParameter>
{internal abstract class CommonEmbeddedType : Cci.INamespaceTypeDefinition
{
public readonly TEmbeddedTypesManager TypeManager;

public readonly TNamedTypeSymbol UnderlyingNamedType;

private ImmutableArray<Cci.IFieldDefinition> _lazyFields;

private ImmutableArray<Cci.IMethodDefinition> _lazyMethods;

private ImmutableArray<Cci.IPropertyDefinition> _lazyProperties;

private ImmutableArray<Cci.IEventDefinition> _lazyEvents;

private ImmutableArray<TAttributeData> _lazyAttributes;

private int _lazyAssemblyRefIndex ;

protected CommonEmbeddedType(TEmbeddedTypesManager typeManager, TNamedTypeSymbol underlyingNamedType)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(776,1799,2044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,1287,1298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,1346,1365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,1756,1782);
this._lazyAssemblyRefIndex = -1;DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,1933,1964);

this.TypeManager = typeManager;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,1982,2029);

this.UnderlyingNamedType = underlyingNamedType;
DynAbs.Tracing.TraceSender.TraceExitConstructor(776,1799,2044);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,1799,2044);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,1799,2044);
}
		}

protected abstract int GetAssemblyRefIndex();

protected abstract IEnumerable<TFieldSymbol> GetFieldsToEmit();

protected abstract IEnumerable<TMethodSymbol> GetMethodsToEmit();

protected abstract IEnumerable<TEventSymbol> GetEventsToEmit();

protected abstract IEnumerable<TPropertySymbol> GetPropertiesToEmit();

protected abstract bool IsPublic {get; }

protected abstract bool IsAbstract {get; }

protected abstract Cci.ITypeReference GetBaseClass(TPEModuleBuilder moduleBuilder, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

protected abstract IEnumerable<Cci.TypeReferenceWithAttributes> GetInterfaces(EmitContext context);

protected abstract bool IsBeforeFieldInit {get; }

protected abstract bool IsComImport {get; }

protected abstract bool IsInterface {get; }

protected abstract bool IsDelegate {get; }

protected abstract bool IsSerializable {get; }

protected abstract bool IsSpecialName {get; }

protected abstract bool IsWindowsRuntimeImport {get; }

protected abstract bool IsSealed {get; }

protected abstract TypeLayout? GetTypeLayoutIfStruct();

protected abstract System.Runtime.InteropServices.CharSet StringFormat {get; }

protected abstract TAttributeData CreateTypeIdentifierAttribute(bool hasGuid, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

protected abstract void EmbedDefaultMembers(string defaultMember, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

protected abstract IEnumerable<TAttributeData> GetCustomAttributesToEmit(TPEModuleBuilder moduleBuilder);

protected abstract void ReportMissingAttribute(AttributeDescription description, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

            private bool IsTargetAttribute(TAttributeData attrData, AttributeDescription description)
            {
                return TypeManager.IsTargetAttribute(UnderlyingNamedType, attrData, description);
            }

            private ImmutableArray<TAttributeData> GetAttributes(TPEModuleBuilder moduleBuilder, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
            {
                var builder = ArrayBuilder<TAttributeData>.GetInstance();

                // Put the CompilerGenerated attribute on the NoPIA types we define so that 
                // static analysis tools (e.g. fxcop) know that they can be skipped
                builder.AddOptional(TypeManager.CreateCompilerGeneratedAttribute());

                // Copy some of the attributes.

                bool hasGuid = false;
                bool hasComEventInterfaceAttribute = false;

                // Note, when porting attributes, we are not using constructors from original symbol.
                // The constructors might be missing (for example, in metadata case) and doing lookup
                // will ensure that we report appropriate errors.

                foreach (var attrData in GetCustomAttributesToEmit(moduleBuilder))
                {
                    if (IsTargetAttribute(attrData, AttributeDescription.GuidAttribute))
                    {
                        string guidString;
                        if (attrData.TryGetGuidAttributeValue(out guidString))
                        {
                            // If this type has a GuidAttribute, we should emit it.
                            hasGuid = true;
                            builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_InteropServices_GuidAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                        }
                    }
                    else if (IsTargetAttribute(attrData, AttributeDescription.ComEventInterfaceAttribute))
                    {
                        if (attrData.CommonConstructorArguments.Length == 2)
                        {
                            hasComEventInterfaceAttribute = true;
                            builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_InteropServices_ComEventInterfaceAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                        }
                    }
                    else
                    {
                        int signatureIndex = TypeManager.GetTargetAttributeSignatureIndex(UnderlyingNamedType, attrData, AttributeDescription.InterfaceTypeAttribute);
                        if (signatureIndex != -1)
                        {
                            Debug.Assert(signatureIndex == 0 || signatureIndex == 1);
                            if (attrData.CommonConstructorArguments.Length == 1)
                            {
                                builder.AddOptional(TypeManager.CreateSynthesizedAttribute(signatureIndex == 0 ? WellKnownMember.System_Runtime_InteropServices_InterfaceTypeAttribute__ctorInt16 :
                                    WellKnownMember.System_Runtime_InteropServices_InterfaceTypeAttribute__ctorComInterfaceType,
                                    attrData, syntaxNodeOpt, diagnostics));
                            }
                        }
                        else if (IsTargetAttribute(attrData, AttributeDescription.BestFitMappingAttribute))
                        {
                            if (attrData.CommonConstructorArguments.Length == 1)
                            {
                                builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_InteropServices_BestFitMappingAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                            }
                        }
                        else if (IsTargetAttribute(attrData, AttributeDescription.CoClassAttribute))
                        {
                            if (attrData.CommonConstructorArguments.Length == 1)
                            {
                                builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_InteropServices_CoClassAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                            }
                        }
                        else if (IsTargetAttribute(attrData, AttributeDescription.FlagsAttribute))
                        {
                            if (attrData.CommonConstructorArguments.Length == 0 && UnderlyingNamedType.IsEnum)
                            {
                                builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_FlagsAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                            }
                        }
                        else if (IsTargetAttribute(attrData, AttributeDescription.DefaultMemberAttribute))
                        {
                            if (attrData.CommonConstructorArguments.Length == 1)
                            {
                                builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Reflection_DefaultMemberAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));

                                // Embed members matching default member name.
                                string defaultMember = attrData.CommonConstructorArguments[0].ValueInternal as string;
                                if (defaultMember != null)
                                {
                                    EmbedDefaultMembers(defaultMember, syntaxNodeOpt, diagnostics);
                                }
                            }
                        }
                        else if (IsTargetAttribute(attrData, AttributeDescription.UnmanagedFunctionPointerAttribute))
                        {
                            if (attrData.CommonConstructorArguments.Length == 1)
                            {
                                builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_InteropServices_UnmanagedFunctionPointerAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                            }
                        }
                    }
                }

                // We must emit a TypeIdentifier attribute which connects this local type with the canonical type. 
                // Interfaces usually have a guid attribute, in which case the TypeIdentifier attribute we emit will
                // not need any additional parameters. For interfaces which lack a guid and all other types, we must 
                // emit a TypeIdentifier that has parameters identifying the scope and name of the original type. We 
                // will use the Assembly GUID as the scope identifier.

                if (IsInterface && !hasComEventInterfaceAttribute)
                {
                    if (!IsComImport)
                    {
                        // If we have an interface not marked ComImport, but the assembly is linked, then
                        // we need to give an error. We allow event interfaces to not have ComImport marked on them.
                        // ERRID_NoPIAAttributeMissing2/ERR_InteropTypeMissingAttribute
                        ReportMissingAttribute(AttributeDescription.ComImportAttribute, syntaxNodeOpt, diagnostics);
                    }
                    else if (!hasGuid)
                    {
                        // Interfaces used with No-PIA ought to have a guid attribute, or the CLR cannot do type unification. 
                        // This interface lacks a guid, so unification probably won't work. We allow event interfaces to not have a Guid.
                        // ERRID_NoPIAAttributeMissing2/ERR_InteropTypeMissingAttribute
                        ReportMissingAttribute(AttributeDescription.GuidAttribute, syntaxNodeOpt, diagnostics);
                    }
                }

                // Note, this logic should match the one in RetargetingSymbolTranslator.RetargetNoPiaLocalType
                // when we try to predict what attributes we will emit on embedded type, which corresponds the 
                // type we are retargeting.

                builder.AddOptional(CreateTypeIdentifierAttribute(hasGuid && IsInterface, syntaxNodeOpt, diagnostics));

                return builder.ToImmutableAndFree();
            }

public int AssemblyRefIndex
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,12737,13068);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,12781,12998) || true) && (_lazyAssemblyRefIndex == -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(776,12781,12998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,12862,12908);

_lazyAssemblyRefIndex = f_776_12886_12907(this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,12934,12975);

f_776_12934_12974(_lazyAssemblyRefIndex >= 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(776,12781,12998);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,13020,13049);

return _lazyAssemblyRefIndex;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,12737,13068);

int
f_776_12886_12907(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
this_param)
{
var return_v = this_param.GetAssemblyRefIndex();
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 12886, 12907);
return return_v;
}


int
f_776_12934_12974(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 12934, 12974);
return 0;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,12677,13083);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,12677,13083);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.INamespaceTypeDefinition.IsPublic
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,13174,13253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,13218,13234);

return f_776_13225_13233();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,13174,13253);

bool
f_776_13225_13233()
{
var return_v = IsPublic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 13225, 13233);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,13099,13268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,13099,13268);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeReference Cci.ITypeDefinition.GetBaseClass(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,13284,13515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,13389,13500);

return f_776_13396_13499(this, context.Module, context.SyntaxNodeOpt, context.Diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,13284,13515);

Microsoft.Cci.ITypeReference
f_776_13396_13499(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
this_param,Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
moduleBuilder,Microsoft.CodeAnalysis.SyntaxNode
syntaxNodeOpt,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.GetBaseClass( (TPEModuleBuilder)moduleBuilder, (TSyntaxNode)syntaxNodeOpt, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 13396, 13499);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,13284,13515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,13284,13515);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

            IEnumerable<Cci.IEventDefinition> Cci.ITypeDefinition.GetEvents(EmitContext context)
            {
                if (_lazyEvents.IsDefault)
                {
                    Debug.Assert(TypeManager.IsFrozen);

                    var builder = ArrayBuilder<Cci.IEventDefinition>.GetInstance();

                    foreach (var e in GetEventsToEmit())
                    {
                        TEmbeddedEvent embedded;

                        if (TypeManager.EmbeddedEventsMap.TryGetValue(e, out embedded))
                        {
                            builder.Add(embedded);
                        }
                    }

                    ImmutableInterlocked.InterlockedInitialize(ref _lazyEvents, builder.ToImmutableAndFree());
                }

                return _lazyEvents;
            }

IEnumerable<Cci.MethodImplementation> Cci.ITypeDefinition.GetExplicitImplementationOverrides(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,14393,14628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,14539,14613);

return f_776_14546_14612();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,14393,14628);

System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
f_776_14546_14612()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.MethodImplementation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14546, 14612);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,14393,14628);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,14393,14628);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

            IEnumerable<Cci.IFieldDefinition> Cci.ITypeDefinition.GetFields(EmitContext context)
            {
                if (_lazyFields.IsDefault)
                {
                    Debug.Assert(TypeManager.IsFrozen);

                    var builder = ArrayBuilder<Cci.IFieldDefinition>.GetInstance();

                    foreach (var f in GetFieldsToEmit())
                    {
                        TEmbeddedField embedded;

                        if (TypeManager.EmbeddedFieldsMap.TryGetValue(f, out embedded))
                        {
                            builder.Add(embedded);
                        }
                    }

                    ImmutableInterlocked.InterlockedInitialize(ref _lazyFields, builder.ToImmutableAndFree());
                }

                return _lazyFields;
            }

IEnumerable<Cci.IGenericTypeParameter> Cci.ITypeDefinition.GenericParameters
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,15615,15753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,15659,15734);

return f_776_15666_15733();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,15615,15753);

System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
f_776_15666_15733()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.IGenericTypeParameter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 15666, 15733);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,15506,15768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,15506,15768);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ushort Cci.ITypeDefinition.GenericParameterCount
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,15865,15937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,15909,15918);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,15865,15937);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,15784,15952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,15784,15952);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.HasDeclarativeSecurity
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,16048,16210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,16178,16191);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,16048,16210);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,15968,16225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,15968,16225);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

IEnumerable<Cci.TypeReferenceWithAttributes> Cci.ITypeDefinition.Interfaces(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,16241,16415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,16370,16400);

return f_776_16377_16399(this, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,16241,16415);

System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
f_776_16377_16399(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetInterfaces( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 16377, 16399);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,16241,16415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,16241,16415);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

bool Cci.ITypeDefinition.IsAbstract
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,16499,16580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,16543,16561);

return f_776_16550_16560();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,16499,16580);

bool
f_776_16550_16560()
{
var return_v = IsAbstract;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 16550, 16560);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,16431,16595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,16431,16595);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsBeforeFieldInit
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,16686,16774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,16730,16755);

return f_776_16737_16754();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,16686,16774);

bool
f_776_16737_16754()
{
var return_v = IsBeforeFieldInit;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 16737, 16754);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,16611,16789);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,16611,16789);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsComObject
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,16874,16971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,16918,16952);

return f_776_16925_16936()||(DynAbs.Tracing.TraceSender.Expression_False(776, 16925, 16951)||f_776_16940_16951());
DynAbs.Tracing.TraceSender.TraceExitMethod(776,16874,16971);

bool
f_776_16925_16936()
{
var return_v = IsInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 16925, 16936);
return return_v;
}


bool
f_776_16940_16951()
{
var return_v = IsComImport;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 16940, 16951);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,16805,16986);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,16805,16986);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsGeneric
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,17069,17145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,17113,17126);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,17069,17145);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,17002,17160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,17002,17160);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsInterface
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,17245,17327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,17289,17308);

return f_776_17296_17307();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,17245,17327);

bool
f_776_17296_17307()
{
var return_v = IsInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 17296, 17307);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,17176,17342);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,17176,17342);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsDelegate
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,17426,17507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,17470,17488);

return f_776_17477_17487();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,17426,17507);

bool
f_776_17477_17487()
{
var return_v = IsDelegate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 17477, 17487);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,17358,17522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,17358,17522);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsRuntimeSpecial
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,17612,17688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,17656,17669);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,17612,17688);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,17538,17703);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,17538,17703);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsSerializable
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,17791,17876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,17835,17857);

return f_776_17842_17856();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,17791,17876);

bool
f_776_17842_17856()
{
var return_v = IsSerializable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 17842, 17856);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,17719,17891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,17719,17891);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsSpecialName
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,17978,18062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,18022,18043);

return f_776_18029_18042();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,17978,18062);

bool
f_776_18029_18042()
{
var return_v = IsSpecialName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18029, 18042);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,17907,18077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,17907,18077);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsWindowsRuntimeImport
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,18173,18266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,18217,18247);

return f_776_18224_18246();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,18173,18266);

bool
f_776_18224_18246()
{
var return_v = IsWindowsRuntimeImport;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18224, 18246);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,18093,18281);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,18093,18281);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeDefinition.IsSealed
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,18363,18442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,18407,18423);

return f_776_18414_18422();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,18363,18442);

bool
f_776_18414_18422()
{
var return_v = IsSealed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18414, 18422);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,18297,18457);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,18297,18457);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

System.Runtime.InteropServices.LayoutKind Cci.ITypeDefinition.Layout
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,18574,18766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,18618,18655);

var 
layout = f_776_18631_18654(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,18677,18747);

return f_776_18684_18696_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(layout, 776, 18684, 18696)?.Kind)??(DynAbs.Tracing.TraceSender.Expression_Null<System.Runtime.InteropServices.LayoutKind?>(776, 18684, 18746)??System.Runtime.InteropServices.LayoutKind.Auto);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,18574,18766);

Microsoft.CodeAnalysis.TypeLayout?
f_776_18631_18654(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
this_param)
{
var return_v = this_param.GetTypeLayoutIfStruct();
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 18631, 18654);
return return_v;
}


System.Runtime.InteropServices.LayoutKind?
f_776_18684_18696_M(System.Runtime.InteropServices.LayoutKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18684, 18696);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,18473,18781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,18473,18781);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ushort Cci.ITypeDefinition.Alignment
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,18866,19028);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,18910,18947);

var 
layout = f_776_18923_18946(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,18969,19009);

return (ushort)(f_776_18985_19002_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(layout, 776, 18985, 19002)?.Alignment)??(DynAbs.Tracing.TraceSender.Expression_Null<short?>(776, 18985, 19007)??0));
DynAbs.Tracing.TraceSender.TraceExitMethod(776,18866,19028);

Microsoft.CodeAnalysis.TypeLayout?
f_776_18923_18946(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
this_param)
{
var return_v = this_param.GetTypeLayoutIfStruct();
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 18923, 18946);
return return_v;
}


short?
f_776_18985_19002_M(short?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18985, 19002);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,18797,19043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,18797,19043);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

uint Cci.ITypeDefinition.SizeOf
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,19123,19278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,19167,19204);

var 
layout = f_776_19180_19203(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,19226,19259);

return (uint)(f_776_19240_19252_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(layout, 776, 19240, 19252)?.Size)??(DynAbs.Tracing.TraceSender.Expression_Null<int?>(776, 19240, 19257)??0));
DynAbs.Tracing.TraceSender.TraceExitMethod(776,19123,19278);

Microsoft.CodeAnalysis.TypeLayout?
f_776_19180_19203(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
this_param)
{
var return_v = this_param.GetTypeLayoutIfStruct();
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 19180, 19203);
return return_v;
}


int?
f_776_19240_19252_M(int?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 19240, 19252);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,19059,19293);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,19059,19293);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

            IEnumerable<Cci.IMethodDefinition> Cci.ITypeDefinition.GetMethods(EmitContext context)
            {
                if (_lazyMethods.IsDefault)
                {
                    Debug.Assert(TypeManager.IsFrozen);

                    var builder = ArrayBuilder<Cci.IMethodDefinition>.GetInstance();

                    int gapIndex = 1;
                    int gapSize = 0;

                    foreach (var method in GetMethodsToEmit())
                    {
                        if ((object)method != null)
                        {
                            TEmbeddedMethod embedded;

                            if (TypeManager.EmbeddedMethodsMap.TryGetValue(method, out embedded))
                            {
                                if (gapSize > 0)
                                {
                                    builder.Add(new VtblGap(this, ModuleExtensions.GetVTableGapName(gapIndex, gapSize)));
                                    gapIndex++;
                                    gapSize = 0;
                                }

                                builder.Add(embedded);
                            }
                            else
                            {
                                gapSize++;
                            }
                        }
                        else
                        {
                            gapSize++;
                        }
                    }

                    ImmutableInterlocked.InterlockedInitialize(ref _lazyMethods, builder.ToImmutableAndFree());
                }

                return _lazyMethods;
            }

IEnumerable<Cci.INestedTypeDefinition> Cci.ITypeDefinition.GetNestedTypes(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,21004,21221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,21131,21206);

return f_776_21138_21205();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,21004,21221);

System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
f_776_21138_21205()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.INestedTypeDefinition>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21138, 21205);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,21004,21221);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,21004,21221);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

            IEnumerable<Cci.IPropertyDefinition> Cci.ITypeDefinition.GetProperties(EmitContext context)
            {
                if (_lazyProperties.IsDefault)
                {
                    Debug.Assert(TypeManager.IsFrozen);

                    var builder = ArrayBuilder<Cci.IPropertyDefinition>.GetInstance();

                    foreach (var p in GetPropertiesToEmit())
                    {
                        TEmbeddedProperty embedded;

                        if (TypeManager.EmbeddedPropertiesMap.TryGetValue(p, out embedded))
                        {
                            builder.Add(embedded);
                        }
                    }

                    ImmutableInterlocked.InterlockedInitialize(ref _lazyProperties, builder.ToImmutableAndFree());
                }

                return _lazyProperties;
            }

IEnumerable<Cci.SecurityAttribute> Cci.ITypeDefinition.SecurityAttributes
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,22238,22458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,22368,22439);

return f_776_22375_22438();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,22238,22458);

System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
f_776_22375_22438()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.SecurityAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 22375, 22438);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,22132,22473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,22132,22473);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

System.Runtime.InteropServices.CharSet Cci.ITypeDefinition.StringFormat
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,22593,22676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,22637,22657);

return f_776_22644_22656();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,22593,22676);

System.Runtime.InteropServices.CharSet
f_776_22644_22656()
{
var return_v = StringFormat;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 22644, 22656);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,22489,22691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,22489,22691);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

            IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
            {
                if (_lazyAttributes.IsDefault)
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var attributes = GetAttributes((TPEModuleBuilder)context.Module, (TSyntaxNode)context.SyntaxNodeOpt, diagnostics);

                    if (ImmutableInterlocked.InterlockedInitialize(ref _lazyAttributes, attributes))
                    {
                        // Save any diagnostics that we encountered.
                        context.Diagnostics.AddRange(diagnostics);
                    }

                    diagnostics.Free();
                }

                return _lazyAttributes;
            }

void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,23500,23642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,23590,23627);

throw f_776_23596_23626();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,23500,23642);

System.Exception
f_776_23596_23626()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 23596, 23626);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,23500,23642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,23500,23642);
}
		}

Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,23658,23782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,23755,23767);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,23658,23782);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,23658,23782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,23658,23782);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(776,23870,23877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,23873,23877);
return null;DynAbs.Tracing.TraceSender.TraceExitMethod(776,23870,23877);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,23870,23877);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,23870,23877);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

bool Cci.ITypeReference.IsEnum
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,23957,24054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,24001,24035);

return f_776_24008_24034(UnderlyingNamedType);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,23957,24054);

bool
f_776_24008_24034(TNamedTypeSymbol
this_param)
{
var return_v = this_param.IsEnum;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 24008, 24034);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,23894,24069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,23894,24069);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeReference.IsValueType
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,24153,24255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,24197,24236);

return f_776_24204_24235(UnderlyingNamedType);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,24153,24255);

bool
f_776_24204_24235(TNamedTypeSymbol
this_param)
{
var return_v = this_param.IsValueType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 24204, 24235);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,24085,24270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,24085,24270);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeDefinition Cci.ITypeReference.GetResolvedType(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,24286,24421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,24394,24406);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,24286,24421);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,24286,24421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,24286,24421);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,24519,24624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,24563,24605);

return Cci.PrimitiveTypeCode.NotPrimitive;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,24519,24624);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,24437,24639);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,24437,24639);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

TypeDefinitionHandle Cci.ITypeReference.TypeDef
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,24735,24835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,24779,24816);

return default(TypeDefinitionHandle);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,24735,24835);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,24655,24850);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,24655,24850);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericMethodParameterReference Cci.ITypeReference.AsGenericMethodParameterReference
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,24988,25063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,25032,25044);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,24988,25063);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,24866,25078);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,24866,25078);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericTypeInstanceReference Cci.ITypeReference.AsGenericTypeInstanceReference
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,25210,25285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,25254,25266);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,25210,25285);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,25094,25300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,25094,25300);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericTypeParameterReference Cci.ITypeReference.AsGenericTypeParameterReference
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,25434,25509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,25478,25490);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,25434,25509);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,25316,25524);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,25316,25524);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.INamespaceTypeDefinition Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,25540,25694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,25667,25679);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,25540,25694);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,25540,25694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,25540,25694);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

Cci.INamespaceTypeReference Cci.ITypeReference.AsNamespaceTypeReference
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,25814,25889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,25858,25870);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,25814,25889);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,25710,25904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,25710,25904);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.INestedTypeDefinition Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,25920,26068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,26041,26053);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,25920,26068);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,25920,26068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,25920,26068);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

Cci.INestedTypeReference Cci.ITypeReference.AsNestedTypeReference
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,26182,26257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,26226,26238);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,26182,26257);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,26084,26272);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,26084,26272);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ISpecializedNestedTypeReference Cci.ITypeReference.AsSpecializedNestedTypeReference
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,26408,26483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,26452,26464);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,26408,26483);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,26288,26498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,26288,26498);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeDefinition Cci.ITypeReference.AsTypeDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,26514,26650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,26623,26635);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,26514,26650);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,26514,26650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,26514,26650);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

ushort Cci.INamedTypeReference.GenericParameterCount
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,26751,26823);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,26795,26804);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,26751,26823);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,26666,26838);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,26666,26838);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.INamedTypeReference.MangleName
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,26926,27027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,26970,27008);

return f_776_26977_27007(UnderlyingNamedType);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,26926,27027);

bool
f_776_26977_27007(TNamedTypeSymbol
this_param)
{
var return_v = this_param.MangleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 26977, 27007);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,26854,27042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,26854,27042);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

string Cci.INamedEntity.Name
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,27119,27214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,27163,27195);

return f_776_27170_27194(UnderlyingNamedType);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,27119,27214);

string?
f_776_27170_27194(TNamedTypeSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 27170, 27194);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,27058,27229);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,27058,27229);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IUnitReference Cci.INamespaceTypeReference.GetUnit(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,27245,27404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,27353,27389);

return TypeManager.ModuleBeingBuilt;
DynAbs.Tracing.TraceSender.TraceExitMethod(776,27245,27404);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,27245,27404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,27245,27404);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

string Cci.INamespaceTypeReference.NamespaceName
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,27501,27605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,27545,27586);

return f_776_27552_27585(UnderlyingNamedType);
DynAbs.Tracing.TraceSender.TraceExitMethod(776,27501,27605);

string
f_776_27552_27585(TNamedTypeSymbol
this_param)
{
var return_v = this_param.NamespaceName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 27552, 27585);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,27420,27620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,27420,27620);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

            /// <remarks>
            /// This is only used for testing.
            /// </remarks>
            public override string ToString()
            {
                return UnderlyingNamedType.GetInternalSymbol().GetISymbol().ToDisplayString(SymbolDisplayFormat.ILVisualizationFormat);
            }

public sealed override bool Equals(object obj)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,27955,28250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,28181,28235);

throw f_776_28187_28234();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,27955,28250);

System.Exception
f_776_28187_28234()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 28187, 28234);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,27955,28250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,27955,28250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override int GetHashCode()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(776,28266,28555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(776,28486,28540);

throw f_776_28492_28539();
DynAbs.Tracing.TraceSender.TraceExitMethod(776,28266,28555);

System.Exception
f_776_28492_28539()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 28492, 28539);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776,28266,28555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,28266,28555);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static CommonEmbeddedType()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(776,1151,28566);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(776,1151,28566);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776,1151,28566);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(776,1151,28566);
}
}
}
