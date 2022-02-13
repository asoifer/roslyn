// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal class BuiltInOperators
{
private readonly CSharpCompilation _compilation;

private ImmutableArray<UnaryOperatorSignature>[] _builtInUnaryOperators;

private ImmutableArray<BinaryOperatorSignature>[][] _builtInOperators;

internal BuiltInOperators(CSharpCompilation compilation)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10913,1034,1153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,778,790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,919,941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,1004,1021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,1115,1142);

_compilation = compilation;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10913,1034,1153);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,1034,1153);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,1034,1153);
}
		}

private ImmutableArray<UnaryOperatorSignature> GetSignaturesFromUnaryOperatorKinds(int[] operatorKinds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,1378,1782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,1506,1571);

var 
builder = f_10913_1520_1570()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,1585,1719);
foreach(var kind in f_10913_1606_1619_I(operatorKinds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,1585,1719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,1653,1704);

f_10913_1653_1703(                builder, f_10913_1665_1702(this, kind));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,1585,1719);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10913,1,135);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10913,1,135);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,1735,1771);

return f_10913_1742_1770(builder);
DynAbs.Tracing.TraceSender.TraceExitMethod(10913,1378,1782);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_1520_1570()
{
var return_v = ArrayBuilder<UnaryOperatorSignature>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 1520, 1570);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
f_10913_1665_1702(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int
kind)
{
var return_v = this_param.GetSignature( (Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind)kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 1665, 1702);
return return_v;
}


int
f_10913_1653_1703(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 1653, 1703);
return 0;
}


int[]
f_10913_1606_1619_I(int[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 1606, 1619);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_1742_1770(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 1742, 1770);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,1378,1782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,1378,1782);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GetSimpleBuiltInOperators(UnaryOperatorKind kind, ArrayBuilder<UnaryOperatorSignature> operators, bool skipNativeIntegerOperators)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,1794,15091);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,1963,14600) || true) && (_builtInUnaryOperators == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,1963,14600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,2031,14489);

var 
allOperators = new ImmutableArray<UnaryOperatorSignature>[]
                {
f_10913_2135_4290(this, new []
                    {
                        (int)UnaryOperatorKind.SBytePostfixIncrement,
                        (int)UnaryOperatorKind.BytePostfixIncrement,
                        (int)UnaryOperatorKind.ShortPostfixIncrement,
                        (int)UnaryOperatorKind.UShortPostfixIncrement,
                        (int)UnaryOperatorKind.IntPostfixIncrement,
                        (int)UnaryOperatorKind.UIntPostfixIncrement,
                        (int)UnaryOperatorKind.LongPostfixIncrement,
                        (int)UnaryOperatorKind.ULongPostfixIncrement,
                        (int)UnaryOperatorKind.NIntPostfixIncrement,
                        (int)UnaryOperatorKind.NUIntPostfixIncrement,
                        (int)UnaryOperatorKind.CharPostfixIncrement,
                        (int)UnaryOperatorKind.FloatPostfixIncrement,
                        (int)UnaryOperatorKind.DoublePostfixIncrement,
                        (int)UnaryOperatorKind.DecimalPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedSBytePostfixIncrement,
                        (int)UnaryOperatorKind.LiftedBytePostfixIncrement,
                        (int)UnaryOperatorKind.LiftedShortPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedUShortPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedIntPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedUIntPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedLongPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedULongPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedNIntPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedNUIntPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedCharPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedFloatPostfixIncrement,
                        (int)UnaryOperatorKind.LiftedDoublePostfixIncrement,
                        (int)UnaryOperatorKind.LiftedDecimalPostfixIncrement,
                    }),
f_10913_4313_6468(this, new []
                    {
                        (int)UnaryOperatorKind.SBytePostfixDecrement,
                        (int)UnaryOperatorKind.BytePostfixDecrement,
                        (int)UnaryOperatorKind.ShortPostfixDecrement,
                        (int)UnaryOperatorKind.UShortPostfixDecrement,
                        (int)UnaryOperatorKind.IntPostfixDecrement,
                        (int)UnaryOperatorKind.UIntPostfixDecrement,
                        (int)UnaryOperatorKind.LongPostfixDecrement,
                        (int)UnaryOperatorKind.ULongPostfixDecrement,
                        (int)UnaryOperatorKind.NIntPostfixDecrement,
                        (int)UnaryOperatorKind.NUIntPostfixDecrement,
                        (int)UnaryOperatorKind.CharPostfixDecrement,
                        (int)UnaryOperatorKind.FloatPostfixDecrement,
                        (int)UnaryOperatorKind.DoublePostfixDecrement,
                        (int)UnaryOperatorKind.DecimalPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedSBytePostfixDecrement,
                        (int)UnaryOperatorKind.LiftedBytePostfixDecrement,
                        (int)UnaryOperatorKind.LiftedShortPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedUShortPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedIntPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedUIntPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedLongPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedULongPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedNIntPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedNUIntPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedCharPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedFloatPostfixDecrement,
                        (int)UnaryOperatorKind.LiftedDoublePostfixDecrement,
                        (int)UnaryOperatorKind.LiftedDecimalPostfixDecrement,
                    }),
f_10913_6491_8618(this, new []
                    {
                        (int)UnaryOperatorKind.SBytePrefixIncrement,
                        (int)UnaryOperatorKind.BytePrefixIncrement,
                        (int)UnaryOperatorKind.ShortPrefixIncrement,
                        (int)UnaryOperatorKind.UShortPrefixIncrement,
                        (int)UnaryOperatorKind.IntPrefixIncrement,
                        (int)UnaryOperatorKind.UIntPrefixIncrement,
                        (int)UnaryOperatorKind.LongPrefixIncrement,
                        (int)UnaryOperatorKind.ULongPrefixIncrement,
                        (int)UnaryOperatorKind.NIntPrefixIncrement,
                        (int)UnaryOperatorKind.NUIntPrefixIncrement,
                        (int)UnaryOperatorKind.CharPrefixIncrement,
                        (int)UnaryOperatorKind.FloatPrefixIncrement,
                        (int)UnaryOperatorKind.DoublePrefixIncrement,
                        (int)UnaryOperatorKind.DecimalPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedSBytePrefixIncrement,
                        (int)UnaryOperatorKind.LiftedBytePrefixIncrement,
                        (int)UnaryOperatorKind.LiftedShortPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedUShortPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedIntPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedUIntPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedLongPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedULongPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedNIntPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedNUIntPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedCharPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedFloatPrefixIncrement,
                        (int)UnaryOperatorKind.LiftedDoublePrefixIncrement,
                        (int)UnaryOperatorKind.LiftedDecimalPrefixIncrement,
                    }),
f_10913_8641_10768(this, new []
                    {
                        (int)UnaryOperatorKind.SBytePrefixDecrement,
                        (int)UnaryOperatorKind.BytePrefixDecrement,
                        (int)UnaryOperatorKind.ShortPrefixDecrement,
                        (int)UnaryOperatorKind.UShortPrefixDecrement,
                        (int)UnaryOperatorKind.IntPrefixDecrement,
                        (int)UnaryOperatorKind.UIntPrefixDecrement,
                        (int)UnaryOperatorKind.NIntPrefixDecrement,
                        (int)UnaryOperatorKind.NUIntPrefixDecrement,
                        (int)UnaryOperatorKind.LongPrefixDecrement,
                        (int)UnaryOperatorKind.ULongPrefixDecrement,
                        (int)UnaryOperatorKind.CharPrefixDecrement,
                        (int)UnaryOperatorKind.FloatPrefixDecrement,
                        (int)UnaryOperatorKind.DoublePrefixDecrement,
                        (int)UnaryOperatorKind.DecimalPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedSBytePrefixDecrement,
                        (int)UnaryOperatorKind.LiftedBytePrefixDecrement,
                        (int)UnaryOperatorKind.LiftedShortPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedUShortPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedIntPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedUIntPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedLongPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedULongPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedNIntPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedNUIntPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedCharPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedFloatPrefixDecrement,
                        (int)UnaryOperatorKind.LiftedDoublePrefixDecrement,
                        (int)UnaryOperatorKind.LiftedDecimalPrefixDecrement,
                    }),
f_10913_10791_12082(this, new []
                    {
                        (int)UnaryOperatorKind.IntUnaryPlus,
                        (int)UnaryOperatorKind.UIntUnaryPlus,
                        (int)UnaryOperatorKind.LongUnaryPlus,
                        (int)UnaryOperatorKind.ULongUnaryPlus,
                        (int)UnaryOperatorKind.NIntUnaryPlus,
                        (int)UnaryOperatorKind.NUIntUnaryPlus,
                        (int)UnaryOperatorKind.FloatUnaryPlus,
                        (int)UnaryOperatorKind.DoubleUnaryPlus,
                        (int)UnaryOperatorKind.DecimalUnaryPlus,
                        (int)UnaryOperatorKind.LiftedIntUnaryPlus,
                        (int)UnaryOperatorKind.LiftedUIntUnaryPlus,
                        (int)UnaryOperatorKind.LiftedLongUnaryPlus,
                        (int)UnaryOperatorKind.LiftedULongUnaryPlus,
                        (int)UnaryOperatorKind.LiftedNIntUnaryPlus,
                        (int)UnaryOperatorKind.LiftedNUIntUnaryPlus,
                        (int)UnaryOperatorKind.LiftedFloatUnaryPlus,
                        (int)UnaryOperatorKind.LiftedDoubleUnaryPlus,
                        (int)UnaryOperatorKind.LiftedDecimalUnaryPlus,
                    }),
f_10913_12105_13008(this, new []
                    {
                        (int)UnaryOperatorKind.IntUnaryMinus,
                        (int)UnaryOperatorKind.LongUnaryMinus,
                        (int)UnaryOperatorKind.NIntUnaryMinus,
                        (int)UnaryOperatorKind.FloatUnaryMinus,
                        (int)UnaryOperatorKind.DoubleUnaryMinus,
                        (int)UnaryOperatorKind.DecimalUnaryMinus,
                        (int)UnaryOperatorKind.LiftedIntUnaryMinus,
                        (int)UnaryOperatorKind.LiftedLongUnaryMinus,
                        (int)UnaryOperatorKind.LiftedNIntUnaryMinus,
                        (int)UnaryOperatorKind.LiftedFloatUnaryMinus,
                        (int)UnaryOperatorKind.LiftedDoubleUnaryMinus,
                        (int)UnaryOperatorKind.LiftedDecimalUnaryMinus,
                    }),
f_10913_13031_13264(this, new []
                    {
                        (int)UnaryOperatorKind.BoolLogicalNegation,
                        (int)UnaryOperatorKind.LiftedBoolLogicalNegation,
                    }),
f_10913_13287_14266(this, new []
                    {
                        (int)UnaryOperatorKind.IntBitwiseComplement,
                        (int)UnaryOperatorKind.UIntBitwiseComplement,
                        (int)UnaryOperatorKind.LongBitwiseComplement,
                        (int)UnaryOperatorKind.ULongBitwiseComplement,
                        (int)UnaryOperatorKind.NIntBitwiseComplement,
                        (int)UnaryOperatorKind.NUIntBitwiseComplement,
                        (int)UnaryOperatorKind.LiftedIntBitwiseComplement,
                        (int)UnaryOperatorKind.LiftedUIntBitwiseComplement,
                        (int)UnaryOperatorKind.LiftedLongBitwiseComplement,
                        (int)UnaryOperatorKind.LiftedULongBitwiseComplement,
                        (int)UnaryOperatorKind.LiftedNIntBitwiseComplement,
                        (int)UnaryOperatorKind.LiftedNUIntBitwiseComplement,
                    }),
                    // No built-in operator true or operator false
                    ImmutableArray<UnaryOperatorSignature>.Empty,
                    ImmutableArray<UnaryOperatorSignature>.Empty,
                }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,14509,14585);

