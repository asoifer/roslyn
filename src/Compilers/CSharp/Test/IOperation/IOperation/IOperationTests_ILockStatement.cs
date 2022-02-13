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
        public void ILockStatement_ObjectLock_FieldReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,524,1586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,672,845);

string 
source = @"
public class C1
{
    object o = new object();

    public void M()
    {
        /*<bind>*/lock (o)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,859,1378);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null) (Syntax: 'lock (o) ... }')
  Expression: 
    IFieldReferenceOperation: System.Object C1.o (OperationKind.FieldReference, Type: System.Object) (Syntax: 'o')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: 'o')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,1392,1445);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,1461,1575);

f_22048_1461_1574(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,524,1586);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,524,1586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,524,1586);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_ObjectLock_LocalReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,1598,2471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,1746,1921);

string 
source = @"
public class C1
{
    public void M()
    {
        object o = new object();
        /*<bind>*/lock (o)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,1935,2263);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null) (Syntax: 'lock (o) ... }')
  Expression: 
    ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,2277,2330);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,2346,2460);

f_22048_2346_2459(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,1598,2471);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,1598,2471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,1598,2471);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_ObjectLock_Null()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,2483,3311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,2621,2765);

string 
source = @"
public class C1
{
    public void M()
    {
        /*<bind>*/lock (null)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,2779,3103);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null) (Syntax: 'lock (null) ... }')
  Expression: 
    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,3117,3170);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,3186,3300);

f_22048_3186_3299(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,2483,3311);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,2483,3311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,2483,3311);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_ObjectLock_NonReferenceType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,3323,4470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,3473,3634);

string 
source = @"
public class C1
{
    public void M()
    {
        int i = 1;
        /*<bind>*/lock (i)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,3648,3997);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null, IsInvalid) (Syntax: 'lock (i) ... }')
  Expression: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'i')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,4011,4329);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22048_4223_4313(f_22048_4223_4293(f_22048_4223_4272(ErrorCode.ERR_LockNeedsReference, "i"), "int"), 7, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,4345,4459);

f_22048_4345_4458(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,3323,4470);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,3323,4470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,3323,4470);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_MissingLockExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,4482,5552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,4626,4766);

string 
source = @"
public class C1
{
    public void M()
    {
        /*<bind>*/lock ()
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,4780,5121);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null, IsInvalid) (Syntax: 'lock () ... }')
  Expression: 
    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
      Children(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,5135,5411);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22048_5310_5395(f_22048_5310_5375(f_22048_5310_5356(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 6, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,5427,5541);

f_22048_5427_5540(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,4482,5552);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,4482,5552);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,4482,5552);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_InvalidLockStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,5564,6768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,5707,5880);

string 
source = @"
using System;

public class C1
{
    public void M()
    {
        /*<bind>*/lock (invalidReference)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,5894,6252);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null, IsInvalid) (Syntax: 'lock (inval ... }')
  Expression: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'invalidReference')
      Children(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,6266,6627);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22048_6495_6611(f_22048_6495_6591(f_22048_6495_6557(ErrorCode.ERR_NameNotInContext, "invalidReference"), "invalidReference"), 8, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,6643,6757);

f_22048_6643_6756(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,5564,6768);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,5564,6768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,5564,6768);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_MissingBody()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,6780,8142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,6914,7067);

string 
source = @"
public class C1
{
    public void M()
    {
        object o = new object();
        /*<bind>*/lock (o)
/*</bind>*/    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,7081,7539);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null, IsInvalid) (Syntax: 'lock (o)')
  Expression: 
    ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
  Body: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
      Expression: 
        IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
          Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,7553,8001);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22048_7729_7813(f_22048_7729_7793(f_22048_7729_7774(ErrorCode.ERR_InvalidExprTerm, ""), "}"), 7, 27),
f_22048_7918_7985(f_22048_7918_7965(ErrorCode.ERR_SemicolonExpected, ""), 7, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,8017,8131);

f_22048_8017_8130(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,6780,8142);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,6780,8142);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,6780,8142);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_ExpressionLock_ObjectMethodCall()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,8154,9246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,8308,8494);

