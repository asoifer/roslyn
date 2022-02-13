// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.DocumentationComments
{
    internal static class PEDocumentationCommentUtils
    {
        internal static string GetDocumentationComment(
                    Symbol symbol,
                    PEModuleSymbol containingPEModule,
                    CultureInfo preferredCulture,
                    CancellationToken cancellationToken,
                    ref Tuple<CultureInfo, string> lazyDocComment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10935, 621, 1907);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10935, 963, 1410) || true) && (lazyDocComment == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10935, 963, 1410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10935, 1023, 1395);

                    f_10935_1023_1394(ref lazyDocComment, f_10935_1114_1366(preferredCulture, f_10935_1196_1365(f_10935_1196_1236(containingPEModule), f_10935_1293_1327(symbol), preferredCulture, cancellationToken)), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10935, 963, 1410);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10935, 1498, 1632) || true) && (f_10935_1502_1555(f_10935_1516_1536(lazyDocComment), preferredCulture))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10935, 1498, 1632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10935, 1589, 1617);

                    return f_10935_1596_1616(lazyDocComment);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10935, 1498, 1632);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10935, 1731, 1896);

                return f_10935_1738_1895(f_10935_1738_1778(containingPEModule), f_10935_1823_1857(symbol), preferredCulture, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10935, 621, 1907);

                Microsoft.CodeAnalysis.DocumentationProvider
                f_10935_1196_1236(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.DocumentationProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10935, 1196, 1236);
                    return return_v;
                }


                string
                f_10935_1293_1327(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetDocumentationCommentId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10935, 1293, 1327);
                    return return_v;
                }


                string?
                f_10935_1196_1365(Microsoft.CodeAnalysis.DocumentationProvider
                this_param, string
                documentationMemberID, System.Globalization.CultureInfo
                preferredCulture, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationForSymbol(documentationMemberID, preferredCulture, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10935, 1196, 1365);
                    return return_v;
                }


                System.Tuple<System.Globalization.CultureInfo, string?>
                f_10935_1114_1366(System.Globalization.CultureInfo
                item1, string?
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10935, 1114, 1366);
                    return return_v;
                }


                System.Tuple<System.Globalization.CultureInfo, string?>?
                f_10935_1023_1394(ref System.Tuple<System.Globalization.CultureInfo, string>?
                location1, System.Tuple<System.Globalization.CultureInfo, string?>
                value, System.Tuple<System.Globalization.CultureInfo, string?>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10935, 1023, 1394);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10935_1516_1536(System.Tuple<System.Globalization.CultureInfo, string>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10935, 1516, 1536);
                    return return_v;
                }


                bool
                f_10935_1502_1555(System.Globalization.CultureInfo
                objA, System.Globalization.CultureInfo
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10935, 1502, 1555);
                    return return_v;
                }


                string
                f_10935_1596_1616(System.Tuple<System.Globalization.CultureInfo, string>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10935, 1596, 1616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationProvider
                f_10935_1738_1778(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.DocumentationProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10935, 1738, 1778);
                    return return_v;
                }


                string
                f_10935_1823_1857(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetDocumentationCommentId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10935, 1823, 1857);
                    return return_v;
                }


                string?
                f_10935_1738_1895(Microsoft.CodeAnalysis.DocumentationProvider
                this_param, string
                documentationMemberID, System.Globalization.CultureInfo
                preferredCulture, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationForSymbol(documentationMemberID, preferredCulture, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10935, 1738, 1895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10935, 621, 1907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10935, 621, 1907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PEDocumentationCommentUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10935, 555, 1914);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10935, 555, 1914);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10935, 555, 1914);
        }

    }
}