f_10913_14509_14584(ref _builtInUnaryOperators, allOperators, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,1963,14600);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,14616,15080);
foreach(var op in f_10913_14635_14679_I(_builtInUnaryOperators[f_10913_14658_14678(kind)]) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,14616,15080);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,14713,15029) || true) && (skipNativeIntegerOperators)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,14713,15029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,14785,15010);

switch (f_10913_14793_14815(op.Kind))
                    {

case UnaryOperatorKind.NInt:
                        case UnaryOperatorKind.NUInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,14785,15010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,14978,14987);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,14785,15010);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,14713,15029);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15047,15065);

f_10913_15047_15064(                operators, op);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,14616,15080);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10913,1,465);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10913,1,465);
}DynAbs.Tracing.TraceSender.TraceExitMethod(10913,1794,15091);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_2135_4290(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromUnaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 2135, 4290);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_4313_6468(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromUnaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 4313, 6468);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_6491_8618(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromUnaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 6491, 8618);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_8641_10768(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromUnaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 8641, 10768);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_10791_12082(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromUnaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 10791, 12082);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_12105_13008(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromUnaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 12105, 13008);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_13031_13264(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromUnaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 13031, 13264);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_13287_14266(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromUnaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 13287, 14266);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>[]?
f_10913_14509_14584(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>[]?
location1,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>[]
value,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>[]?
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, value, comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 14509, 14584);
return return_v;
}


int
f_10913_14658_14678(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperatorIndex();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 14658, 14678);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10913_14793_14815(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 14793, 14815);
return return_v;
}


int
f_10913_15047_15064(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 15047, 15064);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
f_10913_14635_14679_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 14635, 14679);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,1794,15091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,1794,15091);
}
		}

internal UnaryOperatorSignature GetSignature(UnaryOperatorKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,15103,17408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15196,15214);

TypeSymbol 
opType
=default(TypeSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15228,17155);

switch (f_10913_15236_15255(kind))
            {

case UnaryOperatorKind.SByte: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15319,15382);

opType = f_10913_15328_15381(_compilation, SpecialType.System_SByte);
DynAbs.Tracing.TraceSender.TraceBreak(10913,15383,15389);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Byte: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15436,15498);

opType = f_10913_15445_15497(_compilation, SpecialType.System_Byte);
DynAbs.Tracing.TraceSender.TraceBreak(10913,15499,15505);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Short: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15553,15616);

opType = f_10913_15562_15615(_compilation, SpecialType.System_Int16);
DynAbs.Tracing.TraceSender.TraceBreak(10913,15617,15623);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.UShort: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15672,15736);

opType = f_10913_15681_15735(_compilation, SpecialType.System_UInt16);
DynAbs.Tracing.TraceSender.TraceBreak(10913,15737,15743);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Int: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15789,15852);

opType = f_10913_15798_15851(_compilation, SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceBreak(10913,15853,15859);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.UInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,15906,15970);

opType = f_10913_15915_15969(_compilation, SpecialType.System_UInt32);
DynAbs.Tracing.TraceSender.TraceBreak(10913,15971,15977);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Long: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16024,16087);

opType = f_10913_16033_16086(_compilation, SpecialType.System_Int64);
DynAbs.Tracing.TraceSender.TraceBreak(10913,16088,16094);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.ULong: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16142,16206);

opType = f_10913_16151_16205(_compilation, SpecialType.System_UInt64);
DynAbs.Tracing.TraceSender.TraceBreak(10913,16207,16213);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.NInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16260,16326);

opType = f_10913_16269_16325(_compilation, signed: true);
DynAbs.Tracing.TraceSender.TraceBreak(10913,16327,16333);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.NUInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16381,16448);

opType = f_10913_16390_16447(_compilation, signed: false);
DynAbs.Tracing.TraceSender.TraceBreak(10913,16449,16455);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Char: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16502,16564);

