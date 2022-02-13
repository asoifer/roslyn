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
        [Fact]
        public void IUsingStatement_SimpleUsingNewVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,501,3460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,647,923);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        /*<bind>*/using (var c = new C())
        {
            Console.WriteLine(c.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,937,3251);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (var  ... }')
  Locals: Local_1: C c
  Resources: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var c = new C()')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c = new C()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c.ToString()')
                  IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c.ToString()')
                    Instance Receiver: 
                      ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
                    Arguments(0)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,3265,3318);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,3334,3449);

f_22074_3334_3448(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,501,3460);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,501,3460);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,501,3460);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.AsyncStreams)]
        [Fact, WorkItem(30362, "https://github.com/dotnet/roslyn/issues/30362")]
        public void IUsingAwaitStatement_SimpleAwaitUsing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,3472,6635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,3713,4045);

string 
source = @"
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

class C
{
    public static async Task M1(IAsyncDisposable disposable)
    {
        /*<bind>*/await using (var c = disposable)
        {
            Console.WriteLine(c.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,4059,6391);

string 
expectedOperationTree = @"
IUsingOperation (IsAsynchronous) (OperationKind.Using, Type: null) (Syntax: 'await using ... }')
  Locals: Local_1: System.IAsyncDisposable c
  Resources: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var c = disposable')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c = disposable')
        Declarators:
            IVariableDeclaratorOperation (Symbol: System.IAsyncDisposable c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = disposable')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= disposable')
                  IParameterReferenceOperation: disposable (OperationKind.ParameterReference, Type: System.IAsyncDisposable) (Syntax: 'disposable')
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c.ToString()')
                  IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c.ToString()')
                    Instance Receiver: 
                      ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.IAsyncDisposable) (Syntax: 'c')
                    Arguments(0)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,6407,6460);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,6474,6624);

f_22074_6474_6623(source + s_IAsyncEnumerable + s_ValueTask, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,3472,6635);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,3472,6635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,3472,6635);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow, CompilerFeature.AsyncStreams)]
        [Fact, WorkItem(30362, "https://github.com/dotnet/roslyn/issues/30362")]
        public void UsingFlow_SimpleAwaitUsing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,6647,11354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,6903,7235);

string 
source = @"
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

class C
{
    public static async Task M1(IAsyncDisposable disposable)
    /*<bind>*/{
        await using (var c = disposable)
        {
            Console.WriteLine(c.ToString());
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,7251,11131);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.IAsyncDisposable c]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'c = disposable')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'c = disposable')
              Right: 
                IParameterReferenceOperation: disposable (OperationKind.ParameterReference, Type: System.IAsyncDisposable) (Syntax: 'disposable')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
                  Expression: 
                    IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c.ToString()')
                            IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c.ToString()')
                              Instance Receiver: 
                                ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.IAsyncDisposable) (Syntax: 'c')
                              Arguments(0)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c = disposable')
                  Operand: 
                    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'c = disposable')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'c = disposable')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsImplicit) (Syntax: 'c = disposable')
                      Instance Receiver: 
                        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.IAsyncDisposable, IsImplicit) (Syntax: 'c = disposable')
                      Arguments(0)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,11145,11198);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,11214,11343);

f_22074_11214_11342(source + s_IAsyncEnumerable + s_ValueTask, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,6647,11354);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,6647,11354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,6647,11354);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_MultipleNewVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,11366,14897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,11509,11809);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        
        /*<bind>*/using (C c1 = new C(), c2 = new C())
        {
            Console.WriteLine(c1.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,11823,14688);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (C c1 ... }')
  Locals: Local_1: C c1
    Local_2: C c2
  Resources: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'C c1 = new  ... 2 = new C()')
      IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C c1 = new  ... 2 = new C()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: C c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
            IVariableDeclaratorOperation (Symbol: C c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c1.ToString()')
                  IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c1.ToString()')
                    Instance Receiver: 
                      ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C) (Syntax: 'c1')
                    Arguments(0)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,14702,14755);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,14771,14886);

f_22074_14771_14885(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,11366,14897);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,11366,14897);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,11366,14897);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_SimpleUsingStatementExistingResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,14909,17116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,15069,15357);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        var c = new C();
        /*<bind>*/using (c)
        {
            Console.WriteLine(c.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,15371,16907);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (c) ... }')
  Resources: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c.ToString()')
                  IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c.ToString()')
                    Instance Receiver: 
                      ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
                    Arguments(0)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,16921,16974);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,16990,17105);

f_22074_16990_17104(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,14909,17116);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,14909,17116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,14909,17116);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_NestedUsingNewResources()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,17128,21864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,17275,17603);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        /*<bind>*/using (var c1 = new C())
        using (var c2 = new C())
        {
            Console.WriteLine(c1.ToString() + c2.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,17617,21655);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (var  ... }')
  Locals: Local_1: C c1
  Resources: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var c1 = new C()')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c1 = new C()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: C c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
  Body: 
    IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (var  ... }')
      Locals: Local_1: C c2
      Resources: 
        IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var c2 = new C()')
          IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c2 = new C()')
            Declarators:
                IVariableDeclaratorOperation (Symbol: C c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = new C()')
                  Initializer: 
                    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                      IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                        Arguments(0)
                        Initializer: 
                          null
            Initializer: 
              null
      Body: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
            Expression: 
              IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
                Instance Receiver: 
                  null
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c1.ToString ... .ToString()')
                      IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String) (Syntax: 'c1.ToString ... .ToString()')
                        Left: 
                          IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c1.ToString()')
                            Instance Receiver: 
                              ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C) (Syntax: 'c1')
                            Arguments(0)
                        Right: 
                          IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c2.ToString()')
                            Instance Receiver: 
                              ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C) (Syntax: 'c2')
                            Arguments(0)
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,21669,21722);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,21738,21853);

f_22074_21738_21852(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,17128,21864);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,17128,21864);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,17128,21864);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_NestedUsingExistingResources()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,21876,25035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,22028,22382);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        var c1 = new C();
        var c2 = new C();
        /*<bind>*/using (c1)
        using (c2)
        {
            Console.WriteLine(c1.ToString() + c2.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,22396,24826);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (c1) ... }')
  Resources: 
    ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C) (Syntax: 'c1')
  Body: 
    IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (c2) ... }')
      Resources: 
        ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C) (Syntax: 'c2')
      Body: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
            Expression: 
              IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
                Instance Receiver: 
                  null
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c1.ToString ... .ToString()')
                      IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String) (Syntax: 'c1.ToString ... .ToString()')
                        Left: 
                          IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c1.ToString()')
                            Instance Receiver: 
                              ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C) (Syntax: 'c1')
                            Arguments(0)
                        Right: 
                          IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c2.ToString()')
                            Instance Receiver: 
                              ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C) (Syntax: 'c2')
                            Arguments(0)
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,24840,24893);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,24909,25024);

f_22074_24909_25023(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,21876,25035);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,21876,25035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,21876,25035);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_InvalidMultipleVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,25047,29616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,25205,25513);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        /*<bind>*/using (var c1 = new C(), c2 = new C())
        {
            Console.WriteLine(c1.ToString() + c2.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,25527,29084);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using (var  ... }')
  Locals: Local_1: C c1
    Local_2: C c2
  Resources: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid, IsImplicit) (Syntax: 'var c1 = ne ... 2 = new C()')
      IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var c1 = ne ... 2 = new C()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: C c1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1 = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
            IVariableDeclaratorOperation (Symbol: C c2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c2 = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c1.ToString ... .ToString()')
                  IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String) (Syntax: 'c1.ToString ... .ToString()')
                    Left: 
                      IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c1.ToString()')
                        Instance Receiver: 
                          ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C) (Syntax: 'c1')
                        Arguments(0)
                    Right: 
                      IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c2.ToString()')
                        Instance Receiver: 
                          ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C) (Syntax: 'c2')
                        Arguments(0)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,29098,29474);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22074_29336_29458(f_22074_29336_29437(ErrorCode.ERR_ImplicitlyTypedVariableMultipleDeclarator, "var c1 = new C(), c2 = new C()"), 12, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,29490,29605);

f_22074_29490_29604(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,25047,29616);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,25047,29616);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,25047,29616);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IOperationTests_MultipleExistingResourcesPassed()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,29628,36037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,29783,30121);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    /*<bind>*/{
        var c1 = new C();
        var c2 = new C();
        using (c1, c2)
        {
            Console.WriteLine(c1.ToString() + c2.ToString());
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,30415,34771);

string 
expectedOperationTree = @"
IBlockOperation (5 statements, 2 locals) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  Locals: Local_1: C c1
    Local_2: C c2
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var c1 = new C();')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c1 = new C()')
      Declarators:
          IVariableDeclaratorOperation (Symbol: C c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = new C()')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                  Arguments(0)
                  Initializer: 
                    null
      Initializer: 
        null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'var c2 = new C();')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c2 = new C()')
      Declarators:
          IVariableDeclaratorOperation (Symbol: C c2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c2 = new C()')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                  Arguments(0)
                  Initializer: 
                    null
      Initializer: 
        null
  IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using (c1')
    Resources: 
      ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c1')
    Body: 
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
            Children(0)
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'c2')
    Expression: 
      ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c2')
  IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
      Expression: 
        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
          Instance Receiver: 
            null
          Arguments(1):
              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c1.ToString ... .ToString()')
                IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.String) (Syntax: 'c1.ToString ... .ToString()')
                  Left: 
                    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c1.ToString()')
                      Instance Receiver: 
                        ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C) (Syntax: 'c1')
                      Arguments(0)
                  Right: 
                    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c2.ToString()')
                      Instance Receiver: 
                        ILocalReferenceOperation: c2 (OperationKind.LocalReference, Type: C) (Syntax: 'c2')
                      Arguments(0)
                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,34785,35904);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22074_34940_35010(f_22074_34940_34989(ErrorCode.ERR_CloseParenExpected, ","), 14, 18),
f_22074_35128_35214(f_22074_35128_35193(f_22074_35128_35174(ErrorCode.ERR_InvalidExprTerm, ","), ","), 14, 18),
f_22074_35315_35384(f_22074_35315_35363(ErrorCode.ERR_SemicolonExpected, ","), 14, 18),
f_22074_35485_35551(f_22074_35485_35530(ErrorCode.ERR_RbraceExpected, ","), 14, 18),
f_22074_35652_35721(f_22074_35652_35700(ErrorCode.ERR_SemicolonExpected, ")"), 14, 22),
f_22074_35822_35888(f_22074_35822_35867(ErrorCode.ERR_RbraceExpected, ")"), 14, 22)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,35920,36026);

f_22074_35920_36025(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,29628,36037);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,29628,36037);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,29628,36037);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_InvalidNonDisposableNewResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,36049,39355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,36204,36427);

string 
source = @"
using System;

class C
{

    public static void M1()
    {
        /*<bind>*/using (var c1 = new C())
        {
            Console.WriteLine(c1.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,36441,38830);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using (var  ... }')
  Locals: Local_1: C c1
  Resources: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid, IsImplicit) (Syntax: 'var c1 = new C()')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var c1 = new C()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: C c1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'c1 = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C, IsInvalid) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c1.ToString()')
                  IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c1.ToString()')
                    Instance Receiver: 
                      ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C) (Syntax: 'c1')
                    Arguments(0)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,38844,39213);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22074_39099_39197(f_22074_39099_39177(f_22074_39099_39158(ErrorCode.ERR_NoConvToIDisp, "var c1 = new C()"), "C"), 9, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,39229,39344);

f_22074_39229_39343(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,36049,39355);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,36049,39355);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,36049,39355);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_InvalidNonDisposableExistingResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,39367,41840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,39527,39763);

string 
source = @"
using System;

class C
{

    public static void M1()
    {
        var c1 = new C();
        /*<bind>*/using (c1)
        {
            Console.WriteLine(c1.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,39777,41342);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using (c1) ... }')
  Resources: 
    ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c1')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c1.ToString()')
                  IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c1.ToString()')
                    Instance Receiver: 
                      ILocalReferenceOperation: c1 (OperationKind.LocalReference, Type: C) (Syntax: 'c1')
                    Arguments(0)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,41356,41698);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22074_41597_41682(f_22074_41597_41661(f_22074_41597_41642(ErrorCode.ERR_NoConvToIDisp, "c1"), "C"), 10, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,41714,41829);

f_22074_41714_41828(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,39367,41840);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,39367,41840);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,39367,41840);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_InvalidEmptyUsingResources()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,41852,42952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,42002,42162);

string 
source = @"
using System;

class C
{

    public static void M1()
    {
        /*<bind>*/using ()
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,42176,42519);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using () ... }')
  Resources: 
    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
      Children(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,42533,42810);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22074_42709_42794(f_22074_42709_42774(f_22074_42709_42755(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 9, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,42826,42941);

f_22074_42826_42940(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,41852,42952);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,41852,42952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,41852,42952);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_UsingWithoutSavedReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,42964,43988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,43114,43377);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        /*<bind>*/using (GetC())
        {
        }/*</bind>*/
    }

    public static C GetC() => new C();
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,43391,43779);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (GetC ... }')
  Resources: 
    IInvocationOperation (C C.GetC()) (OperationKind.Invocation, Type: C) (Syntax: 'GetC()')
      Instance Receiver: 
        null
      Arguments(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,43793,43846);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,43862,43977);

f_22074_43862_43976(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,42964,43988);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,42964,43988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,42964,43988);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_DynamicArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,44000,45734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,44139,44417);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        dynamic d = null;
        /*<bind>*/using (d)
        {
            Console.WriteLine(d);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,44431,45525);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (d) ... }')
  Resources: 
    ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(d);')
        Expression: 
          IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'Console.WriteLine(d)')
            Expression: 
              IDynamicMemberReferenceOperation (Member Name: ""WriteLine"", Containing Type: System.Console) (OperationKind.DynamicMemberReference, Type: null) (Syntax: 'Console.WriteLine')
                Type Arguments(0)
                Instance Receiver: 
                  null
            Arguments(1):
                ILocalReferenceOperation: d (OperationKind.LocalReference, Type: dynamic) (Syntax: 'd')
            ArgumentNames(0)
            ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,45539,45592);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,45608,45723);

f_22074_45608_45722(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,44000,45734);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,44000,45734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,44000,45734);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_NullResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,45746,46592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,45882,46044);

string 
source = @"
using System;

class C
{
    public static void M1()
    {
        /*<bind>*/using (null)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,46058,46383);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (null ... }')
  Resources: 
    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,46397,46450);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,46466,46581);

f_22074_46466_46580(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,45746,46592);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,45746,46592);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,45746,46592);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_UsingStatementSyntax_Declaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,46604,47924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,46760,47036);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        using (/*<bind>*/var c = new C()/*</bind>*/)
        {
            Console.WriteLine(c.ToString());
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,47050,47710);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c = new C()')
  Declarators:
      IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
            IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
              Arguments(0)
              Initializer: 
                null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,47724,47777);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,47793,47913);

f_22074_47793_47912(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,46604,47924);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,46604,47924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,46604,47924);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_UsingStatementSyntax_StatementSyntax()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,47936,49875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,48096,48372);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        using (var c = new C())
        /*<bind>*/{
            Console.WriteLine(c.ToString());
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,48386,49675);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... oString());')
    Expression: 
      IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ToString())')
        Instance Receiver: 
          null
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'c.ToString()')
              IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c.ToString()')
                Instance Receiver: 
                  ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
                Arguments(0)
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,49689,49742);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,49758,49864);

f_22074_49758_49863(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,47936,49875);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,47936,49875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,47936,49875);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_UsingStatementSyntax_ExpressionSyntax()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,49887,50679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,50048,50336);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        var c = new C();
        using (/*<bind>*/c/*</bind>*/)
        {
            Console.WriteLine(c.ToString());
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,50350,50470);

string 
expectedOperationTree = @"
ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,50484,50537);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,50553,50668);

f_22074_50553_50667(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,49887,50679);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,49887,50679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,49887,50679);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_UsingStatementSyntax_VariableDeclaratorSyntax()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,50691,51841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,50860,51160);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        
        using (C /*<bind>*/c1 = new C()/*</bind>*/, c2 = new C())
        {
            Console.WriteLine(c1.ToString());
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,51174,51628);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: C c1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c1 = new C()')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
      IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
        Arguments(0)
        Initializer: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,51642,51695);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,51711,51830);

f_22074_51711_51829(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,50691,51841);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,50691,51841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,50691,51841);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_OutVarInResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,51853,54565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,51993,52301);

string 
source = @"
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M(P p)
    {
        /*<bind>*/using (p = M2(out int c))
        {
            c = 1;
        }/*</bind>*/
    }

    P M2(out int c)
    {
        c = 0;
        return new P();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,52315,54356);

