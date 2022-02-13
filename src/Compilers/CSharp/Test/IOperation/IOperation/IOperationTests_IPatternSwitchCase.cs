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
public partial class IOperationTests_Patterns : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_VarPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,563,1607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,780,994);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12;
        switch (x)
        {
            /*<bind>*/case var y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,1008,1390);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case var y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'var y') (InputType: System.Int32?, NarrowedType: System.Int32?, DeclaredSymbol: System.Int32? y, MatchesNull: True)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,1404,1457);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,1473,1596);

f_22059_1473_1595(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,563,1607);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,563,1607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,563,1607);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_PrimitiveTypePatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,1619,2672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,1846,2060);

string 
source = @"
using System;
class X
{
    void M()
    {
        int? x = 12;
        switch (x)
        {
            /*<bind>*/case int y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,2074,2455);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case int y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int y') (InputType: System.Int32?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,2469,2522);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,2538,2661);

f_22059_2538_2660(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,1619,2672);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,1619,2672);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,1619,2672);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_ReferenceTypePatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,2684,3695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,2911,3109);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            /*<bind>*/case X y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,3123,3478);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case X y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,3492,3545);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,3561,3684);

f_22059_3561_3683(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,2684,3695);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,2684,3695);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,2684,3695);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_TypeParameterTypePatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,3707,4741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,3938,4155);

string 
source = @"
using System;
class X
{
    void M<T>(object x) where T : class
    {
        switch (x)
        {
            /*<bind>*/case T y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,4169,4524);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case T y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'T y') (InputType: System.Object, NarrowedType: T, DeclaredSymbol: T y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,4538,4591);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,4607,4730);

f_22059_4607_4729(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,3707,4741);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,3707,4741);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,3707,4741);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_DynamicTypePatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,4753,6097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,4978,5201);

string 
source = @"
using System;
class X
{
    void M<T>(object x) where T : class
    {
        switch (x)
        {
            /*<bind>*/case dynamic y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,5215,5616);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case dynamic y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'dynamic y') (InputType: System.Object, NarrowedType: dynamic, DeclaredSymbol: dynamic y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,5630,5947);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_5856_5931(f_22059_5856_5911(ErrorCode.ERR_PatternDynamicType, "dynamic"), 9, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,5963,6086);

f_22059_5963_6085(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,4753,6097);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,4753,6097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,4753,6097);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_MixedDeclarationPatternAndConstantPatternClauses()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,6109,7185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,6353,6599);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            case null:
                break;
            /*<bind>*/case X y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,6613,6968);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case X y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,6982,7035);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,7051,7174);

f_22059_7051_7173(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,6109,7185);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,6109,7185);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,6109,7185);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_MixedDeclarationPatternAndConstantPatternClausesInSameSwitchSection()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,7197,8268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,7460,7682);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            case null:
            /*<bind>*/case X y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,7696,8051);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case X y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,8065,8118);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,8134,8257);

f_22059_8134_8256(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,7197,8268);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,7197,8268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,7197,8268);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_MixedDeclarationPatternAndConstantPatternWithDefaultLabel()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,8280,9363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,8533,8777);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            case null:
            /*<bind>*/case X y:/*</bind>*/
            default:
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,8791,9146);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case X y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,9160,9213);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,9229,9352);

f_22059_9229_9351(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,8280,9363);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,8280,9363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,8280,9363);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_GuardExpressionInPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,9375,11106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,9595,9808);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            /*<bind>*/case X y when x != null:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,9822,10889);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case X y when x != null:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
  Guard: 
    IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x != null')
      Left: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')
      Right: 
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, Constant: null, IsImplicit) (Syntax: 'null')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,10903,10956);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,10972,11095);

f_22059_10972_11094(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,9375,11106);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,9375,11106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,9375,11106);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_PatternInGuardExpressionInPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,11118,12595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,11347,11560);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            /*<bind>*/case X y when x is X z :/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,11574,12378);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case X y when x is X z :')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
  Guard: 
    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'x is X z')
      Value: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'x')
      Pattern: 
        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X z') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X z, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,12392,12445);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,12461,12584);

