// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
[CompilerTrait(CompilerFeature.IOperation)]
    public partial class IOperationTests : SemanticModelTestBase
{
[Fact]
        public void VerifyTupleEqualityBinaryOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,582,1349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,670,801);

var 
source = @"
class C
{
    bool F((int, int) x, (int, int) y)
    {
        return /*<bind>*/x == y/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,817,1240);

string 
expectedOperationTree =
@"
ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: 'x == y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,1256,1338);

f_22069_1256_1337(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,582,1349);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,582,1349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,582,1349);
}
		}

[Fact]
        public void VerifyTupleEqualityBinaryOperator_WithTupleLiteral()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,1361,2386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,1466,1588);

var 
source = @"
class C
{
    bool F((int, int) x)
    {
        return /*<bind>*/x == (1, 2)/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,1604,2277);

string 
expectedOperationTree =
@"
ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: 'x == (1, 2)')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'x')
  Right: 
    ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32)) (Syntax: '(1, 2)')
      NaturalType: (System.Int32, System.Int32)
      Elements(2):
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,2293,2375);

f_22069_2293_2374(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,1361,2386);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,1361,2386);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,1361,2386);
}
		}

[Fact]
        public void VerifyTupleEqualityBinaryOperator_WithNotEquals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,2398,4068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,2500,2624);

var 
source = @"
class C
{
    bool F((long, byte) y)
    {
        return /*<bind>*/(1, 2) != y/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,2640,3959);

string 
expectedOperationTree =
@"
ITupleBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: '(1, 2) != y')
  Left: 
    ITupleOperation (OperationKind.Tuple, Type: (System.Int64, System.Int32)) (Syntax: '(1, 2)')
      NaturalType: (System.Int32, System.Int32)
      Elements(2):
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 1, IsImplicit) (Syntax: '1')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
  Right: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int64, System.Int32), IsImplicit) (Syntax: 'y')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: (System.Int64, System.Byte)) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,3975,4057);

f_22069_3975_4056(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,2398,4068);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,2398,4068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,2398,4068);
}
		}

[Fact]
        public void VerifyTupleEqualityBinaryOperator_WithNullsAndConversions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,4080,6594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,4192,4325);

var 
source = @"
class C
{
    bool F()
    {
        return /*<bind>*/(null, (1, 2L)) == (null, (3L, 4))/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,4341,6485);

string 
expectedOperationTree =
@"
ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: '(null, (1,  ... l, (3L, 4))')
  Left: 
    ITupleOperation (OperationKind.Tuple, Type: null) (Syntax: '(null, (1, 2L))')
      NaturalType: null
      Elements(2):
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
          ITupleOperation (OperationKind.Tuple, Type: (System.Int64, System.Int64)) (Syntax: '(1, 2L)')
            NaturalType: (System.Int32, System.Int64)
            Elements(2):
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 1, IsImplicit) (Syntax: '1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                ILiteralOperation (OperationKind.Literal, Type: System.Int64, Constant: 2) (Syntax: '2L')
  Right: 
    ITupleOperation (OperationKind.Tuple, Type: null) (Syntax: '(null, (3L, 4))')
      NaturalType: null
      Elements(2):
          ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
          ITupleOperation (OperationKind.Tuple, Type: (System.Int64, System.Int64)) (Syntax: '(3L, 4)')
            NaturalType: (System.Int64, System.Int32)
            Elements(2):
                ILiteralOperation (OperationKind.Literal, Type: System.Int64, Constant: 3) (Syntax: '3L')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 4, IsImplicit) (Syntax: '4')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,6501,6583);

f_22069_6501_6582(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,4080,6594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,4080,6594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,4080,6594);
}
		}

[Fact]
        public void VerifyTupleEqualityBinaryOperator_WithDefault()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,6606,7701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,6706,6832);

var 
source = @"
class C
{
    bool F((int, string) y)
    {
        return /*<bind>*/y == default/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,6848,7592);

string 
expectedOperationTree =
@"
ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: 'y == default')
  Left: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: (System.Int32, System.String)) (Syntax: 'y')
  Right: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int32, System.String), IsImplicit) (Syntax: 'default')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IDefaultValueOperation (OperationKind.DefaultValue, Type: (System.Int32, System.String)) (Syntax: 'default')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,7608,7690);

