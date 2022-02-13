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
        public void CoalesceOperation_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 574, 5205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 728, 888);

                var
                source = @"
class C
{
    void F(int? input, int alternative, int result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 904, 948);

                var
                compilation = f_22015_922_947(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 964, 996);

                f_22015_964_995(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 1012, 1056);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 1070, 1156);

                var
                node = f_22015_1081_1155(f_22015_1081_1146(f_22015_1081_1113(f_22015_1081_1095(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 1172, 1777);

                f_22015_1172_1776(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: System.Int32) (Syntax: 'input ?? alternative')
  Expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (Identity)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 1793, 5116);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

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
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'input')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 5130, 5194);

                f_22015_5130_5193(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 574, 5205);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 574, 5205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 574, 5205);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 5217, 10262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 5371, 5533);

                var
                source = @"
class C
{
    void F(int? input, long alternative, long result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 5549, 5593);

                var
                compilation = f_22015_5567_5592(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 5609, 5641);

                f_22015_5609_5640(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 5657, 5701);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 5715, 5801);

                var
                node = f_22015_5726_5800(f_22015_5726_5791(f_22015_5726_5758(f_22015_5726_5740(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 5817, 6429);

                f_22015_5817_6428(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: System.Int64) (Syntax: 'input ?? alternative')
  Expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (ImplicitNumeric)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 6445, 10173);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'result')

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
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNumeric)
                      Operand: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'input')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
                          Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int64) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int64, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int64, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 10187, 10251);

                f_22015_10187_10250(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 5217, 10262);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 5217, 10262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 5217, 10262);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 10274, 15333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 10428, 10592);

                var
                source = @"
class C
{
    void F(int? input, long? alternative, long? result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 10608, 10652);

                var
                compilation = f_22015_10626_10651(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 10668, 10700);

                f_22015_10668_10699(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 10716, 10760);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 10774, 10860);

                var
                node = f_22015_10785_10859(f_22015_10785_10850(f_22015_10785_10817(f_22015_10785_10799(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 10876, 11492);

                f_22015_10876_11491(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: System.Int64?) (Syntax: 'input ?? alternative')
  Expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (ImplicitNullable)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int64?) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 11508, 15244);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int64?) (Syntax: 'result')

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
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64?, IsImplicit) (Syntax: 'input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNullable)
                      Operand: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'input')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
                          Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int64?) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int64?) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int64?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int64?, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 15258, 15322);

                f_22015_15258_15321(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 10274, 15333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 10274, 15333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 10274, 15333);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 15345, 20144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 15499, 15667);

                var
                source = @"
class C
{
    void F(string input, object alternative, object result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 15683, 15727);

                var
                compilation = f_22015_15701_15726(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 15743, 15775);

                f_22015_15743_15774(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 15791, 15835);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 15849, 15935);

                var
                node = f_22015_15860_15934(f_22015_15860_15925(f_22015_15860_15892(f_22015_15860_15874(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 15951, 16567);

                f_22015_15951_16566(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: System.Object) (Syntax: 'input ?? alternative')
  Expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.String) (Syntax: 'input')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
    (ImplicitReference)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 16583, 20055);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'result')

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
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.String) (Syntax: 'input')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'input')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 20069, 20133);

                f_22015_20069_20132(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 15345, 20144);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 15345, 20144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 15345, 20144);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 20156, 25611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 20310, 20485);

                var
                source = @"
class C
{
    void F(int? input, System.DateTime alternative, object result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 20501, 20545);

                var
                compilation = f_22015_20519_20544(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 20561, 20933);

                f_22015_20561_20932(
                            compilation, f_22015_20784_20913(f_22015_20784_20893(f_22015_20784_20846(ErrorCode.ERR_BadBinaryOps, "input ?? alternative"), "??", "int?", "System.DateTime"), 6, 18));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 20949, 20993);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 21007, 21093);

                var
                node = f_22015_21018_21092(f_22015_21018_21083(f_22015_21018_21050(f_22015_21018_21032(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 21109, 21745);

                f_22015_21109_21744(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: ?, IsInvalid) (Syntax: 'input ?? alternative')
  Expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'input')
  ValueConversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (NoConversion)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.DateTime, IsInvalid) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 21761, 25522);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'input')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'input')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'input')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.DateTime, IsInvalid) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'result')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'input ?? alternative')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 25536, 25600);

                f_22015_25536_25599(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 20156, 25611);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 20156, 25611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 20156, 25611);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_06()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 25623, 30707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 25777, 25945);

                var
                source = @"
