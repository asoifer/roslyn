// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DeconstructionFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,524,5549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,679,866);

string 
source = @"
class C
{
    void M(bool b, int i1, int i2, int i3, int i4, int i5, int i6)
    /*<bind>*/{
        (i1, i2) = b ? (i3, i4) : (i5, i6);
    }/*</bind>*/
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,880,933);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,949,5426);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(i3, i4)')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: '(i3, i4)')
                  Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Identity)
                  Operand: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i3, System.Int32 i4)) (Syntax: '(i3, i4)')
                      NaturalType: (System.Int32 i3, System.Int32 i4)
                      Elements(2):
                          IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')
                          IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i4')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(i5, i6)')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: '(i5, i6)')
                  Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Identity)
                  Operand: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i5, System.Int32 i6)) (Syntax: '(i5, i6)')
                      NaturalType: (System.Int32 i5, System.Int32 i6)
                      Elements(2):
                          IParameterReferenceOperation: i5 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i5')
                          IParameterReferenceOperation: i6 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i6')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(i1, i2) =  ... : (i5, i6);')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2) =  ...  : (i5, i6)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
                      NaturalType: (System.Int32 i1, System.Int32 i2)
                      Elements(2):
                          IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'b ? (i3, i4) : (i5, i6)')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,5440,5538);

f_22022_5440_5537(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,524,5549);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,524,5549);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,524,5549);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DeconstructionFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,5561,9463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,5716,5859);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        (var i1, var i2) = b ? (1, 2) : (3, 4);
    }/*</bind>*/
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,5873,5926);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,5942,9340);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i1] [System.Int32 i2]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(1, 2)')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(3, 4)')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(3, 4)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(var i1, va ... ) : (3, 4);')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(var i1, va ... 2) : (3, 4)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(var i1, var i2)')
                      NaturalType: (System.Int32 i1, System.Int32 i2)
                      Elements(2):
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i1')
                            ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i2')
                            ILocalReferenceOperation: i2 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'b ? (1, 2) : (3, 4)')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,9354,9452);

f_22022_9354_9451(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,5561,9463);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,5561,9463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,5561,9463);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DeconstructionFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,9475,13257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,9630,9769);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        var (i1, i2) = b ? (1, 2) : (3, 4);
    }/*</bind>*/
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,9783,9836);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,9852,13134);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i1] [System.Int32 i2]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(1, 2)')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(3, 4)')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(3, 4)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'var (i1, i2 ... ) : (3, 4);')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: 'var (i1, i2 ... 2) : (3, 4)')
                  Left: 
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: 'var (i1, i2)')
                      ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
                        NaturalType: (System.Int32 i1, System.Int32 i2)
                        Elements(2):
                            ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
                            ILocalReferenceOperation: i2 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'b ? (1, 2) : (3, 4)')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,13148,13246);

f_22022_13148_13245(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,9475,13257);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,9475,13257);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,9475,13257);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DeconstructionFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,13269,16515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,13424,13666);

string 
source = @"
class C
{
    void M(bool b, C c1)
    /*<bind>*/{
        var (i1, i2) = b ? this : c1;
    }/*</bind>*/

    public void Deconstruct(out int i1, out int i2)
    {
        i1 = 1;
        i2 = 2;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,13680,13733);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,13749,16392);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i1] [System.Int32 i2]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'this')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'var (i1, i2 ...  this : c1;')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: 'var (i1, i2 ... ? this : c1')
                  Left: 
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: 'var (i1, i2)')
                      ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
                        NaturalType: (System.Int32 i1, System.Int32 i2)
                        Elements(2):
                            ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
                            ILocalReferenceOperation: i2 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'b ? this : c1')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,16406,16504);

f_22022_16406_16503(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,13269,16515);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,13269,16515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,13269,16515);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void MixedDeconstruction()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,16527,23489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,16680,16832);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        int i2;
        (int i1, i2) = b ? (1, 2) : (3, 4);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,16846,16899);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,16915,19657);

