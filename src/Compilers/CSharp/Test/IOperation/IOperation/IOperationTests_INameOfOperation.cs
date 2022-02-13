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
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NameOfFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22051,503,2421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,650,802);

string 
source = @"
class C
{
    void M(bool b, int i1, int i2)
    /*<bind>*/{
        string test = nameof(b ? i1 : i2);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,816,1374);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22051_1013_1093(f_22051_1013_1073(ErrorCode.ERR_ExpressionHasNoName, "b ? i1 : i2"), 6, 30),
f_22051_1263_1358(f_22051_1263_1338(f_22051_1263_1316(ErrorCode.WRN_UnreferencedVarAssg, "test"), "test"), 6, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,1390,2298);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.String test]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsInvalid, IsImplicit) (Syntax: 'test = name ...  ? i1 : i2)')
              Left: 
                ILocalReferenceOperation: test (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsInvalid, IsImplicit) (Syntax: 'test = name ...  ? i1 : i2)')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """", IsInvalid) (Syntax: 'nameof(b ? i1 : i2)')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,2312,2410);

f_22051_2312_2409(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22051,503,2421);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22051,503,2421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22051,503,2421);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NameOfFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22051,2433,4036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,2580,2707);

string 
source = @"
class C
{
    void M(int i1)
    /*<bind>*/{
        string test = nameof(i1);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,2721,3047);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22051_2936_3031(f_22051_2936_3011(f_22051_2936_2989(ErrorCode.WRN_UnreferencedVarAssg, "test"), "test"), 6, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,3063,3913);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.String test]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsImplicit) (Syntax: 'test = nameof(i1)')
              Left: 
                ILocalReferenceOperation: test (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'test = nameof(i1)')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""i1"") (Syntax: 'nameof(i1)')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,3927,4025);

f_22051_3927_4024(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22051,2433,4036);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22051,2433,4036);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22051,2433,4036);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NameOfFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22051,4048,6506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,4195,4355);

string 
source = @"
class C
{
    void M(bool b, int i1, int i2)
    /*<bind>*/{
        string test = b ? nameof(i1) : nameof(i2);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,4369,4422);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,4438,6383);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.String test]
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'nameof(i1)')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""i1"") (Syntax: 'nameof(i1)')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'nameof(i2)')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""i2"") (Syntax: 'nameof(i2)')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsImplicit) (Syntax: 'test = b ?  ...  nameof(i2)')
              Left: 
                ILocalReferenceOperation: test (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'test = b ?  ...  nameof(i2)')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'b ? nameof( ...  nameof(i2)')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22051,6397,6495);

f_22051_6397_6494(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22051,4048,6506);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22051,4048,6506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22051,4048,6506);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22051_1013_1073(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 1013, 1073);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22051_1013_1093(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 1013, 1093);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22051_1263_1316(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 1263, 1316);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22051_1263_1338(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 1263, 1338);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22051_1263_1358(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 1263, 1358);
return return_v;
}


int
f_22051_2312_2409(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 2312, 2409);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22051_2936_2989(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 2936, 2989);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22051_2936_3011(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 2936, 3011);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22051_2936_3031(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 2936, 3031);
return return_v;
}


int
f_22051_3927_4024(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 3927, 4024);
return 0;
}


int
f_22051_6397_6494(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22051, 6397, 6494);
return 0;
}

}
}
