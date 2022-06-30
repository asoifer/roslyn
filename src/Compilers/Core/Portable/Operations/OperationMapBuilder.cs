// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis
{
    internal static class OperationMapBuilder
    {
        internal static void AddToMap(IOperation root, Dictionary<SyntaxNode, IOperation> dictionary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(470, 724, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 842, 878);

                f_470_842_877(f_470_855_871(dictionary) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 892, 932);

                f_470_892_931(Walker.Instance, root, dictionary);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(470, 724, 943);

                int
                f_470_855_871(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(470, 855, 871);
                    return return_v;
                }


                int
                f_470_842_877(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 842, 877);
                    return 0;
                }


                object?
                f_470_892_931(Microsoft.CodeAnalysis.OperationMapBuilder.Walker
                this_param, Microsoft.CodeAnalysis.IOperation
                operation, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                argument)
                {
                    var return_v = this_param.Visit(operation, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 892, 931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(470, 724, 943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(470, 724, 943);
            }
        }
        private sealed class Walker : OperationWalker<Dictionary<SyntaxNode, IOperation>>
        {
            internal static readonly Walker Instance;

            public override object? DefaultVisit(IOperation operation, Dictionary<SyntaxNode, IOperation> argument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(470, 1133, 1385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 1269, 1306);

                    f_470_1269_1305(operation, argument);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 1324, 1370);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DefaultVisit(operation, argument), 470, 1331, 1369);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(470, 1133, 1385);

                    int
                    f_470_1269_1305(Microsoft.CodeAnalysis.IOperation
                    operation, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                    argument)
                    {
                        RecordOperation(operation, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 1269, 1305);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(470, 1133, 1385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(470, 1133, 1385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override object? VisitBinaryOperator([DisallowNull] IBinaryOperation? operation, Dictionary<SyntaxNode, IOperation> argument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(470, 1401, 2355);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 1802, 2308) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(470, 1802, 2308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 1855, 1892);

                            f_470_1855_1891(operation, argument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 1914, 1954);

                            f_470_1914_1953(this, f_470_1920_1942(operation), argument);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 1976, 2289) || true) && (f_470_1980_2001(operation) is IBinaryOperation nested)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(470, 1976, 2289);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 2078, 2097);

                                operation = nested;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(470, 1976, 2289);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(470, 1976, 2289);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 2195, 2234);

                                f_470_2195_2233(this, f_470_2201_2222(operation), argument);
                                DynAbs.Tracing.TraceSender.TraceBreak(470, 2260, 2266);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(470, 1976, 2289);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(470, 1802, 2308);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(470, 1802, 2308);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(470, 1802, 2308);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 2328, 2340);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(470, 1401, 2355);

                    int
                    f_470_1855_1891(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                    operation, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                    argument)
                    {
                        RecordOperation((Microsoft.CodeAnalysis.IOperation)operation, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 1855, 1891);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_470_1920_1942(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                    this_param)
                    {
                        var return_v = this_param.RightOperand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(470, 1920, 1942);
                        return return_v;
                    }


                    object?
                    f_470_1914_1953(Microsoft.CodeAnalysis.OperationMapBuilder.Walker
                    this_param, Microsoft.CodeAnalysis.IOperation
                    operation, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                    argument)
                    {
                        var return_v = this_param.Visit(operation, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 1914, 1953);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_470_1980_2001(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                    this_param)
                    {
                        var return_v = this_param.LeftOperand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(470, 1980, 2001);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IOperation
                    f_470_2201_2222(Microsoft.CodeAnalysis.Operations.IBinaryOperation
                    this_param)
                    {
                        var return_v = this_param.LeftOperand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(470, 2201, 2222);
                        return return_v;
                    }


                    object?
                    f_470_2195_2233(Microsoft.CodeAnalysis.OperationMapBuilder.Walker
                    this_param, Microsoft.CodeAnalysis.IOperation
                    operation, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                    argument)
                    {
                        var return_v = this_param.Visit(operation, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 2195, 2233);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(470, 1401, 2355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(470, 1401, 2355);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override object? VisitNoneOperation(IOperation operation, Dictionary<SyntaxNode, IOperation> argument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(470, 2371, 2783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 2727, 2768);

                    return f_470_2734_2767(this, operation, argument);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(470, 2371, 2783);

                    object?
                    f_470_2734_2767(Microsoft.CodeAnalysis.OperationMapBuilder.Walker
                    this_param, Microsoft.CodeAnalysis.IOperation
                    operation, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                    argument)
                    {
                        var return_v = this_param.DefaultVisit(operation, argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 2734, 2767);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(470, 2371, 2783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(470, 2371, 2783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void RecordOperation(IOperation operation, Dictionary<SyntaxNode, IOperation> argument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(470, 2799, 3188);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 2934, 3173) || true) && (f_470_2938_2959_M(!operation.IsImplicit))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(470, 2934, 3173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 3112, 3154);

                        f_470_3112_3153(                    // IOperation invariant is that all there is at most 1 non-implicit node per syntax node.
                                            argument, f_470_3125_3141(operation), operation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(470, 2934, 3173);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(470, 2799, 3188);

                    bool
                    f_470_2938_2959_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(470, 2938, 2959);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_470_3125_3141(Microsoft.CodeAnalysis.IOperation
                    this_param)
                    {
                        var return_v = this_param.Syntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(470, 3125, 3141);
                        return return_v;
                    }


                    int
                    f_470_3112_3153(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.IOperation>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    key, Microsoft.CodeAnalysis.IOperation
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 3112, 3153);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(470, 2799, 3188);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(470, 2799, 3188);
                }
            }

            public Walker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(470, 955, 3199);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(470, 955, 3199);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(470, 955, 3199);
            }


            static Walker()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(470, 955, 3199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(470, 1093, 1116);
                Instance = f_470_1104_1116(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(470, 955, 3199);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(470, 955, 3199);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(470, 955, 3199);

            static Microsoft.CodeAnalysis.OperationMapBuilder.Walker
            f_470_1104_1116()
            {
                var return_v = new Microsoft.CodeAnalysis.OperationMapBuilder.Walker();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(470, 1104, 1116);
                return return_v;
            }

        }

        static OperationMapBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(470, 395, 3206);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(470, 395, 3206);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(470, 395, 3206);
        }

    }
}
