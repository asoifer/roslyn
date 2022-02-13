// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IInvocation_StaticMethodWithInstanceReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,471,1604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,623,795);

string 
source = @"
class C
{
    static void M1() { }

    public static void M2()
    {
        var c = new C();
        /*<bind>*/c.M1()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,809,1054);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'c.M1()')
  Children(1):
      ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,1068,1456);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22042_1346_1440(f_22042_1346_1420(f_22042_1346_1396(ErrorCode.ERR_ObjectProhibited, "c.M1"), "C.M1()"), 9, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,1472,1593);

f_22042_1472_1592(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,471,1604);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,471,1604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,471,1604);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IInvocation_StaticMethodAccessOnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,1616,2322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,1760,1906);

string 
source = @"
class C
{
    static void M1() { }

    public static void M2()
    {
        /*<bind>*/C.M1()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,1920,2107);

string 
expectedOperationTree = @"
IInvocationOperation (void C.M1()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'C.M1()')
  Instance Receiver: 
    null
  Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,2121,2174);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,2190,2311);

f_22042_2190_2310(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,1616,2322);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,1616,2322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,1616,2322);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IInvocation_InstanceMethodAccessOnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,2334,3392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,2480,2619);

string 
source = @"
class C
{
    void M1() { }

    public static void M2()
    {
        /*<bind>*/C.M1()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,2633,2856);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'C.M1()')
  Children(1):
      IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'C')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,2870,3244);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22042_3136_3228(f_22042_3136_3208(f_22042_3136_3184(ErrorCode.ERR_ObjectRequired, "C.M1"), "C.M1()"), 8, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,3260,3381);

f_22042_3260_3380(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,2334,3392);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,2334,3392);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,2334,3392);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,3404,8622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,3555,3788);

string 
source = @"
public class MyClass
{
    void M(bool b, object o1, object o2, object o3, object o4)
    /*<bind>*/{
        M2(o1, o2, b ? o3 : o4);
    }/*</bind>*/
    void M2(object o1, object o2, object o3) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,3802,3855);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,3871,8499);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass, IsImplicit) (Syntax: 'M2')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
              Value: 
                IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
              Value: 
                IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
              Value: 
                IParameterReferenceOperation: o4 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(o1, o2, b ? o3 : o4);')
              Expression: 
                IInvocationOperation ( void MyClass.M2(System.Object o1, System.Object o2, System.Object o3)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(o1, o2, b ? o3 : o4)')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'M2')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o1')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'o2')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o3) (OperationKind.Argument, Type: null) (Syntax: 'b ? o3 : o4')
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'b ? o3 : o4')
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,8513,8611);

f_22042_8513_8610(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,3404,8622);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,3404,8622);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,3404,8622);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,8634,13455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,8785,9025);

string 
source = @"
public class MyClass
{
    void M(bool b, object o1, object o2, object o3, object o4)
    /*<bind>*/{
        M2(o1, o2, b ? o3 : o4);
    }/*</bind>*/
    static void M2(object o1, object o2, object o3) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,9039,9092);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,9108,13332);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
              Value: 
                IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
              Value: 
                IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
              Value: 
                IParameterReferenceOperation: o4 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o4')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(o1, o2, b ? o3 : o4);')
              Expression: 
                IInvocationOperation (void MyClass.M2(System.Object o1, System.Object o2, System.Object o3)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(o1, o2, b ? o3 : o4)')
                  Instance Receiver: 
                    null
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'o2')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o3) (OperationKind.Argument, Type: null) (Syntax: 'b ? o3 : o4')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'b ? o3 : o4')
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,13346,13444);

f_22042_13346_13443(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,8634,13455);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,8634,13455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,8634,13455);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,13467,15906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,13618,13780);

string 
source = @"
public class MyClass
{
    void M(bool b, object o1, object o2)
    /*<bind>*/{
        (b ? o1 : o2).ToString();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,13794,13847);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,13863,15783);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
              Value: 
                IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(b ? o1 : o ... ToString();')
              Expression: 
                IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '(b ? o1 : o2).ToString()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'b ? o1 : o2')
                  Arguments(0)

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,15797,15895);

f_22042_15797_15894(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,13467,15906);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,13467,15906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,13467,15906);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,15920,21169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,16071,16316);

