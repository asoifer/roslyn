// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_ContainingMethodParameterReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,622,1824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,782,975);

string 
source = @"
class C
{
    public void M(int x)
    {
        /*<bind>*/int Local(int p1)
        {
            return x++;
        }/*</bind>*/

        Local(0);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,989,1607);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Int32 Local(System.Int32 p1)) (OperationKind.LocalFunction, Type: null) (Syntax: 'int Local(i ... }')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return x++;')
      ReturnedValue: 
        IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'x++')
          Target: 
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,1621,1674);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,1690,1813);

f_22046_1690_1812(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,622,1824);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,622,1824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,622,1824);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_ContainingMethodParameterReference_ExpressionBodied()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,1836,3027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,2013,2165);

string 
source = @"
class C
{
    public void M(int x)
    {
        /*<bind>*/int Local(int p1) => x++;/*</bind>*/
        Local(0);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,2179,2810);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Int32 Local(System.Int32 p1)) (OperationKind.LocalFunction, Type: null) (Syntax: 'int Local(i ... p1) => x++;')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> x++')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x++')
      ReturnedValue: 
        IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'x++')
          Target: 
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,2824,2877);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,2893,3016);

f_22046_2893_3015(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,1836,3027);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,1836,3027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,1836,3027);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_LocalFunctionParameterReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,3039,4200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,3196,3342);

string 
source = @"
class C
{
    public void M()
    {
        /*<bind>*/int Local(int x) => x++;/*</bind>*/
        Local(0);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,3356,3983);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Int32 Local(System.Int32 x)) (OperationKind.LocalFunction, Type: null) (Syntax: 'int Local(int x) => x++;')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> x++')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x++')
      ReturnedValue: 
        IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'x++')
          Target: 
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,3997,4050);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,4066,4189);

f_22046_4066_4188(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,3039,4200);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,3039,4200);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,3039,4200);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_ContainingLocalFunctionParameterReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,4212,5618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,4379,4622);

string 
source = @"
class C
{
    public void M()
    {
        int LocalOuter (int x)
        {
            /*<bind>*/int Local(int y) => x + y;/*</bind>*/
            return Local(x);
        }

        LocalOuter(0);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,4636,5401);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Int32 Local(System.Int32 y)) (OperationKind.LocalFunction, Type: null) (Syntax: 'int Local(i ... ) => x + y;')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> x + y')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x + y')
      ReturnedValue: 
        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + y')
          Left: 
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
          Right: 
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,5415,5468);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,5484,5607);

f_22046_5484_5606(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,4212,5618);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,4212,5618);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,4212,5618);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_LocalFunctionReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,5630,7764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,5778,6037);

string 
source = @"
class C
{
    public void M()
    {
        int x;
        int Local(int p1) => x++;
        int Local2(int p1) => Local(p1);
        /*<bind>*/int Local3(int p1) => x + Local2(p1);/*</bind>*/

        Local3(x = 0);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,6051,7547);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Int32 Local3(System.Int32 p1)) (OperationKind.LocalFunction, Type: null) (Syntax: 'int Local3( ... Local2(p1);')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> x + Local2(p1)')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x + Local2(p1)')
      ReturnedValue: 
        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + Local2(p1)')
          Left: 
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
          Right: 
            IInvocationOperation (System.Int32 Local2(System.Int32 p1)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Local2(p1)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p1) (OperationKind.Argument, Type: null) (Syntax: 'p1')
                    IParameterReferenceOperation: p1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p1')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,7561,7614);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,7630,7753);

f_22046_7630_7752(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,5630,7764);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,5630,7764);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,5630,7764);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_Recursion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,7776,9788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,7911,8054);

string 
source = @"
class C
{
    public void M(int x)
    {
        /*<bind>*/int Local(int p1) => Local(x + p1);/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,8068,9571);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Int32 Local(System.Int32 p1)) (OperationKind.LocalFunction, Type: null) (Syntax: 'int Local(i ... al(x + p1);')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> Local(x + p1)')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'Local(x + p1)')
      ReturnedValue: 
        IInvocationOperation (System.Int32 Local(System.Int32 p1)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Local(x + p1)')
          Instance Receiver: 
            null
          Arguments(1):
              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p1) (OperationKind.Argument, Type: null) (Syntax: 'x + p1')
                IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + p1')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    IParameterReferenceOperation: p1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p1')
                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,9585,9638);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,9654,9777);

f_22046_9654_9776(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,7776,9788);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,7776,9788);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,7776,9788);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_Async()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,9800,12436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,9931,10223);

string 
source = @"
using System.Threading.Tasks;

class C
{
    public void M(int x)
    {
        /*<bind>*/async Task<int> LocalAsync(int p1)
        {
            await Task.Delay(0);
            return x + p1;
        }/*</bind>*/

        LocalAsync(0).Wait();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,10237,12183);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Threading.Tasks.Task<System.Int32> LocalAsync(System.Int32 p1)) (OperationKind.LocalFunction, Type: null) (Syntax: 'async Task< ... }')
  IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'await Task.Delay(0);')
      Expression: 
        IAwaitOperation (OperationKind.Await, Type: System.Void) (Syntax: 'await Task.Delay(0)')
          Expression: 
            IInvocationOperation (System.Threading.Tasks.Task System.Threading.Tasks.Task.Delay(System.Int32 millisecondsDelay)) (OperationKind.Invocation, Type: System.Threading.Tasks.Task) (Syntax: 'Task.Delay(0)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: millisecondsDelay) (OperationKind.Argument, Type: null) (Syntax: '0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return x + p1;')
      ReturnedValue: 
        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + p1')
          Left: 
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
          Right: 
            IParameterReferenceOperation: p1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,12197,12250);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,12266,12425);

f_22046_12266_12424(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,9800,12436);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,9800,12436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,9800,12436);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_CaptureForEachVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,12448,13493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,12591,12804);

string 
source = @"
class C
{
    public void M(int[] array)
    {
        foreach (var x in array)
        {
            /*<bind>*/int Local() => x;/*</bind>*/
            Local();
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,12818,13276);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Int32 Local()) (OperationKind.LocalFunction, Type: null) (Syntax: 'int Local() => x;')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> x')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x')
      ReturnedValue: 
        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,13290,13343);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,13359,13482);

f_22046_13359_13481(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,12448,13493);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,12448,13493);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,12448,13493);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_UseOfUnusedVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,13505,14975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,13645,13791);

string 
source = @"
class C
{
    void M()
    {
        F();
        int x = 0;
        /*<bind>*/void F() => x++;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,13805,14538);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: void F()) (OperationKind.LocalFunction, Type: null) (Syntax: 'void F() => x++;')
  IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '=> x++')
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'x++')
      Expression: 
        IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'x++')
          Target: 
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '=> x++')
      ReturnedValue: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,14552,14825);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22046_14723_14809(f_22046_14723_14790(f_22046_14723_14771(ErrorCode.ERR_UseDefViolation, "F()"), "x"), 6, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,14841,14964);

