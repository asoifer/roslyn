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
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IConditionalAccessExpression_SimpleMethodAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,524,1694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,679,852);

string 
source = @"
using System;

public class C1
{
    public void M()
    {
        var o = new object();
        /*<bind>*/o?.ToString()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,866,1472);

string 
expectedOperationTree = @"
IConditionalAccessOperation (OperationKind.ConditionalAccess, Type: System.String) (Syntax: 'o?.ToString()')
  Operation: 
    ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
  WhenNotNull: 
    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '.ToString()')
      Instance Receiver: 
        IConditionalAccessInstanceOperation (OperationKind.ConditionalAccessInstance, Type: System.Object, IsImplicit) (Syntax: 'o')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,1486,1539);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,1555,1683);

f_22017_1555_1682(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,524,1694);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,524,1694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,524,1694);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IConditionalAccessExpression_SimplePropertyAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,1706,2849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,1863,2059);

string 
source = @"
using System;

public class C1
{
    int Prop1 { get; }
    public void M()
    {
        C1 c1 = null;
        var prop = /*<bind>*/c1?.Prop1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,2073,2627);

string 
expectedOperationTree = @"
IConditionalAccessOperation (OperationKind.ConditionalAccess, Type: System.Int32?) (Syntax: 'c1?.Prop1')
  Operation: 
    ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C1) (Syntax: 'c1')
  WhenNotNull: 
    IPropertyReferenceOperation: System.Int32 C1.Prop1 { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: '.Prop1')
      Instance Receiver: 
        IConditionalAccessInstanceOperation (OperationKind.ConditionalAccessInstance, Type: C1, IsImplicit) (Syntax: 'c1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,2641,2694);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,2710,2838);

f_22017_2710_2837(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,1706,2849);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,1706,2849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,1706,2849);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,2861,7021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,3019,3166);

string 
source = @"
class P
{
    void M1(System.Array input, int? result)
/*<bind>*/{
        result = input?.Length;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,3180,6833);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Array) (Syntax: 'input')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Array, IsImplicit) (Syntax: 'input')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.Length')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: '.Length')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNullable)
                      Operand: 
                        IPropertyReferenceOperation: System.Int32 System.Array.Length { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: '.Length')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Array, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32?, IsImplicit) (Syntax: 'input')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = input?.Length;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?) (Syntax: 'result = input?.Length')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input?.Length')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,6847,6900);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,6916,7010);

f_22017_6916_7009(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,2861,7021);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,2861,7021);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,2861,7021);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,7033,11117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,7191,7336);

string 
source = @"
class P
{
    void M1(int? input, string result)
/*<bind>*/{
        result = input?.ToString();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,7350,10929);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.String) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.ToString()')
                  Value: 
                    IInvocationOperation (virtual System.String System.Int32.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '.ToString()')
                      Instance Receiver: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'input')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
                          Arguments(0)
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.String, Constant: null, IsImplicit) (Syntax: 'input')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... ToString();')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'result = in ... .ToString()')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'input?.ToString()')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,10943,10996);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,11012,11106);

f_22017_11012_11105(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,7033,11117);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,7033,11117);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,7033,11117);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,11129,14891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,11287,11455);

string 
source = @"
class P
{
    void M1(P input, int? result)
/*<bind>*/{
        result = input?.Access();
    }/*</bind>*/

    int? Access() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,11469,14703);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: P) (Syntax: 'input')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'input')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.Access()')
                  Value: 
                    IInvocationOperation ( System.Int32? P.Access()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: '.Access()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'input')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32?, IsImplicit) (Syntax: 'input')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... ?.Access();')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?) (Syntax: 'result = input?.Access()')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input?.Access()')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,14717,14770);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,14786,14880);

f_22017_14786_14879(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,11129,14891);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,11129,14891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,11129,14891);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,14903,24207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,15061,15304);

string 
source = @"
class P
{
    void M1(P input, P result)
/*<bind>*/{
        result = (input?[11]?.Access1())?[22]?.Access2();
    }/*</bind>*/

