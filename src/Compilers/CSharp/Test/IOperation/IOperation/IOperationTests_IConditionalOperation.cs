// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConditionalExpression_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22018,554,1558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,686,853);

string 
source = @"
class P
{
    private void M()
    {
        int i = 0;
        int j = 2;
        var z = (/*<bind>*/true ? i : j/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,867,1342);

string 
expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'true ? i : j')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  WhenFalse: 
    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,1356,1409);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,1425,1547);

f_22018_1425_1546(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22018,554,1558);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22018,554,1558);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22018,554,1558);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConditionalExpression_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22018,1570,2594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,1702,1873);

string 
source = @"
class P
{
    private void M()
    {
        int i = 0;
        int j = 2;
        (/*<bind>*/true ? ref i : ref j/*</bind>*/) = 4;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,1887,2378);

string 
expectedOperationTree = @"
IConditionalOperation (IsRef) (OperationKind.Conditional, Type: System.Int32) (Syntax: 'true ? ref i : ref j')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  WhenFalse: 
    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,2392,2445);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,2461,2583);

f_22018_2461_2582(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22018,1570,2594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22018,1570,2594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22018,1570,2594);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalExpressionFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22018,2606,6120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,2768,2946);

string 
source = @"
class P
{
    void M(bool a, bool b)
/*<bind>*/{
        GetArray()[0] =  a && b ? 1 : 2;
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,2960,5932);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] P.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B5]
    Block[B4] - Block
        Predecessors: [B1] [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ...  b ? 1 : 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ... & b ? 1 : 2')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a && b ? 1 : 2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,5946,5999);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,6015,6109);

f_22018_6015_6108(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22018,2606,6120);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22018,2606,6120);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22018,2606,6120);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalExpressionFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22018,6132,10648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,6294,6495);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c)
/*<bind>*/{
        GetArray()[0] =  a ? (b ? 1 : 2) : (c ? 3 : 4);
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,6509,10460);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] P.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Jump if False (Regular) to Block[B5]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B8]
    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B8]
    Block[B5] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B7]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B8]
    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '4')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B3] [B4] [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... c ? 3 : 4);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ... (c ? 3 : 4)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ? (b ? 1  ... (c ? 3 : 4)')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,10474,10527);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,10543,10637);

f_22018_10543_10636(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22018,6132,10648);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22018,6132,10648);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22018,6132,10648);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalExpressionFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22018,10660,15257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,10822,11034);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c, bool d, bool e)
/*<bind>*/{
        GetArray()[0] =  a ? (b && c) : (d || e);
    }/*</bind>*/

    static bool[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,11048,15069);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Boolean) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Boolean[] P.GetArray()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Jump if False (Regular) to Block[B5]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B8]
    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'b')

        Next (Regular) Block[B8]
    Block[B5] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B7]
            IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'e')

        Next (Regular) Block[B8]
    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'd')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B3] [B4] [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... : (d || e);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'GetArray()[ ...  : (d || e)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a ? (b && c) : (d || e)')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,15083,15136);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22018,15152,15246);

f_22018_15152_15245(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22018,10660,15257);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22018,10660,15257);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22018,10660,15257);
}
		}

int
f_22018_1425_1546(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ConditionalExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22018, 1425, 1546);
return 0;
}


int
f_22018_2461_2582(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ConditionalExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22018, 2461, 2582);
return 0;
}


int
f_22018_6015_6108(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22018, 6015, 6108);
return 0;
}


int
f_22018_10543_10636(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22018, 10543, 10636);
return 0;
}


int
f_22018_15152_15245(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22018, 15152, 15245);
return 0;
}

}
}
