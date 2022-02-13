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
        [Fact]
        public void DelegateCreationExpression_ImplicitLambdaConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,554,2298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,713,854);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = () => { };/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,868,2078);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'Action a = () => { };')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Action a = () => { }')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a = () => { }')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= () => { }')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsImplicit) (Syntax: '() => { }')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => { }')
                    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
                      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{ }')
                        ReturnedValue: 
                          null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,2092,2145);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,2161,2287);

f_22024_2161_2286(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,554,2298);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,554,2298);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,554,2298);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitLambdaConversion_InitializerBindingReturnsJustAnonymousFunction()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,2310,3250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,2516,2657);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/() => { }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,2671,3039);

string 
expectedOperationTree = @"
IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => { }')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{ }')
      ReturnedValue: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,3053,3106);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,3122,3239);

f_22024_3122_3238(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,2310,3250);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,2310,3250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,2310,3250);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitLambdaConversion_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,3262,5715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,3439,3578);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = () => 1;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,3592,5189);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action a = () => 1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action a = () => 1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a = () => 1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= () => 1')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid, IsImplicit) (Syntax: '() => 1')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => 1')
                    IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                        Expression: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
                      IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                        ReturnedValue: 
                          null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,5203,5562);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_5479_5546(f_22024_5479_5526(ErrorCode.ERR_IllegalStatement, "1"), 7, 36)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,5578,5704);

f_22024_5578_5703(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,3262,5715);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,3262,5715);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,3262,5715);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitLambdaConversion_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,5727,7728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,5906,6052);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = (int i) => { };/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,6066,7210);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action a =  ...  i) => { };')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action a =  ... t i) => { }')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a = (int i) => { }')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (int i) => { }')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid, IsImplicit) (Syntax: '(int i) => { }')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '(int i) => { }')
                    IBlockOperation (0 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,7224,7575);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_7445_7559(f_22024_7445_7539(f_22024_7445_7503(ErrorCode.ERR_BadDelArgCount, "(int i) => { }"), "System.Action", "1"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,7591,7717);

f_22024_7591_7716(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,5727,7728);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,5727,7728);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,5727,7728);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitLambdaConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,7740,8787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,7899,8050);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/(Action)(() => { })/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,8064,8578);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: '(Action)(() => { })')
  Target: 
    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => { }')
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
        IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{ }')
          ReturnedValue: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,8592,8645);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,8661,8776);

f_22024_8661_8775(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,7740,8787);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,7740,8787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,7740,8787);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitLambdaConversion_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,8799,10487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,8976,9125);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/(Action)(() => 1)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,9139,9962);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)(() => 1)')
  Target: 
    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => 1')
      IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
          Expression: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
        IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
          ReturnedValue: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,9976,10345);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_10262_10329(f_22024_10262_10309(ErrorCode.ERR_IllegalStatement, "1"), 7, 45)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,10361,10476);

f_22024_10361_10475(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,8799,10487);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,8799,10487);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,8799,10487);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitLambdaConversion_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,10499,11788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,10678,10834);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/(Action)((int i) => { })/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,10848,11271);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)((int i) => { })')
  Target: 
    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '(int i) => { }')
      IBlockOperation (0 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,11285,11646);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_11516_11630(f_22024_11516_11610(f_22024_11516_11574(ErrorCode.ERR_BadDelArgCount, "(int i) => { }"), "System.Action", "1"), 7, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,11662,11777);

f_22024_11662_11776(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,10499,11788);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,10499,11788);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,10499,11788);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_DelegateExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,11800,13576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,11953,12099);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = delegate() { };/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,12113,13356);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'Action a =  ... gate() { };')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Action a =  ... egate() { }')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a = delegate() { }')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= delegate() { }')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsImplicit) (Syntax: 'delegate() { }')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: 'delegate() { }')
                    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
                      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{ }')
                        ReturnedValue: 
                          null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,13370,13423);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,13439,13565);

f_22024_13439_13564(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,11800,13576);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,11800,13576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,11800,13576);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_DelegateExpression_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,13588,15919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,13759,13915);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = delegate() { return 1; };/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,13929,15388);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action a =  ... eturn 1; };')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action a =  ... return 1; }')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a = delegat ... return 1; }')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= delegate( ... return 1; }')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid, IsImplicit) (Syntax: 'delegate() { return 1; }')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: 'delegate() { return 1; }')
                    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ return 1; }')
                      IReturnOperation (OperationKind.Return, Type: null, IsInvalid) (Syntax: 'return 1;')
                        ReturnedValue: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,15402,15766);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_15669_15750(f_22024_15669_15730(ErrorCode.ERR_RetNoObjectRequiredLambda, "return"), 7, 43)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,15782,15908);

f_22024_15782_15907(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,13588,15919);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,13588,15919);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,13588,15919);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_DelegateExpression_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,15931,17961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,16104,16255);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = delegate(int i) { };/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,16269,17433);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action a =  ... int i) { };')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action a =  ... (int i) { }')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a = delegate(int i) { }')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= delegate(int i) { }')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid, IsImplicit) (Syntax: 'delegate(int i) { }')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: 'delegate(int i) { }')
                    IBlockOperation (0 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,17447,17808);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_17673_17792(f_22024_17673_17772(f_22024_17673_17736(ErrorCode.ERR_BadDelArgCount, "delegate(int i) { }"), "System.Action", "1"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,17824,17950);

f_22024_17824_17949(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,15931,17961);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,15931,17961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,15931,17961);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,17973,19601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,18129,18282);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = M1;/*</bind>*/
    }
    void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,18296,19381);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'Action a = M1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Action a = M1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a = M1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= M1')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsImplicit) (Syntax: 'M1')
                Target: 
                  IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
                    Instance Receiver: 
                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsImplicit) (Syntax: 'M1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,19395,19448);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,19464,19590);

f_22024_19464_19589(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,17973,19601);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,17973,19601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,17973,19601);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(15513, "https://github.com/dotnet/roslyn/issues/15513")]
        public void DelegateCreationExpression_ImplicitMethodBinding_InitializerBindingReturnsJustMethodReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,19613,20459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,19890,20050);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/M1/*</bind>*/;
    }
    static void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,20066,20250);