    P this[int x] => null;
    P[] Access1() => null;
    P Access2() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,15318,24019);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: P) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2} {R3} {R4} {R5}

    .locals {R2}
    {
        CaptureIds: [4]
        .locals {R3}
        {
            CaptureIds: [3]
            .locals {R4}
            {
                CaptureIds: [2]
                .locals {R5}
                {
                    CaptureIds: [1]
                    Block[B2] - Block
                        Predecessors: [B1]
                        Statements (1)
                            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                              Value: 
                                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: P) (Syntax: 'input')

                        Jump if True (Regular) to Block[B6]
                            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                              Operand: 
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'input')
                            Leaving: {R5} {R4}

                        Next (Regular) Block[B3]
                    Block[B3] - Block
                        Predecessors: [B2]
                        Statements (1)
                            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[11]')
                              Value: 
                                IPropertyReferenceOperation: P P.this[System.Int32 x] { get; } (OperationKind.PropertyReference, Type: P) (Syntax: '[11]')
                                  Instance Receiver: 
                                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'input')
                                  Arguments(1):
                                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '11')
                                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 11) (Syntax: '11')
                                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                        Next (Regular) Block[B4]
                            Leaving: {R5}
                }

                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (0)
                    Jump if True (Regular) to Block[B6]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: '[11]')
                          Operand: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: '[11]')
                        Leaving: {R4}

                    Next (Regular) Block[B5]
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.Access1()')
                          Value: 
                            IInvocationOperation ( P[] P.Access1()) (OperationKind.Invocation, Type: P[]) (Syntax: '.Access1()')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: '[11]')
                              Arguments(0)

                    Next (Regular) Block[B7]
                        Leaving: {R4}
            }

            Block[B6] - Block
                Predecessors: [B2] [B4]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input?[11]?.Access1()')
                      Value: 
                        IDefaultValueOperation (OperationKind.DefaultValue, Type: P[], Constant: null, IsImplicit) (Syntax: 'input?[11]?.Access1()')

                Next (Regular) Block[B7]
            Block[B7] - Block
                Predecessors: [B5] [B6]
                Statements (0)
                Jump if True (Regular) to Block[B11]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input?[11]?.Access1()')
                      Operand: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: P[], IsImplicit) (Syntax: 'input?[11]?.Access1()')
                    Leaving: {R3} {R2}

                Next (Regular) Block[B8]
            Block[B8] - Block
                Predecessors: [B7]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[22]')
                      Value: 
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: P) (Syntax: '[22]')
                          Array reference: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: P[], IsImplicit) (Syntax: 'input?[11]?.Access1()')
                          Indices(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 22) (Syntax: '22')

                Next (Regular) Block[B9]
                    Leaving: {R3}
        }

        Block[B9] - Block
            Predecessors: [B8]
            Statements (0)
            Jump if True (Regular) to Block[B11]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: '[22]')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: '[22]')
                Leaving: {R2}

            Next (Regular) Block[B10]
        Block[B10] - Block
            Predecessors: [B9]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.Access2()')
                  Value: 
                    IInvocationOperation ( P P.Access2()) (OperationKind.Invocation, Type: P) (Syntax: '.Access2()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: '[22]')
                      Arguments(0)

            Next (Regular) Block[B12]
                Leaving: {R2}
    }

    Block[B11] - Block
        Predecessors: [B7] [B9]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(input?[11] ... ?.Access2()')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: P, Constant: null, IsImplicit) (Syntax: '(input?[11] ... ?.Access2()')

        Next (Regular) Block[B12]
    Block[B12] - Block
        Predecessors: [B10] [B11]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (i ... .Access2();')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P) (Syntax: 'result = (i ... ?.Access2()')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: '(input?[11] ... ?.Access2()')

        Next (Regular) Block[B13]
            Leaving: {R1}
}

Block[B13] - Exit
    Predecessors: [B12]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,24033,24086);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,24102,24196);

f_22017_24102_24195(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,14903,24207);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,14903,24207);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,14903,24207);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,24219,35109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,24377,24633);

string 
source = @"
struct P
{
    void M1(P? input, P? result)
/*<bind>*/{
        result = (input?.Access1()?[11])?[22]?.Access2();
    }/*</bind>*/

