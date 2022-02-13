// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class IdentifierNameSyntax
    {
        internal override string ErrorDisplayName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10772, 321, 428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10772, 389, 417);

                return f_10772_396_406().ValueText;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10772, 321, 428);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10772_396_406()
                {
                    var return_v = Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10772, 396, 406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10772, 321, 428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10772, 321, 428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IdentifierNameSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10772, 263, 435);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10772, 263, 435);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10772, 263, 435);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10772, 263, 435);
    }
}
