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
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementSimpleIf()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 554, 2401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 748, 947);

                string
                source = @"
class P
{
    private void M()
    {
        bool condition = false;
        /*<bind>*/if (true)
        {
            condition = true;
        }/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 961, 1873);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (true) ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = true;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = true')
            Left: 
              ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 1887, 2226);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_2105_2210(f_22038_2105_2190(f_22038_2105_2163(ErrorCode.WRN_UnreferencedVarAssg, "condition"), "condition"), 6, 14)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 2242, 2365);

                var
                ok = f_22038_2251_2364(source, expectedOperationTree, expectedDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 2379, 2390);

                var
                x = ok
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 554, 2401);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 554, 2401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 554, 2401);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementSimpleIfWithElse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 2413, 5121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 2615, 2882);

                string
                source = @"
class P
{
    private void M()
    {
        bool condition = false;
        /*<bind>*/if (true)
        {
            condition = true;
        }
        else
        {
            condition = false;
        }/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 2896, 4430);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (true) ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = true;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = true')
            Left: 
              ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenFalse: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = false;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = false')
            Left: 
              ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 4444, 4982);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_4622_4697(f_22038_4622_4676(ErrorCode.WRN_UnreachableCode, "condition"), 13, 13),
f_22038_4861_4966(f_22038_4861_4946(f_22038_4861_4919(ErrorCode.WRN_UnreferencedVarAssg, "condition"), "condition"), 6, 14)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 4998, 5110);

                f_22038_4998_5109(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 2413, 5121);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 2413, 5121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 2413, 5121);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementSimpleIfWithConditionEvaluationTrue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 5133, 7232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 5354, 5557);

                string
                source = @"
class P
{
    private void M()
    {
        bool condition = false;
        /*<bind>*/if (1 == 1)
        {
            condition = true;
        }/*</bind>*/

    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 5571, 6738);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (1 == 1) ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, Constant: True) (Syntax: '1 == 1')
      Left: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = true;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = true')
            Left: 
              ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 6752, 7091);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_6970_7075(f_22038_6970_7055(f_22038_6970_7028(ErrorCode.WRN_UnreferencedVarAssg, "condition"), "condition"), 6, 14)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 7107, 7219);

                f_22038_7107_7218(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 5133, 7232);

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 5133, 7232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 5133, 7232);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementSimpleIfNested1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 7244, 11233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 7445, 7776);

                string
                source = @"
using System;
class P
{
    private void M()
    {
        int m = 12;
        int n = 18;
        /*<bind>*/if (m > 10)
        {
            if (n > 20)
                Console.WriteLine(m);
        }
        else
        {
            Console.WriteLine(n);
        }/*</bind>*/

    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 7790, 11027);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (m > 10) ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'm > 10')
      Left: 
        ILocalReferenceOperation: m (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'm')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (n > 20) ... iteLine(m);')
        Condition: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'n > 20')
            Left: 
              ILocalReferenceOperation: n (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'n')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')
        WhenTrue: 
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(m);')
            Expression: 
              IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(m)')
                Instance Receiver: 
                  null
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'm')
                      ILocalReferenceOperation: m (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'm')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        WhenFalse: 
          null
  WhenFalse: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(n);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(n)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'n')
                  ILocalReferenceOperation: n (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'n')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 11041, 11094);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 11110, 11222);

                f_22038_11110_11221(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 7244, 11233);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 7244, 11233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 7244, 11233);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementSimpleIfNested2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 11245, 15268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 11446, 11797);

                string
                source = @"
using System;
class P
{
    private void M()
    {
        int m = 9;
        int n = 7;
        /*<bind>*/if (m > 10)
            if (n > 20)
            {
                Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine(n);
            }/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 11811, 15062);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (m > 10) ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'm > 10')
      Left: 
        ILocalReferenceOperation: m (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'm')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
  WhenTrue: 
    IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (n > 20) ... }')
      Condition: 
        IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'n > 20')
          Left: 
            ILocalReferenceOperation: n (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'n')
          Right: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')
      WhenTrue: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(m);')
            Expression: 
              IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(m)')
                Instance Receiver: 
                  null
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'm')
                      ILocalReferenceOperation: m (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'm')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      WhenFalse: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(n);')
            Expression: 
              IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(n)')
                Instance Receiver: 
                  null
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'n')
                      ILocalReferenceOperation: n (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'n')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 15076, 15129);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 15145, 15257);

                f_22038_15145_15256(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 11245, 15268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 11245, 15268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 11245, 15268);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithMultipleCondition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 15280, 18245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 15487, 15772);

                string
                source = @"
using System;
class P
{
    private void M()
    {
        int m = 9;
        int n = 7;
        int p = 5;
        /*<bind>*/if (m >= n && m >= p)
        {
            Console.WriteLine(""Nothing is larger than m."");
        }/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 15786, 18039);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (m >= n  ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'm >= n && m >= p')
      Left: 
        IBinaryOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'm >= n')
          Left: 
            ILocalReferenceOperation: m (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'm')
          Right: 
            ILocalReferenceOperation: n (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'n')
      Right: 
        IBinaryOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'm >= p')
          Left: 
            ILocalReferenceOperation: m (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'm')
          Right: 
            ILocalReferenceOperation: p (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'p')
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ...  than m."");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... r than m."")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""Nothing is ... er than m.""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Nothing is larger than m."") (Syntax: '""Nothing is ... er than m.""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 18053, 18106);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 18122, 18234);

                f_22038_18122_18233(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 15280, 18245);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 15280, 18245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 15280, 18245);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithElseIfCondition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 18257, 23524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 18462, 18875);

                string
                source = @"
using System;
class P
{
    private void M()
    {
        int m = 9;
        int n = 7;
        /*<bind>*/if (n > 20)
        {
            Console.WriteLine(""Result1"");
        }
        else if (m > 10)
        {
            Console.WriteLine(""Result2"");
        }
        else
        {
            Console.WriteLine(""Result3"");
        }/*</bind>*/

    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 18889, 23318);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (n > 20) ... }')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'n > 20')
      Left: 
        ILocalReferenceOperation: n (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'n')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... ""Result1"");')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... (""Result1"")')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""Result1""')
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Result1"") (Syntax: '""Result1""')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (m > 10) ... }')
      Condition: 
        IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'm > 10')
          Left: 
            ILocalReferenceOperation: m (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'm')
          Right: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
      WhenTrue: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... ""Result2"");')
            Expression: 
              IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... (""Result2"")')
                Instance Receiver: 
                  null
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""Result2""')
                      ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Result2"") (Syntax: '""Result2""')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      WhenFalse: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... ""Result3"");')
            Expression: 
              IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... (""Result3"")')
                Instance Receiver: 
                  null
                Arguments(1):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '""Result3""')
                      ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Result3"") (Syntax: '""Result3""')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 23332, 23385);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 23401, 23513);

                f_22038_23401_23512(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 18257, 23524);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 18257, 23524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 18257, 23524);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithElseIfConditionOutVar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 23536, 30821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 23747, 24039);

                string
                source = @"
