// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_DynamicArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,501,1366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,646,805);

string 
source = @"
class C
{
    public C(int i)
    {
    }

    void M(dynamic d)
    {
        var x = /*<bind>*/new C(d)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,819,1147);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C) (Syntax: 'new C(d)')
  Arguments(1):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(0)
  ArgumentRefKinds(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,1161,1214);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,1230,1355);

f_22029_1230_1354(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,501,1366);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,501,1366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,501,1366);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_MultipleApplicableSymbols()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,1378,2291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,1533,1730);

string 
source = @"
class C
{
    public C(int i)
    {
    }

    public C(long i)
    {
    }

    void M(dynamic d)
    {
        var x = /*<bind>*/new C(d)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,1744,2072);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C) (Syntax: 'new C(d)')
  Arguments(1):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(0)
  ArgumentRefKinds(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,2086,2139);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,2155,2280);

f_22029_2155_2279(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,1378,2291);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,1378,2291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,1378,2291);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_MultipleArgumentsAndApplicableSymbols()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,2303,3372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,2470,2709);

string 
source = @"
class C
{
    public C(int i, char c)
    {
    }

    public C(long i, char c)
    {
    }

    void M(dynamic d)
    {
        char c = 'c';
        var x = /*<bind>*/new C(d, c)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,2723,3153);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C) (Syntax: 'new C(d, c)')
  Arguments(2):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
      ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.Char) (Syntax: 'c')
  ArgumentNames(0)
  ArgumentRefKinds(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,3167,3220);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,3236,3361);

f_22029_3236_3360(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,2303,3372);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,2303,3372);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,2303,3372);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_ArgumentNames()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,3384,4456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,3527,3760);

string 
source = @"
class C
{
    public C(int i, char c)
    {
    }

    public C(long i, char c)
    {
    }

    void M(dynamic d, dynamic e)
    {
        var x = /*<bind>*/new C(i: d, c: e)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,3774,4237);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C) (Syntax: 'new C(i: d, c: e)')
  Arguments(2):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
      IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'e')
  ArgumentNames(2):
    ""i""
    ""c""
  ArgumentRefKinds(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,4251,4304);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,4320,4445);

f_22029_4320_4444(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,3384,4456);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,3384,4456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,3384,4456);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_ArgumentRefKinds()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,4468,5668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,4614,4855);

string 
source = @"
class C
{
    public C(ref object i, out int j, char c)
    {
        j = 0;
    }

    void M(object d, dynamic e)
    {
        int k;
        var x = /*<bind>*/new C(ref d, out k, e)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,4869,5449);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C) (Syntax: 'new C(ref d, out k, e)')
  Arguments(3):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'd')
      ILocalReferenceOperation: k (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')
      IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'e')
  ArgumentNames(0)
  ArgumentRefKinds(3):
    Ref
    Out
    None
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,5463,5516);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,5532,5657);

f_22029_5532_5656(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,4468,5668);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,4468,5668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,4468,5668);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_Initializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,5680,7283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,5821,6012);

string 
source = @"
class C
{
    public int X;

    public C(char c)
    {
    }

    void M(dynamic d)
    {
        var x = /*<bind>*/new C(d) { X = 0 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,6026,7064);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C) (Syntax: 'new C(d) { X = 0 }')
  Arguments(1):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(0)
  ArgumentRefKinds(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ X = 0 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'X = 0')
            Left: 
              IFieldReferenceOperation: System.Int32 C.X (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'X')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'X')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,7078,7131);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,7147,7272);

f_22029_7147_7271(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,5680,7283);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,5680,7283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,5680,7283);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_AllFields()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,7295,9141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,7434,7715);

string 
source = @"
class C
{
    public int X;

    public C(ref int i, char c)
    {
    }

    public C(ref int i, long c)
    {
    }

    void M(dynamic d)
    {
        int i = 0;
        var x = /*<bind>*/new C(ref i, c: d) { X = 0 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,7729,8922);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C) (Syntax: 'new C(ref i ... ) { X = 0 }')
  Arguments(2):
      ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(2):
    ""null""
    ""c""
  ArgumentRefKinds(2):
    Ref
    None
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: C) (Syntax: '{ X = 0 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'X = 0')
            Left: 
              IFieldReferenceOperation: System.Int32 C.X (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'X')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'X')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,8936,8989);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,9005,9130);

f_22029_9005_9129(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,7295,9141);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,7295,9141);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,7295,9141);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_ErrorBadDynamicMethodArgLambda()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,9153,10883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,9313,9536);

string 
source = @"
using System;

class C
{
    static void Main()
    {
        dynamic y = null;
        /*<bind>*/new C(delegate { }, y)/*</bind>*/;
    }

    public C(Action a, Action y)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,9550,10292);

string 
expectedOperationTree = @"
IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C, IsInvalid) (Syntax: 'new C(delegate { }, y)')
  Arguments(2):
      IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: 'delegate { }')
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
          IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '{ }')
            ReturnedValue: 
              null
      ILocalReferenceOperation: y (OperationKind.LocalReference, Type: dynamic) (Syntax: 'y')
  ArgumentNames(0)
  ArgumentRefKinds(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,10306,10731);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22029_10628_10715(f_22029_10628_10695(ErrorCode.ERR_BadDynamicMethodArgLambda, "delegate { }"), 9, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,10747,10872);

