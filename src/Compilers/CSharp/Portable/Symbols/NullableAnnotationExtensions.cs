// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

// https://github.com/dotnet/roslyn/issues/34962 IDE005 "Fix formatting" does a poor job with a switch expression as the body of an expression-bodied method
#pragma warning disable IDE0055

namespace Microsoft.CodeAnalysis.CSharp
{
internal static class NullableAnnotationExtensions
{
public static bool IsAnnotated(this NullableAnnotation annotation) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10135,741,786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,744,786);
return annotation == NullableAnnotation.Annotated;DynAbs.Tracing.TraceSender.TraceExitMethod(10135,741,786);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,741,786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,741,786);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsNotAnnotated(this NullableAnnotation annotation) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10135,869,917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,872,917);
return annotation == NullableAnnotation.NotAnnotated;DynAbs.Tracing.TraceSender.TraceExitMethod(10135,869,917);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,869,917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,869,917);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsOblivious(this NullableAnnotation annotation) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10135,997,1042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,1000,1042);
return annotation == NullableAnnotation.Oblivious;DynAbs.Tracing.TraceSender.TraceExitMethod(10135,997,1042);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,997,1042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,997,1042);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NullableAnnotation Join(this NullableAnnotation a, NullableAnnotation b)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,1312,1577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,1423,1469);

f_10135_1423_1468(a != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,1483,1529);

f_10135_1483_1528(b != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,1543,1566);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10135, 1550, 1557)||(((a < b) &&DynAbs.Tracing.TraceSender.Conditional_F2(10135, 1560, 1561))||DynAbs.Tracing.TraceSender.Conditional_F3(10135, 1564, 1565)))?b :a;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,1312,1577);

int
f_10135_1423_1468(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 1423, 1468);
return 0;
}


int
f_10135_1483_1528(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 1483, 1528);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,1312,1577);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,1312,1577);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NullableAnnotation Meet(this NullableAnnotation a, NullableAnnotation b)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,1873,2138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,1984,2030);

f_10135_1984_2029(a != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,2044,2090);

f_10135_2044_2089(b != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,2104,2127);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10135, 2111, 2118)||(((a < b) &&DynAbs.Tracing.TraceSender.Conditional_F2(10135, 2121, 2122))||DynAbs.Tracing.TraceSender.Conditional_F3(10135, 2125, 2126)))?a :b;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,1873,2138);

int
f_10135_1984_2029(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 1984, 2029);
return 0;
}


int
f_10135_2044_2089(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 2044, 2089);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,1873,2138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,1873,2138);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NullableAnnotation EnsureCompatible(this NullableAnnotation a, NullableAnnotation b)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,2453,2909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,2576,2622);

f_10135_2576_2621(a != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,2636,2682);

f_10135_2636_2681(b != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,2696,2898);

return (a, b) switch
            {
                (NullableAnnotation.Oblivious, _) when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,2749,2787) && DynAbs.Tracing.TraceSender.Expression_True(10135,2749,2787))
=> b,
                (_, NullableAnnotation.Oblivious) when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,2806,2844) && DynAbs.Tracing.TraceSender.Expression_True(10135,2806,2844))
=> a,
                _ when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,2863,2881) && DynAbs.Tracing.TraceSender.Expression_True(10135,2863,2881))
=> (DynAbs.Tracing.TraceSender.Conditional_F1(10135, 2868, 2873)||((a < b &&DynAbs.Tracing.TraceSender.Conditional_F2(10135, 2876, 2877))||DynAbs.Tracing.TraceSender.Conditional_F3(10135, 2880, 2881)))?a :b,
            };
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,2453,2909);

int
f_10135_2576_2621(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 2576, 2621);
return 0;
}


int
f_10135_2636_2681(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 2636, 2681);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,2453,2909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,2453,2909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NullableAnnotation MergeNullableAnnotation(this NullableAnnotation a, NullableAnnotation b, VarianceKind variance)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,3001,3567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3154,3200);

f_10135_3154_3199(a != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3214,3260);

f_10135_3214_3259(b != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3274,3556);

return variance switch
            {
                VarianceKind.In when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3329,3357) && DynAbs.Tracing.TraceSender.Expression_True(10135,3329,3357))
=> f_10135_3348_3357(a, b),
                VarianceKind.Out when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3376,3405) && DynAbs.Tracing.TraceSender.Expression_True(10135,3376,3405))
=> f_10135_3396_3405(a, b),
                VarianceKind.None when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3424,3466) && DynAbs.Tracing.TraceSender.Expression_True(10135,3424,3466))
