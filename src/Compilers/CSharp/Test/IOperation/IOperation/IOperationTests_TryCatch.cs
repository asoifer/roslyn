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
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatchFinally_Basic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,524,3638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,653,963);

string 
source = @"
using System;

class C
{
    void M(int i)
    {
        /*<bind>*/try
        {
            i = 0;
        }
        catch (Exception ex) when (i > 0)
        {
            throw ex;
        }
        finally
        {
            i = 1;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,977,3431);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 0;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 0')
            Left: 
              IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Exce ... }')
        Locals: Local_1: System.Exception ex
        ExceptionDeclarationOrExpression: 
          IVariableDeclaratorOperation (Symbol: System.Exception ex) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(Exception ex)')
            Initializer: 
              null
        Filter: 
          IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i > 0')
            Left: 
              IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        Handler: 
          IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw ex;')
              ILocalReferenceOperation: ex (OperationKind.LocalReference, Type: System.Exception) (Syntax: 'ex')
  Finally: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
        Expression: 
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
            Left: 
              IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,3445,3498);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,3514,3627);

f_22078_3514_3626(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,524,3638);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,524,3638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,524,3638);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatchFinally_Parent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,3650,6916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,3780,4090);

string 
source = @"
using System;

class C
{
    void M(int i)
    /*<bind>*/{
        try
        {
            i = 0;
        }
        catch (Exception ex) when (i > 0)
        {
            throw ex;
        }
        finally
        {
            i = 1;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,4104,6716);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
    Body: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 0;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 0')
              Left: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
    Catch clauses(1):
        ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Exce ... }')
          Locals: Local_1: System.Exception ex
          ExceptionDeclarationOrExpression: 
            IVariableDeclaratorOperation (Symbol: System.Exception ex) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(Exception ex)')
              Initializer: 
                null
          Filter: 
            IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i > 0')
              Left: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Handler: 
            IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
              IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw ex;')
                ILocalReferenceOperation: ex (OperationKind.LocalReference, Type: System.Exception) (Syntax: 'ex')
    Finally: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
              Left: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,6730,6783);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,6799,6905);

f_22078_6799_6904(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,3650,6916);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,3650,6916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,3650,6916);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_SingleCatchClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,6928,8570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,7062,7256);

string 
source = @"
class C
{
    static void Main()
    {
        /*<bind>*/try
        {
        }
        catch (System.IO.IOException e)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,7270,8110);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.IO.IOException) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Syst ... }')
        Locals: Local_1: System.IO.IOException e
        ExceptionDeclarationOrExpression: 
          IVariableDeclaratorOperation (Symbol: System.IO.IOException e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(System.IO. ... xception e)')
            Initializer: 
              null
        Filter: 
          null
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,8124,8430);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22078_8329_8414(f_22078_8329_8394(f_22078_8329_8375(ErrorCode.WRN_UnreferencedVar, "e"), "e"), 9, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,8446,8559);

f_22078_8446_8558(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,6928,8570);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,6928,8570);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,6928,8570);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_SingleCatchClauseAndFilter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,8582,10941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,8725,8944);

string 
source = @"
class C
{
    static void Main()
    {
        /*<bind>*/try
        {
        }
        catch (System.IO.IOException e) when (e.Message != null)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,8958,10734);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.IO.IOException) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Syst ... }')
        Locals: Local_1: System.IO.IOException e
        ExceptionDeclarationOrExpression: 
          IVariableDeclaratorOperation (Symbol: System.IO.IOException e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(System.IO. ... xception e)')
            Initializer: 
              null
        Filter: 
          IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'e.Message != null')
            Left: 
              IPropertyReferenceOperation: System.String System.Exception.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'e.Message')
                Instance Receiver: 
                  ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.IO.IOException) (Syntax: 'e')
            Right: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,10748,10801);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,10817,10930);

f_22078_10817_10929(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,8582,10941);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,8582,10941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,8582,10941);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_MultipleCatchClausesWithDifferentCaughtTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,10953,14204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,11114,11391);

string 
source = @"
class C
{
    static void Main()
    {
        /*<bind>*/try
        {
        }
        catch (System.IO.IOException e)
        {
        }
        catch (System.Exception e) when (e.Message != null)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,11405,13744);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(2):
      ICatchClauseOperation (Exception type: System.IO.IOException) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Syst ... }')
        Locals: Local_1: System.IO.IOException e
        ExceptionDeclarationOrExpression: 
          IVariableDeclaratorOperation (Symbol: System.IO.IOException e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(System.IO. ... xception e)')
            Initializer: 
              null
        Filter: 
          null
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Syst ... }')
        Locals: Local_1: System.Exception e
        ExceptionDeclarationOrExpression: 
          IVariableDeclaratorOperation (Symbol: System.Exception e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(System.Exception e)')
            Initializer: 
              null
        Filter: 
          IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'e.Message != null')
            Left: 
              IPropertyReferenceOperation: System.String System.Exception.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'e.Message')
                Instance Receiver: 
                  ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Exception) (Syntax: 'e')
            Right: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,13758,14064);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22078_13963_14048(f_22078_13963_14028(f_22078_13963_14009(ErrorCode.WRN_UnreferencedVar, "e"), "e"), 9, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,14080,14193);

f_22078_14080_14192(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,10953,14204);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,10953,14204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,10953,14204);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_MultipleCatchClausesWithDuplicateCaughtTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,14216,17889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,14377,14659);

string 
source = @"
class C
{
    static void Main()
    {
        /*<bind>*/try
        {
        }
        catch (System.IO.IOException e)
        {
        }
        catch (System.IO.IOException e) when (e.Message != null)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,14673,17072);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null, IsInvalid) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(2):
      ICatchClauseOperation (Exception type: System.IO.IOException) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Syst ... }')
        Locals: Local_1: System.IO.IOException e
        ExceptionDeclarationOrExpression: 
          IVariableDeclaratorOperation (Symbol: System.IO.IOException e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(System.IO. ... xception e)')
            Initializer: 
              null
        Filter: 
          null
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      ICatchClauseOperation (Exception type: System.IO.IOException) (OperationKind.CatchClause, Type: null, IsInvalid) (Syntax: 'catch (Syst ... }')
        Locals: Local_1: System.IO.IOException e
        ExceptionDeclarationOrExpression: 
          IVariableDeclaratorOperation (Symbol: System.IO.IOException e) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: '(System.IO. ... xception e)')
            Initializer: 
              null
        Filter: 
          IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'e.Message != null')
            Left: 
              IPropertyReferenceOperation: System.String System.Exception.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'e.Message')
                Instance Receiver: 
                  ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.IO.IOException) (Syntax: 'e')
            Right: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,17086,17749);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22078_17370_17497(f_22078_17370_17476(f_22078_17370_17437(ErrorCode.ERR_UnreachableCatch, "System.IO.IOException"), "System.IO.IOException"), 12, 16),
f_22078_17648_17733(f_22078_17648_17713(f_22078_17648_17694(ErrorCode.WRN_UnreferencedVar, "e"), "e"), 9, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,17765,17878);

f_22078_17765_17877(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,14216,17889);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,14216,17889);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,14216,17889);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_CatchClauseWithoutExceptionLocal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,17901,19066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,18050,18252);

string 
source = @"
using System;

class C
{
    static void M(string s)
    {
        /*<bind>*/try
        {
        }
        catch (Exception)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,18266,18859);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Exce ... }')
        ExceptionDeclarationOrExpression: 
          null
        Filter: 
          null
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,18873,18926);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,18942,19055);

f_22078_18942_19054(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,17901,19066);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,17901,19066);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,17901,19066);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_CatchClauseWithoutCaughtTypeOrExceptionLocal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,19078,20217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,19239,19412);

string 
source = @"
class C
{
    static void M(object o)
    {
        /*<bind>*/try
        {
        }
        catch
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,19426,20010);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.Object) (OperationKind.CatchClause, Type: null) (Syntax: 'catch ... }')
        ExceptionDeclarationOrExpression: 
          null
        Filter: 
          null
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,20024,20077);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,20093,20206);

f_22078_20093_20205(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,19078,20217);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,19078,20217);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,19078,20217);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_FinallyWithoutCatchClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,20229,22121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,20371,20598);

string 
source = @"
using System;

class C
{
    static void M(string s)
    {
        /*<bind>*/try
        {
        }
        finally
        {
            Console.WriteLine(s);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,20612,21914);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(0)
  Finally: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'Console.WriteLine(s);')
        Expression: 
          IInvocationOperation (void System.Console.WriteLine(System.String value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.WriteLine(s)')
            Instance Receiver: 
              null
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: 's')
                  IParameterReferenceOperation: s (OperationKind.ParameterReference, Type: System.String) (Syntax: 's')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,21928,21981);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,21997,22110);

f_22078_21997_22109(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,20229,22121);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,20229,22121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,20229,22121);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_TryBlockWithLocalDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,22133,24348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,22278,22516);

string 
source = @"
using System;

class C
{
    static void M(string s)
    {
        /*<bind>*/try
        {
            int i = 0;
        }
        catch (Exception)
        {            
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,22530,23887);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 i
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i = 0;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Exce ... }')
        ExceptionDeclarationOrExpression: 
          null
        Filter: 
          null
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,23901,24208);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22078_24102_24192(f_22078_24102_24171(f_22078_24102_24152(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 10, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,24224,24337);

f_22078_24224_24336(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,22133,24348);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,22133,24348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,22133,24348);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_CatchClauseWithLocalDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,24360,26626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,24508,24734);

string 
source = @"
using System;

class C
{
    static void M(string s)
    {
        /*<bind>*/try
        {
        }
        catch (Exception)
        {
            int i = 0;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,24748,26165);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Exce ... }')
        ExceptionDeclarationOrExpression: 
          null
        Filter: 
          null
        Handler: 
          IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
            Locals: Local_1: System.Int32 i
            IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i = 0;')
              IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
                Declarators:
                    IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                      Initializer: 
                        IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                Initializer: 
                  null
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,26179,26486);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22078_26380_26470(f_22078_26380_26449(f_22078_26380_26430(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 13, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,26502,26615);

f_22078_26502_26614(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,24360,26626);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,24360,26626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,24360,26626);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_CatchFilterWithLocalDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,26638,28348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,26786,27021);

string 
source = @"
using System;

class C
{
    static void M(object o)
    {
        /*<bind>*/try
        {
        }
        catch (Exception) when (o is string s)
        {            
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,27035,28141);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Exce ... }')
        Locals: Local_1: System.String s
        ExceptionDeclarationOrExpression: 
          null
        Filter: 
          IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'o is string s')
            Value: 
              IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'string s') (InputType: System.Object, NarrowedType: System.String, DeclaredSymbol: System.String s, MatchesNull: False)
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,28155,28208);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,28224,28337);

f_22078_28224_28336(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,26638,28348);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,26638,28348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,26638,28348);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_CatchFilterAndSourceWithLocalDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,28360,30580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,28517,28754);

string 
source = @"
using System;

class C
{
    static void M(object o)
    {
        /*<bind>*/try
        {
        }
        catch (Exception e) when (o is string s)
        {            
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,28768,30086);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(1):
      ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Exce ... }')
        Locals: Local_1: System.Exception e
          Local_2: System.String s
        ExceptionDeclarationOrExpression: 
          IVariableDeclaratorOperation (Symbol: System.Exception e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(Exception e)')
            Initializer: 
              null
        Filter: 
          IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'o is string s')
            Value: 
              IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'o')
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'string s') (InputType: System.Object, NarrowedType: System.String, DeclaredSymbol: System.String s, MatchesNull: False)
        Handler: 
          IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Finally: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,30100,30440);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22078_30338_30424(f_22078_30338_30403(f_22078_30338_30384(ErrorCode.WRN_UnreferencedVar, "e"), "e"), 11, 26)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,30456,30569);

f_22078_30456_30568(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,28360,30580);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,28360,30580);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,28360,30580);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_FinallyWithLocalDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,30592,32498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,30736,30930);

