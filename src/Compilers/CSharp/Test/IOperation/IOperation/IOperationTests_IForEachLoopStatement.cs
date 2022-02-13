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
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_SimpleForEachLoop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,554,3121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,767,1036);

string 
source = @"
class Program
{
    static void Main()
    {
        string[] pets = { ""dog"", ""cat"", ""bird"" };

        /*<bind>*/foreach (string value in pets)
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,1050,3014);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (st ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'string')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'pets')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: pets (OperationKind.LocalReference, Type: System.String[]) (Syntax: 'pets')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,3028,3110);

f_22035_3028_3109(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,554,3121);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,554,3121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,554,3121);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithList()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,3133,5852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,3337,3732);

string 
source = @"
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add(""a"");
        list.Add(""b"");
        list.Add(""c"");
        /*<bind>*/foreach (string item in list)
        {
            Console.WriteLine(item);
        }/*</bind>*/

    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,3746,5745);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (st ... }')
  Locals: Local_1: System.String item
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String item) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'string')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.List<System.String>, IsImplicit) (Syntax: 'list')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: list (OperationKind.LocalReference, Type: System.Collections.Generic.List<System.String>) (Syntax: 'list')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(item);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(item)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'item')
                  ILocalReferenceOperation: item (OperationKind.LocalReference, Type: System.String) (Syntax: 'item')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,5759,5841);

f_22035_5759_5840(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,3133,5852);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,3133,5852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,3133,5852);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithKeyValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,5864,11519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,6072,6507);

string 
source = @"
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, int> _h = new Dictionary<int, int>();

    static void Main()
    {
        _h.Add(5, 4);
        _h.Add(4, 3);
        _h.Add(2, 1);

        /*<bind>*/foreach (KeyValuePair<int, int> pair in _h)
        {
            Console.WriteLine(""{0},{1}"", pair.Key, pair.Value);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,6521,11412);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (Ke ... }')
  Locals: Local_1: System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> pair
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> pair) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'KeyValuePair<int, int>')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>, IsImplicit) (Syntax: '_h')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IFieldReferenceOperation: System.Collections.Generic.Dictionary<System.Int32, System.Int32> Program._h (Static) (OperationKind.FieldReference, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>) (Syntax: '_h')
          Instance Receiver: 
            null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... air.Value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String format, System.Object arg0, System.Object arg1)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... pair.Value)')
            Instance Receiver: 
              null
            Arguments(3):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: format) (OperationKind.Argument, Type: null) (Syntax: '""{0},{1}""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""{0},{1}"") (Syntax: '""{0},{1}""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg0) (OperationKind.Argument, Type: null) (Syntax: 'pair.Key')
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'pair.Key')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      IPropertyReferenceOperation: System.Int32 System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>.Key { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'pair.Key')
                        Instance Receiver: 
                          ILocalReferenceOperation: pair (OperationKind.LocalReference, Type: System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>) (Syntax: 'pair')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg1) (OperationKind.Argument, Type: null) (Syntax: 'pair.Value')
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'pair.Value')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      IPropertyReferenceOperation: System.Int32 System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>.Value { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'pair.Value')
                        Instance Receiver: 
                          ILocalReferenceOperation: pair (OperationKind.LocalReference, Type: System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>) (Syntax: 'pair')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,11426,11508);

f_22035_11426_11507(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,5864,11519);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,5864,11519);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,5864,11519);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithBreak()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,11531,14904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,11736,12059);

string 
source = @"
class Program
{
    static void Main()
    {
        int[] numbers = { 1,2,3,4};

        /*<bind>*/foreach (int num in numbers)
        {
            if (num>3)
            {
                break;
            }
            System.Console.WriteLine(num);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,12073,14797);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (in ... }')
  Locals: Local_1: System.Int32 num
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int32 num) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'int')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'numbers')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: numbers (OperationKind.LocalReference, Type: System.Int32[]) (Syntax: 'numbers')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (num>3) ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'num>3')
            Left: 
              ILocalReferenceOperation: num (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'num')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IBranchOperation (BranchKind.Break, Label Id: 1) (OperationKind.Branch, Type: null) (Syntax: 'break;')
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... eLine(num);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... teLine(num)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'num')
                  ILocalReferenceOperation: num (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'num')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,14811,14893);

f_22035_14811_14892(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,11531,14904);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,11531,14904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,11531,14904);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithContinue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,14916,18301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,15124,15450);

string 
source = @"
class Program
{
    static void Main()
    {
        int[] numbers = { 1,2,3,4};

        /*<bind>*/foreach (int num in numbers)
        {
            if (num>3)
            {
                continue;
            }
            System.Console.WriteLine(num);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,15464,18194);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (in ... }')
  Locals: Local_1: System.Int32 num
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int32 num) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'int')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'numbers')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: numbers (OperationKind.LocalReference, Type: System.Int32[]) (Syntax: 'numbers')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (num>3) ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'num>3')
            Left: 
              ILocalReferenceOperation: num (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'num')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IBranchOperation (BranchKind.Continue, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'continue;')
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... eLine(num);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... teLine(num)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'num')
                  ILocalReferenceOperation: num (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'num')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,18208,18290);

f_22035_18208_18289(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,14916,18301);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,14916,18301);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,14916,18301);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_QueryExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,18313,20671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,18524,18915);

string 
source = @"
class Program
{
    static void Main()
    {
        string[] letters = { ""d"", ""c"", ""a"", ""b"" };
        var sorted = from letter in letters
                     orderby letter
                     select letter;
        /*<bind>*/foreach (string value in sorted)
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,18929,20564);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (st ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'string')
      Initializer: 
        null
  Collection: 
    ILocalReferenceOperation: sorted (OperationKind.LocalReference, Type: ?) (Syntax: 'sorted')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,20578,20660);

f_22035_20578_20659(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,18313,20671);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,18313,20671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,18313,20671);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_Struct()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,20683,27485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,20885,21626);

string 
source = @"
using System.Reflection;

namespace DisplayStructContentsTest
{
    class Program
    {

        struct Employee
        {
            public string name;
            public int age;
            public string location;
        };

        static void Main(string[] args)
        {
            Employee employee;

            employee.name = ""name1"";
            employee.age = 35;
            employee.location = ""loc"";

            /*<bind>*/foreach (FieldInfo fi in employee.GetType().GetFields())
            {
                System.Console.WriteLine(fi.Name + "" = "" +
                System.Convert.ToString(fi.GetValue(employee)));
            }/*</bind>*/

        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,21640,27378);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (Fi ... }')
  Locals: Local_1: System.Reflection.FieldInfo fi
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Reflection.FieldInfo fi) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'FieldInfo')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'employee.Ge ... GetFields()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Reflection.FieldInfo[] System.Type.GetFields()) (OperationKind.Invocation, Type: System.Reflection.FieldInfo[]) (Syntax: 'employee.Ge ... GetFields()')
          Instance Receiver: 
            IInvocationOperation ( System.Type System.Object.GetType()) (OperationKind.Invocation, Type: System.Type) (Syntax: 'employee.GetType()')
              Instance Receiver: 
                ILocalReferenceOperation: employee (OperationKind.LocalReference, Type: DisplayStructContentsTest.Program.Employee) (Syntax: 'employee')
              Arguments(0)
          Arguments(0)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... mployee)));')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... employee)))')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'fi.Name + "" ... (employee))')
                  IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String) (Syntax: 'fi.Name + "" ... (employee))')
                    Left: 
                      IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String) (Syntax: 'fi.Name + "" = ""')
                        Left: 
                          IPropertyReferenceOperation: System.String System.Reflection.MemberInfo.Name { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'fi.Name')
                            Instance Receiver: 
                              ILocalReferenceOperation: fi (OperationKind.LocalReference, Type: System.Reflection.FieldInfo) (Syntax: 'fi')
                        Right: 
                          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "" = "") (Syntax: '"" = ""')
                    Right: 
                      IInvocationOperation (System.String System.Convert.ToString(System.Object value)) (OperationKind.Invocation, Type: System.String) (Syntax: 'System.Conv ... (employee))')
                        Instance Receiver: 
                          null
                        Arguments(1):
                            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'fi.GetValue(employee)')
                              IInvocationOperation (virtual System.Object System.Reflection.FieldInfo.GetValue(System.Object obj)) (OperationKind.Invocation, Type: System.Object) (Syntax: 'fi.GetValue(employee)')
                                Instance Receiver: 
                                  ILocalReferenceOperation: fi (OperationKind.LocalReference, Type: System.Reflection.FieldInfo) (Syntax: 'fi')
                                Arguments(1):
                                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null) (Syntax: 'employee')
                                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'employee')
                                        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                        Operand: 
                                          ILocalReferenceOperation: employee (OperationKind.LocalReference, Type: DisplayStructContentsTest.Program.Employee) (Syntax: 'employee')
                                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,27392,27474);

f_22035_27392_27473(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,20683,27485);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,20683,27485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,20683,27485);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_String()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,27497,29971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,27699,27928);

string 
source = @"
class Class1
{
    public void M()
    {
        const string s = """";
        /*<bind>*/foreach (char c in s)
        {
            System.Console.WriteLine(c);
        }/*</bind>*/

    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,27942,29864);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (ch ... }')
  Locals: Local_1: System.Char c
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Char c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'char')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsImplicit) (Syntax: 's')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: s (OperationKind.LocalReference, Type: System.String, Constant: """") (Syntax: 's')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(c);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Char value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(c)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c')
                  ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.Char) (Syntax: 'c')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,29878,29960);

f_22035_29878_29959(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,27497,29971);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,27497,29971);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,27497,29971);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,29983,35585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,30186,30592);

string 
source = @"
using System.Collections.Generic;
class Program
{
    static Dictionary<int, int> _f = new Dictionary<int, int>();

    static void Main()
    {
        _f.Add(1, 2);
        _f.Add(2, 3);
        _f.Add(3, 4);

        /*<bind>*/foreach (var pair in _f)
        {
            System.Console.WriteLine(""{0},{1}"", pair.Key, pair.Value);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,30606,35478);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
  Locals: Local_1: System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> pair
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> pair) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>, IsImplicit) (Syntax: '_f')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IFieldReferenceOperation: System.Collections.Generic.Dictionary<System.Int32, System.Int32> Program._f (Static) (OperationKind.FieldReference, Type: System.Collections.Generic.Dictionary<System.Int32, System.Int32>) (Syntax: '_f')
          Instance Receiver: 
            null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... air.Value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String format, System.Object arg0, System.Object arg1)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... pair.Value)')
            Instance Receiver: 
              null
            Arguments(3):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: format) (OperationKind.Argument, Type: null) (Syntax: '""{0},{1}""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""{0},{1}"") (Syntax: '""{0},{1}""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg0) (OperationKind.Argument, Type: null) (Syntax: 'pair.Key')
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'pair.Key')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      IPropertyReferenceOperation: System.Int32 System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>.Key { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'pair.Key')
                        Instance Receiver: 
                          ILocalReferenceOperation: pair (OperationKind.LocalReference, Type: System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>) (Syntax: 'pair')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg1) (OperationKind.Argument, Type: null) (Syntax: 'pair.Value')
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'pair.Value')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      IPropertyReferenceOperation: System.Int32 System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>.Value { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'pair.Value')
                        Instance Receiver: 
                          ILocalReferenceOperation: pair (OperationKind.LocalReference, Type: System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>) (Syntax: 'pair')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,35492,35574);

f_22035_35492_35573(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,29983,35585);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,29983,35585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,29983,35585);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_BadElementType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,35597,38677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,35807,36066);

string 
source = @"
class C
{
    static void Main()
    {
        System.Collections.IEnumerable sequence = null;
        /*<bind>*/foreach (MissingType x in sequence)
        {
            bool b = !x.Equals(null);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,36080,38570);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (Mi ... }')
  Locals: Local_1: MissingType x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: MissingType x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'MissingType')
      Initializer: 
        null
  Collection: 
    ILocalReferenceOperation: sequence (OperationKind.LocalReference, Type: System.Collections.IEnumerable) (Syntax: 'sequence')
  Body: 
    IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Boolean b
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'bool b = !x ... uals(null);')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'bool b = !x.Equals(null)')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Boolean b) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'b = !x.Equals(null)')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= !x.Equals(null)')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsImplicit) (Syntax: '!x.Equals(null)')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: ?) (Syntax: '!x.Equals(null)')
                          Operand: 
                            IInvalidOperation (OperationKind.Invalid, Type: ?) (Syntax: 'x.Equals(null)')
                              Children(2):
                                  IOperation:  (OperationKind.None, Type: null) (Syntax: 'x.Equals')
                                    Children(1):
                                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: MissingType) (Syntax: 'x')
                                  ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
          Initializer: 
            null
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,38584,38666);

f_22035_38584_38665(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,35597,38677);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,35597,38677);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,35597,38677);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_NullLiteralCollection()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,38689,39827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,38906,39057);

string 
source = @"
class C
{
    static void Main()
    {
        /*<bind>*/foreach (int x in null)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,39071,39720);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (in ... }')
  Locals: Local_1: System.Int32 x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'int')
      Initializer: 
        null
  Collection: 
    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,39734,39816);

f_22035_39734_39815(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,38689,39827);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,38689,39827);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,38689,39827);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_NoElementCollection()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,39839,41319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,40054,40218);

string 
source = @"
class C
{
    static void Main(string[] args)
    {
        /*<bind>*/foreach (int x in args)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,40232,41212);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (in ... }')
  Locals: Local_1: System.Int32 x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'int')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'args')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,41226,41308);

f_22035_41226_41307(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,39839,41319);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,39839,41319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,39839,41319);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_ModifyIterationVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,41331,43335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,41550,41682);

string 
source = @"
class C
{
    void F(int[] a)
    {
        /*<bind>*/foreach (int x in a) { x++; }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,41696,43228);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (in ... a) { x++; }')
  Locals: Local_1: System.Int32 x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'int')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'a')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ x++; }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x++;')
        Expression: 
          IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: ?, IsInvalid) (Syntax: 'x++')
            Target: 
              IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'x')
                Children(1):
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,43242,43324);

f_22035_43242_43323(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,41331,43335);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,41331,43335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,41331,43335);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_Pattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,43347,44960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,43550,43897);

string 
source = @"
class C
{
    void F(Enumerable e)
    {
        /*<bind>*/foreach (long x in e) { }/*</bind>*/
    }
}

class Enumerable
{
    public Enumerator GetEnumerator() { return new Enumerator(); }
}

class Enumerator
{
    public int Current { get { return 1; } }
    public bool MoveNext() { return false; }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,43911,44853);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (lo ... x in e) { }')
  Locals: Local_1: System.Int64 x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int64 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'long')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Enumerable, IsImplicit) (Syntax: 'e')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: Enumerable) (Syntax: 'e')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,44867,44949);

