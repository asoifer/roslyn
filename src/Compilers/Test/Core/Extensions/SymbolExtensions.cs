// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    internal static class SymbolExtensions
    {
        public static string ToTestDisplayString(this ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25013, 340, 499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25013, 426, 488);

                return f_25013_433_487(symbol, SymbolDisplayFormat.TestFormat);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25013, 340, 499);

                string
                f_25013_433_487(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25013, 433, 487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25013, 340, 499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25013, 340, 499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25013, 285, 506);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25013, 285, 506);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25013, 285, 506);
        }

    }
}