class P
{
    private void M()
    {
        var s = """";
        /*<bind>*/if (int.TryParse(s, out var i))
            System.Console.WriteLine($""i ={i}, s ={s}"");
        else
            System.Console.WriteLine($""i ={i}, s ={s}"");/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 24053, 30615);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (int.Try ... , s ={s}"");')
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
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... , s ={s}"");')
      Expression: 
        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... }, s ={s}"")')
          Instance Receiver: 
            null
          Arguments(1):
              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '$""i ={i}, s ={s}""')
                IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""i ={i}, s ={s}""')
                  Parts(4):
                      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'i =')
                        Text: 
                          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""i ="", IsImplicit) (Syntax: 'i =')
                      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{i}')
                        Expression: 
                          ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        Alignment: 
                          null
                        FormatString: 
                          null
                      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ', s =')
                        Text: 
                          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "", s ="", IsImplicit) (Syntax: ', s =')
                      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{s}')
                        Expression: 
                          ILocalReferenceOperation: s (OperationKind.LocalReference, Type: System.String) (Syntax: 's')
                        Alignment: 
                          null
                        FormatString: 
                          null
                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... , s ={s}"");')
      Expression: 
        IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... }, s ={s}"")')
          Instance Receiver: 
            null
          Arguments(1):
              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '$""i ={i}, s ={s}""')
                IInterpolatedStringOperation (OperationKind.InterpolatedString, Type: System.String) (Syntax: '$""i ={i}, s ={s}""')
                  Parts(4):
                      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: 'i =')
                        Text: 
                          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""i ="", IsImplicit) (Syntax: 'i =')
                      IInterpolationOperation (OperationKind.Interpolation, Type: null) (Syntax: '{i}')
                        Expression: 
                          ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        Alignment: 
                          null
                        FormatString: 
                          null
                      IInterpolatedStringTextOperation (OperationKind.InterpolatedStringText, Type: null) (Syntax: ', s =')
                        Text: 
                          ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: "", s ="", IsImplicit) (Syntax: ', s =')
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 30629, 30682);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 30698, 30810);

                f_22038_30698_30809(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 23536, 30821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 23536, 30821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 23536, 30821);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithOutVar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 30833, 33106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 31029, 31392);

                string
                source = @"
class P
{
    private void M()
    {

        /*<bind>*/if (true)
            System.Console.WriteLine(A());/*</bind>*/
    }
    private int A()
    {
        var s = """";
        if (int.TryParse(s, out var i))
        {
            return i;
        }
        else
        {
            return -1;
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 31406, 32900);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (true) ... eLine(A());')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'System.Cons ... eLine(A());')
      Expression: 
        IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'System.Cons ... teLine(A())')
          Instance Receiver: 
            null
          Arguments(1):
              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'A()')
                IInvocationOperation ( System.Int32 P.A()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'A()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'A')
                  Arguments(0)
                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 32914, 32967);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 32983, 33095);

                f_22038_32983_33094(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 30833, 33106);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 30833, 33106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 30833, 33106);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementExplicitEmbeddedOutVar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 33118, 37016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 33326, 33670);

                string
                source = @"
class P
{
    private void M()
    {
        var s = ""data"";
        /*<bind>*/if (true)
        {
            A(int.TryParse(s, out var i));
        }/*</bind>*/
    }
    private void A(bool flag)
    {
        if (flag)
        {
            System.Console.WriteLine(""Result1"");
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 33684, 36810);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (true) ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 i
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'A(int.TryPa ... ut var i));')
        Expression: 
          IInvocationOperation ( void P.A(System.Boolean flag)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'A(int.TryPa ... out var i))')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'A')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: flag) (OperationKind.Argument, Type: null) (Syntax: 'int.TryPars ...  out var i)')
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
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 36824, 36877);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 36893, 37005);

                f_22038_36893_37004(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 33118, 37016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 33118, 37016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 33118, 37016);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementImplicitEmbeddedOutVar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 37028, 40216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 37236, 37596);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        object o = 25;
        /*<bind>*/if (true)
            A(o is int i, 1);/*</bind>*/
    }

    private static void A(bool flag, int number)
    {
        if (flag)
        {
            System.Console.WriteLine(new string('*', number));
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 37610, 40010);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (true) ...  int i, 1);')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null, IsImplicit) (Syntax: 'A(o is int i, 1);')
      Locals: Local_1: System.Int32 i
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'A(o is int i, 1);')
        Expression: 
          IInvocationOperation (void Program.A(System.Boolean flag, System.Int32 number)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'A(o is int i, 1)')
            Instance Receiver: 
              null
            Arguments(2):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: flag) (OperationKind.Argument, Type: null) (Syntax: 'o is int i')
                  IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'o is int i')
                    Value: 
                      ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
                    Pattern: 
                      IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int i') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 i, MatchesNull: False)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: number) (OperationKind.Argument, Type: null) (Syntax: '1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 40024, 40077);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 40093, 40205);

                f_22038_40093_40204(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 37028, 40216);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 37028, 40216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 37028, 40216);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithConditionPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 40228, 42603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 40434, 40673);

                string
                source = @"
using System;

class P
{
    private void M()
    {
        object obj = ""pattern"";

        /*<bind>*/if (obj is string str)
        {
            Console.WriteLine(str);
        }/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 40687, 42397);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (obj is  ... }')
  Condition: 
    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'obj is string str')
      Value: 
        ILocalReferenceOperation: obj (OperationKind.LocalReference, Type: System.Object) (Syntax: 'obj')
      Pattern: 
        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'string str') (InputType: System.Object, NarrowedType: System.String, DeclaredSymbol: System.String str, MatchesNull: False)
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(str);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(str)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'str')
                  ILocalReferenceOperation: str (OperationKind.LocalReference, Type: System.String) (Syntax: 'str')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 42411, 42464);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 42480, 42592);

                f_22038_42480_42591(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 40228, 42603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 40228, 42603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 40228, 42603);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 42615, 44878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 42812, 43142);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/if (true)
            A(25);/*</bind>*/
    }

    private static void A(object o)
    {
        if (o is null) return;
        if (!(o is int i)) return;
        System.Console.WriteLine(new string('*', i));
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 43156, 44672);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (true) ... A(25);')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'A(25);')
      Expression: 
        IInvocationOperation (void Program.A(System.Object o)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'A(25)')
          Instance Receiver: 
            null
          Arguments(1):
              IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: o) (OperationKind.Argument, Type: null) (Syntax: '25')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '25')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 25) (Syntax: '25')
                InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 44686, 44739);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 44755, 44867);

                f_22038_44755_44866(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 42615, 44878);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 42615, 44878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 42615, 44878);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithEmbeddedPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 44890, 48065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 45095, 45477);

                string
                source = @"
class Program
{
    static void Main(string[] args)
    {
        object o = 25;
        /*<bind>*/if (true)
        {
            A(o is int i, 1);
        }/*</bind>*/
    }

    private static void A(bool flag, int number)
    {
        if (flag)
        {
            System.Console.WriteLine(new string('*', number));
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 45491, 47859);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (true) ... }')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 i
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'A(o is int i, 1);')
        Expression: 
          IInvocationOperation (void Program.A(System.Boolean flag, System.Int32 number)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'A(o is int i, 1)')
            Instance Receiver: 
              null
            Arguments(2):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: flag) (OperationKind.Argument, Type: null) (Syntax: 'o is int i')
                  IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'o is int i')
                    Value: 
                      ILocalReferenceOperation: o (OperationKind.LocalReference, Type: System.Object) (Syntax: 'o')
                    Pattern: 
                      IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int i') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 i, MatchesNull: False)
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: number) (OperationKind.Argument, Type: null) (Syntax: '1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 47873, 47926);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 47942, 48054);

                f_22038_47942_48053(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 44890, 48065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 44890, 48065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 44890, 48065);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(27866, "https://github.com/dotnet/roslyn/issues/27866")]
        public void IIfstatementWithIfMissing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 48077, 52839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 48276, 48475);

                string
                source = @"
using System;

