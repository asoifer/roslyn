// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CodeGen
{

    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal readonly struct RawSequencePoint
    {

        internal readonly SyntaxTree SyntaxTree;

        internal readonly int ILMarker;

        internal readonly TextSpan Span;

        internal static readonly TextSpan HiddenSequencePointSpan;

        internal RawSequencePoint(SyntaxTree syntaxTree, int ilMarker, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(79, 864, 1076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(79, 966, 995);

                this.SyntaxTree = syntaxTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(79, 1009, 1034);

                this.ILMarker = ilMarker;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(79, 1048, 1065);

                this.Span = span;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(79, 864, 1076);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(79, 864, 1076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(79, 864, 1076);
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(79, 1088, 1265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(79, 1148, 1254);

                return f_79_1155_1253("#{0}: {1}", ILMarker, (DynAbs.Tracing.TraceSender.Conditional_F1(79, 1192, 1223) || ((Span == HiddenSequencePointSpan && DynAbs.Tracing.TraceSender.Conditional_F2(79, 1226, 1234)) || DynAbs.Tracing.TraceSender.Conditional_F3(79, 1237, 1252))) ? "hidden" : Span.ToString());
                DynAbs.Tracing.TraceSender.TraceExitMethod(79, 1088, 1265);

                string
                f_79_1155_1253(string
                format, int
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(79, 1155, 1253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(79, 1088, 1265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(79, 1088, 1265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static RawSequencePoint()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(79, 453, 1272);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(79, 798, 851);
            HiddenSequencePointSpan = f_79_824_851(0x7FFFFFFF, 0); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(79, 453, 1272);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(79, 453, 1272);
        }

        static Microsoft.CodeAnalysis.Text.TextSpan
        f_79_824_851(int
        start, int
        length)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(79, 824, 851);
            return return_v;
        }

    }
}
