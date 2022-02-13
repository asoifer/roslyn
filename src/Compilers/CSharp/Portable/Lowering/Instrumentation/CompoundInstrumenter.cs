// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class CompoundInstrumenter : Instrumenter
    {
        public CompoundInstrumenter(Instrumenter previous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10460, 901, 1052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 1064, 1101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 976, 1007);

                f_10460_976_1006(previous != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 1021, 1041);

                Previous = previous;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10460, 901, 1052);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 901, 1052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 901, 1052);
            }
        }

        public Instrumenter Previous { get; }

        public override BoundStatement InstrumentNoOpStatement(BoundNoOpStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 1113, 1319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 1247, 1308);

                return f_10460_1254_1307(f_10460_1254_1262(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 1113, 1319);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_1254_1262()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 1254, 1262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_1254_1307(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentNoOpStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 1254, 1307);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 1113, 1319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 1113, 1319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentYieldBreakStatement(BoundYieldBreakStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 1331, 1555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 1477, 1544);

                return f_10460_1484_1543(f_10460_1484_1492(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 1331, 1555);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_1484_1492()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 1484, 1492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_1484_1543(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundYieldBreakStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentYieldBreakStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 1484, 1543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 1331, 1555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 1331, 1555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentYieldReturnStatement(BoundYieldReturnStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 1567, 1794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 1715, 1783);

                return f_10460_1722_1782(f_10460_1722_1730(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 1567, 1794);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_1722_1730()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 1722, 1730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_1722_1782(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentYieldReturnStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 1722, 1782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 1567, 1794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 1567, 1794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentThrowStatement(BoundThrowStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 1806, 2015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 1942, 2004);

                return f_10460_1949_2003(f_10460_1949_1957(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 1806, 2015);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_1949_1957()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 1949, 1957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_1949_2003(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentThrowStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 1949, 2003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 1806, 2015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 1806, 2015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentContinueStatement(BoundContinueStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 2027, 2245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 2169, 2234);

                return f_10460_2176_2233(f_10460_2176_2184(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 2027, 2245);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_2176_2184()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 2176, 2184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_2176_2233(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentContinueStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 2176, 2233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 2027, 2245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 2027, 2245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentGotoStatement(BoundGotoStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 2257, 2463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 2391, 2452);

                return f_10460_2398_2451(f_10460_2398_2406(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 2257, 2463);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_2398_2406()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 2398, 2406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_2398_2451(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentGotoStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 2398, 2451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 2257, 2463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 2257, 2463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentExpressionStatement(BoundExpressionStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 2475, 2699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 2621, 2688);

                return f_10460_2628_2687(f_10460_2628_2636(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 2475, 2699);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_2628_2636()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 2628, 2636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_2628_2687(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentExpressionStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 2628, 2687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 2475, 2699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 2475, 2699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentFieldOrPropertyInitializer(BoundStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 2711, 2939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 2854, 2928);

                return f_10460_2861_2927(f_10460_2861_2869(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 2711, 2939);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_2861_2869()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 2861, 2869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_2861_2927(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentFieldOrPropertyInitializer(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 2861, 2927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 2711, 2939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 2711, 2939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentBreakStatement(BoundBreakStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 2951, 3160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 3087, 3149);

                return f_10460_3094_3148(f_10460_3094_3102(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 2951, 3160);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_3094_3102()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 3094, 3102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_3094_3148(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentBreakStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 3094, 3148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 2951, 3160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 2951, 3160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement? CreateBlockPrologue(BoundBlock original, out Symbols.LocalSymbol? synthesizedLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 3172, 3391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 3312, 3380);

                return f_10460_3319_3379(f_10460_3319_3327(), original, out synthesizedLocal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 3172, 3391);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_3319_3327()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 3319, 3327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10460_3319_3379(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                original, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
                synthesizedLocal)
                {
                    var return_v = this_param.CreateBlockPrologue(original, out synthesizedLocal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 3319, 3379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 3172, 3391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 3172, 3391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement? CreateBlockEpilogue(BoundBlock original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 3403, 3557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 3500, 3546);

                return f_10460_3507_3545(f_10460_3507_3515(), original);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 3403, 3557);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_3507_3515()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 3507, 3515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10460_3507_3545(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                original)
                {
                    var return_v = this_param.CreateBlockEpilogue(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 3507, 3545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 3403, 3557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 3403, 3557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentDoStatementCondition(BoundDoStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 3569, 3851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 3754, 3840);

                return f_10460_3761_3839(f_10460_3761_3769(), original, rewrittenCondition, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 3569, 3851);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_3761_3769()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 3761, 3769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10460_3761_3839(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = this_param.InstrumentDoStatementCondition(original, rewrittenCondition, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 3761, 3839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 3569, 3851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 3569, 3851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentDoStatementConditionalGotoStart(BoundDoStatement original, BoundStatement ifConditionGotoStart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 3863, 4125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 4024, 4114);

                return f_10460_4031_4113(f_10460_4031_4039(), original, ifConditionGotoStart);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 3863, 4125);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_4031_4039()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 4031, 4039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_4031_4113(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                ifConditionGotoStart)
                {
                    var return_v = this_param.InstrumentDoStatementConditionalGotoStart(original, ifConditionGotoStart);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 4031, 4113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 3863, 4125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 3863, 4125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement? InstrumentForEachStatementCollectionVarDeclaration(BoundForEachStatement original, BoundStatement? collectionVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 4137, 4418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 4311, 4407);

                return f_10460_4318_4406(f_10460_4318_4326(), original, collectionVarDecl);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 4137, 4418);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_4318_4326()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 4318, 4326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10460_4318_4406(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                collectionVarDecl)
                {
                    var return_v = this_param.InstrumentForEachStatementCollectionVarDeclaration(original, collectionVarDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 4318, 4406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 4137, 4418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 4137, 4418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatement(BoundForEachStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 4430, 4645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 4570, 4634);

                return f_10460_4577_4633(f_10460_4577_4585(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 4430, 4645);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_4577_4585()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 4577, 4585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_4577_4633(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentForEachStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 4577, 4633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 4430, 4645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 4430, 4645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementIterationVarDeclaration(BoundForEachStatement original, BoundStatement iterationVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 4657, 4932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 4827, 4921);

                return f_10460_4834_4920(f_10460_4834_4842(), original, iterationVarDecl);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 4657, 4932);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_4834_4842()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 4834, 4842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_4834_4920(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                iterationVarDecl)
                {
                    var return_v = this_param.InstrumentForEachStatementIterationVarDeclaration(original, iterationVarDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 4834, 4920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 4657, 4932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 4657, 4932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForStatementConditionalGotoStartOrBreak(BoundForStatement original, BoundStatement branchBack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 4944, 5203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 5104, 5192);

                return f_10460_5111_5191(f_10460_5111_5119(), original, branchBack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 4944, 5203);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_5111_5119()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 5111, 5119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_5111_5191(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                branchBack)
                {
                    var return_v = this_param.InstrumentForStatementConditionalGotoStartOrBreak(original, branchBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 5111, 5191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 4944, 5203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 4944, 5203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementConditionalGotoStart(BoundForEachStatement original, BoundStatement branchBack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 5215, 5472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 5376, 5461);

                return f_10460_5383_5460(f_10460_5383_5391(), original, branchBack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 5215, 5472);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_5383_5391()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 5383, 5391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_5383_5460(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                branchBack)
                {
                    var return_v = this_param.InstrumentForEachStatementConditionalGotoStart(original, branchBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 5383, 5460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 5215, 5472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 5215, 5472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentForStatementCondition(BoundForStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 5484, 5769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 5671, 5758);

                return f_10460_5678_5757(f_10460_5678_5686(), original, rewrittenCondition, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 5484, 5769);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_5678_5686()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 5678, 5686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10460_5678_5757(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = this_param.InstrumentForStatementCondition(original, rewrittenCondition, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 5678, 5757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 5484, 5769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 5484, 5769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentIfStatement(BoundIfStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 5781, 5981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 5911, 5970);

                return f_10460_5918_5969(f_10460_5918_5926(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 5781, 5981);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_5918_5926()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 5918, 5926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_5918_5969(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentIfStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 5918, 5969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 5781, 5981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 5781, 5981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentIfStatementCondition(BoundIfStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 5993, 6275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 6178, 6264);

                return f_10460_6185_6263(f_10460_6185_6193(), original, rewrittenCondition, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 5993, 6275);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_6185_6193()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 6185, 6193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10460_6185_6263(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = this_param.InstrumentIfStatementCondition(original, rewrittenCondition, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 6185, 6263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 5993, 6275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 5993, 6275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentLabelStatement(BoundLabeledStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 6287, 6498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 6425, 6487);

                return f_10460_6432_6486(f_10460_6432_6440(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 6287, 6498);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_6432_6440()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 6432, 6440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_6432_6486(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentLabelStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 6432, 6486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 6287, 6498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 6287, 6498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentLocalInitialization(BoundLocalDeclaration original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 6510, 6731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 6653, 6720);

                return f_10460_6660_6719(f_10460_6660_6668(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 6510, 6731);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_6660_6668()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 6660, 6668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_6660_6719(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentLocalInitialization(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 6660, 6719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 6510, 6731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 6510, 6731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentLockTargetCapture(BoundLockStatement original, BoundStatement lockTargetCapture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 6743, 6973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 6889, 6962);

                return f_10460_6896_6961(f_10460_6896_6904(), original, lockTargetCapture);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 6743, 6973);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_6896_6904()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 6896, 6904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_6896_6961(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLockStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                lockTargetCapture)
                {
                    var return_v = this_param.InstrumentLockTargetCapture(original, lockTargetCapture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 6896, 6961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 6743, 6973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 6743, 6973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentReturnStatement(BoundReturnStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 6985, 7197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 7123, 7186);

                return f_10460_7130_7185(f_10460_7130_7138(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 6985, 7197);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_7130_7138()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 7130, 7138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_7130_7185(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentReturnStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 7130, 7185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 6985, 7197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 6985, 7197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentSwitchStatement(BoundSwitchStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 7209, 7421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 7347, 7410);

                return f_10460_7354_7409(f_10460_7354_7362(), original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 7209, 7421);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_7354_7362()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 7354, 7362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_7354_7409(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.InstrumentSwitchStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 7354, 7409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 7209, 7421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 7209, 7421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentSwitchWhenClauseConditionalGotoBody(BoundExpression original, BoundStatement ifConditionGotoBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 7433, 7700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 7596, 7689);

                return f_10460_7603_7688(f_10460_7603_7611(), original, ifConditionGotoBody);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 7433, 7700);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_7603_7611()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 7603, 7611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_7603_7688(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                ifConditionGotoBody)
                {
                    var return_v = this_param.InstrumentSwitchWhenClauseConditionalGotoBody(original, ifConditionGotoBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 7603, 7688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 7433, 7700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 7433, 7700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentUsingTargetCapture(BoundUsingStatement original, BoundStatement usingTargetCapture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 7712, 7947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 7861, 7936);

                return f_10460_7868_7935(f_10460_7868_7876(), original, usingTargetCapture);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 7712, 7947);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_7868_7876()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 7868, 7876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_7868_7935(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                usingTargetCapture)
                {
                    var return_v = this_param.InstrumentUsingTargetCapture(original, usingTargetCapture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 7868, 7935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 7712, 7947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 7712, 7947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentWhileStatementCondition(BoundWhileStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 7959, 8250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 8150, 8239);

                return f_10460_8157_8238(f_10460_8157_8165(), original, rewrittenCondition, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 7959, 8250);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_8157_8165()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 8157, 8165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10460_8157_8238(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = this_param.InstrumentWhileStatementCondition(original, rewrittenCondition, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 8157, 8238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 7959, 8250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 7959, 8250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentWhileStatementConditionalGotoStartOrBreak(BoundWhileStatement original, BoundStatement ifConditionGotoStart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 8262, 8547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 8436, 8536);

                return f_10460_8443_8535(f_10460_8443_8451(), original, ifConditionGotoStart);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 8262, 8547);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_8443_8451()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 8443, 8451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_8443_8535(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                ifConditionGotoStart)
                {
                    var return_v = this_param.InstrumentWhileStatementConditionalGotoStartOrBreak(original, ifConditionGotoStart);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 8443, 8535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 8262, 8547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 8262, 8547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentCatchClauseFilter(BoundCatchBlock original, BoundExpression rewrittenFilter, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 8559, 8828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 8737, 8817);

                return f_10460_8744_8816(f_10460_8744_8752(), original, rewrittenFilter, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 8559, 8828);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_8744_8752()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 8744, 8752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10460_8744_8816(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenFilter, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = this_param.InstrumentCatchClauseFilter(original, rewrittenFilter, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 8744, 8816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 8559, 8828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 8559, 8828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentSwitchStatementExpression(BoundStatement original, BoundExpression rewrittenExpression, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 8840, 9132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 9029, 9121);

                return f_10460_9036_9120(f_10460_9036_9044(), original, rewrittenExpression, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 8840, 9132);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_9036_9044()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 9036, 9044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10460_9036_9120(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenExpression, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = this_param.InstrumentSwitchStatementExpression(original, rewrittenExpression, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 9036, 9120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 8840, 9132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 8840, 9132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundExpression InstrumentSwitchExpressionArmExpression(BoundExpression original, BoundExpression rewrittenExpression, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 9144, 9445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 9338, 9434);

                return f_10460_9345_9433(f_10460_9345_9353(), original, rewrittenExpression, factory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 9144, 9445);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_9345_9353()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 9345, 9353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10460_9345_9433(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenExpression, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = this_param.InstrumentSwitchExpressionArmExpression(original, rewrittenExpression, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 9345, 9433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 9144, 9445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 9144, 9445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentSwitchBindCasePatternVariables(BoundStatement bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 9457, 9656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 9578, 9645);

                return f_10460_9585_9644(f_10460_9585_9593(), bindings);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 9457, 9656);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_9585_9593()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 9585, 9593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_9585_9644(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                bindings)
                {
                    var return_v = this_param.InstrumentSwitchBindCasePatternVariables(bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 9585, 9644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 9457, 9656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 9457, 9656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementDeconstructionVariablesDeclaration(BoundForEachStatement original, BoundStatement iterationVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10460, 9668, 9965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10460, 9849, 9954);

                return f_10460_9856_9953(f_10460_9856_9864(), original, iterationVarDecl);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10460, 9668, 9965);

                Microsoft.CodeAnalysis.CSharp.Instrumenter
                f_10460_9856_9864()
                {
                    var return_v = Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10460, 9856, 9864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10460_9856_9953(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                iterationVarDecl)
                {
                    var return_v = this_param.InstrumentForEachStatementDeconstructionVariablesDeclaration(original, iterationVarDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 9856, 9953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10460, 9668, 9965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 9668, 9965);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompoundInstrumenter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10460, 834, 9972);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10460, 834, 9972);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10460, 834, 9972);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10460, 834, 9972);

        int
        f_10460_976_1006(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10460, 976, 1006);
            return 0;
        }

    }
}
