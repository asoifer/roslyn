// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests_Patterns : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void LocalsInSwitch_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,563,1986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,688,904);

string 
source = @"
using System;

class Program
{
    static void M(int input)
    {
        /*<bind>*/switch (input)
        {
            case 1:
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,918,1776);

string 
expectedOperationTree = @"
ISwitchOperation (1 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null) (Syntax: 'switch (inp ... }')
  Switch expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
  Sections:
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case 1: ... break;')
          Clauses:
              ISingleValueCaseClauseOperation (Label Id: 1) (CaseKind.SingleValue) (OperationKind.CaseClause, Type: null) (Syntax: 'case 1:')
                Value: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,1790,1843);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,1859,1975);

f_22065_1859_1974(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,563,1986);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,563,1986);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,563,1986);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void LocalsInSwitch_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,1998,4871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,2123,2395);

string 
source = @"
using System;

class Program
{
    static void M(int input)
    {
        /*<bind>*/switch (input)
        {
            case 1:
                var x = 3;
                input = x;
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,2409,4661);

string 
expectedOperationTree = @"
ISwitchOperation (1 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null) (Syntax: 'switch (inp ... }')
  Switch expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
  Locals: Local_1: System.Int32 x
  Sections:
      ISwitchCaseOperation (1 case clauses, 3 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case 1: ... break;')
          Clauses:
              ISingleValueCaseClauseOperation (Label Id: 1) (CaseKind.SingleValue) (OperationKind.CaseClause, Type: null) (Syntax: 'case 1:')
                Value: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          Body:
              IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var x = 3;')
                IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var x = 3')
                  Declarators:
                      IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = 3')
                        Initializer: 
                          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 3')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                  Initializer: 
                    null
              IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input = x;')
                Expression: 
                  ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'input = x')
                    Left: 
                      IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
                    Right: 
                      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,4675,4728);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,4744,4860);

f_22065_4744_4859(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,1998,4871);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,1998,4871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,1998,4871);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void LocalsInSwitch_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,4883,6918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,5008,5257);

string 
source = @"
using System;

class Program
{
    static void M(object input)
    {
        /*<bind>*/switch (input)
        {
            case int x:
            case long y:
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,5271,6708);

string 
expectedOperationTree = @"
ISwitchOperation (1 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null) (Syntax: 'switch (inp ... }')
  Switch expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')
  Sections:
      ISwitchCaseOperation (2 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case int x: ... break;')
        Locals: Local_1: System.Int32 x
          Local_2: System.Int64 y
          Clauses:
              IPatternCaseClauseOperation (Label Id: 1) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case int x:')
                Pattern: 
                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
              IPatternCaseClauseOperation (Label Id: 2) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case long y:')
                Pattern: 
                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'long y') (InputType: System.Object, NarrowedType: System.Int64, DeclaredSymbol: System.Int64 y, MatchesNull: False)
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,6722,6775);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,6791,6907);

f_22065_6791_6906(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,4883,6918);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,4883,6918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,4883,6918);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void LocalsInSwitch_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,6930,10669);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,7055,7338);

string 
source = @"
using System;

class Program
{
    static void M(object input)
    {
        /*<bind>*/switch (input)
        {
            case int y:
                var x = 3;
                input = x + y;
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,7352,10459);

string 
expectedOperationTree = @"
ISwitchOperation (1 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null) (Syntax: 'switch (inp ... }')
  Switch expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')
  Locals: Local_1: System.Int32 x
  Sections:
      ISwitchCaseOperation (1 case clauses, 3 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case int y: ... break;')
        Locals: Local_1: System.Int32 y
          Clauses:
              IPatternCaseClauseOperation (Label Id: 1) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case int y:')
                Pattern: 
                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int y') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: False)
          Body:
              IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var x = 3;')
                IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var x = 3')
                  Declarators:
                      IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = 3')
                        Initializer: 
                          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 3')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                  Initializer: 
                    null
              IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input = x + y;')
                Expression: 
                  ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'input = x + y')
                    Left: 
                      IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')
                    Right: 
                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'x + y')
                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        Operand: 
                          IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + y')
                            Left: 
                              ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                            Right: 
                              ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,10473,10526);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,10542,10658);

f_22065_10542_10657(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,6930,10669);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,6930,10669);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,6930,10669);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void LabelsInSwitch_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,10681,12725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,10806,11073);

string 
source = @"
using System;

class Program
{
    static void M(int input)
    {
        /*<bind>*/switch (input)
        {
            case 1:
                goto case 2;
            case 2:
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,11087,12515);

string 
expectedOperationTree = @"
ISwitchOperation (2 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null) (Syntax: 'switch (inp ... }')
  Switch expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
  Sections:
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case 1: ... oto case 2;')
          Clauses:
              ISingleValueCaseClauseOperation (Label Id: 1) (CaseKind.SingleValue) (OperationKind.CaseClause, Type: null) (Syntax: 'case 1:')
                Value: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          Body:
              IBranchOperation (BranchKind.GoTo, Label Id: 2) (OperationKind.Branch, Type: null) (Syntax: 'goto case 2;')
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case 2: ... break;')
          Clauses:
              ISingleValueCaseClauseOperation (Label Id: 2) (CaseKind.SingleValue) (OperationKind.CaseClause, Type: null) (Syntax: 'case 2:')
                Value: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,12529,12582);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,12598,12714);

f_22065_12598_12713(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,10681,12725);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,10681,12725);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,10681,12725);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void LabelsInSwitch_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,12737,14645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,12862,13131);

string 
source = @"
using System;

