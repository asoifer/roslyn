// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
public abstract class AttributeData
{
protected AttributeData()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(787,626,673);
DynAbs.Tracing.TraceSender.TraceExitConstructor(787,626,673);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,626,673);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,626,673);
}
		}

public INamedTypeSymbol? AttributeClass {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(787,808,844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,814,842);

return f_787_821_841();
DynAbs.Tracing.TraceSender.TraceExitMethod(787,808,844);

Microsoft.CodeAnalysis.INamedTypeSymbol?
f_787_821_841()
{
var return_v = CommonAttributeClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 821, 841);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,766,846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,766,846);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected abstract INamedTypeSymbol? CommonAttributeClass {get; }

public IMethodSymbol? AttributeConstructor {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(787,1079,1121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,1085,1119);

return f_787_1092_1118();
DynAbs.Tracing.TraceSender.TraceExitMethod(787,1079,1121);

Microsoft.CodeAnalysis.IMethodSymbol?
f_787_1092_1118()
{
var return_v = CommonAttributeConstructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 1092, 1118);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,1034,1123);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,1034,1123);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected abstract IMethodSymbol? CommonAttributeConstructor {get; }

public SyntaxReference? ApplicationSyntaxReference {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(787,1267,1315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,1273,1313);

return f_787_1280_1312();
DynAbs.Tracing.TraceSender.TraceExitMethod(787,1267,1315);

Microsoft.CodeAnalysis.SyntaxReference?
f_787_1280_1312()
{
var return_v = CommonApplicationSyntaxReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 1280, 1312);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,1214,1317);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,1214,1317);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected abstract SyntaxReference? CommonApplicationSyntaxReference {get; }

public ImmutableArray<TypedConstant> ConstructorArguments {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(787,1576,1618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,1582,1616);

return f_787_1589_1615();
DynAbs.Tracing.TraceSender.TraceExitMethod(787,1576,1618);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_1589_1615()
{
var return_v = CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 1589, 1615);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,1516,1620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,1516,1620);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected internal abstract ImmutableArray<TypedConstant> CommonConstructorArguments {get; }

public ImmutableArray<KeyValuePair<string, TypedConstant>> NamedArguments {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(787,1923,1959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,1929,1957);

return f_787_1936_1956();
DynAbs.Tracing.TraceSender.TraceExitMethod(787,1923,1959);

System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_1936_1956()
{
var return_v = CommonNamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 1936, 1956);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,1847,1961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,1847,1961);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected internal abstract ImmutableArray<KeyValuePair<string, TypedConstant>> CommonNamedArguments {get; }

internal virtual bool IsConditionallyOmitted
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(787,2476,2497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,2482,2495);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(787,2476,2497);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,2407,2508);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,2407,2508);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

[MemberNotNullWhen(true, nameof(AttributeClass), nameof(AttributeConstructor))]
        internal virtual bool HasErrors
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(787,2665,2686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,2671,2684);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(787,2665,2686);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,2520,2697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,2520,2697);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal static bool IsTargetEarlyAttribute(INamedTypeSymbolInternal attributeType, int attributeArgCount, AttributeDescription description)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(787,3119,5627);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3284,3410) || true) && (f_787_3288_3324_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_787_3288_3318(attributeType), 787, 3288, 3324)?.Kind)!= SymbolKind.Namespace)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,3284,3410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3382,3395);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,3284,3410);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3426,3482);

int 
attributeCtorsCount = f_787_3452_3481(description.Signatures)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3505,3510);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3496,4183) || true) && (i < attributeCtorsCount)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3537,3540)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(787,3496,4183))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,3496,4183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3574,3644);

int 
parameterCount = description.GetParameterCount(signatureIndex: i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3780,4168) || true) && (attributeArgCount == parameterCount)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,3780,4168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,3861,3982);

StringComparison 
options = (DynAbs.Tracing.TraceSender.Conditional_F1(787, 3888, 3917)||((description.MatchIgnoringCase &&DynAbs.Tracing.TraceSender.Conditional_F2(787, 3920, 3954))||DynAbs.Tracing.TraceSender.Conditional_F3(787, 3957, 3981)))?StringComparison.OrdinalIgnoreCase :StringComparison.Ordinal
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4004,4149);

return f_787_4011_4063(f_787_4011_4029(attributeType), description.Name, options)&&(DynAbs.Tracing.TraceSender.Expression_True(787, 4011, 4148)&&f_787_4067_4148(f_787_4082_4115(attributeType), description.Namespace, options));
DynAbs.Tracing.TraceSender.TraceExitCondition(787,3780,4168);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(787,1,688);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(787,1,688);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4199,4212);

return false;

static bool namespaceMatch(INamespaceSymbolInternal container, string namespaceName, StringComparison options)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(787,4228,5616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4371,4404);

int 
index = f_787_4383_4403(namespaceName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4422,4445);

bool 
expectDot = false
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4465,5601) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,4465,5601);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4518,4640) || true) && (f_787_4522_4549(container))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,4518,4640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4599,4617);

return index == 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,4518,4640);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4664,5043) || true) && (expectDot)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,4664,5043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4727,4735);

