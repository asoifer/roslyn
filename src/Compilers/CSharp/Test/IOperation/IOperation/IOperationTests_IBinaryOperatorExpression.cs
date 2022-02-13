// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
private const string 
RangeCtorSignature = "System.Range..ctor(System.Index start, System.Index end)"
;

private const string 
RangeStartAtSignature = "System.Range System.Range.StartAt(System.Index start)"
;

private const string 
RangeEndAtSignature = "System.Range System.Range.EndAt(System.Index end)"
;

private const string 
RangeAllSignature = "System.Range System.Range.All.get"
;

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyLiftedBinaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,959,1727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,1095,1214);

var 
source = @"
class C
{
    void F(int? x, int? y)
    {
        var z = /*<bind>*/x + y/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,1230,1618);

string 
expectedOperationTree =
@"
IBinaryOperation (BinaryOperatorKind.Add, IsLifted) (OperationKind.Binary, Type: System.Int32?) (Syntax: 'x + y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,1634,1716);

f_22009_1634_1715(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,959,1727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,959,1727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,959,1727);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyLiftedBinaryOperators2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,1739,2513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,1875,1995);

var 
source = @"
class C
{
    void F(int? x, int? y)
    {
        var z = /*<bind>*/x == y/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,2011,2404);

string 
expectedOperationTree =
@"
IBinaryOperation (BinaryOperatorKind.Equals, IsLifted) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x == y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,2420,2502);

f_22009_2420_2501(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,1739,2513);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,1739,2513);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,1739,2513);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyLiftedBinaryOperators3()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,2525,3331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,2661,2813);

var 
source = @"
class C
{
    void F(int? x, int? y)
    {
        if (/*<bind>*/x == y/*</bind>*/)                
            x = y;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,2829,3222);

string 
expectedOperationTree =
@"
IBinaryOperation (BinaryOperatorKind.Equals, IsLifted) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x == y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,3238,3320);

f_22009_3238_3319(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,2525,3331);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,2525,3331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,2525,3331);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyLiftedBinaryOperators4()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,3343,4420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,3479,3615);

var 
source = @"
class C
{
    void F(int? x, int? y)
    {
        if (/*<bind>*/x == 1/*</bind>*/)
            x = y;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,3631,4311);

string 
expectedOperationTree =
@"
IBinaryOperation (BinaryOperatorKind.Equals, IsLifted) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x == 1')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Right: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: '1')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,4327,4409);

f_22009_4327_4408(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,3343,4420);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,3343,4420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,3343,4420);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyNonLiftedBinaryOperators2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,4432,5206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,4571,4710);

var 
source = @"
class C
{
    void F(int? x, int? y)
    {
        if (/*<bind>*/x == null/*</bind>*/)
            x = y;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,4726,5097);

string 
expectedOperationTree =
@"
IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'x == null')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Right: 
    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,5113,5195);

f_22009_5113_5194(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,4432,5206);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,4432,5206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,4432,5206);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyNonLiftedBinaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,5218,5974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,5357,5474);

var 
source = @"
class C
{
    void F(int x, int y)
    {
        var z = /*<bind>*/x + y/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,5490,5865);

string 
expectedOperationTree =
@"
IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,5881,5963);

f_22009_5881_5962(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,5218,5974);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,5218,5974);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,5218,5974);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyLiftedCheckedBinaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,5986,6917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,6129,6296);

string 
source = @"
class C
{
    void F(int? x, int? y)
    {
        checked
        {
            var z = /*<bind>*/x + y/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,6310,6706);

string 
expectedOperationTree = @"
IBinaryOperation (BinaryOperatorKind.Add, IsLifted, Checked) (OperationKind.Binary, Type: System.Int32?) (Syntax: 'x + y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,6720,6773);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,6789,6906);

f_22009_6789_6905(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,5986,6917);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,5986,6917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,5986,6917);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyNonLiftedCheckedBinaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,6929,7848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,7075,7240);

string 
source = @"
class C
{
    void F(int x, int y)
    {
        checked
        {
            var z = /*<bind>*/x + y/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,7254,7637);

string 
expectedOperationTree = @"
IBinaryOperation (BinaryOperatorKind.Add, Checked) (OperationKind.Binary, Type: System.Int32) (Syntax: 'x + y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,7651,7704);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,7720,7837);

f_22009_7720_7836(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,6929,7848);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,6929,7848);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,6929,7848);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyLiftedUserDefinedBinaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,7860,8697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,8007,8171);

var 
source = @"
struct C
{
    public static C operator +(C c1, C c2) { }
    void F(C? x, C? y)
    {
        var z = /*<bind>*/x + y/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,8187,8588);

string 
expectedOperationTree =
@"
IBinaryOperation (BinaryOperatorKind.Add, IsLifted) (OperatorMethod: C C.op_Addition(C c1, C c2)) (OperationKind.Binary, Type: C?) (Syntax: 'x + y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: C?) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: C?) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,8604,8686);

f_22009_8604_8685(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,7860,8697);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,7860,8697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,7860,8697);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyNonLiftedUserDefinedBinaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,8709,9534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,8859,9021);

var 
source = @"
struct C
{
    public static C operator +(C c1, C c2) { }
    void F(C x, C y)
    {
        var z = /*<bind>*/x + y/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,9037,9425);

string 
expectedOperationTree =
@"
IBinaryOperation (BinaryOperatorKind.Add) (OperatorMethod: C C.op_Addition(C c1, C c2)) (OperationKind.Binary, Type: C) (Syntax: 'x + y')
  Left: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: C) (Syntax: 'x')
  Right: 
    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: C) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,9441,9523);

f_22009_9441_9522(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,8709,9534);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,8709,9534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,8709,9534);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestBinaryOperators()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,9546,20265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,9673,10078);

string 
source = @"
using System;
class C
{
    void M(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l, int m, int n, int o, int p)
    {
        /*<bind>*/Console.WriteLine(
            (a >> 10) + (b << 20) - c * d / e % f & g |
            h ^ (i == (j != ((((k < l ? 1 : 0) > m ? 1 : 0) <= o ? 1 : 0) >= p ? 1 : 0) ? 1 : 0) ? 1 : 0))/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,10092,20050);

string 
expectedOperationTree = @"
IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ) ? 1 : 0))')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '(a >> 10) + ... 0) ? 1 : 0)')
        IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a >> 10) + ... 0) ? 1 : 0)')
          Left: 
            IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a >> 10) + ... / e % f & g')
              Left: 
                IBinaryOperation (BinaryOperatorKind.Subtract) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a >> 10) + ... * d / e % f')
                  Left: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a >> 10) + (b << 20)')
                      Left: 
                        IBinaryOperation (BinaryOperatorKind.RightShift) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a >> 10')
                          Left: 
                            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
                      Right: 
                        IBinaryOperation (BinaryOperatorKind.LeftShift) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b << 20')
                          Left: 
                            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Remainder) (OperationKind.Binary, Type: System.Int32) (Syntax: 'c * d / e % f')
                      Left: 
                        IBinaryOperation (BinaryOperatorKind.Divide) (OperationKind.Binary, Type: System.Int32) (Syntax: 'c * d / e')
                          Left: 
                            IBinaryOperation (BinaryOperatorKind.Multiply) (OperationKind.Binary, Type: System.Int32) (Syntax: 'c * d')
                              Left: 
                                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')
                              Right: 
                                IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'd')
                          Right: 
                            IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'e')
                      Right: 
                        IParameterReferenceOperation: f (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'f')
              Right: 
                IParameterReferenceOperation: g (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'g')
          Right: 
            IBinaryOperation (BinaryOperatorKind.ExclusiveOr) (OperationKind.Binary, Type: System.Int32) (Syntax: 'h ^ (i == ( ... 0) ? 1 : 0)')
              Left: 
                IParameterReferenceOperation: h (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'h')
              Right: 
                IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'i == (j !=  ...  0) ? 1 : 0')
                  Condition: 
                    IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i == (j !=  ... 0) ? 1 : 0)')
                      Left: 
                        IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'j != ((((k  ...  0) ? 1 : 0')
                          Condition: 
                            IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j != ((((k  ...  p ? 1 : 0)')
                              Left: 
                                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')
                              Right: 
                                IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: '(((k < l ?  ... = p ? 1 : 0')
                                  Condition: 
                                    IBinaryOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: '(((k < l ?  ... 1 : 0) >= p')
                                      Left: 
                                        IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: '((k < l ? 1 ... = o ? 1 : 0')
                                          Condition: 
                                            IBinaryOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: '((k < l ? 1 ... 1 : 0) <= o')
                                              Left: 
                                                IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: '(k < l ? 1  ... > m ? 1 : 0')
                                                  Condition: 
                                                    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: '(k < l ? 1 : 0) > m')
                                                      Left: 
                                                        IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'k < l ? 1 : 0')
                                                          Condition: 
                                                            IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'k < l')
                                                              Left: 
                                                                IParameterReferenceOperation: k (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'k')
                                                              Right: 
                                                                IParameterReferenceOperation: l (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'l')
                                                          WhenTrue: 
                                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                                          WhenFalse: 
                                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                                      Right: 
                                                        IParameterReferenceOperation: m (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'm')
                                                  WhenTrue: 
                                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                                  WhenFalse: 
                                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                              Right: 
                                                IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'o')
                                          WhenTrue: 
                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                          WhenFalse: 
                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                      Right: 
                                        IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
                                  WhenTrue: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                  WhenFalse: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                          WhenTrue: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          WhenFalse: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                  WhenTrue: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  WhenFalse: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,20064,20117);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,20133,20254);

