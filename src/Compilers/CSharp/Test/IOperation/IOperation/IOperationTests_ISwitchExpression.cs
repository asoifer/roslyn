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
public partial class IOperationTests_SwitchExpression : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_Basic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,571,2868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,727,894);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { 1 => 2, 3 => 4, _ => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,908,2657);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (3 arms) (OperationKind.SwitchExpression, Type: System.Int32) (Syntax: 'x switch {  ... 4, _ => 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(3):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '1 => 2')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '3 => 4')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '3') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ => 5')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,2671,2724);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,2740,2857);

f_22064_2740_2856(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,571,2868);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,571,2868);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,571,2868);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_NoArms()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,2880,4067);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,3037,3181);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,3195,3477);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (0 arms) (OperationKind.SwitchExpression, Type: System.Object) (Syntax: 'x switch { }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,3491,3925);

var 
expectedDiagnostics = new[] {
f_22064_3805_3909(f_22064_3805_3889(f_22064_3805_3870(ErrorCode.WRN_SwitchExpressionNotExhaustive, "switch"), "_"), 7, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,3939,4056);

f_22064_3939_4055(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,2880,4067);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,2880,4067);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,2880,4067);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_MissingPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,4079,5694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,4244,4393);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,4407,5268);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'x switch { => 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(1):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: '=> 5')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid) (Syntax: '') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                Children(0)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,5282,5552);

var 
expectedDiagnostics = new[] {
f_22064_5470_5536(f_22064_5470_5516(ErrorCode.ERR_MissingPattern, "=>"), 7, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,5566,5683);

f_22064_5566_5682(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,4079,5694);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,4079,5694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,4079,5694);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_BadInput_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,5706,8245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,5868,6027);

string 
source = @"
using System;
class X
{
    void M(object y)
    {
        y = /*<bind>*/x switch { 1 => 2, 3 => 4, _ => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,6041,7746);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (3 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'x switch {  ... 4, _ => 5 }')
  Value: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'x')
      Children(0)
  Arms(3):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '1 => 2')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: ?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '3 => 4')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '3') (InputType: ?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ => 5')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: ?, NarrowedType: ?)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,7760,8103);

var 
expectedDiagnostics = new[] {
f_22064_8001_8087(f_22064_8001_8067(f_22064_8001_8048(ErrorCode.ERR_NameNotInContext, "x"), "x"), 7, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,8117,8234);

f_22064_8117_8233(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,5706,8245);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,5706,8245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,5706,8245);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_NoCommonType_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,8257,10692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,8423,8586);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { 1 => 2, _ => ""Z"" }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,8600,10478);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (2 arms) (OperationKind.SwitchExpression, Type: System.Object) (Syntax: 'x switch {  ...  _ => ""Z"" }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(2):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '1 => 2')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Value: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ => ""Z""')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Value: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '""Z""')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Z"") (Syntax: '""Z""')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,10492,10550);

var 
expectedDiagnostics = new DiagnosticDescription[] { }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,10564,10681);

f_22064_10564_10680(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,8257,10692);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,8257,10692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,8257,10692);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_NoCommonType_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,10704,13509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,10870,11037);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        var z = /*<bind>*/x switch { 1 => 2, _ => ""Z"" }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,11051,12995);

string 
expectedOperationTree = @"
    ISwitchExpressionOperation (2 arms) (OperationKind.SwitchExpression, Type: ?, IsInvalid) (Syntax: 'x switch {  ...  _ => ""Z"" }')
      Value: 
        IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
      Arms(2):
          ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '1 => 2')
            Pattern: 
              IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32?, NarrowedType: System.Int32)
                Value: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            Value: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: ?, IsImplicit) (Syntax: '2')
                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
          ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ => ""Z""')
            Pattern: 
              IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
            Value: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: ?, IsImplicit) (Syntax: '""Z""')
                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""Z"") (Syntax: '""Z""')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,13009,13367);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22064_13269_13351(f_22064_13269_13331(ErrorCode.ERR_SwitchExpressionNoBestType, "switch"), 7, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,13381,13498);

