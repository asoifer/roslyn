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
        public void TestAwaitExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,524,1434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,651,837);

string 
source = @"
using System.Threading.Tasks;

class C
{
    static async Task M()
    {
        /*<bind>*/await M2()/*</bind>*/;
    }

    static Task M2() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,851,1188);

string 
expectedOperationTree = @"
IAwaitOperation (OperationKind.Await, Type: System.Void) (Syntax: 'await M2()')
  Expression: 
    IInvocationOperation (System.Threading.Tasks.Task C.M2()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task) (Syntax: 'M2()')
      Instance Receiver: 
        null
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,1202,1255);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,1271,1423);

f_22008_1271_1422(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,524,1434);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,524,1434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,524,1434);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestAwaitExpression_ParameterReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,1446,2260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,1592,1748);

string 
source = @"
using System.Threading.Tasks;

class C
{
    static async Task M(Task t)
    {
        /*<bind>*/await t/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,1762,2014);

string 
expectedOperationTree = @"
IAwaitOperation (OperationKind.Await, Type: System.Void) (Syntax: 'await t')
  Expression: 
    IParameterReferenceOperation: t (OperationKind.ParameterReference, Type: System.Threading.Tasks.Task) (Syntax: 't')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,2028,2081);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,2097,2249);

f_22008_2097_2248(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,1446,2260);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,1446,2260);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,1446,2260);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestAwaitExpression_InLambda()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,2272,3158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,2408,2631);

string 
source = @"
using System;
using System.Threading.Tasks;

class C
{
    static async Task M(Task<int> t)
    {
        Func<Task> f = async () => /*<bind>*/await t/*</bind>*/;
        await f();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,2645,2912);

string 
expectedOperationTree = @"
IAwaitOperation (OperationKind.Await, Type: System.Int32) (Syntax: 'await t')
  Expression: 
    IParameterReferenceOperation: t (OperationKind.ParameterReference, Type: System.Threading.Tasks.Task<System.Int32>) (Syntax: 't')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,2926,2979);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,2995,3147);

f_22008_2995_3146(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,2272,3158);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,2272,3158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,2272,3158);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestAwaitExpression_ErrorArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,3170,4311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,3311,3488);

string 
source = @"
using System;
using System.Threading.Tasks;

class C
{
    static async Task M()
    {
        /*<bind>*/await UndefinedTask/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,3502,3758);

string 
expectedOperationTree = @"
IAwaitOperation (OperationKind.Await, Type: ?, IsInvalid) (Syntax: 'await UndefinedTask')
  Expression: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'UndefinedTask')
      Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,3772,4132);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22008_4006_4116(f_22008_4006_4096(f_22008_4006_4065(ErrorCode.ERR_NameNotInContext, "UndefinedTask"), "UndefinedTask"), 9, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,4148,4300);

f_22008_4148_4299(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,3170,4311);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,3170,4311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,3170,4311);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestAwaitExpression_ValueArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,4323,5588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,4464,4634);

string 
source = @"
using System;
using System.Threading.Tasks;

class C
{
    static async Task M(int i)
    {
        /*<bind>*/await i/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,4648,4897);

string 
expectedOperationTree = @"
IAwaitOperation (OperationKind.Await, Type: ?, IsInvalid) (Syntax: 'await i')
  Expression: 
    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,4911,5409);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22008_5278_5393(f_22008_5278_5373(f_22008_5278_5338(ErrorCode.ERR_NoSuchMemberOrExtension, "await i"), "int", "GetAwaiter"), 9, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,5425,5577);

f_22008_5425_5576(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,4323,5588);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,4323,5588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,4323,5588);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestAwaitExpression_MissingArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,5600,6645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,5743,5907);

string 
source = @"
using System;
using System.Threading.Tasks;

