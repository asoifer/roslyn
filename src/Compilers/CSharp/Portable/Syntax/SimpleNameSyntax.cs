// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class SimpleNameSyntax
    {
        internal sealed override SimpleNameSyntax GetUnqualifiedName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10796, 792, 902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10796, 879, 891);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10796, 792, 902);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10796, 792, 902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10796, 792, 902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SimpleNameSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10796, 422, 909);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10796, 422, 909);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10796, 422, 909);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10796, 422, 909);
    }
}