string 
expectedOperationTree = @"
IUsingOperation (OperationKind.Using, Type: null) (Syntax: 'using (p =  ... }')
  Locals: Local_1: System.Int32 c
  Resources: 
    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P) (Syntax: 'p = M2(out int c)')
      Left: 
        IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: P) (Syntax: 'p')
      Right: 
        IInvocationOperation ( P P.M2(out System.Int32 c)) (OperationKind.Invocation, Type: P) (Syntax: 'M2(out int c)')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
          Arguments(1):
              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null) (Syntax: 'out int c')
                IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int c')
                  ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'c')
                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = 1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'c = 1')
            Left: 
              ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'c')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,54370,54423);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,54439,54554);

f_22074_54439_54553(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,51853,54565);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,51853,54565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,51853,54565);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_DefaultDisposeArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,54577,58582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,54724,54981);

string 
source = @"
class C
{
    public static void M1()
    {
        /*<bind>*/using(var s = new S())
        { 
        }/*</bind>*/
    }
}

ref struct S
{
    public void Dispose(int a = 1, bool b = true, params object[] others) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,54995,58371);

string 
expectedOperationTree = @"
IUsingOperation (DisposeMethod: void S.Dispose([System.Int32 a = 1], [System.Boolean b = true], params System.Object[] others)) (OperationKind.Using, Type: null) (Syntax: 'using(var s ... }')
  Locals: Local_1: S s
  Resources: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var s = new S()')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var s = new S()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: S s) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's = new S()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new S()')
                  IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  DisposeArguments(3):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'using(var s ... }')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: b) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'using(var s ... }')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: others) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'using(var s ... }')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'using(var s ... }')
          Initializer: 
            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
              Element Values(0)
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,58387,58440);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,58456,58571);

f_22074_58456_58570(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,54577,58582);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,54577,58582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,54577,58582);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_ExpressionDefaultDisposeArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,58594,61818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,58751,59020);

string 
source = @"
class C
{
    public static void M1()
    {
        var s = new S();
        /*<bind>*/using(s)
        { 
        }/*</bind>*/
    }
}

ref struct S
{
    public void Dispose(int a = 1, bool b = true, params object[] others) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,59034,61607);

string 
expectedOperationTree = @"
IUsingOperation (DisposeMethod: void S.Dispose([System.Int32 a = 1], [System.Boolean b = true], params System.Object[] others)) (OperationKind.Using, Type: null) (Syntax: 'using(s) ... }')
  Resources: 
    ILocalReferenceOperation: s (OperationKind.LocalReference, Type: S) (Syntax: 's')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  DisposeArguments(3):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(s) ... }')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'using(s) ... }')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: b) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(s) ... }')
        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'using(s) ... }')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: others) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(s) ... }')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'using(s) ... }')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'using(s) ... }')
          Initializer: 
            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'using(s) ... }')
              Element Values(0)
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,61623,61676);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,61692,61807);

f_22074_61692_61806(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,58594,61818);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,58594,61818);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,58594,61818);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_DisposalWithDefaultParams()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,61830,68006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,61979,62310);

string 
source = @"
class C
{
    public static void M1()
    /*<bind>*/{
        using(var s = new S())
        { 
        }
    }/*</bind>*/

    public static void M2()
    {
        var s = new S();
        s.Dispose();
    }
}
ref struct S 
{
    public void Dispose(params object[] extras = null) { } 
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,62326,64606);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IUsingOperation (DisposeMethod: void S.Dispose(params System.Object[] extras)) (OperationKind.Using, Type: null) (Syntax: 'using(var s ... }')
    Locals: Local_1: S s
    Resources: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var s = new S()')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var s = new S()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: S s) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's = new S()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new S()')
                    IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    DisposeArguments(1):
        IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'using(var s ... }')
            Dimension Sizes(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'using(var s ... }')
            Initializer: 
              IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
                Element Values(0)
          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,64622,67393);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [S s]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: S, IsImplicit) (Syntax: 's = new S()')
              Left: 
                ILocalReferenceOperation: s (IsDeclaration: True) (OperationKind.LocalReference, Type: S, IsImplicit) (Syntax: 's = new S()')
              Right: 
                IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation ( void S.Dispose(params System.Object[] extras)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 's = new S()')
                  Instance Receiver: 
                    ILocalReferenceOperation: s (OperationKind.LocalReference, Type: S, IsImplicit) (Syntax: 's = new S()')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
                        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'using(var s ... }')
                          Dimension Sizes(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'using(var s ... }')
                          Initializer: 
                            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
                              Element Values(0)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,67409,67759);

var 
expectedDiagnostics = new[]
            {
f_22074_67656_67743(f_22074_67656_67722(ErrorCode.ERR_DefaultValueForParamsParameter, "params"), 19, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,67775,67881);

f_22074_67775_67880(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,67897,67995);

f_22074_67897_67994(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,61830,68006);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,61830,68006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,61830,68006);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_DisposalWithDefaultParams_Metadata()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,68512,76045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,68670,68919);

string 
source = @"
class C
{
    public static void M1()
    /*<bind>*/{
        using(var s = new S())
        { 
        }
    }/*</bind>*/

    public static void M2()
    {
        var s = new S();
        s.Dispose();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,68935,69551);

var 
ilSource = @"
.class public sequential ansi sealed beforefieldinit S
    extends [mscorlib]System.ValueType
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IsByRefLikeAttribute::.ctor() = (
        01 00 00 00
    )
    .method public hidebysig 
        instance void Dispose (
            [opt] object[] extras
        ) cil managed 
    {
        .param [1] = nullref
            .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = (
                01 00 00 00
            )
        .maxstack 8
        IL_0000: nop
        IL_0001: ret
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,69567,69631);

var 
ilReference = f_22074_69585_69630(ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,69647,69707);

var 
compilation = f_22074_69665_69706(source, ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,69721,69753);

f_22074_69721_69752(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,69769,69814);

var 
verifier = f_22074_69784_69813(this, compilation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,69830,70174);

f_22074_69830_70173(
            verifier, "C.M2", @"
{
  // Code size       21 (0x15)
  .maxstack  2
  .locals init (S V_0) //s
  IL_0000:  ldloca.s   V_0
  IL_0002:  initobj    ""S""
  IL_0008:  ldloca.s   V_0
  IL_000a:  call       ""object[] System.Array.Empty<object>()""
  IL_000f:  call       ""void S.Dispose(params object[])""
  IL_0014:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,70188,70637);

f_22074_70188_70636(            verifier, "C.M1", @"
{
  // Code size       24 (0x18)
  .maxstack  2
  .locals init (S V_0) //s
  IL_0000:  ldloca.s   V_0
  IL_0002:  initobj    ""S""
  .try
  {
    IL_0008:  leave.s    IL_0017
  }
  finally
  {
    IL_000a:  ldloca.s   V_0
    IL_000c:  call       ""object[] System.Array.Empty<object>()""
    IL_0011:  call       ""void S.Dispose(params object[])""
    IL_0016:  endfinally
  }
  IL_0017:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,70655,72935);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IUsingOperation (DisposeMethod: void S.Dispose(params System.Object[] extras)) (OperationKind.Using, Type: null) (Syntax: 'using(var s ... }')
    Locals: Local_1: S s
    Resources: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'var s = new S()')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var s = new S()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: S s) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's = new S()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new S()')
                    IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
    DisposeArguments(1):
        IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
          IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'using(var s ... }')
            Dimension Sizes(1):
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'using(var s ... }')
            Initializer: 
              IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
                Element Values(0)
          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,72951,75719);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [S s]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: S, IsImplicit) (Syntax: 's = new S()')
              Left: 
                ILocalReferenceOperation: s (IsDeclaration: True) (OperationKind.LocalReference, Type: S, IsImplicit) (Syntax: 's = new S()')
              Right: 
                IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation ( void S.Dispose(params System.Object[] extras)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 's = new S()')
                  Instance Receiver: 
                    ILocalReferenceOperation: s (OperationKind.LocalReference, Type: S, IsImplicit) (Syntax: 's = new S()')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
                        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'using(var s ... }')
                          Dimension Sizes(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'using(var s ... }')
                          Initializer: 
                            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'using(var s ... }')
                              Element Values(0)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,75735,75788);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,75804,75915);

f_22074_75804_75914(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,75931,76034);

f_22074_75931_76033(compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,68512,76045);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,68512,76045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,68512,76045);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_DisposalWithNonArrayParams_Metadata()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,76057,82121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,76216,76488);

string 
source = @"
class C
{
    public static void M1()
    /*<bind>*/{
        using(var s = new S())
        { 
        }
    }/*</bind>*/

    public static void M2()
    {
        var s = new S();
        s.Dispose();
        s.Dispose(1);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,76504,77101);

var 
ilSource = @"
.class public sequential ansi sealed beforefieldinit S
    extends [mscorlib]System.ValueType
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IsByRefLikeAttribute::.ctor() = (
        01 00 00 00
    )
    .method public hidebysig 
        instance void Dispose (
            int32 extras
        ) cil managed 
    {
        .param [1]
            .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = (
                01 00 00 00
            )
        .maxstack 8
        IL_0000: nop
        IL_0001: ret
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,77117,77181);

var 
ilReference = f_22074_77135_77180(ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,77197,78267);

var 
expectedDiagnostics = new[]
            {
f_22074_77467_77604(f_22074_77467_77584(f_22074_77467_77535(ErrorCode.ERR_NoCorrespondingArgument, "var s = new S()"), "extras", "S.Dispose(params int)"), 6, 15),
f_22074_77808_77905(f_22074_77808_77885(f_22074_77808_77866(ErrorCode.ERR_NoConvToIDisp, "var s = new S()"), "S"), 6, 15),
f_22074_78121_78251(f_22074_78121_78230(f_22074_78121_78181(ErrorCode.ERR_NoCorrespondingArgument, "Dispose"), "extras", "S.Dispose(params int)"), 14, 11)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,78283,78343);

var 
compilation = f_22074_78301_78342(source, ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,78357,78408);

f_22074_78357_78407(            compilation, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,78424,79717);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using(var s ... }')
    Locals: Local_1: S s
    Resources: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid, IsImplicit) (Syntax: 'var s = new S()')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var s = new S()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: S s) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 's = new S()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new S()')
                    IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S, IsInvalid) (Syntax: 'new S()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,79733,81864);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [S s]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
              Left: 
                ILocalReferenceOperation: s (IsDeclaration: True) (OperationKind.LocalReference, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
              Right: 
                IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S, IsInvalid) (Syntax: 'new S()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        ILocalReferenceOperation: s (OperationKind.LocalReference, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,81880,81991);

f_22074_81880_81990(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,82007,82110);

f_22074_82007_82109(compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,76057,82121);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,76057,82121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,76057,82121);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_DisposalWithNonArrayOptionalParams_Metadata()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,82133,88211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,82300,82572);

string 
source = @"
class C
{
    public static void M1()
    /*<bind>*/{
        using(var s = new S())
        { 
        }
    }/*</bind>*/

    public static void M2()
    {
        var s = new S();
        s.Dispose();
        s.Dispose(1);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,82588,83191);

var 
ilSource = @"
.class public sequential ansi sealed beforefieldinit S
    extends [mscorlib]System.ValueType
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IsByRefLikeAttribute::.ctor() = (
        01 00 00 00
    )
    .method public hidebysig 
        instance void Dispose (
            [opt] int32 extras
        ) cil managed 
    {
        .param [1]
            .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = (
                01 00 00 00
            )
        .maxstack 8
        IL_0000: nop
        IL_0001: ret
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,83207,83271);

var 
ilReference = f_22074_83225_83270(ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,83287,84357);

var 
expectedDiagnostics = new[]
            {
f_22074_83557_83694(f_22074_83557_83674(f_22074_83557_83625(ErrorCode.ERR_NoCorrespondingArgument, "var s = new S()"), "extras", "S.Dispose(params int)"), 6, 15),
f_22074_83898_83995(f_22074_83898_83975(f_22074_83898_83956(ErrorCode.ERR_NoConvToIDisp, "var s = new S()"), "S"), 6, 15),
f_22074_84211_84341(f_22074_84211_84320(f_22074_84211_84271(ErrorCode.ERR_NoCorrespondingArgument, "Dispose"), "extras", "S.Dispose(params int)"), 14, 11)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,84373,84433);

var 
compilation = f_22074_84391_84432(source, ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,84447,84498);

f_22074_84447_84497(            compilation, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,84514,85807);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using(var s ... }')
    Locals: Local_1: S s
    Resources: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid, IsImplicit) (Syntax: 'var s = new S()')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var s = new S()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: S s) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 's = new S()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new S()')
                    IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S, IsInvalid) (Syntax: 'new S()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,85823,87954);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [S s]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
              Left: 
                ILocalReferenceOperation: s (IsDeclaration: True) (OperationKind.LocalReference, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
              Right: 
                IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S, IsInvalid) (Syntax: 'new S()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        ILocalReferenceOperation: s (OperationKind.LocalReference, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,87970,88081);

f_22074_87970_88080(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,88097,88200);

f_22074_88097_88199(compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,82133,88211);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,82133,88211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,82133,88211);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_DisposalWithNonArrayDefaultParams_Metadata()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,88223,94311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,88389,88661);

string 
source = @"
class C
{
    public static void M1()
    /*<bind>*/{
        using(var s = new S())
        { 
        }
    }/*</bind>*/

    public static void M2()
    {
        var s = new S();
        s.Dispose();
        s.Dispose(1);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,88677,89291);

var 
ilSource = @"
.class public sequential ansi sealed beforefieldinit S
    extends [mscorlib]System.ValueType
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IsByRefLikeAttribute::.ctor() = (
        01 00 00 00
    )
    .method public hidebysig 
        instance void Dispose (
            [opt] int32 extras
        ) cil managed 
    {
        .param [1] = int32(3)
            .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = (
                01 00 00 00
            )
        .maxstack 8
        IL_0000: nop
        IL_0001: ret
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,89307,89371);

var 
ilReference = f_22074_89325_89370(ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,89387,90457);

var 
expectedDiagnostics = new[]
            {
f_22074_89657_89794(f_22074_89657_89774(f_22074_89657_89725(ErrorCode.ERR_NoCorrespondingArgument, "var s = new S()"), "extras", "S.Dispose(params int)"), 6, 15),
f_22074_89998_90095(f_22074_89998_90075(f_22074_89998_90056(ErrorCode.ERR_NoConvToIDisp, "var s = new S()"), "S"), 6, 15),
f_22074_90311_90441(f_22074_90311_90420(f_22074_90311_90371(ErrorCode.ERR_NoCorrespondingArgument, "Dispose"), "extras", "S.Dispose(params int)"), 14, 11)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,90473,90533);

var 
compilation = f_22074_90491_90532(source, ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,90547,90598);

f_22074_90547_90597(            compilation, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,90614,91907);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using(var s ... }')
    Locals: Local_1: S s
    Resources: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid, IsImplicit) (Syntax: 'var s = new S()')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var s = new S()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: S s) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 's = new S()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new S()')
                    IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S, IsInvalid) (Syntax: 'new S()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,91923,94054);

var 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [S s]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
              Left: 
                ILocalReferenceOperation: s (IsDeclaration: True) (OperationKind.LocalReference, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
              Right: 
                IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S, IsInvalid) (Syntax: 'new S()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        ILocalReferenceOperation: s (OperationKind.LocalReference, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,94070,94181);

f_22074_94070_94180(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,94197,94300);

f_22074_94197_94299(compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,88223,94311);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,88223,94311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,88223,94311);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IUsingStatement_DisposalWithDefaultParamsNotLast_Metadata()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,94323,100493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,94488,94737);

string 
source = @"
class C
{
    public static void M1()
    /*<bind>*/{
        using(var s = new S())
        { 
        }
    }/*</bind>*/

    public static void M2()
    {
        var s = new S();
        s.Dispose();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,94753,95428);

var 
ilSource = @"
.class public sequential ansi sealed beforefieldinit S
    extends [mscorlib]System.ValueType
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.IsByRefLikeAttribute::.ctor() = (
        01 00 00 00
    )
    .method public hidebysig 
        instance void Dispose (
            [opt] object[] extras,
            [opt] int32 a
        ) cil managed 
    {
        .param [1] = nullref
            .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = (
                01 00 00 00
            )
        .param [2] = int32(0)
        .maxstack 8
        IL_0000: nop
        IL_0001: ret
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,95444,95508);

var 
ilReference = f_22074_95462_95507(ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,95524,96634);

var 
expectedDiagnostics = new[]
            {
f_22074_95804_95951(f_22074_95804_95931(f_22074_95804_95872(ErrorCode.ERR_NoCorrespondingArgument, "var s = new S()"), "extras", "S.Dispose(params object[], int)"), 6, 15),
f_22074_96155_96252(f_22074_96155_96232(f_22074_96155_96213(ErrorCode.ERR_NoConvToIDisp, "var s = new S()"), "S"), 6, 15),
f_22074_96478_96618(f_22074_96478_96597(f_22074_96478_96538(ErrorCode.ERR_NoCorrespondingArgument, "Dispose"), "extras", "S.Dispose(params object[], int)"), 14, 11)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,96650,96710);

var 
compilation = f_22074_96668_96709(source, ilSource)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,96724,96775);