index--;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4763,4905) || true) && (index < 0 ||(DynAbs.Tracing.TraceSender.Expression_False(787, 4767, 4807)||f_787_4780_4800(namespaceName, index)!= '.'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,4763,4905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,4865,4878);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,4763,4905);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(787,4664,5043);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,4664,5043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5003,5020);

expectDot = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,4664,5043);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5067,5096);

string 
name = f_787_5081_5095(container)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5118,5147);

int 
nameLength = f_787_5135_5146(name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5169,5189);

index -= nameLength;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5211,5385) || true) && (index < 0 ||(DynAbs.Tracing.TraceSender.Expression_False(787, 5215, 5299)||f_787_5228_5294(namespaceName, index, name, 0, nameLength, options)!= 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,5211,5385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5349,5362);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,5211,5385);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5409,5451);

container = f_787_5421_5450(container);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5475,5582) || true) && (container is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,5475,5582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5546,5559);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,5475,5582);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(787,4465,5601);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(787,4465,5601);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(787,4465,5601);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(787,4228,5616);

int
f_787_4383_4403(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 4383, 4403);
return return_v;
}


bool
f_787_4522_4549(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
this_param)
{
var return_v = this_param.IsGlobalNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 4522, 4549);
return return_v;
}


char
f_787_4780_4800(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 4780, 4800);
return return_v;
}


string
f_787_5081_5095(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 5081, 5095);
return return_v;
}


int
f_787_5135_5146(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 5135, 5146);
return return_v;
}


int
f_787_5228_5294(string
strA,int
indexA,string
strB,int
indexB,int
length,System.StringComparison
comparisonType)
{
var return_v = string.Compare( strA, indexA, strB, indexB, length, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 5228, 5294);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
f_787_5421_5450(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
this_param)
{
var return_v = this_param.ContainingNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 5421, 5450);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,4228,5616);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,4228,5616);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(787,3119,5627);

Microsoft.CodeAnalysis.Symbols.ISymbolInternal
f_787_3288_3318(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
this_param)
{
var return_v = this_param.ContainingSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 3288, 3318);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind?
f_787_3288_3324_M(Microsoft.CodeAnalysis.SymbolKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 3288, 3324);
return return_v;
}


int
f_787_3452_3481(byte[][]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 3452, 3481);
return return_v;
}


string
f_787_4011_4029(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 4011, 4029);
return return_v;
}


bool
f_787_4011_4063(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 4011, 4063);
return return_v;
}


Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
f_787_4082_4115(Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal
this_param)
{
var return_v = this_param.ContainingNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 4082, 4115);
return return_v;
}


bool
f_787_4067_4148(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
container,string
namespaceName,System.StringComparison
options)
{
var return_v = namespaceMatch( container, namespaceName, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 4067, 4148);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,3119,5627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,3119,5627);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal T? GetConstructorArgument<T>(int i, SpecialType specialType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,5880,6107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,5974,6028);

var 
constructorArgs = f_787_5996_6027(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,6042,6096);

return constructorArgs[i].DecodeValue<T>(specialType);
DynAbs.Tracing.TraceSender.TraceExitMethod(787,5880,6107);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_5996_6027(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 5996, 6027);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,5880,6107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,5880,6107);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal T? DecodeNamedArgument<T>(string name, SpecialType specialType, T? defaultValue = default)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,7016,7236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,7140,7225);

return f_787_7147_7224(f_787_7170_7190(), name, specialType, defaultValue);
DynAbs.Tracing.TraceSender.TraceExitMethod(787,7016,7236);

System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_7170_7190()
{
var return_v = CommonNamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 7170, 7190);
return return_v;
}


T?
f_787_7147_7224(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
namedArguments,string
name,Microsoft.CodeAnalysis.SpecialType
specialType,T?
defaultValue)
{
var return_v = DecodeNamedArgument<T>( namedArguments, name, specialType, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 7147, 7224);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,7016,7236);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,7016,7236);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static T? DecodeNamedArgument<T>(ImmutableArray<KeyValuePair<string, TypedConstant>> namedArguments, string name, SpecialType specialType, T? defaultValue = default)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(787,7248,7617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,7446,7501);

int 
index = f_787_7458_7500(namedArguments, name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,7515,7606);

return (DynAbs.Tracing.TraceSender.Conditional_F1(787, 7522, 7532)||((index >= 0 &&DynAbs.Tracing.TraceSender.Conditional_F2(787, 7535, 7590))||DynAbs.Tracing.TraceSender.Conditional_F3(787, 7593, 7605)))?namedArguments[index].Value.DecodeValue<T>(specialType):defaultValue;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(787,7248,7617);

int
f_787_7458_7500(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
namedArguments,string
name)
{
var return_v = IndexOfNamedArgument( namedArguments, name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 7458, 7500);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,7248,7617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,7248,7617);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int IndexOfNamedArgument(ImmutableArray<KeyValuePair<string, TypedConstant>> namedArguments, string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(787,7629,8327);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,7990,8019);
            // For user defined attributes VB allows duplicate named arguments and uses the last value.
            // Dev11 reports an error for pseudo-custom attributes when emitting metadata. We don't.
            for (int 
i = namedArguments.Length - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,7981,8290) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,8029,8032)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(787,7981,8290))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,7981,8290);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,8133,8275) || true) && (f_787_8137_8205(namedArguments[i].Key, name, StringComparison.Ordinal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,8133,8275);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,8247,8256);