class Program
{
    static void M(int input)
    {
        /*<bind>*/switch (input)
        {
            case 1:
                goto default;
            default:
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,13145,14435);

string 
expectedOperationTree = @"
ISwitchOperation (2 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null) (Syntax: 'switch (inp ... }')
  Switch expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
  Sections:
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case 1: ... to default;')
          Clauses:
              ISingleValueCaseClauseOperation (Label Id: 1) (CaseKind.SingleValue) (OperationKind.CaseClause, Type: null) (Syntax: 'case 1:')
                Value: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          Body:
              IBranchOperation (BranchKind.GoTo, Label Id: 2) (OperationKind.Branch, Type: null) (Syntax: 'goto default;')
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'default: ... break;')
          Clauses:
              IDefaultCaseClauseOperation (Label Id: 2) (CaseKind.Default) (OperationKind.CaseClause, Type: null) (Syntax: 'default:')
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,14449,14502);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,14518,14634);

f_22065_14518_14633(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,12737,14645);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,12737,14645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,12737,14645);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,14657,16468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,14804,15056);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            default:
                result = true;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,15070,15123);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,15139,16345);

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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,16359,16457);

f_22065_16359_16456(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,14657,16468);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,14657,16468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,14657,16468);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,16480,19667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,16627,16957);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            default:
                result = true;
                break;
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,16971,17024);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,17040,19544);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B2]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R1}
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,19558,19656);

f_22065_19558_19655(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,16480,19667);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,16480,19667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,16480,19667);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,19679,22866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,19826,20156);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                result = false;
                break;
            default:
                result = true;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,20170,20223);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,20239,22743);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B4]
            Leaving: {R1}
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,22757,22855);

f_22065_22757_22854(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,19679,22866);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,19679,22866);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,19679,22866);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,22878,25300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,23025,23277);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,23291,23344);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,23360,25177);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,25191,25289);

f_22065_25191_25288(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,22878,25300);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,22878,25300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,22878,25300);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,25312,29990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,25459,25817);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 0:
                bool x = true;
                result = x;
                break;
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,25831,25884);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,25900,29867);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Boolean x]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '0')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsImplicit) (Syntax: 'x = true')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'x = true')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = x')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'x')

            Next (Regular) Block[B6]
                Leaving: {R2} {R1}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if False (Regular) to Block[B6]
                IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Leaving: {R2} {R1}

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B6]
                Leaving: {R2} {R1}
    }
}

Block[B6] - Exit
    Predecessors: [B3] [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,29881,29979);

f_22065_29881_29978(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,25312,29990);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,25312,29990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,25312,29990);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,30002,32416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,30149,30423);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            default:
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,30437,30490);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,30506,32293);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B2]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1*2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,32307,32405);

f_22065_32307_32404(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,30002,32416);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,30002,32416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,30002,32416);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,32428,34842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,32575,32849);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
            default:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,32863,32916);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,32932,34719);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B2]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1*2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,34733,34831);

f_22065_34733_34830(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,32428,34842);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,32428,34842);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,32428,34842);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,34854,37869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,35001,35296);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 2:
            default:
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,35310,35363);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,35379,37746);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B2]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '2')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B1] [B2*2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,37760,37858);

f_22065_37760_37857(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,34854,37869);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,34854,37869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,34854,37869);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,37881,42331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,38028,38461);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                goto case 3;
            case 2:
                goto default;
            case 3:
                result = true;
                break;
            default:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,38475,38528);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,38544,42208);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B2]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '2')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B5]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '3')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B1] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B6]
            Leaving: {R1}
    Block[B5] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,42222,42320);

f_22065_42222_42319(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,37881,42331);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,37881,42331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,37881,42331);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,42343,44971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,42490,42715);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                goto case 3;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,42729,43328);

var 
expectedDiagnostics = new[] {
f_22065_42941_43041(f_22065_42941_43021(f_22065_42941_42996(ErrorCode.ERR_LabelNotFound, "goto case 3;"), "case 3:"), 9, 17),
f_22065_43217_43312(f_22065_43217_43292(f_22065_43217_43267(ErrorCode.ERR_SwitchFallOut, "case 1:"), "case 1:"), 8, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,43344,44848);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (2)
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')

            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto case 3;')
              Children(0)

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,44862,44960);

f_22065_44862_44959(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,42343,44971);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,42343,44971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,42343,44971);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,44983,49950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,45130,45541);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, long input)
    /*<bind>*/{
        switch (input)
        {
            default:
                result = false;
                break;
            case 1:
                result = result;
                break;
            default:
                result = true;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,45555,46170);

var 
expectedDiagnostics = new[] {
f_22065_45773_45875(f_22065_45773_45854(f_22065_45773_45829(ErrorCode.ERR_DuplicateCaseLabel, "default:"), "default"), 14, 13),
f_22065_46072_46154(f_22065_46072_46133(ErrorCode.WRN_AssignmentToSelf, "result = result"), 12, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,46186,49827);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'input')

        Jump if False (Regular) to Block[B2]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int64, IsImplicit) (Syntax: 'input')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 1, IsImplicit) (Syntax: '1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitNumeric)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B5]
            Leaving: {R1}
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = result;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = result')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')

        Next (Regular) Block[B5]
            Leaving: {R1}
    Block[B4] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B2] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,49841,49939);

f_22065_49841_49938(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,44983,49950);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,44983,49950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,44983,49950);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,49962,53114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,50109,50362);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 1L:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,50376,50736);

var 
expectedDiagnostics = new[] {
f_22065_50621_50720(f_22065_50621_50700(f_22065_50621_50671(ErrorCode.ERR_NoImplicitConvCast, "1L"), "long", "int"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,50752,52991);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: '1L')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 1, IsInvalid, IsImplicit) (Syntax: '1L')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (ExplicitNumeric)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int64, Constant: 1, IsInvalid) (Syntax: '1L')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,53005,53103);

f_22065_53005_53102(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,49962,53114);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,49962,53114);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,49962,53114);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,53126,56312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,53273,53867);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, MyClass input, MyClass other)
    /*<bind>*/{
        switch (input)
        {
            case other:
                result = false;
                break;
        }
    }/*</bind>*/

    public static bool operator ==(MyClass x, MyClass y) => false;
    public static bool operator !=(MyClass x, MyClass y) => true;
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,53881,54141);