=> f_10135_3445_3466(a, b),
                _ when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3485,3540) && DynAbs.Tracing.TraceSender.Expression_True(10135,3485,3540))
=> throw f_10135_3496_3540(variance)            };
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,3001,3567);

int
f_10135_3154_3199(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 3154, 3199);
return 0;
}


int
f_10135_3214_3259(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 3214, 3259);
return 0;
}


Microsoft.CodeAnalysis.CSharp.NullableAnnotation
f_10135_3348_3357(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
a,Microsoft.CodeAnalysis.CSharp.NullableAnnotation
b)
{
var return_v = a.Meet( b);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 3348, 3357);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.NullableAnnotation
f_10135_3396_3405(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
a,Microsoft.CodeAnalysis.CSharp.NullableAnnotation
b)
{
var return_v = a.Join( b);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 3396, 3405);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.NullableAnnotation
f_10135_3445_3466(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
a,Microsoft.CodeAnalysis.CSharp.NullableAnnotation
b)
{
var return_v = a.EnsureCompatible( b);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 3445, 3466);
return return_v;
}


System.Exception
f_10135_3496_3540(Microsoft.CodeAnalysis.VarianceKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 3496, 3540);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,3001,3567);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,3001,3567);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public const byte 
NotAnnotatedAttributeValue = 1
;

public const byte 
AnnotatedAttributeValue = 2
;

public const byte 
ObliviousAttributeValue = 0
;

internal static NullabilityInfo ToNullabilityInfo(this CodeAnalysis.NullableAnnotation annotation, TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,4200,4630);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,4340,4458) || true) && (annotation == CodeAnalysis.NullableAnnotation.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10135,4340,4458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,4428,4443);

return default;
DynAbs.Tracing.TraceSender.TraceExitCondition(10135,4340,4458);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,4474,4555);

CSharp.NullableAnnotation 
internalAnnotation = f_10135_4521_4554(annotation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,4569,4619);

return f_10135_4576_4618(internalAnnotation, type);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,4200,4630);

Microsoft.CodeAnalysis.CSharp.NullableAnnotation
f_10135_4521_4554(Microsoft.CodeAnalysis.NullableAnnotation
annotation)
{
var return_v = annotation.ToInternalAnnotation();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 4521, 4554);
return return_v;
}


Microsoft.CodeAnalysis.NullabilityInfo
f_10135_4576_4618(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
annotation,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = annotation.ToNullabilityInfo( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 4576, 4618);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,4200,4630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,4200,4630);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static NullabilityInfo ToNullabilityInfo(this NullableAnnotation annotation, TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,4642,4975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,4769,4854);

var 
flowState = TypeWithAnnotations.Create(type,annotation).ToTypeWithState().State
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,4868,4964);

return f_10135_4875_4963(f_10135_4895_4931(type, annotation), f_10135_4933_4962(flowState));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,4642,4975);

Microsoft.CodeAnalysis.NullableAnnotation
f_10135_4895_4931(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.NullableAnnotation
annotation)
{
var return_v = ToPublicAnnotation( type, annotation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 4895, 4931);
return return_v;
}


Microsoft.CodeAnalysis.NullableFlowState
f_10135_4933_4962(Microsoft.CodeAnalysis.CSharp.NullableFlowState
nullableFlowState)
{
var return_v = nullableFlowState.ToPublicFlowState();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 4933, 4962);
return return_v;
}


Microsoft.CodeAnalysis.NullabilityInfo
f_10135_4875_4963(Microsoft.CodeAnalysis.NullableAnnotation
annotation,Microsoft.CodeAnalysis.NullableFlowState
flowState)
{
var return_v = new Microsoft.CodeAnalysis.NullabilityInfo( annotation, flowState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 4875, 4963);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,4642,4975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,4642,4975);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ITypeSymbol GetPublicSymbol(this TypeWithAnnotations type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,4987,5157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,5086,5146);

return f_10135_5093_5145_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type.Type, 10135, 5093, 5145)?.GetITypeSymbol(type.ToPublicAnnotation()));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,4987,5157);

Microsoft.CodeAnalysis.ITypeSymbol?
f_10135_5093_5145_I(Microsoft.CodeAnalysis.ITypeSymbol?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 5093, 5145);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,4987,5157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,4987,5157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<ITypeSymbol> GetPublicSymbols(this ImmutableArray<TypeWithAnnotations> types)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,5169,5366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,5302,5355);

