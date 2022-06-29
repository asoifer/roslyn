// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security
{
    internal class SuppressUnmanagedCodeSecurityAttribute : Attribute
    {
        public SuppressUnmanagedCodeSecurityAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(388, 340, 419);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(388, 340, 419);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(388, 340, 419);
        }


        static SuppressUnmanagedCodeSecurityAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(388, 340, 419);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(388, 340, 419);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(388, 340, 419);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(388, 340, 419);
    }
}
