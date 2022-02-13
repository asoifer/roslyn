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
        public void IWhileUntilLoopStatement_DoWhileLoopsTest()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,503,3420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,718,1047);

string 
source = @"
class Program
{
    static void Main()
    {
        int[] ids = new int[] { 6, 7, 8, 10 };
        int sum = 0;
        int i = 0;
        /*<bind>*/do
        {
            sum += ids[i];
            i++;
        } while (i < 4);/*</bind>*/

        System.Console.WriteLine(sum);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,1061,3318);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: False, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'do ... le (i < 4);')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 4')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'sum += ids[i];')
        Expression: 
          ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'sum += ids[i]')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Left: 
              ILocalReferenceOperation: sum (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'sum')
            Right: 
              IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'ids[i]')
                Array reference: 
                  ILocalReferenceOperation: ids (OperationKind.LocalReference, Type: System.Int32[]) (Syntax: 'ids')
                Indices(1):
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,3332,3409);

f_22076_3332_3408(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,503,3420);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,503,3420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,503,3420);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileLoopsTest()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,3432,6006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,3645,3954);

string 
source = @"
class Program
{
    static int SumWhile()
    {
        //
        // Sum numbers 0 .. 4
        //
        int sum = 0;
        int i = 0;
        /*<bind>*/while (i < 5)
        {
            sum += i;
            i++;
        }/*</bind>*/
        return sum;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,3968,5901);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (i <  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 5')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'sum += i;')
        Expression: 
          ICompoundAssignmentOperation (BinaryOperatorKind.Add) (OperationKind.CompoundAssignment, Type: System.Int32) (Syntax: 'sum += i')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Left: 
              ILocalReferenceOperation: sum (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'sum')
            Right: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,5915,5995);

f_22076_5915_5994(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,3432,6006);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,3432,6006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,3432,6006);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileConditionTrue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,6018,9428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,6235,6588);

string 
source = @"
using System;

class Program
{
    static void Main()
    {
        int index = 0;
        bool condition = true;
        /*<bind>*/while (condition)
        {
            int value = ++index;
            if (value > 10)
            {
                condition = false;
            }
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,6602,9323);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (cond ... }')
  Condition: 
    ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
  Body: 
    IBlockOperation (2 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 value
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int value = ++index;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int value = ++index')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'value = ++index')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ++index')
                    IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++index')
                      Target: 
                        ILocalReferenceOperation: index (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'index')
          Initializer: 
            null
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (value > ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'value > 10')
            Left: 
              ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'value')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = false')
                  Left: 
                    ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
        WhenFalse: 
          null
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,9337,9417);

f_22076_9337_9416(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,6018,9428);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,6018,9428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,6018,9428);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithBreak()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,9440,14565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,9653,10072);

string 
source = @"
using System;

class Program
{
    static void Main()
    {
        int index = 0;
        /*<bind>*/while (true)
        {
            int value = ++index;
            if (value > 5)
            {
                Console.WriteLine(""While-loop break"");
                break;
            }
            Console.WriteLine(""While-loop statement"");
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,10086,14460);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (true ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  Body: 
    IBlockOperation (3 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 value
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int value = ++index;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int value = ++index')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'value = ++index')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ++index')
                    IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++index')
                      Target: 
                        ILocalReferenceOperation: index (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'index')
          Initializer: 
            null
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (value > ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'value > 5')
            Left: 
              ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'value')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
        WhenTrue: 
          IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... op break"");')
              Expression: 
                IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... oop break"")')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""While-loop break""')
                        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""While-loop break"") (Syntax: '""While-loop break""')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            IBranchOperation (BranchKind.Break, Label Id: 1) (OperationKind.Branch, Type: null) (Syntax: 'break;')
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... tatement"");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... statement"")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""While-loop statement""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""While-loop statement"") (Syntax: '""While-loop statement""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,14474,14554);

f_22076_14474_14553(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,9440,14565);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,9440,14565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,9440,14565);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithThrow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,14577,19489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,14790,15182);

string 
source = @"
using System;

