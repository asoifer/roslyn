// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    [CompilerTrait(CompilerFeature.IOperation)]
    public partial class IOperationTests : SemanticModelTestBase
    {
        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.RefLocalsReturns)]
        [Fact]
        public void SuppressNullableWarningOperation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 665, 2561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 839, 988);

                var
                comp = f_22001_850_987(@"
class C
{
#nullable enable
    void M(string? x)
    /*<bind>*/{
        x!.ToString();
    }/*</bind>*/
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 1002, 1559);

                var
                expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x!.ToString();')
    Expression:
      IInvocationOperation (virtual System.String System.String.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'x!.ToString()')
        Instance Receiver:
          IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.String) (Syntax: 'x')
        Arguments(0)"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 1575, 1620);

                var
                diagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 1634, 1730);

                f_22001_1634_1729(comp, expectedOperationTree, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 1746, 2473);

                var
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x!.ToString();')
          Expression:
            IInvocationOperation (virtual System.String System.String.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'x!.ToString()')
              Instance Receiver:
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.String) (Syntax: 'x')
              Arguments(0)
    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 2489, 2550);

                f_22001_2489_2549(comp, expectedFlowGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 665, 2561);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 665, 2561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 665, 2561);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.RefLocalsReturns)]
        [Fact]
        public void SuppressNullableWarningOperation_ConstantValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 2573, 4299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 2761, 2914);

                var
                comp = f_22001_2772_2913(@"
class C
{
#nullable enable
    void M()
    /*<bind>*/{
        ((string)null)!.ToString();
    }/*</bind>*/
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 2928, 3828);

                var
                expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '((string)nu ... ToString();')
    Expression:
      IInvocationOperation (virtual System.String System.String.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '((string)nu ... .ToString()')
        Instance Receiver:
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null) (Syntax: '(string)null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand:
              ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Arguments(0)"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 3844, 4178);

                var
                diagnostics = new[]
                            {
f_22001_4069_4162(f_22001_4069_4142(ErrorCode.WRN_ConvertingNullableToNonNullable, "(string)null"), 7, 10)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 4192, 4288);

                f_22001_4192_4287(comp, expectedOperationTree, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 2573, 4299);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 2573, 4299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 2573, 4299);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.RefLocalsReturns)]
        [Fact]
        public void SuppressNullableWarningOperation_NestedFlow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 4311, 6706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 4496, 4674);

                var
                comp = f_22001_4507_4673(@"
class C
{
#nullable enable
    void M(bool b, string? x, string? y)
    /*<bind>*/{
        (b ? x : y)!.ToString();
    }/*</bind>*/
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 4688, 4713);

                f_22001_4688_4712(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 4729, 6618);

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
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value:
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.String?) (Syntax: 'x')
        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y')
              Value:
                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.String?) (Syntax: 'y')
        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '(b ? x : y)!.ToString();')
              Expression:
                IInvocationOperation (virtual System.String System.String.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: '(b ? x : y)!.ToString()')
                  Instance Receiver:
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'b ? x : y')
                  Arguments(0)
        Next (Regular) Block[B5]
            Leaving: {R1}
}
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 6634, 6695);

                f_22001_6634_6694(comp, expectedFlowGraph);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 4311, 6706);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 4311, 6706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 4311, 6706);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.RefLocalsReturns)]
        [Fact]
        public void RefReassignmentExpressions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 6718, 11310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 6886, 7174);

                var
                comp = f_22001_6897_7173(@"
class C
{
    ref readonly int M(ref int rx)
    {
        ref int ry = ref rx;
        rx = ref ry;
        ry = ref """".Length == 0
            ? ref (rx = ref ry)
            : ref (ry = ref rx);
        return ref (ry = ref rx);
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 7188, 7213);

                f_22001_7188_7212(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 7229, 7322);

                var
                m = f_22001_7237_7321(f_22001_7237_7312(f_22001_7237_7290(f_22001_7237_7272(comp.SyntaxTrees.Single()))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 7336, 11299);

                f_22001_7336_11298(comp, m, expectedOperationTree: @"
IBlockOperation (4 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Locals: Local_1: System.Int32 ry
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'ref int ry = ref rx;')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'ref int ry = ref rx')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Int32 ry) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'ry = ref rx')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ref rx')
                IParameterReferenceOperation: rx (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'rx')
      Initializer: 
        null
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'rx = ref ry;')
    Expression: 
      ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'rx = ref ry')
        Left: 
          IParameterReferenceOperation: rx (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'rx')
        Right: 
          ILocalReferenceOperation: ry (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'ry')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ry = ref """" ...  = ref rx);')
    Expression: 
      ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'ry = ref """" ... y = ref rx)')
        Left: 
          ILocalReferenceOperation: ry (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'ry')
        Right: 
          IConditionalOperation (IsRef) (OperationKind.Conditional, Type: System.Int32) (Syntax: '"""".Length = ... y = ref rx)')
            Condition: 
              IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: '"""".Length == 0')
                Left: 
                  IPropertyReferenceOperation: System.Int32 System.String.Length { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: '"""".Length')
                    Instance Receiver: 
                      ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: """") (Syntax: '""""')
                Right: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            WhenTrue: 
              ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'rx = ref ry')
                Left: 
                  IParameterReferenceOperation: rx (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'rx')
                Right: 
                  ILocalReferenceOperation: ry (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'ry')
            WhenFalse: 
              ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'ry = ref rx')
                Left: 
                  ILocalReferenceOperation: ry (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'ry')
                Right: 
                  IParameterReferenceOperation: rx (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'rx')
  IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return ref  ...  = ref rx);')
    ReturnedValue: 
      ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'ry = ref rx')
        Left: 
          ILocalReferenceOperation: ry (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'ry')
        Right: 
          IParameterReferenceOperation: rx (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'rx')");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 6718, 11310);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 6718, 11310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 6718, 11310);
            }
        }

        [CompilerTrait(CompilerFeature.RefLocalsReturns)]
        [Fact]
        public void IOperationRefFor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 11322, 16521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 11452, 11853);

                var
                tree = f_22001_11463_11852(@"
using System;
class C
{
    public class LinkedList
    {
        public int Value;
        public LinkedList Next;
    }
    public void M(LinkedList list)
    {
        for (ref readonly var cur = ref list; cur != null; cur = ref cur.Next)
        {
            Console.WriteLine(cur.Value);
        }
    }
}", options: TestOptions.Regular)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 11867, 11902);

                var
                comp = f_22001_11878_11901(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 11916, 11941);

                f_22001_11916_11940(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 11955, 12026);

                var
                m = f_22001_11963_12025(f_22001_11963_12017(f_22001_11963_11995(f_22001_11963_11977(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 12040, 16279);

                f_22001_12040_16278(comp, m, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'for (ref re ... }')
    Locals: Local_1: C.LinkedList cur
    Condition: 
      IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'cur != null')
        Left: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'cur')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILocalReferenceOperation: cur (OperationKind.LocalReference, Type: C.LinkedList) (Syntax: 'cur')
        Right: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Before:
        IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsImplicit) (Syntax: 'ref readonl ...  = ref list')
          IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'ref readonl ...  = ref list')
            Declarators:
                IVariableDeclaratorOperation (Symbol: C.LinkedList cur) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'cur = ref list')
                  Initializer: 
                    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= ref list')
                      IParameterReferenceOperation: list (OperationKind.ParameterReference, Type: C.LinkedList) (Syntax: 'list')
            Initializer: 
              null
    AtLoopBottom:
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'cur = ref cur.Next')
          Expression: 
            ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: C.LinkedList) (Syntax: 'cur = ref cur.Next')
              Left: 
                ILocalReferenceOperation: cur (OperationKind.LocalReference, Type: C.LinkedList) (Syntax: 'cur')
              Right: 
                IFieldReferenceOperation: C.LinkedList C.LinkedList.Next (OperationKind.FieldReference, Type: C.LinkedList) (Syntax: 'cur.Next')
                  Instance Receiver: 
                    ILocalReferenceOperation: cur (OperationKind.LocalReference, Type: C.LinkedList) (Syntax: 'cur')
    Body: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.Wri ... cur.Value);')
          Expression: 
            IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... (cur.Value)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'cur.Value')
                    IFieldReferenceOperation: System.Int32 C.LinkedList.Value (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'cur.Value')
                      Instance Receiver: 
                        ILocalReferenceOperation: cur (OperationKind.LocalReference, Type: C.LinkedList) (Syntax: 'cur')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 16293, 16434);

                var
                op = (IForLoopOperation)f_22001_16321_16433(f_22001_16321_16348(comp, tree), f_22001_16362_16432(f_22001_16362_16423(f_22001_16362_16394(f_22001_16362_16376(tree)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 16448, 16510);

                f_22001_16448_16509(RefKind.RefReadOnly, f_22001_16482_16508(op.Locals.Single()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 11322, 16521);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 11322, 16521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 11322, 16521);
            }
        }

        [CompilerTrait(CompilerFeature.RefLocalsReturns)]
        [Fact]
        public void IOperationRefForeach()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 16533, 19881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 16667, 17407);

                var
                tree = f_22001_16678_17406(@"
using System;
class C
{
    public void M(RefEnumerable re)
    {
        foreach (ref readonly var x in re)
        {
            Console.WriteLine(x);
        }
    }
}

class RefEnumerable
{
    private readonly int[] _arr = new int[5];
    public StructEnum GetEnumerator() => new StructEnum(_arr);

    public struct StructEnum
    {
        private readonly int[] _arr;
        private int _current;
        public StructEnum(int[] arr)
        {
            _arr = arr;
            _current = -1;
        }
        public ref int Current => ref _arr[_current];
        public bool MoveNext() => ++_current != _arr.Length;
    }
}", options: TestOptions.Regular)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 17421, 17456);

                var
                comp = f_22001_17432_17455(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 17470, 17495);

                f_22001_17470_17494(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 17509, 17580);

                var
                m = f_22001_17517_17579(f_22001_17517_17571(f_22001_17517_17549(f_22001_17517_17531(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 17594, 19631);

                f_22001_17594_19630(comp, m, @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IForEachLoopOperation (LoopKind.ForEach, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null) (Syntax: 'foreach (re ... }')
    Locals: Local_1: System.Int32 x
    LoopControlVariable: 
      IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'var')
        Initializer: 
          null
    Collection: 
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: RefEnumerable, IsImplicit) (Syntax: 're')
        Conversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: re (OperationKind.ParameterReference, Type: RefEnumerable) (Syntax: 're')
    Body: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(x);')
          Expression: 
            IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(x)')
              Instance Receiver: 
                null
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 'x')
                    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    NextVariables(0)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 19645, 19794);

                var
                op = (IForEachLoopOperation)f_22001_19677_19793(f_22001_19677_19704(comp, tree), f_22001_19718_19792(f_22001_19718_19783(f_22001_19718_19750(f_22001_19718_19732(tree)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 19808, 19870);

                f_22001_19808_19869(RefKind.RefReadOnly, f_22001_19842_19868(op.Locals.Single()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 16533, 19881);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 16533, 19881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 16533, 19881);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(382240, "https://devdiv.visualstudio.com/DevDiv/_workitems?id=382240")]
        public void NullInPlaceOfParamArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 19893, 22672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 20115, 20374);

                var
                text = @"
public class Cls
{
    public static void Main()
    {
        Test1(null);
        Test2(new object(), null);
    }

    static void Test1(params int[] x)
    {
    }

    static void Test2(int y, params int[] x)
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 20388, 20498);

                var
                compilation = f_22001_20406_20497(text, options: TestOptions.ReleaseExe, parseOptions: TestOptions.Regular)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 20512, 20835);

                f_22001_20512_20834(compilation, f_22001_20707_20815(f_22001_20707_20795(f_22001_20707_20759(ErrorCode.ERR_BadArgType, "new object()"), "1", "object", "int"), 7, 15));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 20851, 20895);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 20909, 21001);

                var
                nodes = f_22001_20921_21000(f_22001_20921_20990(f_22001_20921_20953(f_22001_20921_20935(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 21017, 22135);

                f_22001_21017_22134(
                            compilation, nodes[0], expectedOperationTree:
                @"IInvocationOperation (void Cls.Test1(params System.Int32[] x)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Test1(null)')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'null')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32[], Constant: null, IsImplicit) (Syntax: 'null')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 22151, 22661);

                f_22001_22151_22660(
                            compilation, nodes[1], expectedOperationTree:
                @"IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'Test2(new o ... ct(), null)')
  Children(2):
      IObjectCreationOperation (Constructor: System.Object..ctor()) (OperationKind.ObjectCreation, Type: System.Object, IsInvalid) (Syntax: 'new object()')
        Arguments(0)
        Initializer: 
          null
      ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 19893, 22672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 19893, 22672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 19893, 22672);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DeconstructionAssignmentFromTuple()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 22684, 24577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 22825, 23118);

                var
                text = @"
public class C
{
    public static void M()
    {
        int x, y, z;
        (x, y, z) = (1, 2, 3);
        (x, y, z) = new C();
        var (a, b) = (1, 2);
    }
    public void Deconstruct(out int a, out int b, out int c)
    {
        a = b = c = 1;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23132, 23249);

                var
                compilation = f_22001_23150_23248(text, references: new[] { f_22001_23208_23221(), f_22001_23223_23245() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23263, 23295);

                f_22001_23263_23294(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23309, 23353);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23367, 23414);

                var
                model = f_22001_23379_23413(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23430, 23528);

                var
                assignments = f_22001_23448_23527(f_22001_23448_23517(f_22001_23448_23480(f_22001_23448_23462(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23542, 23607);

                f_22001_23542_23606("(x, y, z) = (1, 2, 3)", f_22001_23580_23605(assignments[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23621, 23680);

                IOperation
                operation1 = f_22001_23645_23679(model, assignments[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23694, 23721);

                f_22001_23694_23720(operation1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23735, 23805);

                f_22001_23735_23804(OperationKind.DeconstructionAssignment, f_22001_23788_23803(operation1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23819, 23874);

                f_22001_23819_23873(operation1 is ISimpleAssignmentOperation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23890, 23953);

                f_22001_23890_23952("(x, y, z) = new C()", f_22001_23926_23951(assignments[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 23967, 24026);

                IOperation
                operation2 = f_22001_23991_24025(model, assignments[1])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24040, 24067);

                f_22001_24040_24066(operation2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24081, 24151);

                f_22001_24081_24150(OperationKind.DeconstructionAssignment, f_22001_24134_24149(operation2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24165, 24220);

                f_22001_24165_24219(operation2 is ISimpleAssignmentOperation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24236, 24299);

                f_22001_24236_24298("var (a, b) = (1, 2)", f_22001_24272_24297(assignments[2]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24313, 24372);

                IOperation
                operation3 = f_22001_24337_24371(model, assignments[2])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24386, 24413);

                f_22001_24386_24412(operation3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24427, 24497);

                f_22001_24427_24496(OperationKind.DeconstructionAssignment, f_22001_24480_24495(operation3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24511, 24566);

                f_22001_24511_24565(operation3 is ISimpleAssignmentOperation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 22684, 24577);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 22684, 24577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 22684, 24577);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact(Skip = "https://github.com/dotnet/roslyn/issues/45687")]
        public void TestClone()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 24589, 25150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24762, 24811);

                var
                sourceCode = f_22001_24779_24810()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 24827, 24991);

                var
                compilation = f_22001_24845_24990(sourceCode, new[] { f_22001_24897_24906(), f_22001_24908_24921(), f_22001_24923_24936(), f_22001_24938_24960() }, sourceFileName: "file.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25005, 25043);

                var
                tree = f_22001_25016_25039(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25057, 25104);

                var
                model = f_22001_25069_25103(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25120, 25139);

                f_22001_25120_25138(model);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 24589, 25150);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 24589, 25150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 24589, 25150);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(22964, "https://github.com/dotnet/roslyn/issues/22964")]
        [Fact]
        public void GlobalStatement_Parent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 25162, 26032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25368, 25417);

                var
                source =
                @"
System.Console.WriteLine();
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25431, 25572);

                var
                compilation = f_22001_25449_25571(source, options: f_22001_25484_25536(TestOptions.ReleaseExe, "Script"), parseOptions: TestOptions.Script)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25586, 25618);

                f_22001_25586_25617(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25634, 25678);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25692, 25776);

                var
                statement = f_22001_25708_25775(f_22001_25708_25766(f_22001_25708_25740(f_22001_25708_25722(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25790, 25837);

                var
                model = f_22001_25802_25836(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25851, 25897);

                var
                operation = f_22001_25867_25896(model, statement)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25913, 25977);

                f_22001_25913_25976(OperationKind.ExpressionStatement, f_22001_25961_25975(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 25991, 26021);

                f_22001_25991_26020(f_22001_26003_26019(operation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 25162, 26032);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 25162, 26032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 25162, 26032);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParentOperations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 26044, 26571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 26172, 26221);

                var
                sourceCode = f_22001_26189_26220()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 26237, 26401);

                var
                compilation = f_22001_26255_26400(sourceCode, new[] { f_22001_26307_26316(), f_22001_26318_26331(), f_22001_26333_26346(), f_22001_26348_26370() }, sourceFileName: "file.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 26415, 26453);

                var
                tree = f_22001_26426_26449(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 26467, 26514);

                var
                model = f_22001_26479_26513(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 26530, 26560);

                f_22001_26530_26559(model);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 26044, 26571);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 26044, 26571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 26044, 26571);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(23001, "https://github.com/dotnet/roslyn/issues/23001")]
        [Fact]
        public void TestGetOperationForQualifiedName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 26583, 27879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 26799, 27012);

                var
                text = @"using System;

public class Test
{
    class A
    {
        public B b;
    }
    class B
    {
    }
    
    void M(A a)
    {
        int x2 = /*<bind>*/a.b/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27026, 27061);

                var
                comp = f_22001_27037_27060(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27075, 27112);

                var
                tree = comp.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27126, 27166);

                var
                model = f_22001_27138_27165(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27277, 27367);

                var
                expr = (MemberAccessExpressionSyntax)f_22001_27318_27366(this, f_22001_27342_27365(this, tree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27381, 27418);

                f_22001_27381_27417("a.b", f_22001_27401_27416(expr));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27432, 27473);

                var
                operation = f_22001_27448_27472(model, expr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27487, 27513);

                f_22001_27487_27512(operation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27527, 27586);

                f_22001_27527_27585(OperationKind.FieldReference, f_22001_27570_27584(operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27600, 27657);

                var
                fieldOperation = (IFieldReferenceOperation)operation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27671, 27716);

                f_22001_27671_27715("b", f_22001_27689_27714(f_22001_27689_27709(fieldOperation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27825, 27868);

                f_22001_27825_27867(f_22001_27837_27866(model, f_22001_27856_27865(expr)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 26583, 27879);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 26583, 27879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 26583, 27879);
            }
        }

        [Fact]
        public void TestSemanticModelOnOperationAncestors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 27891, 28728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 27983, 28125);

                var
                compilation = f_22001_28001_28124(@"
class C 
{
  void M(bool flag)
  {
    if (flag)
    {
        int y = 1000;
    }
  }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28141, 28179);

                var
                tree = f_22001_28152_28175(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28193, 28234);

                var
                root = tree.GetCompilationUnitRoot()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28248, 28328);

                var
                literal = f_22001_28262_28327(f_22001_28262_28318(f_22001_28262_28284(root)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28342, 28428);

                var
                methodDeclSyntax = f_22001_28365_28427(f_22001_28365_28418(f_22001_28365_28384(literal)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28442, 28489);

                var
                model = f_22001_28454_28488(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28503, 28554);

                IOperation
                operation = f_22001_28526_28553(model, literal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28568, 28717);

                f_22001_28568_28716(operation, model, expectedRootOperationKind: OperationKind.MethodBody, expectedRootSyntax: methodDeclSyntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 27891, 28728);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 27891, 28728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 27891, 28728);
            }
        }

        [Fact]
        public void TestGetOperationOnSpeculativeSemanticModel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 28740, 30752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28837, 28947);

                var
                compilation = f_22001_28855_28946(@"
class C 
{
  void M(int x)
  {
    int y = 1000;     
  }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 28963, 29056);

                var
                speculatedBlock = (BlockSyntax)f_22001_28998_29055(@"
{ 
   int z = 0;
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29072, 29110);

                var
                tree = f_22001_29083_29106(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29124, 29165);

                var
                root = tree.GetCompilationUnitRoot()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29179, 29233);

                var
                typeDecl = (TypeDeclarationSyntax)f_22001_29217_29229(root)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29247, 29309);

                var
                methodDecl = (MethodDeclarationSyntax)f_22001_29289_29305(typeDecl)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29323, 29370);

                var
                model = f_22001_29335_29369(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29386, 29417);

                SemanticModel
                speculativeModel
                = default(SemanticModel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29431, 29563);

                bool
                success = f_22001_29446_29562(model, f_22001_29483_29522(f_22001_29483_29509(f_22001_29483_29498(methodDecl))[0]), speculatedBlock, out speculativeModel)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29577, 29598);

                f_22001_29577_29597(success);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29612, 29645);

                f_22001_29612_29644(speculativeModel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29661, 29740);

                var
                localDecl = (LocalDeclarationStatementSyntax)f_22001_29710_29736(speculatedBlock)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29754, 29818);

                IOperation
                operation = f_22001_29777_29817(speculativeModel, localDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 29832, 29986);

                f_22001_29832_29985(operation, speculativeModel, expectedRootOperationKind: OperationKind.Block, expectedRootSyntax: speculatedBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 30002, 30741);

                f_22001_30002_30740(
                            speculativeModel, localDecl, expectedOperationTree: @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int z = 0;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int z = 0')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 z) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'z = 0')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
    Initializer: 
      null
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 28740, 30752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 28740, 30752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 28740, 30752);
            }
        }

        [Fact, WorkItem(26649, "https://github.com/dotnet/roslyn/issues/26649")]
        public void IncrementalBindingReusesBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 30764, 31967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 30914, 31096);

                var
                source = @"