opType = f_10913_16511_16563(_compilation, SpecialType.System_Char);
DynAbs.Tracing.TraceSender.TraceBreak(10913,16565,16571);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Float: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16619,16683);

opType = f_10913_16628_16682(_compilation, SpecialType.System_Single);
DynAbs.Tracing.TraceSender.TraceBreak(10913,16684,16690);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Double: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16739,16803);

opType = f_10913_16748_16802(_compilation, SpecialType.System_Double);
DynAbs.Tracing.TraceSender.TraceBreak(10913,16804,16810);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Decimal: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16860,16925);

opType = f_10913_16869_16924(_compilation, SpecialType.System_Decimal);
DynAbs.Tracing.TraceSender.TraceBreak(10913,16926,16932);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

case UnaryOperatorKind.Bool: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,16979,17044);

opType = f_10913_16988_17043(_compilation, SpecialType.System_Boolean);
DynAbs.Tracing.TraceSender.TraceBreak(10913,17045,17051);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);

default: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,15228,17155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,17078,17140);

throw f_10913_17084_17139(f_10913_17119_17138(kind));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,15228,17155);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,17171,17325) || true) && (f_10913_17175_17190(kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,17171,17325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,17224,17310);

opType = f_10913_17233_17309(f_10913_17233_17291(_compilation, SpecialType.System_Nullable_T), opType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,17171,17325);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,17341,17397);

return f_10913_17348_17396(kind, opType, opType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10913,15103,17408);

Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10913_15236_15255(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 15236, 15255);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_15328_15381(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 15328, 15381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_15445_15497(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 15445, 15497);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_15562_15615(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 15562, 15615);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_15681_15735(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 15681, 15735);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_15798_15851(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 15798, 15851);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_15915_15969(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 15915, 15969);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16033_16086(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16033, 16086);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16151_16205(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16151, 16205);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16269_16325(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16269, 16325);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16390_16447(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16390, 16447);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16511_16563(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16511, 16563);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16628_16682(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16628, 16682);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16748_16802(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16748, 16802);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16869_16924(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16869, 16924);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_16988_17043(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 16988, 17043);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10913_17119_17138(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17119, 17138);
return return_v;
}


System.Exception
f_10913_17084_17139(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17084, 17139);
return return_v;
}


bool
f_10913_17175_17190(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17175, 17190);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_17233_17291(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17233, 17291);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_17233_17309(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17233, 17309);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
f_10913_17348_17396(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
operandType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
returnType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature( kind, operandType, returnType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17348, 17396);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,15103,17408);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,15103,17408);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ImmutableArray<BinaryOperatorSignature> GetSignaturesFromBinaryOperatorKinds(int[] operatorKinds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,17634,18042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,17764,17830);

var 
builder = f_10913_17778_17829()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,17844,17979);
foreach(var kind in f_10913_17865_17878_I(operatorKinds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,17844,17979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,17912,17964);

f_10913_17912_17963(                builder, f_10913_17924_17962(this, kind));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,17844,17979);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10913,1,136);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10913,1,136);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,17995,18031);

return f_10913_18002_18030(builder);
DynAbs.Tracing.TraceSender.TraceExitMethod(10913,17634,18042);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_17778_17829()
{
var return_v = ArrayBuilder<BinaryOperatorSignature>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17778, 17829);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
f_10913_17924_17962(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int
kind)
{
var return_v = this_param.GetSignature( (Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind)kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17924, 17962);
return return_v;
}


int
f_10913_17912_17963(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17912, 17963);
return 0;
}


int[]
f_10913_17865_17878_I(int[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 17865, 17878);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_18002_18030(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 18002, 18030);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,17634,18042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,17634,18042);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal void GetSimpleBuiltInOperators(BinaryOperatorKind kind, ArrayBuilder<BinaryOperatorSignature> operators, bool skipNativeIntegerOperators)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,18054,41054);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,18225,40540) || true) && (_builtInOperators == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,18225,40540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,18288,19783);

var 
logicalOperators = new ImmutableArray<BinaryOperatorSignature>[]
                {
                    ImmutableArray<BinaryOperatorSignature>.Empty, //multiplication
                    ImmutableArray<BinaryOperatorSignature>.Empty, //addition
                    ImmutableArray<BinaryOperatorSignature>.Empty, //subtraction
                    ImmutableArray<BinaryOperatorSignature>.Empty, //division
                    ImmutableArray<BinaryOperatorSignature>.Empty, //remainder
                    ImmutableArray<BinaryOperatorSignature>.Empty, //left shift
                    ImmutableArray<BinaryOperatorSignature>.Empty, //right shift
                    ImmutableArray<BinaryOperatorSignature>.Empty, //equal
                    ImmutableArray<BinaryOperatorSignature>.Empty, //not equal
                    ImmutableArray<BinaryOperatorSignature>.Empty, //greater than
                    ImmutableArray<BinaryOperatorSignature>.Empty, //less than
                    ImmutableArray<BinaryOperatorSignature>.Empty, //greater than or equal
                    ImmutableArray<BinaryOperatorSignature>.Empty, //less than or equal
f_10913_19465_19560(f_10913_19512_19559(this, BinaryOperatorKind.LogicalBoolAnd)), //and
                    ImmutableArray<BinaryOperatorSignature>.Empty, //xor
f_10913_19663_19757(f_10913_19710_19756(this, BinaryOperatorKind.LogicalBoolOr)), //or
                }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,19803,40347);

