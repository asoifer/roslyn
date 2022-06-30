// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Operations
{
internal class ForEachLoopOperationInfo
{
public readonly ITypeSymbol ElementType;

public readonly IMethodSymbol GetEnumeratorMethod;

public readonly IPropertySymbol CurrentProperty;

public readonly IMethodSymbol MoveNextMethod;

public readonly bool IsAsynchronous;

public readonly bool NeedsDispose;

public readonly bool KnownToImplementIDisposable;

public readonly IMethodSymbol? PatternDisposeMethod;

public readonly IConvertibleConversion CurrentConversion;

public readonly IConvertibleConversion ElementConversion;

public readonly ImmutableArray<IArgumentOperation> GetEnumeratorArguments;

public readonly ImmutableArray<IArgumentOperation> MoveNextArguments;

public readonly ImmutableArray<IArgumentOperation> CurrentArguments;

public readonly ImmutableArray<IArgumentOperation> DisposeArguments;

public ForEachLoopOperationInfo(
            ITypeSymbol elementType,
            IMethodSymbol getEnumeratorMethod,
            IPropertySymbol currentProperty,
            IMethodSymbol moveNextMethod,
            bool isAsynchronous,
            bool needsDispose,
            bool knownToImplementIDisposable,
            IMethodSymbol? patternDisposeMethod,
            IConvertibleConversion currentConversion,
            IConvertibleConversion elementConversion,
            ImmutableArray<IArgumentOperation> getEnumeratorArguments = default,
            ImmutableArray<IArgumentOperation> moveNextArguments = default,
            ImmutableArray<IArgumentOperation> currentArguments = default,
            ImmutableArray<IArgumentOperation> disposeArguments = default)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(780,1647,3186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,474,485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,528,547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,590,605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,646,660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,694,708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,740,752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,784,811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,853,873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,1085,1102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,1296,1313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2463,2489);

ElementType = elementType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2503,2545);

GetEnumeratorMethod = getEnumeratorMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2559,2593);

CurrentProperty = currentProperty;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2607,2639);

MoveNextMethod = moveNextMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2653,2685);

IsAsynchronous = isAsynchronous;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2699,2757);

KnownToImplementIDisposable = knownToImplementIDisposable;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2771,2799);

NeedsDispose = needsDispose;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2813,2857);

PatternDisposeMethod = patternDisposeMethod;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2871,2909);

CurrentConversion = currentConversion;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2923,2961);

ElementConversion = elementConversion;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,2975,3023);

GetEnumeratorArguments = getEnumeratorArguments;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,3037,3075);

MoveNextArguments = moveNextArguments;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,3089,3125);

CurrentArguments = currentArguments;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(780,3139,3175);

DisposeArguments = disposeArguments;
DynAbs.Tracing.TraceSender.TraceExitConstructor(780,1647,3186);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(780,1647,3186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(780,1647,3186);
}
		}

static ForEachLoopOperationInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(780,299,3193);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(780,299,3193);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(780,299,3193);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(780,299,3193);
}
}
