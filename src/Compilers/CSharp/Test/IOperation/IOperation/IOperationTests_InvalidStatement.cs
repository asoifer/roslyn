// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using System.Linq;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidVariableDeclarationStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,574,3172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,783,938);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int x, ( 1 );/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,952,1807);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'int x, ( 1 );')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int x, ( 1 ')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
          Initializer: 
            null
        IVariableDeclaratorOperation (Symbol: System.Int32 ) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: '( 1 ')
          Initializer: 
            null
          IgnoredArguments(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,1821,3019);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_2005_2074(f_22055_2005_2054(ErrorCode.ERR_IdentifierExpected, "("), 8, 26),
f_22055_2254_2318(f_22055_2254_2298(ErrorCode.ERR_BadVarDecl, "( 1 "), 8, 26),
f_22055_2455_2541(f_22055_2455_2521(f_22055_2455_2497(ErrorCode.ERR_SyntaxError, "("), "[", "("), 8, 26),
f_22055_2678_2764(f_22055_2678_2744(f_22055_2678_2720(ErrorCode.ERR_SyntaxError, ")"), "]", ")"), 8, 30),
f_22055_2918_3003(f_22055_2918_2983(f_22055_2918_2964(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 8, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,3035,3161);

f_22055_3035_3160(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,574,3172);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,574,3172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,574,3172);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidSwitchStatementExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,3184,5957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,3390,3615);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/switch (Program)
        {
            case 1:
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,3629,5187);

string 
expectedOperationTree = @"
ISwitchOperation (1 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null, IsInvalid) (Syntax: 'switch (Pro ... }')
  Switch expression: 
    IInvalidOperation (OperationKind.Invalid, Type: Program, IsInvalid, IsImplicit) (Syntax: 'Program')
      Children(1):
          IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'Program')
  Sections:
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null, IsInvalid) (Syntax: 'case 1: ... break;')
          Clauses:
              IPatternCaseClauseOperation (Label Id: 1) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case 1:')
                Pattern: 
                  IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid, IsImplicit) (Syntax: '1') (InputType: Program, NarrowedType: Program)
                    Value: 
                      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, IsInvalid, IsImplicit) (Syntax: '1')
                        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        Operand: 
                          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,5201,5814);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_5439_5541(f_22055_5439_5521(f_22055_5439_5488(ErrorCode.ERR_BadSKunknown, "Program"), "Program", "type"), 8, 27),
f_22055_5700_5798(f_22055_5700_5777(f_22055_5700_5745(ErrorCode.ERR_NoImplicitConv, "1"), "int", "Program"), 10, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,5830,5946);

f_22055_5830_5945(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,3184,5957);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,3184,5957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,3184,5957);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidSwitchStatementCaseLabel()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,5969,8344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,6174,6436);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var x = new Program();
        /*<bind>*/switch (x.ToString())
        {
            case 1:
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,6450,7884);

string 
expectedOperationTree = @"
ISwitchOperation (1 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null, IsInvalid) (Syntax: 'switch (x.T ... }')
  Switch expression: 
    IInvocationOperation (virtual System.String System.Object.ToString()) (OperationKind.Invocation, Type: System.String) (Syntax: 'x.ToString()')
      Instance Receiver: 
        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program) (Syntax: 'x')
      Arguments(0)
  Sections:
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null, IsInvalid) (Syntax: 'case 1: ... break;')
          Clauses:
              ISingleValueCaseClauseOperation (Label Id: 1) (CaseKind.SingleValue) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case 1:')
                Value: 
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsInvalid, IsImplicit) (Syntax: '1')
                    Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,7898,8201);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_8088_8185(f_22055_8088_8164(f_22055_8088_8133(ErrorCode.ERR_NoImplicitConv, "1"), "int", "string"), 11, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,8217,8333);

f_22055_8217_8332(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,5969,8344);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,5969,8344);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,5969,8344);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidIfStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,8356,10573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,8548,8757);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var x = new Program();
        /*<bind>*/if (x = null)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,8771,10095);