f_22009_20133_20253(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,9546,20265);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,9546,20265);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,9546,20265);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestBinaryOperators_Checked()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,20277,31091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,20412,20868);

string 
source = @"
using System;
class C
{
    void M(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l, int m, int n, int o, int p)
    {
        checked
        {
            /*<bind>*/Console.WriteLine(
                (a >> 10) + (b << 20) - c * d / e % f & g |
                h ^ (i == (j != ((((k < l ? 1 : 0) > m ? 1 : 0) <= o ? 1 : 0) >= p ? 1 : 0) ? 1 : 0) ? 1 : 0))/*</bind>*/;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,20882,30876);

string 
expectedOperationTree = @"
IInvocationOperation (void System.Console.WriteLine(System.Int32 value)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... ) ? 1 : 0))')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: value) (OperationKind.Argument, Type: null) (Syntax: '(a >> 10) + ... 0) ? 1 : 0)')
        IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a >> 10) + ... 0) ? 1 : 0)')
          Left: 
            IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a >> 10) + ... / e % f & g')
              Left: 
                IBinaryOperation (BinaryOperatorKind.Subtract, Checked) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a >> 10) + ... * d / e % f')
                  Left: 
                    IBinaryOperation (BinaryOperatorKind.Add, Checked) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a >> 10) + (b << 20)')
                      Left: 
                        IBinaryOperation (BinaryOperatorKind.RightShift) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a >> 10')
                          Left: 
                            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
                      Right: 
                        IBinaryOperation (BinaryOperatorKind.LeftShift) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b << 20')
                          Left: 
                            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
                          Right: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20) (Syntax: '20')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Remainder) (OperationKind.Binary, Type: System.Int32) (Syntax: 'c * d / e % f')
                      Left: 
                        IBinaryOperation (BinaryOperatorKind.Divide, Checked) (OperationKind.Binary, Type: System.Int32) (Syntax: 'c * d / e')
                          Left: 
                            IBinaryOperation (BinaryOperatorKind.Multiply, Checked) (OperationKind.Binary, Type: System.Int32) (Syntax: 'c * d')
                              Left: 
                                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')
                              Right: 
                                IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'd')
                          Right: 
                            IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'e')
                      Right: 
                        IParameterReferenceOperation: f (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'f')
              Right: 
                IParameterReferenceOperation: g (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'g')
          Right: 
            IBinaryOperation (BinaryOperatorKind.ExclusiveOr) (OperationKind.Binary, Type: System.Int32) (Syntax: 'h ^ (i == ( ... 0) ? 1 : 0)')
              Left: 
                IParameterReferenceOperation: h (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'h')
              Right: 
                IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'i == (j !=  ...  0) ? 1 : 0')
                  Condition: 
                    IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'i == (j !=  ... 0) ? 1 : 0)')
                      Left: 
                        IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
                      Right: 
                        IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'j != ((((k  ...  0) ? 1 : 0')
                          Condition: 
                            IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'j != ((((k  ...  p ? 1 : 0)')
                              Left: 
                                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')
                              Right: 
                                IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: '(((k < l ?  ... = p ? 1 : 0')
                                  Condition: 
                                    IBinaryOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: '(((k < l ?  ... 1 : 0) >= p')
                                      Left: 
                                        IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: '((k < l ? 1 ... = o ? 1 : 0')
                                          Condition: 
                                            IBinaryOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: '((k < l ? 1 ... 1 : 0) <= o')
                                              Left: 
                                                IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: '(k < l ? 1  ... > m ? 1 : 0')
                                                  Condition: 
                                                    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: '(k < l ? 1 : 0) > m')
                                                      Left: 
                                                        IConditionalOperation (OperationKind.Conditional, Type: System.Int32) (Syntax: 'k < l ? 1 : 0')
                                                          Condition: 
                                                            IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'k < l')
                                                              Left: 
                                                                IParameterReferenceOperation: k (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'k')
                                                              Right: 
                                                                IParameterReferenceOperation: l (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'l')
                                                          WhenTrue: 
                                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                                          WhenFalse: 
                                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                                      Right: 
                                                        IParameterReferenceOperation: m (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'm')
                                                  WhenTrue: 
                                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                                  WhenFalse: 
                                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                              Right: 
                                                IParameterReferenceOperation: o (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'o')
                                          WhenTrue: 
                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                          WhenFalse: 
                                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                                      Right: 
                                        IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
                                  WhenTrue: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                                  WhenFalse: 
                                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                          WhenTrue: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                          WhenFalse: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                  WhenTrue: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
                  WhenFalse: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,30890,30943);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,30959,31080);

f_22009_30959_31079(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,20277,31091);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,20277,31091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,20277,31091);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,31103,34345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,31251,31422);

string 
source = @"
class P
{
    void M(bool a, bool b)
/*<bind>*/{
        GetArray()[0] =  a || b;
    }/*</bind>*/

    static bool[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,31436,34157);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Boolean) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Boolean[] P.GetArray()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Jump if True (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'a')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[0] =  a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'GetArray()[0] =  a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,34171,34224);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,34240,34334);

f_22009_34240_34333(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,31103,34345);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,31103,34345);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,31103,34345);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,34357,38268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,34505,34691);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c)
/*<bind>*/{
        GetArray()[0] =  c && (a || b);
    }/*</bind>*/

    static bool[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,34705,38080);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Boolean) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Boolean[] P.GetArray()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Jump if False (Regular) to Block[B5]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B4]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B6]
    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'a')

        Next (Regular) Block[B6]
    Block[B5] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'c')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B3] [B4] [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... & (a || b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'GetArray()[ ... && (a || b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c && (a || b)')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,38094,38147);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,38163,38257);

f_22009_38163_38256(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,34357,38268);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,34357,38268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,34357,38268);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,38280,41855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,38428,38614);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c)
/*<bind>*/{
        GetArray()[0] =  c && (a && b);
    }/*</bind>*/

    static bool[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,38628,41667);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Boolean) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Boolean[] P.GetArray()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B4] - Block
        Predecessors: [B1] [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c && (a && b)')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'c && (a && b)')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... & (a && b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'GetArray()[ ... && (a && b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c && (a && b)')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,41681,41734);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,41750,41844);

f_22009_41750_41843(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,38280,41855);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,38280,41855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,38280,41855);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,41867,45439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,42015,42201);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c)
/*<bind>*/{
        GetArray()[0] =  c || (a || b);
    }/*</bind>*/

    static bool[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,42215,45251);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Boolean) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Boolean[] P.GetArray()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Jump if True (Regular) to Block[B4]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B4]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B4] - Block
        Predecessors: [B1] [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c || (a || b)')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'c || (a || b)')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... | (a || b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'GetArray()[ ... || (a || b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c || (a || b)')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,45265,45318);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,45334,45428);

f_22009_45334_45427(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,41867,45439);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,41867,45439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,41867,45439);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,45451,50051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,45599,45815);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c, bool d, bool e)
/*<bind>*/{
        GetArray()[0] =  a && (b || (c && (d || e)));
    }/*</bind>*/

    static bool[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,45829,49863);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Boolean) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Boolean[] P.GetArray()) (OperationKind.Invocation, Type: System.Boolean[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Jump if False (Regular) to Block[B7]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B6]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Jump if False (Regular) to Block[B7]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B3]
        Statements (0)
        Jump if True (Regular) to Block[B6]
            IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B4]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'e')
              Value: 
                IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'e')

        Next (Regular) Block[B8]
    Block[B6] - Block
        Predecessors: [B2] [B4]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b || (c && (d || e))')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'b || (c && (d || e))')

        Next (Regular) Block[B8]
    Block[B7] - Block
        Predecessors: [B1] [B3]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && (b ||  ...  (d || e)))')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'a && (b ||  ...  (d || e)))')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B5] [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... (d || e)));')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'GetArray()[ ...  (d || e)))')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a && (b ||  ...  (d || e)))')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,49877,49930);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,49946,50040);

f_22009_49946_50039(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,45451,50051);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,45451,50051);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,45451,50051);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,50063,53262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,50211,50352);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c, bool d)
/*<bind>*/{
        a = b && !(c || d);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,50366,53074);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B4]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd')
              Value: 
                IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'd')
                  Operand: 
                    IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

        Next (Regular) Block[B5]
    Block[B4] - Block
        Predecessors: [B1] [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b && !(c || d)')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'b && !(c || d)')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = b && !(c || d);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = b && !(c || d)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b && !(c || d)')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,53088,53141);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,53157,53251);

f_22009_53157_53250(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,50063,53262);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,50063,53262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,50063,53262);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,53274,56807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,53422,53563);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c, bool d)
/*<bind>*/{
        a = b || !(c || d);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,53577,56619);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Jump if True (Regular) to Block[B5]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if True (Regular) to Block[B4]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd')
              Value: 
                IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'd')
                  Operand: 
                    IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

        Next (Regular) Block[B6]
    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'c')

        Next (Regular) Block[B6]
    Block[B5] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'b')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B3] [B4] [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = b || !(c || d);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = b || !(c || d)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b || !(c || d)')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,56633,56686);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,56702,56796);

f_22009_56702_56795(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,53274,56807);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,53274,56807);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,53274,56807);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,56819,60354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,56967,57108);

string 
source = @"
class P
{
    void M(bool a, bool b, bool c, bool d)
/*<bind>*/{
        a = b && !(c && d);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,57122,60166);

string 
expectedGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Jump if False (Regular) to Block[B5]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd')
              Value: 
                IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'd')
                  Operand: 
                    IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'd')

        Next (Regular) Block[B6]
    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True, IsImplicit) (Syntax: 'c')

        Next (Regular) Block[B6]
    Block[B5] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'b')

        Next (Regular) Block[B6]
    Block[B6] - Block
        Predecessors: [B3] [B4] [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = b && !(c && d);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = b && !(c && d)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'b && !(c && d)')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,60180,60233);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,60249,60343);