class P
{
    private void M()
    {
        /*<bind>*/else
        {
            Console.WriteLine(new string('a', 5));
        }
/*</bind>*/    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 48489, 51449);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: '/*<bind>*/e ... }')
  Condition: 
    IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
      Children(0)
  WhenTrue: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
      Expression: 
        IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
          Children(0)
  WhenFalse: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... g('a', 5));')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ng('a', 5))')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'new string('a', 5)')
                  IObjectCreationOperation (Constructor: System.String..ctor(System.Char c, System.Int32 count)) (OperationKind.ObjectCreation, Type: System.String) (Syntax: 'new string('a', 5)')
                    Arguments(2):
                        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: c) (OperationKind.Argument, Type: null) (Syntax: ''a'')
                          ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: a) (Syntax: ''a'')
                          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: count) (OperationKind.Argument, Type: null) (Syntax: '5')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
                          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Initializer: 
                      null
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 51463, 52700);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_51643_51716(f_22038_51643_51697(ErrorCode.ERR_ElseCannotStartStatement, ""), 7, 6),
f_22038_51836_51923(f_22038_51836_51904(f_22038_51836_51877(ErrorCode.ERR_SyntaxError, ""), "(", "else"), 7, 6),
f_22038_52047_52133(f_22038_52047_52114(f_22038_52047_52092(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 7, 6),
f_22038_52237_52304(f_22038_52237_52285(ErrorCode.ERR_CloseParenExpected, ""), 7, 6),
f_22038_52428_52514(f_22038_52428_52495(f_22038_52428_52473(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 7, 6),
f_22038_52618_52684(f_22038_52618_52665(ErrorCode.ERR_SemicolonExpected, ""), 7, 6)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 52716, 52828);

                f_22038_52716_52827(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 48077, 52839);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 48077, 52839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 48077, 52839);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(27866, "https://github.com/dotnet/roslyn/issues/27866")]
        public void IIfstatementWithDoubleElse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 52851, 58751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 53051, 53490);

                string
                source = @"
using System;

class P
{
    private void Op()
    {
    }

    private void M(bool flag)
    {
        /*<bind>*/{
            if (flag)
            {
                Op();
            }
            else
            {
                Console.WriteLine(flag);
            }
            else 
            {
                Console.WriteLine(!flag);
            }
        }/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 53504, 57295);

                string
                expectedOperationTree = @"
IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'if (flag) ... }')
    Condition: 
      IParameterReferenceOperation: flag (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'flag')
    WhenTrue: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Op();')
          Expression: 
            IInvocationOperation ( void P.Op()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Op()')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'Op')
              Arguments(0)
    WhenFalse: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(flag);')
          Expression: 
            IInvocationOperation (void System.Console.WriteLine(System.Boolean value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(flag)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'flag')
                    IParameterReferenceOperation: flag (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'flag')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'else ... }')
    Condition: 
      IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
        Children(0)
    WhenTrue: 
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
            Children(0)
    WhenFalse: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... ine(!flag);')
          Expression: 
            IInvocationOperation (void System.Console.WriteLine(System.Boolean value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(!flag)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '!flag')
                    IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: System.Boolean) (Syntax: '!flag')
                      Operand: 
                        IParameterReferenceOperation: flag (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'flag')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 57309, 58618);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_57499_57574(f_22038_57499_57553(ErrorCode.ERR_ElseCannotStartStatement, ""), 20, 14),
f_22038_57704_57793(f_22038_57704_57772(f_22038_57704_57745(ErrorCode.ERR_SyntaxError, ""), "(", "else"), 20, 14),
f_22038_57927_58015(f_22038_57927_57994(f_22038_57927_57972(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 20, 14),
f_22038_58129_58198(f_22038_58129_58177(ErrorCode.ERR_CloseParenExpected, ""), 20, 14),
f_22038_58332_58420(f_22038_58332_58399(f_22038_58332_58377(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 20, 14),
f_22038_58534_58602(f_22038_58534_58581(ErrorCode.ERR_SemicolonExpected, ""), 20, 14)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 58634, 58740);

                f_22038_58634_58739(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 52851, 58751);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 52851, 58751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 52851, 58751);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(27866, "https://github.com/dotnet/roslyn/issues/27866")]
        public void IIfstatementWithElseKeywordPlacedAsIfEmbeddedStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 58763, 62132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 58991, 59224);

                string
                source = @"
using System;

class P
{
    private void Op()
    {
    }

    private void M(bool flag)
    {
        /*<bind>*/if (flag)
        else
        {
            Op();
        }
/*</bind>*/    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 59238, 60586);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'if (flag) ... }')
  Condition: 
    IParameterReferenceOperation: flag (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'flag')
  WhenTrue: 
    IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'else ... }')
      Condition: 
        IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
          Children(0)
      WhenTrue: 
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
          Expression: 
            IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
              Children(0)
      WhenFalse: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Op();')
            Expression: 
              IInvocationOperation ( void P.Op()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Op()')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'Op')
                Arguments(0)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 60600, 61993);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_60804_60879(f_22038_60804_60858(ErrorCode.ERR_ElseCannotStartStatement, ""), 12, 28),