string 
expectedOperationTree = @"
IMethodReferenceOperation: void Program.M1() (Static) (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
  Instance Receiver: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,20264,20317);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,20333,20448);

f_22024_20333_20447(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,19613,20459);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,19613,20459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,19613,20459);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding_InvalidIdentifier()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,20471,22398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,20645,20779);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = M1;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,20793,21910);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action a = M1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action a = M1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a = M1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= M1')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action, IsInvalid, IsImplicit) (Syntax: 'M1')
                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M1')
                    Children(0)
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,21924,22245);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_22141_22229(f_22024_22141_22209(f_22024_22141_22189(ErrorCode.ERR_NameNotInContext, "M1"), "M1"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,22261,22387);

f_22024_22261_22386(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,20471,22398);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,20471,22398);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,20471,22398);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding_InvalidIdentifier_InitializerBindingReturnsJustInvalidExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,22410,23401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,22631,22765);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/M1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,22781,22911);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M1')
  Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,22925,23259);

var 
expectedDiagnostics = new DiagnosticDescription[]
            {
f_22024_23155_23243(f_22024_23155_23223(f_22024_23155_23203(ErrorCode.ERR_NameNotInContext, "M1"), "M1"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,23275,23390);

f_22024_23275_23389(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,22410,23401);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,22410,23401);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,22410,23401);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,23413,25495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,23587,23741);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = M1;/*</bind>*/
    }
    int M1() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,23755,24925);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action a = M1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action a = M1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a = M1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= M1')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid, IsImplicit) (Syntax: 'M1')
                Target: 
                  IMethodReferenceOperation: System.Int32 Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
                    Instance Receiver: 
                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,24939,25264);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_25149_25248(f_22024_25149_25228(f_22024_25149_25191(ErrorCode.ERR_BadRetType, "M1"), "Program.M1()", "int"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,25280,25484);

f_22024_25280_25483(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.WithoutImprovedOverloadCandidates);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,23413,25495);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,23413,25495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,23413,25495);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding_InvalidReturnType_InitializerBindingReturnsJustMethodReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,25507,27322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,25726,25880);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/M1/*</bind>*/;
    }
    int M1() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,25896,26655);

f_22024_25896_26654(source, @"
IMethodReferenceOperation: System.Int32 Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
", new DiagnosticDescription[]
            {
f_22024_26478_26577(f_22024_26478_26557(f_22024_26478_26520(ErrorCode.ERR_BadRetType, "M1"), "Program.M1()", "int"), 7, 30)            }, parseOptions: TestOptions.WithoutImprovedOverloadCandidates);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,26669,27311);

f_22024_26669_27310(source, @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
  Children(1):
      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
", new DiagnosticDescription[]
            {
f_22024_27195_27294(f_22024_27195_27274(f_22024_27195_27237(ErrorCode.ERR_BadRetType, "M1"), "Program.M1()", "int"), 7, 30)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,25507,27322);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,25507,27322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,25507,27322);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,27334,29303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,27510,27671);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action a = M1;/*</bind>*/
    }
    void M1(object o) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,27685,28799);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action a = M1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action a = M1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action a) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a = M1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= M1')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid, IsImplicit) (Syntax: 'M1')
                Target: 
                  IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
                    Children(1):
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,28813,29150);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_29025_29134(f_22024_29025_29114(f_22024_29025_29077(ErrorCode.ERR_MethDelegateMismatch, "M1"), "M1", "System.Action"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,29166,29292);

f_22024_29166_29291(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,27334,29303);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,27334,29303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,27334,29303);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding_InvalidArgumentType_InitializerBindingReturnsJustNoneOperation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,29315,30505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,29534,29695);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/M1/*</bind>*/;
    }
    void M1(object o) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,29711,29999);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
  Children(1):
      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,30013,30363);

var 
expectedDiagnostics = new DiagnosticDescription[]
            {
f_22024_30238_30347(f_22024_30238_30327(f_22024_30238_30290(ErrorCode.ERR_MethDelegateMismatch, "M1"), "M1", "System.Action"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,30379,30494);

f_22024_30379_30493(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,29315,30505);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,29315,30505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,29315,30505);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitMethodBinding()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,30517,31500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,30673,30834);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/(Action)M1/*</bind>*/;
    }
    void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,30848,31291);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: '(Action)M1')
  Target: 
    IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,31305,31358);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,31374,31489);

f_22024_31374_31488(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,30517,31500);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,30517,31500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,30517,31500);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitMethodBinding_InvalidIdentifier()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,31512,32758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,31686,31828);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/(Action)M1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,31842,32273);

string 
expectedOperationTree = @"
IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Operand: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M1')
      Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,32287,32616);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_32512_32600(f_22024_32512_32580(f_22024_32512_32560(ErrorCode.ERR_NameNotInContext, "M1"), "M1"), 7, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,32632,32747);

f_22024_32632_32746(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,31512,32758);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,31512,32758);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,31512,32758);
}
		}

[Fact]
        public void DelegateCreationExpression_ExplicitMethodBinding_InvalidIdentifierWithReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,32770,34286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,32903,33081);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        object o = new object();
        Action a = /*<bind>*/(Action)o.M1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,33095,33636);