class Program
{
    static void Main()
    {
        int index = 0;
        /*<bind>*/while (true)
        {
            int value = ++index;
            if (value > 100)
            {
                throw new Exception(""Never hit"");
            }
            Console.WriteLine(""While-loop statement"");
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,15196,19384);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (true ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  Body: 
    IBlockOperation (3 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 value
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int value = ++index;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int value = ++index')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'value = ++index')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ++index')
                    IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++index')
                      Target: 
                        ILocalReferenceOperation: index (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'index')
          Initializer: 
            null
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (value > ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'value > 100')
            Left: 
              ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'value')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 100) (Syntax: '100')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw new E ... ever hit"");')
              IObjectCreationOperation (Constructor: System.Exception..ctor(System.String message)) (OperationKind.ObjectCreation, Type: System.Exception) (Syntax: 'new Excepti ... Never hit"")')
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: message) (OperationKind.Argument, Type: null) (Syntax: '""Never hit""')
                      ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Never hit"") (Syntax: '""Never hit""')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Initializer: 
                  null
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... tatement"");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... statement"")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""While-loop statement""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""While-loop statement"") (Syntax: '""While-loop statement""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,19398,19478);

f_22076_19398_19477(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,14577,19489);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,14577,19489);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,14577,19489);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithAssignment()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,19501,24445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,19719,20018);

string 
source = @"
using System;

class Program
{
    static void Main()
    {
        int value = 4;
        int i;
        /*<bind>*/while ((i = value) >= 0)
        {
             Console.WriteLine(""While {0} {1}"", i, value);
            value--;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,20032,24340);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while ((i = ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: '(i = value) >= 0')
      Left: 
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = value')
          Left: 
            ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
          Right: 
            ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'value')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ...  i, value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String format, System.Object arg0, System.Object arg1)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... , i, value)')
            Instance Receiver: 
              null
            Arguments(3):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: format) (OperationKind.Argument, Type: null) (Syntax: '""While {0} {1}""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""While {0} {1}"") (Syntax: '""While {0} {1}""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg0) (OperationKind.Argument, Type: null) (Syntax: 'i')
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'i')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg1) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'value')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'value--;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Decrement, Type: System.Int32) (Syntax: 'value--')
            Target: 
              ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'value')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,24354,24434);

f_22076_24354_24433(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,19501,24445);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,19501,24445);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,19501,24445);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileInvalidCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,24457,25791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,24677,24851);

string 
source = @"
class Program
{
    static void Main()
    {
        int number = 10;
        /*<bind>*/while (number)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,24865,25686);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'while (numb ... }')
  Condition: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'number')
      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: number (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'number')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,25700,25780);

f_22076_25700_25779(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,24457,25791);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,24457,25791);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,24457,25791);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithReturn()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,25803,28621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,26017,26413);

string 
source = @"
class Program
{
    static void Main()
    {
        System.Console.WriteLine(GetFirstEvenNumber(33));
    }
    public static int GetFirstEvenNumber(int number)
    {
        /*<bind>*/while (true)
        {
            if ((number % 2) == 0)
            {
                return number;
            }
            number++;

        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,26429,28516);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (true ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if ((number ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: '(number % 2) == 0')
            Left: 
              IBinaryOperation (BinaryOperatorKind.Remainder) (OperationKind.Binary, Type: System.Int32) (Syntax: 'number % 2')
                Left: 
                  IParameterReferenceOperation: number (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'number')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return number;')
              ReturnedValue: 
                IParameterReferenceOperation: number (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'number')
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'number++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'number++')
            Target: 
              IParameterReferenceOperation: number (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'number')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,28530,28610);

f_22076_28530_28609(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,25803,28621);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,25803,28621);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,25803,28621);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithGoto()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,28633,31727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,28845,29278);