f_22074_96724_96774(            compilation, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,96793,98086);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IUsingOperation (OperationKind.Using, Type: null, IsInvalid) (Syntax: 'using(var s ... }')
    Locals: Local_1: S s
    Resources: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid, IsImplicit) (Syntax: 'var s = new S()')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var s = new S()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: S s) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 's = new S()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new S()')
                    IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S, IsInvalid) (Syntax: 'new S()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
    Body: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,98102,98213);

f_22074_98102_98212(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,98229,100363);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [S s]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
              Left: 
                ILocalReferenceOperation: s (IsDeclaration: True) (OperationKind.LocalReference, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
              Right: 
                IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S, IsInvalid) (Syntax: 'new S()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        ILocalReferenceOperation: s (OperationKind.LocalReference, Type: S, IsInvalid, IsImplicit) (Syntax: 's = new S()')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,100379,100482);

f_22074_100379_100481(compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,94323,100493);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,94323,100493);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,94323,100493);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,100505,105444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,100651,100909);

string 
source = @"
class P
{
    void M(System.IDisposable input, bool b)
/*<bind>*/{
        using (GetDisposable() ?? input)
        {
            b = true;
        }
    }/*</bind>*/

    System.IDisposable GetDisposable() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,100923,105256);

string 
expectedGraph = @"
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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IInvocationOperation ( System.IDisposable P.GetDisposable()) (OperationKind.Invocation, Type: System.IDisposable) (Syntax: 'GetDisposable()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'GetDisposable')
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable()')

            Next (Regular) Block[B4]
                Leaving: {R2}
                Entering: {R3} {R4}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.IDisposable) (Syntax: 'input')

        Next (Regular) Block[B4]
            Entering: {R3} {R4}

    .try {R3, R4}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B8]
                Finalizing: {R5}
                Leaving: {R4} {R3} {R1}
    }
    .finally {R5}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Arguments(0)

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B8] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,105270,105323);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,105339,105433);

f_22074_105339_105432(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,100505,105444);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,100505,105444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,100505,105444);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,105456,110852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,105602,105939);

string 
source = @"
class P
{
    void M(MyDisposable input, bool b)
/*<bind>*/{
        using (GetDisposable() ?? input)
        {
            b = true;
        }
    }/*</bind>*/

    MyDisposable GetDisposable() => throw null;
}

class MyDisposable : System.IDisposable
{
    public void Dispose() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,105953,110664);

string 
expectedGraph = @"
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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IInvocationOperation ( MyDisposable P.GetDisposable()) (OperationKind.Invocation, Type: MyDisposable) (Syntax: 'GetDisposable()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'GetDisposable')
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'GetDisposable()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'GetDisposable()')

            Next (Regular) Block[B4]
                Leaving: {R2}
                Entering: {R3} {R4}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyDisposable) (Syntax: 'input')

        Next (Regular) Block[B4]
            Entering: {R3} {R4}

    .try {R3, R4}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B8]
                Finalizing: {R5}
                Leaving: {R4} {R3} {R1}
    }
    .finally {R5}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Arguments(0)

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B8] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,110678,110731);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,110747,110841);

f_22074_110747_110840(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,105456,110852);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,105456,110852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,105456,110852);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,110864,114963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,111010,111351);

string 
source = @"
class P
{
    void M(MyDisposable input, bool b)
/*<bind>*/{
        using (b ? GetDisposable() : input)
        {
            b = true;
        }
    }/*</bind>*/

    MyDisposable GetDisposable() => throw null;
}

struct MyDisposable : System.IDisposable
{
    public void Dispose() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,111365,114775);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
              Value: 
                IInvocationOperation ( MyDisposable P.GetDisposable()) (OperationKind.Invocation, Type: MyDisposable) (Syntax: 'GetDisposable()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'GetDisposable')
                  Arguments(0)

        Next (Regular) Block[B4]
            Entering: {R2} {R3}
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyDisposable) (Syntax: 'input')

        Next (Regular) Block[B4]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'b ? GetDisp ... e() : input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'b ? GetDisp ... e() : input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'b ? GetDisp ... e() : input')
                  Arguments(0)

            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B6] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,114789,114842);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,114858,114952);

f_22074_114858_114951(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,110864,114963);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,110864,114963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,110864,114963);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,114975,119724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,115121,115430);

string 
source = @"
class P
{
    void M<MyDisposable>(MyDisposable input, bool b) where MyDisposable : System.IDisposable
/*<bind>*/{
        using (b ? GetDisposable<MyDisposable>() : input)
        {
            b = true;
        }
    }/*</bind>*/

    T GetDisposable<T>() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,115444,119536);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposab ... sposable>()')
              Value: 
                IInvocationOperation ( MyDisposable P.GetDisposable<MyDisposable>()) (OperationKind.Invocation, Type: MyDisposable) (Syntax: 'GetDisposab ... sposable>()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'GetDisposab ... Disposable>')
                  Arguments(0)

        Next (Regular) Block[B4]
            Entering: {R2} {R3}
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyDisposable) (Syntax: 'input')

        Next (Regular) Block[B4]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B8]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
                  Arguments(0)

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B8] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,119550,119603);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,119619,119713);

f_22074_119619_119712(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,114975,119724);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,114975,119724);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,114975,119724);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,119736,125132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,119882,120222);

string 
source = @"
class P
{
    void M(MyDisposable? input, bool b)
/*<bind>*/{
        using (GetDisposable() ?? input)
        {
            b = true;
        }
    }/*</bind>*/

    MyDisposable? GetDisposable() => throw null;
}

struct MyDisposable : System.IDisposable
{
    public void Dispose() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,120236,124944);

string 
expectedGraph = @"
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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IInvocationOperation ( MyDisposable? P.GetDisposable()) (OperationKind.Invocation, Type: MyDisposable?) (Syntax: 'GetDisposable()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'GetDisposable')
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable?, IsImplicit) (Syntax: 'GetDisposable()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable?, IsImplicit) (Syntax: 'GetDisposable()')

            Next (Regular) Block[B4]
                Leaving: {R2}
                Entering: {R3} {R4}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyDisposable?) (Syntax: 'input')

        Next (Regular) Block[B4]
            Entering: {R3} {R4}

    .try {R3, R4}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B8]
                Finalizing: {R5}
                Leaving: {R4} {R3} {R1}
    }
    .finally {R5}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyDisposable?, IsImplicit) (Syntax: 'GetDisposable() ?? input')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyDisposable?, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Arguments(0)

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B8] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,124958,125011);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,125027,125121);

f_22074_125027_125120(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,119736,125132);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,119736,125132);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,119736,125132);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,125144,131060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,125290,125526);

string 
source = @"
class P
{
    void M(dynamic input, bool b)
/*<bind>*/{
        using (GetDisposable() ?? input)
        {
            b = true;
        }
    }/*</bind>*/

    dynamic GetDisposable() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,125540,130872);

string 
expectedGraph = @"
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
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                      Value: 
                        IInvocationOperation ( dynamic P.GetDisposable()) (OperationKind.Invocation, Type: dynamic) (Syntax: 'GetDisposable()')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'GetDisposable')
                          Arguments(0)

                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable()')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'GetDisposable()')
                    Leaving: {R3}

                Next (Regular) Block[B2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'GetDisposable()')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'input')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitDynamic)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'GetDisposable() ?? input')

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R4} {R5}
    }
    .try {R4, R5}
    {
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B9]
                Finalizing: {R6}
                Leaving: {R5} {R4} {R1}
    }
    .finally {R6}
    {
        Block[B6] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B8]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B6]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Arguments(0)

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B9] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,130886,130939);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,130955,131049);

f_22074_130955_131048(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,125144,131060);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,125144,131060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,125144,131060);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,131072,136894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,131218,131495);

string 
source = @"
class P
{
    void M(NotDisposable input, bool b)
/*<bind>*/{
        using (GetDisposable() ?? input)
        {
            b = true;
        }
    }/*</bind>*/

    NotDisposable GetDisposable() => throw null;
}

class NotDisposable
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,131509,136361);

string 
expectedGraph = @"
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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IInvocationOperation ( NotDisposable P.GetDisposable()) (OperationKind.Invocation, Type: NotDisposable, IsInvalid) (Syntax: 'GetDisposable()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'GetDisposable')
                      Arguments(0)
            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: NotDisposable, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
                Leaving: {R2}
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: NotDisposable, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
            Next (Regular) Block[B4]
                Leaving: {R2}
                Entering: {R3} {R4}
    }
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: NotDisposable, IsInvalid) (Syntax: 'input')
        Next (Regular) Block[B4]
            Entering: {R3} {R4}
    .try {R3, R4}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Next (Regular) Block[B8]
                Finalizing: {R5}
                Leaving: {R4} {R3} {R1}
    }
    .finally {R5}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: NotDisposable, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: NotDisposable, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Arguments(0)
            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B8] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,136375,136773);

var 
expectedDiagnostics = new[] {
f_22074_136639_136757(f_22074_136639_136737(f_22074_136639_136706(ErrorCode.ERR_NoConvToIDisp, "GetDisposable() ?? input"), "NotDisposable"), 6, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,136789,136883);

f_22074_136789_136882(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,131072,136894);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,131072,136894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,131072,136894);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,136906,141381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,137052,137330);

string 
source = @"
class P
{
    void M(MyDisposable input, bool b)
/*<bind>*/{
        using (b ? GetDisposable() : input)
        {
            b = true;
        }
    }/*</bind>*/

    MyDisposable GetDisposable() => throw null;
}

struct MyDisposable
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,137344,140844);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'b')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
              Value: 
                IInvocationOperation ( MyDisposable P.GetDisposable()) (OperationKind.Invocation, Type: MyDisposable, IsInvalid) (Syntax: 'GetDisposable()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'GetDisposable')
                  Arguments(0)
        Next (Regular) Block[B4]
            Entering: {R2} {R3}
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyDisposable, IsInvalid) (Syntax: 'input')
        Next (Regular) Block[B4]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'b ? GetDisp ... e() : input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 'b ? GetDisp ... e() : input')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsInvalid, IsImplicit) (Syntax: 'b ? GetDisp ... e() : input')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,140858,141260);

var 
expectedDiagnostics = new[] {
f_22074_141124_141244(f_22074_141124_141224(f_22074_141124_141194(ErrorCode.ERR_NoConvToIDisp, "b ? GetDisposable() : input"), "MyDisposable"), 6, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,141276,141370);

f_22074_141276_141369(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,136906,141381);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,136906,141381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,136906,141381);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,141393,146584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,141539,141808);

string 
source = @"
class P
{
    void M<MyDisposable>(MyDisposable input, bool b)
/*<bind>*/{
        using (b ? GetDisposable<MyDisposable>() : input)
        {
            b = true;
        }
    }/*</bind>*/

    T GetDisposable<T>() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,141822,146019);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'b')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'GetDisposab ... sposable>()')
              Value: 
                IInvocationOperation ( MyDisposable P.GetDisposable<MyDisposable>()) (OperationKind.Invocation, Type: MyDisposable, IsInvalid) (Syntax: 'GetDisposab ... sposable>()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'GetDisposab ... Disposable>')
                  Arguments(0)
        Next (Regular) Block[B4]
            Entering: {R2} {R3}
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyDisposable, IsInvalid) (Syntax: 'input')
        Next (Regular) Block[B4]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Next (Regular) Block[B8]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsInvalid, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Unboxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsInvalid, IsImplicit) (Syntax: 'b ? GetDisp ... >() : input')
                  Arguments(0)
            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B8] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,146033,146463);

var 
expectedDiagnostics = new[] {
f_22074_146313_146447(f_22074_146313_146427(f_22074_146313_146397(ErrorCode.ERR_NoConvToIDisp, "b ? GetDisposable<MyDisposable>() : input"), "MyDisposable"), 6, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,146479,146573);

f_22074_146479_146572(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,141393,146584);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,141393,146584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,141393,146584);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,146596,152413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,146742,147019);

string 
source = @"
class P
{
    void M(MyDisposable? input, bool b)
/*<bind>*/{
        using (GetDisposable() ?? input)
        {
            b = true;
        }
    }/*</bind>*/

    MyDisposable? GetDisposable() => throw null;
}

struct MyDisposable
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,147033,151880);

string 
expectedGraph = @"
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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IInvocationOperation ( MyDisposable? P.GetDisposable()) (OperationKind.Invocation, Type: MyDisposable?, IsInvalid) (Syntax: 'GetDisposable()')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'GetDisposable')
                      Arguments(0)
            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable?, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
                Leaving: {R2}
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable?, IsInvalid, IsImplicit) (Syntax: 'GetDisposable()')
            Next (Regular) Block[B4]
                Leaving: {R2}
                Entering: {R3} {R4}
    }
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input')
              Value: 
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyDisposable?, IsInvalid) (Syntax: 'input')
        Next (Regular) Block[B4]
            Entering: {R3} {R4}
    .try {R3, R4}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Next (Regular) Block[B8]
                Finalizing: {R5}
                Leaving: {R4} {R3} {R1}
    }
    .finally {R5}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyDisposable?, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyDisposable?, IsInvalid, IsImplicit) (Syntax: 'GetDisposable() ?? input')
                  Arguments(0)
            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B5] [B6]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B8] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,151894,152292);

var 
expectedDiagnostics = new[] {
f_22074_152158_152276(f_22074_152158_152256(f_22074_152158_152225(ErrorCode.ERR_NoConvToIDisp, "GetDisposable() ?? input"), "MyDisposable?"), 6, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,152308,152402);

f_22074_152308_152401(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,146596,152413);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,146596,152413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,146596,152413);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,152425,158687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,152571,152916);

string 
source = @"
class P
{
    void M(MyDisposable input, bool b)
/*<bind>*/{
        using (var x = GetDisposable() ?? input)
        {
            b = true;
        }
    }/*</bind>*/

    MyDisposable GetDisposable() => throw null;
}

class MyDisposable : System.IDisposable
{
    public void Dispose() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,152930,158499);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3}

.locals {R1}
{
    Locals: [MyDisposable x]
    .locals {R2}
    {
        CaptureIds: [1]
        .locals {R3}
        {
            CaptureIds: [0]
            Block[B1] - Block
                Predecessors: [B0]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                      Value: 
                        IInvocationOperation ( MyDisposable P.GetDisposable()) (OperationKind.Invocation, Type: MyDisposable) (Syntax: 'GetDisposable()')
                          Instance Receiver: 
                            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'GetDisposable')
                          Arguments(0)

                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetDisposable()')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'GetDisposable()')
                    Leaving: {R3}

                Next (Regular) Block[B2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetDisposable()')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'GetDisposable()')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: MyDisposable) (Syntax: 'input')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: MyDisposable, IsImplicit) (Syntax: 'x = GetDisp ... () ?? input')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: MyDisposable, IsImplicit) (Syntax: 'x = GetDisp ... () ?? input')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: MyDisposable, IsImplicit) (Syntax: 'GetDisposable() ?? input')

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R4} {R5}
    }
    .try {R4, R5}
    {
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B9]
                Finalizing: {R6}
                Leaving: {R5} {R4} {R1}
    }
    .finally {R6}
    {
        Block[B6] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B8]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x = GetDisp ... () ?? input')
                  Operand: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: MyDisposable, IsImplicit) (Syntax: 'x = GetDisp ... () ?? input')

            Next (Regular) Block[B7]
        Block[B7] - Block
            Predecessors: [B6]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x = GetDisp ... () ?? input')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'x = GetDisp ... () ?? input')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: MyDisposable, IsImplicit) (Syntax: 'x = GetDisp ... () ?? input')
                  Arguments(0)

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B9] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,158513,158566);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,158582,158676);

f_22074_158582_158675(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,152425,158687);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,152425,158687);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,152425,158687);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,158699,166472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,158845,159058);