var 
expectedDiagnostics = new[] {
f_22065_54054_54125(f_22065_54054_54105(ErrorCode.ERR_ConstantExpected, "other"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,54157,56189);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyClass) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'other')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid, IsImplicit) (Syntax: 'other') (InputType: MyClass, NarrowedType: MyClass)
                  Value: 
                    IParameterReferenceOperation: other (OperationKind.ParameterReference, Type: MyClass, IsInvalid) (Syntax: 'other')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,56203,56301);

f_22065_56203_56300(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,53126,56312);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,53126,56312);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,53126,56312);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,56324,59899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,56471,57040);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, MyClass input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/

    public static bool operator ==(MyClass x, long y) => false;
    public static bool operator !=(MyClass x, long y) => true;
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,57054,57357);

var 
expectedDiagnostics = new[] {
f_22065_57244_57341(f_22065_57244_57321(f_22065_57244_57289(ErrorCode.ERR_NoImplicitConv, "1"), "int", "MyClass"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,57373,59776);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyClass) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: '1')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid, IsImplicit) (Syntax: '1') (InputType: MyClass, NarrowedType: MyClass)
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: MyClass, IsInvalid, IsImplicit) (Syntax: '1')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,59790,59888);

f_22065_59790_59887(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,56324,59899);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,56324,59899);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,56324,59899);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,59911,63721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,60058,60378);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, MyClass input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/

    public static implicit operator MyClass(long x) => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,60392,60644);

var 
expectedDiagnostics = new[] {
f_22065_60561_60628(f_22065_60561_60608(ErrorCode.ERR_ConstantExpected, "1"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,60660,63598);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyClass) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: '1')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid, IsImplicit) (Syntax: '1') (InputType: MyClass, NarrowedType: MyClass)
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: MyClass MyClass.op_Implicit(System.Int64 x)) (OperationKind.Conversion, Type: MyClass, IsInvalid, IsImplicit) (Syntax: '1')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: MyClass MyClass.op_Implicit(System.Int64 x))
                        (ImplicitUserDefined)
                      Operand: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, Constant: 1, IsInvalid, IsImplicit) (Syntax: '1')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNumeric)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,63612,63710);

f_22065_63612_63709(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,59911,63721);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,59911,63721);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,59911,63721);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,63733,66081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,63880,64062);

string 
source = @"
public sealed class MyClass
{
    void M(bool result)
    /*<bind>*/{
            case 1:
                result = false;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,64076,64880);

var 
expectedDiagnostics = new[] {
f_22065_64223_64287(f_22065_64223_64267(ErrorCode.ERR_RbraceExpected, ""), 5, 16),
f_22065_64406_64474(f_22065_64406_64454(ErrorCode.ERR_SemicolonExpected, ":"), 6, 19),
f_22065_64593_64658(f_22065_64593_64638(ErrorCode.ERR_RbraceExpected, ":"), 6, 19),
f_22065_64802_64864(f_22065_64802_64844(ErrorCode.ERR_EOFExpected, "}"), 10, 1)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,64896,65958);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '1')
          Expression: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,65972,66070);

f_22065_65972_66069(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,63733,66081);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,63733,66081);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,63733,66081);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,66093,68500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,66240,66423);

string 
source = @"
public sealed class MyClass
{
    void M(bool result)
    /*<bind>*/{
            default:
                result = false;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,66437,67305);

var 
expectedDiagnostics = new[] {
f_22065_66627_66710(f_22065_66627_66690(ErrorCode.ERR_DefaultLiteralNoTargetType, "default"), 6, 13),
f_22065_66830_66898(f_22065_66830_66878(ErrorCode.ERR_SemicolonExpected, ":"), 6, 20),
f_22065_67018_67083(f_22065_67018_67063(ErrorCode.ERR_RbraceExpected, ":"), 6, 20),
f_22065_67227_67289(f_22065_67227_67269(ErrorCode.ERR_EOFExpected, "}"), 10, 1)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,67321,68377);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'default')
          Expression: 
            IDefaultValueOperation (OperationKind.DefaultValue, Type: ?, IsInvalid) (Syntax: 'default')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,68391,68489);

f_22065_68391_68488(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,66093,68500);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,66093,68500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,66093,68500);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,68512,71323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,68659,68912);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int? input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,68926,68979);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,68995,71200);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals, IsLifted) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: '1')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitNullable)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,71214,71312);

f_22065_71214_71311(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,68512,71323);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,68512,71323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,68512,71323);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,71335,74154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,71482,71738);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int? input)
    /*<bind>*/{
        switch (input)
        {
            case null:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,71752,71805);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,71821,74031);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')
        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals, IsLifted) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: 'null')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NullLiteral)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
            Leaving: {R1}
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
        Next (Regular) Block[B3]
            Leaving: {R1}
}
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,74045,74143);

f_22065_74045_74142(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,71335,74154);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,71335,74154);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,71335,74154);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,74166,76871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,74313,74582);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int? input, int? other)
    /*<bind>*/{
        switch (input)
        {
            case other:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,74596,74856);

var 
expectedDiagnostics = new[] {
f_22065_74769_74840(f_22065_74769_74820(ErrorCode.ERR_ConstantExpected, "other"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,74872,76748);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals, IsLifted) (OperationKind.Binary, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'other')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
              Right: 
                IParameterReferenceOperation: other (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'other')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,76762,76860);

f_22065_76762_76859(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,74166,76871);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,74166,76871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,74166,76871);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_21()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,76883,80283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,77030,77298);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input, int? other)
    /*<bind>*/{
        switch (input)
        {
            case other:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,77312,77890);

var 
expectedDiagnostics = new[] {
f_22065_77560_77662(f_22065_77560_77642(f_22065_77560_77613(ErrorCode.ERR_NoImplicitConvCast, "other"), "int?", "int"), 8, 18),
f_22065_77803_77874(f_22065_77803_77854(ErrorCode.ERR_ConstantExpected, "other"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,77906,80160);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'other')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'other')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (ExplicitNullable)
                  Operand: 
                    IParameterReferenceOperation: other (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'other')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,80174,80272);