f_22035_44867_44948(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,43347,44960);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,43347,44960);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,43347,44960);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_ImplicitlyTypedString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,44972,46380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,45189,45317);

string 
source = @"
class C
{
    void F(string s)
    {
        /*<bind>*/foreach (var x in s) { }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,45331,46273);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (var x in s) { }')
  Locals: Local_1: System.Char x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Char x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsImplicit) (Syntax: 's')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: s (OperationKind.ParameterReference, Type: System.String) (Syntax: 's')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,46287,46369);

f_22035_46287_46368(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,44972,46380);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,44972,46380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,44972,46380);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_ExplicitlyTypedVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,46392,47816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,46606,46754);

string 
source = @"
class C
{
    void F(var[] a)
    {
        /*<bind>*/foreach (var x in a) { }/*</bind>*/
    }

    class var { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,46768,47709);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (var x in a) { }')
  Locals: Local_1: C.var x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: C.var x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'a')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C.var[]) (Syntax: 'a')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,47723,47805);

f_22035_47723_47804(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,46392,47816);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,46392,47816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,46392,47816);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_DynamicEnumerable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,47828,49247);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,48041,48170);

string 
source = @"
class C
{
    void F(dynamic d)
    {
        /*<bind>*/foreach (int x in d) { }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,48184,49140);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (int x in d) { }')
  Locals: Local_1: System.Int32 x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'int')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'd')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,49154,49236);

f_22035_49154_49235(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,47828,49247);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,47828,49247);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,47828,49247);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_TypeParameterConstrainedToInterface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,49259,52008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,49490,49834);

string 
source = @"
class C
{
    static void Test<T>() where T : System.Collections.IEnumerator
    {
        /*<bind>*/foreach (object x in new Enumerable<T>())
        {
            System.Console.WriteLine(x);
        }/*</bind>*/
    }
}

public class Enumerable<T>
{
    public T GetEnumerator() { return default(T); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,49848,51901);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (ob ... }')
  Locals: Local_1: System.Object x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Object x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'object')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Enumerable<T>, IsImplicit) (Syntax: 'new Enumerable<T>()')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IObjectCreationOperation (Constructor: Enumerable<T>..ctor()) (OperationKind.ObjectCreation, Type: Enumerable<T>) (Syntax: 'new Enumerable<T>()')
          Arguments(0)
          Initializer: 
            null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... iteLine(x);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Object value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... riteLine(x)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'x')
                  ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Object) (Syntax: 'x')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,51915,51997);

f_22035_51915_51996(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,49259,52008);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,49259,52008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,49259,52008);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_CastArrayToIEnumerable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,52020,53877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,52238,52429);

string 
source = @"
using System.Collections;

class C
{
    static void Main(string[] args)
    {
        /*<bind>*/foreach (string x in (IEnumerable)args) { }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,52443,53768);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (st ... e)args) { }')
  Locals: Local_1: System.String x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'string')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: '(IEnumerable)args')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable) (Syntax: '(IEnumerable)args')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,53784,53866);

f_22035_53784_53865(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,52020,53877);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,52020,53877);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,52020,53877);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_CastCollectionToIEnumerable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,53889,55942);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,54112,54323);

string 
source = @"
using System.Collections.Generic;

class C
{
    static void Main(List<string> args)
    {
        /*<bind>*/foreach (string x in (IEnumerable<string>)args) { }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,54411,55833);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (st ... >)args) { }')
  Locals: Local_1: System.String x
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'string')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.String>, IsImplicit) (Syntax: '(IEnumerabl ... tring>)args')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.String>) (Syntax: '(IEnumerabl ... tring>)args')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.Collections.Generic.List<System.String>) (Syntax: 'args')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,55849,55931);

f_22035_55849_55930(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,53889,55942);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,53889,55942);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,53889,55942);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithThrow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,55954,60267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,56159,56522);

string 
source = @"
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4 };

        /*<bind>*/foreach (int num in numbers)
        {
            if (num > 3)
            {
                throw new System.Exception(""testing"");
            }
            System.Console.WriteLine(num);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,56536,60160);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (in ... }')
  Locals: Local_1: System.Int32 num
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int32 num) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'int')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'numbers')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: numbers (OperationKind.LocalReference, Type: System.Int32[]) (Syntax: 'numbers')
  Body: 
    IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (num > 3 ... }')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'num > 3')
            Left: 
              ILocalReferenceOperation: num (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'num')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
        WhenTrue: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw new S ... ""testing"");')
              IObjectCreationOperation (Constructor: System.Exception..ctor(System.String message)) (OperationKind.ObjectCreation, Type: System.Exception) (Syntax: 'new System. ... (""testing"")')
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: message) (OperationKind.Argument, Type: null) (Syntax: '""testing""')
                      ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""testing"") (Syntax: '""testing""')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Initializer: 
                  null
        WhenFalse: 
          null
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... eLine(num);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... teLine(num)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'num')
                  ILocalReferenceOperation: num (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'num')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,60174,60256);

f_22035_60174_60255(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,55954,60267);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,55954,60267);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,55954,60267);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithDeconstructDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,60279,62327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,60501,60672);

string 
source = @"
class X
{
    public static void M((int, int)[] x)
    {
        /*<bind>*/foreach (var (a, b) in x)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,60686,62108);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
  Locals: Local_1: System.Int32 a
    Local_2: System.Int32 b
  LoopControlVariable: 
    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 a, System.Int32 b)) (Syntax: 'var (a, b)')
      ITupleOperation (OperationKind.Tuple, Type: (System.Int32 a, System.Int32 b)) (Syntax: '(a, b)')
        NaturalType: (System.Int32 a, System.Int32 b)
        Elements(2):
            ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
            ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)[]) (Syntax: 'x')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,62122,62175);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,62191,62316);

f_22035_62191_62315(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,60279,62327);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,60279,62327);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,60279,62327);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithNestedDeconstructDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,62339,64853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,62567,62750);

string 
source = @"
class X
{
    public static void M((int, (int, int))[] x)
    {
        /*<bind>*/foreach (var (a, (b, c)) in x)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,62764,64634);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
  Locals: Local_1: System.Int32 a
    Local_2: System.Int32 b
    Local_3: System.Int32 c
  LoopControlVariable: 
    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 a, (System.Int32 b, System.Int32 c))) (Syntax: 'var (a, (b, c))')
      ITupleOperation (OperationKind.Tuple, Type: (System.Int32 a, (System.Int32 b, System.Int32 c))) (Syntax: '(a, (b, c))')
        NaturalType: (System.Int32 a, (System.Int32 b, System.Int32 c))
        Elements(2):
            ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
            ITupleOperation (OperationKind.Tuple, Type: (System.Int32 b, System.Int32 c)) (Syntax: '(b, c)')
              NaturalType: (System.Int32 b, System.Int32 c)
              Elements(2):
                  ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
                  ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'c')
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32, (System.Int32, System.Int32))[]) (Syntax: 'x')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,64648,64701);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,64717,64842);

f_22035_64717_64841(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,62339,64853);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,62339,64853);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,62339,64853);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithInvalidLoopControlVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,64865,69135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,65091,65256);

string 
source = @"
class X
{
    public static void M((int, int)[] x)
    /*<bind>*/{
        foreach (i, j in x)
        {
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,65270,66667);

string 
expectedOperationTree = @"
IBlockOperation (4 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (i')
    LoopControlVariable: 
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'i')
        Children(0)
    Collection: 
      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
        Children(0)
    Body: 
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
            Children(0)
    NextVariables(0)
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'j ')
    Expression: 
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'j')
        Children(0)
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x')
    Expression: 
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: (System.Int32, System.Int32)[], IsInvalid) (Syntax: 'x')
  IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,66681,69002);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22035_66844_66905(f_22035_66844_66885(ErrorCode.ERR_InExpected, ","), 6, 19),
f_22035_67061_67126(f_22035_67061_67106(ErrorCode.ERR_BadForeachDecl, ","), 6, 19),
f_22035_67249_67334(f_22035_67249_67314(f_22035_67249_67295(ErrorCode.ERR_InvalidExprTerm, ","), ","), 6, 19),
f_22035_67440_67509(f_22035_67440_67489(ErrorCode.ERR_CloseParenExpected, ","), 6, 19),
f_22035_67632_67717(f_22035_67632_67697(f_22035_67632_67678(ErrorCode.ERR_InvalidExprTerm, ","), ","), 6, 19),
f_22035_67823_67891(f_22035_67823_67871(ErrorCode.ERR_SemicolonExpected, ","), 6, 19),
f_22035_67997_68062(f_22035_67997_68042(ErrorCode.ERR_RbraceExpected, ","), 6, 19),
f_22035_68168_68237(f_22035_68168_68217(ErrorCode.ERR_SemicolonExpected, "in"), 6, 23),
f_22035_68343_68409(f_22035_68343_68389(ErrorCode.ERR_RbraceExpected, "in"), 6, 23),
f_22035_68515_68583(f_22035_68515_68563(ErrorCode.ERR_SemicolonExpected, ")"), 6, 27),
f_22035_68689_68754(f_22035_68689_68734(ErrorCode.ERR_RbraceExpected, ")"), 6, 27),
f_22035_68900_68986(f_22035_68900_68966(f_22035_68900_68947(ErrorCode.ERR_NameNotInContext, "j"), "j"), 6, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,69018,69124);

f_22035_69018_69123(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,64865,69135);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,64865,69135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,64865,69135);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_WithInvalidLoopControlVariable_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,69147,70801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,69376,69534);

string 
source = @"
class X
{
    public static void M(int[] x)
    /*<bind>*/{
        foreach (x[0] in x)
        {
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,69548,70499);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (x[ ... }')
    LoopControlVariable: 
      IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'x[0]')
        Array reference: 
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'x')
        Indices(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
    Collection: 
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'x')
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,70513,70668);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22035_70586_70652(f_22035_70586_70632(ErrorCode.ERR_BadForeachDecl, "in"), 6, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,70684,70790);

f_22035_70684_70789(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,69147,70801);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,69147,70801);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,69147,70801);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_InvalidLoopControlVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,70813,73061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,71046,71225);

string 
source = @"
class X
{
    public static void M(int[] x)
    {
        int i = 0;
        /*<bind>*/foreach (int i in x)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,71239,72209);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (in ... }')
  Locals: Local_1: System.Int32 i
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'int')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'x')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,72223,72917);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22035_72553_72646(f_22035_72553_72626(f_22035_72553_72607(ErrorCode.ERR_LocalIllegallyOverrides, "i"), "i"), 7, 32),
f_22035_72812_72901(f_22035_72812_72881(f_22035_72812_72862(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 6, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,72933,73050);

f_22035_72933_73049(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,70813,73061);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,70813,73061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,70813,73061);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19996, "https://github.com/dotnet/roslyn/issues/19996")]
        public void IForEachLoopStatement_InvalidLoopControlVariableExpression_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,73073,75871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,73308,73496);

string 
source = @"
class C
{
    void M(int a, int b)
    {
        int[] arr = new int[10];
        /*<bind>*/foreach (M(1, 2) in arr)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,73510,75392);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (M( ... }')
  LoopControlVariable: 
    IInvocationOperation ( void C.M(System.Int32 a, System.Int32 b)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M(1, 2)')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'M')
      Arguments(2):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: a) (OperationKind.Argument, Type: null) (Syntax: '1')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: b) (OperationKind.Argument, Type: null) (Syntax: '2')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Collection: 
    ILocalReferenceOperation: arr (OperationKind.LocalReference, Type: System.Int32[]) (Syntax: 'arr')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,75406,75719);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22035_75637_75703(f_22035_75637_75683(ErrorCode.ERR_BadForeachDecl, "in"), 7, 36)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,75735,75860);

f_22035_75735_75859(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,73073,75871);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,73073,75871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,73073,75871);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_InvalidLoopControlVariableExpression_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,75883,78405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,76118,76368);

string 
source = @"
class C
{
    void M(int a, int b)
    {
        int[] arr = new int[10];
        /*<bind>*/foreach (M2(out var x) in arr)
        {
        }/*</bind>*/
    }

    void M2(out int x)
    {
        x = 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,76382,77905);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (M2 ... }')
  Locals: Local_1: System.Int32 x
  LoopControlVariable: 
    IInvocationOperation ( void C.M2(out System.Int32 x)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(out var x)')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'M2')
      Arguments(1):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var x')
            IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var x')
              ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Collection: 
    ILocalReferenceOperation: arr (OperationKind.LocalReference, Type: System.Int32[]) (Syntax: 'arr')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,77919,78253);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22035_78171_78237(f_22035_78171_78217(ErrorCode.ERR_BadForeachDecl, "in"), 7, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,78269,78394);

f_22035_78269_78393(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,75883,78405);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,75883,78405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,75883,78405);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_InvalidLoopControlVariableExpression_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,78419,80294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,78654,78841);

string 
source = @"
class C
{
    void M(object o)
    {
        int[] arr = new int[10];
        /*<bind>*/foreach (o is int x in arr)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,78855,79797);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (o  ... }')
  Locals: Local_1: System.Int32 x
  LoopControlVariable: 
    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'o is int x')
      Value: 
        IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
      Pattern: 
        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
  Collection: 
    ILocalReferenceOperation: arr (OperationKind.LocalReference, Type: System.Int32[]) (Syntax: 'arr')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,79811,80142);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22035_80060_80126(f_22035_80060_80106(ErrorCode.ERR_BadForeachDecl, "in"), 7, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,80158,80283);

f_22035_80158_80282(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,78419,80294);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,78419,80294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,78419,80294);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_ViaExtensionMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,80306,83077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,80520,80885);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        /*<bind>*/foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}

static class Extensions
{
    public static IEnumerator<string> GetEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,80899,82934);

var 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'new Program()')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
          Arguments(0)
          Initializer: 
            null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,82948,83066);

f_22035_82948_83065(source, expectedOperationTree, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,80306,83077);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,80306,83077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,80306,83077);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_ViaExtensionMethodWithConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,83089,85879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,83317,83681);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        /*<bind>*/foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}

static class Extensions
{
    public static IEnumerator<string> GetEnumerator(this object p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,83695,85736);

var 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new Program()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
          Arguments(0)
          Initializer: 
            null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,85750,85868);

f_22035_85750_85867(source, expectedOperationTree, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,83089,85879);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,83089,85879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,83089,85879);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_ViaExtensionMethod_WithGetEnumeratorReturningWrongType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,85891,87862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,86141,86491);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        /*<bind>*/foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}

static class Extensions
{
    public static bool GetEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,86505,87719);

