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
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ForSimpleLoop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,503,4069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,708,956);

string 
source = @"
class C
{
    static void Main()
    {
        int x = 3;
        /*<bind>*/for (int i = 0; i < 3; i = i + 1)
        {
            x = x * 3;
        }/*</bind>*/
        System.Console.Write(""{0}"", x);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,970,3966);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 3')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = x * 3;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = x * 3')
            Left: 
              ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Multiply) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x * 3')
                Left: 
                  ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,3980,4058);

f_22036_3980_4057(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,503,4069);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,503,4069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,503,4069);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_TrueCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,4081,7286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,4286,4572);

string 
source = @"
class C
{
    static void Main()
    {
        int i = 0;
        int j;
        /*<bind>*/for (j = 0; true; j = j + 1)
        {
            i = i + 1;
            break;
        }/*</bind>*/
        System.Console.Write(""{0},{1}"", i, j);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,4586,7183);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (j = 0; ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = 0')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 0')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                Left: 
                  ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = i + 1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      IBranchOperation (BranchKind.Break, Label Id: 1) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,7197,7275);

f_22036_7197_7274(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,4081,7286);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,4081,7286);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,4081,7286);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_FalseCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,7298,10507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,7504,7791);

string 
source = @"
class C
{
    static void Main()
    {
        int i = 0;
        int j;
        /*<bind>*/for (j = 0; false; j = j + 1)
        {
            i = i + 1;
            break;
        }/*</bind>*/
        System.Console.Write(""{0},{1}"", i, j);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,7805,10404);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (j = 0; ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = 0')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 0')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                Left: 
                  ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = i + 1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      IBranchOperation (BranchKind.Break, Label Id: 1) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,10418,10496);

f_22036_10418_10495(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,7298,10507);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,7298,10507);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,7298,10507);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_WithContinue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,10519,15051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,10723,11029);

string 
source = @"
class C
{
    static void Main()
    {
        int i;
        int j;
        /*<bind>*/for (i = 0, j = 0; i < 5; i = i + 1)
        {
            if (i > 2) continue;
            j = j + 1;
        }/*</bind>*/
        System.Console.Write(""{0},{1}, "", i, j);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,11043,14948);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (i = 0, ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = 0')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 0')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = 0')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 0')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (i > 2) continue;')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i > 2')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
        WhenTrue: 
          IBranchOperation (BranchKind.Continue, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'continue;')
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = j + 1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                Left: 
                  ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,14962,15040);

f_22036_14962_15039(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,10519,15051);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,10519,15051);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,10519,15051);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_WithBreak()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,15063,19579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,15264,15566);

string 
source = @"
class C
{
    static void Main()
    {
        int i;
        int j;
        /*<bind>*/for (i = 0, j = 0; i < 5; i = i + 1)
        {
            if (i > 3) break;
            j = j + 1;
        }/*</bind>*/
        System.Console.Write(""{0}, {1}"", i, j);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,15580,19476);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (i = 0, ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = 0')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 0')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = 0')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 0')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (i > 3) break;')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i > 3')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
        WhenTrue: 
          IBranchOperation (BranchKind.Break, Label Id: 1) (OperationKind.Branch, Type: null) (Syntax: 'break;')
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = j + 1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                Left: 
                  ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,19490,19568);

f_22036_19490_19567(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,15063,19579);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,15063,19579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,15063,19579);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_WithNoStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,19591,21944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,19798,20052);

string 
source = @"
class C
{
    static void Main()
    {
        int i = 0;
        /*<bind>*/for (;;)
        {
            if (i > 4) break;
            i = i + 2;
        }/*</bind>*/
        System.Console.Write(""{0}"", i);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,20066,21841);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (;;) ... }')
  Condition: 
    null
  Before(0)
  AtLoopBottom(0)
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (i > 4) break;')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i > 4')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
        WhenTrue: 
          IBranchOperation (BranchKind.Break, Label Id: 1) (OperationKind.Branch, Type: null) (Syntax: 'break;')
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = i + 2;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 2')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 2')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,21855,21933);

f_22036_21855_21932(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,19591,21944);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,19591,21944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,19591,21944);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_MultipleInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,21956,26371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,22167,22433);

string 
source = @"
class C
{
    static void Main()
    {
        int i = 0;
        int j = 0;
        /*<bind>*/for (i = i + 1, i = i + 1; j < 2; i = i + 2, j = j + 1)
        {
        }/*</bind>*/
        System.Console.Write(""{0}"", i);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,22447,26268);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (i = i  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 2')
      Left: 
        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 2')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 2')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 2')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                Left: 
                  ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,26282,26360);

f_22036_26282_26359(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,21956,26371);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,21956,26371);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,21956,26371);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_InitializerMissing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,26383,28354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,26593,26781);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        int i = 1;
        /*<bind>*/for (; i < 10; i = i + 1)
        {
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,26795,28251);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (; i <  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Before(0)
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,28265,28343);

f_22036_28265_28342(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,26383,28354);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,26383,28354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,26383,28354);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_DecreasingIterator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,28366,31111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,28576,28756);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int k = 200; k > 100; k = k - 1)
        {
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,28770,31008);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int k  ... }')
  Locals: Local_1: System.Int32 k
  Condition: 
    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'k > 100')
      Left: 
        ILocalReferenceOperation: k (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 100) (Syntax: '100')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int k = 200')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int k = 200')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 k) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'k = 200')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 200')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 200) (Syntax: '200')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'k = k - 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'k = k - 1')
            Left: 
              ILocalReferenceOperation: k (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Subtract) (OperationKind.Binary, Type: System.Int32) (Syntax: 'k - 1')
                Left: 
                  ILocalReferenceOperation: k (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,31022,31100);

f_22036_31022_31099(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,28366,31111);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,28366,31111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,28366,31111);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_MethodCall()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,31123,33013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,31325,31673);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (Initializer(); Conditional(); Iterator())
        {
        }/*</bind>*/
    }
    public static int Initializer() { return 1; }
    public static bool Conditional()
    { return true; }
    public static int Iterator() { return 1; }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,31687,32910);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (Initia ... }')
  Condition: 
    IInvocationOperation (System.Boolean C.Conditional()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'Conditional()')
      Instance Receiver: 
        null
      Arguments(0)
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'Initializer()')
        Expression: 
          IInvocationOperation (System.Int32 C.Initializer()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Initializer()')
            Instance Receiver: 
              null
            Arguments(0)
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'Iterator()')
        Expression: 
          IInvocationOperation (System.Int32 C.Iterator()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Iterator()')
            Instance Receiver: 
              null
            Arguments(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,32924,33002);

f_22036_32924_33001(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,31123,33013);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,31123,33013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,31123,33013);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_MissingForBody()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,33025,35718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,33231,33388);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 10; i < 100; i = i + 1) ;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,33402,35615);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ...  = i + 1) ;')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 100')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 100) (Syntax: '100')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 10')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 10')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 10')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 10')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IEmptyOperation (OperationKind.Empty, Type: null) (Syntax: ';')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,35629,35707);