f_22065_80174_80271(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,76883,80283);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,76883,80283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,76883,80283);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_22()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,80295,82885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,80442,80698);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, dynamic input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,80712,80765);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,80781,82762);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsImplicit) (Syntax: '1') (InputType: dynamic, NarrowedType: System.Int32)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,82776,82874);

f_22065_82776_82873(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,80295,82885);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,80295,82885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,80295,82885);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchIOperation_022()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,82897,85165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,83051,83307);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, dynamic input)
    {
        /*<bind>*/switch (input)
        {
            case 1:
                result = false;
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,83321,83374);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,83388,85024);

var 
expectedOperationTree =
@"
ISwitchOperation (1 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null) (Syntax: 'switch (inp ... }')
  Switch expression: 
    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'input')
  Sections:
      ISwitchCaseOperation (1 case clauses, 2 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case 1: ... break;')
          Clauses:
              IPatternCaseClauseOperation (Label Id: 1) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case 1:')
                Pattern: 
                  IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsImplicit) (Syntax: '1') (InputType: dynamic, NarrowedType: System.Int32)
                    Value: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          Body:
              IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                Expression: 
                  ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                    Left: 
                      IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                    Right: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,85038,85154);

f_22065_85038_85153(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,82897,85165);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,82897,85165);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,82897,85165);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_23()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,85177,88044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,85324,85599);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, dynamic input, dynamic other)
    /*<bind>*/{
        switch (input)
        {
            case other:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,85613,85873);

var 
expectedDiagnostics = new[] {
f_22065_85786_85857(f_22065_85786_85837(ErrorCode.ERR_ConstantExpected, "other"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,85889,87921);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'other')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid, IsImplicit) (Syntax: 'other') (InputType: dynamic, NarrowedType: dynamic)
                  Value: 
                    IParameterReferenceOperation: other (OperationKind.ParameterReference, Type: dynamic, IsInvalid) (Syntax: 'other')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,87935,88033);

f_22065_87935_88032(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,85177,88044);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,85177,88044);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,85177,88044);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_24()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,88056,92155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,88203,88480);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int? input1, int input2)
    /*<bind>*/{
        switch (input1 ?? input2)
        {
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,88494,88547);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,88563,92032);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
                  Value: 
                    IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input1')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input1')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'input1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input1')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
              Value: 
                IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B6]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input1 ?? input2')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,92046,92144);

f_22065_92046_92143(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,88056,92155);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,88056,92155);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,88056,92155);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_25()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,92167,97357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,92314,92608);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int? input1, int input2, int input3)
    /*<bind>*/{
        switch (input3)
        {
            case input1 ?? input2:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,92622,92904);

var 
expectedDiagnostics = new[] {
f_22065_92806_92888(f_22065_92806_92868(ErrorCode.ERR_ConstantExpected, "input1 ?? input2"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,92920,97234);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input3')
              Value: 
                IParameterReferenceOperation: input3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input3')

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
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input1')
                      Value: 
                        IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'input1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'input1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'input1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input1')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'input1')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'input1')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input2')
                  Value: 
                    IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'input2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'input1 ?? input2')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input3')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'input1 ?? input2')
                Leaving: {R2} {R1}

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,97248,97346);

f_22065_97248_97345(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,92167,97357);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,92167,97357);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,92167,97357);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_26()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,97369,100642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,97516,97777);

string 
source = @"
public sealed class MyClass
{
    void M(int input1, MyClass input2)
    /*<bind>*/{
        switch (input1)
        {
            case 1:
                input2?.ToString();
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,97791,97844);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,97860,100519);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
              Value: 
                IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input1')

        Jump if False (Regular) to Block[B4]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
                  Value: 
                    IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: MyClass) (Syntax: 'input2')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input2')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'input2')
                Leaving: {R2} {R1}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input2?.ToString();')
                  Expression: 
                    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '.ToString()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'input2')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,100533,100631);

f_22065_100533_100630(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,97369,100642);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,97369,100642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,97369,100642);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_27()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,100654,103261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,100801,101056);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, object input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,101070,101123);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,101139,103138);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsImplicit) (Syntax: '1') (InputType: System.Object, NarrowedType: System.Int32)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,103152,103250);

f_22065_103152_103249(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,100654,103261);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,100654,103261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,100654,103261);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_28()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,103273,109011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,103420,103696);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, object input, int? other)
    /*<bind>*/{
        switch (input)
        {
            case other ?? 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,103710,103980);

var 
expectedDiagnostics = new[] {
f_22065_103888_103964(f_22065_103888_103944(ErrorCode.ERR_ConstantExpected, "other ?? 1"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,103996,108888);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')

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
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'other')
                      Value: 
                        IParameterReferenceOperation: other (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'other')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'other')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'other')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'other')
                      Value: 
                        IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'other')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'other')
                          Arguments(0)

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'other ?? 1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid, IsImplicit) (Syntax: 'other ?? 1') (InputType: System.Object, NarrowedType: System.Object)
                      Value: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'other ?? 1')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (Boxing)
                          Operand: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'other ?? 1')
                Leaving: {R2} {R1}

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,108902,109000);

f_22065_108902_108999(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,103273,109011);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,103273,109011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,103273,109011);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_29()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,109023,111858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,109170,109429);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, object input)
    /*<bind>*/{
        switch (input)
        {
            case int x:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,109443,109496);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,109512,111735);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 x]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: 'int x')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
                Leaving: {R2} {R1}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B4]
                Leaving: {R2} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,111749,111847);

