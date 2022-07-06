// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Xunit;
using Xunit.Sdk;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
[TraitDiscoverer("Microsoft.CodeAnalysis.Test.Utilities.CompilerTraitDiscoverer", assemblyName: "Roslyn.Test.Utilities")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class CompilerTraitAttribute : Attribute, ITraitAttribute
{
public CompilerFeature[] Features {get; }

public CompilerTraitAttribute(params CompilerFeature[] features)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25030,697,817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25030,643,685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25030,786,806);

Features = features;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25030,697,817);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25030,697,817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25030,697,817);
}
		}

static CompilerTraitAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25030,334,824);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25030,334,824);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25030,334,824);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25030,334,824);
}
}