var 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (va ... }')
  Locals: Local_1: var value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: var value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program, IsInvalid) (Syntax: 'new Program()')
      Arguments(0)
      Initializer: 
        null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Children(2):
                IOperation:  (OperationKind.None, Type: null) (Syntax: 'System.Console')
                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: var) (Syntax: 'value')
  NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,87733,87851);

f_22035_87733_87850(source, expectedOperationTree, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,85891,87862);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,85891,87862);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,85891,87862);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IForEachLoopStatement_ViaExtensionMethod_WithSpillInExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,87874,91139);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,88110,88483);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        /*<bind>*/foreach (var value in null ?? new Program())
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}

static class Extensions
{
    public static IEnumerator<string> GetEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,88497,90996);

var 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'null ?? new Program()')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ICoalesceOperation (OperationKind.Coalesce, Type: Program) (Syntax: 'null ?? new Program()')
          Expression: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
          ValueConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            (ImplicitReference)
          WhenNull: 
            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
              Arguments(0)
              Initializer: 
                null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,91010,91128);

f_22035_91010_91127(source, expectedOperationTree, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,87874,91139);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,87874,91139);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,87874,91139);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IAwaitForEachLoopStatement_ViaExtensionMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,91151,94102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,91370,91757);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static async void Main()
    {
        /*<bind>*/await foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}

static class Extensions
{
    public static IAsyncEnumerator<string> GetAsyncEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,91771,93822);

var 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'new Program()')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
          Arguments(0)
          Initializer: 
            null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,93836,93958);

var 
comp = f_22035_93847_93957(new[] { source, s_IAsyncEnumerable }, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,93972,93997);

f_22035_93972_93996(            comp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,94011,94091);

f_22035_94011_94090(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,91151,94102);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,91151,94102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,91151,94102);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IAwaitForEachLoopStatement_ViaExtensionMethodWithConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,94114,97084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,94347,94733);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static async void Main()
    {
        /*<bind>*/await foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}

static class Extensions
{
    public static IAsyncEnumerator<string> GetAsyncEnumerator(this object p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,94747,96804);

var 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new Program()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
          Arguments(0)
          Initializer: 
            null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,96818,96940);

var 
comp = f_22035_96829_96939(new[] { source, s_IAsyncEnumerable }, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,96954,96979);

f_22035_96954_96978(            comp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,96993,97073);

f_22035_96993_97072(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,94114,97084);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,94114,97084);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,94114,97084);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IAwaitForEachLoopStatement_ViaExtensionMethod_WithGetAsyncEnumeratorReturningWrongType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,97096,99985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,97356,97688);

var 
source = @"
class Program
{
    static async void Main()
    {
        /*<bind>*/await foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}

static class Extensions
{
    public static bool GetAsyncEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,97702,98932);

var 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'await forea ... }')
  Locals: Local_1: var value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: var value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program, IsInvalid) (Syntax: 'new Program()')
      Arguments(0)
      Initializer: 
        null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Children(2):
                IOperation:  (OperationKind.None, Type: null) (Syntax: 'System.Console')
                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: var) (Syntax: 'value')
  NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,98946,99068);

var 
comp = f_22035_98957_99067(new[] { source, s_IAsyncEnumerable }, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,99082,99880);

f_22035_99082_99879(            comp, f_22035_99297_99405(f_22035_99297_99385(f_22035_99297_99352(ErrorCode.ERR_NoSuchMember, "new Program()"), "bool", "Current"), 6, 47), f_22035_99730_99878(f_22035_99730_99858(f_22035_99730_99794(ErrorCode.ERR_BadGetAsyncEnumerator, "new Program()"), "bool", "Extensions.GetAsyncEnumerator(Program)"), 6, 47));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,99894,99974);

f_22035_99894_99973(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,97096,99985);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,97096,99985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,97096,99985);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void IAwaitForEachLoopStatement_ViaExtensionMethod_WithSpillInExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,99997,103442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,100238,100633);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static async void Main()
    {
        /*<bind>*/await foreach (var value in null ?? new Program())
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}

static class Extensions
{
    public static IAsyncEnumerator<string> GetAsyncEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,100647,103162);

var 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'null ?? new Program()')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ICoalesceOperation (OperationKind.Coalesce, Type: Program) (Syntax: 'null ?? new Program()')
          Expression: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
          ValueConversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            (ImplicitReference)
          WhenNull: 
            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
              Arguments(0)
              Initializer: 
                null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,103176,103298);

var 
comp = f_22035_103187_103297(new[] { source, s_IAsyncEnumerable }, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,103312,103337);

f_22035_103312_103336(            comp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,103351,103431);

f_22035_103351_103430(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,99997,103442);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,99997,103442);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,99997,103442);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,103454,112979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,103602,103812);

string 
source = @"
public class MyClass
{
    void M(MyClass[] a, MyClass[] b)
    /*<bind>*/{
        foreach (var x in a ?? b) 
        { 
            x?.ToString();
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,103826,103879);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,103895,112856);

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
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: MyClass[]) (Syntax: 'a')

                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass[], IsImplicit) (Syntax: 'a')
                    Leaving: {R3}

                Next (Regular) Block[B2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass[], IsImplicit) (Syntax: 'a')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                  Value: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: MyClass[]) (Syntax: 'b')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a ?? b')
                  Value: 
                    IInvocationOperation (virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()) (OperationKind.Invocation, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a ?? b')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'a ?? b')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyClass[], IsImplicit) (Syntax: 'a ?? b')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R4} {R5}
    }
    .try {R4, R5}
    {
        Block[B5] - Block
            Predecessors: [B4] [B7] [B8]
            Statements (0)
            Jump if False (Regular) to Block[B12]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a ?? b')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a ?? b')
                  Arguments(0)
                Finalizing: {R8}
                Leaving: {R5} {R4} {R1}

            Next (Regular) Block[B6]
                Entering: {R6}

        .locals {R6}
        {
            Locals: [MyClass x]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: MyClass, IsImplicit) (Syntax: 'var')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: MyClass, IsImplicit) (Syntax: 'var')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ExplicitReference)
                          Operand: 
                            IPropertyReferenceOperation: System.Object System.Collections.IEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Object, IsImplicit) (Syntax: 'var')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a ?? b')

                Next (Regular) Block[B7]
                    Entering: {R7}

            .locals {R7}
            {
                CaptureIds: [3]
                Block[B7] - Block
                    Predecessors: [B6]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                          Value: 
                            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: MyClass) (Syntax: 'x')

                    Jump if True (Regular) to Block[B5]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x')
                          Operand: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'x')
                        Leaving: {R7} {R6}

                    Next (Regular) Block[B8]
                Block[B8] - Block
                    Predecessors: [B7]
                    Statements (1)
                        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x?.ToString();')
                          Expression: 
                            IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '.ToString()')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'x')
                              Arguments(0)

                    Next (Regular) Block[B5]
                        Leaving: {R7} {R6}
            }
        }
    }
    .finally {R8}
    {
        CaptureIds: [4]
        Block[B9] - Block
            Predecessors (0)
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a ?? b')
                  Value: 
                    IConversionOperation (TryCast: True, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a ?? b')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a ?? b')

            Jump if True (Regular) to Block[B11]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a ?? b')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'a ?? b')

            Next (Regular) Block[B10]
        Block[B10] - Block
            Predecessors: [B9]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a ?? b')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'a ?? b')
                  Arguments(0)

            Next (Regular) Block[B11]
        Block[B11] - Block
            Predecessors: [B9] [B10]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B12] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,112870,112968);

f_22035_112870_112967(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,103454,112979);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,103454,112979);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,103454,112979);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,112991,119098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,113139,113344);

string 
source = @"
public class MyClass
{
    void M(string a, bool result)
    /*<bind>*/{
        foreach (ushort x in a) 
        { 
            result = true;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,113358,113411);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,113427,118975);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IInvocationOperation ( System.CharEnumerator System.String.GetEnumerator()) (OperationKind.Invocation, Type: System.CharEnumerator, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.String) (Syntax: 'a')
                  Arguments(0)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation ( System.Boolean System.CharEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.CharEnumerator, IsImplicit) (Syntax: 'a')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
                Entering: {R4}

        .locals {R4}
        {
            Locals: [System.UInt16 x]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'ushort')
                      Left: 
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.UInt16, IsImplicit) (Syntax: 'ushort')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.UInt16, IsImplicit) (Syntax: 'ushort')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNumeric)
                          Operand: 
                            IPropertyReferenceOperation: System.Char System.CharEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Char, IsImplicit) (Syntax: 'ushort')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.CharEnumerator, IsImplicit) (Syntax: 'a')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.CharEnumerator, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.CharEnumerator, IsImplicit) (Syntax: 'a')
                  Arguments(0)

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,118989,119087);

f_22035_118989_119086(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,112991,119098);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,112991,119098);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,112991,119098);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,119110,126041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,119258,119458);

string 
source = @"
public class MyClass
{
    void M(int[,] a, long result)
    /*<bind>*/{
        foreach (long x in a) 
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,119472,119525);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,119541,125918);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IInvocationOperation (virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()) (OperationKind.Invocation, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a')
                  Arguments(0)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
                Entering: {R4}

        .locals {R4}
        {
            Locals: [System.Int64 x]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'long')
                      Left: 
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int64, IsImplicit) (Syntax: 'long')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'long')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNumeric)
                          Operand: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'long')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Unboxing)
                              Operand: 
                                IPropertyReferenceOperation: System.Object System.Collections.IEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Object, IsImplicit) (Syntax: 'long')
                                  Instance Receiver: 
                                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int64) (Syntax: 'result = x')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'result')
                          Right: 
                            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int64) (Syntax: 'x')

                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        CaptureIds: [1]
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IConversionOperation (TryCast: True, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')

            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'a')
                  Arguments(0)

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,125932,126030);

f_22035_125932_126029(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,119110,126041);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,119110,126041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,119110,126041);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,126053,130474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,126201,126618);

string 
source = @"
public class MyClass
{
    void M(Enumerable e, long result)
    /*<bind>*/{
        foreach (long x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}

struct Enumerable
{
    public Enumerator GetEnumerator() { return new Enumerator(); }
}

struct Enumerator
{
    public int Current { get { return 1; } }
    public bool MoveNext() { return false; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,126632,126685);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,126701,130351);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation ( Enumerator Enumerable.GetEnumerator()) (OperationKind.Invocation, Type: Enumerator, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Enumerable, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: Enumerable) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IInvocationOperation ( System.Boolean Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Enumerator, IsImplicit) (Syntax: 'e')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int64 x]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'long')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int64, IsImplicit) (Syntax: 'long')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'long')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNumeric)
                      Operand: 
                        IPropertyReferenceOperation: System.Int32 Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'long')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Enumerator, IsImplicit) (Syntax: 'e')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int64) (Syntax: 'result = x')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'result')
                      Right: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int64) (Syntax: 'x')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,130365,130463);

f_22035_130365_130462(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,126053,130474);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,126053,130474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,126053,130474);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,130486,136150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,130634,131102);

string 
source = @"
public class MyClass
{
    void M(Enumerable e, long result)
    /*<bind>*/{
        foreach (long x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}

struct Enumerable
{
    public Enumerator GetEnumerator() { return new Enumerator(); }
}

struct Enumerator : System.IDisposable
{
    public int Current { get { return 1; } }
    public bool MoveNext() { return false; }
    public void Dispose() {}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,131116,131169);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,131185,136027);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation ( Enumerator Enumerable.GetEnumerator()) (OperationKind.Invocation, Type: Enumerator, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Enumerable, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: Enumerable) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IInvocationOperation ( System.Boolean Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Enumerator, IsImplicit) (Syntax: 'e')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
                Entering: {R4}

        .locals {R4}
        {
            Locals: [System.Int64 x]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'long')
                      Left: 
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int64, IsImplicit) (Syntax: 'long')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'long')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNumeric)
                          Operand: 
                            IPropertyReferenceOperation: System.Int32 Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'long')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Enumerator, IsImplicit) (Syntax: 'e')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int64) (Syntax: 'result = x')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'result')
                          Right: 
                            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int64) (Syntax: 'x')

                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: Enumerator, IsImplicit) (Syntax: 'e')
                  Arguments(0)

            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B5] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,136041,136139);

f_22035_136041_136138(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,130486,136150);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,130486,136150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,130486,136150);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,136162,142213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,136310,136544);

string 
source = @"
public class MyClass
{
    void M(System.Collections.Generic.IEnumerable<int> e, int result)
    /*<bind>*/{
        foreach (var x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,136558,136611);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,136627,142090);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation (virtual System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerator<System.Int32>, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Collections.Generic.IEnumerable<System.Int32>) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.Int32>, IsImplicit) (Syntax: 'e')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
                Entering: {R4}

        .locals {R4}
        {
            Locals: [System.Int32 x]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Int32 System.Collections.Generic.IEnumerator<System.Int32>.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.Int32>, IsImplicit) (Syntax: 'e')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                          Right: 
                            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')

                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.Int32>, IsImplicit) (Syntax: 'e')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.Int32>, IsImplicit) (Syntax: 'e')
                  Arguments(0)

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,142104,142202);

f_22035_142104_142201(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,136162,142213);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,136162,142213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,136162,142213);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,142225,146300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,142373,142583);

string 
source = @"
public class MyClass
{
    void M(in System.Span<int> e, int result)
    /*<bind>*/{
        foreach (var x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,142597,142650);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,142666,146118);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation ( System.Span<System.Int32>.Enumerator System.Span<System.Int32>.GetEnumerator()) (OperationKind.Invocation, Type: System.Span<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Span<System.Int32>, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Span<System.Int32>) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IInvocationOperation ( System.Boolean System.Span<System.Int32>.Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Span<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 x]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                  Right: 
                    IPropertyReferenceOperation: ref System.Int32 System.Span<System.Int32>.Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Span<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                      Right: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,146132,146289);

f_22035_146132_146288(source + SpanSource, expectedFlowGraph, expectedDiagnostics, f_22035_146243_146287(TestOptions.ReleaseDll, true));
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,142225,146300);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,142225,146300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,142225,146300);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,146312,150399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,146460,146674);

string 
source = @"
public class MyClass
{
    void M(in System.Span<int> e, int result)
    /*<bind>*/{
        foreach (ref var x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,146688,146741);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,146757,150217);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation ( System.Span<System.Int32>.Enumerator System.Span<System.Int32>.GetEnumerator()) (OperationKind.Invocation, Type: System.Span<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Span<System.Int32>, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Span<System.Int32>) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IInvocationOperation ( System.Boolean System.Span<System.Int32>.Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Span<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 x]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                  Right: 
                    IPropertyReferenceOperation: ref System.Int32 System.Span<System.Int32>.Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Span<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                      Right: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,150231,150388);