string 
source = @"
class P
{
    void M(dynamic input1, dynamic input2, bool b)
/*<bind>*/{
        using (dynamic x = input1, y = input2)
        {
            b = true;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,159072,166284);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [dynamic x] [dynamic y]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsImplicit) (Syntax: 'x = input1')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: dynamic, IsImplicit) (Syntax: 'x = input1')
              Right: 
                IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'input1')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [0]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x = input1')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'x = input1')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ExplicitDynamic)
                      Operand: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: dynamic, IsImplicit) (Syntax: 'x = input1')

            Next (Regular) Block[B3]
                Entering: {R3} {R4}

        .try {R3, R4}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsImplicit) (Syntax: 'y = input2')
                      Left: 
                        ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: dynamic, IsImplicit) (Syntax: 'y = input2')
                      Right: 
                        IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'input2')

                Next (Regular) Block[B4]
                    Entering: {R5}

            .locals {R5}
            {
                CaptureIds: [1]
                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (1)
                        IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y = input2')
                          Value: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'y = input2')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                                (ExplicitDynamic)
                              Operand: 
                                ILocalReferenceOperation: y (OperationKind.LocalReference, Type: dynamic, IsImplicit) (Syntax: 'y = input2')

                    Next (Regular) Block[B5]
                        Entering: {R6} {R7}

                .try {R6, R7}
                {
                    Block[B5] - Block
                        Predecessors: [B4]
                        Statements (1)
                            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                              Expression: 
                                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                                  Left: 
                                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                                  Right: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

                        Next (Regular) Block[B12]
                            Finalizing: {R8} {R9}
                            Leaving: {R7} {R6} {R5} {R4} {R3} {R2} {R1}
                }
                .finally {R8}
                {
                    Block[B6] - Block
                        Predecessors (0)
                        Statements (0)
                        Jump if True (Regular) to Block[B8]
                            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y = input2')
                              Operand: 
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'y = input2')

                        Next (Regular) Block[B7]
                    Block[B7] - Block
                        Predecessors: [B6]
                        Statements (1)
                            IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y = input2')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'y = input2')
                              Arguments(0)

                        Next (Regular) Block[B8]
                    Block[B8] - Block
                        Predecessors: [B6] [B7]
                        Statements (0)
                        Next (StructuredExceptionHandling) Block[null]
                }
            }
        }
        .finally {R9}
        {
            Block[B9] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B11]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x = input1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'x = input1')

                Next (Regular) Block[B10]
            Block[B10] - Block
                Predecessors: [B9]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x = input1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'x = input1')
                      Arguments(0)

                Next (Regular) Block[B11]
            Block[B11] - Block
                Predecessors: [B9] [B10]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
}

Block[B12] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,166298,166351);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,166367,166461);

f_22074_166367_166460(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,158699,166472);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,158699,166472);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,158699,166472);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,166484,170396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,166630,166819);

string 
source = @"
class P
{
    void M(System.IDisposable input, object o)
/*<bind>*/{
        using (input)
        {
            o?.ToString();
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,166833,170208);

string 
expectedGraph = @"
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
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.IDisposable) (Syntax: 'input')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o')
                  Value: 
                    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o')
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'o?.ToString();')
                  Expression: 
                    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '.ToString()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o')
                      Arguments(0)

            Next (Regular) Block[B7]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'input')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'input')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'input')
                  Arguments(0)

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B7] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,170222,170275);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,170291,170385);

f_22074_170291_170384(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,166484,170396);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,166484,170396);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,166484,170396);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,170408,175448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,170554,170888);

string 
source = @"
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M(System.IDisposable input, P p)
    /*<bind>*/{
        using (p = M2(out int c))
        {
            c = 1;
        }
    }/*</bind>*/

    P M2(out int c)
    {
        c = 0;
        return new P();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,170902,175260);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 c]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p = M2(out int c)')
              Value: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P) (Syntax: 'p = M2(out int c)')
                  Left: 
                    IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: P) (Syntax: 'p')
                  Right: 
                    IInvocationOperation ( P P.M2(out System.Int32 c)) (OperationKind.Invocation, Type: P) (Syntax: 'M2(out int c)')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null) (Syntax: 'out int c')
                            IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int c')
                              ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'c')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'c = 1')
                      Left: 
                        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'c')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'p = M2(out int c)')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'p = M2(out int c)')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'p = M2(out int c)')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'p = M2(out int c)')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'p = M2(out int c)')
                  Arguments(0)

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}

Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,175274,175327);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,175343,175437);

f_22074_175343_175436(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,170408,175448);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,170408,175448);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,170408,175448);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,175460,179426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,175606,175795);

string 
source = @"
class P
{
    void M(System.IDisposable input, object o)
/*<bind>*/{
        using (input)
        {
            o?.ToString();
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,175809,175867);

var 
compilation = f_22074_175827_175866(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,175881,175954);

f_22074_175881_175953(            compilation, SpecialMember.System_IDisposable__Dispose);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,175970,179233);

string 
expectedGraph = @"
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
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.IDisposable) (Syntax: 'input')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'o')
                  Value: 
                    IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'o')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o')
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'o?.ToString();')
                  Expression: 
                    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '.ToString()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'o')
                      Arguments(0)
            Next (Regular) Block[B7]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B6]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'input')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'input')
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IInvalidOperation (OperationKind.Invalid, Type: null, IsImplicit) (Syntax: 'input')
                  Children(1):
                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, IsImplicit) (Syntax: 'input')
            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B4] [B5]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B7] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,179247,179300);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,179316,179415);

f_22074_179316_179414(compilation, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,175460,179426);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,175460,179426);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,175460,179426);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,179438,182348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,179584,179714);

string 
source = @"
class P
{
    void M()
    /*<bind>*/{
        using (null)
        {
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,179728,182160);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
              Value: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NullLiteral)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'null')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, Constant: null, IsImplicit) (Syntax: 'null')
            Next (Regular) Block[B4]
        Block[B4] - Block [UnReachable]
            Predecessors: [B3]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'null')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.IDisposable, Constant: null, IsImplicit) (Syntax: 'null')
                  Arguments(0)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,182174,182227);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,182243,182337);

f_22074_182243_182336(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,179438,182348);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,179438,182348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,179438,182348);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,182360,186183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,182572,182878);

string 
source = @"
#pragma  warning disable CS0815, CS0219
using System.Threading.Tasks;

class C
{
    async Task M(S? s)
    /*<bind>*/{
        await using (s)
        {
        }
    }/*</bind>*/
}

struct S
{
    public Task DisposeAsync()
    {
        return default;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,182894,185536);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 's')
              Value: 
                IParameterReferenceOperation: s (OperationKind.ParameterReference, Type: S?, IsInvalid) (Syntax: 's')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 's')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: S?, IsInvalid, IsImplicit) (Syntax: 's')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 's')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsInvalid, IsImplicit) (Syntax: 's')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IAsyncDisposable, IsInvalid, IsImplicit) (Syntax: 's')
                          Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (NoConversion)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: S?, IsInvalid, IsImplicit) (Syntax: 's')
                      Arguments(0)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,185550,185963);

var 
expectedDiagnostics = new[]
            {
f_22074_185858_185947(f_22074_185858_185927(f_22074_185858_185907(ErrorCode.ERR_NoConvToIAsyncDisp, "s"), "S?"), 9, 22)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,185979,186064);

var 
comp = f_22074_185990_186063(new[] { source, AsyncStreamsTypes })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,186078,186170);

f_22074_186078_186169(comp, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,182360,186183);

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,182360,186183);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,182360,186183);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,186195,190386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,186341,186591);

string 
source = @"
using System;
using System.Threading.Tasks;
public class C 
{
    public async Task M() 
/*<bind>*/{
        await using(this){}
    }/*</bind>*/
    
    Task DisposeAsync(int a = 3, bool b = false) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,186605,190163);

string 
expectedGraph = @"
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
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'this')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'this')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'this')
                  Expression: 
                    IInvocationOperation ( System.Threading.Tasks.Task C.DisposeAsync([System.Int32 a = 3], [System.Boolean b = false])) (OperationKind.Invocation, Type: System.Threading.Tasks.Task, IsImplicit) (Syntax: 'this')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'this')
                      Arguments(2):
                          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using(this){}')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: 'await using(this){}')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: b) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using(this){}')
                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'await using(this){}')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,190177,190230);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,190246,190375);

f_22074_190246_190374(source + s_IAsyncEnumerable + s_ValueTask, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,186195,190386);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,186195,190386);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,186195,190386);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,190398,195784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,190544,190815);

string 
source = @"
using System;
using System.Threading.Tasks;
public class C 
{
    public async Task M() 
/*<bind>*/{
        await using(this){}
    }/*</bind>*/
    
    Task DisposeAsync(int a = 3, bool b = false, params int[] extras) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,190829,195561);

string 
expectedGraph = @"
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
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'this')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'this')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'this')
                  Expression: 
                    IInvocationOperation ( System.Threading.Tasks.Task C.DisposeAsync([System.Int32 a = 3], [System.Boolean b = false], params System.Int32[] extras)) (OperationKind.Invocation, Type: System.Threading.Tasks.Task, IsImplicit) (Syntax: 'this')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'this')
                      Arguments(3):
                          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using(this){}')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsImplicit) (Syntax: 'await using(this){}')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: b) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using(this){}')
                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'await using(this){}')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using(this){}')
                            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'await using(this){}')
                              Dimension Sizes(1):
                                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'await using(this){}')
                              Initializer: 
                                IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'await using(this){}')
                                  Element Values(0)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,195575,195628);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,195644,195773);

f_22074_195644_195772(source + s_IAsyncEnumerable + s_ValueTask, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,190398,195784);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,190398,195784);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,190398,195784);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,195796,199749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,195942,196186);

string 
source = @"
using System;
using System.Threading.Tasks;
public class C 
{
    public async Task M() 
/*<bind>*/{
        await using(this){}
    }/*</bind>*/
    
    Task DisposeAsync(params int[] extras) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,196200,199526);

string 
expectedGraph = @"
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
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'this')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'this')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'this')
                  Expression: 
                    IInvocationOperation ( System.Threading.Tasks.Task C.DisposeAsync(params System.Int32[] extras)) (OperationKind.Invocation, Type: System.Threading.Tasks.Task, IsImplicit) (Syntax: 'this')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'this')
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using(this){}')
                            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'await using(this){}')
                              Dimension Sizes(1):
                                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'await using(this){}')
                              Initializer: 
                                IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'await using(this){}')
                                  Element Values(0)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,199540,199593);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,199609,199738);

f_22074_199609_199737(source + s_IAsyncEnumerable + s_ValueTask, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,195796,199749);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,195796,199749);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,195796,199749);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingFlow_21()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,199761,204206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,199907,200178);

string 
source = @"
using System;
using System.Threading.Tasks;
public class C 
{
    public async Task M() 
/*<bind>*/{
        await using(this){}
    }/*</bind>*/
    
    Task DisposeAsync(int a = 3, params int[] extras, bool b = false) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,200192,202893);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'this')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid) (Syntax: 'this')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'this')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'this')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'this')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.ValueTask, IsInvalid, IsImplicit) (Syntax: 'this')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IAsyncDisposable, IsInvalid, IsImplicit) (Syntax: 'this')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ExplicitReference)
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'this')
                      Arguments(0)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,202907,204050);

var 
expectedDiagnostics = new[]
            {
f_22074_203199_203343(f_22074_203199_203323(f_22074_203199_203256(ErrorCode.ERR_NoCorrespondingArgument, "this"), "extras", "C.DisposeAsync(int, params int[], bool)"), 8, 21),
f_22074_203616_203707(f_22074_203616_203687(f_22074_203616_203668(ErrorCode.ERR_NoConvToIAsyncDisp, "this"), "C"), 8, 21),
f_22074_203954_204034(f_22074_203954_204013(ErrorCode.ERR_ParamsLast, "params int[] extras"), 11, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,204066,204195);

f_22074_204066_204194(source + s_IAsyncEnumerable + s_ValueTask, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,199761,204206);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,199761,204206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,199761,204206);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,204218,207466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,204442,204624);

string 
source = @"

using System;
class P : IDisposable
{
    void M()
    /*<bind>*/{
        using var x = new P();
    }/*</bind>*/

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,204638,207278);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [P x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x = new P()')
                  Operand: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'x = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
                  Arguments(0)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,207292,207345);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,207361,207455);

f_22074_207361_207454(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,204218,207466);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,204218,207466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,204218,207466);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,207478,215806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,207702,207908);

string 
source = @"

using System;
class P : IDisposable
{
    void M()
    /*<bind>*/{
        using P x = new P(), y = new P(), z = new P();
    }/*</bind>*/

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,207922,215618);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [P x] [P y] [P z]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'y = new P()')
                  Left: 
                    ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = new P()')
                  Right: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B3]
                Entering: {R4} {R5}
        .try {R4, R5}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'z = new P()')
                      Left: 
                        ILocalReferenceOperation: z (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'z = new P()')
                      Right: 
                        IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                          Arguments(0)
                          Initializer: 
                            null
                Next (Regular) Block[B4]
                    Entering: {R6} {R7}
            .try {R6, R7}
            {
                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (0)
                    Next (Regular) Block[B14]
                        Finalizing: {R8} {R9} {R10}
                        Leaving: {R7} {R6} {R5} {R4} {R3} {R2} {R1}
            }
            .finally {R8}
            {
                Block[B5] - Block
                    Predecessors (0)
                    Statements (0)
                    Jump if True (Regular) to Block[B7]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'z = new P()')
                          Operand: 
                            ILocalReferenceOperation: z (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'z = new P()')
                    Next (Regular) Block[B6]
                Block[B6] - Block
                    Predecessors: [B5]
                    Statements (1)
                        IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'z = new P()')
                          Instance Receiver: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'z = new P()')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                (ImplicitReference)
                              Operand: 
                                ILocalReferenceOperation: z (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'z = new P()')
                          Arguments(0)
                    Next (Regular) Block[B7]
                Block[B7] - Block
                    Predecessors: [B5] [B6]
                    Statements (0)
                    Next (StructuredExceptionHandling) Block[null]
            }
        }
        .finally {R9}
        {
            Block[B8] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B10]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y = new P()')
                      Operand: 
                        ILocalReferenceOperation: y (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = new P()')
                Next (Regular) Block[B9]
            Block[B9] - Block
                Predecessors: [B8]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y = new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'y = new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = new P()')
                      Arguments(0)
                Next (Regular) Block[B10]
            Block[B10] - Block
                Predecessors: [B8] [B9]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    .finally {R10}
    {
        Block[B11] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B13]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x = new P()')
                  Operand: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
            Next (Regular) Block[B12]
        Block[B12] - Block
            Predecessors: [B11]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'x = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
                  Arguments(0)
            Next (Regular) Block[B13]
        Block[B13] - Block
            Predecessors: [B11] [B12]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B14] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,215632,215685);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,215701,215795);

f_22074_215701_215794(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,207478,215806);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,207478,215806);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,207478,215806);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,215818,223910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,216042,216243);

string 
source = @"

using System;
class P : IDisposable
{
    void M()
    /*<bind>*/{
        using P x = null ?? new P(), y = new P();
    }/*</bind>*/

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,216257,223722);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3}
.locals {R1}
{
    Locals: [P x] [P y]
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
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: P, IsImplicit) (Syntax: 'null')
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
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new P()')
                  Value: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'x = null ?? new P()')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = null ?? new P()')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'null ?? new P()')
            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R4} {R5}
    }
    .try {R4, R5}
    {
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'y = new P()')
                  Left: 
                    ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = new P()')
                  Right: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B6]
                Entering: {R6} {R7}
        .try {R6, R7}
        {
            Block[B6] - Block
                Predecessors: [B5]
                Statements (0)
                Next (Regular) Block[B13]
                    Finalizing: {R8} {R9}
                    Leaving: {R7} {R6} {R5} {R4} {R1}
        }
        .finally {R8}
        {
            Block[B7] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B9]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y = new P()')
                      Operand: 
                        ILocalReferenceOperation: y (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = new P()')
                Next (Regular) Block[B8]
            Block[B8] - Block
                Predecessors: [B7]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y = new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'y = new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = new P()')
                      Arguments(0)
                Next (Regular) Block[B9]
            Block[B9] - Block
                Predecessors: [B7] [B8]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    .finally {R9}
    {
        Block[B10] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B12]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x = null ?? new P()')
                  Operand: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = null ?? new P()')
            Next (Regular) Block[B11]
        Block[B11] - Block
            Predecessors: [B10]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x = null ?? new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'x = null ?? new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = null ?? new P()')
                  Arguments(0)
            Next (Regular) Block[B12]
        Block[B12] - Block
            Predecessors: [B10] [B11]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B13] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,223736,223789);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,223805,223899);