f_22064_13381_13497(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,10704,13509);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,10704,13509);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,10704,13509);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_MissingArrow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,13521,15047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,13684,13839);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { _ /*=>*/ 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,13853,14583);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'x switch { _ /*=>*/ 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(1):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: '_ /*=>*/ 5')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5, IsInvalid) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,14597,14905);

var 
expectedDiagnostics = new[] {
f_22064_14803_14889(f_22064_14803_14869(f_22064_14803_14845(ErrorCode.ERR_SyntaxError, "5"), "=>", ""), 7, 43)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,14919,15036);

f_22064_14919_15035(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,13521,15047);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,13521,15047);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,13521,15047);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_MissingExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,15059,16582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,15227,15382);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { _ => /*5*/ }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,15396,16119);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: ?, IsInvalid) (Syntax: 'x switch { _ => /*5*/ }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(1):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: '_ => /*5*/ ')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Value: 
          IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
            Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,16133,16440);

var 
expectedDiagnostics = new[] {
f_22064_16339_16424(f_22064_16339_16404(f_22064_16339_16385(ErrorCode.ERR_InvalidExprTerm, "}"), "}"), 7, 45)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,16454,16571);

f_22064_16454_16570(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,15059,16582);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,15059,16582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,15059,16582);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_BadPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,16594,18683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,16755,16913);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { NotFound => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,16927,18172);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'x switch {  ... ound => 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(1):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: 'NotFound => 5')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid) (Syntax: 'NotFound') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'NotFound')
                Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'NotFound')
                    Children(0)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,18186,18541);

var 
expectedDiagnostics = new[] {
f_22064_18425_18525(f_22064_18425_18505(f_22064_18425_18479(ErrorCode.ERR_NameNotInContext, "NotFound"), "NotFound"), 7, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,18555,18672);

f_22064_18555_18671(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,16594,18683);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,16594,18683);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,16594,18683);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_BadArmExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,18695,20279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,18862,19020);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { _ => NotFound }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,19034,19768);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: ?, IsInvalid) (Syntax: 'x switch {  ...  NotFound }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(1):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: '_ => NotFound')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Value: 
          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'NotFound')
            Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,19782,20137);

var 
expectedDiagnostics = new[] {
f_22064_20021_20121(f_22064_20021_20101(f_22064_20021_20075(ErrorCode.ERR_NameNotInContext, "NotFound"), "NotFound"), 7, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,20151,20268);

f_22064_20151_20267(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,18695,20279);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,18695,20279);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,18695,20279);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_SubsumedArm()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,20291,22444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,20453,20612);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { _ => 5, 1 => 2 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,20626,21893);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (2 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'x switch {  ... 5, 1 => 2 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(2):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ => 5')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: '1 => 2')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid) (Syntax: '1') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,21907,22302);

var 
expectedDiagnostics = new[] {
f_22064_22218_22286(f_22064_22218_22266(ErrorCode.ERR_SwitchArmSubsumed, "1"), 7, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,22316,22433);

f_22064_22316_22432(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,20291,22444);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,20291,22444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,20291,22444);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_BasicGuard()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,22456,24375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,22617,22791);

string 
source = @"
using System;
class X
{
    void M(int? x, bool b, object y)
    {
        y = /*<bind>*/x switch { 1 when b => 2, _ => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,22805,24166);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (2 arms) (OperationKind.SwitchExpression, Type: System.Int32) (Syntax: 'x switch {  ... 2, _ => 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(2):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '1 when b => 2')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Guard: 
          IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ => 5')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,24180,24233);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,24247,24364);

f_22064_24247_24363(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,22456,24375);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,22456,24375);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,22456,24375);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_FalseGuard()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,24387,26794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,24548,24718);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { 1 => 2, _ when false => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,24732,26093);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (2 arms) (OperationKind.SwitchExpression, Type: System.Int32) (Syntax: 'x switch {  ... alse => 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(2):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '1 => 2')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ when false => 5')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Guard: 
          ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,26107,26652);

