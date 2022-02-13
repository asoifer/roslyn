// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class Instrumenter
    {
        public static readonly Instrumenter NoOp;

        public Instrumenter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10464, 1431, 1474);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10464, 1431, 1474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 1431, 1474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 1431, 1474);
            }
        }

        private static BoundStatement InstrumentStatement(BoundStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10464, 1486, 1698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 1611, 1656);

                f_10464_1611_1655(f_10464_1624_1654_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 1670, 1687);

                return rewritten;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10464, 1486, 1698);

                bool
                f_10464_1624_1654_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 1624, 1654);
                    return return_v;
                }


                int
                f_10464_1611_1655(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 1611, 1655);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 1486, 1698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 1486, 1698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentNoOpStatement(BoundNoOpStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 1710, 1902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 1843, 1891);

                return f_10464_1850_1890(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 1710, 1902);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_1850_1890(Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 1850, 1890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 1710, 1902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 1710, 1902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentYieldBreakStatement(BoundYieldBreakStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 1914, 2192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 2059, 2150);

                f_10464_2059_2149(f_10464_2072_2102_M(!original.WasCompilerGenerated) || (DynAbs.Tracing.TraceSender.Expression_False(10464, 2072, 2148) || f_10464_2106_2128(original.Syntax) == SyntaxKind.Block));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 2164, 2181);

                return rewritten;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 1914, 2192);

                bool
                f_10464_2072_2102_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 2072, 2102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_2106_2128(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 2106, 2128);
                    return return_v;
                }


                int
                f_10464_2059_2149(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 2059, 2149);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 1914, 2192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 1914, 2192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentYieldReturnStatement(BoundYieldReturnStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 2204, 2410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 2351, 2399);

                return f_10464_2358_2398(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 2204, 2410);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_2358_2398(Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 2358, 2398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 2204, 2410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 2204, 2410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement? CreateBlockPrologue(BoundBlock original, out Symbols.LocalSymbol? synthesizedLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 2564, 2764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 2703, 2727);

                synthesizedLocal = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 2741, 2753);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 2564, 2764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 2564, 2764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 2564, 2764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement? CreateBlockEpilogue(BoundBlock original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 2919, 3038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 3015, 3027);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 2919, 3038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 2919, 3038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 2919, 3038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentThrowStatement(BoundThrowStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 3050, 3244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 3185, 3233);

                return f_10464_3192_3232(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 3050, 3244);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_3192_3232(Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 3192, 3232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 3050, 3244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 3050, 3244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentContinueStatement(BoundContinueStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 3256, 3456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 3397, 3445);

                return f_10464_3404_3444(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 3256, 3456);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_3404_3444(Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 3404, 3444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 3256, 3456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 3256, 3456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentGotoStatement(BoundGotoStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 3468, 3660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 3601, 3649);

                return f_10464_3608_3648(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 3468, 3660);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_3608_3648(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 3608, 3648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 3468, 3660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 3468, 3660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentExpressionStatement(BoundExpressionStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 3672, 3876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 3817, 3865);

                return f_10464_3824_3864(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 3672, 3876);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_3824_3864(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 3824, 3864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 3672, 3876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 3672, 3876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentFieldOrPropertyInitializer(BoundStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 3888, 4170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 4030, 4097);

                f_10464_4030_4096(f_10464_4043_4095(original));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 4111, 4159);

                return f_10464_4118_4158(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 3888, 4170);

                bool
                f_10464_4043_4095(Microsoft.CodeAnalysis.CSharp.BoundStatement
                initializer)
                {
                    var return_v = LocalRewriter.IsFieldOrPropertyInitializer(initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4043, 4095);
                    return return_v;
                }


                int
                f_10464_4030_4096(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4030, 4096);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_4118_4158(Microsoft.CodeAnalysis.CSharp.BoundStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4118, 4158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 3888, 4170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 3888, 4170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentBreakStatement(BoundBreakStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 4182, 4376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 4317, 4365);

                return f_10464_4324_4364(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 4182, 4376);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_4324_4364(Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4324, 4364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 4182, 4376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 4182, 4376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundExpression InstrumentDoStatementCondition(BoundDoStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 4388, 4789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 4572, 4617);

                f_10464_4572_4616(f_10464_4585_4615_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 4631, 4694);

                f_10464_4631_4693(f_10464_4644_4666(original.Syntax) == SyntaxKind.DoStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 4708, 4738);

                f_10464_4708_4737(factory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 4752, 4778);

                return rewrittenCondition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 4388, 4789);

                bool
                f_10464_4585_4615_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 4585, 4615);
                    return return_v;
                }


                int
                f_10464_4572_4616(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4572, 4616);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_4644_4666(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4644, 4666);
                    return return_v;
                }


                int
                f_10464_4631_4693(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4631, 4693);
                    return 0;
                }


                int
                f_10464_4708_4737(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4708, 4737);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 4388, 4789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 4388, 4789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundExpression InstrumentWhileStatementCondition(BoundWhileStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 4801, 5211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 4991, 5036);

                f_10464_4991_5035(f_10464_5004_5034_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5050, 5116);

                f_10464_5050_5115(f_10464_5063_5085(original.Syntax) == SyntaxKind.WhileStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5130, 5160);

                f_10464_5130_5159(factory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5174, 5200);

                return rewrittenCondition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 4801, 5211);

                bool
                f_10464_5004_5034_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 5004, 5034);
                    return return_v;
                }


                int
                f_10464_4991_5035(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 4991, 5035);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_5063_5085(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5063, 5085);
                    return return_v;
                }


                int
                f_10464_5050_5115(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5050, 5115);
                    return 0;
                }


                int
                f_10464_5130_5159(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5130, 5159);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 4801, 5211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 4801, 5211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentDoStatementConditionalGotoStart(BoundDoStatement original, BoundStatement ifConditionGotoStart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 5223, 5558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5383, 5428);

                f_10464_5383_5427(f_10464_5396_5426_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5442, 5505);

                f_10464_5442_5504(f_10464_5455_5477(original.Syntax) == SyntaxKind.DoStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5519, 5547);

                return ifConditionGotoStart;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 5223, 5558);

                bool
                f_10464_5396_5426_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 5396, 5426);
                    return return_v;
                }


                int
                f_10464_5383_5427(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5383, 5427);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_5455_5477(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5455, 5477);
                    return return_v;
                }


                int
                f_10464_5442_5504(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5442, 5504);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 5223, 5558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 5223, 5558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentWhileStatementConditionalGotoStartOrBreak(BoundWhileStatement original, BoundStatement ifConditionGotoStart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 5570, 5921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5743, 5788);

                f_10464_5743_5787(f_10464_5756_5786_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5802, 5868);

                f_10464_5802_5867(f_10464_5815_5837(original.Syntax) == SyntaxKind.WhileStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 5882, 5910);

                return ifConditionGotoStart;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 5570, 5921);

                bool
                f_10464_5756_5786_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 5756, 5786);
                    return return_v;
                }


                int
                f_10464_5743_5787(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5743, 5787);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_5815_5837(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5815, 5837);
                    return return_v;
                }


                int
                f_10464_5802_5867(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 5802, 5867);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 5570, 5921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 5570, 5921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("collectionVarDecl")]
        public virtual BoundStatement? InstrumentForEachStatementCollectionVarDeclaration(BoundForEachStatement original, BoundStatement? collectionVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 5933, 6334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 6163, 6208);

                f_10464_6163_6207(f_10464_6176_6206_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 6222, 6284);

                f_10464_6222_6283(original.Syntax is CommonForEachStatementSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 6298, 6323);

                return collectionVarDecl;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 5933, 6334);

                bool
                f_10464_6176_6206_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 6176, 6206);
                    return return_v;
                }


                int
                f_10464_6163_6207(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 6163, 6207);
                    return 0;
                }


                int
                f_10464_6222_6283(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 6222, 6283);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 5933, 6334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 5933, 6334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentForEachStatement(BoundForEachStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 6346, 6620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 6485, 6547);

                f_10464_6485_6546(original.Syntax is CommonForEachStatementSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 6561, 6609);

                return f_10464_6568_6608(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 6346, 6620);

                int
                f_10464_6485_6546(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 6485, 6546);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_6568_6608(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 6568, 6608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 6346, 6620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 6346, 6620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentForEachStatementIterationVarDeclaration(BoundForEachStatement original, BoundStatement iterationVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 6632, 6977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 6801, 6846);

                f_10464_6801_6845(f_10464_6814_6844_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 6860, 6928);

                f_10464_6860_6927(f_10464_6873_6895(original.Syntax) == SyntaxKind.ForEachStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 6942, 6966);

                return iterationVarDecl;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 6632, 6977);

                bool
                f_10464_6814_6844_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 6814, 6844);
                    return return_v;
                }


                int
                f_10464_6801_6845(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 6801, 6845);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_6873_6895(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 6873, 6895);
                    return return_v;
                }


                int
                f_10464_6860_6927(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 6860, 6927);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 6632, 6977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 6632, 6977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentForEachStatementDeconstructionVariablesDeclaration(BoundForEachStatement original, BoundStatement iterationVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 6989, 7353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7169, 7214);

                f_10464_7169_7213(f_10464_7182_7212_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7228, 7304);

                f_10464_7228_7303(f_10464_7241_7263(original.Syntax) == SyntaxKind.ForEachVariableStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7318, 7342);

                return iterationVarDecl;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 6989, 7353);

                bool
                f_10464_7182_7212_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 7182, 7212);
                    return return_v;
                }


                int
                f_10464_7169_7213(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 7169, 7213);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_7241_7263(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 7241, 7263);
                    return return_v;
                }


                int
                f_10464_7228_7303(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 7228, 7303);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 6989, 7353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 6989, 7353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentForEachStatementConditionalGotoStart(BoundForEachStatement original, BoundStatement branchBack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 7365, 7689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7525, 7570);

                f_10464_7525_7569(f_10464_7538_7568_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7584, 7646);

                f_10464_7584_7645(original.Syntax is CommonForEachStatementSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7660, 7678);

                return branchBack;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 7365, 7689);

                bool
                f_10464_7538_7568_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 7538, 7568);
                    return return_v;
                }


                int
                f_10464_7525_7569(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 7525, 7569);
                    return 0;
                }


                int
                f_10464_7584_7645(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 7584, 7645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 7365, 7689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 7365, 7689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentForStatementConditionalGotoStartOrBreak(BoundForStatement original, BoundStatement branchBack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 7701, 8026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7860, 7905);

                f_10464_7860_7904(f_10464_7873_7903_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7919, 7983);

                f_10464_7919_7982(f_10464_7932_7954(original.Syntax) == SyntaxKind.ForStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 7997, 8015);

                return branchBack;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 7701, 8026);

                bool
                f_10464_7873_7903_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 7873, 7903);
                    return return_v;
                }


                int
                f_10464_7860_7904(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 7860, 7904);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_7932_7954(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 7932, 7954);
                    return return_v;
                }


                int
                f_10464_7919_7982(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 7919, 7982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 7701, 8026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 7701, 8026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundExpression InstrumentForStatementCondition(BoundForStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 8038, 8442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 8224, 8269);

                f_10464_8224_8268(f_10464_8237_8267_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 8283, 8347);

                f_10464_8283_8346(f_10464_8296_8318(original.Syntax) == SyntaxKind.ForStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 8361, 8391);

                f_10464_8361_8390(factory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 8405, 8431);

                return rewrittenCondition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 8038, 8442);

                bool
                f_10464_8237_8267_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 8237, 8267);
                    return return_v;
                }


                int
                f_10464_8224_8268(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8224, 8268);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_8296_8318(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8296, 8318);
                    return return_v;
                }


                int
                f_10464_8283_8346(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8283, 8346);
                    return 0;
                }


                int
                f_10464_8361_8390(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8361, 8390);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 8038, 8442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 8038, 8442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentIfStatement(BoundIfStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 8454, 8719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 8583, 8646);

                f_10464_8583_8645(f_10464_8596_8618(original.Syntax) == SyntaxKind.IfStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 8660, 8708);

                return f_10464_8667_8707(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 8454, 8719);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_8596_8618(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8596, 8618);
                    return return_v;
                }


                int
                f_10464_8583_8645(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8583, 8645);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_8667_8707(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8667, 8707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 8454, 8719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 8454, 8719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundExpression InstrumentIfStatementCondition(BoundIfStatement original, BoundExpression rewrittenCondition, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 8731, 9132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 8915, 8960);

                f_10464_8915_8959(f_10464_8928_8958_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 8974, 9037);

                f_10464_8974_9036(f_10464_8987_9009(original.Syntax) == SyntaxKind.IfStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 9051, 9081);

                f_10464_9051_9080(factory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 9095, 9121);

                return rewrittenCondition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 8731, 9132);

                bool
                f_10464_8928_8958_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 8928, 8958);
                    return return_v;
                }


                int
                f_10464_8915_8959(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8915, 8959);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_8987_9009(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8987, 9009);
                    return return_v;
                }


                int
                f_10464_8974_9036(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 8974, 9036);
                    return 0;
                }


                int
                f_10464_9051_9080(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 9051, 9080);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 8731, 9132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 8731, 9132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentLabelStatement(BoundLabeledStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 9144, 9422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 9281, 9349);

                f_10464_9281_9348(f_10464_9294_9316(original.Syntax) == SyntaxKind.LabeledStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 9363, 9411);

                return f_10464_9370_9410(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 9144, 9422);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_9294_9316(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 9294, 9316);
                    return return_v;
                }


                int
                f_10464_9281_9348(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 9281, 9348);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_9370_9410(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 9370, 9410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 9144, 9422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 9144, 9422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentLocalInitialization(BoundLocalDeclaration original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 9434, 9933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 9576, 9860);

                f_10464_9576_9859(f_10464_9589_9611(original.Syntax) == SyntaxKind.VariableDeclarator || (DynAbs.Tracing.TraceSender.Expression_False(10464, 9589, 9858) || (f_10464_9675_9697(original.Syntax) == SyntaxKind.LocalDeclarationStatement && (DynAbs.Tracing.TraceSender.Expression_True(10464, 9675, 9857) && f_10464_9774_9836(((LocalDeclarationStatementSyntax)original.Syntax)).Variables.Count == 1))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 9874, 9922);

                return f_10464_9881_9921(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 9434, 9933);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_9589_9611(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 9589, 9611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_9675_9697(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 9675, 9697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10464_9774_9836(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 9774, 9836);
                    return return_v;
                }


                int
                f_10464_9576_9859(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 9576, 9859);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_9881_9921(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 9881, 9921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 9434, 9933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 9434, 9933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentLockTargetCapture(BoundLockStatement original, BoundStatement lockTargetCapture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 9945, 10264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 10090, 10135);

                f_10464_10090_10134(f_10464_10103_10133_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 10149, 10214);

                f_10464_10149_10213(f_10464_10162_10184(original.Syntax) == SyntaxKind.LockStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 10228, 10253);

                return lockTargetCapture;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 9945, 10264);

                bool
                f_10464_10103_10133_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 10103, 10133);
                    return return_v;
                }


                int
                f_10464_10090_10134(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 10090, 10134);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_10162_10184(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 10162, 10184);
                    return return_v;
                }


                int
                f_10464_10149_10213(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 10149, 10213);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 9945, 10264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 9945, 10264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentReturnStatement(BoundReturnStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 10276, 10441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 10413, 10430);

                return rewritten;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 10276, 10441);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 10276, 10441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 10276, 10441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentSwitchStatement(BoundSwitchStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 10453, 10730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 10590, 10657);

                f_10464_10590_10656(f_10464_10603_10625(original.Syntax) == SyntaxKind.SwitchStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 10671, 10719);

                return f_10464_10678_10718(original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 10453, 10730);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_10603_10625(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 10603, 10625);
                    return return_v;
                }


                int
                f_10464_10590_10656(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 10590, 10656);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10464_10678_10718(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = InstrumentStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 10678, 10718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 10453, 10730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 10453, 10730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentSwitchWhenClauseConditionalGotoBody(BoundExpression original, BoundStatement ifConditionGotoBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 11105, 11456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 11267, 11312);

                f_10464_11267_11311(f_10464_11280_11310_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 11326, 11404);

                f_10464_11326_11403(f_10464_11339_11394(original.Syntax) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 11418, 11445);

                return ifConditionGotoBody;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 11105, 11456);

                bool
                f_10464_11280_11310_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 11280, 11310);
                    return return_v;
                }


                int
                f_10464_11267_11311(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 11267, 11311);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10464_11339_11394(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 11339, 11394);
                    return return_v;
                }


                int
                f_10464_11326_11403(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 11326, 11403);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 11105, 11456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 11105, 11456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentUsingTargetCapture(BoundUsingStatement original, BoundStatement usingTargetCapture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 11468, 11792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 11616, 11661);

                f_10464_11616_11660(f_10464_11629_11659_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 11675, 11741);

                f_10464_11675_11740(f_10464_11688_11710(original.Syntax) == SyntaxKind.UsingStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 11755, 11781);

                return usingTargetCapture;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 11468, 11792);

                bool
                f_10464_11629_11659_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 11629, 11659);
                    return return_v;
                }


                int
                f_10464_11616_11660(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 11616, 11660);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_11688_11710(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 11688, 11710);
                    return return_v;
                }


                int
                f_10464_11675_11740(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 11675, 11740);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 11468, 11792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 11468, 11792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundExpression InstrumentCatchClauseFilter(BoundCatchBlock original, BoundExpression rewrittenFilter, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 11804, 12275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 11981, 12026);

                f_10464_11981_12025(f_10464_11994_12024_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12040, 12103);

                f_10464_12040_12102(f_10464_12053_12075(original.Syntax) == SyntaxKind.CatchClause);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12117, 12183);

                f_10464_12117_12182(f_10464_12130_12173(((CatchClauseSyntax)original.Syntax)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12197, 12227);

                f_10464_12197_12226(factory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12241, 12264);

                return rewrittenFilter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 11804, 12275);

                bool
                f_10464_11994_12024_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 11994, 12024);
                    return return_v;
                }


                int
                f_10464_11981_12025(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 11981, 12025);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_12053_12075(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12053, 12075);
                    return return_v;
                }


                int
                f_10464_12040_12102(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12040, 12102);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax?
                f_10464_12130_12173(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 12130, 12173);
                    return return_v;
                }


                int
                f_10464_12117_12182(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12117, 12182);
                    return 0;
                }


                int
                f_10464_12197_12226(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12197, 12226);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 11804, 12275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 11804, 12275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundExpression InstrumentSwitchStatementExpression(BoundStatement original, BoundExpression rewrittenExpression, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 12287, 12768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12475, 12532);

                f_10464_12475_12531(f_10464_12488_12501(original) == BoundKind.SwitchStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12546, 12591);

                f_10464_12546_12590(f_10464_12559_12589_M(!original.WasCompilerGenerated));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12605, 12672);

                f_10464_12605_12671(f_10464_12618_12640(original.Syntax) == SyntaxKind.SwitchStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12686, 12716);

                f_10464_12686_12715(factory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 12730, 12757);

                return rewrittenExpression;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 12287, 12768);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10464_12488_12501(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 12488, 12501);
                    return return_v;
                }


                int
                f_10464_12475_12531(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12475, 12531);
                    return 0;
                }


                bool
                f_10464_12559_12589_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10464, 12559, 12589);
                    return return_v;
                }


                int
                f_10464_12546_12590(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12546, 12590);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10464_12618_12640(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12618, 12640);
                    return return_v;
                }


                int
                f_10464_12605_12671(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12605, 12671);
                    return 0;
                }


                int
                f_10464_12686_12715(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 12686, 12715);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 12287, 12768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 12287, 12768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundExpression InstrumentSwitchExpressionArmExpression(BoundExpression original, BoundExpression rewrittenExpression, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 12906, 13181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 13099, 13129);

                f_10464_13099_13128(factory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 13143, 13170);

                return rewrittenExpression;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 12906, 13181);

                int
                f_10464_13099_13128(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 13099, 13128);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 12906, 13181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 12906, 13181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual BoundStatement InstrumentSwitchBindCasePatternVariables(BoundStatement bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10464, 13193, 13340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 13313, 13329);

                return bindings;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10464, 13193, 13340);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10464, 13193, 13340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 13193, 13340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Instrumenter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10464, 1145, 13347);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10464, 1393, 1418);
            NoOp = f_10464_1400_1418(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10464, 1145, 13347);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10464, 1145, 13347);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10464, 1145, 13347);

        static Microsoft.CodeAnalysis.CSharp.Instrumenter
        f_10464_1400_1418()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Instrumenter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10464, 1400, 1418);
            return return_v;
        }

    }
}
