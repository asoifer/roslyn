// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[Fact]
        public void SimpleStackAllocArrayCreation_PrimitiveType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,501,1528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,599,728);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,742,990);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[1]')
  Children(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,1004,1367);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_1272_1351(f_22077_1272_1331(ErrorCode.ERR_UnsafeNeeded, "stackalloc int[1]"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,1383,1517);

f_22077_1383_1516(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,501,1528);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,501,1528);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,501,1528);
}
		}

[Fact]
        public void SimpleStackAllocArrayCreation_UserDefinedType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,1540,2577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,1640,1783);

string 
source = @"
struct M { }

class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc M[1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,1797,2043);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc M[1]')
  Children(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,2057,2416);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_2323_2400(f_22077_2323_2380(ErrorCode.ERR_UnsafeNeeded, "stackalloc M[1]"), 8, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,2432,2566);

f_22077_2432_2565(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,1540,2577);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,1540,2577);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,1540,2577);
}
		}

[Fact]
        public void SimpleStackAllocArrayCreation_ConstantDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,2589,3727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,2691,2876);

string 
source = @"
struct M { }

class C
{
    public void F()
    {
        const int dimension = 1;
        var a = /*<bind>*/stackalloc M[dimension]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,2890,3177);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc M[dimension]')
  Children(1):
      ILocalReferenceOperation: dimension (OperationKind.LocalReference, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: 'dimension')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,3191,3566);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_3465_3550(f_22077_3465_3530(ErrorCode.ERR_UnsafeNeeded, "stackalloc M[dimension]"), 9, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,3582,3716);

f_22077_3582_3715(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,2589,3727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,2589,3727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,2589,3727);
}
		}

[Fact]
        public void SimpleStackAllocArrayCreation_NonConstantDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,3739,4854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,3844,4008);

string 
source = @"
struct M { }

class C
{
    public void F(int dimension)
    {
        var a = /*<bind>*/stackalloc M[dimension]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,4022,4304);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc M[dimension]')
  Children(1):
      IParameterReferenceOperation: dimension (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'dimension')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,4318,4693);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_4592_4677(f_22077_4592_4657(ErrorCode.ERR_UnsafeNeeded, "stackalloc M[dimension]"), 8, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,4709,4843);

f_22077_4709_4842(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,3739,4854);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,3739,4854);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,3739,4854);
}
		}

[Fact]
        public void SimpleStackAllocArrayCreation_DimensionWithImplicitConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,4866,6315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,4982,5147);

string 
source = @"
struct M { }

class C
{
    public void F(char dimension)
    {
        var a = /*<bind>*/stackalloc M[dimension]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,5161,5765);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc M[dimension]')
  Children(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'dimension')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: dimension (OperationKind.ParameterReference, Type: System.Char, IsInvalid) (Syntax: 'dimension')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,5779,6154);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_6053_6138(f_22077_6053_6118(ErrorCode.ERR_UnsafeNeeded, "stackalloc M[dimension]"), 8, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,6170,6304);

f_22077_6170_6303(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,4866,6315);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,4866,6315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,4866,6315);
}
		}

[Fact]
        public void SimpleStackAllocArrayCreation_DimensionWithExplicitConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,6327,7793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,6443,6615);

string 
source = @"
struct M { }

class C
{
    public void F(object dimension)
    {
        var a = /*<bind>*/stackalloc M[(int)dimension]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,6629,7233);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc  ... )dimension]')
  Children(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid) (Syntax: '(int)dimension')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: dimension (OperationKind.ParameterReference, Type: System.Object, IsInvalid) (Syntax: 'dimension')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,7247,7632);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_7526_7616(f_22077_7526_7596(ErrorCode.ERR_UnsafeNeeded, "stackalloc M[(int)dimension]"), 8, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,7648,7782);

f_22077_7648_7781(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,6327,7793);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,6327,7793);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,6327,7793);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializer_PrimitiveType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,7805,9008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,7912,8047);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[] { 42 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,8061,8458);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[] { 42 }')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid, IsImplicit) (Syntax: 'stackalloc int[] { 42 }')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,8472,8847);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_8746_8831(f_22077_8746_8811(ErrorCode.ERR_UnsafeNeeded, "stackalloc int[] { 42 }"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,8863,8997);

