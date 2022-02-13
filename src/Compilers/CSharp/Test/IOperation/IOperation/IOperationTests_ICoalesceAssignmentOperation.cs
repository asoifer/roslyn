// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
[CompilerTrait(CompilerFeature.IOperation)]
    public partial class IOperationTests : SemanticModelTestBase
{
[Fact]
        public void CoalesceAssignment_SimpleCase()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,540,1374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,626,759);

string 
source = @"
class C
{
    static void M(object o1, object o2)
    {
        /*<bind>*/o1 ??= o2/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,773,1159);

string 
expectedOperationTree = @"
ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: System.Object) (Syntax: 'o1 ??= o2')
  Target: 
    IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')
  Value: 
    IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,1173,1226);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,1242,1363);

f_22014_1242_1362(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,540,1374);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,540,1374);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,540,1374);
}
		}

[Fact]
        public void CoalesceAssignment_WithConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,1386,2522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,1474,1607);

string 
source = @"
class C
{
    static void M(object o1, string s1)
    {
        /*<bind>*/o1 ??= s1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,1621,2307);

string 
expectedOperationTree = @"
ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: System.Object) (Syntax: 'o1 ??= s1')
  Target: 
    IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')
  Value: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 's1')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: s1 (OperationKind.ParameterReference, Type: System.String) (Syntax: 's1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,2321,2374);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,2390,2511);

f_22014_2390_2510(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,1386,2522);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,1386,2522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,1386,2522);
}
		}

[Fact]
        public void CoalesceAssignment_NoConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,2534,3694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,2620,2748);

string 
source = @"
class C
{
    static void M(C c1, string s1)
    {
        /*<bind>*/c1 ??= s1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,2762,3157);

string 
expectedOperationTree = @"
ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: ?, IsInvalid) (Syntax: 'c1 ??= s1')
  Target: 
    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c1')
  Value: 
    IParameterReferenceOperation: s1 (OperationKind.ParameterReference, Type: System.String, IsInvalid) (Syntax: 's1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,3171,3546);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22014_3423_3530(f_22014_3423_3510(f_22014_3423_3474(ErrorCode.ERR_BadBinaryOps, "c1 ??= s1"), "??=", "C", "string"), 6, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,3562,3683);

f_22014_3562_3682(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,2534,3694);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,2534,3694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,2534,3694);
}
		}

[Fact]
        public void CoalesceAssignment_ValueTypeLeft()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,3706,4884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,3793,3923);

string 
source = @"
class C
{
    static void M(int i1, string s1)
    {
        /*<bind>*/i1 ??= s1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,3937,4343);

string 
expectedOperationTree = @"
ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: ?, IsInvalid) (Syntax: 'i1 ??= s1')
  Target: 
    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
  Value: 
    IParameterReferenceOperation: s1 (OperationKind.ParameterReference, Type: System.String, IsInvalid) (Syntax: 's1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,4357,4736);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22014_4611_4720(f_22014_4611_4700(f_22014_4611_4662(ErrorCode.ERR_BadBinaryOps, "i1 ??= s1"), "??=", "int", "string"), 6, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,4752,4873);

f_22014_4752_4872(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,3706,4884);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,3706,4884);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,3706,4884);
}
		}

[Fact]
        public void CoalesceAssignment_MissingLeftAndRight()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,4896,6255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,4991,5104);

string 
source = @"
class C
{
    static void M()
    {
        /*<bind>*/o1 ??= o2/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,5118,5487);

string 
expectedOperationTree = @"
ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: ?, IsInvalid) (Syntax: 'o1 ??= o2')
  Target: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'o1')
      Children(0)
  Value: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'o2')
      Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,5501,6107);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22014_5735_5823(f_22014_5735_5803(f_22014_5735_5783(ErrorCode.ERR_NameNotInContext, "o1"), "o1"), 6, 19),
f_22014_6003_6091(f_22014_6003_6071(f_22014_6003_6051(ErrorCode.ERR_NameNotInContext, "o2"), "o2"), 6, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,6123,6244);

f_22014_6123_6243(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,4896,6255);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,4896,6255);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,4896,6255);
}
		}