string 
expectedOperationTree = @"
IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action, IsInvalid) (Syntax: '(Action)o.M1')
  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Operand: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'o.M1')
      Children(1):
          ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,33650,34144);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_34023_34128(f_22024_34023_34108(f_22024_34023_34078(ErrorCode.ERR_NoSuchMemberOrExtension, "M1"), "object", "M1"), 8, 40)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,34160,34275);

f_22024_34160_34274(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,32770,34286);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,32770,34286);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,32770,34286);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitMethodBinding_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,34298,35720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,34472,34634);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/(Action)M1/*</bind>*/;
    }
    int M1() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,34648,35132);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
  Target: 
    IMethodReferenceOperation: System.Int32 Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,35146,35500);

var 
expectedDiagnostics = new DiagnosticDescription[]
            {
f_22024_35377_35484(f_22024_35377_35464(f_22024_35377_35427(ErrorCode.ERR_BadRetType, "(Action)M1"), "Program.M1()", "int"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,35516,35709);

f_22024_35516_35708(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.WithoutImprovedOverloadCandidates);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,34298,35720);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,34298,35720);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,34298,35720);
}
		}

[Fact]
        public void DelegateCreationExpression_ExplicitMethodBinding_InvalidReturnTypeWithReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,35732,37729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,35865,36065);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Program p = new Program();
        Action a = /*<bind>*/(Action)p.M1/*</bind>*/;
    }
    int M1() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,36079,36954);

f_22024_36079_36953(source, @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)p.M1')
  Target: 
    IMethodReferenceOperation: System.Int32 Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'p.M1')
      Instance Receiver: 
        ILocalReferenceOperation: p (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'p')
", new DiagnosticDescription[] {
f_22024_36767_36876(f_22024_36767_36856(f_22024_36767_36819(ErrorCode.ERR_BadRetType, "(Action)p.M1"), "Program.M1()", "int"), 8, 30)            }, parseOptions: TestOptions.WithoutImprovedOverloadCandidates);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,36968,37718);

f_22024_36968_37717(source, @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)p.M1')
  Target: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'p.M1')
      Children(1):
          ILocalReferenceOperation: p (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'p')
", new DiagnosticDescription[] {
f_22024_37600_37701(f_22024_37600_37681(f_22024_37600_37644(ErrorCode.ERR_BadRetType, "p.M1"), "Program.M1()", "int"), 8, 38)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,35732,37729);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,35732,37729);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,35732,37729);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitMethodBinding_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,37741,39071);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,37917,38086);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/(Action)M1/*</bind>*/;
    }
    void M1(object o) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,38100,38528);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
  Target: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
      Children(1):
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,38542,38929);

var 
expectedDiagnostics = new DiagnosticDescription[]
            {
f_22024_38796_38913(f_22024_38796_38893(f_22024_38796_38856(ErrorCode.ERR_MethDelegateMismatch, "(Action)M1"), "M1", "System.Action"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,38945,39060);

f_22024_38945_39059(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,37741,39071);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,37741,39071);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,37741,39071);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitMethodBinding_InvalidArgumentTypeWithReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,39083,40402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,39271,39478);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Program p = new Program();
        Action a = /*<bind>*/(Action)p.M1/*</bind>*/;
    }
    void M1(object o) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,39492,39868);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)p.M1')
  Target: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'p.M1')
      Children(1):
          ILocalReferenceOperation: p (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'p')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,39882,40260);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_40125_40244(f_22024_40125_40224(f_22024_40125_40187(ErrorCode.ERR_MethDelegateMismatch, "(Action)p.M1"), "M1", "System.Action"), 8, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,40276,40391);

f_22024_40276_40390(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,39083,40402);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,39083,40402);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,39083,40402);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitLambdaConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,40414,41505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,40603,40756);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action(() => { })/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,40770,41286);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action(() => { })')
  Target: 
    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => { }')
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
        IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{ }')
          ReturnedValue: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,41300,41353);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,41369,41494);

f_22024_41369_41493(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,40414,41505);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,40414,41505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,40414,41505);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitLambdaConversion_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,41517,43251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,41724,41875);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action(() => 1)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,41889,42714);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action(() => 1)')
  Target: 
    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => 1')
      IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
          Expression: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
        IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
          ReturnedValue: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,42728,43099);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_43016_43083(f_22024_43016_43063(ErrorCode.ERR_IllegalStatement, "1"), 7, 47)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,43115,43240);

f_22024_43115_43239(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,41517,43251);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,41517,43251);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,41517,43251);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitLambdaConversion_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,43263,44744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,43472,43630);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action((int i) => { })/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,43644,44215);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action( ...  i) => { })')
  Target: 
    IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '(int i) => { }')
      IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
        IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '{ }')
          ReturnedValue: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,44229,44592);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_44462_44576(f_22024_44462_44556(f_22024_44462_44520(ErrorCode.ERR_BadDelArgCount, "(int i) => { }"), "System.Action", "1"), 7, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,44608,44733);

f_22024_44608_44732(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,43263,44744);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,43263,44744);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,43263,44744);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitLambdaConversion_InvalidMultipleParameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,44756,46281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,44971,45138);

string 
source = @"
using System;

class C
{
    void M1()
    {
        Action action = /*<bind>*/new Action((o) => { }, new object())/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,45152,45782);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action, IsInvalid) (Syntax: 'new Action( ... w object())')
  Children(2):
      IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '(o) => { }')
        IBlockOperation (0 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
      IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object, IsInvalid) (Syntax: 'new object()')
        Arguments(0)
        Initializer: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,45796,46129);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_46021_46113(f_22024_46021_46093(ErrorCode.ERR_MethodNameExpected, "(o) => { }, new object()"), 8, 46)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,46145,46270);