string 
source = @"
class Program
{
    static void Main()
    {
        System.Console.WriteLine(GetFirstEvenNumber(33));
    }
    public static int GetFirstEvenNumber(int number)
    {
        /*<bind>*/while (true)
        {
            if ((number % 2) == 0)
            {
                goto Even;
            }
            number++;
        Even:
            return number;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,29292,31622);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (true ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  Body: 
    IBlockOperation (3 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if ((number ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: '(number % 2) == 0')
            Left: 
              IBinaryOperation (BinaryOperatorKind.Remainder) (OperationKind.Binary, Type: System.Int32) (Syntax: 'number % 2')
                Left: 
                  IParameterReferenceOperation: number (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'number')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IBranchOperation (BranchKind.GoTo, Label: Even) (OperationKind.Branch, Type: null) (Syntax: 'goto Even;')
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'number++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'number++')
            Target: 
              IParameterReferenceOperation: number (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'number')
      ILabeledOperation (Label: Even) (OperationKind.Labeled, Type: null) (Syntax: 'Even: ... urn number;')
        Statement: 
          IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return number;')
            ReturnedValue: 
              IParameterReferenceOperation: number (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'number')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,31636,31716);

f_22076_31636_31715(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,28633,31727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,28633,31727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,28633,31727);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileMissingCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,31739,35124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,31959,32287);

string 
source = @"
class Program
{
    static void Main()
    {
        int index = 0;
        bool condition = true;
        /*<bind>*/while ()
        {
            int value = ++index;
            if (value > 100)
            {
                condition = false;
            }
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,32301,35019);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'while () ... }')
  Condition: 
    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
      Children(0)
  Body: 
    IBlockOperation (2 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 value
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int value = ++index;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int value = ++index')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'value = ++index')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ++index')
                    IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++index')
                      Target: 
                        ILocalReferenceOperation: index (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'index')
          Initializer: 
            null
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (value > ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'value > 100')
            Left: 
              ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'value')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 100) (Syntax: '100')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = false')
                  Left: 
                    ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
        WhenFalse: 
          null
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,35033,35113);

f_22076_35033_35112(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,31739,35124);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,31739,35124);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,31739,35124);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileMissingStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,35136,36378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,35356,35531);

string 
source = @"
class ContinueTest
{
    static void Main()
    {
        int i = 0;
        /*<bind>*/while(i <= 10)
        {

        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,35545,36273);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while(i <=  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i <= 10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,36287,36367);

f_22076_36287_36366(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,35136,36378);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,35136,36378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,35136,36378);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithContinue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,36390,39879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,36606,36920);

string 
source = @"
class ContinueTest
{
    static void Main()
    {
        int i = 0;
        /*<bind>*/while(i <= 10)
        {
            i++;
            if (i < 9)
            {
                continue;
            }
            System.Console.WriteLine(i);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,36934,39774);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while(i <=  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i <= 10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Body: 
    IBlockOperation (3 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (i < 9) ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i < 9')
            Left: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IBranchOperation (BranchKind.Continue, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'continue;')
        WhenFalse: 
          null
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
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,39788,39868);

f_22076_39788_39867(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,36390,39879);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,36390,39879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,36390,39879);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileNested()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,39891,45601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,40101,40473);

string 
source = @"
class Test
{
    static void Main()
    {
        int i = 0;
        /*<bind>*/while(i<10)
        {
            i++;
            int j = 0;
            while (j < 10)
            {
                j++;
                System.Console.WriteLine(j);
            }
            System.Console.WriteLine(i);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,40487,45496);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while(i<10) ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i<10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Body: 
    IBlockOperation (4 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 j
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int j = 0;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
      IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'while (j <  ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 10')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        Body: 
          IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j++;')
              Expression: 
                IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'j++')
                  Target: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
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
        IgnoredCondition: 
          null
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
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,45510,45590);

f_22076_45510_45589(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,39891,45601);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,39891,45601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,39891,45601);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileChangeOuterInnerValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,45613,52215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,45838,46238);

string 
source = @"
class Test
{
    static void Main()
    {
        int i = 0;
        /*<bind>*/while(i<10)
        {
            i++;
            int j = 0;
            while (j < 10)
            {
                j++;
                i = i + j;
                System.Console.WriteLine(j);
            }
            System.Console.WriteLine(i);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,46252,52110);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while(i<10) ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i<10')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  Body: 
    IBlockOperation (4 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 j
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int j = 0;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int j = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
      IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 2, Exit Label Id: 3) (OperationKind.Loop, Type: null) (Syntax: 'while (j <  ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j < 10')
            Left: 
              ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        Body: 
          IBlockOperation (3 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j++;')
              Expression: 
                IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'j++')
                  Target: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = i + j;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = i + j')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'i + j')
                      Left: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
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
        IgnoredCondition: 
          null
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
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,52124,52204);

f_22076_52124_52203(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,45613,52215);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,45613,52215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,45613,52215);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithDynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,52227,54806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,52442,53153);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        dynamic d = new MyWhile();
        d.Initialize(5);
        /*<bind>*/while (d.Done)
        {
            d.Next();
        }/*</bind>*/
    }
}