f_22077_8863_8996(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,7805,9008);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,7805,9008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,7805,9008);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializer_PrimitiveTypeWithExplicitDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,9020,10214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,9148,9284);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[1] { 42 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,9298,9662);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[1] { 42 }')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,9676,10053);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_9951_10037(f_22077_9951_10017(ErrorCode.ERR_UnsafeNeeded, "stackalloc int[1] { 42 }"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,10069,10203);

f_22077_10069_10202(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,9020,10214);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,9020,10214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,9020,10214);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializerErrorCase_PrimitiveTypeWithIncorrectExplicitDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,10226,11453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,10372,10508);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[2] { 42 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,10522,10886);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[2] { 42 }')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,10900,11292);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_11152_11276(f_22077_11152_11256(f_22077_11152_11237(ErrorCode.ERR_ArrayInitializerIncorrectLength, "stackalloc int[2] { 42 }"), "2"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,11308,11442);

f_22077_11308_11441(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,10226,11453);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,10226,11453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,10226,11453);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializerErrorCase_PrimitiveTypeWithNonConstantExplicitDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,11465,12676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,11613,11770);

string 
source = @"
class C
{
    public void F(int dimension)
    {
        var a = /*<bind>*/stackalloc int[dimension] { 42 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,11784,12168);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc  ... ion] { 42 }')
  Children(2):
      IParameterReferenceOperation: dimension (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'dimension')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42) (Syntax: '42')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,12182,12515);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_12424_12499(f_22077_12424_12479(ErrorCode.ERR_ConstantExpected, "dimension"), 6, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,12531,12665);

f_22077_12531_12664(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,11465,12676);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,11465,12676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,11465,12676);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializer_UserDefinedType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,12688,14006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,12797,12951);

string 
source = @"
struct M { }

class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc M[] { new M() }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,12965,13450);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc  ... { new M() }')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid, IsImplicit) (Syntax: 'stackalloc  ... { new M() }')
      IObjectCreationOperation (Constructor: M..ctor()) (OperationKind.ObjectCreation, Type: M, IsInvalid) (Syntax: 'new M()')
        Arguments(0)
        Initializer: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,13464,13845);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_13741_13829(f_22077_13741_13809(ErrorCode.ERR_UnsafeNeeded, "stackalloc M[] { new M() }"), 8, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,13861,13995);

f_22077_13861_13994(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,12688,14006);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,12688,14006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,12688,14006);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializer_ImplicitlyTyped()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,14018,15332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,14127,14279);

string 
source = @"
struct M { }

class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc[] { new M() }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,14293,14772);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc[] { new M() }')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid, IsImplicit) (Syntax: 'stackalloc[] { new M() }')
      IObjectCreationOperation (Constructor: M..ctor()) (OperationKind.ObjectCreation, Type: M, IsInvalid) (Syntax: 'new M()')
        Arguments(0)
        Initializer: 
          null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,14786,15163);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_15061_15147(f_22077_15061_15127(ErrorCode.ERR_UnsafeNeeded, "stackalloc[] { new M() }"), 8, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,15179,15321);

f_22077_15179_15320(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,14018,15332);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,14018,15332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,14018,15332);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializerErrorCase_ImplicitlyTypedWithoutInitializerAndDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,15344,16902);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,15492,15629);

string 
source = @"
class C
{
    public void F(int dimension)
    {
        var x = /*<bind>*/stackalloc[]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,15643,15931);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc[]/*</bind>*/')
  Children(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid, IsImplicit) (Syntax: 'stackalloc[]/*</bind>*/')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,15945,16733);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_16149_16214(f_22077_16149_16194(ErrorCode.ERR_LbraceExpected, ";"), 6, 50),
