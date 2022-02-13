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
        public void TestIsOperator_ObjectExpressionStringType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,471,1369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,620,883);

string 
source = @"
namespace TestIsOperator
{
    class TestType
    {
    }

    class C
    {
        static void M(string myStr)
        {
            object o = myStr;
            bool b = /*<bind>*/o is string/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,897,1158);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 'o is string')
  Operand: 
    ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
  IsType: System.String
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,1172,1225);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,1241,1358);

f_22044_1241_1357(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,471,1369);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,471,1369);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,471,1369);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsOperator_IntExpressionIntType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,1381,2574);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,1524,1785);

string 
source = @"
namespace TestIsOperator
{
    class TestType
    {
    }

    class C
    {
        static void M(string myStr)
        {
            int myInt = 3;
            bool b = /*<bind>*/myInt is int/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,1799,2067);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 'myInt is int')
  Operand: 
    ILocalReferenceOperation: myInt (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'myInt')
  IsType: System.Int32
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,2081,2430);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22044_2318_2414(f_22044_2318_2393(f_22044_2318_2372(ErrorCode.WRN_IsAlwaysTrue, "myInt is int"), "int"), 13, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,2446,2563);

f_22044_2446_2562(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,1381,2574);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,1381,2574);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,1381,2574);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsOperator_ObjectExpressionUserDefinedType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,2586,3533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,2740,3035);

string 
source = @"
namespace TestIsOperator
{
    class TestType
    {
    }

    class C
    {
        static void M(string myStr)
        {
            TestType tt = null;
            object o = tt;
            bool b = /*<bind>*/o is TestType/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,3049,3322);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 'o is TestType')
  Operand: 
    ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
  IsType: TestIsOperator.TestType
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,3336,3389);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,3405,3522);

f_22044_3405_3521(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,2586,3533);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,2586,3533);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,2586,3533);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsOperator_NullExpressionUserDefinedType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,3545,4818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,3697,3995);

string 
source = @"
namespace TestIsOperator
{
    class TestType
    {
    }

    class C
    {
        static void M(string myStr)
        {
            TestType tt = null;
            object o = tt;
            bool b = /*<bind>*/null is TestType/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,4009,4278);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 'null is TestType')
  Operand: 
    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
  IsType: TestIsOperator.TestType
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,4292,4674);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22044_4537_4658(f_22044_4537_4637(f_22044_4537_4596(ErrorCode.WRN_IsAlwaysFalse, "null is TestType"), "TestIsOperator.TestType"), 14, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,4690,4807);

f_22044_4690_4806(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,3545,4818);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,3545,4818);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,3545,4818);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsOperator_IntExpressionEnumType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,4830,5921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,4974,5159);

string 
source = @"
class IsTest
{
    static void Main()
    {
        var b = /*<bind>*/1 is color/*</bind>*/;
        System.Console.WriteLine(b);
    }
}
enum color
{ }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,5173,5420);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: '1 is color')
  Operand: 
    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  IsType: color
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,5434,5777);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22044_5665_5761(f_22044_5665_5741(f_22044_5665_5718(ErrorCode.WRN_IsAlwaysFalse, "1 is color"), "color"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,5793,5910);

f_22044_5793_5909(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,4830,5921);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,4830,5921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,4830,5921);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsOperatorGeneric_TypeParameterExpressionIntType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,5933,6844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,6093,6366);

string 
source = @"
namespace TestIsOperatorGeneric
{
    class C
    {
        public static void M<T, U, W>(T t, U u)
            where T : class
            where U : class
        {
            bool test = /*<bind>*/t is int/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,6380,6633);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 't is int')
  Operand: 
    IParameterReferenceOperation: t (OperationKind.ParameterReference, Type: T) (Syntax: 't')
  IsType: System.Int32
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,6647,6700);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,6716,6833);

f_22044_6716_6832(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,5933,6844);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,5933,6844);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,5933,6844);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsOperatorGeneric_TypeParameterExpressionObjectType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,6856,7777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,7019,7295);

string 
source = @"
namespace TestIsOperatorGeneric
{
    class C
    {
        public static void M<T, U, W>(T t, U u)
            where T : class
            where U : class
        {
            bool test = /*<bind>*/u is object/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,7309,7566);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 'u is object')
  Operand: 
    IParameterReferenceOperation: u (OperationKind.ParameterReference, Type: U) (Syntax: 'u')
  IsType: System.Object
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,7580,7633);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,7649,7766);

