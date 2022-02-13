// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void FixedStatement_FixedClassVariableAndPrint()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,524,4652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,673,951);

string 
source = @"
using System;

class C
{
    private int i;

    void M1()
    {
        unsafe
        {
            /*<bind>*/fixed(int *p = &i)
            {
                Console.WriteLine($""P is {*p}"");
            }/*</bind>*/
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,965,4378);

string 
expectedOperationTree = @"
IFixedOperation (OperationKind.None, Type: null) (Syntax: 'fixed(int * ... }')
  Locals: Local_1: System.Int32* p
  Declaration: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int *p = &i')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int *p = &i')
        Declarators:
            IVariableDeclaratorOperation (Symbol: System.Int32* p) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p = &i')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &i')
                  IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i')
                    Children(1):
                        IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i')
                          Reference: 
                            IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'i')
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ...  is {*p}"");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... P is {*p}"")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '$""P is {*p}""')
                  IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""P is {*p}""')
                    Parts(2):
                        IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'P is ')
                          Text: 
                            ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""P is "", IsImplicit) (Syntax: 'P is ')
                        IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{*p}')
                          Expression: 
                            IOperation:  (OperationKind.None, Type: null) (Syntax: '*p')
                              Children(1):
                                  ILocalReferenceOperation: p (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'p')
                          Alignment: 
                            null
                          FormatString: 
                            null
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,4392,4445);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,4461,4641);

f_22034_4461_4640(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,524,4652);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,524,4652);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,524,4652);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void FixedStatement_MultipleDeclarators()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,4664,8940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,4806,5117);

string 
source = @"
using System;

class C
{
    private int i1;
    private int i2;

    void M1()
    {
        int i3;
        unsafe
        {
            /*<bind>*/fixed (int* p1 = &i1, p2 = &i2)
            {
                i3 = *p1 + *p2;
            }/*</bind>*/
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,5131,8664);

string 
expectedOperationTree = @"
IFixedOperation (OperationKind.None, Type: null) (Syntax: 'fixed (int* ... }')
  Locals: Local_1: System.Int32* p1
    Local_2: System.Int32* p2
  Declaration: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int* p1 = &i1, p2 = &i2')
      IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int* p1 = &i1, p2 = &i2')
        Declarators:
            IVariableDeclaratorOperation (Symbol: System.Int32* p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = &i1')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &i1')
                  IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i1')
                    Children(1):
                        IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i1')
                          Reference: 
                            IFieldReferenceOperation: System.Int32 C.i1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i1')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'i1')
            IVariableDeclaratorOperation (Symbol: System.Int32* p2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p2 = &i2')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &i2')
                  IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i2')
                    Children(1):
                        IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i2')
                          Reference: 
                            IFieldReferenceOperation: System.Int32 C.i2 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i2')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'i2')
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i3 = *p1 + *p2;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i3 = *p1 + *p2')
            Left: 
              ILocalReferenceOperation: i3 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i3')
            Right: 
              IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: '*p1 + *p2')
                Left: 
                  IOperation:  (OperationKind.None, Type: null) (Syntax: '*p1')
                    Children(1):
                        ILocalReferenceOperation: p1 (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'p1')
                Right: 
                  IOperation:  (OperationKind.None, Type: null) (Syntax: '*p2')
                    Children(1):
                        ILocalReferenceOperation: p2 (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'p2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,8680,8733);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,8749,8929);

f_22034_8749_8928(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,4664,8940);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,4664,8940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,4664,8940);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void FixedStatement_MultipleFixedStatements()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,8954,13828);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,9100,9436);

string 
source = @"
using System;

class C
{
    private int i1;
    private int i2;

