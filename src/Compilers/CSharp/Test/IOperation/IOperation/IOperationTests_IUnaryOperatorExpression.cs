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
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17591")]
        public void Test_UnaryOperatorExpression_Type_Plus_System_SByte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,543,1642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,768,938);

string 
source = @"
class A
{
    System.SByte Method()
    {
        System.SByte i = default(System.SByte);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,952,1530);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.SByte, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,1544,1631);

f_22073_1544_1630(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,543,1642);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,543,1642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,543,1642);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Byte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,1654,2682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,1812,1979);

string 
source = @"
class A
{
    System.Byte Method()
    {
        System.Byte i = default(System.Byte);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,1993,2570);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Byte, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,2584,2671);

f_22073_2584_2670(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,1654,2682);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,1654,2682);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,1654,2682);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Int16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,2694,3727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,2853,3023);

string 
source = @"
class A
{
    System.Int16 Method()
    {
        System.Int16 i = default(System.Int16);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,3037,3615);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int16, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,3629,3716);

f_22073_3629_3715(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,2694,3727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,2694,3727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,2694,3727);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_UInt16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,3739,4777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,3899,4072);

string 
source = @"
class A
{
    System.UInt16 Method()
    {
        System.UInt16 i = default(System.UInt16);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,4086,4665);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt16, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,4679,4766);

f_22073_4679_4765(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,3739,4777);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,3739,4777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,3739,4777);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Int32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,4789,5491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,4948,5118);

string 
source = @"
class A
{
    System.Int32 Method()
    {
        System.Int32 i = default(System.Int32);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,5132,5379);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,5393,5480);

f_22073_5393_5479(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,4789,5491);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,4789,5491);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,4789,5491);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_UInt32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,5503,6211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,5663,5836);

string 
source = @"
class A
{
    System.UInt32 Method()
    {
        System.UInt32 i = default(System.UInt32);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,5850,6099);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.UInt32) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt32) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,6113,6200);

f_22073_6113_6199(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,5503,6211);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,5503,6211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,5503,6211);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Int64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,6223,6925);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,6382,6552);

string 
source = @"
class A
{
    System.Int64 Method()
    {
        System.Int64 i = default(System.Int64);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,6566,6813);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int64) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int64) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,6827,6914);

f_22073_6827_6913(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,6223,6925);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,6223,6925);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,6223,6925);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_UInt64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,6937,7645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,7097,7270);

string 
source = @"
class A
{
    System.UInt64 Method()
    {
        System.UInt64 i = default(System.UInt64);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,7284,7533);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.UInt64) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt64) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,7547,7634);

f_22073_7547_7633(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,6937,7645);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,6937,7645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,6937,7645);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Char()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,7657,8685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,7815,7982);

string 
source = @"
class A
{
    System.Char Method()
    {
        System.Char i = default(System.Char);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,7996,8573);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Char, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,8587,8674);

f_22073_8587_8673(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,7657,8685);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,7657,8685);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,7657,8685);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,8697,9411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,8858,9034);

string 
source = @"
class A
{
    System.Decimal Method()
    {
        System.Decimal i = default(System.Decimal);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,9048,9299);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Decimal) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Decimal) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,9313,9400);

f_22073_9313_9399(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,8697,9411);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,8697,9411);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,8697,9411);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Single()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,9423,10131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,9583,9756);

string 
source = @"
class A
{
    System.Single Method()
    {
        System.Single i = default(System.Single);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,9770,10019);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Single) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Single) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,10033,10120);

f_22073_10033_10119(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,9423,10131);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,9423,10131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,9423,10131);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Double()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,10143,10851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,10303,10476);

string 
source = @"
class A
{
    System.Double Method()
    {
        System.Double i = default(System.Double);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,10490,10739);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Double) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Double) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,10753,10840);

f_22073_10753_10839(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,10143,10851);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,10143,10851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,10143,10851);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Boolean()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,10863,11586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,11024,11200);

string 
source = @"
class A
{
    System.Boolean Method()
    {
        System.Boolean i = default(System.Boolean);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,11214,11474);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Boolean, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,11488,11575);

f_22073_11488_11574(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,10863,11586);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,10863,11586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,10863,11586);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_System_Object()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,11598,12316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,11758,11931);

string 
source = @"
class A
{
    System.Object Method()
    {
        System.Object i = default(System.Object);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,11945,12204);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Object, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,12218,12305);

f_22073_12218_12304(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,11598,12316);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,11598,12316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,11598,12316);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_SByte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,12328,13363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,12488,12658);

string 
source = @"
class A
{
    System.SByte Method()
    {
        System.SByte i = default(System.SByte);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,12672,13251);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.SByte, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,13265,13352);

f_22073_13265_13351(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,12328,13363);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,12328,13363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,12328,13363);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Byte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,13375,14405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,13534,13701);

string 
source = @"
class A
{
    System.Byte Method()
    {
        System.Byte i = default(System.Byte);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,13715,14293);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Byte, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,14307,14394);

f_22073_14307_14393(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,13375,14405);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,13375,14405);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,13375,14405);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Int16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,14417,15452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,14577,14747);

string 
source = @"
class A
{
    System.Int16 Method()
    {
        System.Int16 i = default(System.Int16);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,14761,15340);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int16, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,15354,15441);

f_22073_15354_15440(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,14417,15452);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,14417,15452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,14417,15452);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_UInt16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,15464,16504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,15625,15798);

string 
source = @"
class A
{
    System.UInt16 Method()
    {
        System.UInt16 i = default(System.UInt16);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,15812,16392);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt16, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,16406,16493);

f_22073_16406_16492(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,15464,16504);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,15464,16504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,15464,16504);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Int32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,16516,17220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,16676,16846);

string 
source = @"
class A
{
    System.Int32 Method()
    {
        System.Int32 i = default(System.Int32);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,16860,17108);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,17122,17209);

f_22073_17122_17208(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,16516,17220);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,16516,17220);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,16516,17220);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_UInt32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,17232,18272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,17393,17566);

string 
source = @"
class A
{
    System.UInt32 Method()
    {
        System.UInt32 i = default(System.UInt32);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,17580,18160);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int64, IsInvalid) (Syntax: '-i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt32, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,18174,18261);

f_22073_18174_18260(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,17232,18272);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,17232,18272);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,17232,18272);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Int64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,18284,18988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,18444,18614);

string 
source = @"
class A
{
    System.Int64 Method()
    {
        System.Int64 i = default(System.Int64);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,18628,18876);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int64) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int64) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,18890,18977);

f_22073_18890_18976(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,18284,18988);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,18284,18988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,18284,18988);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_UInt64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,19000,19720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,19161,19334);

string 
source = @"
class A
{
    System.UInt64 Method()
    {
        System.UInt64 i = default(System.UInt64);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,19348,19608);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt64, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,19622,19709);

f_22073_19622_19708(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,19000,19720);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,19000,19720);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,19000,19720);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Char()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,19732,20762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,19891,20058);

string 
source = @"
class A
{
    System.Char Method()
    {
        System.Char i = default(System.Char);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,20072,20650);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Char, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,20664,20751);

f_22073_20664_20750(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,19732,20762);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,19732,20762);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,19732,20762);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,20774,21490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,20936,21112);

string 
source = @"
class A
{
    System.Decimal Method()
    {
        System.Decimal i = default(System.Decimal);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,21126,21378);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Decimal) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Decimal) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,21392,21479);

f_22073_21392_21478(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,20774,21490);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,20774,21490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,20774,21490);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Single()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,21502,22212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,21663,21836);

string 
source = @"
class A
{
    System.Single Method()
    {
        System.Single i = default(System.Single);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,21850,22100);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Single) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Single) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,22114,22201);

f_22073_22114_22200(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,21502,22212);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,21502,22212);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,21502,22212);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Double()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,22224,22934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,22385,22558);

string 
source = @"
class A
{
    System.Double Method()
    {
        System.Double i = default(System.Double);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,22572,22822);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Double) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Double) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,22836,22923);

f_22073_22836_22922(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,22224,22934);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,22224,22934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,22224,22934);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Boolean()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,22946,23671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,23108,23284);

string 
source = @"
class A
{
    System.Boolean Method()
    {
        System.Boolean i = default(System.Boolean);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,23298,23559);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Boolean, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,23573,23660);

f_22073_23573_23659(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,22946,23671);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,22946,23671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,22946,23671);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_System_Object()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,23683,24403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,23844,24017);

string 
source = @"
class A
{
    System.Object Method()
    {
        System.Object i = default(System.Object);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,24031,24291);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Object, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,24305,24392);

