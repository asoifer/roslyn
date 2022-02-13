// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundPattern
    {
        internal bool IsNegated(out BoundPattern innerPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10570, 595, 964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10570, 674, 694);

                innerPattern = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10570, 708, 729);

                bool
                negated = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10570, 743, 924) || true) && (innerPattern is BoundNegatedPattern negatedPattern)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10570, 743, 924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10570, 834, 853);

                        negated = !negated;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10570, 871, 909);

                        innerPattern = f_10570_886_908(negatedPattern);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10570, 743, 924);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10570, 743, 924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10570, 743, 924);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10570, 938, 953);

                return negated;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10570, 595, 964);

                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10570_886_908(Microsoft.CodeAnalysis.CSharp.BoundNegatedPattern
                this_param)
                {
                    var return_v = this_param.Negated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10570, 886, 908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10570, 595, 964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10570, 595, 964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundPattern()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10570, 256, 971);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10570, 256, 971);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10570, 256, 971);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10570, 256, 971);
    }
}
