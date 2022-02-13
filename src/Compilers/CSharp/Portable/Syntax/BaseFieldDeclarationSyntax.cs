// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class BaseFieldDeclarationSyntax
    {
        public abstract override SyntaxList<AttributeListSyntax> AttributeLists { get; }

        public abstract override SyntaxTokenList Modifiers { get; }

        static BaseFieldDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10741, 263, 483);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10741, 263, 483);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10741, 263, 483);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10741, 263, 483);
    }
}
