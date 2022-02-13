// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct NamespaceOrTypeAndUsingDirective
    {

        public readonly NamespaceOrTypeSymbol NamespaceOrType;

        public readonly UsingDirectiveSyntax UsingDirective;

        public NamespaceOrTypeAndUsingDirective(NamespaceOrTypeSymbol namespaceOrType, UsingDirectiveSyntax usingDirective)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10361, 563, 804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10361, 703, 742);

                this.NamespaceOrType = namespaceOrType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10361, 756, 793);

                this.UsingDirective = usingDirective;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10361, 563, 804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10361, 563, 804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10361, 563, 804);
            }
        }
        static NamespaceOrTypeAndUsingDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10361, 370, 811);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10361, 370, 811);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10361, 370, 811);
        }
    }
}
