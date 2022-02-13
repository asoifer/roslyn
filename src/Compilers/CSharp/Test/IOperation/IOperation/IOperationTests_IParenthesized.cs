// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesized()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,471,903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,596,726);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        return /*<bind>*/(a + b)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,816,892);

f_22058_816_891(f_22058_828_890(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,471,903);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,471,903);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,471,903);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedChild()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,915,1774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,1045,1175);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        return (/*<bind>*/a + b/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,1189,1563);

string 
expectedOperationTree = @"
IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a + b')
  Left: 
    IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
  Right: 
    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,1577,1630);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,1646,1763);

f_22058_1646_1762(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,915,1774);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,915,1774);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,915,1774);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedParent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,1786,2765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,1917,2047);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        /*<bind>*/return (a + b);/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,2061,2555);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return (a + b);')
  ReturnedValue: 
    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a + b')
      Left: 
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
      Right: 
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,2569,2622);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,2638,2754);

f_22058_2638_2753(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,1786,2765);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,1786,2765);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,1786,2765);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedMultipleNesting()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,2777,3228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,2917,3051);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        return (/*<bind>*/((a + b))/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,3141,3217);

f_22058_3141_3216(f_22058_3153_3215(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,2777,3228);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,2777,3228);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,2777,3228);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedMultipleNestingParent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,3240,4242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,3386,3520);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        /*<bind>*/return (((a + b)));/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,3534,4032);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return (((a + b)));')
  ReturnedValue: 
    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a + b')
      Left: 
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
      Right: 
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,4046,4099);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,4115,4231);

f_22058_4115_4230(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,3240,4242);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,3240,4242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,3240,4242);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedMultipleNesting02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,4254,4718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,4396,4541);

string 
source = @"
class P
{
    static int M1(int a, int b, int c)
    {
        return (/*<bind>*/((a + b) * c)/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,4631,4707);

f_22058_4631_4706(f_22058_4643_4705(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,4254,4718);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,4254,4718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,4254,4718);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedMultipleNesting02Parent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,4730,6027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,4878,5023);

string 
source = @"
class P
{
    static int M1(int a, int b, int c)
    {
        /*<bind>*/return (((a + b) * c));/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,5037,5817);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return (((a + b) * c));')
  ReturnedValue: 
    IBinaryOperation (BinaryOperatorKind.Multiply) (OperationKind.Binary, Type: System.Int32) (Syntax: '(a + b) * c')
      Left: 
        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a + b')
          Left: 
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
          Right: 
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
      Right: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,5831,5884);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,5900,6016);

f_22058_5900_6015(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,4730,6027);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,4730,6027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,4730,6027);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedMultipleNesting03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,6039,6492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,6181,6315);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        return /*<bind>*/(((a + b)))/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,6405,6481);

f_22058_6405_6480(f_22058_6417_6479(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,6039,6492);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,6039,6492);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,6039,6492);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedMultipleNesting03Parent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,6504,7508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,6652,6786);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        /*<bind>*/return (((a + b)));/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,6800,7298);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return (((a + b)));')
  ReturnedValue: 
    IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a + b')
      Left: 
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
      Right: 
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,7312,7365);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,7381,7497);

f_22058_7381_7496(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,6504,7508);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,6504,7508);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,6504,7508);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedMultipleNesting04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,7520,7973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,7662,7796);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        return ((/*<bind>*/(a + b)/*</bind>*/));
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,7886,7962);

f_22058_7886_7961(f_22058_7898_7960(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,7520,7973);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,7520,7973);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,7520,7973);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedMultipleNesting05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,7985,8438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,8127,8261);

string 
source = @"
class P
{
    static int M1(int a, int b)
    {
        return (((/*<bind>*/a + b/*</bind>*/)));
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,8351,8427);

f_22058_8351_8426(f_22058_8363_8425(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,7985,8438);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,7985,8438);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,7985,8438);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedImplicitConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,8450,8901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,8593,8724);

string 
source = @"
class P
{
    static long M1(int a, int b)
    {
        return /*<bind>*/(a + b)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,8814,8890);

f_22058_8814_8889(f_22058_8826_8888(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,8450,8901);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,8450,8901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,8450,8901);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedImplicitConversionParent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,8913,10229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,9062,9193);

string 
source = @"
class P
{
    static long M1(int a, int b)
    {
        /*<bind>*/return (a + b);/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,9207,10019);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return (a + b);')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int64, IsImplicit) (Syntax: 'a + b')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a + b')
          Left: 
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
          Right: 
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,10033,10086);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,10102,10218);

f_22058_10102_10217(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,8913,10229);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,8913,10229);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,8913,10229);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedExplicitConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,10241,10702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,10384,10525);

