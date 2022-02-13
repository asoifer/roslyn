// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class PseudoVariableExpressions
    {
        internal abstract BoundExpression GetValue(BoundPseudoVariable variable, DiagnosticBag diagnostics);

        internal abstract BoundExpression GetAddress(BoundPseudoVariable variable);

        public PseudoVariableExpressions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10588, 451, 709);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10588, 451, 709);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10588, 451, 709);
        }


        static PseudoVariableExpressions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10588, 451, 709);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10588, 451, 709);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10588, 451, 709);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10588, 451, 709);
    }
}
