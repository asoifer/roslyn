// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public partial class IOperationTests : SemanticModelTestBase
    {
        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_ForNull_ThrowsArgumentNullException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 558, 939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 829, 928);

                f_22013_829_927(() => OperationExtensions.GetCorrespondingOperation(null));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 558, 939);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 558, 939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 558, 939);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_ForGotoBranch_ReturnsNull()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 951, 1611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 1212, 1481);

                var
                result = f_22013_1225_1480(this, @"
class C
{
    void F()
    {
/*<bind>*/begin:
        for (;;)
        {
            /*<bind>*/goto begin;/*</bind>*/
        }/*</bind>*/
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 1495, 1552);

                f_22013_1495_1551(result.outer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 1566, 1600);

                f_22013_1566_1599(result.corresponding);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 951, 1611);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 951, 1611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 951, 1611);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_ForLoopWithBreak()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 1623, 2127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 1886, 2116);

                f_22013_1886_2115(this, @"
class C
{
    void F()
    {
        /*<bind>*/for (;;)
        {
            /*<bind>*/break;/*</bind>*/
        }/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 1623, 2127);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 1623, 2127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 1623, 2127);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_WhileLoopWithContinue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 2139, 2660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 2407, 2649);

                f_22013_2407_2648(this, @"
class C
{
    void F()
    {
        /*<bind>*/while (true)
        {
            /*<bind>*/continue;/*</bind>*/
        }/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 2139, 2660);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 2139, 2660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 2139, 2660);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_DoWhileLoopWithBreakAndContinue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 2672, 3272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 2950, 3261);

                f_22013_2950_3260(this, @"
class C
{
    void F()
    {
        /*<bind>*/do
        {
            if (true)
                break;
            else
                /*<bind>*/continue;/*</bind>*/
        } while (true)/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 2672, 3272);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 2672, 3272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 2672, 3272);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_ForEachLoopWithBreak()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 3284, 3850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 3551, 3839);

                f_22013_3551_3838(this, @"
class C
{
    void F()
    {
        /*<bind>*/foreach (var i in new [] {1,2,3})
        {
            if (i == 2)
                /*<bind>*/break;/*</bind>*/
        }/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 3284, 3850);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 3284, 3850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 3284, 3850);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_ForEachLoopWithBreakAndContinue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 3862, 4485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 4140, 4474);

                f_22013_4140_4473(this, @"
class C
{
    void F()
    {
        /*<bind>*/foreach (var i in new [] {1,2,3})
        {
            if (i == 2) 
                /*<bind>*/break;/*</bind>*/
            else
                continue;
        }/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 3862, 4485);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 3862, 4485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 3862, 4485);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_NestedLoops()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 4497, 5048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 4755, 5037);

                f_22013_4755_5036(this, @"
class C
{
    void F()
    {
        /*<bind>*/for (;;)
        {
            for (;;)
            {
            }
            /*<bind>*/break;/*</bind>*/
        }/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 4497, 5048);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 4497, 5048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 4497, 5048);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_NestedLoops2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 5060, 5616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 5319, 5605);

                f_22013_5319_5604(this, @"
class C
{
    void F()
    {
        for (;;)
        {
            /*<bind>*/for (;;)
            {
                /*<bind>*/break;/*</bind>*/
            }/*</bind>*/
        }
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 5060, 5616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 5060, 5616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 5060, 5616);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_SwitchLookup_BreakInCase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 5628, 6112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 5888, 6101);

                f_22013_5888_6100(this, @"
class C
{
    void F()
    {
        /*<bind>*/switch (1)
        {
            case 1:
            /*<bind>*/break;/*</bind>*/
        }/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 5628, 6112);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 5628, 6112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 5628, 6112);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_SwitchLookup_NestedSwitches()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 6124, 6734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 6387, 6723);

                f_22013_6387_6722(this, @"
class C
{
    void F()
    {
        /*<bind>*/switch (1)
        {
            case 1:
                switch (2)
                {
                    case 2:
                    break;
                }
            /*<bind>*/break;/*</bind>*/
        }/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 6124, 6734);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 6124, 6734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 6124, 6734);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_SwitchLookup_NestedSwitches2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 6746, 7357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 7010, 7346);

                f_22013_7010_7345(this, @"
class C
{
    void F()
    {
        switch (1)
        {
            case 1:
                /*<bind>*/switch (2)
                {
                    case 2:
                    /*<bind>*/break;/*</bind>*/
                }/*</bind>*/
            break;
        }
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 6746, 7357);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 6746, 7357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 6746, 7357);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_LoopInSwitch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 7369, 7984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 7628, 7973);

                f_22013_7628_7972(this, @"
class C
{
    void F()
    {
        switch (1)
        {
            case 1:
                /*<bind>*/for (;;)
                {
                    /*<bind>*/break;/*</bind>*/
                }/*</bind>*/
            break;
        }
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 7369, 7984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 7369, 7984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 7369, 7984);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_SwitchLookup_SwitchInLoop()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 7996, 8541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 8257, 8530);

                f_22013_8257_8529(this, @"
class C
{
    void F()
    {
        for (;;)
        {
            /*<bind>*/switch (1)
            {
                case 1:
                /*<bind>*/break;/*</bind>*/
            }/*</bind>*/
        }
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 7996, 8541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 7996, 8541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 7996, 8541);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_ContinueNestedInIntermediateSwitch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 8553, 9196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 8834, 9185);

                f_22013_8834_9184(this, @"
class C
{
    void F()
    {
        /*<bind>*/for (;;)
        {
            switch (1)
            {
                case 1:
                    /*<bind>*/continue;/*</bind>*/
                    break;
            }
        }/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 8553, 9196);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 8553, 9196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 8553, 9196);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_LoopLookup_BreakButNoLoop_ReturnsNull()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 9208, 9764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 9481, 9681);

                var (expected, actual) = f_22013_9506_9680(this, @"
class C
{
    void F()
    {
        /*<bind>*/break;/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 9697, 9719);

                f_22013_9697_9718(expected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 9733, 9753);

                f_22013_9733_9752(actual);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 9208, 9764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 9208, 9764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 9208, 9764);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(28095, "https://github.com/dotnet/roslyn/issues/28095")]
        [Fact]
        public void GetCorrespondingOperation_SwitchLookup_BreakButNoSwitch_ReturnsNull()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 9776, 10339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 10053, 10256);

                var (expected, actual) = f_22013_10078_10255(this, @"
class C
{
    void F()
    {
        /*<bind>*/break;/*</bind>*/
    }
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 10272, 10294);

                f_22013_10272_10293(expected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 10308, 10328);

                f_22013_10308_10327(actual);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 9776, 10339);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 9776, 10339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 9776, 10339);
            }
        }

        private void AssertOuterIsCorrespondingLoopOfInner<TOuterSyntax, TInnerSyntax>(string source)
                    where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 10351, 10740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 10559, 10668);

                var (expected, actual) = f_22013_10584_10667<TOuterSyntax, TInnerSyntax>(this, source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 10684, 10729);

                f_22013_10684_10728<TOuterSyntax, TInnerSyntax>(f_22013_10697_10712<TOuterSyntax, TInnerSyntax>(expected), f_22013_10714_10727<TOuterSyntax, TInnerSyntax>(actual));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 10351, 10740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 10351, 10740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 10351, 10740);
            }
        }

        private void AssertOuterIsCorrespondingSwitchOfInner(string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 10752, 11042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 10844, 10970);

                var (expected, actual) = f_22013_10869_10969(this, source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 10986, 11031);

                f_22013_10986_11030(f_22013_10999_11014(expected), f_22013_11016_11029(actual));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 10752, 11042);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 10752, 11042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 10752, 11042);
            }
        }

        private (IOperation outer, IOperation corresponding) GetOuterOperationAndCorrespondingInnerOperation<TOuterSyntax, TInnerSyntax>(string source)
                    where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22013, 11054, 11702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 11312, 11356);

                var
                compilation = f_22013_11330_11355<TOuterSyntax, TInnerSyntax>(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 11372, 11450);

                var
                outer = f_22013_11384_11439<TOuterSyntax, TInnerSyntax>(compilation).operation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 11464, 11562);

                var
                inner = f_22013_11476_11531<TOuterSyntax, TInnerSyntax>(compilation).operation as IBranchOperation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 11576, 11638);

                // LAFHIS
                var
                correspondingOfInner = f_22013_11609_11637<TOuterSyntax, TInnerSyntax>(inner)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22013, 11654, 11691);

                return (outer, correspondingOfInner);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22013, 11054, 11702);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22013, 11054, 11702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22013, 11054, 11702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.ArgumentNullException
        f_22013_829_927(System.Func<object>
        testCode)
        {
            var return_v = Assert.ThrowsAny<ArgumentNullException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 829, 927);
            return return_v;
        }


        (Microsoft.CodeAnalysis.IOperation outer, Microsoft.CodeAnalysis.IOperation corresponding)
        f_22013_1225_1480(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            var return_v = this_param.GetOuterOperationAndCorrespondingInnerOperation<Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 1225, 1480);
            return return_v;
        }


        Microsoft.CodeAnalysis.Operations.ILabeledOperation
        f_22013_1495_1551(Microsoft.CodeAnalysis.IOperation
        @object)
        {
            var return_v = Assert.IsAssignableFrom<ILabeledOperation>((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 1495, 1551);
            return return_v;
        }


        int
        f_22013_1566_1599(Microsoft.CodeAnalysis.IOperation
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 1566, 1599);
            return 0;
        }


        int
        f_22013_1886_2115(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 1886, 2115);
            return 0;
        }


        int
        f_22013_2407_2648(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 2407, 2648);
            return 0;
        }


        int
        f_22013_2950_3260(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 2950, 3260);
            return 0;
        }


        int
        f_22013_3551_3838(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 3551, 3838);
            return 0;
        }


        int
        f_22013_4140_4473(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 4140, 4473);
            return 0;
        }


        int
        f_22013_4755_5036(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 4755, 5036);
            return 0;
        }


        int
        f_22013_5319_5604(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 5319, 5604);
            return 0;
        }


        int
        f_22013_5888_6100(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingSwitchOfInner(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 5888, 6100);
            return 0;
        }


        int
        f_22013_6387_6722(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingSwitchOfInner(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 6387, 6722);
            return 0;
        }


        int
        f_22013_7010_7345(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingSwitchOfInner(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 7010, 7345);
            return 0;
        }


        int
        f_22013_7628_7972(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 7628, 7972);
            return 0;
        }


        int
        f_22013_8257_8529(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingSwitchOfInner(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 8257, 8529);
            return 0;
        }


        int
        f_22013_8834_9184(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            this_param.AssertOuterIsCorrespondingLoopOfInner<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 8834, 9184);
            return 0;
        }


        (Microsoft.CodeAnalysis.IOperation outer, Microsoft.CodeAnalysis.IOperation corresponding)
        f_22013_9506_9680(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            var return_v = this_param.GetOuterOperationAndCorrespondingInnerOperation<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 9506, 9680);
            return return_v;
        }


        int
        f_22013_9697_9718(Microsoft.CodeAnalysis.IOperation
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 9697, 9718);
            return 0;
        }


        int
        f_22013_9733_9752(Microsoft.CodeAnalysis.IOperation
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 9733, 9752);
            return 0;
        }


        (Microsoft.CodeAnalysis.IOperation outer, Microsoft.CodeAnalysis.IOperation corresponding)
        f_22013_10078_10255(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            var return_v = this_param.GetOuterOperationAndCorrespondingInnerOperation<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 10078, 10255);
            return return_v;
        }


        int
        f_22013_10272_10293(Microsoft.CodeAnalysis.IOperation
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 10272, 10293);
            return 0;
        }


        int
        f_22013_10308_10327(Microsoft.CodeAnalysis.IOperation
        @object)
        {
            Assert.Null((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 10308, 10327);
            return 0;
        }


        (Microsoft.CodeAnalysis.IOperation outer, Microsoft.CodeAnalysis.IOperation corresponding)
        f_22013_10584_10667<TOuterSyntax, TInnerSyntax>(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source) where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode

        {
            var return_v = this_param.GetOuterOperationAndCorrespondingInnerOperation<TOuterSyntax, TInnerSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 10584, 10667);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22013_10697_10712<TOuterSyntax, TInnerSyntax>(Microsoft.CodeAnalysis.IOperation
        this_param) where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode

        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22013, 10697, 10712);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22013_10714_10727<TOuterSyntax, TInnerSyntax>(Microsoft.CodeAnalysis.IOperation
        this_param) where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode

        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22013, 10714, 10727);
            return return_v;
        }


        int
        f_22013_10684_10728<TOuterSyntax, TInnerSyntax>(Microsoft.CodeAnalysis.SyntaxNode
        expected, Microsoft.CodeAnalysis.SyntaxNode
        actual) where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode

        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 10684, 10728);
            return 0;
        }


        (Microsoft.CodeAnalysis.IOperation outer, Microsoft.CodeAnalysis.IOperation corresponding)
        f_22013_10869_10969(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, string
        source)
        {
            var return_v = this_param.GetOuterOperationAndCorrespondingInnerOperation<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax>(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 10869, 10969);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22013_10999_11014(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22013, 10999, 11014);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22013_11016_11029(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22013, 11016, 11029);
            return return_v;
        }


        int
        f_22013_10986_11030(Microsoft.CodeAnalysis.SyntaxNode
        expected, Microsoft.CodeAnalysis.SyntaxNode
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 10986, 11030);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22013_11330_11355<TOuterSyntax, TInnerSyntax>(string
        source) where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode

        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 11330, 11355);
            return return_v;
        }


        (Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
        f_22013_11384_11439<TOuterSyntax, TInnerSyntax>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation) where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode

        {
            var return_v = GetOperationAndSyntaxForTest<TOuterSyntax>(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 11384, 11439);
            return return_v;
        }


        (Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
        f_22013_11476_11531<TOuterSyntax, TInnerSyntax>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation) where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode

        {
            var return_v = GetOperationAndSyntaxForTest<TInnerSyntax>(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 11476, 11531);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22013_11609_11637<TOuterSyntax, TInnerSyntax>(Microsoft.CodeAnalysis.Operations.IBranchOperation
        operation) where TOuterSyntax : SyntaxNode
                    where TInnerSyntax : SyntaxNode

        {
            var return_v = operation?.GetCorrespondingOperation();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22013, 11609, 11637);
            return return_v;
        }

    }
}