f_22065_111749_111846(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,109023,111858);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,109023,111858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,109023,111858);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_30()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,111870,115791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,112017,112350);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, object input1, bool other2, bool other3, bool other4)
    /*<bind>*/{
        switch (input1)
        {
            case int x when (other2 ? other3 : other4) :
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,112364,112417);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,112433,115668);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
              Value: 
                IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 x]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: 'int x')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input1')
                  Pattern: 
                    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
                Leaving: {R2} {R1}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IParameterReferenceOperation: other2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'other2')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: other3 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'other3')
                Leaving: {R2} {R1}

            Next (Regular) Block[B6]
        Block[B5] - Block
            Predecessors: [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IParameterReferenceOperation: other4 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'other4')
                Leaving: {R2} {R1}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B7]
                Leaving: {R2} {R1}
    }
}

Block[B7] - Exit
    Predecessors: [B2] [B4] [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,115682,115780);

f_22065_115682_115779(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,111870,115791);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,111870,115791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,111870,115791);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_31()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,115803,119962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,115950,116282);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, object input)
    /*<bind>*/{
        switch (input)
        {
            case 1:
                result = false;
                break;
            case 2:
                result = true;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,116296,116349);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,116365,119839);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')

        Jump if False (Regular) to Block[B3]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsImplicit) (Syntax: '1') (InputType: System.Object, NarrowedType: System.Int32)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B5]
            Leaving: {R1}
    Block[B3] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '2')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsImplicit) (Syntax: '2') (InputType: System.Object, NarrowedType: System.Int32)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            Leaving: {R1}

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B2] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,119853,119951);

f_22065_119853_119950(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,115803,119962);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,115803,119962);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,115803,119962);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,119974,124971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,120121,120414);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, object input, bool? guard)
    /*<bind>*/{
        switch (input)
        {
            case 1 when guard ?? throw null:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,120428,120481);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,120497,124848);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')
            Jump if False (Regular) to Block[B6]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Object, NarrowedType: System.Int32)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Leaving: {R1}
            Next (Regular) Block[B2]
                Entering: {R2}
        .locals {R2}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'guard')
                      Value: 
                        IParameterReferenceOperation: guard (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'guard')
                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'guard')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'guard')
                    Leaving: {R2}
                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Jump if False (Regular) to Block[B6]
                    IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'guard')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'guard')
                      Arguments(0)
                    Leaving: {R2} {R1}
                Next (Regular) Block[B5]
                    Leaving: {R2}
        }
        Block[B4] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Throw) Block[null]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Block[B5] - Block
            Predecessors: [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Next (Regular) Block[B6]
                Leaving: {R1}
    }
    Block[B6] - Exit
        Predecessors: [B1] [B3] [B5]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,124862,124960);

f_22065_124862_124959(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,119974,124971);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,119974,124971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,119974,124971);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_33()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,124983,128538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,125130,125396);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, object input)
    /*<bind>*/{
        switch (input)
        {
            case 1 when guard:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,125410,125726);

var 
expectedDiagnostics = new[] {
f_22065_125616_125710(f_22065_125616_125690(f_22065_125616_125667(ErrorCode.ERR_NameNotInContext, "guard"), "guard"), 8, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,125742,128415);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')

        Jump if False (Regular) to Block[B4]
            IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '1')
              Value: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
              Pattern: 
                IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Object, NarrowedType: System.Int32)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'guard')
              Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                (NoConversion)
              Operand: 
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'guard')
                  Children(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,128429,128527);

f_22065_128429_128526(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,124983,128538);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,124983,128538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,124983,128538);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_34()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,128550,133943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,128697,129080);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case 1+TakeOutParam(3, out MyClass x1):
                result = false;
                break;
        }
    }/*</bind>*/
    int TakeOutParam(int a, out MyClass b)
    {
        b = default;
        return a;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,129094,129432);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22065_129317_129416(f_22065_129317_129396(ErrorCode.ERR_ConstantExpected, "1+TakeOutParam(3, out MyClass x1)"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,129448,133820);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [MyClass x1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: '1+TakeOutPa ... MyClass x1)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32, IsInvalid) (Syntax: '1+TakeOutPa ... MyClass x1)')
                      Left: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
                      Right: 
                        IInvocationOperation ( System.Int32 MyClass.TakeOutParam(System.Int32 a, out MyClass b)) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'TakeOutPara ... MyClass x1)')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass, IsInvalid, IsImplicit) (Syntax: 'TakeOutParam')
                          Arguments(2):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: a) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '3')
                                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: b) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out MyClass x1')
                                IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: MyClass, IsInvalid) (Syntax: 'MyClass x1')
                                  ILocalReferenceOperation: x1 (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsInvalid) (Syntax: 'x1')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R2} {R1}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B4]
                Leaving: {R2} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,133834,133932);

f_22065_133834_133931(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,128550,133943);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,128550,133943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,128550,133943);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchFlow_35()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,133955,140043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,134102,134382);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int? input)
    /*<bind>*/{
        switch (input)
        {
            case 1+(input is int x1 ? x1 : 0):
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,134396,134724);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22065_134614_134708(f_22065_134614_134688(ErrorCode.ERR_ConstantExpected, "1+(input is int x1 ? x1 : 0)"), 8, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,134740,139920);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'input')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        Locals: [System.Int32 x1]
        .locals {R3}
        {
            CaptureIds: [1] [2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')

                Jump if False (Regular) to Block[B4]
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'input is int x1')
                      Value: 
                        IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32?, IsInvalid) (Syntax: 'input')
                      Pattern: 
                        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int x1') (InputType: System.Int32?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x1, MatchesNull: False)

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'x1')
                      Value: 
                        ILocalReferenceOperation: x1 (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'x1')

                Next (Regular) Block[B5]
            Block[B4] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '0')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')

                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (0)
                Jump if False (Regular) to Block[B7]
                    IBinaryOperation (BinaryOperatorKind.Equals, IsLifted) (OperationKind.Binary, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: '1+(input is ... 1 ? x1 : 0)')
                      Left: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'input')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: '1+(input is ... 1 ? x1 : 0)')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNullable)
                          Operand: 
                            IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32, IsInvalid) (Syntax: '1+(input is ... 1 ? x1 : 0)')
                              Left: 
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsInvalid, IsImplicit) (Syntax: '1')
                              Right: 
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'input is int x1 ? x1 : 0')
                    Leaving: {R3} {R2} {R1}

                Next (Regular) Block[B6]
                    Leaving: {R3}
        }

        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B7]
                Leaving: {R2} {R1}
    }
}

