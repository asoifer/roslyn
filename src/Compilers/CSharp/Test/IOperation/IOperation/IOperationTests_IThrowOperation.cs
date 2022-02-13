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
        public void ThrowFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,526,1505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,672,769);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
        throw;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,785,829);

var 
compilation = f_22067_803_828(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,845,1133);

f_22067_845_1132(
            compilation, f_22067_1046_1113(f_22067_1046_1094(ErrorCode.ERR_BadEmptyThrow, "throw"), 6, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,1149,1416);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Next (Rethrow) Block[null]
Block[B2] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,1430,1494);

f_22067_1430_1493(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,526,1505);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,526,1505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,526,1505);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,1517,3852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,1663,1797);

var 
source = @"
class C
{
    void F(int x)
    /*<bind>*/{
        x = 1;
        throw;
        x = 2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,1813,1857);

var 
compilation = f_22067_1831_1856(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,1873,2349);

f_22067_1873_2348(
            compilation, f_22067_2074_2141(f_22067_2074_2122(ErrorCode.ERR_BadEmptyThrow, "throw"), 7, 9), f_22067_2264_2329(f_22067_2264_2310(ErrorCode.WRN_UnreachableCode, "x"), 8, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,2365,3763);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Rethrow) Block[null]
Block[B2] - Block [UnReachable]
    Predecessors (0)
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

    Next (Regular) Block[B3]
Block[B3] - Exit [UnReachable]
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,3777,3841);

f_22067_3777_3840(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,1517,3852);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,1517,3852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,1517,3852);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,3864,4723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,4010,4129);

var 
source = @"
class C
{
    void F(System.Exception ex)
    /*<bind>*/{
        throw ex;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,4145,4189);

var 
compilation = f_22067_4163_4188(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,4205,4237);

f_22067_4205_4236(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,4253,4634);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Next (Throw) Block[null]
        IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
Block[B2] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,4648,4712);

f_22067_4648_4711(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,3864,4723);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,3864,4723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,3864,4723);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,4735,7287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,4881,5036);

var 
source = @"
class C
{
    void F(System.Exception ex)
    /*<bind>*/{
        int x = 1;
        throw ex;
        x = 2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,5052,5096);

var 
compilation = f_22067_5070_5095(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,5112,5597);

f_22067_5112_5596(
            compilation, f_22067_5264_5329(f_22067_5264_5310(ErrorCode.WRN_UnreachableCode, "x"), 8, 9), f_22067_5488_5577(f_22067_5488_5557(f_22067_5488_5538(ErrorCode.WRN_UnreferencedVarAssg, "x"), "x"), 6, 13));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,5613,7198);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'x = 1')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'x = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B2] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit [UnReachable]
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,7212,7276);

f_22067_7212_7275(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,4735,7287);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,4735,7287);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,4735,7287);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,7299,11252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,7445,7579);

var 
source = @"
class C
{
    void F(int x, System.Exception ex)
    /*<bind>*/{
        x = throw ex + x;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,7595,7639);

var 
compilation = f_22067_7613_7638(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,7655,8225);

f_22067_7655_8224(
            compilation, f_22067_7842_7911(f_22067_7842_7891(ErrorCode.ERR_ThrowMisplaced, "throw"), 6, 13), f_22067_8091_8205(f_22067_8091_8185(f_22067_8091_8139(ErrorCode.ERR_BadBinaryOps, "ex + x"), "+", "System.Exception", "int"), 6, 19));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,8241,11163);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1}
    .locals {R1}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                  Value: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
            Next (Throw) Block[null]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, IsInvalid, IsImplicit) (Syntax: 'ex + x')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'ex + x')
                      Left: 
                        IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception, IsInvalid) (Syntax: 'ex')
                      Right: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
        Block[B2] - Block [UnReachable]
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x = throw ex + x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'x = throw ex + x')
                      Left: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'throw ex + x')
                          Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (NoConversion)
                          Operand: 
                            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'throw ex + x')
                              Children(1):
                                  IOperation:  (OperationKind.None, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw ex + x')
            Next (Regular) Block[B3]
                Leaving: {R1}
    }
    Block[B3] - Exit [UnReachable]
        Predecessors: [B2]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,11177,11241);

f_22067_11177_11240(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,7299,11252);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,7299,11252);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,7299,11252);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,11264,14403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,11410,11546);

