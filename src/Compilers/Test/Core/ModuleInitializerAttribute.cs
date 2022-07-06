// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable


namespace System.Runtime.CompilerServices
{
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ModuleInitializerAttribute : Attribute
{
public ModuleInitializerAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25038,294,436);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25038,294,436);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25038,294,436);
}


static ModuleInitializerAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25038,294,436);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25038,294,436);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25038,294,436);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25038,294,436);
}
}