[Fact]
        public void CoalesceAssignment_AsExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,6267,7794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,6355,6525);

string 
source = @"
class C
{
    static void M(object o1, object o2)
    {
        /*<bind>*/M2(o1 ??= o2)/*</bind>*/;
    }
    static void M2(object o) {}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,6539,7579);

string 
expectedOperationTree = @"
IInvocationOperation (void C.M2(System.Object o)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(o1 ??= o2)')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o) (OperationKind.Argument, Type: null) (Syntax: 'o1 ??= o2')
        ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: System.Object) (Syntax: 'o1 ??= o2')
          Target: 
            IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')
          Value: 
            IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,7593,7646);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,7662,7783);

f_22014_7662_7782(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,6267,7794);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,6267,7794);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,6267,7794);
}
		}

[Fact]
        public void CoalesceAssignment_CheckedDynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,7806,8671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,7896,8074);

string 
source = @"
class C
{
    static void M(dynamic d1, dynamic d2)
    {
        checked
        {
            /*<bind>*/d1 ??= d2/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,8088,8456);

string 
expectedOperationTree = @"
ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: dynamic) (Syntax: 'd1 ??= d2')
  Target: 
    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')
  Value: 
    IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,8470,8523);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,8539,8660);

f_22014_8539_8659(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,7806,8671);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,7806,8671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,7806,8671);
}
		}

[Fact]
        public void CoalesceAssignment_NullValueAndTarget()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,8683,12131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,8775,8896);

var 
comp = f_22014_8786_8895(@"
class C
{
    static void M()
    {
        /*<bind>*/??=/*</bind>*/;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,8910,9288);

string 
expectedOperationTree = @"
ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: ?, IsInvalid) (Syntax: '/*<bind>*/? ... /*</bind>*/')
  Target: 
    IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
      Children(0)
  Value: 
    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
      Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,9302,9815);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22014_9479_9564(f_22014_9479_9545(f_22014_9479_9524(ErrorCode.ERR_InvalidExprTerm, ""), "??="), 5, 6),
f_22014_9714_9799(f_22014_9714_9779(f_22014_9714_9760(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 33)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,9831,9950);

f_22014_9831_9949(comp, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,9966,9997);

var 
tree = f_22014_9977_9993(comp)[0]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,10011,10095);

var 
m = f_22014_10019_10094(f_22014_10019_10085(f_22014_10019_10051(f_22014_10019_10033(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,10109,12120);

f_22014_10109_12119(comp, m, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '')
              Value: 
                IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
                  Children(0)
        Next (Regular) Block[B2]
            Entering: {R2}
    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: null, IsImplicit) (Syntax: '')
            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: '')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: null, IsImplicit) (Syntax: '')
                Leaving: {R2}
            Next (Regular) Block[B4]
                Leaving: {R2} {R1}
    }
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid, IsImplicit) (Syntax: '/*<bind>*/? ... /*</bind>*/')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: null, IsImplicit) (Syntax: '')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                  Children(0)
        Next (Regular) Block[B4]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,8683,12131);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,8683,12131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,8683,12131);
}
		}

[Fact, CompilerTrait(CompilerFeature.Dataflow)]
        public void CoalesceAssignmentFlow_NullableValueTypeTarget()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,12143,15475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,12285,12427);

var 
comp = f_22014_12296_12426(@"
class C
{
    static void M(int? i1, int i2)
    /*<bind>*/{
        i1 ??= i2;
    }/*</bind>*/
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,12443,13144);

f_22014_12443_13143(comp, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i1 ??= i2;')
    Expression: 
      ICoalesceAssignmentOperation (OperationKind.CoalesceAssignment, Type: System.Int32) (Syntax: 'i1 ??= i2')
        Target: 
          IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')
        Value: 
          IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')
", expectedDiagnostics: DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,13160,15387);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
        Jump if False (Regular) to Block[B2]
            IInvocationOperation ( System.Boolean System.Int32?.HasValue.get) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
              Arguments(0)
        Next (Regular) Block[B3]
            Leaving: {R1}
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?, IsImplicit) (Syntax: 'i1 ??= i2')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: 'i2')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitNullable)
                  Operand: 
                    IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')
        Next (Regular) Block[B3]
            Leaving: {R1}
}
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,15403,15464);

