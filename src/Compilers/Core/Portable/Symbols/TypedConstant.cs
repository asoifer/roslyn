// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

public struct TypedConstant : IEquatable<TypedConstant>
    {

private readonly TypedConstantKind _kind;

private readonly ITypeSymbolInternal? _type;

private readonly object? _value;

internal TypedConstant(ITypeSymbolInternal? type, TypedConstantKind kind, object? value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(647,774,1228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,887,978);

f_647_887_977(kind == TypedConstantKind.Array ||(DynAbs.Tracing.TraceSender.Expression_False(647, 900, 976)||!(value is ImmutableArray<TypedConstant>)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,992,1054);

f_647_992_1053(!(value is ISymbol) ||(DynAbs.Tracing.TraceSender.Expression_False(647, 1005, 1052)||value is ISymbolInternal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,1068,1132);

f_647_1068_1131(type is object ||(DynAbs.Tracing.TraceSender.Expression_False(647, 1081, 1130)||kind == TypedConstantKind.Error));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,1148,1161);

_kind = kind;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,1175,1188);

_type = type;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,1202,1217);

_value = value;
DynAbs.Tracing.TraceSender.TraceExitConstructor(647,774,1228);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,774,1228);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,774,1228);
}
		}

internal TypedConstant(ITypeSymbolInternal type, ImmutableArray<TypedConstant> array)
:this(f_647_1346_1350_C(type) ,TypedConstantKind.Array,value: (DynAbs.Tracing.TraceSender.Conditional_F1(647, 1384, 1399)||((array.IsDefault &&DynAbs.Tracing.TraceSender.Conditional_F2(647, 1402, 1406))||DynAbs.Tracing.TraceSender.Conditional_F3(647, 1409, 1422)))?null :(object)array)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(647,1240,1445);
DynAbs.Tracing.TraceSender.TraceExitConstructor(647,1240,1445);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,1240,1445);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,1240,1445);
}
		}

public TypedConstantKind Kind
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(647,1597,1618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,1603,1616);

return _kind;
DynAbs.Tracing.TraceSender.TraceExitMethod(647,1597,1618);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,1543,1629);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,1543,1629);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ITypeSymbol? Type
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(647,1868,1907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,1874,1905);

return f_647_1881_1904_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_type, 647, 1881, 1904)?.GetITypeSymbol());
DynAbs.Tracing.TraceSender.TraceExitMethod(647,1868,1907);

Microsoft.CodeAnalysis.ITypeSymbol?
f_647_1881_1904_I(Microsoft.CodeAnalysis.ITypeSymbol?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 1881, 1904);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,1819,1918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,1819,1918);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal ITypeSymbolInternal? TypeInternal
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(647,1997,2018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,2003,2016);

return _type;
DynAbs.Tracing.TraceSender.TraceExitMethod(647,1997,2018);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,1930,2029);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,1930,2029);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool IsNull
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,2194,2267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,2230,2252);

return _value == null;
DynAbs.Tracing.TraceSender.TraceExitMethod(647,2194,2267);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,2151,2278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,2151,2278);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public object? Value
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,2431,2691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,2467,2498);

object? 
result = ValueInternal
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,2518,2642) || true) && (result is ISymbolInternal symbol)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(647,2518,2642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,2596,2623);

return f_647_2603_2622(symbol);
DynAbs.Tracing.TraceSender.TraceExitCondition(647,2518,2642);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,2662,2676);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(647,2431,2691);

Microsoft.CodeAnalysis.ISymbol
f_647_2603_2622(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
this_param)
{
var return_v = this_param.GetISymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 2603, 2622);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,2386,2702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,2386,2702);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal object? ValueInternal
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,2922,3190);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,2958,3141) || true) && (Kind == TypedConstantKind.Array)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(647,2958,3141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3035,3122);

throw f_647_3041_3121("TypedConstant is an array. Use Values property.");
DynAbs.Tracing.TraceSender.TraceExitCondition(647,2958,3141);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3161,3175);

return _value;
DynAbs.Tracing.TraceSender.TraceExitMethod(647,2922,3190);

System.InvalidOperationException
f_647_3041_3121(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 3041, 3121);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,2867,3201);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,2867,3201);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ImmutableArray<TypedConstant> Values
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,3393,3807);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3429,3615) || true) && (Kind != TypedConstantKind.Array)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(647,3429,3615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3506,3596);

throw f_647_3512_3595("TypedConstant is not an array. Use Value property.");
DynAbs.Tracing.TraceSender.TraceExitCondition(647,3429,3615);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3635,3726) || true) && (this.IsNull)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(647,3635,3726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3692,3707);

return default;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,3635,3726);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3746,3792);

return (ImmutableArray<TypedConstant>)_value!;
DynAbs.Tracing.TraceSender.TraceExitMethod(647,3393,3807);

System.InvalidOperationException
f_647_3512_3595(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 3512, 3595);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,3325,3818);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,3325,3818);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal T? DecodeValue<T>(SpecialType specialType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,3830,3986);
T? value = default(T?);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3906,3948);

TryDecodeValue(specialType, out value
);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,3962,3975);

return value;
DynAbs.Tracing.TraceSender.TraceExitMethod(647,3830,3986);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,3830,3986);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,3830,3986);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool TryDecodeValue<T>(SpecialType specialType, [MaybeNullWhen(false)] out T value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,3998,4679);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,4115,4247) || true) && (_kind == TypedConstantKind.Error)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(647,4115,4247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,4185,4201);

