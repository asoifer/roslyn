// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
internal static class BestTypeInferrer
{
public static NullableAnnotation GetNullableAnnotation(ArrayBuilder<TypeWithAnnotations> types)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10836,544,1155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,675,726);

var 
example = f_10836_689_725(types, t => t.HasType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,750,795);

var 
result = NullableAnnotation.NotAnnotated
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,809,1114);
foreach(var type in f_10836_830_835_I(types) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,809,1114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,880,966);

f_10836_880_965(f_10836_893_906_M(!type.HasType)||(DynAbs.Tracing.TraceSender.Expression_False(10836, 893, 964)||type.Equals(example,TypeCompareKind.AllIgnoreOptions)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,1053,1099);

result = f_10836_1062_1098(result, type.NullableAnnotation);
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,809,1114);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10836,1,306);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10836,1,306);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,1130,1144);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10836,544,1155);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
f_10836_689_725(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
source,System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, bool>
predicate)
{
var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 689, 725);
return return_v;
}


bool
f_10836_893_906_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 893, 906);
return return_v;
}


int
f_10836_880_965(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 880, 965);
return 0;
}


Microsoft.CodeAnalysis.CSharp.NullableAnnotation
f_10836_1062_1098(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
a,Microsoft.CodeAnalysis.CSharp.NullableAnnotation
b)
{
var return_v = a.Join( b);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 1062, 1098);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
f_10836_830_835_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 830, 835);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10836,544,1155);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10836,544,1155);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NullableFlowState GetNullableState(ArrayBuilder<TypeWithState> types)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10836,1167,1491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,1275,1328);

NullableFlowState 
result = NullableFlowState.NotNull
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,1342,1450);
foreach(var type in f_10836_1363_1368_I(types) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,1342,1450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,1402,1435);

result = f_10836_1411_1434(result, type.State);
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,1342,1450);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10836,1,109);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10836,1,109);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,1466,1480);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10836,1167,1491);

Microsoft.CodeAnalysis.CSharp.NullableFlowState
f_10836_1411_1434(Microsoft.CodeAnalysis.CSharp.NullableFlowState
a,Microsoft.CodeAnalysis.CSharp.NullableFlowState
b)
{
var return_v = a.Join( b);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 1411, 1434);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState>
f_10836_1363_1368_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithState>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 1363, 1368);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10836,1167,1491);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10836,1167,1491);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static TypeSymbol InferBestType(
            ImmutableArray<BoundExpression> exprs,
            ConversionsBase conversions,
            ref HashSet<DiagnosticInfo> useSiteDiagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10836,1789,4058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3056,3230);

IEqualityComparer<TypeSymbol> 
comparer = (DynAbs.Tracing.TraceSender.Conditional_F1(10836, 3097, 3127)||((conversions.IncludeNullability &&DynAbs.Tracing.TraceSender.Conditional_F2(10836, 3130, 3179))||DynAbs.Tracing.TraceSender.Conditional_F3(10836, 3182, 3229)))?Symbols.SymbolEqualityComparer.ConsiderEverything :Symbols.SymbolEqualityComparer.IgnoringNullable
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3244,3315);

HashSet<TypeSymbol> 
candidateTypes = f_10836_3281_3314(comparer)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3329,3705);
foreach(BoundExpression expr in f_10836_3362_3367_I(exprs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,3329,3705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3401,3429);

TypeSymbol 
type = f_10836_3419_3428(expr)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3449,3690) || true) && ((object)type != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,3449,3690);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3515,3622) || true) && (f_10836_3519_3537(type))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,3515,3622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3587,3599);

return type;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,3515,3622);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3646,3671);

f_10836_3646_3670(
                    candidateTypes, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,3449,3690);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,3329,3705);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10836,1,377);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10836,1,377);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3785,3858);

var 
builder = f_10836_3799_3857(f_10836_3836_3856(candidateTypes))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3872,3905);

f_10836_3872_3904(            builder, candidateTypes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,3919,3990);

var 
result = f_10836_3932_3989(builder, conversions, ref useSiteDiagnostics)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,4004,4019);

f_10836_4004_4018(            builder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,4033,4047);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10836,1789,4058);

System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
f_10836_3281_3314(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
comparer)
{
var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>( comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 3281, 3314);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10836_3419_3428(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 3419, 3428);
return return_v;
}


bool
f_10836_3519_3537(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsErrorType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 3519, 3537);
return return_v;
}


bool
f_10836_3646_3670(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 3646, 3670);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10836_3362_3367_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 3362, 3367);
return return_v;
}


int
f_10836_3836_3856(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 3836, 3856);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
f_10836_3799_3857(int
capacity)
{
var return_v = ArrayBuilder<TypeSymbol>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 3799, 3857);
return return_v;
}


int
f_10836_3872_3904(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param,System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
items)
{
this_param.AddRange( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>)items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 3872, 3904);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10836_3932_3989(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
types,Microsoft.CodeAnalysis.CSharp.ConversionsBase
conversions,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = GetBestType( types, conversions, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 3932, 3989);
return return_v;
}