var 
source = @"
class C
{
    void F(int x, System.Exception ex)
    /*<bind>*/{
        x = (throw ex) + x;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,11562,11606);

var 
compilation = f_22067_11580_11605(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,11622,11900);

f_22067_11622_11899(
            compilation, f_22067_11811_11880(f_22067_11811_11860(ErrorCode.ERR_ThrowMisplaced, "throw"), 6, 14));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,11916,14314);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B2] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x = (throw ex) + x;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'x = (throw ex) + x')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '(throw ex) + x')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: '(throw ex) + x')
                          Left: 
                            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'throw ex')
                              Children(1):
                                  IOperation:  (OperationKind.None, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw ex')
                          Right: 
                            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit [UnReachable]
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,14328,14392);

f_22067_14328_14391(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,11264,14403);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,11264,14403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,11264,14403);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,14415,17828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,14561,14695);

var 
source = @"
class C
{
    void F(int x, System.Exception ex)
    /*<bind>*/{
        x = x + throw ex;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,14711,14755);

var 
compilation = f_22067_14729_14754(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,14771,15055);

f_22067_14771_15054(
            compilation, f_22067_14939_15035(f_22067_14939_15015(f_22067_14939_14992(ErrorCode.ERR_InvalidExprTerm, "throw ex"), "throw"), 6, 17));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,15071,17739);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception, IsInvalid) (Syntax: 'ex')
    Block[B2] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x = x + throw ex;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'x = x + throw ex')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'x + throw ex')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'x + throw ex')
                          Left: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                          Right: 
                            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'throw ex')
                              Children(1):
                                  IOperation:  (OperationKind.None, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw ex')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit [UnReachable]
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,17753,17817);

f_22067_17753_17816(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,14415,17828);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,14415,17828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,14415,17828);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,17840,21246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,17986,18122);

var 
source = @"
class C
{
    void F(int x, System.Exception ex)
    /*<bind>*/{
        x = x + (throw ex);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,18138,18182);

var 
compilation = f_22067_18156_18181(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,18198,18476);

f_22067_18198_18475(
            compilation, f_22067_18387_18456(f_22067_18387_18436(ErrorCode.ERR_ThrowMisplaced, "throw"), 6, 18));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,18492,21157);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')

        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B2] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x = x + (throw ex);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'x = x + (throw ex)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'x + (throw ex)')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'x + (throw ex)')
                          Left: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'x')
                          Right: 
                            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'throw ex')
                              Children(1):
                                  IOperation:  (OperationKind.None, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw ex')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit [UnReachable]
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,21171,21235);

f_22067_21171_21234(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,17840,21246);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,17840,21246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,17840,21246);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,21258,23887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,21404,21552);

var 
source = @"
class C
{
    void F(object x, object y, System.Exception ex)
    /*<bind>*/{
        x = y ?? throw ex;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,21568,21612);

var 
compilation = f_22067_21586_21611(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,21628,21660);

f_22067_21628_21659(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,21676,23798);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
              Value: 
                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'y')

        Jump if True (Regular) to Block[B2]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y')
              Operand: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y')

        Next (Regular) Block[B3]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = y ?? throw ex;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'x = y ?? throw ex')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'x')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,23812,23876);

f_22067_23812_23875(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,21258,23887);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,21258,23887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,21258,23887);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,23899,28289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,24045,24261);

var 
source = @"
class C
{
    void F(object x, object y, object z, System.Exception ex)
    /*<bind>*/{
        M(x, y ?? throw ex, z);
    }/*</bind>*/

    static void M(object x, object y, object z){}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,24277,24321);

var 
compilation = f_22067_24295_24320(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,24337,24369);

f_22067_24337_24368(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,24385,28200);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
              Value: 
                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'y')

        Jump if True (Regular) to Block[B2]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y')
              Operand: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y')

        Next (Regular) Block[B3]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M(x, y ?? throw ex, z);')
              Expression: 
                IInvocationOperation (void C.M(System.Object x, System.Object y, System.Object z)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M(x, y ?? throw ex, z)')
                  Instance Receiver: 
                    null
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'x')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'y ?? throw ex')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: z) (OperationKind.Argument, Type: null) (Syntax: 'z')
                        IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'z')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,28214,28278);

f_22067_28214_28277(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,23899,28289);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,23899,28289);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,23899,28289);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,28301,29950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,28447,28698);

var 
source = @"
class C
{
    void F(int u)
    /*<bind>*/{
        try
        {
            u = 1;
        }
        catch
        {
            throw;
        }
    }/*</bind>*/

    static void M(object x, object y, object z){}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,28714,28758);

var 
compilation = f_22067_28732_28757(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,28774,28806);

f_22067_28774_28805(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,28822,29861);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'u = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'u = 1')
                  Left: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'u')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Next (Rethrow) Block[null]
}

Block[B3] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,29875,29939);

