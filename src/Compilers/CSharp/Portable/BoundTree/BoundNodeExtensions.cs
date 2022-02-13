// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static partial class BoundNodeExtensions
    {
        public static bool HasErrors<T>(this ImmutableArray<T> nodeArray)
                    where T : BoundNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10563, 538, 930);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 661, 716) || true) && (nodeArray.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10563, 661, 716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 703, 716);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10563, 661, 716);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 741, 746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 748, 768);

                    for (int
        i = 0
        ,
        n = nodeArray.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 732, 890) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 777, 780)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10563, 732, 890))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10563, 732, 890);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 814, 875) || true) && (f_10563_818_840<T>(nodeArray[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10563, 814, 875);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 863, 875);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10563, 814, 875);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10563, 1, 159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10563, 1, 159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 906, 919);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10563, 538, 930);

                bool
                f_10563_818_840<T>(T
                this_param) where T : BoundNode

                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 818, 840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10563, 538, 930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10563, 538, 930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasErrors([NotNullWhen(true)] this BoundNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10563, 1020, 1164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 1115, 1153);

                return node != null && (DynAbs.Tracing.TraceSender.Expression_True(10563, 1122, 1152) && f_10563_1138_1152(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10563, 1020, 1164);

                bool
                f_10563_1138_1152(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 1138, 1152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10563, 1020, 1164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10563, 1020, 1164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsConstructorInitializer(this BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10563, 1176, 2011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 1275, 1307);

                f_10563_1275_1306(statement != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 1321, 1971) || true) && (f_10563_1325_1340(statement!) == BoundKind.ExpressionStatement)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10563, 1321, 1971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 1407, 1485);

                    BoundExpression
                    expression = f_10563_1436_1484(((BoundExpressionStatement)statement))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 1503, 1841) || true) && (f_10563_1507_1522(expression) == BoundKind.Sequence && (DynAbs.Tracing.TraceSender.Expression_True(10563, 1507, 1604) && ((BoundSequence)expression).SideEffects.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10563, 1503, 1841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 1775, 1822);

                        expression = f_10563_1788_1821(((BoundSequence)expression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10563, 1503, 1841);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 1861, 1956);

                    return f_10563_1868_1883(expression) == BoundKind.Call && (DynAbs.Tracing.TraceSender.Expression_True(10563, 1868, 1955) && f_10563_1905_1955(((BoundCall)expression)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10563, 1321, 1971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 1987, 2000);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10563, 1176, 2011);

                int
                f_10563_1275_1306(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10563, 1275, 1306);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10563_1325_1340(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 1325, 1340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10563_1436_1484(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 1436, 1484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10563_1507_1522(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 1507, 1522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10563_1788_1821(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 1788, 1821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10563_1868_1883(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 1868, 1883);
                    return return_v;
                }


                bool
                f_10563_1905_1955(Microsoft.CodeAnalysis.CSharp.BoundExpression
                call)
                {
                    var return_v = ((BoundCall)call).IsConstructorInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10563, 1905, 1955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10563, 1176, 2011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10563, 1176, 2011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsConstructorInitializer(this BoundCall call)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10563, 2023, 2480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 2112, 2139);

                f_10563_2112_2138(call != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 2153, 2188);

                MethodSymbol
                method = f_10563_2175_2187(call!)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 2202, 2251);

                BoundExpression?
                receiverOpt = f_10563_2233_2250(call!)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 2265, 2469);

                return f_10563_2272_2289(method) == MethodKind.Constructor && (DynAbs.Tracing.TraceSender.Expression_True(10563, 2272, 2355) && receiverOpt != null) && (DynAbs.Tracing.TraceSender.Expression_True(10563, 2272, 2468) && (f_10563_2377_2393(receiverOpt) == BoundKind.ThisReference || (DynAbs.Tracing.TraceSender.Expression_False(10563, 2377, 2467) || f_10563_2424_2440(receiverOpt) == BoundKind.BaseReference)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10563, 2023, 2480);

                int
                f_10563_2112_2138(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10563, 2112, 2138);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10563_2175_2187(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 2175, 2187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10563_2233_2250(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 2233, 2250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10563_2272_2289(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 2272, 2289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10563_2377_2393(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 2377, 2393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10563_2424_2440(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10563, 2424, 2440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10563, 2023, 2480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10563, 2023, 2480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T MakeCompilerGenerated<T>(this T node) where T : BoundNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10563, 2492, 2660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 2590, 2623);

                node.WasCompilerGenerated = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10563, 2637, 2649);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10563, 2492, 2660);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10563, 2492, 2660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10563, 2492, 2660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundNodeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10563, 408, 2667);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10563, 408, 2667);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10563, 408, 2667);
        }

    }
}