class C
{
    void M()
    {
        try
        {
        }
        catch (Exception e)
        {
            throw new Exception();
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 31112, 31156);

                var
                compilation = f_22001_31130_31155(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 31170, 31214);

                var
                syntaxTree = f_22001_31187_31210(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 31228, 31289);

                var
                semanticModel = f_22001_31248_31288(compilation, syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 31568, 31661);

                var
                catchBlock = f_22001_31585_31660(f_22001_31585_31651(f_22001_31585_31623(f_22001_31585_31605(syntaxTree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 31675, 31713);

                var
                exceptionBlock = f_22001_31696_31712(catchBlock)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 31729, 31793);

                var
                blockOperation = f_22001_31750_31792(semanticModel, exceptionBlock)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 31807, 31890);

                var
                catchOperation = (ICatchClauseOperation)f_22001_31851_31889(semanticModel, catchBlock)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 31904, 31956);

                f_22001_31904_31955(blockOperation, f_22001_31932_31954(catchOperation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 30764, 31967);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 30764, 31967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 30764, 31967);
            }
        }

        private static void VerifyRootAndModelForOperationAncestors(
                    IOperation operation,
                    SemanticModel model,
                    OperationKind expectedRootOperationKind,
                    SyntaxNode expectedRootSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(22001, 31979, 32832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32231, 32302);

                SemanticModel
                memberModel = f_22001_32259_32301(((Operation)operation))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32316, 32821) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(22001, 32316, 32821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32361, 32405);

                        f_22001_32361_32404(model, f_22001_32380_32403(operation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32423, 32492);

                        f_22001_32423_32491(memberModel, f_22001_32448_32490(((Operation)operation)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32512, 32757) || true) && (f_22001_32516_32532(operation) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(22001, 32512, 32757);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32582, 32638);

                            f_22001_32582_32637(expectedRootOperationKind, f_22001_32622_32636(operation));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32660, 32710);

                            f_22001_32660_32709(expectedRootSyntax, f_22001_32692_32708(operation));
                            DynAbs.Tracing.TraceSender.TraceBreak(22001, 32732, 32738);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(22001, 32512, 32757);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32777, 32806);

                        operation = f_22001_32789_32805(operation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(22001, 32316, 32821);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(22001, 32316, 32821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(22001, 32316, 32821);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(22001, 31979, 32832);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 31979, 32832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 31979, 32832);
            }
        }

        [Fact, WorkItem(45955, "https://github.com/dotnet/roslyn/issues/45955")]
        public void SemanticModelFieldInitializerRace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22001, 32844, 34283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 32998, 33248);

                var
                source = $@"
