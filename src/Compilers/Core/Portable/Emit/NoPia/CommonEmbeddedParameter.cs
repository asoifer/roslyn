// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

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
{internal abstract class CommonEmbeddedParameter : Cci.IParameterDefinition
{
public readonly CommonEmbeddedMember ContainingPropertyOrMethod;

public readonly TParameterSymbol UnderlyingParameter;

private ImmutableArray<TAttributeData> _lazyAttributes;

protected CommonEmbeddedParameter(CommonEmbeddedMember containingPropertyOrMethod, TParameterSymbol underlyingParameter)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(774,1431,1725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,1252,1278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,1326,1345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,1584,1645);

this.ContainingPropertyOrMethod = containingPropertyOrMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,1663,1710);

this.UnderlyingParameter = underlyingParameter;
DynAbs.Tracing.TraceSender.TraceExitConstructor(774,1431,1725);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,1431,1725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,1431,1725);
}
		}

protected TEmbeddedTypesManager TypeManager
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,1817,1926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,1861,1907);

return f_774_1868_1906(ContainingPropertyOrMethod);
DynAbs.Tracing.TraceSender.TraceExitMethod(774,1817,1926);

TEmbeddedTypesManager
f_774_1868_1906(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMember
this_param)
{
var return_v = this_param.TypeManager;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 1868, 1906);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,1741,1941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,1741,1941);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected abstract bool HasDefaultValue {get; }

protected abstract MetadataConstant GetDefaultValue(EmitContext context);

protected abstract bool IsIn {get; }

protected abstract bool IsOut {get; }

protected abstract bool IsOptional {get; }

protected abstract bool IsMarshalledExplicitly {get; }

protected abstract Cci.IMarshallingInformation MarshallingInformation {get; }

protected abstract ImmutableArray<byte> MarshallingDescriptor {get; }

protected abstract string Name {get; }

protected abstract Cci.IParameterTypeInformation UnderlyingParameterTypeInformation {get; }

protected abstract ushort Index {get; }

protected abstract IEnumerable<TAttributeData> GetCustomAttributesToEmit(TPEModuleBuilder moduleBuilder);

            private bool IsTargetAttribute(TAttributeData attrData, AttributeDescription description)
            {
                return TypeManager.IsTargetAttribute(UnderlyingParameter, attrData, description);
            }

            private ImmutableArray<TAttributeData> GetAttributes(TPEModuleBuilder moduleBuilder, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
            {
                var builder = ArrayBuilder<TAttributeData>.GetInstance();

                // Copy some of the attributes.

                // Note, when porting attributes, we are not using constructors from original symbol.
                // The constructors might be missing (for example, in metadata case) and doing lookup
                // will ensure that we report appropriate errors.

                foreach (var attrData in GetCustomAttributesToEmit(moduleBuilder))
                {
                    if (IsTargetAttribute(attrData, AttributeDescription.ParamArrayAttribute))
                    {
                        if (attrData.CommonConstructorArguments.Length == 0)
                        {
                            builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_ParamArrayAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                        }
                    }
                    else if (IsTargetAttribute(attrData, AttributeDescription.DateTimeConstantAttribute))
                    {
                        if (attrData.CommonConstructorArguments.Length == 1)
                        {
                            builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_CompilerServices_DateTimeConstantAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                        }
                    }
                    else
                    {
                        int signatureIndex = TypeManager.GetTargetAttributeSignatureIndex(UnderlyingParameter, attrData, AttributeDescription.DecimalConstantAttribute);
                        if (signatureIndex != -1)
                        {
                            Debug.Assert(signatureIndex == 0 || signatureIndex == 1);

                            if (attrData.CommonConstructorArguments.Length == 5)
                            {
                                builder.AddOptional(TypeManager.CreateSynthesizedAttribute(
                                    signatureIndex == 0 ? WellKnownMember.System_Runtime_CompilerServices_DecimalConstantAttribute__ctor :
                                        WellKnownMember.System_Runtime_CompilerServices_DecimalConstantAttribute__ctorByteByteInt32Int32Int32,
                                    attrData, syntaxNodeOpt, diagnostics));
                            }
                        }
                        else if (IsTargetAttribute(attrData, AttributeDescription.DefaultParameterValueAttribute))
                        {
                            if (attrData.CommonConstructorArguments.Length == 1)
                            {
                                builder.AddOptional(TypeManager.CreateSynthesizedAttribute(WellKnownMember.System_Runtime_InteropServices_DefaultParameterValueAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                            }
                        }
                    }
                }

                return builder.ToImmutableAndFree();
            }

bool Cci.IParameterDefinition.HasDefaultValue
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,6433,6519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,6477,6500);

return f_774_6484_6499();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,6433,6519);

bool
f_774_6484_6499()
{
var return_v = HasDefaultValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 6484, 6499);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,6355,6534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,6355,6534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

MetadataConstant Cci.IParameterDefinition.GetDefaultValue(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,6550,6708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,6661,6693);

return f_774_6668_6692(this, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(774,6550,6708);

Microsoft.CodeAnalysis.CodeGen.MetadataConstant
f_774_6668_6692(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedParameter
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetDefaultValue( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(774, 6668, 6692);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,6550,6708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,6550,6708);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

bool Cci.IParameterDefinition.IsIn
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,6791,6866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,6835,6847);

return f_774_6842_6846();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,6791,6866);

bool
f_774_6842_6846()
{
var return_v = IsIn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 6842, 6846);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,6724,6881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,6724,6881);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IParameterDefinition.IsOut
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,6965,7041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,7009,7022);