class C
{
    void F(int? input, dynamic alternative, dynamic result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 25959, 26094);

                var
                compilation = f_22015_25977_26093(source, references: new[] { f_22015_26023_26032() }, targetFramework: TargetFramework.Mscorlib40AndSystemCore)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 26110, 26142);

                f_22015_26110_26141(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 26158, 26202);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 26216, 26302);

                var
                node = f_22015_26227_26301(f_22015_26227_26292(f_22015_26227_26259(f_22015_26227_26241(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 26318, 26912);

                f_22015_26318_26911(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: dynamic) (Syntax: 'input ?? alternative')
  Expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (Boxing)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 26928, 30618);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

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
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'input')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
                          Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 30632, 30696);

                f_22015_30632_30695(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 25623, 30707);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 25623, 30707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 25623, 30707);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_07()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 30719, 35538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 30873, 31028);

                var
                source = @"
class C
{
    void F(dynamic alternative, dynamic result)
    /*<bind>*/{
        result = null ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 31044, 31179);

                var
                compilation = f_22015_31062_31178(source, references: new[] { f_22015_31108_31117() }, targetFramework: TargetFramework.Mscorlib40AndSystemCore)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 31195, 31227);

                f_22015_31195_31226(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 31243, 31287);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 31301, 31387);

                var
                node = f_22015_31312_31386(f_22015_31312_31377(f_22015_31312_31344(f_22015_31312_31326(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 31403, 31983);

                f_22015_31403_31982(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: dynamic) (Syntax: 'null ?? alternative')
  Expression: 
    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
    (ImplicitReference)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 31999, 35449);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'null')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block [UnReachable]
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = nu ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = nu ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'null ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 35463, 35527);

                f_22015_35463_35526(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 30719, 35538);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 30719, 35538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 30719, 35538);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_08()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 35550, 40941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 35704, 35851);

                var
                source = @"
class C
{
    void F(int alternative, int result)
    /*<bind>*/{
        result = null ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 35867, 35911);

                var
                compilation = f_22015_35885_35910(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 35927, 36284);

                f_22015_35927_36283(
                            compilation, f_22015_36146_36264(f_22015_36146_36244(f_22015_36146_36207(ErrorCode.ERR_BadBinaryOps, "null ?? alternative"), "??", "<null>", "int"), 6, 18));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 36300, 36344);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 36358, 36444);

                var
                node = f_22015_36369_36443(f_22015_36369_36434(f_22015_36369_36401(f_22015_36369_36383(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 36460, 37069);

                f_22015_36460_37068(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: ?, IsInvalid) (Syntax: 'null ?? alternative')
  Expression: 
    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
  ValueConversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (NoConversion)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 37085, 40852);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'null')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, Constant: True, IsInvalid, IsImplicit) (Syntax: 'null')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block [UnReachable]
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'null')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'null')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = nu ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'result = nu ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'null ?? alternative')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'null ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 40866, 40930);

                f_22015_40866_40929(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 35550, 40941);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 35550, 40941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 35550, 40941);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_09()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 40953, 45693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 41107, 41256);

                var
                source = @"
class C
{
    void F(int? alternative, int? result)
    /*<bind>*/{
        result = null ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 41272, 41316);

                var
                compilation = f_22015_41290_41315(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 41332, 41364);

