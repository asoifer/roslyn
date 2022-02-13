// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,576,1988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,722,869);

var 
source = @"
#pragma warning disable CS0219

class C
{
    void F()
    /*<bind>*/{
        int i;
        i = 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,885,929);

var 
compilation = f_22010_903_928(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,945,977);

f_22010_945_976(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,993,1899);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,1913,1977);

f_22010_1913_1976(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,576,1988);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,576,1988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,576,1988);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,2000,2650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,2146,2277);

var 
source = @"
#pragma warning disable CS0168

class C
{
    void F()
    /*<bind>*/{
        int i;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,2293,2337);

var 
compilation = f_22010_2311_2336(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,2353,2385);

f_22010_2353_2384(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,2401,2561);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Exit
    Predecessors: [B0]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,2575,2639);

f_22010_2575_2638(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,2000,2650);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,2000,2650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,2000,2650);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,2662,4926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,2808,3017);

var 
source = @"
#pragma warning disable CS0219

class C
{
    void F()
    /*<bind>*/{
        int i;
        i = 1;
        {
            int j;
            j = 1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,3033,3077);

var 
compilation = f_22010_3051_3076(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,3093,3125);

f_22010_3093_3124(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,3141,4837);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 j]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B3]
                Leaving: {R2} {R1}
    }
}

Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,4851,4915);

f_22010_4851_4914(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,2662,4926);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,2662,4926);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,2662,4926);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,4938,6965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,5084,5297);

var 
source = @"
#pragma warning disable CS0219

class C
{
    void F()
    /*<bind>*/{
        int i;
        {
            int j;
            i = 1;
            j = 1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,5313,5357);

var 
compilation = f_22010_5331_5356(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,5373,5405);

f_22010_5373_5404(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,5421,6876);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i] [System.Int32 j]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,6890,6954);

f_22010_6890_6953(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,4938,6965);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,4938,6965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,4938,6965);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,6977,7669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,7123,7296);

var 
source = @"
#pragma warning disable CS0168

class C
{
    void F()
    /*<bind>*/{
        int i;
        {
            int j;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,7312,7356);

var 
compilation = f_22010_7330_7355(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,7372,7404);

f_22010_7372_7403(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,7420,7580);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Exit
    Predecessors: [B0]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,7594,7658);

f_22010_7594_7657(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,6977,7669);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,6977,7669);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,6977,7669);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,7681,9931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,7827,8066);

var 
source = @"
#pragma warning disable CS0219

class C
{
    void F()
    /*<bind>*/{
        {
            int i;
            i = 1;
        }
        {
            int j;
            j = 1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,8082,8126);

var 
compilation = f_22010_8100_8125(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,8142,8174);

f_22010_8142_8173(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,8190,9842);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
            Entering: {R2}
}
.locals {R2}
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2}
}

Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,9856,9920);

f_22010_9856_9919(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,7681,9931);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,7681,9931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,7681,9931);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,9943,10661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,10089,10288);

var 
source = @"
#pragma warning disable CS0168

class C
{
    void F()
    /*<bind>*/{
        {
            int i;
        }
        {
            int j;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,10304,10348);

var 
compilation = f_22010_10322_10347(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,10364,10396);

f_22010_10364_10395(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,10412,10572);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Exit
    Predecessors: [B0]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,10586,10650);

f_22010_10586_10649(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,9943,10661);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,9943,10661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,9943,10661);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,10673,11647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,10819,11274);

var 
source = @"
#pragma warning disable CS0168

class C
{
    void F()
    /*<bind>*/{
        int i;
        {
            int j;
            {
                int k;
                {
                    int l;
                }
                {
                    int m;
                }
            }
            {
                int n;
            }
        }
        {
            int o;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,11290,11334);

var 
compilation = f_22010_11308_11333(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,11350,11382);

f_22010_11350_11381(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,11398,11558);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Exit
    Predecessors: [B0]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,11572,11636);

f_22010_11572_11635(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,10673,11647);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,10673,11647);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,10673,11647);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,11659,15038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,11805,12272);

var 
source = @"
#pragma warning disable CS0219

class C
{
    void F()
    /*<bind>*/{
        int i;
        {
            int j;
            {
                int k;
                {
                    int l;
                    {
                        i = 1;
                        j = 1;
                        k = 1;
                        l = 1;
                    }
                }
            }
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,12288,12332);

var 
compilation = f_22010_12306_12331(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,12348,12380);

f_22010_12348_12379(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,12396,14949);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i] [System.Int32 j] [System.Int32 k] [System.Int32 l]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'k = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'k = 1')
                  Left: 
                    ILocalReferenceOperation: k (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'l = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'l = 1')
                  Left: 
                    ILocalReferenceOperation: l (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'l')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,14963,15027);

f_22010_14963_15026(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,11659,15038);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,11659,15038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,11659,15038);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,15050,17895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,15196,15427);

var 
source = @"
#pragma warning disable CS0219

class C
{
    void F()
    /*<bind>*/{
        int i;
        {
            int j;
            i = 1;
            j = 1;
        }

        i = 2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,15443,15487);

var 
compilation = f_22010_15461_15486(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,15503,15535);

f_22010_15503_15534(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,15551,17806);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32 i]
    .locals {R2}
    {
        Locals: [System.Int32 j]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (2)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                      Left: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }

    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 2')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,17820,17884);