string 
source = @"
public class MyClass
{
    void M(bool b, object o1, object o2, object o3, object o4)
    /*<bind>*/{
        M2(o2: o3, o3: o4, o1: b ? o1 : o2);
    }/*</bind>*/
    void M2(object o1, object o2, object o3) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,16330,16383);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,16399,21046);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass, IsImplicit) (Syntax: 'M2')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
              Value: 
                IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
              Value: 
                IParameterReferenceOperation: o4 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o4')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
              Value: 
                IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(o2: o3,  ... ? o1 : o2);')
              Expression: 
                IInvocationOperation ( void MyClass.M2(System.Object o1, System.Object o2, System.Object o3)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(o2: o3,  ...  ? o1 : o2)')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'M2')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'o2: o3')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o3) (OperationKind.Argument, Type: null) (Syntax: 'o3: o4')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o1: b ? o1 : o2')
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'b ? o1 : o2')
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,21060,21158);

f_22042_21060_21157(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,15920,21169);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,15920,21169);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,15920,21169);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,21181,26244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,21332,21576);

string 
source = @"
public class MyClass
{
    void M(bool b, object o1, object o2, object o3, object o4)
    /*<bind>*/{
        M2(o2: o3, o1: b ? o1 : o2);
    }/*</bind>*/
    void M2(object o1, object o2, object o3 = null) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,21592,21645);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,21661,26121);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass, IsImplicit) (Syntax: 'M2')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
              Value: 
                IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
              Value: 
                IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(o2: o3,  ... ? o1 : o2);')
              Expression: 
                IInvocationOperation ( void MyClass.M2(System.Object o1, System.Object o2, [System.Object o3 = null])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(o2: o3,  ...  ? o1 : o2)')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'M2')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'o2: o3')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o1: b ? o1 : o2')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'b ? o1 : o2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: o3) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(o2: o3,  ...  ? o1 : o2)')
                        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'M2(o2: o3,  ...  ? o1 : o2)')
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,26135,26233);

f_22042_26135_26232(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,21181,26244);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,21181,26244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,21181,26244);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,26256,30781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,26407,26633);

string 
source = @"
public class MyClass
{
    void M(MyClass c1, MyClass c2, object o1, object o2)
    /*<bind>*/{
        c1.M2(o1);
        (c1 ?? c2).M2(o2);
    }/*</bind>*/
    static void M2(object o1) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,26649,27381);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22042_26920_27026(f_22042_26920_27007(f_22042_26920_26971(ErrorCode.ERR_ObjectProhibited, "c1.M2"), "MyClass.M2(object)"), 6, 9),
f_22042_27251_27365(f_22042_27251_27346(f_22042_27251_27310(ErrorCode.ERR_ObjectProhibited, "(c1 ?? c2).M2"), "MyClass.M2(object)"), 7, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,27397,30658);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'c1.M2(o1);')
          Expression: 
            IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'c1.M2(o1)')
              Children(2):
                  IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: MyClass, IsInvalid) (Syntax: 'c1')
                  IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

    Next (Regular) Block[B2]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: MyClass, IsInvalid) (Syntax: 'c1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'c1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsInvalid, IsImplicit) (Syntax: 'c1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsInvalid, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: MyClass, IsInvalid) (Syntax: 'c2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '(c1 ?? c2).M2(o2);')
              Expression: 
                IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: '(c1 ?? c2).M2(o2)')
                  Children(2):
                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyClass, IsInvalid, IsImplicit) (Syntax: 'c1 ?? c2')
                      IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,30672,30770);

f_22042_30672_30769(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,26256,30781);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,26256,30781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,26256,30781);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,30793,39241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,30944,31243);

