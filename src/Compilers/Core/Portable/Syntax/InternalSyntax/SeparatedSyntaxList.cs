// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal struct SeparatedSyntaxList<TNode> : IEquatable<SeparatedSyntaxList<TNode>> where TNode : GreenNode
    {

        private readonly SyntaxList<GreenNode> _list;

        internal SeparatedSyntaxList(SyntaxList<GreenNode> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(822, 496, 630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 577, 592);

                Validate(list);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 606, 619);

                _list = list;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(822, 496, 630);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 496, 630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 496, 630);
            }
        }

        [Conditional("DEBUG")]
        private static void Validate(SyntaxList<GreenNode> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(822, 642, 1219);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 764, 769);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 755, 1208) || true) && (i < list.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 787, 790)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(822, 755, 1208))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(822, 755, 1208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 824, 859);

                        var
                        item = list.GetRequiredItem(i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 877, 1193) || true) && ((i & 1) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(822, 877, 1193);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 935, 1014);

                            f_822_935_1013(f_822_948_961_M(!item.IsToken), "even elements of a separated list must be nodes");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(822, 877, 1193);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(822, 877, 1193);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 1096, 1174);

                            f_822_1096_1173(f_822_1109_1121(item), "odd elements of a separated list must be tokens");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(822, 877, 1193);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(822, 1, 454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(822, 1, 454);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(822, 642, 1219);

                bool
                f_822_948_961_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(822, 948, 961);
                    return return_v;
                }


                int
                f_822_935_1013(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(822, 935, 1013);
                    return 0;
                }


                bool
                f_822_1109_1121(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(822, 1109, 1121);
                    return return_v;
                }


                int
                f_822_1096_1173(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(822, 1096, 1173);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 642, 1219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 642, 1219);
            }
        }

        internal GreenNode? Node
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 1256, 1269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 1259, 1269);
                    return _list.Node; DynAbs.Tracing.TraceSender.TraceExitMethod(822, 1256, 1269);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 1256, 1269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 1256, 1269);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 1323, 1404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 1359, 1389);

                    return (_list.Count + 1) >> 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(822, 1323, 1404);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 1282, 1415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 1282, 1415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int SeparatorCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 1477, 1552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 1513, 1537);

                    return _list.Count >> 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(822, 1477, 1552);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 1427, 1563);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 1427, 1563);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 1629, 1713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 1665, 1698);

                    return (TNode?)_list[index << 1];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(822, 1629, 1713);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 1629, 1713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 1629, 1713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public GreenNode? GetSeparator(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 1933, 2041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 1999, 2030);

                return _list[(index << 1) + 1];
                DynAbs.Tracing.TraceSender.TraceExitMethod(822, 1933, 2041);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 1933, 2041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 1933, 2041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<GreenNode> GetWithSeparators()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 2053, 2150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 2126, 2139);

                return _list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(822, 2053, 2150);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 2053, 2150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 2053, 2150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(in SeparatedSyntaxList<TNode> left, in SeparatedSyntaxList<TNode> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(822, 2162, 2327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 2290, 2316);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(822, 2162, 2327);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 2162, 2327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 2162, 2327);
            }
        }

        public static bool operator !=(in SeparatedSyntaxList<TNode> left, in SeparatedSyntaxList<TNode> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(822, 2339, 2505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 2467, 2494);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(822, 2339, 2505);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 2339, 2505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 2339, 2505);
            }
        }

        public bool Equals(SeparatedSyntaxList<TNode> other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 2517, 2633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 2594, 2622);

                return _list == other._list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(822, 2517, 2633);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 2517, 2633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 2517, 2633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 2645, 2807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 2710, 2796);

                return (obj is SeparatedSyntaxList<TNode>) && (DynAbs.Tracing.TraceSender.Expression_True(822, 2717, 2795) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(822, 2645, 2807);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 2645, 2807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 2645, 2807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 2819, 2915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 2877, 2904);

                return _list.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceExitMethod(822, 2819, 2915);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 2819, 2915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 2819, 2915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator SeparatedSyntaxList<GreenNode>(SeparatedSyntaxList<TNode> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(822, 2927, 3126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 3047, 3115);

                return f_822_3054_3114(list.GetWithSeparators());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(822, 2927, 3126);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_822_3054_3114(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.GreenNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(822, 3054, 3114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 2927, 3126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 2927, 3126);
            }
        }
        [Obsolete("For debugging only", true)]
        private TNode[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(822, 3243, 3528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 3279, 3302);

                    int
                    count = this.Count
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 3320, 3353);

                    TNode[]
                    array = new TNode[count]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 3380, 3385);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 3371, 3482) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 3398, 3401)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(822, 3371, 3482))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(822, 3371, 3482);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 3443, 3463);

                            array[i] = this[i]!;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(822, 1, 112);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(822, 1, 112);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(822, 3500, 3513);

                    return array;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(822, 3243, 3528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(822, 3149, 3539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 3149, 3539);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        static SeparatedSyntaxList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(822, 315, 3554);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(822, 315, 3554);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(822, 315, 3554);
        }
    }
}
