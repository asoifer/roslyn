// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class BoundExpressionWithNullability : BoundExpression
    {
        public BoundExpressionWithNullability(SyntaxNode syntax, BoundExpression expression, NullableAnnotation nullableAnnotation, TypeSymbol? type)
        : this(f_10556_561_567_C(syntax), expression, nullableAnnotation, type, hasErrors: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10556, 399, 699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10556, 649, 688);

                IsSuppressed = f_10556_664_687(expression);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10556, 399, 699);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10556, 399, 699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10556, 399, 699);
            }
        }

        static BoundExpressionWithNullability()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10556, 304, 706);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10556, 304, 706);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10556, 304, 706);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10556, 304, 706);

        bool
        f_10556_664_687(Microsoft.CodeAnalysis.CSharp.BoundExpression
        this_param)
        {
            var return_v = this_param.IsSuppressed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10556, 664, 687);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10556_561_567_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10556, 399, 699);
            return return_v;
        }

    }
}