f_22073_24305_24391(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,23683,24403);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,23683,24403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,23683,24403);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_SByte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,24415,25715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,24576,24753);

string 
source = @"
class A
{
    System.SByte Method()
    {
        System.SByte i = default(System.SByte);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,24767,25603);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.SByte A.Method()) (OperationKind.Invocation, Type: System.SByte, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,25617,25704);

f_22073_25617_25703(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,24415,25715);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,24415,25715);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,24415,25715);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Byte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,25727,27021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,25887,26061);

string 
source = @"
class A
{
    System.Byte Method()
    {
        System.Byte i = default(System.Byte);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,26075,26909);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Byte A.Method()) (OperationKind.Invocation, Type: System.Byte, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,26923,27010);

f_22073_26923_27009(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,25727,27021);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,25727,27021);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,25727,27021);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Int16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,27033,28333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,27194,27371);

string 
source = @"
class A
{
    System.Int16 Method()
    {
        System.Int16 i = default(System.Int16);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,27385,28221);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Int16 A.Method()) (OperationKind.Invocation, Type: System.Int16, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,28235,28322);

f_22073_28235_28321(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,27033,28333);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,27033,28333);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,27033,28333);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_UInt16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,28345,29651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,28507,28687);

string 
source = @"
class A
{
    System.UInt16 Method()
    {
        System.UInt16 i = default(System.UInt16);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,28701,29539);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.UInt16 A.Method()) (OperationKind.Invocation, Type: System.UInt16, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,29553,29640);

f_22073_29553_29639(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,28345,29651);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,28345,29651);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,28345,29651);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Int32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,29663,30602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,29824,30001);

string 
source = @"
class A
{
    System.Int32 Method()
    {
        System.Int32 i = default(System.Int32);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,30015,30490);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.Int32 A.Method()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,30504,30591);

f_22073_30504_30590(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,29663,30602);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,29663,30602);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,29663,30602);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_UInt32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,30614,31560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,30776,30956);

string 
source = @"
class A
{
    System.UInt32 Method()
    {
        System.UInt32 i = default(System.UInt32);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,30970,31448);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.UInt32) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.UInt32 A.Method()) (OperationKind.Invocation, Type: System.UInt32) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,31462,31549);

f_22073_31462_31548(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,30614,31560);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,30614,31560);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,30614,31560);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Int64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,31572,32511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,31733,31910);

string 
source = @"
class A
{
    System.Int64 Method()
    {
        System.Int64 i = default(System.Int64);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,31924,32399);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int64) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.Int64 A.Method()) (OperationKind.Invocation, Type: System.Int64) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,32413,32500);

f_22073_32413_32499(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,31572,32511);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,31572,32511);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,31572,32511);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_UInt64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,32523,33469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,32685,32865);

string 
source = @"
class A
{
    System.UInt64 Method()
    {
        System.UInt64 i = default(System.UInt64);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,32879,33357);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.UInt64) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.UInt64 A.Method()) (OperationKind.Invocation, Type: System.UInt64) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,33371,33458);

f_22073_33371_33457(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,32523,33469);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,32523,33469);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,32523,33469);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Char()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,33481,34775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,33641,33815);

string 
source = @"
class A
{
    System.Char Method()
    {
        System.Char i = default(System.Char);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,33829,34663);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '+Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Char A.Method()) (OperationKind.Invocation, Type: System.Char, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,34677,34764);

f_22073_34677_34763(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,33481,34775);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,33481,34775);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,33481,34775);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,34787,35740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,34950,35133);

string 
source = @"
class A
{
    System.Decimal Method()
    {
        System.Decimal i = default(System.Decimal);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,35147,35628);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Decimal) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.Decimal A.Method()) (OperationKind.Invocation, Type: System.Decimal) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,35642,35729);

f_22073_35642_35728(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,34787,35740);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,34787,35740);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,34787,35740);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Single()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,35752,36698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,35914,36094);

string 
source = @"
class A
{
    System.Single Method()
    {
        System.Single i = default(System.Single);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,36108,36586);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Single) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.Single A.Method()) (OperationKind.Invocation, Type: System.Single) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,36600,36687);

f_22073_36600_36686(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,35752,36698);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,35752,36698);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,35752,36698);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Double()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,36710,37656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,36872,37052);

string 
source = @"
class A
{
    System.Double Method()
    {
        System.Double i = default(System.Double);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,37066,37544);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: System.Double) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.Double A.Method()) (OperationKind.Invocation, Type: System.Double) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,37558,37645);

f_22073_37558_37644(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,36710,37656);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,36710,37656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,36710,37656);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Boolean()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,37668,38641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,37831,38014);

string 
source = @"
class A
{
    System.Boolean Method()
    {
        System.Boolean i = default(System.Boolean);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,38028,38529);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.Boolean A.Method()) (OperationKind.Invocation, Type: System.Boolean, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,38543,38630);

f_22073_38543_38629(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,37668,38641);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,37668,38641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,37668,38641);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_System_Object()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,38653,39620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,38815,38995);

string 
source = @"
class A
{
    System.Object Method()
    {
        System.Object i = default(System.Object);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,39009,39508);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( System.Object A.Method()) (OperationKind.Invocation, Type: System.Object, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,39522,39609);

f_22073_39522_39608(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,38653,39620);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,38653,39620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,38653,39620);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_SByte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,39632,40934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,39794,39971);

string 
source = @"
class A
{
    System.SByte Method()
    {
        System.SByte i = default(System.SByte);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,39985,40822);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.SByte A.Method()) (OperationKind.Invocation, Type: System.SByte, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,40836,40923);

f_22073_40836_40922(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,39632,40934);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,39632,40934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,39632,40934);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Byte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,40946,42242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,41107,41281);

string 
source = @"
class A
{
    System.Byte Method()
    {
        System.Byte i = default(System.Byte);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,41295,42130);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Byte A.Method()) (OperationKind.Invocation, Type: System.Byte, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,42144,42231);

f_22073_42144_42230(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,40946,42242);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,40946,42242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,40946,42242);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Int16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,42254,43556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,42416,42593);

string 
source = @"
class A
{
    System.Int16 Method()
    {
        System.Int16 i = default(System.Int16);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,42607,43444);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Int16 A.Method()) (OperationKind.Invocation, Type: System.Int16, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,43458,43545);

f_22073_43458_43544(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,42254,43556);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,42254,43556);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,42254,43556);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_UInt16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,43568,44876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,43731,43911);

string 
source = @"
class A
{
    System.UInt16 Method()
    {
        System.UInt16 i = default(System.UInt16);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,43925,44764);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.UInt16 A.Method()) (OperationKind.Invocation, Type: System.UInt16, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,44778,44865);

f_22073_44778_44864(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,43568,44876);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,43568,44876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,43568,44876);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Int32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,44888,45829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,45050,45227);

string 
source = @"
class A
{
    System.Int32 Method()
    {
        System.Int32 i = default(System.Int32);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,45241,45717);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( System.Int32 A.Method()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,45731,45818);

f_22073_45731_45817(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,44888,45829);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,44888,45829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,44888,45829);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_UInt32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,45841,47149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,46004,46184);

string 
source = @"
class A
{
    System.UInt32 Method()
    {
        System.UInt32 i = default(System.UInt32);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,46198,47037);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int64, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.UInt32 A.Method()) (OperationKind.Invocation, Type: System.UInt32, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,47051,47138);

f_22073_47051_47137(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,45841,47149);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,45841,47149);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,45841,47149);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Int64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,47161,48102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,47323,47500);

string 
source = @"
class A
{
    System.Int64 Method()
    {
        System.Int64 i = default(System.Int64);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,47514,47990);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int64) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( System.Int64 A.Method()) (OperationKind.Invocation, Type: System.Int64) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,48004,48091);

f_22073_48004_48090(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,47161,48102);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,47161,48102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,47161,48102);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_UInt64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,48114,49083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,48277,48457);

string 
source = @"
class A
{
    System.UInt64 Method()
    {
        System.UInt64 i = default(System.UInt64);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,48471,48971);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( System.UInt64 A.Method()) (OperationKind.Invocation, Type: System.UInt64, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,48985,49072);

f_22073_48985_49071(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,48114,49083);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,48114,49083);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,48114,49083);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Char()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,49095,50391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,49256,49430);

string 
source = @"
class A
{
    System.Char Method()
    {
        System.Char i = default(System.Char);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,49444,50279);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Char A.Method()) (OperationKind.Invocation, Type: System.Char, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,50293,50380);

