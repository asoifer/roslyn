// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{

public struct DeconstructionInfo
    {

private readonly Conversion _conversion;

public IMethodSymbol? Method
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10920,1958,2142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10920,1994,2127);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10920, 2001, 2050)||((_conversion.Kind == ConversionKind.Deconstruction
&&DynAbs.Tracing.TraceSender.Conditional_F2(10920, 2074, 2098))||DynAbs.Tracing.TraceSender.Conditional_F3(10920, 2122, 2126)))?_conversion.MethodSymbol
:null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10920,1958,2142);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10920,1905,2153);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10920,1905,2153);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Conversion? Conversion
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10920,2346,2530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10920,2382,2515);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10920, 2389, 2438)||((_conversion.Kind == ConversionKind.Deconstruction
&&DynAbs.Tracing.TraceSender.Conditional_F2(10920, 2462, 2466))||DynAbs.Tracing.TraceSender.Conditional_F3(10920, 2490, 2514)))?null
:(Conversion?)_conversion;
DynAbs.Tracing.TraceSender.TraceExitMethod(10920,2346,2530);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10920,2292,2541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10920,2292,2541);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ImmutableArray<DeconstructionInfo> Nested
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10920,2729,3056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10920,2765,2827);

var 
underlyingConversions = _conversion.UnderlyingConversions
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10920,2847,3041);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10920, 2854, 2885)||((underlyingConversions.IsDefault
&&DynAbs.Tracing.TraceSender.Conditional_F2(10920, 2909, 2949))||DynAbs.Tracing.TraceSender.Conditional_F3(10920, 2973, 3040)))?ImmutableArray<DeconstructionInfo>.Empty
:underlyingConversions.SelectAsArray(c => new DeconstructionInfo(c));
DynAbs.Tracing.TraceSender.TraceExitMethod(10920,2729,3056);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10920,2656,3067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10920,2656,3067);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal DeconstructionInfo(Conversion conversion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10920,3079,3190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10920,3154,3179);

_conversion = conversion;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10920,3079,3190);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10920,3079,3190);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10920,3079,3190);
}
		}
static DeconstructionInfo(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10920,1653,3197);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10920,1653,3197);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10920,1653,3197);
}
    }
}