public class MyWhile
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,53167,54701);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (d.Do ... }')
  Condition: 
    IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'd.Done')
      Operand: 
        IDynamicMemberReferenceOperation (Member Name: ""Done"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.Done')
          Type Arguments(0)
          Instance Receiver: 
            ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'd.Next();')
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
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,54715,54795);

f_22076_54715_54794(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,52227,54806);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,52227,54806);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,52227,54806);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileIncrementInCondition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,54818,57218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,55042,55269);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        /*<bind>*/while ( ++i < 5)
        {
            System.Console.WriteLine(i);
        }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,55283,57113);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while ( ++i ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: '++i < 5')
      Left: 
        IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++i')
          Target: 
            ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
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
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,57127,57207);

f_22076_57127_57206(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,54818,57218);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,54818,57218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,54818,57218);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileInfiniteLoop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,57230,58843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,57446,57636);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        int i = 1;
        /*<bind>*/while (i > 0)
        {
            i++;
        }/*</bind>*/
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,57650,58738);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (i >  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i > 0')
      Left: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
            Target: 
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,58752,58832);

f_22076_58752_58831(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,57230,58843);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,57230,58843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,57230,58843);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileConstantCheck()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,58855,60384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,59072,59265);

string 
source = @"
class Program
{
    bool foo()
    {
        const bool b = true;
        /*<bind>*/while (b == b)
        {
            return b;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,59279,60279);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (b == ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, Constant: True) (Syntax: 'b == b')
      Left: 
        ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Boolean, Constant: True) (Syntax: 'b')
      Right: 
        ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Boolean, Constant: True) (Syntax: 'b')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return b;')
        ReturnedValue: 
          ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Boolean, Constant: True) (Syntax: 'b')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,60293,60373);

f_22076_60293_60372(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,58855,60384);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,58855,60384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,58855,60384);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithTryCatch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,60396,64582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,60612,61000);

string 
source = @"
public class TryCatchFinally
{
    public void TryMethod()
    {
        sbyte x = 111, y;
        /*<bind>*/while (x-- > 0)
        {
            try
            {
                y = (sbyte)(x / 2);
            }
            finally
            {
                throw new System.Exception(); 
            }
        }/*</bind>*/
       
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,61014,64477);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (x--  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x-- > 0')
      Left: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'x--')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            IIncrementOrDecrementOperation (Postfix) (OperationKind.Decrement, Type: System.SByte) (Syntax: 'x--')
              Target: 
                ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.SByte) (Syntax: 'x')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
        Body: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'y = (sbyte)(x / 2);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.SByte) (Syntax: 'y = (sbyte)(x / 2)')
                  Left: 
                    ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.SByte) (Syntax: 'y')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.SByte) (Syntax: '(sbyte)(x / 2)')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        IBinaryOperation (BinaryOperatorKind.Divide) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x / 2')
                          Left: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'x')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              Operand: 
                                ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.SByte) (Syntax: 'x')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
        Catch clauses(0)
        Finally: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw new S ... xception();')
              IObjectCreationOperation (Constructor: System.Exception..ctor()) (OperationKind.ObjectCreation, Type: System.Exception) (Syntax: 'new System.Exception()')
                Arguments(0)
                Initializer: 
                  null
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,64491,64571);

f_22076_64491_64570(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,60396,64582);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,60396,64582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,60396,64582);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_WhileWithOutVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,64594,72016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,64808,65327);

string 
source = @"
public class X
{
    public static void Main()
    {
        bool f = true;

        /*<bind>*/while (Dummy(f, TakeOutParam((f ? 1 : 2), out var x1), x1))
        {
            System.Console.WriteLine(x1);
            f = false;
        }/*</bind>*/
    }