return types.SelectAsArray(t => t.GetPublicSymbol());
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,5169,5366);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,5169,5366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,5169,5366);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static CodeAnalysis.NullableAnnotation ToPublicAnnotation(this TypeWithAnnotations type) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10135,5476,5546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,5492,5546);
return f_10135_5492_5546(type.Type, type.NullableAnnotation);DynAbs.Tracing.TraceSender.TraceExitMethod(10135,5476,5546);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,5476,5546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,5476,5546);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.NullableAnnotation
f_10135_5492_5546(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.NullableAnnotation
annotation)
{
var return_v = ToPublicAnnotation( type, annotation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 5492, 5546);
return return_v;
}

		}

internal static ImmutableArray<CodeAnalysis.NullableAnnotation> ToPublicAnnotations(this ImmutableArray<TypeWithAnnotations> types) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10135,5691,5755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,5707,5755);
return types.SelectAsArray(t => t.ToPublicAnnotation());DynAbs.Tracing.TraceSender.TraceExitMethod(10135,5691,5755);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,5691,5755);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,5691,5755);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static CodeAnalysis.NullableAnnotation ToPublicAnnotation(TypeSymbol? type, NullableAnnotation annotation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10135,5788,6968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,5928,5983);

f_10135_5928_5982(annotation != NullableAnnotation.Ignored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,5997,6957);

return annotation switch
            {
                NullableAnnotation.Annotated when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,6054,6127) && DynAbs.Tracing.TraceSender.Expression_True(10135,6054,6127))
=> CodeAnalysis.NullableAnnotation.Annotated,
                NullableAnnotation.NotAnnotated when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,6146,6225) && DynAbs.Tracing.TraceSender.Expression_True(10135,6146,6225))
=> CodeAnalysis.NullableAnnotation.NotAnnotated,

                // A value type may be oblivious or not annotated depending on whether the type reference
                // is from source or metadata. (Binding using the #nullable context only when setting the annotation
                // to avoid checking IsValueType early.) The annotation is normalized here in the public API.
                NullableAnnotation.Oblivious when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,6611,6641) || true) && (f_10135_6616_6633_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type, 10135, 6616, 6633)?.IsValueType)== true) && (DynAbs.Tracing.TraceSender.Expression_True(10135,6611,6641) || true)
=> CodeAnalysis.NullableAnnotation.NotAnnotated,
                NullableAnnotation.Oblivious when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,6708,6776) && DynAbs.Tracing.TraceSender.Expression_True(10135,6708,6776))
=> CodeAnalysis.NullableAnnotation.None,

                NullableAnnotation.Ignored when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,6797,6863) && DynAbs.Tracing.TraceSender.Expression_True(10135,6797,6863))
=> CodeAnalysis.NullableAnnotation.None,

                _ when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,6884,6941) && DynAbs.Tracing.TraceSender.Expression_True(10135,6884,6941))
=> throw f_10135_6895_6941(annotation)            };
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10135,5788,6968);

int
f_10135_5928_5982(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 5928, 5982);
return 0;
}


bool?
f_10135_6616_6633_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10135, 6616, 6633);
return return_v;
}


System.Exception
f_10135_6895_6941(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 6895, 6941);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,5788,6968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,5788,6968);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static CSharp.NullableAnnotation ToInternalAnnotation(this CodeAnalysis.NullableAnnotation annotation) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10135,7113,7549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,7129,7549);
return annotation switch
            {
                CodeAnalysis.NullableAnnotation.None when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,7179,7254) && DynAbs.Tracing.TraceSender.Expression_True(10135,7179,7254))
=> CSharp.NullableAnnotation.Oblivious,
                CodeAnalysis.NullableAnnotation.NotAnnotated when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,7273,7359) && DynAbs.Tracing.TraceSender.Expression_True(10135,7273,7359))
=> CSharp.NullableAnnotation.NotAnnotated,
                CodeAnalysis.NullableAnnotation.Annotated when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,7378,7458) && DynAbs.Tracing.TraceSender.Expression_True(10135,7378,7458))
=> CSharp.NullableAnnotation.Annotated,
                _ when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,7477,7534) && DynAbs.Tracing.TraceSender.Expression_True(10135,7477,7534))
=> throw f_10135_7488_7534(annotation)            };DynAbs.Tracing.TraceSender.TraceExitMethod(10135,7113,7549);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10135,7113,7549);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,7113,7549);
}
			throw new System.Exception("Slicer error: unreachable code");

System.Exception
f_10135_7488_7534(Microsoft.CodeAnalysis.NullableAnnotation
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10135, 7488, 7534);
return return_v;
}

		}

static NullableAnnotationExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10135,607,7557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3747,3777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,3955,3982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10135,4160,4187);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10135,607,7557);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10135,607,7557);
}

}
}
