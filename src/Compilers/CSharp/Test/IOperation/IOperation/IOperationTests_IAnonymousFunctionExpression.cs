// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public partial class IOperationTests : SemanticModelTestBase
    {
        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_BoundLambda_HasValidLambdaExpressionTree()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 645, 2901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 822, 1022);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/Action x = () => F();/*</bind>*/
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 1036, 2681);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'Action x = () => F();')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Action x = () => F()')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = () => F()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= () => F()')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsImplicit) (Syntax: '() => F()')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => F()')
                    IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'F()')
                      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'F()')
                        Expression: 
                          IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'F()')
                            Instance Receiver: 
                              null
                            Arguments(0)
                      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'F()')
                        ReturnedValue: 
                          null
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 2695, 2748);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 2764, 2890);

                f_22004_2764_2889(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 645, 2901);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 645, 2901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 645, 2901);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_BoundLambda_HasValidLambdaExpressionTree_JustBindingLambdaReturnsOnlyIAnonymousFunctionExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 2913, 4280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 3147, 3347);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        Action x = /*<bind>*/() => F()/*</bind>*/;
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 3361, 4056);

                string
                expectedOperationTree = @"
IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => F()')
  IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'F()')
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'F()')
      Expression: 
        IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'F()')
          Instance Receiver: 
            null
          Arguments(0)
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'F()')
      ReturnedValue: 
        null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 4070, 4123);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 4139, 4269);

                f_22004_4139_4268(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 2913, 4280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 2913, 4280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 2913, 4280);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_BoundLambda_HasValidLambdaExpressionTree_ExplicitCast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 4292, 6602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 4482, 4692);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/Action x = (Action)(() => F());/*</bind>*/
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 4706, 6382);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'Action x =  ... () => F());')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Action x =  ... (() => F())')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = (Action)(() => F())')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= (Action)(() => F())')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action) (Syntax: '(Action)(() => F())')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => F()')
                    IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'F()')
                      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'F()')
                        Expression: 
                          IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'F()')
                            Instance Receiver: 
                              null
                            Arguments(0)
                      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'F()')
                        ReturnedValue: 
                          null
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 6396, 6449);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 6465, 6591);

                f_22004_6465_6590(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 4292, 6602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 4292, 6602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 4292, 6602);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_BoundLambda_HasValidLambdaExpressionTree2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 6614, 7925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 6792, 6992);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        Action x = /*<bind>*/() => F()/*</bind>*/;
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 7006, 7701);

                string
                expectedOperationTree = @"
IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null) (Syntax: '() => F()')
  IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'F()')
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'F()')
      Expression: 
        IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'F()')
          Instance Receiver: 
            null
          Arguments(0)
    IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'F()')
      ReturnedValue: 
        null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 7715, 7768);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 7784, 7914);

                f_22004_7784_7913(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 6614, 7925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 6614, 7925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 6614, 7925);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_UnboundLambdaAsVar_HasValidLambdaExpressionTree()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 7937, 10239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 8121, 8318);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/var x = () => F();/*</bind>*/
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 8332, 9685);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'var x = () => F();')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'var x = () => F()')
    Declarators:
        IVariableDeclaratorOperation (Symbol: var x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = () => F()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= () => F()')
              IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => F()')
                IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                    Expression: 
                      IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'F()')
                        Instance Receiver: 
                          null
                        Arguments(0)
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 9699, 10086);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22004_9932_10069(f_22004_9932_10049(f_22004_9932_10014(ErrorCode.ERR_ImplicitlyTypedVariableAssignedBadValue, "x = () => F()"), "lambda expression"), 8, 23),
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 10102, 10228);

                f_22004_10102_10227(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 7937, 10239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 7937, 10239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 7937, 10239);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_UnboundLambdaAsDelegate_HasValidLambdaExpressionTree()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 10251, 12791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 10440, 10645);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/Action<int> x = () => F();/*</bind>*/
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 10659, 12268);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action<int> ...  () => F();')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action<int> ... = () => F()')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action<System.Int32> x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = () => F()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= () => F()')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Int32>, IsInvalid, IsImplicit) (Syntax: '() => F()')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => F()')
                    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                        Expression: 
                          IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'F()')
                            Instance Receiver: 
                              null
                            Arguments(0)
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 12282, 12638);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22004_12508_12622(f_22004_12508_12602(f_22004_12508_12561(ErrorCode.ERR_BadDelArgCount, "() => F()"), "System.Action<int>", "0"), 8, 35)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 12654, 12780);

                f_22004_12654_12779(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 10251, 12791);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 10251, 12791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 10251, 12791);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_UnboundLambdaAsDelegate_HasValidLambdaExpressionTree_ExplicitValidCast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 12803, 16038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 13010, 13225);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/Action<int> x = (Action)(() => F());/*</bind>*/
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 13239, 15461);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action<int> ... () => F());')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action<int> ... (() => F())')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action<System.Int32> x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = (Action)(() => F())')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (Action)(() => F())')
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Action<System.Int32>, IsInvalid, IsImplicit) (Syntax: '(Action)(() => F())')
                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid) (Syntax: '(Action)(() => F())')
                    Target: 
                      IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => F()')
                        IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                            Expression: 
                              IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'F()')
                                Instance Receiver: 
                                  null
                                Arguments(0)
                          IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                            ReturnedValue: 
                              null
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 15475, 15885);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22004_15733_15869(f_22004_15733_15849(f_22004_15733_15796(ErrorCode.ERR_NoImplicitConv, "(Action)(() => F())"), "System.Action", "System.Action<int>"), 8, 35)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 15901, 16027);

                f_22004_15901_16026(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 12803, 16038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 12803, 16038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 12803, 16038);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_UnboundLambdaAsDelegate_HasValidLambdaExpressionTree_ExplicitInvalidCast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 16050, 18673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 16259, 16479);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/Action<int> x = (Action<int>)(() => F());/*</bind>*/
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 16493, 18135);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action<int> ... () => F());')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action<int> ... (() => F())')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action<System.Int32> x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = (Action ... (() => F())')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= (Action<i ... (() => F())')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Int32>, IsInvalid) (Syntax: '(Action<int>)(() => F())')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: '() => F()')
                    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'F()')
                        Expression: 
                          IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'F()')
                            Instance Receiver: 
                              null
                            Arguments(0)
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 18149, 18520);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22004_18390_18504(f_22004_18390_18484(f_22004_18390_18443(ErrorCode.ERR_BadDelArgCount, "() => F()"), "System.Action<int>", "0"), 8, 49)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 18536, 18662);

                f_22004_18536_18661(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 16050, 18673);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 16050, 18673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 16050, 18673);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_UnboundLambda_ReferenceEquality()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 18685, 21068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 18853, 19050);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/var x = () => F();/*</bind>*/
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 19066, 19137);

                var
                compilation = f_22004_19084_19136(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 19151, 19195);

                var
                syntaxTree = f_22004_19168_19191(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 19209, 19270);

                var
                semanticModel = f_22004_19229_19269(compilation, syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 19286, 19402);

                var
                variableDeclaration = f_22004_19312_19401(f_22004_19312_19392(f_22004_19312_19350(f_22004_19312_19332(syntaxTree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 19416, 19528);

                // LAFHIS
                var temp = f_22004_19459_19490(variableDeclaration).Variables;
                var
                lambdaSyntax = (LambdaExpressionSyntax)f_22004_19459_19527(f_22004_19459_19521(f_22004_19459_19509(ref temp)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 19544, 19668);

                var
                variableDeclarationGroupOperation = (IVariableDeclarationGroupOperation)f_22004_19620_19667(semanticModel, variableDeclaration)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 19682, 19840);

                var
                variableTreeLambdaOperation = (IAnonymousFunctionOperation)f_22004_19745_19839(f_22004_19745_19833(variableDeclarationGroupOperation.Declarations.Single().Declarators.Single()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 19854, 19946);

                var
                lambdaOperation = (IAnonymousFunctionOperation)f_22004_19905_19945(semanticModel, lambdaSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 20140, 20198);

                f_22004_20140_20197(variableTreeLambdaOperation, lambdaOperation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 20214, 20351);

                var
                variableDeclarationGroupOperationSecondRequest = (IVariableDeclarationGroupOperation)f_22004_20303_20350(semanticModel, variableDeclaration)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 20365, 20536);

                var
                variableTreeLambdaOperationSecondRequest = (IAnonymousFunctionOperation)f_22004_20441_20535(f_22004_20441_20529(variableDeclarationGroupOperation.Declarations.Single().Declarators.Single()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 20550, 20655);

                var
                lambdaOperationSecondRequest = (IAnonymousFunctionOperation)f_22004_20614_20654(semanticModel, lambdaSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 20901, 20984);

                f_22004_20901_20983(variableTreeLambdaOperation, variableTreeLambdaOperationSecondRequest);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 20998, 21057);

                f_22004_20998_21056(lambdaOperation, lambdaOperationSecondRequest);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 18685, 21068);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 18685, 21068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 18685, 21068);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IAnonymousFunctionExpression_StaticLambda()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 21080, 24596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 21229, 21436);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/Action x = static () => F();/*</bind>*/
    }

    static void F()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 21450, 23202);

                string
                expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'Action x =  ...  () => F();')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Action x =  ... c () => F()')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Action x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = static () => F()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= static () => F()')
              IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action, IsInvalid, IsImplicit) (Syntax: 'static () => F()')
                Target: 
                  IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: 'static () => F()')
                    IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'F()')
                      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'F()')
                        Expression: 
                          IInvocationOperation (void Program.F()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'F()')
                            Instance Receiver: 
                              null
                            Arguments(0)
                      IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'F()')
                        ReturnedValue: 
                          null
    Initializer: 
      null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 23216, 23675);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22004_23524_23659(f_22004_23524_23639(f_22004_23524_23589(ErrorCode.ERR_FeatureNotAvailableInVersion8, "static"), "static anonymous function", "9.0"), 8, 30)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 23691, 23940);

                f_22004_23691_23939(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.Regular8);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 23956, 24027);

                var
                compilation = f_22004_23974_24026(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 24041, 24085);

                var
                syntaxTree = f_22004_24058_24081(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 24099, 24160);

                var
                semanticModel = f_22004_24119_24159(compilation, syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 24176, 24292);

                var
                variableDeclaration = f_22004_24202_24291(f_22004_24202_24282(f_22004_24202_24240(f_22004_24202_24222(syntaxTree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 24306, 24418);

                // LAFHIS
                var temp = f_22004_24349_24380(variableDeclaration).Variables;
                var
                lambdaSyntax = (LambdaExpressionSyntax)f_22004_24349_24417(f_22004_24349_24411(f_22004_24349_24399(ref temp)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 24432, 24524);

                var
                lambdaOperation = (IAnonymousFunctionOperation)f_22004_24483_24523(semanticModel, lambdaSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 24540, 24585);

                f_22004_24540_24584(f_22004_24552_24583(f_22004_24552_24574(lambdaOperation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 21080, 24596);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 21080, 24596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 21080, 24596);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LambdaFlow_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 24608, 29325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 24755, 24986);

                string
                source = @"
struct C
{
    void M(System.Action<bool, bool> d)
/*<bind>*/{
        d = (bool result, bool input) =>
        {
            result = input;
        };

        d(false, true);
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 25000, 29137);

                string
                expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'd = (bool r ... };')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action<System.Boolean, System.Boolean>) (Syntax: 'd = (bool r ... }')
              Left: 
                IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Action<System.Boolean, System.Boolean>) (Syntax: 'd')
              Right: 
                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Boolean, System.Boolean>, IsImplicit) (Syntax: '(bool resul ... }')
                  Target: 
                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null) (Syntax: '(bool resul ... }')
                    {
                        Block[B0#A0] - Entry
                            Statements (0)
                            Next (Regular) Block[B1#A0]
                        Block[B1#A0] - Block
                            Predecessors: [B0#A0]
                            Statements (1)
                                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = input;')
                                  Expression: 
                                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = input')
                                      Left: 
                                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                                      Right: 
                                        IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')

                            Next (Regular) Block[B2#A0]
                        Block[B2#A0] - Exit
                            Predecessors: [B1#A0]
                            Statements (0)
                    }

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'd(false, true);')
          Expression: 
            IInvocationOperation (virtual void System.Action<System.Boolean, System.Boolean>.Invoke(System.Boolean arg1, System.Boolean arg2)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'd(false, true)')
              Instance Receiver: 
                IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Action<System.Boolean, System.Boolean>) (Syntax: 'd')
              Arguments(2):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg1) (OperationKind.Argument, Type: null) (Syntax: 'false')
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg2) (OperationKind.Argument, Type: null) (Syntax: 'true')
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 29151, 29204);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 29220, 29314);

                f_22004_29220_29313(source, expectedGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 24608, 29325);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 24608, 29325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 24608, 29325);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LambdaFlow_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 29337, 34556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 29484, 29787);

                string
                source = @"