f_22059_12461_12583(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,11118,12595);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,11118,12595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,11118,12595);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_SyntaxErrorInGuardExpressionInPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,12607,14006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,12840,13044);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            /*<bind>*/case X y when :/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,13058,13543);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case X y when :')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
  Guard: 
    IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
      Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,13557,13856);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_13755_13840(f_22059_13755_13820(f_22059_13755_13801(ErrorCode.ERR_InvalidExprTerm, ":"), ":"), 9, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,13872,13995);

f_22059_13872_13994(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,12607,14006);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,12607,14006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,12607,14006);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_SemanticErrorInGuardExpressionInPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,14018,15846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,14253,14458);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            /*<bind>*/case X y when x:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,14472,15287);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case X y when x:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X y') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
  Guard: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'x')
      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Object, IsInvalid) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,15301,15696);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_15579_15680(f_22059_15579_15660(f_22059_15579_15628(ErrorCode.ERR_NoImplicitConvCast, "x"), "object", "bool"), 9, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,15712,15835);

f_22059_15712_15834(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,14018,15846);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,14018,15846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,14018,15846);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_ConstantPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,15858,17311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,16069,16271);

string 
source = @"
using System;
class X
{
    void M(bool x)
    {
        switch (x)
        {
            case /*<bind>*/x is true/*</bind>*/:
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,16285,16860);

string 
expectedOperationTree = @"
IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is true')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'x')
  Pattern: 
    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid) (Syntax: 'true') (InputType: System.Boolean, NarrowedType: System.Boolean)
      Value: 
        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsInvalid) (Syntax: 'true')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,16874,17164);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_17073_17148(f_22059_17073_17128(ErrorCode.ERR_ConstantExpected, "x is true"), 9, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,17180,17300);

f_22059_17180_17299(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,15858,17311);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,15858,17311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,15858,17311);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_DefaultLabel()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,17323,18137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,17531,17751);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            case X y:
            /*<bind>*/default:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,17765,17924);

string 
expectedOperationTree = @"
IDefaultCaseClauseOperation (Label Id: 0) (CaseKind.Default) (OperationKind.CaseClause, Type: null) (Syntax: 'default:')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,17938,17991);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,18007,18126);

f_22059_18007_18125(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,17323,18137);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,17323,18137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,17323,18137);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_InvalidTypeSwitch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,18149,19541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,18362,18576);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x.GetType())
        {
            /*<bind>*/case typeof(X):/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,18590,19094);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case typeof(X):')
  Pattern: 
    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid, IsImplicit) (Syntax: 'typeof(X)') (InputType: System.Type, NarrowedType: System.Type)
      Value: 
        ITypeOfOperation (OperationKind.TypeOf, Type: System.Type, IsInvalid) (Syntax: 'typeof(X)')
          TypeOperand: X
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,19108,19398);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_19307_19382(f_22059_19307_19362(ErrorCode.ERR_ConstantExpected, "typeof(X)"), 9, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,19414,19530);

f_22059_19414_19529(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,18149,19541);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,18149,19541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,18149,19541);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_UndefinedTypeInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,19553,21027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,19782,19992);

string 
source = @"
using System;
class X
{
    void M(object x)
    {
        switch (x)
        {
            /*<bind>*/case UndefinedType y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,20006,20431);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case UndefinedType y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'UndefinedType y') (InputType: System.Object, NarrowedType: UndefinedType, DeclaredSymbol: UndefinedType y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,20445,20877);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_20745_20861(f_22059_20745_20841(f_22059_20745_20810(ErrorCode.ERR_SingleTypeNameNotFound, "UndefinedType"), "UndefinedType"), 9, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,20893,21016);

f_22059_20893_21015(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,19553,21027);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,19553,21027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,19553,21027);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_InvalidTypeInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,21039,22385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,21266,21462);