string 
source = @"
public class C1
{
    public void M()
    {
        object o = new object();
        /*<bind>*/lock (o.ToString())
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,8508,9038);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null) (Syntax: 'lock (o.ToS ... }')
  Expression: 
    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'o.ToString()')
      Instance Receiver: 
        ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
      Arguments(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,9052,9105);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,9121,9235);

f_22048_9121_9234(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,8154,9246);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,8154,9246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,8154,9246);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_ExpressionLock_ClassMethodCall()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,9258,10390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,9411,9625);

string 
source = @"
public class C1
{
    public void M()
    {
        /*<bind>*/lock (M2())
        {
        }/*</bind>*/
    }

    public object M2()
    {
        return new object();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,9639,10182);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null) (Syntax: 'lock (M2()) ... }')
  Expression: 
    IInvocationOperation ( System.Object C1.M2()) (OperationKind.Invocation, Type: System.Object) (Syntax: 'M2()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsImplicit) (Syntax: 'M2')
      Arguments(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,10196,10249);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,10265,10379);

f_22048_10265_10378(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,9258,10390);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,9258,10390);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,9258,10390);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_ExpressionCall_VoidMethodCall()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,10402,11786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,10554,10726);

string 
source = @"
public class C1
{
    public void M()
    {
        /*<bind>*/lock (M2())
        {
        }/*</bind>*/
    }

    public void M2() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,10740,11305);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null, IsInvalid) (Syntax: 'lock (M2()) ... }')
  Expression: 
    IInvocationOperation ( void C1.M2()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'M2()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1, IsInvalid, IsImplicit) (Syntax: 'M2')
      Arguments(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,11319,11645);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22048_11535_11629(f_22048_11535_11609(f_22048_11535_11587(ErrorCode.ERR_LockNeedsReference, "M2()"), "void"), 6, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,11661,11775);

f_22048_11661_11774(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,10402,11786);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,10402,11786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,10402,11786);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILockStatement_NonEmptybody()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,11798,13826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,11933,12152);

string 
source = @"
using System;

public class C1
{
    public void M()
    {
        /*<bind>*/lock (new object())
        {
            Console.WriteLine(""Hello World!"");
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,12166,13618);

string 
expectedOperationTree = @"
ILockOperation (OperationKind.Lock, Type: null) (Syntax: 'lock (new o ... }')
  Expression: 
    IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object) (Syntax: 'new object()')
      Arguments(0)
      Initializer: 
        null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... o World!"");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... lo World!"")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""Hello World!""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Hello World!"") (Syntax: '""Hello World!""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,13632,13685);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,13701,13815);

f_22048_13701_13814(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,11798,13826);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,11798,13826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,11798,13826);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LockFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,13838,21577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,13983,14180);

string 
source = @"
class P
{
    void M(object source1, object source2, object source3)
/*<bind>*/{
        lock (source1 ?? source2)
            source3?.ToString();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,14194,21389);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Boolean ?]
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'source1')
                  Value: 
                    IParameterReferenceOperation: source1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'source1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'source1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'source1')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'source1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'source1')

            Next (Regular) Block[B4]
                Leaving: {R2}
                Entering: {R3} {R4}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'source2')
              Value: 
                IParameterReferenceOperation: source2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'source2')

        Next (Regular) Block[B4]
            Entering: {R3} {R4}

    .try {R3, R4}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IInvocationOperation (void System.Threading.Monitor.Enter(System.Object obj, ref System.Boolean lockTaken)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'source1 ?? source2')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'source1 ?? source2')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'source1 ?? source2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: lockTaken) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'source1 ?? source2')
                        ILocalReferenceOperation:  (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'source1 ?? source2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B5]
                Entering: {R5}

        .locals {R5}
        {
            CaptureIds: [2]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'source3')
                      Value: 
                        IParameterReferenceOperation: source3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'source3')

                Jump if True (Regular) to Block[B10]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'source3')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'source3')
                    Finalizing: {R6}
                    Leaving: {R5} {R4} {R3} {R1}

                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'source3?.ToString();')
                      Expression: 
                        IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '.ToString()')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'source3')
                          Arguments(0)

                Next (Regular) Block[B10]
                    Finalizing: {R6}
                    Leaving: {R5} {R4} {R3} {R1}
        }
    }
    .finally {R6}
    {
        Block[B7] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B9]
                ILocalReferenceOperation:  (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'source1 ?? source2')

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IInvocationOperation (void System.Threading.Monitor.Exit(System.Object obj)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'source1 ?? source2')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'source1 ?? source2')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'source1 ?? source2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B10] - Exit
    Predecessors: [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,21403,21456);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,21472,21566);