return f_774_7016_7021();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,6965,7041);

bool
f_774_7016_7021()
{
var return_v = IsOut;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 7016, 7021);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,6897,7056);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,6897,7056);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IParameterDefinition.IsOptional
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,7145,7226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,7189,7207);

return f_774_7196_7206();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,7145,7226);

bool
f_774_7196_7206()
{
var return_v = IsOptional;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 7196, 7206);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,7072,7241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,7072,7241);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IParameterDefinition.IsMarshalledExplicitly
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,7342,7435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,7386,7416);

return f_774_7393_7415();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,7342,7435);

bool
f_774_7393_7415()
{
var return_v = IsMarshalledExplicitly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 7393, 7415);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,7257,7450);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,7257,7450);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IMarshallingInformation Cci.IParameterDefinition.MarshallingInformation
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,7574,7667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,7618,7648);

return f_774_7625_7647();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,7574,7667);

Microsoft.Cci.IMarshallingInformation
f_774_7625_7647()
{
var return_v = MarshallingInformation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 7625, 7647);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,7466,7682);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,7466,7682);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ImmutableArray<byte> Cci.IParameterDefinition.MarshallingDescriptor
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,7798,7890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,7842,7871);

return f_774_7849_7870();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,7798,7890);

System.Collections.Immutable.ImmutableArray<byte>
f_774_7849_7870()
{
var return_v = MarshallingDescriptor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 7849, 7870);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,7698,7905);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,7698,7905);
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
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,8714,8856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,8804,8841);

throw f_774_8810_8840();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,8714,8856);

System.Exception
f_774_8810_8840()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 8810, 8840);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,8714,8856);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,8714,8856);
}
		}

Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,8872,8996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,8969,8981);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(774,8872,8996);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,8872,8996);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,8872,8996);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(774,9084,9091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,9087,9091);
return null;DynAbs.Tracing.TraceSender.TraceExitMethod(774,9084,9091);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,9084,9091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,9084,9091);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

string Cci.INamedEntity.Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(774,9169,9189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,9175,9187);

return f_774_9182_9186();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,9169,9189);

string
f_774_9182_9186()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 9182, 9186);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,9108,9204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,9108,9204);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ImmutableArray<Cci.ICustomModifier> Cci.IParameterTypeInformation.CustomModifiers
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,9334,9455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,9378,9436);