string 
source = @"
class C
{
    static void Main()
    {
        /*<bind>*/try
        {
        }
        finally
        {
            int i = 0;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,30944,32037);

string 
expectedOperationTree = @"
ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  Catch clauses(0)
  Finally: 
    IBlockOperation (1 statements, 1 locals) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
      Locals: Local_1: System.Int32 i
      IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i = 0;')
        IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
          Declarators:
              IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
                Initializer: 
                  IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
          Initializer: 
            null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,32051,32358);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22078_32252_32342(f_22078_32252_32321(f_22078_32252_32302(ErrorCode.WRN_UnreferencedVarAssg, "i"), "i"), 11, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,32374,32487);

f_22078_32374_32486(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,30592,32498);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,30592,32498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,30592,32498);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_InvalidCaughtType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,32510,34059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,32644,32820);

string 
source = @"
class C
{
    static void Main()
    {
        try
        {
        }
        /*<bind>*/catch (int e)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,32834,33376);

string 
expectedOperationTree = @"
ICatchClauseOperation (Exception type: System.Int32) (OperationKind.CatchClause, Type: null, IsInvalid) (Syntax: 'catch (int  ... }')
  Locals: Local_1: System.Int32 e
  ExceptionDeclarationOrExpression: 
    IVariableDeclaratorOperation (Symbol: System.Int32 e) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: '(int e)')
      Initializer: 
        null
  Filter: 
    null
  Handler: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,33390,33920);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22078_33607_33676(f_22078_33607_33656(ErrorCode.ERR_BadExceptionType, "int"), 9, 26),
f_22078_33819_33904(f_22078_33819_33884(f_22078_33819_33865(ErrorCode.WRN_UnreferencedVar, "e"), "e"), 9, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,33936,34048);

f_22078_33936_34047(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,32510,34059);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,32510,34059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,32510,34059);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_GetOperationForCatchClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,34071,36102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,34214,34433);

string 
source = @"
class C
{
    static void Main()
    {
        try
        {
        }
        /*<bind>*/catch (System.IO.IOException e) when (e.Message != null)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,34447,35896);

string 
expectedOperationTree = @"
ICatchClauseOperation (Exception type: System.IO.IOException) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Syst ... }')
  Locals: Local_1: System.IO.IOException e
  ExceptionDeclarationOrExpression: 
    IVariableDeclaratorOperation (Symbol: System.IO.IOException e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(System.IO. ... xception e)')
      Initializer: 
        null
  Filter: 
    IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'e.Message != null')
      Left: 
        IPropertyReferenceOperation: System.String System.Exception.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'e.Message')
          Instance Receiver: 
            ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.IO.IOException) (Syntax: 'e')
      Right: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
  Handler: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,35910,35963);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,35979,36091);

f_22078_35979_36090(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,34071,36102);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,34071,36102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,34071,36102);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_GetOperationForCatchDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,36114,36921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,36262,36481);

string 
source = @"
class C
{
    static void Main()
    {
        try
        {
        }
        catch /*<bind>*/(System.IO.IOException e)/*</bind>*/ when (e.Message != null)
        {
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,36495,36710);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.IO.IOException e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(System.IO. ... xception e)')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,36724,36777);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,36793,36910);

f_22078_36793_36909(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,36114,36921);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,36114,36921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,36114,36921);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_GetOperationForCatchFilterClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,36933,37466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,37082,37301);

string 
source = @"
using System;

class C
{
    static void M(string s)
    {
        try
        {
        }
        catch (Exception) /*<bind>*/when (s != null)/*</bind>*/
        {
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,37385,37455);

f_22078_37385_37454(f_22078_37397_37453(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,36933,37466);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,36933,37466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,36933,37466);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_GetOperationForCatchFilterClauseExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,37478,38772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,37637,37856);

string 
source = @"
using System;

class C
{
    static void M(string s)
    {
        try
        {
        }
        catch (Exception) when (/*<bind>*/s != null/*</bind>*/)
        {
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,37870,38561);

string 
expectedOperationTree = @"
IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 's != null')
  Left: 
    IParameterReferenceOperation: s (OperationKind.ParameterReference, Type: System.String) (Syntax: 's')
  Right: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'null')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,38575,38628);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,38644,38761);

f_22078_38644_38760(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,37478,38772);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,37478,38772);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,37478,38772);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TryCatch_GetOperationForFinallyClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,38784,39313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,38929,39156);

string 
source = @"
using System;

class C
{
    static void M(string s)
    {
        try
        {
        }
        /*<bind>*/finally
        {
            Console.WriteLine(s);
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,39236,39302);

f_22078_39236_39301(f_22078_39248_39300(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,38784,39313);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,38784,39313);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,38784,39313);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,39325,40349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,39469,39602);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
        try
        {}
        catch
        {}
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,39618,39662);

var 
compilation = f_22078_39636_39661(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,39678,39710);

f_22078_39678_39709(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,39726,40260);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,40274,40338);

f_22078_40274_40337(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,39325,40349);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,39325,40349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,39325,40349);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,40361,41013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,40505,40640);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
        try
        {}
        finally
        {}
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,40656,40700);

var 
compilation = f_22078_40674_40699(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,40716,40748);

f_22078_40716_40747(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,40764,40924);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Exit
    Predecessors: [B0]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,40938,41002);

f_22078_40938_41001(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,40361,41013);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,40361,41013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,40361,41013);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,41025,52231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,41169,42106);

var 
source = @"
class Exception1 : System.Exception { }
class Exception2 : Exception1 { }
class Exception3 : Exception2 { }
class Exception4 : Exception3 { }
class Exception5 : Exception4 { }

class C
{
    void F(int result, bool filter1, bool filter2, bool filter3, Exception5 e5, Exception4 e4)
    /*<bind>*/{
        try
        {
            result = -2;
        }
        catch (Exception5 e)
        {
            e5 = e;
        }
        catch (Exception4 e) when (filter1)
        {
            e4 = e;
        }
        catch (Exception3) when (filter2)
        {
            result = 3;
        }
        catch (Exception2)
        {
            result = 2;
        }
        catch when (filter3)
        {
            result = 1;
        }
        catch
        {
            result = 0;
        }
        finally
        {
            result = -1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,42122,42166);

var 
compilation = f_22078_42140_42165(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,42182,42214);

f_22078_42182_42213(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,42230,52142);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = -2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = -2')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                      Right: 
                        IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, Constant: -2) (Syntax: '-2')
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B12]
                Finalizing: {R17}
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (Exception5)
    {
        Locals: [Exception5 e]
        Block[B2] - Block
            Predecessors (0)
            Statements (2)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(Exception5 e)')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: Exception5, IsImplicit) (Syntax: '(Exception5 e)')
                  Right: 
                    ICaughtExceptionOperation (OperationKind.CaughtException, Type: Exception5, IsImplicit) (Syntax: '(Exception5 e)')

                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'e5 = e;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Exception5) (Syntax: 'e5 = e')
                      Left: 
                        IParameterReferenceOperation: e5 (OperationKind.ParameterReference, Type: Exception5) (Syntax: 'e5')
                      Right: 
                        ILocalReferenceOperation: e (OperationKind.LocalReference, Type: Exception5) (Syntax: 'e')

            Next (Regular) Block[B12]
                Finalizing: {R17}
                Leaving: {R5} {R3} {R2} {R1}
    }
    .catch {R6} (Exception4)
    {
        Locals: [Exception4 e]
        .filter {R7}
        {
            Block[B3] - Block
                Predecessors (0)
                Statements (1)
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(Exception4 e)')
                      Left: 
                        ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: Exception4, IsImplicit) (Syntax: '(Exception4 e)')
                      Right: 
                        ICaughtExceptionOperation (OperationKind.CaughtException, Type: Exception4, IsImplicit) (Syntax: '(Exception4 e)')

                Jump if True (Regular) to Block[B4]
                    IParameterReferenceOperation: filter1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'filter1')
                    Leaving: {R7}
                    Entering: {R8}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R8}
        {
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'e4 = e;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Exception4) (Syntax: 'e4 = e')
                          Left: 
                            IParameterReferenceOperation: e4 (OperationKind.ParameterReference, Type: Exception4) (Syntax: 'e4')
                          Right: 
                            ILocalReferenceOperation: e (OperationKind.LocalReference, Type: Exception4) (Syntax: 'e')

                Next (Regular) Block[B12]
                    Finalizing: {R17}
                    Leaving: {R8} {R6} {R3} {R2} {R1}
        }
    }
    .catch {R9} (Exception3)
    {
        .filter {R10}
        {
            Block[B5] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B6]
                    IParameterReferenceOperation: filter2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'filter2')
                    Leaving: {R10}
                    Entering: {R11}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R11}
        {
            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = 3;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = 3')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

                Next (Regular) Block[B12]
                    Finalizing: {R17}
                    Leaving: {R11} {R9} {R3} {R2} {R1}
        }
    }
    .catch {R12} (Exception2)
    {
        Block[B7] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = 2')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B12]
                Finalizing: {R17}
                Leaving: {R12} {R3} {R2} {R1}
    }
    .catch {R13} (System.Object)
    {
        .filter {R14}
        {
            Block[B8] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B9]
                    IParameterReferenceOperation: filter3 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'filter3')
                    Leaving: {R14}
                    Entering: {R15}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R15}
        {
            Block[B9] - Block
                Predecessors: [B8]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = 1;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = 1')
                          Left: 
                            IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

                Next (Regular) Block[B12]
                    Finalizing: {R17}
                    Leaving: {R15} {R13} {R3} {R2} {R1}
        }
    }
    .catch {R16} (System.Object)
    {
        Block[B10] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = 0;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = 0')
                      Left: 
                        IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            Next (Regular) Block[B12]
                Finalizing: {R17}
                Leaving: {R16} {R3} {R2} {R1}
    }
}
.finally {R17}
{
    Block[B11] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = -1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = -1')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                  Right: 
                    IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, Constant: -1) (Syntax: '-1')
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (StructuredExceptionHandling) Block[null]
}

Block[B12] - Exit
    Predecessors: [B1] [B2] [B4] [B6] [B7] [B9] [B10]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,52156,52220);

f_22078_52156_52219(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,41025,52231);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,41025,52231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,41025,52231);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,52243,55526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,52387,52667);

var 
source = @"
class C
{
    void F(bool input, int result)
    /*<bind>*/{
        result = 1; 
        try
        {
            if (input)
                input = false;
        }
        finally
        {
            result = 0;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,52683,52727);

var 
compilation = f_22078_52701_52726(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,52743,52775);

f_22078_52743_52774(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,52791,55437);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = 1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = 1')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B2]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')
            Finalizing: {R3}
            Leaving: {R2} {R1}

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'input = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'input = false')
                  Left: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B5]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = 0;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = 0')
                  Left: 
                    IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (StructuredExceptionHandling) Block[null]
}

Block[B5] - Exit
    Predecessors: [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,55451,55515);

f_22078_55451_55514(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,52243,55526);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,52243,55526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,52243,55526);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,55538,56686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,55682,55939);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        try
        {
            int i;
        }
        catch
        {
            int j;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,55955,55999);

var 
compilation = f_22078_55973_55998(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,56015,56047);

f_22078_56015_56046(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,56063,56597);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,56611,56675);

f_22078_56611_56674(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,55538,56686);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,55538,56686);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,55538,56686);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,56698,59010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,56842,57139);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        try
        {
            int i;
            i = 1;
        }
        catch
        {
            int j;
            j = 2;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,57155,57199);

var 
compilation = f_22078_57173_57198(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,57215,57247);

f_22078_57215_57246(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,57263,58921);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,58935,58999);

f_22078_58935_58998(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,56698,59010);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,56698,59010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,56698,59010);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,59022,62787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,59166,59558);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch (Exception1 e)
        {
            int j;
            j = 2;
        }
        finally
        {
            int i;
            i = 1;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,59574,59618);

var 
compilation = f_22078_59592_59617(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,59634,59666);

f_22078_59634_59665(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,59682,62698);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R7}
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (Exception1)
    {
        Locals: [Exception1 e]
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(Exception1 e)')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: Exception1, IsImplicit) (Syntax: '(Exception1 e)')
                  Right: 
                    ICaughtExceptionOperation (OperationKind.CaughtException, Type: Exception1, IsImplicit) (Syntax: '(Exception1 e)')

            Next (Regular) Block[B3]
                Entering: {R6}

        .locals {R6}
        {
            Locals: [System.Int32 j]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
                          Left: 
                            ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

                Next (Regular) Block[B6]
                    Finalizing: {R7}
                    Leaving: {R6} {R5} {R3} {R2} {R1}
        }
    }
}
.finally {R7}
{
    .locals {R8}
    {
        Locals: [System.Int32 i]
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 1')
                      Left: 
                        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B5]
                Leaving: {R8}
    }

    Block[B5] - Block
        Predecessors: [B4]
        Statements (0)
        Next (StructuredExceptionHandling) Block[null]
}