    P? this[int x] => default;
    P[] Access1() => default;
    P Access2() => default;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,24647,34921);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: P?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2} {R3} {R4} {R5}

    .locals {R2}
    {
        CaptureIds: [4]
        .locals {R3}
        {
            CaptureIds: [3]
            .locals {R4}
            {
                CaptureIds: [2]
                .locals {R5}
                {
                    CaptureIds: [1]
                    Block[B2] - Block
                        Predecessors: [B1]
                        Statements (1)
                            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                              Value: 
                                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: P?) (Syntax: 'input')

                        Jump if True (Regular) to Block[B6]
                            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                              Operand: 
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: 'input')
                            Leaving: {R5} {R4}

                        Next (Regular) Block[B3]
                    Block[B3] - Block
                        Predecessors: [B2]
                        Statements (1)
                            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.Access1()')
                              Value: 
                                IInvocationOperation ( P[] P.Access1()) (OperationKind.Invocation, Type: P[]) (Syntax: '.Access1()')
                                  Instance Receiver: 
                                    IInvocationOperation ( P P?.GetValueOrDefault()) (OperationKind.Invocation, Type: P, IsImplicit) (Syntax: 'input')
                                      Instance Receiver: 
                                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: 'input')
                                      Arguments(0)
                                  Arguments(0)

                        Next (Regular) Block[B4]
                            Leaving: {R5}
                }

                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (0)
                    Jump if True (Regular) to Block[B6]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: '.Access1()')
                          Operand: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: P[], IsImplicit) (Syntax: '.Access1()')
                        Leaving: {R4}

                    Next (Regular) Block[B5]
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[11]')
                          Value: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: P?, IsImplicit) (Syntax: '[11]')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (ImplicitNullable)
                              Operand: 
                                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: P) (Syntax: '[11]')
                                  Array reference: 
                                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: P[], IsImplicit) (Syntax: '.Access1()')
                                  Indices(1):
                                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 11) (Syntax: '11')

                    Next (Regular) Block[B7]
                        Leaving: {R4}
            }

            Block[B6] - Block
                Predecessors: [B2] [B4]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input?.Access1()?[11]')
                      Value: 
                        IDefaultValueOperation (OperationKind.DefaultValue, Type: P?, IsImplicit) (Syntax: 'input?.Access1()?[11]')

                Next (Regular) Block[B7]
            Block[B7] - Block
                Predecessors: [B5] [B6]
                Statements (0)
                Jump if True (Regular) to Block[B11]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input?.Access1()?[11]')
                      Operand: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: 'input?.Access1()?[11]')
                    Leaving: {R3} {R2}

                Next (Regular) Block[B8]
            Block[B8] - Block
                Predecessors: [B7]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '[22]')
                      Value: 
                        IPropertyReferenceOperation: P? P.this[System.Int32 x] { get; } (OperationKind.PropertyReference, Type: P?) (Syntax: '[22]')
                          Instance Receiver: 
                            IInvocationOperation ( P P?.GetValueOrDefault()) (OperationKind.Invocation, Type: P, IsImplicit) (Syntax: 'input?.Access1()?[11]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: 'input?.Access1()?[11]')
                              Arguments(0)
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '22')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 22) (Syntax: '22')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B9]
                    Leaving: {R3}
        }

        Block[B9] - Block
            Predecessors: [B8]
            Statements (0)
            Jump if True (Regular) to Block[B11]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: '[22]')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: '[22]')
                Leaving: {R2}

            Next (Regular) Block[B10]
        Block[B10] - Block
            Predecessors: [B9]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.Access2()')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: P?, IsImplicit) (Syntax: '.Access2()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNullable)
                      Operand: 
                        IInvocationOperation ( P P.Access2()) (OperationKind.Invocation, Type: P) (Syntax: '.Access2()')
                          Instance Receiver: 
                            IInvocationOperation ( P P?.GetValueOrDefault()) (OperationKind.Invocation, Type: P, IsImplicit) (Syntax: '[22]')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: '[22]')
                              Arguments(0)
                          Arguments(0)

            Next (Regular) Block[B12]
                Leaving: {R2}
    }

    Block[B11] - Block
        Predecessors: [B7] [B9]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(input?.Acc ... ?.Access2()')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: P?, IsImplicit) (Syntax: '(input?.Acc ... ?.Access2()')

        Next (Regular) Block[B12]
    Block[B12] - Block
        Predecessors: [B10] [B11]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (i ... .Access2();')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P?) (Syntax: 'result = (i ... ?.Access2()')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: '(input?.Acc ... ?.Access2()')

        Next (Regular) Block[B13]
            Leaving: {R1}
}

Block[B13] - Exit
    Predecessors: [B12]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,34935,34988);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,35004,35098);

f_22017_35004_35097(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,24219,35109);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,24219,35109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,24219,35109);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,35121,39563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,35279,35445);

