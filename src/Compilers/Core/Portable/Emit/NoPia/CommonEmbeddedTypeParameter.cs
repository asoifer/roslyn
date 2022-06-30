// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Cci = Microsoft.Cci;

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
{internal abstract class CommonEmbeddedTypeParameter : Cci.IGenericMethodParameter
{
public readonly TEmbeddedMethod ContainingMethod;

public readonly TTypeParameterSymbol UnderlyingTypeParameter;

protected CommonEmbeddedTypeParameter(TEmbeddedMethod containingMethod, TTypeParameterSymbol underlyingTypeParameter)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(777,1292,1571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,1184,1200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,1252,1275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,1442,1483);

this.ContainingMethod = containingMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,1501,1556);

this.UnderlyingTypeParameter = underlyingTypeParameter;
DynAbs.Tracing.TraceSender.TraceExitConstructor(777,1292,1571);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,1292,1571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,1292,1571);
}
		}

protected abstract IEnumerable<Cci.TypeReferenceWithAttributes> GetConstraints(EmitContext context);

protected abstract bool MustBeReferenceType {get; }

protected abstract bool MustBeValueType {get; }

protected abstract bool MustHaveDefaultConstructor {get; }

protected abstract string Name {get; }

protected abstract ushort Index {get; }

Cci.IMethodDefinition Cci.IGenericMethodParameter.DefiningMethod
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,2108,2195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,2152,2176);

return ContainingMethod;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,2108,2195);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,2011,2210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,2011,2210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

IEnumerable<Cci.TypeReferenceWithAttributes> Cci.IGenericParameter.GetConstraints(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,2226,2407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,2361,2392);

return f_777_2368_2391(this, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(777,2226,2407);

System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
f_777_2368_2391(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedTypeParameter
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetConstraints( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(777, 2368, 2391);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,2226,2407);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,2226,2407);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

bool Cci.IGenericParameter.MustBeReferenceType
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,2502,2592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,2546,2573);

return f_777_2553_2572();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,2502,2592);

bool
f_777_2553_2572()
{
var return_v = MustBeReferenceType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(777, 2553, 2572);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,2423,2607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,2423,2607);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IGenericParameter.MustBeValueType
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,2698,2784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,2742,2765);

return f_777_2749_2764();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,2698,2784);

bool
f_777_2749_2764()
{
var return_v = MustBeValueType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(777, 2749, 2764);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,2623,2799);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,2623,2799);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IGenericParameter.MustHaveDefaultConstructor
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,2901,2998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,2945,2979);

return f_777_2952_2978();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,2901,2998);

bool
f_777_2952_2978()
{
var return_v = MustHaveDefaultConstructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(777, 2952, 2978);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,2815,3013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,2815,3013);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.TypeParameterVariance Cci.IGenericParameter.Variance
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,3118,3288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,3225,3269);

return Cci.TypeParameterVariance.NonVariant;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,3118,3288);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,3029,3303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,3029,3303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericMethodParameter Cci.IGenericParameter.AsGenericMethodParameter
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,3426,3501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,3470,3482);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,3426,3501);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,3319,3516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,3319,3516);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericTypeParameter Cci.IGenericParameter.AsGenericTypeParameter
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,3635,3710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,3679,3691);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,3635,3710);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,3532,3725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,3532,3725);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeReference.IsEnum
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,3804,3825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,3810,3823);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,3804,3825);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,3741,3840);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,3741,3840);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ITypeReference.IsValueType
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,3924,3945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,3930,3943);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,3924,3945);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,3856,3960);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,3856,3960);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeDefinition Cci.ITypeReference.GetResolvedType(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,3976,4111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,4084,4096);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,3976,4111);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,3976,4111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,3976,4111);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,4209,4314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,4253,4295);

return Cci.PrimitiveTypeCode.NotPrimitive;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,4209,4314);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,4127,4329);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,4127,4329);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

TypeDefinitionHandle Cci.ITypeReference.TypeDef
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,4425,4470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,4431,4468);