    void M1()
    {
        int i3;
        unsafe
        {
            /*<bind>*/fixed (int* p1 = &i1)
            fixed (int* p2 = &i2)
            {
                i3 = *p1 + *p2;
            }/*</bind>*/
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,9450,13552);

string 
expectedOperationTree = @"
IFixedOperation (OperationKind.None, Type: null) (Syntax: 'fixed (int* ... }')
  Locals: Local_1: System.Int32* p1
  Declaration: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int* p1 = &i1')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int* p1 = &i1')
        Declarators:
            IVariableDeclaratorOperation (Symbol: System.Int32* p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = &i1')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &i1')
                  IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i1')
                    Children(1):
                        IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i1')
                          Reference: 
                            IFieldReferenceOperation: System.Int32 C.i1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i1')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'i1')
        Initializer: 
          null
  Body: 
    IFixedOperation (OperationKind.None, Type: null) (Syntax: 'fixed (int* ... }')
      Locals: Local_1: System.Int32* p2
      Declaration: 
        IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int* p2 = &i2')
          IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int* p2 = &i2')
            Declarators:
                IVariableDeclaratorOperation (Symbol: System.Int32* p2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p2 = &i2')
                  Initializer: 
                    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &i2')
                      IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i2')
                        Children(1):
                            IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i2')
                              Reference: 
                                IFieldReferenceOperation: System.Int32 C.i2 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i2')
                                  Instance Receiver: 
                                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'i2')
            Initializer: 
              null
      Body: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i3 = *p1 + *p2;')
            Expression: 
              ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i3 = *p1 + *p2')
                Left: 
                  ILocalReferenceOperation: i3 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i3')
                Right: 
                  IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: '*p1 + *p2')
                    Left: 
                      IOperation:  (OperationKind.None, Type: null) (Syntax: '*p1')
                        Children(1):
                            ILocalReferenceOperation: p1 (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'p1')
                    Right: 
                      IOperation:  (OperationKind.None, Type: null) (Syntax: '*p2')
                        Children(1):
                            ILocalReferenceOperation: p2 (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'p2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,13568,13621);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,13637,13817);

f_22034_13637_13816(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,8954,13828);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,8954,13828);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,8954,13828);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void FixedStatement_InvalidVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,13840,16423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,13978,14225);

string 
source = @"
using System;

class C
{
    void M1()
    {
        int i3;
        unsafe
        {
            /*<bind>*/fixed (int* p1 =)
            {
                i3 = *p1;
            }/*</bind>*/
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,14239,15910);

string 
expectedOperationTree = @"
IFixedOperation (OperationKind.None, Type: null, IsInvalid) (Syntax: 'fixed (int* ... }')
  Locals: Local_1: System.Int32* p1
  Declaration: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid, IsImplicit) (Syntax: 'int* p1 =')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int* p1 =')
        Declarators:
            IVariableDeclaratorOperation (Symbol: System.Int32* p1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p1 =')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=')
                  IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                    Children(0)
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i3 = *p1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i3 = *p1')
            Left: 
              ILocalReferenceOperation: i3 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i3')
            Right: 
              IOperation:  (OperationKind.None, Type: null) (Syntax: '*p1')
                Children(1):
                    ILocalReferenceOperation: p1 (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'p1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,15924,16216);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22034_16113_16199(f_22034_16113_16178(f_22034_16113_16159(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 11, 39),
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,16232,16412);

f_22034_16232_16411(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,13840,16423);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,13840,16423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,13840,16423);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void FixedStatement_InvalidBody()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,16435,20042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,16569,16843);

string 
source = @"
using System;

class C
{
    private int i1;

    void M1()
    {
        int i3;
        unsafe
        {
            /*<bind>*/fixed (int* p1 = &i1)
            {
                i3 = &p1;
            }/*</bind>*/
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,16857,19429);

string 
expectedOperationTree = @"
IFixedOperation (OperationKind.None, Type: null, IsInvalid) (Syntax: 'fixed (int* ... }')
  Locals: Local_1: System.Int32* p1
  Declaration: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'int* p1 = &i1')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int* p1 = &i1')
        Declarators:
            IVariableDeclaratorOperation (Symbol: System.Int32* p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = &i1')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &i1')
                  IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i1')
                    Children(1):
                        IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i1')
                          Reference: 
                            IFieldReferenceOperation: System.Int32 C.i1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i1')
                              Instance Receiver: 
                                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'i1')
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'i3 = &p1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i3 = &p1')
            Left: 
              ILocalReferenceOperation: i3 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i3')
            Right: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '&p1')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32**, IsInvalid) (Syntax: '&p1')
                    Reference: 
                      ILocalReferenceOperation: p1 (OperationKind.LocalReference, Type: System.Int32*, IsInvalid) (Syntax: 'p1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,19443,19835);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22034_19717_19819(f_22034_19717_19798(f_22034_19717_19768(ErrorCode.ERR_NoImplicitConvCast, "&p1"), "int**", "int"), 15, 22)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,19851,20031);

f_22034_19851_20030(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,16435,20042);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,16435,20042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,16435,20042);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FixedStatement_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,20054,24695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,20205,20441);