string 
source = @"
using System;
class X
{
    void M(int? x)
    {
        switch (x)
        {
            /*<bind>*/case X y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,21476,21853);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case X y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'X y') (InputType: System.Int32?, NarrowedType: X, DeclaredSymbol: X y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,21867,22235);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_22125_22219(f_22059_22125_22199(f_22059_22125_22172(ErrorCode.ERR_PatternWrongType, "X"), "int?", "X"), 9, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,22251,22374);

f_22059_22251_22373(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,21039,22385);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,21039,22385);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,21039,22385);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_DuplicateLocalInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,22397,24085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,22627,22846);

string 
source = @"
using System;
class X
{
    void M(int? x)
    {
        int? y = 0;
        switch (x)
        {
            /*<bind>*/case int y:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,22860,23263);

string 
expectedOperationTree = @"
IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case int y:')
  Pattern: 
    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int y') (InputType: System.Int32?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: False)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,23277,23935);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_23592_23686(f_22059_23592_23665(f_22059_23592_23646(ErrorCode.ERR_LocalIllegallyOverrides, "y"), "y"), 10, 32),
f_22059_23830_23919(f_22059_23830_23899(f_22059_23830_23880(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"), 7, 14)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,23951,24074);

f_22059_23951_24073(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,22397,24085);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,22397,24085);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,22397,24085);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_InvalidConstDeclarationInPatternDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,24097,26449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,24336,24540);

string 
source = @"
using System;
class X
{
    void M(int? x)
    {
        switch (x)
        {
            /*<bind>*/case /*</bind>*/const int y:
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,24554,24869);

string 
expectedOperationTree = @"
    ISingleValueCaseClauseOperation (Label Id: 0) (CaseKind.SingleValue) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case /*</bind>*/')
      Value: 
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
          Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,24883,26306);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_25087_25180(f_22059_25087_25160(f_22059_25087_25137(ErrorCode.ERR_InvalidExprTerm, "const"), "const"), 9, 39),
f_22059_25325_25419(f_22059_25325_25399(f_22059_25325_25371(ErrorCode.ERR_SyntaxError, "const"), ":", "const"), 9, 39),
f_22059_25583_25652(f_22059_25583_25632(ErrorCode.ERR_ConstValueRequired, "y"), 9, 49),
f_22059_25781_25849(f_22059_25781_25829(ErrorCode.ERR_SemicolonExpected, ":"), 9, 50),
f_22059_25978_26043(f_22059_25978_26023(ErrorCode.ERR_RbraceExpected, ":"), 9, 50),
f_22059_26205_26290(f_22059_26205_26270(f_22059_26205_26251(ErrorCode.WRN_UnreferencedVar, "y"), "y"), 9, 49)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,26322,26438);

f_22059_26322_26437(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,24097,26449);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,24097,26449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,24097,26449);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(19927, "https://github.com/dotnet/roslyn/issues/19927")]
        public void TestPatternCaseClause_RedundantPatternDeclarationClauses()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,26461,29964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,26691,26987);