string 
source = @"
struct P
{
    void M1(S1? x)
/*<bind>*/{
        x?.P1 = 0;
    }/*</bind>*/
}

public struct S1
{
    public int P1 { get; set; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,35459,39126);

string 
expectedGraph = @"
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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'x')
                  Value: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: S1?, IsInvalid) (Syntax: 'x')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'x')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: S1?, IsInvalid, IsImplicit) (Syntax: 'x')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '.P1')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: '.P1')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNullable)
                      Operand: 
                        IPropertyReferenceOperation: System.Int32 S1.P1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: '.P1')
                          Instance Receiver: 
                            IInvocationOperation ( S1 S1?.GetValueOrDefault()) (OperationKind.Invocation, Type: S1, IsInvalid, IsImplicit) (Syntax: 'x')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: S1?, IsInvalid, IsImplicit) (Syntax: 'x')
                              Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'x')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'x')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x?.P1 = 0;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?, IsInvalid) (Syntax: 'x?.P1 = 0')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'x?.P1')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'x?.P1')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,39140,39442);

var 
expectedDiagnostics = new[] {
f_22017_39354_39426(f_22017_39354_39407(ErrorCode.ERR_AssgLvalueExpected, "x?.P1"), 6, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,39458,39552);

f_22017_39458_39551(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,35121,39563);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,35121,39563);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,35121,39563);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,39575,43984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,39733,39886);

string 
source = @"
struct P
{
    void M1(S1? x)
/*<bind>*/{
        x?.P1 = 0;
    }/*</bind>*/
}

public struct S1
{
    public int P1;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,39900,43547);

string 
expectedGraph = @"
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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'x')
                  Value: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: S1?, IsInvalid) (Syntax: 'x')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'x')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: S1?, IsInvalid, IsImplicit) (Syntax: 'x')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '.P1')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: '.P1')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNullable)
                      Operand: 
                        IFieldReferenceOperation: System.Int32 S1.P1 (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: '.P1')
                          Instance Receiver: 
                            IInvocationOperation ( S1 S1?.GetValueOrDefault()) (OperationKind.Invocation, Type: S1, IsInvalid, IsImplicit) (Syntax: 'x')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: S1?, IsInvalid, IsImplicit) (Syntax: 'x')
                              Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'x')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'x')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x?.P1 = 0;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?, IsInvalid) (Syntax: 'x?.P1 = 0')
                  Left: 
                    IInvalidOperation (OperationKind.Invalid, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'x?.P1')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'x?.P1')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,43561,43863);

var 
expectedDiagnostics = new[] {
f_22017_43775_43847(f_22017_43775_43828(ErrorCode.ERR_AssgLvalueExpected, "x?.P1"), 6, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,43879,43973);

f_22017_43879_43972(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,39575,43984);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,39575,43984);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,39575,43984);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,43996,48474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,44154,44326);

string 
source = @"
struct P
{
    void M1(P? input, int? result)
/*<bind>*/{
        result = input?.Length;
    }/*</bind>*/

    public int Length { get; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,44340,44398);

var 
compilation = f_22017_44358_44397(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,44412,44493);

f_22017_44412_44492(            compilation, SpecialMember.System_Nullable_T_GetValueOrDefault);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,44509,48281);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: P?) (Syntax: 'input')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: 'input')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.Length')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: '.Length')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNullable)
                      Operand: 
                        IPropertyReferenceOperation: System.Int32 P.Length { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: '.Length')
                          Instance Receiver: 
                            IInvalidOperation (OperationKind.Invalid, Type: P, IsImplicit) (Syntax: 'input')
                              Children(1):
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P?, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32?, IsImplicit) (Syntax: 'input')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = input?.Length;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?) (Syntax: 'result = input?.Length')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input?.Length')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,48295,48348);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,48364,48463);

