// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct AliasAndExternAliasDirective
    {

        public readonly AliasSymbol Alias;

        public readonly ExternAliasDirectiveSyntax ExternAliasDirective;

        public AliasAndExternAliasDirective(AliasSymbol alias, ExternAliasDirectiveSyntax externAliasDirective)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10284, 674, 895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10284, 802, 821);

                this.Alias = alias;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10284, 835, 884);

                this.ExternAliasDirective = externAliasDirective;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10284, 674, 895);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10284, 674, 895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10284, 674, 895);
            }
        }
        static AliasAndExternAliasDirective()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10284, 493, 902);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10284, 493, 902);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10284, 493, 902);
        }
    }
}