Block[B7] - Exit
    Predecessors: [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,139934,140032);

f_22065_139934_140031(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,133955,140043);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,133955,140043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,133955,140043);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns, CompilerFeature.Dataflow)]
        [Fact]
        public void EmptySwitchExpressionFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,140057,142959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,140242,140382);

string 
source = @"
class Program
{
    public static void Main()
    /*<bind>*/{
        var r = 1 switch { };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,140396,141063);

var 
expectedDiagnostics = new[] {
f_22065_140693_140797(f_22065_140693_140777(f_22065_140693_140758(ErrorCode.WRN_SwitchExpressionNotExhaustive, "switch"), "_"), 6, 19),
f_22065_140965_141047(f_22065_140965_141027(ErrorCode.ERR_SwitchExpressionNoBestType, "switch"), 6, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,141079,142836);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}
.locals {R1}
{
    Locals: [? r]
    CaptureIds: [0]
    .locals {R2}
    {
        CaptureIds: [1]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Next (Regular) Block[B2]
                Leaving: {R2}
    }
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsInvalid, IsImplicit) (Syntax: '1 switch { }')
              Arguments(0)
              Initializer: 
                null
    Block[B3] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ?, IsInvalid, IsImplicit) (Syntax: 'r = 1 switch { }')
              Left: 
                ILocalReferenceOperation: r (IsDeclaration: True) (OperationKind.LocalReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'r = 1 switch { }')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: '1 switch { }')
        Next (Regular) Block[B4]
            Leaving: {R1}
}
Block[B4] - Exit [UnReachable]
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,142850,142948);

f_22065_142850_142947(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,140057,142959);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,140057,142959);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,140057,142959);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchFlow_36()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,142971,145831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,143144,143398);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case < 1:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,143412,143467);

var 
expectedDiagnostics = new DiagnosticDescription[0]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,143483,145651);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
            Jump if False (Regular) to Block[B3]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '< 1')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IRelationalPatternOperation (BinaryOperatorKind.LessThan) (OperationKind.RelationalPattern, Type: null) (Syntax: '< 1') (InputType: System.Int32, NarrowedType: System.Int32)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Leaving: {R1}
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Next (Regular) Block[B3]
                Leaving: {R1}
    }
    Block[B3] - Exit
        Predecessors: [B1] [B2]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,145665,145820);

f_22065_145665_145819(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,142971,145831);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,142971,145831);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,142971,145831);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchFlow_37()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,145843,149008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,146016,146285);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input, int other)
    /*<bind>*/{
        switch (input)
        {
            case < other:
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,146299,146583);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22065_146496_146567(f_22065_146496_146547(ErrorCode.ERR_ConstantExpected, "other"), 8, 20)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,146599,148828);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
            Jump if False (Regular) to Block[B3]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: '< other')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IRelationalPatternOperation (BinaryOperatorKind.LessThan) (OperationKind.RelationalPattern, Type: null, IsInvalid) (Syntax: '< other') (InputType: System.Int32, NarrowedType: System.Int32)
                      Value: 
                        IParameterReferenceOperation: other (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'other')
                Leaving: {R1}
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Next (Regular) Block[B3]
                Leaving: {R1}
    }
    Block[B3] - Exit
        Predecessors: [B1] [B2]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,148842,148997);

f_22065_148842_148996(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,145843,149008);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,145843,149008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,145843,149008);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchFlow_38()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,149020,153452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,149193,149462);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case < (true ? 10 : 11):
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,149476,149547);

var 
expectedDiagnostics = new DiagnosticDescription[] {
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,149563,153272);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
            Next (Regular) Block[B2]
                Entering: {R2}
        .locals {R2}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (0)
                Jump if False (Regular) to Block[B4]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '10')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
                Next (Regular) Block[B5]
            Block[B4] - Block [UnReachable]
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '11')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 11) (Syntax: '11')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (0)
                Jump if False (Regular) to Block[B7]
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '< (true ? 10 : 11)')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                      Pattern: 
                        IRelationalPatternOperation (BinaryOperatorKind.LessThan) (OperationKind.RelationalPattern, Type: null) (Syntax: '< (true ? 10 : 11)') (InputType: System.Int32, NarrowedType: System.Int32)
                          Value: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 10, IsImplicit) (Syntax: 'true ? 10 : 11')
                    Leaving: {R2} {R1}
                Next (Regular) Block[B6]
                    Leaving: {R2}
        }
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Next (Regular) Block[B7]
                Leaving: {R1}
    }
    Block[B7] - Exit
        Predecessors: [B5] [B6]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,153286,153441);

f_22065_153286_153440(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,149020,153452);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,149020,153452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,149020,153452);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchFlow_39()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,153464,158162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,153637,153910);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        switch (input)
        {
            case not < (true ? 10 : 11):
                result = false;
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,153924,153995);

