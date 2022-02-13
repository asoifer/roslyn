// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void SimpleReturnFromRegularMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,623,1236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,760,875);

string 
source = @"
class C
{
    static void Method()
    {
        /*<bind>*/return;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,889,1028);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return;')
  ReturnedValue: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,1042,1095);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,1109,1225);

f_22062_1109_1224(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,623,1236);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,623,1236);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,623,1236);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ReturnWithValueFromRegularMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,1248,1968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,1388,1508);

string 
source = @"
class C
{
    static bool Method()
    {
        /*<bind>*/return true;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,1522,1758);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return true;')
  ReturnedValue: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,1772,1825);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,1841,1957);

f_22062_1841_1956(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,1248,1968);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,1248,1968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,1248,1968);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void YieldReturnFromRegularMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,1980,2745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,2116,2286);

string 
source = @"
using System.Collections.Generic;
class C
{
    static IEnumerable<int> Method()
    {
        /*<bind>*/yield return 0;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,2300,2536);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return 0;')
  ReturnedValue: 
    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,2550,2603);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,2619,2734);

f_22062_2619_2733(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,1980,2745);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,1980,2745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,1980,2745);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void YieldBreakFromRegularMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,2757,3455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,2892,3084);

string 
source = @"
using System.Collections.Generic;
class C
{
    static IEnumerable<int> Method()
    {
        yield return 0;
        /*<bind>*/yield break;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,3098,3246);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.YieldBreak, Type: null) (Syntax: 'yield break;')
  ReturnedValue: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,3260,3313);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,3329,3444);

f_22062_3329_3443(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,2757,3455);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,2757,3455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,2757,3455);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(7299, "https://github.com/dotnet/roslyn/issues/7299")]
        public void Return_ConstantConversions_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,3467,4948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,3668,3788);

string 
source = @"
class C
{
    static float Method()
    {
        /*<bind>*/return 0.0;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,3802,4379);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null, IsInvalid) (Syntax: 'return 0.0;')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Single, Constant: 0, IsInvalid, IsImplicit) (Syntax: '0.0')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 0, IsInvalid) (Syntax: '0.0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,4393,4805);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22062_4691_4789(f_22062_4691_4769(f_22062_4691_4741(ErrorCode.ERR_LiteralDoubleCast, "0.0"), "F", "float"), 6, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,4821,4937);

f_22062_4821_4936(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,3467,4948);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,3467,4948);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,3467,4948);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,4960,5578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5107,5205);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
        return;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5221,5265);

var 
compilation = f_22062_5239_5264(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5281,5313);

f_22062_5281_5312(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5329,5489);

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5503,5567);

f_22062_5503_5566(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,4960,5578);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,4960,5578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,4960,5578);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,5590,6399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5737,5836);

var 
source = @"
class C
{
    int F()
    /*<bind>*/{
        return 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5852,5896);

var 
compilation = f_22062_5870_5895(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5912,5944);

f_22062_5912_5943(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,5960,6310);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Next (Return) Block[B2]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,6324,6388);

f_22062_6324_6387(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,5590,6399);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,5590,6399);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,5590,6399);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,6411,7902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,6558,6681);

var 
source = @"
class C
{
    void F(bool a)
    /*<bind>*/{
        return;
        a = true;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,6697,6741);

var 
compilation = f_22062_6715_6740(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,6757,6997);

f_22062_6757_6996(
            compilation, f_22062_6912_6977(f_22062_6912_6958(ErrorCode.WRN_UnreachableCode, "a"), 7, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,7013,7813);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B2]
Block[B1] - Block [UnReachable]
    Predecessors (0)
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B0] [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,7827,7891);

f_22062_7827_7890(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,6411,7902);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,6411,7902);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,6411,7902);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,7914,9596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,8061,8185);

var 
source = @"
class C
{
    int F(bool a)
    /*<bind>*/{
        return 1;
        a = true;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,8201,8245);

var 
compilation = f_22062_8219_8244(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,8261,8501);

f_22062_8261_8500(
            compilation, f_22062_8416_8481(f_22062_8416_8462(ErrorCode.WRN_UnreachableCode, "a"), 7, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,8517,9507);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Next (Return) Block[B3]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B2] - Block [UnReachable]
    Predecessors (0)
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,9521,9585);

f_22062_9521_9584(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,7914,9596);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,7914,9596);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,7914,9596);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,9608,12191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,9755,9880);