f_22024_46145_46269(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,44756,46281);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,44756,46281);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,44756,46281);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitMethodBindingConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,46293,47341);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,46489,46661);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action(M1)/*</bind>*/;
    }

    void M1()
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,46675,47122);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action(M1)')
  Target: 
    IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,47136,47189);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,47205,47330);

f_22024_47205_47329(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,46293,47341);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,46293,47341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,46293,47341);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(15513, "https://github.com/dotnet/roslyn/issues/15513")]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitStaticMethodBindingConversion_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,47353,48363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,47634,47813);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action(M1)/*</bind>*/;
    }

    static void M1()
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,47827,48144);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action(M1)')
  Target: 
    IMethodReferenceOperation: void Program.M1() (Static) (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
      Instance Receiver: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,48158,48211);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,48227,48352);

f_22024_48227_48351(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,47353,48363);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,47353,48363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,47353,48363);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(15513, "https://github.com/dotnet/roslyn/issues/15513")]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitStaticMethodBindingConversion_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,48375,49879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,48656,48840);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action(this.M1)/*</bind>*/;
    }

    static void M1()
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,48854,49286);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action(this.M1)')
  Target: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'this.M1')
      Children(1):
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid) (Syntax: 'this')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,49300,49727);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_49608_49711(f_22024_49608_49691(f_22024_49608_49661(ErrorCode.ERR_ObjectProhibited, "this.M1"), "Program.M1()"), 7, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,49743,49868);

f_22024_49743_49867(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,48375,49879);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,48375,49879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,48375,49879);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitMethodBindingConversionWithReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,49891,50928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,50099,50300);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        var p = new Program();
        Action a = /*<bind>*/new Action(p.M1)/*</bind>*/;
    }

    void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,50314,50709);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action(p.M1)')
  Target: 
    IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null) (Syntax: 'p.M1')
      Instance Receiver: 
        ILocalReferenceOperation: p (OperationKind.LocalReference, Type: Program) (Syntax: 'p')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,50723,50776);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,50792,50917);

f_22024_50792_50916(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,49891,50928);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,49891,50928);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,49891,50928);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitMethodBindingConversion_InvalidMissingIdentifier()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,50940,52080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,51161,51307);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action(M1)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,51321,51581);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action, IsInvalid) (Syntax: 'new Action(M1)')
  Children(1):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M1')
        Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,51595,51928);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_51824_51912(f_22024_51824_51892(f_22024_51824_51872(ErrorCode.ERR_NameNotInContext, "M1"), "M1"), 7, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,51944,52069);

f_22024_51944_52068(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,50940,52080);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,50940,52080);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,50940,52080);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitMethodBindingConversion_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,52092,54241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,52306,52474);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action(M1)/*</bind>*/;
    }

    int M1() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,52488,53400);

f_22024_52488_53399(source, @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action(M1)')
  Target: 
    IMethodReferenceOperation: System.Int32 Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
", new DiagnosticDescription[] {
f_22024_53223_53322(f_22024_53223_53302(f_22024_53223_53265(ErrorCode.ERR_BadRetType, "M1"), "Program.M1()", "int"), 7, 41)            }, parseOptions: TestOptions.WithoutImprovedOverloadCandidates);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,53414,54230);

f_22024_53414_54229(source, @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action(M1)')
  Target: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
      Children(1):
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
", new DiagnosticDescription[] {
f_22024_54114_54213(f_22024_54114_54193(f_22024_54114_54156(ErrorCode.ERR_BadRetType, "M1"), "Program.M1()", "int"), 7, 41)            });
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,52092,54241);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,52092,54241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,52092,54241);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndImplicitMethodBindingConversion_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,54253,55622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,54469,54649);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action(M1)/*</bind>*/;
    }

    void M1(object o)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,54663,55095);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action(M1)')
  Target: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
      Children(1):
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,55109,55470);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_55333_55454(f_22024_55333_55434(f_22024_55333_55397(ErrorCode.ERR_MethDelegateMismatch, "new Action(M1)"), "M1", "System.Action"), 7, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,55486,55611);

f_22024_55486_55610(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,54253,55622);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,54253,55622);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,54253,55622);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateCreation_InvalidMultipleParameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,55634,57190);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,55819,56028);

string 
source = @"
using System;

class C
{
    void M1()
    {
        Action action = /*<bind>*/new Action(M2, M3)/*</bind>*/;
    }

    void M2()
    {
    }
    void M3()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,56042,56727);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action, IsInvalid) (Syntax: 'new Action(M2, M3)')
  Children(2):
      IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M2')
        Children(1):
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M2')
      IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M3')
        Children(1):
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M3')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,56741,57038);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_56948_57022(f_22024_56948_57002(ErrorCode.ERR_MethodNameExpected, "M2, M3"), 8, 46)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,57054,57179);

f_22024_57054_57178(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,55634,57190);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,55634,57190);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,55634,57190);
}
		}

[Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorImplicitMethodBinding_InvalidTargetArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,57202,58599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,57355,57530);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action<string> a = /*<bind>*/new Action(M1)/*</bind>*/;
    }

    void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,57544,58024);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action(M1)')
  Target: 
    IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,58038,58447);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_58297_58431(f_22024_58297_58411(f_22024_58297_58355(ErrorCode.ERR_NoImplicitConv, "new Action(M1)"), "System.Action", "System.Action<string>"), 7, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,58463,58588);

f_22024_58463_58587(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,57202,58599);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,57202,58599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,57202,58599);
}
		}

[Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorImplicitMethodBinding_InvalidTargetReturn()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,58611,59997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,58761,58934);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Func<string> a = /*<bind>*/new Action(M1)/*</bind>*/;
    }

    void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,58948,59428);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action(M1)')
  Target: 
    IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,59442,59845);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_59697_59829(f_22024_59697_59809(f_22024_59697_59755(ErrorCode.ERR_NoImplicitConv, "new Action(M1)"), "System.Action", "System.Func<string>"), 7, 36)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,59861,59986);