                f_22015_41332_41363(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 41380, 41424);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 41438, 41524);

                var
                node = f_22015_41449_41523(f_22015_41449_41514(f_22015_41449_41481(f_22015_41449_41463(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 41540, 42127);

                f_22015_41540_42126(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: System.Int32?) (Syntax: 'null ?? alternative')
  Expression: 
    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (NullLiteral)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 42143, 45604);

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
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'null')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
                Leaving: {R2}
            Next (Regular) Block[B3]
        Block[B3] - Block [UnReachable]
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NullLiteral)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
            Next (Regular) Block[B5]
                Leaving: {R2}
    }
    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'alternative')
        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = nu ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?) (Syntax: 'result = nu ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'null ?? alternative')
        Next (Regular) Block[B6]
            Leaving: {R1}
}
Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 45618, 45682);

                f_22015_45618_45681(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 40953, 45693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 40953, 45693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 40953, 45693);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_10()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 45705, 50788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 45859, 46022);

                var
                source = @"
class C
{
    void F(int? input, byte? alternative, int? result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 46038, 46082);

                var
                compilation = f_22015_46056_46081(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 46098, 46130);

                f_22015_46098_46129(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 46146, 46190);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 46204, 46290);

                var
                node = f_22015_46215_46289(f_22015_46215_46280(f_22015_46215_46247(f_22015_46215_46229(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 46306, 47222);

                f_22015_46306_47221(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: System.Int32?) (Syntax: 'input ?? alternative')
  Expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (Identity)
  WhenNull: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: 'alternative')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Byte?) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 47238, 50699);

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
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: 'alternative')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitNullable)
                  Operand: 
                    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Byte?) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 50713, 50777);

                f_22015_50713_50776(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 45705, 50788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 45705, 50788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 45705, 50788);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_11()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 50800, 55188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 50954, 51116);

                var
                source = @"
class C
{
    void F(int? input, int? alternative, int? result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 51132, 51176);

                var
                compilation = f_22015_51150_51175(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 51192, 51224);

                f_22015_51192_51223(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 51240, 51284);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 51298, 51384);

                var
                node = f_22015_51309_51383(f_22015_51309_51374(f_22015_51309_51341(f_22015_51309_51323(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 51400, 52007);

                f_22015_51400_52006(
                            compilation, node, expectedOperationTree:
                @"
ICoalesceOperation (OperationKind.Coalesce, Type: System.Int32?) (Syntax: 'input ?? alternative')
  Expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')
  ValueConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    (Identity)
  WhenNull: 
    IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'alternative')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 52023, 55099);

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
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 55113, 55177);

                f_22015_55113_55176(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 50800, 55188);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 50800, 55188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 50800, 55188);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_12()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 55200, 61775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 55354, 55582);

                var
                source = @"
class C
{
    void F(int? input1, int? alternative1, int? input2, int? alternative2, int? result)
    /*<bind>*/{
        result = (input1 ?? alternative1) ?? (input2 ?? alternative2);
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 55598, 55642);

                var
                compilation = f_22015_55616_55641(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 55658, 55690);

                f_22015_55658_55689(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 55706, 61686);

                string
                expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
                      Value: 
                        IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input1')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative1')
                  Value: 
                    IParameterReferenceOperation: alternative1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'alternative1')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input1 ?? alternative1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input1 ?? alternative1')
                Leaving: {R2}
                Entering: {R4}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1 ?? alternative1')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input1 ?? alternative1')

            Next (Regular) Block[B10]
                Leaving: {R2}
    }
    .locals {R4}
    {
        CaptureIds: [4]
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
                  Value: 
                    IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input2')

            Jump if True (Regular) to Block[B9]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input2')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input2')
                Leaving: {R4}

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
                  Value: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input2')

            Next (Regular) Block[B10]
                Leaving: {R4}
    }

    Block[B9] - Block
        Predecessors: [B7]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative2')
              Value: 
                IParameterReferenceOperation: alternative2 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'alternative2')

        Next (Regular) Block[B10]
    Block[B10] - Block
        Predecessors: [B6] [B8] [B9]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (i ... ernative2);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?) (Syntax: 'result = (i ... ternative2)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: '(input1 ??  ... ternative2)')

        Next (Regular) Block[B11]
            Leaving: {R1}
}

Block[B11] - Exit
    Predecessors: [B10]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 61700, 61764);

                f_22015_61700_61763(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 55200, 61775);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 55200, 61775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 55200, 61775);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_13()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 61787, 65987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 61941, 62130);

                var
                source = @"
