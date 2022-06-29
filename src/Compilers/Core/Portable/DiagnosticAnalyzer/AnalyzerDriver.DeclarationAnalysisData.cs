// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract partial class AnalyzerDriver
    {
        internal sealed class DeclarationAnalysisData
        {
            public DeclarationAnalysisData(
                            SyntaxNode declaringReferenceSyntax,
                            SyntaxNode topmostNodeForAnalysis,
                            ImmutableArray<DeclarationInfo> declarationsInNodeBuilder,
                            ImmutableArray<SyntaxNode> descendantNodesToAnalyze,
                            bool isPartialAnalysis)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(223, 448, 1129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(223, 1260, 1311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(223, 1438, 1487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(223, 2025, 2063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(223, 805, 857);

                    DeclaringReferenceSyntax = declaringReferenceSyntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(223, 875, 923);

                    TopmostNodeForAnalysis = topmostNodeForAnalysis;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(223, 941, 988);

                    DeclarationsInNode = declarationsInNodeBuilder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(223, 1006, 1058);

                    DescendantNodesToAnalyze = descendantNodesToAnalyze;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(223, 1076, 1114);

                    IsPartialAnalysis = isPartialAnalysis;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(223, 448, 1129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(223, 448, 1129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(223, 448, 1129);
                }
            }

            public SyntaxNode DeclaringReferenceSyntax { get; }

            public SyntaxNode TopmostNodeForAnalysis { get; }

            public ImmutableArray<DeclarationInfo> DeclarationsInNode { get; }

            public ImmutableArray<SyntaxNode> DescendantNodesToAnalyze { get; }

            public bool IsPartialAnalysis { get; }

            static DeclarationAnalysisData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(223, 378, 2074);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(223, 378, 2074);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(223, 378, 2074);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(223, 378, 2074);
        }
    }
}
