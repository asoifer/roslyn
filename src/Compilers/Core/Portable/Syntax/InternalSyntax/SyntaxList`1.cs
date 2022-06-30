// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal partial struct SyntaxList<TNode> : IEquatable<SyntaxList<TNode>>
            where TNode : GreenNode
    {

        private readonly GreenNode? _node;

        internal SyntaxList(GreenNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(834, 509, 594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 570, 583);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(834, 509, 594);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 509, 594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 509, 594);
            }
        }

        internal GreenNode? Node
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 631, 639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 634, 639);
                    return _node; DynAbs.Tracing.TraceSender.TraceExitMethod(834, 631, 639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 631, 639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 631, 639);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 693, 808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 729, 793);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(834, 736, 749) || ((_node == null && DynAbs.Tracing.TraceSender.Conditional_F2(834, 752, 753)) || DynAbs.Tracing.TraceSender.Conditional_F3(834, 756, 792))) ? 0 : ((DynAbs.Tracing.TraceSender.Conditional_F1(834, 757, 769) || ((f_834_757_769(_node) && DynAbs.Tracing.TraceSender.Conditional_F2(834, 772, 787)) || DynAbs.Tracing.TraceSender.Conditional_F3(834, 790, 791))) ? f_834_772_787(_node) : 1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(834, 693, 808);

                    bool
                    f_834_757_769(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(834, 757, 769);
                        return return_v;
                    }


                    int
                    f_834_772_787(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(834, 772, 787);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 652, 819);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 652, 819);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TNode? this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 885, 1510);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 921, 1495) || true) && (_node == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 921, 1495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 980, 992);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(834, 921, 1495);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 921, 1495);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1034, 1495) || true) && (f_834_1038_1050(_node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 1034, 1495);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1092, 1117);

                            f_834_1092_1116(index >= 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1139, 1178);

                            f_834_1139_1177(index <= f_834_1161_1176(_node));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1202, 1238);

                            return (TNode?)f_834_1217_1237(_node, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(834, 1034, 1495);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 1034, 1495);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1280, 1495) || true) && (index == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 1280, 1495);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1336, 1357);

                                return (TNode?)_node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(834, 1280, 1495);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 1280, 1495);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1439, 1476);

                                throw f_834_1445_1475();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(834, 1280, 1495);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(834, 1034, 1495);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(834, 921, 1495);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(834, 885, 1510);

                    bool
                    f_834_1038_1050(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(834, 1038, 1050);
                        return return_v;
                    }


                    int
                    f_834_1092_1116(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 1092, 1116);
                        return 0;
                    }


                    int
                    f_834_1161_1176(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(834, 1161, 1176);
                        return return_v;
                    }


                    int
                    f_834_1139_1177(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 1139, 1177);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_834_1217_1237(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 1217, 1237);
                        return return_v;
                    }


                    System.Exception
                    f_834_1445_1475()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(834, 1445, 1475);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 885, 1510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 885, 1510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TNode GetRequiredItem(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 1533, 1708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1599, 1622);

                var
                node = this[index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1636, 1671);

                f_834_1636_1670(node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1685, 1697);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(834, 1533, 1708);

                int
                f_834_1636_1670(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 1636, 1670);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 1533, 1708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 1533, 1708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GreenNode? ItemUntyped(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 1720, 2042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1787, 1823);

                f_834_1787_1822(_node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1837, 1859);

                var
                node = this._node
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1873, 1964) || true) && (f_834_1877_1888(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 1873, 1964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1922, 1949);

                    return f_834_1929_1948(node, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(834, 1873, 1964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 1980, 2005);

                f_834_1980_2004(index == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2019, 2031);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(834, 1720, 2042);

                int
                f_834_1787_1822(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 1787, 1822);
                    return 0;
                }


                bool
                f_834_1877_1888(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(834, 1877, 1888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_834_1929_1948(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 1929, 1948);
                    return return_v;
                }


                int
                f_834_1980_2004(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 1980, 2004);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 1720, 2042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 1720, 2042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Any()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 2054, 2128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2096, 2117);

                return _node != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(834, 2054, 2128);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 2054, 2128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 2054, 2128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Any(int kind)
        {
            foreach (var element in this)
            {
                if (element.RawKind == kind)
                {
                    return true;
                }
            }

            return false;
        }

        internal TNode[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 2466, 2720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2502, 2534);

                    var
                    arr = new TNode[this.Count]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2561, 2566);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2552, 2676) || true) && (i < this.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2584, 2587)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(834, 2552, 2676))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 2552, 2676);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2629, 2657);

                            arr[i] = GetRequiredItem(i);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(834, 1, 125);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(834, 1, 125);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2694, 2705);

                    return arr;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(834, 2466, 2720);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 2419, 2731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 2419, 2731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TNode? Last
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 2786, 3095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2822, 2858);

                    f_834_2822_2857(_node is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2876, 2898);

                    var
                    node = this._node
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2916, 3040) || true) && (f_834_2920_2931(node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 2916, 3040);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 2973, 3021);

                        return (TNode?)f_834_2988_3020(node, f_834_3001_3015(node) - 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(834, 2916, 3040);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 3060, 3080);

                    return (TNode?)node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(834, 2786, 3095);

                    int
                    f_834_2822_2857(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 2822, 2857);
                        return 0;
                    }


                    bool
                    f_834_2920_2931(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(834, 2920, 2931);
                        return return_v;
                    }


                    int
                    f_834_3001_3015(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(834, 3001, 3015);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_834_2988_3020(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 2988, 3020);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 2743, 3106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 2743, 3106);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        internal void CopyTo(int offset, ArrayElement<GreenNode>[] array, int arrayOffset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 3227, 3494);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 3354, 3359);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 3345, 3483) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 3372, 3375)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(834, 3345, 3483))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(834, 3345, 3483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 3409, 3468);

                        array[arrayOffset + i].Value = GetRequiredItem(i + offset);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(834, 1, 139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(834, 1, 139);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(834, 3227, 3494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 3227, 3494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 3227, 3494);
            }
        }

        public static bool operator ==(SyntaxList<TNode> left, SyntaxList<TNode> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(834, 3506, 3654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 3610, 3643);

                return left._node == right._node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(834, 3506, 3654);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 3506, 3654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 3506, 3654);
            }
        }

        public static bool operator !=(SyntaxList<TNode> left, SyntaxList<TNode> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(834, 3666, 3814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 3770, 3803);

                return left._node != right._node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(834, 3666, 3814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 3666, 3814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 3666, 3814);
            }
        }

        public bool Equals(SyntaxList<TNode> other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 3826, 3933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 3894, 3922);

                return _node == other._node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(834, 3826, 3933);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 3826, 3933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 3826, 3933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 3945, 4089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 4010, 4078);

                return (obj is SyntaxList<TNode>) && (DynAbs.Tracing.TraceSender.Expression_True(834, 4017, 4077) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(834, 3945, 4089);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 3945, 4089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 3945, 4089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 4101, 4217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 4159, 4206);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(834, 4166, 4179) || ((_node != null && DynAbs.Tracing.TraceSender.Conditional_F2(834, 4182, 4201)) || DynAbs.Tracing.TraceSender.Conditional_F3(834, 4204, 4205))) ? f_834_4182_4201(_node) : 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(834, 4101, 4217);

                int
                f_834_4182_4201(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 4182, 4201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 4101, 4217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 4101, 4217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TOther> AsSeparatedList<TOther>() where TOther : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(834, 4229, 4395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 4339, 4384);

                return f_834_4346_4383(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(834, 4229, 4395);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TOther>
                f_834_4346_4383(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TOther>((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 4346, 4383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 4229, 4395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 4229, 4395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator SyntaxList<TNode>(TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(834, 4407, 4539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 4493, 4528);

                return f_834_4500_4527(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(834, 4407, 4539);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                f_834_4500_4527(TNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>((Microsoft.CodeAnalysis.GreenNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 4500, 4527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 4407, 4539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 4407, 4539);
            }
        }
        public static implicit operator SyntaxList<TNode>(SyntaxList<GreenNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(834, 4551, 4707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 4654, 4696);

                return f_834_4661_4695(nodes._node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(834, 4551, 4707);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                f_834_4661_4695(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 4661, 4695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 4551, 4707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 4551, 4707);
            }
        }
        public static implicit operator SyntaxList<GreenNode>(SyntaxList<TNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(834, 4719, 4878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(834, 4822, 4867);

                return f_834_4829_4866(nodes.Node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(834, 4719, 4878);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_834_4829_4866(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(834, 4829, 4866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(834, 4719, 4878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 4719, 4878);
            }
        }
        static SyntaxList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(834, 340, 4885);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(834, 340, 4885);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(834, 340, 4885);
        }
    }
}