struct C
{
    void M(System.Action<bool, bool> d1, System.Action<bool, bool> d2)
/*<bind>*/{
        d1 = (bool result1, bool input1) =>
        {
            result1 = input1;
        };
        d2 = (bool result2, bool input2) => result2 = input2;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 29801, 34368);

                string
                expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'd1 = (bool  ... };')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action<System.Boolean, System.Boolean>) (Syntax: 'd1 = (bool  ... }')
              Left: 
                IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Action<System.Boolean, System.Boolean>) (Syntax: 'd1')
              Right: 
                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Boolean, System.Boolean>, IsImplicit) (Syntax: '(bool resul ... }')
                  Target: 
                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null) (Syntax: '(bool resul ... }')
                    {
                        Block[B0#A0] - Entry
                            Statements (0)
                            Next (Regular) Block[B1#A0]
                        Block[B1#A0] - Block
                            Predecessors: [B0#A0]
                            Statements (1)
                                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result1 = input1;')
                                  Expression: 
                                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result1 = input1')
                                      Left: 
                                        IParameterReferenceOperation: result1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result1')
                                      Right: 
                                        IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input1')

                            Next (Regular) Block[B2#A0]
                        Block[B2#A0] - Exit
                            Predecessors: [B1#A0]
                            Statements (0)
                    }

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'd2 = (bool  ... 2 = input2;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action<System.Boolean, System.Boolean>) (Syntax: 'd2 = (bool  ... t2 = input2')
              Left: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Action<System.Boolean, System.Boolean>) (Syntax: 'd2')
              Right: 
                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Boolean, System.Boolean>, IsImplicit) (Syntax: '(bool resul ... t2 = input2')
                  Target: 
                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null) (Syntax: '(bool resul ... t2 = input2')
                    {
                        Block[B0#A1] - Entry
                            Statements (0)
                            Next (Regular) Block[B1#A1]
                        Block[B1#A1] - Block
                            Predecessors: [B0#A1]
                            Statements (1)
                                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'result2 = input2')
                                  Expression: 
                                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result2 = input2')
                                      Left: 
                                        IParameterReferenceOperation: result2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result2')
                                      Right: 
                                        IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input2')

                            Next (Regular) Block[B2#A1]
                        Block[B2#A1] - Exit
                            Predecessors: [B1#A1]
                            Statements (0)
                    }

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 34382, 34435);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 34451, 34545);

                f_22004_34451_34544(source, expectedGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 29337, 34556);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 29337, 34556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 29337, 34556);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LambdaFlow_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 34568, 42256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 34715, 35083);

                string
                source = @"
struct C
{
    void M(System.Action<int> d1, System.Action<bool> d2)
/*<bind>*/{
        int i = 0;

        d1 = (int input1) =>
        {
            input1 = 1;
            i++;

            d2 = (bool input2) =>
            {
                input2 = true;
                i++;
            };
        };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 35097, 42068);

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
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 0')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'd1 = (int i ... };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action<System.Int32>) (Syntax: 'd1 = (int i ... }')
                  Left: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: System.Action<System.Int32>) (Syntax: 'd1')
                  Right: 
                    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Int32>, IsImplicit) (Syntax: '(int input1 ... }')
                      Target: 
                        IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null) (Syntax: '(int input1 ... }')
                        {
                            Block[B0#A0] - Entry
                                Statements (0)
                                Next (Regular) Block[B1#A0]
                            Block[B1#A0] - Block
                                Predecessors: [B0#A0]
                                Statements (3)
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

                                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'd2 = (bool  ... };')
                                      Expression: 
                                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action<System.Boolean>) (Syntax: 'd2 = (bool  ... }')
                                          Left: 
                                            IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: System.Action<System.Boolean>) (Syntax: 'd2')
                                          Right: 
                                            IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Boolean>, IsImplicit) (Syntax: '(bool input ... }')
                                              Target: 
                                                IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null) (Syntax: '(bool input ... }')
                                                {
                                                    Block[B0#A0#A0] - Entry
                                                        Statements (0)
                                                        Next (Regular) Block[B1#A0#A0]
                                                    Block[B1#A0#A0] - Block
                                                        Predecessors: [B0#A0#A0]
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

                                                        Next (Regular) Block[B2#A0#A0]
                                                    Block[B2#A0#A0] - Exit
                                                        Predecessors: [B1#A0#A0]
                                                        Statements (0)
                                                }

                                Next (Regular) Block[B2#A0]
                            Block[B2#A0] - Exit
                                Predecessors: [B1#A0]
                                Statements (0)
                        }

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 42082, 42135);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 42151, 42245);

                f_22004_42151_42244(source, expectedGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 34568, 42256);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 34568, 42256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 34568, 42256);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LambdaFlow_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 42268, 45106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 42415, 42786);

                string
                source = @"
struct C
{
    void M(System.Action d1, System.Action<bool, bool> d2)
/*<bind>*/{
        d1 = () =>
        {
            d2 = (bool result1, bool input1) =>
            {
                result1 = input1;
            
            };
        };

        void local(bool result2, bool input2) => result2 = input2;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 42802, 42846);

                var
                compilation = f_22004_42820_42845(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 42860, 42904);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 42918, 42973);

                var
                semanticModel = f_22004_42938_42972(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 42987, 43151);

                var
                graphM = f_22004_43000_43150(f_22004_43046_43149(semanticModel, f_22004_43073_43148(f_22004_43073_43139(f_22004_43073_43105(f_22004_43073_43087(tree))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43167, 43190);

                f_22004_43167_43189(graphM);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43204, 43231);

                f_22004_43204_43230(f_22004_43216_43229(graphM));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43247, 43308);

                IFlowAnonymousFunctionOperation
                lambdaD1 = f_22004_43290_43307(graphM)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43324, 43414);

                f_22004_43324_43413(() => graphM.GetLocalFunctionControlFlowGraph(null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43428, 43535);

                f_22004_43428_43534(() => graphM.GetLocalFunctionControlFlowGraph(lambdaD1.Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43549, 43646);

                f_22004_43549_43645(() => graphM.GetLocalFunctionControlFlowGraphInScope(null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43660, 43774);

                f_22004_43660_43773(() => graphM.GetLocalFunctionControlFlowGraphInScope(lambdaD1.Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43790, 43858);

                var
                graphD1 = f_22004_43804_43857(graphM, lambdaD1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43872, 43896);

                f_22004_43872_43895(graphD1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43910, 43946);

                f_22004_43910_43945(graphM, f_22004_43930_43944(graphD1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 43960, 44049);

                var
                graphD1_FromExtension = f_22004_43988_44048(graphM, lambdaD1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44063, 44107);

                f_22004_44063_44106(graphD1, graphD1_FromExtension);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44123, 44185);

                IFlowAnonymousFunctionOperation
                lambdaD2 = f_22004_44166_44184(graphD1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44199, 44268);

                var
                graphD2 = f_22004_44213_44267(graphD1, lambdaD2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44282, 44306);

                f_22004_44282_44305(graphD2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44320, 44357);

                f_22004_44320_44356(graphD1, f_22004_44341_44355(graphD2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44373, 44467);

                f_22004_44373_44466(() => graphM.GetAnonymousFunctionControlFlowGraph(null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44481, 44585);

                f_22004_44481_44584(() => graphM.GetAnonymousFunctionControlFlowGraph(lambdaD2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44599, 44700);

                f_22004_44599_44699(() => graphM.GetAnonymousFunctionControlFlowGraphInScope(null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44714, 44825);

                f_22004_44714_44824(() => graphM.GetAnonymousFunctionControlFlowGraphInScope(lambdaD2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 42268, 45106);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 42268, 45106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 42268, 45106);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LambdaFlow_05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 45118, 47714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 45265, 45469);

                string
                source = @"
struct C
{
    void M(System.Action d1, System.Action d2)
/*<bind>*/{
        d1 = () => { };
        d2 = () =>
        {
            d1();
        };
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 45485, 45529);

                var
                compilation = f_22004_45503_45528(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 45543, 45587);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 45601, 45656);

                var
                semanticModel = f_22004_45621_45655(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 45670, 45834);

                var
                graphM = f_22004_45683_45833(f_22004_45729_45832(semanticModel, f_22004_45756_45831(f_22004_45756_45822(f_22004_45756_45788(f_22004_45756_45770(tree))))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 45850, 45873);

                f_22004_45850_45872(graphM);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 45887, 45914);

                f_22004_45887_45913(f_22004_45899_45912(graphM));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 45930, 46001);

                IFlowAnonymousFunctionOperation
                lambdaD1 = f_22004_45973_46000(graphM, index: 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46015, 46040);

                f_22004_46015_46039(lambdaD1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46054, 46125);

                IFlowAnonymousFunctionOperation
                lambdaD2 = f_22004_46097_46124(graphM, index: 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46139, 46164);

                f_22004_46139_46163(lambdaD2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46180, 46270);

                f_22004_46180_46269(() => graphM.GetLocalFunctionControlFlowGraph(null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46284, 46391);

                f_22004_46284_46390(() => graphM.GetLocalFunctionControlFlowGraph(lambdaD1.Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46405, 46502);

                f_22004_46405_46501(() => graphM.GetLocalFunctionControlFlowGraphInScope(null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46516, 46630);

                f_22004_46516_46629(() => graphM.GetLocalFunctionControlFlowGraphInScope(lambdaD1.Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46646, 46714);

                var
                graphD1 = f_22004_46660_46713(graphM, lambdaD1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46728, 46752);

                f_22004_46728_46751(graphD1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46766, 46802);

                f_22004_46766_46801(graphM, f_22004_46786_46800(graphD1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46816, 46884);

                var
                graphD2 = f_22004_46830_46883(graphM, lambdaD2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46898, 46922);

                f_22004_46898_46921(graphD2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46936, 46972);

                f_22004_46936_46971(graphM, f_22004_46956_46970(graphD2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 46988, 47077);

                var
                graphD1_FromExtension = f_22004_47016_47076(graphM, lambdaD1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 47091, 47135);

                f_22004_47091_47134(graphD1, graphD1_FromExtension);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 47151, 47256);

                f_22004_47151_47255(() => graphD2.GetAnonymousFunctionControlFlowGraph(lambdaD1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 47270, 47356);

                graphD1_FromExtension = f_22004_47294_47355(graphD2, lambdaD1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 47370, 47414);

                f_22004_47370_47413(graphD1, graphD1_FromExtension);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 45118, 47714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 45118, 47714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 45118, 47714);
            }
        }

        int
        f_22004_2764_2889(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 2764, 2889);
            return 0;
        }


        int
        f_22004_4139_4268(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ParenthesizedLambdaExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 4139, 4268);
            return 0;
        }


        int
        f_22004_6465_6590(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 6465, 6590);
            return 0;
        }


        int
        f_22004_7784_7913(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<ParenthesizedLambdaExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 7784, 7913);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_9932_10014(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 9932, 10014);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_9932_10049(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 9932, 10049);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_9932_10069(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 9932, 10069);
            return return_v;
        }


        int
        f_22004_10102_10227(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 10102, 10227);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_12508_12561(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 12508, 12561);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_12508_12602(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 12508, 12602);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_12508_12622(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 12508, 12622);
            return return_v;
        }


        int
        f_22004_12654_12779(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 12654, 12779);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_15733_15796(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 15733, 15796);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_15733_15849(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 15733, 15849);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_15733_15869(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 15733, 15869);
            return return_v;
        }


        int
        f_22004_15901_16026(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 15901, 16026);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_18390_18443(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 18390, 18443);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_18390_18484(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 18390, 18484);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_18390_18504(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 18390, 18504);
            return return_v;
        }


        int
        f_22004_18536_18661(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 18536, 18661);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22004_19084_19136(string
        source)
        {
            var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19084, 19136);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22004_19168_19191(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 19168, 19191);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22004_19229_19269(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19229, 19269);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22004_19312_19332(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19312, 19332);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22004_19312_19350(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19312, 19350);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax>
        f_22004_19312_19392(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19312, 19392);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
        f_22004_19312_19401(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19312, 19401);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
        f_22004_19459_19490(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
        this_param)
        {
            var return_v = this_param.Declaration;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 19459, 19490);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        f_22004_19459_19509(ref Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19459, 19509);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
        f_22004_19459_19521(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        this_param)
        {
            var return_v = this_param.Initializer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 19459, 19521);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        f_22004_19459_19527(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 19459, 19527);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22004_19620_19667(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19620, 19667);
            return return_v;
        }


        Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
        f_22004_19745_19833(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
        this_param)
        {
            var return_v = this_param.Initializer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 19745, 19833);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation
        f_22004_19745_19839(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 19745, 19839);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22004_19905_19945(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 19905, 19945);
            return return_v;
        }


        int
        f_22004_20140_20197(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
        expected, Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation?
        actual)
        {
            Assert.Same((object)expected, (object?)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 20140, 20197);
            return 0;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22004_20303_20350(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 20303, 20350);
            return return_v;
        }


        Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
        f_22004_20441_20529(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
        this_param)
        {
            var return_v = this_param.Initializer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 20441, 20529);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation
        f_22004_20441_20535(Microsoft.CodeAnalysis.Operations.IVariableInitializerOperation?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 20441, 20535);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22004_20614_20654(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 20614, 20654);
            return return_v;
        }


        int
        f_22004_20901_20983(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
        expected, Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation
        actual)
        {
            Assert.Same((object)expected, (object)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 20901, 20983);
            return 0;
        }


        int
        f_22004_20998_21056(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation?
        expected, Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation?
        actual)
        {
            Assert.Same((object?)expected, (object?)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 20998, 21056);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_23524_23589(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 23524, 23589);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_23524_23639(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 23524, 23639);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22004_23524_23659(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 23524, 23659);
            return return_v;
        }


        int
        f_22004_23691_23939(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 23691, 23939);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22004_23974_24026(string
        source)
        {
            var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 23974, 24026);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22004_24058_24081(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 24058, 24081);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22004_24119_24159(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 24119, 24159);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22004_24202_24222(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 24202, 24222);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22004_24202_24240(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 24202, 24240);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax>
        f_22004_24202_24282(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 24202, 24282);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
        f_22004_24202_24291(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 24202, 24291);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
        f_22004_24349_24380(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
        this_param)
        {
            var return_v = this_param.Declaration;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 24349, 24380);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        f_22004_24349_24399(ref Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 24349, 24399);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
        f_22004_24349_24411(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
        this_param)
        {
            var return_v = this_param.Initializer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 24349, 24411);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        f_22004_24349_24417(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 24349, 24417);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22004_24483_24523(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 24483, 24523);
            return return_v;
        }


        Microsoft.CodeAnalysis.IMethodSymbol
        f_22004_24552_24574(Microsoft.CodeAnalysis.Operations.IAnonymousFunctionOperation?
        this_param)
        {
            var return_v = this_param.Symbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 24552, 24574);
            return return_v;
        }


        bool
        f_22004_24552_24583(Microsoft.CodeAnalysis.IMethodSymbol
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 24552, 24583);
            return return_v;
        }


        int
        f_22004_24540_24584(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 24540, 24584);
            return 0;
        }


        int
        f_22004_29220_29313(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 29220, 29313);
            return 0;
        }


        int
        f_22004_34451_34544(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 34451, 34544);
            return 0;
        }


        int
        f_22004_42151_42244(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 42151, 42244);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22004_42820_42845(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 42820, 42845);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22004_42938_42972(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 42938, 42972);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22004_43073_43087(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43073, 43087);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22004_43073_43105(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43073, 43105);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
        f_22004_43073_43139(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43073, 43139);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        f_22004_43073_43148(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43073, 43148);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22004_43046_43149(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43046, 43149);
            return return_v;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_43000_43150(Microsoft.CodeAnalysis.IOperation?
        methodBody)
        {
            var return_v = ControlFlowGraph.Create((Microsoft.CodeAnalysis.Operations.IMethodBodyOperation?)methodBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43000, 43150);
            return return_v;
        }


        int
        f_22004_43167_43189(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43167, 43189);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        f_22004_43216_43229(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 43216, 43229);
            return return_v;
        }


        int
        f_22004_43204_43230(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43204, 43230);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        f_22004_43290_43307(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        graph)
        {
            var return_v = getLambda(graph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43290, 43307);
            return return_v;
        }


        System.ArgumentNullException
        f_22004_43324_43413(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentNullException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43324, 43413);
            return return_v;
        }


        System.ArgumentOutOfRangeException
        f_22004_43428_43534(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentOutOfRangeException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43428, 43534);
            return return_v;
        }


        System.ArgumentNullException
        f_22004_43549_43645(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentNullException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43549, 43645);
            return return_v;
        }


        System.ArgumentOutOfRangeException
        f_22004_43660_43773(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentOutOfRangeException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43660, 43773);
            return return_v;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_43804_43857(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        anonymousFunction)
        {
            var return_v = this_param.GetAnonymousFunctionControlFlowGraph(anonymousFunction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43804, 43857);
            return return_v;
        }


        int
        f_22004_43872_43895(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43872, 43895);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        f_22004_43930_43944(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 43930, 43944);
            return return_v;
        }


        int
        f_22004_43910_43945(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        actual)
        {
            Assert.Same((object)expected, (object?)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43910, 43945);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_43988_44048(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        controlFlowGraph, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        anonymousFunction)
        {
            var return_v = controlFlowGraph.GetAnonymousFunctionControlFlowGraphInScope(anonymousFunction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 43988, 44048);
            return return_v;
        }


        int
        f_22004_44063_44106(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        actual)
        {
            Assert.Same((object)expected, (object)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44063, 44106);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        f_22004_44166_44184(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        graph)
        {
            var return_v = getLambda(graph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44166, 44184);
            return return_v;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_44213_44267(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        anonymousFunction)
        {
            var return_v = this_param.GetAnonymousFunctionControlFlowGraph(anonymousFunction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44213, 44267);
            return return_v;
        }


        int
        f_22004_44282_44305(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44282, 44305);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        f_22004_44341_44355(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 44341, 44355);
            return return_v;
        }


        int
        f_22004_44320_44356(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        actual)
        {
            Assert.Same((object)expected, (object?)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44320, 44356);
            return 0;
        }


        System.ArgumentNullException
        f_22004_44373_44466(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentNullException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44373, 44466);
            return return_v;
        }


        System.ArgumentOutOfRangeException
        f_22004_44481_44584(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentOutOfRangeException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44481, 44584);
            return return_v;
        }


        System.ArgumentNullException
        f_22004_44599_44699(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentNullException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44599, 44699);
            return return_v;
        }


        System.ArgumentOutOfRangeException
        f_22004_44714_44824(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentOutOfRangeException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44714, 44824);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22004_45503_45528(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45503, 45528);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22004_45621_45655(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45621, 45655);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22004_45756_45770(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45756, 45770);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22004_45756_45788(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45756, 45788);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
        f_22004_45756_45822(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45756, 45822);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        f_22004_45756_45831(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45756, 45831);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22004_45729_45832(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45729, 45832);
            return return_v;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_45683_45833(Microsoft.CodeAnalysis.IOperation?
        methodBody)
        {
            var return_v = ControlFlowGraph.Create((Microsoft.CodeAnalysis.Operations.IMethodBodyOperation?)methodBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45683, 45833);
            return return_v;
        }


        int
        f_22004_45850_45872(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45850, 45872);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        f_22004_45899_45912(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 45899, 45912);
            return return_v;
        }


        int
        f_22004_45887_45913(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45887, 45913);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        f_22004_45973_46000(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        graph, int
        index)
        {
            var return_v = getLambda(graph, index: index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 45973, 46000);
            return return_v;
        }


        int
        f_22004_46015_46039(Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46015, 46039);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        f_22004_46097_46124(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        graph, int
        index)
        {
            var return_v = getLambda(graph, index: index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46097, 46124);
            return return_v;
        }


        int
        f_22004_46139_46163(Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46139, 46163);
            return 0;
        }


        System.ArgumentNullException
        f_22004_46180_46269(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentNullException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46180, 46269);
            return return_v;
        }


        System.ArgumentOutOfRangeException
        f_22004_46284_46390(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentOutOfRangeException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46284, 46390);
            return return_v;
        }


        System.ArgumentNullException
        f_22004_46405_46501(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentNullException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46405, 46501);
            return return_v;
        }


        System.ArgumentOutOfRangeException
        f_22004_46516_46629(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentOutOfRangeException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46516, 46629);
            return return_v;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_46660_46713(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        anonymousFunction)
        {
            var return_v = this_param.GetAnonymousFunctionControlFlowGraph(anonymousFunction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46660, 46713);
            return return_v;
        }


        int
        f_22004_46728_46751(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46728, 46751);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        f_22004_46786_46800(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 46786, 46800);
            return return_v;
        }


        int
        f_22004_46766_46801(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        actual)
        {
            Assert.Same((object)expected, (object?)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46766, 46801);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_46830_46883(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        anonymousFunction)
        {
            var return_v = this_param.GetAnonymousFunctionControlFlowGraph(anonymousFunction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46830, 46883);
            return return_v;
        }


        int
        f_22004_46898_46921(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46898, 46921);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        f_22004_46956_46970(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22004, 46956, 46970);
            return return_v;
        }


        int
        f_22004_46936_46971(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph?
        actual)
        {
            Assert.Same((object)expected, (object?)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 46936, 46971);
            return 0;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_47016_47076(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        controlFlowGraph, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        anonymousFunction)
        {
            var return_v = controlFlowGraph.GetAnonymousFunctionControlFlowGraphInScope(anonymousFunction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 47016, 47076);
            return return_v;
        }


        int
        f_22004_47091_47134(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        actual)
        {
            Assert.Same((object)expected, (object)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 47091, 47134);
            return 0;
        }


        System.ArgumentOutOfRangeException
        f_22004_47151_47255(System.Func<object>
        testCode)
        {
            var return_v = Assert.Throws<ArgumentOutOfRangeException>(testCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 47151, 47255);
            return return_v;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        f_22004_47294_47355(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        controlFlowGraph, Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        anonymousFunction)
        {
            var return_v = controlFlowGraph.GetAnonymousFunctionControlFlowGraphInScope(anonymousFunction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 47294, 47355);
            return return_v;
        }


        int
        f_22004_47370_47413(Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        expected, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
        actual)
        {
            Assert.Same((object)expected, (object)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 47370, 47413);
            return 0;
        }



        IFlowAnonymousFunctionOperation
        getLambda(ControlFlowGraph graph)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 44841, 45095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 44939, 45080);

                var temp = graph.Blocks;
                return f_22004_44946_45079(f_22004_44946_45070(f_22004_44946_45028(ref temp, b => b.Operations.SelectMany(o => o.DescendantsAndSelf()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 44841, 45095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 44841, 45095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 44841, 45095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }




        IFlowAnonymousFunctionOperation
        getLambda(ControlFlowGraph graph, int index)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22004, 47430, 47703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22004, 47539, 47688);

                // LAFHIS
                var temp = graph.Blocks;
                return f_22004_47546_47687(f_22004_47546_47670(f_22004_47546_47628(ref temp, b => b.Operations.SelectMany(o => o.DescendantsAndSelf()))), index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22004, 47430, 47703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22004, 47430, 47703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22004, 47430, 47703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }



        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
        f_22004_44946_45028(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock>
        source, System.Func<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>>
        selector)
        {
            var return_v = source.SelectMany<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock, Microsoft.CodeAnalysis.IOperation>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44946, 45028);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation>
        f_22004_44946_45070(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44946, 45070);
            return return_v;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        f_22004_44946_45079(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 44946, 45079);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
        f_22004_47546_47628(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock>
        source, System.Func<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>>
        selector)
        {
            var return_v = source.SelectMany<Microsoft.CodeAnalysis.FlowAnalysis.BasicBlock, Microsoft.CodeAnalysis.IOperation>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 47546, 47628);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation>
        f_22004_47546_47670(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 47546, 47670);
            return return_v;
        }


        Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation
        f_22004_47546_47687(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation>
        source, int
        index)
        {
            var return_v = source.ElementAt<Microsoft.CodeAnalysis.FlowAnalysis.IFlowAnonymousFunctionOperation>(index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22004, 47546, 47687);
            return return_v;
        }

    }
}
