// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class NullabilityRewriter : BoundTreeRewriter
    {
        protected override BoundExpression? VisitExpressionWithoutStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10586, 524, 686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 639, 675);

                return (BoundExpression)f_10586_663_674(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10586, 524, 686);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10586_663_674(Microsoft.CodeAnalysis.CSharp.NullabilityRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 663, 674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10586, 524, 686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 524, 686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode? VisitBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10586, 698, 843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 795, 832);

                return f_10586_802_831(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10586, 698, 843);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10586_802_831(Microsoft.CodeAnalysis.CSharp.NullabilityRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                binaryOperator)
                {
                    var return_v = this_param.VisitBinaryOperatorBase((Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase)binaryOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 802, 831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10586, 698, 843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 698, 843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode? VisitUserDefinedConditionalLogicalOperator(BoundUserDefinedConditionalLogicalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10586, 855, 1046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 998, 1035);

                return f_10586_1005_1034(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10586, 855, 1046);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10586_1005_1034(Microsoft.CodeAnalysis.CSharp.NullabilityRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                binaryOperator)
                {
                    var return_v = this_param.VisitBinaryOperatorBase((Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase)binaryOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 1005, 1034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10586, 855, 1046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 855, 1046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitBinaryOperatorBase(BoundBinaryOperatorBase binaryOperator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10586, 1058, 3296);
                (Microsoft.CodeAnalysis.NullabilityInfo Info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? Type) infoAndType = default((Microsoft.CodeAnalysis.NullabilityInfo Info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1297, 1361);

                var
                stack = f_10586_1309_1360()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1375, 1431);

                BoundBinaryOperatorBase?
                currentBinary = binaryOperator
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 1447, 1649);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1482, 1508);

                            f_10586_1482_1507(stack, currentBinary);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1526, 1588);

                            currentBinary = f_10586_1542_1560(currentBinary) as BoundBinaryOperatorBase;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 1447, 1649);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1447, 1649) || true) && (currentBinary is object)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10586, 1447, 1649);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10586, 1447, 1649);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1665, 1695);

                f_10586_1665_1694(f_10586_1678_1689(stack) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1709, 1767);

                var
                leftChild = (BoundExpression)f_10586_1742_1766(this, f_10586_1748_1765(f_10586_1748_1760(stack)))
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 1783, 3197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1818, 1846);

                            currentBinary = f_10586_1834_1845(stack);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1866, 1990);

                            bool
                            foundInfo = f_10586_1883_1989(_updatedNullabilities, currentBinary, out infoAndType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 2008, 2064);

                            var
                            right = (BoundExpression)f_10586_2037_2063(this, f_10586_2043_2062(currentBinary))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 2082, 2143);

                            var
                            type = (DynAbs.Tracing.TraceSender.Conditional_F1(10586, 2093, 2102) || ((foundInfo && DynAbs.Tracing.TraceSender.Conditional_F2(10586, 2105, 2121)) || DynAbs.Tracing.TraceSender.Conditional_F3(10586, 2124, 2142))) ? infoAndType.Type : f_10586_2124_2142(currentBinary)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 2163, 2951);

                            currentBinary = currentBinary switch
                            {
                                BoundBinaryOperator binary when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 2240, 2457) && DynAbs.Tracing.TraceSender.Expression_True(10586, 2240, 2457))
            => f_10586_2270_2457(binary, f_10586_2284_2303(binary), f_10586_2305_2328(binary), f_10586_2330_2372(this, binary, f_10586_2355_2371(binary)), f_10586_2374_2391(binary), f_10586_2393_2431(binary), leftChild, right, type!),
                                // https://github.com/dotnet/roslyn/issues/35031: We'll need to update logical.LogicalOperator
                                BoundUserDefinedConditionalLogicalOperator logical when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 2596, 2842) && DynAbs.Tracing.TraceSender.Expression_True(10586, 2596, 2842))
            => f_10586_2650_2842(logical, f_10586_2665_2685(logical), f_10586_2687_2710(logical), f_10586_2712_2732(logical), f_10586_2734_2755(logical), f_10586_2757_2775(logical), f_10586_2777_2816(logical), leftChild, right, type!),
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 2865, 2930) && DynAbs.Tracing.TraceSender.Expression_True(10586, 2865, 2930))
            => throw f_10586_2876_2930(f_10586_2911_2929(currentBinary)),
                            };

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 2971, 3098) || true) && (foundInfo)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 2971, 3098);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3026, 3079);

                                currentBinary.TopLevelNullability = infoAndType.Info;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 2971, 3098);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3118, 3144);

                            leftChild = currentBinary;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 1783, 3197);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 1783, 3197) || true) && (f_10586_3180_3191(stack) > 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10586, 1783, 3197);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10586, 1783, 3197);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3213, 3249);

                f_10586_3213_3248(currentBinary != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3263, 3285);

                return currentBinary!;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10586, 1058, 3296);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>
                f_10586_1309_1360()
                {
                    var return_v = ArrayBuilder<BoundBinaryOperatorBase>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 1309, 1360);
                    return return_v;
                }


                int
                f_10586_1482_1507(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 1482, 1507);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10586_1542_1560(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 1542, 1560);
                    return return_v;
                }


                int
                f_10586_1678_1689(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 1678, 1689);
                    return return_v;
                }


                int
                f_10586_1665_1694(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 1665, 1694);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                f_10586_1748_1760(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>
                builder)
                {
                    var return_v = builder.Peek<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 1748, 1760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10586_1748_1765(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 1748, 1765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10586_1742_1766(Microsoft.CodeAnalysis.CSharp.NullabilityRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 1742, 1766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                f_10586_1834_1845(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 1834, 1845);
                    return return_v;
                }


                bool
                f_10586_1883_1989(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundExpression, (Microsoft.CodeAnalysis.NullabilityInfo Info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? Type)>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                key, out (Microsoft.CodeAnalysis.NullabilityInfo Info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? Type)
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.BoundExpression)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 1883, 1989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10586_2043_2062(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2043, 2062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10586_2037_2063(Microsoft.CodeAnalysis.CSharp.NullabilityRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 2037, 2063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10586_2124_2142(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2124, 2142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10586_2284_2303(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2284, 2303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10586_2305_2328(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2305, 2328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10586_2355_2371(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2355, 2371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10586_2330_2372(Microsoft.CodeAnalysis.CSharp.NullabilityRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                sym)
                {
                    var return_v = this_param.GetUpdatedSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>((Microsoft.CodeAnalysis.CSharp.BoundNode)expr, sym);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 2330, 2372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10586_2374_2391(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2374, 2391);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10586_2393_2431(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OriginalUserDefinedOperatorsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2393, 2431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10586_2270_2457(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 2270, 2457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10586_2665_2685(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2665, 2685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10586_2687_2710(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.LogicalOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2687, 2710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10586_2712_2732(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.TrueOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2712, 2732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10586_2734_2755(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.FalseOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2734, 2755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10586_2757_2775(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2757, 2775);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10586_2777_2816(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.OriginalUserDefinedOperatorsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2777, 2816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                f_10586_2650_2842(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                logicalOperator, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                trueOperator, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                falseOperator, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalUserDefinedOperatorsOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operatorKind, logicalOperator, trueOperator, falseOperator, resultKind, originalUserDefinedOperatorsOpt, left, right, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 2650, 2842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10586_2911_2929(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 2911, 2929);
                    return return_v;
                }


                System.Exception
                f_10586_2876_2930(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 2876, 2930);
                    return return_v;
                }


                int
                f_10586_3180_3191(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperatorBase>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 3180, 3191);
                    return return_v;
                }


                int
                f_10586_3213_3248(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 3213, 3248);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10586, 1058, 3296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 1058, 3296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private T GetUpdatedSymbol<T>(BoundNode expr, T sym) where T : Symbol?
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10586, 3308, 6742);
                Microsoft.CodeAnalysis.CSharp.Symbol updatedParam = default(Microsoft.CodeAnalysis.CSharp.Symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3403, 3431) || true) && (sym is null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 3403, 3431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3420, 3431);

                    return sym;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 3403, 3431);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3447, 3476);

                Symbol?
                updatedSymbol = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3490, 3638) || true) && (f_10586_3494_3561_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_snapshotManager, 10586, 3494, 3561)?.TryGetUpdatedSymbol(expr, sym, out updatedSymbol)) != true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 3490, 3638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3603, 3623);

                    updatedSymbol = sym;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 3490, 3638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3652, 3696);

                f_10586_3652_3695<T>(updatedSymbol is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3712, 4231);

                switch (updatedSymbol)
                {

                    case LambdaSymbol lambda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 3712, 4231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3814, 3863);

                        return (T)f_10586_3824_3862<T>(expr, lambda);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 3712, 4231);

                    case SourceLocalSymbol local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 3712, 4231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 3934, 3962);

                        return (T)f_10586_3944_3961<T>(local);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 3712, 4231);

                    case ParameterSymbol param:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 3712, 4231);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4031, 4188) || true) && (f_10586_4035_4092<T>(_remappedSymbols, param, out updatedParam))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 4031, 4188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4142, 4165);

                            return (T)updatedParam;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 4031, 4188);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10586, 4210, 4216);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 3712, 4231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4247, 4271);

                return (T)updatedSymbol;

                Symbol remapLambda(BoundLambda boundLambda, LambdaSymbol lambda)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10586, 4287, 5751);
                        Microsoft.CodeAnalysis.CSharp.Symbol updatedContaining = default(Microsoft.CodeAnalysis.CSharp.Symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4384, 4468);

                        var
                        updatedDelegateType = f_10586_4410_4467_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_snapshotManager, 10586, 4410, 4467)?.GetUpdatedDelegateTypeForLambda(lambda))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4488, 4683) || true) && (!f_10586_4493_4577(_remappedSymbols, f_10586_4522_4545(lambda), out updatedContaining) && (DynAbs.Tracing.TraceSender.Expression_True(10586, 4492, 4608) && updatedDelegateType is null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 4488, 4683);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4650, 4664);

                            return lambda;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 4488, 4683);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4703, 4730);

                        LambdaSymbol
                        updatedLambda
                        = default(LambdaSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4748, 5346) || true) && (updatedDelegateType is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 4748, 5346);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4821, 4863);

                            f_10586_4821_4862(updatedContaining is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 4885, 5065);

                            updatedLambda = f_10586_4901_5064(boundLambda, updatedContaining, f_10586_4951_4983(lambda), f_10586_4985_5021(lambda), f_10586_5023_5047(lambda), f_10586_5049_5063(lambda));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 4748, 5346);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 4748, 5346);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5147, 5191);

                            f_10586_5147_5190(updatedDelegateType is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5213, 5327);

                            updatedLambda = f_10586_5229_5326(boundLambda, updatedDelegateType, updatedContaining ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10586, 5281, 5325) ?? f_10586_5302_5325(lambda)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 4748, 5346);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5366, 5410);

                        f_10586_5366_5409(
                                        _remappedSymbols, lambda, updatedLambda);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5430, 5498);

                        f_10586_5430_5497(f_10586_5443_5464(lambda) == f_10586_5468_5496(updatedLambda));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5525, 5530);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5516, 5695) || true) && (i < f_10586_5536_5557(lambda))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5559, 5562)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 5516, 5695))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 5516, 5695);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5604, 5676);

                                f_10586_5604_5675(_remappedSymbols, f_10586_5625_5642(lambda)[i], f_10586_5647_5671(updatedLambda)[i]);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10586, 1, 180);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10586, 1, 180);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5715, 5736);

                        return updatedLambda;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10586, 4287, 5751);

                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                        f_10586_4410_4467_I(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 4410, 4467);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10586_4522_4545(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 4522, 4545);
                            return return_v;
                        }


                        bool
                        f_10586_4493_4577(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        key, out Microsoft.CodeAnalysis.CSharp.Symbol?
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 4493, 4577);
                            return return_v;
                        }


                        int
                        f_10586_4821_4862(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 4821, 4862);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10586_4951_4983(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnTypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 4951, 4983);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10586_4985_5021(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterTypesWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 4985, 5021);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                        f_10586_5023_5047(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterRefKinds;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 5023, 5047);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.RefKind
                        f_10586_5049_5063(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.RefKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 5049, 5063);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        f_10586_4901_5064(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                        parameterRefKinds, Microsoft.CodeAnalysis.RefKind
                        refKind)
                        {
                            var return_v = this_param.CreateLambdaSymbol(containingSymbol, returnType, parameterTypes, parameterRefKinds, refKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 4901, 5064);
                            return return_v;
                        }


                        int
                        f_10586_5147_5190(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 5147, 5190);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10586_5302_5325(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 5302, 5325);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        f_10586_5229_5326(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        delegateType, Microsoft.CodeAnalysis.CSharp.Symbol
                        containingSymbol)
                        {
                            var return_v = this_param.CreateLambdaSymbol(delegateType, containingSymbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 5229, 5326);
                            return return_v;
                        }


                        int
                        f_10586_5366_5409(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        key, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        value)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.Symbol)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 5366, 5409);
                            return 0;
                        }


                        int
                        f_10586_5443_5464(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 5443, 5464);
                            return return_v;
                        }


                        int
                        f_10586_5468_5496(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 5468, 5496);
                            return return_v;
                        }


                        int
                        f_10586_5430_5497(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 5430, 5497);
                            return 0;
                        }


                        int
                        f_10586_5536_5557(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.ParameterCount;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 5536, 5557);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10586_5625_5642(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 5625, 5642);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10586_5647_5671(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 5647, 5671);
                            return return_v;
                        }


                        int
                        f_10586_5604_5675(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        key, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        value)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.Symbol)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 5604, 5675);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10586, 4287, 5751);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 4287, 5751);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                Symbol remapLocal(SourceLocalSymbol local)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10586, 5767, 6731);
                        Microsoft.CodeAnalysis.CSharp.Symbol updatedLocal = default(Microsoft.CodeAnalysis.CSharp.Symbol);
                        Microsoft.CodeAnalysis.CSharp.Symbol updatedContaining = default(Microsoft.CodeAnalysis.CSharp.Symbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5842, 5984) || true) && (f_10586_5846_5903(_remappedSymbols, local, out updatedLocal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 5842, 5984);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 5945, 5965);

                            return updatedLocal;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 5842, 5984);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6004, 6076);

                        var
                        updatedType = f_10586_6022_6075_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_snapshotManager, 10586, 6022, 6075)?.GetUpdatedTypeForLocalSymbol(local))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6096, 6435) || true) && (!f_10586_6101_6184(_remappedSymbols, f_10586_6130_6152(local), out updatedContaining) && (DynAbs.Tracing.TraceSender.Expression_True(10586, 6100, 6209) && f_10586_6188_6209_M(!updatedType.HasValue)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 6096, 6435);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6346, 6381);

                            f_10586_6346_6380(                    // Map the local to itself so we don't have to search again in the future
                                                _remappedSymbols, local, local);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6403, 6416);

                            return local;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 6096, 6435);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6455, 6618);

                        updatedLocal = f_10586_6470_6617(local, updatedContaining ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10586, 6531, 6574) ?? f_10586_6552_6574(local)), updatedType ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?>(10586, 6576, 6616) ?? f_10586_6591_6616(local)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6636, 6678);

                        f_10586_6636_6677(_remappedSymbols, local, updatedLocal);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6696, 6716);

                        return updatedLocal;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10586, 5767, 6731);

                        bool
                        f_10586_5846_5903(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                        key, out Microsoft.CodeAnalysis.CSharp.Symbol
                        value)
                        {
                            var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 5846, 5903);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?
                        f_10586_6022_6075_I(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 6022, 6075);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10586_6130_6152(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 6130, 6152);
                            return return_v;
                        }


                        bool
                        f_10586_6101_6184(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        key, out Microsoft.CodeAnalysis.CSharp.Symbol?
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 6101, 6184);
                            return return_v;
                        }


                        bool
                        f_10586_6188_6209_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 6188, 6209);
                            return return_v;
                        }


                        int
                        f_10586_6346_6380(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                        key, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                        value)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.Symbol)value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 6346, 6380);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10586_6552_6574(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 6552, 6574);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10586_6591_6616(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10586, 6591, 6616);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.UpdatedContainingSymbolAndNullableAnnotationLocal
                        f_10586_6470_6617(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                        underlyingLocal, Microsoft.CodeAnalysis.CSharp.Symbol
                        updatedContainingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        updatedType)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UpdatedContainingSymbolAndNullableAnnotationLocal(underlyingLocal, updatedContainingSymbol, updatedType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 6470, 6617);
                            return return_v;
                        }


                        int
                        f_10586_6636_6677(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                        key, Microsoft.CodeAnalysis.CSharp.Symbol
                        value)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 6636, 6677);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10586, 5767, 6731);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 5767, 6731);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10586, 3308, 6742);

                bool?
                f_10586_3494_3561_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 3494, 3561);
                    return return_v;
                }


                int
                f_10586_3652_3695<T>(bool
                b) where T : Symbol?

                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 3652, 3695);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10586_3824_3862<T>(Microsoft.CodeAnalysis.CSharp.BoundNode
                boundLambda, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                lambda) where T : Symbol?

                {
                    var return_v = remapLambda((Microsoft.CodeAnalysis.CSharp.BoundLambda)boundLambda, lambda);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 3824, 3862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10586_3944_3961<T>(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                local) where T : Symbol?

                {
                    var return_v = remapLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 3944, 3961);
                    return return_v;
                }


                bool
                f_10586_4035_4092<T>(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbol
                value) where T : Symbol?

                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 4035, 4092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10586, 3308, 6742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 3308, 6742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<T> GetUpdatedArray<T>(BoundNode expr, ImmutableArray<T> symbols) where T : Symbol?
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10586, 6754, 7881);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6884, 6976) || true) && (symbols.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 6884, 6976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6946, 6961);

                    return symbols;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 6884, 6976);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 6992, 7050);

                var
                builder = f_10586_7006_7049<T>(symbols.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7064, 7089);

                bool
                foundUpdate = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7103, 7640);
                    foreach (var originalSymbol in f_10586_7134_7141_I<T>(symbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 7103, 7640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7175, 7199);

                        T
                        updatedSymbol = null!
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7217, 7578) || true) && (originalSymbol is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 7217, 7578);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7287, 7342);

                            updatedSymbol = f_10586_7303_7341<T>(this, expr, originalSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7364, 7402);

                            f_10586_7364_7401<T>(updatedSymbol is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7424, 7559) || true) && ((object)originalSymbol != updatedSymbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 7424, 7559);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7517, 7536);

                                foundUpdate = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 7424, 7559);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 7217, 7578);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7598, 7625);

                        f_10586_7598_7624<T>(
                                        builder, updatedSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 7103, 7640);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10586, 1, 538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10586, 1, 538);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7656, 7870) || true) && (foundUpdate)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 7656, 7870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7705, 7741);

                    return f_10586_7712_7740<T>(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 7656, 7870);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10586, 7656, 7870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7807, 7822);

                    f_10586_7807_7821<T>(builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10586, 7840, 7855);

                    return symbols;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10586, 7656, 7870);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10586, 6754, 7881);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_10586_7006_7049<T>(int
                capacity) where T : Symbol?

                {
                    var return_v = ArrayBuilder<T>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 7006, 7049);
                    return return_v;
                }


                T
                f_10586_7303_7341<T>(Microsoft.CodeAnalysis.CSharp.NullabilityRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                expr, T
                sym) where T : Symbol?

                {
                    var return_v = this_param.GetUpdatedSymbol<T>(expr, sym);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 7303, 7341);
                    return return_v;
                }


                int
                f_10586_7364_7401<T>(bool
                condition) where T : Symbol?

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 7364, 7401);
                    return 0;
                }


                int
                f_10586_7598_7624<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param, T
                item) where T : Symbol?

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 7598, 7624);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_10586_7134_7141_I<T>(System.Collections.Immutable.ImmutableArray<T>
                i) where T : Symbol?

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 7134, 7141);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_10586_7712_7740<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param) where T : Symbol?

                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 7712, 7740);
                    return return_v;
                }


                int
                f_10586_7807_7821<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                this_param) where T : Symbol?

                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10586, 7807, 7821);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10586, 6754, 7881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 6754, 7881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NullabilityRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10586, 438, 7888);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10586, 438, 7888);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10586, 438, 7888);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10586, 438, 7888);
    }
}
