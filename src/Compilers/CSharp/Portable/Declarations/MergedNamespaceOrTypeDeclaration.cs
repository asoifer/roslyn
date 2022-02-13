// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class MergedNamespaceOrTypeDeclaration : Declaration
    {
        protected MergedNamespaceOrTypeDeclaration(string name)
        : base(f_10394_569_573_C(name))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10394, 493, 596);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10394, 493, 596);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10394, 493, 596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10394, 493, 596);
            }
        }

        static MergedNamespaceOrTypeDeclaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10394, 406, 603);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10394, 406, 603);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10394, 406, 603);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10394, 406, 603);

        static string
        f_10394_569_573_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10394, 493, 596);
            return return_v;
        }

    }
}