f_22074_223805_223898(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,215818,223910);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,215818,223910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,215818,223910);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,223922,232174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,224146,224347);

string 
source = @"

using System;
class P : IDisposable
{
    void M()
    /*<bind>*/{
        using P x = new P(), y = null ?? new P();
    }/*</bind>*/

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,224361,231986);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [P x] [P y]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3} {R4} {R5}
    .try {R2, R3}
    {
        .locals {R4}
        {
            CaptureIds: [1]
            .locals {R5}
            {
                CaptureIds: [0]
                Block[B2] - Block
                    Predecessors: [B1]
                    Statements (1)
                        IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
                    Jump if True (Regular) to Block[B4]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'null')
                          Operand: 
                            IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
                        Leaving: {R5}
                    Next (Regular) Block[B3]
                Block[B3] - Block [UnReachable]
                    Predecessors: [B2]
                    Statements (1)
                        IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'null')
                          Value: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: P, IsImplicit) (Syntax: 'null')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                (ImplicitReference)
                              Operand: 
                                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: null, Constant: null, IsImplicit) (Syntax: 'null')
                    Next (Regular) Block[B5]
                        Leaving: {R5}
            }
            Block[B4] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new P()')
                      Value: 
                        IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                          Arguments(0)
                          Initializer: 
                            null
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'y = null ?? new P()')
                      Left: 
                        ILocalReferenceOperation: y (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = null ?? new P()')
                      Right: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsImplicit) (Syntax: 'null ?? new P()')
                Next (Regular) Block[B6]
                    Leaving: {R4}
                    Entering: {R6} {R7}
        }
        .try {R6, R7}
        {
            Block[B6] - Block
                Predecessors: [B5]
                Statements (0)
                Next (Regular) Block[B13]
                    Finalizing: {R8} {R9}
                    Leaving: {R7} {R6} {R3} {R2} {R1}
        }
        .finally {R8}
        {
            Block[B7] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B9]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y = null ?? new P()')
                      Operand: 
                        ILocalReferenceOperation: y (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = null ?? new P()')
                Next (Regular) Block[B8]
            Block[B8] - Block
                Predecessors: [B7]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y = null ?? new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'y = null ?? new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'y = null ?? new P()')
                      Arguments(0)
                Next (Regular) Block[B9]
            Block[B9] - Block
                Predecessors: [B7] [B8]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    .finally {R9}
    {
        Block[B10] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B12]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x = new P()')
                  Operand: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
            Next (Regular) Block[B11]
        Block[B11] - Block
            Predecessors: [B10]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'x = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
                  Arguments(0)
            Next (Regular) Block[B12]
        Block[B12] - Block
            Predecessors: [B10] [B11]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B13] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,232000,232053);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,232069,232163);

f_22074_232069_232162(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,223922,232174);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,223922,232174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,223922,232174);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,232186,239841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,232410,232747);

string 
source = @"
#pragma  warning disable CS0815, CS0219
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        int a = 0;
        int b = 1;
        using var c = new P();
        int d = 2;
        using var e = new P();
        int f = 3;
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,232761,239653);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 b] [P c] [System.Int32 d] [P e] [System.Int32 f]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = 1')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'c = new P()')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = 2')
                  Left: 
                    ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = 2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'e = new P()')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                  Right: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B3]
                Entering: {R4} {R5}
        .try {R4, R5}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'f = 3')
                      Left: 
                        ILocalReferenceOperation: f (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'f = 3')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                Next (Regular) Block[B10]
                    Finalizing: {R6} {R7}
                    Leaving: {R5} {R4} {R3} {R2} {R1}
        }
        .finally {R6}
        {
            Block[B4] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B6]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e = new P()')
                      Operand: 
                        ILocalReferenceOperation: e (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e = new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e = new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: e (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                      Arguments(0)
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    .finally {R7}
    {
        Block[B7] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B9]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c = new P()')
                  Operand: 
                    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'c = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'c = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
                  Arguments(0)
            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B10] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,239667,239720);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,239736,239830);

f_22074_239736_239829(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,232186,239841);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,232186,239841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,232186,239841);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,239853,250503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,240077,240492);

string 
source = @"
#pragma  warning disable CS0815, CS0219
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        int a = 0;
        int b = 1;
        using var c = new P();
        int d = 2;
        System.Action lambda = () => { _ = c.ToString(); };
        using var e = new P();
        int f = 3;
        lambda();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,240506,250315);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 b] [P c] [System.Int32 d] [System.Action lambda] [P e] [System.Int32 f]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = 1')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'c = new P()')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (3)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = 2')
                  Left: 
                    ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = 2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action, IsImplicit) (Syntax: 'lambda = () ... String(); }')
                  Left: 
                    ILocalReferenceOperation: lambda (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Action, IsImplicit) (Syntax: 'lambda = () ... String(); }')
                  Right: 
                    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsImplicit) (Syntax: '() => { _ = ... String(); }')
                      Target: 
                        IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null) (Syntax: '() => { _ = ... String(); }')
                        {
                            Block[B0#A0] - Entry
                                Statements (0)
                                Next (Regular) Block[B1#A0]
                            Block[B1#A0] - Block
                                Predecessors: [B0#A0]
                                Statements (1)
                                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '_ = c.ToString();')
                                      Expression: 
                                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: '_ = c.ToString()')
                                          Left: 
                                            IDiscardOperation (Symbol: System.String _) (OperationKind.Discard, Type: System.String) (Syntax: '_')
                                          Right: 
                                            IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'c.ToString()')
                                              Instance Receiver: 
                                                ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P) (Syntax: 'c')
                                              Arguments(0)
                                Next (Regular) Block[B2#A0]
                            Block[B2#A0] - Exit
                                Predecessors: [B1#A0]
                                Statements (0)
                        }
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'e = new P()')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                  Right: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B3]
                Entering: {R4} {R5}
        .try {R4, R5}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'f = 3')
                      Left: 
                        ILocalReferenceOperation: f (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'f = 3')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'lambda();')
                      Expression: 
                        IInvocationOperation (virtual void System.Action.Invoke()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'lambda()')
                          Instance Receiver: 
                            ILocalReferenceOperation: lambda (OperationKind.LocalReference, Type: System.Action) (Syntax: 'lambda')
                          Arguments(0)
                Next (Regular) Block[B10]
                    Finalizing: {R6} {R7}
                    Leaving: {R5} {R4} {R3} {R2} {R1}
        }
        .finally {R6}
        {
            Block[B4] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B6]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e = new P()')
                      Operand: 
                        ILocalReferenceOperation: e (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e = new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e = new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: e (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                      Arguments(0)
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    .finally {R7}
    {
        Block[B7] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B9]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c = new P()')
                  Operand: 
                    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'c = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'c = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
                  Arguments(0)
            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B10] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,250329,250382);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,250398,250492);

f_22074_250398_250491(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,239853,250503);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,239853,250503);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,239853,250503);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,250515,258716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,250739,251108);

string 
source = @"
#pragma  warning disable CS0815, CS0219
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        int a = 0;
        using var b = new P();
        {
            int c = 1;
            using var d = new P();
            int e = 2;
        }
        int f = 3;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,251122,258528);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32 a] [P b] [System.Int32 f]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'b = new P()')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'b = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3} {R4}
    .try {R2, R3}
    {
        .locals {R4}
        {
            Locals: [System.Int32 c] [P d] [System.Int32 e]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (2)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'c = 1')
                      Left: 
                        ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'c = 1')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'd = new P()')
                      Left: 
                        ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'd = new P()')
                      Right: 
                        IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                          Arguments(0)
                          Initializer: 
                            null
                Next (Regular) Block[B3]
                    Entering: {R5} {R6}
            .try {R5, R6}
            {
                Block[B3] - Block
                    Predecessors: [B2]
                    Statements (1)
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'e = 2')
                          Left: 
                            ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'e = 2')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                    Next (Regular) Block[B7]
                        Finalizing: {R7}
                        Leaving: {R6} {R5} {R4}
            }
            .finally {R7}
            {
                Block[B4] - Block
                    Predecessors (0)
                    Statements (0)
                    Jump if True (Regular) to Block[B6]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd = new P()')
                          Operand: 
                            ILocalReferenceOperation: d (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'd = new P()')
                    Next (Regular) Block[B5]
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (1)
                        IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'd = new P()')
                          Instance Receiver: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'd = new P()')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                (ImplicitReference)
                              Operand: 
                                ILocalReferenceOperation: d (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'd = new P()')
                          Arguments(0)
                    Next (Regular) Block[B6]
                Block[B6] - Block
                    Predecessors: [B4] [B5]
                    Statements (0)
                    Next (StructuredExceptionHandling) Block[null]
            }
        }
        Block[B7] - Block
            Predecessors: [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'f = 3')
                  Left: 
                    ILocalReferenceOperation: f (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'f = 3')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Next (Regular) Block[B11]
                Finalizing: {R8}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R8}
    {
        Block[B8] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B10]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'b = new P()')
                  Operand: 
                    ILocalReferenceOperation: b (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'b = new P()')
            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B8]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'b = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'b = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: b (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'b = new P()')
                  Arguments(0)
            Next (Regular) Block[B10]
        Block[B10] - Block
            Predecessors: [B8] [B9]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B11] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,258542,258595);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,258611,258705);

f_22074_258611_258704(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,250515,258716);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,250515,258716);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,250515,258716);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,258728,268618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,258952,259488);

string 
source = @"
#pragma  warning disable CS0815, CS0219
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        int a = 0;
        using var b = new P();
        label1:
        {
            int c = 1;
            if (a > 0)
                 goto label1;
                 
            using var d = new P();
            if (a > 0)
                goto label1;
            int e = 2;
        }
        int f = 3;
        goto label1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,259502,268430);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32 a] [P b] [System.Int32 f]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'b = new P()')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'b = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1] [B3] [B5] [B10]
            Statements (0)
            Next (Regular) Block[B3]
                Entering: {R4}
        .locals {R4}
        {
            Locals: [System.Int32 c] [P d] [System.Int32 e]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'c = 1')
                      Left: 
                        ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'c = 1')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Jump if False (Regular) to Block[B4]
                    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'a > 0')
                      Left: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                Next (Regular) Block[B2]
                    Leaving: {R4}
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'd = new P()')
                      Left: 
                        ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'd = new P()')
                      Right: 
                        IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                          Arguments(0)
                          Initializer: 
                            null
                Next (Regular) Block[B5]
                    Entering: {R5} {R6}
            .try {R5, R6}
            {
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (0)
                    Jump if False (Regular) to Block[B6]
                        IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'a > 0')
                          Left: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                    Next (Regular) Block[B2]
                        Finalizing: {R7}
                        Leaving: {R6} {R5} {R4}
                Block[B6] - Block
                    Predecessors: [B5]
                    Statements (1)
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'e = 2')
                          Left: 
                            ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'e = 2')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                    Next (Regular) Block[B10]
                        Finalizing: {R7}
                        Leaving: {R6} {R5} {R4}
            }
            .finally {R7}
            {
                Block[B7] - Block
                    Predecessors (0)
                    Statements (0)
                    Jump if True (Regular) to Block[B9]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd = new P()')
                          Operand: 
                            ILocalReferenceOperation: d (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'd = new P()')
                    Next (Regular) Block[B8]
                Block[B8] - Block
                    Predecessors: [B7]
                    Statements (1)
                        IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'd = new P()')
                          Instance Receiver: 
                            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'd = new P()')
                              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                (ImplicitReference)
                              Operand: 
                                ILocalReferenceOperation: d (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'd = new P()')
                          Arguments(0)
                    Next (Regular) Block[B9]
                Block[B9] - Block
                    Predecessors: [B7] [B8]
                    Statements (0)
                    Next (StructuredExceptionHandling) Block[null]
            }
        }
        Block[B10] - Block
            Predecessors: [B6]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'f = 3')
                  Left: 
                    ILocalReferenceOperation: f (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'f = 3')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Next (Regular) Block[B2]
    }
    .finally {R8}
    {
        Block[B11] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B13]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'b = new P()')
                  Operand: 
                    ILocalReferenceOperation: b (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'b = new P()')
            Next (Regular) Block[B12]
        Block[B12] - Block
            Predecessors: [B11]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'b = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'b = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: b (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'b = new P()')
                  Arguments(0)
            Next (Regular) Block[B13]
        Block[B13] - Block
            Predecessors: [B11] [B12]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B14] - Exit [UnReachable]
    Predecessors (0)
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,268444,268497);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,268513,268607);

f_22074_268513_268606(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,258728,268618);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,258728,268618);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,258728,268618);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,268630,272077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,268854,269131);

string 
source = @"
#pragma  warning disable CS0815, CS0219
using System.Threading.Tasks;

class C
{
    public Task DisposeAsync()
    {
        return default;
    }

    async Task M()
    /*<bind>*/{
        await using var c = new C();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,269147,271790);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [C c]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsImplicit) (Syntax: 'c = new C()')
                  Left: 
                    ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'c = new C()')
                  Right: 
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B2]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B2] - Block
                Predecessors: [B1]
                Statements (0)
                Next (Regular) Block[B6]
                    Finalizing: {R4}
                    Leaving: {R3} {R2} {R1}
        }
        .finally {R4}
        {
            Block[B3] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B5]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c = new C()')
                      Operand: 
                        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'c = new C()')
                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'c = new C()')
                      Expression: 
                        IInvocationOperation ( System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task, IsImplicit) (Syntax: 'c = new C()')
                          Instance Receiver: 
                            ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'c = new C()')
                          Arguments(0)
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B6] - Exit
        Predecessors: [B2]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,271804,271857);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,271873,271958);

var 
comp = f_22074_271884_271957(new[] { source, AsyncStreamsTypes })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,271972,272064);

f_22074_271972_272063(comp, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,268630,272077);

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,268630,272077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,268630,272077);
}
		}

[Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,272089,283715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,272234,272677);

string 
source = @"
#pragma  warning disable CS0815, CS0219
using System.Threading.Tasks;

class C : System.IDisposable
{
    public Task DisposeAsync()
    {
        return default;
    }

    public void Dispose()
    {
    }

    async Task M()
    /*<bind>*/{
        using var c = new C();
        await using var d = new C();
        using var e = new C();
        await using var f = new C();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,272691,283430);

string 
expectedGraph = @"
 Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [C c] [C d] [C e] [C f]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsImplicit) (Syntax: 'c = new C()')
                  Left: 
                    ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'c = new C()')
                  Right: 
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B2]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsImplicit) (Syntax: 'd = new C()')
                      Left: 
                        ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'd = new C()')
                      Right: 
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
                Next (Regular) Block[B3]
                    Entering: {R4} {R5}
            .try {R4, R5}
            {
                Block[B3] - Block
                    Predecessors: [B2]
                    Statements (1)
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsImplicit) (Syntax: 'e = new C()')
                          Left: 
                            ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'e = new C()')
                          Right: 
                            IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                              Arguments(0)
                              Initializer: 
                                null
                    Next (Regular) Block[B4]
                        Entering: {R6} {R7}
                .try {R6, R7}
                {
                    Block[B4] - Block
                        Predecessors: [B3]
                        Statements (1)
                            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsImplicit) (Syntax: 'f = new C()')
                              Left: 
                                ILocalReferenceOperation: f (IsDeclaration: True) (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'f = new C()')
                              Right: 
                                IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                                  Arguments(0)
                                  Initializer: 
                                    null
                        Next (Regular) Block[B5]
                            Entering: {R8} {R9}
                    .try {R8, R9}
                    {
                        Block[B5] - Block
                            Predecessors: [B4]
                            Statements (0)
                            Next (Regular) Block[B18]
                                Finalizing: {R10} {R11} {R12} {R13}
                                Leaving: {R9} {R8} {R7} {R6} {R5} {R4} {R3} {R2} {R1}
                    }
                    .finally {R10}
                    {
                        Block[B6] - Block
                            Predecessors (0)
                            Statements (0)
                            Jump if True (Regular) to Block[B8]
                                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'f = new C()')
                                  Operand: 
                                    ILocalReferenceOperation: f (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'f = new C()')
                            Next (Regular) Block[B7]
                        Block[B7] - Block
                            Predecessors: [B6]
                            Statements (1)
                                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'f = new C()')
                                  Expression: 
                                    IInvocationOperation ( System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task, IsImplicit) (Syntax: 'f = new C()')
                                      Instance Receiver: 
                                        ILocalReferenceOperation: f (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'f = new C()')
                                      Arguments(0)
                            Next (Regular) Block[B8]
                        Block[B8] - Block
                            Predecessors: [B6] [B7]
                            Statements (0)
                            Next (StructuredExceptionHandling) Block[null]
                    }
                }
                .finally {R11}
                {
                    Block[B9] - Block
                        Predecessors (0)
                        Statements (0)
                        Jump if True (Regular) to Block[B11]
                            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e = new C()')
                              Operand: 
                                ILocalReferenceOperation: e (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'e = new C()')
                        Next (Regular) Block[B10]
                    Block[B10] - Block
                        Predecessors: [B9]
                        Statements (1)
                            IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e = new C()')
                              Instance Receiver: 
                                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e = new C()')
                                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                                    (ImplicitReference)
                                  Operand: 
                                    ILocalReferenceOperation: e (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'e = new C()')
                              Arguments(0)
                        Next (Regular) Block[B11]
                    Block[B11] - Block
                        Predecessors: [B9] [B10]
                        Statements (0)
                        Next (StructuredExceptionHandling) Block[null]
                }
            }
            .finally {R12}
            {
                Block[B12] - Block
                    Predecessors (0)
                    Statements (0)
                    Jump if True (Regular) to Block[B14]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd = new C()')
                          Operand: 
                            ILocalReferenceOperation: d (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'd = new C()')
                    Next (Regular) Block[B13]
                Block[B13] - Block
                    Predecessors: [B12]
                    Statements (1)
                        IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'd = new C()')
                          Expression: 
                            IInvocationOperation ( System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task, IsImplicit) (Syntax: 'd = new C()')
                              Instance Receiver: 
                                ILocalReferenceOperation: d (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'd = new C()')
                              Arguments(0)
                    Next (Regular) Block[B14]
                Block[B14] - Block
                    Predecessors: [B12] [B13]
                    Statements (0)
                    Next (StructuredExceptionHandling) Block[null]
            }
        }
        .finally {R13}
        {
            Block[B15] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B17]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c = new C()')
                      Operand: 
                        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'c = new C()')
                Next (Regular) Block[B16]
            Block[B16] - Block
                Predecessors: [B15]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'c = new C()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'c = new C()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsImplicit) (Syntax: 'c = new C()')
                      Arguments(0)
                Next (Regular) Block[B17]
            Block[B17] - Block
                Predecessors: [B15] [B16]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B18] - Exit
        Predecessors: [B5]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,283444,283497);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,283513,283598);

