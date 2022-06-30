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
            return new SyntaxListBuilder<TNode>(8);
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
            _builder!.Add(node);
            return this;
        }

        public void AddRange(TNode[] items, int offset, int length)
        {
            _builder!.AddRange(items, offset, length);
        }

        public void AddRange(SyntaxList<TNode> nodes)
        {
            _builder!.AddRange(nodes);
        }

        public void AddRange(SyntaxList<TNode> nodes, int offset, int length)
        {
            _builder!.AddRange(nodes, offset, length);
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
