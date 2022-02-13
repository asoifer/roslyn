// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.CSharp.UnitTests;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.Semantic.UnitTests.IOperation
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void PointerIndirectionFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22060,681,2127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22060,840,995);

string 
source = @"
class C
{
    unsafe static void M(S s, S* sp)
    /*<bind>*/
    {
        s = *sp;
    }/*</bind>*/

     struct S { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22060,1009,1062);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22060,1078,1956);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 's = *sp;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C.S) (Syntax: 's = *sp')
              Left: 
                IParameterReferenceOperation: s (OperationKind.ParameterReference, Type: C.S) (Syntax: 's')
              Right: 
                IOperation:  (OperationKind.None, Type: null) (Syntax: '*sp')
                  Children(1):
                      IParameterReferenceOperation: sp (OperationKind.ParameterReference, Type: C.S*) (Syntax: 'sp')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22060,1970,2116);

f_22060_1970_2115(source, expectedFlowGraph, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22060,681,2127);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22060,681,2127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22060,681,2127);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void PointerIndirectionFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22060,2139,4662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22060,2298,2491);

string 
source = @"
class C
{
    unsafe static void M(S* sp, int i)
    /*<bind>*/
    {
        sp->x = 1;
        i = sp->x;
    }/*</bind>*/

     struct S { public int x; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22060,2505,2558);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22060,2574,4491);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'sp->x = 1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'sp->x = 1')
              Left: 
                IFieldReferenceOperation: System.Int32 C.S.x (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'sp->x')
                  Instance Receiver: 
                    IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: 'sp')
                      Children(1):
                          IParameterReferenceOperation: sp (OperationKind.ParameterReference, Type: C.S*) (Syntax: 'sp')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = sp->x;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = sp->x')
              Left: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                IFieldReferenceOperation: System.Int32 C.S.x (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'sp->x')
                  Instance Receiver: 
                    IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: 'sp')
                      Children(1):
                          IParameterReferenceOperation: sp (OperationKind.ParameterReference, Type: C.S*) (Syntax: 'sp')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22060,4505,4651);

f_22060_4505_4650(source, expectedFlowGraph, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22060,2139,4662);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22060,2139,4662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22060,2139,4662);
}
		}

public IOperationTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(22060,515,4669);
DynAbs.Tracing.TraceSender.TraceExitConstructor(22060,515,4669);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22060,515,4669);
}


static IOperationTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(22060,515,4669);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(22060,515,4669);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22060,515,4669);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(22060,515,4669);

int
f_22060_1970_2115(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22060, 1970, 2115);
return 0;
}


int
f_22060_4505_4650(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22060, 4505, 4650);
return 0;
}

}
}
