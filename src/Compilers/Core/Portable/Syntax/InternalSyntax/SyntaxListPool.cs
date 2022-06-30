// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal class SyntaxListPool
    {
        private ArrayElement<SyntaxListBuilder?>[] _freeList;

        private int _freeIndex;

        private readonly List<SyntaxListBuilder> _allocated;

        internal SyntaxListPool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(833, 677, 724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 464, 516);
                this._freeList = new ArrayElement<SyntaxListBuilder?>[10]; DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 539, 549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 614, 656);
                this._allocated = f_833_627_656(); DynAbs.Tracing.TraceSender.TraceExitConstructor(833, 677, 724);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 677, 724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 677, 724);
            }
        }

        internal SyntaxListBuilder Allocate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(833, 736, 1269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 798, 821);

                SyntaxListBuilder
                item
                = default(SyntaxListBuilder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 835, 1121) || true) && (_freeIndex > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(833, 835, 1121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 887, 900);

                    _freeIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 918, 954);

                    item = _freeList[_freeIndex].Value!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 972, 1007);

                    _freeList[_freeIndex].Value = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(833, 835, 1121);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(833, 835, 1121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1073, 1106);

                    item = f_833_1080_1105(10);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(833, 835, 1121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1148, 1189);

                f_833_1148_1188(!f_833_1162_1187(_allocated, item));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1203, 1224);

                f_833_1203_1223(_allocated, item);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1246, 1258);

                return item;
                DynAbs.Tracing.TraceSender.TraceExitMethod(833, 736, 1269);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_833_1080_1105(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1080, 1105);
                    return return_v;
                }


                bool
                f_833_1162_1187(System.Collections.Generic.List<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder>
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1162, 1187);
                    return return_v;
                }


                int
                f_833_1148_1188(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1148, 1188);
                    return 0;
                }


                int
                f_833_1203_1223(System.Collections.Generic.List<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder>
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1203, 1223);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 736, 1269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 736, 1269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxListBuilder<TNode> Allocate<TNode>() where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(833, 1281, 1445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1381, 1434);

                return f_833_1388_1433(f_833_1417_1432(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(833, 1281, 1445);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_833_1417_1432(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1417, 1432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<TNode>
                f_833_1388_1433(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<TNode>(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1388, 1433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 1281, 1445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 1281, 1445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SeparatedSyntaxListBuilder<TNode> AllocateSeparated<TNode>() where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(833, 1457, 1648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1575, 1637);

                return f_833_1582_1636(f_833_1620_1635(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(833, 1457, 1648);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_833_1620_1635(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1620, 1635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<TNode>
                f_833_1582_1636(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<TNode>(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1582, 1636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 1457, 1648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 1457, 1648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Free<TNode>(in SeparatedSyntaxListBuilder<TNode> item) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(833, 1660, 1884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1777, 1830);

                f_833_1777_1829(item.UnderlyingBuilder is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1844, 1873);

                f_833_1844_1872(this, item.UnderlyingBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(833, 1660, 1884);

                int
                f_833_1777_1829(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1777, 1829);
                    return 0;
                }


                int
                f_833_1844_1872(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                item)
                {
                    this_param.Free(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1844, 1872);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 1660, 1884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 1660, 1884);
            }
        }

        internal void Free(SyntaxListBuilder item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(833, 1896, 2285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1963, 1976);

                f_833_1963_1975(item);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 1990, 2085) || true) && (_freeIndex >= f_833_2008_2024(_freeList))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(833, 1990, 2085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2058, 2070);

                    f_833_2058_2069(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(833, 1990, 2085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2110, 2150);

                f_833_2110_2149(f_833_2123_2148(_allocated, item));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2166, 2190);

                f_833_2166_2189(
                            _allocated, item);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2212, 2247);

                _freeList[_freeIndex].Value = item;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2261, 2274);

                _freeIndex++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(833, 1896, 2285);

                int
                f_833_1963_1975(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 1963, 1975);
                    return 0;
                }


                int
                f_833_2008_2024(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(833, 2008, 2024);
                    return return_v;
                }


                int
                f_833_2058_2069(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param)
                {
                    this_param.Grow();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 2058, 2069);
                    return 0;
                }


                bool
                f_833_2123_2148(System.Collections.Generic.List<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder>
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 2123, 2148);
                    return return_v;
                }


                int
                f_833_2110_2149(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 2110, 2149);
                    return 0;
                }


                bool
                f_833_2166_2189(System.Collections.Generic.List<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder>
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 2166, 2189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 1896, 2285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 1896, 2285);
            }
        }

        private void Grow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(833, 2297, 2510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2341, 2410);

                var
                tmp = new ArrayElement<SyntaxListBuilder?>[f_833_2388_2404(_freeList) * 2]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2424, 2469);

                f_833_2424_2468(_freeList, tmp, f_833_2451_2467(_freeList));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2483, 2499);

                _freeList = tmp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(833, 2297, 2510);

                int
                f_833_2388_2404(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(833, 2388, 2404);
                    return return_v;
                }


                int
                f_833_2451_2467(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(833, 2451, 2467);
                    return return_v;
                }


                int
                f_833_2424_2468(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?>[]
                sourceArray, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?>[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 2424, 2468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 2297, 2510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 2297, 2510);
            }
        }

        public SyntaxList<TNode> ToListAndFree<TNode>(SyntaxListBuilder<TNode> item)
                    where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(833, 2522, 2747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2660, 2685);

                var
                list = item.ToList()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2699, 2710);

                f_833_2699_2709(this, item);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2724, 2736);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(833, 2522, 2747);

                int
                f_833_2699_2709(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<TNode>
                item)
                {
                    this_param.Free((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 2699, 2709);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 2522, 2747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 2522, 2747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TNode> ToListAndFree<TNode>(in SeparatedSyntaxListBuilder<TNode> item)
                    where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(833, 2759, 3005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2918, 2943);

                var
                list = item.ToList()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2957, 2968);

                f_833_2957_2967(this, item);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(833, 2982, 2994);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(833, 2759, 3005);

                int
                f_833_2957_2967(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListPool
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<TNode>
                item)
                {
                    this_param.Free<TNode>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 2957, 2967);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(833, 2759, 3005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 2759, 3005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxListPool()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(833, 375, 3012);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(833, 375, 3012);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(833, 375, 3012);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(833, 375, 3012);

        System.Collections.Generic.List<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder>
        f_833_627_656()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(833, 627, 656);
            return return_v;
        }

    }
}
