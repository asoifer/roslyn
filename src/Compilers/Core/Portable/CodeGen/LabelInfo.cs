// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal partial class ILBuilder
    {
        private struct LabelInfo
        {

            internal readonly int stack;

            internal readonly BasicBlock? bb;

            internal readonly bool targetOfConditionalBranches;

            internal LabelInfo(int stack, bool targetOfConditionalBranches)
            : this(f_63_1531_1535_C(null), stack, targetOfConditionalBranches)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(63, 1443, 1602);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(63, 1443, 1602);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(63, 1443, 1602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(63, 1443, 1602);
                }
            }

            internal LabelInfo(BasicBlock? bb, int stack, bool targetOfConditionalBranches)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(63, 1729, 1987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(63, 1841, 1860);

                    this.stack = stack;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(63, 1878, 1891);

                    this.bb = bb;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(63, 1909, 1972);

                    this.targetOfConditionalBranches = targetOfConditionalBranches;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(63, 1729, 1987);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(63, 1729, 1987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(63, 1729, 1987);
                }
            }

            internal LabelInfo WithNewTarget(BasicBlock? bb)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(63, 2003, 2170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(63, 2084, 2155);

                    return f_63_2091_2154(bb, this.stack, this.targetOfConditionalBranches);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(63, 2003, 2170);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                    f_63_2091_2154(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
                    bb, int
                    stack, bool
                    targetOfConditionalBranches)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo(bb, stack, targetOfConditionalBranches);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(63, 2091, 2154);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(63, 2003, 2170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(63, 2003, 2170);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal LabelInfo SetTargetOfConditionalBranches()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(63, 2186, 2333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(63, 2270, 2318);

                    return f_63_2277_2317(this.bb, this.stack, true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(63, 2186, 2333);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                    f_63_2277_2317(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
                    bb, int
                    stack, bool
                    targetOfConditionalBranches)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo(bb, stack, targetOfConditionalBranches);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(63, 2277, 2317);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(63, 2186, 2333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(63, 2186, 2333);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static LabelInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(63, 440, 2344);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(63, 440, 2344);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(63, 440, 2344);
            }

            static Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
            f_63_1531_1535_C(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(63, 1443, 1602);
                return return_v;
            }

        }
    }
}
