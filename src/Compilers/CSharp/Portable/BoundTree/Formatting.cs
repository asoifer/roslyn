// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class BoundExpression
    {
        public virtual object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 672, 839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 708, 789);

                    f_10582_708_788(f_10582_721_730(this) is { }, $"Unexpected null type in {f_10582_766_785(f_10582_766_780(this))}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 807, 824);

                    return f_10582_814_823(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 672, 839);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10582_721_730(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 721, 730);
                        return return_v;
                    }


                    System.Type
                    f_10582_766_780(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 766, 780);
                        return return_v;
                    }


                    string
                    f_10582_766_785(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 766, 785);
                        return return_v;
                    }


                    int
                    f_10582_708_788(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 708, 788);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10582_814_823(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 814, 823);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 618, 850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 618, 850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class BoundArgListOperator
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 987, 1014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 993, 1012);

                    return "__arglist";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 987, 1014);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 932, 1025);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 932, 1025);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class BoundLiteral
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 1154, 1246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 1160, 1244);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10582, 1167, 1196) || ((f_10582_1167_1188_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10582_1167_1180(), 10582, 1167, 1188)?.IsNull) == true && DynAbs.Tracing.TraceSender.Conditional_F2(10582, 1199, 1228)) || DynAbs.Tracing.TraceSender.Conditional_F3(10582, 1231, 1243))) ? f_10582_1199_1228(MessageID.IDS_NULL) : DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Display, 10582, 1231, 1243);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 1154, 1246);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10582_1167_1180()
                    {
                        var return_v = ConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 1167, 1180);
                        return return_v;
                    }


                    bool?
                    f_10582_1167_1188_M(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 1167, 1188);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                    f_10582_1199_1228(Microsoft.CodeAnalysis.CSharp.MessageID
                    id)
                    {
                        var return_v = id.Localize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 1199, 1228);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 1099, 1257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 1099, 1257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class BoundLambda
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 1385, 1426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 1391, 1424);

                    return f_10582_1398_1423(f_10582_1398_1412(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 1385, 1426);

                    Microsoft.CodeAnalysis.CSharp.MessageID
                    f_10582_1398_1412(Microsoft.CodeAnalysis.CSharp.BoundLambda
                    this_param)
                    {
                        var return_v = this_param.MessageID;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 1398, 1412);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                    f_10582_1398_1423(Microsoft.CodeAnalysis.CSharp.MessageID
                    id)
                    {
                        var return_v = id.Localize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 1398, 1423);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 1330, 1437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 1330, 1437);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class UnboundLambda
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 1567, 1608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 1573, 1606);

                    return f_10582_1580_1605(f_10582_1580_1594(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 1567, 1608);

                    Microsoft.CodeAnalysis.CSharp.MessageID
                    f_10582_1580_1594(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                    this_param)
                    {
                        var return_v = this_param.MessageID;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 1580, 1594);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                    f_10582_1580_1605(Microsoft.CodeAnalysis.CSharp.MessageID
                    id)
                    {
                        var return_v = id.Localize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 1580, 1605);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 1512, 1619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 1512, 1619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static UnboundLambda()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10582, 1452, 1626);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10582, 1452, 1626);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 1452, 1626);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10582, 1452, 1626);
    }
    internal sealed partial class BoundMethodGroup
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 1752, 1804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 1758, 1802);

                    return f_10582_1765_1801(MessageID.IDS_MethodGroup);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 1752, 1804);

                    Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                    f_10582_1765_1801(Microsoft.CodeAnalysis.CSharp.MessageID
                    id)
                    {
                        var return_v = id.Localize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 1765, 1801);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 1697, 1815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 1697, 1815);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class BoundThrowExpression
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 1952, 2008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 1958, 2006);

                    return f_10582_1965_2005(MessageID.IDS_ThrowExpression);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 1952, 2008);

                    Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                    f_10582_1965_2005(Microsoft.CodeAnalysis.CSharp.MessageID
                    id)
                    {
                        var return_v = id.Localize();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 1965, 2005);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 1897, 2019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 1897, 2019);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal partial class BoundTupleExpression
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 2149, 2975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2185, 2239);

                    var
                    pooledBuilder = f_10582_2205_2238()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2257, 2293);

                    var
                    builder = pooledBuilder.Builder
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2311, 2342);

                    var
                    arguments = f_10582_2327_2341(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2360, 2412);

                    var
                    argumentDisplays = new object[arguments.Length]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2432, 2452);

                    f_10582_2432_2451(
                                    builder, '(');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2470, 2492);

                    f_10582_2470_2491(builder, "{0}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2510, 2553);

                    argumentDisplays[0] = f_10582_2532_2552(arguments[0]);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2582, 2587);

                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2573, 2772) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2611, 2614)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10582, 2573, 2772))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10582, 2573, 2772);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2656, 2688);

                            f_10582_2656_2687(builder, ", {" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (i).ToString(), 10582, 2679, 2680) + "}");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2710, 2753);

                            argumentDisplays[i] = f_10582_2732_2752(arguments[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10582, 1, 200);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10582, 1, 200);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2792, 2812);

                    f_10582_2792_2811(
                                    builder, ')');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2832, 2877);

                    var
                    format = f_10582_2845_2876(pooledBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 2895, 2960);

                    return f_10582_2902_2959(format, argumentDisplays);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 2149, 2975);

                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_10582_2205_2238()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 2205, 2238);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10582_2327_2341(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                    this_param)
                    {
                        var return_v = this_param.Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 2327, 2341);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_2432_2451(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 2432, 2451);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_2470_2491(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 2470, 2491);
                        return return_v;
                    }


                    object
                    f_10582_2532_2552(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Display;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 2532, 2552);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_2656_2687(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 2656, 2687);
                        return return_v;
                    }


                    object
                    f_10582_2732_2752(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Display;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 2732, 2752);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_2792_2811(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 2792, 2811);
                        return return_v;
                    }


                    string
                    f_10582_2845_2876(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToStringAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 2845, 2876);
                        return return_v;
                    }


                    System.FormattableString
                    f_10582_2902_2959(string
                    format, params object[]
                    arguments)
                    {
                        var return_v = FormattableStringFactory.Create(format, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 2902, 2959);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 2094, 2986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 2094, 2986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal sealed partial class BoundPropertyGroup
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 3121, 3166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 3127, 3164);

                    throw f_10582_3133_3163();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 3121, 3166);

                    System.Exception
                    f_10582_3133_3163()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 3133, 3163);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 3066, 3177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3066, 3177);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundPropertyGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10582, 3001, 3184);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10582, 3001, 3184);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3001, 3184);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10582, 3001, 3184);
    }
    internal partial class OutVariablePendingInference
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 3314, 3342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 3320, 3340);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 3314, 3342);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 3259, 3353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3259, 3353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static OutVariablePendingInference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10582, 3192, 3360);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10582, 3192, 3360);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3192, 3360);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10582, 3192, 3360);
    }
    internal partial class OutDeconstructVarPendingInference
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 3496, 3524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 3502, 3522);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 3496, 3524);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 3441, 3535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3441, 3535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static OutDeconstructVarPendingInference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10582, 3368, 3542);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10582, 3368, 3542);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3368, 3542);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10582, 3368, 3542);
    }
    internal partial class BoundDiscardExpression
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 3667, 3708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 3673, 3706);

                    return (object?)f_10582_3689_3698(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(10582, 3680, 3705) ?? "_");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 3667, 3708);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10582_3689_3698(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 3689, 3698);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 3612, 3719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3612, 3719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal partial class DeconstructionVariablePendingInference
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 3867, 3912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 3873, 3910);

                    throw f_10582_3879_3909();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 3867, 3912);

                    System.Exception
                    f_10582_3879_3909()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 3879, 3909);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 3812, 3923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3812, 3923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static DeconstructionVariablePendingInference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10582, 3734, 3930);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10582, 3734, 3930);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3734, 3930);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10582, 3734, 3930);
    }
    internal partial class BoundDefaultLiteral
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 4052, 4099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 4058, 4097);

                    return (object?)f_10582_4074_4083(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(10582, 4065, 4096) ?? "default");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 4052, 4099);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10582_4074_4083(Microsoft.CodeAnalysis.CSharp.BoundDefaultLiteral
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4074, 4083);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 3997, 4110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 3997, 4110);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal partial class BoundStackAllocArrayCreation
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 4237, 4400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 4240, 4400);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10582, 4240, 4254) || (((f_10582_4241_4245() is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10582, 4257, 4385)) || DynAbs.Tracing.TraceSender.Conditional_F3(10582, 4388, 4400))) ? f_10582_4257_4385("stackalloc {0}[{1}]", f_10582_4312_4323(), (DynAbs.Tracing.TraceSender.Conditional_F1(10582, 4325, 4351) || ((f_10582_4325_4351(f_10582_4325_4330()) && DynAbs.Tracing.TraceSender.Conditional_F2(10582, 4354, 4358)) || DynAbs.Tracing.TraceSender.Conditional_F3(10582, 4361, 4384))) ? null : f_10582_4361_4384(f_10582_4361_4366().Syntax)) : DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Display, 10582, 4388, 4400); DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 4237, 4400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 4237, 4400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 4237, 4400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10582_4241_4245()
        {
            var return_v = Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4241, 4245);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10582_4312_4323()
        {
            var return_v = ElementType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4312, 4323);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10582_4325_4330()
        {
            var return_v = Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4325, 4330);
            return return_v;
        }


        bool
        f_10582_4325_4351(Microsoft.CodeAnalysis.CSharp.BoundExpression
        this_param)
        {
            var return_v = this_param.WasCompilerGenerated;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4325, 4351);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10582_4361_4366()
        {
            var return_v = Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4361, 4366);
            return return_v;
        }


        string
        f_10582_4361_4384(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 4361, 4384);
            return return_v;
        }


        System.FormattableString
        f_10582_4257_4385(string
        format, params object?[]
        arguments)
        {
            var return_v = FormattableStringFactory.Create(format, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 4257, 4385);
            return return_v;
        }

    }
    internal partial class BoundUnconvertedSwitchExpression
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 4532, 4615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 4535, 4615);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10582, 4535, 4549) || (((f_10582_4536_4540() is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10582, 4552, 4600)) || DynAbs.Tracing.TraceSender.Conditional_F3(10582, 4603, 4615))) ? f_10582_4552_4600(MessageID.IDS_FeatureSwitchExpression) : DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Display, 10582, 4603, 4615); DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 4532, 4615);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 4532, 4615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 4532, 4615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundUnconvertedSwitchExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10582, 4416, 4623);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10582, 4416, 4623);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 4416, 4623);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10582, 4416, 4623);

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10582_4536_4540()
        {
            var return_v = Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4536, 4540);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
        f_10582_4552_4600(Microsoft.CodeAnalysis.CSharp.MessageID
        id)
        {
            var return_v = id.Localize();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 4552, 4600);
            return return_v;
        }

    }
    internal partial class BoundUnconvertedConditionalOperator
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 4750, 4839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 4753, 4839);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10582, 4753, 4767) || (((f_10582_4754_4758() is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10582, 4770, 4824)) || DynAbs.Tracing.TraceSender.Conditional_F3(10582, 4827, 4839))) ? f_10582_4770_4824(MessageID.IDS_FeatureTargetTypedConditional) : DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Display, 10582, 4827, 4839); DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 4750, 4839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 4750, 4839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 4750, 4839);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10582_4754_4758()
        {
            var return_v = Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4754, 4758);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
        f_10582_4770_4824(Microsoft.CodeAnalysis.CSharp.MessageID
        id)
        {
            var return_v = id.Localize();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 4770, 4824);
            return return_v;
        }

    }
    internal partial class BoundPassByCopy
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 4941, 4962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 4944, 4962);
                    return f_10582_4944_4962(f_10582_4944_4954()); DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 4941, 4962);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 4941, 4962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 4941, 4962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10582_4944_4954()
        {
            var return_v = Expression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4944, 4954);
            return return_v;
        }


        object
        f_10582_4944_4962(Microsoft.CodeAnalysis.CSharp.BoundExpression
        this_param)
        {
            var return_v = this_param.Display;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 4944, 4962);
            return return_v;
        }

    }
    internal partial class BoundUnconvertedAddressOfOperator
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 5082, 5141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5085, 5141);
                    return f_10582_5085_5141("&{0}", f_10582_5125_5140(f_10582_5125_5132())); DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 5082, 5141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 5082, 5141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 5082, 5141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundUnconvertedAddressOfOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10582, 4978, 5149);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10582, 4978, 5149);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 4978, 5149);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10582, 4978, 5149);

        Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
        f_10582_5125_5132()
        {
            var return_v = Operand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 5125, 5132);
            return return_v;
        }


        object
        f_10582_5125_5140(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
        this_param)
        {
            var return_v = this_param.Display;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 5125, 5140);
            return return_v;
        }


        System.FormattableString
        f_10582_5085_5141(string
        format, params object?[]
        arguments)
        {
            var return_v = FormattableStringFactory.Create(format, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 5085, 5141);
            return return_v;
        }

    }
    internal partial class BoundUnconvertedObjectCreationExpression
    {
        public override object Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10582, 5292, 6287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5328, 5359);

                    var
                    arguments = f_10582_5344_5358(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5377, 5478) || true) && (arguments.Length == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10582, 5377, 5478);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5444, 5459);

                        return "new()";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10582, 5377, 5478);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5498, 5552);

                    var
                    pooledBuilder = f_10582_5518_5551()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5570, 5606);

                    var
                    builder = pooledBuilder.Builder
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5624, 5676);

                    var
                    argumentDisplays = new object[arguments.Length]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5696, 5718);

                    f_10582_5696_5717(
                                    builder, "new");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5736, 5756);

                    f_10582_5736_5755(builder, '(');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5774, 5796);

                    f_10582_5774_5795(builder, "{0}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5814, 5857);

                    argumentDisplays[0] = f_10582_5836_5856(arguments[0]);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5886, 5891);

                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5877, 6084) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5915, 5918)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10582, 5877, 6084))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10582, 5877, 6084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 5960, 6000);

                            f_10582_5960_5999(builder, $", {{{f_10582_5982_5994(i)}}}");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 6022, 6065);

                            argumentDisplays[i] = f_10582_6044_6064(arguments[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10582, 1, 208);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10582, 1, 208);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 6104, 6124);

                    f_10582_6104_6123(
                                    builder, ')');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 6144, 6189);

                    var
                    format = f_10582_6157_6188(pooledBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10582, 6207, 6272);

                    return f_10582_6214_6271(format, argumentDisplays);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10582, 5292, 6287);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10582_5344_5358(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedObjectCreationExpression
                    this_param)
                    {
                        var return_v = this_param.Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 5344, 5358);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_10582_5518_5551()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 5518, 5551);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_5696_5717(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 5696, 5717);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_5736_5755(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 5736, 5755);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_5774_5795(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 5774, 5795);
                        return return_v;
                    }


                    object
                    f_10582_5836_5856(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Display;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 5836, 5856);
                        return return_v;
                    }


                    string
                    f_10582_5982_5994(int
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 5982, 5994);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_5960_5999(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 5960, 5999);
                        return return_v;
                    }


                    object
                    f_10582_6044_6064(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Display;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10582, 6044, 6064);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10582_6104_6123(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 6104, 6123);
                        return return_v;
                    }


                    string
                    f_10582_6157_6188(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToStringAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 6157, 6188);
                        return return_v;
                    }


                    System.FormattableString
                    f_10582_6214_6271(string
                    format, params object[]
                    arguments)
                    {
                        var return_v = FormattableStringFactory.Create(format, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10582, 6214, 6271);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10582, 5237, 6298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 5237, 6298);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static BoundUnconvertedObjectCreationExpression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10582, 5157, 6305);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10582, 5157, 6305);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10582, 5157, 6305);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10582, 5157, 6305);
    }
}
