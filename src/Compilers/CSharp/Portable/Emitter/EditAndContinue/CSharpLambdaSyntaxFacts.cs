// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal class CSharpLambdaSyntaxFacts : LambdaSyntaxFacts
    {
        public static readonly LambdaSyntaxFacts Instance;

        private CSharpLambdaSyntaxFacts()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10938, 489, 544);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10938, 489, 544);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10938, 489, 544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10938, 489, 544);
            }
        }

        public override SyntaxNode GetLambda(SyntaxNode lambdaOrLambdaBodySyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10938, 643, 697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10938, 646, 697);
                return f_10938_646_697(lambdaOrLambdaBodySyntax); DynAbs.Tracing.TraceSender.TraceExitMethod(10938, 643, 697);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10938, 643, 697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10938, 643, 697);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxNode
            f_10938_646_697(Microsoft.CodeAnalysis.SyntaxNode
            lambdaBody)
            {
                var return_v = LambdaUtilities.GetLambda(lambdaBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10938, 646, 697);
                return return_v;
            }

        }

        public override SyntaxNode TryGetCorrespondingLambdaBody(SyntaxNode previousLambdaSyntax, SyntaxNode lambdaOrLambdaBodySyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10938, 850, 946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10938, 853, 946);
                return f_10938_853_946(lambdaOrLambdaBodySyntax, previousLambdaSyntax); DynAbs.Tracing.TraceSender.TraceExitMethod(10938, 850, 946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10938, 850, 946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10938, 850, 946);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxNode?
            f_10938_853_946(Microsoft.CodeAnalysis.SyntaxNode
            oldBody, Microsoft.CodeAnalysis.SyntaxNode
            newLambda)
            {
                var return_v = LambdaUtilities.TryGetCorrespondingLambdaBody(oldBody, newLambda);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10938, 853, 946);
                return return_v;
            }

        }

        public override int GetDeclaratorPosition(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10938, 1031, 1077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10938, 1034, 1077);
                return f_10938_1034_1077(node); DynAbs.Tracing.TraceSender.TraceExitMethod(10938, 1031, 1077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10938, 1031, 1077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10938, 1031, 1077);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10938_1034_1077(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = LambdaUtilities.GetDeclaratorPosition(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10938, 1034, 1077);
                return return_v;
            }

        }

        static CSharpLambdaSyntaxFacts()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10938, 320, 1085);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10938, 436, 476);
            Instance = f_10938_447_476(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10938, 320, 1085);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10938, 320, 1085);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10938, 320, 1085);

        static Microsoft.CodeAnalysis.CSharp.Emit.CSharpLambdaSyntaxFacts
        f_10938_447_476()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpLambdaSyntaxFacts();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10938, 447, 476);
            return return_v;
        }

    }
}
