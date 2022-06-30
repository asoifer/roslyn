// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal partial class SyntaxList
    {
        internal abstract class WithManyChildrenBase : SyntaxList
        {
            internal readonly ArrayElement<GreenNode>[] children;

            internal WithManyChildrenBase(ArrayElement<GreenNode>[] children)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(827, 541, 723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 516, 524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 639, 664);

                    this.children = children;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 682, 708);

                    f_827_682_707(this);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(827, 541, 723);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 541, 723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 541, 723);
                }
            }

            internal WithManyChildrenBase(DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations, ArrayElement<GreenNode>[] children)
            : base(f_827_893_904_C(diagnostics), annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(827, 739, 1035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 516, 524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 951, 976);

                    this.children = children;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 994, 1020);

                    f_827_994_1019(this);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(827, 739, 1035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 739, 1035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 739, 1035);
                }
            }

            private void InitializeChildren()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 1051, 1553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1117, 1141);

                    int
                    n = f_827_1125_1140(children)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1159, 1379) || true) && (n < byte.MaxValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 1159, 1379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1222, 1247);

                        this.SlotCount = (byte)n;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(827, 1159, 1379);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 1159, 1379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1329, 1360);

                        this.SlotCount = byte.MaxValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(827, 1159, 1379);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1408, 1413);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1399, 1538) || true) && (i < f_827_1419_1434(children))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1436, 1439)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(827, 1399, 1538))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 1399, 1538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1481, 1519);

                            f_827_1481_1518(this, children[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(827, 1, 140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(827, 1, 140);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 1051, 1553);

                    int
                    f_827_1125_1140(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 1125, 1140);
                        return return_v;
                    }


                    int
                    f_827_1419_1434(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 1419, 1434);
                        return return_v;
                    }


                    int
                    f_827_1481_1518(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    this_param, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>
                    node)
                    {
                        this_param.AdjustFlagsAndWidth((Microsoft.CodeAnalysis.GreenNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 1481, 1518);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 1051, 1553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 1051, 1553);
                }
            }

            internal WithManyChildrenBase(ObjectReader reader)
            : base(f_827_1644_1650_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(827, 1569, 2014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 516, 524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1684, 1716);

                    var
                    length = f_827_1697_1715(reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1736, 1788);

                    this.children = new ArrayElement<GreenNode>[length];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1815, 1820);
                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1806, 1953) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1834, 1837)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(827, 1806, 1953))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 1806, 1953);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1879, 1934);

                            this.children[i].Value = (GreenNode)f_827_1915_1933(reader);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(827, 1, 148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(827, 1, 148);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 1973, 1999);

                    f_827_1973_1998(
                                    this);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(827, 1569, 2014);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 1569, 2014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 1569, 2014);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 2030, 2554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2114, 2135);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 827, 2114, 2134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2331, 2371);

                    f_827_2331_2370(
                                    // PERF: Write the array out manually.Profiling shows that this is cheaper than converting to 
                                    // an array in order to use writer.WriteValue.
                                    writer, f_827_2349_2369(this.children));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2400, 2405);

                        for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2391, 2539) || true) && (i < f_827_2411_2431(this.children))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2433, 2436)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(827, 2391, 2539))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 2391, 2539);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2478, 2520);

                            f_827_2478_2519(writer, this.children[i].Value);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(827, 1, 149);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(827, 1, 149);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 2030, 2554);

                    int
                    f_827_2349_2369(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 2349, 2369);
                        return return_v;
                    }


                    int
                    f_827_2331_2370(Roslyn.Utilities.ObjectWriter
                    this_param, int
                    value)
                    {
                        this_param.WriteInt32(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 2331, 2370);
                        return 0;
                    }


                    int
                    f_827_2411_2431(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 2411, 2431);
                        return return_v;
                    }


                    int
                    f_827_2478_2519(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 2478, 2519);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 2030, 2554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 2030, 2554);
                }
            }

            protected override int GetSlotCount()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 2570, 2678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2640, 2663);

                    return f_827_2647_2662(children);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 2570, 2678);

                    int
                    f_827_2647_2662(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 2647, 2662);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 2570, 2678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 2570, 2678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode GetSlot(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 2694, 2816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2773, 2801);

                    return this.children[index];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 2694, 2816);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 2694, 2816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 2694, 2816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override void CopyTo(ArrayElement<GreenNode>[] array, int offset)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 2832, 3020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 2939, 3005);

                    f_827_2939_3004(this.children, 0, array, offset, f_827_2983_3003(this.children));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 2832, 3020);

                    int
                    f_827_2983_3003(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 2983, 3003);
                        return return_v;
                    }


                    int
                    f_827_2939_3004(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    sourceArray, int
                    sourceIndex, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    destinationArray, int
                    destinationIndex, int
                    length)
                    {
                        Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 2939, 3004);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 2832, 3020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 2832, 3020);
                }
            }

            internal override SyntaxNode CreateRed(SyntaxNode? parent, int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 3036, 3872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 3141, 3201);

                    var
                    separated = f_827_3157_3171(this) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(827, 3157, 3200) && f_827_3179_3200(this))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 3219, 3857) || true) && (parent != null && (DynAbs.Tracing.TraceSender.Expression_True(827, 3223, 3270) && f_827_3241_3270(parent)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 3219, 3857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 3312, 3538);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(827, 3319, 3328) || ((separated
                        && DynAbs.Tracing.TraceSender.Conditional_F2(827, 3356, 3431)) || DynAbs.Tracing.TraceSender.Conditional_F3(827, 3459, 3537))) ? f_827_3356_3431(this, parent, position) : (SyntaxNode)f_827_3471_3537(this, parent, position);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(827, 3219, 3857);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 3219, 3857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 3620, 3838);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(827, 3627, 3636) || ((separated
                        && DynAbs.Tracing.TraceSender.Conditional_F2(827, 3664, 3735)) || DynAbs.Tracing.TraceSender.Conditional_F3(827, 3763, 3837))) ? f_827_3664_3735(this, parent, position) : (SyntaxNode)f_827_3775_3837(this, parent, position);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(827, 3219, 3857);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 3036, 3872);

                    int
                    f_827_3157_3171(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 3157, 3171);
                        return return_v;
                    }


                    bool
                    f_827_3179_3200(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    this_param)
                    {
                        var return_v = this_param.HasNodeTokenPattern();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 3179, 3200);
                        return return_v;
                    }


                    bool
                    f_827_3241_3270(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.ShouldCreateWeakList();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 3241, 3270);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.SyntaxList.SeparatedWithManyWeakChildren
                    f_827_3356_3431(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    green, Microsoft.CodeAnalysis.SyntaxNode
                    parent, int
                    position)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxList.SeparatedWithManyWeakChildren((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList)green, parent, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 3356, 3431);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.SyntaxList.WithManyWeakChildren
                    f_827_3471_3537(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    green, Microsoft.CodeAnalysis.SyntaxNode
                    parent, int
                    position)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxList.WithManyWeakChildren(green, parent, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 3471, 3537);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.SyntaxList.SeparatedWithManyChildren
                    f_827_3664_3735(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    green, Microsoft.CodeAnalysis.SyntaxNode?
                    parent, int
                    position)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxList.SeparatedWithManyChildren((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList)green, parent, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 3664, 3735);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.SyntaxList.WithManyChildren
                    f_827_3775_3837(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    green, Microsoft.CodeAnalysis.SyntaxNode?
                    parent, int
                    position)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxList.WithManyChildren((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList)green, parent, position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 3775, 3837);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 3036, 3872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 3036, 3872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool HasNodeTokenPattern()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 3888, 4314);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 3964, 3969);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 3955, 4267) || true) && (i < f_827_3975_3989(this))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 3991, 3994)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(827, 3955, 4267))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 3955, 4267);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 4117, 4248) || true) && (f_827_4121_4144(f_827_4121_4136(this, i)) == ((i & 1) == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(827, 4117, 4248);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 4212, 4225);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(827, 4117, 4248);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(827, 1, 313);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(827, 1, 313);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 4287, 4299);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 3888, 4314);

                    int
                    f_827_3975_3989(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 3975, 3989);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_827_4121_4136(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 4121, 4136);
                        return return_v;
                    }


                    bool
                    f_827_4121_4144(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(827, 4121, 4144);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 3888, 4314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 3888, 4314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static WithManyChildrenBase()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(827, 390, 4325);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(827, 390, 4325);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 390, 4325);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(827, 390, 4325);

            static int
            f_827_682_707(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
            this_param)
            {
                this_param.InitializeChildren();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 682, 707);
                return 0;
            }


            static int
            f_827_994_1019(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
            this_param)
            {
                this_param.InitializeChildren();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 994, 1019);
                return 0;
            }


            static Microsoft.CodeAnalysis.DiagnosticInfo[]?
            f_827_893_904_C(Microsoft.CodeAnalysis.DiagnosticInfo[]?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(827, 739, 1035);
                return return_v;
            }


            static int
            f_827_1697_1715(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadInt32();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 1697, 1715);
                return return_v;
            }


            static object
            f_827_1915_1933(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 1915, 1933);
                return return_v;
            }


            static int
            f_827_1973_1998(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildrenBase
            this_param)
            {
                this_param.InitializeChildren();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 1973, 1998);
                return 0;
            }


            static Roslyn.Utilities.ObjectReader
            f_827_1644_1650_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(827, 1569, 2014);
                return return_v;
            }

        }
        internal sealed class WithManyChildren : WithManyChildrenBase
        {
            static WithManyChildren()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(827, 4423, 4584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 4481, 4569);

                    f_827_4481_4568(typeof(WithManyChildren), r => new WithManyChildren(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(827, 4423, 4584);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 4423, 4584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 4423, 4584);
                }
            }

            internal WithManyChildren(ArrayElement<GreenNode>[] children)
            : base(f_827_4686_4694_C(children))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(827, 4600, 4725);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(827, 4600, 4725);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 4600, 4725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 4600, 4725);
                }
            }

            internal WithManyChildren(DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations, ArrayElement<GreenNode>[] children)
            : base(f_827_4891_4902_C(diagnostics), annotations, children)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(827, 4741, 4956);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(827, 4741, 4956);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 4741, 4956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 4741, 4956);
                }
            }

            internal WithManyChildren(ObjectReader reader)
            : base(f_827_5043_5049_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(827, 4972, 5080);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(827, 4972, 5080);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 4972, 5080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 4972, 5080);
                }
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[]? errors)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 5096, 5281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 5197, 5266);

                    return f_827_5204_5265(errors, f_827_5233_5254(this), children);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 5096, 5281);

                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_827_5233_5254(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildren
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 5233, 5254);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildren
                    f_827_5204_5265(Microsoft.CodeAnalysis.DiagnosticInfo[]?
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildren(diagnostics, annotations, children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 5204, 5265);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 5096, 5281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 5096, 5281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[]? annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(827, 5297, 5489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(827, 5405, 5474);

                    return f_827_5412_5473(f_827_5433_5449(this), annotations, children);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(827, 5297, 5489);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_827_5433_5449(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildren
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 5433, 5449);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildren
                    f_827_5412_5473(Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                    annotations, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildren(diagnostics, annotations, children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 5412, 5473);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(827, 5297, 5489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(827, 5297, 5489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(827, 4337, 5500);

            static int
            f_827_4481_4568(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(827, 4481, 4568);
                return 0;
            }


            static Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
            f_827_4686_4694_C(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(827, 4600, 4725);
                return return_v;
            }


            static Microsoft.CodeAnalysis.DiagnosticInfo[]?
            f_827_4891_4902_C(Microsoft.CodeAnalysis.DiagnosticInfo[]?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(827, 4741, 4956);
                return return_v;
            }


            static Roslyn.Utilities.ObjectReader
            f_827_5043_5049_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(827, 4972, 5080);
                return return_v;
            }

        }
    }
}