class C
{
    const string input = ""a"";

    void F(object alternative, object result)
    /*<bind>*/{
        result = input ?? alternative;
    }/*</bind>*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 62146, 62190);

                var
                compilation = f_22015_62164_62189(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 62206, 62238);

                f_22015_62206_62237(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 62254, 65898);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'result')

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
                    IFieldReferenceOperation: System.String C.input (Static) (OperationKind.FieldReference, Type: System.String, Constant: ""a"") (Syntax: 'input')
                      Instance Receiver: 
                        null

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, Constant: ""a"", IsImplicit) (Syntax: 'input')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, Constant: ""a"", IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block [UnReachable]
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'alternative')
              Value: 
                IParameterReferenceOperation: alternative (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'alternative')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... lternative;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'result = in ... alternative')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input ?? alternative')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 65912, 65976);

                f_22015_65912_65975(compilation, expectedGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 61787, 65987);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 61787, 65987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 61787, 65987);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void CoalesceOperation_14()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22015, 65999, 69794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 66153, 66291);

                string
                source = @"
class P
{
    void M1(int? i, int j, int result)
    /*<bind>*/{
        result = i ?? j;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 66305, 66363);

                var
                compilation = f_22015_66323_66362(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 66377, 66458);

                f_22015_66377_66457(compilation, SpecialMember.System_Nullable_T_GetValueOrDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 66474, 69601);

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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                  Value: 
                    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsImplicit) (Syntax: 'i')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j')
              Value: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = i ?? j;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = i ?? j')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i ?? j')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 69615, 69668);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22015, 69684, 69783);

                f_22015_69684_69782(compilation, expectedGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22015, 65999, 69794);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22015, 65999, 69794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22015, 65999, 69794);
            }
        }

        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_922_947(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 922, 947);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_964_995(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 964, 995);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_1081_1095(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 1081, 1095);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_1081_1113(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 1081, 1113);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_1081_1146(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 1081, 1146);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_1081_1155(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 1081, 1155);
            return return_v;
        }


        int
        f_22015_1172_1776(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 1172, 1776);
            return 0;
        }


        int
        f_22015_5130_5193(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 5130, 5193);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_5567_5592(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 5567, 5592);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_5609_5640(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 5609, 5640);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_5726_5740(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 5726, 5740);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_5726_5758(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 5726, 5758);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_5726_5791(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 5726, 5791);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_5726_5800(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 5726, 5800);
            return return_v;
        }


        int
        f_22015_5817_6428(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 5817, 6428);
            return 0;
        }


        int
        f_22015_10187_10250(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 10187, 10250);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_10626_10651(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 10626, 10651);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_10668_10699(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 10668, 10699);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_10785_10799(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 10785, 10799);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_10785_10817(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 10785, 10817);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_10785_10850(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 10785, 10850);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_10785_10859(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 10785, 10859);
            return return_v;
        }


        int
        f_22015_10876_11491(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 10876, 11491);
            return 0;
        }


        int
        f_22015_15258_15321(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 15258, 15321);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_15701_15726(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 15701, 15726);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_15743_15774(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 15743, 15774);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_15860_15874(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 15860, 15874);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_15860_15892(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 15860, 15892);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_15860_15925(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 15860, 15925);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_15860_15934(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 15860, 15934);
            return return_v;
        }


        int
        f_22015_15951_16566(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 15951, 16566);
            return 0;
        }


        int
        f_22015_20069_20132(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 20069, 20132);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_20519_20544(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 20519, 20544);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22015_20784_20846(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 20784, 20846);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22015_20784_20893(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 20784, 20893);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22015_20784_20913(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 20784, 20913);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_20561_20932(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 20561, 20932);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_21018_21032(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 21018, 21032);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_21018_21050(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 21018, 21050);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_21018_21083(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 21018, 21083);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_21018_21092(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 21018, 21092);
            return return_v;
        }


        int
        f_22015_21109_21744(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 21109, 21744);
            return 0;
        }


        int
        f_22015_25536_25599(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 25536, 25599);
            return 0;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22015_26023_26032()
        {
            var return_v = CSharpRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22015, 26023, 26032);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_25977_26093(string
        source, Microsoft.CodeAnalysis.MetadataReference[]
        references, Roslyn.Test.Utilities.TargetFramework
        targetFramework)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, targetFramework: targetFramework);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 25977, 26093);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_26110_26141(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 26110, 26141);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_26227_26241(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 26227, 26241);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_26227_26259(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 26227, 26259);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_26227_26292(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 26227, 26292);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_26227_26301(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 26227, 26301);
            return return_v;
        }


        int
        f_22015_26318_26911(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 26318, 26911);
            return 0;
        }


        int
        f_22015_30632_30695(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 30632, 30695);
            return 0;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22015_31108_31117()
        {
            var return_v = CSharpRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22015, 31108, 31117);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_31062_31178(string
        source, Microsoft.CodeAnalysis.MetadataReference[]
        references, Roslyn.Test.Utilities.TargetFramework
        targetFramework)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, targetFramework: targetFramework);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 31062, 31178);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_31195_31226(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 31195, 31226);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_31312_31326(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 31312, 31326);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_31312_31344(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 31312, 31344);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_31312_31377(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 31312, 31377);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_31312_31386(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 31312, 31386);
            return return_v;
        }


        int
        f_22015_31403_31982(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 31403, 31982);
            return 0;
        }


        int
        f_22015_35463_35526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 35463, 35526);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_35885_35910(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 35885, 35910);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22015_36146_36207(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 36146, 36207);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22015_36146_36244(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 36146, 36244);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22015_36146_36264(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 36146, 36264);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_35927_36283(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 35927, 36283);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_36369_36383(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 36369, 36383);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_36369_36401(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 36369, 36401);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_36369_36434(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 36369, 36434);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_36369_36443(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 36369, 36443);
            return return_v;
        }


        int
        f_22015_36460_37068(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 36460, 37068);
            return 0;
        }


        int
        f_22015_40866_40929(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 40866, 40929);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_41290_41315(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 41290, 41315);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_41332_41363(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 41332, 41363);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_41449_41463(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 41449, 41463);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_41449_41481(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 41449, 41481);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_41449_41514(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 41449, 41514);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_41449_41523(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 41449, 41523);
            return return_v;
        }


        int
        f_22015_41540_42126(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 41540, 42126);
            return 0;
        }


        int
        f_22015_45618_45681(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 45618, 45681);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_46056_46081(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 46056, 46081);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_46098_46129(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 46098, 46129);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_46215_46229(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 46215, 46229);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_46215_46247(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 46215, 46247);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_46215_46280(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 46215, 46280);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_46215_46289(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 46215, 46289);
            return return_v;
        }


        int
        f_22015_46306_47221(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 46306, 47221);
            return 0;
        }


        int
        f_22015_50713_50776(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 50713, 50776);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_51150_51175(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 51150, 51175);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_51192_51223(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 51192, 51223);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22015_51309_51323(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 51309, 51323);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22015_51309_51341(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 51309, 51341);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        f_22015_51309_51374(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 51309, 51374);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        f_22015_51309_51383(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 51309, 51383);
            return return_v;
        }


        int
        f_22015_51400_52006(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 51400, 52006);
            return 0;
        }


        int
        f_22015_55113_55176(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 55113, 55176);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_55616_55641(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 55616, 55641);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_55658_55689(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 55658, 55689);
            return return_v;
        }


        int
        f_22015_61700_61763(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 61700, 61763);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_62164_62189(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 62164, 62189);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_62206_62237(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 62206, 62237);
            return return_v;
        }


        int
        f_22015_65912_65975(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 65912, 65975);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22015_66323_66362(string
        source)
        {
            var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 66323, 66362);
            return return_v;
        }


        int
        f_22015_66377_66457(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SpecialMember
        member)
        {
            this_param.MakeMemberMissing(member);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 66377, 66457);
            return 0;
        }


        int
        f_22015_69684_69782(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(compilation, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22015, 69684, 69782);
            return 0;
        }

    }
}
