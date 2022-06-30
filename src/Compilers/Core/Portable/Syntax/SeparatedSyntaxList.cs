// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public readonly partial struct SeparatedSyntaxList<TNode> : IEquatable<SeparatedSyntaxList<TNode>>, IReadOnlyList<TNode> where TNode : SyntaxNode
    {

        private readonly SyntaxNodeOrTokenList _list;

        private readonly int _count;

        private readonly int _separatorCount;

        internal SeparatedSyntaxList(SyntaxNodeOrTokenList list)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(669, 740, 1160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 843, 858);

                Validate(list);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1005, 1031);

                int
                allCount = list.Count
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1045, 1074);

                _count = (allCount + 1) >> 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1088, 1120);

                _separatorCount = allCount >> 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1136, 1149);

                _list = list;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(669, 740, 1160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 740, 1160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 740, 1160);
            }
        }

        [Conditional("DEBUG")]
        private static void Validate(SyntaxNodeOrTokenList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(669, 1172, 1710);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1294, 1299);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1285, 1699) || true) && (i < list.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1317, 1320)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(669, 1285, 1699))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 1285, 1699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1354, 1373);

                        var
                        item = list[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1391, 1684) || true) && ((i & 1) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 1391, 1684);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1449, 1510);

                            f_669_1449_1509(item.IsNode, "Node missing in separated list.");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 1391, 1684);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 1391, 1684);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1592, 1665);

                            f_669_1592_1664(item.IsToken, "Separator token missing in separated list.");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 1391, 1684);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(669, 1, 415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(669, 1, 415);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(669, 1172, 1710);

                int
                f_669_1449_1509(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 1449, 1509);
                    return 0;
                }


                int
                f_669_1592_1664(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 1592, 1664);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 1172, 1710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 1172, 1710);
            }
        }

        internal SeparatedSyntaxList(SyntaxNode node, int index)
        : this(f_669_1799_1837_C(f_669_1799_1837(node, index)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(669, 1722, 1860);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(669, 1722, 1860);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 1722, 1860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 1722, 1860);
            }
        }

        internal SyntaxNode? Node
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 1922, 1991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 1958, 1976);

                    return _list.Node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(669, 1922, 1991);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 1872, 2002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 1872, 2002);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 2055, 2120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2091, 2105);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(669, 2055, 2120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 2014, 2131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 2014, 2131);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 2193, 2267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2229, 2252);

                    return _separatorCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(669, 2193, 2267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 2143, 2278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 2143, 2278);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TNode this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 2343, 3066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2379, 2401);

                    var
                    node = _list.Node
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2419, 2978) || true) && (node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 2419, 2978);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2477, 2959) || true) && (f_669_2481_2493_M(!node.IsList))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 2477, 2959);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2543, 2661) || true) && (index == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 2543, 2661);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2615, 2634);

                                return (TNode)node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(669, 2543, 2661);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 2477, 2959);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 2477, 2959);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2759, 2936) || true) && (unchecked((uint)index < (uint)_count))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 2759, 2936);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2858, 2909);

                                return (TNode)f_669_2872_2908(node, index << 1);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(669, 2759, 2936);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 2477, 2959);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 2419, 2978);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 2998, 3051);

                    throw f_669_3004_3050(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(669, 2343, 3066);

                    bool
                    f_669_2481_2493_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 2481, 2493);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_669_2872_2908(Microsoft.CodeAnalysis.SyntaxNode
                    this_param, int
                    slot)
                    {
                        var return_v = this_param.GetRequiredNodeSlot(slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 2872, 2908);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_669_3004_3050(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 3004, 3050);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 2343, 3066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 2343, 3066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxToken GetSeparator(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 3286, 3998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3353, 3375);

                var
                node = _list.Node
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3389, 3918) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 3389, 3918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3439, 3515);

                    f_669_3439_3514(f_669_3452_3463(node), "separated list cannot be a singleton separator");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3533, 3903) || true) && (unchecked((uint)index < (uint)_separatorCount))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 3533, 3903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3625, 3650);

                        index = (index << 1) + 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3672, 3718);

                        var
                        green = f_669_3684_3717(f_669_3684_3694(node), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3740, 3768);

                        f_669_3740_3767(f_669_3753_3766(green));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3790, 3884);

                        return f_669_3797_3883(f_669_3813_3824(node), green, f_669_3833_3861(node, index), _list.index + index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 3533, 3903);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 3389, 3918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 3934, 3987);

                throw f_669_3940_3986(nameof(index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 3286, 3998);

                bool
                f_669_3452_3463(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 3452, 3463);
                    return return_v;
                }


                int
                f_669_3439_3514(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 3439, 3514);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_669_3684_3694(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 3684, 3694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_669_3684_3717(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetRequiredSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 3684, 3717);
                    return return_v;
                }


                bool
                f_669_3753_3766(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 3753, 3766);
                    return return_v;
                }


                int
                f_669_3740_3767(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 3740, 3767);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_669_3813_3824(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 3813, 3824);
                    return return_v;
                }


                int
                f_669_3833_3861(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetChildPosition(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 3833, 3861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_669_3797_3883(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 3797, 3883);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_669_3940_3986(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 3940, 3986);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 3286, 3998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 3286, 3998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<SyntaxToken> GetSeparators()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 4121, 4264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 4193, 4253);

                // LAFHIS
                var temp = _list.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(n => n.IsToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 4200, 4227);
                return f_669_4200_4252(temp, n => n.AsToken());
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 4121, 4264);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_669_4200_4227(ref Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 4200, 4227);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_669_4200_4252(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxToken>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 4200, 4252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 4121, 4264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 4121, 4264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TextSpan FullSpan
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 4513, 4543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 4519, 4541);

                    return _list.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(669, 4513, 4543);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 4464, 4554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 4464, 4554);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TextSpan Span
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 4803, 4829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 4809, 4827);

                    return _list.Span;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(669, 4803, 4829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 4758, 4840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 4758, 4840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 5346, 5439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 5404, 5428);

                return _list.ToString();
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 5346, 5439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 5346, 5439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 5346, 5439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 5943, 6035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 5996, 6024);

                return _list.ToFullString();
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 5943, 6035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 5943, 6035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 5943, 6035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode First()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 6047, 6118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6092, 6107);

                return this[0];
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 6047, 6118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 6047, 6118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 6047, 6118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode? FirstOrDefault()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 6130, 6302);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6185, 6263) || true) && (this.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 6185, 6263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6233, 6248);

                    return this[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 6185, 6263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6279, 6291);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 6130, 6302);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 6130, 6302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 6130, 6302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode Last()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 6314, 6397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6358, 6386);

                return this[this.Count - 1];
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 6314, 6397);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 6314, 6397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 6314, 6397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode? LastOrDefault()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 6409, 6593);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6463, 6554) || true) && (this.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 6463, 6554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6511, 6539);

                    return this[this.Count - 1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 6463, 6554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6570, 6582);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 6409, 6593);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 6409, 6593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 6409, 6593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Contains(TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 6605, 6704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6662, 6693);

                return this.IndexOf(node) >= 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 6605, 6704);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 6605, 6704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 6605, 6704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int IndexOf(TNode node)
        {
            for (int i = 0, n = this.Count; i < n; i++)
            {
                if (object.Equals(this[i], node))
                {
                    return i;
                }
            }

            return -1;
        }

        public int IndexOf(Func<TNode, bool> predicate)
        {
            for (int i = 0, n = this.Count; i < n; i++)
            {
                if (predicate(this[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        internal int IndexOf(int rawKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 7317, 7603);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7384, 7389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7391, 7405);
                    for (int
        i = 0
        ,
        n = this.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7375, 7566) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7414, 7417)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(669, 7375, 7566))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 7375, 7566);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7451, 7551) || true) && (this[i].RawKind == rawKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 7451, 7551);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7523, 7532);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 7451, 7551);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(669, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(669, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7582, 7592);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 7317, 7603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 7317, 7603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 7317, 7603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int LastIndexOf(TNode node)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                if (object.Equals(this[i], node))
                {
                    return i;
                }
            }

            return -1;
        }

        public int LastIndexOf(Func<TNode, bool> predicate)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                if (predicate(this[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Any()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 8220, 8292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8262, 8281);

                return _list.Any();
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 8220, 8292);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 8220, 8292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 8220, 8292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Any(Func<TNode, bool> predicate)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (predicate(this[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public SyntaxNodeOrTokenList GetWithSeparators()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 8606, 8703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8679, 8692);

                return _list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 8606, 8703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 8606, 8703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 8606, 8703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SeparatedSyntaxList<TNode> left, SeparatedSyntaxList<TNode> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(669, 8715, 8874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8837, 8863);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(669, 8715, 8874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 8715, 8874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 8715, 8874);
            }
        }

        public static bool operator !=(SeparatedSyntaxList<TNode> left, SeparatedSyntaxList<TNode> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(669, 8886, 9046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 9008, 9035);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(669, 8886, 9046);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 8886, 9046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 8886, 9046);
            }
        }

        public bool Equals(SeparatedSyntaxList<TNode> other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 9058, 9174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 9135, 9163);

                return _list == other._list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 9058, 9174);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 9058, 9174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 9058, 9174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 9186, 9326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 9251, 9315);

                return (obj is SeparatedSyntaxList<TNode> list) && (DynAbs.Tracing.TraceSender.Expression_True(669, 9258, 9314) && Equals(list));
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 9186, 9326);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 9186, 9326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 9186, 9326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 9338, 9434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 9396, 9423);

                return _list.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 9338, 9434);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 9338, 9434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 9338, 9434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TNode> Add(TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 9624, 9741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 9698, 9730);

                return Insert(this.Count, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 9624, 9741);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 9624, 9741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 9624, 9741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TNode> AddRange(IEnumerable<TNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 9934, 10076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 10027, 10065);

                return InsertRange(this.Count, nodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 9934, 10076);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 9934, 10076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 9934, 10076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TNode> Insert(int index, TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 10339, 10607);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 10427, 10538) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 10427, 10538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 10477, 10523);

                    throw f_669_10483_10522(nameof(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 10427, 10538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 10554, 10596);

                return InsertRange(index, new[] { node });
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 10339, 10607);

                System.ArgumentNullException
                f_669_10483_10522(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 10483, 10522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 10339, 10607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 10339, 10607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates a new list with the specified nodes inserted at the index.
        /// </summary>
        /// <param name="index">The index to insert at.</param>
        /// <param name="nodes">The nodes to insert.</param>
        public SeparatedSyntaxList<TNode> InsertRange(int index, IEnumerable<TNode> nodes)
        {
            if (nodes == null)
            {
                throw new ArgumentNullException(nameof(nodes));
            }

            if (index < 0 || index > this.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var nodesWithSeps = this.GetWithSeparators();
            int insertionIndex = index < this.Count ? nodesWithSeps.IndexOf(this[index]) : nodesWithSeps.Count;

            // determine how to deal with separators (commas)
            if (insertionIndex > 0 && insertionIndex < nodesWithSeps.Count)
            {
                var previous = nodesWithSeps[insertionIndex - 1];
                if (previous.IsToken && !KeepSeparatorWithPreviousNode(previous.AsToken()))
                {
                    // pull back so item in inserted before separator
                    insertionIndex--;
                }
            }

            var nodesToInsertWithSeparators = new List<SyntaxNodeOrToken>();
            foreach (var item in nodes)
            {
                if (item != null)
                {
                    // if item before insertion point is a node, add a separator
                    if (nodesToInsertWithSeparators.Count > 0 || (insertionIndex > 0 && nodesWithSeps[insertionIndex - 1].IsNode))
                    {
                        nodesToInsertWithSeparators.Add(item.Green.CreateSeparator<TNode>(item));
                    }

                    nodesToInsertWithSeparators.Add(item);
                }
            }

            // if item after last inserted node is a node, add separator
            if (insertionIndex < nodesWithSeps.Count && nodesWithSeps[insertionIndex] is { IsNode: true } nodeOrToken)
            {
                var node = nodesWithSeps[insertionIndex].AsNode();
                Debug.Assert(node is object);
                nodesToInsertWithSeparators.Add(node.Green.CreateSeparator<TNode>(node)); // separator
            }

            return new SeparatedSyntaxList<TNode>(nodesWithSeps.InsertRange(insertionIndex, nodesToInsertWithSeparators));
        }

        private static bool KeepSeparatorWithPreviousNode(in SyntaxToken separator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(669, 13139, 13723);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 13413, 13683);
                    foreach (var tr in f_669_13432_13456_I(separator.TrailingTrivia))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 13413, 13683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 13490, 13532);

                        f_669_13490_13531(tr.UnderlyingNode is object);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 13550, 13668) || true) && (f_669_13554_13595(tr.UnderlyingNode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 13550, 13668);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 13637, 13649);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 13550, 13668);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 13413, 13683);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(669, 1, 271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(669, 1, 271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 13699, 13712);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(669, 13139, 13723);

                int
                f_669_13490_13531(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 13490, 13531);
                    return 0;
                }


                bool
                f_669_13554_13595(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsTriviaWithEndOfLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 13554, 13595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_669_13432_13456_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 13432, 13456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 13139, 13723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 13139, 13723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TNode> RemoveAt(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 13940, 14214);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14018, 14155) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(669, 14022, 14053) || index > this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 14018, 14155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14087, 14140);

                    throw f_669_14093_14139(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 14018, 14155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14171, 14203);

                return this.Remove(this[index]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 13940, 14214);

                System.ArgumentOutOfRangeException
                f_669_14093_14139(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 14093, 14139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 13940, 14214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 13940, 14214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates a new list with specified element removed.
        /// </summary>
        /// <param name="node">The element to remove.</param>
        public SeparatedSyntaxList<TNode> Remove(TNode node)
        {
            var nodesWithSeps = this.GetWithSeparators();
            int index = nodesWithSeps.IndexOf(node);

            if (index >= 0 && index <= nodesWithSeps.Count)
            {
                nodesWithSeps = nodesWithSeps.RemoveAt(index);

                // remove separator too
                if (index < nodesWithSeps.Count && nodesWithSeps[index].IsToken)
                {
                    nodesWithSeps = nodesWithSeps.RemoveAt(index);
                }
                else if (index > 0 && nodesWithSeps[index - 1].IsToken)
                {
                    nodesWithSeps = nodesWithSeps.RemoveAt(index - 1);
                }

                return new SeparatedSyntaxList<TNode>(nodesWithSeps);
            }

            return this;
        }

        /// <summary>
        /// Creates a new list with the specified element replaced by the new node.
        /// </summary>
        /// <param name="nodeInList">The element to replace.</param>
        /// <param name="newNode">The new node.</param>
        public SeparatedSyntaxList<TNode> Replace(TNode nodeInList, TNode newNode)
        {
            if (newNode == null)
            {
                throw new ArgumentNullException(nameof(newNode));
            }

            var index = this.IndexOf(nodeInList);
            if (index >= 0 && index < this.Count)
            {
                return new SeparatedSyntaxList<TNode>(this.GetWithSeparators().Replace(nodeInList, newNode));
            }

            throw new ArgumentOutOfRangeException(nameof(nodeInList));
        }

        /// <summary>
        /// Creates a new list with the specified element replaced by the new nodes.
        /// </summary>
        /// <param name="nodeInList">The element to replace.</param>
        /// <param name="newNodes">The new nodes.</param>
        public SeparatedSyntaxList<TNode> ReplaceRange(TNode nodeInList, IEnumerable<TNode> newNodes)
        {
            if (newNodes == null)
            {
                throw new ArgumentNullException(nameof(newNodes));
            }

            var index = this.IndexOf(nodeInList);
            if (index >= 0 && index < this.Count)
            {
                var newNodeList = newNodes.ToList();
                if (newNodeList.Count == 0)
                {
                    return this.Remove(nodeInList);
                }

                var listWithFirstReplaced = this.Replace(nodeInList, newNodeList[0]);

                if (newNodeList.Count > 1)
                {
                    newNodeList.RemoveAt(0);
                    return listWithFirstReplaced.InsertRange(index + 1, newNodeList);
                }

                return listWithFirstReplaced;
            }

            throw new ArgumentOutOfRangeException(nameof(nodeInList));
        }

        /// <summary>
        /// Creates a new list with the specified separator token replaced with the new separator.
        /// </summary>
        /// <param name="separatorToken">The separator token to be replaced.</param>
        /// <param name="newSeparator">The new separator token.</param>
        public SeparatedSyntaxList<TNode> ReplaceSeparator(SyntaxToken separatorToken, SyntaxToken newSeparator)
        {
            var nodesWithSeps = this.GetWithSeparators();
            var index = nodesWithSeps.IndexOf(separatorToken);
            if (index < 0)
            {
                throw new ArgumentException("separatorToken");
            }

            if (newSeparator.RawKind != nodesWithSeps[index].RawKind ||
                newSeparator.Language != nodesWithSeps[index].Language)
            {
                throw new ArgumentException("newSeparator");
            }

            return new SeparatedSyntaxList<TNode>(nodesWithSeps.Replace(separatorToken, newSeparator));
        }

        private TNode[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 18471, 18501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 18477, 18499);

                    // LAFHIS
                    //return f_669_18484_18498(ref this);
                    var return_v = this.ToArray<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 18484, 18498);
                    return return_v;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(669, 18471, 18501);

                    TNode[]
                    f_669_18484_18498(ref Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                    source)
                    {
                        var return_v = source.ToArray<TNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 18484, 18498);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 18425, 18512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 18425, 18512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SyntaxNodeOrToken[] NodesWithSeparators
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 18596, 18627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 18602, 18625);

                    // LAFHIS
                    //return f_669_18609_18624(_list);
                    var return_v = _list.ToArray<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 18609, 18624);
                    return return_v;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(669, 18596, 18627);

                    Microsoft.CodeAnalysis.SyntaxNodeOrToken[]
                    f_669_18609_18624(ref Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                    source)
                    {
                        var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 18609, 18624);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 18524, 18638);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 18524, 18638);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

