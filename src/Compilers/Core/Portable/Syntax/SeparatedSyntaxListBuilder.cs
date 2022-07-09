// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Syntax
{

    internal struct SeparatedSyntaxListBuilder<TNode> where TNode : SyntaxNode
    {

        private readonly SyntaxListBuilder _builder;

        private bool _expectedSeparator;

        public SeparatedSyntaxListBuilder(int size)
        : this(f_671_553_580_C(f_671_553_580(size)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(671, 489, 603);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(671, 489, 603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 489, 603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 489, 603);
            }
        }

        public static SeparatedSyntaxListBuilder<TNode> Create()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(671, 615, 755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 696, 744);

                return f_671_703_743(8);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(671, 615, 755);

                Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder<TNode>
                f_671_703_743(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder<TNode>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 703, 743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 615, 755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 615, 755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SeparatedSyntaxListBuilder(SyntaxListBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(671, 767, 925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 854, 873);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 887, 914);

                _expectedSeparator = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(671, 767, 925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 767, 925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 767, 925);
            }
        }

        public bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 980, 1055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1016, 1040);

                    return _builder == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(671, 980, 1055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 937, 1066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 937, 1066);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 1119, 1192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1155, 1177);

                    return f_671_1162_1176(_builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(671, 1119, 1192);

                    int
                    f_671_1162_1176(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(671, 1162, 1176);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 1078, 1203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 1078, 1203);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 1215, 1287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1259, 1276);

                f_671_1259_1275(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(671, 1215, 1287);

                int
                f_671_1259_1275(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 1259, 1275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 1215, 1287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 1215, 1287);
            }
        }

        private void CheckExpectedElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 1299, 1520);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1359, 1509) || true) && (_expectedSeparator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(671, 1359, 1509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1415, 1494);

                    throw f_671_1421_1493(f_671_1451_1492());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(671, 1359, 1509);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(671, 1299, 1520);

                string
                f_671_1451_1492()
                {
                    var return_v = CodeAnalysisResources.SeparatorIsExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(671, 1451, 1492);
                    return return_v;
                }


                System.InvalidOperationException
                f_671_1421_1493(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 1421, 1493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 1299, 1520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 1299, 1520);
            }
        }

        private void CheckExpectedSeparator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 1532, 1754);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1594, 1743) || true) && (!_expectedSeparator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(671, 1594, 1743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1651, 1728);

                    throw f_671_1657_1727(f_671_1687_1726());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(671, 1594, 1743);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(671, 1532, 1754);

                string
                f_671_1687_1726()
                {
                    var return_v = CodeAnalysisResources.ElementIsExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(671, 1687, 1726);
                    return return_v;
                }


                System.InvalidOperationException
                f_671_1657_1727(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 1657, 1727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 1532, 1754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 1532, 1754);
            }
        }

        public SeparatedSyntaxListBuilder<TNode> Add(TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 1766, 1980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1847, 1870);

                CheckExpectedElement();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1884, 1910);

                _expectedSeparator = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1924, 1943);

                f_671_1924_1942(_builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 1957, 1969);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(671, 1766, 1980);

                int
                f_671_1924_1942(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, TNode
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 1924, 1942);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 1766, 1980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 1766, 1980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxListBuilder<TNode> AddSeparator(in SyntaxToken separatorToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 1992, 2318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2101, 2145);

                f_671_2101_2144(separatorToken.Node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2159, 2184);

                CheckExpectedSeparator();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2198, 2225);

                _expectedSeparator = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2239, 2281);

                f_671_2239_2280(_builder, separatorToken.Node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2295, 2307);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(671, 1992, 2318);

                int
                f_671_2101_2144(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 2101, 2144);
                    return 0;
                }


                int
                f_671_2239_2280(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.AddInternal(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 2239, 2280);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 1992, 2318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 1992, 2318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxListBuilder<TNode> AddRange(in SeparatedSyntaxList<TNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 2330, 2671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2441, 2464);

                CheckExpectedElement();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2478, 2533);

                SyntaxNodeOrTokenList
                list = nodes.GetWithSeparators()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2547, 2571);

                f_671_2547_2570(_builder, list);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2585, 2634);

                _expectedSeparator = ((f_671_2608_2622(_builder) & 1) != 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 2648, 2660);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(671, 2330, 2671);

                int
                f_671_2547_2570(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    this_param.AddRange(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 2547, 2570);
                    return 0;
                }


                int
                f_671_2608_2622(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(671, 2608, 2622);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 2330, 2671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 2330, 2671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TNode> ToList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 3093, 3337);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 3160, 3269) || true) && (_builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(671, 3160, 3269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 3214, 3254);

                    return f_671_3221_3253();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(671, 3160, 3269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 3285, 3326);

                return f_671_3292_3325(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(671, 3093, 3337);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_671_3221_3253()
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 3221, 3253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_671_3292_3325(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                builder)
                {
                    var return_v = builder.ToSeparatedList<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 3292, 3325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 3093, 3337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 3093, 3337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TDerived> ToList<TDerived>() where TDerived : TNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(671, 3349, 3635);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 3452, 3564) || true) && (_builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(671, 3452, 3564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 3506, 3549);

                    return f_671_3513_3548();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(671, 3452, 3564);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 3580, 3624);

                return f_671_3587_3623(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(671, 3349, 3635);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<TDerived>
                f_671_3513_3548()
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TDerived>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 3513, 3548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TDerived>
                f_671_3587_3623(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                builder)
                {
                    var return_v = builder.ToSeparatedList<TDerived>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 3587, 3623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 3349, 3635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 3349, 3635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator SyntaxListBuilder(in SeparatedSyntaxListBuilder<TNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(671, 3647, 3802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 3767, 3791);

                return builder._builder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(671, 3647, 3802);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 3647, 3802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 3647, 3802);
            }
        }
        public static implicit operator SeparatedSyntaxList<TNode>(in SeparatedSyntaxListBuilder<TNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(671, 3814, 4114);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 3943, 4044) || true) && (builder._builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(671, 3943, 4044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 4005, 4029);

                    return builder.ToList();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(671, 3943, 4044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(671, 4060, 4103);

                return default(SeparatedSyntaxList<TNode>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(671, 3814, 4114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(671, 3814, 4114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 3814, 4114);
            }
        }
        static SeparatedSyntaxListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(671, 300, 4121);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(671, 300, 4121);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(671, 300, 4121);
        }

        static Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
        f_671_553_580(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(671, 553, 580);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
        f_671_553_580_C(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(671, 489, 603);
            return return_v;
        }

    }
}