f_22067_29875_29938(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,28301,29950);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,28301,29950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,28301,29950);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,29962,33102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,30108,30399);

var 
source = @"
class C
{
    void F(int u)
    /*<bind>*/{
        try
        {
            u = 1;
        }
        catch
        {
            u = 2;
            throw;
            u = 3;
        }
    }/*</bind>*/

    static void M(object x, object y, object z){}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,30415,30459);

var 
compilation = f_22067_30433_30458(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,30475,30720);

f_22067_30475_30719(
            compilation, f_22067_30633_30700(f_22067_30633_30679(ErrorCode.WRN_UnreachableCode, "u"), 14, 13));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,30736,33013);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'u = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'u = 1')
                  Left: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'u')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'u = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'u = 2')
                  Left: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'u')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Rethrow) Block[null]
    Block[B3] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'u = 3;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'u = 3')
                  Left: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'u')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
            Leaving: {R3} {R1}
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,33027,33091);

f_22067_33027_33090(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,29962,33102);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,29962,33102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,29962,33102);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,33114,38362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,33260,33559);

var 
source = @"
class C
{
    void F(object x, object y, object z, int u)
    /*<bind>*/{
        try
        {
            u = 1;
        }
        catch
        {
            M(x, (y ?? throw), z);
        }
    }/*</bind>*/

    static void M(object x, object y, object z){}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,33575,33619);

var 
compilation = f_22067_33593_33618(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,33635,33915);

f_22067_33635_33914(
            compilation, f_22067_33809_33895(f_22067_33809_33874(f_22067_33809_33855(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 12, 29));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,33931,38273);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'u = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'u = 1')
                  Left: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'u')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B8]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    CaptureIds: [0] [2]
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')

        Next (Regular) Block[B3]
            Entering: {R4}

    .locals {R4}
    {
        CaptureIds: [1]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
                  Value: 
                    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'y')

            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y')
                Leaving: {R4}

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsImplicit) (Syntax: 'y')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y')

            Next (Regular) Block[B7]
                Leaving: {R4}
    }

    Block[B5] - Block
        Predecessors: [B3]
        Statements (0)
        Next (Throw) Block[null]
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
    Block[B6] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'throw')
                  Children(1):
                      IOperation:  (OperationKind.None, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw')

        Next (Regular) Block[B7]
    Block[B7] - Block
        Predecessors: [B4] [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'M(x, (y ?? throw), z);')
              Expression: 
                IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'M(x, (y ?? throw), z)')
                  Children(3):
                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'x')
                      IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'y ?? throw')
                      IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'z')

        Next (Regular) Block[B8]
            Leaving: {R3} {R1}
}

Block[B8] - Exit
    Predecessors: [B1] [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,38287,38351);

f_22067_38287_38350(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,33114,38362);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,33114,38362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,33114,38362);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,38374,40210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,38520,38690);

var 
source = @"
class C
{
    void F(System.Exception ex)
    /*<bind>*/{
        ex = null;
        goto label1;
label1:
        throw ex;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,38706,38750);

var 
compilation = f_22067_38724_38749(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,38766,38798);

f_22067_38766_38797(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,38814,40121);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ex = null;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Exception) (Syntax: 'ex = null')
              Left: 
                IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

    Next (Throw) Block[null]
        IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
Block[B2] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,40135,40199);

f_22067_40135_40198(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,38374,40210);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,38374,40210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,38374,40210);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,40222,42413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,40368,40621);

var 
source = @"
class C
{
    void F(int x)
    /*<bind>*/{
        try
        {
            x = 1;
        }
        catch
        {
            x = 2;
            goto label1;
label1:
            throw;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,40637,40681);

var 
compilation = f_22067_40655_40680(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,40697,40729);

f_22067_40697_40728(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,40745,42324);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Rethrow) Block[null]
}

Block[B3] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,42338,42402);

f_22067_42338_42401(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,40222,42413);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,40222,42413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,40222,42413);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,42425,43581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,42571,42736);

var 
source = @"
class C
{
    void F(System.Exception ex, bool a)
    /*<bind>*/{
        if (a) goto label1;
label1:
        throw ex;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,42752,42796);

var 
compilation = f_22067_42770_42795(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,42812,42844);

f_22067_42812_42843(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,42860,43492);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B2]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1*2]
    Statements (0)
    Next (Throw) Block[null]
        IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
Block[B3] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,43506,43570);

f_22067_43506_43569(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,42425,43581);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,42425,43581);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,42425,43581);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,43593,45405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,43739,43987);