var 
nonLogicalOperators = new ImmutableArray<BinaryOperatorSignature>[]
                {
f_10913_19915_21315(this, new []
                    {
                        (int)BinaryOperatorKind.IntMultiplication,
                        (int)BinaryOperatorKind.UIntMultiplication,
                        (int)BinaryOperatorKind.LongMultiplication,
                        (int)BinaryOperatorKind.ULongMultiplication,
                        (int)BinaryOperatorKind.NIntMultiplication,
                        (int)BinaryOperatorKind.NUIntMultiplication,
                        (int)BinaryOperatorKind.FloatMultiplication,
                        (int)BinaryOperatorKind.DoubleMultiplication,
                        (int)BinaryOperatorKind.DecimalMultiplication,
                        (int)BinaryOperatorKind.LiftedIntMultiplication,
                        (int)BinaryOperatorKind.LiftedUIntMultiplication,
                        (int)BinaryOperatorKind.LiftedLongMultiplication,
                        (int)BinaryOperatorKind.LiftedULongMultiplication,
                        (int)BinaryOperatorKind.LiftedNIntMultiplication,
                        (int)BinaryOperatorKind.LiftedNUIntMultiplication,
                        (int)BinaryOperatorKind.LiftedFloatMultiplication,
                        (int)BinaryOperatorKind.LiftedDoubleMultiplication,
                        (int)BinaryOperatorKind.LiftedDecimalMultiplication,
                    }),
f_10913_21338_22858(this, new []
                    {
                        (int)BinaryOperatorKind.IntAddition,
                        (int)BinaryOperatorKind.UIntAddition,
                        (int)BinaryOperatorKind.LongAddition,
                        (int)BinaryOperatorKind.ULongAddition,
                        (int)BinaryOperatorKind.NIntAddition,
                        (int)BinaryOperatorKind.NUIntAddition,
                        (int)BinaryOperatorKind.FloatAddition,
                        (int)BinaryOperatorKind.DoubleAddition,
                        (int)BinaryOperatorKind.DecimalAddition,
                        (int)BinaryOperatorKind.LiftedIntAddition,
                        (int)BinaryOperatorKind.LiftedUIntAddition,
                        (int)BinaryOperatorKind.LiftedLongAddition,
                        (int)BinaryOperatorKind.LiftedULongAddition,
                        (int)BinaryOperatorKind.LiftedNIntAddition,
                        (int)BinaryOperatorKind.LiftedNUIntAddition,
                        (int)BinaryOperatorKind.LiftedFloatAddition,
                        (int)BinaryOperatorKind.LiftedDoubleAddition,
                        (int)BinaryOperatorKind.LiftedDecimalAddition,
                        (int)BinaryOperatorKind.StringConcatenation,
                        (int)BinaryOperatorKind.StringAndObjectConcatenation,
                        (int)BinaryOperatorKind.ObjectAndStringConcatenation,
                    }),
f_10913_22881_24227(this, new []
                    {
                        (int)BinaryOperatorKind.IntSubtraction,
                        (int)BinaryOperatorKind.UIntSubtraction,
                        (int)BinaryOperatorKind.LongSubtraction,
                        (int)BinaryOperatorKind.ULongSubtraction,
                        (int)BinaryOperatorKind.NIntSubtraction,
                        (int)BinaryOperatorKind.NUIntSubtraction,
                        (int)BinaryOperatorKind.FloatSubtraction,
                        (int)BinaryOperatorKind.DoubleSubtraction,
                        (int)BinaryOperatorKind.DecimalSubtraction,
                        (int)BinaryOperatorKind.LiftedIntSubtraction,
                        (int)BinaryOperatorKind.LiftedUIntSubtraction,
                        (int)BinaryOperatorKind.LiftedLongSubtraction,
                        (int)BinaryOperatorKind.LiftedULongSubtraction,
                        (int)BinaryOperatorKind.LiftedNIntSubtraction,
                        (int)BinaryOperatorKind.LiftedNUIntSubtraction,
                        (int)BinaryOperatorKind.LiftedFloatSubtraction,
                        (int)BinaryOperatorKind.LiftedDoubleSubtraction,
                        (int)BinaryOperatorKind.LiftedDecimalSubtraction,
                    }),
f_10913_24250_25542(this, new []
                    {
                        (int)BinaryOperatorKind.IntDivision,
                        (int)BinaryOperatorKind.UIntDivision,
                        (int)BinaryOperatorKind.LongDivision,
                        (int)BinaryOperatorKind.ULongDivision,
                        (int)BinaryOperatorKind.NIntDivision,
                        (int)BinaryOperatorKind.NUIntDivision,
                        (int)BinaryOperatorKind.FloatDivision,
                        (int)BinaryOperatorKind.DoubleDivision,
                        (int)BinaryOperatorKind.DecimalDivision,
                        (int)BinaryOperatorKind.LiftedIntDivision,
                        (int)BinaryOperatorKind.LiftedUIntDivision,
                        (int)BinaryOperatorKind.LiftedLongDivision,
                        (int)BinaryOperatorKind.LiftedULongDivision,
                        (int)BinaryOperatorKind.LiftedNIntDivision,
                        (int)BinaryOperatorKind.LiftedNUIntDivision,
                        (int)BinaryOperatorKind.LiftedFloatDivision,
                        (int)BinaryOperatorKind.LiftedDoubleDivision,
                        (int)BinaryOperatorKind.LiftedDecimalDivision,
                    }),
f_10913_25565_26875(this, new []
                    {
                        (int)BinaryOperatorKind.IntRemainder,
                        (int)BinaryOperatorKind.UIntRemainder,
                        (int)BinaryOperatorKind.LongRemainder,
                        (int)BinaryOperatorKind.ULongRemainder,
                        (int)BinaryOperatorKind.NIntRemainder,
                        (int)BinaryOperatorKind.NUIntRemainder,
                        (int)BinaryOperatorKind.FloatRemainder,
                        (int)BinaryOperatorKind.DoubleRemainder,
                        (int)BinaryOperatorKind.DecimalRemainder,
                        (int)BinaryOperatorKind.LiftedIntRemainder,
                        (int)BinaryOperatorKind.LiftedUIntRemainder,
                        (int)BinaryOperatorKind.LiftedLongRemainder,
                        (int)BinaryOperatorKind.LiftedULongRemainder,
                        (int)BinaryOperatorKind.LiftedNIntRemainder,
                        (int)BinaryOperatorKind.LiftedNUIntRemainder,
                        (int)BinaryOperatorKind.LiftedFloatRemainder,
                        (int)BinaryOperatorKind.LiftedDoubleRemainder,
                        (int)BinaryOperatorKind.LiftedDecimalRemainder,
                    }),
f_10913_26898_27794(this, new []
                    {
                        (int)BinaryOperatorKind.IntLeftShift,
                        (int)BinaryOperatorKind.UIntLeftShift,
                        (int)BinaryOperatorKind.LongLeftShift,
                        (int)BinaryOperatorKind.ULongLeftShift,
                        (int)BinaryOperatorKind.NIntLeftShift,
                        (int)BinaryOperatorKind.NUIntLeftShift,
                        (int)BinaryOperatorKind.LiftedIntLeftShift,
                        (int)BinaryOperatorKind.LiftedUIntLeftShift,
                        (int)BinaryOperatorKind.LiftedLongLeftShift,
                        (int)BinaryOperatorKind.LiftedULongLeftShift,
                        (int)BinaryOperatorKind.LiftedNIntLeftShift,
                        (int)BinaryOperatorKind.LiftedNUIntLeftShift,
                    }),
f_10913_27817_28725(this, new []
                    {
                        (int)BinaryOperatorKind.IntRightShift,
                        (int)BinaryOperatorKind.UIntRightShift,
                        (int)BinaryOperatorKind.LongRightShift,
                        (int)BinaryOperatorKind.ULongRightShift,
                        (int)BinaryOperatorKind.NIntRightShift,
                        (int)BinaryOperatorKind.NUIntRightShift,
                        (int)BinaryOperatorKind.LiftedIntRightShift,
                        (int)BinaryOperatorKind.LiftedUIntRightShift,
                        (int)BinaryOperatorKind.LiftedLongRightShift,
                        (int)BinaryOperatorKind.LiftedULongRightShift,
                        (int)BinaryOperatorKind.LiftedNIntRightShift,
                        (int)BinaryOperatorKind.LiftedNUIntRightShift,
                    }),
f_10913_28748_30236(this, new []
                    {
                        (int)BinaryOperatorKind.IntEqual,
                        (int)BinaryOperatorKind.UIntEqual,
                        (int)BinaryOperatorKind.LongEqual,
                        (int)BinaryOperatorKind.ULongEqual,
                        (int)BinaryOperatorKind.NIntEqual,
                        (int)BinaryOperatorKind.NUIntEqual,
                        (int)BinaryOperatorKind.FloatEqual,
                        (int)BinaryOperatorKind.DoubleEqual,
                        (int)BinaryOperatorKind.DecimalEqual,
                        (int)BinaryOperatorKind.BoolEqual,
                        (int)BinaryOperatorKind.LiftedIntEqual,
                        (int)BinaryOperatorKind.LiftedUIntEqual,
                        (int)BinaryOperatorKind.LiftedLongEqual,
                        (int)BinaryOperatorKind.LiftedULongEqual,
                        (int)BinaryOperatorKind.LiftedNIntEqual,
                        (int)BinaryOperatorKind.LiftedNUIntEqual,
                        (int)BinaryOperatorKind.LiftedFloatEqual,
                        (int)BinaryOperatorKind.LiftedDoubleEqual,
                        (int)BinaryOperatorKind.LiftedDecimalEqual,
                        (int)BinaryOperatorKind.LiftedBoolEqual,
                        (int)BinaryOperatorKind.ObjectEqual,
                        (int)BinaryOperatorKind.StringEqual,
                    }),
f_10913_30259_31813(this, new []
                    {
                        (int)BinaryOperatorKind.IntNotEqual,
                        (int)BinaryOperatorKind.UIntNotEqual,
                        (int)BinaryOperatorKind.LongNotEqual,
                        (int)BinaryOperatorKind.ULongNotEqual,
                        (int)BinaryOperatorKind.NIntNotEqual,
                        (int)BinaryOperatorKind.NUIntNotEqual,
                        (int)BinaryOperatorKind.FloatNotEqual,
                        (int)BinaryOperatorKind.DoubleNotEqual,
                        (int)BinaryOperatorKind.DecimalNotEqual,
                        (int)BinaryOperatorKind.BoolNotEqual,
                        (int)BinaryOperatorKind.LiftedIntNotEqual,
                        (int)BinaryOperatorKind.LiftedUIntNotEqual,
                        (int)BinaryOperatorKind.LiftedLongNotEqual,
                        (int)BinaryOperatorKind.LiftedULongNotEqual,
                        (int)BinaryOperatorKind.LiftedNIntNotEqual,
                        (int)BinaryOperatorKind.LiftedNUIntNotEqual,
                        (int)BinaryOperatorKind.LiftedFloatNotEqual,
                        (int)BinaryOperatorKind.LiftedDoubleNotEqual,
                        (int)BinaryOperatorKind.LiftedDecimalNotEqual,
                        (int)BinaryOperatorKind.LiftedBoolNotEqual,
                        (int)BinaryOperatorKind.ObjectNotEqual,
                        (int)BinaryOperatorKind.StringNotEqual,
                    }),
f_10913_31836_33182(this, new []
                    {
                        (int)BinaryOperatorKind.IntGreaterThan,
                        (int)BinaryOperatorKind.UIntGreaterThan,
                        (int)BinaryOperatorKind.LongGreaterThan,
                        (int)BinaryOperatorKind.ULongGreaterThan,
                        (int)BinaryOperatorKind.NIntGreaterThan,
                        (int)BinaryOperatorKind.NUIntGreaterThan,
                        (int)BinaryOperatorKind.FloatGreaterThan,
                        (int)BinaryOperatorKind.DoubleGreaterThan,
                        (int)BinaryOperatorKind.DecimalGreaterThan,
                        (int)BinaryOperatorKind.LiftedIntGreaterThan,
                        (int)BinaryOperatorKind.LiftedUIntGreaterThan,
                        (int)BinaryOperatorKind.LiftedLongGreaterThan,
                        (int)BinaryOperatorKind.LiftedULongGreaterThan,
                        (int)BinaryOperatorKind.LiftedNIntGreaterThan,
                        (int)BinaryOperatorKind.LiftedNUIntGreaterThan,
                        (int)BinaryOperatorKind.LiftedFloatGreaterThan,
                        (int)BinaryOperatorKind.LiftedDoubleGreaterThan,
                        (int)BinaryOperatorKind.LiftedDecimalGreaterThan,
                    }),
f_10913_33205_34497(this, new []
                    {
                        (int)BinaryOperatorKind.IntLessThan,
                        (int)BinaryOperatorKind.UIntLessThan,
                        (int)BinaryOperatorKind.LongLessThan,
                        (int)BinaryOperatorKind.ULongLessThan,
                        (int)BinaryOperatorKind.NIntLessThan,
                        (int)BinaryOperatorKind.NUIntLessThan,
                        (int)BinaryOperatorKind.FloatLessThan,
                        (int)BinaryOperatorKind.DoubleLessThan,
                        (int)BinaryOperatorKind.DecimalLessThan,
                        (int)BinaryOperatorKind.LiftedIntLessThan,
                        (int)BinaryOperatorKind.LiftedUIntLessThan,
                        (int)BinaryOperatorKind.LiftedLongLessThan,
                        (int)BinaryOperatorKind.LiftedULongLessThan,
                        (int)BinaryOperatorKind.LiftedNIntLessThan,
                        (int)BinaryOperatorKind.LiftedNUIntLessThan,
                        (int)BinaryOperatorKind.LiftedFloatLessThan,
                        (int)BinaryOperatorKind.LiftedDoubleLessThan,
                        (int)BinaryOperatorKind.LiftedDecimalLessThan,
                    }),
f_10913_34520_35992(this, new []
                    {
                        (int)BinaryOperatorKind.IntGreaterThanOrEqual,
                        (int)BinaryOperatorKind.UIntGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LongGreaterThanOrEqual,
                        (int)BinaryOperatorKind.ULongGreaterThanOrEqual,
                        (int)BinaryOperatorKind.NIntGreaterThanOrEqual,
                        (int)BinaryOperatorKind.NUIntGreaterThanOrEqual,
                        (int)BinaryOperatorKind.FloatGreaterThanOrEqual,
                        (int)BinaryOperatorKind.DoubleGreaterThanOrEqual,
                        (int)BinaryOperatorKind.DecimalGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedIntGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedUIntGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedLongGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedULongGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedNIntGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedNUIntGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedFloatGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedDoubleGreaterThanOrEqual,
                        (int)BinaryOperatorKind.LiftedDecimalGreaterThanOrEqual,
                    }),
f_10913_36015_37433(this, new []
                    {
                        (int)BinaryOperatorKind.IntLessThanOrEqual,
                        (int)BinaryOperatorKind.UIntLessThanOrEqual,
                        (int)BinaryOperatorKind.LongLessThanOrEqual,
                        (int)BinaryOperatorKind.ULongLessThanOrEqual,
                        (int)BinaryOperatorKind.NIntLessThanOrEqual,
                        (int)BinaryOperatorKind.NUIntLessThanOrEqual,
                        (int)BinaryOperatorKind.FloatLessThanOrEqual,
                        (int)BinaryOperatorKind.DoubleLessThanOrEqual,
                        (int)BinaryOperatorKind.DecimalLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedIntLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedUIntLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedLongLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedULongLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedNIntLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedNUIntLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedFloatLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedDoubleLessThanOrEqual,
                        (int)BinaryOperatorKind.LiftedDecimalLessThanOrEqual,
                    }),
f_10913_37456_38402(this, new []
                    {
                        (int)BinaryOperatorKind.IntAnd,
                        (int)BinaryOperatorKind.UIntAnd,
                        (int)BinaryOperatorKind.LongAnd,
                        (int)BinaryOperatorKind.ULongAnd,
                        (int)BinaryOperatorKind.NIntAnd,
                        (int)BinaryOperatorKind.NUIntAnd,
                        (int)BinaryOperatorKind.BoolAnd,
                        (int)BinaryOperatorKind.LiftedIntAnd,
                        (int)BinaryOperatorKind.LiftedUIntAnd,
                        (int)BinaryOperatorKind.LiftedLongAnd,
                        (int)BinaryOperatorKind.LiftedULongAnd,
                        (int)BinaryOperatorKind.LiftedNIntAnd,
                        (int)BinaryOperatorKind.LiftedNUIntAnd,
                        (int)BinaryOperatorKind.LiftedBoolAnd,
                    }),
f_10913_38425_39371(this, new []
                    {
                        (int)BinaryOperatorKind.IntXor,
                        (int)BinaryOperatorKind.UIntXor,
                        (int)BinaryOperatorKind.LongXor,
                        (int)BinaryOperatorKind.ULongXor,
                        (int)BinaryOperatorKind.NIntXor,
                        (int)BinaryOperatorKind.NUIntXor,
                        (int)BinaryOperatorKind.BoolXor,
                        (int)BinaryOperatorKind.LiftedIntXor,
                        (int)BinaryOperatorKind.LiftedUIntXor,
                        (int)BinaryOperatorKind.LiftedLongXor,
                        (int)BinaryOperatorKind.LiftedULongXor,
                        (int)BinaryOperatorKind.LiftedNIntXor,
                        (int)BinaryOperatorKind.LiftedNUIntXor,
                        (int)BinaryOperatorKind.LiftedBoolXor,
                    }),
f_10913_39394_40326(this, new []
                    {
                        (int)BinaryOperatorKind.IntOr,
                        (int)BinaryOperatorKind.UIntOr,
                        (int)BinaryOperatorKind.LongOr,
                        (int)BinaryOperatorKind.ULongOr,
                        (int)BinaryOperatorKind.NIntOr,
                        (int)BinaryOperatorKind.NUIntOr,
                        (int)BinaryOperatorKind.BoolOr,
                        (int)BinaryOperatorKind.LiftedIntOr,
                        (int)BinaryOperatorKind.LiftedUIntOr,
                        (int)BinaryOperatorKind.LiftedLongOr,
                        (int)BinaryOperatorKind.LiftedULongOr,
                        (int)BinaryOperatorKind.LiftedNIntOr,
                        (int)BinaryOperatorKind.LiftedNUIntOr,
                        (int)BinaryOperatorKind.LiftedBoolOr,
                    }),
                }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,40367,40434);