var 
expectedDiagnostics = new DiagnosticDescription[] {
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,154011,157982);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
            Next (Regular) Block[B2]
                Entering: {R2}
        .locals {R2}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (0)
                Jump if False (Regular) to Block[B4]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '10')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
                Next (Regular) Block[B5]
            Block[B4] - Block [UnReachable]
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '11')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 11) (Syntax: '11')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (0)
                Jump if False (Regular) to Block[B7]
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: 'not < (true ? 10 : 11)')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                      Pattern: 
                        INegatedPatternOperation (OperationKind.NegatedPattern, Type: null) (Syntax: 'not < (true ? 10 : 11)') (InputType: System.Int32, NarrowedType: System.Int32)
                          Pattern: 
                            IRelationalPatternOperation (BinaryOperatorKind.LessThan) (OperationKind.RelationalPattern, Type: null) (Syntax: '< (true ? 10 : 11)') (InputType: System.Int32, NarrowedType: System.Int32)
                              Value: 
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 10, IsImplicit) (Syntax: 'true ? 10 : 11')
                         
                    Leaving: {R2} {R1}
                Next (Regular) Block[B6]
                    Leaving: {R2}
        }
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Next (Regular) Block[B7]
                Leaving: {R1}
    }
    Block[B7] - Exit
        Predecessors: [B5] [B6]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,157996,158151);

f_22065_157996_158150(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,153464,158162);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,153464,158162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,153464,158162);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchFlow_40()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,158174,163504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,158347,158631);

string 
source = @"
public sealed class MyClass
{
    bool M(char input)
    /*<bind>*/{
        switch (input)
        {
            case (>= 'A' and <= 'Z') or (>= 'a' and <= 'z') or '_':
                return true;
        }
        return false;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,158645,158716);

var 
expectedDiagnostics = new DiagnosticDescription[] {
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,158732,163324);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'input')
            Jump if False (Regular) to Block[B3]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: '(>= 'A' and ... 'z') or '_'')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Char, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: '(>= 'A' and ... 'z') or '_'') (InputType: System.Char, NarrowedType: System.Char)
                      LeftPattern: 
                        IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: '(>= 'A' and ... and <= 'z')') (InputType: System.Char, NarrowedType: System.Char)
                          LeftPattern: 
                            IBinaryPatternOperation (BinaryOperatorKind.And) (OperationKind.BinaryPattern, Type: null) (Syntax: '>= 'A' and <= 'Z'') (InputType: System.Char, NarrowedType: System.Char)
                              LeftPattern: 
                                IRelationalPatternOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '>= 'A'') (InputType: System.Char, NarrowedType: System.Char)
                                  Value: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: A) (Syntax: ''A'')
                              RightPattern: 
                                IRelationalPatternOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '<= 'Z'') (InputType: System.Char, NarrowedType: System.Char)
                                  Value: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: Z) (Syntax: ''Z'')
                          RightPattern: 
                            IBinaryPatternOperation (BinaryOperatorKind.And) (OperationKind.BinaryPattern, Type: null) (Syntax: '>= 'a' and <= 'z'') (InputType: System.Char, NarrowedType: System.Char)
                              LeftPattern: 
                                IRelationalPatternOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '>= 'a'') (InputType: System.Char, NarrowedType: System.Char)
                                  Value: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: a) (Syntax: ''a'')
                              RightPattern: 
                                IRelationalPatternOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '<= 'z'') (InputType: System.Char, NarrowedType: System.Char)
                                  Value: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: z) (Syntax: ''z'')
                      RightPattern: 
                        IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: ''_'') (InputType: System.Char, NarrowedType: System.Char)
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: _) (Syntax: ''_'')
                Leaving: {R1}
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Return) Block[B4]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Leaving: {R1}
    }
    Block[B3] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Return) Block[B4]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
    Block[B4] - Exit
        Predecessors: [B2] [B3]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,163338,163493);

f_22065_163338_163492(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,158174,163504);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,158174,163504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,158174,163504);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchFlow_41()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22065,163516,166970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,163689,163976);

string 
source = @"
public sealed class MyClass
{
    bool M(object input)
    /*<bind>*/{
        switch (input)
        {
            case int or long or ulong:
                return true;
            default:
                return false;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,163990,164061);

var 
expectedDiagnostics = new DiagnosticDescription[] {
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,164077,166790);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'input')
            Jump if False (Regular) to Block[B3]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsImplicit) (Syntax: 'int or long or ulong')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: 'int or long or ulong') (InputType: System.Object, NarrowedType: System.Object)
                      LeftPattern: 
                        IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: 'int or long') (InputType: System.Object, NarrowedType: System.Object)
                          LeftPattern: 
                            ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'int') (InputType: System.Object, NarrowedType: System.Int32, MatchedType: System.Int32)
                          RightPattern: 
                            ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'long') (InputType: System.Object, NarrowedType: System.Int64, MatchedType: System.Int64)
                      RightPattern: 
                        ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'ulong') (InputType: System.Object, NarrowedType: System.UInt64, MatchedType: System.UInt64)
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Return) Block[B4]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Leaving: {R1}
        Block[B3] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Return) Block[B4]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                Leaving: {R1}
    }
    Block[B4] - Exit
        Predecessors: [B2] [B3]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22065,166804,166959);

f_22065_166804_166958(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22065,163516,166970);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22065,163516,166970);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22065,163516,166970);
}
		}

int
f_22065_1859_1974(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 1859, 1974);
return 0;
}


int
f_22065_4744_4859(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 4744, 4859);
return 0;
}


int
f_22065_6791_6906(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 6791, 6906);
return 0;
}


int
f_22065_10542_10657(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 10542, 10657);
return 0;
}


int
f_22065_12598_12713(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 12598, 12713);
return 0;
}


int
f_22065_14518_14633(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 14518, 14633);
return 0;
}


int
f_22065_16359_16456(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 16359, 16456);
return 0;
}


int
f_22065_19558_19655(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 19558, 19655);
return 0;
}