var 
source = @"
class C
{
    void F(int x, bool a)
    /*<bind>*/{
        try
        {
            x = 1;
        }
        catch
        {
            if (a) goto label1;
label1:
            throw;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,44003,44047);

var 
compilation = f_22067_44021_44046(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,44063,44095);

f_22067_44063_44094(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,44111,45316);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Jump if False (Rethrow) to Block[null]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Rethrow) Block[null]
}

Block[B3] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,45330,45394);

f_22067_45330_45393(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,43593,45405);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,43593,45405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,43593,45405);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,45417,47026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,45563,45794);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F(System.Exception ex)
    /*<bind>*/{
        {
            int x = 1;
        }

        throw ex;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,45810,45854);

var 
compilation = f_22067_45828_45853(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,45870,45902);

f_22067_45870_45901(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,45918,46937);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'x = 1')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'x = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Throw) Block[null]
        IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
Block[B3] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,46951,47015);

f_22067_46951_47014(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,45417,47026);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,45417,47026);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,45417,47026);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,47038,49426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,47184,47506);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F(int x)
    /*<bind>*/{
        try
        {
            x = 1;
        }
        catch
        {
            {
                int y = 1;
            }

            throw;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,47522,47566);

var 
compilation = f_22067_47540_47565(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,47582,47614);

f_22067_47582_47613(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,47630,49337);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .locals {R4}
    {
        Locals: [System.Int32 y]
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'y = 1')
                  Left: 
                    ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'y = 1')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B3]
                Leaving: {R4}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Next (Rethrow) Block[null]
}

Block[B4] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,49351,49415);

f_22067_49351_49414(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,47038,49426);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,47038,49426);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,47038,49426);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,49438,52107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,49584,49861);

var 
source = @"
class C
{
    void F(System.Exception ex, int x)
    /*<bind>*/{
        try
        {
            x = 1;
        }
        catch
        {
label1:
            throw ex;
            x = 2;
            goto label1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,49877,49921);

var 
compilation = f_22067_49895_49920(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,49937,50182);

f_22067_49937_50181(
            compilation, f_22067_50095_50162(f_22067_50095_50141(ErrorCode.WRN_UnreachableCode, "x"), 14, 13));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,50198,52018);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors: [B3]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B3] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B2]
}

Block[B4] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,52032,52096);

f_22067_52032_52095(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,49438,52107);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,49438,52107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,49438,52107);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_21()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,52119,54646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,52265,52518);

var 
source = @"
class C
{
    void F(int x)
    /*<bind>*/{
        try
        {
            x = 1;
        }
        catch
        {
label1:
            throw;
            x = 2;
            goto label1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,52534,52578);

var 
compilation = f_22067_52552_52577(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,52594,52839);

f_22067_52594_52838(
            compilation, f_22067_52752_52819(f_22067_52752_52798(ErrorCode.WRN_UnreachableCode, "x"), 14, 13));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,52855,54557);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors: [B3]
        Statements (0)
        Next (Rethrow) Block[null]
    Block[B3] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B2]
}

Block[B4] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,54571,54635);

f_22067_54571_54634(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,52119,54646);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,52119,54646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,52119,54646);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_22()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,54658,56101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,54804,55045);

var 
source = @"
class C
{
    int F(bool a, System.Exception ex1, System.Exception ex2)
    /*<bind>*/{
        if (a) throw ex1;
        goto label1;

label1:
        goto label2;
label2:
        throw ex2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,55061,55105);

var 
compilation = f_22067_55079_55104(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,55121,55153);

f_22067_55121_55152(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,55169,56012);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Throw) Block[null]
        IParameterReferenceOperation: ex1 (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex1')
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Throw) Block[null]
        IParameterReferenceOperation: ex2 (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex2')
Block[B4] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,56026,56090);

f_22067_56026_56089(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,54658,56101);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,54658,56101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,54658,56101);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_23()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,56113,58090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,56259,56522);

var 
source = @"
class C
{
    void F(int x, System.Exception ex1, System.Exception ex2, bool a)
    /*<bind>*/{
        x = 1;
        goto label2;
label1:
        if (a) throw ex1;
        throw ex2;
label2:
        goto label1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,56538,56582);

var 
compilation = f_22067_56556_56581(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,56598,56630);

f_22067_56598_56629(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,56646,58001);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Throw) Block[null]
        IParameterReferenceOperation: ex1 (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex1')
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Throw) Block[null]
        IParameterReferenceOperation: ex2 (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex2')
Block[B4] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,58015,58079);

f_22067_58015_58078(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,56113,58090);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,56113,58090);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,56113,58090);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_24()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,58102,60529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,58248,58571);