Block[B6] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,62712,62776);

f_22078_62712_62775(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,59022,62787);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,59022,62787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,59022,62787);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,62799,64525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,62943,63295);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch (Exception1 e)
        {
            int j;
        }
        finally
        {
            int i;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,63311,63355);

var 
compilation = f_22078_63329_63354(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,63371,63403);

f_22078_63371_63402(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,63419,64436);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (Exception1)
{
    Locals: [Exception1 e]
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(Exception1 e)')
              Left: 
                ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: Exception1, IsImplicit) (Syntax: '(Exception1 e)')
              Right: 
                ICaughtExceptionOperation (OperationKind.CaughtException, Type: Exception1, IsImplicit) (Syntax: '(Exception1 e)')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,64450,64514);

f_22078_64450_64513(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,62799,64525);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,62799,64525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,62799,64525);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,64537,68439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,64681,65064);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch (Exception1 e) when (filter(out var i))
        {
            int j;
            j = 2;
        }
    }/*</bind>*/

    bool filter(out int i) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,65080,65124);

var 
compilation = f_22078_65098_65123(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,65140,65172);

f_22078_65140_65171(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,65188,68350);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (Exception1)
{
    Locals: [Exception1 e] [System.Int32 i]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(Exception1 e)')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: Exception1, IsImplicit) (Syntax: '(Exception1 e)')
                  Right: 
                    ICaughtExceptionOperation (OperationKind.CaughtException, Type: Exception1, IsImplicit) (Syntax: '(Exception1 e)')

            Jump if True (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean C.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'filter')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Locals: [System.Int32 j]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,68364,68428);

f_22078_68364_68427(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,64537,68439);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,64537,68439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,64537,68439);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,68451,71739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,68595,68958);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch (Exception1 e) when (filter(out var i))
        {
            int j;
        }
    }/*</bind>*/

    bool filter(out int i) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,68974,69018);

var 
compilation = f_22078_68992_69017(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,69034,69066);

f_22078_69034_69065(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,69082,71650);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (Exception1)
{
    Locals: [Exception1 e] [System.Int32 i]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(Exception1 e)')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: Exception1, IsImplicit) (Syntax: '(Exception1 e)')
                  Right: 
                    ICaughtExceptionOperation (OperationKind.CaughtException, Type: Exception1, IsImplicit) (Syntax: '(Exception1 e)')

            Jump if True (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean C.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'filter')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,71664,71728);

f_22078_71664_71727(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,68451,71739);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,68451,71739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,68451,71739);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,71751,75158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,71895,72276);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch (Exception1) when (filter(out var i))
        {
            int j;
            j = 2;
        }
    }/*</bind>*/

    bool filter(out int i) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,72292,72336);

var 
compilation = f_22078_72310_72335(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,72352,72384);

f_22078_72352_72383(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,72400,75069);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (Exception1)
{
    Locals: [System.Int32 i]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean C.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'filter')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Locals: [System.Int32 j]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,75083,75147);

f_22078_75083_75146(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,71751,75158);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,71751,75158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,71751,75158);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,75170,77963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,75314,75675);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch (Exception1) when (filter(out var i))
        {
            int j;
        }
    }/*</bind>*/

    bool filter(out int i) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,75691,75735);

var 
compilation = f_22078_75709_75734(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,75751,75783);

f_22078_75751_75782(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,75799,77874);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (Exception1)
{
    Locals: [System.Int32 i]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean C.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'filter')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,77888,77952);

f_22078_77888_77951(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,75170,77963);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,75170,77963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,75170,77963);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,77975,81372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,78119,78487);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch when (filter(out var i))
        {
            int j;
            j = 2;
        }
    }/*</bind>*/

    bool filter(out int i) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,78503,78547);

var 
compilation = f_22078_78521_78546(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,78563,78595);

f_22078_78563_78594(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,78611,81283);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Locals: [System.Int32 i]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean C.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'filter')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Locals: [System.Int32 j]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,81297,81361);

f_22078_81297_81360(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,77975,81372);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,77975,81372);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,77975,81372);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,81384,84167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,81528,81876);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch when (filter(out var i))
        {
            int j;
        }
    }/*</bind>*/

    bool filter(out int i) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,81892,81936);

var 
compilation = f_22078_81910_81935(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,81952,81984);

f_22078_81952_81983(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,82000,84078);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Locals: [System.Int32 i]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean C.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'filter')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,84092,84156);

f_22078_84092_84155(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,81384,84167);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,81384,84167);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,81384,84167);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,84179,85940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,84323,84634);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch (Exception1)
        {
            int j;
            j = 2;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,84650,84694);

var 
compilation = f_22078_84668_84693(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,84710,84742);

f_22078_84710_84741(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,84758,85851);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (Exception1)
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,85865,85929);

f_22078_85865_85928(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,84179,85940);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,84179,85940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,84179,85940);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,85952,87131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,86096,86387);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch (Exception1)
        {
            int j;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,86403,86447);

var 
compilation = f_22078_86421_86446(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,86463,86495);

f_22078_86463_86494(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,86511,87042);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (Exception1)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,87056,87120);

f_22078_87056_87119(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,85952,87131);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,85952,87131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,85952,87131);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,87143,90540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,87287,87655);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch when (filter(out var i))
        {
            int j;
            j = 2;
        }
    }/*</bind>*/

    bool filter(out int i) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,87671,87715);

var 
compilation = f_22078_87689_87714(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,87731,87763);

f_22078_87731_87762(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,87779,90451);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Locals: [System.Int32 i]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean C.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'filter')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Locals: [System.Int32 j]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 2')
                      Left: 
                        ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,90465,90529);

f_22078_90465_90528(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,87143,90540);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,87143,90540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,87143,90540);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,90552,93335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,90696,91044);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class Exception1 : System.Exception { }
class C
{
    void F()
    /*<bind>*/{
        try
        {
        }
        catch when (filter(out var i))
        {
            int j;
        }
    }/*</bind>*/

    bool filter(out int i) => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,91060,91104);

var 
compilation = f_22078_91078_91103(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,91120,91152);

f_22078_91120_91151(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,91168,93246);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Locals: [System.Int32 i]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                IInvocationOperation ( System.Boolean C.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'filter')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,93260,93324);

f_22078_93260_93323(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,90552,93335);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,90552,93335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,90552,93335);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,93347,94727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,93491,93696);

var 
source = @"
class C
{
    void F(bool input)
    /*<bind>*/{
        try
        {
        }
        finally
        {
            if (input)
            {}
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,93712,93756);

var 
compilation = f_22078_93730_93755(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,93772,93804);

f_22078_93772_93803(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,93820,94638);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B4]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2*2]
        Statements (0)
        Next (StructuredExceptionHandling) Block[null]
}

Block[B4] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,94652,94716);

f_22078_94652_94715(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,93347,94727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,93347,94727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,93347,94727);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,94739,96029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,94883,95108);

var 
source = @"
class C
{
    void F(bool input)
    /*<bind>*/{
        try
        {
        }
        finally
        {
            do
            {}
            while (input);
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,95124,95168);

var 
compilation = f_22078_95142_95167(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,95184,95216);

f_22078_95184_95215(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,95232,95940);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B3]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B2] - Block
        Predecessors: [B2]
        Statements (0)
        Jump if True (Regular) to Block[B2]
            IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')

        Next (StructuredExceptionHandling) Block[null]
}

Block[B3] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,95954,96018);

f_22078_95954_96017(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,94739,96029);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,94739,96029);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,94739,96029);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_21()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,96041,97583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,96185,96464);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        try
        {
            int i;
            i = 1;
        }
        finally
        {
            int j;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,96480,96524);

var 
compilation = f_22078_96498_96523(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,96540,96572);

f_22078_96540_96571(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,96588,97494);

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

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,97508,97572);

f_22078_97508_97571(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,96041,97583);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,96041,97583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,96041,97583);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_22()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,97595,98969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,97739,97958);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        int i = 3;
        try
        {}
        finally
        {}
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,97974,98018);

var 
compilation = f_22078_97992_98017(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,98034,98066);

f_22078_98034_98065(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,98082,98880);

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
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 3')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 3')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,98894,98958);

f_22078_98894_98957(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,97595,98969);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,97595,98969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,97595,98969);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_23()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,98981,101081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,99125,99432);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        {
            int i = 3;
            try
            {}
            finally
            {}
        }
        {
            int j = 4;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,99448,99492);

var 
compilation = f_22078_99466_99491(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,99508,99540);

f_22078_99508_99539(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,99556,100992);

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
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 3')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 3')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B2]
            Leaving: {R1}
            Entering: {R2}
}
.locals {R2}
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'j = 4')
              Left: 
                ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'j = 4')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B3]
            Leaving: {R2}
}

Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,101006,101070);

f_22078_101006_101069(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,98981,101081);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,98981,101081);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,98981,101081);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_24()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,101093,102685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,101237,101566);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        try
        {
            int i;
            i = 1;
        }
        finally
        {
            try
            {}
            finally
            {}
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,101582,101626);

var 
compilation = f_22078_101600_101625(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,101642,101674);

f_22078_101642_101673(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,101690,102596);

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

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,102610,102674);

f_22078_102610_102673(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,101093,102685);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,101093,102685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,101093,102685);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_25()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,102697,110257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,102841,103444);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F(int p)
    /*<bind>*/{
        p = 1;
        {
            int a = 2;
        }
        p = 3;
        try
        {
            {
                int i;
                i = 4;
            }
            p = 5;
            {
                int j;
                j = 6;
            }
        }
        finally
        {
        }
        p = 7;
        {
            int b = 8;
        }
        p = 9;
        {
            int c = 10;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,103460,103504);

var 
compilation = f_22078_103478_103503(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,103520,103552);

f_22078_103520_103551(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,103568,110168);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = 1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = 1')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B2]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 a]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 2')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 2')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Block
    Predecessors: [B2]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = 3;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = 3')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

    Next (Regular) Block[B4]
        Entering: {R2}

.locals {R2}
{
    Locals: [System.Int32 i]
    Block[B4] - Block
        Predecessors: [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = 4;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = 4')
                  Left: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B5]
            Leaving: {R2}
}

Block[B5] - Block
    Predecessors: [B4]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = 5;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = 5')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

    Next (Regular) Block[B6]
        Entering: {R3}

.locals {R3}
{
    Locals: [System.Int32 j]
    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = 6;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = 6')
                  Left: 
                    ILocalReferenceOperation: j (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6) (Syntax: '6')

        Next (Regular) Block[B7]
            Leaving: {R3}
}

Block[B7] - Block
    Predecessors: [B6]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = 7;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = 7')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 7) (Syntax: '7')

    Next (Regular) Block[B8]
        Entering: {R4}

.locals {R4}
{
    Locals: [System.Int32 b]
    Block[B8] - Block
        Predecessors: [B7]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = 8')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = 8')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8) (Syntax: '8')

        Next (Regular) Block[B9]
            Leaving: {R4}
}

Block[B9] - Block
    Predecessors: [B8]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = 9;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = 9')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')

    Next (Regular) Block[B10]
        Entering: {R5}

.locals {R5}
{
    Locals: [System.Int32 c]
    Block[B10] - Block
        Predecessors: [B9]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'c = 10')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'c = 10')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')

        Next (Regular) Block[B11]
            Leaving: {R5}
}

Block[B11] - Exit
    Predecessors: [B10]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,110182,110246);

f_22078_110182_110245(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,102697,110257);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,102697,110257);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,102697,110257);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_26()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,110269,112571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,110413,110701);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        try
        {
            int i = 1;
            return;
        }
        finally
        {
            int j = 2;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,110717,110761);

var 
compilation = f_22078_110735_110760(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,110777,110809);

