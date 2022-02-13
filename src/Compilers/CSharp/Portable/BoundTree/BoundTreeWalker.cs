// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class BoundTreeWalker : BoundTreeVisitor
    {
        protected BoundTreeWalker()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10578, 423, 472);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10578, 423, 472);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 423, 472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 423, 472);
            }
        }

        public void VisitList<T>(ImmutableArray<T> list) where T : BoundNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10578, 484, 773);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 577, 762) || true) && (f_10578_581_596_M(!list.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 577, 762);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 639, 644);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 630, 747) || true) && (i < list.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 663, 666)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 630, 747))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 630, 747);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 708, 728);

                            f_10578_708_727<T>(this, list[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10578, 1, 118);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10578, 1, 118);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 577, 762);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10578, 484, 773);

                bool
                f_10578_581_596_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 581, 596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10578_708_727<T>(Microsoft.CodeAnalysis.CSharp.BoundTreeWalker
                this_param, T
                node) where T : BoundNode

                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 708, 727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 484, 773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 484, 773);
            }
        }

        protected void VisitUnoptimizedForm(BoundQueryClause queryClause)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10578, 785, 1901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 875, 938);

                BoundExpression?
                unoptimizedForm = f_10578_910_937(queryClause)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1277, 1322);

                var
                qc = unoptimizedForm as BoundQueryClause
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1336, 1379) || true) && (qc != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 1336, 1379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1352, 1379);

                    unoptimizedForm = f_10578_1370_1378(qc);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 1336, 1379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1393, 1433);

                var
                call = unoptimizedForm as BoundCall
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1447, 1890) || true) && (call != null && (DynAbs.Tracing.TraceSender.Expression_True(10578, 1451, 1494) && (object)f_10578_1475_1486(call) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 1447, 1890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1528, 1559);

                    var
                    arguments = f_10578_1544_1558(call)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1577, 1875) || true) && (f_10578_1581_1597(f_10578_1581_1592(call)) == "Select")
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 1577, 1875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1651, 1695);

                        f_10578_1651_1694(this, arguments[arguments.Length - 1]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 1577, 1875);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 1577, 1875);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1737, 1875) || true) && (f_10578_1741_1757(f_10578_1741_1752(call)) == "GroupBy")
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 1737, 1875);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 1812, 1856);

                            f_10578_1812_1855(this, arguments[arguments.Length - 2]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 1737, 1875);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 1577, 1875);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 1447, 1890);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10578, 785, 1901);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10578_910_937(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.UnoptimizedForm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 910, 937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_1370_1378(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 1370, 1378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10578_1475_1486(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 1475, 1486);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10578_1544_1558(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 1544, 1558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10578_1581_1592(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 1581, 1592);
                    return return_v;
                }


                string
                f_10578_1581_1597(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 1581, 1597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10578_1651_1694(Microsoft.CodeAnalysis.CSharp.BoundTreeWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 1651, 1694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10578_1741_1752(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 1741, 1752);
                    return return_v;
                }


                string
                f_10578_1741_1757(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 1741, 1757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10578_1812_1855(Microsoft.CodeAnalysis.CSharp.BoundTreeWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 1812, 1855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 785, 1901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 785, 1901);
            }
        }

        static BoundTreeWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10578, 340, 1908);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10578, 340, 1908);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 340, 1908);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10578, 340, 1908);
    }
    internal abstract class BoundTreeWalkerWithStackGuard : BoundTreeWalker
    {
        private int _recursionDepth;

        protected BoundTreeWalkerWithStackGuard()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10578, 2170, 2224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2142, 2157);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10578, 2170, 2224);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 2170, 2224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 2170, 2224);
            }
        }

        protected BoundTreeWalkerWithStackGuard(int recursionDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10578, 2236, 2364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2142, 2157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2320, 2353);

                _recursionDepth = recursionDepth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10578, 2236, 2364);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 2236, 2364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 2236, 2364);
            }
        }

        protected int RecursionDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10578, 2405, 2423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2408, 2423);
                    return _recursionDepth; DynAbs.Tracing.TraceSender.TraceExitMethod(10578, 2405, 2423);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 2405, 2423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 2405, 2423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override BoundNode? Visit(BoundNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10578, 2436, 2757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2510, 2551);

                var
                expression = node as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2565, 2706) || true) && (expression != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 2565, 2706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2621, 2691);

                    return f_10578_2628_2690(this, ref _recursionDepth, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 2565, 2706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2722, 2746);

                // LAFHIS
                //return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10578, 2729, 2745);
                var temp = base.Visit(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 2729, 2745);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10578, 2436, 2757);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_2628_2690(Microsoft.CodeAnalysis.CSharp.BoundTreeWalkerWithStackGuard
                this_param, ref int
                recursionDepth, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithStackGuard(ref recursionDepth, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 2628, 2690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 2436, 2757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 2436, 2757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundExpression VisitExpressionWithStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10578, 2769, 2946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 2871, 2935);

                return f_10578_2878_2934(this, ref _recursionDepth, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10578, 2769, 2946);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_2878_2934(Microsoft.CodeAnalysis.CSharp.BoundTreeWalkerWithStackGuard
                this_param, ref int
                recursionDepth, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithStackGuard(ref recursionDepth, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 2878, 2934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 2769, 2946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 2769, 2946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override BoundExpression VisitExpressionWithoutStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10578, 2958, 3131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 3079, 3120);

                return (BoundExpression)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10578, 3103, 3119);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10578, 2958, 3131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 2958, 3131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 2958, 3131);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundTreeWalkerWithStackGuard()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10578, 2042, 3138);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10578, 2042, 3138);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 2042, 3138);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10578, 2042, 3138);
    }
    internal abstract class BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator : BoundTreeWalkerWithStackGuard
    {
        protected BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10578, 3415, 3510);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10578, 3415, 3510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 3415, 3510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 3415, 3510);
            }
        }

        protected BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator(int recursionDepth)
        : base(f_10578_3643_3657_C(recursionDepth))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10578, 3522, 3671);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10578, 3522, 3671);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 3522, 3671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 3522, 3671);
            }
        }

        public sealed override BoundNode? VisitBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10578, 3683, 4688);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 3787, 3920) || true) && (f_10578_3791_3805(f_10578_3791_3800(node)) != BoundKind.BinaryOperator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 3787, 3920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 3867, 3905);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBinaryOperator(node), 10578, 3874, 3904);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 3787, 3920);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 3936, 4000);

                var
                rightOperands = f_10578_3956_3999()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4016, 4047);

                f_10578_4016_4046(
                            rightOperands, f_10578_4035_4045(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4063, 4107);

                var
                binary = (BoundBinaryOperator)f_10578_4097_4106(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4123, 4156);

                f_10578_4123_4155(
                            rightOperands, f_10578_4142_4154(binary));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4172, 4210);

                BoundExpression
                current = f_10578_4198_4209(binary)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4226, 4451) || true) && (f_10578_4233_4245(current) == BoundKind.BinaryOperator)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 4226, 4451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4307, 4345);

                        binary = (BoundBinaryOperator)current;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4363, 4396);

                        f_10578_4363_4395(rightOperands, f_10578_4382_4394(binary));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4414, 4436);

                        current = f_10578_4424_4435(binary);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 4226, 4451);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10578, 4226, 4451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10578, 4226, 4451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4467, 4487);

                f_10578_4467_4486(
                            this, current);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4503, 4614) || true) && (f_10578_4510_4529(rightOperands) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10578, 4503, 4614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4567, 4599);

                        f_10578_4567_4598(this, f_10578_4578_4597(rightOperands));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10578, 4503, 4614);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10578, 4503, 4614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10578, 4503, 4614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4630, 4651);

                f_10578_4630_4650(
                            rightOperands);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10578, 4665, 4677);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10578, 3683, 4688);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_3791_3800(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 3791, 3800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10578_3791_3805(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 3791, 3805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10578_3956_3999()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 3956, 3999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_4035_4045(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 4035, 4045);
                    return return_v;
                }


                int
                f_10578_4016_4046(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundExpression>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 4016, 4046);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_4097_4106(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 4097, 4106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_4142_4154(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 4142, 4154);
                    return return_v;
                }


                int
                f_10578_4123_4155(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundExpression>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 4123, 4155);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_4198_4209(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 4198, 4209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10578_4233_4245(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 4233, 4245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_4382_4394(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 4382, 4394);
                    return return_v;
                }


                int
                f_10578_4363_4395(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundExpression>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 4363, 4395);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_4424_4435(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 4424, 4435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10578_4467_4486(Microsoft.CodeAnalysis.CSharp.BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 4467, 4486);
                    return return_v;
                }


                int
                f_10578_4510_4529(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10578, 4510, 4529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10578_4578_4597(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 4578, 4597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10578_4567_4598(Microsoft.CodeAnalysis.CSharp.BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 4567, 4598);
                    return return_v;
                }


                int
                f_10578_4630_4650(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10578, 4630, 4650);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10578, 3683, 4688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 3683, 4688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10578, 3272, 4695);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10578, 3272, 4695);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10578, 3272, 4695);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10578, 3272, 4695);

        static int
        f_10578_3643_3657_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10578, 3522, 3671);
            return return_v;
        }

    }
}