    static bool Dummy(bool x, object y, object z)
    {
        System.Console.WriteLine(z);
        return x;
    }

    static bool TakeOutParam<T>(T y, out T x)
    {
        x = y;
        return true;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,65341,71911);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: True, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'while (Dumm ... }')
  Locals: Local_1: System.Int32 x1
  Condition: 
    IInvocationOperation (System.Boolean X.Dummy(System.Boolean x, System.Object y, System.Object z)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'Dummy(f, Ta ... ar x1), x1)')
      Instance Receiver: 
        null
      Arguments(3):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'f')
            ILocalReferenceOperation: f (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'f')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'TakeOutPara ... out var x1)')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'TakeOutPara ... out var x1)')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                IInvocationOperation (System.Boolean X.TakeOutParam<System.Int32>(System.Int32 y, out System.Int32 x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'TakeOutPara ... out var x1)')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'f ? 1 : 2')
                        IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'f ? 1 : 2')
                          Condition: 
                            ILocalReferenceOperation: f (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'f')
                          WhenTrue: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          WhenFalse: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var x1')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var x1')
                          ILocalReferenceOperation: x1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: z) (OperationKind.Argument, Type: null) (Syntax: 'x1')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'x1')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILocalReferenceOperation: x1 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... teLine(x1);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... iteLine(x1)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'x1')
                  ILocalReferenceOperation: x1 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'f = false;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'f = false')
            Left: 
              ILocalReferenceOperation: f (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'f')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,71925,72005);

f_22076_71925_72004(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,64594,72016);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,64594,72016);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,64594,72016);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IWhileUntilLoopStatement_DoWithOutVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,72028,78525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,72239,72712);

string 
source = @"
class X
{
    public static void Main()
    {
        bool f = true;

        /*<bind>*/do
        {
            f = false;
        } while (Dummy(f, TakeOutParam((f ? 1 : 2), out var x1), x1));/*</bind>*/
    }

    static bool Dummy(bool x, object y, object z)
    {
        System.Console.WriteLine(z);
        return x;
    }

    static bool TakeOutParam<T>(T y, out T x)
    {
        x = y;
        return true;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,72726,78319);

string 
expectedOperationTree = @"
IWhileLoopOperation (ConditionIsTop: False, ConditionIsUntil: False) (LoopKind.While, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'do ...  x1), x1));')
  Locals: Local_1: System.Int32 x1
  Condition: 
    IInvocationOperation (System.Boolean X.Dummy(System.Boolean x, System.Object y, System.Object z)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'Dummy(f, Ta ... ar x1), x1)')
      Instance Receiver: 
        null
      Arguments(3):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'f')
            ILocalReferenceOperation: f (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'f')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'TakeOutPara ... out var x1)')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'TakeOutPara ... out var x1)')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                IInvocationOperation (System.Boolean X.TakeOutParam<System.Int32>(System.Int32 y, out System.Int32 x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'TakeOutPara ... out var x1)')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'f ? 1 : 2')
                        IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'f ? 1 : 2')
                          Condition: 
                            ILocalReferenceOperation: f (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'f')
                          WhenTrue: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          WhenFalse: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var x1')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var x1')
                          ILocalReferenceOperation: x1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: z) (OperationKind.Argument, Type: null) (Syntax: 'x1')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'x1')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILocalReferenceOperation: x1 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'f = false;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'f = false')
            Left: 
              ILocalReferenceOperation: f (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'f')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
  IgnoredCondition: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,78333,78386);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,78402,78514);

f_22076_78402_78513(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,72028,78525);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,72028,78525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,72028,78525);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void WhileFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,78537,80782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,78683,78897);

string 
source1 = @"
class P
{
    void M(bool condition1, bool condition2)
/*<bind>*/{
        while (condition1)
        {
            if (condition2) condition1 = false;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,78911,79103);

string 
source2 = @"
class P
{
    void M(bool condition1, bool condition2)
/*<bind>*/{
        while (condition1)
            if (condition2) condition1 = false;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,79117,80484);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B2] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: condition1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition1')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B1]
        IParameterReferenceOperation: condition2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition2')

    Next (Regular) Block[B3]
Block[B3] - Block
    Predecessors: [B2]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition1 = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition1 = false')
              Left: 
                IParameterReferenceOperation: condition1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B1]
Block[B4] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,80498,80551);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,80567,80662);

