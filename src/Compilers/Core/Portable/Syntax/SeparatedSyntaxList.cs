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

        // LAFHIS (base call first, then end invocation)
        internal SeparatedSyntaxList(SyntaxNode node, int index)
        : this(f_669_1799_1837(f_669_1799_1837_C(node), index))
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 6716, 7001);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6780, 6785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6787, 6801);
                    for (int
        i = 0
        ,
        n = this.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6771, 6964) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6810, 6813)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(669, 6771, 6964))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 6771, 6964);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6847, 6949) || true) && (f_669_6851_6879(this[i], node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 6847, 6949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6921, 6930);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 6847, 6949);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(669, 1, 194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(669, 1, 194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 6980, 6990);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 6716, 7001);

                bool
                f_669_6851_6879(TNode
                objA, TNode
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 6851, 6879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 6716, 7001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 6716, 7001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int IndexOf(Func<TNode, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 7013, 7305);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7094, 7099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7101, 7115);
                    for (int
        i = 0
        ,
        n = this.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7085, 7268) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7124, 7127)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(669, 7085, 7268))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 7085, 7268);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7161, 7253) || true) && (f_669_7165_7183(predicate, this[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 7161, 7253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7225, 7234);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 7161, 7253);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(669, 1, 184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(669, 1, 184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7284, 7294);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 7013, 7305);

                bool
                f_669_7165_7183(System.Func<TNode, bool>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 7165, 7183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 7013, 7305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 7013, 7305);
            }
            throw new System.Exception("Slicer error: unreachable code");
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

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7451, 7551) || true) && (f_669_7455_7470(this[i]) == rawKind)
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

                int
                f_669_7455_7470(TNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 7455, 7470);
                    return return_v;
                }

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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 7615, 7902);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7683, 7701);
                    for (int
        i = this.Count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7674, 7865) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7711, 7714)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(669, 7674, 7865))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 7674, 7865);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7748, 7850) || true) && (f_669_7752_7780(this[i], node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 7748, 7850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7822, 7831);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 7748, 7850);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7881, 7891);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 7615, 7902);

                bool
                f_669_7752_7780(TNode
                objA, TNode
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 7752, 7780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 7615, 7902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 7615, 7902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int LastIndexOf(Func<TNode, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 7914, 8208);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7999, 8017);
                    for (int
        i = this.Count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 7990, 8171) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8027, 8030)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(669, 7990, 8171))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 7990, 8171);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8064, 8156) || true) && (f_669_8068_8086(predicate, this[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 8064, 8156);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8128, 8137);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 8064, 8156);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(669, 1, 182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(669, 1, 182);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8187, 8197);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 7914, 8208);

                bool
                f_669_8068_8086(System.Func<TNode, bool>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 8068, 8086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 7914, 8208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 7914, 8208);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 8304, 8594);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8384, 8389);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8375, 8554) || true) && (i < this.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8407, 8410)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(669, 8375, 8554))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 8375, 8554);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8444, 8539) || true) && (f_669_8448_8466(predicate, this[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 8444, 8539);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8508, 8520);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 8444, 8539);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(669, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(669, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 8570, 8583);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 8304, 8594);

                bool
                f_669_8448_8466(System.Func<TNode, bool>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 8448, 8466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 8304, 8594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 8304, 8594);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 10873, 13127);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 10980, 11093) || true) && (nodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 10980, 11093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11031, 11078);

                    throw f_669_11037_11077(nameof(nodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 10980, 11093);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11109, 11246) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(669, 11113, 11144) || index > this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 11109, 11246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11178, 11231);

                    throw f_669_11184_11230(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 11109, 11246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11262, 11307);

                var
                nodesWithSeps = this.GetWithSeparators()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11321, 11420);

                int
                insertionIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(669, 11342, 11360) || ((index < this.Count && DynAbs.Tracing.TraceSender.Conditional_F2(669, 11363, 11397)) || DynAbs.Tracing.TraceSender.Conditional_F3(669, 11400, 11419))) ? nodesWithSeps.IndexOf(this[index]) : nodesWithSeps.Count
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11499, 11900) || true) && (insertionIndex > 0 && (DynAbs.Tracing.TraceSender.Expression_True(669, 11503, 11561) && insertionIndex < nodesWithSeps.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 11499, 11900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11595, 11644);

                    var
                    previous = nodesWithSeps[insertionIndex - 1]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11662, 11885) || true) && (previous.IsToken && (DynAbs.Tracing.TraceSender.Expression_True(669, 11666, 11736) && !KeepSeparatorWithPreviousNode(previous.AsToken())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 11662, 11885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11849, 11866);

                        insertionIndex--;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 11662, 11885);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 11499, 11900);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11916, 11980);

                var
                nodesToInsertWithSeparators = f_669_11950_11979()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 11994, 12545);
                    foreach (var item in f_669_12015_12020_I(nodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 11994, 12545);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 12054, 12530) || true) && (item != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 12054, 12530);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 12194, 12449) || true) && (f_669_12198_12231(nodesToInsertWithSeparators) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(669, 12198, 12303) || (insertionIndex > 0 && (DynAbs.Tracing.TraceSender.Expression_True(669, 12240, 12302) && nodesWithSeps[insertionIndex - 1].IsNode))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 12194, 12449);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 12353, 12426);

                                f_669_12353_12425(nodesToInsertWithSeparators, f_669_12385_12424(f_669_12385_12395(item), item));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(669, 12194, 12449);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 12473, 12511);

                            f_669_12473_12510(
                                                nodesToInsertWithSeparators, item);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 12054, 12530);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 11994, 12545);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(669, 1, 552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(669, 1, 552);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 12635, 12990) || true) && (insertionIndex < nodesWithSeps.Count && (DynAbs.Tracing.TraceSender.Expression_True(669, 12639, 12740) && nodesWithSeps[insertionIndex] is { IsNode: true } nodeOrToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 12635, 12990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 12774, 12824);

                    var
                    node = nodesWithSeps[insertionIndex].AsNode()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 12842, 12871);

                    f_669_12842_12870(node is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 12889, 12962);

                    f_669_12889_12961(nodesToInsertWithSeparators, f_669_12921_12960(f_669_12921_12931(node), node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 12635, 12990);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 13006, 13116);

                return f_669_13013_13115(nodesWithSeps.InsertRange(insertionIndex, nodesToInsertWithSeparators));
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 10873, 13127);

                System.ArgumentNullException
                f_669_11037_11077(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 11037, 11077);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_669_11184_11230(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 11184, 11230);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_669_11950_11979()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 11950, 11979);
                    return return_v;
                }


                int
                f_669_12198_12231(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 12198, 12231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_669_12385_12395(TNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 12385, 12395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_669_12385_12424(Microsoft.CodeAnalysis.GreenNode
                this_param, TNode
                element)
                {
                    var return_v = this_param.CreateSeparator<TNode>((Microsoft.CodeAnalysis.SyntaxNode)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 12385, 12424);
                    return return_v;
                }


                int
                f_669_12353_12425(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.SyntaxNodeOrToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 12353, 12425);
                    return 0;
                }


                int
                f_669_12473_12510(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.SyntaxNodeOrToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 12473, 12510);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_669_12015_12020_I(System.Collections.Generic.IEnumerable<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 12015, 12020);
                    return return_v;
                }


                int
                f_669_12842_12870(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 12842, 12870);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_669_12921_12931(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 12921, 12931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_669_12921_12960(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                element)
                {
                    var return_v = this_param.CreateSeparator<TNode>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 12921, 12960);
                    return return_v;
                }


                int
                f_669_12889_12961(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.SyntaxNodeOrToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 12889, 12961);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_669_13013_13115(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 13013, 13115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 10873, 13127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 10873, 13127);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 14400, 15259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14477, 14522);

                var
                nodesWithSeps = this.GetWithSeparators()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14536, 14576);

                int
                index = nodesWithSeps.IndexOf(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14592, 15220) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(669, 14596, 14638) && index <= nodesWithSeps.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 14592, 15220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14672, 14718);

                    nodesWithSeps = nodesWithSeps.RemoveAt(index);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14779, 15132) || true) && (index < nodesWithSeps.Count && (DynAbs.Tracing.TraceSender.Expression_True(669, 14783, 14842) && nodesWithSeps[index].IsToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 14779, 15132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14884, 14930);

                        nodesWithSeps = nodesWithSeps.RemoveAt(index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 14779, 15132);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 14779, 15132);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 14972, 15132) || true) && (index > 0 && (DynAbs.Tracing.TraceSender.Expression_True(669, 14976, 15021) && nodesWithSeps[index - 1].IsToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 14972, 15132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 15063, 15113);

                            nodesWithSeps = nodesWithSeps.RemoveAt(index - 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(669, 14972, 15132);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 14779, 15132);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 15152, 15205);

                    return f_669_15159_15204(nodesWithSeps);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 14592, 15220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 15236, 15248);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 14400, 15259);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_669_15159_15204(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 15159, 15204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 14400, 15259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 14400, 15259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates a new list with the specified element replaced by the new node.
        /// </summary>
        /// <param name="nodeInList">The element to replace.</param>
        /// <param name="newNode">The new node.</param>
        public SeparatedSyntaxList<TNode> Replace(TNode nodeInList, TNode newNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 15530, 16076);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 15629, 15746) || true) && (newNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 15629, 15746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 15682, 15731);

                    throw f_669_15688_15730(nameof(newNode));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 15629, 15746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 15762, 15799);

                var
                index = this.IndexOf(nodeInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 15813, 15991) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(669, 15817, 15849) && index < this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 15813, 15991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 15883, 15976);

                    return f_669_15890_15975(this.GetWithSeparators().Replace(nodeInList, newNode));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 15813, 15991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16007, 16065);

                throw f_669_16013_16064(nameof(nodeInList));
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 15530, 16076);

                System.ArgumentNullException
                f_669_15688_15730(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 15688, 15730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_669_15890_15975(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 15890, 15975);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_669_16013_16064(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 16013, 16064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 15530, 16076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 15530, 16076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates a new list with the specified element replaced by the new nodes.
        /// </summary>
        /// <param name="nodeInList">The element to replace.</param>
        /// <param name="newNodes">The new nodes.</param>
        public SeparatedSyntaxList<TNode> ReplaceRange(TNode nodeInList, IEnumerable<TNode> newNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 16350, 17351);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16468, 16587) || true) && (newNodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 16468, 16587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16522, 16572);

                    throw f_669_16528_16571(nameof(newNodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 16468, 16587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16603, 16640);

                var
                index = this.IndexOf(nodeInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16654, 17266) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(669, 16658, 16690) && index < this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 16654, 17266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16724, 16760);

                    var
                    newNodeList = f_669_16742_16759(newNodes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16778, 16896) || true) && (f_669_16782_16799(newNodeList) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 16778, 16896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16846, 16877);

                        return this.Remove(nodeInList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 16778, 16896);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 16916, 16985);

                    var
                    listWithFirstReplaced = this.Replace(nodeInList, f_669_16969_16983(newNodeList, 0))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17005, 17202) || true) && (f_669_17009_17026(newNodeList) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 17005, 17202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17072, 17096);

                        f_669_17072_17095(newNodeList, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17118, 17183);

                        return listWithFirstReplaced.InsertRange(index + 1, newNodeList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(669, 17005, 17202);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17222, 17251);

                    return listWithFirstReplaced;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 16654, 17266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17282, 17340);

                throw f_669_17288_17339(nameof(nodeInList));
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 16350, 17351);

                System.ArgumentNullException
                f_669_16528_16571(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 16528, 16571);
                    return return_v;
                }


                System.Collections.Generic.List<TNode>
                f_669_16742_16759(System.Collections.Generic.IEnumerable<TNode>
                source)
                {
                    var return_v = source.ToList<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 16742, 16759);
                    return return_v;
                }


                int
                f_669_16782_16799(System.Collections.Generic.List<TNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 16782, 16799);
                    return return_v;
                }


                TNode
                f_669_16969_16983(System.Collections.Generic.List<TNode>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 16969, 16983);
                    return return_v;
                }


                int
                f_669_17009_17026(System.Collections.Generic.List<TNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(669, 17009, 17026);
                    return return_v;
                }


                int
                f_669_17072_17095(System.Collections.Generic.List<TNode>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 17072, 17095);
                    return 0;
                }


                System.ArgumentOutOfRangeException
                f_669_17288_17339(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 17288, 17339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 16350, 17351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 16350, 17351);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates a new list with the specified separator token replaced with the new separator.
        /// </summary>
        /// <param name="separatorToken">The separator token to be replaced.</param>
        /// <param name="newSeparator">The new separator token.</param>
        public SeparatedSyntaxList<TNode> ReplaceSeparator(SyntaxToken separatorToken, SyntaxToken newSeparator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 17669, 18387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17798, 17843);

                var
                nodesWithSeps = this.GetWithSeparators()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17857, 17907);

                var
                index = nodesWithSeps.IndexOf(separatorToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17921, 18029) || true) && (index < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 17921, 18029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 17968, 18014);

                    throw f_669_17974_18013("separatorToken");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 17921, 18029);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 18045, 18269) || true) && (newSeparator.RawKind != nodesWithSeps[index].RawKind || (DynAbs.Tracing.TraceSender.Expression_False(669, 18049, 18176) || newSeparator.Language != nodesWithSeps[index].Language))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 18045, 18269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 18210, 18254);

                    throw f_669_18216_18253("newSeparator");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 18045, 18269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 18285, 18376);

                return f_669_18292_18375(nodesWithSeps.Replace(separatorToken, newSeparator));
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 17669, 18387);

                System.ArgumentException
                f_669_17974_18013(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 17974, 18013);
                    return return_v;
                }


                System.ArgumentException
                f_669_18216_18253(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 18216, 18253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_669_18292_18375(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 18292, 18375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 17669, 18387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 17669, 18387);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
        {
            try
#pragma warning restore RS0041 // uses oblivious reference types
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 18716, 18879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 18840, 18868);

                return f_669_18847_18867(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 18716, 18879);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>.Enumerator
                f_669_18847_18867(Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>.Enumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 18847, 18867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 18716, 18879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 18716, 18879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 18891, 19146);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 18969, 19064) || true) && (this.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 18969, 19064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 19017, 19049);

                    return f_669_19024_19048(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 18969, 19064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 19080, 19135);

                return f_669_19087_19134();
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 18891, 19146);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>.EnumeratorImpl
                f_669_19024_19048(Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>.EnumeratorImpl(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 19024, 19048);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<TNode>
                f_669_19087_19134()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 19087, 19134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 18891, 19146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 18891, 19146);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(669, 19158, 19399);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 19222, 19317) || true) && (this.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(669, 19222, 19317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 19270, 19302);

                    return f_669_19277_19301(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(669, 19222, 19317);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(669, 19333, 19388);

                return f_669_19340_19387();
                DynAbs.Tracing.TraceSender.TraceExitMethod(669, 19158, 19399);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>.EnumeratorImpl
                f_669_19277_19301(Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>.EnumeratorImpl(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 19277, 19301);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<TNode>
                f_669_19340_19387()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(669, 19340, 19387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(669, 19158, 19399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(669, 19158, 19399);
            }
            throw new System.Exception("Slicer error: unreachable code");
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


        static SyntaxNode
        f_669_1799_1837_C(SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(669, 1722, 1860);
            return return_v;
        }

    }
}