f_22014_15403_15463(comp, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,12143,15475);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,12143,15475);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,12143,15475);
}
		}

[Fact, CompilerTrait(CompilerFeature.Dataflow)]
        public void CoalesceAssignmentFlow_WhenNullConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,15487,18391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,15624,15757);

string 
source = @"
class C
{
    static void M(object o1, string s1)
    /*<bind>*/{
        o1 ??= s1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,15771,18199);

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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                Leaving: {R2}

            Next (Regular) Block[B4]
                Leaving: {R2} {R1}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'o1 ??= s1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 's1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    IParameterReferenceOperation: s1 (OperationKind.ParameterReference, Type: System.String) (Syntax: 's1')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,18213,18266);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,18282,18380);

f_22014_18282_18379(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,15487,18391);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,15487,18391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,15487,18391);
}
		}

[Fact, CompilerTrait(CompilerFeature.Dataflow)]
        public void CoalesceAssignmentFlow_WhenNullHasFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,18403,23234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,18537,18687);

string 
source = @"
class C
{
    static void M(object o1, string s1, string s2)
    /*<bind>*/{
        o1 ??= s1 ?? s2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,18701,23042);

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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                Leaving: {R2}
                Entering: {R3} {R4}

            Next (Regular) Block[B7]
                Leaving: {R2} {R1}
    }
    .locals {R3}
    {
        CaptureIds: [3]
        .locals {R4}
        {
            CaptureIds: [2]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 's1')
                      Value: 
                        IParameterReferenceOperation: s1 (OperationKind.ParameterReference, Type: System.String) (Syntax: 's1')

                Jump if True (Regular) to Block[B5]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 's1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 's1')
                    Leaving: {R4}

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 's1')
                      Value: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 's1')

                Next (Regular) Block[B6]
                    Leaving: {R4}
        }

        Block[B5] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 's2')
                  Value: 
                    IParameterReferenceOperation: s2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 's2')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'o1 ??= s1 ?? s2')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 's1 ?? s2')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 's1 ?? s2')

            Next (Regular) Block[B7]
                Leaving: {R3} {R1}
    }
}

Block[B7] - Exit
    Predecessors: [B2] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,23056,23109);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,23125,23223);

f_22014_23125_23222(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,18403,23234);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,18403,23234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,18403,23234);
}
		}

[Fact, CompilerTrait(CompilerFeature.Dataflow)]
        public void CoalesceAssignmentFlow_BothSidesHaveFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,23246,30254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,23382,23553);

string 
source = @"
class C
{
    static void M(object o1, object o2, string s1, string s2)
    /*<bind>*/{
        (o1 ?? o2) ??= (s1 ?? s2);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,23567,29770);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3}

.locals {R1}
{
    CaptureIds: [2]
    .locals {R2}
    {
        CaptureIds: [1]
        .locals {R3}
        {
            CaptureIds: [0]
            Block[B1] - Block
                Predecessors: [B0]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'o1')
                      Value: 
                        IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object, IsInvalid) (Syntax: 'o1')

                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'o1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'o1')
                    Leaving: {R3}

                Next (Regular) Block[B2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'o1')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'o1')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'o2')
                  Value: 
                    IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object, IsInvalid) (Syntax: 'o2')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'o1 ?? o2')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'o1 ?? o2')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'o1 ?? o2')

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
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'o1 ?? o2')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'o1 ?? o2')

            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'o1 ?? o2')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'o1 ?? o2')
                Leaving: {R4}
                Entering: {R5} {R6}

            Next (Regular) Block[B10]
                Leaving: {R4} {R1}
    }
    .locals {R5}
    {
        CaptureIds: [5]
        .locals {R6}
        {
            CaptureIds: [4]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 's1')
                      Value: 
                        IParameterReferenceOperation: s1 (OperationKind.ParameterReference, Type: System.String) (Syntax: 's1')

                Jump if True (Regular) to Block[B8]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 's1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 's1')
                    Leaving: {R6}

                Next (Regular) Block[B7]
            Block[B7] - Block
                Predecessors: [B6]
                Statements (1)
                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 's1')
                      Value: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 's1')

                Next (Regular) Block[B9]
                    Leaving: {R6}
        }

        Block[B8] - Block
            Predecessors: [B6]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 's2')
                  Value: 
                    IParameterReferenceOperation: s2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 's2')

            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid, IsImplicit) (Syntax: '(o1 ?? o2)  ...  (s1 ?? s2)')
                  Left: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'o1 ?? o2')
                  Right: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 's1 ?? s2')

            Next (Regular) Block[B10]
                Leaving: {R5} {R1}
    }
}

