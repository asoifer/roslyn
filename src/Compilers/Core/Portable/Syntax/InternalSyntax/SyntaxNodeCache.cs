// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Syntax.InternalSyntax;

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal class GreenStats
    {
        internal static void NoteGreen(GreenNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 3798, 3866);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 3798, 3866);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 3798, 3866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 3798, 3866);
            }
        }

        [Conditional("DEBUG")]
        internal static void ItemAdded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 3878, 3964);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 3878, 3964);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 3878, 3964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 3878, 3964);
            }
        }

        [Conditional("DEBUG")]
        internal static void ItemCacheable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 3976, 4066);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 3976, 4066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 3976, 4066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 3976, 4066);
            }
        }

        [Conditional("DEBUG")]
        internal static void CacheHit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 4078, 4163);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 4078, 4163);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 4078, 4163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 4078, 4163);
            }
        }

        public GreenStats()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(836, 2214, 4178);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(836, 2214, 4178);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 2214, 4178);
        }


        static GreenStats()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(836, 2214, 4178);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(836, 2214, 4178);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 2214, 4178);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(836, 2214, 4178);
    }
    internal static class SyntaxNodeCache
    {
        private const int
        CacheSizeBits = 16
        ;

        private const int
        CacheSize = 1 << CacheSizeBits
        ;

        private const int
        CacheMask = CacheSize - 1
        ;

        private readonly struct Entry
        {

            public readonly int hash;

            public readonly GreenNode? node;

            internal Entry(int hash, GreenNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(836, 4543, 4683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4616, 4633);

                    this.hash = hash;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4651, 4668);

                    this.node = node;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(836, 4543, 4683);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 4543, 4683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 4543, 4683);
                }
            }
            static Entry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(836, 4402, 4694);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(836, 4402, 4694);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 4402, 4694);
            }
        }

        private static readonly Entry[] s_cache;

        internal static void AddNode(GreenNode node, int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 4781, 5154);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4860, 5143) || true) && (f_836_4864_4888(node) && (DynAbs.Tracing.TraceSender.Expression_True(836, 4864, 4907) && f_836_4892_4907_M(!node.IsMissing)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 4860, 5143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4941, 4964);

                    f_836_4941_4963();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4984, 5026);

                    f_836_4984_5025(f_836_4997_5016(node) == hash);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 5046, 5073);

                    var
                    idx = hash & CacheMask
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 5091, 5128);

                    s_cache[idx] = f_836_5106_5127(hash, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 4860, 5143);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 4781, 5154);

                bool
                f_836_4864_4888(Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = AllChildrenInCache(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 4864, 4888);
                    return return_v;
                }


                bool
                f_836_4892_4907_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(836, 4892, 4907);
                    return return_v;
                }


                int
                f_836_4941_4963()
                {
                    GreenStats.ItemAdded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 4941, 4963);
                    return 0;
                }


                int
                f_836_4997_5016(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetCacheHash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 4997, 5016);
                    return return_v;
                }


                int
                f_836_4984_5025(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 4984, 5025);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache.Entry
                f_836_5106_5127(int
                hash, Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxNodeCache.Entry(hash, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 5106, 5127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 4781, 5154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 4781, 5154);
            }
        }

        private static bool CanBeCached(GreenNode? child1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 5166, 5296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 5241, 5285);

                return child1 == null || (DynAbs.Tracing.TraceSender.Expression_False(836, 5248, 5284) || f_836_5266_5284(child1));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 5166, 5296);

                bool
                f_836_5266_5284(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsCacheable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(836, 5266, 5284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 5166, 5296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 5166, 5296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CanBeCached(GreenNode? child1, GreenNode? child2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 5308, 5463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 5402, 5452);

                return f_836_5409_5428(child1) && (DynAbs.Tracing.TraceSender.Expression_True(836, 5409, 5451) && f_836_5432_5451(child2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 5308, 5463);

                bool
                f_836_5409_5428(Microsoft.CodeAnalysis.GreenNode?
                child1)
                {
                    var return_v = CanBeCached(child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 5409, 5428);
                    return return_v;
                }


                bool
                f_836_5432_5451(Microsoft.CodeAnalysis.GreenNode?
                child1)
                {
                    var return_v = CanBeCached(child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 5432, 5451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 5308, 5463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 5308, 5463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CanBeCached(GreenNode? child1, GreenNode? child2, GreenNode? child3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 5475, 5672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 5588, 5661);

                return f_836_5595_5614(child1) && (DynAbs.Tracing.TraceSender.Expression_True(836, 5595, 5637) && f_836_5618_5637(child2)) && (DynAbs.Tracing.TraceSender.Expression_True(836, 5595, 5660) && f_836_5641_5660(child3));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 5475, 5672);

                bool
                f_836_5595_5614(Microsoft.CodeAnalysis.GreenNode?
                child1)
                {
                    var return_v = CanBeCached(child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 5595, 5614);
                    return return_v;
                }


                bool
                f_836_5618_5637(Microsoft.CodeAnalysis.GreenNode?
                child1)
                {
                    var return_v = CanBeCached(child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 5618, 5637);
                    return return_v;
                }


                bool
                f_836_5641_5660(Microsoft.CodeAnalysis.GreenNode?
                child1)
                {
                    var return_v = CanBeCached(child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 5641, 5660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 5475, 5672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 5475, 5672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ChildInCache(GreenNode? child)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 5684, 6143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 5940, 5995) || true) && (child == null || (DynAbs.Tracing.TraceSender.Expression_False(836, 5944, 5981) || f_836_5961_5976(child) == 0))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 5940, 5995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 5983, 5995);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 5940, 5995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6011, 6043);

                int
                hash = f_836_6022_6042(child)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6057, 6084);

                int
                idx = hash & CacheMask
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6098, 6132);

                return s_cache[idx].node == child;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 5684, 6143);

                int
                f_836_5961_5976(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(836, 5961, 5976);
                    return return_v;
                }


                int
                f_836_6022_6042(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetCacheHash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 6022, 6042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 5684, 6143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 5684, 6143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AllChildrenInCache(GreenNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 6155, 6540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6277, 6302);

                var
                cnt = f_836_6287_6301(node)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6325, 6330);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6316, 6501) || true) && (i < cnt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6341, 6344)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(836, 6316, 6501))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 6316, 6501);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6378, 6486) || true) && (!f_836_6383_6412(f_836_6396_6411(node, i)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 6378, 6486);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6454, 6467);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(836, 6378, 6486);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(836, 1, 186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(836, 1, 186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6517, 6529);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 6155, 6540);

                int
                f_836_6287_6301(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(836, 6287, 6301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_836_6396_6411(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 6396, 6411);
                    return return_v;
                }


                bool
                f_836_6383_6412(Microsoft.CodeAnalysis.GreenNode?
                child)
                {
                    var return_v = ChildInCache(child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 6383, 6412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 6155, 6540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 6155, 6540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode? TryGetNode(int kind, GreenNode? child1, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 6552, 6733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6657, 6722);

                return f_836_6664_6721(kind, child1, f_836_6689_6710(), out hash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 6552, 6733);

                Microsoft.CodeAnalysis.GreenNode.NodeFlags
                f_836_6689_6710()
                {
                    var return_v = GetDefaultNodeFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 6689, 6710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_836_6664_6721(int
                kind, Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, out int
                hash)
                {
                    var return_v = TryGetNode(kind, child1, flags, out hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 6664, 6721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 6552, 6733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 6552, 6733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode? TryGetNode(int kind, GreenNode? child1, GreenNode.NodeFlags flags, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 6745, 7460);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6877, 7421) || true) && (f_836_6881_6900(child1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 6877, 7421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6934, 6961);

                    f_836_6934_6960();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 6981, 7030);

                    int
                    h = hash = f_836_6996_7029(kind, flags, child1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7048, 7072);

                    int
                    idx = h & CacheMask
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7090, 7111);

                    var
                    e = s_cache[idx]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7129, 7330) || true) && (e.hash == h && (DynAbs.Tracing.TraceSender.Expression_True(836, 7133, 7162) && e.node != null) && (DynAbs.Tracing.TraceSender.Expression_True(836, 7133, 7211) && f_836_7166_7211(e.node, kind, flags, child1)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 7129, 7330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7253, 7275);

                        f_836_7253_7274();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7297, 7311);

                        return e.node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(836, 7129, 7330);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 6877, 7421);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 6877, 7421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7396, 7406);

                    hash = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 6877, 7421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7437, 7449);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 6745, 7460);

                bool
                f_836_6881_6900(Microsoft.CodeAnalysis.GreenNode?
                child1)
                {
                    var return_v = CanBeCached(child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 6881, 6900);
                    return return_v;
                }


                int
                f_836_6934_6960()
                {
                    GreenStats.ItemCacheable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 6934, 6960);
                    return 0;
                }


                int
                f_836_6996_7029(int
                kind, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, Microsoft.CodeAnalysis.GreenNode?
                child1)
                {
                    var return_v = GetCacheHash(kind, flags, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 6996, 7029);
                    return return_v;
                }


                bool
                f_836_7166_7211(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                kind, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, Microsoft.CodeAnalysis.GreenNode?
                child1)
                {
                    var return_v = this_param.IsCacheEquivalent(kind, flags, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 7166, 7211);
                    return return_v;
                }


                int
                f_836_7253_7274()
                {
                    GreenStats.CacheHit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 7253, 7274);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 6745, 7460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 6745, 7460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode? TryGetNode(int kind, GreenNode? child1, GreenNode? child2, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 7472, 7680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7596, 7669);

                return f_836_7603_7668(kind, child1, child2, f_836_7636_7657(), out hash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 7472, 7680);

                Microsoft.CodeAnalysis.GreenNode.NodeFlags
                f_836_7636_7657()
                {
                    var return_v = GetDefaultNodeFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 7636, 7657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_836_7603_7668(int
                kind, Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode?
                child2, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, out int
                hash)
                {
                    var return_v = TryGetNode(kind, child1, child2, flags, out hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 7603, 7668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 7472, 7680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 7472, 7680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode? TryGetNode(int kind, GreenNode? child1, GreenNode? child2, GreenNode.NodeFlags flags, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 7692, 8450);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7843, 8411) || true) && (f_836_7847_7874(child1, child2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 7843, 8411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7908, 7935);

                    f_836_7908_7934();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 7955, 8012);

                    int
                    h = hash = f_836_7970_8011(kind, flags, child1, child2)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8030, 8054);

                    int
                    idx = h & CacheMask
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8072, 8093);

                    var
                    e = s_cache[idx]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8111, 8320) || true) && (e.hash == h && (DynAbs.Tracing.TraceSender.Expression_True(836, 8115, 8144) && e.node != null) && (DynAbs.Tracing.TraceSender.Expression_True(836, 8115, 8201) && f_836_8148_8201(e.node, kind, flags, child1, child2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 8111, 8320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8243, 8265);

                        f_836_8243_8264();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8287, 8301);

                        return e.node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(836, 8111, 8320);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 7843, 8411);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 7843, 8411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8386, 8396);

                    hash = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 7843, 8411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8427, 8439);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 7692, 8450);

                bool
                f_836_7847_7874(Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode?
                child2)
                {
                    var return_v = CanBeCached(child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 7847, 7874);
                    return return_v;
                }


                int
                f_836_7908_7934()
                {
                    GreenStats.ItemCacheable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 7908, 7934);
                    return 0;
                }


                int
                f_836_7970_8011(int
                kind, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode?
                child2)
                {
                    var return_v = GetCacheHash(kind, flags, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 7970, 8011);
                    return return_v;
                }


                bool
                f_836_8148_8201(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                kind, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode?
                child2)
                {
                    var return_v = this_param.IsCacheEquivalent(kind, flags, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 8148, 8201);
                    return return_v;
                }


                int
                f_836_8243_8264()
                {
                    GreenStats.CacheHit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 8243, 8264);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 7692, 8450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 7692, 8450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode? TryGetNode(int kind, GreenNode? child1, GreenNode? child2, GreenNode? child3, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 8462, 8697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8605, 8686);

                return f_836_8612_8685(kind, child1, child2, child3, f_836_8653_8674(), out hash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 8462, 8697);

                Microsoft.CodeAnalysis.GreenNode.NodeFlags
                f_836_8653_8674()
                {
                    var return_v = GetDefaultNodeFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 8653, 8674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_836_8612_8685(int
                kind, Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode?
                child2, Microsoft.CodeAnalysis.GreenNode?
                child3, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, out int
                hash)
                {
                    var return_v = TryGetNode(kind, child1, child2, child3, flags, out hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 8612, 8685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 8462, 8697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 8462, 8697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode? TryGetNode(int kind, GreenNode? child1, GreenNode? child2, GreenNode? child3, GreenNode.NodeFlags flags, out int hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 8709, 9510);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8879, 9471) || true) && (f_836_8883_8918(child1, child2, child3))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 8879, 9471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8952, 8979);

                    f_836_8952_8978();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 8999, 9064);

                    int
                    h = hash = f_836_9014_9063(kind, flags, child1, child2, child3)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9082, 9106);

                    int
                    idx = h & CacheMask
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9124, 9145);

                    var
                    e = s_cache[idx]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9163, 9380) || true) && (e.hash == h && (DynAbs.Tracing.TraceSender.Expression_True(836, 9167, 9196) && e.node != null) && (DynAbs.Tracing.TraceSender.Expression_True(836, 9167, 9261) && f_836_9200_9261(e.node, kind, flags, child1, child2, child3)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 9163, 9380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9303, 9325);

                        f_836_9303_9324();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9347, 9361);

                        return e.node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(836, 9163, 9380);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 8879, 9471);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 8879, 9471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9446, 9456);

                    hash = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 8879, 9471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9487, 9499);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 8709, 9510);

                bool
                f_836_8883_8918(Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode?
                child2, Microsoft.CodeAnalysis.GreenNode?
                child3)
                {
                    var return_v = CanBeCached(child1, child2, child3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 8883, 8918);
                    return return_v;
                }


                int
                f_836_8952_8978()
                {
                    GreenStats.ItemCacheable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 8952, 8978);
                    return 0;
                }


                int
                f_836_9014_9063(int
                kind, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode?
                child2, Microsoft.CodeAnalysis.GreenNode?
                child3)
                {
                    var return_v = GetCacheHash(kind, flags, child1, child2, child3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 9014, 9063);
                    return return_v;
                }


                bool
                f_836_9200_9261(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                kind, Microsoft.CodeAnalysis.GreenNode.NodeFlags
                flags, Microsoft.CodeAnalysis.GreenNode?
                child1, Microsoft.CodeAnalysis.GreenNode?
                child2, Microsoft.CodeAnalysis.GreenNode?
                child3)
                {
                    var return_v = this_param.IsCacheEquivalent(kind, flags, child1, child2, child3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 9200, 9261);
                    return return_v;
                }


                int
                f_836_9303_9324()
                {
                    GreenStats.CacheHit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 9303, 9324);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 8709, 9510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 8709, 9510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static GreenNode.NodeFlags GetDefaultNodeFlags()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 9522, 9653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9602, 9642);

                return GreenNode.NodeFlags.IsNotMissing;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 9522, 9653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 9522, 9653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 9522, 9653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetCacheHash(int kind, GreenNode.NodeFlags flags, GreenNode? child1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 9665, 10120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9777, 9808);

                int
                code = (int)(flags) ^ kind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 9929, 10024);

                code = f_836_9936_10023(f_836_9949_10016(child1!), code);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10080, 10109);

                return code & Int32.MaxValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 9665, 10120);

                int
                f_836_9949_10016(Microsoft.CodeAnalysis.GreenNode
                o)
                {
                    var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 9949, 10016);
                    return return_v;
                }


                int
                f_836_9936_10023(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 9936, 10023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 9665, 10120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 9665, 10120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetCacheHash(int kind, GreenNode.NodeFlags flags, GreenNode? child1, GreenNode? child2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 10132, 10742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10263, 10294);

                int
                code = (int)(flags) ^ kind
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10310, 10471) || true) && (child1 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 10310, 10471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10362, 10456);

                    code = f_836_10369_10455(f_836_10382_10448(child1), code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 10310, 10471);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10485, 10646) || true) && (child2 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 10485, 10646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10537, 10631);

                    code = f_836_10544_10630(f_836_10557_10623(child2), code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 10485, 10646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10702, 10731);

                return code & Int32.MaxValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 10132, 10742);

                int
                f_836_10382_10448(Microsoft.CodeAnalysis.GreenNode
                o)
                {
                    var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 10382, 10448);
                    return return_v;
                }


                int
                f_836_10369_10455(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 10369, 10455);
                    return return_v;
                }


                int
                f_836_10557_10623(Microsoft.CodeAnalysis.GreenNode
                o)
                {
                    var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 10557, 10623);
                    return return_v;
                }


                int
                f_836_10544_10630(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 10544, 10630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 10132, 10742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 10132, 10742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetCacheHash(int kind, GreenNode.NodeFlags flags, GreenNode? child1, GreenNode? child2, GreenNode? child3)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(836, 10754, 11558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10904, 10935);

                int
                code = (int)(flags) ^ kind
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 10951, 11112) || true) && (child1 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 10951, 11112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 11003, 11097);

                    code = f_836_11010_11096(f_836_11023_11089(child1), code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 10951, 11112);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 11126, 11287) || true) && (child2 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 11126, 11287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 11178, 11272);

                    code = f_836_11185_11271(f_836_11198_11264(child2), code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 11126, 11287);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 11301, 11462) || true) && (child3 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(836, 11301, 11462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 11353, 11447);

                    code = f_836_11360_11446(f_836_11373_11439(child3), code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(836, 11301, 11462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 11518, 11547);

                return code & Int32.MaxValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(836, 10754, 11558);

                int
                f_836_11023_11089(Microsoft.CodeAnalysis.GreenNode
                o)
                {
                    var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 11023, 11089);
                    return return_v;
                }


                int
                f_836_11010_11096(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 11010, 11096);
                    return return_v;
                }


                int
                f_836_11198_11264(Microsoft.CodeAnalysis.GreenNode
                o)
                {
                    var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 11198, 11264);
                    return return_v;
                }


                int
                f_836_11185_11271(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 11185, 11271);
                    return return_v;
                }


                int
                f_836_11373_11439(Microsoft.CodeAnalysis.GreenNode
                o)
                {
                    var return_v = System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 11373, 11439);
                    return return_v;
                }


                int
                f_836_11360_11446(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(836, 11360, 11446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(836, 10754, 11558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 10754, 11558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxNodeCache()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(836, 4186, 11565);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4258, 4276);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4305, 4335);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4364, 4389);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(836, 4738, 4768);
            s_cache = new Entry[CacheSize]; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(836, 4186, 11565);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(836, 4186, 11565);
        }

    }
}