var 
comp = f_22074_283524_283597(new[] { source, AsyncStreamsTypes })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,283612,283704);

f_22074_283612_283703(comp, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,272089,283715);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,272089,283715);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,272089,283715);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_Flow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,283727,290885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,283951,284268);

string 
source = @"
#pragma  warning disable CS0815, CS0219
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        int a = 0;
        int b = 1;
        using var c = new P();
        int d = 2;
        using var e = new P();
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,284282,290697);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 b] [P c] [System.Int32 d] [P e]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = 1')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'c = new P()')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = 2')
                  Left: 
                    ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = 2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'e = new P()')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                  Right: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B3]
                Entering: {R4} {R5}
        .try {R4, R5}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)  
                Next (Regular) Block[B10]
                    Finalizing: {R6} {R7}
                    Leaving: {R5} {R4} {R3} {R2} {R1}
        }
        .finally {R6}
        {
            Block[B4] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B6]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e = new P()')
                      Operand: 
                        ILocalReferenceOperation: e (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e = new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e = new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: e (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                      Arguments(0)
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    .finally {R7}
    {
        Block[B7] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B9]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c = new P()')
                  Operand: 
                    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'c = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'c = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
                  Arguments(0)
            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B10] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,290711,290764);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,290780,290874);

f_22074_290780_290873(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,283727,290885);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,283727,290885);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,283727,290885);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,290897,298024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,291055,291407);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        int a = 0;
        int b = 1;
label1:
        using var c = new P();
        int d = 2;
label2:
label3:
        using var e = new P();
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,291421,297836);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 b] [P c] [System.Int32 d] [P e]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = 1')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'c = new P()')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = 2')
                  Left: 
                    ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = 2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'e = new P()')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                  Right: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B3]
                Entering: {R4} {R5}
        .try {R4, R5}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)  
                Next (Regular) Block[B10]
                    Finalizing: {R6} {R7}
                    Leaving: {R5} {R4} {R3} {R2} {R1}
        }
        .finally {R6}
        {
            Block[B4] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B6]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e = new P()')
                      Operand: 
                        ILocalReferenceOperation: e (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'e = new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'e = new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: e (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'e = new P()')
                      Arguments(0)
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    .finally {R7}
    {
        Block[B7] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B9]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c = new P()')
                  Operand: 
                    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'c = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'c = new P()')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILocalReferenceOperation: c (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'c = new P()')
                  Arguments(0)
            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B7] [B8]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B10] - Exit
    Predecessors: [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,297850,297903);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,297919,298013);

f_22074_297919_298012(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,290897,298024);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,290897,298024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,290897,298024);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,298036,305671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,298194,298576);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        if (true)
            label1:
                using var a = new P();
        if (true)
            label2:
            label3:
                using var b = new P();
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,298590,304894);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B7]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B2]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [P a]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsInvalid, IsImplicit) (Syntax: 'a = new P()')
                  Left: 
                    ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'a = new P()')
                  Right: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P, IsInvalid) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B3]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Next (Regular) Block[B7]
                    Finalizing: {R4}
                    Leaving: {R3} {R2} {R1}
        }
        .finally {R4}
        {
            Block[B4] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B6]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a = new P()')
                      Operand: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'a = new P()')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'a = new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 'a = new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'a = new P()')
                      Arguments(0)
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B7] - Block
        Predecessors: [B1] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B13]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B8]
            Entering: {R5}
    .locals {R5}
    {
        Locals: [P b]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsInvalid, IsImplicit) (Syntax: 'b = new P()')
                  Left: 
                    ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b = new P()')
                  Right: 
                    IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P, IsInvalid) (Syntax: 'new P()')
                      Arguments(0)
                      Initializer: 
                        null
            Next (Regular) Block[B9]
                Entering: {R6} {R7}
        .try {R6, R7}
        {
            Block[B9] - Block
                Predecessors: [B8]
                Statements (0)
                Next (Regular) Block[B13]
                    Finalizing: {R8}
                    Leaving: {R7} {R6} {R5}
        }
        .finally {R8}
        {
            Block[B10] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B12]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'b = new P()')
                      Operand: 
                        ILocalReferenceOperation: b (OperationKind.LocalReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b = new P()')
                Next (Regular) Block[B11]
            Block[B11] - Block
                Predecessors: [B10]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'b = new P()')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 'b = new P()')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: b (OperationKind.LocalReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b = new P()')
                      Arguments(0)
                Next (Regular) Block[B12]
            Block[B12] - Block
                Predecessors: [B10] [B11]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B13] - Exit
        Predecessors: [B7] [B9]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,304908,305550);

var 
expectedDiagnostics = new[]{
f_22074_305112_305226(f_22074_305112_305205(ErrorCode.ERR_BadEmbeddedStmt, @"label1:
                using var a = new P();"), 12, 13),
f_22074_305399_305534(f_22074_305399_305513(ErrorCode.ERR_BadEmbeddedStmt, @"label2:
            label3:
                using var b = new P();"), 15, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,305566,305660);

f_22074_305566_305659(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,298036,305671);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,298036,305671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,298036,305671);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,305683,309904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,305841,306130);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        goto label1;
        int x = 0;
        label1:
        using var a = this;
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,306144,309519);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B2]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [System.Int32 x] [P a]
        Block[B1] - Block [UnReachable]
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'x = 0')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'x = 0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B0] [B1]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'a = this')
                  Left: 
                    ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                  Right: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
            Next (Regular) Block[B3]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Next (Regular) Block[B7]
                    Finalizing: {R4}
                    Leaving: {R3} {R2} {R1}
        }
        .finally {R4}
        {
            Block[B4] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B6]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a = this')
                      Operand: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a = this')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a = this')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                      Arguments(0)
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B7] - Exit
        Predecessors: [B3]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,309533,309783);

var 
expectedDiagnostics = new[]{
f_22074_309699_309767(f_22074_309699_309747(ErrorCode.WRN_UnreachableCode, "int"), 12, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,309799,309893);

f_22074_309799_309892(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,305683,309904);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,305683,309904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,305683,309904);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,309916,313607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,310074,310343);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        label1:
        using var a = this;
        goto label1;
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,310357,313143);

string 
expectedGraph = @"
      Block[B0] - Entry
      Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [P a]
        Block[B1] - Block
            Predecessors: [B0] [B2]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'a = this')
                  Left: 
                    ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                  Right: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
            Next (Regular) Block[B2]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B2] - Block
                Predecessors: [B1]
                Statements (0)
                Next (Regular) Block[B1]
                    Finalizing: {R4}
                    Leaving: {R3} {R2}
        }
        .finally {R4}
        {
            Block[B3] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B5]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a = this')
                      Operand: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a = this')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a = this')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                      Arguments(0)
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B6] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,313157,313486);

var 
expectedDiagnostics = new[]{
f_22074_313380_313470(f_22074_313380_313450(ErrorCode.ERR_GoToBackwardJumpOverUsingVar, "goto label1;"), 13, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,313502,313596);

f_22074_313502_313595(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,309916,313607);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,309916,313607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,309916,313607);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,313619,318156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,313777,314088);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M()
    /*<bind>*/{
        goto label1;
        int x = 0;
        label1:
        using var a = this;
        goto label1;
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,314102,317489);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B2]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [System.Int32 x] [P a]
        Block[B1] - Block [UnReachable]
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'x = 0')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'x = 0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B0] [B1] [B3]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'a = this')
                  Left: 
                    ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                  Right: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
            Next (Regular) Block[B3]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Next (Regular) Block[B2]
                    Finalizing: {R4}
                    Leaving: {R3} {R2}
        }
        .finally {R4}
        {
            Block[B4] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B6]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a = this')
                      Operand: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B4]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a = this')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a = this')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                      Arguments(0)
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B7] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,317503,318035);

var 
expectedDiagnostics = new[]{
f_22074_317669_317737(f_22074_317669_317717(ErrorCode.WRN_UnreachableCode, "int"), 12, 9),
f_22074_317929_318019(f_22074_317929_317999(ErrorCode.ERR_GoToBackwardJumpOverUsingVar, "goto label1;"), 15, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,318051,318145);

f_22074_318051_318144(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,313619,318156);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,313619,318156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,313619,318156);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,318168,322501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,318326,318641);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M(bool b)
    /*<bind>*/{
        if (b)
            goto label1;
        int x = 0;
        label1:
        using var a = this;
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,318655,322313);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [System.Int32 x] [P a]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Jump if False (Regular) to Block[B2]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
            Next (Regular) Block[B3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'x = 0')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'x = 0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B1] [B2]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'a = this')
                  Left: 
                    ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                  Right: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
            Next (Regular) Block[B4]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B4] - Block
                Predecessors: [B3]
                Statements (0)
                Next (Regular) Block[B8]
                    Finalizing: {R4}
                    Leaving: {R3} {R2} {R1}
        }
        .finally {R4}
        {
            Block[B5] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B7]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a = this')
                      Operand: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a = this')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a = this')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                      Arguments(0)
                Next (Regular) Block[B7]
            Block[B7] - Block
                Predecessors: [B5] [B6]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B8] - Exit
        Predecessors: [B4]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,322327,322380);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,322396,322490);

f_22074_322396_322489(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,318168,322501);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,318168,322501);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,318168,322501);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,322513,326485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,322671,322966);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M(bool b)
    /*<bind>*/{
        label1:
        using var a = this;
        if (b)
            goto label1;
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,322980,326015);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [P a]
        Block[B1] - Block
            Predecessors: [B0] [B2]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'a = this')
                  Left: 
                    ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                  Right: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
            Next (Regular) Block[B2]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B2] - Block
                Predecessors: [B1]
                Statements (0)
                Jump if False (Regular) to Block[B6]
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                    Finalizing: {R4}
                    Leaving: {R3} {R2} {R1}
                Next (Regular) Block[B1]
                    Finalizing: {R4}
                    Leaving: {R3} {R2}
        }
        .finally {R4}
        {
            Block[B3] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B5]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a = this')
                      Operand: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a = this')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a = this')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                      Arguments(0)
                Next (Regular) Block[B5]
            Block[B5] - Block
                Predecessors: [B3] [B4]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B6] - Exit
        Predecessors: [B2]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,326029,326364);

var 
expectedDiagnostics = new[]{
f_22074_326257_326348(f_22074_326257_326327(ErrorCode.ERR_GoToBackwardJumpOverUsingVar, "goto label1;"), 14, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,326380,326474);

f_22074_326380_326473(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,322513,326485);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,322513,326485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,322513,326485);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,326497,331415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,326655,327012);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
class P : System.IDisposable
{
    public void Dispose()
    {
    }

    void M(bool b)
    /*<bind>*/{
        if (b)
            goto label1;
        int x = 0;
        label1:
        using var a = this;
        if (b)
            goto label1;
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,327026,330945);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1}
    .locals {R1}
    {
        Locals: [System.Int32 x] [P a]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Jump if False (Regular) to Block[B2]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
            Next (Regular) Block[B3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'x = 0')
                  Left: 
                    ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'x = 0')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B1] [B2] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'a = this')
                  Left: 
                    ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                  Right: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
            Next (Regular) Block[B4]
                Entering: {R2} {R3}
        .try {R2, R3}
        {
            Block[B4] - Block
                Predecessors: [B3]
                Statements (0)
                Jump if False (Regular) to Block[B8]
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                    Finalizing: {R4}
                    Leaving: {R3} {R2} {R1}
                Next (Regular) Block[B3]
                    Finalizing: {R4}
                    Leaving: {R3} {R2}
        }
        .finally {R4}
        {
            Block[B5] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B7]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a = this')
                      Operand: 
                        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'a = this')
                      Instance Receiver: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsImplicit) (Syntax: 'a = this')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitReference)
                          Operand: 
                            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'a = this')
                      Arguments(0)
                Next (Regular) Block[B7]
            Block[B7] - Block
                Predecessors: [B5] [B6]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
    }
    Block[B8] - Exit
        Predecessors: [B4]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,330959,331294);

var 
expectedDiagnostics = new[]{
f_22074_331187_331278(f_22074_331187_331257(ErrorCode.ERR_GoToBackwardJumpOverUsingVar, "goto label1;"), 17, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,331310,331404);

f_22074_331310_331403(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,326497,331415);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,326497,331415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,326497,331415);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,331427,333651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,331585,331813);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
ref struct P 
{
    public void Dispose()
    {
    }

    void M(bool b)
    /*<bind>*/{
            using var x = new P();
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,331827,333463);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [P x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation ( void P.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x = new P()')
                  Instance Receiver: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,333477,333530);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,333546,333640);

f_22074_333546_333639(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,331427,333651);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,331427,333651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,331427,333651);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_21()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,333663,337032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,333821,333997);

string 
source = @"
ref struct P 
{
    public object Dispose() => null;

    void M(bool b)
    /*<bind>*/{
            using var x = new P();
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,334011,336141);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [P x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsInvalid, IsImplicit) (Syntax: 'x = new P()')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'x = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P, IsInvalid) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsInvalid, IsImplicit) (Syntax: 'x = new P()')
                  Instance Receiver: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, IsInvalid, IsImplicit) (Syntax: 'x = new P()')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'x = new P()')
                  Arguments(0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,336155,336911);

var 
expectedDiagnostics = new[]
            {
f_22074_336425_336564(f_22074_336425_336544(f_22074_336425_336496(ErrorCode.WRN_PatternBadSignature, "using var x = new P();"), "P", "disposable", "P.Dispose()"), 8, 13),
f_22074_336791_336895(f_22074_336791_336875(f_22074_336791_336856(ErrorCode.ERR_NoConvToIDisp, "using var x = new P();"), "P"), 8, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,336927,337021);

f_22074_336927_337020(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,333663,337032);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,333663,337032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,333663,337032);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_22()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,337044,341851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,337202,337478);

string 
source = @"
#pragma  warning disable CS0815, CS0219, CS0164
ref struct P 
{
    public void Dispose(int a = 1, bool b = true, params object[] extras)
    {
    }

    void M(bool b)
    /*<bind>*/{
            using var x = new P();
    }/*</bind>*/

}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,337492,341663);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [P x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IInvocationOperation ( void P.Dispose([System.Int32 a = 1], [System.Boolean b = true], params System.Object[] extras)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'x = new P()')
                  Instance Receiver: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
                  Arguments(3):
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using var x = new P();')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'using var x = new P();')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: b) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using var x = new P();')
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'using var x = new P();')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using var x = new P();')
                        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'using var x = new P();')
                          Dimension Sizes(1):
                              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'using var x = new P();')
                          Initializer: 
                            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'using var x = new P();')
                              Element Values(0)
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B4] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,341677,341730);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,341746,341840);

