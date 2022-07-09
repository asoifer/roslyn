// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax
{

    internal struct SyntaxListBuilder<TNode> where TNode : SyntaxNode
    {

        private readonly SyntaxListBuilder? _builder;

        public SyntaxListBuilder(int size)
        : this(f_683_450_477_C(f_683_450_477(size)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(683, 395, 500);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(683, 395, 500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 395, 500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 395, 500);
            }
        }

        public static SyntaxListBuilder<TNode> Create()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(683, 512, 634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 584, 623);

                return f_683_591_622(8);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(683, 512, 634);

                Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder<TNode>
                f_683_591_622(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder<TNode>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 591, 622);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 512, 634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 512, 634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxListBuilder(SyntaxListBuilder? builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(683, 646, 755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 725, 744);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(683, 646, 755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 646, 755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 646, 755);
            }
        }

        public bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 810, 885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 846, 870);

                    return _builder == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(683, 810, 885);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 767, 896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 767, 896);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 949, 1023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 985, 1008);

                    return f_683_992_1007(_builder!);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(683, 949, 1023);

                    int
                    f_683_992_1007(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(683, 992, 1007);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 908, 1034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 908, 1034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 1046, 1119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 1090, 1108);

                f_683_1090_1107(_builder!);
                DynAbs.Tracing.TraceSender.TraceExitMethod(683, 1046, 1119);

                int
                f_683_1090_1107(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 1090, 1107);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 1046, 1119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 1046, 1119);
            }
        }

        public SyntaxListBuilder<TNode> Add(TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 1131, 1260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 1203, 1223);

                f_683_1203_1222(_builder!, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 1237, 1249);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(683, 1131, 1260);

                int
                f_683_1203_1222(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, TNode
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 1203, 1222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 1131, 1260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 1131, 1260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void AddRange(TNode[] items, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 1272, 1409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 1356, 1398);

                f_683_1356_1397(_builder!, items, offset, length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(683, 1272, 1409);

                int
                f_683_1356_1397(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, TNode[]
                items, int
                offset, int
                length)
                {
                    this_param.AddRange((Microsoft.CodeAnalysis.SyntaxNode[])items, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 1356, 1397);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 1272, 1409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 1272, 1409);
            }
        }

        public void AddRange(SyntaxList<TNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 1421, 1528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 1491, 1517);

                f_683_1491_1516(_builder!, nodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(683, 1421, 1528);

                int
                f_683_1491_1516(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxList<TNode>
                list)
                {
                    this_param.AddRange<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 1491, 1516);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 1421, 1528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 1421, 1528);
            }
        }

        public void AddRange(SyntaxList<TNode> nodes, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 1540, 1687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 1634, 1676);

                f_683_1634_1675(_builder!, nodes, offset, length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(683, 1540, 1687);

                int
                f_683_1634_1675(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxList<TNode>
                list, int
                offset, int
                count)
                {
                    this_param.AddRange<TNode>(list, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 1634, 1675);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 1540, 1687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 1540, 1687);
            }
        }

        public bool Any(int kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 1699, 1787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 1749, 1776);

                return f_683_1756_1775(_builder!, kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(683, 1699, 1787);

                bool
                f_683_1756_1775(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, int
                kind)
                {
                    var return_v = this_param.Any(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 1756, 1775);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 1699, 1787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 1699, 1787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<TNode> ToList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(683, 1799, 1893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 1857, 1882);

                return f_683_1864_1881(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(683, 1799, 1893);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                f_683_1864_1881(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder?
                builder)
                {
                    var return_v = builder.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 1864, 1881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 1799, 1893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 1799, 1893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator SyntaxListBuilder?(SyntaxListBuilder<TNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(683, 1905, 2049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 2014, 2038);

                return builder._builder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(683, 1905, 2049);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 1905, 2049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 1905, 2049);
            }
        }
        public static implicit operator SyntaxList<TNode>(SyntaxListBuilder<TNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(683, 2061, 2312);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 2169, 2270) || true) && (builder._builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(683, 2169, 2270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 2231, 2255);

                    return builder.ToList();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(683, 2169, 2270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(683, 2286, 2301);

                return default;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(683, 2061, 2312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(683, 2061, 2312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 2061, 2312);
            }
        }
        static SyntaxListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(683, 256, 2319);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(683, 256, 2319);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(683, 256, 2319);
        }

        static Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
        f_683_450_477(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(683, 450, 477);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
        f_683_450_477_C(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(683, 395, 500);
            return return_v;
        }

    }
}