f_22038_61023_61112(f_22038_61023_61091(f_22038_61023_61064(ErrorCode.ERR_SyntaxError, ""), "(", "else"), 12, 28),
f_22038_61260_61348(f_22038_61260_61327(f_22038_61260_61305(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 12, 28),
f_22038_61476_61545(f_22038_61476_61524(ErrorCode.ERR_CloseParenExpected, ""), 12, 28),
f_22038_61693_61781(f_22038_61693_61760(f_22038_61693_61738(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 12, 28),
f_22038_61909_61977(f_22038_61909_61956(ErrorCode.ERR_SemicolonExpected, ""), 12, 28)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 62009, 62121);

                f_22038_62009_62120(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 58763, 62132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 58763, 62132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 58763, 62132);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(27866, "https://github.com/dotnet/roslyn/issues/27866")]
        public void IIfstatementWithIfKeywordMissingAndDoubleElseKeywordsPresent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 62144, 67125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 62378, 62669);

                string
                source = @"
using System;

class P
{
    private void Op()
    {
    }

    private void M()
    {
        /*<bind>*/{
            else
            {
            }
            else
            {
                Op();
            }
        }/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 62683, 64394);

                string
                expectedOperationTree = @"
IBlockOperation (2 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'else ... }')
    Condition: 
      IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
        Children(0)
    WhenTrue: 
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
            Children(0)
    WhenFalse: 
      IBlockOperation (0 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'else ... }')
    Condition: 
      IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
        Children(0)
    WhenTrue: 
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
            Children(0)
    WhenFalse: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Op();')
          Expression: 
            IInvocationOperation ( void P.Op()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Op()')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'Op')
              Arguments(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 64408, 66992);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_64604_64679(f_22038_64604_64658(ErrorCode.ERR_ElseCannotStartStatement, ""), 12, 20),
f_22038_64815_64904(f_22038_64815_64883(f_22038_64815_64856(ErrorCode.ERR_SyntaxError, ""), "(", "else"), 12, 20),
f_22038_65044_65132(f_22038_65044_65111(f_22038_65044_65089(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 12, 20),
f_22038_65252_65321(f_22038_65252_65300(ErrorCode.ERR_CloseParenExpected, ""), 12, 20),
f_22038_65461_65549(f_22038_65461_65528(f_22038_65461_65506(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 12, 20),
f_22038_65669_65737(f_22038_65669_65716(ErrorCode.ERR_SemicolonExpected, ""), 12, 20),
f_22038_65873_65948(f_22038_65873_65927(ErrorCode.ERR_ElseCannotStartStatement, ""), 15, 14),
f_22038_66078_66167(f_22038_66078_66146(f_22038_66078_66119(ErrorCode.ERR_SyntaxError, ""), "(", "else"), 15, 14),
f_22038_66301_66389(f_22038_66301_66368(f_22038_66301_66346(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 15, 14),
f_22038_66503_66572(f_22038_66503_66551(ErrorCode.ERR_CloseParenExpected, ""), 15, 14),
f_22038_66706_66794(f_22038_66706_66773(f_22038_66706_66751(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 15, 14),
f_22038_66908_66976(f_22038_66908_66955(ErrorCode.ERR_SemicolonExpected, ""), 15, 14)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 67008, 67114);

                f_22038_67008_67113(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 62144, 67125);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 62144, 67125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 62144, 67125);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithElseMissing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 67137, 70109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 67338, 67591);

                string
                source = @"
using System;

class P
{
    private void M()
    {
        object obj = ""pattern"";

        /*<bind>*/if (obj is string str)
        {
            Console.WriteLine(str);
        }
        else
/*</bind>*/    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 67605, 69534);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'if (obj is  ... else')
  Condition: 
    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'obj is string str')
      Value: 
        ILocalReferenceOperation: obj (OperationKind.LocalReference, Type: System.Object) (Syntax: 'obj')
      Pattern: 
        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'string str') (InputType: System.Object, NarrowedType: System.String, DeclaredSymbol: System.String str, MatchesNull: False)
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(str);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(str)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'str')
                  ILocalReferenceOperation: str (OperationKind.LocalReference, Type: System.String) (Syntax: 'str')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenFalse: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
      Expression: 
        IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
          Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 69548, 69970);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_69710_69795(f_22038_69710_69774(f_22038_69710_69755(ErrorCode.ERR_InvalidExprTerm, ""), "}"), 14, 13),
f_22038_69886_69954(f_22038_69886_69933(ErrorCode.ERR_SemicolonExpected, ""), 14, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 69986, 70098);

                f_22038_69986_70097(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 67137, 70109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 67137, 70109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 67137, 70109);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithConditionMissing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 70121, 72681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 70327, 70571);

                string
                source = @"
using System;

class P
{
    private void M()
    {
        int a = 1;
        /*<bind>*/if ()
        {
            a = 2;
        }
        else
        {
            a = 3;
        }/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 70585, 72022);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'if () ... }')
  Condition: 
    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
      Children(0)
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 2;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 2')
            Left: 
              ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
  WhenFalse: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 3;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 3')
            Left: 
              ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 72036, 72542);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_72209_72294(f_22038_72209_72274(f_22038_72209_72255(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 9, 23),
f_22038_72437_72526(f_22038_72437_72506(f_22038_72437_72487(ErrorCode.WRN_UnreferencedVarAssg, "a"), "a"), 8, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 72558, 72670);

                f_22038_72558_72669(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 70121, 72681);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 70121, 72681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 70121, 72681);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithStatementMissing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 72693, 76306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 72899, 73077);

                string
                source = @"
using System;

class P
{
    private void M()
    {
        int a = 1;
        
        /*<bind>*/if (a == 1)
        else
/*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 73091, 74352);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'if (a == 1) ... else')
  Condition: 
    IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'a == 1')
      Left: 
        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
      Right: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  WhenTrue: 
    IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: '        else')
      Condition: 
        IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
          Children(0)
      WhenTrue: 
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
          Expression: 
            IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
              Children(0)
      WhenFalse: 
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
          Expression: 
            IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
              Children(0)
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 74366, 76167);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_74572_74647(f_22038_74572_74626(ErrorCode.ERR_ElseCannotStartStatement, ""), 10, 30),
f_22038_74793_74882(f_22038_74793_74861(f_22038_74793_74834(ErrorCode.ERR_SyntaxError, ""), "(", "else"), 10, 30),
f_22038_75032_75120(f_22038_75032_75099(f_22038_75032_75077(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 10, 30),
f_22038_75250_75319(f_22038_75250_75298(ErrorCode.ERR_CloseParenExpected, ""), 10, 30),
f_22038_75469_75557(f_22038_75469_75536(f_22038_75469_75514(ErrorCode.ERR_InvalidExprTerm, ""), "else"), 10, 30),
f_22038_75687_75755(f_22038_75687_75734(ErrorCode.ERR_SemicolonExpected, ""), 10, 30),
f_22038_75885_75970(f_22038_75885_75949(f_22038_75885_75930(ErrorCode.ERR_InvalidExprTerm, ""), "}"), 11, 13),
f_22038_76083_76151(f_22038_76083_76130(ErrorCode.ERR_SemicolonExpected, ""), 11, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 76183, 76295);

                f_22038_76183_76294(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 72693, 76306);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 72693, 76306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 72693, 76306);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithFuncCall()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 76318, 78402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 76516, 76838);

                string
                source = @"
using System;

class P
{
    private void M()
    {
        /*<bind>*/if (true)
            A();
        else
            B();/*</bind>*/
    }
    private void A()
    {
        Console.WriteLine(""A"");
    }
    private void B()
    {
        Console.WriteLine(""B"");
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 76852, 77991);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (true) ... B();')
  Condition: 
    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
  WhenTrue: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'A();')
      Expression: 
        IInvocationOperation ( void P.A()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'A()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'A')
          Arguments(0)
  WhenFalse: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'B();')
      Expression: 
        IInvocationOperation ( void P.B()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'B()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'B')
          Arguments(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 78005, 78263);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_78180_78247(f_22038_78180_78226(ErrorCode.WRN_UnreachableCode, "B"), 11, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 78279, 78391);

                f_22038_78279_78390(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 76318, 78402);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 76318, 78402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 76318, 78402);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17601, "https://github.com/dotnet/roslyn/issues/17601")]
        public void IIfstatementWithDynamic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 78414, 82453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 78611, 78886);

                string
                source = @"
using System;

class C
{
    public static int F<T>(dynamic d, Type t, T x) where T : struct
    {
        /*<bind>*/if (d.GetType() == t && ((T)d).Equals(x))
        {
            return 1;
        }/*</bind>*/

        return 2;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 78900, 82247);

                string
                expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (d.GetTy ... }')
  Condition: 
    IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'd.GetType() ... ).Equals(x)')
      Operand: 
        IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperationKind.Binary, Type: dynamic) (Syntax: 'd.GetType() ... ).Equals(x)')
          Left: 
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: dynamic) (Syntax: 'd.GetType() == t')
              Left: 
                IDynamicInvocationOperation (OperationKind.DynamicInvocation, Type: dynamic) (Syntax: 'd.GetType()')
                  Expression: 
                    IDynamicMemberReferenceOperation (Member Name: ""GetType"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.GetType')
                      Type Arguments(0)
                      Instance Receiver: 
                        IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
                  Arguments(0)
                  ArgumentNames(0)
                  ArgumentRefKinds(0)
              Right: 
                IParameterReferenceOperation: t (OperationKind.ParameterReference, Type: System.Type) (Syntax: 't')
          Right: 
            IInvocationOperation (virtual System.Boolean System.ValueType.Equals(System.Object obj)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: '((T)d).Equals(x)')
              Instance Receiver: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: T) (Syntax: '(T)d')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: obj) (OperationKind.Argument, Type: null) (Syntax: 'x')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'x')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: T) (Syntax: 'x')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  WhenTrue: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return 1;')
        ReturnedValue: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  WhenFalse: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 82261, 82314);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 82330, 82442);

                f_22038_82330_82441(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 78414, 82453);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 78414, 82453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 78414, 82453);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 82465, 85026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 82608, 82795);

                string
                source = @"
