// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal static class SwitchConstantValueHelper
    {
        public static bool IsValidSwitchCaseLabelConstant(ConstantValue constant)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(39, 547, 1537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 645, 1526);

                switch (f_39_653_675(constant))
                {

                    case ConstantValueTypeDiscriminator.Null:
                    case ConstantValueTypeDiscriminator.SByte:
                    case ConstantValueTypeDiscriminator.Byte:
                    case ConstantValueTypeDiscriminator.Int16:
                    case ConstantValueTypeDiscriminator.UInt16:
                    case ConstantValueTypeDiscriminator.Int32:
                    case ConstantValueTypeDiscriminator.UInt32:
                    case ConstantValueTypeDiscriminator.Int64:
                    case ConstantValueTypeDiscriminator.UInt64:
                    case ConstantValueTypeDiscriminator.Char:
                    case ConstantValueTypeDiscriminator.Boolean:
                    case ConstantValueTypeDiscriminator.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 645, 1526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 1436, 1448);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 645, 1526);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 645, 1526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 1498, 1511);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 645, 1526);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(39, 547, 1537);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_39_653_675(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 653, 675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(39, 547, 1537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(39, 547, 1537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int CompareSwitchCaseLabelConstants(ConstantValue first, ConstantValue second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(39, 2191, 4256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 2308, 2342);

                f_39_2308_2341(first != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 2356, 2391);

                f_39_2356_2390(second != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 2407, 2465);

                f_39_2407_2464(f_39_2426_2463(first));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 2479, 2538);

                f_39_2479_2537(f_39_2498_2536(second));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 2554, 3097) || true) && (f_39_2558_2570(first))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 2554, 3097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 2805, 2835);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(39, 2812, 2825) || ((f_39_2812_2825(second) && DynAbs.Tracing.TraceSender.Conditional_F2(39, 2828, 2829)) || DynAbs.Tracing.TraceSender.Conditional_F3(39, 2832, 2834))) ? 0 : -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(39, 2554, 3097);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 2554, 3097);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 2869, 3097) || true) && (f_39_2873_2886(second))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 2869, 3097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 3073, 3082);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 2869, 3097);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(39, 2554, 3097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 3113, 4245);

                switch (f_39_3121_3140(first))
                {

                    case ConstantValueTypeDiscriminator.SByte:
                    case ConstantValueTypeDiscriminator.Int16:
                    case ConstantValueTypeDiscriminator.Int32:
                    case ConstantValueTypeDiscriminator.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 3113, 4245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 3418, 3471);

                        return f_39_3425_3470(f_39_3425_3441(first), f_39_3452_3469(second));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 3113, 4245);

                    case ConstantValueTypeDiscriminator.Boolean:
                    case ConstantValueTypeDiscriminator.Byte:
                    case ConstantValueTypeDiscriminator.UInt16:
                    case ConstantValueTypeDiscriminator.UInt32:
                    case ConstantValueTypeDiscriminator.UInt64:
                    case ConstantValueTypeDiscriminator.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 3113, 4245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 3858, 3913);

                        return f_39_3865_3912(f_39_3865_3882(first), f_39_3893_3911(second));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 3113, 4245);

                    case ConstantValueTypeDiscriminator.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 3113, 4245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 3998, 4028);

                        f_39_3998_4027(f_39_4011_4026(second));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 4050, 4118);

                        return f_39_4057_4117(f_39_4079_4096(first), f_39_4098_4116(second));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 3113, 4245);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 3113, 4245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 4168, 4230);

                        throw f_39_4174_4229(f_39_4209_4228(first));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 3113, 4245);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(39, 2191, 4256);

                int
                f_39_2308_2341(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 2308, 2341);
                    return 0;
                }


                int
                f_39_2356_2390(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 2356, 2390);
                    return 0;
                }


                bool
                f_39_2426_2463(Microsoft.CodeAnalysis.ConstantValue
                constant)
                {
                    var return_v = IsValidSwitchCaseLabelConstant(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 2426, 2463);
                    return return_v;
                }


                int
                f_39_2407_2464(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 2407, 2464);
                    return 0;
                }


                bool
                f_39_2498_2536(Microsoft.CodeAnalysis.ConstantValue
                constant)
                {
                    var return_v = IsValidSwitchCaseLabelConstant(constant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 2498, 2536);
                    return return_v;
                }


                int
                f_39_2479_2537(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 2479, 2537);
                    return 0;
                }


                bool
                f_39_2558_2570(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 2558, 2570);
                    return return_v;
                }


                bool
                f_39_2812_2825(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 2812, 2825);
                    return return_v;
                }


                bool
                f_39_2873_2886(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 2873, 2886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_39_3121_3140(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 3121, 3140);
                    return return_v;
                }


                long
                f_39_3425_3441(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 3425, 3441);
                    return return_v;
                }


                long
                f_39_3452_3469(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 3452, 3469);
                    return return_v;
                }


                int
                f_39_3425_3470(long
                this_param, long
                value)
                {
                    var return_v = this_param.CompareTo(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 3425, 3470);
                    return return_v;
                }


                ulong
                f_39_3865_3882(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 3865, 3882);
                    return return_v;
                }


                ulong
                f_39_3893_3911(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 3893, 3911);
                    return return_v;
                }


                int
                f_39_3865_3912(ulong
                this_param, ulong
                value)
                {
                    var return_v = this_param.CompareTo(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 3865, 3912);
                    return return_v;
                }


                bool
                f_39_4011_4026(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 4011, 4026);
                    return return_v;
                }


                int
                f_39_3998_4027(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 3998, 4027);
                    return 0;
                }


                string?
                f_39_4079_4096(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.StringValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 4079, 4096);
                    return return_v;
                }


                string
                f_39_4098_4116(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.StringValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 4098, 4116);
                    return return_v;
                }


                int
                f_39_4057_4117(string?
                strA, string
                strB)
                {
                    var return_v = string.CompareOrdinal(strA, strB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 4057, 4117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_39_4209_4228(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 4209, 4228);
                    return return_v;
                }


                System.Exception
                f_39_4174_4229(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 4174, 4229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(39, 2191, 4256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(39, 2191, 4256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        public class SwitchLabelsComparer : EqualityComparer<object>
        {
            public override bool Equals(object? first, object? second)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(39, 4353, 5676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 4444, 4496);

                    f_39_4444_4495(first != null && (DynAbs.Tracing.TraceSender.Expression_True(39, 4463, 4494) && second != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 4516, 4559);

                    var
                    firstConstant = first as ConstantValue
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 4577, 5372) || true) && (firstConstant != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 4577, 5372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 4644, 4689);

                        var
                        secondConstant = second as ConstantValue
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 4711, 5353) || true) && (secondConstant != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 4711, 5353);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 4787, 5227) || true) && (!f_39_4792_4837(firstConstant) || (DynAbs.Tracing.TraceSender.Expression_False(39, 4791, 4917) || !f_39_4871_4917(secondConstant)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 4787, 5227);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5156, 5200);

                                return f_39_5163_5199(firstConstant, secondConstant);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(39, 4787, 5227);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5255, 5330);

                            return f_39_5262_5324(firstConstant, secondConstant) == 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(39, 4711, 5353);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 4577, 5372);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5392, 5426);

                    var
                    firstString = first as string
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5444, 5613) || true) && (firstString != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 5444, 5613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5509, 5594);

                        return f_39_5516_5593(firstString, second as string, System.StringComparison.Ordinal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 5444, 5613);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5633, 5661);

                    return f_39_5640_5660(first, second);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(39, 4353, 5676);

                    int
                    f_39_4444_4495(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 4444, 4495);
                        return 0;
                    }


                    bool
                    f_39_4792_4837(Microsoft.CodeAnalysis.ConstantValue
                    constant)
                    {
                        var return_v = IsValidSwitchCaseLabelConstant(constant);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 4792, 4837);
                        return return_v;
                    }


                    bool
                    f_39_4871_4917(Microsoft.CodeAnalysis.ConstantValue
                    constant)
                    {
                        var return_v = IsValidSwitchCaseLabelConstant(constant);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 4871, 4917);
                        return return_v;
                    }


                    bool
                    f_39_5163_5199(Microsoft.CodeAnalysis.ConstantValue
                    this_param, Microsoft.CodeAnalysis.ConstantValue
                    other)
                    {
                        var return_v = this_param.Equals(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 5163, 5199);
                        return return_v;
                    }


                    int
                    f_39_5262_5324(Microsoft.CodeAnalysis.ConstantValue
                    first, Microsoft.CodeAnalysis.ConstantValue
                    second)
                    {
                        var return_v = CompareSwitchCaseLabelConstants(first, second);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 5262, 5324);
                        return return_v;
                    }


                    bool
                    f_39_5516_5593(string
                    a, object
                    b, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Equals(a, (string?)b, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 5516, 5593);
                        return return_v;
                    }


                    bool
                    f_39_5640_5660(object
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.Equals(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 5640, 5660);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(39, 4353, 5676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(39, 4353, 5676);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(39, 5692, 7010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5768, 5804);

                    var
                    constant = obj as ConstantValue
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5822, 6950) || true) && (constant != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 5822, 6950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 5884, 6931);

                        switch (f_39_5892_5914(constant))
                        {

                            case ConstantValueTypeDiscriminator.SByte:
                            case ConstantValueTypeDiscriminator.Int16:
                            case ConstantValueTypeDiscriminator.Int32:
                            case ConstantValueTypeDiscriminator.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 5884, 6931);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 6240, 6281);

                                return f_39_6247_6280(f_39_6247_6266(constant));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(39, 5884, 6931);

                            case ConstantValueTypeDiscriminator.Boolean:
                            case ConstantValueTypeDiscriminator.Byte:
                            case ConstantValueTypeDiscriminator.UInt16:
                            case ConstantValueTypeDiscriminator.UInt32:
                            case ConstantValueTypeDiscriminator.UInt64:
                            case ConstantValueTypeDiscriminator.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 5884, 6931);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 6724, 6766);

                                return f_39_6731_6765(f_39_6731_6751(constant));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(39, 5884, 6931);

                            case ConstantValueTypeDiscriminator.String:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(39, 5884, 6931);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 6867, 6908);

                                return f_39_6874_6907(constant.RopeValue!);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(39, 5884, 6931);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(39, 5822, 6950);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(39, 6970, 6995);

                    return f_39_6977_6994(obj);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(39, 5692, 7010);

                    Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                    f_39_5892_5914(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Discriminator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 5892, 5914);
                        return return_v;
                    }


                    long
                    f_39_6247_6266(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Int64Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 6247, 6266);
                        return return_v;
                    }


                    int
                    f_39_6247_6280(long
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 6247, 6280);
                        return return_v;
                    }


                    ulong
                    f_39_6731_6751(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.UInt64Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(39, 6731, 6751);
                        return return_v;
                    }


                    int
                    f_39_6731_6765(ulong
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 6731, 6765);
                        return return_v;
                    }


                    int
                    f_39_6874_6907(Microsoft.CodeAnalysis.Rope
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 6874, 6907);
                        return return_v;
                    }


                    int
                    f_39_6977_6994(object
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(39, 6977, 6994);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(39, 5692, 7010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(39, 5692, 7010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SwitchLabelsComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(39, 4268, 7021);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(39, 4268, 7021);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(39, 4268, 7021);
            }


            static SwitchLabelsComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(39, 4268, 7021);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(39, 4268, 7021);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(39, 4268, 7021);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(39, 4268, 7021);
        }

        static SwitchConstantValueHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(39, 483, 7028);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(39, 483, 7028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(39, 483, 7028);
        }

    }
}