f_22073_50293_50379(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,49095,50391);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,49095,50391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,49095,50391);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,50403,51358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,50567,50750);

string 
source = @"
class A
{
    System.Decimal Method()
    {
        System.Decimal i = default(System.Decimal);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,50764,51246);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Decimal) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( System.Decimal A.Method()) (OperationKind.Invocation, Type: System.Decimal) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,51260,51347);

f_22073_51260_51346(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,50403,51358);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,50403,51358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,50403,51358);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Single()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,51370,52318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,51533,51713);

string 
source = @"
class A
{
    System.Single Method()
    {
        System.Single i = default(System.Single);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,51727,52206);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Single) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( System.Single A.Method()) (OperationKind.Invocation, Type: System.Single) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,52220,52307);

f_22073_52220_52306(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,51370,52318);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,51370,52318);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,51370,52318);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Double()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,52330,53278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,52493,52673);

string 
source = @"
class A
{
    System.Double Method()
    {
        System.Double i = default(System.Double);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,52687,53166);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Double) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( System.Double A.Method()) (OperationKind.Invocation, Type: System.Double) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,53180,53267);

f_22073_53180_53266(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,52330,53278);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,52330,53278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,52330,53278);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Boolean()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,53290,54265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,53454,53637);

string 
source = @"
class A
{
    System.Boolean Method()
    {
        System.Boolean i = default(System.Boolean);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,53651,54153);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( System.Boolean A.Method()) (OperationKind.Invocation, Type: System.Boolean, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,54167,54254);

f_22073_54167_54253(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,53290,54265);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,53290,54265);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,53290,54265);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_System_Object()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,54277,55246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,54440,54620);

string 
source = @"
class A
{
    System.Object Method()
    {
        System.Object i = default(System.Object);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,54634,55134);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( System.Object A.Method()) (OperationKind.Invocation, Type: System.Object, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,55148,55235);

f_22073_55148_55234(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,54277,55246);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,54277,55246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,54277,55246);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_LogicalNot_System_Boolean()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,55258,55977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,55425,55601);

string 
source = @"
class A
{
    System.Boolean Method()
    {
        System.Boolean i = default(System.Boolean);
        return /*<bind>*/!i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,55615,55865);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: System.Boolean) (Syntax: '!i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Boolean) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,55879,55966);

f_22073_55879_55965(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,55258,55977);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,55258,55977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,55258,55977);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_LogicalNot_System_Boolean()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,55989,56947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,56158,56341);

string 
source = @"
class A
{
    System.Boolean Method()
    {
        System.Boolean i = default(System.Boolean);
        return /*<bind>*/!Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,56355,56835);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: System.Boolean) (Syntax: '!Method()')
  Operand: 
    IInvocationOperation ( System.Boolean A.Method()) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,56849,56936);

f_22073_56849_56935(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,55989,56947);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,55989,56947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,55989,56947);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_SByte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,56959,58009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,57124,57294);

string 
source = @"
class A
{
    System.SByte Method()
    {
        System.SByte i = default(System.SByte);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,57308,57897);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.SByte, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,57911,57998);

f_22073_57911_57997(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,56959,58009);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,56959,58009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,56959,58009);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Byte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,58021,59066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,58185,58352);

string 
source = @"
class A
{
    System.Byte Method()
    {
        System.Byte i = default(System.Byte);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,58366,58954);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Byte, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,58968,59055);

f_22073_58968_59054(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,58021,59066);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,58021,59066);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,58021,59066);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Int16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,59078,60128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,59243,59413);

string 
source = @"
class A
{
    System.Int16 Method()
    {
        System.Int16 i = default(System.Int16);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,59427,60016);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int16, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,60030,60117);

f_22073_60030_60116(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,59078,60128);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,59078,60128);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,59078,60128);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_UInt16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,60140,61195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,60306,60479);

string 
source = @"
class A
{
    System.UInt16 Method()
    {
        System.UInt16 i = default(System.UInt16);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,60493,61083);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt16, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,61097,61184);

f_22073_61097_61183(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,60140,61195);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,60140,61195);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,60140,61195);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Int32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,61207,61926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,61372,61542);

string 
source = @"
class A
{
    System.Int32 Method()
    {
        System.Int32 i = default(System.Int32);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,61556,61814);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,61828,61915);

f_22073_61828_61914(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,61207,61926);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,61207,61926);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,61207,61926);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_UInt32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,61938,62663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,62104,62277);

string 
source = @"
class A
{
    System.UInt32 Method()
    {
        System.UInt32 i = default(System.UInt32);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,62291,62551);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.UInt32) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt32) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,62565,62652);

f_22073_62565_62651(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,61938,62663);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,61938,62663);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,61938,62663);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Int64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,62675,63394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,62840,63010);

string 
source = @"
class A
{
    System.Int64 Method()
    {
        System.Int64 i = default(System.Int64);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,63024,63282);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int64) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int64) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,63296,63383);

f_22073_63296_63382(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,62675,63394);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,62675,63394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,62675,63394);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_UInt64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,63406,64131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,63572,63745);

string 
source = @"
class A
{
    System.UInt64 Method()
    {
        System.UInt64 i = default(System.UInt64);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,63759,64019);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.UInt64) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.UInt64) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,64033,64120);

f_22073_64033_64119(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,63406,64131);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,63406,64131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,63406,64131);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Char()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,64143,65188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,64307,64474);

string 
source = @"
class A
{
    System.Char Method()
    {
        System.Char i = default(System.Char);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,64488,65076);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Char, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,65090,65177);

f_22073_65090_65176(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,64143,65188);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,64143,65188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,64143,65188);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,65200,65940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,65367,65543);

string 
source = @"
class A
{
    System.Decimal Method()
    {
        System.Decimal i = default(System.Decimal);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,65557,65828);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Decimal, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,65842,65929);

f_22073_65842_65928(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,65200,65940);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,65200,65940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,65200,65940);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Single()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,65952,66687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,66118,66291);

string 
source = @"
class A
{
    System.Single Method()
    {
        System.Single i = default(System.Single);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,66305,66575);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Single, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,66589,66676);

f_22073_66589_66675(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,65952,66687);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,65952,66687);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,65952,66687);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Double()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,66699,67434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,66865,67038);

string 
source = @"
class A
{
    System.Double Method()
    {
        System.Double i = default(System.Double);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,67052,67322);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Double, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,67336,67423);

f_22073_67336_67422(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,66699,67434);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,66699,67434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,66699,67434);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Boolean()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,67446,68186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,67613,67789);

string 
source = @"
class A
{
    System.Boolean Method()
    {
        System.Boolean i = default(System.Boolean);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,67803,68074);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Boolean, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,68088,68175);

f_22073_68088_68174(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,67446,68186);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,67446,68186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,67446,68186);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_System_Object()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,68198,68933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,68364,68537);

string 
source = @"
class A
{
    System.Object Method()
    {
        System.Object i = default(System.Object);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,68551,68821);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Object, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,68835,68922);

f_22073_68835_68921(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,68198,68933);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,68198,68933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,68198,68933);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_SByte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,68945,70262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,69112,69289);

string 
source = @"
class A
{
    System.SByte Method()
    {
        System.SByte i = default(System.SByte);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,69303,70150);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.SByte A.Method()) (OperationKind.Invocation, Type: System.SByte, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,70164,70251);

f_22073_70164_70250(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,68945,70262);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,68945,70262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,68945,70262);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Byte()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,70274,71585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,70440,70614);

string 
source = @"
class A
{
    System.Byte Method()
    {
        System.Byte i = default(System.Byte);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,70628,71473);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Byte A.Method()) (OperationKind.Invocation, Type: System.Byte, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,71487,71574);

f_22073_71487_71573(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,70274,71585);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,70274,71585);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,70274,71585);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Int16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,71597,72914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,71764,71941);

string 
source = @"
class A
{
    System.Int16 Method()
    {
        System.Int16 i = default(System.Int16);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,71955,72802);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Int16 A.Method()) (OperationKind.Invocation, Type: System.Int16, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,72816,72903);

f_22073_72816_72902(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,71597,72914);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,71597,72914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,71597,72914);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_UInt16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,72926,74249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,73094,73274);

string 
source = @"
class A
{
    System.UInt16 Method()
    {
        System.UInt16 i = default(System.UInt16);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,73288,74137);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.UInt16 A.Method()) (OperationKind.Invocation, Type: System.UInt16, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,74151,74238);

f_22073_74151_74237(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,72926,74249);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,72926,74249);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,72926,74249);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Int32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,74261,75217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,74428,74605);