var 
expectedDiagnostics = new[] {
f_22064_26524_26636(f_22064_26524_26616(f_22064_26524_26597(ErrorCode.WRN_SwitchExpressionNotExhaustiveWithWhen, "switch"), "0"), 7, 25)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,26666,26783);

f_22064_26666_26782(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,24387,26794);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,24387,26794);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,24387,26794);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_TrueGuard()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,26806,28716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,26966,27135);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { 1 => 2, _ when true => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,27149,28507);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (2 arms) (OperationKind.SwitchExpression, Type: System.Int32) (Syntax: 'x switch {  ... true => 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(2):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '1 => 2')
        Pattern: 
          IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32?, NarrowedType: System.Int32)
            Value: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null) (Syntax: '_ when true => 5')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Guard: 
          ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,28521,28574);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,28588,28705);

f_22064_28588_28704(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,26806,28716);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,26806,28716);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,26806,28716);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_BadGuard()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,28728,30795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,28887,29052);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { _ when NotFound => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,29066,30277);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'x switch {  ... ound => 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(1):
      ISwitchExpressionArmOperation (0 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: '_ when NotFound => 5')
        Pattern: 
          IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32?, NarrowedType: System.Int32?)
        Guard: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'NotFound')
            Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'NotFound')
                Children(0)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,30291,30653);

var 
expectedDiagnostics = new[] {
f_22064_30537_30637(f_22064_30537_30617(f_22064_30537_30591(ErrorCode.ERR_NameNotInContext, "NotFound"), "NotFound"), 7, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,30667,30784);

f_22064_30667_30783(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,28728,30795);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,28728,30795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,28728,30795);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Patterns)]
        [Fact]
        public void SwitchExpression_LocalsClash()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,30807,33429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,30969,31140);

string 
source = @"
using System;
class X
{
    void M(int? x, object y)
    {
        y = /*<bind>*/x switch { int z when x is int z => 5 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,31154,32907);

string 
expectedOperationTree = @"
ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'x switch {  ... nt z => 5 }')
  Value: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Arms(1):
      ISwitchExpressionArmOperation (2 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: 'int z when  ...  int z => 5')
        Pattern: 
          IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null) (Syntax: 'int z') (InputType: System.Int32?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
        Guard: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'x is int z')
            Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'x is int z')
                Value: 
                  IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
                Pattern: 
                  IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int z') (InputType: System.Int32?, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
        Value: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
        Locals: Local_1: System.Int32 z
          Local_2: System.Int32 z
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,32921,33287);

var 
expectedDiagnostics = new[] {
f_22064_33187_33271(f_22064_33187_33251(f_22064_33187_33232(ErrorCode.ERR_LocalDuplicate, "z"), "z"), 7, 54)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,33301,33418);

f_22064_33301_33417(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,30807,33429);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,30807,33429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,30807,33429);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchExpression_BasicFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,33441,38480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,33601,33847);

string 
source = @"
public sealed class MyClass
{
    void M(bool result, int input)
    /*<bind>*/{
        result = input switch
            {
                1 => false,
                _ => true
            };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,33861,33914);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,33928,38357);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

            Jump if False (Regular) to Block[B4]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '1 => false')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'false')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B7]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if False (Regular) to Block[B6]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '_ => true')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Int32, NarrowedType: System.Int32)
                Leaving: {R2}

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'true')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B7]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B4]
        Statements (0)
        Next (Throw) Block[null]
            IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsImplicit) (Syntax: 'input switc ... }')
              Arguments(0)
              Initializer: 
                null
    Block[B7] - Block
        Predecessors: [B3] [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = in ... }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'input switc ... }')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,38371,38469);

f_22064_38371_38468(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,33441,38480);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,33441,38480);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,33441,38480);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32216, "https://github.com/dotnet/roslyn/issues/32216")]
        public void SwitchExpression_CompoundGuard()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,38492,43253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,38722,39000);