var 
source = @"
class C
{
    object F(object a, object b)
    /*<bind>*/{
        return a ?? b;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,9896,9940);

var 
compilation = f_22062_9914_9939(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,9956,9988);

f_22062_9956_9987(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,10004,12102);

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
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'a')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Next (Return) Block[B5]
            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a ?? b')
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,12116,12180);

f_22062_12116_12179(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,9608,12191);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,9608,12191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,9608,12191);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,12203,13563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,12350,12556);

var 
source = @"
class C
{
    int F(bool a)
    /*<bind>*/{
        if (a)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,12572,12616);

var 
compilation = f_22062_12590_12615(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,12632,12664);

f_22062_12632_12663(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,12680,13474);

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
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,13488,13552);

f_22062_13488_13551(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,12203,13563);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,12203,13563);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,12203,13563);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,13575,15177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,13722,13927);

var 
source = @"
class C
{
    void F(bool a)
    /*<bind>*/{
        if (a)
        {
            return;
        }
        else
        {
            a = true;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,13943,13987);

var 
compilation = f_22062_13961_13986(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,14003,14035);

f_22062_14003_14034(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,14051,15088);

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

    Next (Regular) Block[B3]
Block[B2] - Block
    Predecessors: [B1]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,15102,15166);

f_22062_15102_15165(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,13575,15177);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,13575,15177);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,13575,15177);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,15189,17347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,15336,15563);

var 
source = @"
class C
{
    void F(bool a)
    /*<bind>*/{
        if (a)
        {
            a = false;
        }
        else
        {
            return;
        }

        a = true;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,15579,15623);

var 
compilation = f_22062_15597_15622(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,15639,15671);

f_22062_15639_15670(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,15687,17258);

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
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = false')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,17272,17336);

f_22062_17272_17335(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,15189,17347);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,15189,17347);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,15189,17347);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,17359,19809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,17506,17742);

var 
source = @"
class C
{
    int F(bool a, bool b)
    /*<bind>*/{
        if (a)
        {
            b = false;
        }
        else
        {
            b = true;
        }

        return 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,17758,17802);

var 
compilation = f_22062_17776_17801(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,17818,17850);

f_22062_17818_17849(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,17866,19720);

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
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = false')
              Left: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B4]
Block[B3] - Block
    Predecessors: [B1]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
              Left: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B2] [B3]
    Statements (0)
    Next (Return) Block[B5]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,19734,19798);

f_22062_19734_19797(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,17359,19809);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,17359,19809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,17359,19809);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,19821,21069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,19968,20086);

var 
source = @"
class C
{
    int F()
    /*<bind>*/{
        return 1;
        return 2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,20102,20146);

var 
compilation = f_22062_20120_20145(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,20162,20407);

f_22062_20162_20406(
            compilation, f_22062_20317_20387(f_22062_20317_20368(ErrorCode.WRN_UnreachableCode, "return"), 7, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,20423,20980);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Next (Return) Block[B3]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B2] - Block [UnReachable]
    Predecessors (0)
    Statements (0)
    Next (Return) Block[B3]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,20994,21058);

f_22062_20994_21057(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,19821,21069);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,19821,21069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,19821,21069);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,21081,21927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,21228,21343);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
        return;
        return;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,21359,21403);

var 
compilation = f_22062_21377_21402(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,21419,21662);

f_22062_21419_21661(
            compilation, f_22062_21572_21642(f_22062_21572_21623(ErrorCode.WRN_UnreachableCode, "return"), 7, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,21678,21838);

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,21852,21916);

f_22062_21852_21915(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,21081,21927);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,21081,21927);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,21081,21927);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,21939,24013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,22086,22268);

var 
source = @"
class C
{
    int F(int a)
    /*<bind>*/{
        
        {
            int b = 0;
            a = b;
        }

        return 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,22284,22328);

var 
compilation = f_22062_22302_22327(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,22344,22376);

f_22062_22344_22375(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,22392,23924);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 b]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = 0')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = b')
                  Left: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
                  Right: 
                    ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Return) Block[B3]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,23938,24002);

f_22062_23938_24001(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,21939,24013);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,21939,24013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,21939,24013);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,24025,26386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,24172,24392);

var 
source = @"
class C
{
    int F(int a)
    /*<bind>*/{
        a = 0;

        try
        {
            return 1;
        }
        finally
        {
            a = 2;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,24408,24452);

var 
compilation = f_22062_24426_24451(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,24468,24500);

f_22062_24468_24499(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,24516,26297);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 0;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 0')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

    Next (Regular) Block[B2]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Return) Block[B4]
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 2')
                  Left: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (StructuredExceptionHandling) Block[null]
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,26311,26375);