f_22035_150231_150387(source + SpanSource, expectedFlowGraph, expectedDiagnostics, f_22035_150342_150386(TestOptions.ReleaseDll, true));
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,146312,150399);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,146312,150399);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,146312,150399);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,150411,154626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,150559,150777);

string 
source = @"
public class MyClass
{
    void M(in System.ReadOnlySpan<int> e, int result)
    /*<bind>*/{
        foreach (var x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,150791,150844);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,150860,154444);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation ( System.ReadOnlySpan<System.Int32>.Enumerator System.ReadOnlySpan<System.Int32>.GetEnumerator()) (OperationKind.Invocation, Type: System.ReadOnlySpan<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.ReadOnlySpan<System.Int32>, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.ReadOnlySpan<System.Int32>) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IInvocationOperation ( System.Boolean System.ReadOnlySpan<System.Int32>.Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.ReadOnlySpan<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 x]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                  Right: 
                    IPropertyReferenceOperation: ref readonly modreq(System.Runtime.InteropServices.InAttribute) System.Int32 System.ReadOnlySpan<System.Int32>.Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.ReadOnlySpan<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                      Right: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,154458,154615);

f_22035_154458_154614(source + SpanSource, expectedFlowGraph, expectedDiagnostics, f_22035_154569_154613(TestOptions.ReleaseDll, true));
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,150411,154626);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,150411,154626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,150411,154626);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,154638,158874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,154786,155017);

string 
source = @"
public class MyClass
{
    void M(in System.ReadOnlySpan<int> e, int result)
    /*<bind>*/{
        foreach (ref readonly var x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,155031,155084);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,155100,158692);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation ( System.ReadOnlySpan<System.Int32>.Enumerator System.ReadOnlySpan<System.Int32>.GetEnumerator()) (OperationKind.Invocation, Type: System.ReadOnlySpan<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.ReadOnlySpan<System.Int32>, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.ReadOnlySpan<System.Int32>) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IInvocationOperation ( System.Boolean System.ReadOnlySpan<System.Int32>.Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.ReadOnlySpan<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 x]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                  Right: 
                    IPropertyReferenceOperation: ref readonly modreq(System.Runtime.InteropServices.InAttribute) System.Int32 System.ReadOnlySpan<System.Int32>.Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.ReadOnlySpan<System.Int32>.Enumerator, IsImplicit) (Syntax: 'e')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                      Right: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,158706,158863);

f_22035_158706_158862(source + SpanSource, expectedFlowGraph, expectedDiagnostics, f_22035_158817_158861(TestOptions.ReleaseDll, true));
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,154638,158874);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,154638,158874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,154638,158874);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,158886,165368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,159034,159232);

string 
source = @"
public class MyClass
{
    void M(dynamic e, int result)
    /*<bind>*/{
        foreach (var x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,159246,159299);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,159315,165245);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation (virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()) (OperationKind.Invocation, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitDynamic)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'e')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
                Entering: {R4}

        .locals {R4}
        {
            Locals: [dynamic x]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: dynamic, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Object System.Collections.IEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Object, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'e')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                          Right: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'x')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (ImplicitDynamic)
                              Operand: 
                                ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic) (Syntax: 'x')

                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        CaptureIds: [1]
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
                  Value: 
                    IConversionOperation (TryCast: True, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'e')

            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'e')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'e')
                  Arguments(0)

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,165259,165357);

f_22035_165259_165356(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,158886,165368);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,158886,165368);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,158886,165368);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,165380,168970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,165528,165726);

string 
source = @"
public class MyClass
{
    void M(MyClass e, int result)
    /*<bind>*/{
        foreach (var x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,165740,166179);

var 
expectedDiagnostics = new[] {
f_22035_166050_166163(f_22035_166050_166143(f_22035_166050_166101(ErrorCode.ERR_ForEachMissingMember, "e"), "MyClass", "GetEnumerator"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,166195,168847);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'e')
          Children(1):
              IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: MyClass, IsInvalid) (Syntax: 'e')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'e')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'e')
                Children(0)

    Next (Regular) Block[B3]
        Entering: {R1}

.locals {R1}
{
    Locals: [var x]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsImplicit) (Syntax: 'var')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'e')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'e')
                        Children(0)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'x')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: var) (Syntax: 'x')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,168861,168959);

f_22035_168861_168958(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,165380,168970);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,165380,168970);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,165380,168970);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,168982,176540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,169130,169426);

string 
source = @"
public class MyClass
{
    void M(MyClass[] a, int result)
    /*<bind>*/{
        foreach (var (x, y) in a) 
        { 
            result = x + y;
        }
    }/*</bind>*/
    public void Deconstruct(out int a, out int b)
    {
        throw null;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,169440,169493);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,169509,176417);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IInvocationOperation (virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()) (OperationKind.Invocation, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: MyClass[]) (Syntax: 'a')
                  Arguments(0)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
                Entering: {R4}

        .locals {R4}
        {
            Locals: [System.Int32 x] [System.Int32 y]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 x, System.Int32 y), IsImplicit) (Syntax: 'var (x, y)')
                      Left: 
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 x, System.Int32 y)) (Syntax: 'var (x, y)')
                          ITupleOperation (OperationKind.Tuple, Type: (System.Int32 x, System.Int32 y)) (Syntax: '(x, y)')
                            NaturalType: (System.Int32 x, System.Int32 y)
                            Elements(2):
                                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                                ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: MyClass, IsImplicit) (Syntax: 'var (x, y)')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ExplicitReference)
                          Operand: 
                            IPropertyReferenceOperation: System.Object System.Collections.IEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Object, IsImplicit) (Syntax: 'var (x, y)')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x + y;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x + y')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                          Right: 
                            IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + y')
                              Left: 
                                ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                              Right: 
                                ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')

                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        CaptureIds: [1]
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IConversionOperation (TryCast: True, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')

            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'a')
                  Arguments(0)

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,176431,176529);

f_22035_176431_176528(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,168982,176540);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,168982,176540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,168982,176540);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,176552,181648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,176700,177123);

string 
source = @"
public sealed class MyClass
{
    void M(int result)
    /*<bind>*/{
        foreach ((var x, var y) in this) 
        { 
            result = x + y;
        }
    }/*</bind>*/
    public void Deconstruct(out int a, out int b)
    {
        throw null;
    }
    public bool MoveNext() => false;
    public MyClass Current => null;
    public MyClass GetEnumerator() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,177137,177190);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,177206,181525);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'this')
              Value: 
                IInvocationOperation ( MyClass MyClass.GetEnumerator()) (OperationKind.Invocation, Type: MyClass, IsImplicit) (Syntax: 'this')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: MyClass, IsImplicit) (Syntax: 'this')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass) (Syntax: 'this')
                  Arguments(0)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IInvocationOperation ( System.Boolean MyClass.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'this')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'this')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Int32 x] [System.Int32 y]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 x, System.Int32 y), IsImplicit) (Syntax: '(var x, var y)')
                  Left: 
                    ITupleOperation (OperationKind.Tuple, Type: (System.Int32 x, System.Int32 y)) (Syntax: '(var x, var y)')
                      NaturalType: (System.Int32 x, System.Int32 y)
                      Elements(2):
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var x')
                            ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                          IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var y')
                            ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')
                  Right: 
                    IPropertyReferenceOperation: MyClass MyClass.Current { get; } (OperationKind.PropertyReference, Type: MyClass, IsImplicit) (Syntax: '(var x, var y)')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'this')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x + y;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x + y')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                      Right: 
                        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + y')
                          Left: 
                            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                          Right: 
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'y')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,181539,181637);

f_22035_181539_181636(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,176552,181648);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,176552,181648);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,176552,181648);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,181660,185817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,181808,182201);

string 
source = @"
public sealed class MyClass
{
    void M(int result)
    /*<bind>*/{
        foreach (M2(out var x) in this) 
        { 
            result = x;
        }
    }/*</bind>*/
    public bool MoveNext() => false;
    public MyClass Current => null;
    public MyClass GetEnumerator() => throw null;
    static void M2(out int x)
    {
        x = 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,182215,182519);

var 
expectedDiagnostics = new[] {
f_22035_182437_182503(f_22035_182437_182483(ErrorCode.ERR_BadForeachDecl, "in"), 6, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,182535,185694);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'this')
          Children(1):
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass) (Syntax: 'this')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsImplicit) (Syntax: 'this')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'this')
                Children(0)

    Next (Regular) Block[B3]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 x]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Void, IsImplicit) (Syntax: 'M2(out var x)')
              Left: 
                IInvocationOperation (void MyClass.M2(out System.Int32 x)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(out var x)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out var x')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var x')
                          ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'this')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'this')
                        Children(0)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = x')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                  Right: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,185708,185806);

f_22035_185708_185805(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,181660,185817);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,181660,185817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,181660,185817);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,185829,191950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,185977,186201);

string 
source = @"
public class MyClass
{
    void M(System.Collections.IEnumerable e, object result)
    /*<bind>*/{
        foreach (var x in e)
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,186215,186268);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,186284,191827);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IInvocationOperation (virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()) (OperationKind.Invocation, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Collections.IEnumerable) (Syntax: 'e')
                  Arguments(0)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'e')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
                Entering: {R4}

        .locals {R4}
        {
            Locals: [System.Object x]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Object, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Object System.Collections.IEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Object, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'e')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object) (Syntax: 'result = x')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'result')
                          Right: 
                            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Object) (Syntax: 'x')

                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        CaptureIds: [1]
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
                  Value: 
                    IConversionOperation (TryCast: True, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'e')

            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'e')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'e')
                  Arguments(0)

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,191841,191939);

f_22035_191841_191938(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,185829,191950);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,185829,191950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,185829,191950);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,191962,198891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,192110,192309);

string 
source = @"
public class MyClass
{
    void M(int[] a, long result)
    /*<bind>*/{
        foreach (long x in a) 
        { 
            result = x;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,192323,192376);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,192392,198768);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IInvocationOperation (virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()) (OperationKind.Invocation, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.IEnumerable, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                  Arguments(0)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
                Entering: {R4}

        .locals {R4}
        {
            Locals: [System.Int64 x]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'long')
                      Left: 
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int64, IsImplicit) (Syntax: 'long')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'long')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNumeric)
                          Operand: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'long')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Unboxing)
                              Operand: 
                                IPropertyReferenceOperation: System.Object System.Collections.IEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Object, IsImplicit) (Syntax: 'long')
                                  Instance Receiver: 
                                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int64) (Syntax: 'result = x')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int64) (Syntax: 'result')
                          Right: 
                            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int64) (Syntax: 'x')

                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        CaptureIds: [1]
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IConversionOperation (TryCast: True, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.IEnumerator, IsImplicit) (Syntax: 'a')

            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'a')
                  Arguments(0)

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,198782,198880);

f_22035_198782_198879(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,191962,198891);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,191962,198891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,191962,198891);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,198903,203225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,199051,199404);

string 
source = @"
public sealed class MyClass
{
    void M(bool result)
    /*<bind>*/{
        foreach (var x in this) 
        { 
            if (x) continue;
            result = x;
        }
    }/*</bind>*/
    public bool MoveNext() => false;
    public bool Current => false;
    public MyClass GetEnumerator() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,199418,199471);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,199487,203102);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'this')
              Value: 
                IInvocationOperation ( MyClass MyClass.GetEnumerator()) (OperationKind.Invocation, Type: MyClass, IsImplicit) (Syntax: 'this')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: MyClass, IsImplicit) (Syntax: 'this')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass) (Syntax: 'this')
                  Arguments(0)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B3] [B4]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IInvocationOperation ( System.Boolean MyClass.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'this')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'this')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Boolean x]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'var')
                  Right: 
                    IPropertyReferenceOperation: System.Boolean MyClass.Current { get; } (OperationKind.PropertyReference, Type: System.Boolean, IsImplicit) (Syntax: 'var')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'this')

            Jump if False (Regular) to Block[B4]
                ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'x')

            Next (Regular) Block[B2]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = x')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'x')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B5] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,203116,203214);

f_22035_203116_203213(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,198903,203225);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,198903,203225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,198903,203225);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,203237,207561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,203385,203735);

string 
source = @"
public sealed class MyClass
{
    void M(bool result)
    /*<bind>*/{
        foreach (var x in this) 
        { 
            if (x) break;
            result = x;
        }
    }/*</bind>*/
    public bool MoveNext() => false;
    public bool Current => false;
    public MyClass GetEnumerator() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,203749,203802);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,203818,207438);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'this')
              Value: 
                IInvocationOperation ( MyClass MyClass.GetEnumerator()) (OperationKind.Invocation, Type: MyClass, IsImplicit) (Syntax: 'this')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: MyClass, IsImplicit) (Syntax: 'this')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass) (Syntax: 'this')
                  Arguments(0)

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B4]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IInvocationOperation ( System.Boolean MyClass.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'this')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'this')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B3]
            Entering: {R2}

    .locals {R2}
    {
        Locals: [System.Boolean x]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'var')
                  Right: 
                    IPropertyReferenceOperation: System.Boolean MyClass.Current { get; } (OperationKind.PropertyReference, Type: System.Boolean, IsImplicit) (Syntax: 'var')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyClass, IsImplicit) (Syntax: 'this')

            Jump if False (Regular) to Block[B4]
                ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'x')

            Next (Regular) Block[B5]
                Leaving: {R2} {R1}
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = x;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = x')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'x')

            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}

Block[B5] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,207452,207550);

f_22035_207452_207549(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,203237,207561);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,203237,207561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,203237,207561);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ForEachFlow_26()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,207573,214110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,207721,208094);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, object a, object b)
    /*<bind>*/{
        foreach ((var x, (var y, var z), a ?? b) in this) 
        { 
        }
    }/*</bind>*/
    public bool MoveNext() => false;
    public (int a, (int, int) b, object c) Current => default;
    public MyClass GetEnumerator() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,208108,208761);