f_22069_7608_7689(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,6606,7701);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,6606,7701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,6606,7701);
}
		}

[Fact]
        public void VerifyTupleEqualityBinaryOperator_VerifyChildren()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,7713,9104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,7816,7951);

string 
source = @"
class C
{
    void M1((int, int) t1, long l)
    {
        _ = /*<bind>*/t1 == (l, l)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,7965,8997);

string 
expectedOperationTree =
@"
ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: 't1 == (l, l)')
    Left: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.Int64, System.Int64), IsImplicit) (Syntax: 't1')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
        IParameterReferenceOperation: t1 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 't1')
    Right: 
    ITupleOperation (OperationKind.Tuple, Type: (System.Int64, System.Int64)) (Syntax: '(l, l)')
        NaturalType: (System.Int64, System.Int64)
        Elements(2):
            IParameterReferenceOperation: l (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'l')
            IParameterReferenceOperation: l (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'l')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,9011,9093);

f_22069_9011_9092(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,7713,9104);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,7713,9104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,7713,9104);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        public void TupleBinaryOperator_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,9116,10767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,9273,9415);

var 
source = @"
class C
{
    void F((int, int) x, (int, int) y, bool b)
    /*<bind>*/
    {
        b = x == y;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,9431,10573);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = x == y;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = x == y')
              Left: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
              Right: 
                ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: 'x == y')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'x')
                  Right: 
                    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'y')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,10589,10642);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,10658,10756);

f_22069_10658_10755(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,9116,10767);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,9116,10767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,9116,10767);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        public void TupleBinaryOperator_ControlFlowInLeftOperand()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,10779,15044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,10947,11115);

var 
source = @"
class C
{
    void F((int, int)? x1, (int, int) x2, (int, int) y, bool b)
    /*<bind>*/
    {
        b = (x1 ?? x2) == y;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,11131,14850);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x1')
                  Value: 
                    IParameterReferenceOperation: x1 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)?) (Syntax: 'x1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32)?, IsImplicit) (Syntax: 'x1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x1')
                  Value: 
                    IInvocationOperation ( (System.Int32, System.Int32) (System.Int32, System.Int32)?.GetValueOrDefault()) (OperationKind.Invocation, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'x1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32)?, IsImplicit) (Syntax: 'x1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x2')
              Value: 
                IParameterReferenceOperation: x2 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'x2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (x1 ?? x2) == y;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (x1 ?? x2) == y')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: '(x1 ?? x2) == y')
                      Left: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'x1 ?? x2')
                      Right: 
                        IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'y')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,14866,14919);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,14935,15033);

f_22069_14935_15032(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,10779,15044);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,10779,15044);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,10779,15044);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        public void TupleBinaryOperator_ControlFlowInRightOperand()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,15056,19605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,15225,15393);

var 
source = @"
class C
{
    void F((int, int)? x1, (int, int) x2, (int, int) y, bool b)
    /*<bind>*/
    {
        b = y == (x1 ?? x2);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,15409,19411);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
              Value: 
                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'y')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x1')
                  Value: 
                    IParameterReferenceOperation: x1 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)?) (Syntax: 'x1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32)?, IsImplicit) (Syntax: 'x1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x1')
                  Value: 
                    IInvocationOperation ( (System.Int32, System.Int32) (System.Int32, System.Int32)?.GetValueOrDefault()) (OperationKind.Invocation, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'x1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32)?, IsImplicit) (Syntax: 'x1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x2')
              Value: 
                IParameterReferenceOperation: x2 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'x2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = y == (x1 ?? x2);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = y == (x1 ?? x2)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: 'y == (x1 ?? x2)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'y')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'x1 ?? x2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,19427,19480);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,19496,19594);

f_22069_19496_19593(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,15056,19605);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,15056,19605);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,15056,19605);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        public void TupleBinaryOperator_ControlFlowInBothOperands()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,19617,25985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,19786,19980);

