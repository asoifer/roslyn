// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
public static partial class ISymbolExtensions
{
public static IMethodSymbol? GetConstructedReducedFrom(this IMethodSymbol method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(624,573,2324);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,679,843) || true) && (f_624_683_700(method)!= MethodKind.ReducedExtension)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,679,843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,816,828);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(624,679,843);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,859,896);

var 
reducedFrom = f_624_877_895(method)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,910,946);

f_624_910_945(reducedFrom is object);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,960,1117) || true) && (f_624_964_992_M(!reducedFrom.IsGenericMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,960,1117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1083,1102);

return reducedFrom;
DynAbs.Tracing.TraceSender.TraceExitCondition(624,960,1117);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1133,1199);

var 
typeArgs = new ITypeSymbol[reducedFrom.TypeParameters.Length]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1295,1300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1302,1334);

            // first seed with any type arguments from reduced method
            for (int 
i = 0
, 
n = method.TypeParameters.Length
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1286,1875) || true) && (i < n)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1343,1346)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(624,1286,1875))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,1286,1875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1380,1414);

var 
arg = f_624_1390_1410(method)[i]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1432,1477);

var 
typeParameter = f_624_1452_1473(method)[i]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1495,1545);

f_624_1495_1544(f_624_1508_1533(typeParameter)is object);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1668,1790) || true) && (f_624_1672_1697(arg, typeParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,1668,1790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1739,1771);

arg = f_624_1745_1770(typeParameter);
DynAbs.Tracing.TraceSender.TraceExitCondition(624,1668,1790);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1810,1860);

typeArgs[f_624_1819_1852(f_624_1819_1844(typeParameter))] = arg;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(624,1,590);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(624,1,590);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1935,1940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1942,1979);

            // add any inferences
            for (int 
i = 0
, 
n = reducedFrom.TypeParameters.Length
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1926,2258) || true) && (i < n)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,1988,1991)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(624,1926,2258))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,1926,2258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,2025,2113);

var 
inferredType = f_624_2044_2112(method, f_624_2082_2108(reducedFrom)[i])
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,2131,2243) || true) && (inferredType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,2131,2243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,2197,2224);

typeArgs[i] = inferredType;
DynAbs.Tracing.TraceSender.TraceExitCondition(624,2131,2243);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(624,1,333);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(624,1,333);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,2274,2313);

return f_624_2281_2312(reducedFrom, typeArgs);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(624,573,2324);

Microsoft.CodeAnalysis.MethodKind
f_624_683_700(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.MethodKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 683, 700);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_624_877_895(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.ReducedFrom;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 877, 895);
return return_v;
}


int
f_624_910_945(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 910, 945);
return 0;
}


bool
f_624_964_992_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 964, 992);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
f_624_1390_1410(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.TypeArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 1390, 1410);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
f_624_1452_1473(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.TypeParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 1452, 1473);
return return_v;
}


Microsoft.CodeAnalysis.ITypeParameterSymbol?
f_624_1508_1533(Microsoft.CodeAnalysis.ITypeParameterSymbol
this_param)
{
var return_v = this_param.ReducedFrom ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 1508, 1533);
return return_v;
}


int
f_624_1495_1544(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 1495, 1544);
return 0;
}


bool
f_624_1672_1697(Microsoft.CodeAnalysis.ITypeSymbol
this_param,Microsoft.CodeAnalysis.ITypeParameterSymbol
other)
{
var return_v = this_param.Equals( (Microsoft.CodeAnalysis.ISymbol)other);
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 1672, 1697);
return return_v;
}


Microsoft.CodeAnalysis.ITypeParameterSymbol
f_624_1745_1770(Microsoft.CodeAnalysis.ITypeParameterSymbol
this_param)
{
var return_v = this_param.ReducedFrom;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 1745, 1770);
return return_v;
}


Microsoft.CodeAnalysis.ITypeParameterSymbol
f_624_1819_1844(Microsoft.CodeAnalysis.ITypeParameterSymbol
this_param)
{
var return_v = this_param.ReducedFrom;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 1819, 1844);
return return_v;
}


int
f_624_1819_1852(Microsoft.CodeAnalysis.ITypeParameterSymbol
this_param)
{
var return_v = this_param.Ordinal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 1819, 1852);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
f_624_2082_2108(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.TypeParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 2082, 2108);
return return_v;
}