return i;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,8133,8275);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(787,1,310);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(787,1,310);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,8306,8316);

return -1;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(787,7629,8327);

bool
f_787_8137_8205(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 8137, 8205);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,7629,8327);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,7629,8327);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal ConstantValue DecodeDecimalConstantValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,8397,10793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,8855,8900);

f_787_8855_8899(f_787_8868_8888()is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,8914,8963);

var 
parameters = f_787_8931_8962(f_787_8931_8951())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,8977,9046);

ImmutableArray<TypedConstant> 
args = f_787_9014_9045(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9062,9099);

f_787_9062_9098(parameters.Length == 5);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9113,9185);

f_787_9113_9184(f_787_9126_9156(f_787_9126_9144(parameters[0]))== SpecialType.System_Byte);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9199,9271);

f_787_9199_9270(f_787_9212_9242(f_787_9212_9230(parameters[1]))== SpecialType.System_Byte);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9287,9306);

int 
low
=default(int),
mid
=default(int),
high
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9322,9386);

byte 
scale = args[0].DecodeValue<byte>(SpecialType.System_Byte)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9400,9474);

bool 
isNegative = args[1].DecodeValue<byte>(SpecialType.System_Byte)!= 0
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9490,10690) || true) && (f_787_9494_9524(f_787_9494_9512(parameters[2]))== SpecialType.System_Int32)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,9490,10690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9586,9659);

f_787_9586_9658(f_787_9599_9629(f_787_9599_9617(parameters[2]))== SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9677,9750);

f_787_9677_9749(f_787_9690_9720(f_787_9690_9708(parameters[3]))== SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9768,9841);

f_787_9768_9840(f_787_9781_9811(f_787_9781_9799(parameters[4]))== SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9861,9919);

high = args[2].DecodeValue<int>(SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,9937,9994);

mid = args[3].DecodeValue<int>(SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10012,10069);

low = args[4].DecodeValue<int>(SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,9490,10690);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,9490,10690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10135,10209);

f_787_10135_10208(f_787_10148_10178(f_787_10148_10166(parameters[2]))== SpecialType.System_UInt32);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10227,10301);

f_787_10227_10300(f_787_10240_10270(f_787_10240_10258(parameters[3]))== SpecialType.System_UInt32);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10319,10393);

f_787_10319_10392(f_787_10332_10362(f_787_10332_10350(parameters[4]))== SpecialType.System_UInt32);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10413,10489);

high = unchecked((int)args[2].DecodeValue<uint>(SpecialType.System_UInt32));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10507,10582);

mid = unchecked((int)args[3].DecodeValue<uint>(SpecialType.System_UInt32));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10600,10675);

low = unchecked((int)args[4].DecodeValue<uint>(SpecialType.System_UInt32));
DynAbs.Tracing.TraceSender.TraceExitCondition(787,9490,10690);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10706,10782);

return f_787_10713_10781(f_787_10734_10780(low, mid, high, isNegative, scale));
DynAbs.Tracing.TraceSender.TraceExitMethod(787,8397,10793);

Microsoft.CodeAnalysis.IMethodSymbol?
f_787_8868_8888()
{
var return_v = AttributeConstructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 8868, 8888);
return return_v;
}


int
f_787_8855_8899(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 8855, 8899);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_787_8931_8951()
{
var return_v = AttributeConstructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 8931, 8951);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
f_787_8931_8962(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 8931, 8962);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_9014_9045(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9014, 9045);
return return_v;
}


int
f_787_9062_9098(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 9062, 9098);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_9126_9144(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9126, 9144);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_9126_9156(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9126, 9156);
return return_v;
}


int
f_787_9113_9184(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 9113, 9184);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_9212_9230(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9212, 9230);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_9212_9242(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9212, 9242);
return return_v;
}


int
f_787_9199_9270(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 9199, 9270);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_9494_9512(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9494, 9512);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_9494_9524(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9494, 9524);
return return_v;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_9599_9617(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9599, 9617);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_9599_9629(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9599, 9629);
return return_v;
}


int
f_787_9586_9658(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 9586, 9658);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_9690_9708(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9690, 9708);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_9690_9720(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9690, 9720);
return return_v;
}


int
f_787_9677_9749(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 9677, 9749);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_9781_9799(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9781, 9799);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_9781_9811(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 9781, 9811);
return return_v;
}


int
f_787_9768_9840(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 9768, 9840);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_10148_10166(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 10148, 10166);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_10148_10178(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 10148, 10178);
return return_v;
}


int
f_787_10135_10208(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 10135, 10208);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_10240_10258(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 10240, 10258);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_10240_10270(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 10240, 10270);
return return_v;
}


int
f_787_10227_10300(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 10227, 10300);
return 0;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_10332_10350(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 10332, 10350);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_10332_10362(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 10332, 10362);
return return_v;
}


int
f_787_10319_10392(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 10319, 10392);
return 0;
}