#pragma warning disable RS0041 // uses oblivious reference types
        public Enumerator GetEnumerator()
#pragma warning restore RS0041 // uses oblivious reference types
        {
            return new Enumerator(this);
        }

        IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
        {
            if (this.Any())
            {
                return new EnumeratorImpl(this);
            }

            return SpecializedCollections.EmptyEnumerator<TNode>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (this.Any())
            {
                return new EnumeratorImpl(this);
            }

            return SpecializedCollections.EmptyEnumerator<TNode>();
        }

        public static implicit operator SeparatedSyntaxList<SyntaxNode>(SeparatedSyntaxList<TNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(669, 19411, 19600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 19533, 19589);

                return f_669_19540_19588(nodes._list);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(669, 19411, 19600);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                f_669_19540_19588(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.SyntaxNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 19540, 19588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 19411, 19600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 19411, 19600);
            }
        }
        public static implicit operator SeparatedSyntaxList<TNode>(SeparatedSyntaxList<SyntaxNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(669, 19612, 19796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 19734, 19785);

                return f_669_19741_19784(nodes._list);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(669, 19612, 19796);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_669_19741_19784(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 19741, 19784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 19612, 19796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 19612, 19796);
            }
        }
        static SeparatedSyntaxList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(669, 436, 19803);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(669, 436, 19803);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 436, 19803);
        }

        static Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
        f_669_1799_1837(Microsoft.CodeAnalysis.SyntaxNode
        node, int
        index)
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(node, index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 1799, 1837);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
        f_669_1799_1837_C(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(669, 1722, 1860);
            return return_v;
        }

    }
}