var 
source = @"
class C
{
    void F(int x, bool a)
    /*<bind>*/{
        try
        {
            x = 1;
        }
        catch
        {
            x = 2;
            goto label2;
label1:
            if (a) throw;
            throw;
label2:
            goto label1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,58587,58631);

var 
compilation = f_22067_58605_58630(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,58647,58679);

f_22067_58647_58678(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,58695,60440);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Jump if False (Rethrow) to Block[null]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Rethrow) Block[null]
}

Block[B3] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,60454,60518);

f_22067_60454_60517(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,58102,60529);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,58102,60529);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,58102,60529);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_25()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,60541,63004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,60687,61011);

var 
source = @"
class C
{
    void F(int x, bool a)
    /*<bind>*/{
        try
        {
            x = 1;
        }
        catch
        {
            x = 2;
            goto label2;
label1:
            if (a) throw;
            return;
label2:
            goto label1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,61027,61071);

var 
compilation = f_22067_61045_61070(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,61087,61119);

f_22067_61087_61118(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,61135,62915);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
            Leaving: {R3} {R1}

        Next (Rethrow) Block[null]
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,62929,62993);

f_22067_62929_62992(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,60541,63004);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,60541,63004);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,60541,63004);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_26()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,63016,65479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,63162,63486);

var 
source = @"
class C
{
    void F(int x, bool a)
    /*<bind>*/{
        try
        {
            x = 1;
        }
        catch
        {
            x = 2;
            goto label2;
label1:
            if (a) return;
            throw;
label2:
            goto label1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,63502,63546);

var 
compilation = f_22067_63520_63545(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,63562,63594);

f_22067_63562_63593(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,63610,65390);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Jump if False (Rethrow) to Block[null]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,65404,65468);

f_22067_65404_65467(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,63016,65479);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,63016,65479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,63016,65479);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_27()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,65491,67383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,65637,65837);

var 
source = @"
class C
{
    void F(int u)
    /*<bind>*/{
        try
        {
            u = 1;
        }
        finally
        {
            throw;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,65853,65897);

var 
compilation = f_22067_65871_65896(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,65913,66209);

f_22067_65913_66208(
            compilation, f_22067_66120_66189(f_22067_66120_66168(ErrorCode.ERR_BadEmptyThrow, "throw"), 12, 13));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,66225,67294);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'u = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'u = 1')
                  Left: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'u')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Next (Rethrow) Block[null]
}

Block[B3] - Exit [UnReachable]
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,67308,67372);

f_22067_67308_67371(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,65491,67383);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,65491,67383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,65491,67383);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_28()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,67395,69165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,67541,67765);

var 
source = @"
class C
{
    void F(int u, System.Exception ex)
    /*<bind>*/{
        try
        {
            u = 1;
        }
        finally
        {
            throw ex;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,67781,67825);

var 
compilation = f_22067_67799_67824(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,67841,67873);

f_22067_67841_67872(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,67889,69076);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'u = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'u = 1')
                  Left: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'u')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
}

Block[B3] - Exit [UnReachable]
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,69090,69154);

f_22067_69090_69153(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,67395,69165);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,67395,69165);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,67395,69165);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_29()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,69177,71777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,69323,69465);

var 
source = @"
class C
{
    void F(System.Exception a, System.Exception b)
    /*<bind>*/{
        throw a ?? b;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,69481,69525);

var 
compilation = f_22067_69499_69524(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,69541,69573);

f_22067_69541_69572(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,69589,71688);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'a')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Exception, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Exception, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Next (Throw) Block[null]
            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Exception, IsImplicit) (Syntax: 'a ?? b')
}

Block[B5] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,71702,71766);

f_22067_71702_71765(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,69177,71777);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,69177,71777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,69177,71777);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_30()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,71789,74023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,71935,72090);

var 
source = @"
class C
{
    void F(bool x, bool y, bool z, System.Exception ex)
    /*<bind>*/{
        x = y ? z : throw ex;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,72106,72150);

var 
compilation = f_22067_72124_72149(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,72166,72198);

f_22067_72166_72197(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,72214,73934);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')

        Jump if False (Regular) to Block[B2]
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')

        Next (Regular) Block[B3]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = y ? z : throw ex;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'x = y ? z : throw ex')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'x')
                  Right: 
                    IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'z')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,73948,74012);

f_22067_73948_74011(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,71789,74023);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,71789,74023);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,71789,74023);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_31()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,74035,76269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,74181,74336);

var 
source = @"
class C
{
    void F(bool x, bool y, bool z, System.Exception ex)
    /*<bind>*/{
        x = y ? throw ex : z;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,74352,74396);

var 
compilation = f_22067_74370_74395(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,74412,74444);

f_22067_74412_74443(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,74460,76180);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = y ? throw ex : z;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'x = y ? throw ex : z')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'x')
                  Right: 
                    IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'z')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,76194,76258);