string 
expectedOperationTree = @"
IBlockOperation (2 statements, 2 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: System.Int32 i2
    Local_2: System.Int32 i1
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i2;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i2')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2')
            Initializer: 
              null
      Initializer: 
        null
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(int i1, i2 ... ) : (3, 4);')
    Expression: 
      IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(int i1, i2 ... 2) : (3, 4)')
        Left: 
          ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(int i1, i2)')
            NaturalType: (System.Int32 i1, System.Int32 i2)
            Elements(2):
                IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i1')
                  ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
                ILocalReferenceOperation: i2 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
        Right: 
          IConditionalOperation (OperationKind.Conditional, Type: (System.Int32, System.Int32)) (Syntax: 'b ? (1, 2) : (3, 4)')
            Condition: 
              IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
            WhenTrue: 
              ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                NaturalType: (System.Int32, System.Int32)
                Elements(2):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            WhenFalse: 
              ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(3, 4)')
                NaturalType: (System.Int32, System.Int32)
                Elements(2):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,19671,19819);

f_22022_19671_19818(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.RegularPreview);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,19835,23324);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32 i2] [System.Int32 i1]
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                ILocalReferenceOperation: i2 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(1, 2)')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(3, 4)')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(3, 4)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(int i1, i2 ... ) : (3, 4);')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(int i1, i2 ... 2) : (3, 4)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(int i1, i2)')
                      NaturalType: (System.Int32 i1, System.Int32 i2)
                      Elements(2):
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i1')
                            ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
                          IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'b ? (1, 2) : (3, 4)')
        Next (Regular) Block[B5]
            Leaving: {R1}
}
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,23338,23478);

f_22022_23338_23477(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularPreview);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,16527,23489);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,16527,23489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,16527,23489);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void MixedNestedDeconstruction()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,23501,33291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,23660,23832);

string 
source = @"
class C
{
    void M(bool b)
    /*<bind>*/{
        int i2;
        (int i1, (i2, int i3)) = b ? (1, (2, 3)) : (4, (5, 6));
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,23846,23899);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,23915,28027);

string 
expectedOperationTree = @"
IBlockOperation (2 statements, 3 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: System.Int32 i2
    Local_2: System.Int32 i1
    Local_3: System.Int32 i3
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i2;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i2')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2')
            Initializer: 
              null
      Initializer: 
        null
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(int i1, (i ... 4, (5, 6));')
    Expression: 
      IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))) (Syntax: '(int i1, (i ... (4, (5, 6))')
        Left: 
          ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))) (Syntax: '(int i1, (i2, int i3))')
            NaturalType: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))
            Elements(2):
                IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i1')
                  ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i2, System.Int32 i3)) (Syntax: '(i2, int i3)')
                  NaturalType: (System.Int32 i2, System.Int32 i3)
                  Elements(2):
                      ILocalReferenceOperation: i2 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
                      IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i3')
                        ILocalReferenceOperation: i3 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i3')
        Right: 
          IConditionalOperation (OperationKind.Conditional, Type: (System.Int32, (System.Int32, System.Int32))) (Syntax: 'b ? (1, (2, ... (4, (5, 6))')
            Condition: 
              IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
            WhenTrue: 
              ITupleOperation (OperationKind.Tuple, Type: (System.Int32, (System.Int32, System.Int32))) (Syntax: '(1, (2, 3))')
                NaturalType: (System.Int32, (System.Int32, System.Int32))
                Elements(2):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(2, 3)')
                      NaturalType: (System.Int32, System.Int32)
                      Elements(2):
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            WhenFalse: 
              ITupleOperation (OperationKind.Tuple, Type: (System.Int32, (System.Int32, System.Int32))) (Syntax: '(4, (5, 6))')
                NaturalType: (System.Int32, (System.Int32, System.Int32))
                Elements(2):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(5, 6)')
                      NaturalType: (System.Int32, System.Int32)
                      Elements(2):
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,28041,28189);