var 
expectedDiagnostics = new[] {
f_22035_208363_208437(f_22035_208363_208417(ErrorCode.ERR_AssgLvalueExpected, "a ?? b"), 6, 42),
f_22035_208637_208745(f_22035_208637_208725(ErrorCode.ERR_MustDeclareForeachIteration, "(var x, (var y, var z), a ?? b)"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,208777,213987);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'this')
          Children(1):
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass) (Syntax: 'this')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B6]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsImplicit) (Syntax: 'this')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'this')
                Children(0)

    Next (Regular) Block[B3]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32 x] [System.Int32 y] [System.Int32 z]
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Object, IsInvalid) (Syntax: 'a')

            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Object, IsInvalid) (Syntax: 'b')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B4] [B5]
        Statements (1)
            IDeconstructionAssignmentOperation (OperationKind.DeconstructionAssignment, Type: (System.Int32 x, (System.Int32 y, System.Int32 z), System.Object), IsInvalid, IsImplicit) (Syntax: '(var x, (va ... z), a ?? b)')
              Left: 
                ITupleOperation (OperationKind.Tuple, Type: (System.Int32 x, (System.Int32 y, System.Int32 z), System.Object), IsInvalid) (Syntax: '(var x, (va ... z), a ?? b)')
                  NaturalType: (System.Int32 x, (System.Int32 y, System.Int32 z), System.Object)
                  Elements(3):
                      IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var x')
                        ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
                      ITupleOperation (OperationKind.Tuple, Type: (System.Int32 y, System.Int32 z), IsInvalid) (Syntax: '(var y, var z)')
                        NaturalType: (System.Int32 y, System.Int32 z)
                        Elements(2):
                            IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var y')
                              ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
                            IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var z')
                              ILocalReferenceOperation: z (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'z')
                      IInvalidOperation (OperationKind.Invalid, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'a ?? b')
                        Children(1):
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'a ?? b')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'this')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'this')
                        Children(0)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,214001,214099);

f_22035_214001_214098(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,207573,214110);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,207573,214110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,207573,214110);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void ForEachFlow_ViaExtensionMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,214122,221647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,214352,214717);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static void Main()
    /*<bind>*/{
        foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}

static class Extensions
{
    public static IEnumerator<string> GetEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,214731,214784);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,214800,221486);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Program()')
              Value: 
                IInvocationOperation (System.Collections.Generic.IEnumerator<System.String> Extensions.GetEnumerator(this Program p)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new Program()')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'new Program()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (Identity)
                          Operand: 
                            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
                              Arguments(0)
                              Initializer: 
                                null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'new Program()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.String value]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.String System.Collections.Generic.IEnumerator<System.String>.Current { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
                      Expression: 
                        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'new Program()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new Program()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'new Program()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                  Arguments(0)
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,221502,221636);

f_22035_221502_221635(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,214122,221647);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,214122,221647);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,214122,221647);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void ForEachFlow_ViaExtensionMethodWithConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,221659,229220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,221903,222269);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static void Main()
    /*<bind>*/{
        foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}


static class Extensions
{
    public static IEnumerator<string> GetEnumerator(this object p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,222283,222336);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,222352,229059);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Program()')
              Value: 
                IInvocationOperation (System.Collections.Generic.IEnumerator<System.String> Extensions.GetEnumerator(this System.Object p)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new Program()')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new Program()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
                              Arguments(0)
                              Initializer: 
                                null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'new Program()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.String value]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.String System.Collections.Generic.IEnumerator<System.String>.Current { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
                      Expression: 
                        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'new Program()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new Program()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'new Program()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                  Arguments(0)
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,229075,229209);

f_22035_229075_229208(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,221659,229220);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,221659,229220);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,221659,229220);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void ForEachFlow_ViaExtensionMethod_WithGetEnumeratorReturningWrongType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,229232,233209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,229498,229848);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static void Main()
    /*<bind>*/{
        foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}

static class Extensions
{
    public static bool GetEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,229862,230633);

var 
expectedDiagnostics = new[] {
f_22035_230078_230186(f_22035_230078_230166(f_22035_230078_230133(ErrorCode.ERR_NoSuchMember, "new Program()"), "bool", "Current"), 7, 31),
f_22035_230479_230617(f_22035_230479_230597(f_22035_230479_230538(ErrorCode.ERR_BadGetEnumerator, "new Program()"), "bool", "Extensions.GetEnumerator(Program)"), 7, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,230649,233048);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Program()')
          Children(1):
              IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program, IsInvalid) (Syntax: 'new Program()')
                Arguments(0)
                Initializer: 
                  null
    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'new Program()')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Program()')
                Children(0)
    Next (Regular) Block[B3]
        Entering: {R1}
.locals {R1}
{
    Locals: [var value]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
              Left: 
                ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsImplicit) (Syntax: 'var')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Program()')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Program()')
                        Children(0)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
              Expression: 
                IInvalidOperation (OperationKind.Invalid, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                  Children(2):
                      IOperation:  (OperationKind.None, Type: null) (Syntax: 'System.Console')
                      ILocalReferenceOperation: value (OperationKind.LocalReference, Type: var) (Syntax: 'value')
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,233064,233198);

f_22035_233064_233197(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,229232,233209);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,229232,233209);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,229232,233209);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void ForEachFlow_ViaExtensionMethod_WithSpillInExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,233221,243222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,233473,233846);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static void Main()
    /*<bind>*/{
        foreach (var value in null ?? new Program())
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}

static class Extensions
{
    public static IEnumerator<string> GetEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,233860,233913);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,233929,243061);

var 
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
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'null')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
                    Leaving: {R3}
                Next (Regular) Block[B2]
            Block[B2] - Block [UnReachable]
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                      Value: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'null')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
                Next (Regular) Block[B4]
                    Leaving: {R3}
        }
        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Program()')
                  Value: 
                    IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null ?? new Program()')
                  Value: 
                    IInvocationOperation (System.Collections.Generic.IEnumerator<System.String> Extensions.GetEnumerator(this Program p)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'null ?? new Program()')
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'null ?? new Program()')
                              Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Identity)
                              Operand: 
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Program, IsImplicit) (Syntax: 'null ?? new Program()')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R4} {R5}
    }
    .try {R4, R5}
    {
        Block[B5] - Block
            Predecessors: [B4] [B6]
            Statements (0)
            Jump if False (Regular) to Block[B10]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'null ?? new Program()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
                  Arguments(0)
                Finalizing: {R7}
                Leaving: {R5} {R4} {R1}
            Next (Regular) Block[B6]
                Entering: {R6}
        .locals {R6}
        {
            Locals: [System.String value]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.String System.Collections.Generic.IEnumerator<System.String>.Current { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
                      Expression: 
                        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Next (Regular) Block[B5]
                    Leaving: {R6}
        }
    }
    .finally {R7}
    {
        Block[B7] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B9]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'null ?? new Program()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'null ?? new Program()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'null ?? new Program()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
                  Arguments(0)
            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B10] - Exit
    Predecessors: [B5]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,243077,243211);

f_22035_243077_243210(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.Regular9);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,233221,243222);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,233221,243222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,233221,243222);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void AwaitForeachFlow_ViaExtensionMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,243234,251429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,243469,243853);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static async void M()
    /*<bind>*/{
        await foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}

static class Extensions
{
    public static IAsyncEnumerator<string> GetAsyncEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,243867,243920);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,243936,251170);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Program()')
              Value: 
                IInvocationOperation (System.Collections.Generic.IAsyncEnumerator<System.String> Extensions.GetAsyncEnumerator(this Program p)) (OperationKind.Invocation, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new Program()')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'new Program()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (Identity)
                          Operand: 
                            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
                              Arguments(0)
                              Initializer: 
                                null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IAwaitOperation (OperationKind.Await, Type: System.Boolean, IsImplicit) (Syntax: 'await forea ... }')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask<System.Boolean> System.Collections.Generic.IAsyncEnumerator<System.String>.MoveNextAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask<System.Boolean>, IsImplicit) (Syntax: 'new Program()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                      Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.String value]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.String System.Collections.Generic.IAsyncEnumerator<System.String>.Current { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
                      Expression: 
                        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'new Program()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'new Program()')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsImplicit) (Syntax: 'new Program()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'new Program()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                      Arguments(0)
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,251186,251308);

var 
comp = f_22035_251197_251307(new[] { source, s_IAsyncEnumerable }, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,251322,251418);

f_22035_251322_251417(comp, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,243234,251429);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,243234,251429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,243234,251429);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void AwaitForeachFlow_ViaExtensionMethodWithConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,251441,259672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,251690,252075);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static async void M()
    /*<bind>*/{
        await foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}


static class Extensions
{
    public static IAsyncEnumerator<string> GetAsyncEnumerator(this object p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,252089,252142);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,252158,259413);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Program()')
              Value: 
                IInvocationOperation (System.Collections.Generic.IAsyncEnumerator<System.String> Extensions.GetAsyncEnumerator(this System.Object p)) (OperationKind.Invocation, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new Program()')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'new Program()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
                              Arguments(0)
                              Initializer: 
                                null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IAwaitOperation (OperationKind.Await, Type: System.Boolean, IsImplicit) (Syntax: 'await forea ... }')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask<System.Boolean> System.Collections.Generic.IAsyncEnumerator<System.String>.MoveNextAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask<System.Boolean>, IsImplicit) (Syntax: 'new Program()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                      Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.String value]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.String System.Collections.Generic.IAsyncEnumerator<System.String>.Current { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
                      Expression: 
                        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'new Program()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'new Program()')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsImplicit) (Syntax: 'new Program()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'new Program()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'new Program()')
                      Arguments(0)
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,259429,259551);

var 
comp = f_22035_259440_259550(new[] { source, s_IAsyncEnumerable }, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,259565,259661);

f_22035_259565_259660(comp, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,251441,259672);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,251441,259672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,251441,259672);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void AwaitForeachFlow_ViaExtensionMethod_WithGetAsyncEnumeratorReturningWrongType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,259684,263814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,259960,260324);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static async void M()
    /*<bind>*/{
        await foreach (var value in new Program())
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}

static class Extensions
{
    public static bool GetAsyncEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,260338,261140);

var 
expectedDiagnostics = new[] {
f_22035_260553_260661(f_22035_260553_260641(f_22035_260553_260608(ErrorCode.ERR_NoSuchMember, "new Program()"), "bool", "Current"), 7, 37),
f_22035_260976_261124(f_22035_260976_261104(f_22035_260976_261040(ErrorCode.ERR_BadGetAsyncEnumerator, "new Program()"), "bool", "Extensions.GetAsyncEnumerator(Program)"), 7, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,261156,263555);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Program()')
          Children(1):
              IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program, IsInvalid) (Syntax: 'new Program()')
                Arguments(0)
                Initializer: 
                  null
    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'new Program()')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Program()')
                Children(0)
    Next (Regular) Block[B3]
        Entering: {R1}
.locals {R1}
{
    Locals: [var value]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
              Left: 
                ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsImplicit) (Syntax: 'var')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Program()')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'new Program()')
                        Children(0)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
              Expression: 
                IInvalidOperation (OperationKind.Invalid, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                  Children(2):
                      IOperation:  (OperationKind.None, Type: null) (Syntax: 'System.Console')
                      ILocalReferenceOperation: value (OperationKind.LocalReference, Type: var) (Syntax: 'value')
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,263571,263693);

var 
comp = f_22035_263582_263692(new[] { source, s_IAsyncEnumerable }, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,263707,263803);

f_22035_263707_263802(comp, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,259684,263814);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,259684,263814);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,259684,263814);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(17602, "https://github.com/dotnet/roslyn/issues/17602")]
        public void AwaitForeachFlow_ViaExtensionMethod_WithSpillInExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,263826,274505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,264083,264475);

var 
source = @"
using System.Collections.Generic;
class Program
{
    static async void M()
    /*<bind>*/{
        await foreach (var value in null ?? new Program())
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}

static class Extensions
{
    public static IAsyncEnumerator<string> GetAsyncEnumerator(this Program p) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,264489,264542);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,264558,274246);

var 
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
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'null')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
                    Leaving: {R3}
                Next (Regular) Block[B2]
            Block[B2] - Block [UnReachable]
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                      Value: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'null')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
                Next (Regular) Block[B4]
                    Leaving: {R3}
        }
        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new Program()')
                  Value: 
                    IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null ?? new Program()')
                  Value: 
                    IInvocationOperation (System.Collections.Generic.IAsyncEnumerator<System.String> Extensions.GetAsyncEnumerator(this Program p)) (OperationKind.Invocation, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'null ?? new Program()')
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsImplicit) (Syntax: 'null ?? new Program()')
                              Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (Identity)
                              Operand: 
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: Program, IsImplicit) (Syntax: 'null ?? new Program()')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R4} {R5}
    }
    .try {R4, R5}
    {
        Block[B5] - Block
            Predecessors: [B4] [B6]
            Statements (0)
            Jump if False (Regular) to Block[B10]
                IAwaitOperation (OperationKind.Await, Type: System.Boolean, IsImplicit) (Syntax: 'await forea ... }')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask<System.Boolean> System.Collections.Generic.IAsyncEnumerator<System.String>.MoveNextAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask<System.Boolean>, IsImplicit) (Syntax: 'null ?? new Program()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
                      Arguments(0)
                Finalizing: {R7}
                Leaving: {R5} {R4} {R1}
            Next (Regular) Block[B6]
                Entering: {R6}
        .locals {R6}
        {
            Locals: [System.String value]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.String System.Collections.Generic.IAsyncEnumerator<System.String>.Current { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
                      Expression: 
                        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Next (Regular) Block[B5]
                    Leaving: {R6}
        }
    }
    .finally {R7}
    {
        Block[B7] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B9]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'null ?? new Program()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'null ?? new Program()')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsImplicit) (Syntax: 'null ?? new Program()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'null ?? new Program()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'null ?? new Program()')
                      Arguments(0)
            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B10] - Exit
    Predecessors: [B5]
    Statements (0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,274262,274384);

var 
comp = f_22035_274273_274383(new[] { source, s_IAsyncEnumerable }, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,274398,274494);

f_22035_274398_274493(comp, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,263826,274505);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,263826,274505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,263826,274505);
}
		}

[Fact, CompilerTrait(CompilerFeature.IOperation, CompilerFeature.AsyncStreams)]
        [WorkItem(30362, "https://github.com/dotnet/roslyn/issues/30362")]
        public void IForEachLoopStatement_SimpleAwaitForEachLoop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,274517,277283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,274765,275066);

string 
source = @"
class Program
{
    static async System.Threading.Tasks.Task Main(System.Collections.Generic.IAsyncEnumerable<string> pets)
    {
        /*<bind>*/await foreach (string value in pets)
        {
            System.Console.WriteLine(value);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,275080,277139);

string 
expectedOperationTree = @"
IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
  Locals: Local_1: System.String value
  LoopControlVariable: 
    IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'string')
      Initializer: 
        null
  Collection: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IAsyncEnumerable<System.String>, IsImplicit) (Syntax: 'pets')
      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: pets (OperationKind.ParameterReference, Type: System.Collections.Generic.IAsyncEnumerable<System.String>) (Syntax: 'pets')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                  ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  NextVariables(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,277155,277272);

f_22035_277155_277271(source + s_IAsyncEnumerable + s_ValueTask, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,274517,277283);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,274517,277283);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,274517,277283);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.AsyncStreams)]
        [Fact, WorkItem(30362, "https://github.com/dotnet/roslyn/issues/30362")]
        public void ForEachAwaitFlow_SimpleAwaitForEachLoop()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,277295,284836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,277564,277926);