f_22078_110777_110808(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,110825,112482);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    .locals {R4}
    {
        Locals: [System.Int32 j]
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'j = 2')
                  Left: 
                    ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'j = 2')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            Next (Regular) Block[B3]
                Leaving: {R4}
    }

    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Next (StructuredExceptionHandling) Block[null]
}

Block[B4] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,112496,112560);

f_22078_112496_112559(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,110269,112571);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,110269,112571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,110269,112571);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_27()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,112583,114927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,112727,113015);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        try
        {
            int i = 1;
        }
        finally
        {
            int j = 2;
            return;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,113031,113075);

var 
compilation = f_22078_113049_113074(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,113091,113364);

f_22078_113091_113363(
            compilation, f_22078_113272_113344(f_22078_113272_113323(ErrorCode.ERR_BadFinallyLeave, "return"), 15, 13));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,113380,114838);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'j = 2')
              Left: 
                ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'j = 2')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,114852,114916);

f_22078_114852_114915(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,112583,114927);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,112583,114927);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,112583,114927);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_28()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,114939,117024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,115083,115369);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        try
        {
            int i = 1;
        }
        catch
        {
            int j = 2;
            return;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,115385,115429);

var 
compilation = f_22078_115403_115428(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,115445,115477);

f_22078_115445_115476(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,115493,116935);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'j = 2')
              Left: 
                ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'j = 2')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,116949,117013);

f_22078_116949_117012(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,114939,117024);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,114939,117024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,114939,117024);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_29()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,117036,118495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,117180,117484);

var 
source = @"
#pragma warning disable CS0168
#pragma warning disable CS0219
class C
{
    void F()
    /*<bind>*/{
        try
        {
            int i = 1;
        }
        finally
        {
            int j;
            goto label1;
label1:     ;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,117500,117544);

var 
compilation = f_22078_117518_117543(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,117560,117592);

f_22078_117560_117591(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,117608,118406);

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
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
              Left: 
                ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'i = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,118420,118484);

f_22078_118420_118483(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,117036,118495);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,117036,118495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,117036,118495);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TryFlow_30()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,118505,120017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,118649,118804);

var 
source = @"
class C
{
    void F(bool result)
    /*<bind>*/{
        try
        {
            result = true;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,118820,118864);

var 
compilation = f_22078_118838_118863(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,118880,119109);

f_22078_118880_119108(
            compilation, f_22078_119025_119089(f_22078_119025_119070(ErrorCode.ERR_ExpectedEndTry, "}"), 9, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,119125,119928);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = true')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,119942,120006);

f_22078_119942_120005(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,118505,120017);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,118505,120017);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,118505,120017);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,120029,122132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,120183,120444);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,120458,121944);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,121958,122011);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,122027,122121);

f_22078_122027_122120(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,120029,122132);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,120029,122132);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,120029,122132);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,122144,124176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,122298,122571);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            if (ThisCanThrow()) return;
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,122585,123988);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
              Instance Receiver: 
                null
              Arguments(0)
            Leaving: {R2} {R1}

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1*2] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,124002,124055);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,124071,124165);

f_22078_124071_124164(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,122144,124176);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,122144,124176);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,122144,124176);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,124188,126357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,124342,124635);

string 
source = @"
class P
{
    bool M(bool b)
/*<bind>*/{
        try
        {
            return ThisCanThrow();
        }
        catch
        {
            b = true;
        }

        return false;
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,124649,126169);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Return) Block[B4]
            IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
              Instance Receiver: 
                null
              Arguments(0)
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Block
    Predecessors: [B2]
    Statements (0)
    Next (Return) Block[B4]
        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,126183,126236);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,126252,126346);

f_22078_126252_126345(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,124188,126357);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,124188,126357);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,124188,126357);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,126369,128474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,126523,126731);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            throw null;
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,126745,128286);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}
.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
                Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                    Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                    Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}
Block[B3] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,128300,128353);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,128369,128463);

f_22078_128369_128462(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,126369,128474);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,126369,128474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,126369,128474);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,128486,130903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,128640,128858);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            if (true) throw null;
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,128872,130715);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}
.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Leaving: {R2} {R1}
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
}
.catch {R3} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                    Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                    Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B4]
            Leaving: {R3} {R1}
}
Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,130729,130782);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,130798,130892);

f_22078_130798_130891(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,128486,130903);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,128486,130903);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,128486,130903);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,130915,133349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,131069,131288);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            if (false) throw null;
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,131302,133161);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}
.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Leaving: {R2} {R1}
        Next (Regular) Block[B2]
    Block[B2] - Block [UnReachable]
        Predecessors: [B1]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
                Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
}
.catch {R3} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                    Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                    Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B4]
            Leaving: {R3} {R1}
}
Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,133175,133228);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,133244,133338);

f_22078_133244_133337(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,130915,133349);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,130915,133349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,130915,133349);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,133361,136078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,133515,133910);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch
        {
            try
            {
                if (true) throw;
            }
            catch
            {
                b = true;
            }
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,133924,135890);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .try {R4, R5}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B4]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Leaving: {R5} {R4} {R3} {R1}

            Next (Rethrow) Block[null]
    }
    .catch {R6} (System.Object)
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B4]
                Leaving: {R6} {R4} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,135904,135957);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,135973,136067);

f_22078_135973_136066(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,133361,136078);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,133361,136078);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,133361,136078);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,136090,138810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,136244,136640);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch
        {
            try
            {
                if (false) throw;
            }
            catch
            {
                b = true;
            }
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,136654,138622);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .try {R4, R5}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B4]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                Leaving: {R5} {R4} {R3} {R1}

            Next (Rethrow) Block[null]
    }
    .catch {R6} (System.Object)
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                      Left: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B4]
                Leaving: {R6} {R4} {R3} {R1}
    }
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,138636,138689);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,138705,138799);

f_22078_138705_138798(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,136090,138810);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,136090,138810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,136090,138810);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,138822,141364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,138976,139265);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
            if (false) return;
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool[] ThisCanThrow() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,139279,140963);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean[] P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Jump if False (Regular) to Block[B3]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Leaving: {R2} {R1}

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1*2] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,140977,141243);

var 
expectedDiagnostics = new[] {
f_22078_141156_141227(f_22078_141156_141207(ErrorCode.WRN_UnreachableCode, "return"), 9, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,141259,141353);

f_22078_141259_141352(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,138822,141364);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,138822,141364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,138822,141364);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,141376,143702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,141530,141818);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
            if (true) return;
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool[] ThisCanThrow() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,141832,143514);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean[] P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Jump if False (Regular) to Block[B3]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Leaving: {R2} {R1}

        Next (Regular) Block[B3]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B3]
            Leaving: {R3} {R1}
}

Block[B3] - Exit
    Predecessors: [B1*2] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,143528,143581);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,143597,143691);

f_22078_143597_143690(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,141376,143702);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,141376,143702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,141376,143702);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,143714,146552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,143868,144168);

string 
source = @"
class P
{
    bool[] M(bool b)
/*<bind>*/{
        try
        {
            if (true) return ThisCanThrow();
        }
        catch
        {
            b = true;
        }

        return null;
    }/*</bind>*/

    static bool[] ThisCanThrow() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,144182,146364);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Leaving: {R2} {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Next (Return) Block[B5]
            IInvocationOperation (System.Boolean[] P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'ThisCanThrow()')
              Instance Receiver: 
                null
              Arguments(0)
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R3} {R1}
}

Block[B4] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Next (Return) Block[B5]
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean[], Constant: null, IsImplicit) (Syntax: 'null')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            (ImplicitReference)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
Block[B5] - Exit
    Predecessors: [B2] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,146378,146431);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,146447,146541);

f_22078_146447_146540(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,143714,146552);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,143714,146552);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,143714,146552);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,146564,149647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,146718,147019);

string 
source = @"
class P
{
    bool[] M(bool b)
/*<bind>*/{
        try
        {
            if (false) return ThisCanThrow();
        }
        catch
        {
            b = true;
        }

        return null;
    }/*</bind>*/

    static bool[] ThisCanThrow() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,147033,149231);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Leaving: {R2} {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block [UnReachable]
        Predecessors: [B1]
        Statements (0)
        Next (Return) Block[B5]
            IInvocationOperation (System.Boolean[] P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'ThisCanThrow()')
              Instance Receiver: 
                null
              Arguments(0)
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R3} {R1}
}

Block[B4] - Block
    Predecessors: [B1] [B3]
    Statements (0)
    Next (Return) Block[B5]
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean[], Constant: null, IsImplicit) (Syntax: 'null')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            (ImplicitReference)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
Block[B5] - Exit
    Predecessors: [B2] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,149245,149526);

var 
expectedDiagnostics = new[] {
f_22078_149439_149510(f_22078_149439_149490(ErrorCode.WRN_UnreachableCode, "return"), 8, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,149542,149636);

f_22078_149542_149635(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,146564,149647);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,146564,149647);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,146564,149647);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,149659,152173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,149813,150176);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
            }
            finally
            {
                ThisCanThrow();
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,150190,151985);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Next (Regular) Block[B4]
                Finalizing: {R5}
                Leaving: {R4} {R3} {R2} {R1}
    }
    .finally {R5}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (StructuredExceptionHandling) Block[null]
    }
}
.catch {R6} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R6} {R1}
}

Block[B4] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,151999,152052);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,152068,152162);

f_22078_152068_152161(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,149659,152173);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,149659,152173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,149659,152173);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,152185,154706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,152339,152700);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,152714,154518);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R2} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R6} {R1}
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,154532,154585);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,154601,154695);

f_22078_154601_154694(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,152185,154706);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,152185,154706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,152185,154706);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,154718,158032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,154872,155245);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch when (true)
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,155259,157584);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        .filter {R6}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B3]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                    Leaving: {R6}
                    Entering: {R7}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R7}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Next (Regular) Block[B5]
                    Leaving: {R7} {R5} {R3} {R2} {R1}
        }
    }
}
.catch {R8} (System.Object)
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R8} {R1}
}

Block[B5] - Exit
    Predecessors: [B1] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,157598,157911);

var 
expectedDiagnostics = new[] {
f_22078_157820_157895(f_22078_157820_157874(ErrorCode.WRN_FilterIsConstantTrue, "true"), 12, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,157927,158021);

f_22078_157927_158020(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,154718,158032);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,154718,158032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,154718,158032);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,158044,161405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,158198,158572);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch when (false)
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,158586,160927);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        .filter {R6}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B3]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                    Leaving: {R6}
                    Entering: {R7}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R7}
        {
            Block[B3] - Block [UnReachable]
                Predecessors: [B2]
                Statements (0)
                Next (Regular) Block[B5]
                    Leaving: {R7} {R5} {R3} {R2} {R1}
        }
    }
}
.catch {R8} (System.Object)
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R8} {R1}
}

Block[B5] - Exit
    Predecessors: [B1] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,160941,161284);

var 
expectedDiagnostics = new[] {
f_22078_161174_161268(f_22078_161174_161247(ErrorCode.WRN_FilterIsConstantFalseRedundantTryCatch, "false"), 12, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,161300,161394);

f_22078_161300_161393(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,158044,161405);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,158044,161405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,158044,161405);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,161417,164624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,161571,161954);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch when (ThisCanThrow())
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,161968,164436);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        .filter {R6}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B3]
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                    Leaving: {R6}
                    Entering: {R7}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R7}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Next (Regular) Block[B5]
                    Leaving: {R7} {R5} {R3} {R2} {R1}
        }
    }
}
.catch {R8} (System.Object)
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R8} {R1}
}

Block[B5] - Exit
    Predecessors: [B1] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,164450,164503);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,164519,164613);

f_22078_164519_164612(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,161417,164624);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,161417,164624);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,161417,164624);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,164636,168241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,164790,165181);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch when (ThisCanThrow() || true)
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,165195,168053);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B6]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        .filter {R6}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B4]
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                    Leaving: {R6}
                    Entering: {R7}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Jump if True (Regular) to Block[B4]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                    Leaving: {R6}
                    Entering: {R7}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R7}
        {
            Block[B4] - Block
                Predecessors: [B2] [B3]
                Statements (0)
                Next (Regular) Block[B6]
                    Leaving: {R7} {R5} {R3} {R2} {R1}
        }
    }
}
.catch {R8} (System.Object)
{
    Block[B5] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B6]
            Leaving: {R8} {R1}
}