string 
source = @"
public class MyClass
{
    void M(object o1, object o2, object o3, object o4, object o5)
    /*<bind>*/{
        M1(o1, M2(o2 ?? o3), o4 ?? o5);
    }/*</bind>*/
    static void M1(object o1, object o2, object o3) { }
    static object M2(object o1) { throw null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,31259,31312);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,31328,39118);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [3] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

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
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
                      Value: 
                        IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o2')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
                  Value: 
                    IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2(o2 ?? o3)')
                  Value: 
                    IInvocationOperation (System.Object MyClass.M2(System.Object o1)) (OperationKind.Invocation, Type: System.Object) (Syntax: 'M2(o2 ?? o3)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o2 ?? o3')
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2 ?? o3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B6]
                Leaving: {R2}
                Entering: {R4}
    }
    .locals {R4}
    {
        CaptureIds: [4]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
                  Value: 
                    IParameterReferenceOperation: o4 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o4')

            Jump if True (Regular) to Block[B8]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o4')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')
                Leaving: {R4}

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B6]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
                  Value: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')

            Next (Regular) Block[B9]
                Leaving: {R4}
    }

    Block[B8] - Block
        Predecessors: [B6]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o5')
              Value: 
                IParameterReferenceOperation: o5 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o5')

        Next (Regular) Block[B9]
    Block[B9] - Block
        Predecessors: [B7] [B8]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M1(o1, M2(o ...  o4 ?? o5);')
              Expression: 
                IInvocationOperation (void MyClass.M1(System.Object o1, System.Object o2, System.Object o3)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M1(o1, M2(o ... , o4 ?? o5)')
                  Instance Receiver: 
                    null
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'M2(o2 ?? o3)')
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'M2(o2 ?? o3)')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o3) (OperationKind.Argument, Type: null) (Syntax: 'o4 ?? o5')
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4 ?? o5')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B10]
            Leaving: {R1}
}

Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,39132,39230);

f_22042_39132_39229(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,30793,39241);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,30793,39241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,30793,39241);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,39253,44331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,39404,39660);

string 
source = @"
public class MyClass
{
    void M(object o2, object o3, object o4)
    /*<bind>*/{
        M1(M2(o2 ?? o3), o4);
    }/*</bind>*/
    static void M1(object o1, object o2) { }
    static object M2(object o1) { throw null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,39676,39729);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,39745,44208);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
                  Value: 
                    IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o2')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
              Value: 
                IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M1(M2(o2 ?? o3), o4);')
              Expression: 
                IInvocationOperation (void MyClass.M1(System.Object o1, System.Object o2)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M1(M2(o2 ?? o3), o4)')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'M2(o2 ?? o3)')
                        IInvocationOperation (System.Object MyClass.M2(System.Object o1)) (OperationKind.Invocation, Type: System.Object) (Syntax: 'M2(o2 ?? o3)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o2 ?? o3')
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2 ?? o3')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'o4')
                        IParameterReferenceOperation: o4 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o4')
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,44222,44320);

f_22042_44222_44319(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,39253,44331);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,39253,44331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,39253,44331);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,44343,51729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,44494,44767);

string 
source = @"
public class MyClass
{
    void M(object o2, object o3, object o4, object o5)
    /*<bind>*/{
        M1(M2(o2 ?? o3), o4 ?? o5);
    }/*</bind>*/
    static void M1(object o1, object o2) { }
    static object M2(object o1) { throw null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,44783,44836);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,44852,51606);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3}

.locals {R1}
{
    CaptureIds: [2] [4]
    .locals {R2}
    {
        CaptureIds: [1]
        .locals {R3}
        {
            CaptureIds: [0]
            Block[B1] - Block
                Predecessors: [B0]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
                      Value: 
                        IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o2')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')
                    Leaving: {R3}

                Next (Regular) Block[B2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
                  Value: 
                    IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2(o2 ?? o3)')
                  Value: 
                    IInvocationOperation (System.Object MyClass.M2(System.Object o1)) (OperationKind.Invocation, Type: System.Object) (Syntax: 'M2(o2 ?? o3)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o2 ?? o3')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2 ?? o3')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R4}
    }
    .locals {R4}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
                  Value: 
                    IParameterReferenceOperation: o4 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o4')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o4')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')
                Leaving: {R4}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
                  Value: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')

            Next (Regular) Block[B8]
                Leaving: {R4}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o5')
              Value: 
                IParameterReferenceOperation: o5 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o5')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M1(M2(o2 ?? ...  o4 ?? o5);')
              Expression: 
                IInvocationOperation (void MyClass.M1(System.Object o1, System.Object o2)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M1(M2(o2 ?? ... , o4 ?? o5)')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'M2(o2 ?? o3)')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'M2(o2 ?? o3)')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'o4 ?? o5')
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4 ?? o5')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,51620,51718);

f_22042_51620_51717(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,44343,51729);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,44343,51729);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,44343,51729);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,51741,58684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,51892,52138);

