// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public sealed partial class AttributeTargetSpecifierSyntax : CSharpSyntaxNode
    {
        internal AttributeLocation GetAttributeLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10740, 486, 616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10740, 560, 605);

                return this.Identifier.ToAttributeLocation();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10740, 486, 616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10740, 486, 616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10740, 486, 616);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AttributeTargetSpecifierSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10740, 392, 623);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10740, 392, 623);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10740, 392, 623);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10740, 392, 623);
    }
}
