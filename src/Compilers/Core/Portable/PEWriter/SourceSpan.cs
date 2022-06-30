// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{

    [SuppressMessage("Performance", "RS0008", Justification = "Equality not actually implemented")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal struct SourceSpan
    {

        public readonly int StartLine;

        public readonly int StartColumn;

        public readonly int EndLine;

        public readonly int EndColumn;

        public readonly Cci.DebugSourceDocument Document;

        public SourceSpan(
                    Cci.DebugSourceDocument document,
                    int startLine,
                    int startColumn,
                    int endLine,
                    int endColumn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(515, 784, 1214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 986, 1023);

                f_515_986_1022(document != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 1039, 1061);

                StartLine = startLine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 1075, 1101);

                StartColumn = startColumn;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 1115, 1133);

                EndLine = endLine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 1147, 1169);

                EndColumn = endColumn;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 1183, 1203);

                Document = document;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(515, 784, 1214);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(515, 784, 1214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(515, 784, 1214);
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(515, 1226, 1332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 1284, 1321);

                throw f_515_1290_1320();
                DynAbs.Tracing.TraceSender.TraceExitMethod(515, 1226, 1332);

                System.Exception
                f_515_1290_1320()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(515, 1290, 1320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(515, 1226, 1332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(515, 1226, 1332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(515, 1344, 1457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 1409, 1446);

                throw f_515_1415_1445();
                DynAbs.Tracing.TraceSender.TraceExitMethod(515, 1344, 1457);

                System.Exception
                f_515_1415_1445()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(515, 1415, 1445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(515, 1344, 1457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(515, 1344, 1457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(515, 1469, 1606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(515, 1529, 1595);

                return $"({StartLine}, {StartColumn}) - ({EndLine}, {EndColumn})";
                DynAbs.Tracing.TraceSender.TraceExitMethod(515, 1469, 1606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(515, 1469, 1606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(515, 1469, 1606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SourceSpan()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(515, 351, 1613);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(515, 351, 1613);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(515, 351, 1613);
        }

        static int
        f_515_986_1022(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(515, 986, 1022);
            return 0;
        }

    }
}