f_22036_35629_35706(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,33025,35718);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,33025,35718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,33025,35718);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_Nested()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,35730,40887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,35928,36182);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; i < 100; i = i + 1)
        {
            for (int j = 0; j < 10; j = j + 1)
            {
            }
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,36196,40784);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 100')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 100) (Syntax: '100')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForLoopOperation (LoopKind.For, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
        Locals: Local_1: System.Int32 j
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 10')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        Before:
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = 0')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 0')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                Initializer: 
                  null
        AtLoopBottom:
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j + 1')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Body: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,40798,40876);

f_22036_40798_40875(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,35730,40887);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,35730,40887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,35730,40887);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ChangeOuterVariableInInnerLoop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,40899,46632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,41121,41400);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; i < 10; i = i + 1)
        {
            for (int j = 0; j < 10; j = j + 1)
            {
                i = 1;
            }
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,41414,46529);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForLoopOperation (LoopKind.For, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
        Locals: Local_1: System.Int32 j
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 10')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        Before:
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = 0')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 0')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                Initializer: 
                  null
        AtLoopBottom:
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j + 1')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Body: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,46543,46621);

f_22036_46543_46620(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,40899,46632);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,40899,46632);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,40899,46632);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_InnerLoopRefOuterIteration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,46644,52171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,46862,47119);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; i < 5; i = i + 1)
        {
            for (int j = i + 1; i < j; j = j - 1)
            {
            }
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,47133,52068);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForLoopOperation (LoopKind.For, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
        Locals: Local_1: System.Int32 j
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < j')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
        Before:
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = i + 1')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = i + 1')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = i + 1')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i + 1')
                          IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                            Left: 
                              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                            Right: 
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Initializer: 
                  null
        AtLoopBottom:
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j - 1')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j - 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Subtract) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j - 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Body: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,52082,52160);

f_22036_52082_52159(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,46644,52171);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,46644,52171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,46644,52171);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_BreakFromNestedLoop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,52183,58139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,52394,52705);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; i < 5; i = i + 1)
        {
            for (int j = 0; j < 10; j = j + 1)
            {
                if (j == 5)
                    break;
            }
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,52719,58036);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForLoopOperation (LoopKind.For, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
        Locals: Local_1: System.Int32 j
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 10')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        Before:
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = 0')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 0')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                Initializer: 
                  null
        AtLoopBottom:
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j + 1')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Body: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (j == 5) ... break;')
              Condition: 
                IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j == 5')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
              WhenTrue: 
                IBranchOperation (BranchKind.Break, Label Id: 3) (OperationKind.Branch, Type: null) (Syntax: 'break;')
              WhenFalse: 
                null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,58050,58128);

f_22036_58050_58127(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,52183,58139);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,52183,58139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,52183,58139);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ContinueForNestedLoop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,58151,66383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,58364,58752);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; i < 5; i = i + 1)
        {
            for (int j = 1; j < 10; j = j + 1)
            {
                if ((j % 2) != 0)
                    continue;
                i = i + 1;
                System.Console.Write(i);
            }
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,58766,66280);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForLoopOperation (LoopKind.For, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
        Locals: Local_1: System.Int32 j
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 10')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        Before:
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = 1')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 1')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 1')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Initializer: 
                  null
        AtLoopBottom:
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j + 1')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Body: 
          IBlockOperation (3 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if ((j % 2) ... continue;')
              Condition: 
                IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: '(j % 2) != 0')
                  Left: 
                    IBinaryOperation (BinaryOperatorKind.Remainder) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j % 2')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
              WhenTrue: 
                IBranchOperation (BranchKind.Continue, Label Id: 2) (OperationKind.Branch, Type: null) (Syntax: 'continue;')
              WhenFalse: 
                null
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = i + 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                      Left: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Console.Write(i);')
              Expression: 
                IInvocationOperation (void System.Console.Write(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Console.Write(i)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'i')
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,66294,66372);

f_22036_66294_66371(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,58151,66383);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,58151,66383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,58151,66383);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_GotoForNestedLoop_1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,66395,72783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,66606,66935);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; i < 5; i = i + 1)
        {
            for (int j = 0; j < 10; j = j + 1)
            {
                goto stop;
            stop:
                j = j + 1;
            }
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,66949,72680);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForLoopOperation (LoopKind.For, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
        Locals: Local_1: System.Int32 j
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 10')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        Before:
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = 0')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 0')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                Initializer: 
                  null
        AtLoopBottom:
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = j + 1')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Body: 
          IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IBranchOperation (BranchKind.GoTo, Label: stop) (OperationKind.Branch, Type: null) (Syntax: 'goto stop;')
            ILabeledOperation (Label: stop) (OperationKind.Labeled, Type: null) (Syntax: 'stop: ... j = j + 1;')
              Statement: 
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = j + 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = j + 1')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'j + 1')
                          Left: 
                            ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,72694,72772);

f_22036_72694_72771(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,66395,72783);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,66395,72783);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,66395,72783);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ThrowException()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,72795,77499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,73001,73293);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; i < 10; i = i + 1)
        {
            for (int j = 0; j < 10;)
            {
                throw new System.Exception();
            }
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,73307,77396);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForLoopOperation (LoopKind.For, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
        Locals: Local_1: System.Int32 j
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 10')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        Before:
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = 0')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 0')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                Initializer: 
                  null
        AtLoopBottom(0)
        Body: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw new S ... xception();')
              IObjectCreationOperation (Constructor: System.Exception..ctor()) (OperationKind.ObjectCreation, Type: System.Exception) (Syntax: 'new System.Exception()')
                Arguments(0)
                Initializer: 
                  null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,77410,77488);

f_22036_77410_77487(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,72795,77499);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,72795,77499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,72795,77499);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ReturnInFor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,77511,81168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,77714,77973);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; i < 10;)
        {
            for (int j = 0; j < 5;)
            {
                return;
            }
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,77987,81065);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom(0)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForLoopOperation (LoopKind.For, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
        Locals: Local_1: System.Int32 j
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 5')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
        Before:
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = 0')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 0')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                Initializer: 
                  null
        AtLoopBottom(0)
        Body: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return;')
              ReturnedValue: 
                null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,81079,81157);

f_22036_81079_81156(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,77511,81168);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,77511,81168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,77511,81168);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ChangeValueOfInit()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,81180,84840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,81389,81592);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0, j = 1; i < 5; i = i + 1)
        {
            j = 2;
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,81606,84737);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
    Local_2: System.Int32 j
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0, j = 1')
        IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0, j = 1')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
              IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 1')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,84751,84829);