string 
source = @"
class P
{
    static double M1(int a, int b)
    {
        return /*<bind>*/(double)(a + b)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,10615,10691);

f_22058_10615_10690(f_22058_10627_10689(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,10241,10702);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,10241,10702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,10241,10702);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedExplicitConversionParent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,10714,12047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,10863,11004);

string 
source = @"
class P
{
    static double M1(int a, int b)
    {
        /*<bind>*/return (double)(a + b);/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,11018,11837);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return (double)(a + b);')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Double) (Syntax: '(double)(a + b)')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'a + b')
          Left: 
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'a')
          Right: 
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,11851,11904);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,11920,12036);

f_22058_11920_12035(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,10714,12047);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,10714,12047);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,10714,12047);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedConstantValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,12059,12488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,12197,12311);

string 
source = @"
class P
{
    static int M1()
    {
        return /*<bind>*/(5)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,12401,12477);

f_22058_12401_12476(f_22058_12413_12475(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,12059,12488);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,12059,12488);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,12059,12488);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedConstantValueParent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,12500,13209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,12644,12758);

string 
source = @"
class P
{
    static int M1()
    {
        /*<bind>*/return (5);/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,12772,12999);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return (5);')
  ReturnedValue: 
    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,13013,13066);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,13082,13198);

f_22058_13082_13197(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,12500,13209);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,12500,13209);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,12500,13209);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedQueryClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,13221,13700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,13357,13523);

string 
source = @"
using System.Linq;

class P
{
    static object M1(int[] a)
    {
        return from r in a select /*<bind>*/(-r)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,13613,13689);

f_22058_13613_13688(f_22058_13625_13687(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,13221,13700);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,13221,13700);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,13221,13700);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedQueryClauseParent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,13712,17814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,13854,14020);

string 
source = @"
using System.Linq;

class P
{
    static object M1(int[] a)
    {
        /*<bind>*/return from r in a select (-r);/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,14034,17604);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null) (Syntax: 'return from ... elect (-r);')
  ReturnedValue: 
    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: 'from r in a select (-r)')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
      Operand: 
        ITranslatedQueryOperation (OperationKind.TranslatedQuery, Type: System.Collections.Generic.IEnumerable<System.Int32>) (Syntax: 'from r in a select (-r)')
          Expression: 
            IInvocationOperation (System.Collections.Generic.IEnumerable<System.Int32> System.Linq.Enumerable.Select<System.Int32, System.Int32>(this System.Collections.Generic.IEnumerable<System.Int32> source, System.Func<System.Int32, System.Int32> selector)) (OperationKind.Invocation, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'select (-r)')
              Instance Receiver: 
                null
              Arguments(2):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: source) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'from r in a')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Collections.Generic.IEnumerable<System.Int32>, IsImplicit) (Syntax: 'from r in a')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: selector) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '(-r)')
                    IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Func<System.Int32, System.Int32>, IsImplicit) (Syntax: '(-r)')
                      Target: 
                        IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsImplicit) (Syntax: '(-r)')
                          IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsImplicit) (Syntax: '(-r)')
                            IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: '(-r)')
                              ReturnedValue: 
                                IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32) (Syntax: '-r')
                                  Operand: 
                                    IParameterReferenceOperation: r (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'r')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,17618,17671);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,17687,17803);

f_22058_17687_17802(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,13712,17814);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,13712,17814);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,13712,17814);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedErrorOperand()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,17826,18254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,17963,18077);

string 
source = @"
class P
{
    static int M1()
    {
        return /*<bind>*/(a)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,18167,18243);

f_22058_18167_18242(f_22058_18179_18241(source));
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,17826,18254);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,17826,18254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,17826,18254);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestParenthesizedErrorOperandParent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,18266,19253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,18409,18523);

string 
source = @"
class P
{
    static int M1()
    {
        /*<bind>*/return (a);/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,18537,18781);

string 
expectedOperationTree = @"
IReturnOperation (OperationKind.Return, Type: null, IsInvalid) (Syntax: 'return (a);')
  ReturnedValue: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'a')
      Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,18795,19110);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22058_19008_19094(f_22058_19008_19074(f_22058_19008_19055(ErrorCode.ERR_NameNotInContext, "a"), "a"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,19126,19242);

f_22058_19126_19241(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,18266,19253);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,18266,19253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,18266,19253);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ParenthesizedFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,19265,20507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,19419,19528);

string 
source = @"
class C
{
    void M(int i)
    /*<bind>*/{
        i = (3);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,19542,19595);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,19611,20384);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = (3);')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = (3)')
              Left: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,20398,20496);

f_22058_20398_20495(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,19265,20507);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,19265,20507);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,19265,20507);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ParenthesizedFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,20519,23202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,20673,20798);

string 
source = @"
class C
{
    void M(int i, bool b)
    /*<bind>*/{
        i = (b ? 3 : 5);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,20812,20865);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,20881,23079);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = (b ? 3 : 5);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = (b ? 3 : 5)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 3 : 5')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,23093,23191);