string 
source = @"
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System;
class Program
{
    static async Task Main(System.Collections.Generic.IAsyncEnumerable<string> pets)
    /*<bind>*/{
        await foreach (string value in pets)
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,277942,277995);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,278011,284678);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'pets')
              Value: 
                IInvocationOperation (virtual System.Collections.Generic.IAsyncEnumerator<System.String> System.Collections.Generic.IAsyncEnumerable<System.String>.GetAsyncEnumerator([System.Threading.CancellationToken token = default(System.Threading.CancellationToken)])) (OperationKind.Invocation, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'pets')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IAsyncEnumerable<System.String>, IsImplicit) (Syntax: 'pets')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IParameterReferenceOperation: pets (OperationKind.ParameterReference, Type: System.Collections.Generic.IAsyncEnumerable<System.String>) (Syntax: 'pets')
                  Arguments(0)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IAwaitOperation (OperationKind.Await, Type: System.Boolean, IsImplicit) (Syntax: 'await forea ... }')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask<System.Boolean> System.Collections.Generic.IAsyncEnumerator<System.String>.MoveNextAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask<System.Boolean>, IsImplicit) (Syntax: 'pets')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'pets')
                      Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.String value]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'string')
                      Left: 
                        ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'string')
                      Right: 
                        IPropertyReferenceOperation: System.String System.Collections.Generic.IAsyncEnumerator<System.String>.Current { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'string')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'pets')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
                      Expression: 
                        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                                ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'pets')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'pets')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'pets')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsImplicit) (Syntax: 'pets')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'pets')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.String>, IsImplicit) (Syntax: 'pets')
                      Arguments(0)
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,284692,284825);

f_22035_284692_284824(source + s_IAsyncEnumerable + s_ValueTask, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,277295,284836);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,277295,284836);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,277295,284836);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.AsyncStreams)]
        [Fact, WorkItem(30362, "https://github.com/dotnet/roslyn/issues/30362")]
        public void ForEachAwaitFlow_SimpleAwaitForEachLoop_MissingIAsyncEnumerableType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,284848,290940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,285145,285507);

string 
source = @"
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System;
class Program
{
    static async Task Main(System.Collections.Generic.IAsyncEnumerable<string> pets)
    /*<bind>*/{
        await foreach (string value in pets)
        {
            System.Console.WriteLine(value);
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,285523,286082);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22035_285900_286066(f_22035_285900_286046(f_22035_285900_285980(ErrorCode.ERR_DottedTypeNameNotFoundInNS, "IAsyncEnumerable<string>"), "IAsyncEnumerable<>", "System.Collections.Generic"), 7, 55)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,286098,288887);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'pets')
          Children(1):
              IParameterReferenceOperation: pets (OperationKind.ParameterReference, Type: System.Collections.Generic.IAsyncEnumerable<System.String>) (Syntax: 'pets')
    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsImplicit) (Syntax: 'pets')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'pets')
                Children(0)
    Next (Regular) Block[B3]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.String value]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'string')
              Left: 
                ILocalReferenceOperation: value (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String, IsImplicit) (Syntax: 'string')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'pets')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'pets')
                        Children(0)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
              Expression: 
                IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                        ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,288901,288999);

f_22035_288901_288998(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,289015,290844);

var 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
    Locals: Local_1: System.String value
    LoopControlVariable:
      IVariableDeclaratorOperation (Symbol: System.String value) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'string')
        Initializer:
          null
    Collection:
      IParameterReferenceOperation: pets (OperationKind.ParameterReference, Type: System.Collections.Generic.IAsyncEnumerable<System.String>) (Syntax: 'pets')
    Body:
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... ine(value);')
          Expression:
            IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... Line(value)')
              Instance Receiver:
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'value')
                    ILocalReferenceOperation: value (OperationKind.LocalReference, Type: System.String) (Syntax: 'value')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    NextVariables(0)"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,290858,290929);

f_22035_290858_290928(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,284848,290940);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,284848,290940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,284848,290940);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.AsyncStreams)]
        [Fact, WorkItem(49267, "https://github.com/dotnet/roslyn/issues/49267")]
        public void AsyncForeach_StructEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,290952,297144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,291211,291815);

var 
compilation = f_22035_291229_291814(@"
#pragma warning disable CS1998 // async method lacks awaits
using System.Threading.Tasks;
class C
{
    static async Task Main()
    /*<bind>*/{
        await foreach (var i in new C())
        {
        }
    }/*</bind>*/
    public AsyncEnumerator GetAsyncEnumerator() => throw null;
    public struct AsyncEnumerator
    {
        public int Current => throw null;
        public async Task<bool> MoveNextAsync() => throw null;
        public async ValueTask DisposeAsync() => throw null;
    }
}", targetFramework: TargetFramework.NetCoreApp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,291831,293054);

f_22035_291831_293053(compilation, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
    Locals: Local_1: System.Int32 i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
            Arguments(0)
            Initializer: 
              null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)
            ", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,293070,297133);

f_22035_293070_297132(compilation, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C()')
              Value: 
                IInvocationOperation ( C.AsyncEnumerator C.GetAsyncEnumerator()) (OperationKind.Invocation, Type: C.AsyncEnumerator, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
                  Arguments(0)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IAwaitOperation (OperationKind.Await, Type: System.Boolean, IsImplicit) (Syntax: 'await forea ... }')
                  Expression: 
                    IInvocationOperation ( System.Threading.Tasks.Task<System.Boolean> C.AsyncEnumerator.MoveNextAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task<System.Boolean>, IsImplicit) (Syntax: 'new C()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.AsyncEnumerator, IsImplicit) (Syntax: 'new C()')
                      Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.Int32 i]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Int32 C.AsyncEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.AsyncEnumerator, IsImplicit) (Syntax: 'new C()')
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'new C()')
                  Expression: 
                    IInvocationOperation ( System.Threading.Tasks.ValueTask C.AsyncEnumerator.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsImplicit) (Syntax: 'new C()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.AsyncEnumerator, IsImplicit) (Syntax: 'new C()')
                      Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B5] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,290952,297144);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,290952,297144);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,290952,297144);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.AsyncStreams)]
        [Fact, WorkItem(49267, "https://github.com/dotnet/roslyn/issues/49267")]
        public void AsyncForeach_StructEnumerator_ExplicitAsyncDisposeInterface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,297156,303831);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,297445,298075);

var 
compilation = f_22035_297463_298074(@"
#pragma warning disable CS1998 // async method lacks awaits
using System.Threading.Tasks;
class C
{
    static async Task Main()
    /*<bind>*/{
        await foreach (var i in new C())
        {
        }
    }/*</bind>*/
    public AsyncEnumerator GetAsyncEnumerator() => throw null;
    public struct AsyncEnumerator : System.IAsyncDisposable
    {
        public int Current => throw null;
        public async Task<bool> MoveNextAsync() => throw null;
        public async ValueTask DisposeAsync() => throw null;
    }
}", targetFramework: TargetFramework.NetCoreApp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,298091,299314);

f_22035_298091_299313(compilation, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
    Locals: Local_1: System.Int32 i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
            Arguments(0)
            Initializer: 
              null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)
            ", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,299330,303820);

f_22035_299330_303819(compilation, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C()')
              Value: 
                IInvocationOperation ( C.AsyncEnumerator C.GetAsyncEnumerator()) (OperationKind.Invocation, Type: C.AsyncEnumerator, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
                  Arguments(0)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IAwaitOperation (OperationKind.Await, Type: System.Boolean, IsImplicit) (Syntax: 'await forea ... }')
                  Expression: 
                    IInvocationOperation ( System.Threading.Tasks.Task<System.Boolean> C.AsyncEnumerator.MoveNextAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task<System.Boolean>, IsImplicit) (Syntax: 'new C()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.AsyncEnumerator, IsImplicit) (Syntax: 'new C()')
                      Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.Int32 i]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Int32 C.AsyncEnumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.AsyncEnumerator, IsImplicit) (Syntax: 'new C()')
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'new C()')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsImplicit) (Syntax: 'new C()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'new C()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (Boxing)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.AsyncEnumerator, IsImplicit) (Syntax: 'new C()')
                      Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B5] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,297156,303831);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,297156,303831);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,297156,303831);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.AsyncStreams)]
        [Fact, WorkItem(49267, "https://github.com/dotnet/roslyn/issues/49267")]
        public void Foreach_StructEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,303843,309795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,304097,304573);

var 
compilation = f_22035_304115_304572(@"
class C
{
    static void Main()
    /*<bind>*/{
        foreach (var i in new C())
        {
        } 
    }/*</bind>*/

    public Enumerator GetEnumerator() => throw null;
    public struct Enumerator : System.IDisposable
    {
        public int Current => throw null;
        public bool MoveNext() => throw null;
        public void Dispose() => throw null;
    }
}", targetFramework: TargetFramework.NetCoreApp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,304589,305782);

f_22035_304589_305781(compilation, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
    Locals: Local_1: System.Int32 i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
            Arguments(0)
            Initializer: 
              null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,305798,309784);

f_22035_305798_309783(compilation, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C()')
              Value: 
                IInvocationOperation ( C.Enumerator C.GetEnumerator()) (OperationKind.Invocation, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
                  Arguments(0)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IInvocationOperation ( System.Boolean C.Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.Int32 i]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Int32 C.Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'new C()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B5] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,303843,309795);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,303843,309795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,303843,309795);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.AsyncStreams)]
        [Fact, WorkItem(49267, "https://github.com/dotnet/roslyn/issues/49267")]
        public void Foreach_RefStructEnumerator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,309807,315339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,310064,310523);

var 
compilation = f_22035_310082_310522(@"
class C
{
    static void Main()
    /*<bind>*/{
        foreach (var i in new C())
        {
        } 
    }/*</bind>*/

    public Enumerator GetEnumerator() => throw null;
    public ref struct Enumerator
    {
        public int Current => throw null;
        public bool MoveNext() => throw null;
        public void Dispose() => throw null;
    }
}", targetFramework: TargetFramework.NetCoreApp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,310539,311732);

f_22035_310539_311731(compilation, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
    Locals: Local_1: System.Int32 i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
            Arguments(0)
            Initializer: 
              null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,311748,315328);

f_22035_311748_315327(compilation, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C()')
              Value: 
                IInvocationOperation ( C.Enumerator C.GetEnumerator()) (OperationKind.Invocation, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
                  Arguments(0)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IInvocationOperation ( System.Boolean C.Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.Int32 i]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Int32 C.Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation ( void C.Enumerator.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B5] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,309807,315339);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,309807,315339);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,309807,315339);
}
		}

[Fact]
        public void AsyncForEach_TestConstantNullableImplementingIEnumerable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,315351,323920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,315462,315881);

var 
source = @"
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
public struct C : IAsyncEnumerable<int>
{
    public static async Task Main()
    /*<bind>*/{
        await foreach (var i in (C?)null)
        {
        }
    }/*</bind>*/
    IAsyncEnumerator<int> IAsyncEnumerable<int>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,315895,316011);

var 
comp = f_22035_315906_316010(new[] { source, AsyncStreamsTypes }, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,316025,317747);

f_22035_316025_317746(comp, expectedDiagnostics: DiagnosticDescription.None, expectedOperationTree: @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
    Locals: Local_1: System.Int32 i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IAsyncEnumerable<System.Int32>, IsImplicit) (Syntax: '(C?)null')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvocationOperation ( C C?.Value.get) (OperationKind.Invocation, Type: C, IsImplicit) (Syntax: '(C?)null')
            Instance Receiver: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C?, Constant: null) (Syntax: '(C?)null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
            Arguments(0)
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,317763,323909);

f_22035_317763_323908(comp, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(C?)null')
              Value: 
                IInvocationOperation (virtual System.Collections.Generic.IAsyncEnumerator<System.Int32> System.Collections.Generic.IAsyncEnumerable<System.Int32>.GetAsyncEnumerator([System.Threading.CancellationToken token = default(System.Threading.CancellationToken)])) (OperationKind.Invocation, Type: System.Collections.Generic.IAsyncEnumerator<System.Int32>, IsImplicit) (Syntax: '(C?)null')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IAsyncEnumerable<System.Int32>, IsImplicit) (Syntax: '(C?)null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IInvocationOperation ( C C?.Value.get) (OperationKind.Invocation, Type: C, IsImplicit) (Syntax: '(C?)null')
                          Instance Receiver: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C?, Constant: null) (Syntax: '(C?)null')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (NullLiteral)
                              Operand: 
                                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
                          Arguments(0)
                  Arguments(0)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IAwaitOperation (OperationKind.Await, Type: System.Boolean, IsImplicit) (Syntax: 'await forea ... }')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask<System.Boolean> System.Collections.Generic.IAsyncEnumerator<System.Int32>.MoveNextAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask<System.Boolean>, IsImplicit) (Syntax: '(C?)null')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.Int32>, IsImplicit) (Syntax: '(C?)null')
                      Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.Int32 i]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Int32 System.Collections.Generic.IAsyncEnumerator<System.Int32>.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.Int32>, IsImplicit) (Syntax: '(C?)null')
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: '(C?)null')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.Int32>, IsImplicit) (Syntax: '(C?)null')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: '(C?)null')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsImplicit) (Syntax: '(C?)null')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IAsyncDisposable, IsImplicit) (Syntax: '(C?)null')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IAsyncEnumerator<System.Int32>, IsImplicit) (Syntax: '(C?)null')
                      Arguments(0)
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,315351,323920);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,315351,323920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,315351,323920);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void Foreach_RefStructEnumerator_DefaultDisposeArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,323932,331935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,324117,324624);

var 
compilation = f_22035_324135_324623(@"
class C
{
    static void Main()
    /*<bind>*/{
        foreach (var i in new C())
        {
        } 
    }/*</bind>*/

    public Enumerator GetEnumerator() => throw null;
    public ref struct Enumerator
    {
        public int Current => throw null;
        public bool MoveNext() => throw null;
        public void Dispose(int a = 1, bool b = true, params object[] extras) => throw null;
    }
}", targetFramework: TargetFramework.NetCoreApp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,324640,325833);

f_22035_324640_325832(compilation, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
    Locals: Local_1: System.Int32 i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
            Arguments(0)
            Initializer: 
              null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,325849,331924);

f_22035_325849_331923(compilation, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C()')
              Value: 
                IInvocationOperation ( C.Enumerator C.GetEnumerator()) (OperationKind.Invocation, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Identity)
                      Operand: 
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
                  Arguments(0)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IInvocationOperation ( System.Boolean C.Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.Int32 i]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Int32 C.Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation ( void C.Enumerator.Dispose([System.Int32 a = 1], [System.Boolean b = true], params System.Object[] extras)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'foreach (va ... }')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'foreach (va ... }')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: b) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'foreach (va ... }')
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'foreach (va ... }')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'foreach (va ... }')
                        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'foreach (va ... }')
                          Dimension Sizes(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'foreach (va ... }')
                          Initializer: 
                            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'foreach (va ... }')
                              Element Values(0)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B5] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,323932,331935);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,323932,331935);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,323932,331935);
}
		}

