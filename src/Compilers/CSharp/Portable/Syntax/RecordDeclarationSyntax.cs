// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class RecordDeclarationSyntax
    {
        internal PrimaryConstructorBaseTypeSyntax? PrimaryConstructorBaseType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10792, 418, 545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10792, 454, 530);

                    return f_10792_461_469()?.Types.FirstOrDefault() as PrimaryConstructorBaseTypeSyntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10792, 418, 545);

                    Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
                    f_10792_461_469()
                    {
                        var return_v = BaseList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10792, 461, 469);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10792, 324, 556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10792, 324, 556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RecordDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10792, 263, 563);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10792, 263, 563);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10792, 263, 563);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10792, 263, 563);
    }
}