f_22010_17820_17883(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,15050,17895);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,15050,17895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,15050,17895);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,17907,19881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,18053,18222);

var 
source = @"
#pragma warning disable CS0219

class C
{
    void F(int j)
    /*<bind>*/{
        j = 2; 
        int i;
        i = 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,18238,18282);

var 
compilation = f_22010_18256_18281(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,18298,18330);

f_22010_18298_18329(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,18346,19792);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
                  Left: 
                    IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,19806,19870);

f_22010_19806_19869(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,17907,19881);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,17907,19881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,17907,19881);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,19893,24021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,20039,20406);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        int a;
        {
            a = 1;
            {
                int j = 2;
            }
            int k = 3;
            {
                int l = 4;
            }
            int m = 5;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,20422,20466);

var 
compilation = f_22010_20440_20465(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,20482,20514);

f_22010_20482_20513(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,20530,23932);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 k] [System.Int32 m]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 1')
                  Left: 
                    ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 j]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'j = 2')
                  Left: 
                    ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'j = 2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'k = 3')
              Left: 
                ILocalReferenceOperation: k (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'k = 3')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
            Entering: {R3}

    .locals {R3}
    {
        Locals: [System.Int32 l]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'l = 4')
                  Left: 
                    ILocalReferenceOperation: l (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'l = 4')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

            Next (Regular) Block[B5]
                Leaving: {R3}
    }

    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'm = 5')
              Left: 
                ILocalReferenceOperation: m (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'm = 5')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,23946,24010);

f_22010_23946_24009(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,19893,24021);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,19893,24021);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,19893,24021);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BlockFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22010,24033,28294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,24179,24580);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        int a;
        {
            {
                int i = 1;
            }
            a = 2;
            {
                int k = 3;
            }
            int l = 4;
            {
                int m = 5;
            }
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,24596,24640);

var 
compilation = f_22010_24614_24639(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,24656,24688);

f_22010_24656_24687(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,24704,28205);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 l]
    .locals {R2}
    {
        Locals: [System.Int32 i]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }

    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 2')
                  Left: 
                    ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Entering: {R3}

    .locals {R3}
    {
        Locals: [System.Int32 k]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'k = 3')
                  Left: 
                    ILocalReferenceOperation: k (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'k = 3')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B4]
                Leaving: {R3}
    }

    Block[B4] - Block
        Predecessors: [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'l = 4')
              Left: 
                ILocalReferenceOperation: l (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'l = 4')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B5]
            Entering: {R4}

    .locals {R4}
    {
        Locals: [System.Int32 m]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'm = 5')
                  Left: 
                    ILocalReferenceOperation: m (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'm = 5')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

            Next (Regular) Block[B6]
                Leaving: {R4} {R1}
    }
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22010,28219,28283);

f_22010_28219_28282(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22010,24033,28294);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22010,24033,28294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22010,24033,28294);
}
		}

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_903_928(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 903, 928);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_945_976(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 945, 976);
return return_v;
}


int
f_22010_1913_1976(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 1913, 1976);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_2311_2336(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 2311, 2336);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_2353_2384(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 2353, 2384);
return return_v;
}


int
f_22010_2575_2638(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 2575, 2638);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_3051_3076(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 3051, 3076);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_3093_3124(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 3093, 3124);
return return_v;
}


int
f_22010_4851_4914(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 4851, 4914);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_5331_5356(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 5331, 5356);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_5373_5404(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 5373, 5404);
return return_v;
}


int
f_22010_6890_6953(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 6890, 6953);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_7330_7355(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 7330, 7355);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_7372_7403(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 7372, 7403);
return return_v;
}


int
f_22010_7594_7657(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 7594, 7657);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_8100_8125(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 8100, 8125);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_8142_8173(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 8142, 8173);
return return_v;
}


int
f_22010_9856_9919(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 9856, 9919);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_10322_10347(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 10322, 10347);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_10364_10395(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 10364, 10395);
return return_v;
}


int
f_22010_10586_10649(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 10586, 10649);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_11308_11333(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 11308, 11333);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_11350_11381(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 11350, 11381);
return return_v;
}


int
f_22010_11572_11635(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 11572, 11635);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_12306_12331(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 12306, 12331);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_12348_12379(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 12348, 12379);
return return_v;
}


int
f_22010_14963_15026(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 14963, 15026);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_15461_15486(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 15461, 15486);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_15503_15534(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 15503, 15534);
return return_v;
}


int
f_22010_17820_17883(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 17820, 17883);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_18256_18281(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 18256, 18281);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_18298_18329(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 18298, 18329);
return return_v;
}


int
f_22010_19806_19869(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 19806, 19869);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_20440_20465(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 20440, 20465);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_20482_20513(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 20482, 20513);
return return_v;
}


int
f_22010_23946_24009(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 23946, 24009);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_24614_24639(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 24614, 24639);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22010_24656_24687(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 24656, 24687);
return return_v;
}


int
f_22010_28219_28282(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22010, 28219, 28282);
return 0;
}

}
}