f_22058_23093_23190(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,20519,23202);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,20519,23202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,20519,23202);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ParenthesizedFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,23214,25907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,23368,23495);

string 
source = @"
class C
{
    void M(int i, bool b)
    /*<bind>*/{
        i = b ? (3) : (5);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,23509,23562);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,23578,25784);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
              Value: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = b ? (3) : (5);')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = b ? (3) : (5)')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? (3) : (5)')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,25798,25896);

f_22058_25798_25895(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,23214,25907);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,23214,25907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,23214,25907);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ParenthesizedFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22058,25919,30358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,26073,26305);

string 
source = @"
class C
{
    void M(C2 c, bool b)
    /*bind*/{
        M2(ref (c.i), b ? 3 : 5);
    }/*</bind>*/

    private void M2(ref int i, int v)
    {
        i = v;
    }
}

class C2 { public int i; }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,26319,26372);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,26388,30235);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'M2')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c.i')
              Value: 
                IFieldReferenceOperation: System.Int32 C2.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'c.i')
                  Instance Receiver: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C2) (Syntax: 'c')

        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '3')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '5')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(ref (c.i ... b ? 3 : 5);')
              Expression: 
                IInvocationOperation ( void C.M2(ref System.Int32 i, System.Int32 v)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(ref (c.i), b ? 3 : 5)')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'M2')
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'c.i')
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'c.i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: v) (OperationKind.Argument, Type: null) (Syntax: 'b ? 3 : 5')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'b ? 3 : 5')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22058,30249,30347);

f_22058_30249_30346(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22058,25919,30358);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22058,25919,30358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22058,25919,30358);
}
		}

string
f_22058_828_890(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 828, 890);
return return_v;
}


int
f_22058_816_891(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 816, 891);
return 0;
}


int
f_22058_1646_1762(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BinaryExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 1646, 1762);
return 0;
}


int
f_22058_2638_2753(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 2638, 2753);
return 0;
}


string
f_22058_3153_3215(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 3153, 3215);
return return_v;
}


int
f_22058_3141_3216(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 3141, 3216);
return 0;
}


int
f_22058_4115_4230(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 4115, 4230);
return 0;
}


string
f_22058_4643_4705(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 4643, 4705);
return return_v;
}


int
f_22058_4631_4706(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 4631, 4706);
return 0;
}


int
f_22058_5900_6015(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 5900, 6015);
return 0;
}


string
f_22058_6417_6479(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 6417, 6479);
return return_v;
}


int
f_22058_6405_6480(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 6405, 6480);
return 0;
}


int
f_22058_7381_7496(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 7381, 7496);
return 0;
}


string
f_22058_7898_7960(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 7898, 7960);
return return_v;
}


int
f_22058_7886_7961(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 7886, 7961);
return 0;
}


string
f_22058_8363_8425(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 8363, 8425);
return return_v;
}


int
f_22058_8351_8426(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 8351, 8426);
return 0;
}


string
f_22058_8826_8888(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 8826, 8888);
return return_v;
}


int
f_22058_8814_8889(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 8814, 8889);
return 0;
}


int
f_22058_10102_10217(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 10102, 10217);
return 0;
}


string
f_22058_10627_10689(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 10627, 10689);
return return_v;
}


int
f_22058_10615_10690(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 10615, 10690);
return 0;
}


int
f_22058_11920_12035(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 11920, 12035);
return 0;
}


string
f_22058_12413_12475(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 12413, 12475);
return return_v;
}


int
f_22058_12401_12476(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 12401, 12476);
return 0;
}


int
f_22058_13082_13197(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 13082, 13197);
return 0;
}


string
f_22058_13625_13687(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 13625, 13687);
return return_v;
}


int
f_22058_13613_13688(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 13613, 13688);
return 0;
}


int
f_22058_17687_17802(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 17687, 17802);
return 0;
}


string
f_22058_18179_18241(string
testSrc)
{
var return_v = GetOperationTreeForTest<ParenthesizedExpressionSyntax>( testSrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 18179, 18241);
return return_v;
}


int
f_22058_18167_18242(string
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 18167, 18242);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22058_19008_19055(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 19008, 19055);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22058_19008_19074(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 19008, 19074);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22058_19008_19094(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 19008, 19094);
return return_v;
}


int
f_22058_19126_19241(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ReturnStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 19126, 19241);
return 0;
}


int
f_22058_20398_20495(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 20398, 20495);
return 0;
}


int
f_22058_23093_23190(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 23093, 23190);
return 0;
}


int
f_22058_25798_25895(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 25798, 25895);
return 0;
}


int
f_22058_30249_30346(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22058, 30249, 30346);
return 0;
}

}
}