f_22062_26311_26374(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,24025,26386);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,24025,26386);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,24025,26386);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,26398,28220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,26545,26743);

var 
source = @"
class C
{
    int F(int a)
    /*<bind>*/{
        try
        {
            a = 2;
        }
        catch
        {
        }

        return 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,26759,26803);

var 
compilation = f_22062_26777_26802(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,26819,26851);

f_22062_26819_26850(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,26867,28131);

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 2')
                  Left: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Block
    Predecessors: [B1] [B2]
    Statements (0)
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,28145,28209);

f_22062_28145_28208(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,26398,28220);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,26398,28220);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,26398,28220);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,28232,30617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,28379,28599);

var 
source = @"
class C
{
    int F(int a)
    /*<bind>*/{
        try
        {
            a = 2;
        }
        finally
        {
            a = 3;
        }

        return 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,28615,28659);

var 
compilation = f_22062_28633_28658(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,28675,28707);

f_22062_28675_28706(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,28723,30528);

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 2')
                  Left: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 3;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 3')
                  Left: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (StructuredExceptionHandling) Block[null]
}

Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,30542,30606);

f_22062_30542_30605(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,28232,30617);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,28232,30617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,28232,30617);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,30629,31753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,30776,30937);

var 
source = @"
class C
{
    int F(bool a)
    /*<bind>*/{
        do
        {
        }
        while (a);

        return 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,30953,30997);

var 
compilation = f_22062_30971_30996(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,31013,31045);

f_22062_31013_31044(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,31061,31664);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B1]
    Statements (0)
    Jump if True (Regular) to Block[B1]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Return) Block[B3]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,31678,31742);

f_22062_31678_31741(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,30629,31753);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,30629,31753);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,30629,31753);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,31765,33114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,31912,32107);

var 
source = @"
class C
{
    int F(bool a)
    /*<bind>*/{
        if (a) return 1;
        goto label1;

label1:
        goto label2;
label2:
        return 2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,32123,32167);

var 
compilation = f_22062_32141_32166(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,32183,32215);

f_22062_32183_32214(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,32231,33025);

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
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,33039,33103);

f_22062_33039_33102(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,31765,33114);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,31765,33114);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,31765,33114);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ReturnFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,33126,35022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,33273,33485);

var 
source = @"
class C
{
    int F(bool a)
    /*<bind>*/{
        a = true;
        goto label1;
label2:
        if (a) return 1;
        return 2;
label1:
        goto label2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,33501,33545);

var 
compilation = f_22062_33519_33544(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,33561,33593);

f_22062_33561_33592(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,33609,34933);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,34947,35011);

f_22062_34947_35010(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,33126,35022);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,33126,35022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,33126,35022);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,35034,35695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,35180,35322);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F()
    /*<bind>*/{
        yield break;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,35338,35382);

var 
compilation = f_22062_35356_35381(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,35398,35430);

f_22062_35398_35429(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,35446,35606);

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,35620,35684);

f_22062_35620_35683(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,35034,35695);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,35034,35695);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,35034,35695);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,35707,36689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,35853,35998);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F()
    /*<bind>*/{
        yield return 1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,36014,36058);

var 
compilation = f_22062_36032_36057(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,36074,36106);

f_22062_36074_36105(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,36122,36600);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return 1;')
          ReturnedValue: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,36614,36678);

f_22062_36614_36677(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,35707,36689);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,35707,36689);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,35707,36689);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,36701,38235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,36847,37014);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F(bool a)
    /*<bind>*/{
        yield break;
        a = true;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,37030,37074);

var 
compilation = f_22062_37048_37073(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,37090,37330);

f_22062_37090_37329(
            compilation, f_22062_37245_37310(f_22062_37245_37291(ErrorCode.WRN_UnreachableCode, "a"), 7, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,37346,38146);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B2]
Block[B1] - Block [UnReachable]
    Predecessors (0)
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B0] [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,38160,38224);

f_22062_38160_38223(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,36701,38235);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,36701,38235);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,36701,38235);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,38247,39784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,38393,38563);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F(bool a)
    /*<bind>*/{
        yield return 1;
        a = true;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,38579,38623);

var 
compilation = f_22062_38597_38622(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,38639,38671);

f_22062_38639_38670(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,38687,39695);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return 1;')
          ReturnedValue: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,39709,39773);