var 
allOperators = new[] { nonLogicalOperators, logicalOperators }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,40454,40525);

f_10913_40454_40524(ref _builtInOperators, allOperators, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,18225,40540);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,40556,41043);
foreach(var op in f_10913_40575_40640_I(_builtInOperators[(DynAbs.Tracing.TraceSender.Conditional_F1(10913, 40593, 40609)||((f_10913_40593_40609(kind)&&DynAbs.Tracing.TraceSender.Conditional_F2(10913, 40612, 40613))||DynAbs.Tracing.TraceSender.Conditional_F3(10913, 40616, 40617)))?1 :0][f_10913_40619_40639(kind)]) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,40556,41043);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,40674,40992) || true) && (skipNativeIntegerOperators)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,40674,40992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,40746,40973);

switch (f_10913_40754_40776(op.Kind))
                    {

case BinaryOperatorKind.NInt:
                        case BinaryOperatorKind.NUInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,40746,40973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,40941,40950);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,40746,40973);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,40674,40992);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,41010,41028);

f_10913_41010_41027(                operators, op);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,40556,41043);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10913,1,488);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10913,1,488);
}DynAbs.Tracing.TraceSender.TraceExitMethod(10913,18054,41054);

Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
f_10913_19512_19559(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.GetSignature( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 19512, 19559);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_19465_19560(Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
item)
{
var return_v = ImmutableArray.Create<BinaryOperatorSignature>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 19465, 19560);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
f_10913_19710_19756(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.GetSignature( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 19710, 19756);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_19663_19757(Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
item)
{
var return_v = ImmutableArray.Create<BinaryOperatorSignature>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 19663, 19757);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_19915_21315(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 19915, 21315);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_21338_22858(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 21338, 22858);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_22881_24227(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 22881, 24227);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_24250_25542(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 24250, 25542);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_25565_26875(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 25565, 26875);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_26898_27794(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 26898, 27794);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_27817_28725(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 27817, 28725);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_28748_30236(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 28748, 30236);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_30259_31813(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 30259, 31813);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_31836_33182(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 31836, 33182);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_33205_34497(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 33205, 34497);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_34520_35992(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 34520, 35992);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_36015_37433(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 36015, 37433);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_37456_38402(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 37456, 38402);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_38425_39371(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 38425, 39371);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_39394_40326(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,int[]
operatorKinds)
{
var return_v = this_param.GetSignaturesFromBinaryOperatorKinds( operatorKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 39394, 40326);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>[][]?
f_10913_40454_40524(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>[][]?
location1,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>[][]
value,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>[][]?
comparand)
{
var return_v = Interlocked.CompareExchange( ref location1, value, comparand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 40454, 40524);
return return_v;
}


bool
f_10913_40593_40609(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLogical();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 40593, 40609);
return return_v;
}


int
f_10913_40619_40639(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperatorIndex();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 40619, 40639);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10913_40754_40776(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 40754, 40776);
return return_v;
}


int
f_10913_41010_41027(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 41010, 41027);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
f_10913_40575_40640_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 40575, 40640);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,18054,41054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,18054,41054);
}
		}