f_22067_76194_76257(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,74035,76269);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,74035,76269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,74035,76269);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_32_Regular8()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,76281,81909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,76436,76615);

var 
source = @"
class C
{
    void F(bool x, bool y, System.Exception ex1, System.Exception ex2)
    /*<bind>*/{
        x = y ? throw ex1 : throw ex2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,76631,76711);

var 
compilation = f_22067_76649_76710(source, parseOptions: TestOptions.Regular8)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,76727,77178);

f_22067_76727_77177(
            compilation, f_22067_76994_77158(f_22067_76994_77138(f_22067_76994_77078(ErrorCode.ERR_FeatureNotAvailableInVersion8, "y ? throw ex1 : throw ex2"), "target-typed conditional expression", "9.0"), 6, 13));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,77194,79280);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x = y ? thr ...  throw ex2;')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsInvalid) (Syntax: 'x = y ? thr ... : throw ex2')
        Left: 
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')
        Right: 
          IConditionalOperation (OperationKind.Conditional, Type: System.Boolean, IsInvalid) (Syntax: 'y ? throw e ... : throw ex2')
            Condition: 
              IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'y')
            WhenTrue: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'throw ex1')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw ex1')
                    IParameterReferenceOperation: ex1 (OperationKind.ParameterReference, Type: System.Exception, IsInvalid) (Syntax: 'ex1')
            WhenFalse: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'throw ex2')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw ex2')
                    IParameterReferenceOperation: ex2 (OperationKind.ParameterReference, Type: System.Exception, IsInvalid) (Syntax: 'ex2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,79294,79370);

f_22067_79294_79369(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,79386,81820);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'y')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex1 (OperationKind.ParameterReference, Type: System.Exception, IsInvalid) (Syntax: 'ex1')
    Block[B3] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex2 (OperationKind.ParameterReference, Type: System.Exception, IsInvalid) (Syntax: 'ex2')
    Block[B4] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x = y ? thr ...  throw ex2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsInvalid) (Syntax: 'x = y ? thr ... : throw ex2')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'x')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'throw ex2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitThrow)
                      Operand: 
                        IOperation:  (OperationKind.None, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw ex2')
        Next (Regular) Block[B5]
            Leaving: {R1}
}
Block[B5] - Exit [UnReachable]
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,81834,81898);

f_22067_81834_81897(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,76281,81909);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,76281,81909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,76281,81909);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_32_TargetTypedConditional()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,81921,87024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,82090,82269);

var 
source = @"
class C
{
    void F(bool x, bool y, System.Exception ex1, System.Exception ex2)
    /*<bind>*/{
        x = y ? throw ex1 : throw ex2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,82285,82447);

var 
compilation = f_22067_82303_82446(source, parseOptions: f_22067_82343_82445(TestOptions.Regular, f_22067_82383_82444(MessageID.IDS_FeatureTargetTypedConditional)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,82461,82493);

f_22067_82461_82492(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,82507,84472);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = y ? thr ...  throw ex2;')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'x = y ? thr ... : throw ex2')
        Left: 
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')
        Right: 
          IConditionalOperation (OperationKind.Conditional, Type: System.Boolean) (Syntax: 'y ? throw e ... : throw ex2')
            Condition: 
              IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')
            WhenTrue: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsImplicit) (Syntax: 'throw ex1')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw ex1')
                    IParameterReferenceOperation: ex1 (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex1')
            WhenFalse: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsImplicit) (Syntax: 'throw ex2')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw ex2')
                    IParameterReferenceOperation: ex2 (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,84486,84562);

f_22067_84486_84561(compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,84578,86935);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex1 (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex1')
    Block[B3] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex2 (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex2')
    Block[B4] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = y ? thr ...  throw ex2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'x = y ? thr ... : throw ex2')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'x')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsImplicit) (Syntax: 'throw ex2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitThrow)
                      Operand: 
                        IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: 'throw ex2')
        Next (Regular) Block[B5]
            Leaving: {R1}
}
Block[B5] - Exit [UnReachable]
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,86949,87013);

f_22067_86949_87012(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,81921,87024);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,81921,87024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,81921,87024);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_33()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,87036,90948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,87182,87358);

var 
source = @"
class C
{
    void F(object x, bool y, object u, object v, System.Exception ex)
    /*<bind>*/{
        x = y ? (u ?? v) : throw ex;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,87374,87418);

var 
compilation = f_22067_87392_87417(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,87434,87466);

f_22067_87434_87465(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,87482,90859);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')