string 
source = @"
class A
{
    System.Int32 Method()
    {
        System.Int32 i = default(System.Int32);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,74619,75105);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.Int32 A.Method()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,75119,75206);

f_22073_75119_75205(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,74261,75217);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,74261,75217);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,74261,75217);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_UInt32()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,75229,76192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,75397,75577);

string 
source = @"
class A
{
    System.UInt32 Method()
    {
        System.UInt32 i = default(System.UInt32);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,75591,76080);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.UInt32) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.UInt32 A.Method()) (OperationKind.Invocation, Type: System.UInt32) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,76094,76181);

f_22073_76094_76180(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,75229,76192);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,75229,76192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,75229,76192);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Int64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,76204,77160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,76371,76548);

string 
source = @"
class A
{
    System.Int64 Method()
    {
        System.Int64 i = default(System.Int64);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,76562,77048);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int64) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.Int64 A.Method()) (OperationKind.Invocation, Type: System.Int64) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,77062,77149);

f_22073_77062_77148(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,76204,77160);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,76204,77160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,76204,77160);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_UInt64()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,77172,78135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,77340,77520);

string 
source = @"
class A
{
    System.UInt64 Method()
    {
        System.UInt64 i = default(System.UInt64);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,77534,78023);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.UInt64) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.UInt64 A.Method()) (OperationKind.Invocation, Type: System.UInt64) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,78037,78124);

f_22073_78037_78123(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,77172,78135);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,77172,78135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,77172,78135);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Char()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,78147,79458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,78313,78487);

string 
source = @"
class A
{
    System.Char Method()
    {
        System.Char i = default(System.Char);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,78501,79346);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: System.Int32, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'Method()')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IInvocationOperation ( System.Char A.Method()) (OperationKind.Invocation, Type: System.Char, IsInvalid) (Syntax: 'Method()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
          Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,79360,79447);

f_22073_79360_79446(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,78147,79458);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,78147,79458);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,78147,79458);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,79470,80460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,79639,79822);

string 
source = @"
class A
{
    System.Decimal Method()
    {
        System.Decimal i = default(System.Decimal);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,79836,80348);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.Decimal A.Method()) (OperationKind.Invocation, Type: System.Decimal, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,80362,80449);

f_22073_80362_80448(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,79470,80460);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,79470,80460);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,79470,80460);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Single()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,80472,81456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,80640,80820);

string 
source = @"
class A
{
    System.Single Method()
    {
        System.Single i = default(System.Single);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,80834,81344);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.Single A.Method()) (OperationKind.Invocation, Type: System.Single, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,81358,81445);

f_22073_81358_81444(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,80472,81456);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,80472,81456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,80472,81456);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Double()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,81468,82452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,81636,81816);

string 
source = @"
class A
{
    System.Double Method()
    {
        System.Double i = default(System.Double);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,81830,82340);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.Double A.Method()) (OperationKind.Invocation, Type: System.Double, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,82354,82441);

f_22073_82354_82440(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,81468,82452);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,81468,82452);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,81468,82452);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Boolean()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,82464,83454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,82633,82816);

string 
source = @"
class A
{
    System.Boolean Method()
    {
        System.Boolean i = default(System.Boolean);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,82830,83342);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.Boolean A.Method()) (OperationKind.Invocation, Type: System.Boolean, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,83356,83443);

f_22073_83356_83442(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,82464,83454);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,82464,83454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,82464,83454);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_System_Object()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,83466,84450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,83634,83814);

string 
source = @"
class A
{
    System.Object Method()
    {
        System.Object i = default(System.Object);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,83828,84338);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( System.Object A.Method()) (OperationKind.Invocation, Type: System.Object, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,84352,84439);

f_22073_84352_84438(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,83466,84450);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,83466,84450);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,83466,84450);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,84462,85134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,84616,84771);

string 
source = @"
class A
{
    dynamic Method()
    {
        dynamic i = default(dynamic);
        return /*<bind>*/+i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,84785,85022);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: dynamic) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: dynamic) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,85036,85123);

f_22073_85036_85122(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,84462,85134);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,84462,85134);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,84462,85134);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,85146,85820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,85301,85456);

string 
source = @"
class A
{
    dynamic Method()
    {
        dynamic i = default(dynamic);
        return /*<bind>*/-i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,85470,85708);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: dynamic) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: dynamic) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,85722,85809);

f_22073_85722_85808(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,85146,85820);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,85146,85820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,85146,85820);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,85832,86521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,85992,86147);

string 
source = @"
class A
{
    dynamic Method()
    {
        dynamic i = default(dynamic);
        return /*<bind>*/~i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,86161,86409);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: dynamic) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: dynamic) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,86423,86510);

f_22073_86423_86509(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,85832,86521);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,85832,86521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,85832,86521);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_LogicalNot_dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,86533,87210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,86693,86848);

string 
source = @"
class A
{
    dynamic Method()
    {
        dynamic i = default(dynamic);
        return /*<bind>*/!i/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,86862,87098);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: dynamic) (Syntax: '!i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: dynamic) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,87112,87199);

f_22073_87112_87198(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,86533,87210);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,86533,87210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,86533,87210);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,87222,88126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,87378,87540);

string 
source = @"
class A
{
    dynamic Method()
    {
        dynamic i = default(dynamic);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,87554,88014);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: dynamic) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( dynamic A.Method()) (OperationKind.Invocation, Type: dynamic) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,88028,88115);

f_22073_88028_88114(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,87222,88126);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,87222,88126);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,87222,88126);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,88138,89044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,88295,88457);

string 
source = @"
class A
{
    dynamic Method()
    {
        dynamic i = default(dynamic);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,88471,88932);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: dynamic) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( dynamic A.Method()) (OperationKind.Invocation, Type: dynamic) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,88946,89033);

f_22073_88946_89032(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,88138,89044);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,88138,89044);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,88138,89044);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,89056,89977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,89218,89380);

string 
source = @"
class A
{
    dynamic Method()
    {
        dynamic i = default(dynamic);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,89394,89865);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: dynamic) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( dynamic A.Method()) (OperationKind.Invocation, Type: dynamic) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,89879,89966);

f_22073_89879_89965(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,89056,89977);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,89056,89977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,89056,89977);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_LogicalNot_dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,89989,90898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,90151,90313);

string 
source = @"
class A
{
    dynamic Method()
    {
        dynamic i = default(dynamic);
        return /*<bind>*/!Method()/*</bind>*/;
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,90327,90786);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: dynamic) (Syntax: '!Method()')
  Operand: 
    IInvocationOperation ( dynamic A.Method()) (OperationKind.Invocation, Type: dynamic) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,90800,90887);

f_22073_90800_90886(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,89989,90898);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,89989,90898);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,89989,90898);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_Enum()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,90910,91601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,91061,91225);

string 
source = @"
class A
{
    Enum Method()
    {
        Enum i = default(Enum);
        return /*<bind>*/+i/*</bind>*/;
    }
}
enum Enum { A, B }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,91239,91489);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: Enum, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,91503,91590);

f_22073_91503_91589(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,90910,91601);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,90910,91601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,90910,91601);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_Enum()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,91613,92306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,91765,91929);

string 
source = @"
class A
{
    Enum Method()
    {
        Enum i = default(Enum);
        return /*<bind>*/-i/*</bind>*/;
    }
}
enum Enum { A, B }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,91943,92194);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: Enum, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,92208,92295);

f_22073_92208_92294(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,91613,92306);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,91613,92306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,91613,92306);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_Enum()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,92318,93007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,92475,92639);

string 
source = @"
class A
{
    Enum Method()
    {
        Enum i = default(Enum);
        return /*<bind>*/~i/*</bind>*/;
    }
}
enum Enum { A, B }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,92653,92895);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: Enum) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: Enum) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,92909,92996);

f_22073_92909_92995(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,92318,93007);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,92318,93007);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,92318,93007);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_Enum()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,93019,93950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,93172,93343);

string 
source = @"
class A
{
    Enum Method()
    {
        Enum i = default(Enum);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}
enum Enum { A, B }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,93357,93838);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( Enum A.Method()) (OperationKind.Invocation, Type: Enum, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,93852,93939);

f_22073_93852_93938(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,93019,93950);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,93019,93950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,93019,93950);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_Enum()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,93962,94895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,94116,94287);

string 
source = @"
class A
{
    Enum Method()
    {
        Enum i = default(Enum);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}
enum Enum { A, B }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,94301,94783);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( Enum A.Method()) (OperationKind.Invocation, Type: Enum, IsInvalid) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsInvalid, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,94797,94884);