f_22076_80567_80661(source1, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,80676,80771);

f_22076_80676_80770(source2, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,78537,80782);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,78537,80782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,78537,80782);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DoFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,80794,82324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,80937,81127);

string 
source = @"
class P
{
    void M(bool condition)
/*<bind>*/{
        do
        {
            condition = false;
        }
        while (condition);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,81141,82136);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B1]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = false')
              Left: 
                IParameterReferenceOperation: condition (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Jump if True (Regular) to Block[B1]
        IParameterReferenceOperation: condition (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,82150,82203);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,82219,82313);

f_22076_82219_82312(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,80794,82324);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,80794,82324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,80794,82324);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DoFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,82336,83268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,82479,82637);

string 
source = @"
class P
{
    void M(bool condition)
/*<bind>*/{
        do
        {
        }
        while (condition);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,82651,83080);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B1]
    Statements (0)
    Jump if True (Regular) to Block[B1]
        IParameterReferenceOperation: condition (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,83094,83147);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,83163,83257);

f_22076_83163_83256(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,82336,83268);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,82336,83268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,82336,83268);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void WhileFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,83280,85057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,83426,83677);

string 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class P
{
    void M(bool condition1)
/*<bind>*/{
        while (condition1)
        {
            int i;
            i = 1;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,83691,84869);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B2]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: condition1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition1')

    Next (Regular) Block[B2]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B1]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,84883,84936);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,84952,85046);

f_22076_84952_85045(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,83280,85057);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,83280,85057);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,83280,85057);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void WhileFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,85069,86080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,85215,85446);

string 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class P
{
    void M(bool condition1)
/*<bind>*/{
        while (condition1)
        {
            int i;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,85460,85892);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B1]
    Statements (0)
    Jump if False (Regular) to Block[B2]
        IParameterReferenceOperation: condition1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition1')

    Next (Regular) Block[B1]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,85906,85959);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,85975,86069);

f_22076_85975_86068(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,85069,86080);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,85069,86080);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,85069,86080);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void WhileFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,86092,89190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,86238,86524);

string 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class P
{
    void M()
/*<bind>*/{
        while (filter(out var j))
        {
            int i;
            i = 1;
        }
    }/*</bind>*/
    bool filter(out int i) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,86538,89002);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B3]
    Statements (0)
    Next (Regular) Block[B2]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IInvocationOperation ( System.Boolean P.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var j)')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'filter')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var j')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var j')
                      ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 i]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                      Left: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B1]
                Leaving: {R2} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,89016,89069);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,89085,89179);

f_22076_89085_89178(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,86092,89190);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,86092,89190);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,86092,89190);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void WhileFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,89202,91490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,89348,89614);

string 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class P
{
    void M()
/*<bind>*/{
        while (filter(out var j))
        {
            int i;
        }
    }/*</bind>*/
    bool filter(out int i) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,89628,91302);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B2]
    Statements (0)
    Next (Regular) Block[B2]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IInvocationOperation ( System.Boolean P.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var j)')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'filter')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var j')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var j')
                      ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R1}

        Next (Regular) Block[B1]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,91316,91369);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,91385,91479);

f_22076_91385_91478(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,89202,91490);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,89202,91490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,89202,91490);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DoFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,91502,93308);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,91645,91907);

string 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class P
{
    void M(bool condition)
/*<bind>*/{
        do
        {
            int i;
            i = 1;
        }
        while (condition);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,91921,93120);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0] [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if True (Regular) to Block[B1]
        IParameterReferenceOperation: condition (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition')
        Entering: {R1}

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,93134,93187);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,93203,93297);

f_22076_93203_93296(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,91502,93308);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,91502,93308);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,91502,93308);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DoFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,93320,94336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,93463,93705);