decimal
f_787_10734_10780(int
lo,int
mid,int
hi,bool
isNegative,byte
scale)
{
var return_v = new decimal( lo, mid, hi, isNegative, scale);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 10734, 10780);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_787_10713_10781(decimal
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 10713, 10781);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,8397,10793);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,8397,10793);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal ConstantValue DecodeDateTimeConstantValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,10805,11296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,10882,10974);

long 
value = f_787_10895_10926(this)[0].DecodeValue<long>(SpecialType.System_Int64)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,11076,11220) || true) && (value < DateTime.MinValue.Ticks ||(DynAbs.Tracing.TraceSender.Expression_False(787, 11080, 11146)||value > DateTime.MaxValue.Ticks))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,11076,11220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,11180,11205);

return f_787_11187_11204();
DynAbs.Tracing.TraceSender.TraceExitCondition(787,11076,11220);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,11236,11285);

return f_787_11243_11284(f_787_11264_11283(value));
DynAbs.Tracing.TraceSender.TraceExitMethod(787,10805,11296);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_10895_10926(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 10895, 10926);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_787_11187_11204()
{
var return_v = ConstantValue.Bad;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 11187, 11204);
return return_v;
}


System.DateTime
f_787_11264_11283(long
ticks)
{
var return_v = new System.DateTime( ticks);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 11264, 11283);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_787_11243_11284(System.DateTime
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 11243, 11284);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,10805,11296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,10805,11296);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal ObsoleteAttributeData DecodeObsoleteAttribute(ObsoleteAttributeKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,11330,11925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,11437,11914);

switch (kind)
            {

case ObsoleteAttributeKind.Obsolete:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,11437,11914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,11541,11574);

return f_787_11548_11573(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,11437,11914);

case ObsoleteAttributeKind.Deprecated:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,11437,11914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,11652,11687);

return f_787_11659_11686(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,11437,11914);

case ObsoleteAttributeKind.Experimental:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,11437,11914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,11767,11804);

return f_787_11774_11803(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,11437,11914);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,11437,11914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,11852,11899);

throw f_787_11858_11898(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,11437,11914);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(787,11330,11925);

Microsoft.CodeAnalysis.ObsoleteAttributeData
f_787_11548_11573(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.DecodeObsoleteAttribute();
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 11548, 11573);
return return_v;
}


Microsoft.CodeAnalysis.ObsoleteAttributeData
f_787_11659_11686(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.DecodeDeprecatedAttribute();
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 11659, 11686);
return return_v;
}


Microsoft.CodeAnalysis.ObsoleteAttributeData
f_787_11774_11803(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.DecodeExperimentalAttribute();
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 11774, 11803);
return return_v;
}


System.Exception
f_787_11858_11898(Microsoft.CodeAnalysis.ObsoleteAttributeKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 11858, 11898);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,11330,11925);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,11330,11925);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ObsoleteAttributeData DecodeObsoleteAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,12088,13826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12168,12237);

ImmutableArray<TypedConstant> 
args = f_787_12205_12236(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12290,12313);

string? 
message = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12327,12348);

bool 
isError = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12364,12831) || true) && (args.Length > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,12364,12831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12518,12549);

f_787_12518_12548(args.Length <= 2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12567,12608);

message = (string?)args[0].ValueInternal;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12628,12816) || true) && (args.Length == 2)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,12628,12816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12690,12736);

f_787_12690_12735(args[1].ValueInternal is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12758,12797);

isError = (bool)args[1].ValueInternal!;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,12628,12816);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(787,12364,12831);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12847,12875);

string? 
diagnosticId = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12889,12914);

string? 
urlFormat = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,12928,13691);
foreach(var (name, value) in f_787_12958_12983_I(f_787_12958_12983(this)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,12928,13691);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,13017,13540) || true) && (diagnosticId is null &&(DynAbs.Tracing.TraceSender.Expression_True(787, 13021, 13099)&&name == ObsoleteAttributeData.DiagnosticIdPropertyName )&&(DynAbs.Tracing.TraceSender.Expression_True(787, 13021, 13167)&&f_787_13103_13167(this, ObsoleteAttributeData.DiagnosticIdPropertyName)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,13017,13540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,13209,13254);

diagnosticId = value.ValueInternal as string;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,13017,13540);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,13017,13540);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,13296,13540) || true) && (urlFormat is null &&(DynAbs.Tracing.TraceSender.Expression_True(787, 13300, 13372)&&name == ObsoleteAttributeData.UrlFormatPropertyName )&&(DynAbs.Tracing.TraceSender.Expression_True(787, 13300, 13437)&&f_787_13376_13437(this, ObsoleteAttributeData.UrlFormatPropertyName)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,13296,13540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,13479,13521);

urlFormat = value.ValueInternal as string;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,13296,13540);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(787,13017,13540);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,13560,13676) || true) && (diagnosticId is object &&(DynAbs.Tracing.TraceSender.Expression_True(787, 13564, 13609)&&urlFormat is object))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,13560,13676);
DynAbs.Tracing.TraceSender.TraceBreak(787,13651,13657);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,13560,13676);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(787,12928,13691);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(787,1,764);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(787,1,764);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,13707,13815);

