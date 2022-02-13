// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

public struct ForEachStatementInfo : IEquatable<ForEachStatementInfo>
    {

public bool IsAsynchronous {get; }

public IMethodSymbol? GetEnumeratorMethod {get; }

public IMethodSymbol? MoveNextMethod {get; }

public IPropertySymbol? CurrentProperty {get; }

public IMethodSymbol? DisposeMethod {get; }

public ITypeSymbol? ElementType {get; }

public Conversion ElementConversion {get; }

public Conversion CurrentConversion {get; }

internal ForEachStatementInfo(bool isAsync,
                                      IMethodSymbol getEnumeratorMethod,
                                      IMethodSymbol moveNextMethod,
                                      IPropertySymbol currentProperty,
                                      IMethodSymbol disposeMethod,
                                      ITypeSymbol elementType,
                                      Conversion elementConversion,
                                      Conversion currentConversion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10921,2439,3406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,2992,3022);

this.IsAsynchronous = isAsync;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3036,3083);

this.GetEnumeratorMethod = getEnumeratorMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3097,3134);

this.MoveNextMethod = moveNextMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3148,3187);

this.CurrentProperty = currentProperty;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3201,3236);

this.DisposeMethod = disposeMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3250,3281);

this.ElementType = elementType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3295,3338);

this.ElementConversion = elementConversion;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3352,3395);

this.CurrentConversion = currentConversion;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10921,2439,3406);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10921,2439,3406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10921,2439,3406);
}
		}

public override bool Equals(object? obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10921,3418,3566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3483,3555);

return obj is ForEachStatementInfo &&(DynAbs.Tracing.TraceSender.Expression_True(10921, 3490, 3554)&&Equals(obj));
DynAbs.Tracing.TraceSender.TraceExitMethod(10921,3418,3566);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10921,3418,3566);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10921,3418,3566);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool Equals(ForEachStatementInfo other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10921,3578,4240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,3649,4229);

return this.IsAsynchronous == other.IsAsynchronous
&&(DynAbs.Tracing.TraceSender.Expression_True(10921, 3656, 3786)&&f_10921_3720_3786(this.GetEnumeratorMethod, other.GetEnumeratorMethod))&&(DynAbs.Tracing.TraceSender.Expression_True(10921, 3656, 3863)&&f_10921_3807_3863(this.MoveNextMethod, other.MoveNextMethod))&&(DynAbs.Tracing.TraceSender.Expression_True(10921, 3656, 3942)&&f_10921_3884_3942(this.CurrentProperty, other.CurrentProperty))&&(DynAbs.Tracing.TraceSender.Expression_True(10921, 3656, 4017)&&f_10921_3963_4017(this.DisposeMethod, other.DisposeMethod))&&(DynAbs.Tracing.TraceSender.Expression_True(10921, 3656, 4088)&&f_10921_4038_4088(this.ElementType, other.ElementType))&&(DynAbs.Tracing.TraceSender.Expression_True(10921, 3656, 4158)&&this.ElementConversion == other.ElementConversion
)&&(DynAbs.Tracing.TraceSender.Expression_True(10921, 3656, 4228)&&this.CurrentConversion == other.CurrentConversion);
DynAbs.Tracing.TraceSender.TraceExitMethod(10921,3578,4240);

bool
f_10921_3720_3786(Microsoft.CodeAnalysis.IMethodSymbol?
objA,Microsoft.CodeAnalysis.IMethodSymbol?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 3720, 3786);
return return_v;
}


bool
f_10921_3807_3863(Microsoft.CodeAnalysis.IMethodSymbol?
objA,Microsoft.CodeAnalysis.IMethodSymbol?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 3807, 3863);
return return_v;
}


bool
f_10921_3884_3942(Microsoft.CodeAnalysis.IPropertySymbol?
objA,Microsoft.CodeAnalysis.IPropertySymbol?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 3884, 3942);
return return_v;
}


bool
f_10921_3963_4017(Microsoft.CodeAnalysis.IMethodSymbol?
objA,Microsoft.CodeAnalysis.IMethodSymbol?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 3963, 4017);
return return_v;
}


bool
f_10921_4038_4088(Microsoft.CodeAnalysis.ITypeSymbol?
objA,Microsoft.CodeAnalysis.ITypeSymbol?
objB)
{
var return_v = object.Equals( (object?)objA, (object?)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 4038, 4088);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10921,3578,4240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10921,3578,4240);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10921,4252,4742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10921,4310,4731);

return f_10921_4317_4730(IsAsynchronous, f_10921_4366_4729(GetEnumeratorMethod, f_10921_4420_4728(MoveNextMethod, f_10921_4469_4727(CurrentProperty, f_10921_4519_4726(DisposeMethod, f_10921_4567_4725(ElementType, f_10921_4613_4724(ElementConversion.GetHashCode(), CurrentConversion.GetHashCode())))))));
DynAbs.Tracing.TraceSender.TraceExitMethod(10921,4252,4742);

int
f_10921_4613_4724(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 4613, 4724);
return return_v;
}


int
f_10921_4567_4725(Microsoft.CodeAnalysis.ITypeSymbol?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 4567, 4725);
return return_v;
}


int
f_10921_4519_4726(Microsoft.CodeAnalysis.IMethodSymbol?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 4519, 4726);
return return_v;
}


int
f_10921_4469_4727(Microsoft.CodeAnalysis.IPropertySymbol?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 4469, 4727);
return return_v;
}


int
f_10921_4420_4728(Microsoft.CodeAnalysis.IMethodSymbol?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 4420, 4728);
return return_v;
}


int
f_10921_4366_4729(Microsoft.CodeAnalysis.IMethodSymbol?
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 4366, 4729);
return return_v;
}


int
f_10921_4317_4730(bool
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10921, 4317, 4730);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10921,4252,4742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10921,4252,4742);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static ForEachStatementInfo(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10921,420,4749);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10921,420,4749);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10921,420,4749);
}
    }
}