f_22024_59861_59985(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,58611,59997);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,58611,59997);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,58611,59997);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitLambdaConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,60009,61270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,60198,60361);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action((Action)(() => { }))/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,60375,61051);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action( ... () => { }))')
  Target: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: '(Action)(() => { })')
      Target: 
        IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => { }')
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
            IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{ }')
              ReturnedValue: 
                null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,61065,61118);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,61134,61259);

f_22024_61134_61258(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,60009,61270);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,60009,61270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,60009,61270);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitLambdaConversion_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,61282,63225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,61489,61650);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action((Action)(() => 1))/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,61664,62678);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action, IsInvalid) (Syntax: 'new Action( ... )(() => 1))')
  Children(1):
      IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)(() => 1)')
        Target: 
          IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => 1')
            IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
              IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                Expression: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
              IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '1')
                ReturnedValue: 
                  null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,62692,63073);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_62990_63057(f_22024_62990_63037(ErrorCode.ERR_IllegalStatement, "1"), 7, 56)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,63089,63214);

f_22024_63089_63213(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,61282,63225);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,61282,63225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,61282,63225);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitLambdaConversion_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,63237,64745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,63446,63614);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action((Action)((int i) => { }))/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,63628,64206);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action, IsInvalid) (Syntax: 'new Action( ... i) => { }))')
  Children(1):
      IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)((int i) => { })')
        Target: 
          IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '(int i) => { }')
            IBlockOperation (0 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,64220,64593);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_64463_64577(f_22024_64463_64557(f_22024_64463_64521(ErrorCode.ERR_BadDelArgCount, "(int i) => { }"), "System.Action", "1"), 7, 50)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,64609,64734);

f_22024_64609_64733(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,63237,64745);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,63237,64745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,63237,64745);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitMethodBindingConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,64757,65950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,64953,65125);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action((Action)M1)/*</bind>*/;
    }
    void M1() {}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,65139,65731);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action((Action)M1)')
  Target: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: '(Action)M1')
      Target: 
        IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,65745,65798);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,65814,65939);

f_22024_65814_65938(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,64757,65950);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,64757,65950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,64757,65950);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitMethodBindingConversion_InvalidMissingIdentifier()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,65962,67445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,66183,66337);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action((Action)M1)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,66351,66938);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action, IsInvalid) (Syntax: 'new Action((Action)M1)')
  Children(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M1')
            Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,66952,67293);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_67189_67277(f_22024_67189_67257(f_22024_67189_67237(ErrorCode.ERR_NameNotInContext, "M1"), "M1"), 7, 49)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,67309,67434);

f_22024_67309_67433(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,65962,67445);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,65962,67445);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,65962,67445);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitMethodBindingConversion_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,67457,69096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,67671,67845);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action((Action)M1)/*</bind>*/;
    }
    int M1() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,67859,68499);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action, IsInvalid) (Syntax: 'new Action((Action)M1)')
  Children(1):
      IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
        Target: 
          IMethodReferenceOperation: System.Int32 Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,68513,68866);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_68743_68850(f_22024_68743_68830(f_22024_68743_68793(ErrorCode.ERR_BadRetType, "(Action)M1"), "Program.M1()", "int"), 7, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,68882,69085);

f_22024_68882_69084(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.WithoutImprovedOverloadCandidates);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,67457,69096);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,67457,69096);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,67457,69096);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitMethodBindingConversion_InvalidArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,69108,70652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,69324,69502);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action a = /*<bind>*/new Action((Action)M1)/*</bind>*/;
    }
    void M1(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,69516,70100);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action, IsInvalid) (Syntax: 'new Action((Action)M1)')
  Children(1):
      IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
        Target: 
          IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
            Children(1):
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,70114,70500);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_70367_70484(f_22024_70367_70464(f_22024_70367_70427(ErrorCode.ERR_MethDelegateMismatch, "(Action)M1"), "M1", "System.Action"), 7, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,70516,70641);

f_22024_70516_70640(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,69108,70652);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,69108,70652);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,69108,70652);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitMethodBindingConversion_InvalidTargetArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,70664,72306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,70882,71065);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action<string> a = /*<bind>*/new Action((Action)M1)/*</bind>*/;
    }

    void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,71079,71715);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action((Action)M1)')
  Target: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
      Target: 
        IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,71729,72154);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_71996_72138(f_22024_71996_72118(f_22024_71996_72062(ErrorCode.ERR_NoImplicitConv, "new Action((Action)M1)"), "System.Action", "System.Action<string>"), 7, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,72170,72295);

f_22024_72170_72294(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,70664,72306);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,70664,72306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,70664,72306);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitMethodBindingConversion_InvalidTargetReturn()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,72318,73950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,72534,72715);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Func<string> a = /*<bind>*/new Action((Action)M1)/*</bind>*/;
    }

    void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,72729,73365);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: 'new Action((Action)M1)')
  Target: 
    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
      Target: 
        IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,73379,73798);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_73642_73782(f_22024_73642_73762(f_22024_73642_73708(ErrorCode.ERR_NoImplicitConv, "new Action((Action)M1)"), "System.Action", "System.Func<string>"), 7, 36)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,73814,73939);

f_22024_73814_73938(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,72318,73950);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,72318,73950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,72318,73950);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorAndExplicitMethodBindingConversion_InvalidConstructorArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,73962,75657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,74185,74370);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action<int> a = /*<bind>*/new Action<int>((Action)M1)/*</bind>*/;
    }

    void M1() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,74384,75035);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Action<System.Int32>, IsInvalid) (Syntax: 'new Action< ... (Action)M1)')
  Children(1):
      IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)M1')
        Target: 
          IMethodReferenceOperation: void Program.M1() (OperationKind.MethodReference, Type: null, IsInvalid) (Syntax: 'M1')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,75049,75505);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_75330_75489(f_22024_75330_75469(f_22024_75330_75407(ErrorCode.ERR_MethDelegateMismatch, "new Action<int>((Action)M1)"), "System.Action.Invoke()", "System.Action<int>"), 7, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,75521,75646);

