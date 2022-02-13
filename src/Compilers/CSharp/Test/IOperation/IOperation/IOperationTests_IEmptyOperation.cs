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
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TestEmptyStatementInWhile()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22030,471,1204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22030,630,800);

string 
source = @"
using System;

class C
{
    void M(string s)
    {
        while (true)
        /*<bind>*/{
            ;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22030,814,867);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22030,883,1073);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IEmptyOperation (OperationKind.Empty, Type: null) (Syntax: ';')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22030,1087,1193);

f_22030_1087_1192(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22030,471,1204);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22030,471,1204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22030,471,1204);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void EmptyFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22030,1216,2164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22030,1362,1532);

string 
source = @"
using System;

class C
{
    void M(string s)
    /*<bind>*/{
        while (true)
        {
            ;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22030,1546,1599);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22030,1615,2041);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B1]
    Statements (0)
    Jump if False (Regular) to Block[B2]
        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B1]
Block[B2] - Exit [UnReachable]
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22030,2055,2153);

f_22030_2055_2152(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22030,1216,2164);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22030,1216,2164);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22030,1216,2164);
}
		}

int
f_22030_1087_1192(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22030, 1087, 1192);
return 0;
}


int
f_22030_2055_2152(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22030, 2055, 2152);
return 0;
}

}
}