        Jump if False (Regular) to Block[B5]
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'u')
                  Value: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'u')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'u')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'u')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'u')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'u')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v')
              Value: 
                IParameterReferenceOperation: v (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'v')

        Next (Regular) Block[B6]
    Block[B5] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')
    Block[B6] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = y ? (u  ... : throw ex;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'x = y ? (u  ...  : throw ex')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'x')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'u ?? v')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,90873,90937);

f_22067_90873_90936(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,87036,90948);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,87036,90948);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,87036,90948);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ThrowFlow_34()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22067,90960,94872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,91106,91282);

var 
source = @"
class C
{
    void F(object x, bool y, object u, object v, System.Exception ex)
    /*<bind>*/{
        x = y ? throw ex : (u ?? v);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,91298,91342);

var 
compilation = f_22067_91316_91341(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,91358,91390);

f_22067_91358_91389(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,91406,94783);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')
            Entering: {R2}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IParameterReferenceOperation: ex (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'ex')

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'u')
                  Value: 
                    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'u')

            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'u')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'u')
                Leaving: {R2}

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'u')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'u')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'v')
              Value: 
                IParameterReferenceOperation: v (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'v')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B4] [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = y ? thr ... : (u ?? v);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'x = y ? thr ...  : (u ?? v)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'x')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'u ?? v')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22067,94797,94861);

f_22067_94797_94860(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22067,90960,94872);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22067,90960,94872);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22067,90960,94872);
}
		}

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_803_828(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 803, 828);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_1046_1094(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 1046, 1094);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_1046_1113(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 1046, 1113);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_845_1132(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 845, 1132);
return return_v;
}


int
f_22067_1430_1493(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 1430, 1493);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_1831_1856(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 1831, 1856);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_2074_2122(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 2074, 2122);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_2074_2141(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 2074, 2141);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_2264_2310(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 2264, 2310);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_2264_2329(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 2264, 2329);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_1873_2348(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 1873, 2348);
return return_v;
}


int
f_22067_3777_3840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 3777, 3840);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_4163_4188(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 4163, 4188);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_4205_4236(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 4205, 4236);
return return_v;
}


int
f_22067_4648_4711(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 4648, 4711);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_5070_5095(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 5070, 5095);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_5264_5310(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 5264, 5310);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_5264_5329(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 5264, 5329);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_5488_5538(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 5488, 5538);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_5488_5557(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 5488, 5557);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_5488_5577(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 5488, 5577);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_5112_5596(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 5112, 5596);
return return_v;
}


int
f_22067_7212_7275(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 7212, 7275);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_7613_7638(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 7613, 7638);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_7842_7891(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 7842, 7891);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_7842_7911(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 7842, 7911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_8091_8139(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 8091, 8139);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_8091_8185(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 8091, 8185);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_8091_8205(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 8091, 8205);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_7655_8224(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 7655, 8224);
return return_v;
}


int
f_22067_11177_11240(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 11177, 11240);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_11580_11605(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 11580, 11605);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_11811_11860(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 11811, 11860);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_11811_11880(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 11811, 11880);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_11622_11899(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 11622, 11899);
return return_v;
}


int
f_22067_14328_14391(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 14328, 14391);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_14729_14754(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 14729, 14754);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_14939_14992(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 14939, 14992);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_14939_15015(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 14939, 15015);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_14939_15035(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 14939, 15035);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_14771_15054(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 14771, 15054);
return return_v;
}


int
f_22067_17753_17816(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 17753, 17816);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_18156_18181(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 18156, 18181);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_18387_18436(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 18387, 18436);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_18387_18456(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 18387, 18456);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_18198_18475(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 18198, 18475);
return return_v;
}


int
f_22067_21171_21234(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 21171, 21234);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_21586_21611(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 21586, 21611);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_21628_21659(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 21628, 21659);
return return_v;
}


int
f_22067_23812_23875(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 23812, 23875);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_24295_24320(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 24295, 24320);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_24337_24368(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 24337, 24368);
return return_v;
}


int
f_22067_28214_28277(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 28214, 28277);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_28732_28757(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 28732, 28757);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_28774_28805(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 28774, 28805);
return return_v;
}


int
f_22067_29875_29938(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 29875, 29938);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_30433_30458(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 30433, 30458);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_30633_30679(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 30633, 30679);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_30633_30700(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 30633, 30700);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_30475_30719(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 30475, 30719);
return return_v;
}


int
f_22067_33027_33090(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 33027, 33090);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_33593_33618(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 33593, 33618);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_33809_33855(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 33809, 33855);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_33809_33874(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 33809, 33874);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_33809_33895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 33809, 33895);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_33635_33914(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 33635, 33914);
return return_v;
}