int
f_10836_4004_4018(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 4004, 4018);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10836,1789,4058);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10836,1789,4058);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static TypeSymbol InferBestTypeForConditionalOperator(
            BoundExpression expr1,
            BoundExpression expr2,
            ConversionsBase conversions,
            out bool hadMultipleCandidates,
            ref HashSet<DiagnosticInfo> useSiteDiagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10836,4310,7213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,5609,5690);

ArrayBuilder<TypeSymbol> 
candidateTypes = f_10836_5651_5689()
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,5740,5811);

var 
conversionsWithoutNullability = f_10836_5776_5810(conversions, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,5829,5859);

TypeSymbol 
type1 = f_10836_5848_5858(expr1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,5879,6372) || true) && ((object)type1 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,5879,6372);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,5946,6111) || true) && (f_10836_5950_5969(type1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,5946,6111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6019,6049);

hadMultipleCandidates = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6075,6088);

return type1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,5946,6111);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6135,6353) || true) && (f_10836_6139_6247(conversionsWithoutNullability, expr2, type1, ref useSiteDiagnostics).Exists)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,6135,6353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6304,6330);

f_10836_6304_6329(                        candidateTypes, type1);
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,6135,6353);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,5879,6372);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6392,6422);

TypeSymbol 
type2 = f_10836_6411_6421(expr2)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6442,6935) || true) && ((object)type2 != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,6442,6935);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6509,6674) || true) && (f_10836_6513_6532(type2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,6509,6674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6582,6612);

hadMultipleCandidates = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6638,6651);

return type2;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,6509,6674);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6698,6916) || true) && (f_10836_6702_6810(conversionsWithoutNullability, expr1, type2, ref useSiteDiagnostics).Exists)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,6698,6916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6867,6893);

f_10836_6867_6892(                        candidateTypes, type2);
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,6698,6916);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,6442,6935);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,6955,7004);

hadMultipleCandidates = f_10836_6979_6999(candidateTypes)> 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,7024,7096);

return f_10836_7031_7095(candidateTypes, conversions, ref useSiteDiagnostics);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(10836,7125,7202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,7165,7187);

f_10836_7165_7186(                candidateTypes);
DynAbs.Tracing.TraceSender.TraceExitFinally(10836,7125,7202);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10836,4310,7213);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
f_10836_5651_5689()
{
var return_v = ArrayBuilder<TypeSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 5651, 5689);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ConversionsBase
f_10836_5776_5810(Microsoft.CodeAnalysis.CSharp.ConversionsBase
this_param,bool
includeNullability)
{
var return_v = this_param.WithNullability( includeNullability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 5776, 5810);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10836_5848_5858(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 5848, 5858);
return return_v;
}


bool
f_10836_5950_5969(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsErrorType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 5950, 5969);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10836_6139_6247(Microsoft.CodeAnalysis.CSharp.ConversionsBase
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
sourceExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = this_param.ClassifyImplicitConversionFromExpression( sourceExpression, destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 6139, 6247);
return return_v;
}


int
f_10836_6304_6329(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 6304, 6329);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10836_6411_6421(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 6411, 6421);
return return_v;
}


bool
f_10836_6513_6532(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsErrorType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 6513, 6532);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10836_6702_6810(Microsoft.CodeAnalysis.CSharp.ConversionsBase
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
sourceExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = this_param.ClassifyImplicitConversionFromExpression( sourceExpression, destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 6702, 6810);
return return_v;
}


int
f_10836_6867_6892(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 6867, 6892);
return 0;
}


int
f_10836_6979_6999(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 6979, 6999);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10836_7031_7095(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
types,Microsoft.CodeAnalysis.CSharp.ConversionsBase
conversions,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = GetBestType( types, conversions, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 7031, 7095);
return return_v;
}


int
f_10836_7165_7186(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 7165, 7186);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10836,4310,7213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10836,4310,7213);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static TypeSymbol GetBestType(
            ArrayBuilder<TypeSymbol> types,
            ConversionsBase conversions,
            ref HashSet<DiagnosticInfo> useSiteDiagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10836,7225,9448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,7795,7967);

switch (f_10836_7803_7814(types))
            {

case 0:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,7795,7967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,7877,7889);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,7795,7967);

case 1:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,7795,7967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,7936,7952);

return f_10836_7943_7951(types, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,7795,7967);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,7983,8006);

TypeSymbol 
best = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8020,8039);

int 
bestIndex = -1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8062,8067);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8053,8754) || true) && (i < f_10836_8073_8084(types))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8086,8089)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10836,8053,8754))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,8053,8754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8123,8150);

TypeSymbol 
type = f_10836_8141_8149(types, i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8168,8739) || true) && ((object)best == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,8168,8739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8234,8246);

best = type;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8268,8282);

bestIndex = i;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,8168,8739);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,8168,8739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8364,8433);

var 
better = f_10836_8377_8432(best, type, conversions, ref useSiteDiagnostics)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8457,8720) || true) && ((object)better == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,8457,8720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8533,8545);

best = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,8457,8720);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,8457,8720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8643,8657);

best = better;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8683,8697);

bestIndex = i;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,8457,8720);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,8168,8739);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10836,1,702);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10836,1,702);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8770,8855) || true) && ((object)best == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,8770,8855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,8828,8840);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,8770,8855);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9041,9046);

            // We have actually only determined that every type *after* best was worse. Now check
            // that every type *before* best was also worse.
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9032,9409) || true) && (i < bestIndex)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9063,9066)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10836,9032,9409))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,9032,9409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9100,9127);

TypeSymbol 
type = f_10836_9118_9126(types, i)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9145,9221);

TypeSymbol 
better = f_10836_9165_9220(best, type, conversions, ref useSiteDiagnostics)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9239,9394) || true) && (!f_10836_9244_9321(best, better, TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,9239,9394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9363,9375);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,9239,9394);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10836,1,378);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10836,1,378);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9425,9437);

return best;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10836,7225,9448);

int
f_10836_7803_7814(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 7803, 7814);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10836_7943_7951(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 7943, 7951);
return return_v;
}


int
f_10836_8073_8084(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 8073, 8084);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10836_8141_8149(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 8141, 8149);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10836_8377_8432(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type1,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type2,Microsoft.CodeAnalysis.CSharp.ConversionsBase
conversions,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = Better( type1, type2, conversions, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 8377, 8432);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10836_9118_9126(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10836, 9118, 9126);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10836_9165_9220(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type1,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type2,Microsoft.CodeAnalysis.CSharp.ConversionsBase
conversions,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = Better( type1, type2, conversions, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 9165, 9220);
return return_v;
}


bool
f_10836_9244_9321(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
t2,Microsoft.CodeAnalysis.TypeCompareKind
compareKind)
{
var return_v = this_param.Equals( t2, compareKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 9244, 9321);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10836,7225,9448);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10836,7225,9448);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static TypeSymbol Better(
            TypeSymbol type1,
            TypeSymbol type2,
            ConversionsBase conversions,
            ref HashSet<DiagnosticInfo> useSiteDiagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10836,9627,11054);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9904,9989) || true) && (f_10836_9908_9927(type1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,9904,9989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,9961,9974);

return type2;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,9904,9989);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10005,10115) || true) && ((object)type2 == null ||(DynAbs.Tracing.TraceSender.Expression_False(10836, 10009, 10053)||f_10836_10034_10053(type2)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,10005,10115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10087,10100);

return type1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,10005,10115);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10131,10202);

var 
conversionsWithoutNullability = f_10836_10167_10201(conversions, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10216,10339);

var 
t1tot2 = f_10836_10229_10331(conversionsWithoutNullability, type1, type2, ref useSiteDiagnostics).Exists
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10353,10476);

var 
t2tot1 = f_10836_10366_10468(conversionsWithoutNullability, type2, type1, ref useSiteDiagnostics).Exists
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10492,10839) || true) && (t1tot2 &&(DynAbs.Tracing.TraceSender.Expression_True(10836, 10496, 10512)&&t2tot1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,10492,10839);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10546,10792) || true) && (f_10836_10550_10672(type1, type2, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,10546,10792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10714,10773);

return f_10836_10721_10772(type1, type2, VarianceKind.Out);
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,10546,10792);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10812,10824);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,10492,10839);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10855,10927) || true) && (t1tot2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,10855,10927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10899,10912);

return type2;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,10855,10927);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10943,11015) || true) && (t2tot1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10836,10943,11015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,10987,11000);

return type1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10836,10943,11015);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10836,11031,11043);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10836,9627,11054);

bool
f_10836_9908_9927(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsErrorType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 9908, 9927);
return return_v;
}


bool
f_10836_10034_10053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsErrorType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 10034, 10053);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ConversionsBase
f_10836_10167_10201(Microsoft.CodeAnalysis.CSharp.ConversionsBase
this_param,bool
includeNullability)
{
var return_v = this_param.WithNullability( includeNullability);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 10167, 10201);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10836_10229_10331(Microsoft.CodeAnalysis.CSharp.ConversionsBase
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
source,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = this_param.ClassifyImplicitConversionFromType( source, destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 10229, 10331);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10836_10366_10468(Microsoft.CodeAnalysis.CSharp.ConversionsBase
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
source,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = this_param.ClassifyImplicitConversionFromType( source, destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 10366, 10468);
return return_v;
}


bool
f_10836_10550_10672(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
t2,Microsoft.CodeAnalysis.TypeCompareKind
compareKind)
{
var return_v = this_param.Equals( t2, compareKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 10550, 10672);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10836_10721_10772(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
other,Microsoft.CodeAnalysis.VarianceKind
variance)
{
var return_v = this_param.MergeEquivalentTypes( other, variance);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10836, 10721, 10772);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10836,9627,11054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10836,9627,11054);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static BestTypeInferrer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10836,489,11061);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10836,489,11061);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10836,489,11061);
}

}
}