Block[B6] - Exit
    Predecessors: [B1] [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,168067,168120);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,168136,168230);

f_22078_168136_168229(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,164636,168241);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,164636,168241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,164636,168241);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,168253,171872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,168407,168798);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch when (true || ThisCanThrow())
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,168812,171684);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B6]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        .filter {R6}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B4]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                    Leaving: {R6}
                    Entering: {R7}

                Next (Regular) Block[B3]
            Block[B3] - Block [UnReachable]
                Predecessors: [B2]
                Statements (0)
                Jump if True (Regular) to Block[B4]
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                    Leaving: {R6}
                    Entering: {R7}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R7}
        {
            Block[B4] - Block
                Predecessors: [B2] [B3]
                Statements (0)
                Next (Regular) Block[B6]
                    Leaving: {R7} {R5} {R3} {R2} {R1}
        }
    }
}
.catch {R8} (System.Object)
{
    Block[B5] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B6]
            Leaving: {R8} {R1}
}

Block[B6] - Exit
    Predecessors: [B1] [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,171698,171751);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,171767,171861);

f_22078_171767_171860(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,168253,171872);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,168253,171872);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,168253,171872);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,171884,175577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,172038,172430);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch when (ThisCanThrow() && false)
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,172444,175389);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B7]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        .filter {R6}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Jump if False (Regular) to Block[B4]
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Jump if True (Regular) to Block[B5]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                    Leaving: {R6}
                    Entering: {R7}

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B2] [B3]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R7}
        {
            Block[B5] - Block [UnReachable]
                Predecessors: [B3]
                Statements (0)
                Next (Regular) Block[B7]
                    Leaving: {R7} {R5} {R3} {R2} {R1}
        }
    }
}
.catch {R8} (System.Object)
{
    Block[B6] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B7]
            Leaving: {R8} {R1}
}

Block[B7] - Exit
    Predecessors: [B1] [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,175403,175456);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,175472,175566);

f_22078_175472_175565(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,171884,175577);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,171884,175577);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,171884,175577);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_21()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,175589,179296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,175743,176135);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch when (false && ThisCanThrow())
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,176149,179108);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B7]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        .filter {R6}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Jump if False (Regular) to Block[B4]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

                Next (Regular) Block[B3]
            Block[B3] - Block [UnReachable]
                Predecessors: [B2]
                Statements (0)
                Jump if True (Regular) to Block[B5]
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                    Leaving: {R6}
                    Entering: {R7}

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B2] [B3]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R7}
        {
            Block[B5] - Block [UnReachable]
                Predecessors: [B3]
                Statements (0)
                Next (Regular) Block[B7]
                    Leaving: {R7} {R5} {R3} {R2} {R1}
        }
    }
}
.catch {R8} (System.Object)
{
    Block[B6] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B7]
            Leaving: {R8} {R1}
}

Block[B7] - Exit
    Predecessors: [B1] [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,179122,179175);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,179191,179285);

f_22078_179191_179284(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,175589,179296);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,175589,179296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,175589,179296);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_22()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,179308,181865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,179462,179760);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,179774,181439);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Next (Regular) Block[B4]
            Leaving: {R3} {R1}
}
.catch {R4} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R4} {R1}
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,181453,181744);

var 
expectedDiagnostics = new[] {
f_22078_181659_181728(f_22078_181659_181708(ErrorCode.ERR_TooManyCatches, "catch"), 13, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,181760,181854);

f_22078_181760_181853(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,179308,181865);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,179308,181865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,179308,181865);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_23()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,181877,184929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,182031,182341);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch when (true)
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,182355,184485);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B5]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Regular) Block[B5]
                Leaving: {R5} {R3} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R6} {R1}
}

Block[B5] - Exit
    Predecessors: [B1] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,184499,184808);

var 
expectedDiagnostics = new[] {
f_22078_184717_184792(f_22078_184717_184771(ErrorCode.WRN_FilterIsConstantTrue, "true"), 10, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,184824,184918);

f_22078_184824_184917(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,181877,184929);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,181877,184929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,181877,184929);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_24()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,184941,188020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,185095,185406);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch when (false)
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,185420,187566);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B5]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B3] - Block [UnReachable]
            Predecessors: [B2]
            Statements (0)
            Next (Regular) Block[B5]
                Leaving: {R5} {R3} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R6} {R1}
}

Block[B5] - Exit
    Predecessors: [B1] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,187580,187899);

var 
expectedDiagnostics = new[] {
f_22078_187806_187883(f_22078_187806_187862(ErrorCode.WRN_FilterIsConstantFalse, "false"), 10, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,187915,188009);

f_22078_187915_188008(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,184941,188020);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,184941,188020);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,184941,188020);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_25()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,188032,190969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,188186,188506);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch when (ThisCanThrow())
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,188520,190781);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B5]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Regular) Block[B5]
                Leaving: {R5} {R3} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R6} {R1}
}

Block[B5] - Exit
    Predecessors: [B1] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,190795,190848);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,190864,190958);

f_22078_190864_190957(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,188032,190969);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,188032,190969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,188032,190969);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_26()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,190981,194458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,191135,191567);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch when (ThisCanThrow())
            {
            }
            catch
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,191581,194270);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B6]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        .filter {R6}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Jump if True (Regular) to Block[B3]
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                    Leaving: {R6}
                    Entering: {R7}

                Next (StructuredExceptionHandling) Block[null]
        }
        .handler {R7}
        {
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Next (Regular) Block[B6]
                    Leaving: {R7} {R5} {R3} {R2} {R1}
        }
    }
    .catch {R8} (System.Object)
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Next (Regular) Block[B6]
                Leaving: {R8} {R3} {R2} {R1}
    }
}
.catch {R9} (System.Object)
{
    Block[B5] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B6]
            Leaving: {R9} {R1}
}

Block[B6] - Exit
    Predecessors: [B1] [B3] [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,194284,194337);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,194353,194447);

f_22078_194353_194446(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,190981,194458);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,190981,194458);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,190981,194458);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_27()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,194470,197773);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,194624,194952);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch when (ThisCanThrow() || true)
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,194966,197585);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B6]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B4]
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)
                Leaving: {R4}
                Entering: {R5}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if True (Regular) to Block[B4]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (0)
            Next (Regular) Block[B6]
                Leaving: {R5} {R3} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B5] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B6]
            Leaving: {R6} {R1}
}

Block[B6] - Exit
    Predecessors: [B1] [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,197599,197652);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,197668,197762);

f_22078_197668_197761(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,194470,197773);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,194470,197773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,194470,197773);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_28()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,197785,201102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,197939,198267);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch when (true || ThisCanThrow())
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,198281,200914);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B6]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B4]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Leaving: {R4}
                Entering: {R5}

            Next (Regular) Block[B3]
        Block[B3] - Block [UnReachable]
            Predecessors: [B2]
            Statements (0)
            Jump if True (Regular) to Block[B4]
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (0)
            Next (Regular) Block[B6]
                Leaving: {R5} {R3} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B5] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B6]
            Leaving: {R6} {R1}
}

Block[B6] - Exit
    Predecessors: [B1] [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,200928,200981);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,200997,201091);

f_22078_200997_201090(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,197785,201102);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,197785,201102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,197785,201102);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_29()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,201114,204497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,201268,201597);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch when (ThisCanThrow() && false)
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,201611,204309);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B7]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if True (Regular) to Block[B5]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                Leaving: {R4}
                Entering: {R5}

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B5] - Block [UnReachable]
            Predecessors: [B3]
            Statements (0)
            Next (Regular) Block[B7]
                Leaving: {R5} {R3} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B6] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B7]
            Leaving: {R6} {R1}
}

Block[B7] - Exit
    Predecessors: [B1] [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,204323,204376);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,204392,204486);

f_22078_204392_204485(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,201114,204497);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,201114,204497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,201114,204497);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_30()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,204509,207906);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,204663,204992);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch when (false && ThisCanThrow())
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,205006,207718);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B7]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B4]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B3]
        Block[B3] - Block [UnReachable]
            Predecessors: [B2]
            Statements (0)
            Jump if True (Regular) to Block[B5]
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)
                Leaving: {R4}
                Entering: {R5}

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B2] [B3]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B5] - Block [UnReachable]
            Predecessors: [B3]
            Statements (0)
            Next (Regular) Block[B7]
                Leaving: {R5} {R3} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B6] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B7]
            Leaving: {R6} {R1}
}

Block[B7] - Exit
    Predecessors: [B1] [B5] [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,207732,207785);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,207801,207895);

f_22078_207801_207894(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,204509,207906);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,204509,207906);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,204509,207906);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_31()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,207918,210890);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,208072,208466);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch
            {
                ThisCanThrow();
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,208480,210702);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R2} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R6} {R1}
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,210716,210769);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,210785,210879);

f_22078_210785_210878(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,207918,210890);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,207918,210890);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,207918,210890);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,210902,214540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,211056,211417);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch (System.NullReferenceException e)
        {
            ThisCanThrow();
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,211431,214088);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
            Leaving: {R2} {R1}
}
.catch {R3} (System.NullReferenceException)
{
    Locals: [System.NullReferenceException e]
    Block[B2] - Block
        Predecessors (0)
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(System.Nul ... xception e)')
              Left: 
                ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: System.NullReferenceException, IsImplicit) (Syntax: '(System.Nul ... xception e)')
              Right: 
                ICaughtExceptionOperation (OperationKind.CaughtException, Type: System.NullReferenceException, IsImplicit) (Syntax: '(System.Nul ... xception e)')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
            Leaving: {R3} {R1}
}
.catch {R4} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R4} {R1}
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,214102,214419);

var 
expectedDiagnostics = new[] {
f_22078_214317_214403(f_22078_214317_214382(f_22078_214317_214363(ErrorCode.WRN_UnreferencedVar, "e"), "e"), 10, 46)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,214435,214529);

f_22078_214435_214528(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,210902,214540);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,210902,214540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,210902,214540);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_33()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,214552,217997);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,214706,215101);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            try
            {
                ThisCanThrow();
            }
            catch (System.NullReferenceException e)
            {
            }
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,215115,217541);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.NullReferenceException)
    {
        Locals: [System.NullReferenceException e]
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(System.Nul ... xception e)')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: System.NullReferenceException, IsImplicit) (Syntax: '(System.Nul ... xception e)')
                  Right: 
                    ICaughtExceptionOperation (OperationKind.CaughtException, Type: System.NullReferenceException, IsImplicit) (Syntax: '(System.Nul ... xception e)')

            Next (Regular) Block[B4]
                Leaving: {R5} {R3} {R2} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B3] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B4]
            Leaving: {R6} {R1}
}

Block[B4] - Exit
    Predecessors: [B1] [B2] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,217555,217876);

var 
expectedDiagnostics = new[] {
f_22078_217774_217860(f_22078_217774_217839(f_22078_217774_217820(ErrorCode.WRN_UnreferencedVar, "e"), "e"), 12, 50)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,217892,217986);

f_22078_217892_217985(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,214552,217997);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,214552,217997);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,214552,217997);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_34()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,218009,219981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,218163,218360);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
        }
        finally
        {
            if (true) throw null;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,218374,219793);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}
.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B5]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Jump if False (Regular) to Block[B4]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
                Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B4] - Block [UnReachable]
        Predecessors: [B2]
        Statements (0)
        Next (StructuredExceptionHandling) Block[null]
}
Block[B5] - Exit [UnReachable]
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,219807,219860);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,219876,219970);

f_22078_219876_219969(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,218009,219981);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,218009,219981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,218009,219981);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_35()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,219993,221954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,220147,220345);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
        }
        finally
        {
            if (false) throw null;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,220359,221766);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}
.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B5]
            Finalizing: {R3}
            Leaving: {R2} {R1}
}
.finally {R3}
{
    Block[B2] - Block
        Predecessors (0)
        Statements (0)
        Jump if False (Regular) to Block[B4]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
        Next (Regular) Block[B3]
    Block[B3] - Block [UnReachable]
        Predecessors: [B2]
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
        Next (StructuredExceptionHandling) Block[null]
}
Block[B5] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,221780,221833);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,221849,221943);