return f_787_13714_13814(ObsoleteAttributeKind.Obsolete, message, isError, diagnosticId, urlFormat);
DynAbs.Tracing.TraceSender.TraceExitMethod(787,12088,13826);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_12205_12236(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 12205, 12236);
return return_v;
}


int
f_787_12518_12548(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 12518, 12548);
return 0;
}


int
f_787_12690_12735(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 12690, 12735);
return 0;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_12958_12983(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonNamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 12958, 12983);
return return_v;
}


bool
f_787_13103_13167(Microsoft.CodeAnalysis.AttributeData
this_param,string
memberName)
{
var return_v = this_param.IsStringProperty( memberName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 13103, 13167);
return return_v;
}


bool
f_787_13376_13437(Microsoft.CodeAnalysis.AttributeData
this_param,string
memberName)
{
var return_v = this_param.IsStringProperty( memberName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 13376, 13437);
return return_v;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_12958_12983_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 12958, 12983);
return return_v;
}


Microsoft.CodeAnalysis.ObsoleteAttributeData
f_787_13714_13814(Microsoft.CodeAnalysis.ObsoleteAttributeKind
kind,string?
message,bool
isError,string?
diagnosticId,string?
urlFormat)
{
var return_v = new Microsoft.CodeAnalysis.ObsoleteAttributeData( kind, message, isError, diagnosticId, urlFormat);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 13714, 13814);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,12088,13826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,12088,13826);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private protected virtual bool IsStringProperty(string memberName) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(787,14473,14512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,14476,14512);
throw f_787_14482_14512();DynAbs.Tracing.TraceSender.TraceExitMethod(787,14473,14512);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,14473,14512);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,14473,14512);
}
			throw new System.Exception("Slicer error: unreachable code");

System.Exception
f_787_14482_14512()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 14482, 14512);
return return_v;
}

		}

private ObsoleteAttributeData DecodeDeprecatedAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,14677,15579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,14759,14802);

var 
args = f_787_14770_14801(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,14857,14880);

string? 
message = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,14894,14915);

bool 
isError = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,14931,15430) || true) && (args.Length == 3 ||(DynAbs.Tracing.TraceSender.Expression_False(787, 14935, 14971)||args.Length == 4))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,14931,15430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,15247,15293);

f_787_15247_15292(args[1].ValueInternal is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,15311,15352);

message = (string?)args[0].ValueInternal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,15370,15415);

isError = ((int)args[1].ValueInternal! == 1);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,14931,15430);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,15446,15568);

return f_787_15453_15567(ObsoleteAttributeKind.Deprecated, message, isError, diagnosticId: null, urlFormat: null);
DynAbs.Tracing.TraceSender.TraceExitMethod(787,14677,15579);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_14770_14801(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 14770, 14801);
return return_v;
}


int
f_787_15247_15292(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 15247, 15292);
return 0;
}


Microsoft.CodeAnalysis.ObsoleteAttributeData
f_787_15453_15567(Microsoft.CodeAnalysis.ObsoleteAttributeKind
kind,string?
message,bool
isError,string?
diagnosticId,string?
urlFormat)
{
var return_v = new Microsoft.CodeAnalysis.ObsoleteAttributeData( kind, message, isError, diagnosticId: diagnosticId, urlFormat: urlFormat);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 15453, 15567);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,14677,15579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,14677,15579);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ObsoleteAttributeData DecodeExperimentalAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,15737,15987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,15862,15920);

f_787_15862_15919(this.CommonConstructorArguments.Length == 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,15934,15976);

return ObsoleteAttributeData.Experimental;
DynAbs.Tracing.TraceSender.TraceExitMethod(787,15737,15987);

int
f_787_15862_15919(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 15862, 15919);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,15737,15987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,15737,15987);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void DecodeMethodImplAttribute<T, TAttributeSyntaxNode, TAttributeData, TAttributeLocation>(
            ref DecodeWellKnownAttributeArguments<TAttributeSyntaxNode, TAttributeData, TAttributeLocation> arguments,
            CommonMessageProvider messageProvider)
            where T : CommonMethodWellKnownAttributeData, new()
            where TAttributeSyntaxNode : SyntaxNode
            where TAttributeData : AttributeData
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(787,15999,18780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,16472,16525);

f_787_16472_16524(arguments.AttributeSyntaxOpt is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,16541,16567);

MethodImplOptions 
options
=default(MethodImplOptions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,16581,16617);

var 
attribute = arguments.Attribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,16631,17711) || true) && (attribute.CommonConstructorArguments.Length == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,16631,17711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,16717,16772);

f_787_16717_16771(f_787_16730_16760(attribute)is object);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,16790,17246) || true) && (f_787_16794_16855(f_787_16794_16843(f_787_16794_16835(f_787_16794_16824(attribute))[0]))== SpecialType.System_Int16)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,16790,17246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,16925,17039);

options = (MethodImplOptions)f_787_16954_16990(attribute)[0].DecodeValue<short>(SpecialType.System_Int16);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,16790,17246);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,16790,17246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17121,17227);

options = f_787_17131_17167(attribute)[0].DecodeValue<MethodImplOptions>(SpecialType.System_Enum);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,16790,17246);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17346,17612) || true) && (((int)options & 3) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,17346,17612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17415,17529);

f_787_17415_17528(                    messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, 0, attribute);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17551,17593);

