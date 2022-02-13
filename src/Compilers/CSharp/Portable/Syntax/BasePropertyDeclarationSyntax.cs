// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class BasePropertyDeclarationSyntax
    {
        public abstract override SyntaxList<AttributeListSyntax> AttributeLists { get; }

        public abstract override SyntaxTokenList Modifiers { get; }

        static BasePropertyDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10743, 263, 486);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10743, 263, 486);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10743, 263, 486);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10743, 263, 486);
    }
}
