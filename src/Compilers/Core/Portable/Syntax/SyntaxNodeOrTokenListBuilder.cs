// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal class SyntaxNodeOrTokenListBuilder
    {
        private GreenNode?[] _nodes;

        private int _count;

        public SyntaxNodeOrTokenListBuilder(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(694, 462, 598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 414, 420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 443, 449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 532, 562);

                _nodes = new GreenNode?[size];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 576, 587);

                _count = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(694, 462, 598);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 462, 598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 462, 598);
            }
        }

        public static SyntaxNodeOrTokenListBuilder Create()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(694, 610, 740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 686, 729);

                return f_694_693_728(8);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(694, 610, 740);

                Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                f_694_693_728(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 693, 728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 610, 740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 610, 740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 793, 815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 799, 813);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(694, 793, 815);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 752, 826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 752, 826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 838, 904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 882, 893);

                _count = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 838, 904);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 838, 904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 838, 904);
            }
        }

        public SyntaxNodeOrToken this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 981, 1469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1017, 1047);

                    var
                    innerNode = _nodes[index]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1065, 1105);

                    f_694_1065_1104(innerNode is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1123, 1454) || true) && (f_694_1127_1144(innerNode) == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 1123, 1454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1272, 1324);

                        return f_694_1279_1323(null, innerNode, 0, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(694, 1123, 1454);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 1123, 1454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1406, 1435);

                        return f_694_1413_1434(innerNode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(694, 1123, 1454);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(694, 981, 1469);

                    int
                    f_694_1065_1104(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 1065, 1104);
                        return 0;
                    }


                    bool
                    f_694_1127_1144(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(694, 1127, 1144);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNodeOrToken
                    f_694_1279_1323(Microsoft.CodeAnalysis.SyntaxNode?
                    parent, Microsoft.CodeAnalysis.GreenNode
                    token, int
                    position, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrToken(parent, token, position, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 1279, 1323);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_694_1413_1434(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.CreateRed();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 1413, 1434);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 981, 1469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 981, 1469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 1485, 1573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1521, 1558);

                    _nodes[index] = value.UnderlyingNode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(694, 1485, 1573);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 1485, 1573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 1485, 1573);
                }
            }
        }

        internal void Add(GreenNode item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 1596, 1828);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1654, 1777) || true) && (_count >= f_694_1668_1681(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 1654, 1777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1715, 1762);

                    f_694_1715_1761(this, (DynAbs.Tracing.TraceSender.Conditional_F1(694, 1725, 1736) || ((_count == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(694, 1739, 1740)) || DynAbs.Tracing.TraceSender.Conditional_F3(694, 1743, 1760))) ? 8 : f_694_1743_1756(_nodes) * 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(694, 1654, 1777);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1793, 1817);

                _nodes[_count++] = item;
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 1596, 1828);

                int
                f_694_1668_1681(Microsoft.CodeAnalysis.GreenNode?[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(694, 1668, 1681);
                    return return_v;
                }


                int
                f_694_1743_1756(Microsoft.CodeAnalysis.GreenNode?[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(694, 1743, 1756);
                    return return_v;
                }


                int
                f_694_1715_1761(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 1715, 1761);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 1596, 1828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 1596, 1828);
            }
        }

        public void Add(SyntaxNode item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 1840, 1929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 1897, 1918);

                f_694_1897_1917(this, f_694_1906_1916(item));
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 1840, 1929);

                Microsoft.CodeAnalysis.GreenNode
                f_694_1906_1916(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(694, 1906, 1916);
                    return return_v;
                }


                int
                f_694_1897_1917(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 1897, 1917);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 1840, 1929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 1840, 1929);
            }
        }

        public void Add(in SyntaxToken item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 1941, 2087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2002, 2042);

                f_694_2002_2041(item.Node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2056, 2076);

                f_694_2056_2075(this, item.Node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 1941, 2087);

                int
                f_694_2002_2041(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 2002, 2041);
                    return 0;
                }


                int
                f_694_2056_2075(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 2056, 2075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 1941, 2087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 1941, 2087);
            }
        }

        public void Add(in SyntaxNodeOrToken item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 2099, 2271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2166, 2216);

                f_694_2166_2215(item.UnderlyingNode is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2230, 2260);

                f_694_2230_2259(this, item.UnderlyingNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 2099, 2271);

                int
                f_694_2166_2215(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 2166, 2215);
                    return 0;
                }


                int
                f_694_2230_2259(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 2230, 2259);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 2099, 2271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 2099, 2271);
            }
        }

        public void Add(SyntaxNodeOrTokenList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 2283, 2392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2351, 2381);

                f_694_2351_2380(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 2283, 2392);

                int
                f_694_2351_2380(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list, int
                offset, int
                length)
                {
                    this_param.Add(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 2351, 2380);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 2283, 2392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 2283, 2392);
            }
        }

        public void Add(SyntaxNodeOrTokenList list, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 2404, 2709);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2496, 2607) || true) && (_count + length > f_694_2518_2531(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 2496, 2607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2565, 2592);

                    f_694_2565_2591(this, _count + length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(694, 2496, 2607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2623, 2667);

                list.CopyTo(offset, _nodes, _count, length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2681, 2698);

                _count += length;
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 2404, 2709);

                int
                f_694_2518_2531(Microsoft.CodeAnalysis.GreenNode?[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(694, 2518, 2531);
                    return return_v;
                }


                int
                f_694_2565_2591(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 2565, 2591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 2404, 2709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 2404, 2709);
            }
        }

        public void Add(IEnumerable<SyntaxNodeOrToken> nodeOrTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 2721, 2908);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2806, 2897);
                    foreach (var n in f_694_2824_2836_I(nodeOrTokens))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 2806, 2897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2870, 2882);

                        f_694_2870_2881(this, n);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(694, 2806, 2897);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(694, 1, 92);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(694, 1, 92);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 2721, 2908);

                int
                f_694_2870_2881(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 2870, 2881);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_694_2824_2836_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 2824, 2836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 2721, 2908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 2721, 2908);
            }
        }

        internal void RemoveLast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 2920, 3027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2971, 2980);

                _count--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 2994, 3016);

                _nodes[_count] = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 2920, 3027);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 2920, 3027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 2920, 3027);
            }
        }

        private void Grow(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 3039, 3212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3091, 3121);

                var
                tmp = new GreenNode[size]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3135, 3174);

                f_694_3135_3173(_nodes, tmp, f_694_3159_3172(_nodes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3188, 3201);

                _nodes = tmp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 3039, 3212);

                int
                f_694_3159_3172(Microsoft.CodeAnalysis.GreenNode?[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(694, 3159, 3172);
                    return return_v;
                }


                int
                f_694_3135_3173(Microsoft.CodeAnalysis.GreenNode?[]
                sourceArray, Microsoft.CodeAnalysis.GreenNode[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 3135, 3173);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 3039, 3212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 3039, 3212);
            }
        }

        public SyntaxNodeOrTokenList ToList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(694, 3224, 4888);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3286, 4877) || true) && (_count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 3286, 4877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3334, 4758);

                    switch (_count)
                    {

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 3334, 4758);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3423, 3887) || true) && (f_694_3427_3445(_nodes[0]!))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 3423, 3887);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3503, 3679);

                                return f_694_3510_3678(f_694_3570_3634(f_694_3570_3622(new[] { _nodes[0]! })), index: 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(694, 3423, 3887);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 3423, 3887);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3793, 3860);

                                return f_694_3800_3859(f_694_3826_3848(_nodes[0]!), index: 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(694, 3423, 3887);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(694, 3334, 4758);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 3334, 4758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 3942, 4112);

                            return f_694_3949_4111(f_694_4005_4071(f_694_4005_4059(_nodes[0]!, _nodes[1]!)), index: 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(694, 3334, 4758);

                        case 3:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 3334, 4758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 4167, 4349);

                            return f_694_4174_4348(f_694_4230_4308(f_694_4230_4296(_nodes[0]!, _nodes[1]!, _nodes[2]!)), index: 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(694, 3334, 4758);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 3334, 4758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 4405, 4451);

                            var
                            tmp = new ArrayElement<GreenNode>[_count]
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 4486, 4491);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 4477, 4619) || true) && (i < _count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 4505, 4508)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(694, 4477, 4619))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 4477, 4619);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 4566, 4592);

                                    tmp[i].Value = _nodes[i]!;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(694, 1, 143);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(694, 1, 143);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 4647, 4739);

                            return f_694_4654_4738(f_694_4680_4727(f_694_4680_4715(tmp)), index: 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(694, 3334, 4758);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(694, 3286, 4877);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(694, 3286, 4877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(694, 4824, 4862);

                    return default(SyntaxNodeOrTokenList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(694, 3286, 4877);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(694, 3224, 4888);

                bool
                f_694_3427_3445(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(694, 3427, 3445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_694_3570_3622(Microsoft.CodeAnalysis.GreenNode[]
                nodes)
                {
                    var return_v = InternalSyntax.SyntaxList.List(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 3570, 3622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_694_3570_3634(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 3570, 3634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_694_3510_3678(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(node, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 3510, 3678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_694_3826_3848(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 3826, 3848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_694_3800_3859(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(node, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 3800, 3859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_694_4005_4059(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1)
                {
                    var return_v = InternalSyntax.SyntaxList.List(child0, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 4005, 4059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_694_4005_4071(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 4005, 4071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_694_3949_4111(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(node, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 3949, 4111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_694_4230_4296(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2)
                {
                    var return_v = InternalSyntax.SyntaxList.List(child0, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 4230, 4296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_694_4230_4308(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 4230, 4308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_694_4174_4348(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(node, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 4174, 4348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_694_4680_4715(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = InternalSyntax.SyntaxList.List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 4680, 4715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_694_4680_4727(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 4680, 4727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_694_4654_4738(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(node, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(694, 4654, 4738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(694, 3224, 4888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 3224, 4888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxNodeOrTokenListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(694, 333, 4895);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(694, 333, 4895);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(694, 333, 4895);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(694, 333, 4895);
    }
}