class P
{
    void M()
/*<bind>*/{
        bool condition = false;
        if (true)
        {
            condition = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 82809, 84548);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Boolean condition]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsImplicit) (Syntax: 'condition = false')
              Left: 
                ILocalReferenceOperation: condition (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'condition = false')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Jump if False (Regular) to Block[B3]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = true')
                  Left: 
                    ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 84562, 84901);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_84780_84885(f_22038_84780_84865(f_22038_84780_84838(ErrorCode.WRN_UnreferencedVarAssg, "condition"), "condition"), 6, 14)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 84917, 85015);

                f_22038_84917_85014(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 82465, 85026);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 82465, 85026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 82465, 85026);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 85038, 87909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 85181, 85419);

                string
                source = @"
class P
{
    void M()
/*<bind>*/{
        bool condition = false;
        if (true)
        {
            ;
        }
        else
        {
            condition = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 85433, 87186);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Boolean condition]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsImplicit) (Syntax: 'condition = false')
              Left: 
                ILocalReferenceOperation: condition (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Boolean, IsImplicit) (Syntax: 'condition = false')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Jump if False (Regular) to Block[B2]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B3]
            Leaving: {R1}
    Block[B2] - Block [UnReachable]
        Predecessors: [B1]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'condition = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'condition = true')
                  Left: 
                    ILocalReferenceOperation: condition (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'condition')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 87200, 87784);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22038_87401_87476(f_22038_87401_87455(ErrorCode.WRN_UnreachableCode, "condition"), 13, 13),
f_22038_87663_87768(f_22038_87663_87748(f_22038_87663_87721(ErrorCode.WRN_UnreferencedVarAssg, "condition"), "condition"), 6, 14)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 87800, 87898);

                f_22038_87800_87897(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 85038, 87909);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 85038, 87909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 85038, 87909);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 87921, 90414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 88064, 88286);

                string
                source = @"
class P
{
    void M(bool a, bool b)
/*<bind>*/{
        if (a && b)
        {
            a = false;
        }
        else
        {
            b = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 88300, 90222);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B3]
Block[B3] - Block
    Predecessors: [B2]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = false')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B5]
Block[B4] - Block
    Predecessors: [B1] [B2]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
              Left: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B5]
Block[B5] - Exit
    Predecessors: [B3] [B4]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 90236, 90289);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 90305, 90403);

                f_22038_90305_90402(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 87921, 90414);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 87921, 90414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 87921, 90414);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 90426, 93249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 90569, 90825);

                string
                source = @"
class P
{
    void M(bool a, bool b, bool c, bool result)
/*<bind>*/{
        if (a ? b : c)
        {
            result = false;
        }
        else
        {
            result = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 90841, 93057);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
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
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B6]
Block[B5] - Block
    Predecessors: [B2] [B3]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B6]
Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 93071, 93124);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 93140, 93238);

                f_22038_93140_93237(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 90426, 93249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 90426, 93249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 90426, 93249);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 93261, 96913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 93404, 93650);

                string
                source = @"
class P
{
    void M(bool? a, bool b, bool result)
/*<bind>*/{
        if (a ?? b)
        {
            result = false;
        }
        else
        {
            result = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 93664, 96721);

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
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'a')

        Jump if True (Regular) to Block[B3]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
              Operand: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B5]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B4] - Block
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
Block[B5] - Block
    Predecessors: [B2] [B3]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B6]
Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 96735, 96788);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 96804, 96902);

                f_22038_96804_96901(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 93261, 96913);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 93261, 96913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 93261, 96913);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_06()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 96925, 99749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 97068, 97327);

                string
                source = @"
class P
{
    void M(bool a, bool b, bool c, bool result)
/*<bind>*/{
        if (!(a ? b : c))
        {
            result = false;
        }
        else
        {
            result = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 97343, 99557);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if True (Regular) to Block[B5]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if True (Regular) to Block[B5]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B4]
Block[B4] - Block
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
Block[B5] - Block
    Predecessors: [B2] [B3]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B6]
Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 99571, 99624);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 99640, 99738);

                f_22038_99640_99737(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 96925, 99749);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 96925, 99749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 96925, 99749);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_07()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 99761, 102412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 99904, 100123);

                string
                source = @"
class P
{
    void M(bool a, bool b, bool c, bool d , bool e, bool result)
/*<bind>*/{
        if ((a ? b : c) ? d : e)
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 100139, 102220);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
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
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

    Next (Regular) Block[B6]
Block[B5] - Block
    Predecessors: [B2] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'e')

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
Block[B7] - Exit
    Predecessors: [B4] [B5] [B6]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 102234, 102287);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 102303, 102401);

                f_22038_102303_102400(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 99761, 102412);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 99761, 102412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 99761, 102412);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_08()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 102424, 105075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 102567, 102786);

                string
                source = @"
class P
{
    void M(bool a, bool b, bool c, bool d , bool e, bool result)
/*<bind>*/{
        if (a ? (b ? c : d) : e)
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 102802, 104883);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B5]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B3]
Block[B3] - Block
    Predecessors: [B2]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B6]
Block[B4] - Block
    Predecessors: [B2]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

    Next (Regular) Block[B6]
Block[B5] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'e')

    Next (Regular) Block[B6]
Block[B6] - Block
    Predecessors: [B3] [B4] [B5]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B7]
Block[B7] - Exit
    Predecessors: [B3] [B4] [B5] [B6]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 104897, 104950);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 104966, 105064);

                f_22038_104966_105063(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 102424, 105075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 102424, 105075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 102424, 105075);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_09()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 105087, 107738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 105230, 105449);

                string
                source = @"
class P
{
    void M(bool a, bool b, bool c, bool d , bool e, bool result)
/*<bind>*/{
        if (a ? b : (c ? d : e))
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 105465, 107546);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B6]
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B5]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B3]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

    Next (Regular) Block[B6]
Block[B5] - Block
    Predecessors: [B3]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'e')

    Next (Regular) Block[B6]
Block[B6] - Block
    Predecessors: [B2] [B4] [B5]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B7]
Block[B7] - Exit
    Predecessors: [B2] [B4] [B5] [B6]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 107560, 107613);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 107629, 107727);

                f_22038_107629_107726(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 105087, 107738);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 105087, 107738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 105087, 107738);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_10()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 107750, 117475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 107893, 108211);

                string
                source = @"
class P
{
    void M(object a, object b, object c, object d , object e, object f, bool result)
/*<bind>*/{
        if (GetBool(a ?? b) ? GetBool(c ?? d) : GetBool(e ?? f))
        {
            result = false;
        }
    }/*</bind>*/

    static bool GetBool(object x) => false;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 108227, 117283);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'a')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B9]
            IInvocationOperation (System.Boolean P.GetBool(System.Object x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'GetBool(a ?? b)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'a ?? b')
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a ?? b')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R1}
            Entering: {R5} {R6}

        Next (Regular) Block[B5]
            Leaving: {R1}
            Entering: {R3} {R4}
}
.locals {R3}
{
    CaptureIds: [3]
    .locals {R4}
    {
        CaptureIds: [2]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                  Value: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'c')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c')
                Leaving: {R4}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c')

            Next (Regular) Block[B8]
                Leaving: {R4}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd')
              Value: 
                IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'd')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (0)
        Jump if False (Regular) to Block[B14]
            IInvocationOperation (System.Boolean P.GetBool(System.Object x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'GetBool(c ?? d)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'c ?? d')
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c ?? d')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R3}

        Next (Regular) Block[B13]
            Leaving: {R3}
}
.locals {R5}
{
    CaptureIds: [5]
    .locals {R6}
    {
        CaptureIds: [4]
        Block[B9] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
                  Value: 
                    IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'e')

            Jump if True (Regular) to Block[B11]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'e')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'e')
                Leaving: {R6}

            Next (Regular) Block[B10]
        Block[B10] - Block
            Predecessors: [B9]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
                  Value: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'e')

            Next (Regular) Block[B12]
                Leaving: {R6}
    }

    Block[B11] - Block
        Predecessors: [B9]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'f')
              Value: 
                IParameterReferenceOperation: f (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'f')

        Next (Regular) Block[B12]
    Block[B12] - Block
        Predecessors: [B10] [B11]
        Statements (0)
        Jump if False (Regular) to Block[B14]
            IInvocationOperation (System.Boolean P.GetBool(System.Object x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'GetBool(e ?? f)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'e ?? f')
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'e ?? f')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R5}

        Next (Regular) Block[B13]
            Leaving: {R5}
}