f_22017_48364_48462(compilation, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,43996,48474);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,43996,48474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,43996,48474);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ConditionalAccessFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22017,48486,56997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,48644,48842);

string 
source = @"
class C
{
    void M1(C input1, C input2, C input3)
/*<bind>*/{
        input1?.M(input2?.M(input3?.M(null)));
    }/*</bind>*/

    public string M(string x) => x;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,48856,56809);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
              Value: 
                IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: C) (Syntax: 'input1')

        Jump if True (Regular) to Block[B9]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input1')
              Operand: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input1')
            Leaving: {R1}

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1] [4]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
                  Value: 
                    IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: C) (Syntax: 'input2')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input2')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input2')
                Leaving: {R2}

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input3')
                      Value: 
                        IParameterReferenceOperation: input3 (OperationKind.ParameterReference, Type: C) (Syntax: 'input3')

                Jump if True (Regular) to Block[B5]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input3')
                      Operand: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input3')
                    Leaving: {R3}

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.M(null)')
                      Value: 
                        IInvocationOperation ( System.String C.M(System.String x)) (OperationKind.Invocation, Type: System.String) (Syntax: '.M(null)')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input3')
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'null')
                                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
                                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                    (ImplicitReference)
                                  Operand: 
                                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Regular) Block[B6]
                    Leaving: {R3}
        }

        Block[B5] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input3')
                  Value: 
                    IDefaultValueOperation (OperationKind.DefaultValue, Type: System.String, Constant: null, IsImplicit) (Syntax: 'input3')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '.M(input3?.M(null))')
                  Value: 
                    IInvocationOperation ( System.String C.M(System.String x)) (OperationKind.Invocation, Type: System.String) (Syntax: '.M(input3?.M(null))')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input2')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'input3?.M(null)')
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'input3?.M(null)')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B8]
                Leaving: {R2}
    }

    Block[B7] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
              Value: 
                IDefaultValueOperation (OperationKind.DefaultValue, Type: System.String, Constant: null, IsImplicit) (Syntax: 'input2')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input1?.M(i ... .M(null)));')
              Expression: 
                IInvocationOperation ( System.String C.M(System.String x)) (OperationKind.Invocation, Type: System.String) (Syntax: '.M(input2?. ... ?.M(null)))')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input1')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'input2?.M(i ... 3?.M(null))')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'input2?.M(i ... 3?.M(null))')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B1] [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,56823,56876);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22017,56892,56986);

f_22017_56892_56985(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22017,48486,56997);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22017,48486,56997);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22017,48486,56997);
}
		}

int
f_22017_1555_1682(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ConditionalAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 1555, 1682);
return 0;
}


int
f_22017_2710_2837(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ConditionalAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 2710, 2837);
return 0;
}


int
f_22017_6916_7009(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 6916, 7009);
return 0;
}


int
f_22017_11012_11105(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 11012, 11105);
return 0;
}


int
f_22017_14786_14879(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 14786, 14879);
return 0;
}


int
f_22017_24102_24195(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 24102, 24195);
return 0;
}


int
f_22017_35004_35097(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 35004, 35097);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22017_39354_39407(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 39354, 39407);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22017_39354_39426(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 39354, 39426);
return return_v;
}


int
f_22017_39458_39551(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 39458, 39551);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22017_43775_43828(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 43775, 43828);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22017_43775_43847(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 43775, 43847);
return return_v;
}


int
f_22017_43879_43972(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 43879, 43972);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22017_44358_44397(string
source)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 44358, 44397);
return return_v;
}


int
f_22017_44412_44492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
member)
{
this_param.MakeMemberMissing( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 44412, 44492);
return 0;
}


int
f_22017_48364_48462(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 48364, 48462);
return 0;
}


int
f_22017_56892_56985(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22017, 56892, 56985);
return 0;
}

}
}