f_22029_10747_10871(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,9153,10883);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,9153,10883);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,9153,10883);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicObjectCreation_OVerloadResolutionFailure()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,10895,12063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,11050,11248);

string 
source = @"
class C
{
    public C()
    {
    }

    public C(int i, int j)
    {
    }

    void M(dynamic d)
    {
        var x = /*<bind>*/new C(d)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,11262,11502);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: C, IsInvalid) (Syntax: 'new C(d)')
  Children(1):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,11516,11911);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22029_11784_11895(f_22029_11784_11874(f_22029_11784_11838(ErrorCode.ERR_NoCorrespondingArgument, "C"), "j", "C.C(int, int)"), 14, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,11927,12052);

f_22029_11927_12051(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,10895,12063);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,10895,12063);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,10895,12063);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicObjectCreationFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,12075,13670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,12237,12384);

string 
source = @"
class C1
{
    C1(int i) { }
    /*<bind>*/void M(C1 c1, dynamic d)
    {
        c1 = new C1(d);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,12398,12451);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,12467,13535);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c1 = new C1(d);')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c1 = new C1(d)')
              Left: 
                IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c1')
              Right: 
                IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C1) (Syntax: 'new C1(d)')
                  Arguments(1):
                      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)
                  Initializer: 
                    null

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,13549,13659);

f_22029_13549_13658(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,12075,13670);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,12075,13670);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,12075,13670);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicObjectCreationFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,13682,18795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,13844,14078);

string 
source = @"
class C1
{
    C1(int i) { }
    /*<bind>*/void M(C1 c1, dynamic d, bool b)
    {
        c1 = new C1(d) { I1 = 1, I2 = b ? 2 : 3 };
    }/*</bind>*/
    int I1 { get; set; }
    int I2 { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,14092,14145);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,14161,18660);

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
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')
              Value: 
                IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C1) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')
                  Arguments(1):
                      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I1 = 1')
              Left: 
                IPropertyReferenceOperation: System.Int32 C1.I1 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I1')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'I2 = b ? 2 : 3')
                  Left: 
                    IPropertyReferenceOperation: System.Int32 C1.I2 { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'I2')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c1 = new C1 ...  ? 2 : 3 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c1 = new C1 ... b ? 2 : 3 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,18674,18784);

f_22029_18674_18783(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,13682,18795);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,13682,18795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,13682,18795);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicObjectCreationFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22029,18807,24845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,18969,19440);

string 
source = @"
using System.Collections;
using System.Collections.Generic;

class C1 : IEnumerable<int>
{
    C1(int i) { }
    /*<bind>*/void M(C1 c1, dynamic d, bool b)
    {
        c1 = new C1(d) { 1, b ? 2 : 3 };
    }/*</bind>*/
    public IEnumerator<int> GetEnumerator() => throw new System.NotImplementedException();
    IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    public void Add(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,19454,19507);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,19523,24710);

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
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
              Value: 
                IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C1) (Syntax: 'c1')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')
              Value: 
                IDynamicObjectCreationOperation (OperationKind.DynamicObjectCreation, Type: C1) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')
                  Arguments(1):
                      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)
                  Initializer: 
                    null

            IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: '1')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IInvocationOperation ( void C1.Add(System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'b ? 2 : 3')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'b ? 2 : 3')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 2 : 3')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c1 = new C1 ...  ? 2 : 3 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C1) (Syntax: 'c1 = new C1 ... b ? 2 : 3 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'c1')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C1, IsImplicit) (Syntax: 'new C1(d) { ... b ? 2 : 3 }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22029,24724,24834);

f_22029_24724_24833(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22029,18807,24845);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22029,18807,24845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22029,18807,24845);
}
		}

int
f_22029_1230_1354(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 1230, 1354);
return 0;
}


int
f_22029_2155_2279(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 2155, 2279);
return 0;
}


int
f_22029_3236_3360(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 3236, 3360);
return 0;
}


int
f_22029_4320_4444(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 4320, 4444);
return 0;
}


int
f_22029_5532_5656(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 5532, 5656);
return 0;
}


int
f_22029_7147_7271(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 7147, 7271);
return 0;
}


int
f_22029_9005_9129(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 9005, 9129);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22029_10628_10695(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 10628, 10695);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22029_10628_10715(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 10628, 10715);
return return_v;
}


int
f_22029_10747_10871(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 10747, 10871);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22029_11784_11838(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 11784, 11838);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22029_11784_11874(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 11784, 11874);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22029_11784_11895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 11784, 11895);
return return_v;
}


int
f_22029_11927_12051(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 11927, 12051);
return 0;
}


int
f_22029_13549_13658(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 13549, 13658);
return 0;
}


int
f_22029_18674_18783(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 18674, 18783);
return 0;
}


int
f_22029_24724_24833(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22029, 24724, 24833);
return 0;
}

}
}
