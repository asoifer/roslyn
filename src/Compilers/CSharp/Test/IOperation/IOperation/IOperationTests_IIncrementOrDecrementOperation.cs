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
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IncrementOrDecrementFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22039,556,1977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22039,717,835);

string 
source = @"
class C
{
    void M(int i, int j)
    /*<bind>*/{
        j = --i;
    }/*</bind>*/
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22039,849,902);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22039,918,1854);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = --i;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = --i')
              Left: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')
              Right: 
                IIncrementOrDecrementOperation (Prefix) (OperationKind.Decrement, Type: System.Int32) (Syntax: '--i')
                  Target: 
                    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22039,1868,1966);

f_22039_1868_1965(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22039,556,1977);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22039,556,1977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22039,556,1977);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IncrementOrDecrementFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22039,1989,5065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22039,2150,2307);

string 
source = @"
class C
{
    void M(D x, D y)
    /*<bind>*/{
        (x ?? y).i++;
    }/*</bind>*/
    public class D { public int i; }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22039,2321,2374);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22039,2390,4942);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                  Value: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: C.D) (Syntax: 'x')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.D, IsImplicit) (Syntax: 'x')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.D, IsImplicit) (Syntax: 'x')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
              Value: 
                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: C.D) (Syntax: 'y')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(x ?? y).i++;')
              Expression: 
                IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: '(x ?? y).i++')
                  Target: 
                    IFieldReferenceOperation: System.Int32 C.D.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: '(x ?? y).i')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C.D, IsImplicit) (Syntax: 'x ?? y')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22039,4956,5054);

f_22039_4956_5053(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22039,1989,5065);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22039,1989,5065);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22039,1989,5065);
}
		}

int
f_22039_1868_1965(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22039, 1868, 1965);
return 0;
}


int
f_22039_4956_5053(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22039, 4956, 5053);
return 0;
}

}
}