f_22036_84751_84828(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,81180,84840);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,81180,84840);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,81180,84840);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ChangeValueOfCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,84852,89481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,85066,85322);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        int c = 0, x = 0;
        /*<bind>*/for (int i = 0; i < 50 - x; i = i + 1)
        {
            x = x + 1;
            c = c + 1;
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,85336,89378);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 50 - x')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        IBinaryOperation (BinaryOperatorKind.Subtract) (OperationKind.Binary, Type: System.Int32) (Syntax: '50 - x')
          Left: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 50) (Syntax: '50')
          Right: 
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = x + 1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = x + 1')
            Left: 
              ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + 1')
                Left: 
                  ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = c + 1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'c = c + 1')
            Left: 
              ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'c')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'c + 1')
                Left: 
                  ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'c')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,89392,89470);

f_22036_89392_89469(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,84852,89481);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,84852,89481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,84852,89481);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_UnreachableCode1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,89493,91471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,89701,89927);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (; false;)
        {
            System.Console.WriteLine(""hello"");        //unreachable
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,89941,91368);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (; fals ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
  Before(0)
  AtLoopBottom(0)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... e(""hello"");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... ne(""hello"")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""hello""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""hello"") (Syntax: '""hello""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,91382,91460);

f_22036_91382_91459(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,89493,91471);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,89493,91471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,89493,91471);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ObjectInitAsInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,91483,96583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,91698,91968);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (F f = new F { i = 0, s = ""abc"" }; f.i < 5; f.i = f.i + 1)
        {
        }/*</bind>*/
    }
}
public class F
{
    public int i;
    public string s;
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,91982,96480);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (F f =  ... }')
  Locals: Local_1: F f
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'f.i < 5')
      Left: 
        IFieldReferenceOperation: System.Int32 F.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'f.i')
          Instance Receiver: 
            ILocalReferenceOperation: f (OperationKind.LocalReference, Type: F) (Syntax: 'f')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'F f = new F ... s = ""abc"" }')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'F f = new F ... s = ""abc"" }')
          Declarators:
              IVariableDeclaratorOperation (Symbol: F f) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'f = new F { ... s = ""abc"" }')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new F { i ... s = ""abc"" }')
                    IObjectCreationOperation (Constructor: F..ctor()) (OperationKind.ObjectCreation, Type: F) (Syntax: 'new F { i = ... s = ""abc"" }')
                      Arguments(0)
                      Initializer: 
                        IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: F) (Syntax: '{ i = 0, s = ""abc"" }')
                          Initializers(2):
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 0')
                                Left: 
                                  IFieldReferenceOperation: System.Int32 F.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 'i')
                                Right: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 's = ""abc""')
                                Left: 
                                  IFieldReferenceOperation: System.String F.s (OperationKind.FieldReference, Type: System.String) (Syntax: 's')
                                    Instance Receiver: 
                                      IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: F, IsImplicit) (Syntax: 's')
                                Right: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""abc"") (Syntax: '""abc""')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'f.i = f.i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'f.i = f.i + 1')
            Left: 
              IFieldReferenceOperation: System.Int32 F.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'f.i')
                Instance Receiver: 
                  ILocalReferenceOperation: f (OperationKind.LocalReference, Type: F) (Syntax: 'f')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'f.i + 1')
                Left: 
                  IFieldReferenceOperation: System.Int32 F.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'f.i')
                    Instance Receiver: 
                      ILocalReferenceOperation: f (OperationKind.LocalReference, Type: F) (Syntax: 'f')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,96494,96572);

f_22036_96494_96571(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,91483,96583);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,91483,96583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,91483,96583);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_DynamicInFor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,96595,99934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,96799,97482);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        dynamic d = new myFor();
        /*<bind>*/for (d.Initialize(5); d.Done; d.Next())
        {
        }/*</bind>*/
    }
}

public class myFor
{
    int index;
    int max;
    public void Initialize(int max)
    {
        index = 0;
        this.max = max;
        System.Console.WriteLine(""Initialize"");
    }
    public bool Done
    {
        get
        {
            System.Console.WriteLine(""Done"");
            return index < max;
        }
    }
    public void Next()
    {
        index = index + 1;
        System.Console.WriteLine(""Next"");
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,97496,99829);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (d.Init ... }')
  Condition: 
    IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'd.Done')
      Operand: 
        IDynamicMemberReferenceOperation (Member Name: ""Done"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Done')
          Type Arguments(0)
          Instance Receiver: 
            ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'd.Initialize(5)')
        Expression: 
          IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.Initialize(5)')
            Expression: 
              IDynamicMemberReferenceOperation (Member Name: ""Initialize"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Initialize')
                Type Arguments(0)
                Instance Receiver: 
                  ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
            Arguments(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
            ArgumentNames(0)
            ArgumentRefKinds(0)
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'd.Next()')
        Expression: 
          IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.Next()')
            Expression: 
              IDynamicMemberReferenceOperation (Member Name: ""Next"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Next')
                Type Arguments(0)
                Instance Receiver: 
                  ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
            Arguments(0)
            ArgumentNames(0)
            ArgumentRefKinds(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,99845,99923);

f_22036_99845_99922(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,96595,99934);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,96595,99934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,96595,99934);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_VarInFor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,99946,102620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,100146,100302);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (var i = 1; i < 5; i = i + 1) ;/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,100316,102517);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (var i  ...  = i + 1) ;')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var i = 1')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var i = 1')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 1')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IEmptyOperation (OperationKind.Empty, Type: null) (Syntax: ';')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,102531,102609);

f_22036_102531_102608(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,99946,102620);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,99946,102620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,99946,102620);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_QueryInInit()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,102632,119021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,102835,103389);