f_22022_28041_28188(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.RegularPreview);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,28205,33126);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32 i2] [System.Int32 i1] [System.Int32 i3]
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                ILocalReferenceOperation: i2 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(1, (2, 3))')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, (System.Int32, System.Int32))) (Syntax: '(1, (2, 3))')
                  NaturalType: (System.Int32, (System.Int32, System.Int32))
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(2, 3)')
                        NaturalType: (System.Int32, System.Int32)
                        Elements(2):
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(4, (5, 6))')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, (System.Int32, System.Int32))) (Syntax: '(4, (5, 6))')
                  NaturalType: (System.Int32, (System.Int32, System.Int32))
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
                      ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(5, 6)')
                        NaturalType: (System.Int32, System.Int32)
                        Elements(2):
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')
        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(int i1, (i ... 4, (5, 6));')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))) (Syntax: '(int i1, (i ... (4, (5, 6))')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))) (Syntax: '(int i1, (i2, int i3))')
                      NaturalType: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))
                      Elements(2):
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i1')
                            ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
                          ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i2, System.Int32 i3)) (Syntax: '(i2, int i3)')
                            NaturalType: (System.Int32 i2, System.Int32 i3)
                            Elements(2):
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                                IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i3')
                                  ILocalReferenceOperation: i3 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i3')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: (System.Int32, (System.Int32, System.Int32)), IsImplicit) (Syntax: 'b ? (1, (2, ... (4, (5, 6))')
        Next (Regular) Block[B5]
            Leaving: {R1}
}
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,33140,33280);

f_22022_33140_33279(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularPreview);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,23501,33291);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,23501,33291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,23501,33291);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DeconstructionFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,33303,40614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,33458,33630);

string 
source = @"
class C
{
    int fI1 = 0;
    void M(bool b, C c1, int i1)
    /*<bind>*/{
        (c1?.fI1, i1) = b ? (1, 2) : (3, 4);
    }/*</bind>*/
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,33644,33978);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22022_33886_33961(f_22022_33886_33941(ErrorCode.ERR_AssgLvalueExpected, "c1?.fI1"), 7, 10),
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,33994,40491);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3}

.locals {R1}
{
    CaptureIds: [2] [3] [4]
    .locals {R2}
    {
        CaptureIds: [1]
        .locals {R3}
        {
            CaptureIds: [0]
            Block[B1] - Block
                Predecessors: [B0]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c1')
                      Value: 
                        IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c1')

                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'c1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'c1')
                    Leaving: {R3}

                Next (Regular) Block[B2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '.fI1')
                      Value: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: '.fI1')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNullable)
                          Operand: 
                            IFieldReferenceOperation: System.Int32 C.fI1 (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: '.fI1')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'c1')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c1?.fI1')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'c1?.fI1')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'c1?.fI1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

        Jump if False (Regular) to Block[B7]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(1, 2)')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B8]
    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(3, 4)')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(3, 4)')
                  NaturalType: (System.Int32, System.Int32)
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(c1?.fI1, i ... ) : (3, 4);')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32? fI1, System.Int32 i1), IsInvalid) (Syntax: '(c1?.fI1, i ... 2) : (3, 4)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32? fI1, System.Int32 i1), IsInvalid) (Syntax: '(c1?.fI1, i1)')
                      NaturalType: (System.Int32? fI1, System.Int32 i1)
                      Elements(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'c1?.fI1')
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                  Right: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'b ? (1, 2) : (3, 4)')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,40505,40603);

f_22022_40505_40602(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,33303,40614);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,33303,40614);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,33303,40614);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DeconstructionFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,40626,46256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,40781,40956);