[Fact]
        public void AsyncForeach_ExtensionGetEnumeratorWithParams()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,331947,340751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,332047,332637);

string 
source = @"
using System;
using System.Threading.Tasks;
public class C
{
    public static async Task Main()
    /*<bind>*/{
        await foreach (var i in new C())
        {
            Console.Write(i);
        }
    }/*</bind>*/
    public sealed class Enumerator
    {
        public Enumerator() => throw null;
        public int Current { get; private set; }
        public Task<bool> MoveNextAsync() => throw null;
    }
}
public static class Extensions
{
    public static C.Enumerator GetAsyncEnumerator(this C self, params int[] x) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,332651,332769);

var 
comp = f_22035_332662_332768(source, options: TestOptions.DebugExe, parseOptions: TestOptions.Regular9)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,332783,334958);

f_22035_332783_334957(comp, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, IsAsynchronous, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'await forea ... }')
    Locals: Local_1: System.Int32 i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
            Arguments(0)
            Initializer: 
              null
    Body: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Write(i);')
          Expression: 
            IInvocationOperation (void System.Console.Write(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Write(i)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'i')
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    NextVariables(0)
", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,334974,340740);

f_22035_334974_340739(comp, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new C()')
              Value: 
                IInvocationOperation (C.Enumerator Extensions.GetAsyncEnumerator(this C self, params System.Int32[] x)) (OperationKind.Invocation, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: self) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new C()')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'new C()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (Identity)
                          Operand: 
                            IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                              Arguments(0)
                              Initializer: 
                                null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new C()')
                        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'new C()')
                          Dimension Sizes(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'new C()')
                          Initializer: 
                            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'new C()')
                              Element Values(0)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IAwaitOperation (OperationKind.Await, Type: System.Boolean, IsImplicit) (Syntax: 'await forea ... }')
              Expression: 
                IInvocationOperation ( System.Threading.Tasks.Task<System.Boolean> C.Enumerator.MoveNextAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task<System.Boolean>, IsImplicit) (Syntax: 'new C()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                  Arguments(0)
            Leaving: {R1}
        Next (Regular) Block[B3]
            Entering: {R2}
    .locals {R2}
    {
        Locals: [System.Int32 i]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                  Left: 
                    ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                  Right: 
                    IPropertyReferenceOperation: System.Int32 C.Enumerator.Current { get; private set; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C.Enumerator, IsImplicit) (Syntax: 'new C()')
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Write(i);')
                  Expression: 
                    IInvocationOperation (void System.Console.Write(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Write(i)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'i')
                            ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B2]
                Leaving: {R2}
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,331947,340751);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,331947,340751);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,331947,340751);
}
		}

[Fact]
        public void ForEach_ExtensionGetEnumeratorDefaultParam()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,340763,348287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,340860,341254);

var 
comp = f_22035_340871_341253(@"
public class C
{
    static void M(C c)
    /*<bind>*/{
        foreach (var i in c)
        {
        }
    }/*</bind>*/
}
public static class CExt
{
    public class Enumerator
    {
        public int Current => 1;
        public bool MoveNext() => false;
    }
    public static Enumerator GetEnumerator(this C c, int i = 1) => null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,341270,342359);

f_22035_341270_342358(comp, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (va ... }')
    Locals: Local_1: System.Int32 i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'c')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)
", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,342375,348276);

f_22035_342375_348275(comp, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IInvocationOperation (CExt.Enumerator CExt.GetEnumerator(this C c, [System.Int32 i = 1])) (OperationKind.Invocation, Type: CExt.Enumerator, IsImplicit) (Syntax: 'c')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'c')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'c')
                          Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (Identity)
                          Operand: 
                            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'c')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'c')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation ( System.Boolean CExt.Enumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: CExt.Enumerator, IsImplicit) (Syntax: 'c')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.Int32 i]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.Int32 CExt.Enumerator.Current { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: CExt.Enumerator, IsImplicit) (Syntax: 'c')
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        CaptureIds: [1]
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                  Value: 
                    IConversionOperation (TryCast: True, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'c')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: CExt.Enumerator, IsImplicit) (Syntax: 'c')
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'c')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'c')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'c')
                  Arguments(0)
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,340763,348287);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,340763,348287);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,340763,348287);
}
		}

[Fact]
        public void ForEach_ExtensionGetEnumeratorParamArrayNotLast()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,348299,352504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,348401,348813);

var 
comp = f_22035_348412_348812(@"
public class C
{
    static void M(C c)
    /*<bind>*/{
        foreach (var i in c)
        {
        }
    }/*</bind>*/
}
public static class CExt
{
    public class Enumerator
    {
        public int Current => 1;
        public bool MoveNext() => false;
    }
    public static Enumerator GetEnumerator(this C c, params int[] arr, int i = 0) => null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,348829,349958);

var 
diagnostics = new DiagnosticDescription[] {
f_22035_349114_349253(f_22035_349114_349233(f_22035_349114_349168(ErrorCode.ERR_NoCorrespondingArgument, "c"), "arr", "CExt.GetEnumerator(C, params int[], int)"), 6, 27),
f_22035_349512_349619(f_22035_349512_349599(f_22035_349512_349563(ErrorCode.ERR_ForEachMissingMember, "c"), "C", "GetEnumerator"), 6, 27),
f_22035_349865_349942(f_22035_349865_349921(ErrorCode.ERR_ParamsLast, "params int[] arr"), 18, 54)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,349974,350768);

f_22035_349974_350767(comp, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (va ... }')
    Locals: Local_1: var i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: var i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)", diagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,350784,352493);

f_22035_350784_352492(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
          Children(1):
              IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'c')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                Children(0)
    Next (Regular) Block[B3]
        Entering: {R1}
.locals {R1}
{
    Locals: [var i]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsImplicit) (Syntax: 'var')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                        Children(0)
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,348299,352504);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,348299,352504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,348299,352504);
}
		}

[Fact]
        public void ForEach_ExtensionGetEnumeratorParamArrayWrongType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,352516,356965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,352620,353021);

var 
comp = f_22035_352631_353020(@"
public class C
{
    static void M(C c)
    /*<bind>*/{
        foreach (var i in c)
        {
        }
    }/*</bind>*/
}
public static class CExt
{
    public class Enumerator
    {
        public int Current => 1;
        public bool MoveNext() => false;
    }
    public static Enumerator GetEnumerator(this C c, params int i = 0) => null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,353037,354419);

var 
diagnostics = new DiagnosticDescription[] {
f_22035_353313_353443(f_22035_353313_353423(f_22035_353313_353367(ErrorCode.ERR_NoCorrespondingArgument, "c"), "i", "CExt.GetEnumerator(C, params int)"), 6, 27),
f_22035_353702_353809(f_22035_353702_353789(f_22035_353702_353753(ErrorCode.ERR_ForEachMissingMember, "c"), "C", "GetEnumerator"), 6, 27),
f_22035_354027_354101(f_22035_354027_354080(ErrorCode.ERR_ParamsMustBeArray, "params"), 18, 54),
f_22035_354316_354403(f_22035_354316_354382(ErrorCode.ERR_DefaultValueForParamsParameter, "params"), 18, 54)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,354435,355229);

f_22035_354435_355228(comp, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (va ... }')
    Locals: Local_1: var i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: var i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)", diagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,355245,356954);

f_22035_355245_356953(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
          Children(1):
              IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'c')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                Children(0)
    Next (Regular) Block[B3]
        Entering: {R1}
.locals {R1}
{
    Locals: [var i]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsImplicit) (Syntax: 'var')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                        Children(0)
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,352516,356965);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,352516,356965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,352516,356965);
}
		}

[Fact]
        public static void ForEach_ExtensionGetEnumeratorParamsOnWrongType_IL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(22035,356977,361686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,357089,358141);

string 
il = @"
.class public auto ansi beforefieldinit C extends [mscorlib]System.Object
{
    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        ldarg.0
        call instance void [mscorlib]System.Object::.ctor()
        nop
        ret
    }
}

.class public auto ansi abstract sealed beforefieldinit CExt extends [mscorlib]System.Object
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = (
        01 00 00 00
    )
    .method public hidebysig static 
        class [mscorlib]System.Collections.IEnumerator GetEnumerator (
            class C c,
            int32 i
        ) cil managed 
    {
        .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = (
            01 00 00 00
        )
        .param [2]
            .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = (
                01 00 00 00
            )
        ldnull
        ret
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,358157,358336);

var 
comp = f_22035_358168_358335(@"
public class D
{
    static void M(C c)
    /*<bind>*/{
        foreach (var i in c)
        {
        }
    }/*</bind>*/
}
", il)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,358352,359140);

var 
diagnostics = new DiagnosticDescription[] {
f_22035_358628_358758(f_22035_358628_358738(f_22035_358628_358682(ErrorCode.ERR_NoCorrespondingArgument, "c"), "i", "CExt.GetEnumerator(C, params int)"), 6, 27),
f_22035_359017_359124(f_22035_359017_359104(f_22035_359017_359068(ErrorCode.ERR_ForEachMissingMember, "c"), "C", "GetEnumerator"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,359156,359950);

f_22035_359156_359949(comp, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (va ... }')
    Locals: Local_1: var i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: var i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)", diagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,359966,361675);

f_22035_359966_361674(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
          Children(1):
              IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'c')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                Children(0)
    Next (Regular) Block[B3]
        Entering: {R1}
.locals {R1}
{
    Locals: [var i]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsImplicit) (Syntax: 'var')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                        Children(0)
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(22035,356977,361686);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,356977,361686);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,356977,361686);
}
		}

[Fact]
        public static void ForEach_ExtensionGetEnumeratorNonTrailingDefaultValue_IL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(22035,361698,366362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,361816,362819);

string 
il = @"
.class public auto ansi beforefieldinit C extends [mscorlib]System.Object
{
    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        ldarg.0
        call instance void [mscorlib]System.Object::.ctor()
        nop
        ret
    }
}

.class public auto ansi abstract sealed beforefieldinit CExt extends [mscorlib]System.Object
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = (
        01 00 00 00
    )
    .method public hidebysig static 
        class [mscorlib]System.Collections.IEnumerator GetEnumerator (
            class C c,
            [opt] int32 i1,
            int32 i2
        ) cil managed 
    {
        .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = (
            01 00 00 00
        )
        .param [2] = int32(0)

        ldnull
        ret
    } // end of method CExt::GetEnumerator
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,362835,363014);

var 
comp = f_22035_362846_363013(@"
public class D
{
    static void M(C c)
    /*<bind>*/{
        foreach (var i in c)
        {
        }
    }/*</bind>*/
}
", il)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,363030,363816);

var 
diagnostics = new DiagnosticDescription[] {
f_22035_363305_363434(f_22035_363305_363414(f_22035_363305_363359(ErrorCode.ERR_NoCorrespondingArgument, "c"), "i2", "CExt.GetEnumerator(C, int, int)"), 6, 27),
f_22035_363693_363800(f_22035_363693_363780(f_22035_363693_363744(ErrorCode.ERR_ForEachMissingMember, "c"), "C", "GetEnumerator"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,363832,364626);

f_22035_363832_364625(comp, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'foreach (va ... }')
    Locals: Local_1: var i
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: var i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    NextVariables(0)", diagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,364642,366351);

f_22035_364642_366350(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
          Children(1):
              IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'c')
          Children(1):
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                Children(0)
    Next (Regular) Block[B3]
        Entering: {R1}
.locals {R1}
{
    Locals: [var i]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: var, IsImplicit) (Syntax: 'var')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                  Children(1):
                      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
                        Children(0)
        Next (Regular) Block[B2]
            Leaving: {R1}
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(22035,361698,366362);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,361698,366362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,361698,366362);
}
		}

[Fact]
        public void FlowGraph_NullableSuppressionOnForeachVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22035,366374,375233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,366475,366853);

var 
comp = f_22035_366486_366852(@"
using System.Collections.Generic;
class A
{
    public static void M()
    /*<bind>*/{
        foreach(var s in new A()!)
        {
            _ = s.ToString();
        }
    }/*</bind>*/
}
static class Extensions
{
    public static IEnumerator<string>? GetEnumerator(this A a) => throw null!;
}", options: f_22035_366831_366851())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,366869,368836);

f_22035_366869_368835(comp, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach(var ... }')
    Locals: Local_1: System.String? s
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.String? s) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: A, IsImplicit) (Syntax: 'new A()')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IObjectCreationOperation (Constructor: A..ctor()) (OperationKind.ObjectCreation, Type: A) (Syntax: 'new A()')
            Arguments(0)
            Initializer: 
              null
    Body: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '_ = s.ToString();')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: '_ = s.ToString()')
              Left: 
                IDiscardOperation (Symbol: System.String _) (OperationKind.Discard, Type: System.String) (Syntax: '_')
              Right: 
                IInvocationOperation (virtual System.String System.String.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 's.ToString()')
                  Instance Receiver: 
                    ILocalReferenceOperation: s (OperationKind.LocalReference, Type: System.String) (Syntax: 's')
                  Arguments(0)
    NextVariables(0)
", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035,368852,375222);

f_22035_368852_375221(comp, @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new A()')
              Value: 
                IInvocationOperation (System.Collections.Generic.IEnumerator<System.String>? Extensions.GetEnumerator(this A a)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerator<System.String>?, IsImplicit) (Syntax: 'new A()')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new A()')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: A, IsImplicit) (Syntax: 'new A()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (Identity)
                          Operand: 
                            IObjectCreationOperation (Constructor: A..ctor()) (OperationKind.ObjectCreation, Type: A) (Syntax: 'new A()')
                              Arguments(0)
                              Initializer: 
                                null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IInvocationOperation (virtual System.Boolean System.Collections.IEnumerator.MoveNext()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'new A()')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>?, IsImplicit) (Syntax: 'new A()')
                  Arguments(0)
                Finalizing: {R5}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.String? s]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: 'var')
                      Left: 
                        ILocalReferenceOperation: s (IsDeclaration: True) (OperationKind.LocalReference, Type: System.String?, IsImplicit) (Syntax: 'var')
                      Right: 
                        IPropertyReferenceOperation: System.String System.Collections.Generic.IEnumerator<System.String>.Current { get; } (OperationKind.PropertyReference, Type: System.String, IsImplicit) (Syntax: 'var')
                          Instance Receiver: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>?, IsImplicit) (Syntax: 'new A()')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '_ = s.ToString();')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: '_ = s.ToString()')
                          Left: 
                            IDiscardOperation (Symbol: System.String _) (OperationKind.Discard, Type: System.String) (Syntax: '_')
                          Right: 
                            IInvocationOperation (virtual System.String System.String.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 's.ToString()')
                              Instance Receiver: 
                                ILocalReferenceOperation: s (OperationKind.LocalReference, Type: System.String) (Syntax: 's')
                              Arguments(0)
                Next (Regular) Block[B2]
                    Leaving: {R4}
        }
    }
    .finally {R5}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'new A()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>?, IsImplicit) (Syntax: 'new A()')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'new A()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'new A()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Collections.Generic.IEnumerator<System.String>?, IsImplicit) (Syntax: 'new A()')
                  Arguments(0)
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22035,366374,375233);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22035,366374,375233);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22035,366374,375233);
}
		}

