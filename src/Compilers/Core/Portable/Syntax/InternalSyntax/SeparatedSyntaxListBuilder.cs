// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal struct SeparatedSyntaxListBuilder<TNode> where TNode : GreenNode
    {

        private readonly SyntaxListBuilder? _builder;

        public SeparatedSyntaxListBuilder(int size)
        : this(f_823_696_723_C(f_823_696_723(size)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(823, 632, 746);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(823, 632, 746);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 632, 746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 632, 746);
            }
        }

        public static SeparatedSyntaxListBuilder<TNode> Create()
        {
            return new SeparatedSyntaxListBuilder<TNode>(8);
        }

        internal SeparatedSyntaxListBuilder(SyntaxListBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(823, 910, 1027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 997, 1016);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(823, 910, 1027);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 910, 1027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 910, 1027);
            }
        }

        public bool IsNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 1082, 1157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 1118, 1142);

                    return _builder == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(823, 1082, 1157);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 1039, 1168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 1039, 1168);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 1221, 1295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 1257, 1280);

                    return f_823_1264_1279(_builder!);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(823, 1221, 1295);

                    int
                    f_823_1264_1279(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(823, 1264, 1279);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 1180, 1306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 1180, 1306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public GreenNode? this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 1376, 1451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 1412, 1436);

                    return f_823_1419_1435(_builder, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(823, 1376, 1451);

                    Microsoft.CodeAnalysis.GreenNode?
                    f_823_1419_1435(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(823, 1419, 1435);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 1376, 1451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 1376, 1451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 1467, 1543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 1503, 1528);

                    _builder![index] = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(823, 1467, 1543);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 1467, 1543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 1467, 1543);
                }
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 1566, 1639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 1610, 1628);

                f_823_1610_1627(_builder!);
                DynAbs.Tracing.TraceSender.TraceExitMethod(823, 1566, 1639);

                int
                f_823_1610_1627(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(823, 1610, 1627);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 1566, 1639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 1566, 1639);
            }
        }

        public void RemoveLast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 1651, 1734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 1700, 1723);

                f_823_1700_1722(_builder!);
                DynAbs.Tracing.TraceSender.TraceExitMethod(823, 1651, 1734);

                int
                f_823_1700_1722(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(823, 1700, 1722);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 1651, 1734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 1651, 1734);
            }
        }

        public SeparatedSyntaxListBuilder<TNode> Add(TNode node)
        {
            _builder!.Add(node);
            return this;
        }

        public void AddSeparator(GreenNode separatorToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 1896, 2012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 1971, 2001);

                f_823_1971_2000(_builder!, separatorToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(823, 1896, 2012);

                int
                f_823_1971_2000(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(823, 1971, 2000);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 1896, 2012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 1896, 2012);
            }
        }

        public void AddRange(TNode[] items, int offset, int length)
        {
            _builder!.AddRange(items, offset, length);
        }

        public void AddRange(in SeparatedSyntaxList<TNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 2173, 2312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 2255, 2301);

                f_823_2255_2300(_builder!, nodes.GetWithSeparators());
                DynAbs.Tracing.TraceSender.TraceExitMethod(823, 2173, 2312);

                int
                f_823_2255_2300(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                list)
                {
                    this_param.AddRange(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(823, 2255, 2300);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 2173, 2312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 2173, 2312);
            }
        }

        public void AddRange(in SeparatedSyntaxList<TNode> nodes, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 2324, 2549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 2417, 2454);

                var
                list = nodes.GetWithSeparators()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 2468, 2538);

                f_823_2468_2537(_builder!, list, this.Count, f_823_2505_2536(count * 2, list.Count));
                DynAbs.Tracing.TraceSender.TraceExitMethod(823, 2324, 2549);

                int
                f_823_2505_2536(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(823, 2505, 2536);
                    return return_v;
                }


                int
                f_823_2468_2537(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                list, int
                offset, int
                length)
                {
                    this_param.AddRange(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(823, 2468, 2537);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 2324, 2549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 2324, 2549);
            }
        }

        public bool Any(int kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 2561, 2649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 2611, 2638);

                return f_823_2618_2637(_builder!, kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(823, 2561, 2649);

                bool
                f_823_2618_2637(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                kind)
                {
                    var return_v = this_param.Any(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(823, 2618, 2637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 2561, 2649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 2561, 2649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TNode> ToList()
        {
            return _builder == null
                ? default(SeparatedSyntaxList<TNode>)
                : new SeparatedSyntaxList<TNode>(new SyntaxList<GreenNode>(_builder.ToListNode()));
        }

        internal SyntaxListBuilder? UnderlyingBuilder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(823, 3527, 3551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 3533, 3549);

                    return _builder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(823, 3527, 3551);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 3457, 3562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 3457, 3562);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static implicit operator SeparatedSyntaxList<TNode>(in SeparatedSyntaxListBuilder<TNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(823, 3574, 3738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 3703, 3727);

                return builder.ToList();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(823, 3574, 3738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 3574, 3738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 3574, 3738);
            }
        }
        public static implicit operator SyntaxListBuilder?(in SeparatedSyntaxListBuilder<TNode> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(823, 3750, 3906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(823, 3871, 3895);

                return builder._builder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(823, 3750, 3906);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(823, 3750, 3906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 3750, 3906);
            }
        }
        static SeparatedSyntaxListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(823, 485, 3913);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(823, 485, 3913);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(823, 485, 3913);
        }

        static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
        f_823_696_723(int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(823, 696, 723);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
        f_823_696_723_C(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(823, 632, 746);
            return return_v;
        }

    }
}