Block[B10] - Exit
    Predecessors: [B5] [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,29784,30129);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22014_30037_30113(f_22014_30037_30093(ErrorCode.ERR_AssgLvalueExpected, "o1 ?? o2"), 6, 10)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,30145,30243);

f_22014_30145_30242(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,23246,30254);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,23246,30254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,23246,30254);
}
		}

[Fact, CompilerTrait(CompilerFeature.Dataflow)]
        public void CoalesceAssignmentFlow_NestedUse()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,30266,35782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,30394,30547);

string 
source = @"
class C
{
    static void M(object o1, object o2, object o3)
    /*<bind>*/{
        o1 ??= (o2 ??= o3);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,30561,35590);

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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
              Value: 
                IParameterReferenceOperation: o1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                Leaving: {R2}
                Entering: {R3} {R4}

            Next (Regular) Block[B8]
                Leaving: {R2} {R1}
    }
    .locals {R3}
    {
        CaptureIds: [4]
        .locals {R4}
        {
            CaptureIds: [2]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
                      Value: 
                        IParameterReferenceOperation: o2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o2')

                Next (Regular) Block[B4]
                    Entering: {R5}

            .locals {R5}
            {
                CaptureIds: [3]
                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2')
                          Value: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')

                    Jump if True (Regular) to Block[B6]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o2')
                          Operand: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')
                        Leaving: {R5}

                    Next (Regular) Block[B5]
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (1)
                        IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2 ??= o3')
                          Value: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')

                    Next (Regular) Block[B7]
                        Leaving: {R5} {R4}
            }

            Block[B6] - Block
                Predecessors: [B4]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o2 ??= o3')
                      Value: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'o2 ??= o3')
                          Left: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2')
                          Right: 
                            IParameterReferenceOperation: o3 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o3')

                Next (Regular) Block[B7]
                    Leaving: {R4}
        }

        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'o1 ??= (o2 ??= o3)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o1')
                  Right: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o2 ??= o3')

            Next (Regular) Block[B8]
                Leaving: {R3} {R1}
    }
}

Block[B8] - Exit
    Predecessors: [B2] [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,35604,35657);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,35673,35771);

f_22014_35673_35770(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,30266,35782);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,30266,35782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,30266,35782);
}
		}

[Fact]
        public void CoalesceAssignmentOperation_PropertyAssignment_ReferenceTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,35794,38885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,35910,36051);

var 
source = @"
class C
{
    object Prop { get; set; }
    void M(C c)
    /*<bind>*/{
        c.Prop ??= null;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,36067,38691);

var 
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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.Prop')
              Value: 
                IPropertyReferenceOperation: System.Object C.Prop { get; set; } (OperationKind.PropertyReference, Type: System.Object) (Syntax: 'c.Prop')
                  Instance Receiver: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
        Next (Regular) Block[B2]
            Entering: {R2}
    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.Prop')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c.Prop')
            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c.Prop')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c.Prop')
                Leaving: {R2}
            Next (Regular) Block[B4]
                Leaving: {R2} {R1}
    }
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'c.Prop ??= null')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c.Prop')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Next (Regular) Block[B4]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,38707,38760);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,38776,38874);

f_22014_38776_38873(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,35794,38885);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,35794,38885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,35794,38885);
}
		}

[Fact]
        public void CoalesceAssignmentOperation_PropertyAssignment_NullableValueTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22014,38897,44956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,39017,39187);