f_22073_94797_94883(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,93962,94895);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,93962,94895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,93962,94895);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_Enum()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,94907,95825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,95066,95237);

string 
source = @"
class A
{
    Enum Method()
    {
        Enum i = default(Enum);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}
enum Enum { A, B }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,95251,95713);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperationKind.Unary, Type: Enum) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( Enum A.Method()) (OperationKind.Invocation, Type: Enum) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,95727,95814);

f_22073_95727_95813(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,94907,95825);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,94907,95825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,94907,95825);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Plus_CustomType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,95837,96976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,95994,96540);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/+i/*</bind>*/;
    }
}
public struct CustomType
{
    public static CustomType operator +(CustomType x)
    {
        return x;
    }
    public static CustomType operator -(CustomType x)
    {
        return x;
    }
    public static CustomType operator !(CustomType x)
    {
        return x;
    }
    public static CustomType operator ~(CustomType x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,96554,96864);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperatorMethod: CustomType CustomType.op_UnaryPlus(CustomType x)) (OperationKind.Unary, Type: CustomType) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: CustomType) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,96878,96965);

f_22073_96878_96964(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,95837,96976);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,95837,96976);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,95837,96976);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_Minus_CustomType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,96988,98133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,97146,97692);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/-i/*</bind>*/;
    }
}
public struct CustomType
{
    public static CustomType operator +(CustomType x)
    {
        return x;
    }
    public static CustomType operator -(CustomType x)
    {
        return x;
    }
    public static CustomType operator !(CustomType x)
    {
        return x;
    }
    public static CustomType operator ~(CustomType x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,97706,98021);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperatorMethod: CustomType CustomType.op_UnaryNegation(CustomType x)) (OperationKind.Unary, Type: CustomType) (Syntax: '-i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: CustomType) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,98035,98122);

f_22073_98035_98121(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,96988,98133);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,96988,98133);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,96988,98133);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_BitwiseNot_CustomType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,98145,99306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,98308,98854);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/~i/*</bind>*/;
    }
}
public struct CustomType
{
    public static CustomType operator +(CustomType x)
    {
        return x;
    }
    public static CustomType operator -(CustomType x)
    {
        return x;
    }
    public static CustomType operator !(CustomType x)
    {
        return x;
    }
    public static CustomType operator ~(CustomType x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,98868,99194);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperatorMethod: CustomType CustomType.op_OnesComplement(CustomType x)) (OperationKind.Unary, Type: CustomType) (Syntax: '~i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: CustomType) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,99208,99295);

f_22073_99208_99294(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,98145,99306);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,98145,99306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,98145,99306);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Type_LogicalNot_CustomType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,99318,100463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,99481,100027);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/!i/*</bind>*/;
    }
}
public struct CustomType
{
    public static CustomType operator +(CustomType x)
    {
        return x;
    }
    public static CustomType operator -(CustomType x)
    {
        return x;
    }
    public static CustomType operator !(CustomType x)
    {
        return x;
    }
    public static CustomType operator ~(CustomType x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,100041,100351);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Not) (OperatorMethod: CustomType CustomType.op_LogicalNot(CustomType x)) (OperationKind.Unary, Type: CustomType) (Syntax: '!i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: CustomType) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,100365,100452);

f_22073_100365_100451(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,99318,100463);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,99318,100463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,99318,100463);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Plus_CustomType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,100475,101849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,100634,101187);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/+Method()/*</bind>*/;
    }
}
public struct CustomType
{
    public static CustomType operator +(CustomType x)
    {
        return x;
    }
    public static CustomType operator -(CustomType x)
    {
        return x;
    }
    public static CustomType operator !(CustomType x)
    {
        return x;
    }
    public static CustomType operator ~(CustomType x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,101201,101737);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperatorMethod: CustomType CustomType.op_UnaryPlus(CustomType x)) (OperationKind.Unary, Type: CustomType) (Syntax: '+Method()')
  Operand: 
    IInvocationOperation ( CustomType A.Method()) (OperationKind.Invocation, Type: CustomType) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,101751,101838);

f_22073_101751_101837(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,100475,101849);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,100475,101849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,100475,101849);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_Minus_CustomType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,101861,103241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,102021,102574);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/-Method()/*</bind>*/;
    }
}
public struct CustomType
{
    public static CustomType operator +(CustomType x)
    {
        return x;
    }
    public static CustomType operator -(CustomType x)
    {
        return x;
    }
    public static CustomType operator !(CustomType x)
    {
        return x;
    }
    public static CustomType operator ~(CustomType x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,102588,103129);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Minus) (OperatorMethod: CustomType CustomType.op_UnaryNegation(CustomType x)) (OperationKind.Unary, Type: CustomType) (Syntax: '-Method()')
  Operand: 
    IInvocationOperation ( CustomType A.Method()) (OperationKind.Invocation, Type: CustomType) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,103143,103230);

f_22073_103143_103229(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,101861,103241);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,101861,103241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,101861,103241);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_BitwiseNot_CustomType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,103253,104649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,103418,103971);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/~Method()/*</bind>*/;
    }
}
public struct CustomType
{
    public static CustomType operator +(CustomType x)
    {
        return x;
    }
    public static CustomType operator -(CustomType x)
    {
        return x;
    }
    public static CustomType operator !(CustomType x)
    {
        return x;
    }
    public static CustomType operator ~(CustomType x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,103985,104537);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.BitwiseNegation) (OperatorMethod: CustomType CustomType.op_OnesComplement(CustomType x)) (OperationKind.Unary, Type: CustomType) (Syntax: '~Method()')
  Operand: 
    IInvocationOperation ( CustomType A.Method()) (OperationKind.Invocation, Type: CustomType) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,104551,104638);

f_22073_104551_104637(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,103253,104649);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,103253,104649);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,103253,104649);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Method_LogicalNot_CustomType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,104661,106041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,104826,105379);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/!Method()/*</bind>*/;
    }
}
public struct CustomType
{
    public static CustomType operator +(CustomType x)
    {
        return x;
    }
    public static CustomType operator -(CustomType x)
    {
        return x;
    }
    public static CustomType operator !(CustomType x)
    {
        return x;
    }
    public static CustomType operator ~(CustomType x)
    {
        return x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,105393,105929);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Not) (OperatorMethod: CustomType CustomType.op_LogicalNot(CustomType x)) (OperationKind.Unary, Type: CustomType) (Syntax: '!Method()')
  Operand: 
    IInvocationOperation ( CustomType A.Method()) (OperationKind.Invocation, Type: CustomType) (Syntax: 'Method()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: A, IsImplicit) (Syntax: 'Method')
      Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,105943,106030);

f_22073_105943_106029(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,104661,106041);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,104661,106041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,104661,106041);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18135, "https://github.com/dotnet/roslyn/issues/18135")]
        [WorkItem(18160, "https://github.com/dotnet/roslyn/issues/18160")]
        public void Test_UnaryOperatorExpression_Type_And_TrueFalse()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,106053,107957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,106350,107001);

string 
source = @"

public struct S
{
    private int value;
    public S(int v)
    {
        value = v;
    }
    public static S operator |(S x, S y)
    {
        return new S(x.value - y.value);
    }
    public static S operator &(S x, S y)
    {
        return new S(x.value + y.value);
    }
    public static bool operator true(S x)
    {
        return x.value > 0;
    }
    public static bool operator false(S x)
    {
        return x.value <= 0;
    }
}
 
class C
{
    public void M()
    {
        var x = new S(2);
        var y = new S(1);
        /*<bind>*/if (x && y) { }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,107015,107855);

string 
expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (x && y) { }')
  Condition: 
    IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean S.op_True(S x)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'x && y')
      Operand: 
        IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperatorMethod: S S.op_BitwiseAnd(S x, S y)) (OperationKind.Binary, Type: S) (Syntax: 'x && y')
          Left: 
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: S) (Syntax: 'x')
          Right: 
            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: S) (Syntax: 'y')
  WhenTrue: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
  WhenFalse: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,107869,107946);

f_22073_107869_107945(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,106053,107957);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,106053,107957);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,106053,107957);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(18135, "https://github.com/dotnet/roslyn/issues/18135")]
        [WorkItem(18160, "https://github.com/dotnet/roslyn/issues/18160")]
        public void Test_UnaryOperatorExpression_Type_Or_TrueFalse()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,107969,109870);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,108265,108916);

string 
source = @"

