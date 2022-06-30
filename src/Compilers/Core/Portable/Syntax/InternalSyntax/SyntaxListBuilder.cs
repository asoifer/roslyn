// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal class SyntaxListBuilder
    {
        private ArrayElement<GreenNode?>[] _nodes;

        public int Count { get; private set; }

        public SyntaxListBuilder(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(830, 466, 580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 399, 405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 416, 454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 525, 569);

                _nodes = new ArrayElement<GreenNode?>[size];
                DynAbs.Tracing.TraceSender.TraceExitConstructor(830, 466, 580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 466, 580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 466, 580);
            }
        }

        public static SyntaxListBuilder Create()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(830, 592, 700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 657, 689);

                return f_830_664_688(8);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(830, 592, 700);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_830_664_688(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 664, 688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 592, 700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 592, 700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 712, 782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 756, 771);

                this.Count = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 712, 782);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 712, 782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 712, 782);
            }
        }

        public GreenNode? this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 852, 924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 888, 909);

                    return _nodes[index];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(830, 852, 924);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 852, 924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 852, 924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 940, 1019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 976, 1004);

                    _nodes[index].Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(830, 940, 1019);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 940, 1019);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 940, 1019);
                }
            }
        }

        public void Add(GreenNode? item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 1042, 1661);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1099, 1124) || true) && (item == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 1099, 1124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1117, 1124);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(830, 1099, 1124);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1140, 1650) || true) && (f_830_1144_1155(item))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 1140, 1650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1189, 1220);

                    int
                    slotCount = f_830_1205_1219(item)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1315, 1351);

                    f_830_1315_1350(this, slotCount);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1380, 1385);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1371, 1492) || true) && (i < slotCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1402, 1405)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(830, 1371, 1492))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 1371, 1492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1447, 1473);

                            f_830_1447_1472(this, f_830_1456_1471(item, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(830, 1, 122);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(830, 1, 122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(830, 1140, 1650);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 1140, 1650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1558, 1586);

                    f_830_1558_1585(this, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1606, 1635);

                    _nodes[f_830_1613_1620_M(Count++)].Value = item;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(830, 1140, 1650);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 1042, 1661);

                bool
                f_830_1144_1155(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 1144, 1155);
                    return return_v;
                }


                int
                f_830_1205_1219(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 1205, 1219);
                    return return_v;
                }


                int
                f_830_1315_1350(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                additionalCount)
                {
                    this_param.EnsureAdditionalCapacity(additionalCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 1315, 1350);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_830_1456_1471(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 1456, 1471);
                    return return_v;
                }


                int
                f_830_1447_1472(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 1447, 1472);
                    return 0;
                }


                int
                f_830_1558_1585(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                additionalCount)
                {
                    this_param.EnsureAdditionalCapacity(additionalCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 1558, 1585);
                    return 0;
                }


                int
                f_830_1613_1620_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 1613, 1620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 1042, 1661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 1042, 1661);
            }
        }

        public void AddRange(GreenNode[] items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 1673, 1786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1737, 1775);

                f_830_1737_1774(this, items, 0, f_830_1761_1773(items));
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 1673, 1786);

                int
                f_830_1761_1773(Microsoft.CodeAnalysis.GreenNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 1761, 1773);
                    return return_v;
                }


                int
                f_830_1737_1774(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode[]
                items, int
                offset, int
                length)
                {
                    this_param.AddRange(items, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 1737, 1774);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 1673, 1786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 1673, 1786);
            }
        }

        public void AddRange(GreenNode[] items, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 1798, 2214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 1957, 1999);

                f_830_1957_1998(this, length - offset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2015, 2041);

                int
                oldCount = f_830_2030_2040(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2066, 2076);

                    for (int
        i = offset
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2057, 2156) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2090, 2093)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(830, 2057, 2156))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 2057, 2156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2127, 2141);

                        f_830_2127_2140(this, items[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(830, 1, 100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(830, 1, 100);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2172, 2203);

                f_830_2172_2202(this, oldCount, f_830_2191_2201(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 1798, 2214);

                int
                f_830_1957_1998(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                additionalCount)
                {
                    this_param.EnsureAdditionalCapacity(additionalCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 1957, 1998);
                    return 0;
                }


                int
                f_830_2030_2040(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 2030, 2040);
                    return return_v;
                }


                int
                f_830_2127_2140(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 2127, 2140);
                    return 0;
                }


                int
                f_830_2191_2201(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 2191, 2201);
                    return return_v;
                }


                int
                f_830_2172_2202(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                start, int
                end)
                {
                    this_param.Validate(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 2172, 2202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 1798, 2214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 1798, 2214);
            }
        }

        [Conditional("DEBUG")]
        private void Validate(int start, int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 2226, 2454);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2333, 2342);
                    for (int
        i = start
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2324, 2443) || true) && (i < end)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2353, 2356)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(830, 2324, 2443))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 2324, 2443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2390, 2428);

                        f_830_2390_2427(_nodes[i].Value != null);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(830, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(830, 1, 120);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 2226, 2454);

                int
                f_830_2390_2427(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 2390, 2427);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 2226, 2454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 2226, 2454);
            }
        }

        public void AddRange(SyntaxList<GreenNode> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 2466, 2585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2539, 2574);

                f_830_2539_2573(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 2466, 2585);

                int
                f_830_2539_2573(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                list, int
                offset, int
                length)
                {
                    this_param.AddRange(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 2539, 2573);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 2466, 2585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 2466, 2585);
            }
        }

        public void AddRange(SyntaxList<GreenNode> list, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 2597, 3021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2765, 2807);

                f_830_2765_2806(this, length - offset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2823, 2849);

                int
                oldCount = f_830_2838_2848(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2874, 2884);

                    for (int
        i = offset
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2865, 2963) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2898, 2901)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(830, 2865, 2963))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 2865, 2963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2935, 2948);

                        f_830_2935_2947(this, list[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(830, 1, 99);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(830, 1, 99);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 2979, 3010);

                f_830_2979_3009(this, oldCount, f_830_2998_3008(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 2597, 3021);

                int
                f_830_2765_2806(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                additionalCount)
                {
                    this_param.EnsureAdditionalCapacity(additionalCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 2765, 2806);
                    return 0;
                }


                int
                f_830_2838_2848(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 2838, 2848);
                    return return_v;
                }


                int
                f_830_2935_2947(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 2935, 2947);
                    return 0;
                }


                int
                f_830_2998_3008(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 2998, 3008);
                    return return_v;
                }


                int
                f_830_2979_3009(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                start, int
                end)
                {
                    this_param.Validate(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 2979, 3009);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 2597, 3021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 2597, 3021);
            }
        }

        public void AddRange<TNode>(SyntaxList<TNode> list) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 3033, 3179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3133, 3168);

                f_830_3133_3167(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 3033, 3179);

                int
                f_830_3133_3167(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                list, int
                offset, int
                length)
                {
                    this_param.AddRange<TNode>(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 3133, 3167);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 3033, 3179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 3033, 3179);
            }
        }

        public void AddRange<TNode>(SyntaxList<TNode> list, int offset, int length) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 3191, 3394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3315, 3383);

                f_830_3315_3382(this, f_830_3329_3365(list.Node), offset, length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 3191, 3394);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_830_3329_3365(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 3329, 3365);
                    return return_v;
                }


                int
                f_830_3315_3382(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                list, int
                offset, int
                length)
                {
                    this_param.AddRange(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 3315, 3382);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 3191, 3394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 3191, 3394);
            }
        }

        public void RemoveLast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 3406, 3515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3455, 3463);

                f_830_3455_3462_M(Count--);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3477, 3504);

                _nodes[f_830_3484_3489()].Value = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 3406, 3515);

                int
                f_830_3455_3462_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 3455, 3462);
                    return return_v;
                }


                int
                f_830_3484_3489()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 3484, 3489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 3406, 3515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 3406, 3515);
            }
        }

        private void EnsureAdditionalCapacity(int additionalCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 3527, 4105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3610, 3642);

                int
                currentSize = f_830_3628_3641(_nodes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3656, 3704);

                int
                requiredSize = f_830_3675_3685(this) + additionalCount
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3720, 3760) || true) && (requiredSize <= currentSize)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 3720, 3760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3753, 3760);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(830, 3720, 3760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 3776, 3956);

                int
                newSize =
                (DynAbs.Tracing.TraceSender.Conditional_F1(830, 3807, 3823) || ((requiredSize < 8 && DynAbs.Tracing.TraceSender.Conditional_F2(830, 3826, 3827)) || DynAbs.Tracing.TraceSender.Conditional_F3(830, 3847, 3955))) ? 8 : (DynAbs.Tracing.TraceSender.Conditional_F1(830, 3847, 3881) || ((requiredSize >= (int.MaxValue / 2) && DynAbs.Tracing.TraceSender.Conditional_F2(830, 3884, 3896)) || DynAbs.Tracing.TraceSender.Conditional_F3(830, 3916, 3955))) ? int.MaxValue : f_830_3916_3955(requiredSize, currentSize * 2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4006, 4044);

                f_830_4006_4043(newSize >= requiredSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4060, 4094);

                f_830_4060_4093(ref _nodes, newSize);
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 3527, 4105);

                int
                f_830_3628_3641(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 3628, 3641);
                    return return_v;
                }


                int
                f_830_3675_3685(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 3675, 3685);
                    return return_v;
                }


                int
                f_830_3916_3955(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 3916, 3955);
                    return return_v;
                }


                int
                f_830_4006_4043(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 4006, 4043);
                    return 0;
                }


                int
                f_830_4060_4093(ref Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 4060, 4093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 3527, 4105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 3527, 4105);
            }
        }

        public bool Any(int kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 4117, 4395);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4176, 4181);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4167, 4355) || true) && (i < f_830_4187_4192())
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4194, 4197)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(830, 4167, 4355))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 4167, 4355);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4231, 4340) || true) && (f_830_4235_4259(_nodes[i].Value!) == kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 4231, 4340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4309, 4321);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(830, 4231, 4340);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(830, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(830, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4371, 4384);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 4117, 4395);

                int
                f_830_4187_4192()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 4187, 4192);
                    return return_v;
                }


                int
                f_830_4235_4259(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 4235, 4259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 4117, 4395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 4117, 4395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GreenNode[] ToArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 4407, 4660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4460, 4498);

                var
                array = new GreenNode[f_830_4486_4496(this)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4521, 4526);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4512, 4620) || true) && (i < f_830_4532_4544(array))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4546, 4549)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(830, 4512, 4620))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 4512, 4620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4583, 4605);

                        array[i] = _nodes[i]!;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(830, 1, 109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(830, 1, 109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4636, 4649);

                return array;
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 4407, 4660);

                int
                f_830_4486_4496(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 4486, 4496);
                    return return_v;
                }


                int
                f_830_4532_4544(Microsoft.CodeAnalysis.GreenNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 4532, 4544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 4407, 4660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 4407, 4660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GreenNode? ToListNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 4672, 5318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4729, 5307);

                switch (f_830_4737_4747(this))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 4729, 5307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4810, 4822);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(830, 4729, 5307);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 4729, 5307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4869, 4886);

                        return _nodes[0];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(830, 4729, 5307);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 4729, 5307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 4933, 4980);

                        return f_830_4940_4979(_nodes[0]!, _nodes[1]!);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(830, 4729, 5307);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 4729, 5307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 5027, 5086);

                        return f_830_5034_5085(_nodes[0]!, _nodes[1]!, _nodes[2]!);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(830, 4729, 5307);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(830, 4729, 5307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 5134, 5184);

                        var
                        tmp = new ArrayElement<GreenNode>[f_830_5172_5182(this)]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 5206, 5242);

                        f_830_5206_5241(_nodes, tmp, f_830_5230_5240(this));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 5264, 5292);

                        return f_830_5271_5291(tmp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(830, 4729, 5307);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 4672, 5318);

                int
                f_830_4737_4747(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 4737, 4747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_830_4940_4979(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>
                child0, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>
                child1)
                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode)child0, (Microsoft.CodeAnalysis.GreenNode)child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 4940, 4979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_830_5034_5085(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>
                child0, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>
                child1, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>
                child2)
                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode)child0, (Microsoft.CodeAnalysis.GreenNode)child1, (Microsoft.CodeAnalysis.GreenNode)child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 5034, 5085);
                    return return_v;
                }


                int
                f_830_5172_5182(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 5172, 5182);
                    return return_v;
                }


                int
                f_830_5230_5240(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(830, 5230, 5240);
                    return return_v;
                }


                int
                f_830_5206_5241(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                sourceArray, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 5206, 5241);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_830_5271_5291(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = SyntaxList.List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 5271, 5291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 4672, 5318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 4672, 5318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<GreenNode> ToList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 5330, 5450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 5392, 5439);

                return f_830_5399_5438(f_830_5425_5437(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 5330, 5450);

                Microsoft.CodeAnalysis.GreenNode?
                f_830_5425_5437(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 5425, 5437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_830_5399_5438(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 5399, 5438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 5330, 5450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 5330, 5450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<TNode> ToList<TNode>() where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(830, 5462, 5605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(830, 5551, 5594);

                return f_830_5558_5593(f_830_5580_5592(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(830, 5462, 5605);

                Microsoft.CodeAnalysis.GreenNode?
                f_830_5580_5592(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 5580, 5592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                f_830_5558_5593(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(830, 5558, 5593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(830, 5462, 5605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 5462, 5605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(830, 315, 5612);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(830, 315, 5612);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(830, 315, 5612);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(830, 315, 5612);
    }
}
