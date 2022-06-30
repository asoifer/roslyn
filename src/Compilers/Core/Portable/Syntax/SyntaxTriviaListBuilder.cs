// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal class SyntaxTriviaListBuilder
    {
        private SyntaxTrivia[] _nodes;

        private int _count;

        public SyntaxTriviaListBuilder(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(709, 461, 569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 413, 419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 442, 448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 526, 558);

                _nodes = new SyntaxTrivia[size];
                DynAbs.Tracing.TraceSender.TraceExitConstructor(709, 461, 569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 461, 569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 461, 569);
            }
        }

        public static SyntaxTriviaListBuilder Create()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(709, 581, 701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 652, 690);

                return f_709_659_689(4);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(709, 581, 701);

                Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                f_709_659_689(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 659, 689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 581, 701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 581, 701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTriviaList Create(IEnumerable<SyntaxTrivia>? trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(709, 713, 1058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 810, 907) || true) && (trivia == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 810, 907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 862, 892);

                    return f_709_869_891();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(709, 810, 907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 923, 970);

                var
                builder = f_709_937_969()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 984, 1009);

                f_709_984_1008(builder, trivia);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1023, 1047);

                return f_709_1030_1046(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(709, 713, 1058);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_709_869_891()
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 869, 891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                f_709_937_969()
                {
                    var return_v = SyntaxTriviaListBuilder.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 937, 969);
                    return return_v;
                }


                int
                f_709_984_1008(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 984, 1008);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_709_1030_1046(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 1030, 1046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 713, 1058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 713, 1058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 1111, 1133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1117, 1131);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(709, 1111, 1133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 1070, 1144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 1070, 1144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 1156, 1222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1200, 1211);

                _count = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 1156, 1222);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 1156, 1222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 1156, 1222);
            }
        }

        public SyntaxTrivia this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 1294, 1515);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1330, 1459) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(709, 1334, 1361) || index > _count))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 1330, 1459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1403, 1440);

                        throw f_709_1409_1439();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(709, 1330, 1459);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1479, 1500);

                    return _nodes[index];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(709, 1294, 1515);

                    System.IndexOutOfRangeException
                    f_709_1409_1439()
                    {
                        var return_v = new System.IndexOutOfRangeException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 1409, 1439);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 1294, 1515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 1294, 1515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void AddRange(IEnumerable<SyntaxTrivia>? items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 1538, 1796);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1617, 1785) || true) && (items != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 1617, 1785);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1668, 1770);
                        foreach (var item in f_709_1689_1694_I(items))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 1668, 1770);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1736, 1751);

                            f_709_1736_1750(this, item);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(709, 1668, 1770);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(709, 1, 103);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(709, 1, 103);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(709, 1617, 1785);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 1538, 1796);

                Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                f_709_1736_1750(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 1736, 1750);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_709_1689_1694_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 1689, 1694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 1538, 1796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 1538, 1796);
            }
        }

        public SyntaxTriviaListBuilder Add(SyntaxTrivia item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 1808, 2086);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1886, 2009) || true) && (_count >= f_709_1900_1913(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 1886, 2009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 1947, 1994);

                    f_709_1947_1993(this, (DynAbs.Tracing.TraceSender.Conditional_F1(709, 1957, 1968) || ((_count == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(709, 1971, 1972)) || DynAbs.Tracing.TraceSender.Conditional_F3(709, 1975, 1992))) ? 8 : f_709_1975_1988(_nodes) * 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(709, 1886, 2009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2025, 2049);

                _nodes[_count++] = item;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2063, 2075);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 1808, 2086);

                int
                f_709_1900_1913(Microsoft.CodeAnalysis.SyntaxTrivia[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(709, 1900, 1913);
                    return return_v;
                }


                int
                f_709_1975_1988(Microsoft.CodeAnalysis.SyntaxTrivia[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(709, 1975, 1988);
                    return return_v;
                }


                int
                f_709_1947_1993(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 1947, 1993);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 1808, 2086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 1808, 2086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Add(SyntaxTrivia[] items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 2098, 2204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2160, 2193);

                f_709_2160_2192(this, items, 0, f_709_2179_2191(items));
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 2098, 2204);

                int
                f_709_2179_2191(Microsoft.CodeAnalysis.SyntaxTrivia[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(709, 2179, 2191);
                    return return_v;
                }


                int
                f_709_2160_2192(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia[]
                items, int
                offset, int
                length)
                {
                    this_param.Add(items, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 2160, 2192);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 2098, 2204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 2098, 2204);
            }
        }

        public void Add(SyntaxTrivia[] items, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 2216, 2521);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2302, 2413) || true) && (_count + length > f_709_2324_2337(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 2302, 2413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2371, 2398);

                    f_709_2371_2397(this, _count + length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(709, 2302, 2413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2429, 2479);

                f_709_2429_2478(items, offset, _nodes, _count, length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2493, 2510);

                _count += length;
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 2216, 2521);

                int
                f_709_2324_2337(Microsoft.CodeAnalysis.SyntaxTrivia[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(709, 2324, 2337);
                    return return_v;
                }


                int
                f_709_2371_2397(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 2371, 2397);
                    return 0;
                }


                int
                f_709_2429_2478(Microsoft.CodeAnalysis.SyntaxTrivia[]
                sourceArray, int
                sourceIndex, Microsoft.CodeAnalysis.SyntaxTrivia[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 2429, 2478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 2216, 2521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 2216, 2521);
            }
        }

        public void Add(in SyntaxTriviaList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 2533, 2640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2599, 2629);

                f_709_2599_2628(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 2533, 2640);

                int
                f_709_2599_2628(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, int
                offset, int
                length)
                {
                    this_param.Add(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 2599, 2628);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 2533, 2640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 2533, 2640);
            }
        }

        public void Add(in SyntaxTriviaList list, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 2652, 2955);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2742, 2853) || true) && (_count + length > f_709_2764_2777(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 2742, 2853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2811, 2838);

                    f_709_2811_2837(this, _count + length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(709, 2742, 2853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2869, 2913);

                list.CopyTo(offset, _nodes, _count, length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 2927, 2944);

                _count += length;
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 2652, 2955);

                int
                f_709_2764_2777(Microsoft.CodeAnalysis.SyntaxTrivia[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(709, 2764, 2777);
                    return return_v;
                }


                int
                f_709_2811_2837(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 2811, 2837);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 2652, 2955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 2652, 2955);
            }
        }

        private void Grow(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 2967, 3143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3019, 3052);

                var
                tmp = new SyntaxTrivia[size]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3066, 3105);

                f_709_3066_3104(_nodes, tmp, f_709_3090_3103(_nodes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3119, 3132);

                _nodes = tmp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 2967, 3143);

                int
                f_709_3090_3103(Microsoft.CodeAnalysis.SyntaxTrivia[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(709, 3090, 3103);
                    return return_v;
                }


                int
                f_709_3066_3104(Microsoft.CodeAnalysis.SyntaxTrivia[]
                sourceArray, Microsoft.CodeAnalysis.SyntaxTrivia[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 3066, 3104);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 2967, 3143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 2967, 3143);
            }
        }

        public static implicit operator SyntaxTriviaList(SyntaxTriviaListBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(709, 3155, 3296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3261, 3285);

                return f_709_3268_3284(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(709, 3155, 3296);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_709_3268_3284(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 3268, 3284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 3155, 3296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 3155, 3296);
            }
        }
        public SyntaxTriviaList ToList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(709, 3308, 4980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3365, 4969) || true) && (_count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 3365, 4969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3413, 4855);

                    switch (_count)
                    {

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 3413, 4855);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3502, 3601);

                            return f_709_3509_3600(default(SyntaxToken), _nodes[0].UnderlyingNode, position: 0, index: 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(709, 3413, 4855);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 3413, 4855);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3656, 3903);

                            return f_709_3663_3902(default(SyntaxToken), f_709_3735_3878(_nodes[0].UnderlyingNode!, _nodes[1].UnderlyingNode!), position: 0, index: 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(709, 3413, 4855);

                        case 3:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 3413, 4855);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 3958, 4302);

                            return f_709_3965_4301(default(SyntaxToken), f_709_4037_4248(_nodes[0].UnderlyingNode!, _nodes[1].UnderlyingNode!, _nodes[2].UnderlyingNode!), position: 0, index: 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(709, 3413, 4855);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 3413, 4855);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 4389, 4435);

                                var
                                tmp = new ArrayElement<GreenNode>[_count]
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 4474, 4479);
                                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 4465, 4634) || true) && (i < _count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 4493, 4496)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(709, 4465, 4634))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 4465, 4634);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 4562, 4603);

                                        tmp[i].Value = _nodes[i].UnderlyingNode!;
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(709, 1, 170);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(709, 1, 170);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 4666, 4809);

                                return f_709_4673_4808(default(SyntaxToken), f_709_4749_4784(tmp), position: 0, index: 0);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(709, 3413, 4855);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(709, 3365, 4969);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(709, 3365, 4969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(709, 4921, 4954);

                    return default(SyntaxTriviaList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(709, 3365, 4969);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(709, 3308, 4980);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_709_3509_3600(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode?
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 3509, 3600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_709_3735_3878(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1)
                {
                    var return_v = InternalSyntax.SyntaxList.List(child0, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 3735, 3878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_709_3663_3902(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, (Microsoft.CodeAnalysis.GreenNode)node, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 3663, 3902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_709_4037_4248(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2)
                {
                    var return_v = InternalSyntax.SyntaxList.List(child0, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 4037, 4248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_709_3965_4301(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, (Microsoft.CodeAnalysis.GreenNode)node, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 3965, 4301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_709_4749_4784(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = InternalSyntax.SyntaxList.List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 4749, 4784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_709_4673_4808(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, (Microsoft.CodeAnalysis.GreenNode)node, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(709, 4673, 4808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(709, 3308, 4980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 3308, 4980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxTriviaListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(709, 335, 4987);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(709, 335, 4987);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(709, 335, 4987);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(709, 335, 4987);
    }
}