public struct S
{
    private int value;
    public S(int v)
    {
        value = v;
    }
    public static S operator |(S x, S y)
    {
        return new S(x.value - y.value);
    }
    public static S operator &(S x, S y)
    {
        return new S(x.value + y.value);
    }
    public static bool operator true(S x)
    {
        return x.value > 0;
    }
    public static bool operator false(S x)
    {
        return x.value <= 0;
    }
}
 
class C
{
    public void M()
    {
        var x = new S(2);
        var y = new S(1);
        /*<bind>*/if (x || y) { }/*</bind>*/
    }
}

"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,108930,109768);

string 
expectedOperationTree = @"
IConditionalOperation (OperationKind.Conditional, Type: null) (Syntax: 'if (x || y) { }')
  Condition: 
    IUnaryOperation (UnaryOperatorKind.True) (OperatorMethod: System.Boolean S.op_True(S x)) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'x || y')
      Operand: 
        IBinaryOperation (BinaryOperatorKind.ConditionalOr) (OperatorMethod: S S.op_BitwiseOr(S x, S y)) (OperationKind.Binary, Type: S) (Syntax: 'x || y')
          Left: 
            ILocalReferenceOperation: x (OperationKind.LocalReference, Type: S) (Syntax: 'x')
          Right: 
            ILocalReferenceOperation: y (OperationKind.LocalReference, Type: S) (Syntax: 'y')
  WhenTrue: 
    IBlockOperation (0 statements) (OperationKind.Block, Type: null) (Syntax: '{ }')
  WhenFalse: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,109782,109859);

f_22073_109782_109858(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,107969,109870);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,107969,109870);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,107969,109870);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_With_CustomType_NoRightOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,109882,110626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,110050,110244);

string 
source = @"
class A
{
    CustomType Method()
    {
        CustomType i = default(CustomType);
        return /*<bind>*/+i/*</bind>*/;
    }
}
public struct CustomType
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,110258,110514);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: CustomType, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,110528,110615);

f_22073_110528_110614(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,109882,110626);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,109882,110626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,109882,110626);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_With_CustomType_DerivedTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,110638,111851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,110803,111128);

string 
source = @"
class A
{
    BaseType Method()
    {
        var i = default(DerivedType);
        return /*<bind>*/+i/*</bind>*/;
    }
}
public class BaseType
{
    public static BaseType operator +(BaseType x)
    {
        return new BaseType();
    }
}

public class DerivedType : BaseType
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,111142,111739);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperatorMethod: BaseType BaseType.op_UnaryPlus(BaseType x)) (OperationKind.Unary, Type: BaseType) (Syntax: '+i')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: BaseType, IsImplicit) (Syntax: 'i')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ILocalReferenceOperation: i (OperationKind.LocalReference, Type: DerivedType) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,111753,111840);

f_22073_111753_111839(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,110638,111851);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,110638,111851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,110638,111851);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_With_CustomType_ImplicitConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,111863,112839);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,112034,112456);

string 
source = @"
class A
{
    BaseType Method()
    {
        var i = default(DerivedType);
        return /*<bind>*/+i/*</bind>*/;
    }
}
public class BaseType
{
    public static BaseType operator +(BaseType x)
    {
        return new BaseType();
    }
}

public class DerivedType 
{
    public static implicit operator BaseType(DerivedType x)
    {
        return new BaseType();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,112470,112727);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: DerivedType, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,112741,112828);

f_22073_112741_112827(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,111863,112839);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,111863,112839);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,111863,112839);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_With_CustomType_ExplicitConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,112851,113829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,113022,113444);

string 
source = @"
class A
{
    BaseType Method()
    {
        var i = default(DerivedType);
        return /*<bind>*/+i/*</bind>*/;
    }
}
public class BaseType
{
    public static BaseType operator +(BaseType x)
    {
        return new BaseType();
    }
}

public class DerivedType 
{
    public static explicit operator BaseType(DerivedType x)
    {
        return new BaseType();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,113458,113715);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: DerivedType, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,113731,113818);

f_22073_113731_113817(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,112851,113829);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,112851,113829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,112851,113829);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_With_CustomType_Malformed_Operator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,113841,114666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,114012,114284);

string 
source = @"
class A
{
    BaseType Method()
    {
        var i = default(BaseType);
        return /*<bind>*/+i/*</bind>*/;
    }
}
public class BaseType
{
    public static BaseType operator +(int x)
    {
        return new BaseType();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,114298,114552);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Plus) (OperationKind.Unary, Type: ?, IsInvalid) (Syntax: '+i')
  Operand: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: BaseType, IsInvalid) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,114568,114655);

f_22073_114568_114654(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,113841,114666);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,113841,114666);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,113841,114666);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(18160, "https://github.com/dotnet/roslyn/issues/18160")]
        public void Test_BinaryExpressionSyntax_Type_And_TrueFalse_Condition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,114678,116068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,114918,115564);

string 
source = @"
public struct S
{
    private int value;
    public S(int v)
    {
        value = v;
    }
    public static S operator |(S x, S y)
    {
        return new S(x.value - y.value);
    }
    public static S operator &(S x, S y)
    {
        return new S(x.value + y.value);
    }
    public static bool operator true(S x)
    {
        return x.value > 0;
    }
    public static bool operator false(S x)
    {
        return x.value <= 0;
    }
}

class C
{
    public void M()
    {
        var x = new S(2);
        var y = new S(1);
        if (/*<bind>*/x && y/*</bind>*/) { }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,115578,115961);

string 
expectedOperationTree = @"
IBinaryOperation (BinaryOperatorKind.ConditionalAnd) (OperatorMethod: S S.op_BitwiseAnd(S x, S y)) (OperationKind.Binary, Type: S) (Syntax: 'x && y')
  Left: 
    ILocalReferenceOperation: x (OperationKind.LocalReference, Type: S) (Syntax: 'x')
  Right: 
    ILocalReferenceOperation: y (OperationKind.LocalReference, Type: S) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,115975,116057);

f_22073_115975_116056(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,114678,116068);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,114678,116068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,114678,116068);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_IncrementExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,116080,116745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,116236,116367);

string 
source = @"
class A
{
    int Method()
    {
        var i = 1;
        return /*<bind>*/++i/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,116381,116631);

string 
expectedOperationTree = @"
IIncrementOrDecrementOperation (Prefix) (OperationKind.Increment, Type: System.Int32) (Syntax: '++i')
  Target: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,116647,116734);

f_22073_116647_116733(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,116080,116745);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,116080,116745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,116080,116745);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_DecrementExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,116757,117420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,116913,117044);

string 
source = @"
class A
{
    int Method()
    {
        var i = 1;
        return /*<bind>*/--i/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,117058,117308);

string 
expectedOperationTree = @"
IIncrementOrDecrementOperation (Prefix) (OperationKind.Decrement, Type: System.Int32) (Syntax: '--i')
  Target: 
    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,117322,117409);

f_22073_117322_117408(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,116757,117420);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,116757,117420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,116757,117420);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Nullable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,117432,118222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,117577,117694);

string 
source = @"
class A
{
    void Method()
    {
        var i = /*<bind>*/(int?)1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,117708,118117);

string 
expectedOperationTree = @"
IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?) (Syntax: '(int?)1')
  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Operand: 
    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,118131,118211);

f_22073_118131_118210(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,117432,118222);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,117432,118222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,117432,118222);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void Test_UnaryOperatorExpression_Pointer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,118234,119002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,118378,118655);

string 
source = @"
class A
{
    unsafe void Method()
    {
        int[] a = new int[5] {10, 20, 30, 40, 50};
        
        fixed (int* p = &a[0])  
        {  
            int* p2 = p;  
            int p1 = /*<bind>*/*p2/*</bind>*/;  
        }  
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,118669,118888);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: '*p2')
  Children(1):
      ILocalReferenceOperation: p2 (OperationKind.LocalReference, Type: System.Int32*) (Syntax: 'p2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,118904,118991);

f_22073_118904_118990(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,118234,119002);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,118234,119002);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,118234,119002);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyLiftedUnaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,119014,119663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,119149,119264);

var 
source = @"
 class C
 {
     void F(int? x)
     {
         var y = /*<bind>*/-x/*</bind>*/;
     }
 }"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,119280,119549);

string 
expectedOperationTree =
@"
IUnaryOperation (UnaryOperatorKind.Minus, IsLifted) (OperationKind.Unary, Type: System.Int32?) (Syntax: '-x')
  Operand: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,119565,119652);

f_22073_119565_119651(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,119014,119663);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,119014,119663);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,119014,119663);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyNonLiftedUnaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,119675,120307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,119813,119920);