f_22074_341746_341839(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,337044,341851);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,337044,341851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,337044,341851);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_23()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,341863,344905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,342021,342250);

string 
source = @"
using System.Threading.Tasks;
class P 
{
    public virtual Task DisposeAsync() => throw null;

    async Task M(bool b)
    /*<bind>*/{
            await using var x = new P();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,342264,344682);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [P x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x = new P()')
                  Operand: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'x = new P()')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.Task P.DisposeAsync()) (OperationKind.Invocation, Type: System.Threading.Tasks.Task, IsImplicit) (Syntax: 'x = new P()')
                      Instance Receiver: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
                      Arguments(0)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,344696,344749);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,344765,344894);

f_22074_344765_344893(source + s_IAsyncEnumerable + s_ValueTask, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,341863,344905);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,341863,344905);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,341863,344905);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void UsingDeclaration_Flow_24()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,344917,350650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,345075,345352);

string 
source = @"
using System.Threading.Tasks;
class P 
{
    public virtual Task DisposeAsync(int a = 1, bool b = true, params object[] extras) => throw null;

    async Task M(bool b)
    /*<bind>*/{
            await using var x = new P();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,345366,350427);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [P x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Left: 
                ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
              Right: 
                IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P()')
                  Arguments(0)
                  Initializer: 
                    null
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'x = new P()')
                  Operand: 
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IAwaitOperation (OperationKind.Await, Type: System.Void, IsImplicit) (Syntax: 'x = new P()')
                  Expression: 
                    IInvocationOperation (virtual System.Threading.Tasks.Task P.DisposeAsync([System.Int32 a = 1], [System.Boolean b = true], params System.Object[] extras)) (OperationKind.Invocation, Type: System.Threading.Tasks.Task, IsImplicit) (Syntax: 'x = new P()')
                      Instance Receiver: 
                        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: P, IsImplicit) (Syntax: 'x = new P()')
                      Arguments(3):
                          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using ...  = new P();')
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'await using ...  = new P();')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: b) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using ...  = new P();')
                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'await using ...  = new P();')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: extras) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'await using ...  = new P();')
                            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'await using ...  = new P();')
                              Dimension Sizes(1):
                                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'await using ...  = new P();')
                              Initializer: 
                                IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'await using ...  = new P();')
                                  Element Values(0)
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,350441,350494);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,350510,350639);

f_22074_350510_350638(source + s_IAsyncEnumerable + s_ValueTask, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,344917,350650);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,344917,350650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,344917,350650);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_SingleDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,350664,352407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,350872,351079);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        /*<bind>*/using var c = new C();/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,351093,352185);

string 
expectedOperationTree = @"
    IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using var c = new C();')
      DeclarationGroup: 
        IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using var c = new C();')
          IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c = new C()')
            Declarators:
                IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
                  Initializer: 
                    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                      IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                        Arguments(0)
                        Initializer: 
                          null
            Initializer: 
              null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,352201,352254);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,352270,352396);

f_22074_352270_352395(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,350664,352407);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,350664,352407);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,350664,352407);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_MultipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,352419,356573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,352630,352899);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
/*<bind>*/{
        using var c = new C();
        using var d = new C();
        using var e = new C();
    }  /*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,352913,356371);

string 
expectedOperationTree = @"
    IBlockOperation (3 statements, 3 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: C c
        Local_2: C d
        Local_3: C e
      IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using var c = new C();')
        DeclarationGroup: 
          IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using var c = new C();')
            IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c = new C()')
              Declarators:
                  IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
                    Initializer: 
                      IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
              Initializer: 
                null
      IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using var d = new C();')
        DeclarationGroup: 
          IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using var d = new C();')
            IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var d = new C()')
              Declarators:
                  IVariableDeclaratorOperation (Symbol: C d) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd = new C()')
                    Initializer: 
                      IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
              Initializer: 
                null
      IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using var e = new C();')
        DeclarationGroup: 
          IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using var e = new C();')
            IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var e = new C()')
              Declarators:
                  IVariableDeclaratorOperation (Symbol: C e) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e = new C()')
                    Initializer: 
                      IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
              Initializer: 
                null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,356387,356440);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,356456,356562);

f_22074_356456_356561(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,352419,356573);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,352419,356573);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,352419,356573);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_SingleDeclaration_MultipleVariables()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,356585,359444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,356811,357042);

string 
source = @"
using System;

class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    {
        /*<bind>*/using C c = new C(), d = new C(), e = new C();/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,357056,359222);

string 
expectedOperationTree = @"
    IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using C c = ...  = new C();')
      DeclarationGroup: 
        IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using C c = ...  = new C();')
          IVariableDeclarationOperation (3 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C c = new C ... e = new C()')
            Declarators:
                IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
                  Initializer: 
                    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                      IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                        Arguments(0)
                        Initializer: 
                          null
                IVariableDeclaratorOperation (Symbol: C d) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd = new C()')
                  Initializer: 
                    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                      IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                        Arguments(0)
                        Initializer: 
                          null
                IVariableDeclaratorOperation (Symbol: C e) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e = new C()')
                  Initializer: 
                    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                      IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                        Arguments(0)
                        Initializer: 
                          null
            Initializer: 
              null"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,359238,359291);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,359307,359433);

f_22074_359307_359432(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,356585,359444);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,356585,359444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,356585,359444);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_MultipleDeclaration_WithLabels()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,359456,362984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,359677,359985);

string 
source = @"
using System;
#pragma warning disable CS0164
class C : IDisposable
{
    public void Dispose()
    {
    }

    public static void M1()
    /*<bind>*/{
    label1:
        using var a = new C();
    label2:
    label3:
        using var b = new C();
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,359999,362782);

string 
expectedOperationTree = @"
IBlockOperation (2 statements, 2 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: C a
    Local_2: C b
  ILabeledOperation (Label: label1) (OperationKind.Labeled, Type: null) (Syntax: 'label1: ...  = new C();')
    Statement: 
      IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using var a = new C();')
        DeclarationGroup: 
          IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using var a = new C();')
            IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var a = new C()')
              Declarators:
                  IVariableDeclaratorOperation (Symbol: C a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a = new C()')
                    Initializer: 
                      IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                        IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                          Arguments(0)
                          Initializer: 
                            null
              Initializer: 
                null
  ILabeledOperation (Label: label2) (OperationKind.Labeled, Type: null) (Syntax: 'label2: ...  = new C();')
    Statement: 
      ILabeledOperation (Label: label3) (OperationKind.Labeled, Type: null) (Syntax: 'label3: ...  = new C();')
        Statement: 
          IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using var b = new C();')
            DeclarationGroup: 
              IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using var b = new C();')
                IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var b = new C()')
                  Declarators:
                      IVariableDeclaratorOperation (Symbol: C b) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'b = new C()')
                        Initializer: 
                          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                            IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                              Arguments(0)
                              Initializer: 
                                null
                  Initializer: 
                    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,362798,362851);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,362867,362973);

f_22074_362867_362972(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,359456,362984);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,359456,362984);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,359456,362984);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_SingleDeclaration_Async()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,362996,364873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,363210,363531);

string 
source = @"
using System;
using System.Threading.Tasks;

namespace System { interface IAsyncDisposable { } }

class C
{
    public Task DisposeAsync()
    {
        return default;
    }

    public static async Task M1()
    {
        /*<bind>*/await using var c = new C();/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,363545,364651);

string 
expectedOperationTree = @"
IUsingDeclarationOperation(IsAsynchronous: True, DisposeMethod: System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'await using ...  = new C();')
  DeclarationGroup: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'await using ...  = new C();')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c = new C()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,364667,364720);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,364736,364862);

f_22074_364736_364861(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,362996,364873);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,362996,364873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,362996,364873);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_MultipleDeclarations_Async()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,364885,369197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,365102,365497);

string 
source = @"
using System;
using System.Threading.Tasks;

namespace System { interface IAsyncDisposable { } }

class C
{
    public Task DisposeAsync()
    {
        return default;
    }

    public static async Task M1()
/*<bind>*/{
        await using var c = new C();
        await using var d = new C();
        await using var e = new C();
    }  /*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,365511,368995);

string 
expectedOperationTree = @"
IBlockOperation (3 statements, 3 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: C c
    Local_2: C d
    Local_3: C e
  IUsingDeclarationOperation(IsAsynchronous: True, DisposeMethod: System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'await using ...  = new C();')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'await using ...  = new C();')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var c = new C()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
  IUsingDeclarationOperation(IsAsynchronous: True, DisposeMethod: System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'await using ...  = new C();')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'await using ...  = new C();')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var d = new C()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: C d) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
  IUsingDeclarationOperation(IsAsynchronous: True, DisposeMethod: System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'await using ...  = new C();')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'await using ...  = new C();')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var e = new C()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: C e) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,369011,369064);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,369080,369186);

f_22074_369080_369185(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,364885,369197);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,364885,369197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,364885,369197);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_SingleDeclaration_MultipleVariables_Async()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,369209,372138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,369441,369786);

string 
source = @"
using System;
using System.Threading.Tasks;

namespace System { interface IAsyncDisposable { } }

class C
{
    public Task DisposeAsync()
    {
        return default;
    }

    public static async Task M1()
    {
        /*<bind>*/await using C c = new C(), d = new C(), e = new C();/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,369800,371916);

string 
expectedOperationTree = @"
IUsingDeclarationOperation(IsAsynchronous: True, DisposeMethod: System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'await using ...  = new C();')
  DeclarationGroup: 
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'await using ...  = new C();')
      IVariableDeclarationOperation (3 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C c = new C ... e = new C()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
            IVariableDeclaratorOperation (Symbol: C d) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
            IVariableDeclaratorOperation (Symbol: C e) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e = new C()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                  IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,371932,371985);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,372001,372127);

f_22074_372001_372126(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,369209,372138);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,369209,372138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,369209,372138);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(32100, "https://github.com/dotnet/roslyn/issues/32100")]
        public void UsingDeclaration_RegularAsync_Mix()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,372150,378616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,372357,372853);

string 
source = @"
using System;
using System.Threading.Tasks;

namespace System { interface IAsyncDisposable { } }

class C : IDisposable
{
    public Task DisposeAsync()
    {
        return default;
    }

    public void Dispose()
    {
    }

    public static async Task M1()
/*<bind>*/{
        using C c = new C();
        await using C d = new C();
        using C e = new C(), f = new C();
        await using C g = new C(), h = new C();
    }  /*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,372867,378414);

string 
expectedOperationTree = @"
IBlockOperation (4 statements, 6 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: C c
    Local_2: C d
    Local_3: C e
    Local_4: C f
    Local_5: C g
    Local_6: C h
  IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using C c = new C();')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using C c = new C();')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C c = new C()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: C c) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'c = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
  IUsingDeclarationOperation(IsAsynchronous: True, DisposeMethod: System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'await using ...  = new C();')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'await using ...  = new C();')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C d = new C()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: C d) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'd = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
  IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using C e = ...  = new C();')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using C e = ...  = new C();')
        IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C e = new C ... f = new C()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: C e) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'e = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
              IVariableDeclaratorOperation (Symbol: C f) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'f = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
  IUsingDeclarationOperation(IsAsynchronous: True, DisposeMethod: System.Threading.Tasks.Task C.DisposeAsync()) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'await using ...  = new C();')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'await using ...  = new C();')
        IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'C g = new C ... h = new C()')
          Declarators:
              IVariableDeclaratorOperation (Symbol: C g) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'g = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
              IVariableDeclaratorOperation (Symbol: C h) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'h = new C()')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new C()')
                    IObjectCreationOperation (Constructor: C..ctor()) (OperationKind.ObjectCreation, Type: C) (Syntax: 'new C()')
                      Arguments(0)
                      Initializer: 
                        null
          Initializer: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,378430,378483);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,378499,378605);

f_22074_378499_378604(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,372150,378616);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,372150,378616);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,372150,378616);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void UsingDeclaration_DefaultDisposeArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,378628,382600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,378776,379010);

string 
source = @"
class C
{
    public static void M1()
    {
        /*<bind>*/using var s = new S();/*</bind>*/
    }
}

ref struct S
{
    public void Dispose(int a = 1, bool b = true, params object[] others) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,379024,382378);

string 
expectedOperationTree = @"
IUsingDeclarationOperation(IsAsynchronous: False, DisposeMethod: void S.Dispose([System.Int32 a = 1], [System.Boolean b = true], params System.Object[] others)) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using var s = new S();')
  DeclarationGroup:
    IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using var s = new S();')
      IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'var s = new S()')
        Declarators:
            IVariableDeclaratorOperation (Symbol: S s) (OperationKind.VariableDeclarator, Type: null) (Syntax: 's = new S()')
              Initializer: 
                IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new S()')
                  IObjectCreationOperation (Constructor: S..ctor()) (OperationKind.ObjectCreation, Type: S) (Syntax: 'new S()')
                    Arguments(0)
                    Initializer: 
                      null
        Initializer: 
          null
  DisposeArguments(3):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: a) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using var s = new S();')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'using var s = new S();')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: b) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using var s = new S();')
        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'using var s = new S();')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: others) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'using var s = new S();')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Object[], IsImplicit) (Syntax: 'using var s = new S();')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'using var s = new S();')
          Initializer: 
            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'using var s = new S();')
              Element Values(0)
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,382394,382447);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,382463,382589);

f_22074_382463_382588(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,378628,382600);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,378628,382600);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,378628,382600);
}
		}

[Fact]
        public void UsingDeclaration_LocalFunctionDefinedAfterUsingReferenceBeforeUsing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,382612,391180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,382734,383072);

var 
comp = f_22074_382745_383071(@"
using System;

class C
{
    void M()
    /*<bind>*/{
        localFunc2();
        static void localFunc() {}

        using IDisposable i = null;
        localFunc();

        static void localFunc2() {}
        localFunc3();

        static void localFunc3() {}
    }/*</bind>*/
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,383088,386594);

f_22074_383088_386593(comp, @"
IBlockOperation (7 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: System.IDisposable i
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'localFunc2();')
    Expression: 
      IInvocationOperation (void localFunc2()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'localFunc2()')
        Instance Receiver: 
          null
        Arguments(0)
  ILocalFunctionOperation (Symbol: void localFunc()) (OperationKind.LocalFunction, Type: null) (Syntax: 'static void ... alFunc() {}')
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{}')
      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{}')
        ReturnedValue: 
          null
  IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using IDisp ... e i = null;')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using IDisp ... e i = null;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'IDisposable i = null')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.IDisposable i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = null')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= null')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
          Initializer: 
            null
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'localFunc();')
    Expression: 
      IInvocationOperation (void localFunc()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'localFunc()')
        Instance Receiver: 
          null
        Arguments(0)
  ILocalFunctionOperation (Symbol: void localFunc2()) (OperationKind.LocalFunction, Type: null) (Syntax: 'static void ... lFunc2() {}')
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{}')
      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{}')
        ReturnedValue: 
          null
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'localFunc3();')
    Expression: 
      IInvocationOperation (void localFunc3()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'localFunc3()')
        Instance Receiver: 
          null
        Arguments(0)
  ILocalFunctionOperation (Symbol: void localFunc3()) (OperationKind.LocalFunction, Type: null) (Syntax: 'static void ... lFunc3() {}')
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{}')
      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '{}')
        ReturnedValue: 
          null
", DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,386610,391169);