Block[B13] - Block
    Predecessors: [B8] [B12]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B14]
Block[B14] - Exit
    Predecessors: [B8] [B12] [B13]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 117297, 117350);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 117366, 117464);

                f_22038_117366_117463(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 107750, 117475);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 107750, 117475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 107750, 117475);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_11()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 117487, 120909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 117630, 117816);

                string
                source = @"
class P
{
    void M(bool a, P b, P c, bool result)
/*<bind>*/{
        if (a ? b : c)
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 117832, 120466);

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
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: P, IsInvalid) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: P, IsInvalid) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B6]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a ? b : c')
              Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                (NoConversion)
              Operand: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'a ? b : c')
            Leaving: {R1}

        Next (Regular) Block[B5]
            Leaving: {R1}
}

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
Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 120480, 120784);

                var
                expectedDiagnostics = new[] {
f_22038_120668_120768(f_22038_120668_120748(f_22038_120668_120721(ErrorCode.ERR_NoImplicitConv, "a ? b : c"), "P", "bool"), 6, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 120800, 120898);

                f_22038_120800_120897(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 117487, 120909);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 117487, 120909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 117487, 120909);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_12()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 120921, 124574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 121064, 121313);

                string
                source = @"
class P
{
    void M(bool? a, bool b, bool result)
/*<bind>*/{
        if (!(a ?? b))
        {
            result = false;
        }
        else
        {
            result = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 121327, 124382);

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
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'a')

        Jump if True (Regular) to Block[B3]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
              Operand: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B5]
            IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if True (Regular) to Block[B5]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B4] - Block
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
Block[B5] - Block
    Predecessors: [B2] [B3]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B6]
Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 124396, 124449);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 124465, 124563);

                f_22038_124465_124562(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 120921, 124574);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 120921, 124574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 120921, 124574);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_13()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 124586, 128896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 124729, 124927);

                string
                source = @"
class P
{
    void M(bool? a, bool? b, bool c, bool result)
/*<bind>*/{
        if (a ?? (b ?? c))
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 124941, 128704);

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
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'a')

        Jump if True (Regular) to Block[B3]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
              Operand: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
            Leaving: {R1}
            Entering: {R2}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B7]
            IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B6]
            Leaving: {R1}
}
.locals {R2}
{
    CaptureIds: [1]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'b')

        Jump if True (Regular) to Block[B5]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'b')
              Operand: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'b')
            Leaving: {R2}

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B3]
        Statements (0)
        Jump if False (Regular) to Block[B7]
            IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'b')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'b')
              Arguments(0)
            Leaving: {R2}

        Next (Regular) Block[B6]
            Leaving: {R2}
}

Block[B5] - Block
    Predecessors: [B3]
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B6]
Block[B6] - Block
    Predecessors: [B2] [B4] [B5]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B7]
Block[B7] - Exit
    Predecessors: [B2] [B4] [B5] [B6]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 128718, 128771);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 128787, 128885);

                f_22038_128787_128884(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 124586, 128896);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 124586, 128896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 124586, 128896);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_14()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 128908, 137396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 129051, 129395);

                string
                source = @"
class P
{
    void M(object a, object b, object c, object d, bool result)
/*<bind>*/{
        if (GetNullableBool(a ?? b) ?? GetBool(c ?? d))
        {
            result = false;
        }
    }/*</bind>*/

    static bool GetBool(object x) => false;

    static bool? GetNullableBool(object x) => false;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 129409, 137204);

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
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'a')

                Jump if True (Regular) to Block[B3]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                      Operand: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a')
                    Leaving: {R3}

                Next (Regular) Block[B2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a')

                Next (Regular) Block[B4]
                    Leaving: {R3}
        }

        Block[B3] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                  Value: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'b')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetNullableBool(a ?? b)')
                  Value: 
                    IInvocationOperation (System.Boolean? P.GetNullableBool(System.Object x)) (OperationKind.Invocation, Type: System.Boolean?) (Syntax: 'GetNullableBool(a ?? b)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'a ?? b')
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'a ?? b')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B4]
        Statements (0)
        Jump if True (Regular) to Block[B7]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'GetNullableBool(a ?? b)')
              Operand: 
                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'GetNullableBool(a ?? b)')
            Leaving: {R1}
            Entering: {R4} {R5}

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B5]
        Statements (0)
        Jump if False (Regular) to Block[B12]
            IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'GetNullableBool(a ?? b)')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'GetNullableBool(a ?? b)')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B11]
            Leaving: {R1}
}
.locals {R4}
{
    CaptureIds: [4]
    .locals {R5}
    {
        CaptureIds: [3]
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                  Value: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'c')

            Jump if True (Regular) to Block[B9]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c')
                Leaving: {R5}

            Next (Regular) Block[B8]
        Block[B8] - Block
            Predecessors: [B7]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                  Value: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c')

            Next (Regular) Block[B10]
                Leaving: {R5}
    }

    Block[B9] - Block
        Predecessors: [B7]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd')
              Value: 
                IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'd')

        Next (Regular) Block[B10]
    Block[B10] - Block
        Predecessors: [B8] [B9]
        Statements (0)
        Jump if False (Regular) to Block[B12]
            IInvocationOperation (System.Boolean P.GetBool(System.Object x)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'GetBool(c ?? d)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'c ?? d')
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'c ?? d')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R4}

        Next (Regular) Block[B11]
            Leaving: {R4}
}

Block[B11] - Block
    Predecessors: [B6] [B10]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B12]
Block[B12] - Exit
    Predecessors: [B6] [B10] [B11]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 137218, 137271);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 137287, 137385);

                f_22038_137287_137384(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 128908, 137396);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 128908, 137396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 128908, 137396);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_15()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 137408, 141422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 137551, 137726);

                string
                source = @"
class P
{
    void M(P a, P b, bool result)
/*<bind>*/{
        if (a ?? b)
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 137742, 140985);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: P, IsInvalid) (Syntax: 'a')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: P, IsInvalid) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Jump if False (Regular) to Block[B6]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a ?? b')
              Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                (NoConversion)
              Operand: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'a ?? b')
            Leaving: {R1}

        Next (Regular) Block[B5]
            Leaving: {R1}
}

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
Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 140999, 141297);

                var
                expectedDiagnostics = new[] {
f_22038_141184_141281(f_22038_141184_141261(f_22038_141184_141234(ErrorCode.ERR_NoImplicitConv, "a ?? b"), "P", "bool"), 6, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 141313, 141411);

                f_22038_141313_141410(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 137408, 141422);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 137408, 141422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 137408, 141422);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_16()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 141434, 145637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 141577, 141832);

                string
                source = @"
