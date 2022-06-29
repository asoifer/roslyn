// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Roslyn.Utilities
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.GenericParameter)]
    internal sealed class NonDefaultableAttribute : Attribute
    {
        public NonDefaultableAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(348, 281, 435);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(348, 281, 435);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(348, 281, 435);
        }


        static NonDefaultableAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(348, 281, 435);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(348, 281, 435);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(348, 281, 435);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(348, 281, 435);
    }
}
