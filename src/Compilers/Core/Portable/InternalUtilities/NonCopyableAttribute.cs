// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Roslyn.Utilities
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.GenericParameter)]
    internal sealed class NonCopyableAttribute : Attribute
    {
        public NonCopyableAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(347, 281, 432);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(347, 281, 432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(347, 281, 432);
        }


        static NonCopyableAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(347, 281, 432);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(347, 281, 432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(347, 281, 432);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(347, 281, 432);
    }
}
