// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal partial struct ChildSyntaxList
    {

        internal struct Enumerator
        {

            private readonly GreenNode? _node;

            private int _childIndex;

            private GreenNode? _list;

            private int _listIndex;

            private GreenNode? _currentChild;

            internal Enumerator(GreenNode? node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(818, 589, 825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 658, 671);

                    _node = node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 689, 706);

                    _childIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 724, 740);

                    _listIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 758, 771);

                    _list = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 789, 810);

                    _currentChild = null;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(818, 589, 825);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(818, 589, 825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(818, 589, 825);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(818, 841, 2825);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 896, 2738) || true) && (_node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 896, 2738);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 955, 1370) || true) && (_list != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 955, 1370);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1022, 1035);

                            _listIndex++;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1063, 1264) || true) && (_listIndex < f_818_1080_1095(_list))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 1063, 1264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1153, 1195);

                                _currentChild = f_818_1169_1194(_list, _listIndex);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1225, 1237);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(818, 1063, 1264);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1292, 1305);

                            _list = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1331, 1347);

                            _listIndex = -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(818, 955, 1370);
                        }
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1394, 2719) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 1394, 2719);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1455, 1469);

                                _childIndex++;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1497, 1622) || true) && (_childIndex == f_818_1516_1531(_node))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 1497, 1622);
                                    DynAbs.Tracing.TraceSender.TraceBreak(818, 1589, 1595);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(818, 1497, 1622);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1650, 1689);

                                var
                                child = f_818_1662_1688(_node, _childIndex)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1715, 1826) || true) && (child == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 1715, 1826);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1790, 1799);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(818, 1715, 1826);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1854, 2656) || true) && (f_818_1858_1871(child) == GreenNode.ListKind)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 1854, 2656);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1951, 1965);

                                    _list = child;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 1995, 2008);

                                    _listIndex++;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2040, 2493) || true) && (_listIndex < f_818_2057_2072(_list))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 2040, 2493);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2138, 2180);

                                        _currentChild = f_818_2154_2179(_list, _listIndex);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2214, 2226);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(818, 2040, 2493);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 2040, 2493);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2356, 2369);

                                        _list = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2403, 2419);

                                        _listIndex = -1;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2453, 2462);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(818, 2040, 2493);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(818, 1854, 2656);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(818, 1854, 2656);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2607, 2629);

                                    _currentChild = child;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(818, 1854, 2656);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2684, 2696);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(818, 1394, 2719);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(818, 1394, 2719);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(818, 1394, 2719);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(818, 896, 2738);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2758, 2779);

                    _currentChild = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2797, 2810);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(818, 841, 2825);

                    int
                    f_818_1080_1095(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(818, 1080, 1095);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_818_1169_1194(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(818, 1169, 1194);
                        return return_v;
                    }


                    int
                    f_818_1516_1531(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(818, 1516, 1531);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_818_1662_1688(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(818, 1662, 1688);
                        return return_v;
                    }


                    int
                    f_818_1858_1871(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.RawKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(818, 1858, 1871);
                        return return_v;
                    }


                    int
                    f_818_2057_2072(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(818, 2057, 2072);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_818_2154_2179(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(818, 2154, 2179);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(818, 841, 2825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(818, 841, 2825);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreenNode Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(818, 2898, 2928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(818, 2904, 2926);

                        return _currentChild!;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(818, 2898, 2928);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(818, 2841, 2943);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(818, 2841, 2943);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(818, 327, 2954);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(818, 327, 2954);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(818, 327, 2954);
            }
        }
    }
}
