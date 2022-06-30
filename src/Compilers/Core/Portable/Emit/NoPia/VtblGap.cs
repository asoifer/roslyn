// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Roslyn.Utilities;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Emit.NoPia
{
internal sealed class VtblGap : Cci.IMethodDefinition
{
public readonly Cci.ITypeDefinition ContainingType;

private readonly string _name;

public VtblGap(Cci.ITypeDefinition containingType, string name)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(779,553,716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,486,500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,535,540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,641,678);

this.ContainingType = containingType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,692,705);

_name = name;
DynAbs.Tracing.TraceSender.TraceExitConstructor(779,553,716);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,553,716);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,553,716);
}
		}

Cci.IMethodBody Cci.IMethodDefinition.GetBody(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,728,842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,819,831);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,728,842);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,728,842);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,728,842);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

IEnumerable<Cci.IGenericMethodParameter> Cci.IMethodDefinition.GenericParameters
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,959,1044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,965,1042);

return f_779_972_1041();
DynAbs.Tracing.TraceSender.TraceExitMethod(779,959,1044);

System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
f_779_972_1041()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.IGenericMethodParameter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(779, 972, 1041);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,854,1055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,854,1055);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.HasDeclarativeSecurity
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,1141,1162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,1147,1160);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,1141,1162);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1067,1173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1067,1173);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsAbstract
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,1247,1268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,1253,1266);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,1247,1268);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1185,1279);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1185,1279);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsAccessCheckedOnOverride
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,1368,1389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,1374,1387);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,1368,1389);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1291,1400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1291,1400);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsConstructor
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,1477,1498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,1483,1496);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,1477,1498);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1412,1509);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1412,1509);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsExternal
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,1583,1604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,1589,1602);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,1583,1604);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1521,1615);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1521,1615);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsHiddenBySignature
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,1698,1719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,1704,1717);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,1698,1719);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1627,1730);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1627,1730);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsNewSlot
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,1803,1824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,1809,1822);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,1803,1824);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1742,1835);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1742,1835);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsPlatformInvoke
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,1915,1936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,1921,1934);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,1915,1936);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1847,1947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1847,1947);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsRuntimeSpecial
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,2027,2047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,2033,2045);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,2027,2047);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,1959,2058);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,1959,2058);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsSealed
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,2130,2151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,2136,2149);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,2130,2151);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,2070,2162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,2070,2162);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsSpecialName
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,2239,2259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,2245,2257);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,2239,2259);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,2174,2270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,2174,2270);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsStatic
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,2342,2363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,2348,2361);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,2342,2363);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,2282,2374);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,2282,2374);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.IsVirtual
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,2447,2468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,2453,2466);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,2447,2468);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,2386,2479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,2386,2479);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

System.Reflection.MethodImplAttributes Cci.IMethodDefinition.GetImplementationAttributes(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,2491,2739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,2625,2728);

return System.Reflection.MethodImplAttributes.Managed | System.Reflection.MethodImplAttributes.Runtime;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,2491,2739);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,2491,2739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,2491,2739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

ImmutableArray<Cci.IParameterDefinition> Cci.IMethodDefinition.Parameters
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,2849,2911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,2855,2909);

return ImmutableArray<Cci.IParameterDefinition>.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,2849,2911);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,2751,2922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,2751,2922);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IPlatformInvokeInformation Cci.IMethodDefinition.PlatformInvokeData
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,3030,3050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,3036,3048);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,3030,3050);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,2934,3061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,2934,3061);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodDefinition.RequiresSecurityObject
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,3147,3168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,3153,3166);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,3147,3168);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,3073,3179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,3073,3179);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

IEnumerable<Cci.ICustomAttribute> Cci.IMethodDefinition.GetReturnValueAttributes(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,3191,3398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,3317,3387);

return f_779_3324_3386();
DynAbs.Tracing.TraceSender.TraceExitMethod(779,3191,3398);

System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
f_779_3324_3386()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(779, 3324, 3386);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,3191,3398);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,3191,3398);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

bool Cci.IMethodDefinition.ReturnValueIsMarshalledExplicitly
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,3495,3516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,3501,3514);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,3495,3516);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,3410,3527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,3410,3527);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IMarshallingInformation Cci.IMethodDefinition.ReturnValueMarshallingInformation
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,3647,3667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,3653,3665);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,3647,3667);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,3539,3678);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,3539,3678);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ImmutableArray<byte> Cci.IMethodDefinition.ReturnValueMarshallingDescriptor
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,3790,3835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,3796,3833);

return default(ImmutableArray<byte>);
DynAbs.Tracing.TraceSender.TraceExitMethod(779,3790,3835);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,3690,3846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,3690,3846);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

IEnumerable<Cci.SecurityAttribute> Cci.IMethodDefinition.SecurityAttributes
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,3958,4037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,3964,4035);

return f_779_3971_4034();
DynAbs.Tracing.TraceSender.TraceExitMethod(779,3958,4037);

System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
f_779_3971_4034()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.SecurityAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(779, 3971, 4034);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,3858,4048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,3858,4048);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeDefinition Cci.ITypeDefinitionMember.ContainingTypeDefinition
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,4155,4185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,4161,4183);

return ContainingType;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,4155,4185);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,4060,4196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,4060,4196);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.INamespace Cci.IMethodDefinition.ContainingNamespace
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,4289,4463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,4436,4448);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,4289,4463);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,4208,4474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,4208,4474);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.TypeMemberVisibility Cci.ITypeDefinitionMember.Visibility
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,4572,4619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,4578,4617);

