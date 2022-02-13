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
[Fact]
        public void PatternIndexAndRangeIndexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22037,664,6597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,746,982);

var 
src = @"
class C
{
    public int Length => 0;
    public int this[int i] => i;
    public int Slice(int i, int j) => i;
    public void M()
    /*<bind*/{
        _ = this[^0];
        _ = this[0..];
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,996,1047);

var 
comp = f_22037_1007_1046(src)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,1061,3475);

const string 
expectedOperationTree = @"
IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '_ = this[^0];')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '_ = this[^0]')
        Left: 
          IDiscardOperation (Symbol: System.Int32 _) (OperationKind.Discard, Type: System.Int32) (Syntax: '_')
        Right: 
          IOperation:  (OperationKind.None, Type: null) (Syntax: 'this[^0]')
            Children(2):
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
                IUnaryOperation (UnaryOperatorKind.Hat) (OperationKind.Unary, Type: System.Index) (Syntax: '^0')
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '_ = this[0..];')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '_ = this[0..]')
        Left: 
          IDiscardOperation (Symbol: System.Int32 _) (OperationKind.Discard, Type: System.Int32) (Syntax: '_')
        Right: 
          IOperation:  (OperationKind.None, Type: null) (Syntax: 'this[0..]')
            Children(2):
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '0..')
                  LeftOperand: 
                    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index, IsImplicit) (Syntax: '0')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                  RightOperand: 
                    null"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,3489,3600);

f_22037_3489_3599(comp, expectedOperationTree, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,3616,3727);

f_22037_3616_3726(comp, expectedOperationTree, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,3743,6509);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '_ = this[^0];')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '_ = this[^0]')
              Left: 
                IDiscardOperation (Symbol: System.Int32 _) (OperationKind.Discard, Type: System.Int32) (Syntax: '_')
              Right: 
                IOperation:  (OperationKind.None, Type: null) (Syntax: 'this[^0]')
                  Children(2):
                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
                      IUnaryOperation (UnaryOperatorKind.Hat) (OperationKind.Unary, Type: System.Index) (Syntax: '^0')
                        Operand: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '_ = this[0..];')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '_ = this[0..]')
              Left: 
                IDiscardOperation (Symbol: System.Int32 _) (OperationKind.Discard, Type: System.Int32) (Syntax: '_')
              Right: 
                IOperation:  (OperationKind.None, Type: null) (Syntax: 'this[0..]')
                  Children(2):
                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
                      IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '0..')
                        LeftOperand: 
                          IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index, IsImplicit) (Syntax: '0')
                            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
                              (ImplicitUserDefined)
                            Operand: 
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                        RightOperand: 
                          null
    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,6525,6586);

f_22037_6525_6585(comp, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22037,664,6597);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22037,664,6597);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22037,664,6597);
}
		}

[Fact]
        public void FromEndIndexFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22037,6609,9160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,6683,6797);

var 
source = @"
class Test
{
    void M(int arg)
    /*<bind>*/{
        var x = ^arg;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,6813,6866);

var 
compilation = f_22037_6831_6865(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,6882,7901);

var 
expectedOperationTree = @"
IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: System.Index x
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var x = ^arg;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var x = ^arg')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Index x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = ^arg')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ^arg')
                IUnaryOperation (UnaryOperatorKind.Hat) (OperationKind.Unary, Type: System.Index) (Syntax: '^arg')
                  Operand: 
                    IParameterReferenceOperation: arg (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'arg')
      Initializer: 
        null"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,7917,7962);

var 
diagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,7978,8081);

f_22037_7978_8080(compilation, expectedOperationTree, diagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,8097,9065);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Index x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Index, IsImplicit) (Syntax: 'x = ^arg')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Index, IsImplicit) (Syntax: 'x = ^arg')
              Right: 
                IUnaryOperation (UnaryOperatorKind.Hat) (OperationKind.Unary, Type: System.Index) (Syntax: '^arg')
                  Operand: 
                    IParameterReferenceOperation: arg (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'arg')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,9081,9149);

f_22037_9081_9148(compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22037,6609,9160);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22037,6609,9160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22037,6609,9160);
}
		}