string 
source = @"
#pragma warning disable CS8509
public sealed class MyClass
{
    void M(bool result, int input, bool a, bool b)
    /*<bind>*/{
        result = input switch
            {
                1 when a && b => false
            };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,39014,39067);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,39081,43130);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

            Jump if False (Regular) to Block[B6]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '1 when a && b => false')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if False (Regular) to Block[B6]
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (0)
            Jump if False (Regular) to Block[B6]
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
                Leaving: {R2}

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B4]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'false')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B7]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B2] [B3] [B4]
        Statements (0)
        Next (Throw) Block[null]
            IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsImplicit) (Syntax: 'input switc ... }')
              Arguments(0)
              Initializer: 
                null
    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = in ... }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'input switc ... }')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,43144,43242);

f_22064_43144_43241(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,38492,43253);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,38492,43253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,38492,43253);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32216, "https://github.com/dotnet/roslyn/issues/32216")]
        public void SwitchExpression_CompoundInput()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,43265,48200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,43495,43782);

string 
source = @"
#pragma warning disable CS8509
public sealed class MyClass
{
    void M(bool result, bool a, int input1, int input2)
    /*<bind>*/{
        result = (a ? input1 : input2) switch
            {
                1 => false
            };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,43796,43849);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,43863,48077);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
                  Value: 
                    IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input1')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
                  Value: 
                    IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '1 => false')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ? input1 : input2')
                  Pattern: 
                    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Leaving: {R2}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'false')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B8]
                Leaving: {R2}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (0)
        Next (Throw) Block[null]
            IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsImplicit) (Syntax: '(a ? input1 ... }')
              Arguments(0)
              Initializer: 
                null
    Block[B8] - Block
        Predecessors: [B6]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (a ... };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = (a ... }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: '(a ? input1 ... }')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,48091,48189);

f_22064_48091_48188(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,43265,48200);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,43265,48200);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,43265,48200);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32216, "https://github.com/dotnet/roslyn/issues/32216")]
        public void SwitchExpression_BadInput_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,48212,52594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,48440,48682);

string 
source = @"
#pragma warning disable CS8509
public sealed class MyClass
{
    void M(bool result)
    /*<bind>*/{
        result = NotFound switch
            {
                1 => false
            };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,48696,49027);

var 
expectedDiagnostics = new[] {
f_22064_48907_49007(f_22064_48907_48987(f_22064_48907_48961(ErrorCode.ERR_NameNotInContext, "NotFound"), "NotFound"), 7, 18)                }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,49041,52471);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'NotFound')
                  Value: 
                    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'NotFound')
                      Children(0)

            Jump if False (Regular) to Block[B4]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '1 => false')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: ?, IsInvalid, IsImplicit) (Syntax: 'NotFound')
                  Pattern: 
                    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: ?, NarrowedType: System.Int32)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'false')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (0)
        Next (Throw) Block[null]
            IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsInvalid, IsImplicit) (Syntax: 'NotFound sw ... }')
              Arguments(0)
              Initializer: 
                null
    Block[B5] - Block
        Predecessors: [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = No ... };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsInvalid) (Syntax: 'result = No ... }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'NotFound sw ... }')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,52485,52583);

f_22064_52485_52582(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,48212,52594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,48212,52594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,48212,52594);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32216, "https://github.com/dotnet/roslyn/issues/32216")]
        public void SwitchExpression_CompoundConsequence()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,52606,57483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,52842,53142);

string 
source = @"
#pragma warning disable CS8509
public sealed class MyClass
{
    void M(bool result, bool a, int input, bool input1, bool input2)
    /*<bind>*/{
        result = input switch
            {
                1 => (a ? input1 : input2)
            };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,53156,53209);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,53223,57360);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

            Jump if False (Regular) to Block[B6]
                IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '1 => (a ? i ... 1 : input2)')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                  Pattern: 
                    IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: '1') (InputType: System.Int32, NarrowedType: System.Int32)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (0)
            Jump if False (Regular) to Block[B5]
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

            Next (Regular) Block[B4]
        Block[B4] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input1')
                  Value: 
                    IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input1')

            Next (Regular) Block[B7]
                Leaving: {R2}
        Block[B5] - Block
            Predecessors: [B3]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input2')
                  Value: 
                    IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input2')

            Next (Regular) Block[B7]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B2]
        Statements (0)
        Next (Throw) Block[null]
            IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsImplicit) (Syntax: 'input switc ... }')
              Arguments(0)
              Initializer: 
                null
    Block[B7] - Block
        Predecessors: [B4] [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = in ... };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'result = in ... }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'input switc ... }')

        Next (Regular) Block[B8]
            Leaving: {R1}
}