string 
expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'if (x = nul ... }')
  Condition: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'x = null')
      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: Program, IsInvalid) (Syntax: 'x = null')
          Left: 
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'x')
          Right: 
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: Program, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
  WhenTrue: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  WhenFalse: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,10109,10434);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_10313_10418(f_22055_10313_10398(f_22055_10313_10365(ErrorCode.ERR_NoImplicitConv, "x = null"), "Program", "bool"), 9, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,10450,10562);

f_22055_10450_10561(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,8356,10573);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,8356,10573);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,8356,10573);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidIfElseStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,10585,13769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,10781,11020);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var x = new Program();
        /*<bind>*/if ()
        {
        }
        else if (x) x;
        else
/*</bind>*/    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,11034,12486);

string 
expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'if () ... else')
  Condition: 
    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
      Children(0)
  WhenTrue: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  WhenFalse: 
    IConditionalOperation (OperationKind.Conditional, Type: null, IsInvalid) (Syntax: 'if (x) x; ... else')
      Condition: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'x')
          Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'x')
      WhenTrue: 
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'x;')
          Expression: 
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'x')
      WhenFalse: 
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '')
          Expression: 
            IInvalidOperation (OperationKind.Invalid, Type: null) (Syntax: '')
              Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,12500,13630);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_12673_12758(f_22055_12673_12738(f_22055_12673_12719(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 9, 23),
f_22055_12866_12951(f_22055_12866_12930(f_22055_12866_12911(ErrorCode.ERR_InvalidExprTerm, ""), "}"), 13, 13),
f_22055_13042_13110(f_22055_13042_13089(ErrorCode.ERR_SemicolonExpected, ""), 13, 13),
f_22055_13251_13350(f_22055_13251_13329(f_22055_13251_13296(ErrorCode.ERR_NoImplicitConv, "x"), "Program", "bool"), 12, 18),
f_22055_13546_13614(f_22055_13546_13593(ErrorCode.ERR_IllegalStatement, "x"), 12, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,13646,13758);

f_22055_13646_13757(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,10585,13769);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,10585,13769);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,10585,13769);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidForStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,13781,16172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,13974,14181);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        var x = new Program();
        /*<bind>*/for (P; x;)
        {
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,14195,15198);

string 
expectedOperationTree = @"
IForLoopOperation (LoopKind.For, Continue Label Id: 0, Exit Label Id: 1) (OperationKind.Loop, Type: null, IsInvalid) (Syntax: 'for (P; x;) ... }')
  Condition: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: x (OperationKind.LocalReference, Type: Program, IsInvalid) (Syntax: 'x')
  Before:
      IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'P')
        Expression: 
          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'P')
            Children(0)
  AtLoopBottom(0)
  Body: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,15212,16032);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_15414_15500(f_22055_15414_15480(f_22055_15414_15461(ErrorCode.ERR_NameNotInContext, "P"), "P"), 9, 24),
f_22055_15703_15770(f_22055_15703_15750(ErrorCode.ERR_IllegalStatement, "P"), 9, 24),
f_22055_15918_16016(f_22055_15918_15996(f_22055_15918_15963(ErrorCode.ERR_NoImplicitConv, "x"), "Program", "bool"), 9, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,16048,16161);

f_22055_16048_16160(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,13781,16172);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,13781,16172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,13781,16172);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidGotoCaseStatement_MissingLabel()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,16184,17425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,16395,16654);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        switch (args.Length)
        {
            case 0:
                /*<bind>*/goto case 1;/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,16668,16919);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto case 1;')
  Children(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,16933,17284);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_17167_17268(f_22055_17167_17247(f_22055_17167_17222(ErrorCode.ERR_LabelNotFound, "goto case 1;"), "case 1:"), 11, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,17300,17414);