[Fact]
        public void RangeFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22037,9172,16726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,9239,9460);

var 
source = @"
using System;
class Test
{
    void M(Index start, Index end)
    /*<bind>*/{
        var a = start..end;
        var b = start..;
        var c = ..end;
        var d = ..;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,9476,9537);

var 
compilation = f_22037_9494_9536(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,9553,13437);

var 
expectedOperationTree = @"
IBlockOperation (4 statements, 4 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: System.Range a
    Local_2: System.Range b
    Local_3: System.Range c
    Local_4: System.Range d
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var a = start..end;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var a = start..end')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Range a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a = start..end')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= start..end')
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: 'start..end')
                  LeftOperand: 
                    IParameterReferenceOperation: start (OperationKind.ParameterReference, Type: System.Index) (Syntax: 'start')
                  RightOperand: 
                    IParameterReferenceOperation: end (OperationKind.ParameterReference, Type: System.Index) (Syntax: 'end')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var b = start..;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var b = start..')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Range b) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'b = start..')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= start..')
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: 'start..')
                  LeftOperand: 
                    IParameterReferenceOperation: start (OperationKind.ParameterReference, Type: System.Index) (Syntax: 'start')
                  RightOperand: 
                    null
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var c = ..end;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c = ..end')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Range c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = ..end')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ..end')
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '..end')
                  LeftOperand: 
                    null
                  RightOperand: 
                    IParameterReferenceOperation: end (OperationKind.ParameterReference, Type: System.Index) (Syntax: 'end')
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var d = ..;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var d = ..')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Range d) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd = ..')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ..')
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '..')
                  LeftOperand: 
                    null
                  RightOperand: 
                    null
      Initializer: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,13453,13498);

var 
diagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,13514,13617);

f_22037_13514_13616(compilation, expectedOperationTree, diagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,13633,16631);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Range a] [System.Range b] [System.Range c] [System.Range d]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Range, IsImplicit) (Syntax: 'a = start..end')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Range, IsImplicit) (Syntax: 'a = start..end')
              Right: 
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: 'start..end')
                  LeftOperand: 
                    IParameterReferenceOperation: start (OperationKind.ParameterReference, Type: System.Index) (Syntax: 'start')
                  RightOperand: 
                    IParameterReferenceOperation: end (OperationKind.ParameterReference, Type: System.Index) (Syntax: 'end')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Range, IsImplicit) (Syntax: 'b = start..')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Range, IsImplicit) (Syntax: 'b = start..')
              Right: 
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: 'start..')
                  LeftOperand: 
                    IParameterReferenceOperation: start (OperationKind.ParameterReference, Type: System.Index) (Syntax: 'start')
                  RightOperand: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Range, IsImplicit) (Syntax: 'c = ..end')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Range, IsImplicit) (Syntax: 'c = ..end')
              Right: 
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '..end')
                  LeftOperand: 
                    null
                  RightOperand: 
                    IParameterReferenceOperation: end (OperationKind.ParameterReference, Type: System.Index) (Syntax: 'end')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Range, IsImplicit) (Syntax: 'd = ..')
              Left: 
                ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Range, IsImplicit) (Syntax: 'd = ..')
              Right: 
                IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '..')
                  LeftOperand: 
                    null
                  RightOperand: 
                    null

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22037,16647,16715);

f_22037_16647_16714(compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22037,9172,16726);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22037,9172,16726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22037,9172,16726);
}
		}

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22037_1007_1046(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 1007, 1046);
return return_v;
}


int
f_22037_3489_3599(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 3489, 3599);
return 0;
}


int
f_22037_3616_3726(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 3616, 3726);
return 0;
}


int
f_22037_6525_6585(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 6525, 6585);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22037_6831_6865(string
text)
{
var return_v = CreateCompilationWithIndex( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 6831, 6865);
return return_v;
}


int
f_22037_7978_8080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 7978, 8080);
return 0;
}


int
f_22037_9081_9148(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 9081, 9148);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22037_9494_9536(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 9494, 9536);
return return_v;
}


int
f_22037_13514_13616(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 13514, 13616);
return 0;
}


int
f_22037_16647_16714(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22037, 16647, 16714);
return 0;
}

}
}