f_22024_75521_75645(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,73962,75657);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,73962,75657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,73962,75657);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ConversionExpression_Implicit_ReferenceLambdaToDelegateConversion_InvalidSyntax()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,75669,77766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,75856,76006);

string 
source = @"
class Program
{
    delegate void DType();
    void Main()
    {
        DType /*<bind>*/d1 = () =>/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,76020,77222);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: Program.DType d1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'd1 = () =>/*</bind>*/')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= () =>/*</bind>*/')
      IDelegateCreationOperation (OperationKind.DelegateCreation, Type: Program.DType, IsInvalid, IsImplicit) (Syntax: '() =>/*</bind>*/')
        Target: 
          IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() =>/*</bind>*/')
            IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: '')
              IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: '')
                Expression: 
                  IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                    Children(0)
              IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '')
                ReturnedValue: 
                  null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,77236,77533);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_77432_77517(f_22024_77432_77497(f_22024_77432_77478(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 7, 46)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,77549,77755);

f_22024_77549_77754(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: f_22024_77718_77746().Verify);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,75669,77766);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,75669,77766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,75669,77766);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding_MultipleCandidates_InvalidNoMatch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,77778,79863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,77968,78162);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action<int> a = M1;/*</bind>*/
    }
    void M1(Program o) { }
    void M1(string s) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,78176,79328);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action<int> a = M1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action<int> a = M1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action<System.Int32> a) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'a = M1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= M1')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Int32>, IsInvalid, IsImplicit) (Syntax: 'M1')
                Target: 
                  IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
                    Children(1):
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,79342,79710);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_79580_79694(f_22024_79580_79674(f_22024_79580_79632(ErrorCode.ERR_MethDelegateMismatch, "M1"), "M1", "System.Action<int>"), 7, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,79726,79852);

f_22024_79726_79851(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,77778,79863);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,77778,79863);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,77778,79863);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ImplicitMethodBinding_MultipleCandidates()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,79875,81611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,80050,80240);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        /*<bind>*/Action<int> a = M1;/*</bind>*/
    }
    void M1(object o) { }
    void M1(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,80254,81391);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'Action<int> a = M1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Action<int> a = M1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action<System.Int32> a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a = M1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= M1')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Int32>, IsImplicit) (Syntax: 'M1')
                Target: 
                  IMethodReferenceOperation: void Program.M1(System.Int32 i) (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
                    Instance Receiver: 
                      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsImplicit) (Syntax: 'M1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,81405,81458);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,81474,81600);

f_22024_81474_81599(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,79875,81611);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,79875,81611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,79875,81611);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorImplicitMethodBinding_MultipleCandidates()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,81623,82763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,81825,82045);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action<string> a = /*<bind>*/new Action<string>(M1)/*</bind>*/;
    }

    void M1(object o) { }

    void M1(string s) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,82059,82544);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.String>) (Syntax: 'new Action<string>(M1)')
  Target: 
    IMethodReferenceOperation: void Program.M1(System.String s) (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,82558,82611);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,82627,82752);

f_22024_82627_82751(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,81623,82763);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,81623,82763);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,81623,82763);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DelegateCreationExpression_ExplicitDelegateConstructorImplicitMethodBinding_MultipleCandidates_InvalidNoMatch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,82775,84240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,82992,83207);

string 
source = @"
using System;
class Program
{
    void Main()
    {
        Action<int> a = /*<bind>*/new Action<int>(M1)/*</bind>*/;
    }

    void M1(Program o) { }

    void M1(string s) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,83221,83672);

string 
expectedOperationTree = @"
IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Int32>, IsInvalid) (Syntax: 'new Action<int>(M1)')
  Target: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
      Children(1):
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Program, IsInvalid, IsImplicit) (Syntax: 'M1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,83686,84088);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22024_83941_84072(f_22024_83941_84052(f_22024_83941_84010(ErrorCode.ERR_MethDelegateMismatch, "new Action<int>(M1)"), "M1", "System.Action<int>"), 7, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,84104,84229);

f_22024_84104_84228(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,82775,84240);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,82775,84240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,82775,84240);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DelegateCreation_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,84252,87800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,84416,84655);

string 
source = @"
using System;

class C
{
    void M(Action a1, Action a2, Action a3, Action a4)
    /*<bind>*/{
        a1 = () => { };
        a2 = M2;
        a3 = new Action(a4);
    }/*</bind>*/

    void M2() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,84669,87608);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (3)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = () => { };')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action) (Syntax: 'a1 = () => { }')
              Left: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Action) (Syntax: 'a1')
              Right: 
                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsImplicit) (Syntax: '() => { }')
                  Target: 
                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null) (Syntax: '() => { }')
                    {
                        Block[B0#A0] - Entry
                            Statements (0)
                            Next (Regular) Block[B1#A0]
                        Block[B1#A0] - Exit
                            Predecessors: [B0#A0]
                            Statements (0)
                    }

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a2 = M2;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action) (Syntax: 'a2 = M2')
              Left: 
                IParameterReferenceOperation: a2 (OperationKind.ParameterReference, Type: System.Action) (Syntax: 'a2')
              Right: 
                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsImplicit) (Syntax: 'M2')
                  Target: 
                    IMethodReferenceOperation: void C.M2() (OperationKind.MethodReference, Type: null) (Syntax: 'M2')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'M2')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a3 = new Action(a4);')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action) (Syntax: 'a3 = new Action(a4)')
              Left: 
                IParameterReferenceOperation: a3 (OperationKind.ParameterReference, Type: System.Action) (Syntax: 'a3')
              Right: 
                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action(a4)')
                  Target: 
                    IParameterReferenceOperation: a4 (OperationKind.ParameterReference, Type: System.Action) (Syntax: 'a4')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,87622,87675);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,87691,87789);