f_22048_21472_21565(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,13838,21577);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,13838,21577);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,13838,21577);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LockFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,21589,26163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,21734,21893);

string 
source = @"
class P
{
    void M(string input1, bool input2)
/*<bind>*/{
        lock (input1)
            input2 = true;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,21907,25748);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'input1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.String) (Syntax: 'input1')

            IInvocationOperation (void System.Threading.Monitor.Enter(System.Object obj)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'input1')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'input1')
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input2 = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'input2 = true')
                      Left: 
                        IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input2')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (void System.Threading.Monitor.Exit(System.Object obj)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'input1')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'input1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,25762,25815);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,25831,26152);

f_22048_25831_26151(source, expectedGraph, expectedDiagnostics, targetFramework: Roslyn.Test.Utilities.TargetFramework.Empty, references: new[] { f_22048_26133_26148()});
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,21589,26163);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,21589,26163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,21589,26163);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LockFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,26175,32097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,26320,26476);

string 
source = @"
class P
{
    void M(int input1, bool input2)
/*<bind>*/{
        lock (input1)
            input2 = true;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,26490,31645);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Boolean ?]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input1')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'input1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (Boxing)
                  Operand: 
                    IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'input1')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IInvocationOperation (void System.Threading.Monitor.Enter(System.Object obj, ref System.Boolean lockTaken)) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'input1')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'input1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'input1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: lockTaken) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'input1')
                        ILocalReferenceOperation:  (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'input1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input2 = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'input2 = true')
                      Left: 
                        IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input2')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B5]
                ILocalReferenceOperation:  (OperationKind.LocalReference, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'input1')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IInvocationOperation (void System.Threading.Monitor.Exit(System.Object obj)) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'input1')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'input1')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'input1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,31659,31976);

var 
expectedDiagnostics = new[] {
f_22048_31865_31960(f_22048_31865_31940(f_22048_31865_31919(ErrorCode.ERR_LockNeedsReference, "input1"), "int"), 6, 15)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,31992,32086);

f_22048_31992_32085(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,26175,32097);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,26175,32097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,26175,32097);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LockFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,32109,37612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,32254,32396);

string 
source = @"
class P
{
    void M(bool input2)
/*<bind>*/{
        lock (null)
            input2 = true;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,32410,37424);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Boolean ?]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NullLiteral)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IInvocationOperation (void System.Threading.Monitor.Enter(System.Object obj, ref System.Boolean lockTaken)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'null')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'null')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: lockTaken) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'null')
                        ILocalReferenceOperation:  (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'null')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input2 = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'input2 = true')
                      Left: 
                        IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input2')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B5]
                ILocalReferenceOperation:  (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'null')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IInvocationOperation (void System.Threading.Monitor.Exit(System.Object obj)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'null')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'null')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,37438,37491);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,37507,37601);

f_22048_37507_37600(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,32109,37612);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,32109,37612);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,32109,37612);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LockFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,37624,41565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,37769,37915);

string 
source = @"
class P
{
    void M(P input, bool b)
    /*<bind>*/{
        lock (input)
            b = true;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,37929,37987);

var 
compilation = f_22048_37947_37986(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,38001,38080);

f_22048_38001_38079(            compilation, WellKnownMember.System_Threading_Monitor__Enter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,38094,38174);

f_22048_38094_38173(            compilation, WellKnownMember.System_Threading_Monitor__Enter2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,38190,41372);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'input')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: P) (Syntax: 'input')

            IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'input')
              Children(1):
                  IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
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
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (void System.Threading.Monitor.Exit(System.Object obj)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'input')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'input')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,41386,41439);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,41455,41554);