#nullable enable
public class C
{{
    // Use a big initializer to increase the odds of hitting the race
    public static object o = null;
    public string s = {f_22001_33184_33240(" + ", f_22001_33203_33239("(string)o", 1000))};
}}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33262, 33299);

                var
                comp = f_22001_33273_33298(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33313, 33344);

                var
                tree = f_22001_33324_33340(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33358, 33461);

                var
                fieldInitializer = f_22001_33381_33460(f_22001_33381_33454(f_22001_33381_33447(f_22001_33381_33413(f_22001_33381_33395(tree)))))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33486, 33491);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33477, 34272) || true) && (i < 5)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33500, 33503)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(22001, 33477, 34272))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(22001, 33477, 34272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33893, 33933);

                        var
                        model = f_22001_33905_33932(comp, tree)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33951, 33973);

                        const int
                        nTasks = 10
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(22001, 33991, 34257);

                        f_22001_33991_34256(f_22001_33991_34031(f_22001_33991_34018(0, nTasks)), _ => Assert.Equal("System.String System.String.op_Addition(System.String left, System.String right)", model.GetSymbolInfo(fieldInitializer).Symbol.ToTestDisplayString(includeNonNullable: false)));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(22001, 1, 796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(22001, 1, 796);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(22001, 32844, 34283);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22001, 32844, 34283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 32844, 34283);
            }
        }

        public IOperationTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(22001, 539, 34290);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(22001, 539, 34290);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 539, 34290);
        }


        static IOperationTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(22001, 539, 34290);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009, 564, 643);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009, 675, 754);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009, 786, 859);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009, 891, 946);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(22035, 375276, 378676);
            s_ValueTask = @"
