// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.Cci
{

    [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal readonly struct SequencePoint
    {

        public const int
        HiddenLine = 0xfeefee
        ;

        public readonly int Offset;

        public readonly int StartLine;

        public readonly int EndLine;

        public readonly ushort StartColumn;

        public readonly ushort EndColumn;

        public readonly DebugSourceDocument Document;

        public SequencePoint(
                    DebugSourceDocument document,
                    int offset,
                    int startLine,
                    ushort startColumn,
                    int endLine,
                    ushort endColumn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(513, 869, 1359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1101, 1138);

                f_513_1101_1137(document != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1154, 1170);

                Offset = offset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1184, 1206);

                StartLine = startLine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1220, 1246);

                StartColumn = startColumn;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1260, 1278);

                EndLine = endLine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1292, 1314);

                EndColumn = endColumn;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1328, 1348);

                Document = document;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(513, 869, 1359);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(513, 869, 1359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(513, 869, 1359);
            }
        }

        public bool IsHidden
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(513, 1392, 1418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1395, 1418);
                    return StartLine == HiddenLine; DynAbs.Tracing.TraceSender.TraceExitMethod(513, 1392, 1418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(513, 1392, 1418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(513, 1392, 1418);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(513, 1431, 1537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1489, 1526);

                throw f_513_1495_1525();
                DynAbs.Tracing.TraceSender.TraceExitMethod(513, 1431, 1537);

                System.Exception
                f_513_1495_1525()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(513, 1495, 1525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(513, 1431, 1537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(513, 1431, 1537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(513, 1549, 1662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1614, 1651);

                throw f_513_1620_1650();
                DynAbs.Tracing.TraceSender.TraceExitMethod(513, 1549, 1662);

                System.Exception
                f_513_1620_1650()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(513, 1620, 1650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(513, 1549, 1662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(513, 1549, 1662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(513, 1674, 1845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 1734, 1834);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(513, 1741, 1749) || ((IsHidden && DynAbs.Tracing.TraceSender.Conditional_F2(513, 1752, 1762)) || DynAbs.Tracing.TraceSender.Conditional_F3(513, 1765, 1833))) ? "<hidden>" : $"{Offset}: ({StartLine}, {StartColumn}) - ({EndLine}, {EndColumn})";
                DynAbs.Tracing.TraceSender.TraceExitMethod(513, 1674, 1845);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(513, 1674, 1845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(513, 1674, 1845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SequencePoint()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(513, 334, 1852);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(513, 575, 596);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(513, 334, 1852);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(513, 334, 1852);
        }

        static int
        f_513_1101_1137(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(513, 1101, 1137);
            return 0;
        }

    }
}