f_22077_16364_16429(f_22077_16364_16409(ErrorCode.ERR_RbraceExpected, ";"), 6, 50),
f_22077_16614_16717(f_22077_16614_16697(ErrorCode.ERR_ImplicitlyTypedArrayNoBestType, "stackalloc[]/*</bind>*/"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,16749,16891);

f_22077_16749_16890(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,15344,16902);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,15344,16902);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,15344,16902);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializerErrorCase_ImplicitlyTypedWithoutInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,16914,18718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,17050,17188);

string 
source = @"
class C
{
    public void F(int dimension)
    {
        var x = /*<bind>*/stackalloc[2]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,17202,17492);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc[2]/*</bind>*/')
  Children(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid, IsImplicit) (Syntax: 'stackalloc[2]/*</bind>*/')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,17506,18549);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_17738_17811(f_22077_17738_17791(ErrorCode.ERR_InvalidStackAllocArray, "2"), 6, 38),
f_22077_17962_18027(f_22077_17962_18007(ErrorCode.ERR_LbraceExpected, ";"), 6, 51),
f_22077_18178_18243(f_22077_18178_18223(ErrorCode.ERR_RbraceExpected, ";"), 6, 51),
f_22077_18429_18533(f_22077_18429_18513(ErrorCode.ERR_ImplicitlyTypedArrayNoBestType, "stackalloc[2]/*</bind>*/"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,18565,18707);

f_22077_18565_18706(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,16914,18718);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,16914,18718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,16914,18718);
}
		}

[Fact]
        public void StackAllocArrayCreationWithInitializer_MultipleInitializersWithConversions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,18730,20580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,18859,19022);

string 
source = @"
class C
{
    public void F()
    {
        var a = 42;
        var b = /*<bind>*/stackalloc[] { 2, a, default }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,19036,20008);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc[ ... , default }')
  Children(4):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid, IsImplicit) (Syntax: 'stackalloc[ ... , default }')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
      ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'a')
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 0, IsInvalid, IsImplicit) (Syntax: 'default')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: 'default')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,20022,20411);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_20303_20395(f_22077_20303_20375(ErrorCode.ERR_UnsafeNeeded, "stackalloc[] { 2, a, default }"), 7, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,20427,20569);

f_22077_20427_20568(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,18730,20580);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,18730,20580);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,18730,20580);
}
		}

[Fact]
        public void StackAllocArrayCreationErrorCase_MissingDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,20592,21594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,20696,20824);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,20838,21081);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[]')
  Children(1):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: '')
        Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,21095,21433);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_21349_21417(f_22077_21349_21397(ErrorCode.ERR_MissingArraySize, "[]"), 6, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,21449,21583);

f_22077_21449_21582(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,20592,21594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,20592,21594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,20592,21594);
}
		}

[Fact]
        public void StackAllocArrayCreationErrorCase_InvalidInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,21606,22801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,21712,21846);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[] { 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,21860,22253);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[] { 1 }')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid, IsImplicit) (Syntax: 'stackalloc int[] { 1 }')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,22267,22640);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_22540_22624(f_22077_22540_22604(ErrorCode.ERR_UnsafeNeeded, "stackalloc int[] { 1 }"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,22656,22790);

f_22077_22656_22789(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,21606,22801);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,21606,22801);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,21606,22801);
}
		}

[Fact]
        public void StackAllocArrayCreationErrorCase_MissingExplicitCast()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,22813,24536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,22920,23057);

string 
source = @"
class C
{
    public void F(object b)
    {
        var a = /*<bind>*/stackalloc int[b]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,23071,23648);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[b]')
  Children(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Object, IsInvalid) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,23662,24375);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_23966_24066(f_22077_23966_24046(f_22077_23966_24015(ErrorCode.ERR_NoImplicitConvCast, "b"), "object", "int"), 6, 42),
f_22077_24280_24359(f_22077_24280_24339(ErrorCode.ERR_UnsafeNeeded, "stackalloc int[b]"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,24391,24525);

f_22077_24391_24524(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,22813,24536);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,22813,24536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,22813,24536);
}
		}

