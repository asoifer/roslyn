// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    partial class BoundDecisionDagNode
    {
        public override bool Equals(object? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10552, 374, 1349);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 441, 489) || true) && (this == other)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 441, 489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 477, 489);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 441, 489);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 505, 1338);

                switch (this, other)
                {

                    case (BoundEvaluationDecisionDagNode n1, BoundEvaluationDecisionDagNode n2):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 505, 1338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 656, 721);

                        return f_10552_663_698(f_10552_663_676(n1), f_10552_684_697(n2)) && (DynAbs.Tracing.TraceSender.Expression_True(10552, 663, 720) && f_10552_702_709(n1) == f_10552_713_720(n2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 505, 1338);

                    case (BoundTestDecisionDagNode n1, BoundTestDecisionDagNode n2):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 505, 1338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 825, 918);

                        return f_10552_832_855(f_10552_832_839(n1), f_10552_847_854(n2)) && (DynAbs.Tracing.TraceSender.Expression_True(10552, 832, 885) && f_10552_859_870(n1) == f_10552_874_885(n2)) && (DynAbs.Tracing.TraceSender.Expression_True(10552, 832, 917) && f_10552_889_901(n1) == f_10552_905_917(n2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 505, 1338);

                    case (BoundWhenDecisionDagNode n1, BoundWhenDecisionDagNode n2):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 505, 1338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 1022, 1130);

                        return f_10552_1029_1046(n1) == f_10552_1050_1067(n2) && (DynAbs.Tracing.TraceSender.Expression_True(10552, 1029, 1097) && f_10552_1071_1082(n1) == f_10552_1086_1097(n2)) && (DynAbs.Tracing.TraceSender.Expression_True(10552, 1029, 1129) && f_10552_1101_1113(n1) == f_10552_1117_1129(n2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 505, 1338);

                    case (BoundLeafDecisionDagNode n1, BoundLeafDecisionDagNode n2):
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 505, 1338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 1234, 1262);

                        return f_10552_1241_1249(n1) == f_10552_1253_1261(n2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 505, 1338);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 505, 1338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 1310, 1323);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 505, 1338);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10552, 374, 1349);

                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                f_10552_663_676(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Evaluation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 663, 676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                f_10552_684_697(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Evaluation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 684, 697);
                    return return_v;
                }


                bool
                f_10552_663_698(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 663, 698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_702_709(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 702, 709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_713_720(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 713, 720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTest
                f_10552_832_839(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 832, 839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTest
                f_10552_847_854(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 847, 854);
                    return return_v;
                }


                bool
                f_10552_832_855(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 832, 855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_859_870(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 859, 870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_874_885(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 874, 885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_889_901(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 889, 901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_905_917(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 905, 917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10552_1029_1046(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1029, 1046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10552_1050_1067(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1050, 1067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_1071_1082(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1071, 1082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_1086_1097(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1086, 1097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10552_1101_1113(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1101, 1113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                f_10552_1117_1129(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1117, 1129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10552_1241_1249(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1241, 1249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10552_1253_1261(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1253, 1261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10552, 374, 1349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10552, 374, 1349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10552, 1361, 2403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 1419, 2392);

                switch (this)
                {

                    case BoundEvaluationDecisionDagNode n:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 1419, 2392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 1525, 1609);

                        return f_10552_1532_1608(f_10552_1545_1571(f_10552_1545_1557(n)), f_10552_1573_1607(f_10552_1600_1606(n)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 1419, 2392);

                    case BoundTestDecisionDagNode n:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 1419, 2392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 1681, 1818);

                        return f_10552_1688_1817(f_10552_1701_1721(f_10552_1701_1707(n)), f_10552_1723_1816(f_10552_1736_1775(f_10552_1763_1774(n)), f_10552_1777_1815(f_10552_1804_1814(n))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 1419, 2392);

                    case BoundWhenDecisionDagNode n:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 1419, 2392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 2004, 2167);

                        return f_10552_2011_2166(f_10552_2024_2069(n.WhenExpression!), f_10552_2071_2165(f_10552_2084_2124(n.WhenFalse!), f_10552_2126_2164(f_10552_2153_2163(n))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 1419, 2392);

                    case BoundLeafDecisionDagNode n:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 1419, 2392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 2239, 2282);

                        return f_10552_2246_2281(f_10552_2273_2280(n));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 1419, 2392);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10552, 1419, 2392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10552, 2330, 2377);

                        throw f_10552_2336_2376(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10552, 1419, 2392);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10552, 1361, 2403);

                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                f_10552_1545_1557(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Evaluation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1545, 1557);
                    return return_v;
                }


                int
                f_10552_1545_1571(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 1545, 1571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_1600_1606(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1600, 1606);
                    return return_v;
                }


                int
                f_10552_1573_1607(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 1573, 1607);
                    return return_v;
                }


                int
                f_10552_1532_1608(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 1532, 1608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTest
                f_10552_1701_1707(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1701, 1707);
                    return return_v;
                }


                int
                f_10552_1701_1721(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 1701, 1721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_1763_1774(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1763, 1774);
                    return return_v;
                }


                int
                f_10552_1736_1775(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 1736, 1775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_1804_1814(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 1804, 1814);
                    return return_v;
                }


                int
                f_10552_1777_1815(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 1777, 1815);
                    return return_v;
                }


                int
                f_10552_1723_1816(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 1723, 1816);
                    return return_v;
                }


                int
                f_10552_1688_1817(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 1688, 1817);
                    return return_v;
                }


                int
                f_10552_2024_2069(Microsoft.CodeAnalysis.CSharp.BoundExpression
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 2024, 2069);
                    return return_v;
                }


                int
                f_10552_2084_2124(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 2084, 2124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10552_2153_2163(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                this_param)
                {
                    var return_v = this_param.WhenTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 2153, 2163);
                    return return_v;
                }


                int
                f_10552_2126_2164(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 2126, 2164);
                    return return_v;
                }


                int
                f_10552_2071_2165(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 2071, 2165);
                    return return_v;
                }


                int
                f_10552_2011_2166(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 2011, 2166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10552_2273_2280(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10552, 2273, 2280);
                    return return_v;
                }


                int
                f_10552_2246_2281(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 2246, 2281);
                    return return_v;
                }


                System.Exception
                f_10552_2336_2376(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10552, 2336, 2376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10552, 1361, 2403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10552, 1361, 2403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundDecisionDagNode()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10552, 323, 2410);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10552, 323, 2410);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10552, 323, 2410);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10552, 323, 2410);
    }
}
