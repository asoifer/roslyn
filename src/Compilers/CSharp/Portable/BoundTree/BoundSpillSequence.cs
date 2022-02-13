// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundSpillSequence
    {
        public BoundSpillSequence(
                    SyntaxNode syntax,
                    ImmutableArray<LocalSymbol> locals,
                    ImmutableArray<BoundExpression> sideEffects,
                    BoundExpression value,
                    TypeSymbol type,
                    bool hasErrors = false)
        : this(f_10573_784_790_C(syntax), locals, f_10573_800_827(sideEffects), value, type, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10573, 495, 874);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10573, 495, 874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10573, 495, 874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10573, 495, 874);
            }
        }

        private static ImmutableArray<BoundStatement> MakeStatements(ImmutableArray<BoundExpression> expressions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10573, 886, 1208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10573, 1016, 1197);

                return expressions.SelectAsArray<BoundExpression, BoundStatement>(expression => new BoundExpressionStatement(expression.Syntax, expression, expression.HasErrors));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10573, 886, 1208);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10573, 886, 1208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10573, 886, 1208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundSpillSequence()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10573, 437, 1215);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10573, 437, 1215);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10573, 437, 1215);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10573, 437, 1215);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
        f_10573_800_827(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
        expressions)
        {
            var return_v = MakeStatements(expressions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10573, 800, 827);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10573_784_790_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10573, 495, 874);
            return return_v;
        }

    }
}