f_22044_7649_7765(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,6856,7777);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,6856,7777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,6856,7777);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsOperatorGeneric_TypeParameterExpressionDifferentTypeParameterType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,7789,8704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,7968,8239);

string 
source = @"
namespace TestIsOperatorGeneric
{
    class C
    {
        public static void M<T, U, W>(T t, U u)
            where T : class
            where U : class
        {
            bool test = /*<bind>*/t is U/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,8253,8493);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 't is U')
  Operand: 
    IParameterReferenceOperation: t (OperationKind.ParameterReference, Type: T) (Syntax: 't')
  IsType: U
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,8507,8560);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,8576,8693);

f_22044_8576_8692(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,7789,8704);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,7789,8704);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,7789,8704);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestIsOperatorGeneric_TypeParameterExpressionSameTypeParameterType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,8716,9626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,8890,9161);

string 
source = @"
namespace TestIsOperatorGeneric
{
    class C
    {
        public static void M<T, U, W>(T t, U u)
            where T : class
            where U : class
        {
            bool test = /*<bind>*/t is T/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,9175,9415);

string 
expectedOperationTree = @"
IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 't is T')
  Operand: 
    IParameterReferenceOperation: t (OperationKind.ParameterReference, Type: T) (Syntax: 't')
  IsType: T
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,9429,9482);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,9498,9615);

f_22044_9498_9614(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,8716,9626);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,8716,9626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,8716,9626);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IsTypeFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,9638,11106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,9785,9945);

string 
source = @"
class C
{
    public static void M2(C1 c, bool b)
    /*<bind>*/{
        b = c is C1;
    }/*</bind>*/
    public class C1 { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,9961,10014);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,10030,10983);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = c is C1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = c is C1')
              Left: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
              Right: 
                IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: 'c is C1')
                  Operand: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C.C1) (Syntax: 'c')
                  IsType: C.C1

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,10997,11095);

f_22044_10997_11094(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,9638,11106);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,9638,11106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,9638,11106);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IsTypeFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22044,11118,14780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,11265,11442);

string 
source = @"
class C
{
    public static void M2(C1 c1, C1 c2, bool b)
    /*<bind>*/{
        b = (c1 ?? c2) is C1;
    }/*</bind>*/
    public class C1 { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,11458,11511);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,11527,14657);

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
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C.C1) (Syntax: 'c1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C.C1, IsImplicit) (Syntax: 'c1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C.C1, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C.C1) (Syntax: 'c2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = (c1 ?? c2) is C1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = (c1 ?? c2) is C1')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Right: 
                    IIsTypeOperation (OperationKind.IsType, Type: System.Boolean) (Syntax: '(c1 ?? c2) is C1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C.C1, IsImplicit) (Syntax: 'c1 ?? c2')
                      IsType: C.C1

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22044,14671,14769);

f_22044_14671_14768(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22044,11118,14780);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22044,11118,14780);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22044,11118,14780);
}
		}

int
f_22044_1241_1357(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 1241, 1357);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_2318_2372(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 2318, 2372);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_2318_2393(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 2318, 2393);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_2318_2414(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 2318, 2414);
return return_v;
}


int
f_22044_2446_2562(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 2446, 2562);
return 0;
}


int
f_22044_3405_3521(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 3405, 3521);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_4537_4596(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 4537, 4596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_4537_4637(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 4537, 4637);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_4537_4658(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 4537, 4658);
return return_v;
}


int
f_22044_4690_4806(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 4690, 4806);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_5665_5718(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 5665, 5718);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_5665_5741(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 5665, 5741);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22044_5665_5761(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 5665, 5761);
return return_v;
}


int
f_22044_5793_5909(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 5793, 5909);
return 0;
}


int
f_22044_6716_6832(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 6716, 6832);
return 0;
}


int
f_22044_7649_7765(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 7649, 7765);
return 0;
}


int
f_22044_8576_8692(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 8576, 8692);
return 0;
}


int
f_22044_9498_9614(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 9498, 9614);
return 0;
}


int
f_22044_10997_11094(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 10997, 11094);
return 0;
}


int
f_22044_14671_14768(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22044, 14671, 14768);
return 0;
}

}
}