Block[B8] - Exit
    Predecessors: [B7]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,57374,57472);

f_22064_57374_57471(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,52606,57483);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,52606,57483);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,52606,57483);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact, WorkItem(32216, "https://github.com/dotnet/roslyn/issues/32216")]
        public void SwitchExpression_CompoundPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,57495,63570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,57727,58028);

string 
source = @"
#pragma warning disable CS8509
public sealed class MyClass
{
    void M(bool result, bool a, int input, int input1, int input2)
    /*<bind>*/{
        result = input switch
            {
                (a ? input1 : input2) => true
            };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,58042,58342);

var 
expectedDiagnostics = new[] {
f_22064_58237_58322(f_22064_58237_58302(ErrorCode.ERR_ConstantExpected, "a ? input1 : input2"), 9, 18)                }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,58356,63447);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                  Value: 
                    IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'input')

            Next (Regular) Block[B3]
                Entering: {R3}

        .locals {R3}
        {
            CaptureIds: [3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (0)
                Jump if False (Regular) to Block[B5]
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean, IsInvalid) (Syntax: 'a')

                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input1')
                      Value: 
                        IParameterReferenceOperation: input1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'input1')

                Next (Regular) Block[B6]
            Block[B5] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'input2')
                      Value: 
                        IParameterReferenceOperation: input2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'input2')

                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B4] [B5]
                Statements (0)
                Jump if False (Regular) to Block[B8]
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: '(a ? input1 ... t2) => true')
                      Value: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'input')
                      Pattern: 
                        IConstantPatternOperation (OperationKind.ConstantPattern, Type: null, IsInvalid) (Syntax: '(a ? input1 : input2)') (InputType: System.Int32, NarrowedType: System.Int32)
                          Value: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'a ? input1 : input2')
                    Leaving: {R3} {R2}

                Next (Regular) Block[B7]
                    Leaving: {R3}
        }

        Block[B7] - Block
            Predecessors: [B6]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'true')
                  Value: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

            Next (Regular) Block[B9]
                Leaving: {R2}
    }

    Block[B8] - Block
        Predecessors: [B6]
        Statements (0)
        Next (Throw) Block[null]
            IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsInvalid, IsImplicit) (Syntax: 'input switc ... }')
              Arguments(0)
              Initializer: 
                null
    Block[B9] - Block
        Predecessors: [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = in ... };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean, IsInvalid) (Syntax: 'result = in ... }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'input switc ... }')

        Next (Regular) Block[B10]
            Leaving: {R1}
}

Block[B10] - Exit
    Predecessors: [B9]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,63461,63559);

f_22064_63461_63558(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,57495,63570);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,57495,63570);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,57495,63570);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SwitchExpression_Combinators()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22064,63582,73873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,63744,64103);

string 
source = @"
#pragma warning disable CS8509
public sealed class MyClass
{
    bool M(char input)
    /*<bind>*/{
        return input switch
        {
            >= 'A' and <= 'Z' or >= 'a' and <= 'z' => true,
            '_' => false,
            not (>= '0' and <= '9') => true,
            _ => false,
        };
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,64117,64192);

var 
expectedDiagnostics = new DiagnosticDescription[] {
                }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,64206,73693);