var 
source = @"
class C
{
    void F(int x)
    {
        var y = /*<bind>*/-x/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,119936,120193);

string 
expectedOperationTree =
@"
IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32) (Syntax: '-x')
  Operand: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,120209,120296);

f_22073_120209_120295(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,119675,120307);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,119675,120307);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,119675,120307);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyLiftedUserDefinedUnaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,120319,121034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,120465,120613);

var 
source = @"
struct C
{
    public static C operator -(C c) { }
    void F(C? x)
    {
        var y = /*<bind>*/-x/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,120629,120920);

string 
expectedOperationTree =
@"
IUnaryOperation (UnaryOperatorKind.Minus, IsLifted) (OperatorMethod: C C.op_UnaryNegation(C c)) (OperationKind.Unary, Type: C?) (Syntax: '-x')
  Operand: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: C?) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,120936,121023);

f_22073_120936_121022(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,120319,121034);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,120319,121034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,120319,121034);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VerifyNonLiftedUserDefinedUnaryOperators1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,121046,121751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,121195,121342);

var 
source = @"
struct C
{
    public static C operator -(C c) { }
    void F(C x)
    {
        var y = /*<bind>*/-x/*</bind>*/;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,121358,121637);

string 
expectedOperationTree =
@"
IUnaryOperation (UnaryOperatorKind.Minus) (OperatorMethod: C C.op_UnaryNegation(C c)) (OperationKind.Unary, Type: C) (Syntax: '-x')
  Operand: 
    IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: C) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,121653,121740);

f_22073_121653_121739(source, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,121046,121751);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,121046,121751);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,121046,121751);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalNotFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,121763,125179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,121914,122088);

string 
source = @"
class P
{
    void M(bool a, bool b)
/*<bind>*/{
        GetArray()[0] =  !(a || b);
    }/*</bind>*/

    static bool[] GetArray() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,122102,124991);

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
                IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: System.Boolean, IsImplicit) (Syntax: 'b')
                  Operand: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False, IsImplicit) (Syntax: 'a')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'GetArray()[ ...  !(a || b);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'GetArray()[ ...   !(a || b)')
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,125005,125058);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,125074,125168);

f_22073_125074_125167(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,121763,125179);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,121763,125179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,121763,125179);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalNotFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,125191,126150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,125342,125449);

var 
source = @"
class C
{
    bool F(bool f)
    /*<bind>*/{
        return !f;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,125465,125962);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Next (Return) Block[B2]
        IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: System.Boolean) (Syntax: '!f')
          Operand: 
            IParameterReferenceOperation: f (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'f')
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,125976,126029);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,126045,126139);

f_22073_126045_126138(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,125191,126150);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,125191,126150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,125191,126150);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void LogicalNotFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,126164,126991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,126315,126423);

var 
source = @"
class C
{
    bool F(bool f)
    /*<bind>*/{
        return !!f;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,126439,126803);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Next (Return) Block[B2]
        IParameterReferenceOperation: f (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'f')
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,126817,126870);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,126886,126980);

f_22073_126886_126979(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,126164,126991);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,126164,126991);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,126164,126991);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicNotFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,127007,128385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,127158,127277);

string 
source = @"
class P
{
    void M(dynamic a, dynamic b)
/*<bind>*/{
        a = !b;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,127291,128197);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = !b;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'a = !b')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'a')
              Right: 
                IUnaryOperation (UnaryOperatorKind.Not) (OperationKind.Unary, Type: dynamic) (Syntax: '!b')
                  Operand: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'b')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,128211,128264);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,128280,128374);

f_22073_128280_128373(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,127007,128385);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,127007,128385);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,127007,128385);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyIndexOperator_Int()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,128397,129183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,128528,128703);

var 
compilation = f_22073_128546_128702(f_22073_128546_128682(@"
class Test
{
    void M(int arg)
    {
        var x = /*<bind>*/^arg/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,128719,128979);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Hat) (OperationKind.Unary, Type: System.Index) (Syntax: '^arg')
  Operand: 
    IParameterReferenceOperation: arg (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'arg')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,128995,129120);

var 
operation = (IUnaryOperation)f_22073_129028_129119(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,129134,129172);

f_22073_129134_129171(f_22073_129146_129170(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,128397,129183);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,128397,129183);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,128397,129183);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyIndexOperator_NullableInt()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,129195,130002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,129334,129510);

var 
compilation = f_22073_129352_129509(f_22073_129352_129489(@"
class Test
{
    void M(int? arg)
    {
        var x = /*<bind>*/^arg/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,129526,129798);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Hat, IsLifted) (OperationKind.Unary, Type: System.Index?) (Syntax: '^arg')
  Operand: 
    IParameterReferenceOperation: arg (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'arg')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,129814,129939);

var 
operation = (IUnaryOperation)f_22073_129847_129938(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,129953,129991);

f_22073_129953_129990(f_22073_129965_129989(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,129195,130002);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,129195,130002);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,129195,130002);
}
		}

[Fact]
        [CompilerTrait(CompilerFeature.IOperation)]
        public void VerifyIndexOperator_ConvertibleToInt()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22073,130014,131113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,130158,130334);

var 
compilation = f_22073_130176_130333(f_22073_130176_130313(@"
class Test
{
    void M(byte arg)
    {
        var x = /*<bind>*/^arg/*</bind>*/;
    }
}"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,130350,130909);

string 
expectedOperationTree = @"
IUnaryOperation (UnaryOperatorKind.Hat) (OperationKind.Unary, Type: System.Index) (Syntax: '^arg')
  Operand: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'arg')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IParameterReferenceOperation: arg (OperationKind.ParameterReference, Type: System.Byte) (Syntax: 'arg')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,130925,131050);

var 
operation = (IUnaryOperation)f_22073_130958_131049(compilation, expectedOperationTree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22073,131064,131102);

f_22073_131064_131101(f_22073_131076_131100(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(22073,130014,131113);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22073,130014,131113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22073,130014,131113);
}
		}

int
f_22073_1544_1630(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 1544, 1630);
return 0;
}


int
f_22073_2584_2670(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 2584, 2670);
return 0;
}


int
f_22073_3629_3715(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 3629, 3715);
return 0;
}


int
f_22073_4679_4765(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 4679, 4765);
return 0;
}


int
f_22073_5393_5479(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 5393, 5479);
return 0;
}


int
f_22073_6113_6199(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 6113, 6199);
return 0;
}


int
f_22073_6827_6913(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 6827, 6913);
return 0;
}


int
f_22073_7547_7633(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 7547, 7633);
return 0;
}


int
f_22073_8587_8673(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 8587, 8673);
return 0;
}


int
f_22073_9313_9399(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 9313, 9399);
return 0;
}


int
f_22073_10033_10119(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 10033, 10119);
return 0;
}


int
f_22073_10753_10839(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 10753, 10839);
return 0;
}


int
f_22073_11488_11574(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 11488, 11574);
return 0;
}


int
f_22073_12218_12304(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 12218, 12304);
return 0;
}


int
f_22073_13265_13351(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 13265, 13351);
return 0;
}


int
f_22073_14307_14393(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 14307, 14393);
return 0;
}


int
f_22073_15354_15440(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 15354, 15440);
return 0;
}


int
f_22073_16406_16492(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 16406, 16492);
return 0;
}


int
f_22073_17122_17208(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 17122, 17208);
return 0;
}


int
f_22073_18174_18260(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 18174, 18260);
return 0;
}


int
f_22073_18890_18976(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 18890, 18976);
return 0;
}


int
f_22073_19622_19708(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 19622, 19708);
return 0;
}


int
f_22073_20664_20750(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 20664, 20750);
return 0;
}


int
f_22073_21392_21478(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 21392, 21478);
return 0;
}


int
f_22073_22114_22200(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 22114, 22200);
return 0;
}


int
f_22073_22836_22922(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 22836, 22922);
return 0;
}


int
f_22073_23573_23659(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 23573, 23659);
return 0;
}


int
f_22073_24305_24391(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 24305, 24391);
return 0;
}


int
f_22073_25617_25703(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 25617, 25703);
return 0;
}


int
f_22073_26923_27009(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 26923, 27009);
return 0;
}


int
f_22073_28235_28321(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 28235, 28321);
return 0;
}


int
f_22073_29553_29639(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 29553, 29639);
return 0;
}


int
f_22073_30504_30590(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 30504, 30590);
return 0;
}


int
f_22073_31462_31548(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 31462, 31548);
return 0;
}


int
f_22073_32413_32499(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 32413, 32499);
return 0;
}