f_22024_87691_87788(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,84252,87800);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,84252,87800);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,84252,87800);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DelegateCreation_ControlFlowInTarget()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22024,87812,91539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,87982,88158);

string 
source = @"
using System;

class C
{
    void M(Action a1, Action a2, Action a3)
    /*<bind>*/
    {
        a1 = new Action(a2 ?? a3);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,88172,91347);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
              Value: 
                IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Action) (Syntax: 'a1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a2')
                  Value: 
                    IParameterReferenceOperation: a2 (OperationKind.ParameterReference, Type: System.Action) (Syntax: 'a2')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a2')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Action, IsImplicit) (Syntax: 'a2')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a2')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Action, IsImplicit) (Syntax: 'a2')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a3')
              Value: 
                IParameterReferenceOperation: a3 (OperationKind.ParameterReference, Type: System.Action) (Syntax: 'a3')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a1 = new Ac ... (a2 ?? a3);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action) (Syntax: 'a1 = new Ac ... n(a2 ?? a3)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Action, IsImplicit) (Syntax: 'a1')
                  Right: 
                    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: 'new Action(a2 ?? a3)')
                      Target: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Action, IsImplicit) (Syntax: 'a2 ?? a3')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,91361,91414);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22024,91430,91528);

f_22024_91430_91527(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22024,87812,91539);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22024,87812,91539);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22024,87812,91539);
}
		}

int
f_22024_2161_2286(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 2161, 2286);
return 0;
}


int
f_22024_3122_3238(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LambdaExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 3122, 3238);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_5479_5526(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 5479, 5526);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_5479_5546(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 5479, 5546);
return return_v;
}


int
f_22024_5578_5703(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 5578, 5703);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_7445_7503(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 7445, 7503);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_7445_7539(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 7445, 7539);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_7445_7559(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 7445, 7559);
return return_v;
}


int
f_22024_7591_7716(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 7591, 7716);
return 0;
}


int
f_22024_8661_8775(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 8661, 8775);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_10262_10309(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 10262, 10309);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_10262_10329(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 10262, 10329);
return return_v;
}


int
f_22024_10361_10475(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 10361, 10475);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_11516_11574(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 11516, 11574);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_11516_11610(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 11516, 11610);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_11516_11630(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 11516, 11630);
return return_v;
}


int
f_22024_11662_11776(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 11662, 11776);
return 0;
}


int
f_22024_13439_13564(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 13439, 13564);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_15669_15730(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 15669, 15730);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_15669_15750(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 15669, 15750);
return return_v;
}


int
f_22024_15782_15907(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 15782, 15907);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_17673_17736(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 17673, 17736);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_17673_17772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 17673, 17772);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_17673_17792(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 17673, 17792);
return return_v;
}


int
f_22024_17824_17949(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 17824, 17949);
return 0;
}


int
f_22024_19464_19589(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 19464, 19589);
return 0;
}


int
f_22024_20333_20447(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 20333, 20447);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_22141_22189(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 22141, 22189);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_22141_22209(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 22141, 22209);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_22141_22229(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 22141, 22229);
return return_v;
}


int
f_22024_22261_22386(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 22261, 22386);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_23155_23203(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 23155, 23203);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_23155_23223(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 23155, 23223);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_23155_23243(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 23155, 23243);
return return_v;
}


int
f_22024_23275_23389(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 23275, 23389);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_25149_25191(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 25149, 25191);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_25149_25228(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 25149, 25228);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_25149_25248(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 25149, 25248);
return return_v;
}


int
f_22024_25280_25483(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 25280, 25483);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_26478_26520(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 26478, 26520);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_26478_26557(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 26478, 26557);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_26478_26577(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 26478, 26577);
return return_v;
}


int
f_22024_25896_26654(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 25896, 26654);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_27195_27237(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 27195, 27237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_27195_27274(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 27195, 27274);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_27195_27294(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 27195, 27294);
return return_v;
}


int
f_22024_26669_27310(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 26669, 27310);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_29025_29077(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 29025, 29077);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_29025_29114(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 29025, 29114);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_29025_29134(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 29025, 29134);
return return_v;
}


int
f_22024_29166_29291(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 29166, 29291);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_30238_30290(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 30238, 30290);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_30238_30327(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 30238, 30327);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_30238_30347(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 30238, 30347);
return return_v;
}


int
f_22024_30379_30493(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 30379, 30493);
return 0;
}


int
f_22024_31374_31488(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 31374, 31488);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_32512_32560(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 32512, 32560);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_32512_32580(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 32512, 32580);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_32512_32600(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 32512, 32600);
return return_v;
}


int
f_22024_32632_32746(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 32632, 32746);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_34023_34078(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 34023, 34078);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_34023_34108(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 34023, 34108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_34023_34128(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 34023, 34128);
return return_v;
}


int
f_22024_34160_34274(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 34160, 34274);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_35377_35427(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 35377, 35427);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_35377_35464(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 35377, 35464);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_35377_35484(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 35377, 35484);
return return_v;
}


int
f_22024_35516_35708(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 35516, 35708);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_36767_36819(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 36767, 36819);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_36767_36856(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 36767, 36856);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_36767_36876(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 36767, 36876);
return return_v;
}


int
f_22024_36079_36953(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 36079, 36953);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_37600_37644(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 37600, 37644);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_37600_37681(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 37600, 37681);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_37600_37701(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 37600, 37701);
return return_v;
}


