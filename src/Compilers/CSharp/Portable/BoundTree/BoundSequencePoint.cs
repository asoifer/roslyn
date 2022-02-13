// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundSequencePoint
    {
        public static BoundStatement Create(SyntaxNode? syntax, TextSpan? part, BoundStatement statement, bool hasErrors = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10572, 352, 1005);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10572, 498, 994) || true) && (part.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10572, 498, 994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10572, 660, 741);

                    return f_10572_667_740(syntax!, statement, part.Value, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10572, 498, 994);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10572, 498, 994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10572, 918, 979);

                    return f_10572_925_978(syntax!, statement, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10572, 498, 994);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10572, 352, 1005);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10572_667_740(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan(syntax, statementOpt, span, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10572, 667, 740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                f_10572_925_978(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePoint(syntax, statementOpt, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10572, 925, 978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10572, 352, 1005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10572, 352, 1005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundStatement Create(SyntaxNode? syntax, BoundStatement? statementOpt, bool hasErrors = false, bool wasCompilerGenerated = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10572, 1017, 1416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10572, 1293, 1405);

                return new BoundSequencePoint(syntax!, statementOpt, hasErrors) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => wasCompilerGenerated, 10572, 1300, 1404) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10572, 1017, 1416);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10572, 1017, 1416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10572, 1017, 1416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundStatement CreateHidden(BoundStatement? statementOpt = null, bool hasErrors = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10572, 1428, 1767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10572, 1662, 1756);

                return new BoundSequencePoint(null!, statementOpt, hasErrors) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10572, 1669, 1755) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10572, 1428, 1767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10572, 1428, 1767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10572, 1428, 1767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundSequencePoint()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10572, 294, 1774);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10572, 294, 1774);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10572, 294, 1774);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10572, 294, 1774);
    }
}