int
f_22065_22757_22854(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 22757, 22854);
return 0;
}


int
f_22065_25191_25288(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 25191, 25288);
return 0;
}


int
f_22065_29881_29978(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 29881, 29978);
return 0;
}


int
f_22065_32307_32404(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 32307, 32404);
return 0;
}


int
f_22065_34733_34830(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 34733, 34830);
return 0;
}


int
f_22065_37760_37857(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 37760, 37857);
return 0;
}


int
f_22065_42222_42319(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 42222, 42319);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_42941_42996(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 42941, 42996);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_42941_43021(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 42941, 43021);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_42941_43041(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 42941, 43041);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_43217_43267(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 43217, 43267);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_43217_43292(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 43217, 43292);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_43217_43312(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 43217, 43312);
return return_v;
}


int
f_22065_44862_44959(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 44862, 44959);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_45773_45829(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 45773, 45829);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_45773_45854(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 45773, 45854);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_45773_45875(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 45773, 45875);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_46072_46133(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 46072, 46133);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_46072_46154(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 46072, 46154);
return return_v;
}


int
f_22065_49841_49938(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 49841, 49938);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_50621_50671(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 50621, 50671);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_50621_50700(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 50621, 50700);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_50621_50720(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 50621, 50720);
return return_v;
}


int
f_22065_53005_53102(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 53005, 53102);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_54054_54105(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 54054, 54105);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_54054_54125(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 54054, 54125);
return return_v;
}


int
f_22065_56203_56300(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 56203, 56300);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_57244_57289(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 57244, 57289);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_57244_57321(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 57244, 57321);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_57244_57341(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 57244, 57341);
return return_v;
}


int
f_22065_59790_59887(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 59790, 59887);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_60561_60608(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 60561, 60608);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_60561_60628(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 60561, 60628);
return return_v;
}


int
f_22065_63612_63709(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 63612, 63709);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_64223_64267(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 64223, 64267);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_64223_64287(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 64223, 64287);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_64406_64454(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 64406, 64454);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_64406_64474(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 64406, 64474);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_64593_64638(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 64593, 64638);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_64593_64658(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 64593, 64658);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_64802_64844(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 64802, 64844);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_64802_64864(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 64802, 64864);
return return_v;
}


int
f_22065_65972_66069(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 65972, 66069);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_66627_66690(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 66627, 66690);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_66627_66710(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 66627, 66710);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_66830_66878(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 66830, 66878);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_66830_66898(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 66830, 66898);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_67018_67063(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 67018, 67063);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_67018_67083(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 67018, 67083);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_67227_67269(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 67227, 67269);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_67227_67289(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 67227, 67289);
return return_v;
}


int
f_22065_68391_68488(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 68391, 68488);
return 0;
}


int
f_22065_71214_71311(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 71214, 71311);
return 0;
}


int
f_22065_74045_74142(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 74045, 74142);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_74769_74820(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 74769, 74820);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_74769_74840(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 74769, 74840);
return return_v;
}


int
f_22065_76762_76859(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 76762, 76859);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_77560_77613(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 77560, 77613);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_77560_77642(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 77560, 77642);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_77560_77662(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 77560, 77662);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_77803_77854(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 77803, 77854);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_77803_77874(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 77803, 77874);
return return_v;
}


int
f_22065_80174_80271(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 80174, 80271);
return 0;
}


int
f_22065_82776_82873(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 82776, 82873);
return 0;
}


int
f_22065_85038_85153(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 85038, 85153);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_85786_85837(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 85786, 85837);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_85786_85857(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 85786, 85857);
return return_v;
}


int
f_22065_87935_88032(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 87935, 88032);
return 0;
}


int
f_22065_92046_92143(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 92046, 92143);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_92806_92868(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 92806, 92868);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_92806_92888(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 92806, 92888);
return return_v;
}


int
f_22065_97248_97345(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 97248, 97345);
return 0;
}


int
f_22065_100533_100630(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 100533, 100630);
return 0;
}


int
f_22065_103152_103249(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 103152, 103249);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_103888_103944(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 103888, 103944);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_103888_103964(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 103888, 103964);
return return_v;
}


int
f_22065_108902_108999(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 108902, 108999);
return 0;
}


int
f_22065_111749_111846(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 111749, 111846);
return 0;
}


int
f_22065_115682_115779(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 115682, 115779);
return 0;
}


int
f_22065_119853_119950(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 119853, 119950);
return 0;
}


int
f_22065_124862_124959(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 124862, 124959);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_125616_125667(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 125616, 125667);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_125616_125690(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 125616, 125690);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_125616_125710(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 125616, 125710);
return return_v;
}


int
f_22065_128429_128526(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 128429, 128526);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_129317_129396(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 129317, 129396);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_129317_129416(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 129317, 129416);
return return_v;
}


int
f_22065_133834_133931(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 133834, 133931);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_134614_134688(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 134614, 134688);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_134614_134708(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 134614, 134708);
return return_v;
}


int
f_22065_139934_140031(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 139934, 140031);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_140693_140758(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 140693, 140758);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_140693_140777(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 140693, 140777);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_140693_140797(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 140693, 140797);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_140965_141027(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 140965, 141027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_140965_141047(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 140965, 141047);
return return_v;
}


int
f_22065_142850_142947(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 142850, 142947);
return 0;
}


int
f_22065_145665_145819(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 145665, 145819);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_146496_146547(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 146496, 146547);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22065_146496_146567(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 146496, 146567);
return return_v;
}


int
f_22065_148842_148996(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 148842, 148996);
return 0;
}


int
f_22065_153286_153440(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 153286, 153440);
return 0;
}


int
f_22065_157996_158150(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 157996, 158150);
return 0;
}


int
f_22065_163338_163492(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 163338, 163492);
return 0;
}


int
f_22065_166804_166958(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22065, 166804, 166958);
return 0;
}

}
}