int
f_22067_38287_38350(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 38287, 38350);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_38724_38749(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 38724, 38749);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_38766_38797(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 38766, 38797);
return return_v;
}


int
f_22067_40135_40198(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 40135, 40198);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_40655_40680(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 40655, 40680);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_40697_40728(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 40697, 40728);
return return_v;
}


int
f_22067_42338_42401(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 42338, 42401);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_42770_42795(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 42770, 42795);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_42812_42843(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 42812, 42843);
return return_v;
}


int
f_22067_43506_43569(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 43506, 43569);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_44021_44046(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 44021, 44046);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_44063_44094(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 44063, 44094);
return return_v;
}


int
f_22067_45330_45393(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 45330, 45393);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_45828_45853(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 45828, 45853);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_45870_45901(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 45870, 45901);
return return_v;
}


int
f_22067_46951_47014(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 46951, 47014);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_47540_47565(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 47540, 47565);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_47582_47613(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 47582, 47613);
return return_v;
}


int
f_22067_49351_49414(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 49351, 49414);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_49895_49920(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 49895, 49920);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_50095_50141(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 50095, 50141);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_50095_50162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 50095, 50162);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_49937_50181(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 49937, 50181);
return return_v;
}


int
f_22067_52032_52095(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 52032, 52095);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_52552_52577(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 52552, 52577);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_52752_52798(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 52752, 52798);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_52752_52819(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 52752, 52819);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_52594_52838(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 52594, 52838);
return return_v;
}


int
f_22067_54571_54634(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 54571, 54634);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_55079_55104(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 55079, 55104);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_55121_55152(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 55121, 55152);
return return_v;
}


int
f_22067_56026_56089(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 56026, 56089);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_56556_56581(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 56556, 56581);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_56598_56629(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 56598, 56629);
return return_v;
}


int
f_22067_58015_58078(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 58015, 58078);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_58605_58630(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 58605, 58630);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_58647_58678(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 58647, 58678);
return return_v;
}


int
f_22067_60454_60517(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 60454, 60517);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_61045_61070(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 61045, 61070);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_61087_61118(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 61087, 61118);
return return_v;
}


int
f_22067_62929_62992(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 62929, 62992);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_63520_63545(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 63520, 63545);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_63562_63593(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 63562, 63593);
return return_v;
}


int
f_22067_65404_65467(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 65404, 65467);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_65871_65896(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 65871, 65896);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_66120_66168(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 66120, 66168);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_66120_66189(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 66120, 66189);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_65913_66208(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 65913, 66208);
return return_v;
}


int
f_22067_67308_67371(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 67308, 67371);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_67799_67824(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 67799, 67824);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_67841_67872(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 67841, 67872);
return return_v;
}


int
f_22067_69090_69153(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 69090, 69153);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_69499_69524(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 69499, 69524);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_69541_69572(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 69541, 69572);
return return_v;
}


int
f_22067_71702_71765(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 71702, 71765);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_72124_72149(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 72124, 72149);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_72166_72197(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 72166, 72197);
return return_v;
}


int
f_22067_73948_74011(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 73948, 74011);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_74370_74395(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 74370, 74395);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_74412_74443(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 74412, 74443);
return return_v;
}


int
f_22067_76194_76257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 76194, 76257);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_76649_76710(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 76649, 76710);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_76994_77078(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 76994, 77078);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_76994_77138(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 76994, 77138);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22067_76994_77158(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 76994, 77158);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_76727_77177(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 76727, 77177);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22067_79294_79369(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<BlockSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 79294, 79369);
return return_v;
}


int
f_22067_81834_81897(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 81834, 81897);
return 0;
}


Microsoft.CodeAnalysis.CSharp.LanguageVersion
f_22067_82383_82444(Microsoft.CodeAnalysis.CSharp.MessageID
feature)
{
var return_v = feature.RequiredVersion();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 82383, 82444);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_22067_82343_82445(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param,Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = this_param.WithLanguageVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 82343, 82445);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_82303_82446(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 82303, 82446);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_82461_82492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 82461, 82492);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22067_84486_84561(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<BlockSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 84486, 84561);
return return_v;
}


int
f_22067_86949_87012(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 86949, 87012);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_87392_87417(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 87392, 87417);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_87434_87465(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 87434, 87465);
return return_v;
}


int
f_22067_90873_90936(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 90873, 90936);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_91316_91341(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 91316, 91341);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22067_91358_91389(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 91358, 91389);
return return_v;
}


int
f_22067_94797_94860(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22067, 94797, 94860);
return 0;
}

}
}