internal BinaryOperatorSignature GetSignature(BinaryOperatorKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,41066,42902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,41161,41187);

var 
left = f_10913_41172_41186(this, kind)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,41201,42795);

switch (f_10913_41209_41224(kind))
            {

case BinaryOperatorKind.Multiplication:
                case BinaryOperatorKind.Division:
                case BinaryOperatorKind.Subtraction:
                case BinaryOperatorKind.Remainder:
                case BinaryOperatorKind.And:
                case BinaryOperatorKind.Or:
                case BinaryOperatorKind.Xor:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,41201,42795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,41613,41672);

return f_10913_41620_41671(kind, left, left, left);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,41201,42795);

case BinaryOperatorKind.Addition:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,41201,42795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,41745,41827);

return f_10913_41752_41826(kind, left, f_10913_41792_41807(this, kind), f_10913_41809_41825(this, kind));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,41201,42795);

case BinaryOperatorKind.LeftShift:
                case BinaryOperatorKind.RightShift:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,41201,42795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,41954,42031);

TypeSymbol 
rightType = f_10913_41977_42030(_compilation, SpecialType.System_Int32)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,42053,42237) || true) && (f_10913_42057_42072(kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,42053,42237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,42122,42214);

rightType = f_10913_42134_42213(f_10913_42134_42192(_compilation, SpecialType.System_Nullable_T), rightType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,42053,42237);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,42259,42323);

return f_10913_42266_42322(kind, left, rightType, left);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,41201,42795);

case BinaryOperatorKind.Equal:
                case BinaryOperatorKind.NotEqual:
                case BinaryOperatorKind.GreaterThan:
                case BinaryOperatorKind.LessThan:
                case BinaryOperatorKind.GreaterThanOrEqual:
                case BinaryOperatorKind.LessThanOrEqual:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,41201,42795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,42670,42780);

return f_10913_42677_42779(kind, left, left, f_10913_42723_42778(_compilation, SpecialType.System_Boolean));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,41201,42795);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,42809,42891);

return f_10913_42816_42890(kind, left, f_10913_42856_42871(this, kind), f_10913_42873_42889(this, kind));
DynAbs.Tracing.TraceSender.TraceExitMethod(10913,41066,42902);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10913_41172_41186(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.LeftType( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 41172, 41186);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10913_41209_41224(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 41209, 41224);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
f_10913_41620_41671(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
leftType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rightType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
returnType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature( kind, leftType, rightType, returnType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 41620, 41671);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10913_41792_41807(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.RightType( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 41792, 41807);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10913_41809_41825(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.ReturnType( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 41809, 41825);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
f_10913_41752_41826(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
leftType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rightType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
returnType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature( kind, leftType, rightType, returnType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 41752, 41826);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_41977_42030(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 41977, 42030);
return return_v;
}


bool
f_10913_42057_42072(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42057, 42072);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_42134_42192(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42134, 42192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_42134_42213(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42134, 42213);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
f_10913_42266_42322(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
leftType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rightType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
returnType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature( kind, leftType, rightType, returnType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42266, 42322);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_42723_42778(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42723, 42778);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
f_10913_42677_42779(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
leftType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rightType,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
returnType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature( kind, leftType, rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42677, 42779);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10913_42856_42871(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.RightType( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42856, 42871);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10913_42873_42889(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.ReturnType( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42873, 42889);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
f_10913_42816_42890(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
leftType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rightType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
returnType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature( kind, leftType, rightType, returnType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42816, 42890);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,41066,42902);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,41066,42902);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private TypeSymbol LeftType(BinaryOperatorKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,42914,44878);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,42991,44773) || true) && (f_10913_42995_43010(kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,42991,44773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43044,43068);

return f_10913_43051_43067(this, kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,42991,44773);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,42991,44773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43134,44758);

switch (f_10913_43142_43161(kind))
                {

case BinaryOperatorKind.Int: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43232,43293);

return f_10913_43239_43292(_compilation, SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.UInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43345,43407);

return f_10913_43352_43406(_compilation, SpecialType.System_UInt32);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.Long: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43459,43520);

return f_10913_43466_43519(_compilation, SpecialType.System_Int64);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.ULong: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43573,43635);

return f_10913_43580_43634(_compilation, SpecialType.System_UInt64);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.NInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43687,43751);

return f_10913_43694_43750(_compilation, signed: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.NUInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43804,43869);

return f_10913_43811_43868(_compilation, signed: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.Float: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,43922,43984);

return f_10913_43929_43983(_compilation, SpecialType.System_Single);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.Double: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,44038,44100);

return f_10913_44045_44099(_compilation, SpecialType.System_Double);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.Decimal: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,44155,44218);

return f_10913_44162_44217(_compilation, SpecialType.System_Decimal);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.Bool: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,44270,44333);

