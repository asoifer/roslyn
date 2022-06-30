// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal struct SyntaxListBuilder<TNode> where TNode : GreenNode
    {

        private readonly SyntaxListBuilder _builder;

        public SyntaxListBuilder(int size)
        : this(f_832_463_490_C(f_832_463_490(size)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(832, 408, 513);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(832, 408, 513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 408, 513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 408, 513);
            }
        }

        public static SyntaxListBuilder<TNode> Create()
        {
            return new SyntaxListBuilder<TNode>(8);
        }

        internal SyntaxListBuilder(SyntaxListBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(832, 659, 767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 737, 756);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(832, 659, 767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 659, 767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 659, 767);
            }
        }

        public bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 822, 897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 858, 882);

                    return _builder == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(832, 822, 897);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 779, 908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 779, 908);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 961, 1034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 997, 1019);

                    return f_832_1004_1018(_builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(832, 961, 1034);

                    int
                    f_832_1004_1018(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(832, 1004, 1018);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 920, 1045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 920, 1045);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 1111, 1193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 1147, 1178);

                    return (TNode?)f_832_1162_1177(_builder, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(832, 1111, 1193);

                    Microsoft.CodeAnalysis.GreenNode?
                    f_832_1162_1177(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(832, 1162, 1177);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 1111, 1193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 1111, 1193);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 1209, 1284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 1245, 1269);

                    _builder[index] = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(832, 1209, 1284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 1209, 1284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 1209, 1284);
                }
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 1307, 1379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 1351, 1368);

                f_832_1351_1367(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(832, 1307, 1379);

                int
                f_832_1351_1367(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(832, 1351, 1367);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 1307, 1379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 1307, 1379);
            }
        }

        public SyntaxListBuilder<TNode> Add(TNode node)
        {
            _builder.Add(node);
            return this;
        }

        public void AddRange(TNode[] items, int offset, int length)
        {
            _builder.AddRange(items, offset, length);
        }

        public void AddRange(SyntaxList<TNode> nodes)
        {
            _builder.AddRange(nodes);
        }

        public void AddRange(SyntaxList<TNode> nodes, int offset, int length)
        {
            _builder.AddRange(nodes, offset, length);
        }

        public bool Any(int kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 1955, 2042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 2005, 2031);

                return f_832_2012_2030(_builder, kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(832, 1955, 2042);

                bool
                f_832_2012_2030(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                kind)
                {
                    var return_v = this_param.Any(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(832, 2012, 2030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 1955, 2042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 1955, 2042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<TNode> ToList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 2054, 2148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 2112, 2137);

                return f_832_2119_2136(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(832, 2054, 2148);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_832_2119_2136(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(832, 2119, 2136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 2054, 2148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 2054, 2148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GreenNode? ToListNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 2160, 2255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 2215, 2244);

                return f_832_2222_2243(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(832, 2160, 2255);

                Microsoft.CodeAnalysis.GreenNode?
                f_832_2222_2243(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(832, 2222, 2243);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 2160, 2255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 2160, 2255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator SyntaxListBuilder(SyntaxListBuilder<TNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(832, 2267, 2410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 2375, 2399);

                return builder._builder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(832, 2267, 2410);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 2267, 2410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 2267, 2410);
            }
        }
        public static implicit operator SyntaxList<TNode>(SyntaxListBuilder<TNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(832, 2422, 2692);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 2530, 2631) || true) && (builder._builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(832, 2530, 2631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 2592, 2616);

                    return builder.ToList();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(832, 2530, 2631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 2647, 2681);

                return default(SyntaxList<TNode>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(832, 2422, 2692);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 2422, 2692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 2422, 2692);
            }
        }
        public SyntaxList<TDerived> ToList<TDerived>() where TDerived : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(832, 2704, 2859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(832, 2802, 2848);

                return f_832_2809_2847(ToListNode());
                DynAbs.Tracing.TraceSender.TraceExitMethod(832, 2704, 2859);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TDerived>
                f_832_2809_2847(Microsoft.CodeAnalysis.GreenNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TDerived>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(832, 2809, 2847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(832, 2704, 2859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 2704, 2859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SyntaxListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(832, 271, 2866);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(832, 271, 2866);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(832, 271, 2866);
        }

        static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
        f_832_463_490(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(832, 463, 490);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
        f_832_463_490_C(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(832, 408, 513);
            return return_v;
        }

    }
}