string 
source = @"
class C
{
    void M(bool b, int i1, int i2, int i3)
    /*<bind>*/{
        (i1, (i2, i3)) = b ? (1, (2, 3)) : (4, (5, 6));
    }/*</bind>*/
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,40970,41023);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,41039,46133);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
              Value: 
                IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(1, (2, 3))')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, (System.Int32, System.Int32))) (Syntax: '(1, (2, 3))')
                  NaturalType: (System.Int32, (System.Int32, System.Int32))
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                      ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(2, 3)')
                        NaturalType: (System.Int32, System.Int32)
                        Elements(2):
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(4, (5, 6))')
              Value: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32, (System.Int32, System.Int32))) (Syntax: '(4, (5, 6))')
                  NaturalType: (System.Int32, (System.Int32, System.Int32))
                  Elements(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
                      ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(5, 6)')
                        NaturalType: (System.Int32, System.Int32)
                        Elements(2):
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(i1, (i2, i ... 4, (5, 6));')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))) (Syntax: '(i1, (i2, i ... (4, (5, 6))')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))) (Syntax: '(i1, (i2, i3))')
                      NaturalType: (System.Int32 i1, (System.Int32 i2, System.Int32 i3))
                      Elements(2):
                          IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                          ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i2, System.Int32 i3)) (Syntax: '(i2, i3)')
                            NaturalType: (System.Int32 i2, System.Int32 i3)
                            Elements(2):
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                  Right: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: (System.Int32, (System.Int32, System.Int32)), IsImplicit) (Syntax: 'b ? (1, (2, ... (4, (5, 6))')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,46147,46245);

f_22022_46147_46244(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,40626,46256);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,40626,46256);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,40626,46256);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DeconstructionFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22022,46268,53266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,46423,46618);

string 
source = @"
class C
{
    void M(int i1, int i2, int i3, int i4, int i5, int? i6, int i7)
    /*<bind>*/
    {
        ((i1, i2), i3) = ((i4, i5), i6 ?? i7);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,46632,46685);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,46701,53143);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3] [4] [6]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (5)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
              Value: 
                IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i4')
              Value: 
                IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i4')

            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i5')
              Value: 
                IParameterReferenceOperation: i5 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i5')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [5]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i6')
                  Value: 
                    IParameterReferenceOperation: i6 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i6')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i6')
                  Operand: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i6')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i6')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i6')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i6')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i7')
              Value: 
                IParameterReferenceOperation: i7 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i7')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '((i1, i2),  ...  i6 ?? i7);')
              Expression: 
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: ((System.Int32 i1, System.Int32 i2), System.Int32 i3)) (Syntax: '((i1, i2),  ... , i6 ?? i7)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: ((System.Int32 i1, System.Int32 i2), System.Int32 i3)) (Syntax: '((i1, i2), i3)')
                      NaturalType: ((System.Int32 i1, System.Int32 i2), System.Int32 i3)
                      Elements(2):
                          ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
                            NaturalType: (System.Int32 i1, System.Int32 i2)
                            Elements(2):
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: ((System.Int32, System.Int32), System.Int32), IsImplicit) (Syntax: '((i4, i5), i6 ?? i7)')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        ITupleOperation (OperationKind.Tuple, Type: ((System.Int32 i4, System.Int32 i5), System.Int32)) (Syntax: '((i4, i5), i6 ?? i7)')
                          NaturalType: ((System.Int32 i4, System.Int32 i5), System.Int32)
                          Elements(2):
                              ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i4, System.Int32 i5)) (Syntax: '(i4, i5)')
                                NaturalType: (System.Int32 i4, System.Int32 i5)
                                Elements(2):
                                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i4')
                                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i5')
                              IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i6 ?? i7')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22022,53157,53255);

f_22022_53157_53254(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22022,46268,53266);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22022,46268,53266);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22022,46268,53266);
}
		}

int
f_22022_5440_5537(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 5440, 5537);
return 0;
}


int
f_22022_9354_9451(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 9354, 9451);
return 0;
}


int
f_22022_13148_13245(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 13148, 13245);
return 0;
}


int
f_22022_16406_16503(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 16406, 16503);
return 0;
}


int
f_22022_19671_19818(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 19671, 19818);
return 0;
}


int
f_22022_23338_23477(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 23338, 23477);
return 0;
}


int
f_22022_28041_28188(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 28041, 28188);
return 0;
}


int
f_22022_33140_33279(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 33140, 33279);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22022_33886_33941(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 33886, 33941);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22022_33886_33961(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 33886, 33961);
return return_v;
}


int
f_22022_40505_40602(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 40505, 40602);
return 0;
}


int
f_22022_46147_46244(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 46147, 46244);
return 0;
}


int
f_22022_53157_53254(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22022, 53157, 53254);
return 0;
}

}
}