f_22048_41455_41553(compilation, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,37624,41565);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,37624,41565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,37624,41565);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LockFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22048,41577,46594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,41722,41868);

string 
source = @"
class P
{
    void M(P input, bool b)
    /*<bind>*/{
        lock (input)
            b = true;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,41882,41940);

var 
compilation = f_22048_41900_41939(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,41954,42032);

f_22048_41954_42031(            compilation, WellKnownMember.System_Threading_Monitor__Exit);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,42048,46401);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Boolean ?]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'input')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: P) (Syntax: 'input')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IInvocationOperation (void System.Threading.Monitor.Enter(System.Object obj, ref System.Boolean lockTaken)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'input')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'input')
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: lockTaken) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'input')
                        ILocalReferenceOperation:  (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B5]
                ILocalReferenceOperation:  (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'input')
                  Children(1):
                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,46415,46468);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22048,46484,46583);

f_22048_46484_46582(compilation, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22048,41577,46594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22048,41577,46594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22048,41577,46594);
}
		}

int
f_22048_1461_1574(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 1461, 1574);
return 0;
}


int
f_22048_2346_2459(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 2346, 2459);
return 0;
}


int
f_22048_3186_3299(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 3186, 3299);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_4223_4272(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 4223, 4272);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_4223_4293(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 4223, 4293);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_4223_4313(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 4223, 4313);
return return_v;
}


int
f_22048_4345_4458(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 4345, 4458);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_5310_5356(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 5310, 5356);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_5310_5375(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 5310, 5375);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_5310_5395(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 5310, 5395);
return return_v;
}


int
f_22048_5427_5540(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 5427, 5540);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_6495_6557(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 6495, 6557);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_6495_6591(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 6495, 6591);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_6495_6611(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 6495, 6611);
return return_v;
}


int
f_22048_6643_6756(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 6643, 6756);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_7729_7774(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 7729, 7774);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_7729_7793(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 7729, 7793);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_7729_7813(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 7729, 7813);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_7918_7965(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 7918, 7965);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_7918_7985(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 7918, 7985);
return return_v;
}


int
f_22048_8017_8130(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 8017, 8130);
return 0;
}


int
f_22048_9121_9234(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 9121, 9234);
return 0;
}


int
f_22048_10265_10378(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 10265, 10378);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_11535_11587(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 11535, 11587);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_11535_11609(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 11535, 11609);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_11535_11629(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 11535, 11629);
return return_v;
}


int
f_22048_11661_11774(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 11661, 11774);
return 0;
}


int
f_22048_13701_13814(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LockStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 13701, 13814);
return 0;
}


int
f_22048_21472_21565(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 21472, 21565);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_22048_26133_26148()
{
var return_v = MscorlibRef_v20 ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22048, 26133, 26148);
return return_v;
}


int
f_22048_25831_26151(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, targetFramework:targetFramework, references:references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 25831, 26151);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_31865_31919(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 31865, 31919);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_31865_31940(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 31865, 31940);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22048_31865_31960(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 31865, 31960);
return return_v;
}


int
f_22048_31992_32085(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 31992, 32085);
return 0;
}


int
f_22048_37507_37600(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 37507, 37600);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22048_37947_37986(string
source)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 37947, 37986);
return return_v;
}


int
f_22048_38001_38079(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
this_param.MakeMemberMissing( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 38001, 38079);
return 0;
}


int
f_22048_38094_38173(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
this_param.MakeMemberMissing( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 38094, 38173);
return 0;
}


int
f_22048_41455_41553(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 41455, 41553);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22048_41900_41939(string
source)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 41900, 41939);
return return_v;
}


int
f_22048_41954_42031(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
this_param.MakeMemberMissing( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 41954, 42031);
return 0;
}


int
f_22048_46484_46582(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22048, 46484, 46582);
return 0;
}

}
}
