// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class IteratorMethodToStateMachineRewriter
    {
        private sealed class YieldsInTryAnalysis : LabelCollector
        {
            private Dictionary<BoundTryStatement, HashSet<LabelSymbol>> _labelsInYieldingTrys;

            private bool _seenYield;

            public YieldsInTryAnalysis(BoundStatement body)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10469, 1140, 1289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 1022, 1043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 1113, 1123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 1220, 1239);

                    _seenYield = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 1257, 1274);

                    f_10469_1257_1273(this, body);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10469, 1140, 1289);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 1140, 1289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 1140, 1289);
                }
            }

            public bool ContainsYields(BoundTryStatement statement)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10469, 1450, 1638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 1538, 1623);

                    return _labelsInYieldingTrys != null && (DynAbs.Tracing.TraceSender.Expression_True(10469, 1545, 1622) && f_10469_1578_1622(_labelsInYieldingTrys, statement));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10469, 1450, 1638);

                    bool
                    f_10469_1578_1622(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10469, 1578, 1622);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 1450, 1638);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 1450, 1638);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool ContainsYieldsInTrys()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10469, 1789, 1908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 1856, 1893);

                    return _labelsInYieldingTrys != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10469, 1789, 1908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 1789, 1908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 1789, 1908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal HashSet<LabelSymbol> Labels(BoundTryStatement statement)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10469, 2120, 2273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2218, 2258);

                    return f_10469_2225_2257(_labelsInYieldingTrys, statement);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10469, 2120, 2273);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10469_2225_2257(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10469, 2225, 2257);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 2120, 2273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 2120, 2273);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitTryStatement(BoundTryStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10469, 2289, 3802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2389, 2420);

                    var
                    origSeenYield = _seenYield
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2438, 2474);

                    var
                    origLabels = this.currentLabels
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2564, 2583);

                    _seenYield = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2601, 2627);

                    this.currentLabels = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2647, 2676);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTryStatement(node), 10469, 2647, 2675);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2696, 3697) || true) && (_seenYield)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10469, 2696, 3697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2796, 2842);

                        var
                        yieldingTryLabels = _labelsInYieldingTrys
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2864, 3068) || true) && (yieldingTryLabels == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10469, 2864, 3068);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 2943, 3045);

                            _labelsInYieldingTrys = yieldingTryLabels = f_10469_2987_3044();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10469, 2864, 3068);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3092, 3135);

                        f_10469_3092_3134(
                                            yieldingTryLabels, node, currentLabels);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3157, 3184);

                        currentLabels = origLabels;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10469, 2696, 3697);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10469, 2696, 3697);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3395, 3678) || true) && (currentLabels == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10469, 3395, 3678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3470, 3497);

                            currentLabels = origLabels;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10469, 3395, 3678);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10469, 3395, 3678);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3547, 3678) || true) && (origLabels != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10469, 3547, 3678);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3619, 3655);

                                f_10469_3619_3654(currentLabels, origLabels);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10469, 3547, 3678);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10469, 3395, 3678);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10469, 2696, 3697);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3717, 3757);

                    _seenYield = _seenYield | origSeenYield;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3775, 3787);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10469, 2289, 3802);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                    f_10469_2987_3044()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10469, 2987, 3044);
                        return return_v;
                    }


                    int
                    f_10469_3092_3134(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundTryStatement, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    key, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>?
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10469, 3092, 3134);
                        return 0;
                    }


                    int
                    f_10469_3619_3654(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    other)
                    {
                        this_param.UnionWith((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10469, 3619, 3654);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 2289, 3802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 2289, 3802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitYieldReturnStatement(BoundYieldReturnStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10469, 3818, 4029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3934, 3952);

                    _seenYield = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 3970, 4014);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitYieldReturnStatement(node), 10469, 3977, 4013);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10469, 3818, 4029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 3818, 4029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 3818, 4029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitExpressionStatement(BoundExpressionStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10469, 4045, 4261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 4234, 4246);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10469, 4045, 4261);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 4045, 4261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 4045, 4261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static YieldsInTryAnalysis()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10469, 597, 4272);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10469, 597, 4272);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 597, 4272);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10469, 597, 4272);

            Microsoft.CodeAnalysis.CSharp.BoundNode?
            f_10469_1257_1273(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.YieldsInTryAnalysis
            this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
            node)
            {
                var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10469, 1257, 1273);
                return return_v;
            }

        }
    }
    internal abstract class LabelCollector : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
    {
        protected HashSet<LabelSymbol> currentLabels;

        public override BoundNode VisitLabelStatement(BoundLabelStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10469, 4588, 4772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 4684, 4709);

                f_10469_4684_4708(this, f_10469_4697_4707(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 4723, 4761);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabelStatement(node), 10469, 4730, 4760);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10469, 4588, 4772);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10469_4697_4707(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10469, 4697, 4707);
                    return return_v;
                }


                int
                f_10469_4684_4708(Microsoft.CodeAnalysis.CSharp.LabelCollector
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.CollectLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10469, 4684, 4708);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 4588, 4772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 4588, 4772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CollectLabel(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10469, 4784, 5188);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 4853, 5177) || true) && ((object)label != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10469, 4853, 5177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 4912, 4951);

                    var
                    currentLabels = this.currentLabels
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 4969, 5119) || true) && (currentLabels == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10469, 4969, 5119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 5036, 5100);

                        this.currentLabels = currentLabels = f_10469_5073_5099();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10469, 4969, 5119);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 5137, 5162);

                    f_10469_5137_5161(currentLabels, label);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10469, 4853, 5177);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10469, 4784, 5188);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10469_5073_5099()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10469, 5073, 5099);
                    return return_v;
                }


                bool
                f_10469_5137_5161(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10469, 5137, 5161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10469, 4784, 5188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 4784, 5188);
            }
        }

        public LabelCollector()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10469, 4368, 5195);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10469, 4562, 4575);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10469, 4368, 5195);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 4368, 5195);
        }


        static LabelCollector()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10469, 4368, 5195);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10469, 4368, 5195);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10469, 4368, 5195);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10469, 4368, 5195);
    }
}