f_22055_17300_17413(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,16184,17425);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,16184,17425);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,16184,17425);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(40714, "https://github.com/dotnet/roslyn/issues/40714")]
        public void InvalidGotoCaseStatement_BadLabel()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,17437,21504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,17644,18020);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        switch (args[0], args[1])
        {
            case (string s1, string s2) _:
                /*<bind>*/goto case args is (var x1, var x2);/*</bind>*/
                x1 = x2;
            case (string str, null) _:
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,18034,19609);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto case a ... 1, var x2);')
  Children(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: (System.String, System.String), IsInvalid, IsImplicit) (Syntax: 'args is (var x1, var x2)')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'args is (var x1, var x2)')
            Value: 
              IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[], IsInvalid) (Syntax: 'args')
            Pattern: 
              IRecursivePatternOperation (OperationKind.RecursivePattern, Type: null, IsInvalid) (Syntax: '(var x1, var x2)') (InputType: System.String[], NarrowedType: System.String[], DeclaredSymbol: null, MatchedType: System.String[], DeconstructSymbol: null)
                DeconstructionSubpatterns (2):
                    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'var x1') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? x1, MatchesNull: True)
                    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'var x2') (InputType: ?, NarrowedType: ?, DeclaredSymbol: ?? x2, MatchesNull: True)
                PropertySubpatterns (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,19623,21363);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_19903_20049(f_22055_19903_20028(f_22055_19903_19980(ErrorCode.ERR_SwitchFallThrough, "case (string s1, string s2) _:"), "case (string s1, string s2) _:"), 10, 13),
f_22055_20271_20413(f_22055_20271_20392(f_22055_20271_20350(ErrorCode.ERR_NoImplicitConv, "goto case args is (var x1, var x2);"), "bool", "(string, string)"), 11, 27),
f_22055_20806_20937(f_22055_20806_20916(f_22055_20806_20875(ErrorCode.ERR_NoSuchMemberOrExtension, "(var x1, var x2)"), "string[]", "Deconstruct"), 11, 45),
f_22055_21231_21347(f_22055_21231_21326(f_22055_21231_21295(ErrorCode.ERR_MissingDeconstruct, "(var x1, var x2)"), "string[]", "2"), 11, 45)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,21379,21493);

f_22055_21379_21492(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,17437,21504);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,17437,21504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,17437,21504);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidGotoCaseStatement_OutsideSwitchStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,21516,22619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,21737,21891);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/goto case 1;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,21905,22156);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto case 1;')
  Children(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,22170,22478);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_22385_22462(f_22055_22385_22442(ErrorCode.ERR_InvalidGotoCase, "goto case 1;"), 8, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,22494,22608);

f_22055_22494_22607(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,21516,22619);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,21516,22619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,21516,22619);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidBreakStatement_OutsideLoopOrSwitch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,22631,23595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,22846,22994);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/break;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,23008,23145);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'break;')
  Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,23159,23453);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_23368_23437(f_22055_23368_23417(ErrorCode.ERR_NoBreakOrCont, "break;"), 8, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,23469,23584);

f_22055_23469_23583(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,22631,23595);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,22631,23595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,22631,23595);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17607, "https://github.com/dotnet/roslyn/issues/17607")]
        public void InvalidContinueStatement_OutsideLoopOrSwitch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,23607,24589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,23825,23976);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/continue;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,23990,24130);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'continue;')
  Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,24144,24444);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_24356_24428(f_22055_24356_24408(ErrorCode.ERR_NoBreakOrCont, "continue;"), 8, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,24460,24578);

f_22055_24460_24577(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,23607,24589);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,23607,24589);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,23607,24589);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void InvalidStatementFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22055,24601,27268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,24758,25038);

string 
source = @"
using System;

class Program
{
    static void Main(string[] args)
    /*<bind>*/{
        switch (args.Length)
        {
            case 0:
                /*<bind>*/goto case 1;/*</bind>*/
                break;
        }
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,25052,25425);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22055_25308_25409(f_22055_25308_25388(f_22055_25308_25363(ErrorCode.ERR_LabelNotFound, "goto case 1;"), "case 1:"), 11, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,25441,27145);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'args.Length')
              Value: 
                IPropertyReferenceOperation: System.Int32 System.Array.Length { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'args.Length')
                  Instance Receiver: 
                    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')

        Jump if False (Regular) to Block[B3]
            IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean, IsImplicit) (Syntax: '0')
              Left: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'args.Length')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
            Leaving: {R1}

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (2)
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')

            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto case 1;')
              Children(0)

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22055,27159,27257);