string 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class P
{
    void M(bool condition)
/*<bind>*/{
        do
        {
            int i;
        }
        while (condition);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,93719,94148);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B1]
    Statements (0)
    Jump if True (Regular) to Block[B1]
        IParameterReferenceOperation: condition (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'condition')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,94162,94215);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,94231,94325);

f_22076_94231_94324(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,93320,94336);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,93320,94336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,93320,94336);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DoFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,94348,97454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,94491,94790);

string 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class P
{
    void M()
/*<bind>*/{
        do
        {
            int i;
            i = 1;
        }
        while (filter(out var j));
    }/*</bind>*/
    bool filter(out int i) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,94804,97266);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B3]
    Statements (0)
    Next (Regular) Block[B2]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32 j]
    .locals {R2}
    {
        Locals: [System.Int32 i]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                      Left: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B3]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Jump if True (Regular) to Block[B1]
            IInvocationOperation ( System.Boolean P.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var j)')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'filter')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var j')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var j')
                      ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R1}

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,97280,97333);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,97349,97443);

f_22076_97349_97442(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,94348,97454);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,94348,97454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,94348,97454);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DoFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22076,97466,99763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,97609,97888);

string 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class P
{
    void M()
/*<bind>*/{
        do
        {
            int i;
        }
        while (filter(out var j));
    }/*</bind>*/
    bool filter(out int i) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,97902,99575);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B2]
    Statements (0)
    Next (Regular) Block[B2]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B1]
            IInvocationOperation ( System.Boolean P.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var j)')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'filter')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var j')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var j')
                      ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,99589,99642);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22076,99658,99752);

f_22076_99658_99751(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22076,97466,99763);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22076,97466,99763);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22076,97466,99763);
}
		}

int
f_22076_3332_3408(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<DoStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 3332, 3408);
return 0;
}


int
f_22076_5915_5994(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 5915, 5994);
return 0;
}


int
f_22076_9337_9416(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 9337, 9416);
return 0;
}


int
f_22076_14474_14553(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 14474, 14553);
return 0;
}


int
f_22076_19398_19477(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 19398, 19477);
return 0;
}


int
f_22076_24354_24433(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 24354, 24433);
return 0;
}


int
f_22076_25700_25779(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 25700, 25779);
return 0;
}


int
f_22076_28530_28609(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 28530, 28609);
return 0;
}


int
f_22076_31636_31715(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 31636, 31715);
return 0;
}


int
f_22076_35033_35112(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 35033, 35112);
return 0;
}


int
f_22076_36287_36366(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 36287, 36366);
return 0;
}


int
f_22076_39788_39867(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 39788, 39867);
return 0;
}


int
f_22076_45510_45589(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 45510, 45589);
return 0;
}


int
f_22076_52124_52203(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 52124, 52203);
return 0;
}


int
f_22076_54715_54794(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 54715, 54794);
return 0;
}


int
f_22076_57127_57206(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 57127, 57206);
return 0;
}


int
f_22076_58752_58831(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 58752, 58831);
return 0;
}


int
f_22076_60293_60372(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 60293, 60372);
return 0;
}


int
f_22076_64491_64570(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 64491, 64570);
return 0;
}


int
f_22076_71925_72004(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<WhileStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 71925, 72004);
return 0;
}


int
f_22076_78402_78513(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<DoStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 78402, 78513);
return 0;
}


int
f_22076_80567_80661(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 80567, 80661);
return 0;
}


int
f_22076_80676_80770(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 80676, 80770);
return 0;
}


int
f_22076_82219_82312(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 82219, 82312);
return 0;
}


int
f_22076_83163_83256(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 83163, 83256);
return 0;
}


int
f_22076_84952_85045(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 84952, 85045);
return 0;
}


int
f_22076_85975_86068(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 85975, 86068);
return 0;
}


int
f_22076_89085_89178(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 89085, 89178);
return 0;
}


int
f_22076_91385_91478(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 91385, 91478);
return 0;
}


int
f_22076_93203_93296(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 93203, 93296);
return 0;
}


int
f_22076_94231_94324(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 94231, 94324);
return 0;
}


int
f_22076_97349_97442(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 97349, 97442);
return 0;
}


int
f_22076_99658_99751(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22076, 99658, 99751);
return 0;
}

}
}