string 
source = @"
unsafe public class MyClass
{
    int i;
    unsafe void M(bool b)
    /*<bind>*/{
        fixed (int* p = &i)
        {
            System.Console.WriteLine($""P is {p}"");
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,20455,20790);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22034_20677_20774(f_22034_20677_20754(f_22034_20677_20722(ErrorCode.ERR_NoImplicitConv, "p"), "int*", "object"), 9, 46)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,21237,24524);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32* p]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32*, IsImplicit) (Syntax: 'p = &i')
              Left: 
                ILocalReferenceOperation: p (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32*, IsImplicit) (Syntax: 'p = &i')
              Right: 
                IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i')
                  Children(1):
                      IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i')
                        Reference: 
                          IFieldReferenceOperation: System.Int32 MyClass.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
                            Instance Receiver: 
                              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass, IsImplicit) (Syntax: 'i')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'System.Cons ... P is {p}"");')
              Expression: 
                IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'System.Cons ... ""P is {p}"")')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '$""P is {p}""')
                        IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, IsInvalid) (Syntax: '$""P is {p}""')
                          Parts(2):
                              IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'P is ')
                                Text: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""P is "", IsImplicit) (Syntax: 'P is ')
                              IInterpolationOperation (OperationKind.Interpolation, Type: null, IsInvalid) (Syntax: '{p}')
                                Expression: 
                                  ILocalReferenceOperation: p (OperationKind.LocalReference, Type: System.Int32*, IsInvalid) (Syntax: 'p')
                                Alignment: 
                                  null
                                FormatString: 
                                  null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,24538,24684);

f_22034_24538_24683(source, expectedFlowGraph, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,20054,24695);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,20054,24695);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,20054,24695);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FixedStatement_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,24707,29712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,24858,25148);

string 
source = @"
unsafe public class MyClass
{
    int i;
    unsafe void M(bool b)
    /*<bind>*/{
        fixed (int* p = &i)
        {
            if (b)
            {
                System.Console.WriteLine($""P is {p}"");
            }
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,25162,25502);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22034_25388_25486(f_22034_25388_25465(f_22034_25388_25433(ErrorCode.ERR_NoImplicitConv, "p"), "int*", "object"), 11, 50)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,25949,29541);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32* p]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32*, IsImplicit) (Syntax: 'p = &i')
              Left: 
                ILocalReferenceOperation: p (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32*, IsImplicit) (Syntax: 'p = &i')
              Right: 
                IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i')
                  Children(1):
                      IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i')
                        Reference: 
                          IFieldReferenceOperation: System.Int32 MyClass.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
                            Instance Receiver: 
                              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass, IsImplicit) (Syntax: 'i')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'System.Cons ... P is {p}"");')
              Expression: 
                IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'System.Cons ... ""P is {p}"")')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '$""P is {p}""')
                        IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String, IsInvalid) (Syntax: '$""P is {p}""')
                          Parts(2):
                              IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'P is ')
                                Text: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""P is "", IsImplicit) (Syntax: 'P is ')
                              IInterpolationOperation (OperationKind.Interpolation, Type: null, IsInvalid) (Syntax: '{p}')
                                Expression: 
                                  ILocalReferenceOperation: p (OperationKind.LocalReference, Type: System.Int32*, IsInvalid) (Syntax: 'p')
                                Alignment: 
                                  null
                                FormatString: 
                                  null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,29555,29701);

f_22034_29555_29700(source, expectedFlowGraph, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,24707,29712);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,24707,29712);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,24707,29712);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FixedStatement_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,29724,36826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,29875,30182);

string 
source = @"
unsafe public class MyClass
{
    int i1, i2;
    unsafe void M(bool b)
    /*<bind>*/{
        fixed (int* p = b ? &i1 : &i2)
        {
            if (b)
            {
                System.Console.WriteLine($""P is {*p}"");
            }
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,30196,30796);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22034_30451_30515(f_22034_30451_30495(ErrorCode.ERR_FixedNeeded, "&i1"), 7, 29),
f_22034_30716_30780(f_22034_30716_30760(ErrorCode.ERR_FixedNeeded, "&i2"), 7, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,31243,36655);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32* p]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Jump if False (Regular) to Block[B3]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '&i1')
                  Value: 
                    IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*, IsInvalid) (Syntax: '&i1')
                      Reference: 
                        IFieldReferenceOperation: System.Int32 MyClass.i1 (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass, IsInvalid, IsImplicit) (Syntax: 'i1')

            Next (Regular) Block[B4]
        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: '&i2')
                  Value: 
                    IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*, IsInvalid) (Syntax: '&i2')
                      Reference: 
                        IFieldReferenceOperation: System.Int32 MyClass.i2 (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'i2')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: MyClass, IsInvalid, IsImplicit) (Syntax: 'i2')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32*, IsInvalid, IsImplicit) (Syntax: 'p = b ? &i1 : &i2')
                  Left: 
                    ILocalReferenceOperation: p (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32*, IsInvalid, IsImplicit) (Syntax: 'p = b ? &i1 : &i2')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32*, IsInvalid, IsImplicit) (Syntax: 'b ? &i1 : &i2')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B4]
        Statements (0)
        Jump if False (Regular) to Block[B7]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
            Leaving: {R1}

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ...  is {*p}"");')
              Expression: 
                IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... P is {*p}"")')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '$""P is {*p}""')
                        IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""P is {*p}""')
                          Parts(2):
                              IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'P is ')
                                Text: 
                                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""P is "", IsImplicit) (Syntax: 'P is ')
                              IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{*p}')
                                Expression: 
                                  IOperation:  (OperationKind.None, Type: null) (Syntax: '*p')
                                    Children(1):
                                        ILocalReferenceOperation: p (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'p')
                                Alignment: 
                                  null
                                FormatString: 
                                  null
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,36669,36815);