string 
expectedFlowGraph = @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
            Entering: {R1} {R2}
    .locals {R1}
    {
        CaptureIds: [0]
        .locals {R2}
        {
            CaptureIds: [1]
            Block[B1] - Block
                Predecessors: [B0]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'input')
                      Value: 
                        IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Char) (Syntax: 'input')
                Jump if False (Regular) to Block[B3]
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '>= 'A' and  ... 'z' => true')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Char, IsImplicit) (Syntax: 'input')
                      Pattern: 
                        IBinaryPatternOperation (BinaryOperatorKind.Or) (OperationKind.BinaryPattern, Type: null) (Syntax: '>= 'A' and  ...  and <= 'z'') (InputType: System.Char, NarrowedType: System.Char)
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
                Next (Regular) Block[B2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'true')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Next (Regular) Block[B10]
                    Leaving: {R2}
            Block[B3] - Block
                Predecessors: [B1]
                Statements (0)
                Jump if False (Regular) to Block[B5]
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: ''_' => false')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Char, IsImplicit) (Syntax: 'input')
                      Pattern: 
                        IConstantPatternOperation (OperationKind.ConstantPattern, Type: null) (Syntax: ''_'') (InputType: System.Char, NarrowedType: System.Char)
                          Value: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: _) (Syntax: ''_'')
                Next (Regular) Block[B4]
            Block[B4] - Block
                Predecessors: [B3]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'false')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                Next (Regular) Block[B10]
                    Leaving: {R2}
            Block[B5] - Block
                Predecessors: [B3]
                Statements (0)
                Jump if False (Regular) to Block[B7]
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: 'not (>= '0' ... 9') => true')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Char, IsImplicit) (Syntax: 'input')
                      Pattern: 
                        INegatedPatternOperation (OperationKind.NegatedPattern, Type: null) (Syntax: 'not (>= '0' and <= '9')') (InputType: System.Char, NarrowedType: System.Char)
                          Pattern: 
                            IBinaryPatternOperation (BinaryOperatorKind.And) (OperationKind.BinaryPattern, Type: null) (Syntax: '>= '0' and <= '9'') (InputType: System.Char, NarrowedType: System.Char)
                              LeftPattern: 
                                IRelationalPatternOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '>= '0'') (InputType: System.Char, NarrowedType: System.Char)
                                  Value: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: 0) (Syntax: ''0'')
                              RightPattern: 
                                IRelationalPatternOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.RelationalPattern, Type: null) (Syntax: '<= '9'') (InputType: System.Char, NarrowedType: System.Char)
                                  Value: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Char, Constant: 9) (Syntax: ''9'')
                Next (Regular) Block[B6]
            Block[B6] - Block
                Predecessors: [B5]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'true')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
                Next (Regular) Block[B10]
                    Leaving: {R2}
            Block[B7] - Block
                Predecessors: [B5]
                Statements (0)
                Jump if False (Regular) to Block[B9]
                    IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean) (Syntax: '_ => false')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Char, IsImplicit) (Syntax: 'input')
                      Pattern: 
                        IDiscardPatternOperation (OperationKind.DiscardPattern, Type: null) (Syntax: '_') (InputType: System.Char, NarrowedType: System.Char)
                    Leaving: {R2}
                Next (Regular) Block[B8]
            Block[B8] - Block
                Predecessors: [B7]
                Statements (1)
                    IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'false')
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')
                Next (Regular) Block[B10]
                    Leaving: {R2}
        }
        Block[B9] - Block
            Predecessors: [B7]
            Statements (0)
            Next (Throw) Block[null]
                IObjectCreationOperation (Constructor: System.InvalidOperationException..ctor()) (OperationKind.ObjectCreation, Type: System.InvalidOperationException, IsImplicit) (Syntax: 'input switc ... }')
                  Arguments(0)
                  Initializer: 
                    null
        Block[B10] - Block
            Predecessors: [B2] [B4] [B6] [B8]
            Statements (0)
            Next (Return) Block[B11]
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'input switc ... }')
                Leaving: {R1}
    }
    Block[B11] - Exit
        Predecessors: [B10]
        Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22064,73707,73862);