return f_10913_44277_44332(_compilation, SpecialType.System_Boolean);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.ObjectAndString:
                    case BinaryOperatorKind.Object:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,44474,44536);

return f_10913_44481_44535(_compilation, SpecialType.System_Object);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);

case BinaryOperatorKind.String:
                    case BinaryOperatorKind.StringAndObject:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,43134,44758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,44677,44739);

return f_10913_44684_44738(_compilation, SpecialType.System_String);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,43134,44758);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,42991,44773);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,44787,44841);

f_10913_44787_44840(false, "Bad operator kind in left type");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,44855,44867);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10913,42914,44878);

bool
f_10913_42995_43010(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 42995, 43010);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10913_43051_43067(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.LiftedType( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43051, 43067);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10913_43142_43161(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43142, 43161);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_43239_43292(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43239, 43292);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_43352_43406(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43352, 43406);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_43466_43519(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43466, 43519);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_43580_43634(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43580, 43634);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_43694_43750(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43694, 43750);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_43811_43868(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43811, 43868);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_43929_43983(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 43929, 43983);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_44045_44099(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 44045, 44099);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_44162_44217(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 44162, 44217);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_44277_44332(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 44277, 44332);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_44481_44535(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 44481, 44535);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_44684_44738(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 44684, 44738);
return return_v;
}


int
f_10913_44787_44840(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 44787, 44840);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,42914,44878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,42914,44878);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private TypeSymbol RightType(BinaryOperatorKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,44890,46856);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,44968,46750) || true) && (f_10913_44972_44987(kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,44968,46750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45021,45045);

return f_10913_45028_45044(this, kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,44968,46750);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,44968,46750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45111,46735);

switch (f_10913_45119_45138(kind))
                {

case BinaryOperatorKind.Int: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45209,45270);

return f_10913_45216_45269(_compilation, SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.UInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45322,45384);

return f_10913_45329_45383(_compilation, SpecialType.System_UInt32);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.Long: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45436,45497);

return f_10913_45443_45496(_compilation, SpecialType.System_Int64);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.ULong: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45550,45612);

return f_10913_45557_45611(_compilation, SpecialType.System_UInt64);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.NInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45664,45728);

return f_10913_45671_45727(_compilation, signed: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.NUInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45781,45846);

return f_10913_45788_45845(_compilation, signed: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.Float: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,45899,45961);

return f_10913_45906_45960(_compilation, SpecialType.System_Single);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.Double: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,46015,46077);

return f_10913_46022_46076(_compilation, SpecialType.System_Double);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.Decimal: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,46132,46195);

return f_10913_46139_46194(_compilation, SpecialType.System_Decimal);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.Bool: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,46247,46310);

return f_10913_46254_46309(_compilation, SpecialType.System_Boolean);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.ObjectAndString:
                    case BinaryOperatorKind.String:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,46451,46513);

return f_10913_46458_46512(_compilation, SpecialType.System_String);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);

case BinaryOperatorKind.StringAndObject:
                    case BinaryOperatorKind.Object:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,45111,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,46654,46716);

return f_10913_46661_46715(_compilation, SpecialType.System_Object);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,45111,46735);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,44968,46750);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,46764,46819);

f_10913_46764_46818(false, "Bad operator kind in right type");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,46833,46845);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10913,44890,46856);

bool
f_10913_44972_44987(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 44972, 44987);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10913_45028_45044(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.LiftedType( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45028, 45044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10913_45119_45138(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45119, 45138);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_45216_45269(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45216, 45269);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_45329_45383(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45329, 45383);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_45443_45496(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45443, 45496);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_45557_45611(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45557, 45611);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_45671_45727(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45671, 45727);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_45788_45845(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45788, 45845);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_45906_45960(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 45906, 45960);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_46022_46076(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 46022, 46076);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_46139_46194(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 46139, 46194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_46254_46309(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 46254, 46309);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_46458_46512(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 46458, 46512);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_46661_46715(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 46661, 46715);
return return_v;
}


int
f_10913_46764_46818(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 46764, 46818);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,44890,46856);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,44890,46856);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private TypeSymbol ReturnType(BinaryOperatorKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,46868,48811);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,46947,48704) || true) && (f_10913_46951_46966(kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,46947,48704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47000,47024);

return f_10913_47007_47023(this, kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,46947,48704);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,46947,48704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47090,48689);

switch (f_10913_47098_47117(kind))
                {

case BinaryOperatorKind.Int: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47188,47249);

return f_10913_47195_47248(_compilation, SpecialType.System_Int32);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.UInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47301,47363);

return f_10913_47308_47362(_compilation, SpecialType.System_UInt32);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.Long: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47415,47476);

return f_10913_47422_47475(_compilation, SpecialType.System_Int64);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.ULong: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47529,47591);

return f_10913_47536_47590(_compilation, SpecialType.System_UInt64);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.NInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47643,47707);

return f_10913_47650_47706(_compilation, signed: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.NUInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47760,47825);

return f_10913_47767_47824(_compilation, signed: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.Float: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47878,47940);

return f_10913_47885_47939(_compilation, SpecialType.System_Single);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.Double: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,47994,48056);

return f_10913_48001_48055(_compilation, SpecialType.System_Double);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.Decimal: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,48111,48174);

return f_10913_48118_48173(_compilation, SpecialType.System_Decimal);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.Bool: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,48226,48289);

return f_10913_48233_48288(_compilation, SpecialType.System_Boolean);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.Object: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,48343,48405);

return f_10913_48350_48404(_compilation, SpecialType.System_Object);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);

case BinaryOperatorKind.ObjectAndString:
                    case BinaryOperatorKind.StringAndObject:
                    case BinaryOperatorKind.String:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,47090,48689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,48608,48670);

return f_10913_48615_48669(_compilation, SpecialType.System_String);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,47090,48689);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,46947,48704);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,48718,48774);

f_10913_48718_48773(false, "Bad operator kind in return type");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,48788,48800);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10913,46868,48811);

bool
f_10913_46951_46966(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 46951, 46966);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10913_47007_47023(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = this_param.LiftedType( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47007, 47023);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10913_47098_47117(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47098, 47117);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_47195_47248(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47195, 47248);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_47308_47362(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47308, 47362);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_47422_47475(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47422, 47475);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_47536_47590(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47536, 47590);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_47650_47706(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47650, 47706);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_47767_47824(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47767, 47824);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_47885_47939(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 47885, 47939);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_48001_48055(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48001, 48055);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_48118_48173(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48118, 48173);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_48233_48288(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48233, 48288);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_48350_48404(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48350, 48404);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_48615_48669(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48615, 48669);
return return_v;
}


int
f_10913_48718_48773(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48718, 48773);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,46868,48811);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,46868,48811);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private TypeSymbol LiftedType(BinaryOperatorKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10913,48823,50515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,48902,48932);

f_10913_48902_48931(f_10913_48915_48930(kind));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,48948,49022);

var 
nullable = f_10913_48963_49021(_compilation, SpecialType.System_Nullable_T)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,49038,50408);

switch (f_10913_49046_49065(kind))
            {

case BinaryOperatorKind.Int: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,49128,49209);

return f_10913_49135_49208(nullable, f_10913_49154_49207(_compilation, SpecialType.System_Int32));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.UInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,49257,49339);

return f_10913_49264_49338(nullable, f_10913_49283_49337(_compilation, SpecialType.System_UInt32));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.Long: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,49387,49468);

return f_10913_49394_49467(nullable, f_10913_49413_49466(_compilation, SpecialType.System_Int64));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.ULong: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,49517,49599);