string 
source = @"
using System.Linq;
using System.Collections.Generic;
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (IEnumerable<string> str = from x in ""123""
                                       let z = x.ToString()
                                       select z into w
                                       select w; ; )
        {
            foreach (var item in str)
            {
                System.Console.WriteLine(item);
            }
            return;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,103403,118918);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (IEnume ... }')
  Locals: Local_1: System.Collections.Generic.IEnumerable<System.String> str
  Condition: 
    null
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'IEnumerable ... select w')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'IEnumerable ... select w')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Collections.Generic.IEnumerable<System.String> str) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'str = from  ... select w')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= from x in ... select w')
                    ITranslatedQueryOperation (OperationKind.TranslatedQuery, Type: System.Collections.Generic.IEnumerable<System.String>) (Syntax: 'from x in "" ... select w')
                      Expression: 
                        IInvocationOperation (System.Collections.Generic.IEnumerable<System.String> System.Linq.Enumerable.Select<System.String, System.String>(this System.Collections.Generic.IEnumerable<System.String> source, System.Func<System.String, System.String> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<System.String>, IsImplicit) (Syntax: 'select w')
                          Instance Receiver: 
                            null
                          Arguments(2):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'select z')
                                IInvocationOperation (System.Collections.Generic.IEnumerable<System.String> System.Linq.Enumerable.Select<<anonymous type: System.Char x, System.String z>, System.String>(this System.Collections.Generic.IEnumerable<<anonymous type: System.Char x, System.String z>> source, System.Func<<anonymous type: System.Char x, System.String z>, System.String> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<System.String>, IsImplicit) (Syntax: 'select z')
                                  Instance Receiver: 
                                    null
                                  Arguments(2):
                                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'let z = x.ToString()')
                                        IInvocationOperation (System.Collections.Generic.IEnumerable<<anonymous type: System.Char x, System.String z>> System.Linq.Enumerable.Select<System.Char, <anonymous type: System.Char x, System.String z>>(this System.Collections.Generic.IEnumerable<System.Char> source, System.Func<System.Char, <anonymous type: System.Char x, System.String z>> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<<anonymous type: System.Char x, System.String z>>, IsImplicit) (Syntax: 'let z = x.ToString()')
                                          Instance Receiver: 
                                            null
                                          Arguments(2):
                                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'from x in ""123""')
                                                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Char>, IsImplicit) (Syntax: 'from x in ""123""')
                                                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                                  Operand: 
                                                    ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""123"") (Syntax: '""123""')
                                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x.ToString()')
                                                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<System.Char, <anonymous type: System.Char x, System.String z>>, IsImplicit) (Syntax: 'x.ToString()')
                                                  Target: 
                                                    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsImplicit) (Syntax: 'x.ToString()')
                                                      IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'x.ToString()')
                                                        IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x.ToString()')
                                                          ReturnedValue: 
                                                            IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Char x, System.String z>, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                              Initializers(2):
                                                                  ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Char, IsImplicit) (Syntax: 'let z = x.T ... select w')
                                                                    Left: 
                                                                      IPropertyReferenceOperation: System.Char <anonymous type: System.Char x, System.String z>.x { get; } (OperationKind.PropertyReference, Type: System.Char, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                                        Instance Receiver: 
                                                                          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Char x, System.String z>, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                                    Right: 
                                                                      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Char, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                                  ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                                    Left: 
                                                                      IPropertyReferenceOperation: System.String <anonymous type: System.Char x, System.String z>.z { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'x.ToString()')
                                                                        Instance Receiver: 
                                                                          IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Char x, System.String z>, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                                    Right: 
                                                                      IInvocationOperation (virtual System.String System.Char.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'x.ToString()')
                                                                        Instance Receiver: 
                                                                          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'x')
                                                                        Arguments(0)
                                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'z')
                                        IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<<anonymous type: System.Char x, System.String z>, System.String>, IsImplicit) (Syntax: 'z')
                                          Target: 
                                            IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsImplicit) (Syntax: 'z')
                                              IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'z')
                                                IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'z')
                                                  ReturnedValue: 
                                                    IPropertyReferenceOperation: System.String <anonymous type: System.Char x, System.String z>.z { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'z')
                                                      Instance Receiver: 
                                                        IParameterReferenceOperation: <>h__TransparentIdentifier0 (OperationKind.ParameterReference, Type: <anonymous type: System.Char x, System.String z>, IsImplicit) (Syntax: 'z')
                                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'w')
                                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<System.String, System.String>, IsImplicit) (Syntax: 'w')
                                  Target: 
                                    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsImplicit) (Syntax: 'w')
                                      IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'w')
                                        IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'w')
                                          ReturnedValue: 
                                            IParameterReferenceOperation: w (OperationKind.ParameterReference, Type: System.String) (Syntax: 'w')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Initializer: 
            null
  AtLoopBottom(0)
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
        Locals: Local_1: System.String item
        LoopControlVariable: 
          IVariableDeclaratorOperation (Symbol: System.String item) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
            Initializer: 
              null
        Collection: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.String>, IsImplicit) (Syntax: 'str')
            Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILocalReferenceOperation: str (OperationKind.LocalReference, Type: System.Collections.Generic.IEnumerable<System.String>) (Syntax: 'str')
        Body: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... Line(item);')
              Expression: 
                IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... eLine(item)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'item')
                        ILocalReferenceOperation: item (OperationKind.LocalReference, Type: System.String) (Syntax: 'item')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        NextVariables(0)
      IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return;')
        ReturnedValue: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,118932,119010);

f_22036_118932_119009(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,102632,119021);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,102632,119021);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,102632,119021);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_QueryInBody()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,119033,132821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,119236,119790);

string 
source = @"
using System.Linq;
using System.Collections.Generic;
class C
{
    static void Main(string[] args)
    {
        foreach (var item in fun())
        {
            System.Console.WriteLine(item);
        }
    }

