// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class BoundTreeRewriter : BoundTreeVisitor
    {
        [return: NotNullIfNotNull("type")]
        public virtual TypeSymbol? VisitType(TypeSymbol? type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10576, 538, 684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 661, 673);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10576, 538, 684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 538, 684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 538, 684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<T> VisitList<T>(ImmutableArray<T> list) where T : BoundNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10576, 696, 933);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 802, 881) || true) && (list.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 802, 881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 854, 866);

                    return list;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 802, 881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 897, 922);

                return f_10576_904_921<T>(this, list);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10576, 696, 933);

                System.Collections.Immutable.ImmutableArray<T>
                f_10576_904_921<T>(Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter
                this_param, System.Collections.Immutable.ImmutableArray<T>
                list) where T : BoundNode

                {
                    var return_v = this_param.DoVisitList<T>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 904, 921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 696, 933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 696, 933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<T> DoVisitList<T>(ImmutableArray<T> list) where T : BoundNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10576, 945, 1908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1054, 1086);

                ArrayBuilder<T>?
                newList = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1109, 1114);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1100, 1749) || true) && (i < list.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1133, 1136)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 1100, 1749))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 1100, 1749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1170, 1189);

                        var
                        item = list[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1207, 1253);

                        f_10576_1207_1252<T>(item != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1273, 1304);

                        var
                        visited = f_10576_1287_1303<T>(this, item)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1322, 1591) || true) && (newList == null && (DynAbs.Tracing.TraceSender.Expression_True(10576, 1326, 1360) && item != visited))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 1322, 1591);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1402, 1442);

                            newList = f_10576_1412_1441<T>();

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1464, 1572) || true) && (i > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 1464, 1572);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1523, 1549);

                                f_10576_1523_1548<T>(newList, list, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 1464, 1572);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 1322, 1591);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1611, 1734) || true) && (newList != null && (DynAbs.Tracing.TraceSender.Expression_True(10576, 1615, 1649) && visited != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 1611, 1734);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1691, 1715);

                            f_10576_1691_1714<T>(newList, visited);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 1611, 1734);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10576, 1, 650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10576, 1, 650);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1765, 1869) || true) && (newList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 1765, 1869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1818, 1854);

                    return f_10576_1825_1853<T>(newList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 1765, 1869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 1885, 1897);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10576, 945, 1908);

                int
                f_10576_1207_1252<T>(bool
                condition) where T : BoundNode

                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 1207, 1252);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10576_1287_1303<T>(Microsoft.CodeAnalysis.CSharp.BoundTreeRewriter
                this_param, T
                node) where T : BoundNode

                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 1287, 1303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_10576_1412_1441<T>() where T : BoundNode

                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 1412, 1441);
                    return return_v;
                }


                int
                f_10576_1523_1548<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, System.Collections.Immutable.ImmutableArray<T>
                items, int
                length) where T : BoundNode

                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 1523, 1548);
                    return 0;
                }


                int
                f_10576_1691_1714<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                item) where T : BoundNode

                {
                    this_param.Add((T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 1691, 1714);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_10576_1825_1853<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param) where T : BoundNode

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 1825, 1853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 945, 1908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 945, 1908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundTreeRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10576, 453, 1915);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10576, 453, 1915);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 453, 1915);
        }


        static BoundTreeRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10576, 453, 1915);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10576, 453, 1915);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 453, 1915);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10576, 453, 1915);
    }
    internal abstract class BoundTreeRewriterWithStackGuard : BoundTreeRewriter
    {
        private int _recursionDepth;

        protected BoundTreeRewriterWithStackGuard()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10576, 2055, 2111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2027, 2042);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10576, 2055, 2111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 2055, 2111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 2055, 2111);
            }
        }

        protected BoundTreeRewriterWithStackGuard(int recursionDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10576, 2123, 2253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2027, 2042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2209, 2242);

                _recursionDepth = recursionDepth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10576, 2123, 2253);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 2123, 2253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 2123, 2253);
            }
        }

        protected int RecursionDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10576, 2294, 2312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2297, 2312);
                    return _recursionDepth; DynAbs.Tracing.TraceSender.TraceExitMethod(10576, 2294, 2312);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 2294, 2312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 2294, 2312);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override BoundNode? Visit(BoundNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10576, 2325, 2646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2399, 2440);

                var
                expression = node as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2454, 2595) || true) && (expression != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 2454, 2595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2510, 2580);

                    return f_10576_2517_2579(this, ref _recursionDepth, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 2454, 2595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2611, 2635);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10576, 2618, 2634);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10576, 2325, 2646);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10576_2517_2579(Microsoft.CodeAnalysis.CSharp.BoundTreeRewriterWithStackGuard
                this_param, ref int
                recursionDepth, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithStackGuard(ref recursionDepth, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 2517, 2579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 2325, 2646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 2325, 2646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundExpression VisitExpressionWithStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10576, 2658, 2835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2760, 2824);

                return f_10576_2767_2823(this, ref _recursionDepth, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10576, 2658, 2835);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10576_2767_2823(Microsoft.CodeAnalysis.CSharp.BoundTreeRewriterWithStackGuard
                this_param, ref int
                recursionDepth, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithStackGuard(ref recursionDepth, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 2767, 2823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 2658, 2835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 2658, 2835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override BoundExpression VisitExpressionWithoutStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10576, 2847, 3020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 2968, 3009);

                return (BoundExpression)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10576, 2992, 3008);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10576, 2847, 3020);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 2847, 3020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 2847, 3020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundTreeRewriterWithStackGuard()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10576, 1923, 3027);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10576, 1923, 3027);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 1923, 3027);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10576, 1923, 3027);
    }
    internal abstract class BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator : BoundTreeRewriterWithStackGuard
    {
        protected BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10576, 3182, 3279);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10576, 3182, 3279);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 3182, 3279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 3182, 3279);
            }
        }

        protected BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator(int recursionDepth)
        : base(f_10576_3414_3428_C(recursionDepth))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10576, 3291, 3442);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10576, 3291, 3442);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 3291, 3442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 3291, 3442);
            }
        }

        public sealed override BoundNode? VisitBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10576, 3454, 4937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 3558, 3592);

                BoundExpression
                child = f_10576_3582_3591(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 3608, 3737) || true) && (f_10576_3612_3622(child) != BoundKind.BinaryOperator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 3608, 3737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 3684, 3722);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBinaryOperator(node), 10576, 3691, 3721);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 3608, 3737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 3753, 3813);

                var
                stack = f_10576_3765_3812()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 3827, 3844);

                f_10576_3827_3843(stack, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 3860, 3916);

                BoundBinaryOperator
                binary = (BoundBinaryOperator)child
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 3932, 4234) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 3932, 4234);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 3977, 3996);

                        f_10576_3977_3995(stack, binary);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4014, 4034);

                        child = f_10576_4022_4033(binary);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4054, 4163) || true) && (f_10576_4058_4068(child) != BoundKind.BinaryOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 4054, 4163);
                            DynAbs.Tracing.TraceSender.TraceBreak(10576, 4138, 4144);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 4054, 4163);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4183, 4219);

                        binary = (BoundBinaryOperator)child;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 3932, 4234);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10576, 3932, 4234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10576, 3932, 4234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4250, 4297);

                var
                left = (BoundExpression?)f_10576_4279_4296(this, child)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4311, 4337);

                f_10576_4311_4336(left is { });
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10576, 4353, 4818);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4388, 4409);

                            binary = f_10576_4397_4408(stack);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4427, 4482);

                            var
                            right = (BoundExpression?)f_10576_4457_4481(this, f_10576_4468_4480(binary))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4500, 4527);

                            f_10576_4500_4526(right is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4545, 4584);

                            var
                            type = f_10576_4556_4583(this, f_10576_4571_4582(binary))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4602, 4765);

                            left = f_10576_4609_4764(binary, f_10576_4623_4642(binary), f_10576_4644_4667(binary), f_10576_4669_4685(binary), f_10576_4687_4704(binary), f_10576_4706_4744(binary), left, right, type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10576, 4353, 4818);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4353, 4818) || true) && (f_10576_4801_4812(stack) > 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10576, 4353, 4818);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10576, 4353, 4818);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4834, 4871);

                f_10576_4834_4870((object)binary == node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4885, 4898);

                f_10576_4885_4897(stack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10576, 4914, 4926);

                return left;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10576, 3454, 4937);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10576_3582_3591(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 3582, 3591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10576_3612_3622(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 3612, 3622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                f_10576_3765_3812()
                {
                    var return_v = ArrayBuilder<BoundBinaryOperator>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 3765, 3812);
                    return return_v;
                }


                int
                f_10576_3827_3843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 3827, 3843);
                    return 0;
                }


                int
                f_10576_3977_3995(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 3977, 3995);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10576_4022_4033(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4022, 4033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10576_4058_4068(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4058, 4068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10576_4279_4296(Microsoft.CodeAnalysis.CSharp.BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4279, 4296);
                    return return_v;
                }


                int
                f_10576_4311_4336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4311, 4336);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10576_4397_4408(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4397, 4408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10576_4468_4480(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4468, 4480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10576_4457_4481(Microsoft.CodeAnalysis.CSharp.BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4457, 4481);
                    return return_v;
                }


                int
                f_10576_4500_4526(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4500, 4526);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10576_4571_4582(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4571, 4582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10576_4556_4583(Microsoft.CodeAnalysis.CSharp.BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4556, 4583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10576_4623_4642(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4623, 4642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10576_4644_4667(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4644, 4667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10576_4669_4685(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4669, 4685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10576_4687_4704(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4687, 4704);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10576_4706_4744(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OriginalUserDefinedOperatorsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4706, 4744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10576_4609_4764(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalUserDefinedOperatorsOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operatorKind, constantValueOpt, methodOpt, resultKind, originalUserDefinedOperatorsOpt, left, right, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4609, 4764);
                    return return_v;
                }


                int
                f_10576_4801_4812(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10576, 4801, 4812);
                    return return_v;
                }


                int
                f_10576_4834_4870(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4834, 4870);
                    return 0;
                }


                int
                f_10576_4885_4897(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10576, 4885, 4897);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10576, 3454, 4937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 3454, 4937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10576, 3035, 4944);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10576, 3035, 4944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10576, 3035, 4944);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10576, 3035, 4944);

        static int
        f_10576_3414_3428_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10576, 3291, 3442);
            return return_v;
        }

    }
}