var 
source = @"
class C
{
    void F((int, int)? x1, (int, int) x2, (int, int)? y1, (int, int) y2, bool b)
    /*<bind>*/
    {
        b = (x1 ?? x2) == (y1 ?? y2);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,19996,25791);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x1')
                  Value: 
                    IParameterReferenceOperation: x1 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)?) (Syntax: 'x1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32)?, IsImplicit) (Syntax: 'x1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x1')
                  Value: 
                    IInvocationOperation ( (System.Int32, System.Int32) (System.Int32, System.Int32)?.GetValueOrDefault()) (OperationKind.Invocation, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'x1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32)?, IsImplicit) (Syntax: 'x1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x2')
              Value: 
                IParameterReferenceOperation: x2 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'x2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y1')
                  Value: 
                    IParameterReferenceOperation: y1 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)?) (Syntax: 'y1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32)?, IsImplicit) (Syntax: 'y1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y1')
                  Value: 
                    IInvocationOperation ( (System.Int32, System.Int32) (System.Int32, System.Int32)?.GetValueOrDefault()) (OperationKind.Invocation, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'y1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32)?, IsImplicit) (Syntax: 'y1')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y2')
              Value: 
                IParameterReferenceOperation: y2 (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)) (Syntax: 'y2')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (x1 ??  ... (y1 ?? y2);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (x1 ??  ...  (y1 ?? y2)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: '(x1 ?? x2) == (y1 ?? y2)')
                      Left: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'x1 ?? x2')
                      Right: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: (System.Int32, System.Int32), IsImplicit) (Syntax: 'y1 ?? y2')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,25807,25860);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,25876,25974);

f_22069_25876_25973(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,19617,25985);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,19617,25985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,19617,25985);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        public void TupleBinaryOperator_TupleExpressions_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,25997,28429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,26171,26331);

var 
source = @"
class C
{
    void F(int i1, int i2, int i3, int i4, bool b)
    /*<bind>*/
    {
        b = (i1, i2) == (i3, i4);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,26347,28235);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (i1, i2 ... = (i3, i4);')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (i1, i2) == (i3, i4)')
              Left: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
              Right: 
                ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: '(i1, i2) == (i3, i4)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
                      NaturalType: (System.Int32 i1, System.Int32 i2)
                      Elements(2):
                          IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')
                          IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')
                  Right: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i3, System.Int32 i4)) (Syntax: '(i3, i4)')
                      NaturalType: (System.Int32 i3, System.Int32 i4)
                      Elements(2):
                          IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')
                          IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i4')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,28251,28304);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,28320,28418);

f_22069_28320_28417(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,25997,28429);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,25997,28429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,25997,28429);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        public void TupleBinaryOperator_TupleExpressions_ControlFlowInLeftOperand()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,28441,33646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,28626,28801);

var 
source = @"
class C
{
    void F(int i1, int? i2, int i3, int i4, int i5, bool b)
    /*<bind>*/
    {
        b = (i1, i2 ?? i5) == (i3, i4);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,28817,33452);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                  Value: 
                    IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i2')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i2')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i5')
              Value: 
                IParameterReferenceOperation: i5 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i5')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (i1, i2 ... = (i3, i4);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (i1, i2 ... == (i3, i4)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: '(i1, i2 ??  ... == (i3, i4)')
                      Left: 
                        ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32)) (Syntax: '(i1, i2 ?? i5)')
                          NaturalType: (System.Int32 i1, System.Int32)
                          Elements(2):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2 ?? i5')
                      Right: 
                        ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i3, System.Int32 i4)) (Syntax: '(i3, i4)')
                          NaturalType: (System.Int32 i3, System.Int32 i4)
                          Elements(2):
                              IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')
                              IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i4')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,33468,33521);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,33537,33635);

f_22069_33537_33634(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,28441,33646);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,28441,33646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,28441,33646);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        public void TupleBinaryOperator_TupleExpressions_ControlFlowInRightOperand()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,33658,39402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,33844,34019);

