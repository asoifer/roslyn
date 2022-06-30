// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public readonly partial struct ChildSyntaxList : IEquatable<ChildSyntaxList>, IReadOnlyList<SyntaxNodeOrToken>
    {

        private readonly SyntaxNode? _node;

        private readonly int _count;

        internal ChildSyntaxList(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(657, 612, 748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 678, 691);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 705, 737);

                _count = CountNodes(f_657_725_735(node));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(657, 612, 748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 612, 748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 612, 748);
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 937, 1002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 973, 987);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(657, 937, 1002);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 896, 1013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 896, 1013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static int CountNodes(GreenNode green)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(657, 1025, 1593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1097, 1107);

                int
                n = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1132, 1137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1139, 1158);

                    for (int
        i = 0
        ,
        s = f_657_1143_1158(green)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1123, 1557) || true) && (i < s)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1167, 1170)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(657, 1123, 1557))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 1123, 1557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1204, 1233);

                        var
                        child = f_657_1216_1232(green, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1251, 1542) || true) && (child != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 1251, 1542);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1310, 1523) || true) && (f_657_1314_1327_M(!child.IsList))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 1310, 1523);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1377, 1381);

                                n++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(657, 1310, 1523);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 1310, 1523);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1479, 1500);

                                n += f_657_1484_1499(child);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(657, 1310, 1523);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(657, 1251, 1542);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(657, 1, 435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(657, 1, 435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 1573, 1582);

                return n;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(657, 1025, 1593);

                int
                f_657_1143_1158(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 1143, 1158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_657_1216_1232(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 1216, 1232);
                    return return_v;
                }


                bool
                f_657_1314_1327_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 1314, 1327);
                    return return_v;
                }


                int
                f_657_1484_1499(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 1484, 1499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 1025, 1593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 1025, 1593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>Gets the child at the specified index.</summary>
        /// <param name="index">The zero-based index of the child to get.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        ///   <paramref name="index"/> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="ChildSyntaxList.Count"/>. </exception>
        public SyntaxNodeOrToken this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 2054, 2315);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2090, 2227) || true) && (unchecked((uint)index < (uint)_count))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 2090, 2227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2173, 2208);

                        return ItemInternal(_node!, index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(657, 2090, 2227);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2247, 2300);

                    throw f_657_2253_2299(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(657, 2054, 2315);

                    System.ArgumentOutOfRangeException
                    f_657_2253_2299(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 2253, 2299);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 2054, 2315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 2054, 2315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxNode? Node
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 2388, 2409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2394, 2407);

                    return _node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(657, 2388, 2409);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 2338, 2420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 2338, 2420);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static int Occupancy(GreenNode green)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(657, 2432, 2555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2502, 2544);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(657, 2509, 2521) || ((f_657_2509_2521(green) && DynAbs.Tracing.TraceSender.Conditional_F2(657, 2524, 2539)) || DynAbs.Tracing.TraceSender.Conditional_F3(657, 2542, 2543))) ? f_657_2524_2539(green) : 1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(657, 2432, 2555);

                bool
                f_657_2509_2521(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 2509, 2521);
                    return return_v;
                }


                int
                f_657_2524_2539(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 2524, 2539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 2432, 2555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 2432, 2555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxNodeOrToken ItemInternal(SyntaxNode node, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(657, 2751, 5521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2850, 2872);

                GreenNode?
                greenChild
                = default(GreenNode?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2886, 2909);

                var
                green = f_657_2898_2908(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2923, 2939);

                var
                idx = index
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2953, 2971);

                var
                slotIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 2985, 3014);

                var
                position = f_657_3000_3013(node)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 3558, 4064) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 3558, 4064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 3603, 3641);

                        greenChild = f_657_3616_3640(green, slotIndex);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 3659, 4017) || true) && (greenChild != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 3659, 4017);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 3723, 3768);

                            int
                            currentOccupancy = Occupancy(greenChild)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 3790, 3895) || true) && (idx < currentOccupancy)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 3790, 3895);
                                DynAbs.Tracing.TraceSender.TraceBreak(657, 3866, 3872);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(657, 3790, 3895);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 3919, 3943);

                            idx -= currentOccupancy;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 3965, 3998);

                            position += f_657_3977_3997(greenChild);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(657, 3659, 4017);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4037, 4049);

                        slotIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(657, 3558, 4064);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(657, 3558, 4064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(657, 3558, 4064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4131, 4169);

                var
                red = f_657_4141_4168(node, slotIndex)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4183, 5430) || true) && (f_657_4187_4205_M(!greenChild.IsList))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 4183, 5430);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4428, 4515) || true) && (red != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 4428, 4515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4485, 4496);

                        return red;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(657, 4428, 4515);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 4183, 5430);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 4183, 5430);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4549, 5430) || true) && (red != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 4549, 5430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4681, 4717);

                        var
                        redChild = f_657_4696_4716(red, idx)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4735, 4873) || true) && (redChild != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 4735, 4873);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 4838, 4854);

                            return redChild;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(657, 4735, 4873);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 5013, 5050);

                        greenChild = f_657_5026_5049(greenChild, idx);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 5068, 5105);

                        position = f_657_5079_5104(red, idx);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(657, 4549, 5430);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 4549, 5430);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 5318, 5360);

                        position += f_657_5330_5359(greenChild, idx);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 5378, 5415);

                        greenChild = f_657_5391_5414(greenChild, idx);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(657, 4549, 5430);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 4183, 5430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 5446, 5510);

                return f_657_5453_5509(node, greenChild, position, index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(657, 2751, 5521);

                Microsoft.CodeAnalysis.GreenNode
                f_657_2898_2908(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 2898, 2908);
                    return return_v;
                }


                int
                f_657_3000_3013(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 3000, 3013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_657_3616_3640(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 3616, 3640);
                    return return_v;
                }


                int
                f_657_3977_3997(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 3977, 3997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_657_4141_4168(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNodeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 4141, 4168);
                    return return_v;
                }


                bool
                f_657_4187_4205_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 4187, 4205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_657_4696_4716(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNodeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 4696, 4716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_657_5026_5049(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 5026, 5049);
                    return return_v;
                }


                int
                f_657_5079_5104(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetChildPosition(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 5079, 5104);
                    return return_v;
                }


                int
                f_657_5330_5359(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlotOffset(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 5330, 5359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_657_5391_5414(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 5391, 5414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_657_5453_5509(Microsoft.CodeAnalysis.SyntaxNode
                parent, Microsoft.CodeAnalysis.GreenNode?
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrToken(parent, token, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 5453, 5509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 2751, 5521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 2751, 5521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxNodeOrToken ChildThatContainsPosition(SyntaxNode node, int targetPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(657, 6084, 8886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6273, 6326);

                f_657_6273_6325(node.FullSpan.Contains(targetPosition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6342, 6372);

                GreenNode?
                green = f_657_6361_6371(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6386, 6415);

                var
                position = f_657_6401_6414(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6429, 6443);

                var
                index = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6459, 6487);

                f_657_6459_6486(f_657_6472_6485_M(!green.IsList));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6782, 6791);

                int
                slot
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6810, 6818)
   , slot = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6805, 7409) || true) && (true)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6822, 6828)
   , slot++, DynAbs.Tracing.TraceSender.TraceExitCondition(657, 6805, 7409))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 6805, 7409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6862, 6906);

                        GreenNode?
                        greenChild = f_657_6886_6905(green, slot)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6924, 7394) || true) && (greenChild != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 6924, 7394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 6988, 7038);

                            var
                            endPosition = position + f_657_7017_7037(greenChild)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7060, 7275) || true) && (targetPosition < endPosition)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 7060, 7275);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7201, 7220);

                                green = greenChild;
                                DynAbs.Tracing.TraceSender.TraceBreak(657, 7246, 7252);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(657, 7060, 7275);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7299, 7322);

                            position = endPosition;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7344, 7375);

                            index += Occupancy(greenChild);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(657, 6924, 7394);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(657, 1, 605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(657, 1, 605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7471, 7504);

                var
                red = f_657_7481_7503(node, slot)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7518, 8738) || true) && (f_657_7522_7535_M(!green.IsList))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 7518, 8738);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7671, 7758) || true) && (red != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 7671, 7758);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7728, 7739);

                        return red;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(657, 7671, 7758);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 7518, 8738);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 7518, 8738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 7914, 7984);

                    slot = f_657_7921_7983(green, targetPosition - position);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 8054, 8394) || true) && (red != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 8054, 8394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 8180, 8208);

                        red = f_657_8186_8207(red, slot);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 8230, 8329) || true) && (red != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 8230, 8329);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 8295, 8306);

                            return red;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(657, 8230, 8329);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(657, 8054, 8394);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 8461, 8499);

                    position += f_657_8473_8498(green, slot);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 8517, 8545);

                    green = f_657_8525_8544(green, slot);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 8709, 8723);

                    index += slot;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 7518, 8738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 8816, 8875);

                return f_657_8823_8874(node, green, position, index);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(657, 6084, 8886);

                int
                f_657_6273_6325(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 6273, 6325);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_657_6361_6371(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 6361, 6371);
                    return return_v;
                }


                int
                f_657_6401_6414(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 6401, 6414);
                    return return_v;
                }


                bool
                f_657_6472_6485_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 6472, 6485);
                    return return_v;
                }


                int
                f_657_6459_6486(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 6459, 6486);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_657_6886_6905(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 6886, 6905);
                    return return_v;
                }


                int
                f_657_7017_7037(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 7017, 7037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_657_7481_7503(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNodeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 7481, 7503);
                    return return_v;
                }


                bool
                f_657_7522_7535_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 7522, 7535);
                    return return_v;
                }


                int
                f_657_7921_7983(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                offset)
                {
                    var return_v = this_param.FindSlotIndexContainingOffset(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 7921, 7983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_657_8186_8207(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNodeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 8186, 8207);
                    return return_v;
                }


                int
                f_657_8473_8498(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlotOffset(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 8473, 8498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_657_8525_8544(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 8525, 8544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_657_8823_8874(Microsoft.CodeAnalysis.SyntaxNode
                parent, Microsoft.CodeAnalysis.GreenNode?
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrToken(parent, token, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 8823, 8874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 6084, 8886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 6084, 8886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxNode? ItemInternalAsNode(SyntaxNode node, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(657, 9082, 10653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 9181, 9203);

                GreenNode?
                greenChild
                = default(GreenNode?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 9217, 9240);

                var
                green = f_657_9229_9239(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 9254, 9270);

                var
                idx = index
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 9284, 9302);

                var
                slotIndex = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 9802, 10253) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 9802, 10253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 9847, 9885);

                        greenChild = f_657_9860_9884(green, slotIndex);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 9903, 10206) || true) && (greenChild != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 9903, 10206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 9967, 10012);

                            int
                            currentOccupancy = Occupancy(greenChild)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10034, 10139) || true) && (idx < currentOccupancy)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 10034, 10139);
                                DynAbs.Tracing.TraceSender.TraceBreak(657, 10110, 10116);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(657, 10034, 10139);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10163, 10187);

                            idx -= currentOccupancy;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(657, 9903, 10206);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10226, 10238);

                        slotIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(657, 9802, 10253);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(657, 9802, 10253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(657, 9802, 10253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10320, 10358);

                var
                red = f_657_10330_10357(node, slotIndex)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10372, 10568) || true) && (f_657_10376_10393(greenChild) && (DynAbs.Tracing.TraceSender.Expression_True(657, 10376, 10408) && red != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 10372, 10568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10525, 10553);

                    return f_657_10532_10552(red, idx);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 10372, 10568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10631, 10642);

                return red;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(657, 9082, 10653);

                Microsoft.CodeAnalysis.GreenNode
                f_657_9229_9239(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 9229, 9239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_657_9860_9884(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 9860, 9884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_657_10330_10357(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNodeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 10330, 10357);
                    return return_v;
                }


                bool
                f_657_10376_10393(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 10376, 10393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_657_10532_10552(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNodeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 10532, 10552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 9082, 10653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 9082, 10653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxNodeOrToken[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 10749, 10822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10785, 10807);

                    // LAFHIS
                    //return f_657_10792_10806(ref this);
                    
                    var return_v = this.ToArray<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 10792, 10806);
                    return return_v;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(657, 10749, 10822);

                    Microsoft.CodeAnalysis.SyntaxNodeOrToken[]
                    f_657_10792_10806(ref Microsoft.CodeAnalysis.ChildSyntaxList
                    source)
                    {
                        var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 10792, 10806);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 10691, 10833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 10691, 10833);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Any()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 10845, 10917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 10887, 10906);

                return _count != 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 10845, 10917);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 10845, 10917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 10845, 10917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken First()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 11186, 11381);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 11243, 11316) || true) && (Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 11243, 11316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 11286, 11301);

                    return this[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 11243, 11316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 11332, 11370);

                throw f_657_11338_11369();
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 11186, 11381);

                System.InvalidOperationException
                f_657_11338_11369()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 11338, 11369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 11186, 11381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 11186, 11381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken Last()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 11648, 11851);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 11704, 11786) || true) && (Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 11704, 11786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 11747, 11771);

                    return this[_count - 1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 11704, 11786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 11802, 11840);

                throw f_657_11808_11839();
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 11648, 11851);

                System.InvalidOperationException
                f_657_11808_11839()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 11808, 11839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 11648, 11851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 11648, 11851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Reversed Reverse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 12152, 12292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 12202, 12232);

                f_657_12202_12231(_node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 12246, 12281);

                return f_657_12253_12280(_node, _count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 12152, 12292);

                int
                f_657_12202_12231(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 12202, 12231);
                    return 0;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.Reversed
                f_657_12253_12280(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.Reversed(node, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 12253, 12280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 12152, 12292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 12152, 12292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 12513, 12716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 12571, 12652) || true) && (_node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 12571, 12652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 12622, 12637);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 12571, 12652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 12668, 12705);

                return f_657_12675_12704(_node, _count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 12513, 12716);

                Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
                f_657_12675_12704(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator(node, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 12675, 12704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 12513, 12716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 12513, 12716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<SyntaxNodeOrToken> IEnumerable<SyntaxNodeOrToken>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 12728, 13031);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 12830, 12963) || true) && (_node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 12830, 12963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 12881, 12948);

                    return f_657_12888_12947();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 12830, 12963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 12979, 13020);

                return f_657_12986_13019(_node, _count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 12728, 13031);

                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_657_12888_12947()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 12888, 12947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.EnumeratorImpl
                f_657_12986_13019(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.EnumeratorImpl(node, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 12986, 13019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 12728, 13031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 12728, 13031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 13043, 13308);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 13107, 13240) || true) && (_node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(657, 13107, 13240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 13158, 13225);

                    return f_657_13165_13224();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(657, 13107, 13240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 13256, 13297);

                return f_657_13263_13296(_node, _count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 13043, 13308);

                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_657_13165_13224()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 13165, 13224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList.EnumeratorImpl
                f_657_13263_13296(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.EnumeratorImpl(node, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 13263, 13296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 13043, 13308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 13043, 13308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 13681, 13808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 13746, 13797);

                return obj is ChildSyntaxList list && (DynAbs.Tracing.TraceSender.Expression_True(657, 13753, 13796) && Equals(list));
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 13681, 13808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 13681, 13808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 13681, 13808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(ChildSyntaxList other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 14235, 14340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 14301, 14329);

                return _node == other._node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 14235, 14340);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 14235, 14340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 14235, 14340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(657, 14499, 14601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 14557, 14590);

                return f_657_14564_14584_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_node, 657, 14564, 14584)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(657, 14564, 14589) ?? 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(657, 14499, 14601);

                int?
                f_657_14564_14584_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(657, 14564, 14584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 14499, 14601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 14499, 14601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(ChildSyntaxList list1, ChildSyntaxList list2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(657, 15102, 15241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 15203, 15230);

                return list1.Equals(list2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(657, 15102, 15241);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 15102, 15241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 15102, 15241);
            }
        }

        public static bool operator !=(ChildSyntaxList list1, ChildSyntaxList list2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(657, 15748, 15888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(657, 15849, 15877);

                return !list1.Equals(list2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(657, 15748, 15888);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(657, 15748, 15888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 15748, 15888);
            }
        }
        static ChildSyntaxList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(657, 400, 15895);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(657, 400, 15895);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(657, 400, 15895);
        }

        static Microsoft.CodeAnalysis.GreenNode
        f_657_725_735(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Green;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(657, 725, 735);
            return return_v;
        }

    }
}
