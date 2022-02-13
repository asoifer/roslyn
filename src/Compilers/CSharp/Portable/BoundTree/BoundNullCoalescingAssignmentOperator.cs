// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class BoundNullCoalescingAssignmentOperator
    {
        internal bool IsNullableValueTypeAssignment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10567, 449, 860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10567, 485, 517);

                    var
                    leftType = f_10567_500_516(f_10567_500_511())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10567, 562, 693) || true) && (leftType is null || (DynAbs.Tracing.TraceSender.Expression_False(10567, 566, 619) || f_10567_586_611(leftType) != true))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10567, 562, 693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10567, 661, 674);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10567, 562, 693);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10567, 713, 775);

                    var
                    nullableUnderlying = f_10567_738_774(leftType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10567, 793, 845);

                    return f_10567_800_844(nullableUnderlying, f_10567_826_843(f_10567_826_838()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10567, 449, 860);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10567_500_511()
                    {
                        var return_v = LeftOperand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10567, 500, 511);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10567_500_516(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10567, 500, 516);
                        return return_v;
                    }


                    bool
                    f_10567_586_611(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsNullableType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10567, 586, 611);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10567_738_774(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.GetNullableUnderlyingType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10567, 738, 774);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10567_826_838()
                    {
                        var return_v = RightOperand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10567, 826, 838);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10567_826_843(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10567, 826, 843);
                        return return_v;
                    }


                    bool
                    f_10567_800_844(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    obj)
                    {
                        var return_v = this_param.Equals((object?)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10567, 800, 844);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10567, 381, 871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10567, 381, 871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundNullCoalescingAssignmentOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10567, 304, 878);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10567, 304, 878);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10567, 304, 878);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10567, 304, 878);
    }
}