f_22062_39709_39772(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,38247,39784);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,38247,39784);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,38247,39784);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,39796,42565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,39942,40113);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<object> F(object a, object b)
    /*<bind>*/{
        yield return a ?? b;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,40129,40173);

var 
compilation = f_22062_40147_40172(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,40189,40221);

f_22062_40189_40220(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,40237,42476);

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
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'a')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return a ?? b;')
              ReturnedValue: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,42490,42554);

f_22062_42490_42553(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,39796,42565);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,39796,42565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,39796,42565);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,42577,44244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,42723,42981);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F(bool a)
    /*<bind>*/{
        if (a)
        {
            yield return 1;
        }
        else
        {
            yield return 2;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,42997,43041);

var 
compilation = f_22062_43015_43040(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,43057,43089);

f_22062_43057_43088(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,43105,44155);

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
    Statements (1)
        IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return 1;')
          ReturnedValue: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B4]
Block[B3] - Block
    Predecessors: [B1]
    Statements (1)
        IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return 2;')
          ReturnedValue: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

    Next (Regular) Block[B4]
Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,44169,44233);

f_22062_44169_44232(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,42577,44244);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,42577,44244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,42577,44244);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,44256,45901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,44402,44651);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F(bool a)
    /*<bind>*/{
        if (a)
        {
            yield break;
        }
        else
        {
            a = true;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,44667,44711);

var 
compilation = f_22062_44685_44710(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,44727,44759);

f_22062_44727_44758(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,44775,45812);

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

    Next (Regular) Block[B3]
Block[B2] - Block
    Predecessors: [B1]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,45826,45890);

f_22062_45826_45889(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,44256,45901);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,44256,45901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,44256,45901);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,45913,48114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,46059,46330);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F(bool a)
    /*<bind>*/{
        if (a)
        {
            a = false;
        }
        else
        {
            yield break;
        }

        a = true;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,46346,46390);

var 
compilation = f_22062_46364_46389(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,46406,46438);

f_22062_46406_46437(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,46454,48025);

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
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = false')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,48039,48103);

f_22062_48039_48102(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,45913,48114);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,45913,48114);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,45913,48114);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,48126,49358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,48272,48442);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F()
    /*<bind>*/{
        yield return 1;
        yield return 2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,48458,48502);

var 
compilation = f_22062_48476_48501(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,48518,48550);

f_22062_48518_48549(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,48566,49269);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return 1;')
          ReturnedValue: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return 2;')
          ReturnedValue: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,49283,49347);

f_22062_49283_49346(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,48126,49358);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,48126,49358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,48126,49358);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void YieldFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22062,49370,50268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,49516,49680);

var 
source = @"
class C
{
    System.Collections.Generic.IEnumerable<int> F()
    /*<bind>*/{
        yield break;
        yield break;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,49696,49740);

var 
compilation = f_22062_49714_49739(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,49756,50003);

f_22062_49756_50002(
            compilation, f_22062_49914_49983(f_22062_49914_49964(ErrorCode.WRN_UnreachableCode, "yield"), 7, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,50019,50179);

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22062,50193,50257);

f_22062_50193_50256(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22062,49370,50268);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22062,49370,50268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22062,49370,50268);
}
		}

int
f_22062_1109_1224(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 1109, 1224);
return 0;
}


int
f_22062_1841_1956(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 1841, 1956);
return 0;
}


int
f_22062_2619_2733(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<YieldStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 2619, 2733);
return 0;
}


int
f_22062_3329_3443(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<YieldStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 3329, 3443);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_4691_4741(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 4691, 4741);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_4691_4769(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 4691, 4769);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_4691_4789(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 4691, 4789);
return return_v;
}


int
f_22062_4821_4936(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 4821, 4936);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_5239_5264(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 5239, 5264);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_5281_5312(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 5281, 5312);
return return_v;
}


int
f_22062_5503_5566(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 5503, 5566);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_5870_5895(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 5870, 5895);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_5912_5943(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 5912, 5943);
return return_v;
}


int
f_22062_6324_6387(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 6324, 6387);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_6715_6740(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 6715, 6740);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_6912_6958(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 6912, 6958);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_6912_6977(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 6912, 6977);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_6757_6996(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 6757, 6996);
return return_v;
}


int
f_22062_7827_7890(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 7827, 7890);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_8219_8244(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 8219, 8244);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_8416_8462(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 8416, 8462);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_8416_8481(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 8416, 8481);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_8261_8500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 8261, 8500);
return return_v;
}


