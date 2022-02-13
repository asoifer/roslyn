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
        public void ILocalReferenceExpression_OutVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22047,471,1320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,611,826);

string 
source = @"
using System;

public class C1
{
    public virtual void M1()
    {
        M2(out /*<bind>*/var i/*</bind>*/);
    }

    public void M2(out int i )
    {
        i = 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,840,1104);

string 
expectedOperationTree = @"
IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
  ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,1118,1171);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,1187,1309);

f_22047_1187_1308(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22047,471,1320);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22047,471,1320);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22047,471,1320);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILocalReferenceExpression_DeconstructionDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22047,1332,2576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,1491,1654);

string 
source = @"
using System;

public class C1
{
    public virtual void M1()
    {
        /*<bind>*/(var i1, var i2)/*</bind>*/ = (1, 2);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,1668,2366);

string 
expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(var i1, var i2)')
  NaturalType: (System.Int32 i1, System.Int32 i2)
  Elements(2):
      IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i1')
        ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
      IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i2')
        ILocalReferenceOperation: i2 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,2380,2433);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,2449,2565);

f_22047_2449_2564(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22047,1332,2576);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22047,1332,2576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22047,1332,2576);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ILocalReferenceExpression_DeconstructionDeclaration_AlternateSyntax()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22047,2588,3754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,2763,2922);

string 
source = @"
using System;

public class C1
{
    public virtual void M1()
    {
        /*<bind>*/var (i1, i2)/*</bind>*/ = (1, 2);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,2936,3538);

string 
expectedOperationTree = @"
IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: 'var (i1, i2)')
  ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
    NaturalType: (System.Int32 i1, System.Int32 i2)
    Elements(2):
        ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
        ILocalReferenceOperation: i2 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,3552,3605);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,3621,3743);

f_22047_3621_3742(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22047,2588,3754);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22047,2588,3754);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22047,2588,3754);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalReference_ParameterReference_Flow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22047,3766,5643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,3938,4079);

string 
source = @"
public class C
{
    public void M(int p)
    /*<bind>*/{
        var l = p;
        p = l;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,4093,5451);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 l]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'l = p')
              Left: 
                ILocalReferenceOperation: l (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'l = p')
              Right: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = l;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = l')
                  Left: 
                    IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
                  Right: 
                    ILocalReferenceOperation: l (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'l')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,5465,5518);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22047,5534,5632);

f_22047_5534_5631(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22047,3766,5643);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22047,3766,5643);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22047,3766,5643);
}
		}

int
f_22047_1187_1308(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<DeclarationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22047, 1187, 1308);
return 0;
}


int
f_22047_2449_2564(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22047, 2449, 2564);
return 0;
}


int
f_22047_3621_3742(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<DeclarationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22047, 3621, 3742);
return 0;
}


int
f_22047_5534_5631(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22047, 5534, 5631);
return 0;
}

}
}
