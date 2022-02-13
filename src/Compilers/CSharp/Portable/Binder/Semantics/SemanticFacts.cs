// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Symbol
    {
        public static bool IsSymbolAccessible(
                    Symbol symbol,
                    NamedTypeSymbol within,
                    NamedTypeSymbol throughTypeOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10059, 811, 1507);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 991, 1114) || true) && ((object)symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10059, 991, 1114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1051, 1099);

                    throw f_10059_1057_1098(nameof(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10059, 991, 1114);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1130, 1253) || true) && ((object)within == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10059, 1130, 1253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1190, 1238);

                    throw f_10059_1196_1237(nameof(within));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10059, 1130, 1253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1269, 1319);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1333, 1496);

                return f_10059_1340_1495(symbol, within, ref useSiteDiagnostics, throughTypeOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10059, 811, 1507);

                System.ArgumentNullException
                f_10059_1057_1098(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10059, 1057, 1098);
                    return return_v;
                }


                System.ArgumentNullException
                f_10059_1196_1237(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10059, 1196, 1237);
                    return return_v;
                }


                bool
                f_10059_1340_1495(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                throughTypeOpt)
                {
                    var return_v = AccessCheck.IsSymbolAccessible(symbol, within, ref useSiteDiagnostics, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)throughTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10059, 1340, 1495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10059, 811, 1507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10059, 811, 1507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsSymbolAccessible(
                    Symbol symbol,
                    AssemblySymbol within)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10059, 1645, 2203);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1772, 1895) || true) && ((object)symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10059, 1772, 1895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1832, 1880);

                    throw f_10059_1838_1879(nameof(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10059, 1772, 1895);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1911, 2034) || true) && ((object)within == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10059, 1911, 2034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 1971, 2019);

                    throw f_10059_1977_2018(nameof(within));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10059, 1911, 2034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 2050, 2100);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10059, 2114, 2192);

                return f_10059_2121_2191(symbol, within, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10059, 1645, 2203);

                System.ArgumentNullException
                f_10059_1838_1879(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10059, 1838, 1879);
                    return return_v;
                }


                System.ArgumentNullException
                f_10059_1977_2018(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10059, 1977, 2018);
                    return return_v;
                }


                bool
                f_10059_2121_2191(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible(symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10059, 2121, 2191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10059, 1645, 2203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10059, 1645, 2203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Symbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10059, 458, 2210);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10040, 36609, 36978);

            var temp = SymbolDisplayFormat.TestFormat
                .AddMiscellaneousOptions(SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier
                    | SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 36648, 36889);

            s_debuggerDisplayFormat = temp.WithCompilerInternalOptions(SymbolDisplayCompilerInternalOptions.None);

            DynAbs.Tracing.TraceSender.TraceEndInvocation(10040, 36648, 36978);

            //s_debuggerDisplayFormat = f_10040_36648_36978(f_10040_36648_36889(SymbolDisplayFormat.TestFormat
            //, SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier
            //                    | SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier), SymbolDisplayCompilerInternalOptions.None);

            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10059, 458, 2210);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10059, 458, 2210);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10059, 458, 2210);
    }
}