return default(TypeDefinitionHandle);
DynAbs.Tracing.TraceSender.TraceExitMethod(777,4425,4470);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,4345,4485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,4345,4485);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericMethodParameterReference Cci.ITypeReference.AsGenericMethodParameterReference
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,4623,4643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,4629,4641);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,4623,4643);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,4501,4658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,4501,4658);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericTypeInstanceReference Cci.ITypeReference.AsGenericTypeInstanceReference
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,4790,4810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,4796,4808);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,4790,4810);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,4674,4825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,4674,4825);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericTypeParameterReference Cci.ITypeReference.AsGenericTypeParameterReference
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,4959,4979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,4965,4977);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,4959,4979);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,4841,4994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,4841,4994);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.INamespaceTypeDefinition Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,5010,5164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,5137,5149);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,5010,5164);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,5010,5164);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,5010,5164);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

Cci.INamespaceTypeReference Cci.ITypeReference.AsNamespaceTypeReference
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,5284,5304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,5290,5302);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,5284,5304);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,5180,5319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,5180,5319);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.INestedTypeDefinition Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,5335,5483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,5456,5468);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,5335,5483);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,5335,5483);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,5335,5483);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

Cci.INestedTypeReference Cci.ITypeReference.AsNestedTypeReference
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,5597,5617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,5603,5615);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,5597,5617);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,5499,5632);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,5499,5632);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ISpecializedNestedTypeReference Cci.ITypeReference.AsSpecializedNestedTypeReference
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,5768,5788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,5774,5786);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,5768,5788);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,5648,5803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,5648,5803);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeDefinition Cci.ITypeReference.AsTypeDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,5819,5955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,5928,5940);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,5819,5955);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,5819,5955);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,5819,5955);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,5971,6198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,6113,6183);

return f_777_6120_6182();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,5971,6198);

System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
f_777_6120_6182()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(777, 6120, 6182);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,5971,6198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,5971,6198);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,6214,6356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,6304,6341);

throw f_777_6310_6340();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,6214,6356);

System.Exception
f_777_6310_6340()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(777, 6310, 6340);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,6214,6356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,6214,6356);
}
		}

Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,6372,6496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,6469,6481);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,6372,6496);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,6372,6496);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,6372,6496);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(777,6584,6591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,6587,6591);
return null;DynAbs.Tracing.TraceSender.TraceExitMethod(777,6584,6591);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,6584,6591);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,6584,6591);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

string Cci.INamedEntity.Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,6669,6689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,6675,6687);

return f_777_6682_6686();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,6669,6689);

string
f_777_6682_6686()
{
var return_v = Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(777, 6682, 6686);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,6608,6704);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,6608,6704);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ushort Cci.IParameterListEntry.Index
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,6789,6865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,6833,6846);

return f_777_6840_6845();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,6789,6865);

ushort
f_777_6840_6845()
{
var return_v = Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(777, 6840, 6845);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,6720,6880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,6720,6880);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IMethodReference Cci.IGenericMethodParameterReference.DefiningMethod
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(777,7001,7033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,7007,7031);

return ContainingMethod;
DynAbs.Tracing.TraceSender.TraceExitMethod(777,7001,7033);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,6896,7048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,6896,7048);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public sealed override bool Equals(object obj)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,7064,7359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,7290,7344);

throw f_777_7296_7343();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,7064,7359);

System.Exception
f_777_7296_7343()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(777, 7296, 7343);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,7064,7359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,7064,7359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override int GetHashCode()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(777,7375,7664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(777,7595,7649);

throw f_777_7601_7648();
DynAbs.Tracing.TraceSender.TraceExitMethod(777,7375,7664);

System.Exception
f_777_7601_7648()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(777, 7601, 7648);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(777,7375,7664);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,7375,7664);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static CommonEmbeddedTypeParameter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(777,1046,7675);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(777,1046,7675);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(777,1046,7675);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(777,1046,7675);
}
}
}