int
f_22024_36968_37717(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 36968, 37717);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_38796_38856(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 38796, 38856);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_38796_38893(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 38796, 38893);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_38796_38913(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 38796, 38913);
return return_v;
}


int
f_22024_38945_39059(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 38945, 39059);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_40125_40187(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 40125, 40187);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_40125_40224(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 40125, 40224);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_40125_40244(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 40125, 40244);
return return_v;
}


int
f_22024_40276_40390(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CastExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 40276, 40390);
return 0;
}


int
f_22024_41369_41493(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 41369, 41493);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_43016_43063(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 43016, 43063);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_43016_43083(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 43016, 43083);
return return_v;
}


int
f_22024_43115_43239(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 43115, 43239);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_44462_44520(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 44462, 44520);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_44462_44556(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 44462, 44556);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_44462_44576(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 44462, 44576);
return return_v;
}


int
f_22024_44608_44732(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 44608, 44732);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_46021_46093(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 46021, 46093);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_46021_46113(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 46021, 46113);
return return_v;
}


int
f_22024_46145_46269(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 46145, 46269);
return 0;
}


int
f_22024_47205_47329(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 47205, 47329);
return 0;
}


int
f_22024_48227_48351(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 48227, 48351);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_49608_49661(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 49608, 49661);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_49608_49691(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 49608, 49691);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_49608_49711(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 49608, 49711);
return return_v;
}


int
f_22024_49743_49867(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 49743, 49867);
return 0;
}


int
f_22024_50792_50916(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 50792, 50916);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_51824_51872(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 51824, 51872);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_51824_51892(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 51824, 51892);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_51824_51912(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 51824, 51912);
return return_v;
}


int
f_22024_51944_52068(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 51944, 52068);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_53223_53265(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 53223, 53265);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_53223_53302(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 53223, 53302);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_53223_53322(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 53223, 53322);
return return_v;
}


int
f_22024_52488_53399(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 52488, 53399);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_54114_54156(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 54114, 54156);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_54114_54193(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 54114, 54193);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_54114_54213(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 54114, 54213);
return return_v;
}


int
f_22024_53414_54229(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 53414, 54229);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_55333_55397(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 55333, 55397);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_55333_55434(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 55333, 55434);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_55333_55454(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 55333, 55454);
return return_v;
}


int
f_22024_55486_55610(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 55486, 55610);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_56948_57002(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 56948, 57002);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_56948_57022(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 56948, 57022);
return return_v;
}


int
f_22024_57054_57178(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 57054, 57178);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_58297_58355(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 58297, 58355);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_58297_58411(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 58297, 58411);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_58297_58431(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 58297, 58431);
return return_v;
}


int
f_22024_58463_58587(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 58463, 58587);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_59697_59755(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 59697, 59755);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_59697_59809(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 59697, 59809);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_59697_59829(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 59697, 59829);
return return_v;
}


int
f_22024_59861_59985(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 59861, 59985);
return 0;
}


int
f_22024_61134_61258(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 61134, 61258);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_62990_63037(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 62990, 63037);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_62990_63057(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 62990, 63057);
return return_v;
}


int
f_22024_63089_63213(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 63089, 63213);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_64463_64521(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 64463, 64521);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_64463_64557(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 64463, 64557);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_64463_64577(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 64463, 64577);
return return_v;
}


int
f_22024_64609_64733(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 64609, 64733);
return 0;
}


int
f_22024_65814_65938(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 65814, 65938);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_67189_67237(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 67189, 67237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_67189_67257(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 67189, 67257);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_67189_67277(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 67189, 67277);
return return_v;
}


int
f_22024_67309_67433(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 67309, 67433);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_68743_68793(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 68743, 68793);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_68743_68830(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 68743, 68830);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_68743_68850(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 68743, 68850);
return return_v;
}


int
f_22024_68882_69084(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 68882, 69084);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_70367_70427(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 70367, 70427);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_70367_70464(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 70367, 70464);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_70367_70484(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 70367, 70484);
return return_v;
}


int
f_22024_70516_70640(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 70516, 70640);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_71996_72062(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 71996, 72062);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_71996_72118(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 71996, 72118);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_71996_72138(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 71996, 72138);
return return_v;
}


int
f_22024_72170_72294(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 72170, 72294);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_73642_73708(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 73642, 73708);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_73642_73762(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 73642, 73762);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_73642_73782(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 73642, 73782);
return return_v;
}


int
f_22024_73814_73938(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 73814, 73938);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_75330_75407(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 75330, 75407);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_75330_75469(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 75330, 75469);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_75330_75489(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 75330, 75489);
return return_v;
}


int
f_22024_75521_75645(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 75521, 75645);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_77432_77478(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 77432, 77478);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_77432_77497(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 77432, 77497);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_77432_77517(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 77432, 77517);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier
f_22024_77718_77746()
{
var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.ExpectedSymbolVerifier();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 77718, 77746);
return return_v;
}


int
f_22024_77549_77754(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 77549, 77754);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_79580_79632(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 79580, 79632);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_79580_79674(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 79580, 79674);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_79580_79694(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 79580, 79694);
return return_v;
}


int
f_22024_79726_79851(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 79726, 79851);
return 0;
}


int
f_22024_81474_81599(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 81474, 81599);
return 0;
}


int
f_22024_82627_82751(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 82627, 82751);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_83941_84010(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 83941, 84010);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_83941_84052(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 83941, 84052);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22024_83941_84072(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 83941, 84072);
return return_v;
}


int
f_22024_84104_84228(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 84104, 84228);
return 0;
}


int
f_22024_87691_87788(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 87691, 87788);
return 0;
}


int
f_22024_91430_91527(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22024, 91430, 91527);
return 0;
}

}
}