class C
{
    static async Task M()
    {
        /*<bind>*/await /*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,5921,6165);

string 
expectedOperationTree = @"
IAwaitOperation (OperationKind.Await, Type: ?, IsInvalid) (Syntax: 'await /*</bind>*/')
  Expression: 
    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
      Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,6179,6466);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22008_6365_6450(f_22008_6365_6430(f_22008_6365_6411(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 9, 36)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,6482,6634);

f_22008_6482_6633(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,5600,6645);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,5600,6645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,5600,6645);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestAwaitExpression_NonAsyncMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,6657,8681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,6799,6969);

string 
source = @"
using System;
using System.Threading.Tasks;

class C
{
    static void M(Task<int> t)
    {
        /*<bind>*/await t;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,6983,7506);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'await t;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'await t')
    Declarators:
        IVariableDeclaratorOperation (Symbol: await t) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 't')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,7520,8492);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22008_7795_7895(f_22008_7795_7875(f_22008_7795_7852(ErrorCode.ERR_SingleTypeNameNotFound, "await"), "await"), 9, 19),
f_22008_8149_8242(f_22008_8149_8222(f_22008_8149_8203(ErrorCode.ERR_LocalIllegallyOverrides, "t"), "t"), 9, 25),
f_22008_8391_8476(f_22008_8391_8456(f_22008_8391_8437(ErrorCode.WRN_UnreferencedVar, "t"), "t"), 9, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,8508,8670);

f_22008_8508_8669(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,6657,8681);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,6657,8681);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,6657,8681);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.AsyncStreams)]
        [Fact]
        public void AwaitFlow_AsyncIterator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,8693,11213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,8880,9136);

string 
source = @"
using System.Threading.Tasks;

class C
{
    static async System.Collections.Generic.IAsyncEnumerable<int> M()
    /*<bind>*/{
        await M2();
        yield return 42;
    }/*</bind>*/

    static Task M2() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,9150,10059);

var 
expectedDiagnostics = new[] {
f_22008_9474_9621(f_22008_9474_9600(f_22008_9474_9545(ErrorCode.ERR_DottedTypeNameNotFoundInNS, "ValueTask<bool>"), "ValueTask<>", "System.Threading.Tasks"), 24, 32),
f_22008_9904_10043(f_22008_9904_10022(f_22008_9904_9969(ErrorCode.ERR_DottedTypeNameNotFoundInNS, "ValueTask"), "ValueTask", "System.Threading.Tasks"), 32, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,10075,11069);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'await M2();')
          Expression: 
            IAwaitOperation (OperationKind.Await, Type: System.Void) (Syntax: 'await M2()')
              Expression: 
                IInvocationOperation (System.Threading.Tasks.Task C.M2()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        IReturnOperation (OperationKind.YieldReturn, Type: null) (Syntax: 'yield return 42;')
          ReturnedValue: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42) (Syntax: '42')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,11083,11202);

f_22008_11083_11201(source + s_IAsyncEnumerable, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,8693,11213);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,8693,11213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,8693,11213);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AwaitFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,11225,12531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,11371,11559);

string 
source = @"
using System.Threading.Tasks;

class C
{
    static async Task M()
    /*<bind>*/{

        await M2();
    }/*</bind>*/

    static Task M2() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,11573,11626);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,11642,12408);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'await M2();')
          Expression: 
            IAwaitOperation (OperationKind.Await, Type: System.Void) (Syntax: 'await M2()')
              Expression: 
                IInvocationOperation (System.Threading.Tasks.Task C.M2()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,12422,12520);

f_22008_12422_12519(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,11225,12531);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,11225,12531);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,11225,12531);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AwaitFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,12543,17301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,12689,12942);

string 
source = @"
using System.Threading.Tasks;

class C
{
    static async Task M(bool b, int i)
    /*<bind>*/{

        i = b ? await M2(2) : await M2(3);
    }/*</bind>*/

    static Task<int> M2(int i) => Task.FromResult<int>(i);
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,12956,13009);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,13025,17178);