f_22034_36669_36814(source, expectedFlowGraph, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,29724,36826);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,29724,36826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,29724,36826);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FixedFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,36838,40303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,36984,37228);

string 
source = @"
class P
{
    void M(object x)
/*<bind>*/{
        unsafe
        {
            fixed(int *p = &i)
            {
                x?.ToString();
            }
        }
    }/*</bind>*/

    private int i;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,37242,40067);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32* p]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32*, IsImplicit) (Syntax: 'p = &i')
              Left: 
                ILocalReferenceOperation: p (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32*, IsImplicit) (Syntax: 'p = &i')
              Right: 
                IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i')
                  Children(1):
                      IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i')
                        Reference: 
                          IFieldReferenceOperation: System.Int32 P.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
                            Instance Receiver: 
                              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'i')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [0]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
                  Value: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'x')
                Leaving: {R2} {R1}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x?.ToString();')
                  Expression: 
                    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '.ToString()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'x')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,40081,40134);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,40150,40292);

f_22034_40150_40291(source, expectedGraph, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,36838,40303);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,36838,40303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,36838,40303);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FixedFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22034,40315,46040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,40461,40753);

string 
source = @"
class P
{
    void M(bool x, P input)
/*<bind>*/{
        unsafe
        {
            fixed(int *p1 = &i, p2 = &(input ?? this).j)
            {
                x = true;
            }
        }
    }/*</bind>*/

    private int i;
    private int j;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,40767,45804);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32* p1] [System.Int32* p2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32*, IsImplicit) (Syntax: 'p1 = &i')
              Left: 
                ILocalReferenceOperation: p1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32*, IsImplicit) (Syntax: 'p1 = &i')
              Right: 
                IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&i')
                  Children(1):
                      IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&i')
                        Reference: 
                          IFieldReferenceOperation: System.Int32 P.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
                            Instance Receiver: 
                              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'i')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [1]
        .locals {R3}
        {
            CaptureIds: [0]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                      Value: 
                        IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: P) (Syntax: 'input')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'input')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'input')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'this')
                  Value: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32*, IsImplicit) (Syntax: 'p2 = &(input ?? this).j')
                  Left: 
                    ILocalReferenceOperation: p2 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32*, IsImplicit) (Syntax: 'p2 = &(input ?? this).j')
                  Right: 
                    IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&(input ?? this).j')
                      Children(1):
                          IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&(input ?? this).j')
                            Reference: 
                              IFieldReferenceOperation: System.Int32 P.j (OperationKind.FieldReference, Type: System.Int32) (Syntax: '(input ?? this).j')
                                Instance Receiver: 
                                  IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'input ?? this')

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'x = true')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,45818,45871);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22034,45887,46029);

f_22034_45887_46028(source, expectedGraph, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22034,40315,46040);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22034,40315,46040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22034,40315,46040);
}
		}

int
f_22034_4461_4640(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<FixedStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 4461, 4640);
return 0;
}


int
f_22034_8749_8928(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<FixedStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 8749, 8928);
return 0;
}


int
f_22034_13637_13816(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<FixedStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 13637, 13816);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_16113_16159(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 16113, 16159);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_16113_16178(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 16113, 16178);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_16113_16199(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 16113, 16199);
return return_v;
}


int
f_22034_16232_16411(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<FixedStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 16232, 16411);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_19717_19768(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 19717, 19768);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_19717_19798(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 19717, 19798);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_19717_19819(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 19717, 19819);
return return_v;
}


int
f_22034_19851_20030(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<FixedStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 19851, 20030);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_20677_20722(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 20677, 20722);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_20677_20754(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 20677, 20754);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_20677_20774(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 20677, 20774);
return return_v;
}


int
f_22034_24538_24683(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 24538, 24683);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_25388_25433(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 25388, 25433);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_25388_25465(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 25388, 25465);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_25388_25486(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 25388, 25486);
return return_v;
}


int
f_22034_29555_29700(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 29555, 29700);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_30451_30495(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 30451, 30495);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_30451_30515(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 30451, 30515);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_30716_30760(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 30716, 30760);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22034_30716_30780(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 30716, 30780);
return return_v;
}


int
f_22034_36669_36814(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 36669, 36814);
return 0;
}


int
f_22034_40150_40291(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 40150, 40291);
return 0;
}


int
f_22034_45887_46028(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22034, 45887, 46028);
return 0;
}

}
}