string 
source = @"
public class MyClass
{
    void M(object o1, object o2, object o3, object o4, object o5)
    /*<bind>*/{
        M1(o1 ?? o2, o3, o4 ?? o5);
    }/*</bind>*/
    static void M1(object o1, object o2, object o3) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,52154,52207);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,52223,58561);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1] [2] [4]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
                  Value: 
                    IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
              Value: 
                IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
              Value: 
                IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
                  Value: 
                    IParameterReferenceOperation: o4 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o4')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o4')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
                  Value: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o5')
              Value: 
                IParameterReferenceOperation: o5 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o5')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M1(o1 ?? o2 ...  o4 ?? o5);')
              Expression: 
                IInvocationOperation (void MyClass.M1(System.Object o1, System.Object o2, System.Object o3)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M1(o1 ?? o2 ... , o4 ?? o5)')
                  Instance Receiver: 
                    null
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'o1 ?? o2')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1 ?? o2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'o3')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o3) (OperationKind.Argument, Type: null) (Syntax: 'o4 ?? o5')
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4 ?? o5')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,58575,58673);

f_22042_58575_58672(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,51741,58684);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,51741,58684);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,51741,58684);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvocationFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22042,58696,65046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,58847,59104);

string 
source = @"
public class MyClass
{
    void M(bool b, object o1, object o2, object o3, object o4, object o5)
    /*<bind>*/{
        M1(b ? o1 : o2, o3, o4 ?? o5);
    }/*</bind>*/
    static void M1(object o1, object o2, object o3) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,59120,59173);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,59189,64923);

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
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
              Value: 
                IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o3')
              Value: 
                IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

        Next (Regular) Block[B5]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
                  Value: 
                    IParameterReferenceOperation: o4 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o4')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o4')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')
                Leaving: {R2}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o4')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4')

            Next (Regular) Block[B8]
                Leaving: {R2}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o5')
              Value: 
                IParameterReferenceOperation: o5 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o5')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M1(b ? o1 : ...  o4 ?? o5);')
              Expression: 
                IInvocationOperation (void MyClass.M1(System.Object o1, System.Object o2, System.Object o3)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M1(b ? o1 : ... , o4 ?? o5)')
                  Instance Receiver: 
                    null
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o1) (OperationKind.Argument, Type: null) (Syntax: 'b ? o1 : o2')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'b ? o1 : o2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o2) (OperationKind.Argument, Type: null) (Syntax: 'o3')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o3) (OperationKind.Argument, Type: null) (Syntax: 'o4 ?? o5')
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o4 ?? o5')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22042,64937,65035);

f_22042_64937_65034(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22042,58696,65046);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22042,58696,65046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22042,58696,65046);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_1346_1396(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 1346, 1396);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_1346_1420(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 1346, 1420);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_1346_1440(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 1346, 1440);
return return_v;
}


int
f_22042_1472_1592(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 1472, 1592);
return 0;
}


int
f_22042_2190_2310(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 2190, 2310);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_3136_3184(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 3136, 3184);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_3136_3208(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 3136, 3208);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_3136_3228(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 3136, 3228);
return return_v;
}


int
f_22042_3260_3380(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 3260, 3380);
return 0;
}


int
f_22042_8513_8610(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 8513, 8610);
return 0;
}


int
f_22042_13346_13443(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 13346, 13443);
return 0;
}


int
f_22042_15797_15894(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 15797, 15894);
return 0;
}


int
f_22042_21060_21157(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 21060, 21157);
return 0;
}


int
f_22042_26135_26232(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 26135, 26232);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_26920_26971(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 26920, 26971);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_26920_27007(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 26920, 27007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_26920_27026(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 26920, 27026);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_27251_27310(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 27251, 27310);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_27251_27346(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 27251, 27346);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22042_27251_27365(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 27251, 27365);
return return_v;
}


int
f_22042_30672_30769(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 30672, 30769);
return 0;
}


int
f_22042_39132_39229(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 39132, 39229);
return 0;
}


int
f_22042_44222_44319(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 44222, 44319);
return 0;
}


int
f_22042_51620_51717(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 51620, 51717);
return 0;
}


int
f_22042_58575_58672(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 58575, 58672);
return 0;
}


int
f_22042_64937_65034(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22042, 64937, 65034);
return 0;
}

}
}