f_22078_221849_221942(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,219993,221954);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,219993,221954);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,219993,221954);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_36()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,221966,224061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,222120,222314);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
        }
        finally
        {
            if (b) throw null;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,222328,223873);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2}
    .try {R1, R2}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Next (Regular) Block[B5]
                Finalizing: {R3}
                Leaving: {R2} {R1}
    }
    .finally {R3}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
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
            Next (StructuredExceptionHandling) Block[null]
    }
    Block[B5] - Exit
        Predecessors: [B1]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,223887,223940);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,223956,224050);

f_22078_223956_224049(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,221966,224061);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,221966,224061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,221966,224061);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_37()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,224073,226220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,224227,224465);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
        }
        finally
        {
            if (true) goto label1;
            throw null;
label1:     ;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,224479,226032);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2}
    .try {R1, R2}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Next (Regular) Block[B5]
                Finalizing: {R3}
                Leaving: {R2} {R1}
    }
    .finally {R3}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B3]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
            Next (Regular) Block[B4]
        Block[B3] - Block [UnReachable]
            Predecessors: [B2]
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
            Next (StructuredExceptionHandling) Block[null]
    }
    Block[B5] - Exit
        Predecessors: [B1]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,226046,226099);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,226115,226209);

f_22078_226115_226208(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,224073,226220);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,224073,226220);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,224073,226220);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_38()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,226232,228815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,226386,226625);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
        }
        finally
        {
            if (false) goto label1;
            throw null;
label1:     ;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,226639,228208);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2}
    .try {R1, R2}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Next (Regular) Block[B5]
                Finalizing: {R3}
                Leaving: {R2} {R1}
    }
    .finally {R3}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Regular) to Block[B3]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
            Next (Regular) Block[B4]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Throw) Block[null]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        Block[B4] - Block [UnReachable]
            Predecessors: [B2]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
    Block[B5] - Exit [UnReachable]
        Predecessors: [B1]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,228222,228694);

var 
expectedDiagnostics = new[] {
f_22078_228407_228477(f_22078_228407_228456(ErrorCode.WRN_UnreachableCode, "goto"), 11, 24),
f_22078_228607_228678(f_22078_228607_228658(ErrorCode.WRN_UnreachableCode, "label1"), 13, 1)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,228710,228804);

f_22078_228710_228803(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,226232,228815);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,226232,228815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,226232,228815);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_39()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,228827,233121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,228981,229467);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch
        {
            try
            {
                ThisCanThrow();
            }
            finally
            {
                if (false) goto label1;
                throw;
    label1:     ;
            }

            b = false;
        }       
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,229481,231981);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B5]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Object)
{
    .try {R4, R5}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
                  Expression: 
                    IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Next (Regular) Block[B4]
                Finalizing: {R6}
                Leaving: {R5} {R4}
    }
    .finally {R6}
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (0)
            Jump if False (Rethrow) to Block[null]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (StructuredExceptionHandling) Block[null]
    }

    Block[B4] - Block [UnReachable]
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = false')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B5]
            Leaving: {R3} {R1}
}

Block[B5] - Exit
    Predecessors: [B1] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,231995,233000);

var 
expectedDiagnostics = new[] {
f_22078_232267_232345(f_22078_232267_232324(ErrorCode.ERR_BadEmptyThrowInFinally, "throw"), 19, 17),
f_22078_232502_232572(f_22078_232502_232551(ErrorCode.WRN_UnreachableCode, "goto"), 18, 28),
f_22078_232706_232777(f_22078_232706_232757(ErrorCode.WRN_UnreachableCode, "label1"), 20, 5),
f_22078_232917_232984(f_22078_232917_232963(ErrorCode.WRN_UnreachableCode, "b"), 23, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,233016,233110);

f_22078_233016_233109(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,228827,233121);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,228827,233121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,228827,233121);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_40()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,233133,236265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,233287,233629);

string 
source = @"
class P
{
    void M(bool b)
/*<bind>*/{
        try
        {
            ThisCanThrow();
        }
        catch (System.NullReferenceException) when (true)
        {
        }
        catch
        {
            b = true;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,233643,235789);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ThisCanThrow();')
              Expression: 
                IInvocationOperation (System.Boolean P.ThisCanThrow()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'ThisCanThrow()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B5]
            Leaving: {R2} {R1}
}
.catch {R3} (System.NullReferenceException)
{
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (0)
            Jump if True (Regular) to Block[B3]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Leaving: {R4}
                Entering: {R5}

            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R5}
    {
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Next (Regular) Block[B5]
                Leaving: {R5} {R3} {R1}
    }
}
.catch {R6} (System.Object)
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = true;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = true')
                  Left: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B5]
            Leaving: {R6} {R1}
}

Block[B5] - Exit
    Predecessors: [B1] [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,235803,236144);

var 
expectedDiagnostics = new[] {
f_22078_236053_236128(f_22078_236053_236107(ErrorCode.WRN_FilterIsConstantTrue, "true"), 10, 53)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,236160,236254);

f_22078_236160_236253(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,233133,236265);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,233133,236265);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,233133,236265);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_41()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,236277,240533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,236431,236834);

string 
source = @"
class P
{
    void M(int x)
/*<bind>*/{
        try
        {
            try
            {
                throw null;
            }
            finally
            {
                x = 1;
            }

            x = 2;
        }
        finally
        {
            x = 3;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,236848,240147);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2} {R3} {R4}
    .try {R1, R2}
    {
        .try {R3, R4}
        {
            Block[B1] - Block
                Predecessors: [B0]
                Statements (0)
                Next (Throw) Block[null]
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        }
        .finally {R5}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (1)
                    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
                      Expression: 
                        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                          Left: 
                            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Next (StructuredExceptionHandling) Block[null]
        }
        Block[B3] - Block [UnReachable]
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            Next (Regular) Block[B5]
                Finalizing: {R6}
                Leaving: {R2} {R1}
    }
    .finally {R6}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 3;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 3')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Next (StructuredExceptionHandling) Block[null]
    }
    Block[B5] - Exit [UnReachable]
        Predecessors: [B3]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,240161,240412);

var 
expectedDiagnostics = new[] {
f_22078_240329_240396(f_22078_240329_240375(ErrorCode.WRN_UnreachableCode, "x"), 17, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,240428,240522);

f_22078_240428_240521(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,236277,240533);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,236277,240533);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,236277,240533);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_42()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,240545,244712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,240699,241107);

string 
source = @"
class P
{
    void M(int x)
/*<bind>*/{
        try
        {
            try
            {
                throw null;
            }
            finally
            {
                throw null;
            }

            x = 2;
        }
        finally
        {
            x = 3;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,241121,244326);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2} {R3} {R4}
    .try {R1, R2}
    {
        .try {R3, R4}
        {
            Block[B1] - Block
                Predecessors: [B0]
                Statements (0)
                Next (Throw) Block[null]
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        }
        .finally {R5}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Next (Throw) Block[null]
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        }
        Block[B3] - Block [UnReachable]
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            Next (Regular) Block[B5]
                Finalizing: {R6}
                Leaving: {R2} {R1}
    }
    .finally {R6}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 3;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 3')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Next (StructuredExceptionHandling) Block[null]
    }
    Block[B5] - Exit [UnReachable]
        Predecessors: [B3]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,244340,244591);

var 
expectedDiagnostics = new[] {
f_22078_244508_244575(f_22078_244508_244554(ErrorCode.WRN_UnreachableCode, "x"), 17, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,244607,244701);

f_22078_244607_244700(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,240545,244712);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,240545,244712);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,240545,244712);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_43()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,244724,248724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,244878,245290);

string 
source = @"
class P
{
    void M(int x)
/*<bind>*/{
        try
        {
            try
            {
                throw null;
            }
            finally
            {
                while (true) {}
            }

            x = 2;
        }
        finally
        {
            x = 3;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,245304,248338);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2} {R3} {R4}
    .try {R1, R2}
    {
        .try {R3, R4}
        {
            Block[B1] - Block
                Predecessors: [B0]
                Statements (0)
                Next (Throw) Block[null]
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        }
        .finally {R5}
        {
            Block[B2] - Block
                Predecessors: [B2]
                Statements (0)
                Jump if False (Regular) to Block[B3]
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Next (Regular) Block[B2]
            Block[B3] - Block [UnReachable]
                Predecessors: [B2]
                Statements (0)
                Next (StructuredExceptionHandling) Block[null]
        }
        Block[B4] - Block [UnReachable]
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            Next (Regular) Block[B6]
                Finalizing: {R6}
                Leaving: {R2} {R1}
    }
    .finally {R6}
    {
        Block[B5] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 3;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 3')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Next (StructuredExceptionHandling) Block[null]
    }
    Block[B6] - Exit [UnReachable]
        Predecessors: [B4]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,248352,248603);

var 
expectedDiagnostics = new[] {
f_22078_248520_248587(f_22078_248520_248566(ErrorCode.WRN_UnreachableCode, "x"), 17, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,248619,248713);

f_22078_248619_248712(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,244724,248724);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,244724,248724);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,244724,248724);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ExceptionDispatch_44()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,248736,251680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,248890,249318);

string 
source = @"
class P
{
    void M()
/*<bind>*/{
        try
        {
            try
            {
                try
                {
                }
                finally
                {
                    return;
                }
            }
            catch
            {
            }
        }
        finally
        {
            throw null;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,249332,251258);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2} {R3} {R4} {R5} {R6}
    .try {R1, R2}
    {
        .try {R3, R4}
        {
            .try {R5, R6}
            {
                Block[B1] - Block
                    Predecessors: [B0]
                    Statements (0)
                    Next (Regular) Block[B5]
                        Finalizing: {R7} {R9}
                        Leaving: {R6} {R5} {R4} {R3} {R2} {R1}
            }
            .finally {R7}
            {
                Block[B2] - Block
                    Predecessors (0)
                    Statements (0)
                    Next (Regular) Block[B5]
                        Finalizing: {R9}
                        Leaving: {R7} {R5} {R4} {R3} {R2} {R1}
            }
        }
        .catch {R8} (System.Object)
        {
            Block[B3] - Block
                Predecessors (0)
                Statements (0)
                Next (Regular) Block[B5]
                    Finalizing: {R9}
                    Leaving: {R8} {R3} {R2} {R1}
        }
    }
    .finally {R9}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (0)
            Next (Throw) Block[null]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    }
    Block[B5] - Exit [UnReachable]
        Predecessors: [B1] [B2] [B3]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,251272,251559);

var 
expectedDiagnostics = new[] {
f_22078_251471_251543(f_22078_251471_251522(ErrorCode.ERR_BadFinallyLeave, "return"), 15, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,251575,251669);

f_22078_251575_251668(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,248736,251680);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,248736,251680);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,248736,251680);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FinallyDispatch_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,251692,255276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,251844,252243);

string 
source = @"
class P
{
    void M(int x)
/*<bind>*/{
        try
        {
            try
            {
                return;
            }
            finally
            {
                x = 1;
            }

            x = 2;
        }
        finally
        {
            x = 3;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,252257,254890);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Next (Regular) Block[B5]
                Finalizing: {R5} {R6}
                Leaving: {R4} {R3} {R2} {R1}
    }
    .finally {R5}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 1;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 1')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (StructuredExceptionHandling) Block[null]
    }

    Block[B3] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B5]
            Finalizing: {R6}
            Leaving: {R2} {R1}
}
.finally {R6}
{
    Block[B4] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 3;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 3')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (StructuredExceptionHandling) Block[null]
}

Block[B5] - Exit
    Predecessors: [B1] [B3]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,254904,255155);

var 
expectedDiagnostics = new[] {
f_22078_255072_255139(f_22078_255072_255118(ErrorCode.WRN_UnreachableCode, "x"), 17, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,255171,255265);

f_22078_255171_255264(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,251692,255276);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,251692,255276);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,251692,255276);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FinallyDispatch_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,255288,259025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,255440,255844);