[Fact]
        public void StackAllocArrayCreation_InvocationExpressionAsDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,24548,25850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,24658,24817);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[M()]/*</bind>*/;
    }

    public int M() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,24831,25308);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[M()]')
  Children(1):
      IInvocationOperation ( System.Int32 C.M()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M()')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M')
        Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,25322,25689);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_25592_25673(f_22077_25592_25653(ErrorCode.ERR_UnsafeNeeded, "stackalloc int[M()]"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,25705,25839);

f_22077_25705_25838(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,24548,25850);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,24548,25850);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,24548,25850);
}
		}

[Fact]
        public void StackAllocArrayCreation_InvocationExpressionWithConversionAsDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,25862,27529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,25986,26156);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[(int)M()]/*</bind>*/;
    }

    public object M() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,26170,26977);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[(int)M()]')
  Children(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid) (Syntax: '(int)M()')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvocationOperation ( System.Object C.M()) (OperationKind.Invocation, Type: System.Object, IsInvalid) (Syntax: 'M()')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M')
            Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,26991,27368);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_27266_27352(f_22077_27266_27332(ErrorCode.ERR_UnsafeNeeded, "stackalloc int[(int)M()]"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,27384,27518);

f_22077_27384_27517(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,25862,27529);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,25862,27529);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,25862,27529);
}
		}

[Fact]
        public void StackAllocArrayCreationErrorCase_InvocationExpressionAsDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,27541,29022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,27660,27832);

string 
source = @"
class C
{
    public static void F()
    {
        var a = /*<bind>*/stackalloc int[M()]/*</bind>*/;
    }

    public object M() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,27846,28457);

string 
expectedOperationTree = @"
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[M()]')
      Children(1):
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M()')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IInvalidOperation (OperationKind.Invalid, Type: System.Object, IsInvalid) (Syntax: 'M()')
                Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,28471,28861);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_28757_28845(f_22077_28757_28825(f_22077_28757_28802(ErrorCode.ERR_ObjectRequired, "M"), "C.M()"), 6, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,28877,29011);

f_22077_28877_29010(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,27541,29022);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,27541,29022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,27541,29022);
}
		}

[Fact]
        public void StackAllocArrayCreationErrorCase_InvocationExpressionWithConversionAsDimension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,29034,30660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,29167,29335);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[(int)M()]/*</bind>*/;
    }

    public C M() => new C();
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,29349,30133);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[(int)M()]')
  Children(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid) (Syntax: '(int)M()')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvocationOperation ( C C.M()) (OperationKind.Invocation, Type: C, IsInvalid) (Syntax: 'M()')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M')
            Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,30147,30499);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_30385_30483(f_22077_30385_30463(f_22077_30385_30437(ErrorCode.ERR_NoExplicitConv, "(int)M()"), "C", "int"), 6, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,30515,30649);

f_22077_30515_30648(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,29034,30660);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,29034,30660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,29034,30660);
}
		}

[Fact]
        public void SimpleStackAllocArrayCreation_ConstantConversion()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22077,30672,32398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,30775,30906);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/stackalloc int[0.0]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,30920,31503);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'stackalloc int[0.0]')
  Children(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, Constant: 0, IsInvalid, IsImplicit) (Syntax: '0.0')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 0, IsInvalid) (Syntax: '0.0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,31517,32237);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22077_31822_31924(f_22077_31822_31904(f_22077_31822_31873(ErrorCode.ERR_NoImplicitConvCast, "0.0"), "double", "int"), 6, 42),
f_22077_32140_32221(f_22077_32140_32201(ErrorCode.ERR_UnsafeNeeded, "stackalloc int[0.0]"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22077,32253,32387);

f_22077_32253_32386(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22077,30672,32398);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22077,30672,32398);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22077,30672,32398);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_1272_1331(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 1272, 1331);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_1272_1351(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 1272, 1351);
return return_v;
}


int
f_22077_1383_1516(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 1383, 1516);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_2323_2380(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 2323, 2380);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_2323_2400(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 2323, 2400);
return return_v;
}


int
f_22077_2432_2565(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 2432, 2565);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_3465_3530(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 3465, 3530);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_3465_3550(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 3465, 3550);
return return_v;
}


int
f_22077_3582_3715(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 3582, 3715);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_4592_4657(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 4592, 4657);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_4592_4677(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 4592, 4677);
return return_v;
}