f_22009_60249_60342(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,56819,60354);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,56819,60354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,56819,60354);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,60366,64933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,60517,60710);

string 
source = @"
using System;
class C
{
    void M(int? a, int b)
    /*<bind>*/{
        GetArray()[0] = (a ?? b) + b;
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,60724,60777);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,60793,64814);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ...  ?? b) + b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ... a ?? b) + b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a ?? b) + b')
                      Left: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,64828,64922);

f_22009_64828_64921(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,60366,64933);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,60366,64933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,60366,64933);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,64945,69777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,65096,65289);

string 
source = @"
using System;
class C
{
    void M(int? a, int b)
    /*<bind>*/{
        GetArray()[0] = b + (a ?? b);
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,65303,65356);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,65370,69658);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... + (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ...  + (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b + (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,69672,69766);

f_22009_69672_69765(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,64945,69777);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,64945,69777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,64945,69777);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,69789,76297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,69940,70140);

string 
source = @"
using System;
class C
{
    void M(int? a, int b)
    /*<bind>*/{
        GetArray()[0] = (a ?? b) + (a ?? b);
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,70154,70207);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,70223,76178);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... + (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ...  + (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a ?? b) + (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')
                      Right: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,76192,76286);

f_22009_76192_76285(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,69789,76297);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,69789,76297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,69789,76297);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,76309,82311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,76460,76709);

string 
source = @"
using System;
class C
{
    void M(C a, C b)
    /*<bind>*/{
        GetArray()[0] = (a ?? b) + (a ?? b);
    }/*</bind>*/

    static int[] GetArray() => null;

    public static int operator +(C c1, C c2) => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,76723,76776);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,76792,82192);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... + (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ...  + (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Add) (OperatorMethod: System.Int32 C.op_Addition(C c1, C c2)) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a ?? b) + (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a ?? b')
                      Right: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,82206,82300);

f_22009_82206_82299(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,76309,82311);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,76309,82311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,76309,82311);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,82323,87162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,82474,82667);

string 
source = @"
using System;
class C
{
    void M(int? a, int b)
    /*<bind>*/{
        GetArray()[0] = b - (a ?? b);
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,82681,82734);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,82750,87043);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... - (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ...  - (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Subtract) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b - (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,87057,87151);

f_22009_87057_87150(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,82323,87162);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,82323,87162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,82323,87162);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,87174,92016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,87325,87519);

string 
source = @"
using System;
class C
{
    void M(int? a, int b)
    /*<bind>*/{
        GetArray()[0] = b << (a ?? b);
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,87533,87586);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,87602,91897);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... < (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ... << (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.LeftShift) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b << (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,91911,92005);

f_22009_91911_92004(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,87174,92016);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,87174,92016);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,87174,92016);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,92028,96867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,92179,92372);

string 
source = @"
using System;
class C
{
    void M(int? a, int b)
    /*<bind>*/{
        GetArray()[0] = b * (a ?? b);
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,92386,92439);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,92455,96748);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... * (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ...  * (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Multiply) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b * (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,96762,96856);

f_22009_96762_96855(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,92028,96867);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,92028,96867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,92028,96867);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,96879,101716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,97030,97223);

string 
source = @"
using System;
class C
{
    void M(int? a, int b)
    /*<bind>*/{
        GetArray()[0] = b / (a ?? b);
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,97237,97290);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,97306,101597);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... / (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ...  / (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Divide) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b / (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,101611,101705);

f_22009_101611_101704(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,96879,101716);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,96879,101716);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,96879,101716);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,101728,106568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,101879,102072);

string 
source = @"
using System;
class C
{
    void M(int? a, int b)
    /*<bind>*/{
        GetArray()[0] = b % (a ?? b);
    }/*</bind>*/

    static int[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,102086,102139);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,102155,106449);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'GetArray()[0]')
              Value: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'GetArray()[0]')
                  Array reference: 
                    IInvocationOperation (System.Int32[] C.GetArray()) (OperationKind.Invocation, Type: System.Int32[]) (Syntax: 'GetArray()')
                      Instance Receiver: 
                        null
                      Arguments(0)
                  Indices(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ... % (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'GetArray()[ ...  % (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'GetArray()[0]')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Remainder) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b % (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,106463,106557);

f_22009_106463_106556(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,101728,106568);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,101728,106568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,101728,106568);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,106580,110898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,106731,106880);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, bool c)
    /*<bind>*/{
        c = b < (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,106894,106947);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,106963,110775);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b < (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = b < (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.LessThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'b < (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,110789,110887);

f_22009_110789_110886(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,106580,110898);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,106580,110898);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,106580,110898);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,110910,115231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,111061,111210);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, bool c)
    /*<bind>*/{
        c = b > (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,111224,111277);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,111293,115108);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b > (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = b > (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.GreaterThan) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'b > (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,115122,115220);

f_22009_115122_115219(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,110910,115231);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,110910,115231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,110910,115231);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,115243,119572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,115394,115544);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, bool c)
    /*<bind>*/{
        c = b <= (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,115558,115611);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,115627,119449);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b <= (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = b <= (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.LessThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'b <= (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,119463,119561);

f_22009_119463_119560(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,115243,119572);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,115243,119572);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,115243,119572);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,119584,123916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,119735,119885);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, bool c)
    /*<bind>*/{
        c = b >= (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,119899,119952);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,119968,123793);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b >= (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = b >= (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.GreaterThanOrEqual) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'b >= (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,123807,123905);

f_22009_123807_123904(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,119584,123916);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,119584,123916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,119584,123916);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,123928,128248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,124079,124229);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, bool c)
    /*<bind>*/{
        c = b == (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,124243,124296);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,124312,128125);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b == (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = b == (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Equals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'b == (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,128139,128237);

f_22009_128139_128236(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,123928,128248);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,123928,128248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,123928,128248);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,128260,132583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,128411,128561);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, bool c)
    /*<bind>*/{
        c = b != (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,128575,128628);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,128644,132460);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b != (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = b != (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.NotEquals) (OperationKind.Binary, Type: System.Boolean) (Syntax: 'b != (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,132474,132572);

f_22009_132474_132571(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,128260,132583);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,128260,132583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,128260,132583);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,132595,136899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,132746,132894);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, int c)
    /*<bind>*/{
        c = b & (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,132908,132961);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,132977,136776);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b & (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'c = b & (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b & (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,136790,136888);

f_22009_136790_136887(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,132595,136899);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,132595,136899);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,132595,136899);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,136911,141214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,137062,137210);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, int c)
    /*<bind>*/{
        c = b | (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,137224,137277);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,137293,141091);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b | (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'c = b | (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b | (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,141105,141203);

f_22009_141105_141202(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,136911,141214);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,136911,141214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,136911,141214);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NonLogicalFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,141226,145538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,141377,141525);

string 
source = @"
using System;
class C
{
    void M(int? a, int b, int c)
    /*<bind>*/{
        c = b ^ (a ?? b);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,141539,141592);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,141608,145415);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'a')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'a')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = b ^ (a ?? b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'c = b ^ (a ?? b)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'c')
                  Right: 
                    IBinaryOperation (BinaryOperatorKind.ExclusiveOr) (OperationKind.Binary, Type: System.Int32) (Syntax: 'b ^ (a ?? b)')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b')
                      Right: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ?? b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,145429,145527);

f_22009_145429_145526(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,141226,145538);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,141226,145538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,141226,145538);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalNullableFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,145550,147912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,145706,145844);

string 
source = @"
class P
{
    void M(bool? a, bool? b, bool? result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,145858,147438);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a || b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean?, IsInvalid) (Syntax: 'result = a || b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean?, IsInvalid, IsImplicit) (Syntax: 'a || b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean?, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,147452,147791);

var 
expectedDiagnostics = new[] {
f_22009_147669_147775(f_22009_147669_147755(f_22009_147669_147717(ErrorCode.ERR_BadBinaryOps, "a || b"), "||", "bool?", "bool?"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,147807,147901);

f_22009_147807_147900(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,145550,147912);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,145550,147912);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,145550,147912);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalNullableFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,147924,150287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,148080,148218);

string 
source = @"
class P
{
    void M(bool? a, bool? b, bool? result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,148232,149813);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean?, IsInvalid) (Syntax: 'result = a && b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean?, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean?, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,149827,150166);

var 
expectedDiagnostics = new[] {
f_22009_150044_150150(f_22009_150044_150130(f_22009_150044_150092(ErrorCode.ERR_BadBinaryOps, "a && b"), "&&", "bool?", "bool?"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,150182,150276);

f_22009_150182_150275(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,147924,150287);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,147924,150287);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,147924,150287);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalNullableFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,150299,155491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,150455,150626);

string 
source = @"
class P
{
    void M(bool? a, P b, P c, bool? result)
/*<bind>*/{
        result = a || (b ?? c).F;
    }/*</bind>*/

    bool? F = null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,150640,154999);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'result')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?, IsInvalid) (Syntax: 'a')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
                  Value: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: P, IsInvalid) (Syntax: 'b')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'b')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: P, IsInvalid) (Syntax: 'c')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a  ... (b ?? c).F;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean?, IsInvalid) (Syntax: 'result = a || (b ?? c).F')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean?, IsInvalid, IsImplicit) (Syntax: 'a || (b ?? c).F')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || (b ?? c).F')
                          Left: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsInvalid, IsImplicit) (Syntax: 'a')
                          Right: 
                            IFieldReferenceOperation: System.Boolean? P.F (OperationKind.FieldReference, Type: System.Boolean?, IsInvalid) (Syntax: '(b ?? c).F')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b ?? c')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,155013,155370);