string 
source = @"
class P
{
    void M(int x)
/*<bind>*/{
        try
        {
            try
            {
                return;
            }
            finally
            {
                throw null;
            }

            x = 2;
        }
        finally
        {
            x = 3;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,255858,258639);

string 
expectedGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2} {R3} {R4}
    .try {R1, R2}
    {
        .try {R3, R4}
        {
            Block[B1] - Block
                Predecessors: [B0]
                Statements (0)
                Next (Regular) Block[B5]
                    Finalizing: {R5} {R6}
                    Leaving: {R4} {R3} {R2} {R1}
        }
        .finally {R5}
        {
            Block[B2] - Block
                Predecessors (0)
                Statements (0)
                Next (Throw) Block[null]
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitReference)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
        }
        Block[B3] - Block [UnReachable]
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            Next (Regular) Block[B5]
                Finalizing: {R6}
                Leaving: {R2} {R1}
    }
    .finally {R6}
    {
        Block[B4] - Block
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 3;')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 3')
                      Left: 
                        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                      Right: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
            Next (StructuredExceptionHandling) Block[null]
    }
    Block[B5] - Exit [UnReachable]
        Predecessors: [B1] [B3]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,258653,258904);

var 
expectedDiagnostics = new[] {
f_22078_258821_258888(f_22078_258821_258867(ErrorCode.WRN_UnreachableCode, "x"), 17, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,258920,259014);

f_22078_258920_259013(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,255288,259025);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,255288,259025);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,255288,259025);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FinallyDispatch_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,259037,262383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,259189,259597);

string 
source = @"
class P
{
    void M(int x)
/*<bind>*/{
        try
        {
            try
            {
                return;
            }
            finally
            {
                while (true) {}
            }

            x = 2;
        }
        finally
        {
            x = 3;
        }
    }/*</bind>*/

    static bool ThisCanThrow() => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,259611,261997);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B1] - Block
            Predecessors: [B0]
            Statements (0)
            Next (Regular) Block[B6]
                Finalizing: {R5} {R6}
                Leaving: {R4} {R3} {R2} {R1}
    }
    .finally {R5}
    {
        Block[B2] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if False (Regular) to Block[B3]
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B2]
        Block[B3] - Block [UnReachable]
            Predecessors: [B2]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }

    Block[B4] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 2')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B6]
            Finalizing: {R6}
            Leaving: {R2} {R1}
}
.finally {R6}
{
    Block[B5] - Block
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = 3;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'x = 3')
                  Left: 
                    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (StructuredExceptionHandling) Block[null]
}

Block[B6] - Exit [UnReachable]
    Predecessors: [B1] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,262011,262262);

var 
expectedDiagnostics = new[] {
f_22078_262179_262246(f_22078_262179_262225(ErrorCode.WRN_UnreachableCode, "x"), 17, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,262278,262372);

f_22078_262278_262371(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,259037,262383);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,259037,262383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,259037,262383);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchExpressionInExceptionFilter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22078,262395,278766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,262562,263116);

string 
source = @"
using System;
class C
{
    const string K1 = ""const1"";
    const string K2 = ""const2"";
    public void M(string msg)
    /*<bind>*/{
        try
        {
            T(msg);
        }
        catch (Exception e) when (e.Message switch
            {
                K1 => true,
                K2 => true,
                _ => false,
            })
        {
            throw new Exception(e.Message);
        }
    }/*</bind>*/
    void T(string msg)
    {
        throw new Exception(msg);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,263130,272690);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}
.try {R1, R2}
{
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'T(msg);')
              Expression: 
                IInvocationOperation ( void C.T(System.String msg)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'T(msg)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'T')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: msg) (OperationKind.Argument, Type: null) (Syntax: 'msg')
                        IParameterReferenceOperation: msg (OperationKind.ParameterReference, Type: System.String) (Syntax: 'msg')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Next (Regular) Block[B13]
            Leaving: {R2} {R1}
}
.catch {R3} (System.Exception)
{
    Locals: [System.Exception e]
    .filter {R4}
    {
        Block[B2] - Block
            Predecessors (0)
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: null, IsImplicit) (Syntax: '(Exception e)')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Exception, IsImplicit) (Syntax: '(Exception e)')
                  Right: 
                    ICaughtExceptionOperation (OperationKind.CaughtException, Type: System.Exception, IsImplicit) (Syntax: '(Exception e)')
            Next (Regular) Block[B3]
                Entering: {R5} {R6}
        .locals {R5}
        {
            CaptureIds: [0]
            .locals {R6}
            {
                CaptureIds: [1]
                Block[B3] - Block
                    Predecessors: [B2]
                    Statements (1)
                        IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e.Message')
                          Value: 
                            IPropertyReferenceOperation: System.String System.Exception.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'e.Message')
                              Instance Receiver: 
                                ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Exception) (Syntax: 'e')
                    Jump if False (Regular) to Block[B5]
                        IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'K1 => true')
                          Value: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'e.Message')
                          Pattern: 
                            IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: 'K1') (InputType: System.String, NarrowedType: System.String)
                              Value: 
                                IFieldReferenceOperation: System.String C.K1 (Static) (OperationKind.FieldReference, Type: System.String, Constant: ""const1"") (Syntax: 'K1')
                                  Instance Receiver: 
                                    null
                    Next (Regular) Block[B4]
                Block[B4] - Block
                    Predecessors: [B3]
                    Statements (1)
                        IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'true')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                    Next (Regular) Block[B10]
                        Leaving: {R6}
                Block[B5] - Block
                    Predecessors: [B3]
                    Statements (0)
                    Jump if False (Regular) to Block[B7]
                        IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'K2 => true')
                          Value: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'e.Message')
                          Pattern: 
                            IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: 'K2') (InputType: System.String, NarrowedType: System.String)
                              Value: 
                                IFieldReferenceOperation: System.String C.K2 (Static) (OperationKind.FieldReference, Type: System.String, Constant: ""const2"") (Syntax: 'K2')
                                  Instance Receiver: 
                                    null
                    Next (Regular) Block[B6]
                Block[B6] - Block
                    Predecessors: [B5]
                    Statements (1)
                        IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'true')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                    Next (Regular) Block[B10]
                        Leaving: {R6}
                Block[B7] - Block
                    Predecessors: [B5]
                    Statements (0)
                    Jump if False (Regular) to Block[B9]
                        IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '_ => false')
                          Value: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'e.Message')
                          Pattern: 
                            IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.String, NarrowedType: System.String)
                        Leaving: {R6}
                    Next (Regular) Block[B8]
                Block[B8] - Block
                    Predecessors: [B7]
                    Statements (1)
                        IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'false')
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                    Next (Regular) Block[B10]
                        Leaving: {R6}
            }
            Block[B9] - Block
                Predecessors: [B7]
                Statements (0)
                Next (Throw) Block[null]
                    IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsImplicit) (Syntax: 'e.Message s ... }')
                      Arguments(0)
                      Initializer: 
                        null
            Block[B10] - Block
                Predecessors: [B4] [B6] [B8]
                Statements (0)
                Jump if True (Regular) to Block[B12]
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'e.Message s ... }')
                    Leaving: {R5} {R4}
                    Entering: {R7}
                Next (Regular) Block[B11]
                    Leaving: {R5}
        }
        Block[B11] - Block
            Predecessors: [B10]
            Statements (0)
            Next (StructuredExceptionHandling) Block[null]
    }
    .handler {R7}
    {
        Block[B12] - Block
            Predecessors: [B10]
            Statements (0)
            Next (Throw) Block[null]
                IObjectCreationOperation (Constructor: System.Exception..ctor(System.String message)) (OperationKind.ObjectCreation, Type: System.Exception) (Syntax: 'new Exception(e.Message)')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: message) (OperationKind.Argument, Type: null) (Syntax: 'e.Message')
                        IPropertyReferenceOperation: System.String System.Exception.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'e.Message')
                          Instance Receiver: 
                            ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Exception) (Syntax: 'e')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null
    }
}
Block[B13] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,272704,278440);

var 
expectedIoperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  ITryOperation (OperationKind.Try, Type: null) (Syntax: 'try ... }')
    Body: 
      IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'T(msg);')
          Expression: 
            IInvocationOperation ( void C.T(System.String msg)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'T(msg)')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'T')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: msg) (OperationKind.Argument, Type: null) (Syntax: 'msg')
                    IParameterReferenceOperation: msg (OperationKind.ParameterReference, Type: System.String) (Syntax: 'msg')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    Catch clauses(1):
        ICatchClauseOperation (Exception type: System.Exception) (OperationKind.CatchClause, Type: null) (Syntax: 'catch (Exce ... }')
          Locals: Local_1: System.Exception e
          ExceptionDeclarationOrExpression: 
            IVariableDeclaratorOperation (Symbol: System.Exception e) (OperationKind.VariableDeclarator, Type: null) (Syntax: '(Exception e)')
              Initializer: 
                null
          Filter: 
            ISwitchExpressionOperation (3 arms) (OperationKind.SwitchExpression, Type: System.Boolean) (Syntax: 'e.Message s ... }')
              Value: 
                IPropertyReferenceOperation: System.String System.Exception.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'e.Message')
                  Instance Receiver: 
                    ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Exception) (Syntax: 'e')
              Arms(3):
                  ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: 'K1 => true')
                    Pattern: 
                      IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: 'K1') (InputType: System.String, NarrowedType: System.String)
                        Value: 
                          IFieldReferenceOperation: System.String C.K1 (Static) (OperationKind.FieldReference, Type: System.String, Constant: ""const1"") (Syntax: 'K1')
                            Instance Receiver: 
                              null
                    Value: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                  ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: 'K2 => true')
                    Pattern: 
                      IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: 'K2') (InputType: System.String, NarrowedType: System.String)
                        Value: 
                          IFieldReferenceOperation: System.String C.K2 (Static) (OperationKind.FieldReference, Type: System.String, Constant: ""const2"") (Syntax: 'K2')
                            Instance Receiver: 
                              null
                    Value: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                  ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ => false')
                    Pattern: 
                      IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.String, NarrowedType: System.String)
                    Value: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
          Handler: 
            IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
              IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw new E ... e.Message);')
                IObjectCreationOperation (Constructor: System.Exception..ctor(System.String message)) (OperationKind.ObjectCreation, Type: System.Exception) (Syntax: 'new Exception(e.Message)')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: message) (OperationKind.Argument, Type: null) (Syntax: 'e.Message')
                        IPropertyReferenceOperation: System.String System.Exception.Message { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'e.Message')
                          Instance Receiver: 
                            ILocalReferenceOperation: e (OperationKind.LocalReference, Type: System.Exception) (Syntax: 'e')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Initializer: 
                    null
    Finally: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,278454,278512);

var 
expectedDiagnostics = new DiagnosticDescription[] { }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,278528,278565);

var 
comp = f_22078_278539_278564(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,278579,278649);

f_22078_278579_278648(comp, expectedIoperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22078,278663,278755);

f_22078_278663_278754(comp, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22078,262395,278766);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22078,262395,278766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22078,262395,278766);
}
		}

int
f_22078_3514_3626(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 3514, 3626);
return 0;
}


int
f_22078_6799_6904(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 6799, 6904);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_8329_8375(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 8329, 8375);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_8329_8394(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 8329, 8394);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_8329_8414(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 8329, 8414);
return return_v;
}


int
f_22078_8446_8558(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 8446, 8558);
return 0;
}


int
f_22078_10817_10929(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 10817, 10929);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_13963_14009(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 13963, 14009);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_13963_14028(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 13963, 14028);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_13963_14048(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 13963, 14048);
return return_v;
}


int
f_22078_14080_14192(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 14080, 14192);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_17370_17437(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 17370, 17437);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_17370_17476(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 17370, 17476);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_17370_17497(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 17370, 17497);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_17648_17694(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 17648, 17694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_17648_17713(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 17648, 17713);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_17648_17733(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 17648, 17733);
return return_v;
}


int
f_22078_17765_17877(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 17765, 17877);
return 0;
}


int
f_22078_18942_19054(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 18942, 19054);
return 0;
}


int
f_22078_20093_20205(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 20093, 20205);
return 0;
}


int
f_22078_21997_22109(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 21997, 22109);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_24102_24152(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 24102, 24152);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_24102_24171(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 24102, 24171);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_24102_24192(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 24102, 24192);
return return_v;
}


int
f_22078_24224_24336(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 24224, 24336);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_26380_26430(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 26380, 26430);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_26380_26449(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 26380, 26449);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_26380_26470(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 26380, 26470);
return return_v;
}


int
f_22078_26502_26614(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 26502, 26614);
return 0;
}


