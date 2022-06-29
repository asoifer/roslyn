// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    internal sealed class CommitHashAttribute : Attribute
    {
        internal readonly string Hash;

        public CommitHashAttribute(string hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(5, 448, 535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(5, 433, 437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(5, 512, 524);

                Hash = hash;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(5, 448, 535);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(5, 448, 535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(5, 448, 535);
            }
        }

        static CommitHashAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(5, 266, 542);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(5, 266, 542);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(5, 266, 542);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(5, 266, 542);
    }
}
