// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct AliasAndUsingDirective
    {

        public readonly AliasSymbol Alias;

        public readonly UsingDirectiveSyntax UsingDirective;

        public AliasAndUsingDirective(AliasSymbol alias, UsingDirectiveSyntax usingDirective)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10285, 533, 724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10285, 643, 662);

                this.Alias = alias;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10285, 676, 713);

                this.UsingDirective = usingDirective;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10285, 533, 724);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10285, 533, 724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10285, 533, 724);
            }
        }
        static AliasAndUsingDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10285, 370, 731);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10285, 370, 731);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10285, 370, 731);
        }
    }
}