return f_774_9385_9435(f_774_9385_9419());
DynAbs.Tracing.TraceSender.TraceExitMethod(774,9334,9455);

Microsoft.Cci.IParameterTypeInformation
f_774_9385_9419()
{
var return_v = UnderlyingParameterTypeInformation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 9385, 9419);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
f_774_9385_9435(Microsoft.Cci.IParameterTypeInformation
this_param)
{
var return_v = this_param.CustomModifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 9385, 9435);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,9220,9470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,9220,9470);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IParameterTypeInformation.IsByReference
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,9567,9686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,9611,9667);

return f_774_9618_9666(f_774_9618_9652());
DynAbs.Tracing.TraceSender.TraceExitMethod(774,9567,9686);

Microsoft.Cci.IParameterTypeInformation
f_774_9618_9652()
{
var return_v = UnderlyingParameterTypeInformation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 9618, 9652);
return return_v;
}


bool
f_774_9618_9666(Microsoft.Cci.IParameterTypeInformation
this_param)
{
var return_v = this_param.IsByReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 9618, 9666);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,9486,9701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,9486,9701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ImmutableArray<Cci.ICustomModifier> Cci.IParameterTypeInformation.RefCustomModifiers
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,9834,9958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,9878,9939);

return f_774_9885_9938(f_774_9885_9919());
DynAbs.Tracing.TraceSender.TraceExitMethod(774,9834,9958);

Microsoft.Cci.IParameterTypeInformation
f_774_9885_9919()
{
var return_v = UnderlyingParameterTypeInformation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 9885, 9919);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
f_774_9885_9938(Microsoft.Cci.IParameterTypeInformation
this_param)
{
var return_v = this_param.RefCustomModifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 9885, 9938);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,9717,9973);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,9717,9973);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeReference Cci.IParameterTypeInformation.GetType(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,9989,10173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,10099,10158);

return f_774_10106_10157(f_774_10106_10140(), context);
DynAbs.Tracing.TraceSender.TraceExitMethod(774,9989,10173);

Microsoft.Cci.IParameterTypeInformation
f_774_10106_10140()
{
var return_v = UnderlyingParameterTypeInformation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 10106, 10140);
return return_v;
}


Microsoft.Cci.ITypeReference
f_774_10106_10157(Microsoft.Cci.IParameterTypeInformation
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetType( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(774, 10106, 10157);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,9989,10173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,9989,10173);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

ushort Cci.IParameterListEntry.Index
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,10258,10334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,10302,10315);

return f_774_10309_10314();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,10258,10334);

ushort
f_774_10309_10314()
{
var return_v = Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 10309, 10314);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,10189,10349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,10189,10349);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override string ToString()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,10468,10646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,10534,10631);

return f_774_10541_10630(((ISymbol)UnderlyingParameter), SymbolDisplayFormat.ILVisualizationFormat);
DynAbs.Tracing.TraceSender.TraceExitMethod(774,10468,10646);

string
f_774_10541_10630(Microsoft.CodeAnalysis.ISymbol
this_param,Microsoft.CodeAnalysis.SymbolDisplayFormat
format)
{
var return_v = this_param.ToDisplayString( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(774, 10541, 10630);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,10468,10646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,10468,10646);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override bool Equals(object obj)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,10662,10957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,10888,10942);

throw f_774_10894_10941();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,10662,10957);

System.Exception
f_774_10894_10941()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 10894, 10941);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,10662,10957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,10662,10957);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override int GetHashCode()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(774,10973,11262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(774,11193,11247);

throw f_774_11199_11246();
DynAbs.Tracing.TraceSender.TraceExitMethod(774,10973,11262);

System.Exception
f_774_11199_11246()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(774, 11199, 11246);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(774,10973,11262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,10973,11262);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static CommonEmbeddedParameter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(774,1116,11273);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(774,1116,11273);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(774,1116,11273);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(774,1116,11273);
}
}
}