private static readonly string s_ValueTask ;

int
f_22035_3028_3109(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 3028, 3109);
return 0;
}


int
f_22035_5759_5840(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 5759, 5840);
return 0;
}


int
f_22035_11426_11507(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 11426, 11507);
return 0;
}


int
f_22035_14811_14892(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 14811, 14892);
return 0;
}


int
f_22035_18208_18289(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 18208, 18289);
return 0;
}


int
f_22035_20578_20659(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 20578, 20659);
return 0;
}


int
f_22035_27392_27473(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 27392, 27473);
return 0;
}


int
f_22035_29878_29959(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 29878, 29959);
return 0;
}


int
f_22035_35492_35573(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 35492, 35573);
return 0;
}


int
f_22035_38584_38665(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 38584, 38665);
return 0;
}


int
f_22035_39734_39815(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 39734, 39815);
return 0;
}


int
f_22035_41226_41307(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 41226, 41307);
return 0;
}


int
f_22035_43242_43323(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 43242, 43323);
return 0;
}


int
f_22035_44867_44948(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 44867, 44948);
return 0;
}


int
f_22035_46287_46368(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 46287, 46368);
return 0;
}


int
f_22035_47723_47804(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 47723, 47804);
return 0;
}


int
f_22035_49154_49235(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 49154, 49235);
return 0;
}


int
f_22035_51915_51996(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 51915, 51996);
return 0;
}


int
f_22035_53784_53865(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 53784, 53865);
return 0;
}


int
f_22035_55849_55930(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 55849, 55930);
return 0;
}


int
f_22035_60174_60255(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 60174, 60255);
return 0;
}


int
f_22035_62191_62315(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForEachVariableStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 62191, 62315);
return 0;
}


int
f_22035_64717_64841(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForEachVariableStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 64717, 64841);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_66844_66885(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 66844, 66885);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_66844_66905(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 66844, 66905);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67061_67106(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67061, 67106);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67061_67126(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67061, 67126);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67249_67295(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67249, 67295);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67249_67314(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67249, 67314);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67249_67334(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67249, 67334);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67440_67489(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67440, 67489);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67440_67509(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67440, 67509);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67632_67678(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67632, 67678);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67632_67697(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67632, 67697);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67632_67717(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67632, 67717);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67823_67871(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67823, 67871);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67823_67891(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67823, 67891);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67997_68042(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67997, 68042);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_67997_68062(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 67997, 68062);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68168_68217(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68168, 68217);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68168_68237(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68168, 68237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68343_68389(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68343, 68389);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68343_68409(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68343, 68409);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68515_68563(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68515, 68563);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68515_68583(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68515, 68583);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68689_68734(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68689, 68734);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68689_68754(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68689, 68754);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68900_68947(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68900, 68947);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68900_68966(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68900, 68966);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_68900_68986(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 68900, 68986);
return return_v;
}


int
f_22035_69018_69123(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 69018, 69123);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_70586_70632(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 70586, 70632);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_70586_70652(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 70586, 70652);
return return_v;
}


int
f_22035_70684_70789(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 70684, 70789);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_72553_72607(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 72553, 72607);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_72553_72626(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 72553, 72626);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_72553_72646(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 72553, 72646);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_72812_72862(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 72812, 72862);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_72812_72881(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 72812, 72881);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_72812_72901(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 72812, 72901);
return return_v;
}


int
f_22035_72933_73049(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 72933, 73049);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_75637_75683(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 75637, 75683);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_75637_75703(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 75637, 75703);
return return_v;
}


int
f_22035_75735_75859(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForEachVariableStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 75735, 75859);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_78171_78217(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 78171, 78217);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_78171_78237(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 78171, 78237);
return return_v;
}


int
f_22035_78269_78393(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForEachVariableStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 78269, 78393);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_80060_80106(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 80060, 80106);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_80060_80126(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 80060, 80126);
return return_v;
}


int
f_22035_80158_80282(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForEachVariableStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 80158, 80282);
return 0;
}


int
f_22035_82948_83065(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 82948, 83065);
return 0;
}


int
f_22035_85750_85867(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 85750, 85867);
return 0;
}


int
f_22035_87733_87850(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 87733, 87850);
return 0;
}


int
f_22035_91010_91127(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 91010, 91127);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_93847_93957(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 93847, 93957);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_93972_93996(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 93972, 93996);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22035_94011_94090(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<ForEachStatementSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 94011, 94090);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_96829_96939(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 96829, 96939);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_96954_96978(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 96954, 96978);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22035_96993_97072(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<ForEachStatementSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 96993, 97072);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_98957_99067(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 98957, 99067);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_99297_99352(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 99297, 99352);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_99297_99385(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 99297, 99385);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_99297_99405(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 99297, 99405);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_99730_99794(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 99730, 99794);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_99730_99858(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 99730, 99858);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_99730_99878(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 99730, 99878);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_99082_99879(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 99082, 99879);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22035_99894_99973(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<ForEachStatementSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 99894, 99973);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_103187_103297(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 103187, 103297);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_103312_103336(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 103312, 103336);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22035_103351_103430(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<ForEachStatementSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 103351, 103430);
return return_v;
}


int
f_22035_112870_112967(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 112870, 112967);
return 0;
}


int
f_22035_118989_119086(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 118989, 119086);
return 0;
}


int
f_22035_125932_126029(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 125932, 126029);
return 0;
}


int
f_22035_130365_130462(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 130365, 130462);
return 0;
}


int
f_22035_136041_136138(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 136041, 136138);
return 0;
}


int
f_22035_142104_142201(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 142104, 142201);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_22035_146243_146287(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
enabled)
{
var return_v = this_param.WithAllowUnsafe( enabled);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 146243, 146287);
return return_v;
}


int
f_22035_146132_146288(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 146132, 146288);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_22035_150342_150386(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
enabled)
{
var return_v = this_param.WithAllowUnsafe( enabled);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 150342, 150386);
return return_v;
}


int
f_22035_150231_150387(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 150231, 150387);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_22035_154569_154613(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
enabled)
{
var return_v = this_param.WithAllowUnsafe( enabled);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 154569, 154613);
return return_v;
}


int
f_22035_154458_154614(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 154458, 154614);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_22035_158817_158861(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
enabled)
{
var return_v = this_param.WithAllowUnsafe( enabled);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 158817, 158861);
return return_v;
}


int
f_22035_158706_158862(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 158706, 158862);
return 0;
}


int
f_22035_165259_165356(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 165259, 165356);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_166050_166101(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 166050, 166101);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_166050_166143(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 166050, 166143);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_166050_166163(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 166050, 166163);
return return_v;
}


int
f_22035_168861_168958(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 168861, 168958);
return 0;
}


int
f_22035_176431_176528(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 176431, 176528);
return 0;
}


int
f_22035_181539_181636(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 181539, 181636);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_182437_182483(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 182437, 182483);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_182437_182503(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 182437, 182503);
return return_v;
}


int
f_22035_185708_185805(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 185708, 185805);
return 0;
}


int
f_22035_191841_191938(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 191841, 191938);
return 0;
}


int
f_22035_198782_198879(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 198782, 198879);
return 0;
}


int
f_22035_203116_203213(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 203116, 203213);
return 0;
}


int
f_22035_207452_207549(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 207452, 207549);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_208363_208417(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 208363, 208417);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_208363_208437(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 208363, 208437);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_208637_208725(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 208637, 208725);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_208637_208745(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 208637, 208745);
return return_v;
}


int
f_22035_214001_214098(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 214001, 214098);
return 0;
}


int
f_22035_221502_221635(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 221502, 221635);
return 0;
}


int
f_22035_229075_229208(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 229075, 229208);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_230078_230133(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 230078, 230133);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_230078_230166(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 230078, 230166);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_230078_230186(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 230078, 230186);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_230479_230538(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 230479, 230538);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_230479_230597(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 230479, 230597);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_230479_230617(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 230479, 230617);
return return_v;
}


int
f_22035_233064_233197(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 233064, 233197);
return 0;
}


int
f_22035_243077_243210(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 243077, 243210);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_251197_251307(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 251197, 251307);
return return_v;
}


int
f_22035_251322_251417(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 251322, 251417);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_259440_259550(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 259440, 259550);
return return_v;
}


int
f_22035_259565_259660(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 259565, 259660);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_260553_260608(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 260553, 260608);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_260553_260641(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 260553, 260641);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_260553_260661(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 260553, 260661);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_260976_261040(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 260976, 261040);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_260976_261104(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 260976, 261104);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_260976_261124(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 260976, 261124);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_263582_263692(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 263582, 263692);
return return_v;
}


int
f_22035_263707_263802(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 263707, 263802);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_274273_274383(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 274273, 274383);
return return_v;
}


int
f_22035_274398_274493(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 274398, 274493);
return 0;
}


int
f_22035_277155_277271(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<ForEachStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 277155, 277271);
return 0;
}


int
f_22035_284692_284824(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 284692, 284824);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_285900_285980(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 285900, 285980);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_285900_286046(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 285900, 286046);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_285900_286066(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 285900, 286066);
return return_v;
}


int
f_22035_288901_288998(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 288901, 288998);
return 0;
}


int
f_22035_290858_290928(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BlockSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 290858, 290928);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_291229_291814(string
source,Roslyn.Test.Utilities.TargetFramework
targetFramework)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, targetFramework:targetFramework);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 291229, 291814);
return return_v;
}


int
f_22035_291831_293053(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 291831, 293053);
return 0;
}


int
f_22035_293070_297132(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 293070, 297132);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_297463_298074(string
source,Roslyn.Test.Utilities.TargetFramework
targetFramework)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, targetFramework:targetFramework);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 297463, 298074);
return return_v;
}


int
f_22035_298091_299313(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 298091, 299313);
return 0;
}


int
f_22035_299330_303819(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 299330, 303819);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_304115_304572(string
source,Roslyn.Test.Utilities.TargetFramework
targetFramework)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, targetFramework:targetFramework);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 304115, 304572);
return return_v;
}


int
f_22035_304589_305781(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 304589, 305781);
return 0;
}


int
f_22035_305798_309783(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 305798, 309783);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_310082_310522(string
source,Roslyn.Test.Utilities.TargetFramework
targetFramework)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, targetFramework:targetFramework);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 310082, 310522);
return return_v;
}


int
f_22035_310539_311731(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 310539, 311731);
return 0;
}


int
f_22035_311748_315327(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 311748, 315327);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_315906_316010(string[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 315906, 316010);
return return_v;
}


int
f_22035_316025_317746(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,string
expectedOperationTree)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedDiagnostics:expectedDiagnostics, expectedOperationTree:expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 316025, 317746);
return 0;
}


int
f_22035_317763_323908(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 317763, 323908);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_324135_324623(string
source,Roslyn.Test.Utilities.TargetFramework
targetFramework)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, targetFramework:targetFramework);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 324135, 324623);
return return_v;
}


int
f_22035_324640_325832(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 324640, 325832);
return 0;
}


int
f_22035_325849_331923(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 325849, 331923);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_332662_332768(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithMscorlib46( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 332662, 332768);
return return_v;
}


int
f_22035_332783_334957(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 332783, 334957);
return 0;
}


int
f_22035_334974_340739(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 334974, 340739);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_340871_341253(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 340871, 341253);
return return_v;
}


int
f_22035_341270_342358(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 341270, 342358);
return 0;
}


int
f_22035_342375_348275(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 342375, 348275);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_348412_348812(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 348412, 348812);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_349114_349168(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349114, 349168);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_349114_349233(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349114, 349233);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_349114_349253(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349114, 349253);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_349512_349563(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349512, 349563);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_349512_349599(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349512, 349599);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_349512_349619(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349512, 349619);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_349865_349921(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349865, 349921);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_349865_349942(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349865, 349942);
return return_v;
}


int
f_22035_349974_350767(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 349974, 350767);
return 0;
}


int
f_22035_350784_352492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 350784, 352492);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_352631_353020(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 352631, 353020);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_353313_353367(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 353313, 353367);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_353313_353423(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 353313, 353423);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_353313_353443(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 353313, 353443);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_353702_353753(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 353702, 353753);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_353702_353789(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 353702, 353789);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_353702_353809(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 353702, 353809);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_354027_354080(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 354027, 354080);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_354027_354101(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 354027, 354101);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_354316_354382(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 354316, 354382);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_354316_354403(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 354316, 354403);
return return_v;
}


int
f_22035_354435_355228(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 354435, 355228);
return 0;
}


int
f_22035_355245_356953(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 355245, 356953);
return 0;
}


static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_358168_358335(string
source,string
ilSource)
{
var return_v = CreateCompilationWithIL( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 358168, 358335);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_358628_358682(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 358628, 358682);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_358628_358738(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 358628, 358738);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_358628_358758(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 358628, 358758);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_359017_359068(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 359017, 359068);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_359017_359104(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 359017, 359104);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_359017_359124(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 359017, 359124);
return return_v;
}


static int
f_22035_359156_359949(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 359156, 359949);
return 0;
}


static int
f_22035_359966_361674(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 359966, 361674);
return 0;
}


static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_362846_363013(string
source,string
ilSource)
{
var return_v = CreateCompilationWithIL( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 362846, 363013);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_363305_363359(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 363305, 363359);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_363305_363414(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 363305, 363414);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_363305_363434(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 363305, 363434);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_363693_363744(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 363693, 363744);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_363693_363780(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 363693, 363780);
return return_v;
}


static Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22035_363693_363800(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 363693, 363800);
return return_v;
}


static int
f_22035_363832_364625(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 363832, 364625);
return 0;
}


static int
f_22035_364642_366350(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 364642, 366350);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_22035_366831_366851()
{
var return_v = WithNullableEnable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 366831, 366851);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22035_366486_366852(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 366486, 366852);
return return_v;
}


int
f_22035_366869_368835(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 366869, 368835);
return 0;
}


int
f_22035_368852_375221(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22035, 368852, 375221);
return 0;
}

}
}