    private static IEnumerable<string> fun()
    {
        /*<bind>*/for (int i = 0; i < 5;)
        {
            return from x in ""123""
                   let z = x.ToString()
                   select z into w
                   select w;
        }/*</bind>*/
        return null;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,119804,132718);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom(0)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return from ... select w;')
        ReturnedValue: 
          ITranslatedQueryOperation (OperationKind.TranslatedQuery, Type: System.Collections.Generic.IEnumerable<System.String>) (Syntax: 'from x in "" ... select w')
            Expression: 
              IInvocationOperation (System.Collections.Generic.IEnumerable<System.String> System.Linq.Enumerable.Select<System.String, System.String>(this System.Collections.Generic.IEnumerable<System.String> source, System.Func<System.String, System.String> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<System.String>, IsImplicit) (Syntax: 'select w')
                Instance Receiver: 
                  null
                Arguments(2):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'select z')
                      IInvocationOperation (System.Collections.Generic.IEnumerable<System.String> System.Linq.Enumerable.Select<<anonymous type: System.Char x, System.String z>, System.String>(this System.Collections.Generic.IEnumerable<<anonymous type: System.Char x, System.String z>> source, System.Func<<anonymous type: System.Char x, System.String z>, System.String> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<System.String>, IsImplicit) (Syntax: 'select z')
                        Instance Receiver: 
                          null
                        Arguments(2):
                            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'let z = x.ToString()')
                              IInvocationOperation (System.Collections.Generic.IEnumerable<<anonymous type: System.Char x, System.String z>> System.Linq.Enumerable.Select<System.Char, <anonymous type: System.Char x, System.String z>>(this System.Collections.Generic.IEnumerable<System.Char> source, System.Func<System.Char, <anonymous type: System.Char x, System.String z>> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<<anonymous type: System.Char x, System.String z>>, IsImplicit) (Syntax: 'let z = x.ToString()')
                                Instance Receiver: 
                                  null
                                Arguments(2):
                                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'from x in ""123""')
                                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Char>, IsImplicit) (Syntax: 'from x in ""123""')
                                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                        Operand: 
                                          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""123"") (Syntax: '""123""')
                                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'x.ToString()')
                                      IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<System.Char, <anonymous type: System.Char x, System.String z>>, IsImplicit) (Syntax: 'x.ToString()')
                                        Target: 
                                          IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsImplicit) (Syntax: 'x.ToString()')
                                            IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'x.ToString()')
                                              IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x.ToString()')
                                                ReturnedValue: 
                                                  IAnonymousObjectCreationOperation (OperationKind.AnonymousObjectCreation, Type: <anonymous type: System.Char x, System.String z>, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                    Initializers(2):
                                                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Char, IsImplicit) (Syntax: 'let z = x.T ... select w')
                                                          Left: 
                                                            IPropertyReferenceOperation: System.Char <anonymous type: System.Char x, System.String z>.x { get; } (OperationKind.PropertyReference, Type: System.Char, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                              Instance Receiver: 
                                                                IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Char x, System.String z>, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                          Right: 
                                                            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Char, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                          Left: 
                                                            IPropertyReferenceOperation: System.String <anonymous type: System.Char x, System.String z>.z { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'x.ToString()')
                                                              Instance Receiver: 
                                                                IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: <anonymous type: System.Char x, System.String z>, IsImplicit) (Syntax: 'let z = x.ToString()')
                                                          Right: 
                                                            IInvocationOperation (virtual System.String System.Char.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'x.ToString()')
                                                              Instance Receiver: 
                                                                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'x')
                                                              Arguments(0)
                                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'z')
                              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<<anonymous type: System.Char x, System.String z>, System.String>, IsImplicit) (Syntax: 'z')
                                Target: 
                                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsImplicit) (Syntax: 'z')
                                    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'z')
                                      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'z')
                                        ReturnedValue: 
                                          IPropertyReferenceOperation: System.String <anonymous type: System.Char x, System.String z>.z { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'z')
                                            Instance Receiver: 
                                              IParameterReferenceOperation: <>h__TransparentIdentifier0 (OperationKind.ParameterReference, Type: <anonymous type: System.Char x, System.String z>, IsImplicit) (Syntax: 'z')
                              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'w')
                      IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<System.String, System.String>, IsImplicit) (Syntax: 'w')
                        Target: 
                          IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsImplicit) (Syntax: 'w')
                            IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'w')
                              IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'w')
                                ReturnedValue: 
                                  IParameterReferenceOperation: w (OperationKind.ParameterReference, Type: System.String) (Syntax: 'w')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,132732,132810);

f_22036_132732_132809(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,119033,132821);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,119033,132821);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,119033,132821);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ExpressiontreeInInit()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,132833,139594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,133045,133412);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        System.Linq.Expressions.Expression<System.Func<int, int>> e = x => x % 6;
        int i = 1;
        /*<bind>*/for (e = x => x * x; i < 5; i++)
        {
            var lambda = e.Compile();
            System.Console.WriteLine(lambda(i));
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,133426,139491);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (e = x  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'e = x => x * x')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>) (Syntax: 'e = x => x * x')
            Left: 
              ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>) (Syntax: 'e')
            Right: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>, IsImplicit) (Syntax: 'x => x * x')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: 'x => x * x')
                    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'x * x')
                      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x * x')
                        ReturnedValue: 
                          IBinaryOperation (BinaryOperatorKind.Multiply) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x * x')
                            Left: 
                              IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                            Right: 
                              IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i++')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  Body: 
    IBlockOperation (2 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Func<System.Int32, System.Int32> lambda
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var lambda  ... .Compile();')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var lambda = e.Compile()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Func<System.Int32, System.Int32> lambda) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'lambda = e.Compile()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= e.Compile()')
                    IInvocationOperation ( System.Func<System.Int32, System.Int32> System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>.Compile()) (OperationKind.Invocation, Type: System.Func<System.Int32, System.Int32>) (Syntax: 'e.Compile()')
                      Instance Receiver: 
                        ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>) (Syntax: 'e')
                      Arguments(0)
          Initializer: 
            null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... lambda(i));')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... (lambda(i))')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'lambda(i)')
                  IInvocationOperation (virtual System.Int32 System.Func<System.Int32, System.Int32>.Invoke(System.Int32 arg)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'lambda(i)')
                    Instance Receiver: 
                      ILocalReferenceOperation: lambda (OperationKind.LocalReference, Type: System.Func<System.Int32, System.Int32>) (Syntax: 'lambda')
                    Arguments(1):
                        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg) (OperationKind.Argument, Type: null) (Syntax: 'i')
                          ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,139505,139583);

f_22036_139505_139582(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,132833,139594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,132833,139594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,132833,139594);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ExpressiontreeInIterator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,139606,147540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,139822,140186);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        System.Linq.Expressions.Expression<System.Func<int, int>> e = x => x % 6;
        /*<bind>*/for (int i = 1; i < 5; e = x => x * x, i = i + 1)
        {
            var lambda = e.Compile();
            System.Console.WriteLine(lambda(i));
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,140200,147437);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 1')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 1')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 1')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'e = x => x * x')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>) (Syntax: 'e = x => x * x')
            Left: 
              ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>) (Syntax: 'e')
            Right: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>, IsImplicit) (Syntax: 'x => x * x')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: 'x => x * x')
                    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'x * x')
                      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x * x')
                        ReturnedValue: 
                          IBinaryOperation (BinaryOperatorKind.Multiply) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x * x')
                            Left: 
                              IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                            Right: 
                              IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = i + 1')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + 1')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + 1')
                Left: 
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Body: 
    IBlockOperation (2 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Func<System.Int32, System.Int32> lambda
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var lambda  ... .Compile();')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var lambda = e.Compile()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Func<System.Int32, System.Int32> lambda) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'lambda = e.Compile()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= e.Compile()')
                    IInvocationOperation ( System.Func<System.Int32, System.Int32> System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>.Compile()) (OperationKind.Invocation, Type: System.Func<System.Int32, System.Int32>) (Syntax: 'e.Compile()')
                      Instance Receiver: 
                        ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Linq.Expressions.Expression<System.Func<System.Int32, System.Int32>>) (Syntax: 'e')
                      Arguments(0)
          Initializer: 
            null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... lambda(i));')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... (lambda(i))')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'lambda(i)')
                  IInvocationOperation (virtual System.Int32 System.Func<System.Int32, System.Int32>.Invoke(System.Int32 arg)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'lambda(i)')
                    Instance Receiver: 
                      ILocalReferenceOperation: lambda (OperationKind.LocalReference, Type: System.Func<System.Int32, System.Int32>) (Syntax: 'lambda')
                    Arguments(1):
                        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg) (OperationKind.Argument, Type: null) (Syntax: 'i')
                          ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,147451,147529);