var 
expectedDiagnostics = new[] {
f_22009_155239_155354(f_22009_155239_155334(f_22009_155239_155296(ErrorCode.ERR_BadBinaryOps, "a || (b ?? c).F"), "||", "bool?", "bool?"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,155386,155480);

f_22009_155386_155479(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,150299,155491);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,150299,155491);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,150299,155491);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalNullableFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,155503,160404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,155659,155830);

string 
source = @"
class P
{
    void M(bool? a, P b, P c, bool? result)
/*<bind>*/{
        result = (b ?? c).F && a;
    }/*</bind>*/

    bool? F = null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,155844,159912);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Boolean?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
                  Value: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: P, IsInvalid) (Syntax: 'b')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'b')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: P, IsInvalid) (Syntax: 'c')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = (b ...  c).F && a;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean?, IsInvalid) (Syntax: 'result = (b ?? c).F && a')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean?, IsInvalid, IsImplicit) (Syntax: '(b ?? c).F && a')
                      Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (NoConversion)
                      Operand: 
                        IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: '(b ?? c).F && a')
                          Left: 
                            IFieldReferenceOperation: System.Boolean? P.F (OperationKind.FieldReference, Type: System.Boolean?, IsInvalid) (Syntax: '(b ?? c).F')
                              Instance Receiver: 
                                IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: P, IsInvalid, IsImplicit) (Syntax: 'b ?? c')
                          Right: 
                            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?, IsInvalid) (Syntax: 'a')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,159926,160283);

var 
expectedDiagnostics = new[] {
f_22009_160152_160267(f_22009_160152_160247(f_22009_160152_160209(ErrorCode.ERR_BadBinaryOps, "(b ?? c).F && a"), "&&", "bool?", "bool?"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,160299,160393);

f_22009_160299_160392(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,155503,160404);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,155503,160404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,155503,160404);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,160416,164485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,160575,160934);

string 
source = @"
class C
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,160948,164297);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean C.op_True(C c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperatorMethod: C C.op_BitwiseOr(C x, C y)) (OperationKind.Binary, Type: C) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,164311,164364);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,164380,164474);

f_22009_164380_164473(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,160416,164485);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,160416,164485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,160416,164485);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,164497,168570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,164656,165015);

string 
source = @"
class C
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,165029,168382);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.False) (OperatorMethod: System.Boolean C.op_False(C c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperatorMethod: C C.op_BitwiseAnd(C x, C y)) (OperationKind.Binary, Type: C) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,168396,168449);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,168465,168559);

f_22009_168465_168558(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,164497,168570);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,164497,168570);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,164497,168570);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,168582,174151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,168741,169112);

string 
source = @"
class C
{
    void M(C a, C b, C c, C result)
/*<bind>*/{
        result = (a ?? c) || b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,169126,173963);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                  Value: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean C.op_True(C c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a ?? c')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a ?? c')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(a ?? c) || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a ?? c')

            Next (Regular) Block[B8]
                Leaving: {R2}
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(a ?? c) || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperatorMethod: C C.op_BitwiseOr(C x, C y)) (OperationKind.Binary, Type: C) (Syntax: '(a ?? c) || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a ?? c')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B8]
                Leaving: {R2}
    }

    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (a ?? c) || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result = (a ?? c) || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: '(a ?? c) || b')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,173977,174030);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,174046,174140);

f_22009_174046_174139(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,168582,174151);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,168582,174151);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,168582,174151);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,174163,180269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,174322,174693);

string 
source = @"
class C
{
    void M(C a, C b, C c, C result)
/*<bind>*/{
        result = a && (b ?? c);
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,174707,180081);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.False) (OperatorMethod: System.Boolean C.op_False(C c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                Entering: {R3} {R4}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && (b ?? c)')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B8]
                Leaving: {R2}

        .locals {R3}
        {
            CaptureIds: [4]
            .locals {R4}
            {
                CaptureIds: [3]
                Block[B4] - Block
                    Predecessors: [B2]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                          Value: 
                            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

                    Jump if True (Regular) to Block[B6]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                          Operand: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'b')
                        Leaving: {R4}

                    Next (Regular) Block[B5]
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (1)
                        IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                          Value: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'b')

                    Next (Regular) Block[B7]
                        Leaving: {R4}
            }

            Block[B6] - Block
                Predecessors: [B4]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                      Value: 
                        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

                Next (Regular) Block[B7]
            Block[B7] - Block
                Predecessors: [B5] [B6]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && (b ?? c)')
                      Value: 
                        IBinaryOperation (BinaryOperatorKind.And) (OperatorMethod: C C.op_BitwiseAnd(C x, C y)) (OperationKind.Binary, Type: C) (Syntax: 'a && (b ?? c)')
                          Left: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                          Right: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'b ?? c')

                Next (Regular) Block[B8]
                    Leaving: {R3} {R2}
        }
    }

    Block[B8] - Block
        Predecessors: [B3] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && (b ?? c);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result = a && (b ?? c)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a && (b ?? c)')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,180095,180148);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,180164,180258);

f_22009_180164_180257(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,174163,180269);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,174163,180269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,174163,180269);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,180281,182548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,180440,180566);

string 
source = @"
class C
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,180580,182090);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a || b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsInvalid) (Syntax: 'result = a || b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsInvalid, IsImplicit) (Syntax: 'a || b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,182104,182427);

var 
expectedDiagnostics = new[] {
f_22009_182313_182411(f_22009_182313_182391(f_22009_182313_182361(ErrorCode.ERR_BadBinaryOps, "a || b"), "||", "C", "C"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,182443,182537);

f_22009_182443_182536(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,180281,182548);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,180281,182548);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,180281,182548);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,182560,185175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,182719,183094);

string 
source = @"
class B {}
class C : B
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static B operator &(C x, C y) => throw null;
    public static B operator |(C x, C y) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,183108,184618);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a || b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsInvalid) (Syntax: 'result = a || b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsInvalid, IsImplicit) (Syntax: 'a || b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,184632,185054);

var 
expectedDiagnostics = new[] {
f_22009_184937_185038(f_22009_184937_185018(f_22009_184937_184982(ErrorCode.ERR_BadBoolOp, "a || b"), "C.operator |(C, C)"), 7, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,185070,185164);

f_22009_185070_185163(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,182560,185175);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,182560,185175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,182560,185175);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,185187,187666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,185346,185588);

string 
source = @"
class C
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,185602,187113);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsInvalid) (Syntax: 'result = a && b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,187127,187545);

var 
expectedDiagnostics = new[] {
f_22009_187420_187529(f_22009_187420_187509(f_22009_187420_187468(ErrorCode.ERR_MustHaveOpTF, "a && b"), "C.operator &(C, C)", "C"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,187561,187655);

f_22009_187561_187654(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,185187,187666);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,185187,187666);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,185187,187666);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,187678,190318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,187837,188284);

string 
source = @"
class C
{
    void M(B3 a, B2 b, object result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    class B2
    {
        public static B2 operator &(B3 x, B2 y) => throw null;
        public static B2 operator |(B3 x, B2 y) => throw null;
    }
    class B3
    {
        public static B3 operator &(B3 x, B2 y) => throw null;
        public static B3 operator |(B3 x, B2 y) => throw null;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,188298,189851);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Object, IsInvalid) (Syntax: 'result = a && b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C.B3, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C.B2, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,189865,190197);

var 
expectedDiagnostics = new[] {
f_22009_190075_190181(f_22009_190075_190161(f_22009_190075_190125(ErrorCode.ERR_AmbigBinaryOps, "a && b"), "&&", "C.B3", "C.B2"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,190213,190307);

f_22009_190213_190306(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,187678,190318);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,187678,190318);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,187678,190318);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,190330,192934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,190489,190852);

string 
source = @"
struct C
{
    void M(C? a, C? b, C? result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,190866,192381);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a || b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C?, IsInvalid) (Syntax: 'result = a || b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C?) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a || b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,192395,192813);

var 
expectedDiagnostics = new[] {
f_22009_192688_192797(f_22009_192688_192777(f_22009_192688_192736(ErrorCode.ERR_MustHaveOpTF, "a || b"), "C.operator |(C, C)", "C"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,192829,192923);

f_22009_192829_192922(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,190330,192934);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,190330,192934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,190330,192934);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,192946,197041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,193105,193476);

string 
source = @"
struct C
{
    void M(C? a, C? b, C? result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C? operator &(C? x, C? y) => throw null;
    public static C? operator |(C? x, C? y) => throw null;
    public static bool operator true(C? c) => throw null;
    public static bool operator false(C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,193490,196853);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean C.op_True(C? c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperatorMethod: C? C.op_BitwiseOr(C? x, C? y)) (OperationKind.Binary, Type: C?) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C?) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,196867,196920);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,196936,197030);

f_22009_196936_197029(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,192946,197041);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,192946,197041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,192946,197041);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,197053,199541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,197212,197458);