f_22046_14841_14963(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,13505,14975);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,13505,14975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,13505,14975);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_OutVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,14987,16415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,15119,15282);

string 
source = @"
class C
{
    void M(int p)
    {
        int x;
        /*<bind>*/void F(out int y) => y = p;/*</bind>*/
        F(out x);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,15296,16198);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: void F(out System.Int32 y)) (OperationKind.LocalFunction, Type: null) (Syntax: 'void F(out  ... ) => y = p;')
  IBlockOperation (2 statements) (OperationKind.Block, Type: null) (Syntax: '=> y = p')
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'y = p')
      Expression: 
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'y = p')
          Left: 
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
          Right: 
            IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '=> y = p')
      ReturnedValue: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,16212,16265);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,16281,16404);

f_22046_16281_16403(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,14987,16415);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,14987,16415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,14987,16415);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestInvalidLocalFunction_MissingBody()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,16427,18454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,16571,16694);

string 
source = @"
class C
{
    void M(int p)
    {
        /*<bind>*/void F(out int y) => ;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,16708,17372);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: void F(out System.Int32 y)) (OperationKind.LocalFunction, Type: null, IsInvalid) (Syntax: 'void F(out int y) => ;')
  IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> ')
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: '')
      Expression: 
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
          Children(0)
    IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '=> ')
      ReturnedValue: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,17386,18304);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22046_17608_17693(f_22046_17608_17673(f_22046_17608_17654(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 40),
f_22046_17916_18001(f_22046_17916_17981(f_22046_17916_17962(ErrorCode.ERR_ParamUnassigned, "F"), "y"), 6, 24),
f_22046_18193_18288(f_22046_18193_18268(f_22046_18193_18249(ErrorCode.WRN_UnreferencedLocalFunction, "F"), "F"), 6, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,18320,18443);

f_22046_18320_18442(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,16427,18454);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,16427,18454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,16427,18454);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestInvalidLocalFunction_MissingParameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,18466,19850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,18616,18729);

string 
source = @"
class C
{
    void M(int p)
    {
        /*<bind>*/void F( { }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,18743,19129);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: void F()) (OperationKind.LocalFunction, Type: null, IsInvalid) (Syntax: 'void F( { }')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
    IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '{ }')
      ReturnedValue: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,19143,19700);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22046_19338_19407(f_22046_19338_19387(ErrorCode.ERR_CloseParenExpected, "{"), 6, 27),
f_22046_19589_19684(f_22046_19589_19664(f_22046_19589_19645(ErrorCode.WRN_UnreferencedLocalFunction, "F"), "F"), 6, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,19716,19839);

f_22046_19716_19838(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,18466,19850);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,18466,19850);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,18466,19850);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestInvalidLocalFunction_InvalidReturnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,19862,21405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,20012,20123);

string 
source = @"
class C
{
    void M(int p)
    {
        /*<bind>*/X F() { }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,20137,20374);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: X F()) (OperationKind.LocalFunction, Type: null, IsInvalid) (Syntax: 'X F() { }')
  IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,20388,21255);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22046_20590_20676(f_22046_20590_20656(f_22046_20590_20635(ErrorCode.ERR_ReturnExpected, "F"), "F()"), 6, 21),
f_22046_20895_20987(f_22046_20895_20967(f_22046_20895_20948(ErrorCode.ERR_SingleTypeNameNotFound, "X"), "X"), 6, 19),
f_22046_21144_21239(f_22046_21144_21219(f_22046_21144_21200(ErrorCode.WRN_UnreferencedLocalFunction, "F"), "F"), 6, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,21271,21394);

f_22046_21271_21393(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,19862,21405);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,19862,21405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,19862,21405);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(24650, "https://github.com/dotnet/roslyn/issues/24650")]
        public void TestInvalidLocalFunction_ExpressionAndBlockBody()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,21417,23315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,21638,21784);

string 
source = @"
class C
{
    void M(int p)
    {
        /*<bind>*/object F() => new object(); { return null; }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,21798,22398);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Object F()) (OperationKind.LocalFunction, Type: null) (Syntax: 'object F()  ... w object();')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> new object()')
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'new object()')
      ReturnedValue: 
        IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object) (Syntax: 'new object()')
          Arguments(0)
          Initializer: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,22412,23165);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22046_22730_22831(f_22046_22730_22811(f_22046_22730_22785(ErrorCode.ERR_RetNoObjectRequired, "return"), "C.M(int)"), 6, 49),
f_22046_23054_23149(f_22046_23054_23129(f_22046_23054_23110(ErrorCode.WRN_UnreferencedLocalFunction, "F"), "F"), 6, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,23181,23304);

f_22046_23181_23303(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,21417,23315);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,21417,23315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,21417,23315);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(24650, "https://github.com/dotnet/roslyn/issues/24650")]
        public void TestInvalidLocalFunction_BlockAndExpressionBody()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,23327,25936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,23548,23694);

string 
source = @"
class C
{
    void M(int p)
    {
        /*<bind>*/object F() { return new object(); } => null;/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,23708,25079);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Object F()) (OperationKind.LocalFunction, Type: null, IsInvalid) (Syntax: 'object F()  ...  } => null;')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ return new object(); }')
      IReturnOperation (OperationKind.Return, Type: null, IsInvalid) (Syntax: 'return new object();')
        ReturnedValue: 
          IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object, IsInvalid) (Syntax: 'new object()')
            Arguments(0)
            Initializer: 
              null
  IgnoredBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> null')
      IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: 'null')
        ReturnedValue: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,25093,25786);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22046_25355_25475(f_22046_25355_25455(ErrorCode.ERR_BlockBodyAndExpressionBody, "object F() { return new object(); } => null;"), 6, 19),
f_22046_25675_25770(f_22046_25675_25750(f_22046_25675_25731(ErrorCode.WRN_UnreferencedLocalFunction, "F"), "F"), 6, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,25802,25925);

f_22046_25802_25924(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,23327,25936);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,23327,25936);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,23327,25936);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(24650, "https://github.com/dotnet/roslyn/issues/24650")]
        public void TestLocalFunction_ExpressionBodyInnerMember()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,25948,27013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,26165,26317);

string 
source = @"
class C
{
    public void M(int x)
    {
        int Local(int p1) /*<bind>*/=> x++/*</bind>*/;
        Local(0);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,26331,26797);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> x++')
  IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'x++')
    ReturnedValue: 
      IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'x++')
        Target: 
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,26811,26864);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,26880,27002);

f_22046_26880_27001(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,25948,27013);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,25948,27013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,25948,27013);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_StaticWithShadowedVariableReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,27025,30601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,27186,27523);