value = default;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,4219,4232);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,4115,4247);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,4263,4477) || true) && (f_647_4267_4285(_type!)== specialType ||(DynAbs.Tracing.TraceSender.Expression_False(647, 4267, 4379)||(f_647_4305_4319(_type)== TypeKind.Enum &&(DynAbs.Tracing.TraceSender.Expression_True(647, 4305, 4378)&&specialType == SpecialType.System_Enum))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(647,4263,4477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,4413,4432);

value = (T)_value!;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,4450,4462);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,4263,4477);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,4625,4641);

value = default;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,4655,4668);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(647,3998,4679);

Microsoft.CodeAnalysis.SpecialType
f_647_4267_4285(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(647, 4267, 4285);
return return_v;
}


Microsoft.CodeAnalysis.TypeKind
f_647_4305_4319(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
this_param)
{
var return_v = this_param.TypeKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(647, 4305, 4319);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,3998,4679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,3998,4679);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static TypedConstantKind GetTypedConstantKind(ITypeSymbolInternal type, Compilation compilation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(647,4904,6593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,5034,5067);

f_647_5034_5066(type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,5083,6582);

switch (f_647_5091_5107(type))
            {

case SpecialType.System_Boolean:
                case SpecialType.System_SByte:
                case SpecialType.System_Int16:
                case SpecialType.System_Int32:
                case SpecialType.System_Int64:
                case SpecialType.System_Byte:
                case SpecialType.System_UInt16:
                case SpecialType.System_UInt32:
                case SpecialType.System_UInt64:
                case SpecialType.System_Single:
                case SpecialType.System_Double:
                case SpecialType.System_Char:
                case SpecialType.System_String:
                case SpecialType.System_Object:
DynAbs.Tracing.TraceSender.TraceEnterCondition(647,5083,6582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,5824,5859);

return TypedConstantKind.Primitive;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,5083,6582);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(647,5083,6582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,5907,6294);

switch (f_647_5915_5928(type))
                    {

case TypeKind.Array:
DynAbs.Tracing.TraceSender.TraceEnterCondition(647,5907,6294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,6028,6059);

return TypedConstantKind.Array;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,5907,6294);

case TypeKind.Enum:
DynAbs.Tracing.TraceSender.TraceEnterCondition(647,5907,6294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,6134,6164);

return TypedConstantKind.Enum;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,5907,6294);

case TypeKind.Error:
DynAbs.Tracing.TraceSender.TraceEnterCondition(647,5907,6294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,6240,6271);

return TypedConstantKind.Error;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,5907,6294);
                    }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,6318,6512) || true) && (compilation != null &&(DynAbs.Tracing.TraceSender.Expression_True(647, 6322, 6409)&&f_647_6370_6409(                        compilation, type)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(647,6318,6512);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,6459,6489);

return TypedConstantKind.Type;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,6318,6512);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,6536,6567);

return TypedConstantKind.Error;
DynAbs.Tracing.TraceSender.TraceExitCondition(647,5083,6582);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(647,4904,6593);

int
f_647_5034_5066(bool
b)
{
RoslynDebug.Assert( b);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 5034, 5066);
return 0;
}


Microsoft.CodeAnalysis.SpecialType
f_647_5091_5107(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(647, 5091, 5107);
return return_v;
}


Microsoft.CodeAnalysis.TypeKind
f_647_5915_5928(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
this_param)
{
var return_v = this_param.TypeKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(647, 5915, 5928);
return return_v;
}


bool
f_647_6370_6409(Microsoft.CodeAnalysis.Compilation
this_param,Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
type)
{
var return_v = this_param.IsSystemTypeReference( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 6370, 6409);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,4904,6593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,4904,6593);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object? obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,6605,6739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,6670,6728);

return obj is TypedConstant &&(DynAbs.Tracing.TraceSender.Expression_True(647, 6677, 6727)&&Equals(obj));
DynAbs.Tracing.TraceSender.TraceExitMethod(647,6605,6739);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,6605,6739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,6605,6739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool Equals(TypedConstant other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,6751,6964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,6815,6953);

return _kind == other._kind
&&(DynAbs.Tracing.TraceSender.Expression_True(647, 6822, 6898)&&f_647_6863_6898(_value, other._value))&&(DynAbs.Tracing.TraceSender.Expression_True(647, 6822, 6952)&&f_647_6919_6952(_type, other._type));
DynAbs.Tracing.TraceSender.TraceExitMethod(647,6751,6964);

bool
f_647_6863_6898(object?
objA,object?
objB)
{
var return_v = object.Equals( objA, objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 6863, 6898);
return return_v;
}


bool
f_647_6919_6952(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
objA,Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 6919, 6952);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,6751,6964);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,6751,6964);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(647,6976,7130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(647,7034,7119);

return f_647_7041_7118(_value, f_647_7082_7117(_type, this.Kind));
DynAbs.Tracing.TraceSender.TraceExitMethod(647,6976,7130);

int
f_647_7082_7117(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?
newKeyPart,Microsoft.CodeAnalysis.TypedConstantKind
currentKey)
{
var return_v = Hash.Combine( newKeyPart, (int)currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 7082, 7117);
return return_v;
}


int
f_647_7041_7118(object?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 7041, 7118);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(647,6976,7130);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,6976,7130);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static TypedConstant(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(647,553,15235);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(647,553,15235);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(647,553,15235);
}

static int
f_647_887_977(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 887, 977);
return 0;
}


static int
f_647_992_1053(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 992, 1053);
return 0;
}


static int
f_647_1068_1131(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(647, 1068, 1131);
return 0;
}


static Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
f_647_1346_1350_C(Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(647, 1240, 1445);
return return_v;
}


                    }
}