f_22055_27159_27256(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22055,24601,27268);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22055,24601,27268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22055,24601,27268);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2005_2054(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2005, 2054);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2005_2074(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2005, 2074);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2254_2298(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2254, 2298);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2254_2318(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2254, 2318);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2455_2497(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2455, 2497);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2455_2521(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2455, 2521);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2455_2541(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2455, 2541);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2678_2720(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2678, 2720);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2678_2744(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2678, 2744);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2678_2764(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2678, 2764);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2918_2964(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2918, 2964);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2918_2983(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2918, 2983);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_2918_3003(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 2918, 3003);
return return_v;
}


int
f_22055_3035_3160(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 3035, 3160);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_5439_5488(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 5439, 5488);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_5439_5521(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 5439, 5521);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_5439_5541(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 5439, 5541);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_5700_5745(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 5700, 5745);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_5700_5777(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 5700, 5777);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_5700_5798(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 5700, 5798);
return return_v;
}


int
f_22055_5830_5945(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 5830, 5945);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_8088_8133(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 8088, 8133);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_8088_8164(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 8088, 8164);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_8088_8185(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 8088, 8185);
return return_v;
}


int
f_22055_8217_8332(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 8217, 8332);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_10313_10365(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 10313, 10365);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_10313_10398(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 10313, 10398);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_10313_10418(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 10313, 10418);
return return_v;
}


int
f_22055_10450_10561(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 10450, 10561);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_12673_12719(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 12673, 12719);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_12673_12738(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 12673, 12738);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_12673_12758(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 12673, 12758);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_12866_12911(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 12866, 12911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_12866_12930(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 12866, 12930);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_12866_12951(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 12866, 12951);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_13042_13089(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 13042, 13089);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_13042_13110(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 13042, 13110);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_13251_13296(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 13251, 13296);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_13251_13329(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 13251, 13329);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_13251_13350(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 13251, 13350);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_13546_13593(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 13546, 13593);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_13546_13614(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 13546, 13614);
return return_v;
}


int
f_22055_13646_13757(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IfStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 13646, 13757);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_15414_15461(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 15414, 15461);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_15414_15480(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 15414, 15480);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_15414_15500(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 15414, 15500);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_15703_15750(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 15703, 15750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_15703_15770(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 15703, 15770);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_15918_15963(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 15918, 15963);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_15918_15996(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 15918, 15996);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_15918_16016(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 15918, 16016);
return return_v;
}


int
f_22055_16048_16160(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ForStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 16048, 16160);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_17167_17222(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 17167, 17222);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_17167_17247(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 17167, 17247);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_17167_17268(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 17167, 17268);
return return_v;
}


int
f_22055_17300_17413(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<GotoStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 17300, 17413);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_19903_19980(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 19903, 19980);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_19903_20028(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 19903, 20028);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_19903_20049(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 19903, 20049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_20271_20350(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 20271, 20350);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_20271_20392(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 20271, 20392);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_20271_20413(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 20271, 20413);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_20806_20875(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 20806, 20875);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_20806_20916(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 20806, 20916);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_20806_20937(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 20806, 20937);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_21231_21295(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 21231, 21295);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_21231_21326(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 21231, 21326);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_21231_21347(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 21231, 21347);
return return_v;
}


int
f_22055_21379_21492(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<GotoStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 21379, 21492);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_22385_22442(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 22385, 22442);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_22385_22462(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 22385, 22462);
return return_v;
}


int
f_22055_22494_22607(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<GotoStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 22494, 22607);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_23368_23417(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 23368, 23417);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_23368_23437(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 23368, 23437);
return return_v;
}


int
f_22055_23469_23583(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BreakStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 23469, 23583);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_24356_24408(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 24356, 24408);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_24356_24428(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 24356, 24428);
return return_v;
}


int
f_22055_24460_24577(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ContinueStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 24460, 24577);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_25308_25363(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 25308, 25363);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_25308_25388(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 25308, 25388);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22055_25308_25409(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 25308, 25409);
return return_v;
}


int
f_22055_27159_27256(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22055, 27159, 27256);
return 0;
}

}
}