string 
source =
@"#pragma warning disable 8321
class C
{
    static void M(int x)
    {
        /*<bind>*/
        static int Local(int y)
        {
            if (y > 0)
            {
                int x = (int)y;
                return x;
            }
            return x;
        }
        /*</bind>*/
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,27537,30104);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Int32 Local(System.Int32 y)) (OperationKind.LocalFunction, Type: null, IsInvalid) (Syntax: 'static int  ... }')
  IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
    IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (y > 0) ... }')
      Condition: 
        IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'y > 0')
          Left: 
            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
          Right: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      WhenTrue: 
        IBlockOperation (2 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          Locals: Local_1: System.Int32 x
          IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int x = (int)y;')
            IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int x = (int)y')
              Declarators:
                  IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = (int)y')
                    Initializer: 
                      IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (int)y')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)y')
                          Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
              Initializer: 
                null
          IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return x;')
            ReturnedValue: 
              ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
      WhenFalse: 
        null
    IReturnOperation (OperationKind.Return, Type: null, IsInvalid) (Syntax: 'return x;')
      ReturnedValue: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,30118,30453);

var 
expectedDiagnostics = new[]
            {
f_22046_30326_30437(f_22046_30326_30416(f_22046_30326_30397(ErrorCode.ERR_StaticLocalFunctionCannotCaptureVariable, "x"), "x"), 14, 20)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,30467,30590);

f_22046_30467_30589(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,27025,30601);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,27025,30601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,27025,30601);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestLocalFunction_StaticWithThisReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,30613,35444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,30762,30983);

string 
source =
@"#pragma warning disable 8321
class C
{
    void M()
    {
        /*<bind>*/
        static object Local() => ToString() + this.GetHashCode() + base.GetHashCode();
        /*</bind>*/
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,30997,34227);

string 
expectedOperationTree = @"
ILocalFunctionOperation (Symbol: System.Object Local()) (OperationKind.LocalFunction, Type: null, IsInvalid) (Syntax: 'static obje ... HashCode();')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> ToString ... tHashCode()')
    IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: 'ToString()  ... tHashCode()')
      ReturnedValue: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'ToString()  ... tHashCode()')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String, IsInvalid) (Syntax: 'ToString()  ... tHashCode()')
              Left: 
                IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String, IsInvalid) (Syntax: 'ToString()  ... tHashCode()')
                  Left: 
                    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String, IsInvalid) (Syntax: 'ToString()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'ToString')
                      Arguments(0)
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'this.GetHashCode()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        IInvocationOperation (virtual System.Int32 System.Object.GetHashCode()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'this.GetHashCode()')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid) (Syntax: 'this')
                          Arguments(0)
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'base.GetHashCode()')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    IInvocationOperation ( System.Int32 System.Object.GetHashCode()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'base.GetHashCode()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object, IsInvalid) (Syntax: 'base')
                      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,34241,35296);

var 
expectedDiagnostics = new[]
            {
f_22046_34526_34620(f_22046_34526_34600(ErrorCode.ERR_StaticLocalFunctionCannotCaptureThis, "ToString"), 7, 34),
f_22046_34860_34950(f_22046_34860_34930(ErrorCode.ERR_StaticLocalFunctionCannotCaptureThis, "this"), 7, 47),
f_22046_35190_35280(f_22046_35190_35260(ErrorCode.ERR_StaticLocalFunctionCannotCaptureThis, "base"), 7, 68)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,35310,35433);

f_22046_35310_35432(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,30613,35444);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,30613,35444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,30613,35444);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,35456,39124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,35610,35820);

