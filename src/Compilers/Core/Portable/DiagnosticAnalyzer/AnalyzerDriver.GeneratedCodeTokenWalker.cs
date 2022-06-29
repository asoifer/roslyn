// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.CodeDom.Compiler;
using System.Threading;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract partial class AnalyzerDriver
    {
        private sealed class GeneratedCodeTokenWalker : SyntaxWalker
        {
            private readonly CancellationToken _cancellationToken;

            public GeneratedCodeTokenWalker(CancellationToken cancellationToken)
            : base(f_226_646_669_C(SyntaxWalkerDepth.Token))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(226, 553, 757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(226, 773, 833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(226, 703, 742);

                    _cancellationToken = cancellationToken;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(226, 553, 757);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(226, 553, 757);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(226, 553, 757);
                }
            }

            public bool HasGeneratedCodeIdentifier { get; private set; }

            public override void Visit(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(226, 849, 1105);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(226, 925, 985) || true) && (f_226_929_955())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(226, 925, 985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(226, 978, 985);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(226, 925, 985);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(226, 1005, 1055);

                    _cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(226, 1073, 1090);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 226, 1073, 1089);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(226, 849, 1105);

                    bool
                    f_226_929_955()
                    {
                        var return_v = HasGeneratedCodeIdentifier;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(226, 929, 955);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(226, 849, 1105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(226, 849, 1105);
                }
            }

            protected override void VisitToken(SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(226, 1121, 1439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(226, 1207, 1424);

                    HasGeneratedCodeIdentifier |= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => f_226_1237_1310(token.ValueText, "GeneratedCode", StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(226, 1237, 1423) || f_226_1335_1423(token.ValueText, nameof(GeneratedCodeAttribute), StringComparison.Ordinal)), 226, 1207, 1233);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(226, 1121, 1439);

                    bool
                    f_226_1237_1310(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(226, 1237, 1310);
                        return return_v;
                    }


                    bool
                    f_226_1335_1423(string
                    a, string
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(226, 1335, 1423);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(226, 1121, 1439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(226, 1121, 1439);
                }
            }

            static GeneratedCodeTokenWalker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(226, 398, 1450);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(226, 398, 1450);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(226, 398, 1450);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(226, 398, 1450);

            static Microsoft.CodeAnalysis.SyntaxWalkerDepth
            f_226_646_669_C(Microsoft.CodeAnalysis.SyntaxWalkerDepth
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(226, 553, 757);
                return return_v;
            }

        }
    }
}