string 
source = @"
struct C
{
    void M(C? a, C? b, C? result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,197472,198988);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C?, IsInvalid) (Syntax: 'result = a && b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C?) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,199002,199420);

var 
expectedDiagnostics = new[] {
f_22009_199295_199404(f_22009_199295_199384(f_22009_199295_199343(ErrorCode.ERR_MustHaveOpTF, "a && b"), "C.operator &(C, C)", "C"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,199436,199530);

f_22009_199436_199529(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,197053,199541);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,197053,199541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,197053,199541);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,199553,204422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,199712,200081);

string 
source = @"
struct C
{
    void M(C a, C b, C? result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C? operator &(C? x, C? y) => throw null;
    public static C? operator |(C? x, C? y) => throw null;
    public static bool operator true(C? c) => throw null;
    public static bool operator false(C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,200095,204234);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C?, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (ImplicitNullable)
                      Operand: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean C.op_True(C? c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperatorMethod: C? C.op_BitwiseOr(C? x, C? y)) (OperationKind.Binary, Type: C?) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')
                      Right: 
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C?, IsImplicit) (Syntax: 'b')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            (ImplicitNullable)
                          Operand: 
                            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C?) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,204248,204301);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,204317,204411);

f_22009_204317_204410(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,199553,204422);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,199553,204422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,199553,204422);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,204434,207042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,204593,204957);

string 
source = @"
struct C
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C operator &(C? x, C? y) => throw null;
    public static C operator |(C? x, C? y) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,204971,206481);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a || b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsInvalid) (Syntax: 'result = a || b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsInvalid, IsImplicit) (Syntax: 'a || b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,206495,206921);

var 
expectedDiagnostics = new[] {
f_22009_206802_206905(f_22009_206802_206885(f_22009_206802_206847(ErrorCode.ERR_BadBoolOp, "a || b"), "C.operator |(C?, C?)"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,206937,207031);

f_22009_206937_207030(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,204434,207042);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,204434,207042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,204434,207042);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [WorkItem(27044, "https://github.com/dotnet/roslyn/issues/27044")]
        [Fact]
        public void LogicalUserDefinedFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,207054,211529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,207289,207651);

string 
source = @"
struct C
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
    public static bool operator true(C? c) => throw null;
    public static bool operator false(C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,207850,211341);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean C.op_True(C? c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IInvalidOperation (OperationKind.Invalid, Type: C?, IsImplicit) (Syntax: 'a')
                      Children(1):
                          IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperatorMethod: C C.op_BitwiseOr(C x, C y)) (OperationKind.Binary, Type: C) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,211355,211408);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,211424,211518);

f_22009_211424_211517(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,207054,211529);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,207054,211529);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,207054,211529);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,211541,214155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,211700,212069);

string 
source = @"
struct C
{
    void M(C? a, C? b, C? result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C? operator &(C? x, C? y) => throw null;
    public static C? operator |(C? x, C? y) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,212083,213598);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a || b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C?, IsInvalid) (Syntax: 'result = a || b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C?) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a || b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,213612,214034);

var 
expectedDiagnostics = new[] {
f_22009_213907_214018(f_22009_213907_213998(f_22009_213907_213955(ErrorCode.ERR_MustHaveOpTF, "a || b"), "C.operator |(C?, C?)", "C"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,214050,214144);

f_22009_214050_214143(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,211541,214155);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,211541,214155);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,211541,214155);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,214167,216801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,214326,214810);

string 
source = @"
struct C
{
    void M(C? a, C? b, C? result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C? operator &(C x, C y) => throw null;
    public static C? operator |(C x, C y) => throw null;
    public static bool operator true(C? c) => throw null;
    public static bool operator false(C? c) => throw null;
    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,214824,216339);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a || b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C?, IsInvalid) (Syntax: 'result = a || b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C?) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a || b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,216353,216680);

var 
expectedDiagnostics = new[] {
f_22009_216564_216664(f_22009_216564_216644(f_22009_216564_216612(ErrorCode.ERR_BadBinaryOps, "a || b"), "||", "C?", "C?"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,216696,216790);

f_22009_216696_216789(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,214167,216801);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,214167,216801);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,214167,216801);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,216813,221380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,216972,217345);

string 
source = @"
struct C
{
    void M(C? a, C? b, C? result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C? operator &(C? x, C? y) => throw null;
    public static C? operator |(C? x, C? y) => throw null;
    public static bool? operator true(C? c) => throw null;
    public static bool? operator false(C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,217359,220657);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Children(1):
                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperatorMethod: C? C.op_BitwiseOr(C? x, C? y)) (OperationKind.Binary, Type: C?) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C?) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,220671,221259);

var 
expectedDiagnostics = new[] {
f_22009_220906_220972(f_22009_220906_220951(ErrorCode.ERR_OpTFRetType, "true"), 11, 34),
f_22009_221176_221243(f_22009_221176_221222(ErrorCode.ERR_OpTFRetType, "false"), 12, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,221275,221369);

f_22009_221275_221368(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,216813,221380);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,216813,221380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,216813,221380);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,221392,225480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,221551,221929);

string 
source = @"
class B
{
    public static bool operator true(B c) => throw null;
    public static bool operator false(B c) => throw null;
}
class C : B
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,221943,225292);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean B.op_True(B c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperatorMethod: C C.op_BitwiseOr(C x, C y)) (OperationKind.Binary, Type: C) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,225306,225359);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,225375,225469);

f_22009_225375_225468(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,221392,225480);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,221392,225480);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,221392,225480);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,225492,228108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,225651,226029);

string 
source = @"
class B
{
    public static B operator &(B x, B y) => throw null;
    public static B operator |(B x, B y) => throw null;
}
class C : B
{
    void M(C a, C b, C result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,226043,227553);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a || b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C, IsInvalid) (Syntax: 'result = a || b')
              Left: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C) (Syntax: 'result')
              Right: 
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsInvalid, IsImplicit) (Syntax: 'a || b')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperationKind.Binary, Type: ?, IsInvalid) (Syntax: 'a || b')
                      Left: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,227567,227987);

var 
expectedDiagnostics = new[] {
f_22009_227861_227971(f_22009_227861_227950(f_22009_227861_227909(ErrorCode.ERR_MustHaveOpTF, "a || b"), "B.operator |(B, B)", "B"), 11, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,228003,228097);

f_22009_228003_228096(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,225492,228108);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,225492,228108);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,225492,228108);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalUserDefinedFlow_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,228120,232216);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,228279,228644);

string 
source = @"
struct C
{
    void M(C? a, C? b, C? result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static C operator &(C x, C y) => throw null;
    public static C operator |(C x, C y) => throw null;
    public static bool operator true(C? c) => throw null;
    public static bool operator false(C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,228658,232028);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: C?) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean C.op_True(C? c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or, IsLifted) (OperatorMethod: C C.op_BitwiseOr(C x, C y)) (OperationKind.Binary, Type: C?) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: C?) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,232042,232095);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,232111,232205);

f_22009_232111_232204(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,228120,232216);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,228120,232216);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,228120,232216);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,232228,236046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,232383,232528);

string 
source = @"
struct C
{
    void M(dynamic a, dynamic b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,232542,235858);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,235872,235925);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,235941,236035);

f_22009_235941_236034(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,232228,236046);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,232228,236046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,232228,236046);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,236058,239878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,236213,236358);

string 
source = @"
struct C
{
    void M(dynamic a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,236372,239690);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.False) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,239704,239757);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,239773,239867);

f_22009_239773_239866(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,236058,239878);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,236058,239878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,236058,239878);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,239890,245232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,240045,240208);

string 
source = @"
struct C
{
    void M(dynamic a, dynamic b, dynamic c, dynamic result)
/*<bind>*/{
        result = (a ?? c) || b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,240222,245044);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [3]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [2]
        .locals {R3}
        {
            CaptureIds: [1]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                      Value: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                  Value: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'c')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (0)
            Jump if False (Regular) to Block[B7]
                IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a ?? c')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a ?? c')

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(a ?? c) || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a ?? c')

            Next (Regular) Block[B8]
                Leaving: {R2}
        Block[B7] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(a ?? c) || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: '(a ?? c) || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a ?? c')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B8]
                Leaving: {R2}
    }

    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (a ?? c) || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = (a ?? c) || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: '(a ?? c) || b')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,245058,245111);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,245127,245221);

f_22009_245127_245220(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,239890,245232);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,239890,245232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,239890,245232);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,245244,251127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,245399,245562);

string 
source = @"
struct C
{
    void M(dynamic a, dynamic b, dynamic c, dynamic result)
/*<bind>*/{
        result = a && (b ?? c);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,245576,250939);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.False) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                Entering: {R3} {R4}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && (b ?? c)')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B8]
                Leaving: {R2}

        .locals {R3}
        {
            CaptureIds: [4]
            .locals {R4}
            {
                CaptureIds: [3]
                Block[B4] - Block
                    Predecessors: [B2]
                    Statements (1)
                        IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                          Value: 
                            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

                    Jump if True (Regular) to Block[B6]
                        IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                          Operand: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'b')
                        Leaving: {R4}

                    Next (Regular) Block[B5]
                Block[B5] - Block
                    Predecessors: [B4]
                    Statements (1)
                        IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                          Value: 
                            IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'b')

                    Next (Regular) Block[B7]
                        Leaving: {R4}
            }

            Block[B6] - Block
                Predecessors: [B4]
                Statements (1)
                    IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                      Value: 
                        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'c')

                Next (Regular) Block[B7]
            Block[B7] - Block
                Predecessors: [B5] [B6]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && (b ?? c)')
                      Value: 
                        IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && (b ?? c)')
                          Left: 
                            IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                          Right: 
                            IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'b ?? c')

                Next (Regular) Block[B8]
                    Leaving: {R3} {R2}
        }
    }

    Block[B8] - Block
        Predecessors: [B3] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && (b ?? c);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && (b ?? c)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && (b ?? c)')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,250953,251006);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,251022,251116);

f_22009_251022_251115(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,245244,251127);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,245244,251127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,245244,251127);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,251139,254961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,251294,251436);

string 
source = @"
struct C
{
    void M(dynamic a, bool b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,251450,254773);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,254787,254840);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,254856,254950);

