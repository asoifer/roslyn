// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false)]
    internal sealed class InternalImplementationOnlyAttribute : Attribute
    {
        public InternalImplementationOnlyAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(20, 451, 607);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(20, 451, 607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(20, 451, 607);
        }


        static InternalImplementationOnlyAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(20, 451, 607);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(20, 451, 607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(20, 451, 607);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(20, 451, 607);
    }
}