int
f_22062_9521_9584(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 9521, 9584);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_9914_9939(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 9914, 9939);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_9956_9987(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 9956, 9987);
return return_v;
}


int
f_22062_12116_12179(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 12116, 12179);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_12590_12615(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 12590, 12615);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_12632_12663(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 12632, 12663);
return return_v;
}


int
f_22062_13488_13551(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 13488, 13551);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_13961_13986(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 13961, 13986);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_14003_14034(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 14003, 14034);
return return_v;
}


int
f_22062_15102_15165(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 15102, 15165);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_15597_15622(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 15597, 15622);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_15639_15670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 15639, 15670);
return return_v;
}


int
f_22062_17272_17335(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 17272, 17335);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_17776_17801(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 17776, 17801);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_17818_17849(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 17818, 17849);
return return_v;
}


int
f_22062_19734_19797(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 19734, 19797);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_20120_20145(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 20120, 20145);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_20317_20368(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 20317, 20368);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_20317_20387(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 20317, 20387);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_20162_20406(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 20162, 20406);
return return_v;
}


int
f_22062_20994_21057(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 20994, 21057);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_21377_21402(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 21377, 21402);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_21572_21623(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 21572, 21623);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_21572_21642(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 21572, 21642);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_21419_21661(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 21419, 21661);
return return_v;
}


int
f_22062_21852_21915(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 21852, 21915);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_22302_22327(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 22302, 22327);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_22344_22375(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 22344, 22375);
return return_v;
}


int
f_22062_23938_24001(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 23938, 24001);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_24426_24451(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 24426, 24451);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_24468_24499(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 24468, 24499);
return return_v;
}


int
f_22062_26311_26374(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 26311, 26374);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_26777_26802(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 26777, 26802);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_26819_26850(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 26819, 26850);
return return_v;
}


int
f_22062_28145_28208(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 28145, 28208);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_28633_28658(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 28633, 28658);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_28675_28706(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 28675, 28706);
return return_v;
}


int
f_22062_30542_30605(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 30542, 30605);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_30971_30996(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 30971, 30996);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_31013_31044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 31013, 31044);
return return_v;
}


int
f_22062_31678_31741(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 31678, 31741);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_32141_32166(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 32141, 32166);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_32183_32214(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 32183, 32214);
return return_v;
}


int
f_22062_33039_33102(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 33039, 33102);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_33519_33544(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 33519, 33544);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_33561_33592(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 33561, 33592);
return return_v;
}


int
f_22062_34947_35010(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 34947, 35010);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_35356_35381(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 35356, 35381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_35398_35429(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 35398, 35429);
return return_v;
}


int
f_22062_35620_35683(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 35620, 35683);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_36032_36057(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 36032, 36057);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_36074_36105(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 36074, 36105);
return return_v;
}


int
f_22062_36614_36677(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 36614, 36677);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_37048_37073(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 37048, 37073);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_37245_37291(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 37245, 37291);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_37245_37310(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 37245, 37310);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_37090_37329(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 37090, 37329);
return return_v;
}


int
f_22062_38160_38223(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 38160, 38223);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_38597_38622(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 38597, 38622);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_38639_38670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 38639, 38670);
return return_v;
}


int
f_22062_39709_39772(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 39709, 39772);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_40147_40172(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 40147, 40172);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_40189_40220(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 40189, 40220);
return return_v;
}


int
f_22062_42490_42553(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 42490, 42553);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_43015_43040(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 43015, 43040);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_43057_43088(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 43057, 43088);
return return_v;
}


int
f_22062_44169_44232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 44169, 44232);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_44685_44710(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 44685, 44710);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_44727_44758(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 44727, 44758);
return return_v;
}


int
f_22062_45826_45889(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 45826, 45889);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_46364_46389(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 46364, 46389);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_46406_46437(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 46406, 46437);
return return_v;
}


int
f_22062_48039_48102(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 48039, 48102);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_48476_48501(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 48476, 48501);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_48518_48549(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 48518, 48549);
return return_v;
}


int
f_22062_49283_49346(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 49283, 49346);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_49714_49739(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 49714, 49739);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_49914_49964(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 49914, 49964);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22062_49914_49983(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 49914, 49983);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22062_49756_50002(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 49756, 50002);
return return_v;
}


int
f_22062_50193_50256(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22062, 50193, 50256);
return 0;
}

}
}
