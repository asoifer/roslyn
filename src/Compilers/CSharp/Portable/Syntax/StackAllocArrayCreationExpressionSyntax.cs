// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class StackAllocArrayCreationExpressionSyntax
    {
        public StackAllocArrayCreationExpressionSyntax Update(SyntaxToken stackAllocKeyword, TypeSyntax type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10799, 502, 555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10799, 505, 555);
                return f_10799_505_555(this, f_10799_512_529(), type, initializer: null); DynAbs.Tracing.TraceSender.TraceExitMethod(10799, 502, 555);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10799, 502, 555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10799, 502, 555);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxToken
            f_10799_512_529()
            {
                var return_v = StackAllocKeyword;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10799, 512, 529);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax
            f_10799_505_555(Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            stackAllocKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            type, Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax?
            initializer)
            {
                var return_v = this_param.Update(stackAllocKeyword, type, initializer: initializer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10799, 505, 555);
                return return_v;
            }

        }

        static StackAllocArrayCreationExpressionSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10799, 310, 563);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10799, 310, 563);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10799, 310, 563);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10799, 310, 563);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static StackAllocArrayCreationExpressionSyntax StackAllocArrayCreationExpression(SyntaxToken stackAllocKeyword, TypeSyntax type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10799, 818, 898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10799, 821, 898);
                return f_10799_821_898(stackAllocKeyword, type, initializer: null); DynAbs.Tracing.TraceSender.TraceExitMethod(10799, 818, 898);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10799, 818, 898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10799, 818, 898);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax
            f_10799_821_898(Microsoft.CodeAnalysis.SyntaxToken
            stackAllocKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            type, Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax?
            initializer)
            {
                var return_v = StackAllocArrayCreationExpression(stackAllocKeyword, type, initializer: initializer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10799, 821, 898);
                return return_v;
            }

        }
    }
}