options = options & ~(MethodImplOptions)3;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,17346,17612);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(787,16631,17711);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,16631,17711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17678,17696);

options = default;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,16631,17711);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17727,17783);

MethodImplAttributes 
codeType = MethodImplAttributes.IL
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17797,17814);

int 
position = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17828,18639);
foreach(var namedArg in f_787_17853_17883_I(f_787_17853_17883(attribute)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,17828,18639);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17917,18593) || true) && (namedArg.Key == "MethodCodeType")
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,17917,18593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,17995,18086);

var 
value = (MethodImplAttributes)namedArg.Value.DecodeValue<int>(SpecialType.System_Enum)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,18108,18574) || true) && (value < 0 ||(DynAbs.Tracing.TraceSender.Expression_False(787, 18112, 18161)||value > MethodImplAttributes.Runtime))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,18108,18574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,18211,18260);

f_787_18211_18259(f_787_18224_18248(attribute)is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,18286,18436);

f_787_18286_18435(                        messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_787_18392_18416(attribute), "MethodCodeType");
DynAbs.Tracing.TraceSender.TraceExitCondition(787,18108,18574);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,18108,18574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,18534,18551);

codeType = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,18108,18574);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(787,17917,18593);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,18613,18624);

position++;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,17828,18639);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(787,1,812);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(787,1,812);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,18655,18769);

f_787_18655_18768(
            arguments.GetOrCreateData<T>(), arguments.Index, (MethodImplAttributes)options | codeType);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(787,15999,18780);

int
f_787_16472_16524(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 16472, 16524);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_787_16730_16760(TAttributeData
this_param)
{
var return_v = this_param.AttributeConstructor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 16730, 16760);
return return_v;
}


int
f_787_16717_16771(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 16717, 16771);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_787_16794_16824(TAttributeData
this_param)
{
var return_v = this_param.AttributeConstructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 16794, 16824);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
f_787_16794_16835(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 16794, 16835);
return return_v;
}


Microsoft.CodeAnalysis.ITypeSymbol
f_787_16794_16843(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 16794, 16843);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_787_16794_16855(Microsoft.CodeAnalysis.ITypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 16794, 16855);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_16954_16990(TAttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 16954, 16990);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_17131_17167(TAttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 17131, 17167);
return return_v;
}


int
f_787_17415_17528(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,TAttributeSyntaxNode
attributeSyntax,int
parameterIndex,TAttributeData
attribute)
{
this_param.ReportInvalidAttributeArgument( diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, parameterIndex, (Microsoft.CodeAnalysis.AttributeData)attribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 17415, 17528);
return 0;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_17853_17883(TAttributeData
this_param)
{
var return_v = this_param.CommonNamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 17853, 17883);
return return_v;
}


Microsoft.CodeAnalysis.INamedTypeSymbol?
f_787_18224_18248(TAttributeData
this_param)
{
var return_v = this_param.AttributeClass ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 18224, 18248);
return return_v;
}


int
f_787_18211_18259(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 18211, 18259);
return 0;
}


Microsoft.CodeAnalysis.INamedTypeSymbol
f_787_18392_18416(TAttributeData
this_param)
{
var return_v = this_param.AttributeClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 18392, 18416);
return return_v;
}


int
f_787_18286_18435(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,TAttributeSyntaxNode
attributeSyntax,int
namedArgumentIndex,Microsoft.CodeAnalysis.INamedTypeSymbol
attributeClass,string
parameterName)
{
this_param.ReportInvalidNamedArgument( diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol)attributeClass, parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 18286, 18435);
return 0;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_17853_17883_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 17853, 17883);
return return_v;
}


int
f_787_18655_18768(T
this_param,int
attributeIndex,System.Reflection.MethodImplAttributes
attributes)
{
this_param.SetMethodImplementation( attributeIndex, attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 18655, 18768);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,15999,18780);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,15999,18780);
}
		}

internal static void DecodeStructLayoutAttribute<TTypeWellKnownAttributeData, TAttributeSyntaxNode, TAttributeData, TAttributeLocation>(
            ref DecodeWellKnownAttributeArguments<TAttributeSyntaxNode, TAttributeData, TAttributeLocation> arguments,
            CharSet defaultCharSet,
            int defaultAutoLayoutSize,
            CommonMessageProvider messageProvider)
            where TTypeWellKnownAttributeData : CommonTypeWellKnownAttributeData, new()
            where TAttributeSyntaxNode : SyntaxNode
            where TAttributeData : AttributeData
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(787,18792,23243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19394,19447);

f_787_19394_19446(arguments.AttributeSyntaxOpt is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19463,19499);

var 
attribute = arguments.Attribute
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19513,19562);

f_787_19513_19561(f_787_19526_19550(attribute)is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19578,19675);

CharSet 
charSet = (DynAbs.Tracing.TraceSender.Conditional_F1(787, 19596, 19642)||(((defaultCharSet != Cci.Constants.CharSet_None) &&DynAbs.Tracing.TraceSender.Conditional_F2(787, 19645, 19659))||DynAbs.Tracing.TraceSender.Conditional_F3(787, 19662, 19674)))?defaultCharSet :CharSet.Ansi
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19689,19706);