string 
source = @"
using System;
class X
{
    void M(object p)
    {
        /*<bind>*/switch (p)
        {
            case int x:
                break;
            case int y:
                break;
            case X z:
                break;
        }/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,27001,29441);

string 
expectedOperationTree = @"
ISwitchOperation (3 cases, Exit Label Id: 0) (OperationKind.Switch, Type: null, IsInvalid) (Syntax: 'switch (p) ... }')
  Switch expression: 
    IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'p')
  Sections:
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case int x: ... break;')
        Locals: Local_1: System.Int32 x
          Clauses:
              IPatternCaseClauseOperation (Label Id: 1) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case int x:')
                Pattern: 
                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int x') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 x, MatchesNull: False)
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null, IsInvalid) (Syntax: 'case int y: ... break;')
        Locals: Local_1: System.Int32 y
          Clauses:
              IPatternCaseClauseOperation (Label Id: 2) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null, IsInvalid) (Syntax: 'case int y:')
                Pattern: 
                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int y') (InputType: System.Object, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 y, MatchesNull: False)
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
      ISwitchCaseOperation (1 case clauses, 1 statements) (OperationKind.SwitchCase, Type: null) (Syntax: 'case X z: ... break;')
        Locals: Local_1: X z
          Clauses:
              IPatternCaseClauseOperation (Label Id: 3) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case X z:')
                Pattern: 
                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'X z') (InputType: System.Object, NarrowedType: X, DeclaredSymbol: X z, MatchesNull: False)
          Body:
              IBranchOperation (BranchKind.Break, Label Id: 0) (OperationKind.Branch, Type: null) (Syntax: 'break;')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,29455,29821);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22059_29731_29805(f_22059_29731_29784(ErrorCode.ERR_SwitchCaseSubsumed, "int y"), 11, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,29837,29953);

f_22059_29837_29952(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,26461,29964);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,26461,29964);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,26461,29964);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestPatternCaseClause_PatternCombinatorsAndRelationalPatterns_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,29976,32941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,30148,30368);

string 
source = @"
class X
{
    void M(char c)
    {
        switch (c)
        {
            /*<bind>*/case (>= 'A' and <= 'Z') or (>= 'a' and <= 'z'):/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,30382,32667);

string 
expectedOperationTree = @"
    IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case (>= 'A ... nd <= 'z'):')
      Pattern: 
        IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: '(>= 'A' and ... and <= 'z')') (InputType: System.Char, NarrowedType: System.Char)
          LeftPattern: 
            IBinaryPatternOperation (BinaryOperatorKind.And) (OperationKind.BinaryPattern, Type: null) (Syntax: '>= 'A' and <= 'Z'') (InputType: System.Char, NarrowedType: System.Char)
              LeftPattern: 
                IRelationalPatternOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '>= 'A'') (InputType: System.Char, NarrowedType: System.Char)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: A) (Syntax: ''A'')
              RightPattern: 
                IRelationalPatternOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '<= 'Z'') (InputType: System.Char, NarrowedType: System.Char)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: Z) (Syntax: ''Z'')
          RightPattern: 
            IBinaryPatternOperation (BinaryOperatorKind.And) (OperationKind.BinaryPattern, Type: null) (Syntax: '>= 'a' and <= 'z'') (InputType: System.Char, NarrowedType: System.Char)
              LeftPattern: 
                IRelationalPatternOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '>= 'a'') (InputType: System.Char, NarrowedType: System.Char)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: a) (Syntax: ''a'')
              RightPattern: 
                IRelationalPatternOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '<= 'z'') (InputType: System.Char, NarrowedType: System.Char)
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: z) (Syntax: ''z'')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,32681,32734);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,32750,32930);

f_22059_32750_32929(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,29976,32941);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,29976,32941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,29976,32941);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestPatternCaseClause_TypePatterns_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22059,32953,34797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,33098,33297);

string 
source = @"
class X
{
    void M(object o)
    {
        switch (o)
        {
            /*<bind>*/case int or long or bool:/*</bind>*/
                break;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,33311,34523);

string 
expectedOperationTree = @"
    IPatternCaseClauseOperation (Label Id: 0) (CaseKind.Pattern) (OperationKind.CaseClause, Type: null) (Syntax: 'case int or ... ng or bool:')
      Pattern: 
        IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: 'int or long or bool') (InputType: System.Object, NarrowedType: System.Object)
          LeftPattern: 
            IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: 'int or long') (InputType: System.Object, NarrowedType: System.Object)
              LeftPattern: 
                ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'int') (InputType: System.Object, NarrowedType: System.Int32, MatchedType: System.Int32)
              RightPattern: 
                ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'long') (InputType: System.Object, NarrowedType: System.Int64, MatchedType: System.Int64)
          RightPattern: 
            ITypePatternOperation (OperationKind.TypePattern, Type: null) (Syntax: 'bool') (InputType: System.Object, NarrowedType: System.Boolean, MatchedType: System.Boolean)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,34537,34590);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22059,34606,34786);