var 
source = @"
using System;
class C
{
    int? Prop { get; set; }
    void M(C c)
    /*<bind>*/{
        Console.WriteLine(c.Prop ??= 1);
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,39203,44762);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}
.locals {R1}
{
    CaptureIds: [2]
    .locals {R2}
    {
        CaptureIds: [0] [1] [3]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (3)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.Prop')
                  Value: 
                    IPropertyReferenceOperation: System.Int32? C.Prop { get; set; } (OperationKind.PropertyReference, Type: System.Int32?) (Syntax: 'c.Prop')
                      Instance Receiver: 
                        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.Prop')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'c.Prop')
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.Prop')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'c.Prop')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'c.Prop')
                      Arguments(0)
            Jump if False (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean System.Int32?.HasValue.get) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'c.Prop')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'c.Prop')
                  Arguments(0)
                Entering: {R3}
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.Prop ??= 1')
                  Value: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'c.Prop')
            Next (Regular) Block[B4]
                Leaving: {R2}
        .locals {R3}
        {
            CaptureIds: [4]
            Block[B3] - Block
                Predecessors: [B1]
                Statements (3)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.Prop ??= 1')
                      Value: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32?, IsImplicit) (Syntax: 'c.Prop ??= 1')
                      Left: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'c.Prop')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: '1')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNullable)
                          Operand: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '1')
                Next (Regular) Block[B4]
                    Leaving: {R3} {R2}
        }
    }
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... rop ??= 1);')
              Expression: 
                IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... Prop ??= 1)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c.Prop ??= 1')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'c.Prop ??= 1')
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,44778,44831);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22014,44847,44945);

f_22014_44847_44944(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22014,38897,44956);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22014,38897,44956);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22014,38897,44956);
}
		}

int
f_22014_1242_1362(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 1242, 1362);
return 0;
}


int
f_22014_2390_2510(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 2390, 2510);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_3423_3474(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 3423, 3474);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_3423_3510(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 3423, 3510);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_3423_3530(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 3423, 3530);
return return_v;
}


int
f_22014_3562_3682(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 3562, 3682);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_4611_4662(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 4611, 4662);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_4611_4700(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 4611, 4700);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_4611_4720(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 4611, 4720);
return return_v;
}


int
f_22014_4752_4872(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 4752, 4872);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_5735_5783(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 5735, 5783);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_5735_5803(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 5735, 5803);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_5735_5823(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 5735, 5823);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_6003_6051(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 6003, 6051);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_6003_6071(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 6003, 6071);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_6003_6091(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 6003, 6091);
return return_v;
}


int
f_22014_6123_6243(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 6123, 6243);
return 0;
}


int
f_22014_7662_7782(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 7662, 7782);
return 0;
}


int
f_22014_8539_8659(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 8539, 8659);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22014_8786_8895(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 8786, 8895);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_9479_9524(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 9479, 9524);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_9479_9545(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 9479, 9545);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_9479_9564(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 9479, 9564);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_9714_9760(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 9714, 9760);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_9714_9779(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 9714, 9779);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_9714_9799(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 9714, 9799);
return return_v;
}


int
f_22014_9831_9949(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 9831, 9949);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
f_22014_9977_9993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22014, 9977, 9993);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22014_10019_10033(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 10019, 10033);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22014_10019_10051(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 10019, 10051);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22014_10019_10085(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 10019, 10085);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22014_10019_10094(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 10019, 10094);
return return_v;
}


int
f_22014_10109_12119(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 10109, 12119);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22014_12296_12426(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 12296, 12426);
return return_v;
}


int
f_22014_12443_13143(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics:expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 12443, 13143);
return 0;
}


int
f_22014_15403_15463(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 15403, 15463);
return 0;
}


int
f_22014_18282_18379(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 18282, 18379);
return 0;
}


int
f_22014_23125_23222(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 23125, 23222);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_30037_30093(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 30037, 30093);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22014_30037_30113(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 30037, 30113);
return return_v;
}


int
f_22014_30145_30242(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 30145, 30242);
return 0;
}


int
f_22014_35673_35770(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 35673, 35770);
return 0;
}


int
f_22014_38776_38873(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 38776, 38873);
return 0;
}


int
f_22014_44847_44944(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22014, 44847, 44944);
return 0;
}

}
}