f_22036_147451_147528(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,139606,147540);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,139606,147540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,139606,147540);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_CustomerTypeInFor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,147552,150734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,147761,148021);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (C1 i = new C1(); i == null; i++) { }/*</bind>*/
    }
}
public class C1
{
    public static C1 operator ++(C1 obj)
    {
        return obj;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,148035,150631);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (C1 i = ... l; i++) { }')
  Locals: Local_1: C1 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i == null')
      Left: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'i')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILocalReferenceOperation: i (OperationKind.LocalReference, Type: C1) (Syntax: 'i')
      Right: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'C1 i = new C1()')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C1 i = new C1()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: C1 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = new C1()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C1()')
                    IObjectCreationOperation (Constructor: C1..ctor()) (OperationKind.ObjectCreation, Type: C1) (Syntax: 'new C1()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i++')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperatorMethod: C1 C1.op_Increment(C1 obj)) (OperationKind.Increment, Type: C1) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: C1) (Syntax: 'i')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,150645,150723);

f_22036_150645_150722(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,147552,150734);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,147552,150734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,147552,150734);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_PostFixIncrementInFor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,150746,154262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,150959,151197);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        /*<bind>*/for (int j = i++; j < 5; ++j)
        {
            System.Console.WriteLine(j);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,151211,154159);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
  Locals: Local_1: System.Int32 j
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 5')
      Left: 
        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = i++')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = i++')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = i++')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i++')
                    IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
                      Target: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: '++j')
        Expression: 
          IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++j')
            Target: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(j);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(j)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'j')
                  ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,154173,154251);

f_22036_154173_154250(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,150746,154262);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,150746,154262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,150746,154262);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_PreFixIncrementInFor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,154274,157790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,154486,154726);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        /*<bind>*/for (int j = ++i; j < 5; ++j)
        {
            System.Console.WriteLine(j);
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,154740,157687);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int j  ... }')
  Locals: Local_1: System.Int32 j
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 5')
      Left: 
        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int j = ++i')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = ++i')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = ++i')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ++i')
                    IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++i')
                      Target: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: '++j')
        Expression: 
          IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++j')
            Target: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(j);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(j)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'j')
                  ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,157701,157779);

f_22036_157701_157778(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,154274,157790);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,154274,157790);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,154274,157790);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_PreFixIncrementInCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,157802,160888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,158020,158234);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; ++i < 5;)
        {
            System.Console.WriteLine(i);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,158248,160785);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: '++i < 5')
      Left: 
        IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++i')
          Target: 
            ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom(0)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(i);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(i)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'i')
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,160799,160877);

f_22036_160799_160876(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,157802,160888);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,157802,160888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,157802,160888);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_PostFixDecrementInCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,160900,164910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,161119,161401);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int i = 0; foo(i--) > -5;)
        {
            System.Console.WriteLine(i);
        }/*</bind>*/
    }
    static int foo(int x)
    {
        return x;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,161415,164807);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'foo(i--) > -5')
      Left: 
        IInvocationOperation (System.Int32 Program.foo(System.Int32 x)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'foo(i--)')
          Instance Receiver: 
            null
          Arguments(1):
              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'i--')
                IIncrementOrDecrementOperation (Postfix) (OperationKind.Decrement, Type: System.Int32) (Syntax: 'i--')
                  Target: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Right: 
        IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, Constant: -5) (Syntax: '-5')
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom(0)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(i);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(i)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'i')
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,164821,164899);

f_22036_164821_164898(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,160900,164910);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,160900,164910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,160900,164910);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_InfiniteLoopVerify()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,164922,166868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,165132,165338);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/for (; true;)
        {
            System.Console.WriteLine(""z"");
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,165352,166765);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (; true ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  Before(0)
  AtLoopBottom(0)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... eLine(""z"");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... teLine(""z"")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""z""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""z"") (Syntax: '""z""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,166779,166857);

f_22036_166779_166856(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,164922,166868);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,164922,166868);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,164922,166868);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_InvalidExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,166880,170097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,167089,167273);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/for (int k = 0, j = 0; k < 100, j > 5;/*</bind>*/ k++)
        {
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,167287,169994);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'for (int k  ... 100, j > 5;')
  Locals: Local_1: System.Int32 k
    Local_2: System.Int32 j
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean, IsInvalid) (Syntax: 'k < 100')
      Left: 
        ILocalReferenceOperation: k (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 100, IsInvalid) (Syntax: '100')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int k = 0, j = 0')
        IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int k = 0, j = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 k) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'k = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
              IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: '')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
            Children(0)
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'j > 5')
        Expression: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean, IsInvalid) (Syntax: 'j > 5')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5, IsInvalid) (Syntax: '5')
  Body: 
    IEmptyOperation (OperationKind.Empty, Type: null, IsInvalid) (Syntax: ';')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,170008,170086);

f_22036_170008_170085(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,166880,170097);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,166880,170097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,166880,170097);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForLoopStatement_ConditionOutVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,170109,177233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,170316,170584);