f_22009_254856_254949(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,251139,254961);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,251139,254961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,251139,254961);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,254973,259031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,255128,255270);

string 
source = @"
struct C
{
    void M(bool a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,255284,258843);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,258857,258910);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,258926,259020);

f_22009_258926_259019(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,254973,259031);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,254973,259031);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,254973,259031);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,259043,263101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,259198,259340);

string 
source = @"
struct C
{
    void M(bool a, dynamic b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,259354,262913);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,262927,262980);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,262996,263090);

f_22009_262996_263089(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,259043,263101);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,259043,263101);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,259043,263101);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,263113,266919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,263268,263407);

string 
source = @"
struct C
{
    void M(dynamic a, C b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,263421,266731);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,266745,266798);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,266814,266908);

f_22009_266814_266907(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,263113,266919);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,263113,266919);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,263113,266919);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,266931,271760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,267086,267225);

string 
source = @"
struct C
{
    void M(C a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,267239,271263);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsInvalid) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,271277,271639);

var 
expectedDiagnostics = new[] {
f_22009_271521_271623(f_22009_271521_271603(f_22009_271521_271575(ErrorCode.ERR_InvalidDynamicCondition, "a"), "C", "false"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,271655,271749);

f_22009_271655_271748(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,266931,271760);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,266931,271760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,266931,271760);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,271772,275643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,271927,272131);

string 
source = @"
struct C
{
    void M(dynamic a, C b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static implicit operator bool (C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,272145,275455);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,275469,275522);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,275538,275632);

f_22009_275538_275631(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,271772,275643);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,271772,275643);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,271772,275643);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,275655,280183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,275810,276014);

string 
source = @"
struct C
{
    void M(C a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static implicit operator bool (C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,276028,279995);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Boolean C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Boolean C.op_Implicit(C c))
                    (ImplicitUserDefined)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,280009,280062);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,280078,280172);

f_22009_280078_280171(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,275655,280183);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,275655,280183);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,275655,280183);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,280195,284723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,280350,280554);

string 
source = @"
struct C
{
    void M(C a, dynamic b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static implicit operator bool (C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,280568,284535);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Boolean C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Boolean C.op_Implicit(C c))
                    (ImplicitUserDefined)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,284549,284602);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,284618,284712);

f_22009_284618_284711(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,280195,284723);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,280195,284723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,280195,284723);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,284735,288608);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,284890,285095);

string 
source = @"
struct C
{
    void M(dynamic a, C? b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static implicit operator bool (C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,285109,288420);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,288434,288487);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,288503,288597);

f_22009_288503_288596(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,284735,288608);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,284735,288608);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,284735,288608);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,288620,293607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,288775,288980);

string 
source = @"
struct C
{
    void M(C? a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static implicit operator bool (C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,288994,293108);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Boolean C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Boolean C.op_Implicit(C c))
                    (ExplicitUserDefined)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsInvalid) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,293122,293486);

var 
expectedDiagnostics = new[] {
f_22009_293367_293470(f_22009_293367_293450(f_22009_293367_293421(ErrorCode.ERR_InvalidDynamicCondition, "a"), "C?", "false"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,293502,293596);

f_22009_293502_293595(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,288620,293607);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,288620,293607);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,288620,293607);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,293619,298155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,293774,293980);

string 
source = @"
struct C
{
    void M(C? a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static implicit operator bool (C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,293994,297967);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Boolean C.op_Implicit(C? c)) (OperationKind.Conversion, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Boolean C.op_Implicit(C? c))
                    (ImplicitUserDefined)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,297981,298034);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,298050,298144);

f_22009_298050_298143(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,293619,298155);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,293619,298155);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,293619,298155);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,298167,302698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,298322,298527);

string 
source = @"
struct C
{
    void M(C a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static implicit operator bool (C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,298541,302510);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Boolean C.op_Implicit(C? c)) (OperationKind.Conversion, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Boolean C.op_Implicit(C? c))
                    (ImplicitUserDefined)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,302524,302577);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,302593,302687);

f_22009_302593_302686(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,298167,302698);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,298167,302698);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,298167,302698);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,302710,306635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,302865,303123);

string 
source = @"
struct C
{
    void M(dynamic a, C b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,303137,306447);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,306461,306514);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,306530,306624);

f_22009_306530_306623(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,302710,306635);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,302710,306635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,302710,306635);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_18()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,306647,310981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,306802,307060);

string 
source = @"
struct C
{
    void M(C a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,307074,310793);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.False) (OperatorMethod: System.Boolean C.op_False(C c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,310807,310860);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,310876,310970);

f_22009_310876_310969(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,306647,310981);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,306647,310981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,306647,310981);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,310993,315324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,311148,311406);

string 
source = @"
struct C
{
    void M(C a, dynamic b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,311420,315136);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean C.op_True(C c)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,315150,315203);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,315219,315313);

f_22009_315219_315312(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,310993,315324);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,310993,315324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,310993,315324);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_20()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,315336,319263);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,315491,315750);

string 
source = @"
struct C
{
    void M(dynamic a, C? b, dynamic result)
/*<bind>*/{
        result = a || b;
    }/*</bind>*/

    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,315764,319075);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IUnaryOperation (UnaryOperatorKind.True) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a || b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.Or) (OperationKind.Binary, Type: dynamic) (Syntax: 'a || b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: C?) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a || b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a || b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a || b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,319089,319142);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,319158,319252);

f_22009_319158_319251(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,315336,319263);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,315336,319263);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,315336,319263);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_21()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,319275,324230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,319430,319689);

string 
source = @"
struct C
{
    void M(C? a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static bool operator true(C c) => throw null;
    public static bool operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,319703,323731);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsInvalid) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,323745,324109);

var 
expectedDiagnostics = new[] {
f_22009_323990_324093(f_22009_323990_324073(f_22009_323990_324044(ErrorCode.ERR_InvalidDynamicCondition, "a"), "C?", "false"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,324125,324219);

f_22009_324125_324218(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,319275,324230);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,319275,324230);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,319275,324230);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_22()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,324242,329199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,324397,324658);

string 
source = @"
struct C
{
    void M(C? a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static bool operator true(C? c) => throw null;
    public static bool operator false(C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,324672,328700);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C?, IsInvalid) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (NoConversion)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C?, IsInvalid, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsInvalid) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,328714,329078);

var 
expectedDiagnostics = new[] {
f_22009_328959_329062(f_22009_328959_329042(f_22009_328959_329013(ErrorCode.ERR_InvalidDynamicCondition, "a"), "C?", "false"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,329094,329188);

f_22009_329094_329187(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,324242,329199);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,324242,329199);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,324242,329199);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_23()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,329211,333671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,329366,329626);

string 
source = @"
struct C
{
    void M(C a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static bool operator true(C? c) => throw null;
    public static bool operator false(C? c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,329830,333483);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Children(1):
                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,333497,333550);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,333566,333660);

f_22009_333566_333659(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,329211,333671);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,329211,333671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,329211,333671);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_24()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,333683,338484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,333838,334098);

string 
source = @"
struct C
{
    void M(C a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/

    public static bool? operator true(C c) => throw null;
    public static bool? operator false(C c) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,334112,337765);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: C) (Syntax: 'a')

            Jump if False (Regular) to Block[B4]
                IInvalidOperation (OperationKind.Invalid, Type: System.Boolean, IsImplicit) (Syntax: 'a')
                  Children(1):
                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,337779,338363);

var 
expectedDiagnostics = new[] {
f_22009_338012_338077(f_22009_338012_338057(ErrorCode.ERR_OpTFRetType, "true"), 9, 34),
f_22009_338280_338347(f_22009_338280_338326(ErrorCode.ERR_OpTFRetType, "false"), 10, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,338379,338473);

f_22009_338379_338472(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,333683,338484);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,333683,338484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,333683,338484);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalDynamicFlow_25()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,338496,343396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,338651,338794);

string 
source = @"
struct C
{
    void M(bool? a, dynamic b, dynamic result)
/*<bind>*/{
        result = a && b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,338808,342891);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a')
                  Value: 
                    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean?, IsInvalid) (Syntax: 'a')

            Jump if True (Regular) to Block[B4]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'a')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    (ExplicitNullable)
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        (Boxing)
                      Operand: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsInvalid, IsImplicit) (Syntax: 'a')

            Next (Regular) Block[B5]
                Leaving: {R2}
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'a && b')
                  Value: 
                    IBinaryOperation (BinaryOperatorKind.And) (OperationKind.Binary, Type: dynamic, IsInvalid) (Syntax: 'a && b')
                      Left: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Boolean?, IsInvalid, IsImplicit) (Syntax: 'a')
                      Right: 
                        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'result = a && b;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsInvalid) (Syntax: 'result = a && b')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'result')
                  Right: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsInvalid, IsImplicit) (Syntax: 'a && b')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,342905,343275);

var 
expectedDiagnostics = new[] {
f_22009_343153_343259(f_22009_343153_343239(f_22009_343153_343207(ErrorCode.ERR_InvalidDynamicCondition, "a"), "bool?", "false"), 6, 18)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,343291,343385);

f_22009_343291_343384(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,338496,343396);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,338496,343396);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,338496,343396);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_Int_Create()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,343408,345153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,343546,343714);

var 
compilation = f_22009_343564_343713(f_22009_343564_343693(@"
class Test
{
    void M()
    {
        var x = /*<bind>*/1..2/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,343730,344920);

string 
expectedOperationTree = @"
IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '1..2')
  LeftOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index, IsImplicit) (Syntax: '1')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  RightOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index, IsImplicit) (Syntax: '2')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,344936,345055);