var 
source = @"
class C
{
    void F(int i1, int i2, int i3, int? i4, int i5, bool b)
    /*<bind>*/
    {
        b = (i1, i2) == (i3, i4 ?? i5);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,34035,39208);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [3] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
              Value: 
                IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [4]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i4')
                  Value: 
                    IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i4')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i4')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i4')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i4')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i4')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i4')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i5')
              Value: 
                IParameterReferenceOperation: i5 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i5')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (i1, i2 ...  i4 ?? i5);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (i1, i2 ... , i4 ?? i5)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: '(i1, i2) == ... , i4 ?? i5)')
                      Left: 
                        ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
                          NaturalType: (System.Int32 i1, System.Int32 i2)
                          Elements(2):
                              IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                      Right: 
                        ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i3, System.Int32)) (Syntax: '(i3, i4 ?? i5)')
                          NaturalType: (System.Int32 i3, System.Int32)
                          Elements(2):
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                              IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i4 ?? i5')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,39224,39277);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,39293,39391);

f_22069_39293_39390(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,33658,39402);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,33658,39402);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,33658,39402);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        public void TupleBinaryOperator_TupleExpressions_ControlFlowInBothOperands()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22069,39414,46921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,39600,39790);

var 
source = @"
class C
{
    void F(int? i1, int i2, int i3, int? i4, int i5, int i6, bool b)
    /*<bind>*/
    {
        b = (i1 ?? i5, i2) == (i3, i4 ?? i6);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,39806,46727);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [3] [4] [6]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i5')
              Value: 
                IParameterReferenceOperation: i5 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i5')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (2)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i3')
              Value: 
                IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

        Next (Regular) Block[B6]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [5]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i4')
                  Value: 
                    IParameterReferenceOperation: i4 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i4')

            Jump if True (Regular) to Block[B8]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i4')
                  Operand: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i4')
                Leaving: {R3}

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B6]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i4')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i4')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i4')
                      Arguments(0)

            Next (Regular) Block[B9]
                Leaving: {R3}
    }

    Block[B8] - Block
        Predecessors: [B6]
        Statements (1)
            IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i6')
              Value: 
                IParameterReferenceOperation: i6 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i6')

        Next (Regular) Block[B9]
    Block[B9] - Block
        Predecessors: [B7] [B8]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (i1 ??  ...  i4 ?? i6);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (i1 ??  ... , i4 ?? i6)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    ITupleBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.TupleBinary, Type: System.Boolean) (Syntax: '(i1 ?? i5,  ... , i4 ?? i6)')
                      Left: 
                        ITupleOperation (OperationKind.Tuple, Type: (System.Int32, System.Int32 i2)) (Syntax: '(i1 ?? i5, i2)')
                          NaturalType: (System.Int32, System.Int32 i2)
                          Elements(2):
                              IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i5')
                              IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i2')
                      Right: 
                        ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i3, System.Int32)) (Syntax: '(i3, i4 ?? i6)')
                          NaturalType: (System.Int32 i3, System.Int32)
                          Elements(2):
                              IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i3')
                              IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i4 ?? i6')

        Next (Regular) Block[B10]
            Leaving: {R1}
}

Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,46743,46796);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22069,46812,46910);

f_22069_46812_46909(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22069,39414,46921);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22069,39414,46921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22069,39414,46921);
}
		}

int
f_22069_1256_1337(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 1256, 1337);
return 0;
}


int
f_22069_2293_2374(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 2293, 2374);
return 0;
}


int
f_22069_3975_4056(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 3975, 4056);
return 0;
}


int
f_22069_6501_6582(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 6501, 6582);
return 0;
}


int
f_22069_7608_7689(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 7608, 7689);
return 0;
}


int
f_22069_9011_9092(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 9011, 9092);
return 0;
}


int
f_22069_10658_10755(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 10658, 10755);
return 0;
}


int
f_22069_14935_15032(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 14935, 15032);
return 0;
}


int
f_22069_19496_19593(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 19496, 19593);
return 0;
}


int
f_22069_25876_25973(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 25876, 25973);
return 0;
}


int
f_22069_28320_28417(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 28320, 28417);
return 0;
}


int
f_22069_33537_33634(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 33537, 33634);
return 0;
}


int
f_22069_39293_39390(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 39293, 39390);
return 0;
}


int
f_22069_46812_46909(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22069, 46812, 46909);
return 0;
}

}
}