string 
source = @"
class P
{
    private void M()
    {
        var s = """";
        /*<bind>*/for (var j = int.TryParse(s, out var i) ? i : 0; i < 10; i++)
        {
            System.Console.WriteLine($""i={i}, s={s}"");
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,170598,177130);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (var j  ... }')
  Locals: Local_1: System.Int32 j
    Local_2: System.Int32 i
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var j = int ...  i) ? i : 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var j = int ...  i) ? i : 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = int.Try ...  i) ? i : 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= int.TryPa ...  i) ? i : 0')
                    IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'int.TryPars ...  i) ? i : 0')
                      Condition: 
                        IInvocationOperation (System.Boolean System.Int32.TryParse(System.String s, out System.Int32 result)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'int.TryPars ...  out var i)')
                          Instance Receiver: 
                            null
                          Arguments(2):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: s) (OperationKind.Argument, Type: null) (Syntax: 's')
                                ILocalReferenceOperation: s (OperationKind.LocalReference, Type: System.String) (Syntax: 's')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: result) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                                IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                                  ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      WhenTrue: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                      WhenFalse: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i++')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... }, s={s}"");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... i}, s={s}"")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '$""i={i}, s={s}""')
                  IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""i={i}, s={s}""')
                    Parts(4):
                        IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'i=')
                          Text: 
                            ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""i="", IsImplicit) (Syntax: 'i=')
                        IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{i}')
                          Expression: 
                            ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                          Alignment: 
                            null
                          FormatString: 
                            null
                        IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ', s=')
                          Text: 
                            ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "", s="", IsImplicit) (Syntax: ', s=')
                        IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{s}')
                          Expression: 
                            ILocalReferenceOperation: s (OperationKind.LocalReference, Type: System.String) (Syntax: 's')
                          Alignment: 
                            null
                          FormatString: 
                            null
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,177144,177222);

f_22036_177144_177221(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,170109,177233);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,170109,177233);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,170109,177233);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IForLoopStatement_InvalidIterationVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,177245,179956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,177406,177637);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        /*<bind>*/for (int i = 0; true;)
        {
            System.Console.WriteLine(i);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,177651,179853);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'for (int i  ... }')
  Locals: Local_1: System.Int32 i
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  Before:
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid, IsImplicit) (Syntax: 'int i = 0')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  AtLoopBottom(0)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(i);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(i)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'i')
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,179867,179945);

f_22036_179867_179944(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,177245,179956);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,177245,179956);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,177245,179956);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(21823, "https://github.com/dotnet/roslyn/issues/21823")]
        [Fact]
        public void IForLoopStatement_CollectionLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,179968,184296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,180186,180494);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/for (; GetBool(out var a); GetBool(out var b))
        {
            System.Console.WriteLine(a);
        }/*</bind>*/
    }

    static bool GetBool(out int x)
    {
        throw null;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,180508,184089);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (; GetB ... }')
  ConditionLocals: Local_1: System.Int32 a
  Condition: 
    IInvocationOperation (System.Boolean Program.GetBool(out System.Int32 x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'GetBool(out var a)')
      Instance Receiver: 
        null
      Arguments(1):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var a')
            IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var a')
              ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Before(0)
  AtLoopBottom:
      IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'GetBool(out var b)')
        Locals: Local_1: System.Int32 b
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'GetBool(out var b)')
          Expression: 
            IInvocationOperation (System.Boolean Program.GetBool(out System.Int32 x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'GetBool(out var b)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var b')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var b')
                      ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(a);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(a)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'a')
                  ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,184103,184156);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,184172,184285);

f_22036_184172_184284(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,179968,184296);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,179968,184296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,179968,184296);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IForLoopStatement_MultipleIncrements()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,184308,187998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,184452,184766);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        /*<bind>*/for (;; GetBool(out var j), j++)
        {
            System.Console.WriteLine(i);
        }/*</bind>*/
    }

    static bool GetBool(out int x)
    {
        throw null;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,184780,187791);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (;; Get ... }')
  Condition: 
    null
  Before(0)
  AtLoopBottom:
      IBlockOperation (2 statements, 1 locals) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'GetBool(out var j)')
        Locals: Local_1: System.Int32 j
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'GetBool(out var j)')
          Expression: 
            IInvocationOperation (System.Boolean Program.GetBool(out System.Int32 x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'GetBool(out var j)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var j')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var j')
                      ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j++')
          Expression: 
            IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'j++')
              Target: 
                ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(i);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(i)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'i')
                  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,187805,187858);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,187874,187987);

f_22036_187874_187986(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,184308,187998);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,184308,187998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,184308,187998);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,188010,196335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,188154,188478);

string 
source = @"
public sealed class MyClass
{
    void M(int result)
    /*<bind>*/{
        for (int i = Get<int>(out var a); Get<bool>(out var b); Get(out int c), i++)
        {
            result = b ? a : i;
        }
    }/*</bind>*/

    static T Get<T>(out T x)
    {
        throw null;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,188492,188545);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,188561,196212);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i] [System.Int32 a]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = Get<int>(out var a)')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = Get<int>(out var a)')
              Right: 
                IInvocationOperation (System.Int32 MyClass.Get<System.Int32>(out System.Int32 x)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Get<int>(out var a)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var a')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var a')
                          ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B8]
        Statements (0)
        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Boolean b]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if False (Regular) to Block[B9]
                IInvocationOperation (System.Boolean MyClass.Get<System.Boolean>(out System.Boolean x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'Get<bool>(out var b)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var b')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Boolean) (Syntax: 'var b')
                          ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'b')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R2} {R1}

            Next (Regular) Block[B4]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [0] [1]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
                      Value: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

                Jump if False (Regular) to Block[B6]
                    ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'b')

                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')

                Next (Regular) Block[B7]
            Block[B6] - Block
                Predecessors: [B4]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                      Value: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

                Next (Regular) Block[B7]
            Block[B7] - Block
                Predecessors: [B5] [B6]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = b ? a : i;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = b ? a : i')
                          Left: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                          Right: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? a : i')

                Next (Regular) Block[B8]
                    Leaving: {R3}
                    Entering: {R4}
        }
        .locals {R4}
        {
            Locals: [System.Int32 c]
            Block[B8] - Block
                Predecessors: [B7]
                Statements (2)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'Get(out int c)')
                      Expression: 
                        IInvocationOperation (System.Int32 MyClass.Get<System.Int32>(out System.Int32 x)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Get(out int c)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out int c')
                                IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int c')
                                  ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'c')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i++')
                      Expression: 
                        IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
                          Target: 
                            ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

                Next (Regular) Block[B2]
                    Leaving: {R4} {R2}
        }
    }
}

Block[B9] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,196226,196324);

f_22036_196226_196323(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,188010,196335);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,188010,196335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,188010,196335);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,196347,200608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,196491,196723);

string 
source = @"
public sealed class MyClass
{
    void M(int result, int a, int b, bool c)
    /*<bind>*/{
        for (int i = c ? a : b, j = 0; ; j++)
        {
            result = i;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,196737,196790);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,196806,200485);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32 i] [System.Int32 j]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Jump if False (Regular) to Block[B3]
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')

            Next (Regular) Block[B4]
        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                  Value: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = c ? a : b')
                  Left: 
                    ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = c ? a : b')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'c ? a : b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'j = 0')
              Left: 
                ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'j = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B5] [B6]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = i;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = i')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                  Right: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j++')
              Expression: 
                IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'j++')
                  Target: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')

        Next (Regular) Block[B6]
}

Block[B7] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,200499,200597);

f_22036_200499_200596(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,196347,200608);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,196347,200608);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,196347,200608);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,200620,206186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,200764,201086);

string 
source = @"
public sealed class MyClass
{
    void M(int result, int a, int b, bool c, int i, int j)
    /*<bind>*/{
        for (i = c ? a : b, j = 0; Get(out var k); )
        {
            result = k;
        }
    }/*</bind>*/

    static bool Get(out int x)
    {
        throw null;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,201100,201153);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,201169,206063);

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
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i = c ? a : b')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = c ? a : b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'c ? a : b')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Block
    Predecessors: [B4]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = 0')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 0')
              Left: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

    Next (Regular) Block[B6]
Block[B6] - Block
    Predecessors: [B5] [B8]
    Statements (0)
    Next (Regular) Block[B7]
        Entering: {R2}

.locals {R2}
{
    Locals: [System.Int32 k]
    Block[B7] - Block
        Predecessors: [B6]
        Statements (0)
        Jump if False (Regular) to Block[B9]
            IInvocationOperation (System.Boolean MyClass.Get(out System.Int32 x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'Get(out var k)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var k')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var k')
                      ILocalReferenceOperation: k (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R2}

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = k;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = k')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                  Right: 
                    ILocalReferenceOperation: k (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'k')

        Next (Regular) Block[B6]
            Leaving: {R2}
}

Block[B9] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,206077,206175);

f_22036_206077_206174(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,200620,206186);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,200620,206186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,200620,206186);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,206198,208334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,206342,206559);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, bool a, bool b, bool c)
    /*<bind>*/{
        for (; a ? b : c ;)
        {
            result = a;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,206573,206626);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,206642,208211);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B4]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B5]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B5]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B2] [B3]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = a')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B1]
Block[B5] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,208225,208323);

f_22036_208225_208322(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,206198,208334);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,206198,208334);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,206198,208334);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,208346,213576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,208490,208736);

string 
source = @"
public sealed class MyClass
{
    void M(int result, MyClass a, MyClass b)
    /*<bind>*/{
        for (int i = 0; i < 3 ; (a ?? b).f++)
        {
            result = i;
        }
    }/*</bind>*/

    int f;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,208750,208803);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,208819,213453);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B7]
        Statements (0)
        Jump if False (Regular) to Block[B8]
            IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 3')
              Left: 
                ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Leaving: {R1}

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = i;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = i')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                  Right: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

        Next (Regular) Block[B4]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [1]
        .locals {R3}
        {
            CaptureIds: [0]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: MyClass) (Syntax: 'a')

                Jump if True (Regular) to Block[B6]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'a')
                    Leaving: {R3}

                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'a')

                Next (Regular) Block[B7]
                    Leaving: {R3}
        }

        Block[B6] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                  Value: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: MyClass) (Syntax: 'b')

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: '(a ?? b).f++')
                  Expression: 
                    IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: '(a ?? b).f++')
                      Target: 
                        IFieldReferenceOperation: System.Int32 MyClass.f (OperationKind.FieldReference, Type: System.Int32) (Syntax: '(a ?? b).f')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'a ?? b')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B8] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,213467,213565);

f_22036_213467_213564(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,208346,213576);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,208346,213576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,208346,213576);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,213588,217012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,213732,213973);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, bool x)
    /*<bind>*/{
        for (int i = 0; i < 3; i++) 
        { 
            if (x) continue;
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,213987,214040);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,214056,216889);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B5]
        Statements (0)
        Jump if False (Regular) to Block[B6]
            IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 3')
              Left: 
                ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Leaving: {R1}

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')

        Next (Regular) Block[B5]
    Block[B4] - Block
        Predecessors: [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = x')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i++')
              Expression: 
                IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
                  Target: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

        Next (Regular) Block[B2]
}

Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,216903,217001);

f_22036_216903_217000(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,213588,217012);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,213588,217012);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,213588,217012);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22036,217024,220363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,217168,217406);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, bool x)
    /*<bind>*/{
        for (int i = 0; i < 3; i++) 
        { 
            if (x) break;
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,217420,217473);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,217489,220240);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B4]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 3')
              Left: 
                ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Leaving: {R1}

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')

        Next (Regular) Block[B5]
            Leaving: {R1}
    Block[B4] - Block
        Predecessors: [B3]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = x')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'i++')
              Expression: 
                IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
                  Target: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

        Next (Regular) Block[B2]
}

Block[B5] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22036,220254,220352);

f_22036_220254_220351(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22036,217024,220363);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22036,217024,220363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22036,217024,220363);
}
		}

int
f_22036_3980_4057(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 3980, 4057);
return 0;
}


int
f_22036_7197_7274(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 7197, 7274);
return 0;
}


int
f_22036_10418_10495(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 10418, 10495);
return 0;
}


int
f_22036_14962_15039(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 14962, 15039);
return 0;
}


int
f_22036_19490_19567(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 19490, 19567);
return 0;
}


int
f_22036_21855_21932(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 21855, 21932);
return 0;
}


int
f_22036_26282_26359(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 26282, 26359);
return 0;
}


int
f_22036_28265_28342(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 28265, 28342);
return 0;
}


int
f_22036_31022_31099(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 31022, 31099);
return 0;
}


int
f_22036_32924_33001(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 32924, 33001);
return 0;
}


int
f_22036_35629_35706(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 35629, 35706);
return 0;
}


int
f_22036_40798_40875(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 40798, 40875);
return 0;
}


int
f_22036_46543_46620(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 46543, 46620);
return 0;
}


int
f_22036_52082_52159(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 52082, 52159);
return 0;
}


int
f_22036_58050_58127(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 58050, 58127);
return 0;
}


int
f_22036_66294_66371(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 66294, 66371);
return 0;
}


int
f_22036_72694_72771(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 72694, 72771);
return 0;
}


int
f_22036_77410_77487(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 77410, 77487);
return 0;
}


int
f_22036_81079_81156(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 81079, 81156);
return 0;
}


int
f_22036_84751_84828(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 84751, 84828);
return 0;
}


int
f_22036_89392_89469(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 89392, 89469);
return 0;
}


int
f_22036_91382_91459(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 91382, 91459);
return 0;
}


int
f_22036_96494_96571(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 96494, 96571);
return 0;
}


int
f_22036_99845_99922(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 99845, 99922);
return 0;
}


int
f_22036_102531_102608(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 102531, 102608);
return 0;
}


int
f_22036_118932_119009(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 118932, 119009);
return 0;
}


int
f_22036_132732_132809(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 132732, 132809);
return 0;
}


int
f_22036_139505_139582(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 139505, 139582);
return 0;
}


int
f_22036_147451_147528(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 147451, 147528);
return 0;
}


int
f_22036_150645_150722(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 150645, 150722);
return 0;
}


int
f_22036_154173_154250(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 154173, 154250);
return 0;
}


int
f_22036_157701_157778(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 157701, 157778);
return 0;
}


int
f_22036_160799_160876(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 160799, 160876);
return 0;
}


int
f_22036_164821_164898(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 164821, 164898);
return 0;
}


int
f_22036_166779_166856(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 166779, 166856);
return 0;
}


int
f_22036_170008_170085(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 170008, 170085);
return 0;
}


int
f_22036_177144_177221(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 177144, 177221);
return 0;
}


int
f_22036_179867_179944(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 179867, 179944);
return 0;
}


int
f_22036_184172_184284(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 184172, 184284);
return 0;
}


int
f_22036_187874_187986(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 187874, 187986);
return 0;
}


int
f_22036_196226_196323(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 196226, 196323);
return 0;
}


int
f_22036_200499_200596(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 200499, 200596);
return 0;
}


int
f_22036_206077_206174(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 206077, 206174);
return 0;
}


int
f_22036_208225_208322(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 208225, 208322);
return 0;
}


int
f_22036_213467_213564(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 213467, 213564);
return 0;
}


int
f_22036_216903_217000(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 216903, 217000);
return 0;
}


int
f_22036_220254_220351(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22036, 220254, 220351);
return 0;
}

}
}