Microsoft.CodeAnalysis.ITypeSymbol?
f_624_2044_2112(Microsoft.CodeAnalysis.IMethodSymbol
this_param,Microsoft.CodeAnalysis.ITypeParameterSymbol
reducedFromTypeParameter)
{
var return_v = this_param.GetTypeInferredDuringReduction( reducedFromTypeParameter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 2044, 2112);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_624_2281_2312(Microsoft.CodeAnalysis.IMethodSymbol
this_param,params Microsoft.CodeAnalysis.ITypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 2281, 2312);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(624,573,2324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(624,573,2324);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsDefaultTupleElement(this IFieldSymbol field)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(624,2453,2610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,2545,2599);

return (object)field == f_624_2569_2598(field);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(624,2453,2610);

Microsoft.CodeAnalysis.IFieldSymbol?
f_624_2569_2598(Microsoft.CodeAnalysis.IFieldSymbol
this_param)
{
var return_v = this_param.CorrespondingTupleField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 2569, 2598);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(624,2453,2610);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(624,2453,2610);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsTupleElement(this IFieldSymbol field)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(624,2731,2874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,2816,2863);

return f_624_2823_2852(field)is object;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(624,2731,2874);

Microsoft.CodeAnalysis.IFieldSymbol?
f_624_2823_2852(Microsoft.CodeAnalysis.IFieldSymbol
this_param)
{
var return_v = this_param.CorrespondingTupleField ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 2823, 2852);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(624,2731,2874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(624,2731,2874);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string? ProvidedTupleElementNameOrNull(this IFieldSymbol field)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(624,3312,3508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,3416,3497);

return (DynAbs.Tracing.TraceSender.Conditional_F1(624, 3423, 3476)||((f_624_3423_3445(field)&&(DynAbs.Tracing.TraceSender.Expression_True(624, 3423, 3476)&&f_624_3449_3476_M(!field.IsImplicitlyDeclared))&&DynAbs.Tracing.TraceSender.Conditional_F2(624, 3479, 3489))||DynAbs.Tracing.TraceSender.Conditional_F3(624, 3492, 3496)))?f_624_3479_3489(field):null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(624,3312,3508);

bool
f_624_3423_3445(Microsoft.CodeAnalysis.IFieldSymbol
field)
{
var return_v = field.IsTupleElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 3423, 3445);
return return_v;
}


bool
f_624_3449_3476_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 3449, 3476);
return return_v;
}


string
f_624_3479_3489(Microsoft.CodeAnalysis.IFieldSymbol
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 3479, 3489);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(624,3312,3508);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(624,3312,3508);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static INamespaceSymbol? GetNestedNamespace(this INamespaceSymbol container, string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(624,3520,3903);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,3643,3864);
foreach(var sym in f_624_3663_3689_I(f_624_3663_3689(container, name)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,3643,3864);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,3723,3849) || true) && (f_624_3727_3735(sym)== SymbolKind.Namespace)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,3723,3849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,3801,3830);

return (INamespaceSymbol)sym;
DynAbs.Tracing.TraceSender.TraceExitCondition(624,3723,3849);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(624,3643,3864);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(624,1,222);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(624,1,222);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,3880,3892);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(624,3520,3903);

System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
f_624_3663_3689(Microsoft.CodeAnalysis.INamespaceSymbol
this_param,string
name)
{
var return_v = this_param.GetMembers( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 3663, 3689);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_624_3727_3735(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 3727, 3735);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
f_624_3663_3689_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 3663, 3689);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(624,3520,3903);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(624,3520,3903);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsNetModule(this IAssemblySymbol assembly) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(624,3979,4106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,3995,4106);
return assembly is ISourceAssemblySymbol sourceAssembly &&(DynAbs.Tracing.TraceSender.Expression_True(624, 3995, 4106)&&f_624_4047_4106(f_624_4047_4092(f_624_4047_4081(f_624_4047_4073(sourceAssembly)))));DynAbs.Tracing.TraceSender.TraceExitMethod(624,3979,4106);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(624,3979,4106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(624,3979,4106);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.Compilation
f_624_4047_4073(Microsoft.CodeAnalysis.ISourceAssemblySymbol
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 4047, 4073);
return return_v;
}


Microsoft.CodeAnalysis.CompilationOptions
f_624_4047_4081(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 4047, 4081);
return return_v;
}


Microsoft.CodeAnalysis.OutputKind
f_624_4047_4092(Microsoft.CodeAnalysis.CompilationOptions
this_param)
{
var return_v = this_param.OutputKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 4047, 4092);
return return_v;
}


bool
f_624_4047_4106(Microsoft.CodeAnalysis.OutputKind
kind)
{
var return_v = kind.IsNetModule();
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 4047, 4106);
return return_v;
}

		}

internal static bool IsInSource(this ISymbol symbol)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(624,4119,4422);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,4196,4382);
foreach(var location in f_624_4221_4237_I(f_624_4221_4237(symbol)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,4196,4382);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,4271,4367) || true) && (f_624_4275_4294(location))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(624,4271,4367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,4336,4348);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(624,4271,4367);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(624,4196,4382);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(624,1,187);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(624,1,187);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(624,4398,4411);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(624,4119,4422);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
f_624_4221_4237(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.Locations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 4221, 4237);
return return_v;
}


bool
f_624_4275_4294(Microsoft.CodeAnalysis.Location
this_param)
{
var return_v = this_param.IsInSource;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(624, 4275, 4294);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
f_624_4221_4237_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(624, 4221, 4237);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(624,4119,4422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(624,4119,4422);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ISymbolExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(624,278,4429);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(624,278,4429);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(624,278,4429);
}

}
}