f_22064_73707_73861(source, expectedFlowGraph, expectedDiagnostics, parseOptions: TestOptions.RegularWithPatternCombinators);
DynAbs.Tracing.TraceSender.TraceExitMethod(22064,63582,73873);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22064,63582,73873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,63582,73873);
}
		}

public IOperationTests_SwitchExpression()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(22064,477,73880);
DynAbs.Tracing.TraceSender.TraceExitConstructor(22064,477,73880);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,477,73880);
}


static IOperationTests_SwitchExpression()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(22064,477,73880);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(22064,477,73880);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22064,477,73880);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(22064,477,73880);

int
f_22064_2740_2856(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 2740, 2856);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_3805_3870(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 3805, 3870);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_3805_3889(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 3805, 3889);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_3805_3909(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 3805, 3909);
return return_v;
}


int
f_22064_3939_4055(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 3939, 4055);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_5470_5516(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 5470, 5516);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_5470_5536(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 5470, 5536);
return return_v;
}


int
f_22064_5566_5682(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 5566, 5682);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_8001_8048(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 8001, 8048);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_8001_8067(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 8001, 8067);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_8001_8087(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 8001, 8087);
return return_v;
}


int
f_22064_8117_8233(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 8117, 8233);
return 0;
}


int
f_22064_10564_10680(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 10564, 10680);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_13269_13331(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 13269, 13331);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_13269_13351(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 13269, 13351);
return return_v;
}


int
f_22064_13381_13497(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 13381, 13497);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_14803_14845(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 14803, 14845);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_14803_14869(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 14803, 14869);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_14803_14889(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 14803, 14889);
return return_v;
}


int
f_22064_14919_15035(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 14919, 15035);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_16339_16385(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 16339, 16385);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_16339_16404(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 16339, 16404);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_16339_16424(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 16339, 16424);
return return_v;
}


int
f_22064_16454_16570(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 16454, 16570);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_18425_18479(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 18425, 18479);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_18425_18505(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 18425, 18505);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_18425_18525(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 18425, 18525);
return return_v;
}


int
f_22064_18555_18671(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 18555, 18671);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_20021_20075(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 20021, 20075);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_20021_20101(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 20021, 20101);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_20021_20121(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 20021, 20121);
return return_v;
}


int
f_22064_20151_20267(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 20151, 20267);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_22218_22266(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 22218, 22266);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_22218_22286(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 22218, 22286);
return return_v;
}


int
f_22064_22316_22432(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 22316, 22432);
return 0;
}


int
f_22064_24247_24363(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 24247, 24363);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_26524_26597(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 26524, 26597);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_26524_26616(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 26524, 26616);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_26524_26636(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 26524, 26636);
return return_v;
}


int
f_22064_26666_26782(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 26666, 26782);
return 0;
}


int
f_22064_28588_28704(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 28588, 28704);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_30537_30591(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 30537, 30591);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_30537_30617(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 30537, 30617);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_30537_30637(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 30537, 30637);
return return_v;
}


int
f_22064_30667_30783(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 30667, 30783);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_33187_33232(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 33187, 33232);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_33187_33251(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 33187, 33251);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_33187_33271(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 33187, 33271);
return return_v;
}


int
f_22064_33301_33417(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SwitchExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 33301, 33417);
return 0;
}


int
f_22064_38371_38468(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 38371, 38468);
return 0;
}


int
f_22064_43144_43241(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 43144, 43241);
return 0;
}


int
f_22064_48091_48188(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 48091, 48188);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_48907_48961(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 48907, 48961);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_48907_48987(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 48907, 48987);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_48907_49007(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 48907, 49007);
return return_v;
}


int
f_22064_52485_52582(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 52485, 52582);
return 0;
}


int
f_22064_57374_57471(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 57374, 57471);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_58237_58302(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 58237, 58302);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22064_58237_58322(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 58237, 58322);
return return_v;
}


int
f_22064_63461_63558(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 63461, 63558);
return 0;
}


int
f_22064_73707_73861(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22064, 73707, 73861);
return 0;
}

}
}