int
f_22078_28224_28336(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 28224, 28336);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_30338_30384(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 30338, 30384);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_30338_30403(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 30338, 30403);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_30338_30424(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 30338, 30424);
return return_v;
}


int
f_22078_30456_30568(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 30456, 30568);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_32252_32302(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 32252, 32302);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_32252_32321(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 32252, 32321);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_32252_32342(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 32252, 32342);
return return_v;
}


int
f_22078_32374_32486(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TryStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 32374, 32486);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_33607_33656(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 33607, 33656);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_33607_33676(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 33607, 33676);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_33819_33865(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 33819, 33865);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_33819_33884(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 33819, 33884);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_33819_33904(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 33819, 33904);
return return_v;
}


int
f_22078_33936_34047(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CatchClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 33936, 34047);
return 0;
}


int
f_22078_35979_36090(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CatchClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 35979, 36090);
return 0;
}


int
f_22078_36793_36909(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CatchDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 36793, 36909);
return 0;
}


string
f_22078_37397_37453(string
testSrc)
{
var return_v = GetOperationTreeForTest<CatchFilterClauseSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 37397, 37453);
return return_v;
}


int
f_22078_37385_37454(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 37385, 37454);
return 0;
}


int
f_22078_38644_38760(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 38644, 38760);
return 0;
}


string
f_22078_39248_39300(string
testSrc)
{
var return_v = GetOperationTreeForTest<FinallyClauseSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 39248, 39300);
return return_v;
}


int
f_22078_39236_39301(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 39236, 39301);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_39636_39661(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 39636, 39661);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_39678_39709(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 39678, 39709);
return return_v;
}


int
f_22078_40274_40337(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 40274, 40337);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_40674_40699(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 40674, 40699);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_40716_40747(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 40716, 40747);
return return_v;
}


int
f_22078_40938_41001(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 40938, 41001);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_42140_42165(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 42140, 42165);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_42182_42213(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 42182, 42213);
return return_v;
}


int
f_22078_52156_52219(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 52156, 52219);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_52701_52726(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 52701, 52726);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_52743_52774(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 52743, 52774);
return return_v;
}


int
f_22078_55451_55514(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 55451, 55514);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_55973_55998(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 55973, 55998);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_56015_56046(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 56015, 56046);
return return_v;
}


int
f_22078_56611_56674(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 56611, 56674);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_57173_57198(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 57173, 57198);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_57215_57246(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 57215, 57246);
return return_v;
}


int
f_22078_58935_58998(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 58935, 58998);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_59592_59617(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 59592, 59617);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_59634_59665(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 59634, 59665);
return return_v;
}


int
f_22078_62712_62775(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 62712, 62775);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_63329_63354(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 63329, 63354);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_63371_63402(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 63371, 63402);
return return_v;
}


int
f_22078_64450_64513(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 64450, 64513);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_65098_65123(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 65098, 65123);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_65140_65171(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 65140, 65171);
return return_v;
}


int
f_22078_68364_68427(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 68364, 68427);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_68992_69017(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 68992, 69017);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_69034_69065(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 69034, 69065);
return return_v;
}


int
f_22078_71664_71727(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 71664, 71727);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_72310_72335(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 72310, 72335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_72352_72383(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 72352, 72383);
return return_v;
}


int
f_22078_75083_75146(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 75083, 75146);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_75709_75734(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 75709, 75734);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_75751_75782(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 75751, 75782);
return return_v;
}


int
f_22078_77888_77951(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 77888, 77951);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_78521_78546(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 78521, 78546);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_78563_78594(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 78563, 78594);
return return_v;
}


int
f_22078_81297_81360(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 81297, 81360);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_81910_81935(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 81910, 81935);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_81952_81983(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 81952, 81983);
return return_v;
}


int
f_22078_84092_84155(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 84092, 84155);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_84668_84693(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 84668, 84693);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_84710_84741(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 84710, 84741);
return return_v;
}


int
f_22078_85865_85928(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 85865, 85928);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_86421_86446(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 86421, 86446);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_86463_86494(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 86463, 86494);
return return_v;
}


int
f_22078_87056_87119(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 87056, 87119);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_87689_87714(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 87689, 87714);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_87731_87762(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 87731, 87762);
return return_v;
}


int
f_22078_90465_90528(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 90465, 90528);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_91078_91103(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 91078, 91103);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_91120_91151(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 91120, 91151);
return return_v;
}


int
f_22078_93260_93323(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 93260, 93323);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_93730_93755(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 93730, 93755);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_93772_93803(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 93772, 93803);
return return_v;
}


int
f_22078_94652_94715(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 94652, 94715);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_95142_95167(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 95142, 95167);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_95184_95215(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 95184, 95215);
return return_v;
}


int
f_22078_95954_96017(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 95954, 96017);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_96498_96523(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 96498, 96523);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_96540_96571(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 96540, 96571);
return return_v;
}


int
f_22078_97508_97571(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 97508, 97571);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_97992_98017(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 97992, 98017);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_98034_98065(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 98034, 98065);
return return_v;
}


int
f_22078_98894_98957(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 98894, 98957);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_99466_99491(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 99466, 99491);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_99508_99539(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 99508, 99539);
return return_v;
}


int
f_22078_101006_101069(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 101006, 101069);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_101600_101625(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 101600, 101625);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_101642_101673(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 101642, 101673);
return return_v;
}


int
f_22078_102610_102673(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 102610, 102673);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_103478_103503(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 103478, 103503);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_103520_103551(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 103520, 103551);
return return_v;
}


int
f_22078_110182_110245(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 110182, 110245);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_110735_110760(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 110735, 110760);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_110777_110808(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 110777, 110808);
return return_v;
}


int
f_22078_112496_112559(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 112496, 112559);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_113049_113074(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 113049, 113074);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_113272_113323(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 113272, 113323);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_113272_113344(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 113272, 113344);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_113091_113363(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 113091, 113363);
return return_v;
}


int
f_22078_114852_114915(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 114852, 114915);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_115403_115428(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 115403, 115428);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_115445_115476(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 115445, 115476);
return return_v;
}


int
f_22078_116949_117012(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 116949, 117012);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_117518_117543(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 117518, 117543);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_117560_117591(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 117560, 117591);
return return_v;
}


int
f_22078_118420_118483(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 118420, 118483);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_118838_118863(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 118838, 118863);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_119025_119070(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 119025, 119070);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_119025_119089(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 119025, 119089);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_118880_119108(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 118880, 119108);
return return_v;
}


int
f_22078_119942_120005(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 119942, 120005);
return 0;
}


int
f_22078_122027_122120(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 122027, 122120);
return 0;
}


int
f_22078_124071_124164(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 124071, 124164);
return 0;
}


int
f_22078_126252_126345(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 126252, 126345);
return 0;
}


int
f_22078_128369_128462(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 128369, 128462);
return 0;
}


int
f_22078_130798_130891(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 130798, 130891);
return 0;
}


int
f_22078_133244_133337(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 133244, 133337);
return 0;
}


int
f_22078_135973_136066(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 135973, 136066);
return 0;
}


int
f_22078_138705_138798(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 138705, 138798);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_141156_141207(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 141156, 141207);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_141156_141227(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 141156, 141227);
return return_v;
}


int
f_22078_141259_141352(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 141259, 141352);
return 0;
}


int
f_22078_143597_143690(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 143597, 143690);
return 0;
}


int
f_22078_146447_146540(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 146447, 146540);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_149439_149490(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 149439, 149490);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_149439_149510(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 149439, 149510);
return return_v;
}


int
f_22078_149542_149635(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 149542, 149635);
return 0;
}


int
f_22078_152068_152161(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 152068, 152161);
return 0;
}


int
f_22078_154601_154694(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 154601, 154694);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_157820_157874(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 157820, 157874);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_157820_157895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 157820, 157895);
return return_v;
}


int
f_22078_157927_158020(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 157927, 158020);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_161174_161247(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 161174, 161247);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_161174_161268(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 161174, 161268);
return return_v;
}


int
f_22078_161300_161393(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 161300, 161393);
return 0;
}


int
f_22078_164519_164612(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 164519, 164612);
return 0;
}


int
f_22078_168136_168229(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 168136, 168229);
return 0;
}


int
f_22078_171767_171860(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 171767, 171860);
return 0;
}


int
f_22078_175472_175565(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 175472, 175565);
return 0;
}


int
f_22078_179191_179284(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 179191, 179284);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_181659_181708(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 181659, 181708);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_181659_181728(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 181659, 181728);
return return_v;
}


int
f_22078_181760_181853(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 181760, 181853);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_184717_184771(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 184717, 184771);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_184717_184792(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 184717, 184792);
return return_v;
}


int
f_22078_184824_184917(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 184824, 184917);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_187806_187862(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 187806, 187862);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_187806_187883(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 187806, 187883);
return return_v;
}


int
f_22078_187915_188008(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 187915, 188008);
return 0;
}


int
f_22078_190864_190957(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 190864, 190957);
return 0;
}


int
f_22078_194353_194446(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 194353, 194446);
return 0;
}


int
f_22078_197668_197761(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 197668, 197761);
return 0;
}


int
f_22078_200997_201090(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 200997, 201090);
return 0;
}


int
f_22078_204392_204485(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 204392, 204485);
return 0;
}


int
f_22078_207801_207894(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 207801, 207894);
return 0;
}


int
f_22078_210785_210878(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 210785, 210878);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_214317_214363(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 214317, 214363);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_214317_214382(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 214317, 214382);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_214317_214403(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 214317, 214403);
return return_v;
}


int
f_22078_214435_214528(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 214435, 214528);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_217774_217820(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 217774, 217820);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_217774_217839(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 217774, 217839);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_217774_217860(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 217774, 217860);
return return_v;
}


int
f_22078_217892_217985(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 217892, 217985);
return 0;
}


int
f_22078_219876_219969(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 219876, 219969);
return 0;
}


int
f_22078_221849_221942(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 221849, 221942);
return 0;
}


int
f_22078_223956_224049(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 223956, 224049);
return 0;
}


int
f_22078_226115_226208(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 226115, 226208);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_228407_228456(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 228407, 228456);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_228407_228477(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 228407, 228477);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_228607_228658(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 228607, 228658);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_228607_228678(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 228607, 228678);
return return_v;
}


int
f_22078_228710_228803(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 228710, 228803);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_232267_232324(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 232267, 232324);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_232267_232345(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 232267, 232345);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_232502_232551(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 232502, 232551);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_232502_232572(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 232502, 232572);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_232706_232757(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 232706, 232757);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_232706_232777(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 232706, 232777);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_232917_232963(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 232917, 232963);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_232917_232984(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 232917, 232984);
return return_v;
}


int
f_22078_233016_233109(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 233016, 233109);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_236053_236107(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 236053, 236107);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_236053_236128(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 236053, 236128);
return return_v;
}


int
f_22078_236160_236253(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 236160, 236253);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_240329_240375(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 240329, 240375);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_240329_240396(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 240329, 240396);
return return_v;
}


int
f_22078_240428_240521(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 240428, 240521);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_244508_244554(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 244508, 244554);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_244508_244575(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 244508, 244575);
return return_v;
}


int
f_22078_244607_244700(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 244607, 244700);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_248520_248566(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 248520, 248566);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_248520_248587(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 248520, 248587);
return return_v;
}


int
f_22078_248619_248712(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 248619, 248712);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_251471_251522(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 251471, 251522);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_251471_251543(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 251471, 251543);
return return_v;
}


int
f_22078_251575_251668(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 251575, 251668);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_255072_255118(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 255072, 255118);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_255072_255139(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 255072, 255139);
return return_v;
}


int
f_22078_255171_255264(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 255171, 255264);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_258821_258867(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 258821, 258867);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_258821_258888(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 258821, 258888);
return return_v;
}


int
f_22078_258920_259013(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 258920, 259013);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_262179_262225(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 262179, 262225);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22078_262179_262246(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 262179, 262246);
return return_v;
}


int
f_22078_262278_262371(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 262278, 262371);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22078_278539_278564(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 278539, 278564);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22078_278579_278648(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<BlockSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 278579, 278648);
return return_v;
}


int
f_22078_278663_278754(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( compilation, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22078, 278663, 278754);
return 0;
}

}
}
