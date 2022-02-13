// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LocalInProgressBinder : Binder
    {
        private readonly LocalSymbol _inProgress;

        internal LocalInProgressBinder(LocalSymbol inProgress, Binder next)
        : base(f_10349_866_870_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10349, 778, 932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10349, 754, 765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10349, 896, 921);

                _inProgress = inProgress;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10349, 778, 932);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10349, 778, 932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10349, 778, 932);
            }
        }

        internal override LocalSymbol LocalInProgress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10349, 1014, 1084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10349, 1050, 1069);

                    return _inProgress;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10349, 1014, 1084);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10349, 944, 1095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10349, 944, 1095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static LocalInProgressBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10349, 656, 1102);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10349, 656, 1102);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10349, 656, 1102);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10349, 656, 1102);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10349_866_870_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10349, 778, 932);
            return return_v;
        }

    }
}