f_22059_34606_34785(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22059,32953,34797);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22059,32953,34797);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22059,32953,34797);
}
		}

int
f_22059_1473_1595(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 1473, 1595);
return 0;
}


int
f_22059_2538_2660(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 2538, 2660);
return 0;
}


int
f_22059_3561_3683(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 3561, 3683);
return 0;
}


int
f_22059_4607_4729(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 4607, 4729);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_5856_5911(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 5856, 5911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_5856_5931(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 5856, 5931);
return return_v;
}


int
f_22059_5963_6085(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 5963, 6085);
return 0;
}


int
f_22059_7051_7173(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 7051, 7173);
return 0;
}


int
f_22059_8134_8256(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 8134, 8256);
return 0;
}


int
f_22059_9229_9351(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 9229, 9351);
return 0;
}


int
f_22059_10972_11094(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 10972, 11094);
return 0;
}


int
f_22059_12461_12583(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 12461, 12583);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_13755_13801(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 13755, 13801);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_13755_13820(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 13755, 13820);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_13755_13840(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 13755, 13840);
return return_v;
}


int
f_22059_13872_13994(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 13872, 13994);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_15579_15628(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 15579, 15628);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_15579_15660(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 15579, 15660);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_15579_15680(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 15579, 15680);
return return_v;
}


int
f_22059_15712_15834(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 15712, 15834);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_17073_17128(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 17073, 17128);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_17073_17148(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 17073, 17148);
return return_v;
}


int
f_22059_17180_17299(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IsPatternExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 17180, 17299);
return 0;
}


int
f_22059_18007_18125(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<DefaultSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 18007, 18125);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_19307_19362(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 19307, 19362);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_19307_19382(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 19307, 19382);
return return_v;
}


int
f_22059_19414_19529(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CaseSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 19414, 19529);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_20745_20810(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 20745, 20810);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_20745_20841(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 20745, 20841);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_20745_20861(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 20745, 20861);
return return_v;
}


int
f_22059_20893_21015(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 20893, 21015);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_22125_22172(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 22125, 22172);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_22125_22199(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 22125, 22199);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_22125_22219(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 22125, 22219);
return return_v;
}


int
f_22059_22251_22373(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 22251, 22373);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_23592_23646(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 23592, 23646);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_23592_23665(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 23592, 23665);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_23592_23686(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 23592, 23686);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_23830_23880(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 23830, 23880);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_23830_23899(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 23830, 23899);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_23830_23919(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 23830, 23919);
return return_v;
}


int
f_22059_23951_24073(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 23951, 24073);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25087_25137(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25087, 25137);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25087_25160(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25087, 25160);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25087_25180(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25087, 25180);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25325_25371(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25325, 25371);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25325_25399(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25325, 25399);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25325_25419(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25325, 25419);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25583_25632(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25583, 25632);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25583_25652(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25583, 25652);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25781_25829(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25781, 25829);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25781_25849(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25781, 25849);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25978_26023(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25978, 26023);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_25978_26043(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 25978, 26043);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_26205_26251(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 26205, 26251);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_26205_26270(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 26205, 26270);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_26205_26290(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 26205, 26290);
return return_v;
}


int
f_22059_26322_26437(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<CaseSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 26322, 26437);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_29731_29784(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 29731, 29784);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22059_29731_29805(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 29731, 29805);
return return_v;
}


int
f_22059_29837_29952(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 29837, 29952);
return 0;
}


int
f_22059_32750_32929(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 32750, 32929);
return 0;
}


int
f_22059_34606_34785(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<CasePatternSwitchLabelSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22059, 34606, 34785);
return 0;
}

}
}