string 
source = @"
struct C
{
    void M()
/*<bind>*/{
        void local(bool result, bool input)
        {
            result = input;
        }

        local(false, true);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,35834,38936);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local(System.Boolean result, System.Boolean input)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'local(false, true);')
              Expression: 
                IInvocationOperation (void local(System.Boolean result, System.Boolean input)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'local(false, true)')
                  Instance Receiver: 
                    null
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: result) (OperationKind.Argument, Type: null) (Syntax: 'false')
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: input) (OperationKind.Argument, Type: null) (Syntax: 'true')
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local(System.Boolean result, System.Boolean input)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Block
            Predecessors: [B0#0R1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = input;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = input')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')

            Next (Regular) Block[B2#0R1]
        Block[B2#0R1] - Exit
            Predecessors: [B1#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,38950,39003);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,39019,39113);

f_22046_39019_39112(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,35456,39124);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,35456,39124);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,35456,39124);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,39136,41157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,39290,39501);

string 
source = @"
#pragma warning disable CS8321
struct C
{
    void M()
/*<bind>*/{
        void local(bool result, bool input)
        {
            result = input;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,39515,40969);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local(System.Boolean result, System.Boolean input)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local(System.Boolean result, System.Boolean input)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Block
            Predecessors: [B0#0R1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = input;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = input')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')

            Next (Regular) Block[B2#0R1]
        Block[B2#0R1] - Exit
            Predecessors: [B1#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,40983,41036);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,41052,41146);

f_22046_41052_41145(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,39136,41157);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,39136,41157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,39136,41157);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,41169,42910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,41323,41483);

string 
source = @"
#pragma warning disable CS8321
struct C
{
    void M()
/*<bind>*/{
        void local(bool result, bool input)
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,41497,42192);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local(System.Boolean result, System.Boolean input)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local(System.Boolean result, System.Boolean input)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Exit
            Predecessors: [B0#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,42206,42789);

var 
expectedDiagnostics = new[] {
f_22046_42381_42448(f_22046_42381_42428(ErrorCode.ERR_SemicolonExpected, ""), 7, 44),
f_22046_42659_42773(f_22046_42659_42753(f_22046_42659_42718(ErrorCode.ERR_LocalFunctionMissingBody, "local"), "local(bool, bool)"), 7, 14)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,42805,42899);

f_22046_42805_42898(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,41169,42910);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,41169,42910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,41169,42910);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,42922,46469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,43076,43332);

string 
source = @"
#pragma warning disable CS8321
struct C
{
    void M()
/*<bind>*/{
        void local(bool result, bool input1, bool input2)
        {
            result = input1;
        } 
        => result = input2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,43346,45874);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local(System.Boolean result, System.Boolean input1, System.Boolean input2)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local(System.Boolean result, System.Boolean input1, System.Boolean input2)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Block
            Predecessors: [B0#0R1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = input1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsInvalid) (Syntax: 'result = input1')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'result')
                      Right: 
                        IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'input1')

            Next (Regular) Block[B3#0R1]

        .erroneous body {R1#0R1}
        {
            Block[B2#0R1] - Block [UnReachable]
                Predecessors (0)
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'result = input2')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsInvalid) (Syntax: 'result = input2')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'result')
                          Right: 
                            IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'input2')

                Next (Regular) Block[B3#0R1]
                    Leaving: {R1#0R1}
        }

        Block[B3#0R1] - Exit
            Predecessors: [B1#0R1] [B2#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,45888,46348);

var 
expectedDiagnostics = new[] {
f_22046_46125_46332(f_22046_46125_46313(ErrorCode.ERR_BlockBodyAndExpressionBody, @"void local(bool result, bool input1, bool input2)
        {
            result = input1;
        } 
        => result = input2;"), 7, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,46364,46458);

f_22046_46364_46457(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,42922,46469);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,42922,46469);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,42922,46469);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,46481,49711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,46635,46920);

string 
source = @"
#pragma warning disable CS8321
struct C
{
    void M()
/*<bind>*/{
        void local1(bool result1, bool input1)
        {
            result1 = input1;
        }
        void local2(bool result2, bool input2) => result2 = input2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,46934,49523);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local1(System.Boolean result1, System.Boolean input1)] [void local2(System.Boolean result2, System.Boolean input2)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local1(System.Boolean result1, System.Boolean input1)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Block
            Predecessors: [B0#0R1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result1 = input1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result1 = input1')
                      Left: 
                        IParameterReferenceOperation: result1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result1')
                      Right: 
                        IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input1')

            Next (Regular) Block[B2#0R1]
        Block[B2#0R1] - Exit
            Predecessors: [B1#0R1]
            Statements (0)
    }
    
    {   void local2(System.Boolean result2, System.Boolean input2)
    
        Block[B0#1R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#1R1]
        Block[B1#1R1] - Block
            Predecessors: [B0#1R1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'result2 = input2')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result2 = input2')
                      Left: 
                        IParameterReferenceOperation: result2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result2')
                      Right: 
                        IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input2')

            Next (Regular) Block[B2#1R1]
        Block[B2#1R1] - Exit
            Predecessors: [B1#1R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,49537,49590);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,49606,49700);

f_22046_49606_49699(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,46481,49711);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,46481,49711);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,46481,49711);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,49723,56357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,49877,50195);

string 
source = @"
struct C
{
    void M(int input)
/*<bind>*/{
        int result;
        local1(input);

        int local1(int input1)
        {
            int i = local1(input1);
            result = local1(i);
            return result;
        }

        local1(result);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,50209,56169);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 result]
    Methods: [System.Int32 local1(System.Int32 input1)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'local1(input);')
              Expression: 
                IInvocationOperation (System.Int32 local1(System.Int32 input1)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'local1(input)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: input1) (OperationKind.Argument, Type: null) (Syntax: 'input')
                        IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'local1(result);')
              Expression: 
                IInvocationOperation (System.Int32 local1(System.Int32 input1)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'local1(result)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: input1) (OperationKind.Argument, Type: null) (Syntax: 'result')
                        ILocalReferenceOperation: result (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'result')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   System.Int32 local1(System.Int32 input1)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
                Entering: {R1#0R1}

        .locals {R1#0R1}
        {
            Locals: [System.Int32 i]
            Block[B1#0R1] - Block
                Predecessors: [B0#0R1]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = local1(input1)')
                      Left: 
                        ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = local1(input1)')
                      Right: 
                        IInvocationOperation (System.Int32 local1(System.Int32 input1)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'local1(input1)')
                          Instance Receiver: 
                            null
                          Arguments(1):
                              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: input1) (OperationKind.Argument, Type: null) (Syntax: 'input1')
                                IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input1')
                                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = local1(i);')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = local1(i)')
                          Left: 
                            ILocalReferenceOperation: result (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'result')
                          Right: 
                            IInvocationOperation (System.Int32 local1(System.Int32 input1)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'local1(i)')
                              Instance Receiver: 
                                null
                              Arguments(1):
                                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: input1) (OperationKind.Argument, Type: null) (Syntax: 'i')
                                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

                Next (Return) Block[B2#0R1]
                    ILocalReferenceOperation: result (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'result')
                    Leaving: {R1#0R1}
        }

        Block[B2#0R1] - Exit
            Predecessors: [B1#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,56183,56236);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,56252,56346);

f_22046_56252_56345(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,49723,56357);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,49723,56357);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,49723,56357);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,56369,58470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,56523,56814);

string 
source = @"
#pragma warning disable CS8321
struct C
{
    void M()
/*<bind>*/{
        try
        {
            void local(bool result, bool input)
            {
                result = input;
            }
        }
        finally
        {}
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,56828,58282);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local(System.Boolean result, System.Boolean input)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local(System.Boolean result, System.Boolean input)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Block
            Predecessors: [B0#0R1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = input;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = input')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                      Right: 
                        IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')

            Next (Regular) Block[B2#0R1]
        Block[B2#0R1] - Exit
            Predecessors: [B1#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,58296,58349);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,58365,58459);

f_22046_58365_58458(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,56369,58470);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,56369,58470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,56369,58470);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,58482,63352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,58636,58995);

string 
source = @"
#pragma warning disable CS8321
struct C
{
    void M()
/*<bind>*/{
        int i = 0;

        void local1(int input1)
        {
            input1 = 1;
            i++;

            void local2(bool input2)
            {
                input2 = true;
                i++;
            }
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,59009,63164);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Methods: [void local1(System.Int32 input1)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local1(System.Int32 input1)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
                Entering: {R1#0R1}

        .locals {R1#0R1}
        {
            Methods: [void local2(System.Boolean input2)]
            Block[B1#0R1] - Block
                Predecessors: [B0#0R1]
                Statements (2)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input1 = 1;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'input1 = 1')
                          Left: 
                            IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input1')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i++;')
                      Expression: 
                        IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
                          Target: 
                            ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

                Next (Regular) Block[B2#0R1]
                    Leaving: {R1#0R1}
            
            {   void local2(System.Boolean input2)
            
                Block[B0#0R1#0R1] - Entry
                    Statements (0)
                    Next (Regular) Block[B1#0R1#0R1]
                Block[B1#0R1#0R1] - Block
                    Predecessors: [B0#0R1#0R1]
                    Statements (2)
                        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input2 = true;')
                          Expression: 
                            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'input2 = true')
                              Left: 
                                IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input2')
                              Right: 
                                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

                        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i++;')
                          Expression: 
                            IIncrementOrDecrementOperation (Postfix) (OperationKind.Increment, Type: System.Int32) (Syntax: 'i++')
                              Target: 
                                ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

                    Next (Regular) Block[B2#0R1#0R1]
                Block[B2#0R1#0R1] - Exit
                    Predecessors: [B1#0R1#0R1]
                    Statements (0)
            }
        }

        Block[B2#0R1] - Exit
            Predecessors: [B1#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,63178,63231);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,63247,63341);

f_22046_63247_63340(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,58482,63352);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,58482,63352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,58482,63352);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,63364,70510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,63518,63780);

string 
source = @"
#pragma warning disable CS8321
class C
{
    void M(C x, C y, C z)
/*<bind>*/{
        x = y ?? z;

        void local(C result, C input1, C input2)
        {
            result = input1 ?? input2;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,63794,70322);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local(C result, C input1, C input2)]
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: C) (Syntax: 'x')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
                  Value: 
                    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: C) (Syntax: 'y')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'y')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'y')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'z')
              Value: 
                IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: C) (Syntax: 'z')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = y ?? z;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'x = y ?? z')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'x')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'y ?? z')

        Next (Regular) Block[B6]
            Leaving: {R1}
    
    {   void local(C result, C input1, C input2)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
                Entering: {R1#0R1}

        .locals {R1#0R1}
        {
            CaptureIds: [3] [5]
            Block[B1#0R1] - Block
                Predecessors: [B0#0R1]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
                      Value: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')

                Next (Regular) Block[B2#0R1]
                    Entering: {R2#0R1}

            .locals {R2#0R1}
            {
                CaptureIds: [4]
                Block[B2#0R1] - Block
                    Predecessors: [B1#0R1]
                    Statements (1)
                        IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
                          Value: 
                            IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: C) (Syntax: 'input1')

                    Jump if True (Regular) to Block[B4#0R1]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input1')
                          Operand: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input1')
                        Leaving: {R2#0R1}

                    Next (Regular) Block[B3#0R1]
                Block[B3#0R1] - Block
                    Predecessors: [B2#0R1]
                    Statements (1)
                        IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
                          Value: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input1')

                    Next (Regular) Block[B5#0R1]
                        Leaving: {R2#0R1}
            }

            Block[B4#0R1] - Block
                Predecessors: [B2#0R1]
                Statements (1)
                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
                      Value: 
                        IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: C) (Syntax: 'input2')

                Next (Regular) Block[B5#0R1]
            Block[B5#0R1] - Block
                Predecessors: [B3#0R1] [B4#0R1]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ...  ?? input2;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result = in ... 1 ?? input2')
                          Left: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result')
                          Right: 
                            IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input1 ?? input2')

                Next (Regular) Block[B6#0R1]
                    Leaving: {R1#0R1}
        }

        Block[B6#0R1] - Exit
            Predecessors: [B5#0R1]
            Statements (0)
    }
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,70336,70389);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,70405,70499);

f_22046_70405_70498(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,63364,70510);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,63364,70510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,63364,70510);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,70522,78954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,70676,71028);

string 
source = @"
#pragma warning disable CS8321
class C
{
    void M()
/*<bind>*/{
        void local1(C result1, C input11, C input12)
        {
            result1 = input11 ?? input12;
        }
        void local2(C result2, C input21, C input22)
        {
            result2 = input21 ?? input22;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,71042,78766);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local1(C result1, C input11, C input12)] [void local2(C result2, C input21, C input22)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local1(C result1, C input11, C input12)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
                Entering: {R1#0R1}

        .locals {R1#0R1}
        {
            CaptureIds: [0] [2]
            Block[B1#0R1] - Block
                Predecessors: [B0#0R1]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result1')
                      Value: 
                        IParameterReferenceOperation: result1 (OperationKind.ParameterReference, Type: C) (Syntax: 'result1')

                Next (Regular) Block[B2#0R1]
                    Entering: {R2#0R1}

            .locals {R2#0R1}
            {
                CaptureIds: [1]
                Block[B2#0R1] - Block
                    Predecessors: [B1#0R1]
                    Statements (1)
                        IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input11')
                          Value: 
                            IParameterReferenceOperation: input11 (OperationKind.ParameterReference, Type: C) (Syntax: 'input11')

                    Jump if True (Regular) to Block[B4#0R1]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input11')
                          Operand: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input11')
                        Leaving: {R2#0R1}

                    Next (Regular) Block[B3#0R1]
                Block[B3#0R1] - Block
                    Predecessors: [B2#0R1]
                    Statements (1)
                        IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input11')
                          Value: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input11')

                    Next (Regular) Block[B5#0R1]
                        Leaving: {R2#0R1}
            }

            Block[B4#0R1] - Block
                Predecessors: [B2#0R1]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input12')
                      Value: 
                        IParameterReferenceOperation: input12 (OperationKind.ParameterReference, Type: C) (Syntax: 'input12')

                Next (Regular) Block[B5#0R1]
            Block[B5#0R1] - Block
                Predecessors: [B3#0R1] [B4#0R1]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result1 = i ... ?? input12;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result1 = i ...  ?? input12')
                          Left: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result1')
                          Right: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input11 ?? input12')

                Next (Regular) Block[B6#0R1]
                    Leaving: {R1#0R1}
        }

        Block[B6#0R1] - Exit
            Predecessors: [B5#0R1]
            Statements (0)
    }
    
    {   void local2(C result2, C input21, C input22)
    
        Block[B0#1R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#1R1]
                Entering: {R1#1R1}

        .locals {R1#1R1}
        {
            CaptureIds: [3] [5]
            Block[B1#1R1] - Block
                Predecessors: [B0#1R1]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result2')
                      Value: 
                        IParameterReferenceOperation: result2 (OperationKind.ParameterReference, Type: C) (Syntax: 'result2')

                Next (Regular) Block[B2#1R1]
                    Entering: {R2#1R1}

            .locals {R2#1R1}
            {
                CaptureIds: [4]
                Block[B2#1R1] - Block
                    Predecessors: [B1#1R1]
                    Statements (1)
                        IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input21')
                          Value: 
                            IParameterReferenceOperation: input21 (OperationKind.ParameterReference, Type: C) (Syntax: 'input21')

                    Jump if True (Regular) to Block[B4#1R1]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input21')
                          Operand: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input21')
                        Leaving: {R2#1R1}

                    Next (Regular) Block[B3#1R1]
                Block[B3#1R1] - Block
                    Predecessors: [B2#1R1]
                    Statements (1)
                        IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input21')
                          Value: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input21')

                    Next (Regular) Block[B5#1R1]
                        Leaving: {R2#1R1}
            }

            Block[B4#1R1] - Block
                Predecessors: [B2#1R1]
                Statements (1)
                    IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input22')
                      Value: 
                        IParameterReferenceOperation: input22 (OperationKind.ParameterReference, Type: C) (Syntax: 'input22')

                Next (Regular) Block[B5#1R1]
            Block[B5#1R1] - Block
                Predecessors: [B3#1R1] [B4#1R1]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result2 = i ... ?? input22;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result2 = i ...  ?? input22')
                          Left: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result2')
                          Right: 
                            IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'input21 ?? input22')

                Next (Regular) Block[B6#1R1]
                    Leaving: {R1#1R1}
        }

        Block[B6#1R1] - Exit
            Predecessors: [B5#1R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,78780,78833);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,78849,78943);

f_22046_78849_78942(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,70522,78954);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,70522,78954);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,70522,78954);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,78966,81299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79120,79358);

string 
source = @"
struct C
{
    void M()
/*<bind>*/{
        void d1()
        {
            void d2(bool result1, bool input1)
            {
                result1 = input1;
            }
        };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79374,79418);

var 
compilation = f_22046_79392_79417(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79432,79476);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79490,79545);

var 
semanticModel = f_22046_79510_79544(compilation, tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79559,79722);

var 
graphM = f_22046_79572_79721(f_22046_79618_79720(semanticModel, f_22046_79645_79719(f_22046_79645_79711(f_22046_79645_79677(f_22046_79645_79659(tree))))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79738,79761);

f_22046_79738_79760(graphM);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79775,79802);

f_22046_79775_79801(f_22046_79787_79800(graphM));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79818,79875);

IMethodSymbol 
localFunctionD1 = f_22046_79850_79874(graphM)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79889,79921);

f_22046_79889_79920(localFunctionD1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79935,79976);

f_22046_79935_79975("d1", f_22046_79954_79974(localFunctionD1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,79992,80063);

var 
graphD1 = f_22046_80006_80062(graphM, localFunctionD1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80077,80101);

f_22046_80077_80100(graphD1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80115,80151);

f_22046_80115_80150(graphM, f_22046_80135_80149(graphD1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80165,80257);

var 
graphD1_FromExtension = f_22046_80193_80256(graphM, localFunctionD1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80271,80315);

f_22046_80271_80314(graphD1, graphD1_FromExtension);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80331,80389);

IMethodSymbol 
localFunctionD2 = f_22046_80363_80388(graphD1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80403,80435);

f_22046_80403_80434(localFunctionD2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80449,80490);

f_22046_80449_80489("d2", f_22046_80468_80488(localFunctionD2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80506,80578);

var 
graphD2 = f_22046_80520_80577(graphD1, localFunctionD2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80592,80616);

f_22046_80592_80615(graphD2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80630,80667);

f_22046_80630_80666(graphD1, f_22046_80651_80665(graphD2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80683,80773);

f_22046_80683_80772(() => graphM.GetLocalFunctionControlFlowGraph(null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80787,80894);

f_22046_80787_80893(() => graphM.GetLocalFunctionControlFlowGraph(localFunctionD2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,80908,81005);

f_22046_80908_81004(() => graphM.GetLocalFunctionControlFlowGraphInScope(null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,81019,81133);

f_22046_81019_81132(() => graphM.GetLocalFunctionControlFlowGraphInScope(localFunctionD2));
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,78966,81299);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,78966,81299);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,78966,81299);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,81311,83320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,81465,81631);

string 
source = @"
struct C
{
    void M()
/*<bind>*/{
        void d1() { }
        void d2()
        {
            d1();
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,81647,81691);

var 
compilation = f_22046_81665_81690(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,81705,81749);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,81763,81818);

var 
semanticModel = f_22046_81783_81817(compilation, tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,81832,81995);

var 
graphM = f_22046_81845_81994(f_22046_81891_81993(semanticModel, f_22046_81918_81992(f_22046_81918_81984(f_22046_81918_81950(f_22046_81918_81932(tree))))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82011,82034);

f_22046_82011_82033(graphM);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82048,82075);

f_22046_82048_82074(f_22046_82060_82073(graphM));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82091,82154);

IMethodSymbol 
localFunctionD1 = f_22046_82123_82153(graphM, "d1")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82168,82200);

f_22046_82168_82199(localFunctionD1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82214,82277);

IMethodSymbol 
localFunctionD2 = f_22046_82246_82276(graphM, "d2")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82291,82323);

f_22046_82291_82322(localFunctionD2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82339,82410);

var 
graphD1 = f_22046_82353_82409(graphM, localFunctionD1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82424,82448);

f_22046_82424_82447(graphD1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82462,82498);

f_22046_82462_82497(graphM, f_22046_82482_82496(graphD1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82512,82583);

var 
graphD2 = f_22046_82526_82582(graphM, localFunctionD2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82597,82621);

f_22046_82597_82620(graphD2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82635,82671);

f_22046_82635_82670(graphM, f_22046_82655_82669(graphD2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82687,82779);

var 
graphD1_FromExtension = f_22046_82715_82778(graphM, localFunctionD1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82793,82837);

f_22046_82793_82836(graphD1, graphD1_FromExtension);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82853,82961);

f_22046_82853_82960(() => graphD2.GetLocalFunctionControlFlowGraph(localFunctionD1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,82975,83064);

graphD1_FromExtension = f_22046_82999_83063(graphD2, localFunctionD1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,83078,83122);

f_22046_83078_83121(graphD1, graphD1_FromExtension);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,81311,83320);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,81311,83320);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,81311,83320);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LocalFunctionFlow_StaticWithShadowedVariableReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,83332,91082);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,83519,83798);

string 
source =
@"#pragma warning disable 0219
#pragma warning disable 8321
class C
{
    static void M()
    /*<bind>*/
    {
        object x = null;
        object y = null;
        static object Local(string y, object z) => x ?? y ?? z;
    }
    /*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,83812,90572);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Object x] [System.Object y]
    Methods: [System.Object Local(System.String y, System.Object z)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'x = null')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Object, IsImplicit) (Syntax: 'x = null')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'y = null')
              Left: 
                ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Object, IsImplicit) (Syntax: 'y = null')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')

        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   System.Object Local(System.String y, System.Object z)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
                Entering: {R1#0R1} {R2#0R1}

        .locals {R1#0R1}
        {
            CaptureIds: [1]
            .locals {R2#0R1}
            {
                CaptureIds: [0]
                Block[B1#0R1] - Block
                    Predecessors: [B0#0R1]
                    Statements (1)
                        IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'x')
                          Value: 
                            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Object, IsInvalid) (Syntax: 'x')

                    Jump if True (Regular) to Block[B3#0R1]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'x')
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'x')
                        Leaving: {R2#0R1}
                        Entering: {R3#0R1}

                    Next (Regular) Block[B2#0R1]
                Block[B2#0R1] - Block
                    Predecessors: [B1#0R1]
                    Statements (1)
                        IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'x')
                          Value: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'x')

                    Next (Regular) Block[B6#0R1]
                        Leaving: {R2#0R1}
            }
            .locals {R3#0R1}
            {
                CaptureIds: [2]
                Block[B3#0R1] - Block
                    Predecessors: [B1#0R1]
                    Statements (1)
                        IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
                          Value: 
                            IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.String) (Syntax: 'y')

                    Jump if True (Regular) to Block[B5#0R1]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y')
                          Operand: 
                            IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'y')
                        Leaving: {R3#0R1}

                    Next (Regular) Block[B4#0R1]
                Block[B4#0R1] - Block
                    Predecessors: [B3#0R1]
                    Statements (1)
                        IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
                          Value: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'y')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                (ImplicitReference)
                              Operand: 
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'y')

                    Next (Regular) Block[B6#0R1]
                        Leaving: {R3#0R1}
            }

            Block[B5#0R1] - Block
                Predecessors: [B3#0R1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'z')
                      Value: 
                        IParameterReferenceOperation: z (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'z')

                Next (Regular) Block[B6#0R1]
            Block[B6#0R1] - Block
                Predecessors: [B2#0R1] [B4#0R1] [B5#0R1]
                Statements (0)
                Next (Return) Block[B7#0R1]
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'x ?? y ?? z')
                    Leaving: {R1#0R1}
        }

        Block[B7#0R1] - Exit
            Predecessors: [B6#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,90586,90963);

var 
expectedDiagnostics = new[]
            {
f_22046_90836_90947(f_22046_90836_90926(f_22046_90836_90907(ErrorCode.ERR_StaticLocalFunctionCannotCaptureVariable, "x"), "x"), 10, 52)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,90977,91071);

f_22046_90977_91070(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,83332,91082);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,83332,91082);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,83332,91082);
}
		}

int
f_22046_1690_1812(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 1690, 1812);
return 0;
}


int
f_22046_2893_3015(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 2893, 3015);
return 0;
}


int
f_22046_4066_4188(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 4066, 4188);
return 0;
}


int
f_22046_5484_5606(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 5484, 5606);
return 0;
}


int
f_22046_7630_7752(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 7630, 7752);
return 0;
}


int
f_22046_9654_9776(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 9654, 9776);
return 0;
}


int
f_22046_12266_12424(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 12266, 12424);
return 0;
}


int
f_22046_13359_13481(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 13359, 13481);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_14723_14771(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 14723, 14771);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_14723_14790(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 14723, 14790);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_14723_14809(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 14723, 14809);
return return_v;
}


int
f_22046_14841_14963(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 14841, 14963);
return 0;
}


int
f_22046_16281_16403(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 16281, 16403);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_17608_17654(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 17608, 17654);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_17608_17673(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 17608, 17673);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_17608_17693(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 17608, 17693);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_17916_17962(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 17916, 17962);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_17916_17981(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 17916, 17981);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_17916_18001(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 17916, 18001);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_18193_18249(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 18193, 18249);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_18193_18268(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 18193, 18268);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_18193_18288(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 18193, 18288);
return return_v;
}


int
f_22046_18320_18442(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 18320, 18442);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_19338_19387(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 19338, 19387);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_19338_19407(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 19338, 19407);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_19589_19645(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 19589, 19645);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_19589_19664(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 19589, 19664);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_19589_19684(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 19589, 19684);
return return_v;
}


int
f_22046_19716_19838(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 19716, 19838);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_20590_20635(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 20590, 20635);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_20590_20656(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 20590, 20656);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_20590_20676(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 20590, 20676);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_20895_20948(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 20895, 20948);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_20895_20967(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 20895, 20967);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_20895_20987(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 20895, 20987);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_21144_21200(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 21144, 21200);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_21144_21219(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 21144, 21219);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_21144_21239(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 21144, 21239);
return return_v;
}


int
f_22046_21271_21393(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 21271, 21393);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_22730_22785(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 22730, 22785);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_22730_22811(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 22730, 22811);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_22730_22831(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 22730, 22831);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_23054_23110(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 23054, 23110);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_23054_23129(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 23054, 23129);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_23054_23149(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 23054, 23149);
return return_v;
}


int
f_22046_23181_23303(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 23181, 23303);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_25355_25455(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 25355, 25455);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_25355_25475(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 25355, 25475);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_25675_25731(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 25675, 25731);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_25675_25750(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 25675, 25750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_25675_25770(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 25675, 25770);
return return_v;
}


int
f_22046_25802_25924(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 25802, 25924);
return 0;
}


int
f_22046_26880_27001(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArrowExpressionClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 26880, 27001);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_30326_30397(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 30326, 30397);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_30326_30416(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 30326, 30416);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_30326_30437(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 30326, 30437);
return return_v;
}


int
f_22046_30467_30589(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 30467, 30589);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_34526_34600(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 34526, 34600);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_34526_34620(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 34526, 34620);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_34860_34930(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 34860, 34930);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_34860_34950(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 34860, 34950);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_35190_35260(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 35190, 35260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_35190_35280(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 35190, 35280);
return return_v;
}


int
f_22046_35310_35432(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalFunctionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 35310, 35432);
return 0;
}


int
f_22046_39019_39112(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 39019, 39112);
return 0;
}


int
f_22046_41052_41145(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 41052, 41145);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_42381_42428(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 42381, 42428);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_42381_42448(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 42381, 42448);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_42659_42718(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 42659, 42718);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_42659_42753(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 42659, 42753);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_42659_42773(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 42659, 42773);
return return_v;
}


int
f_22046_42805_42898(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 42805, 42898);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_46125_46313(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 46125, 46313);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_46125_46332(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 46125, 46332);
return return_v;
}


int
f_22046_46364_46457(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 46364, 46457);
return 0;
}


int
f_22046_49606_49699(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 49606, 49699);
return 0;
}


int
f_22046_56252_56345(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 56252, 56345);
return 0;
}


int
f_22046_58365_58458(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 58365, 58458);
return 0;
}


int
f_22046_63247_63340(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 63247, 63340);
return 0;
}


int
f_22046_70405_70498(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 70405, 70498);
return 0;
}


int
f_22046_78849_78942(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 78849, 78942);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22046_79392_79417(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79392, 79417);
return return_v;
}


Microsoft.CodeAnalysis.SemanticModel
f_22046_79510_79544(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree)
{
var return_v = this_param.GetSemanticModel( syntaxTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79510, 79544);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22046_79645_79659(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79645, 79659);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22046_79645_79677(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79645, 79677);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22046_79645_79711(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79645, 79711);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22046_79645_79719(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79645, 79719);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_22046_79618_79720(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
node)
{
var return_v = this_param.GetOperation( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79618, 79720);
return return_v;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_79572_79721(Microsoft.CodeAnalysis.IOperation?
methodBody)
{
var return_v = ControlFlowGraph.Create( (Microsoft.CodeAnalysis.Operations.IMethodBodyOperation?)methodBody);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79572, 79721);
return return_v;
}


int
f_22046_79738_79760(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79738, 79760);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
f_22046_79787_79800(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22046, 79787, 79800);
return return_v;
}


int
f_22046_79775_79801(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79775, 79801);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_22046_79850_79874(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
graph)
{
var return_v = getLocalFunction( graph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79850, 79874);
return return_v;
}


int
f_22046_79889_79920(Microsoft.CodeAnalysis.IMethodSymbol
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79889, 79920);
return 0;
}


string
f_22046_79954_79974(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22046, 79954, 79974);
return return_v;
}


int
f_22046_79935_79975(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 79935, 79975);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_80006_80062(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param,Microsoft.CodeAnalysis.IMethodSymbol
localFunction)
{
var return_v = this_param.GetLocalFunctionControlFlowGraph( localFunction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80006, 80062);
return return_v;
}


int
f_22046_80077_80100(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80077, 80100);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
f_22046_80135_80149(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22046, 80135, 80149);
return return_v;
}


int
f_22046_80115_80150(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
expected,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
actual)
{
Assert.Same( (object)expected, (object?)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80115, 80150);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_80193_80256(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
controlFlowGraph,Microsoft.CodeAnalysis.IMethodSymbol
localFunction)
{
var return_v = controlFlowGraph.GetLocalFunctionControlFlowGraphInScope( localFunction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80193, 80256);
return return_v;
}


int
f_22046_80271_80314(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
expected,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
actual)
{
Assert.Same( (object)expected, (object)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80271, 80314);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_22046_80363_80388(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
graph)
{
var return_v = getLocalFunction( graph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80363, 80388);
return return_v;
}


int
f_22046_80403_80434(Microsoft.CodeAnalysis.IMethodSymbol
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80403, 80434);
return 0;
}


string
f_22046_80468_80488(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22046, 80468, 80488);
return return_v;
}


int
f_22046_80449_80489(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80449, 80489);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_80520_80577(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param,Microsoft.CodeAnalysis.IMethodSymbol
localFunction)
{
var return_v = this_param.GetLocalFunctionControlFlowGraph( localFunction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80520, 80577);
return return_v;
}


int
f_22046_80592_80615(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80592, 80615);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
f_22046_80651_80665(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22046, 80651, 80665);
return return_v;
}


int
f_22046_80630_80666(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
expected,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
actual)
{
Assert.Same( (object)expected, (object?)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80630, 80666);
return 0;
}


System.ArgumentNullException
f_22046_80683_80772(System.Func<object>
testCode)
{
var return_v = Assert.Throws<ArgumentNullException>( testCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80683, 80772);
return return_v;
}


System.ArgumentOutOfRangeException
f_22046_80787_80893(System.Func<object>
testCode)
{
var return_v = Assert.Throws<ArgumentOutOfRangeException>( testCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80787, 80893);
return return_v;
}


System.ArgumentNullException
f_22046_80908_81004(System.Func<object>
testCode)
{
var return_v = Assert.Throws<ArgumentNullException>( testCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 80908, 81004);
return return_v;
}


System.ArgumentOutOfRangeException
f_22046_81019_81132(System.Func<object>
testCode)
{
var return_v = Assert.Throws<ArgumentOutOfRangeException>( testCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81019, 81132);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22046_81665_81690(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81665, 81690);
return return_v;
}


Microsoft.CodeAnalysis.SemanticModel
f_22046_81783_81817(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree)
{
var return_v = this_param.GetSemanticModel( syntaxTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81783, 81817);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22046_81918_81932(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81918, 81932);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22046_81918_81950(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81918, 81950);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
f_22046_81918_81984(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81918, 81984);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_22046_81918_81992(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81918, 81992);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_22046_81891_81993(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
node)
{
var return_v = this_param.GetOperation( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81891, 81993);
return return_v;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_81845_81994(Microsoft.CodeAnalysis.IOperation?
methodBody)
{
var return_v = ControlFlowGraph.Create( (Microsoft.CodeAnalysis.Operations.IMethodBodyOperation?)methodBody);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 81845, 81994);
return return_v;
}


int
f_22046_82011_82033(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82011, 82033);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
f_22046_82060_82073(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22046, 82060, 82073);
return return_v;
}


int
f_22046_82048_82074(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82048, 82074);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_22046_82123_82153(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
graph,string
name)
{
var return_v = getLocalFunction( graph, name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82123, 82153);
return return_v;
}


int
f_22046_82168_82199(Microsoft.CodeAnalysis.IMethodSymbol
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82168, 82199);
return 0;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_22046_82246_82276(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
graph,string
name)
{
var return_v = getLocalFunction( graph, name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82246, 82276);
return return_v;
}


int
f_22046_82291_82322(Microsoft.CodeAnalysis.IMethodSymbol
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82291, 82322);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_82353_82409(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param,Microsoft.CodeAnalysis.IMethodSymbol
localFunction)
{
var return_v = this_param.GetLocalFunctionControlFlowGraph( localFunction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82353, 82409);
return return_v;
}


int
f_22046_82424_82447(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82424, 82447);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
f_22046_82482_82496(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22046, 82482, 82496);
return return_v;
}


int
f_22046_82462_82497(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
expected,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
actual)
{
Assert.Same( (object)expected, (object?)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82462, 82497);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_82526_82582(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param,Microsoft.CodeAnalysis.IMethodSymbol
localFunction)
{
var return_v = this_param.GetLocalFunctionControlFlowGraph( localFunction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82526, 82582);
return return_v;
}


int
f_22046_82597_82620(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82597, 82620);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
f_22046_82655_82669(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22046, 82655, 82669);
return return_v;
}


int
f_22046_82635_82670(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
expected,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
actual)
{
Assert.Same( (object)expected, (object?)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82635, 82670);
return 0;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_82715_82778(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
controlFlowGraph,Microsoft.CodeAnalysis.IMethodSymbol
localFunction)
{
var return_v = controlFlowGraph.GetLocalFunctionControlFlowGraphInScope( localFunction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82715, 82778);
return return_v;
}


int
f_22046_82793_82836(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
expected,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
actual)
{
Assert.Same( (object)expected, (object)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82793, 82836);
return 0;
}


System.ArgumentOutOfRangeException
f_22046_82853_82960(System.Func<object>
testCode)
{
var return_v = Assert.Throws<ArgumentOutOfRangeException>( testCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82853, 82960);
return return_v;
}


Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
f_22046_82999_83063(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
controlFlowGraph,Microsoft.CodeAnalysis.IMethodSymbol
localFunction)
{
var return_v = controlFlowGraph.GetLocalFunctionControlFlowGraphInScope( localFunction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 82999, 83063);
return return_v;
}


int
f_22046_83078_83121(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
expected,Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
actual)
{
Assert.Same( (object)expected, (object)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 83078, 83121);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_90836_90907(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 90836, 90907);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_90836_90926(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 90836, 90926);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22046_90836_90947(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 90836, 90947);
return return_v;
}


int
f_22046_90977_91070(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22046, 90977, 91070);
return 0;
}


            
IMethodSymbol 
getLocalFunction(ControlFlowGraph graph)
		
{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,81149,81288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,81236,81273);

return graph.LocalFunctions.Single();
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,81149,81288);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,81149,81288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,81149,81288);
}
			throw new System.Exception("Slicer error: unreachable code");
		}



            
IMethodSymbol 
getLocalFunction(ControlFlowGraph graph, string name)
		
{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22046,83138,83309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22046,83238,83294);

return graph.LocalFunctions.Single(l => l.Name == name);
DynAbs.Tracing.TraceSender.TraceExitMethod(22046,83138,83309);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22046,83138,83309);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22046,83138,83309);
}
			throw new System.Exception("Slicer error: unreachable code");
		}


}
}