return f_10913_49524_49598(nullable, f_10913_49543_49597(_compilation, SpecialType.System_UInt64));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.NInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,49647,49731);

return f_10913_49654_49730(nullable, f_10913_49673_49729(_compilation, signed: true));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.NUInt: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,49780,49865);

return f_10913_49787_49864(nullable, f_10913_49806_49863(_compilation, signed: false));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.Float: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,49914,49996);

return f_10913_49921_49995(nullable, f_10913_49940_49994(_compilation, SpecialType.System_Single));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.Double: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,50046,50128);

return f_10913_50053_50127(nullable, f_10913_50072_50126(_compilation, SpecialType.System_Double));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.Decimal: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,50179,50262);

return f_10913_50186_50261(nullable, f_10913_50205_50260(_compilation, SpecialType.System_Decimal));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);

case BinaryOperatorKind.Bool: DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,49038,50408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,50310,50393);

return f_10913_50317_50392(nullable, f_10913_50336_50391(_compilation, SpecialType.System_Boolean));
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,49038,50408);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,50422,50478);

f_10913_50422_50477(false, "Bad operator kind in lifted type");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,50492,50504);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10913,48823,50515);

bool
f_10913_48915_48930(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48915, 48930);
return return_v;
}


int
f_10913_48902_48931(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48902, 48931);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_48963_49021(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 48963, 49021);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10913_49046_49065(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49046, 49065);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49154_49207(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49154, 49207);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49135_49208(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49135, 49208);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49283_49337(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49283, 49337);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49264_49338(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49264, 49338);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49413_49466(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49413, 49466);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49394_49467(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49394, 49467);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49543_49597(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49543, 49597);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49524_49598(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49524, 49598);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49673_49729(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49673, 49729);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49654_49730(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49654, 49730);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49806_49863(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49806, 49863);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49787_49864(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49787, 49864);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49940_49994(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49940, 49994);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_49921_49995(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 49921, 49995);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_50072_50126(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 50072, 50126);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_50053_50127(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 50053, 50127);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_50205_50260(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 50205, 50260);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_50186_50261(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 50186, 50261);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_50336_50391(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 50336, 50391);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_50317_50392(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 50317, 50392);
return return_v;
}


int
f_10913_50422_50477(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 50422, 50477);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,48823,50515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,48823,50515);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsValidObjectEquality(Conversions Conversions, TypeSymbol leftType, bool leftIsNull, bool leftIsDefault, TypeSymbol rightType, bool rightIsNull, bool rightIsDefault, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10913,50527,54944);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,52505,52922) || true) && (((object)leftType != null) &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 52509, 52565)&&f_10913_52539_52565(leftType)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,52505,52922);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,52599,52744) || true) && (f_10913_52603_52623(leftType)||(DynAbs.Tracing.TraceSender.Expression_False(10913, 52603, 52670)||(f_10913_52628_52653_M(!leftType.IsReferenceType)&&(DynAbs.Tracing.TraceSender.Expression_True(10913, 52628, 52669)&&!rightIsNull))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,52599,52744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,52712,52725);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,52599,52744);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,52764,52850);

leftType = f_10913_52775_52849(((TypeParameterSymbol)leftType), ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,52868,52907);

f_10913_52868_52906((object)leftType != null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,52505,52922);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,52938,53361) || true) && (((object)rightType != null) &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 52942, 53000)&&f_10913_52973_53000(rightType)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,52938,53361);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53034,53180) || true) && (f_10913_53038_53059(rightType)||(DynAbs.Tracing.TraceSender.Expression_False(10913, 53038, 53106)||(f_10913_53064_53090_M(!rightType.IsReferenceType)&&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53064, 53105)&&!leftIsNull))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,53034,53180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53148,53161);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,53034,53180);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53200,53288);

rightType = f_10913_53212_53287(((TypeParameterSymbol)rightType), ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53306,53346);

f_10913_53306_53345((object)rightType != null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,52938,53361);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53377,53458);

var 
leftIsReferenceType = ((object)leftType != null) &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53403, 53457)&&f_10913_53433_53457(leftType))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53472,53591) || true) && (!leftIsReferenceType &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53476, 53511)&&!leftIsNull )&&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53476, 53529)&&!leftIsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,53472,53591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53563,53576);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,53472,53591);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53607,53691);

var 
rightIsReferenceType = ((object)rightType != null) &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53634, 53690)&&f_10913_53665_53690(rightType))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53705,53827) || true) && (!rightIsReferenceType &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53709, 53746)&&!rightIsNull )&&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53709, 53765)&&!rightIsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,53705,53827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53799,53812);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,53705,53827);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53843,53940) || true) && (leftIsDefault &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53847, 53878)&&rightIsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,53843,53940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53912,53925);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,53843,53940);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,53956,54050) || true) && (leftIsDefault &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 53960, 53988)&&rightIsNull))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,53956,54050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54022,54035);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,53956,54050);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54066,54160) || true) && (leftIsNull &&(DynAbs.Tracing.TraceSender.Expression_True(10913, 54070, 54098)&&rightIsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,54066,54160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54132,54145);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,54066,54160);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54266,54391) || true) && (leftIsNull ||(DynAbs.Tracing.TraceSender.Expression_False(10913, 54270, 54295)||rightIsNull )||(DynAbs.Tracing.TraceSender.Expression_False(10913, 54270, 54312)||leftIsDefault )||(DynAbs.Tracing.TraceSender.Expression_False(10913, 54270, 54330)||rightIsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,54266,54391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54364,54376);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,54266,54391);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54407,54512);

var 
leftConversion = f_10913_54428_54511(Conversions, leftType, rightType, ref useSiteDiagnostics)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54526,54646) || true) && (leftConversion.IsIdentity ||(DynAbs.Tracing.TraceSender.Expression_False(10913, 54530, 54585)||leftConversion.IsReference))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,54526,54646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54619,54631);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,54526,54646);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54662,54768);

var 
rightConversion = f_10913_54684_54767(Conversions, rightType, leftType, ref useSiteDiagnostics)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54782,54904) || true) && (rightConversion.IsIdentity ||(DynAbs.Tracing.TraceSender.Expression_False(10913, 54786, 54843)||rightConversion.IsReference))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10913,54782,54904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54877,54889);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10913,54782,54904);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10913,54920,54933);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10913,50527,54944);

bool
f_10913_52539_52565(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsTypeParameter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 52539, 52565);
return return_v;
}


bool
f_10913_52603_52623(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsValueType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10913, 52603, 52623);
return return_v;
}


bool
f_10913_52628_52653_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10913, 52628, 52653);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_52775_52849(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
this_param,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = this_param.EffectiveBaseClass( ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 52775, 52849);
return return_v;
}


int
f_10913_52868_52906(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 52868, 52906);
return 0;
}


bool
f_10913_52973_53000(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsTypeParameter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 52973, 53000);
return return_v;
}


bool
f_10913_53038_53059(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsValueType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10913, 53038, 53059);
return return_v;
}


bool
f_10913_53064_53090_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10913, 53064, 53090);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10913_53212_53287(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
this_param,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = this_param.EffectiveBaseClass( ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 53212, 53287);
return return_v;
}


int
f_10913_53306_53345(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 53306, 53345);
return 0;
}


bool
f_10913_53433_53457(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsReferenceType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10913, 53433, 53457);
return return_v;
}


bool
f_10913_53665_53690(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsReferenceType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10913, 53665, 53690);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10913_54428_54511(Microsoft.CodeAnalysis.CSharp.Conversions
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
source,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = this_param.ClassifyConversionFromType( source, destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 54428, 54511);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10913_54684_54767(Microsoft.CodeAnalysis.CSharp.Conversions
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
source,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = this_param.ClassifyConversionFromType( source, destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10913, 54684, 54767);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10913,50527,54944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,50527,54944);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static BuiltInOperators()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10913,695,54951);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10913,695,54951);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10913,695,54951);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10913,695,54951);
}
}