class P
{
    void M(bool? a, bool b, bool result)
/*<bind>*/{
        if (a ?? throw null)
        {
            result = false;
        }
        else
        {
            result = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 141846, 145445);

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
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'a')
            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
                Leaving: {R1}
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
                  Arguments(0)
                Leaving: {R1}
            Next (Regular) Block[B4]
                Leaving: {R1}
    }
    Block[B3] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
        Next (Regular) Block[B6]
    Block[B5] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B6]
    Block[B6] - Exit
        Predecessors: [B4] [B5]
        Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 145459, 145512);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 145528, 145626);

                f_22038_145528_145625(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 141434, 145637);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 141434, 145637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 141434, 145637);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_17()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 145649, 148955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 145792, 146049);

                string
                source = @"
class P
{
    void M(bool a, bool b, bool result)
/*<bind>*/{
        if (a ? throw null : b)
        {
            result = false;
        }
        else
        {
            result = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 146063, 148763);

                string
                expectedFlowGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B3] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
        Next (Regular) Block[B4]
    Block[B4] - Block
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
    Block[B5] - Block
        Predecessors: [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B6]
    Block[B6] - Exit
        Predecessors: [B4] [B5]
        Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 148777, 148830);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 148846, 148944);

                f_22038_148846_148943(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 145649, 148955);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 145649, 148955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 145649, 148955);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_18()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 148967, 152273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 149110, 149367);

                string
                source = @"
class P
{
    void M(bool a, bool b, bool result)
/*<bind>*/{
        if (a ? b : throw null)
        {
            result = false;
        }
        else
        {
            result = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 149381, 152081);

                string
                expectedFlowGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
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
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
        Next (Regular) Block[B6]
    Block[B5] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B6]
    Block[B6] - Exit
        Predecessors: [B4] [B5]
        Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 152095, 152148);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 152164, 152262);

                f_22038_152164_152261(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 148967, 152273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 148967, 152273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 148967, 152273);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_19()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 152285, 157326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 152428, 152703);

                string
                source = @"
class P
{
    void M(bool result, System.Exception a, System.Exception b)
/*<bind>*/{
        if (throw a ?? b)
        {
            result = false;
        }
        else
        {
            result = true;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 152717, 156907);

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
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'a')

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Exception, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Exception, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Exception) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Next (Throw) Block[null]
            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Exception, IsImplicit) (Syntax: 'a ?? b')
}

Block[B5] - Block [UnReachable]
    Predecessors (0)
    Statements (0)
    Jump if False (Regular) to Block[B7]
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'throw a ?? b')
          Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            (NoConversion)
          Operand: 
            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid, IsImplicit) (Syntax: 'throw a ?? b')
              Children(1):
                  IOperation:  (OperationKind.None, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw a ?? b')

    Next (Regular) Block[B6]
Block[B6] - Block [UnReachable]
    Predecessors: [B5]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B8]
Block[B7] - Block [UnReachable]
    Predecessors: [B5]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B8]
Block[B8] - Exit [UnReachable]
    Predecessors: [B6] [B7]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 156921, 157201);

                var
                expectedDiagnostics = new[] {
f_22038_157116_157185(f_22038_157116_157165(ErrorCode.ERR_ThrowMisplaced, "throw"), 6, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 157217, 157315);

                f_22038_157217_157314(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 152285, 157326);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 152285, 157326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 152285, 157326);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_20()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 157338, 161075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 157481, 157679);

                string
                source = @"
class P
{
    void M(bool? a, bool b, bool result)
/*<bind>*/{
        if ((a ?? throw null) && b)
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 157693, 160883);

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
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'a')
            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
                Leaving: {R1}
            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B6]
                IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
                  Arguments(0)
                Leaving: {R1}
            Next (Regular) Block[B4]
                Leaving: {R1}
    }
    Block[B3] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B4] - Block
        Predecessors: [B2]
        Statements (0)
        Jump if False (Regular) to Block[B6]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
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
    Block[B6] - Exit
        Predecessors: [B2] [B4] [B5]
        Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 160897, 160950);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 160966, 161064);

                f_22038_160966_161063(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 157338, 161075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 157338, 161075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 157338, 161075);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_21()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 161087, 163472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 161230, 161437);

                string
                source = @"
class P
{
    void M(bool a, bool b, bool c, bool d, bool result)
/*<bind>*/{
        if ((a ? b : c) && d)
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 161453, 163280);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B6]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B6]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B2] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B6]
        IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

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
Block[B6] - Exit
    Predecessors: [B2] [B3] [B4] [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 163294, 163347);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 163363, 163461);

                f_22038_163363_163460(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 161087, 163472);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 161087, 163472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 161087, 163472);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_22()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 163484, 166696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 163627, 163824);

                string
                source = @"
class P
{
    void M(bool? a, bool b, bool c, bool result)
/*<bind>*/{
        if ((a ?? b) || c)
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 163838, 166504);

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
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'a')

        Jump if True (Regular) to Block[B3]
            IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
              Operand: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B5]
            IInvocationOperation ( System.Boolean System.Boolean?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Boolean, IsImplicit) (Syntax: 'a')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'a')
              Arguments(0)
            Leaving: {R1}

        Next (Regular) Block[B4]
            Leaving: {R1}
}

Block[B3] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if True (Regular) to Block[B5]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B2] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B6]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B5]
Block[B5] - Block
    Predecessors: [B2] [B3] [B4]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = false')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B6]
Block[B6] - Exit
    Predecessors: [B4] [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 166518, 166571);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 166587, 166685);

                f_22038_166587_166684(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 163484, 166696);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 163484, 166696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 163484, 166696);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void IfFlow_24()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22038, 166708, 168431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 166851, 167022);

                string
                source = @"