int
f_22077_4709_4842(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 4709, 4842);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_6053_6118(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 6053, 6118);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_6053_6138(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 6053, 6138);
return return_v;
}


int
f_22077_6170_6303(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 6170, 6303);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_7526_7596(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 7526, 7596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_7526_7616(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 7526, 7616);
return return_v;
}


int
f_22077_7648_7781(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 7648, 7781);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_8746_8811(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 8746, 8811);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_8746_8831(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 8746, 8831);
return return_v;
}


int
f_22077_8863_8996(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 8863, 8996);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_9951_10017(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 9951, 10017);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_9951_10037(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 9951, 10037);
return return_v;
}


int
f_22077_10069_10202(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 10069, 10202);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_11152_11237(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 11152, 11237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_11152_11256(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 11152, 11256);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_11152_11276(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 11152, 11276);
return return_v;
}


int
f_22077_11308_11441(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 11308, 11441);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_12424_12479(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 12424, 12479);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_12424_12499(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 12424, 12499);
return return_v;
}


int
f_22077_12531_12664(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 12531, 12664);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_13741_13809(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 13741, 13809);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_13741_13829(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 13741, 13829);
return return_v;
}


int
f_22077_13861_13994(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 13861, 13994);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_15061_15127(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 15061, 15127);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_15061_15147(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 15061, 15147);
return return_v;
}


int
f_22077_15179_15320(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitStackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 15179, 15320);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_16149_16194(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 16149, 16194);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_16149_16214(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 16149, 16214);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_16364_16409(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 16364, 16409);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_16364_16429(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 16364, 16429);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_16614_16697(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 16614, 16697);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_16614_16717(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 16614, 16717);
return return_v;
}


int
f_22077_16749_16890(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitStackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 16749, 16890);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_17738_17791(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 17738, 17791);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_17738_17811(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 17738, 17811);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_17962_18007(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 17962, 18007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_17962_18027(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 17962, 18027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_18178_18223(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 18178, 18223);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_18178_18243(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 18178, 18243);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_18429_18513(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 18429, 18513);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_18429_18533(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 18429, 18533);
return return_v;
}


int
f_22077_18565_18706(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitStackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 18565, 18706);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_20303_20375(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 20303, 20375);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_20303_20395(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 20303, 20395);
return return_v;
}


int
f_22077_20427_20568(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ImplicitStackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 20427, 20568);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_21349_21397(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 21349, 21397);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_21349_21417(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 21349, 21417);
return return_v;
}


int
f_22077_21449_21582(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 21449, 21582);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_22540_22604(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 22540, 22604);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_22540_22624(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 22540, 22624);
return return_v;
}


int
f_22077_22656_22789(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 22656, 22789);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_23966_24015(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 23966, 24015);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_23966_24046(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 23966, 24046);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_23966_24066(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 23966, 24066);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_24280_24339(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 24280, 24339);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_24280_24359(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 24280, 24359);
return return_v;
}


int
f_22077_24391_24524(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 24391, 24524);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_25592_25653(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 25592, 25653);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_25592_25673(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 25592, 25673);
return return_v;
}


int
f_22077_25705_25838(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 25705, 25838);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_27266_27332(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 27266, 27332);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_27266_27352(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 27266, 27352);
return return_v;
}


int
f_22077_27384_27517(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 27384, 27517);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_28757_28802(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 28757, 28802);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_28757_28825(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 28757, 28825);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_28757_28845(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 28757, 28845);
return return_v;
}


int
f_22077_28877_29010(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 28877, 29010);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_30385_30437(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 30385, 30437);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_30385_30463(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 30385, 30463);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_30385_30483(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 30385, 30483);
return return_v;
}


int
f_22077_30515_30648(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 30515, 30648);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_31822_31873(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 31822, 31873);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_31822_31904(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 31822, 31904);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_31822_31924(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 31822, 31924);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_32140_32201(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 32140, 32201);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22077_32140_32221(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 32140, 32221);
return return_v;
}


int
f_22077_32253_32386(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<StackAllocArrayCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22077, 32253, 32386);
return 0;
}

}
}