int
f_22073_33371_33457(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 33371, 33457);
return 0;
}


int
f_22073_34677_34763(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 34677, 34763);
return 0;
}


int
f_22073_35642_35728(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 35642, 35728);
return 0;
}


int
f_22073_36600_36686(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 36600, 36686);
return 0;
}


int
f_22073_37558_37644(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 37558, 37644);
return 0;
}


int
f_22073_38543_38629(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 38543, 38629);
return 0;
}


int
f_22073_39522_39608(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 39522, 39608);
return 0;
}


int
f_22073_40836_40922(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 40836, 40922);
return 0;
}


int
f_22073_42144_42230(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 42144, 42230);
return 0;
}


int
f_22073_43458_43544(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 43458, 43544);
return 0;
}


int
f_22073_44778_44864(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 44778, 44864);
return 0;
}


int
f_22073_45731_45817(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 45731, 45817);
return 0;
}


int
f_22073_47051_47137(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 47051, 47137);
return 0;
}


int
f_22073_48004_48090(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 48004, 48090);
return 0;
}


int
f_22073_48985_49071(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 48985, 49071);
return 0;
}


int
f_22073_50293_50379(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 50293, 50379);
return 0;
}


int
f_22073_51260_51346(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 51260, 51346);
return 0;
}


int
f_22073_52220_52306(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 52220, 52306);
return 0;
}


int
f_22073_53180_53266(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 53180, 53266);
return 0;
}


int
f_22073_54167_54253(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 54167, 54253);
return 0;
}


int
f_22073_55148_55234(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 55148, 55234);
return 0;
}


int
f_22073_55879_55965(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 55879, 55965);
return 0;
}


int
f_22073_56849_56935(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 56849, 56935);
return 0;
}


int
f_22073_57911_57997(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 57911, 57997);
return 0;
}


int
f_22073_58968_59054(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 58968, 59054);
return 0;
}


int
f_22073_60030_60116(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 60030, 60116);
return 0;
}


int
f_22073_61097_61183(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 61097, 61183);
return 0;
}


int
f_22073_61828_61914(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 61828, 61914);
return 0;
}


int
f_22073_62565_62651(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 62565, 62651);
return 0;
}


int
f_22073_63296_63382(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 63296, 63382);
return 0;
}


int
f_22073_64033_64119(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 64033, 64119);
return 0;
}


int
f_22073_65090_65176(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 65090, 65176);
return 0;
}


int
f_22073_65842_65928(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 65842, 65928);
return 0;
}


int
f_22073_66589_66675(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 66589, 66675);
return 0;
}


int
f_22073_67336_67422(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 67336, 67422);
return 0;
}


int
f_22073_68088_68174(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 68088, 68174);
return 0;
}


int
f_22073_68835_68921(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 68835, 68921);
return 0;
}


int
f_22073_70164_70250(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 70164, 70250);
return 0;
}


int
f_22073_71487_71573(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 71487, 71573);
return 0;
}


int
f_22073_72816_72902(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 72816, 72902);
return 0;
}


int
f_22073_74151_74237(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 74151, 74237);
return 0;
}


int
f_22073_75119_75205(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 75119, 75205);
return 0;
}


int
f_22073_76094_76180(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 76094, 76180);
return 0;
}


int
f_22073_77062_77148(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 77062, 77148);
return 0;
}


int
f_22073_78037_78123(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 78037, 78123);
return 0;
}


int
f_22073_79360_79446(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 79360, 79446);
return 0;
}


int
f_22073_80362_80448(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 80362, 80448);
return 0;
}


int
f_22073_81358_81444(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 81358, 81444);
return 0;
}


int
f_22073_82354_82440(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 82354, 82440);
return 0;
}


int
f_22073_83356_83442(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 83356, 83442);
return 0;
}


int
f_22073_84352_84438(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 84352, 84438);
return 0;
}


int
f_22073_85036_85122(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 85036, 85122);
return 0;
}


int
f_22073_85722_85808(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 85722, 85808);
return 0;
}


int
f_22073_86423_86509(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 86423, 86509);
return 0;
}


int
f_22073_87112_87198(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 87112, 87198);
return 0;
}


int
f_22073_88028_88114(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 88028, 88114);
return 0;
}


int
f_22073_88946_89032(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 88946, 89032);
return 0;
}


int
f_22073_89879_89965(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 89879, 89965);
return 0;
}


int
f_22073_90800_90886(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 90800, 90886);
return 0;
}


int
f_22073_91503_91589(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 91503, 91589);
return 0;
}


int
f_22073_92208_92294(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 92208, 92294);
return 0;
}


int
f_22073_92909_92995(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 92909, 92995);
return 0;
}


int
f_22073_93852_93938(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 93852, 93938);
return 0;
}


int
f_22073_94797_94883(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 94797, 94883);
return 0;
}


int
f_22073_95727_95813(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 95727, 95813);
return 0;
}


int
f_22073_96878_96964(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 96878, 96964);
return 0;
}


int
f_22073_98035_98121(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 98035, 98121);
return 0;
}


int
f_22073_99208_99294(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 99208, 99294);
return 0;
}


int
f_22073_100365_100451(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 100365, 100451);
return 0;
}


int
f_22073_101751_101837(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 101751, 101837);
return 0;
}


int
f_22073_103143_103229(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 103143, 103229);
return 0;
}


int
f_22073_104551_104637(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 104551, 104637);
return 0;
}


int
f_22073_105943_106029(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 105943, 106029);
return 0;
}


int
f_22073_107869_107945(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<IfStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 107869, 107945);
return 0;
}


int
f_22073_109782_109858(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<IfStatementSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 109782, 109858);
return 0;
}


int
f_22073_110528_110614(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 110528, 110614);
return 0;
}


int
f_22073_111753_111839(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 111753, 111839);
return 0;
}


int
f_22073_112741_112827(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 112741, 112827);
return 0;
}


int
f_22073_113731_113817(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 113731, 113817);
return 0;
}


int
f_22073_114568_114654(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 114568, 114654);
return 0;
}


int
f_22073_115975_116056(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 115975, 116056);
return 0;
}


int
f_22073_116647_116733(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 116647, 116733);
return 0;
}


int
f_22073_117322_117408(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 117322, 117408);
return 0;
}


int
f_22073_118131_118210(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<CastExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 118131, 118210);
return 0;
}


int
f_22073_118904_118990(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 118904, 118990);
return 0;
}


int
f_22073_119565_119651(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 119565, 119651);
return 0;
}


int
f_22073_120209_120295(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 120209, 120295);
return 0;
}


int
f_22073_120936_121022(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 120936, 121022);
return 0;
}


int
f_22073_121653_121739(string
testSrc,string
expectedOperationTree)
{
VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( testSrc, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 121653, 121739);
return 0;
}


int
f_22073_125074_125167(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 125074, 125167);
return 0;
}


int
f_22073_126045_126138(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 126045, 126138);
return 0;
}


int
f_22073_126886_126979(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 126886, 126979);
return 0;
}


int
f_22073_128280_128373(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 128280, 128373);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22073_128546_128682(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 128546, 128682);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22073_128546_128702(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 128546, 128702);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22073_129028_129119(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 129028, 129119);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22073_129146_129170(Microsoft.CodeAnalysis.Operations.IUnaryOperation
this_param)
{
var return_v = this_param.OperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22073, 129146, 129170);
return return_v;
}


int
f_22073_129134_129171(Microsoft.CodeAnalysis.IMethodSymbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 129134, 129171);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22073_129352_129489(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 129352, 129489);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22073_129352_129509(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 129352, 129509);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22073_129847_129938(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 129847, 129938);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22073_129965_129989(Microsoft.CodeAnalysis.Operations.IUnaryOperation
this_param)
{
var return_v = this_param.OperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22073, 129965, 129989);
return return_v;
}


int
f_22073_129953_129990(Microsoft.CodeAnalysis.IMethodSymbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 129953, 129990);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22073_130176_130313(string
text)
{
var return_v = CreateCompilationWithIndexAndRange( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 130176, 130313);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22073_130176_130333(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 130176, 130333);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22073_130958_131049(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<PrefixUnaryExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 130958, 131049);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_22073_131076_131100(Microsoft.CodeAnalysis.Operations.IUnaryOperation
this_param)
{
var return_v = this_param.OperatorMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22073, 131076, 131100);
return return_v;
}


int
f_22073_131064_131101(Microsoft.CodeAnalysis.IMethodSymbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22073, 131064, 131101);
return 0;
}

}
}
