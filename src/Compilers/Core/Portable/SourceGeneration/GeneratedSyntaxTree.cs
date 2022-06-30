// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{

    internal readonly struct GeneratedSyntaxTree
    {

        public SourceText Text { get; }

        public string HintName { get; }

        public SyntaxTree Tree { get; }

        public GeneratedSyntaxTree(string hintName, SourceText text, SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(547, 583, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(547, 685, 702);

                this.Text = text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(547, 716, 741);

                this.HintName = hintName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(547, 755, 772);

                this.Tree = tree;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(547, 583, 783);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(547, 583, 783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(547, 583, 783);
            }
        }
        static GeneratedSyntaxTree()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(547, 393, 790);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(547, 393, 790);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(547, 393, 790);
        }
    }
}