f_22074_386610_391168(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.IDisposable i]
    Methods: [void localFunc()] [void localFunc2()] [void localFunc3()]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'localFunc2();')
              Expression: 
                IInvocationOperation (void localFunc2()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'localFunc2()')
                  Instance Receiver: 
                    null
                  Arguments(0)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.IDisposable, IsImplicit) (Syntax: 'i = null')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.IDisposable, IsImplicit) (Syntax: 'i = null')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (2)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'localFunc();')
                  Expression: 
                    IInvocationOperation (void localFunc()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'localFunc()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'localFunc3();')
                  Expression: 
                    IInvocationOperation (void localFunc3()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'localFunc3()')
                      Instance Receiver: 
                        null
                      Arguments(0)
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i = null')
                  Operand: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.IDisposable, IsImplicit) (Syntax: 'i = null')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'i = null')
                  Instance Receiver: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.IDisposable, IsImplicit) (Syntax: 'i = null')
                  Arguments(0)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
    
    {   void localFunc()
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Exit
            Predecessors: [B0#0R1]
            Statements (0)
    }
    
    {   void localFunc2()
    
        Block[B0#1R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#1R1]
        Block[B1#1R1] - Exit
            Predecessors: [B0#1R1]
            Statements (0)
    }
    
    {   void localFunc3()
    
        Block[B0#2R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#2R1]
        Block[B1#2R1] - Exit
            Predecessors: [B0#2R1]
            Statements (0)
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,382612,391180);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,382612,391180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,382612,391180);
}
		}

[Fact]
        public void UsingDeclaration_LocalDefinedAfterUsingReferenceBeforeUsing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22074,391192,399075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,391306,391510);

var 
comp = f_22074_391317_391509(@"
using System;

class C
{
    void M()
    /*<bind>*/{
        _ = local;
        using IDisposable i = null;
        object local = null;
    }/*</bind>*/
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,391526,391859);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22074_391736_391843(f_22074_391736_391823(f_22074_391736_391800(ErrorCode.ERR_VariableUsedBeforeDeclaration, "local"), "local"), 8, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,391875,394994);

f_22074_391875_394993(comp, @"
IBlockOperation (3 statements, 2 locals) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  Locals: Local_1: System.IDisposable i
    Local_2: System.Object local
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '_ = local;')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: var, IsInvalid) (Syntax: '_ = local')
        Left: 
          IDiscardOperation (Symbol: var _) (OperationKind.Discard, Type: var) (Syntax: '_')
        Right: 
          ILocalReferenceOperation: local (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'local')
  IUsingDeclarationOperation(IsAsynchronous: False) (OperationKind.UsingDeclaration, Type: null) (Syntax: 'using IDisp ... e i = null;')
    DeclarationGroup: 
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'using IDisp ... e i = null;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'IDisposable i = null')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.IDisposable i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = null')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= null')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
          Initializer: 
            null
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'object local = null;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'object local = null')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Object local) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'local = null')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= null')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
      Initializer: 
        null
", expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22074,395010,399064);

f_22074_395010_399063(comp, @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    Locals: [System.IDisposable i] [System.Object local]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: '_ = local;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: var, IsInvalid) (Syntax: '_ = local')
                  Left: 
                    IDiscardOperation (Symbol: var _) (OperationKind.Discard, Type: var) (Syntax: '_')
                  Right: 
                    ILocalReferenceOperation: local (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'local')
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.IDisposable, IsImplicit) (Syntax: 'i = null')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.IDisposable, IsImplicit) (Syntax: 'i = null')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.IDisposable, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Next (Regular) Block[B2]
            Entering: {R2} {R3}
    .try {R2, R3}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsImplicit) (Syntax: 'local = null')
                  Left: 
                    ILocalReferenceOperation: local (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Object, IsImplicit) (Syntax: 'local = null')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
            Next (Regular) Block[B6]
                Finalizing: {R4}
                Leaving: {R3} {R2} {R1}
    }
    .finally {R4}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i = null')
                  Operand: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.IDisposable, IsImplicit) (Syntax: 'i = null')
            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IInvocationOperation (virtual void System.IDisposable.Dispose()) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'i = null')
                  Instance Receiver: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.IDisposable, IsImplicit) (Syntax: 'i = null')
                  Arguments(0)
            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
}
Block[B6] - Exit
    Predecessors: [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22074,391192,399075);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22074,391192,399075);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22074,391192,399075);
}
		}

int
f_22074_3334_3448(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 3334, 3448);
return 0;
}


int
f_22074_6474_6623(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 6474, 6623);
return 0;
}


int
f_22074_11214_11342(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 11214, 11342);
return 0;
}


int
f_22074_14771_14885(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 14771, 14885);
return 0;
}


int
f_22074_16990_17104(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 16990, 17104);
return 0;
}


int
f_22074_21738_21852(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 21738, 21852);
return 0;
}


int
f_22074_24909_25023(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 24909, 25023);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_29336_29437(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 29336, 29437);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_29336_29458(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 29336, 29458);
return return_v;
}


int
f_22074_29490_29604(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 29490, 29604);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_34940_34989(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 34940, 34989);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_34940_35010(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 34940, 35010);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35128_35174(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35128, 35174);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35128_35193(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35128, 35193);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35128_35214(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35128, 35214);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35315_35363(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35315, 35363);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35315_35384(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35315, 35384);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35485_35530(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35485, 35530);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35485_35551(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35485, 35551);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35652_35700(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35652, 35700);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35652_35721(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35652, 35721);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35822_35867(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35822, 35867);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_35822_35888(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35822, 35888);
return return_v;
}


int
f_22074_35920_36025(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 35920, 36025);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_39099_39158(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 39099, 39158);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_39099_39177(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 39099, 39177);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_39099_39197(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 39099, 39197);
return return_v;
}


int
f_22074_39229_39343(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 39229, 39343);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_41597_41642(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 41597, 41642);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_41597_41661(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 41597, 41661);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_41597_41682(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 41597, 41682);
return return_v;
}


int
f_22074_41714_41828(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 41714, 41828);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_42709_42755(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 42709, 42755);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_42709_42774(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 42709, 42774);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_42709_42794(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 42709, 42794);
return return_v;
}


int
f_22074_42826_42940(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 42826, 42940);
return 0;
}


int
f_22074_43862_43976(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 43862, 43976);
return 0;
}


int
f_22074_45608_45722(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 45608, 45722);
return 0;
}


int
f_22074_46466_46580(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 46466, 46580);
return 0;
}


int
f_22074_47793_47912(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 47793, 47912);
return 0;
}


int
f_22074_49758_49863(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 49758, 49863);
return 0;
}


int
f_22074_50553_50667(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 50553, 50667);
return 0;
}


int
f_22074_51711_51829(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 51711, 51829);
return 0;
}


int
f_22074_54439_54553(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 54439, 54553);
return 0;
}


int
f_22074_58456_58570(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 58456, 58570);
return 0;
}


int
f_22074_61692_61806(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<UsingStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 61692, 61806);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_67656_67722(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 67656, 67722);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_67656_67743(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 67656, 67743);
return return_v;
}


int
f_22074_67775_67880(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 67775, 67880);
return 0;
}


int
f_22074_67897_67994(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 67897, 67994);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_22074_69585_69630(string
ilSource)
{
var return_v = CreateMetadataReferenceFromIlSource( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 69585, 69630);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_69665_69706(string
source,string
ilSource)
{
var return_v = CreateCompilationWithIL( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 69665, 69706);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_69721_69752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 69721, 69752);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22074_69784_69813(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 69784, 69813);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22074_69830_70173(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 69830, 70173);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22074_70188_70636(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 70188, 70636);
return return_v;
}


int
f_22074_75804_75914(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 75804, 75914);
return 0;
}


int
f_22074_75931_76033(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 75931, 76033);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_22074_77135_77180(string
ilSource)
{
var return_v = CreateMetadataReferenceFromIlSource( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 77135, 77180);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_77467_77535(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 77467, 77535);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_77467_77584(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 77467, 77584);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_77467_77604(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 77467, 77604);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_77808_77866(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 77808, 77866);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_77808_77885(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 77808, 77885);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_77808_77905(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 77808, 77905);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_78121_78181(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 78121, 78181);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_78121_78230(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 78121, 78230);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_78121_78251(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 78121, 78251);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_78301_78342(string
source,string
ilSource)
{
var return_v = CreateCompilationWithIL( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 78301, 78342);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_78357_78407(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 78357, 78407);
return return_v;
}


int
f_22074_81880_81990(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 81880, 81990);
return 0;
}


int
f_22074_82007_82109(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 82007, 82109);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_22074_83225_83270(string
ilSource)
{
var return_v = CreateMetadataReferenceFromIlSource( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 83225, 83270);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_83557_83625(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 83557, 83625);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_83557_83674(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 83557, 83674);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_83557_83694(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 83557, 83694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_83898_83956(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 83898, 83956);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_83898_83975(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 83898, 83975);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_83898_83995(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 83898, 83995);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_84211_84271(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 84211, 84271);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_84211_84320(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 84211, 84320);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_84211_84341(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 84211, 84341);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_84391_84432(string
source,string
ilSource)
{
var return_v = CreateCompilationWithIL( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 84391, 84432);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_84447_84497(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 84447, 84497);
return return_v;
}


int
f_22074_87970_88080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 87970, 88080);
return 0;
}


int
f_22074_88097_88199(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 88097, 88199);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_22074_89325_89370(string
ilSource)
{
var return_v = CreateMetadataReferenceFromIlSource( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 89325, 89370);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_89657_89725(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 89657, 89725);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_89657_89774(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 89657, 89774);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_89657_89794(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 89657, 89794);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_89998_90056(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 89998, 90056);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_89998_90075(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 89998, 90075);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_89998_90095(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 89998, 90095);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_90311_90371(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 90311, 90371);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_90311_90420(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 90311, 90420);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_90311_90441(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 90311, 90441);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_90491_90532(string
source,string
ilSource)
{
var return_v = CreateCompilationWithIL( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 90491, 90532);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_90547_90597(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 90547, 90597);
return return_v;
}


int
f_22074_94070_94180(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 94070, 94180);
return 0;
}


int
f_22074_94197_94299(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 94197, 94299);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_22074_95462_95507(string
ilSource)
{
var return_v = CreateMetadataReferenceFromIlSource( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 95462, 95507);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_95804_95872(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 95804, 95872);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_95804_95931(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 95804, 95931);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_95804_95951(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 95804, 95951);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_96155_96213(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 96155, 96213);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_96155_96232(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 96155, 96232);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_96155_96252(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 96155, 96252);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_96478_96538(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 96478, 96538);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_96478_96597(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 96478, 96597);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_96478_96618(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 96478, 96618);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_96668_96709(string
source,string
ilSource)
{
var return_v = CreateCompilationWithIL( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 96668, 96709);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_96724_96774(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 96724, 96774);
return return_v;
}


int
f_22074_98102_98212(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 98102, 98212);
return 0;
}


int
f_22074_100379_100481(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 100379, 100481);
return 0;
}


int
f_22074_105339_105432(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 105339, 105432);
return 0;
}


int
f_22074_110747_110840(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 110747, 110840);
return 0;
}


int
f_22074_114858_114951(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 114858, 114951);
return 0;
}


int
f_22074_119619_119712(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 119619, 119712);
return 0;
}


int
f_22074_125027_125120(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 125027, 125120);
return 0;
}


int
f_22074_130955_131048(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 130955, 131048);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_136639_136706(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 136639, 136706);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_136639_136737(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 136639, 136737);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_136639_136757(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 136639, 136757);
return return_v;
}


int
f_22074_136789_136882(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 136789, 136882);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_141124_141194(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 141124, 141194);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_141124_141224(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 141124, 141224);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_141124_141244(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 141124, 141244);
return return_v;
}


int
f_22074_141276_141369(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 141276, 141369);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_146313_146397(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 146313, 146397);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_146313_146427(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 146313, 146427);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_146313_146447(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 146313, 146447);
return return_v;
}


int
f_22074_146479_146572(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 146479, 146572);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_152158_152225(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 152158, 152225);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_152158_152256(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 152158, 152256);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_152158_152276(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 152158, 152276);
return return_v;
}


int
f_22074_152308_152401(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 152308, 152401);
return 0;
}


int
f_22074_158582_158675(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 158582, 158675);
return 0;
}


int
f_22074_166367_166460(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 166367, 166460);
return 0;
}


int
f_22074_170291_170384(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 170291, 170384);
return 0;
}


int
f_22074_175343_175436(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 175343, 175436);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_175827_175866(string
source)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 175827, 175866);
return return_v;
}


int
f_22074_175881_175953(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
member)
{
this_param.MakeMemberMissing( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 175881, 175953);
return 0;
}


int
f_22074_179316_179414(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 179316, 179414);
return 0;
}


int
f_22074_182243_182336(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 182243, 182336);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_185858_185907(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 185858, 185907);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_185858_185927(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 185858, 185927);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_185858_185947(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 185858, 185947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_185990_186063(string[]
source)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 185990, 186063);
return return_v;
}


int
f_22074_186078_186169(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 186078, 186169);
return 0;
}


int
f_22074_190246_190374(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 190246, 190374);
return 0;
}


int
f_22074_195644_195772(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 195644, 195772);
return 0;
}


int
f_22074_199609_199737(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 199609, 199737);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_203199_203256(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 203199, 203256);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_203199_203323(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 203199, 203323);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_203199_203343(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 203199, 203343);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_203616_203668(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 203616, 203668);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_203616_203687(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 203616, 203687);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_203616_203707(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 203616, 203707);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_203954_204013(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 203954, 204013);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_203954_204034(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 203954, 204034);
return return_v;
}


int
f_22074_204066_204194(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 204066, 204194);
return 0;
}


int
f_22074_207361_207454(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 207361, 207454);
return 0;
}


int
f_22074_215701_215794(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 215701, 215794);
return 0;
}


int
f_22074_223805_223898(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 223805, 223898);
return 0;
}


int
f_22074_232069_232162(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 232069, 232162);
return 0;
}


int
f_22074_239736_239829(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 239736, 239829);
return 0;
}


int
f_22074_250398_250491(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 250398, 250491);
return 0;
}


int
f_22074_258611_258704(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 258611, 258704);
return 0;
}


int
f_22074_268513_268606(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 268513, 268606);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_271884_271957(string[]
source)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 271884, 271957);
return return_v;
}


int
f_22074_271972_272063(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 271972, 272063);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_283524_283597(string[]
source)
{
var return_v = CreateCompilationWithTasksExtensions( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 283524, 283597);
return return_v;
}


int
f_22074_283612_283703(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 283612, 283703);
return 0;
}


int
f_22074_290780_290873(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 290780, 290873);
return 0;
}


int
f_22074_297919_298012(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 297919, 298012);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_305112_305205(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 305112, 305205);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_305112_305226(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 305112, 305226);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_305399_305513(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 305399, 305513);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_305399_305534(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 305399, 305534);
return return_v;
}


int
f_22074_305566_305659(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 305566, 305659);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_309699_309747(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 309699, 309747);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_309699_309767(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 309699, 309767);
return return_v;
}


int
f_22074_309799_309892(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 309799, 309892);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_313380_313450(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 313380, 313450);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_313380_313470(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 313380, 313470);
return return_v;
}


int
f_22074_313502_313595(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 313502, 313595);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_317669_317717(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 317669, 317717);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_317669_317737(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 317669, 317737);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_317929_317999(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 317929, 317999);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_317929_318019(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 317929, 318019);
return return_v;
}


int
f_22074_318051_318144(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 318051, 318144);
return 0;
}


int
f_22074_322396_322489(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 322396, 322489);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_326257_326327(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 326257, 326327);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_326257_326348(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 326257, 326348);
return return_v;
}


int
f_22074_326380_326473(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 326380, 326473);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_331187_331257(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 331187, 331257);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_331187_331278(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 331187, 331278);
return return_v;
}


int
f_22074_331310_331403(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 331310, 331403);
return 0;
}


int
f_22074_333546_333639(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 333546, 333639);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_336425_336496(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 336425, 336496);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_336425_336544(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 336425, 336544);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_336425_336564(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 336425, 336564);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_336791_336856(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 336791, 336856);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_336791_336875(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 336791, 336875);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_336791_336895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 336791, 336895);
return return_v;
}


int
f_22074_336927_337020(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 336927, 337020);
return 0;
}


int
f_22074_341746_341839(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 341746, 341839);
return 0;
}


int
f_22074_344765_344893(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 344765, 344893);
return 0;
}


int
f_22074_350510_350638(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 350510, 350638);
return 0;
}


int
f_22074_352270_352395(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 352270, 352395);
return 0;
}


int
f_22074_356456_356561(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 356456, 356561);
return 0;
}


int
f_22074_359307_359432(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 359307, 359432);
return 0;
}


int
f_22074_362867_362972(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 362867, 362972);
return 0;
}


int
f_22074_364736_364861(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 364736, 364861);
return 0;
}


int
f_22074_369080_369185(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 369080, 369185);
return 0;
}


int
f_22074_372001_372126(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 372001, 372126);
return 0;
}


int
f_22074_378499_378604(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 378499, 378604);
return 0;
}


int
f_22074_382463_382588(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 382463, 382588);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_382745_383071(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 382745, 383071);
return return_v;
}


int
f_22074_383088_386593(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 383088, 386593);
return 0;
}


int
f_22074_386610_391168(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 386610, 391168);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22074_391317_391509(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 391317, 391509);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_391736_391800(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 391736, 391800);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_391736_391823(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 391736, 391823);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22074_391736_391843(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 391736, 391843);
return return_v;
}


int
f_22074_391875_394993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 391875, 394993);
return 0;
}


int
f_22074_395010_399063(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22074, 395010, 399063);
return 0;
}

}
}