namespace System.Threading.Tasks
{
    [System.Runtime.CompilerServices.AsyncMethodBuilder(typeof(System.Runtime.CompilerServices.ValueTaskMethodBuilder))]
    public struct ValueTask
    {
        public Awaiter GetAwaiter() => null;
        public class Awaiter : System.Runtime.CompilerServices.INotifyCompletion
        {
            public void OnCompleted(Action a) { }
            public bool IsCompleted => true;
            public void GetResult() { }
        }
    }
    [System.Runtime.CompilerServices.AsyncMethodBuilder(typeof(System.Runtime.CompilerServices.ValueTaskMethodBuilder<>))]
    public struct ValueTask<T>
    {
        public Awaiter GetAwaiter() => null;
        public class Awaiter : System.Runtime.CompilerServices.INotifyCompletion
        {
            public void OnCompleted(Action a) { }
            public bool IsCompleted => true;
            public T GetResult() => default;
        }
    }
}
namespace System.Runtime.CompilerServices
{
    public class AsyncMethodBuilderAttribute : Attribute
    {
       public AsyncMethodBuilderAttribute(Type t) { }
    }
    public class ValueTaskMethodBuilder
    {
        public static ValueTaskMethodBuilder Create() => null;
        internal ValueTaskMethodBuilder(System.Threading.Tasks.ValueTask task) { }
        public void SetStateMachine(IAsyncStateMachine stateMachine) { }
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void SetException(Exception e) { }
        public void SetResult() { }
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public System.Threading.Tasks.ValueTask Task => default;
    }
    public class ValueTaskMethodBuilder<T>
    {
        public static ValueTaskMethodBuilder<T> Create() => null;
        internal ValueTaskMethodBuilder(System.Threading.Tasks.ValueTask<T> task) { }
        public void SetStateMachine(IAsyncStateMachine stateMachine) { }
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void SetException(Exception e) { }
        public void SetResult(T t) { }
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine { }
        public System.Threading.Tasks.ValueTask<T> Task => default;
    }
}"; DynAbs.Tracing.TraceSender.TraceSimpleStatement(22056, 617, 669);
            ImplicitObjectCreationOptions = TestOptions.Regular9; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(22001, 539, 34290);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22001, 539, 34290);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(22001, 539, 34290);

        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_850_987(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 850, 987);
            return return_v;
        }


        int
        f_22001_1634_1729(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 1634, 1729);
            return 0;
        }


        int
        f_22001_2489_2549(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 2489, 2549);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_2772_2913(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 2772, 2913);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22001_4069_4142(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 4069, 4142);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22001_4069_4162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 4069, 4162);
            return return_v;
        }


        int
        f_22001_4192_4287(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 4192, 4287);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_4507_4673(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 4507, 4673);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_4688_4712(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 4688, 4712);
            return return_v;
        }


        int
        f_22001_6634_6694(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph)
        {
            VerifyFlowGraphForTest<BlockSyntax>(compilation, expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 6634, 6694);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_6897_7173(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 6897, 7173);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_7188_7212(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 7188, 7212);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_7237_7272(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 7237, 7272);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_7237_7290(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 7237, 7290);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>
        f_22001_7237_7312(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 7237, 7312);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        f_22001_7237_7321(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 7237, 7321);
            return return_v;
        }


        int
        f_22001_7336_11298(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 7336, 11298);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_22001_11463_11852(string
        text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        options)
        {
            var return_v = CSharpSyntaxTree.ParseText(text, options: options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 11463, 11852);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_11878_11901(Microsoft.CodeAnalysis.SyntaxTree
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 11878, 11901);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_11916_11940(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 11916, 11940);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_11963_11977(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 11963, 11977);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_11963_11995(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 11963, 11995);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>
        f_22001_11963_12017(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 11963, 12017);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        f_22001_11963_12025(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>
        source)
        {
            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 11963, 12025);
            return return_v;
        }


        int
        f_22001_12040_16278(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 12040, 16278);
            return 0;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_16321_16348(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 16321, 16348);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_16362_16376(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 16362, 16376);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_16362_16394(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 16362, 16394);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax>
        f_22001_16362_16423(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 16362, 16423);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
        f_22001_16362_16432(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 16362, 16432);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_16321_16433(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 16321, 16433);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_22001_16482_16508(Microsoft.CodeAnalysis.ILocalSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 16482, 16508);
            return return_v;
        }


        int
        f_22001_16448_16509(Microsoft.CodeAnalysis.RefKind
        expected, Microsoft.CodeAnalysis.RefKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 16448, 16509);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_22001_16678_17406(string
        text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        options)
        {
            var return_v = CSharpSyntaxTree.ParseText(text, options: options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 16678, 17406);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_17432_17455(Microsoft.CodeAnalysis.SyntaxTree
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 17432, 17455);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_17470_17494(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 17470, 17494);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_17517_17531(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 17517, 17531);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_17517_17549(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 17517, 17549);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>
        f_22001_17517_17571(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 17517, 17571);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        f_22001_17517_17579(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>
        source)
        {
            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 17517, 17579);
            return return_v;
        }


        int
        f_22001_17594_19630(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 17594, 19630);
            return 0;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_19677_19704(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 19677, 19704);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_19718_19732(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 19718, 19732);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_19718_19750(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 19718, 19750);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax>
        f_22001_19718_19783(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 19718, 19783);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
        f_22001_19718_19792(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 19718, 19792);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_19677_19793(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 19677, 19793);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_22001_19842_19868(Microsoft.CodeAnalysis.ILocalSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 19842, 19868);
            return return_v;
        }


        int
        f_22001_19808_19869(Microsoft.CodeAnalysis.RefKind
        expected, Microsoft.CodeAnalysis.RefKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 19808, 19869);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_20406_20497(string
        source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20406, 20497);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22001_20707_20759(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20707, 20759);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22001_20707_20795(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20707, 20795);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22001_20707_20815(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20707, 20815);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_20512_20834(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20512, 20834);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_20921_20935(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20921, 20935);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_20921_20953(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20921, 20953);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>
        f_22001_20921_20990(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20921, 20990);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax[]
        f_22001_20921_21000(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>
        source)
        {
            var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 20921, 21000);
            return return_v;
        }


        int
        f_22001_21017_22134(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 21017, 22134);
            return 0;
        }


        int
        f_22001_22151_22660(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 22151, 22660);
            return 0;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_23208_23221()
        {
            var return_v = ValueTupleRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 23208, 23221);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_23223_23245()
        {
            var return_v = SystemRuntimeFacadeRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 23223, 23245);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_23150_23248(string
        source, Microsoft.CodeAnalysis.MetadataReference[]
        references)
        {
            var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23150, 23248);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_23263_23294(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23263, 23294);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_23379_23413(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23379, 23413);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_23448_23462(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23448, 23462);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_23448_23480(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23448, 23480);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax>
        f_22001_23448_23517(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23448, 23517);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax[]
        f_22001_23448_23527(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax>
        source)
        {
            var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23448, 23527);
            return return_v;
        }


        string
        f_22001_23580_23605(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23580, 23605);
            return return_v;
        }


        int
        f_22001_23542_23606(string
        expected, string
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23542, 23606);
            return 0;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_23645_23679(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23645, 23679);
            return return_v;
        }


        int
        f_22001_23694_23720(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.NotNull((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23694, 23720);
            return 0;
        }


        Microsoft.CodeAnalysis.OperationKind
        f_22001_23788_23803(Microsoft.CodeAnalysis.IOperation?
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 23788, 23803);
            return return_v;
        }


        int
        f_22001_23735_23804(Microsoft.CodeAnalysis.OperationKind
        expected, Microsoft.CodeAnalysis.OperationKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23735, 23804);
            return 0;
        }


        int
        f_22001_23819_23873(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23819, 23873);
            return 0;
        }


        string
        f_22001_23926_23951(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23926, 23951);
            return return_v;
        }


        int
        f_22001_23890_23952(string
        expected, string
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23890, 23952);
            return 0;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_23991_24025(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 23991, 24025);
            return return_v;
        }


        int
        f_22001_24040_24066(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.NotNull((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24040, 24066);
            return 0;
        }


        Microsoft.CodeAnalysis.OperationKind
        f_22001_24134_24149(Microsoft.CodeAnalysis.IOperation?
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 24134, 24149);
            return return_v;
        }


        int
        f_22001_24081_24150(Microsoft.CodeAnalysis.OperationKind
        expected, Microsoft.CodeAnalysis.OperationKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24081, 24150);
            return 0;
        }


        int
        f_22001_24165_24219(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24165, 24219);
            return 0;
        }


        string
        f_22001_24272_24297(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24272, 24297);
            return return_v;
        }


        int
        f_22001_24236_24298(string
        expected, string
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24236, 24298);
            return 0;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_24337_24371(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24337, 24371);
            return return_v;
        }


        int
        f_22001_24386_24412(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.NotNull((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24386, 24412);
            return 0;
        }


        Microsoft.CodeAnalysis.OperationKind
        f_22001_24480_24495(Microsoft.CodeAnalysis.IOperation?
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 24480, 24495);
            return return_v;
        }


        int
        f_22001_24427_24496(Microsoft.CodeAnalysis.OperationKind
        expected, Microsoft.CodeAnalysis.OperationKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24427, 24496);
            return 0;
        }


        int
        f_22001_24511_24565(bool
        condition)
        {
            Assert.False(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24511, 24565);
            return 0;
        }


        string
        f_22001_24779_24810()
        {
            var return_v = TestResource.AllInOneCSharpCode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 24779, 24810);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_24897_24906()
        {
            var return_v = SystemRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 24897, 24906);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_24908_24921()
        {
            var return_v = SystemCoreRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 24908, 24921);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_24923_24936()
        {
            var return_v = ValueTupleRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 24923, 24936);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_24938_24960()
        {
            var return_v = SystemRuntimeFacadeRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 24938, 24960);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_24845_24990(string
        source, Microsoft.CodeAnalysis.MetadataReference[]
        references, string
        sourceFileName)
        {
            var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, sourceFileName: sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 24845, 24990);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22001_25016_25039(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 25016, 25039);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_25069_25103(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25069, 25103);
            return return_v;
        }


        int
        f_22001_25120_25138(Microsoft.CodeAnalysis.SemanticModel
        model)
        {
            VerifyClone(model);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25120, 25138);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_22001_25484_25536(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, string
        name)
        {
            var return_v = this_param.WithScriptClassName(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25484, 25536);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_25449_25571(string
        source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25449, 25571);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_25586_25617(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25586, 25617);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_25708_25722(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25708, 25722);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_25708_25740(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25708, 25740);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
        f_22001_25708_25766(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25708, 25766);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
        f_22001_25708_25775(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25708, 25775);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_25802_25836(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25802, 25836);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_25867_25896(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25867, 25896);
            return return_v;
        }


        Microsoft.CodeAnalysis.OperationKind
        f_22001_25961_25975(Microsoft.CodeAnalysis.IOperation?
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 25961, 25975);
            return return_v;
        }


        int
        f_22001_25913_25976(Microsoft.CodeAnalysis.OperationKind
        expected, Microsoft.CodeAnalysis.OperationKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25913, 25976);
            return 0;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_26003_26019(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 26003, 26019);
            return return_v;
        }


        int
        f_22001_25991_26020(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 25991, 26020);
            return 0;
        }


        string
        f_22001_26189_26220()
        {
            var return_v = TestResource.AllInOneCSharpCode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 26189, 26220);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_26307_26316()
        {
            var return_v = SystemRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 26307, 26316);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_26318_26331()
        {
            var return_v = SystemCoreRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 26318, 26331);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_26333_26346()
        {
            var return_v = ValueTupleRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 26333, 26346);
            return return_v;
        }


        Microsoft.CodeAnalysis.MetadataReference
        f_22001_26348_26370()
        {
            var return_v = SystemRuntimeFacadeRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 26348, 26370);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_26255_26400(string
        source, Microsoft.CodeAnalysis.MetadataReference[]
        references, string
        sourceFileName)
        {
            var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, sourceFileName: sourceFileName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 26255, 26400);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22001_26426_26449(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 26426, 26449);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_26479_26513(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 26479, 26513);
            return return_v;
        }


        int
        f_22001_26530_26559(Microsoft.CodeAnalysis.SemanticModel
        model)
        {
            VerifyParentOperations(model);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 26530, 26559);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_27037_27060(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27037, 27060);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_27138_27165(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27138, 27165);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        f_22001_27342_27365(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetExprSyntaxList(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27342, 27365);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        f_22001_27318_27366(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
        this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        exprSynList)
        {
            var return_v = this_param.GetExprSyntaxForBinding(exprSynList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27318, 27366);
            return return_v;
        }


        string
        f_22001_27401_27416(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27401, 27416);
            return return_v;
        }


        int
        f_22001_27381_27417(string
        expected, string
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27381, 27417);
            return 0;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_27448_27472(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27448, 27472);
            return return_v;
        }


        int
        f_22001_27487_27512(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.NotNull((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27487, 27512);
            return 0;
        }


        Microsoft.CodeAnalysis.OperationKind
        f_22001_27570_27584(Microsoft.CodeAnalysis.IOperation?
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 27570, 27584);
            return return_v;
        }


        int
        f_22001_27527_27585(Microsoft.CodeAnalysis.OperationKind
        expected, Microsoft.CodeAnalysis.OperationKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27527, 27585);
            return 0;
        }


        Microsoft.CodeAnalysis.IFieldSymbol
        f_22001_27689_27709(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
        this_param)
        {
            var return_v = this_param.Field;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 27689, 27709);
            return return_v;
        }


        string
        f_22001_27689_27714(Microsoft.CodeAnalysis.IFieldSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 27689, 27714);
            return return_v;
        }


        int
        f_22001_27671_27715(string
        expected, string
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27671, 27715);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
        f_22001_27856_27865(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 27856, 27865);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_27837_27866(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27837, 27866);
            return return_v;
        }


        int
        f_22001_27825_27867(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 27825, 27867);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_28001_28124(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28001, 28124);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22001_28152_28175(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 28152, 28175);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_28262_28284(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28262, 28284);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax>
        f_22001_28262_28318(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28262, 28318);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
        f_22001_28262_28327(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28262, 28327);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_28365_28384(Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
        this_param)
        {
            var return_v = this_param.Ancestors();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28365, 28384);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
        f_22001_28365_28418(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28365, 28418);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        f_22001_28365_28427(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28365, 28427);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_28454_28488(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28454, 28488);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_28526_28553(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28526, 28553);
            return return_v;
        }


        int
        f_22001_28568_28716(Microsoft.CodeAnalysis.IOperation?
        operation, Microsoft.CodeAnalysis.SemanticModel
        model, Microsoft.CodeAnalysis.OperationKind
        expectedRootOperationKind, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        expectedRootSyntax)
        {
            VerifyRootAndModelForOperationAncestors(operation, model, expectedRootOperationKind: expectedRootOperationKind, expectedRootSyntax: (Microsoft.CodeAnalysis.SyntaxNode)expectedRootSyntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28568, 28716);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_28855_28946(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28855, 28946);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
        f_22001_28998_29055(string
        text)
        {
            var return_v = SyntaxFactory.ParseStatement(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 28998, 29055);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22001_29083_29106(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 29083, 29106);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
        f_22001_29217_29229(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
        this_param)
        {
            var return_v = this_param.Members;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 29217, 29229);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
        f_22001_29289_29305(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Members;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 29289, 29305);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_29335_29369(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 29335, 29369);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_22001_29483_29498(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 29483, 29498);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
        f_22001_29483_29509(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        this_param)
        {
            var return_v = this_param.Statements;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 29483, 29509);
            return return_v;
        }


        int
        f_22001_29483_29522(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
        this_param)
        {
            var return_v = this_param.SpanStart;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 29483, 29522);
            return return_v;
        }


        bool
        f_22001_29446_29562(Microsoft.CodeAnalysis.SemanticModel
        semanticModel, int
        position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        statement, out Microsoft.CodeAnalysis.SemanticModel
        speculativeModel)
        {
            var return_v = semanticModel.TryGetSpeculativeSemanticModel(position, (Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)statement, out speculativeModel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 29446, 29562);
            return return_v;
        }


        int
        f_22001_29577_29597(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 29577, 29597);
            return 0;
        }


        int
        f_22001_29612_29644(Microsoft.CodeAnalysis.SemanticModel?
        @object)
        {
            Assert.NotNull((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 29612, 29644);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
        f_22001_29710_29736(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        this_param)
        {
            var return_v = this_param.Statements;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 29710, 29736);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_29777_29817(Microsoft.CodeAnalysis.SemanticModel?
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 29777, 29817);
            return return_v;
        }


        int
        f_22001_29832_29985(Microsoft.CodeAnalysis.IOperation?
        operation, Microsoft.CodeAnalysis.SemanticModel
        model, Microsoft.CodeAnalysis.OperationKind
        expectedRootOperationKind, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        expectedRootSyntax)
        {
            VerifyRootAndModelForOperationAncestors(operation, model, expectedRootOperationKind: expectedRootOperationKind, expectedRootSyntax: (Microsoft.CodeAnalysis.SyntaxNode)expectedRootSyntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 29832, 29985);
            return 0;
        }


        int
        f_22001_30002_30740(Microsoft.CodeAnalysis.SemanticModel
        model, Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
        node, string
        expectedOperationTree)
        {
            model.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 30002, 30740);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_31130_31155(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31130, 31155);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22001_31187_31210(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 31187, 31210);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_31248_31288(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31248, 31288);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_31585_31605(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31585, 31605);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_31585_31623(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31585, 31623);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>
        f_22001_31585_31651(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31585, 31651);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
        f_22001_31585_31660(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31585, 31660);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        f_22001_31696_31712(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
        this_param)
        {
            var return_v = this_param.Block;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 31696, 31712);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_31750_31792(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31750, 31792);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22001_31851_31889(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31851, 31889);
            return return_v;
        }


        Microsoft.CodeAnalysis.Operations.IBlockOperation
        f_22001_31932_31954(Microsoft.CodeAnalysis.Operations.ICatchClauseOperation?
        this_param)
        {
            var return_v = this_param.Handler;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 31932, 31954);
            return return_v;
        }


        int
        f_22001_31904_31955(Microsoft.CodeAnalysis.IOperation?
        expected, Microsoft.CodeAnalysis.Operations.IBlockOperation
        actual)
        {
            Assert.Same((object?)expected, (object)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 31904, 31955);
            return 0;
        }


        static Microsoft.CodeAnalysis.SemanticModel?
        f_22001_32259_32301(Microsoft.CodeAnalysis.Operation
        this_param)
        {
            var return_v = this_param.OwningSemanticModel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 32259, 32301);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel?
        f_22001_32380_32403(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.SemanticModel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 32380, 32403);
            return return_v;
        }


        static int
        f_22001_32361_32404(Microsoft.CodeAnalysis.SemanticModel
        expected, Microsoft.CodeAnalysis.SemanticModel?
        actual)
        {
            Assert.Same((object)expected, (object?)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 32361, 32404);
            return 0;
        }


        static Microsoft.CodeAnalysis.SemanticModel?
        f_22001_32448_32490(Microsoft.CodeAnalysis.Operation
        this_param)
        {
            var return_v = this_param.OwningSemanticModel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 32448, 32490);
            return return_v;
        }


        static int
        f_22001_32423_32491(Microsoft.CodeAnalysis.SemanticModel?
        expected, Microsoft.CodeAnalysis.SemanticModel?
        actual)
        {
            Assert.Same((object?)expected, (object?)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 32423, 32491);
            return 0;
        }


        static Microsoft.CodeAnalysis.IOperation?
        f_22001_32516_32532(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 32516, 32532);
            return return_v;
        }


        static Microsoft.CodeAnalysis.OperationKind
        f_22001_32622_32636(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 32622, 32636);
            return return_v;
        }


        static int
        f_22001_32582_32637(Microsoft.CodeAnalysis.OperationKind
        expected, Microsoft.CodeAnalysis.OperationKind
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 32582, 32637);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_22001_32692_32708(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 32692, 32708);
            return return_v;
        }


        static int
        f_22001_32660_32709(Microsoft.CodeAnalysis.SyntaxNode
        expected, Microsoft.CodeAnalysis.SyntaxNode
        actual)
        {
            Assert.Same((object)expected, (object)actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 32660, 32709);
            return 0;
        }


        static Microsoft.CodeAnalysis.IOperation
        f_22001_32789_32805(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Parent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 32789, 32805);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<string>
        f_22001_33203_33239(string
        element, int
        count)
        {
            var return_v = Enumerable.Repeat(element, count);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33203, 33239);
            return return_v;
        }


        string
        f_22001_33184_33240(string
        separator, System.Collections.Generic.IEnumerable<string>
        values)
        {
            var return_v = string.Join(separator, values);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33184, 33240);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22001_33273_33298(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33273, 33298);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22001_33324_33340(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 33324, 33340);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22001_33381_33395(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33381, 33395);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22001_33381_33413(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33381, 33413);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax>
        f_22001_33381_33447(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33381, 33447);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
        f_22001_33381_33454(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax>
        source)
        {
            var return_v = source.Last<Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33381, 33454);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        f_22001_33381_33460(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22001, 33381, 33460);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22001_33905_33932(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33905, 33932);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<int>
        f_22001_33991_34018(int
        start, int
        count)
        {
            var return_v = Enumerable.Range(start, count);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33991, 34018);
            return return_v;
        }


        System.Linq.ParallelQuery<int>
        f_22001_33991_34031(System.Collections.Generic.IEnumerable<int>
        source)
        {
            var return_v = source.AsParallel<int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33991, 34031);
            return return_v;
        }


        int
        f_22001_33991_34256(System.Linq.ParallelQuery<int>
        source, System.Action<int>
        action)
        {
            source.ForAll<int>(action);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22001, 33991, 34256);
            return 0;
        }

    }
}