class P
{
    void M(dynamic a, bool result)
/*<bind>*/{
        if (a)
        {
            result = false;
        }
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 167036, 168239);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
          Operand: 
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

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
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 168253, 168306);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22038, 168322, 168420);

                f_22038_168322_168419(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22038, 166708, 168431);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22038, 166708, 168431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22038, 166708, 168431);
            }
        }

        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_2105_2163(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 2105, 2163);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_2105_2190(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 2105, 2190);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_2105_2210(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 2105, 2210);
            return return_v;
        }


        bool
        f_22038_2251_2364(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            var return_v = VerifyOperationTreeAndDiagnosticsForTest_B<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 2251, 2364);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_4622_4676(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 4622, 4676);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_4622_4697(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 4622, 4697);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_4861_4919(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 4861, 4919);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_4861_4946(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 4861, 4946);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_4861_4966(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 4861, 4966);
            return return_v;
        }


        int
        f_22038_4998_5109(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 4998, 5109);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_6970_7028(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 6970, 7028);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_6970_7055(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 6970, 7055);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_6970_7075(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 6970, 7075);
            return return_v;
        }


        int
        f_22038_7107_7218(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 7107, 7218);
            return 0;
        }


        int
        f_22038_11110_11221(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 11110, 11221);
            return 0;
        }


        int
        f_22038_15145_15256(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 15145, 15256);
            return 0;
        }


        int
        f_22038_18122_18233(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 18122, 18233);
            return 0;
        }


        int
        f_22038_23401_23512(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 23401, 23512);
            return 0;
        }


        int
        f_22038_30698_30809(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 30698, 30809);
            return 0;
        }


        int
        f_22038_32983_33094(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 32983, 33094);
            return 0;
        }


        int
        f_22038_36893_37004(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 36893, 37004);
            return 0;
        }


        int
        f_22038_40093_40204(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 40093, 40204);
            return 0;
        }


        int
        f_22038_42480_42591(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 42480, 42591);
            return 0;
        }


        int
        f_22038_44755_44866(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 44755, 44866);
            return 0;
        }


        int
        f_22038_47942_48053(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 47942, 48053);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_51643_51697(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 51643, 51697);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_51643_51716(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 51643, 51716);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_51836_51877(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 51836, 51877);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_51836_51904(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 51836, 51904);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_51836_51923(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 51836, 51923);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52047_52092(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52047, 52092);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52047_52114(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52047, 52114);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52047_52133(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52047, 52133);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52237_52285(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52237, 52285);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52237_52304(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52237, 52304);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52428_52473(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52428, 52473);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52428_52495(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52428, 52495);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52428_52514(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52428, 52514);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52618_52665(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52618, 52665);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_52618_52684(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52618, 52684);
            return return_v;
        }


        int
        f_22038_52716_52827(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 52716, 52827);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_57499_57553(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 57499, 57553);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_57499_57574(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 57499, 57574);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_57704_57745(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 57704, 57745);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_57704_57772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 57704, 57772);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_57704_57793(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 57704, 57793);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_57927_57972(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 57927, 57972);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_57927_57994(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 57927, 57994);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_57927_58015(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 57927, 58015);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_58129_58177(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 58129, 58177);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_58129_58198(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 58129, 58198);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_58332_58377(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 58332, 58377);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_58332_58399(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 58332, 58399);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_58332_58420(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 58332, 58420);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_58534_58581(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 58534, 58581);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_58534_58602(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 58534, 58602);
            return return_v;
        }


        int
        f_22038_58634_58739(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 58634, 58739);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_60804_60858(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 60804, 60858);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_60804_60879(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 60804, 60879);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61023_61064(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61023, 61064);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61023_61091(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61023, 61091);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61023_61112(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61023, 61112);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61260_61305(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61260, 61305);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61260_61327(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61260, 61327);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61260_61348(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61260, 61348);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61476_61524(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61476, 61524);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61476_61545(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61476, 61545);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61693_61738(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61693, 61738);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61693_61760(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61693, 61760);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61693_61781(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61693, 61781);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61909_61956(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61909, 61956);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_61909_61977(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 61909, 61977);
            return return_v;
        }


        int
        f_22038_62009_62120(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 62009, 62120);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_64604_64658(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 64604, 64658);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_64604_64679(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 64604, 64679);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_64815_64856(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 64815, 64856);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_64815_64883(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 64815, 64883);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_64815_64904(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 64815, 64904);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65044_65089(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65044, 65089);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65044_65111(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65044, 65111);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65044_65132(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65044, 65132);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65252_65300(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65252, 65300);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65252_65321(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65252, 65321);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65461_65506(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65461, 65506);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65461_65528(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65461, 65528);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65461_65549(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65461, 65549);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65669_65716(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65669, 65716);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65669_65737(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65669, 65737);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65873_65927(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65873, 65927);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_65873_65948(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 65873, 65948);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66078_66119(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66078, 66119);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66078_66146(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66078, 66146);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66078_66167(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66078, 66167);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66301_66346(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66301, 66346);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66301_66368(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66301, 66368);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66301_66389(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66301, 66389);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66503_66551(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66503, 66551);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66503_66572(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66503, 66572);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66706_66751(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66706, 66751);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66706_66773(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66706, 66773);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66706_66794(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66706, 66794);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66908_66955(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66908, 66955);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_66908_66976(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 66908, 66976);
            return return_v;
        }


        int
        f_22038_67008_67113(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 67008, 67113);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_69710_69755(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 69710, 69755);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_69710_69774(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 69710, 69774);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_69710_69795(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 69710, 69795);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_69886_69933(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 69886, 69933);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_69886_69954(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 69886, 69954);
            return return_v;
        }


        int
        f_22038_69986_70097(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 69986, 70097);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_72209_72255(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 72209, 72255);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_72209_72274(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 72209, 72274);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_72209_72294(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 72209, 72294);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_72437_72487(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 72437, 72487);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_72437_72506(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 72437, 72506);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_72437_72526(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 72437, 72526);
            return return_v;
        }


        int
        f_22038_72558_72669(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 72558, 72669);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_74572_74626(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 74572, 74626);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_74572_74647(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 74572, 74647);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_74793_74834(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 74793, 74834);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_74793_74861(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 74793, 74861);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_74793_74882(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 74793, 74882);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75032_75077(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75032, 75077);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75032_75099(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75032, 75099);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75032_75120(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75032, 75120);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75250_75298(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75250, 75298);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75250_75319(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75250, 75319);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75469_75514(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75469, 75514);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75469_75536(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75469, 75536);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75469_75557(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75469, 75557);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75687_75734(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75687, 75734);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75687_75755(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75687, 75755);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75885_75930(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75885, 75930);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75885_75949(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75885, 75949);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_75885_75970(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 75885, 75970);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_76083_76130(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 76083, 76130);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_76083_76151(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 76083, 76151);
            return return_v;
        }


        int
        f_22038_76183_76294(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 76183, 76294);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_78180_78226(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 78180, 78226);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_78180_78247(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 78180, 78247);
            return return_v;
        }


        int
        f_22038_78279_78390(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 78279, 78390);
            return 0;
        }


        int
        f_22038_82330_82441(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 82330, 82441);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_84780_84838(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 84780, 84838);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_84780_84865(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 84780, 84865);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_84780_84885(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 84780, 84885);
            return return_v;
        }


        int
        f_22038_84917_85014(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 84917, 85014);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_87401_87455(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 87401, 87455);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_87401_87476(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 87401, 87476);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_87663_87721(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 87663, 87721);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_87663_87748(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 87663, 87748);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_87663_87768(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 87663, 87768);
            return return_v;
        }


        int
        f_22038_87800_87897(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 87800, 87897);
            return 0;
        }


        int
        f_22038_90305_90402(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 90305, 90402);
            return 0;
        }


        int
        f_22038_93140_93237(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 93140, 93237);
            return 0;
        }


        int
        f_22038_96804_96901(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 96804, 96901);
            return 0;
        }


        int
        f_22038_99640_99737(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 99640, 99737);
            return 0;
        }


        int
        f_22038_102303_102400(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 102303, 102400);
            return 0;
        }


        int
        f_22038_104966_105063(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 104966, 105063);
            return 0;
        }


        int
        f_22038_107629_107726(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 107629, 107726);
            return 0;
        }


        int
        f_22038_117366_117463(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 117366, 117463);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_120668_120721(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 120668, 120721);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_120668_120748(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 120668, 120748);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_120668_120768(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 120668, 120768);
            return return_v;
        }


        int
        f_22038_120800_120897(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 120800, 120897);
            return 0;
        }


        int
        f_22038_124465_124562(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 124465, 124562);
            return 0;
        }


        int
        f_22038_128787_128884(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 128787, 128884);
            return 0;
        }


        int
        f_22038_137287_137384(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 137287, 137384);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_141184_141234(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 141184, 141234);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_141184_141261(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 141184, 141261);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_141184_141281(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 141184, 141281);
            return return_v;
        }


        int
        f_22038_141313_141410(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 141313, 141410);
            return 0;
        }


        int
        f_22038_145528_145625(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 145528, 145625);
            return 0;
        }


        int
        f_22038_148846_148943(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 148846, 148943);
            return 0;
        }


        int
        f_22038_152164_152261(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 152164, 152261);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_157116_157165(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 157116, 157165);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22038_157116_157185(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 157116, 157185);
            return return_v;
        }


        int
        f_22038_157217_157314(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 157217, 157314);
            return 0;
        }


        int
        f_22038_160966_161063(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 160966, 161063);
            return 0;
        }


        int
        f_22038_163363_163460(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 163363, 163460);
            return 0;
        }


        int
        f_22038_166587_166684(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 166587, 166684);
            return 0;
        }


        int
        f_22038_168322_168419(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22038, 168322, 168419);
            return 0;
        }

    }
}