var 
operation = (IRangeOperation)f_22009_344969_345054(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,345069,345142);

f_22009_345069_345141(RangeCtorSignature, f_22009_345102_345140(f_22009_345102_345118(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,343408,345153);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,343408,345153);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,343408,345153);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_Int_Create_WithHat()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,345165,346623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,345311,345487);

var 
compilation = f_22009_345329_345486(f_22009_345329_345466(@"
class Test
{
    void M(int arg)
    {
        var x = /*<bind>*/0..^1/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,345503,346390);

string 
expectedOperationTree = @"
IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '0..^1')
  LeftOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index, IsImplicit) (Syntax: '0')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  RightOperand: 
    IUnaryOperation (UnaryOperatorKind.Hat) (OperationKind.Unary, Type: System.Index) (Syntax: '^1')
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,346406,346525);

var 
operation = (IRangeOperation)f_22009_346439_346524(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,346539,346612);

f_22009_346539_346611(RangeCtorSignature, f_22009_346572_346610(f_22009_346572_346588(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,345165,346623);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,345165,346623);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,345165,346623);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_Int_ToEnd()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,346635,347867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,346772,346939);

var 
compilation = f_22009_346790_346938(f_22009_346790_346918(@"
class Test
{
    void M()
    {
        var x = /*<bind>*/..2/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,346955,347633);

string 
expectedOperationTree = @"
IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '..2')
  LeftOperand: 
    null
  RightOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index, IsImplicit) (Syntax: '2')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,347649,347768);

var 
operation = (IRangeOperation)f_22009_347682_347767(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,347782,347856);

f_22009_347782_347855(RangeEndAtSignature, f_22009_347816_347854(f_22009_347816_347832(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,346635,347867);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,346635,347867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,346635,347867);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_Int_FromStart()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,347879,349117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,348020,348187);

var 
compilation = f_22009_348038_348186(f_22009_348038_348166(@"
class Test
{
    void M()
    {
        var x = /*<bind>*/1../*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,348203,348881);

string 
expectedOperationTree = @"
IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '1..')
  LeftOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index, IsImplicit) (Syntax: '1')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  RightOperand: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,348897,349016);

var 
operation = (IRangeOperation)f_22009_348930_349015(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,349030,349106);

f_22009_349030_349105(RangeStartAtSignature, f_22009_349066_349104(f_22009_349066_349082(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,347879,349117);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,347879,349117);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,347879,349117);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_Int_All()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,349129,349844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,349264,349430);

var 
compilation = f_22009_349282_349429(f_22009_349282_349409(@"
class Test
{
    void M()
    {
        var x = /*<bind>*/../*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,349446,349612);

string 
expectedOperationTree = @"
IRangeOperation (OperationKind.Range, Type: System.Range) (Syntax: '..')
  LeftOperand: 
    null
  RightOperand: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,349628,349747);

var 
operation = (IRangeOperation)f_22009_349661_349746(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,349761,349833);

f_22009_349761_349832(RangeAllSignature, f_22009_349793_349831(f_22009_349793_349809(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,349129,349844);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,349129,349844);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,349129,349844);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_NullableInt_Create()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,349856,351699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,350002,350196);

var 
compilation = f_22009_350020_350195(f_22009_350020_350175(@"
class Test
{
    void M(int? start, int? end)
    {
        var x = /*<bind>*/start..end/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,350212,351466);

string 
expectedOperationTree = @"
IRangeOperation (IsLifted) (OperationKind.Range, Type: System.Range?) (Syntax: 'start..end')
  LeftOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index?, IsImplicit) (Syntax: 'start')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        IParameterReferenceOperation: start (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'start')
  RightOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index?, IsImplicit) (Syntax: 'end')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        IParameterReferenceOperation: end (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'end')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,351482,351601);

var 
operation = (IRangeOperation)f_22009_351515_351600(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,351615,351688);

f_22009_351615_351687(RangeCtorSignature, f_22009_351648_351686(f_22009_351648_351664(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,349856,351699);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,349856,351699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,349856,351699);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_NullableInt_Create_WithHat()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,351711,353270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,351865,352060);