return Cci.TypeMemberVisibility.Public;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,4572,4619);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,4486,4630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,4486,4630);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,4642,4782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,4749,4771);

return ContainingType;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,4642,4782);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,4642,4782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,4642,4782);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,4794,4983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,4902,4972);

return f_779_4909_4971();
DynAbs.Tracing.TraceSender.TraceExitMethod(779,4794,4983);

System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
f_779_4909_4971()
{
var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(779, 4909, 4971);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,4794,4983);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,4794,4983);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,4995,5131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,5077,5120);

f_779_5077_5119(            visitor, this);
DynAbs.Tracing.TraceSender.TraceExitMethod(779,4995,5131);

int
f_779_5077_5119(Microsoft.Cci.MetadataVisitor
this_param,Microsoft.CodeAnalysis.Emit.NoPia.VtblGap
method)
{
this_param.Visit( (Microsoft.Cci.IMethodDefinition)method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(779, 5077, 5119);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,4995,5131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,4995,5131);
}
		}

Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(779,5202,5209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,5205,5209);
return null;DynAbs.Tracing.TraceSender.TraceExitMethod(779,5202,5209);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,5202,5209);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,5202,5209);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,5222,5334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,5311,5323);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,5222,5334);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,5222,5334);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,5222,5334);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

string Cci.INamedEntity.Name
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,5399,5420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,5405,5418);

return _name;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,5399,5420);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,5346,5431);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,5346,5431);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodReference.AcceptsExtraArguments
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,5515,5536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,5521,5534);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,5515,5536);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,5443,5547);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,5443,5547);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ushort Cci.IMethodReference.GenericParameterCount
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,5633,5650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,5639,5648);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,5633,5650);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,5559,5661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,5559,5661);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.IMethodReference.IsGeneric
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,5733,5754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,5739,5752);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,5733,5754);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,5673,5765);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,5673,5765);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IMethodDefinition Cci.IMethodReference.GetResolvedMethod(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,5777,5906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,5883,5895);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,5777,5906);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,5777,5906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,5777,5906);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

ImmutableArray<Cci.IParameterTypeInformation> Cci.IMethodReference.ExtraParameters
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,6025,6092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,6031,6090);

return ImmutableArray<Cci.IParameterTypeInformation>.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,6025,6092);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,5918,6103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,5918,6103);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.IGenericMethodInstanceReference Cci.IMethodReference.AsGenericMethodInstanceReference
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,6229,6249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,6235,6247);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,6229,6249);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,6115,6260);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,6115,6260);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ISpecializedMethodReference Cci.IMethodReference.AsSpecializedMethodReference
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,6378,6398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,6384,6396);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,6378,6398);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,6272,6409);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,6272,6409);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.CallingConvention Cci.ISignature.CallingConvention
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,6500,6577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,6506,6575);

return Cci.CallingConvention.Default | Cci.CallingConvention.HasThis;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,6500,6577);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,6421,6588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,6421,6588);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ushort Cci.ISignature.ParameterCount
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,6661,6678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,6667,6676);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,6661,6678);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,6600,6689);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,6600,6689);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ImmutableArray<Cci.IParameterTypeInformation> Cci.ISignature.GetParameters(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,6701,6891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,6821,6880);

return ImmutableArray<Cci.IParameterTypeInformation>.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,6701,6891);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,6701,6891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,6701,6891);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

ImmutableArray<Cci.ICustomModifier> Cci.ISignature.ReturnValueCustomModifiers
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,7005,7062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,7011,7060);

return ImmutableArray<Cci.ICustomModifier>.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,7005,7062);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,6903,7073);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,6903,7073);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

ImmutableArray<Cci.ICustomModifier> Cci.ISignature.RefCustomModifiers
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,7179,7236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,7185,7234);

return ImmutableArray<Cci.ICustomModifier>.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,7179,7236);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,7085,7247);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,7085,7247);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

bool Cci.ISignature.ReturnValueIsByRef
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(779,7322,7343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,7328,7341);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(779,7322,7343);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,7259,7354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,7259,7354);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

Cci.ITypeReference Cci.ISignature.GetType(EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,7366,7540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,7453,7529);

return f_779_7460_7528(context.Module, Cci.PlatformType.SystemVoid, context);
DynAbs.Tracing.TraceSender.TraceExitMethod(779,7366,7540);

Microsoft.Cci.ITypeReference
f_779_7460_7528(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param,Microsoft.Cci.PlatformType
platformType,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetPlatformType( platformType, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(779, 7460, 7528);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,7366,7540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,7366,7540);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override bool Equals(object obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,7552,7831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,7766,7820);

throw f_779_7772_7819();
DynAbs.Tracing.TraceSender.TraceExitMethod(779,7552,7831);

System.Exception
f_779_7772_7819()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(779, 7772, 7819);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,7552,7831);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,7552,7831);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(779,7843,8116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(779,8051,8105);

throw f_779_8057_8104();
DynAbs.Tracing.TraceSender.TraceExitMethod(779,7843,8116);

System.Exception
f_779_8057_8104()
{
var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(779, 8057, 8104);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(779,7843,8116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,7843,8116);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static VtblGap()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(779,380,8123);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(779,380,8123);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(779,380,8123);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(779,380,8123);
}
}