int? 
size = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19720,19742);

int? 
alignment = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19756,19779);

bool 
hasErrors = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19795,19902);

LayoutKind 
kind = f_787_19813_19849(attribute)[0].DecodeValue<LayoutKind>(SpecialType.System_Enum)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,19916,20345);

switch (kind)
            {

case LayoutKind.Auto:
                case LayoutKind.Explicit:
                case LayoutKind.Sequential:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,19916,20345);
DynAbs.Tracing.TraceSender.TraceBreak(787,20093,20099);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,19916,20345);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,19916,20345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,20149,20263);

f_787_20149_20262(                    messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, 0, attribute);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,20285,20302);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceBreak(787,20324,20330);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,19916,20345);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,20361,20378);

int 
position = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,20392,22631);
foreach(var namedArg in f_787_20417_20447_I(f_787_20417_20447(attribute)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,20392,22631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,20481,22585);

switch (namedArg.Key)
                {

case "CharSet":
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,20481,22585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,20584,20655);

charSet = namedArg.Value.DecodeValue<CharSet>(SpecialType.System_Enum);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,20681,21424);

switch (charSet)
                        {

case Cci.Constants.CharSet_None:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,20681,21424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,20820,20843);

charSet = CharSet.Ansi;
DynAbs.Tracing.TraceSender.TraceBreak(787,20877,20883);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,20681,21424);

case CharSet.Ansi:
                            case Cci.Constants.CharSet_Auto:
                            case CharSet.Unicode:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,20681,21424);
DynAbs.Tracing.TraceSender.TraceBreak(787,21080,21086);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,20681,21424);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,20681,21424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,21160,21306);

f_787_21160_21305(                                messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_787_21266_21290(attribute), namedArg.Key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,21340,21357);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceBreak(787,21391,21397);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,20681,21424);
                        }
DynAbs.Tracing.TraceSender.TraceBreak(787,21452,21458);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,20481,22585);

case "Pack":
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,20481,22585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,21520,21590);

alignment = namedArg.Value.DecodeValue<int>(SpecialType.System_Int32);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,21697,22032) || true) && (alignment > 128 ||(DynAbs.Tracing.TraceSender.Expression_False(787, 21701, 21754)||(alignment & (alignment - 1)) != 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,21697,22032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,21812,21958);

f_787_21812_21957(                            messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_787_21918_21942(attribute), namedArg.Key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,21988,22005);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,21697,22032);
}
DynAbs.Tracing.TraceSender.TraceBreak(787,22060,22066);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,20481,22585);

case "Size":
DynAbs.Tracing.TraceSender.TraceEnterCondition(787,20481,22585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,22128,22216);

size = namedArg.Value.DecodeValue<int>(Microsoft.CodeAnalysis.SpecialType.System_Int32);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,22242,22532) || true) && (size < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,22242,22532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,22312,22458);

f_787_22312_22457(                            messageProvider, arguments.Diagnostics, arguments.AttributeSyntaxOpt, position, f_787_22418_22442(attribute), namedArg.Key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,22488,22505);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,22242,22532);
}
DynAbs.Tracing.TraceSender.TraceBreak(787,22560,22566);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,20481,22585);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,22605,22616);

position++;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,20392,22631);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(787,1,2240);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(787,1,2240);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,22647,23232) || true) && (!hasErrors)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,22647,23232);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,22695,23058) || true) && (kind == LayoutKind.Auto &&(DynAbs.Tracing.TraceSender.Expression_True(787, 22699, 22738)&&size == null )&&(DynAbs.Tracing.TraceSender.Expression_True(787, 22699, 22759)&&alignment != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(787,22695,23058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,23010,23039);

size = defaultAutoLayoutSize;
DynAbs.Tracing.TraceSender.TraceExitCondition(787,22695,23058);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,23078,23217);

f_787_23078_23216(
                arguments.GetOrCreateData<TTypeWellKnownAttributeData>(), f_787_23151_23206(kind, size ??(DynAbs.Tracing.TraceSender.Expression_Null<int?>(787, 23172, 23181)??0), (byte)(alignment ??(DynAbs.Tracing.TraceSender.Expression_Null<int?>(787, 23190, 23204)??0))), charSet);
DynAbs.Tracing.TraceSender.TraceExitCondition(787,22647,23232);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(787,18792,23243);

int
f_787_19394_19446(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 19394, 19446);
return 0;
}


Microsoft.CodeAnalysis.INamedTypeSymbol?
f_787_19526_19550(TAttributeData
this_param)
{
var return_v = this_param.AttributeClass ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 19526, 19550);
return return_v;
}


int
f_787_19513_19561(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 19513, 19561);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_19813_19849(TAttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 19813, 19849);
return return_v;
}


int
f_787_20149_20262(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,TAttributeSyntaxNode
attributeSyntax,int
parameterIndex,TAttributeData
attribute)
{
this_param.ReportInvalidAttributeArgument( diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, parameterIndex, (Microsoft.CodeAnalysis.AttributeData)attribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 20149, 20262);
return 0;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_20417_20447(TAttributeData
this_param)
{
var return_v = this_param.CommonNamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 20417, 20447);
return return_v;
}