var 
compilation = f_22009_351883_352059(f_22009_351883_352039(@"
class Test
{
    void M(int? start, int? end)
    {
        var x = /*<bind>*/start..^end/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,352076,353037);

string 
expectedOperationTree = @"
IRangeOperation (IsLifted) (OperationKind.Range, Type: System.Range?) (Syntax: 'start..^end')
  LeftOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index?, IsImplicit) (Syntax: 'start')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        IParameterReferenceOperation: start (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'start')
  RightOperand: 
    IUnaryOperation (UnaryOperatorKind.Hat, IsLifted) (OperationKind.Unary, Type: System.Index?) (Syntax: '^end')
      Operand: 
        IParameterReferenceOperation: end (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'end')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,353053,353172);

var 
operation = (IRangeOperation)f_22009_353086_353171(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,353186,353259);

f_22009_353186_353258(RangeCtorSignature, f_22009_353219_353257(f_22009_353219_353235(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,351711,353270);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,351711,353270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,351711,353270);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_NullableInt_ToEnd()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,353282,354566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,353427,353604);

var 
compilation = f_22009_353445_353603(f_22009_353445_353583(@"
class Test
{
    void M(int? end)
    {
        var x = /*<bind>*/..end/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,353620,354332);

string 
expectedOperationTree = @"
IRangeOperation (IsLifted) (OperationKind.Range, Type: System.Range?) (Syntax: '..end')
  LeftOperand: 
    null
  RightOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index?, IsImplicit) (Syntax: 'end')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        IParameterReferenceOperation: end (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'end')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,354348,354467);

var 
operation = (IRangeOperation)f_22009_354381_354466(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,354481,354555);

f_22009_354481_354554(RangeEndAtSignature, f_22009_354515_354553(f_22009_354515_354531(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,353282,354566);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,353282,354566);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,353282,354566);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyRangeOperator_NullableInt_FromStart()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22009,354578,355880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,354727,354908);

var 
compilation = f_22009_354745_354907(f_22009_354745_354887(@"
class Test
{
    void M(int? start)
    {
        var x = /*<bind>*/start../*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,354924,355644);

string 
expectedOperationTree = @"
IRangeOperation (IsLifted) (OperationKind.Range, Type: System.Range?) (Syntax: 'start..')
  LeftOperand: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Index System.Index.op_Implicit(System.Int32 value)) (OperationKind.Conversion, Type: System.Index?, IsImplicit) (Syntax: 'start')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Index System.Index.op_Implicit(System.Int32 value))
      Operand: 
        IParameterReferenceOperation: start (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'start')
  RightOperand: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,355660,355779);

var 
operation = (IRangeOperation)f_22009_355693_355778(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22009,355793,355869);

f_22009_355793_355868(RangeStartAtSignature, f_22009_355829_355867(f_22009_355829_355845(operation)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22009,354578,355880);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22009,354578,355880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22009,354578,355880);
}
		}

int
f_22009_1634_1715(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 1634, 1715);
return 0;
}


int
f_22009_2420_2501(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 2420, 2501);
return 0;
}


int
f_22009_3238_3319(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 3238, 3319);
return 0;
}


int
f_22009_4327_4408(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 4327, 4408);
return 0;
}


int
f_22009_5113_5194(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 5113, 5194);
return 0;
}


int
f_22009_5881_5962(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 5881, 5962);
return 0;
}


int
f_22009_6789_6905(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 6789, 6905);
return 0;
}


int
f_22009_7720_7836(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 7720, 7836);
return 0;
}


int
f_22009_8604_8685(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 8604, 8685);
return 0;
}


int
f_22009_9441_9522(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 9441, 9522);
return 0;
}


int
f_22009_20133_20253(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 20133, 20253);
return 0;
}


int
f_22009_30959_31079(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 30959, 31079);
return 0;
}


int
f_22009_34240_34333(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 34240, 34333);
return 0;
}


int
f_22009_38163_38256(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 38163, 38256);
return 0;
}


int
f_22009_41750_41843(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 41750, 41843);
return 0;
}


int
f_22009_45334_45427(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 45334, 45427);
return 0;
}


int
f_22009_49946_50039(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 49946, 50039);
return 0;
}


int
f_22009_53157_53250(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 53157, 53250);
return 0;
}


int
f_22009_56702_56795(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 56702, 56795);
return 0;
}


int
f_22009_60249_60342(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 60249, 60342);
return 0;
}


int
f_22009_64828_64921(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 64828, 64921);
return 0;
}


int
f_22009_69672_69765(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 69672, 69765);
return 0;
}


int
f_22009_76192_76285(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 76192, 76285);
return 0;
}


int
f_22009_82206_82299(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 82206, 82299);
return 0;
}


int
f_22009_87057_87150(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 87057, 87150);
return 0;
}


int
f_22009_91911_92004(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 91911, 92004);
return 0;
}


int
f_22009_96762_96855(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 96762, 96855);
return 0;
}


int
f_22009_101611_101704(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 101611, 101704);
return 0;
}


int
f_22009_106463_106556(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 106463, 106556);
return 0;
}


int
f_22009_110789_110886(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 110789, 110886);
return 0;
}


int
f_22009_115122_115219(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 115122, 115219);
return 0;
}


int
f_22009_119463_119560(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 119463, 119560);
return 0;
}


int
f_22009_123807_123904(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 123807, 123904);
return 0;
}


int
f_22009_128139_128236(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 128139, 128236);
return 0;
}


int
f_22009_132474_132571(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 132474, 132571);
return 0;
}


int
f_22009_136790_136887(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 136790, 136887);
return 0;
}


int
f_22009_141105_141202(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 141105, 141202);
return 0;
}


int
f_22009_145429_145526(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 145429, 145526);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_147669_147717(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 147669, 147717);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_147669_147755(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 147669, 147755);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_147669_147775(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 147669, 147775);
return return_v;
}


int
f_22009_147807_147900(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 147807, 147900);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_150044_150092(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 150044, 150092);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_150044_150130(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 150044, 150130);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_150044_150150(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 150044, 150150);
return return_v;
}


int
f_22009_150182_150275(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 150182, 150275);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_155239_155296(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 155239, 155296);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_155239_155334(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 155239, 155334);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_155239_155354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 155239, 155354);
return return_v;
}


int
f_22009_155386_155479(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 155386, 155479);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_160152_160209(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 160152, 160209);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_160152_160247(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 160152, 160247);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_160152_160267(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 160152, 160267);
return return_v;
}


int
f_22009_160299_160392(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 160299, 160392);
return 0;
}


int
f_22009_164380_164473(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 164380, 164473);
return 0;
}


int
f_22009_168465_168558(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 168465, 168558);
return 0;
}


int
f_22009_174046_174139(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 174046, 174139);
return 0;
}


int
f_22009_180164_180257(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 180164, 180257);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_182313_182361(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 182313, 182361);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_182313_182391(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 182313, 182391);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_182313_182411(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 182313, 182411);
return return_v;
}


int
f_22009_182443_182536(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 182443, 182536);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_184937_184982(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 184937, 184982);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_184937_185018(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 184937, 185018);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_184937_185038(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 184937, 185038);
return return_v;
}


int
f_22009_185070_185163(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 185070, 185163);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_187420_187468(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 187420, 187468);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_187420_187509(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 187420, 187509);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_187420_187529(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 187420, 187529);
return return_v;
}


int
f_22009_187561_187654(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 187561, 187654);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_190075_190125(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 190075, 190125);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_190075_190161(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 190075, 190161);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_190075_190181(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 190075, 190181);
return return_v;
}


int
f_22009_190213_190306(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 190213, 190306);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_192688_192736(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 192688, 192736);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_192688_192777(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 192688, 192777);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_192688_192797(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 192688, 192797);
return return_v;
}


int
f_22009_192829_192922(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 192829, 192922);
return 0;
}


int
f_22009_196936_197029(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 196936, 197029);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_199295_199343(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 199295, 199343);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_199295_199384(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 199295, 199384);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_199295_199404(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 199295, 199404);
return return_v;
}


int
f_22009_199436_199529(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 199436, 199529);
return 0;
}


int
f_22009_204317_204410(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 204317, 204410);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_206802_206847(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 206802, 206847);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_206802_206885(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 206802, 206885);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_206802_206905(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 206802, 206905);
return return_v;
}


int
f_22009_206937_207030(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 206937, 207030);
return 0;
}


int
f_22009_211424_211517(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 211424, 211517);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_213907_213955(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 213907, 213955);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_213907_213998(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 213907, 213998);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_213907_214018(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 213907, 214018);
return return_v;
}


int
f_22009_214050_214143(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 214050, 214143);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_216564_216612(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 216564, 216612);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_216564_216644(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 216564, 216644);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_216564_216664(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 216564, 216664);
return return_v;
}


int
f_22009_216696_216789(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 216696, 216789);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_220906_220951(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 220906, 220951);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_220906_220972(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 220906, 220972);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_221176_221222(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 221176, 221222);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_221176_221243(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 221176, 221243);
return return_v;
}


int
f_22009_221275_221368(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 221275, 221368);
return 0;
}


int
f_22009_225375_225468(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 225375, 225468);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_227861_227909(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 227861, 227909);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_227861_227950(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 227861, 227950);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_227861_227971(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 227861, 227971);
return return_v;
}


int
f_22009_228003_228096(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 228003, 228096);
return 0;
}


int
f_22009_232111_232204(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 232111, 232204);
return 0;
}


int
f_22009_235941_236034(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 235941, 236034);
return 0;
}


int
f_22009_239773_239866(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 239773, 239866);
return 0;
}


int
f_22009_245127_245220(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 245127, 245220);
return 0;
}


int
f_22009_251022_251115(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 251022, 251115);
return 0;
}


int
f_22009_254856_254949(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 254856, 254949);
return 0;
}


int
f_22009_258926_259019(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 258926, 259019);
return 0;
}


int
f_22009_262996_263089(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 262996, 263089);
return 0;
}


int
f_22009_266814_266907(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 266814, 266907);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_271521_271575(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 271521, 271575);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_271521_271603(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 271521, 271603);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_271521_271623(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 271521, 271623);
return return_v;
}


int
f_22009_271655_271748(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 271655, 271748);
return 0;
}


int
f_22009_275538_275631(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 275538, 275631);
return 0;
}


int
f_22009_280078_280171(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 280078, 280171);
return 0;
}


int
f_22009_284618_284711(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 284618, 284711);
return 0;
}


int
f_22009_288503_288596(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 288503, 288596);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_293367_293421(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 293367, 293421);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_293367_293450(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 293367, 293450);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_293367_293470(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 293367, 293470);
return return_v;
}


int
f_22009_293502_293595(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 293502, 293595);
return 0;
}


int
f_22009_298050_298143(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 298050, 298143);
return 0;
}


int
f_22009_302593_302686(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 302593, 302686);
return 0;
}


int
f_22009_306530_306623(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 306530, 306623);
return 0;
}


int
f_22009_310876_310969(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 310876, 310969);
return 0;
}


int
f_22009_315219_315312(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 315219, 315312);
return 0;
}


int
f_22009_319158_319251(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 319158, 319251);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_323990_324044(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 323990, 324044);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_323990_324073(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 323990, 324073);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_323990_324093(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 323990, 324093);
return return_v;
}


int
f_22009_324125_324218(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 324125, 324218);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_328959_329013(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 328959, 329013);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_328959_329042(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 328959, 329042);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_328959_329062(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 328959, 329062);
return return_v;
}


int
f_22009_329094_329187(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 329094, 329187);
return 0;
}


int
f_22009_333566_333659(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 333566, 333659);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_338012_338057(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 338012, 338057);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_338012_338077(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 338012, 338077);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_338280_338326(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 338280, 338326);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_338280_338347(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 338280, 338347);
return return_v;
}


int
f_22009_338379_338472(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 338379, 338472);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_343153_343207(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 343153, 343207);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_343153_343239(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 343153, 343239);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22009_343153_343259(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 343153, 343259);
return return_v;
}


int
f_22009_343291_343384(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 343291, 343384);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_343564_343693(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 343564, 343693);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_343564_343713(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 343564, 343713);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_344969_345054(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 344969, 345054);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_345102_345118(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 345102, 345118);
return return_v;
}


string
f_22009_345102_345140(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 345102, 345140);
return return_v;
}


int
f_22009_345069_345141(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 345069, 345141);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_345329_345466(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 345329, 345466);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_345329_345486(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 345329, 345486);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_346439_346524(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 346439, 346524);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_346572_346588(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 346572, 346588);
return return_v;
}


string
f_22009_346572_346610(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 346572, 346610);
return return_v;
}


int
f_22009_346539_346611(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 346539, 346611);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_346790_346918(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 346790, 346918);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_346790_346938(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 346790, 346938);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_347682_347767(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 347682, 347767);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_347816_347832(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 347816, 347832);
return return_v;
}


string
f_22009_347816_347854(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 347816, 347854);
return return_v;
}


int
f_22009_347782_347855(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 347782, 347855);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_348038_348166(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 348038, 348166);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_348038_348186(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 348038, 348186);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_348930_349015(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 348930, 349015);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_349066_349082(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 349066, 349082);
return return_v;
}


string
f_22009_349066_349104(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 349066, 349104);
return return_v;
}


int
f_22009_349030_349105(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 349030, 349105);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_349282_349409(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 349282, 349409);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_349282_349429(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 349282, 349429);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_349661_349746(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 349661, 349746);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_349793_349809(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 349793, 349809);
return return_v;
}


string
f_22009_349793_349831(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 349793, 349831);
return return_v;
}


int
f_22009_349761_349832(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 349761, 349832);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_350020_350175(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 350020, 350175);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_350020_350195(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 350020, 350195);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_351515_351600(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 351515, 351600);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_351648_351664(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 351648, 351664);
return return_v;
}


string
f_22009_351648_351686(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 351648, 351686);
return return_v;
}


int
f_22009_351615_351687(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 351615, 351687);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_351883_352039(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 351883, 352039);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_351883_352059(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 351883, 352059);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_353086_353171(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 353086, 353171);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_353219_353235(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 353219, 353235);
return return_v;
}


string
f_22009_353219_353257(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 353219, 353257);
return return_v;
}


int
f_22009_353186_353258(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 353186, 353258);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_353445_353583(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 353445, 353583);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_353445_353603(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 353445, 353603);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_354381_354466(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 354381, 354466);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_354515_354531(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 354515, 354531);
return return_v;
}


string
f_22009_354515_354553(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 354515, 354553);
return return_v;
}


int
f_22009_354481_354554(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 354481, 354554);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_354745_354887(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 354745, 354887);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22009_354745_354907(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 354745, 354907);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22009_355693_355778(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<RangeExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 355693, 355778);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22009_355829_355845(Microsoft.CodeAnalysis.Operations.IRangeOperation
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22009, 355829, 355845);
return return_v;
}


string
f_22009_355829_355867(Microsoft.CodeAnalysis.IMethodSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 355829, 355867);
return return_v;
}


int
f_22009_355793_355868(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22009, 355793, 355868);
return 0;
}

}
}
