// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class BoundDagRelationalTest
    {
        public BinaryOperatorKind Relation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10548, 360, 386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10548, 363, 386);
                    return f_10548_363_386(f_10548_363_375()); DynAbs.Tracing.TraceSender.TraceExitMethod(10548, 360, 386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10548, 360, 386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10548, 360, 386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundDagRelationalTest()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10548, 256, 394);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10548, 256, 394);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10548, 256, 394);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10548, 256, 394);

        Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
        f_10548_363_375()
        {
            var return_v = OperatorKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10548, 363, 375);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
        f_10548_363_386(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
        kind)
        {
            var return_v = kind.Operator();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10548, 363, 386);
            return return_v;
        }

    }
}