string 
expectedFlowGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'await M2(2)')
              Value: 
                IAwaitOperation (OperationKind.Await, Type: System.Int32) (Syntax: 'await M2(2)')
                  Expression: 
                    IInvocationOperation (System.Threading.Tasks.Task<System.Int32> C.M2(System.Int32 i)) (OperationKind.Invocation, Type: System.Threading.Tasks.Task<System.Int32>) (Syntax: 'M2(2)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '2')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'await M2(3)')
              Value: 
                IAwaitOperation (OperationKind.Await, Type: System.Int32) (Syntax: 'await M2(3)')
                  Expression: 
                    IInvocationOperation (System.Threading.Tasks.Task<System.Int32> C.M2(System.Int32 i)) (OperationKind.Invocation, Type: System.Threading.Tasks.Task<System.Int32>) (Syntax: 'M2(3)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '3')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = b ? awa ... wait M2(3);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = b ? awa ... await M2(3)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? await M ... await M2(3)')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,17192,17290);

f_22008_17192_17289(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,12543,17301);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,12543,17301);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,12543,17301);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void AwaitFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22008,17313,21129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,17459,17702);

string 
source = @"
using System.Threading.Tasks;

class C
{
    static async Task M(bool b, int i)
    /*<bind>*/{

        i = await M2(b ? 2 : 3);
    }/*</bind>*/

    static Task<int> M2(int i) => Task.FromResult<int>(i);
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,17716,17769);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,17785,21006);

string 
expectedFlowGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = await M2(b ? 2 : 3);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = await M2(b ? 2 : 3)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IAwaitOperation (OperationKind.Await, Type: System.Int32) (Syntax: 'await M2(b ? 2 : 3)')
                      Expression: 
                        IInvocationOperation (System.Threading.Tasks.Task<System.Int32> C.M2(System.Int32 i)) (OperationKind.Invocation, Type: System.Threading.Tasks.Task<System.Int32>) (Syntax: 'M2(b ? 2 : 3)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'b ? 2 : 3')
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22008,21020,21118);

f_22008_21020_21117(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22008,17313,21129);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22008,17313,21129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22008,17313,21129);
}
		}

int
f_22008_1271_1422(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<AwaitExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 1271, 1422);
return 0;
}


int
f_22008_2097_2248(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<AwaitExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 2097, 2248);
return 0;
}


int
f_22008_2995_3146(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<AwaitExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 2995, 3146);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_4006_4065(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 4006, 4065);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_4006_4096(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 4006, 4096);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_4006_4116(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 4006, 4116);
return return_v;
}


int
f_22008_4148_4299(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<AwaitExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 4148, 4299);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_5278_5338(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 5278, 5338);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_5278_5373(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 5278, 5373);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_5278_5393(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 5278, 5393);
return return_v;
}


int
f_22008_5425_5576(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<AwaitExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 5425, 5576);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_6365_6411(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 6365, 6411);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_6365_6430(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 6365, 6430);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_6365_6450(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 6365, 6450);
return return_v;
}


int
f_22008_6482_6633(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<AwaitExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 6482, 6633);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_7795_7852(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 7795, 7852);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_7795_7875(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 7795, 7875);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_7795_7895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 7795, 7895);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_8149_8203(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 8149, 8203);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_8149_8222(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 8149, 8222);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_8149_8242(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 8149, 8242);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_8391_8437(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 8391, 8437);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_8391_8456(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 8391, 8456);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_8391_8476(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 8391, 8476);
return return_v;
}


int
f_22008_8508_8669(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 8508, 8669);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_9474_9545(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 9474, 9545);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_9474_9600(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 9474, 9600);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_9474_9621(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 9474, 9621);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_9904_9969(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 9904, 9969);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_9904_10022(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 9904, 10022);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22008_9904_10043(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 9904, 10043);
return return_v;
}


int
f_22008_11083_11201(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 11083, 11201);
return 0;
}


int
f_22008_12422_12519(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 12422, 12519);
return 0;
}


int
f_22008_17192_17289(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 17192, 17289);
return 0;
}


int
f_22008_21020_21117(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22008, 21020, 21117);
return 0;
}

}
}