Microsoft.CodeAnalysis.INamedTypeSymbol
f_787_21266_21290(TAttributeData
this_param)
{
var return_v = this_param.AttributeClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 21266, 21290);
return return_v;
}


int
f_787_21160_21305(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,TAttributeSyntaxNode
attributeSyntax,int
namedArgumentIndex,Microsoft.CodeAnalysis.INamedTypeSymbol
attributeClass,string
parameterName)
{
this_param.ReportInvalidNamedArgument( diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol)attributeClass, parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 21160, 21305);
return 0;
}


Microsoft.CodeAnalysis.INamedTypeSymbol
f_787_21918_21942(TAttributeData
this_param)
{
var return_v = this_param.AttributeClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 21918, 21942);
return return_v;
}


int
f_787_21812_21957(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,TAttributeSyntaxNode
attributeSyntax,int
namedArgumentIndex,Microsoft.CodeAnalysis.INamedTypeSymbol
attributeClass,string
parameterName)
{
this_param.ReportInvalidNamedArgument( diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol)attributeClass, parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 21812, 21957);
return 0;
}


Microsoft.CodeAnalysis.INamedTypeSymbol
f_787_22418_22442(TAttributeData
this_param)
{
var return_v = this_param.AttributeClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 22418, 22442);
return return_v;
}


int
f_787_22312_22457(Microsoft.CodeAnalysis.CommonMessageProvider
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,TAttributeSyntaxNode
attributeSyntax,int
namedArgumentIndex,Microsoft.CodeAnalysis.INamedTypeSymbol
attributeClass,string
parameterName)
{
this_param.ReportInvalidNamedArgument( diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)attributeSyntax, namedArgumentIndex, (Microsoft.CodeAnalysis.ITypeSymbol)attributeClass, parameterName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 22312, 22457);
return 0;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_20417_20447_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 20417, 20447);
return return_v;
}


Microsoft.CodeAnalysis.TypeLayout
f_787_23151_23206(System.Runtime.InteropServices.LayoutKind
kind,int
size,int
alignment)
{
var return_v = new Microsoft.CodeAnalysis.TypeLayout( kind, size, (byte)alignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 23151, 23206);
return return_v;
}


int
f_787_23078_23216(TTypeWellKnownAttributeData
this_param,Microsoft.CodeAnalysis.TypeLayout
layout,System.Runtime.InteropServices.CharSet
charSet)
{
this_param.SetStructLayout( layout, charSet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 23078, 23216);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,18792,23243);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,18792,23243);
}
		}

internal AttributeUsageInfo DecodeAttributeUsageAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(787,23255,23450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,23339,23439);

return f_787_23346_23438(f_787_23376_23407(this)[0], f_787_23412_23437(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(787,23255,23450);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_787_23376_23407(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 23376, 23407);
return return_v;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_787_23412_23437(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonNamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(787, 23412, 23437);
return return_v;
}


Microsoft.CodeAnalysis.AttributeUsageInfo
f_787_23346_23438(Microsoft.CodeAnalysis.TypedConstant
positionalArg,System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
namedArgs)
{
var return_v = DecodeAttributeUsageAttribute( positionalArg, namedArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 23346, 23438);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,23255,23450);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,23255,23450);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static AttributeUsageInfo DecodeAttributeUsageAttribute(TypedConstant positionalArg, ImmutableArray<KeyValuePair<string, TypedConstant>> namedArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(787,23462,25141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,24696,24748);

f_787_24696_24747(positionalArg.ValueInternal is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,24762,24822);

var 
validOn = (AttributeTargets)positionalArg.ValueInternal
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,24836,24940);

bool 
allowMultiple = f_787_24857_24939(namedArgs, "AllowMultiple", SpecialType.System_Boolean, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,24954,25049);

bool 
inherited = f_787_24971_25048(namedArgs, "Inherited", SpecialType.System_Boolean, true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(787,25065,25130);

return f_787_25072_25129(validOn, allowMultiple, inherited);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(787,23462,25141);

int
f_787_24696_24747(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 24696, 24747);
return 0;
}


bool
f_787_24857_24939(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
namedArguments,string
name,Microsoft.CodeAnalysis.SpecialType
specialType,bool
defaultValue)
{
var return_v = DecodeNamedArgument( namedArguments, name, specialType, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 24857, 24939);
return return_v;
}


bool
f_787_24971_25048(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
namedArguments,string
name,Microsoft.CodeAnalysis.SpecialType
specialType,bool
defaultValue)
{
var return_v = DecodeNamedArgument( namedArguments, name, specialType, defaultValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 24971, 25048);
return return_v;
}


Microsoft.CodeAnalysis.AttributeUsageInfo
f_787_25072_25129(System.AttributeTargets
validTargets,bool
allowMultiple,bool
inherited)
{
var return_v = new Microsoft.CodeAnalysis.AttributeUsageInfo( validTargets, allowMultiple, inherited);
DynAbs.Tracing.TraceSender.TraceEndInvocation(787, 25072, 25129);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(787,23462,25141);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,23462,25141);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static AttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(787,574,25148);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(787,574,25148);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(787,574,25148);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(787,574,25148);
}
}
