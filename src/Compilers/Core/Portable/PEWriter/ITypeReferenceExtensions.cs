// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Text;

namespace Microsoft.Cci
{
internal static class ITypeReferenceExtensions
{
internal static void GetConsolidatedTypeArguments(this ITypeReference typeReference, ArrayBuilder<ITypeReference> consolidatedTypeArguments, EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(493,480,1237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,666,746);

INestedTypeReference? 
nestedTypeReference = f_493_710_745(typeReference)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,783,945) || true) && (nestedTypeReference != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(493,783,945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,833,945);

f_493_833_944(f_493_833_879(                nestedTypeReference, context), consolidatedTypeArguments, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(493,783,945);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,961,1055);

IGenericTypeInstanceReference? 
genTypeInstance = f_493_1010_1054(typeReference)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1069,1226) || true) && (genTypeInstance != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(493,1069,1226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1130,1211);

f_493_1130_1210(                consolidatedTypeArguments, f_493_1165_1209(genTypeInstance, context));
DynAbs.Tracing.TraceSender.TraceExitCondition(493,1069,1226);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(493,480,1237);

Microsoft.Cci.INestedTypeReference?
f_493_710_745(Microsoft.Cci.ITypeReference
this_param)
{
var return_v = this_param.AsNestedTypeReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(493, 710, 745);
return return_v;
}


Microsoft.Cci.ITypeReference
f_493_833_879(Microsoft.Cci.INestedTypeReference
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetContainingType( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(493, 833, 879);
return return_v;
}


int
f_493_833_944(Microsoft.Cci.ITypeReference
typeReference,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
consolidatedTypeArguments,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
typeReference.GetConsolidatedTypeArguments( consolidatedTypeArguments, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(493, 833, 944);
return 0;
}


Microsoft.Cci.IGenericTypeInstanceReference?
f_493_1010_1054(Microsoft.Cci.ITypeReference
this_param)
{
var return_v = this_param.AsGenericTypeInstanceReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(493, 1010, 1054);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
f_493_1165_1209(Microsoft.Cci.IGenericTypeInstanceReference
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetGenericArguments( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(493, 1165, 1209);
return return_v;
}


int
f_493_1130_1210(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ITypeReference>
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(493, 1130, 1210);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(493,480,1237);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(493,480,1237);
}
		}

internal static ITypeReference GetUninstantiatedGenericType(this ITypeReference typeReference, EmitContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(493,1249,1985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1389,1496);

IGenericTypeInstanceReference? 
genericTypeInstanceReference = f_493_1451_1495(typeReference)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1510,1659) || true) && (genericTypeInstanceReference != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(493,1510,1659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1584,1644);

return f_493_1591_1643(genericTypeInstanceReference, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(493,1510,1659);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1675,1779);

ISpecializedNestedTypeReference? 
specializedNestedType = f_493_1732_1778(typeReference)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1793,1937) || true) && (specializedNestedType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(493,1793,1937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1860,1922);

return f_493_1867_1921(specializedNestedType, context);
DynAbs.Tracing.TraceSender.TraceExitCondition(493,1793,1937);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,1953,1974);

return typeReference;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(493,1249,1985);

Microsoft.Cci.IGenericTypeInstanceReference?
f_493_1451_1495(Microsoft.Cci.ITypeReference
this_param)
{
var return_v = this_param.AsGenericTypeInstanceReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(493, 1451, 1495);
return return_v;
}


Microsoft.Cci.INamedTypeReference
f_493_1591_1643(Microsoft.Cci.IGenericTypeInstanceReference
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetGenericType( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(493, 1591, 1643);
return return_v;
}


Microsoft.Cci.ISpecializedNestedTypeReference?
f_493_1732_1778(Microsoft.Cci.ITypeReference
this_param)
{
var return_v = this_param.AsSpecializedNestedTypeReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(493, 1732, 1778);
return return_v;
}


Microsoft.Cci.INestedTypeReference
f_493_1867_1921(Microsoft.Cci.ISpecializedNestedTypeReference
this_param,Microsoft.CodeAnalysis.Emit.EmitContext
context)
{
var return_v = this_param.GetUnspecializedVersion( context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(493, 1867, 1921);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(493,1249,1985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(493,1249,1985);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsTypeSpecification(this ITypeReference typeReference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(493,1997,2503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,2097,2177);

INestedTypeReference? 
nestedTypeReference = f_493_2141_2176(typeReference)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,2191,2422) || true) && (nestedTypeReference != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(493,2191,2422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,2256,2407);

return f_493_2263_2315(nestedTypeReference)!= null ||(DynAbs.Tracing.TraceSender.Expression_False(493, 2263, 2406)||f_493_2348_2398(nestedTypeReference)!= null);
DynAbs.Tracing.TraceSender.TraceExitCondition(493,2191,2422);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(493,2438,2492);

return f_493_2445_2483(typeReference)== null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(493,1997,2503);

Microsoft.Cci.INestedTypeReference?
f_493_2141_2176(Microsoft.Cci.ITypeReference
this_param)
{
var return_v = this_param.AsNestedTypeReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(493, 2141, 2176);
return return_v;
}


Microsoft.Cci.ISpecializedNestedTypeReference?
f_493_2263_2315(Microsoft.Cci.INestedTypeReference
this_param)
{
var return_v = this_param.AsSpecializedNestedTypeReference ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(493, 2263, 2315);
return return_v;
}


Microsoft.Cci.IGenericTypeInstanceReference?
f_493_2348_2398(Microsoft.Cci.INestedTypeReference
this_param)
{
var return_v = this_param.AsGenericTypeInstanceReference ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(493, 2348, 2398);
return return_v;
}


Microsoft.Cci.INamespaceTypeReference?
f_493_2445_2483(Microsoft.Cci.ITypeReference
this_param)
{
var return_v = this_param.AsNamespaceTypeReference ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(493, 2445, 2483);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(493,1997,2503);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(493,1997,2503);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ITypeReferenceExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(493,417,2510);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(493,417,2510);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(493,417,2510);
}

}
}
