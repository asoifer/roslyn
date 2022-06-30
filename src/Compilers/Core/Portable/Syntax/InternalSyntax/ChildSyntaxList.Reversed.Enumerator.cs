// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal partial struct ChildSyntaxList
    {

        internal partial struct Reversed
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
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(820, 674, 1244);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 751, 1145) || true) && (node != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 751, 1145);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 817, 830);

                            _node = node;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 856, 885);

                            _childIndex = f_820_870_884(node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 911, 927);

                            _listIndex = -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(820, 751, 1145);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 751, 1145);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1025, 1038);

                            _node = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1064, 1080);

                            _childIndex = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1106, 1122);

                            _listIndex = -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(820, 751, 1145);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1169, 1182);

                        _list = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1204, 1225);

                        _currentChild = null;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(820, 674, 1244);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(820, 674, 1244);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(820, 674, 1244);
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(820, 1264, 3179);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1327, 3080) || true) && (_node != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 1327, 3080);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1394, 1793) || true) && (_list != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 1394, 1793);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1469, 1675) || true) && (--_listIndex >= 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 1469, 1675);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1556, 1598);

                                    _currentChild = f_820_1572_1597(_list, _listIndex);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1632, 1644);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(820, 1469, 1675);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1707, 1720);

                                _list = null;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1750, 1766);

                                _listIndex = -1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(820, 1394, 1793);
                            }
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1821, 3057) || true) && (--_childIndex >= 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 1821, 3057);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1904, 1943);

                                    var
                                    child = f_820_1916_1942(_node, _childIndex)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 1973, 2096) || true) && (child == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 1973, 2096);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2056, 2065);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(820, 1973, 2096);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2128, 2986) || true) && (f_820_2132_2144(child))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 2128, 2986);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2210, 2224);

                                        _list = child;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2258, 2287);

                                        _listIndex = f_820_2271_2286(_list);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2321, 2803) || true) && (--_listIndex >= 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 2321, 2803);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2416, 2458);

                                            _currentChild = f_820_2432_2457(_list, _listIndex);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2496, 2508);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(820, 2321, 2803);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 2321, 2803);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2654, 2667);

                                            _list = null;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2705, 2721);

                                            _listIndex = -1;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2759, 2768);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(820, 2321, 2803);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(820, 2128, 2986);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(820, 2128, 2986);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 2933, 2955);

                                        _currentChild = child;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(820, 2128, 2986);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 3018, 3030);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(820, 1821, 3057);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(820, 1821, 3057);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(820, 1821, 3057);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(820, 1327, 3080);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 3104, 3125);

                        _currentChild = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 3147, 3160);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(820, 1264, 3179);

                        Microsoft.CodeAnalysis.GreenNode?
                        f_820_1572_1597(Microsoft.CodeAnalysis.GreenNode
                        this_param, int
                        index)
                        {
                            var return_v = this_param.GetSlot(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(820, 1572, 1597);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.GreenNode?
                        f_820_1916_1942(Microsoft.CodeAnalysis.GreenNode
                        this_param, int
                        index)
                        {
                            var return_v = this_param.GetSlot(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(820, 1916, 1942);
                            return return_v;
                        }


                        bool
                        f_820_2132_2144(Microsoft.CodeAnalysis.GreenNode
                        this_param)
                        {
                            var return_v = this_param.IsList;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(820, 2132, 2144);
                            return return_v;
                        }


                        int
                        f_820_2271_2286(Microsoft.CodeAnalysis.GreenNode
                        this_param)
                        {
                            var return_v = this_param.SlotCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(820, 2271, 2286);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.GreenNode?
                        f_820_2432_2457(Microsoft.CodeAnalysis.GreenNode
                        this_param, int
                        index)
                        {
                            var return_v = this_param.GetSlot(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(820, 2432, 2457);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(820, 1264, 3179);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(820, 1264, 3179);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public GreenNode Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(820, 3264, 3294);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(820, 3270, 3292);

                            return _currentChild!;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(820, 3264, 3294);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(820, 3199, 3313);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(820, 3199, 3313);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }
                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(820, 384, 3328);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(820, 384, 3328);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(820, 384, 3328);
                }

                static int
                f_820_870_884(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(820, 870, 884);
                    return return_v;
                }

            }
        }
    }
}
