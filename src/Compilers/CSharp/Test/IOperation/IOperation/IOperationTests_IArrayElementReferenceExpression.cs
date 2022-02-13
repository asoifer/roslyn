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
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_SingleDimensionArray_ConstantIndex()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,501,1491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,731,863);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[0]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,877,1273);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[0]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,1287,1340);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,1356,1480);

f_22007_1356_1479(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,501,1491);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,501,1491);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,501,1491);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_SingleDimensionArray_NonConstantIndex()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,1503,2515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,1736,1875);

string 
source = @"
class C
{
    public void F(string[] args, int x)
    {
        var a = /*<bind>*/args[x]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,1889,2297);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[x]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,2311,2364);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,2380,2504);

f_22007_2380_2503(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,1503,2515);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,1503,2515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,1503,2515);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_SingleDimensionArray_FunctionCallArrayReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,2527,3752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,2770,2926);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/F2()[0]/*</bind>*/;
    }

    public string[] F2() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,2940,3534);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'F2()[0]')
  Array reference: 
    IInvocationOperation ( System.String[] C.F2()) (OperationKind.Invocation, Type: System.String[]) (Syntax: 'F2()')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'F2')
      Arguments(0)
  Indices(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,3548,3601);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,3617,3741);

f_22007_3617_3740(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,2527,3752);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,2527,3752);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,2527,3752);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_MultiDimensionArray_ConstantIndices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,3764,4859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,3995,4131);

string 
source = @"
class C
{
    public void F(string[,] args)
    {
        var a = /*<bind>*/args[0, 1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,4145,4641);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[0, 1]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[,]) (Syntax: 'args')
  Indices(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,4655,4708);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,4724,4848);

f_22007_4724_4847(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,3764,4859);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,3764,4859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,3764,4859);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_MultiDimensionArray_NonConstantIndices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,4871,6007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,5105,5255);

string 
source = @"
class C
{
    public void F(string[,] args, int x, int y)
    {
        var a = /*<bind>*/args[x, y]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,5269,5789);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[x, y]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[,]) (Syntax: 'args')
  Indices(2):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
      IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,5803,5856);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,5872,5996);

f_22007_5872_5995(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,4871,6007);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,4871,6007);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,4871,6007);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_MultiDimensionArray_InvocationInIndex()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,6019,7394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,6252,6440);

string 
source = @"
class C
{
    public void F(string[,] args)
    {
        int x = 0;
        var a = /*<bind>*/args[x, F2()]/*</bind>*/;
    }

    public int F2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,6454,7176);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[x, F2()]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[,]) (Syntax: 'args')
  Indices(2):
      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
      IInvocationOperation ( System.Int32 C.F2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'F2()')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'F2')
        Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,7190,7243);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,7259,7383);

f_22007_7259_7382(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,6019,7394);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,6019,7394);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,6019,7394);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_JaggedArray_ConstantIndices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,7406,8665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,7629,7766);

string 
source = @"
class C
{
    public void F(string[][] args)
    {
        var a = /*<bind>*/args[0][0]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,7780,8447);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[0][0]')
  Array reference: 
    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String[]) (Syntax: 'args[0]')
      Array reference: 
        IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[][]) (Syntax: 'args')
      Indices(1):
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  Indices(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,8461,8514);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,8530,8654);

f_22007_8530_8653(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,7406,8665);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,7406,8665);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,7406,8665);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_JaggedArray_NonConstantIndices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,8677,10232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,8903,9092);

string 
source = @"
class C
{
    public void F(string[][] args)
    {
        int x = 0;
        var a = /*<bind>*/args[F2()][x]/*</bind>*/;
    }

    public int F2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,9106,10014);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[F2()][x]')
  Array reference: 
    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String[]) (Syntax: 'args[F2()]')
      Array reference: 
        IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[][]) (Syntax: 'args')
      Indices(1):
          IInvocationOperation ( System.Int32 C.F2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'F2()')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'F2')
            Arguments(0)
  Indices(1):
      ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,10028,10081);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,10097,10221);

f_22007_10097_10220(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,8677,10232);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,8677,10232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,8677,10232);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_JaggedArrayOfMultidimensionalArrays()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,10244,11894);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,10475,10668);

string 
source = @"
class C
{
    public void F(string[][,] args)
    {
        int x = 0;
        var a = /*<bind>*/args[x][0, F2()]/*</bind>*/;
    }

    public int F2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,10682,11676);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[x][0, F2()]')
  Array reference: 
    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String[,]) (Syntax: 'args[x]')
      Array reference: 
        IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[][,]) (Syntax: 'args')
      Indices(1):
          ILocalReferenceOperation: x (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
  Indices(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      IInvocationOperation ( System.Int32 C.F2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'F2()')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'F2')
        Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,11690,11743);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,11759,11883);

f_22007_11759_11882(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,10244,11894);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,10244,11894);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,10244,11894);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_ImplicitConversionInIndexExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,11906,13220);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,12137,12277);

string 
source = @"
class C
{
    public void F(string[] args, byte b)
    {
        var a = /*<bind>*/args[b]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,12291,13002);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[b]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'b')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Byte) (Syntax: 'b')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,13016,13069);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,13085,13209);

f_22007_13085_13208(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,11906,13220);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,11906,13220);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,11906,13220);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_ExplicitConversionInIndexExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,13232,14553);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,13463,13610);

string 
source = @"
class C
{
    public void F(string[] args, double d)
    {
        var a = /*<bind>*/args[(int)d]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,13624,14335);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[(int)d]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)d')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Double) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,14349,14402);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,14418,14542);

f_22007_14418_14541(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,13232,14553);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,13232,14553);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,13232,14553);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_ImplicitUserDefinedConversionInIndexExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,14565,16035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,14807,15025);

string 
source = @"
class C
{
    public void F(string[] args, C c)
    {
        var a = /*<bind>*/args[c]/*</bind>*/;
    }

    public static implicit operator int(C c)
    {
        return 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,15039,15817);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[c]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Int32 C.op_Implicit(C c)) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'c')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Implicit(C c))
        Operand: 
          IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,15831,15884);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,15900,16024);

f_22007_15900_16023(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,14565,16035);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,14565,16035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,14565,16035);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_ExplicitUserDefinedConversionInIndexExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,16047,17520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,16289,16512);

string 
source = @"
class C
{
    public void F(string[] args, C c)
    {
        var a = /*<bind>*/args[(int)c]/*</bind>*/;
    }

    public static explicit operator int(C c)
    {
        return 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,16526,17302);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[(int)c]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Int32 C.op_Explicit(C c)) (OperationKind.Conversion, Type: System.Int32) (Syntax: '(int)c')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Explicit(C c))
        Operand: 
          IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,17316,17369);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,17385,17509);

f_22007_17385_17508(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,16047,17520);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,16047,17520);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,16047,17520);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReference_ExplicitUserDefinedConversionInArrayReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,17532,19011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,17773,18000);

string 
source = @"
class C
{
    public void F(C c, int x)
    {
        var a = /*<bind>*/((string[])c)[x]/*</bind>*/;
    }

    public static explicit operator string[](C c)
    {
        return null;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,18014,18793);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: '((string[])c)[x]')
  Array reference: 
    IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.String[] C.op_Explicit(C c)) (OperationKind.Conversion, Type: System.String[]) (Syntax: '(string[])c')
      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.String[] C.op_Explicit(C c))
      Operand: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Indices(1):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,18807,18860);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,18876,19000);

f_22007_18876_18999(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,17532,19011);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,17532,19011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,17532,19011);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_NoConversionInIndexExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,19023,20640);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,19253,19390);

string 
source = @"
class C
{
    public void F(string[] args, C c)
    {
        var a = /*<bind>*/args[c]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,19404,20151);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[c]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[], IsInvalid) (Syntax: 'args')
  Indices(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'c')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,20165,20489);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_20376_20473(f_22007_20376_20453(f_22007_20376_20427(ErrorCode.ERR_NoImplicitConv, "args[c]"), "C", "int"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,20505,20629);

f_22007_20505_20628(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,19023,20640);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,19023,20640);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,19023,20640);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_MissingExplicitCastInIndexExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,20652,22493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,20889,21107);

string 
source = @"
class C
{
    public void F(string[] args, C c)
    {
        var a = /*<bind>*/args[c]/*</bind>*/;
    }

    public static explicit operator int(C c)
    {
        return 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,21121,21943);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[c]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[], IsInvalid) (Syntax: 'args')
  Indices(1):
      IConversionOperation (TryCast: False, Unchecked) (OperatorMethod: System.Int32 C.op_Explicit(C c)) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'c')
        Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: True) (MethodSymbol: System.Int32 C.op_Explicit(C c))
        Operand: 
          IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,21957,22342);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_22225_22326(f_22007_22225_22306(f_22007_22225_22280(ErrorCode.ERR_NoImplicitConvCast, "args[c]"), "C", "int"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,22358,22482);

f_22007_22358_22481(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,20652,22493);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,20652,22493);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,20652,22493);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_NoArrayReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,22505,23690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,22722,22874);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/[0]/*</bind>*/;
    }

    public string[] F2() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,22888,23233);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: '[0]')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
        Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,23247,23539);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_23438_23523(f_22007_23438_23503(f_22007_23438_23484(ErrorCode.ERR_InvalidExprTerm, "["), "["), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,23555,23679);

f_22007_23555_23678(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,22505,23690);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,22505,23690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,22505,23690);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_NoIndices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,23702,24913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,23912,24043);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,24057,24473);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
        Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,24487,24762);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_24682_24746(f_22007_24682_24726(ErrorCode.ERR_ValueExpected, "]"), 6, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,24778,24902);

f_22007_24778_24901(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,23702,24913);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,23702,24913);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,23702,24913);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_BadIndexing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,24925,26143);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,25137,25293);

string 
source = @"
class C
{
    public void F(C c)
    {
        var a = /*<bind>*/c[0]/*</bind>*/;
    }

    public string[] F2() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,25307,25655);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'c[0]')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
      IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,25669,25992);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_25892_25976(f_22007_25892_25956(f_22007_25892_25937(ErrorCode.ERR_BadIndexLHS, "c[0]"), "C"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,26008,26132);

f_22007_26008_26131(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,24925,26143);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,24925,26143);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,24925,26143);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_BadIndexCount()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,26155,27546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,26369,26504);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[0, 0]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,26518,27057);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[0, 0]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[], IsInvalid) (Syntax: 'args')
  Indices(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,27071,27395);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_27287_27379(f_22007_27287_27359(f_22007_27287_27340(ErrorCode.ERR_BadIndexCount, "args[0, 0]"), "1"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,27411,27535);

f_22007_27411_27534(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,26155,27546);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,26155,27546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,26155,27546);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_ExtraElementAccessOperator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,27558,29019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,27785,27919);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[0][]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,27933,28576);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Char, IsInvalid) (Syntax: 'args[0][]')
  Children(2):
      IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[0]')
        Array reference: 
          IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
        Indices(1):
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
        Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,28590,28868);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_28788_28852(f_22007_28788_28832(ErrorCode.ERR_ValueExpected, "]"), 6, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,28884,29008);

f_22007_28884_29007(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,27558,29019);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,27558,29019);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,27558,29019);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_IndexErrorExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,29031,30295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,29252,29382);

string 
source = @"
class C
{
    public void F()
    {
        var a = /*<bind>*/ErrorExpression[0]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,29396,29757);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'ErrorExpression[0]')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'ErrorExpression')
        Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,29771,30144);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_30014_30128(f_22007_30014_30108(f_22007_30014_30075(ErrorCode.ERR_NameNotInContext, "ErrorExpression"), "ErrorExpression"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,30160,30284);

f_22007_30160_30283(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,29031,30295);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,29031,30295);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,29031,30295);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_InvalidIndexerExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,30307,32011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,30532,30678);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[ErrorExpression]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,30692,31470);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[ErrorExpression]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'ErrorExpression')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'ErrorExpression')
            Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,31484,31860);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_31730_31844(f_22007_31730_31824(f_22007_31730_31791(ErrorCode.ERR_NameNotInContext, "ErrorExpression"), "ErrorExpression"), 6, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,31876,32000);

f_22007_31876_31999(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,30307,32011);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,30307,32011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,30307,32011);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_SyntaxErrorInIndexer_MissingValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,32023,33360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,32257,32390);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[0,]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,32404,32918);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[0,]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
        Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,32932,33209);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_33129_33193(f_22007_33129_33173(ErrorCode.ERR_ValueExpected, "]"), 6, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,33225,33349);

f_22007_33225_33348(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,32023,33360);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,32023,33360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,32023,33360);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_SyntaxErrorInIndexer_MissingBracket()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,33372,34796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,33608,33738);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,33752,34082);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[/*</bind>*/')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[], IsInvalid) (Syntax: 'args')
  Indices(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,34096,34645);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_34288_34374(f_22007_34288_34354(f_22007_34288_34330(ErrorCode.ERR_SyntaxError, ";"), "]", ";"), 6, 43),
f_22007_34531_34629(f_22007_34531_34609(f_22007_34531_34590(ErrorCode.ERR_BadIndexCount, "args[/*</bind>*/"), "1"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,34661,34785);

f_22007_34661_34784(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,33372,34796);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,33372,34796);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,33372,34796);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_SyntaxErrorInIndexer_MissingBracketAfterIndex()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,34808,36076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,35054,35185);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[0/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,35199,35616);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[0/*</bind>*/')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,35630,35925);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_35823_35909(f_22007_35823_35889(f_22007_35823_35865(ErrorCode.ERR_SyntaxError, ";"), "]", ";"), 6, 44)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,35941,36065);

f_22007_35941_36064(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,34808,36076);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,34808,36076);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,34808,36076);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_SyntaxErrorInIndexer_DeeplyNestedParameterReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,36088,38914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,36340,36495);

string 
source = @"
class C
{
    public void F(string[] args, int x, int y)
    {
        var a = /*<bind>*/args[y][][][][x]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,36509,38034);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'args[y][][][][x]')
  Children(2):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'x')
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'args[y][][][]')
        Children(2):
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'args[y][][]')
              Children(2):
                  IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                    Children(0)
                  IInvalidOperation (OperationKind.Invalid, Type: System.Char, IsInvalid) (Syntax: 'args[y][]')
                    Children(2):
                        IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[y]')
                          Array reference: 
                            IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
                          Indices(1):
                              IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
                        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                          Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,38048,38763);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_38253_38317(f_22007_38253_38297(ErrorCode.ERR_ValueExpected, "]"), 6, 35),
f_22007_38468_38532(f_22007_38468_38512(ErrorCode.ERR_ValueExpected, "]"), 6, 37),
f_22007_38683_38747(f_22007_38683_38727(ErrorCode.ERR_ValueExpected, "]"), 6, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,38779,38903);

f_22007_38779_38902(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,36088,38914);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,36088,38914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,36088,38914);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_NamedArgumentForArray()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,38926,40229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,39148,39286);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[name: 0]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,39300,39735);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[name: 0]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[], IsInvalid) (Syntax: 'args')
  Indices(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,39749,40078);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_39978_40062(f_22007_39978_40042(ErrorCode.ERR_NamedArgumentForArray, "args[name: 0]"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,40094,40218);

f_22007_40094_40217(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,38926,40229);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,38926,40229);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,38926,40229);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceError_RefAndOutArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,40241,42242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,40460,40626);

string 
source = @"
class C
{
    public void F(string[,] args, ref int x, out int y)
    {
        var a = /*<bind>*/args[ref x, out y]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,40640,41201);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String, IsInvalid) (Syntax: 'args[ref x, out y]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[,]) (Syntax: 'args')
  Indices(2):
      IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
      IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,41215,42091);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_41445_41536(f_22007_41445_41516(f_22007_41445_41490(ErrorCode.ERR_BadArgExtraRef, "x"), "1", "ref"), 6, 36),
f_22007_41696_41784(f_22007_41696_41764(f_22007_41696_41745(ErrorCode.ERR_UseDefViolationOut, "y"), "y"), 6, 43),
f_22007_41990_42075(f_22007_41990_42055(f_22007_41990_42036(ErrorCode.ERR_ParamUnassigned, "F"), "y"), 4, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,42107,42231);

f_22007_42107_42230(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,40241,42242);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,40241,42242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,40241,42242);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(22006, "https://github.com/dotnet/roslyn/issues/22006")]
        public void ArrayElementReferenceWarning_NegativeIndexExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,42254,43663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,42480,42613);

string 
source = @"
class C
{
    public void F(string[] args)
    {
        var a = /*<bind>*/args[-1]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,42627,43167);

string 
expectedOperationTree = @"
IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.String) (Syntax: 'args[-1]')
  Array reference: 
    IParameterReferenceOperation: args (OperationKind.ParameterReference, Type: System.String[]) (Syntax: 'args')
  Indices(1):
      IUnaryOperation (UnaryOperatorKind.Minus) (OperationKind.Unary, Type: System.Int32, Constant: -1) (Syntax: '-1')
        Operand: 
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,43181,43512);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22007_43426_43496(f_22007_43426_43476(ErrorCode.WRN_NegativeArrayIndex, "-1"), 6, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,43528,43652);

f_22007_43528_43651(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,42254,43663);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,42254,43663);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,42254,43663);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayElementReference_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,43675,46431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,43844,44057);

string 
source = @"
class C
{
    void M(int[] a1, int[,] a2, int i1, int i2, int i3, int result1, int result2)
    /*<bind>*/{
        result1 = a1[i1];
        result2 = a2[i2, i3];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,44071,46239);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result1 = a1[i1];')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result1 = a1[i1]')
              Left: 
                IParameterReferenceOperation: result1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result1')
              Right: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a1[i1]')
                  Array reference: 
                    IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a1')
                  Indices(1):
                      IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i1')

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result2 = a2[i2, i3];')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result2 = a2[i2, i3]')
              Left: 
                IParameterReferenceOperation: result2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result2')
              Right: 
                IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a2[i2, i3]')
                  Array reference: 
                    IParameterReferenceOperation: a2 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a2')
                  Indices(2):
                      IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')
                      IParameterReferenceOperation: i3 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i3')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,46253,46306);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,46322,46420);

f_22007_46322_46419(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,43675,46431);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,43675,46431);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,43675,46431);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayElementReference_ControlFlowInArrayReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,46443,50346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,46626,46782);

string 
source = @"
class C
{
    void M(int[] a1, int[] a2, int i, int result)
    /*<bind>*/{
        result = (a1 ?? a2)[i];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,46796,50154);

string 
expectedFlowGraph = @"
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
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
                  Value: 
                    IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32[], IsImplicit) (Syntax: 'a1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32[], IsImplicit) (Syntax: 'a1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a2')
              Value: 
                IParameterReferenceOperation: a2 (OperationKind.ParameterReference, Type: System.Int32[]) (Syntax: 'a2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (a1 ?? a2)[i];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = (a1 ?? a2)[i]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                  Right: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '(a1 ?? a2)[i]')
                      Array reference: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32[], IsImplicit) (Syntax: 'a1 ?? a2')
                      Indices(1):
                          IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,50168,50221);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,50237,50335);

f_22007_50237_50334(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,46443,50346);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,46443,50346);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,46443,50346);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayElementReference_ControlFlowInFirstIndex()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,50358,55324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,50537,50702);

string 
source = @"
class C
{
    void M(int[,] a, int? i1, int i2, byte j, int result)
    /*<bind>*/{
        result = a[i1 ?? i2, j];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,50716,55132);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a[i1 ?? i2, j];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = a[i1 ?? i2, j]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                  Right: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[i1 ?? i2, j]')
                      Array reference: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a')
                      Indices(2):
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'j')
                            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                              (ImplicitNumeric)
                            Operand: 
                              IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Byte) (Syntax: 'j')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,55146,55199);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,55215,55313);

f_22007_55215_55312(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,50358,55324);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,50358,55324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,50358,55324);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayElementReference_ControlFlowInSecondIndex()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,55336,60157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,55516,55680);

string 
source = @"
class C
{
    void M(int[,] a, int? i1, int i2, int j, int result)
    /*<bind>*/{
        result = a[j, i1 ?? i2];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,55694,59965);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [2] [4]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (3)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a')

            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j')
              Value: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [3]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a[j, i1 ?? i2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = a[j, i1 ?? i2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                  Right: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[j, i1 ?? i2]')
                      Array reference: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a')
                      Indices(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j')
                          IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,59979,60032);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,60048,60146);

f_22007_60048_60145(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,55336,60157);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,55336,60157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,55336,60157);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayElementReference_ControlFlowInMultipleIndices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,60169,66698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,60353,60534);

string 
source = @"
class C
{
    void M(int[,] a, int? i1, int i2, int? j1, int j2, int result)
    /*<bind>*/{
        result = a[i1 ?? i2, j1 ?? j2];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,60548,66506);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [1] [3] [5]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a')
              Value: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [4]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j1')
                  Value: 
                    IParameterReferenceOperation: j1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'j1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'j1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'j1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'j1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'j1')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j2')
              Value: 
                IParameterReferenceOperation: j2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j2')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = a[ ...  j1 ?? j2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = a[ ... , j1 ?? j2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                  Right: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: 'a[i1 ?? i2, j1 ?? j2]')
                      Array reference: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a')
                      Indices(2):
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                          IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j1 ?? j2')

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,66520,66573);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,66589,66687);

f_22007_66589_66686(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,60169,66698);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,60169,66698);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,60169,66698);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ArrayElementReference_ControlFlowInArrayReferenceAndIndices()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22007,66710,74714);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,66903,67105);

string 
source = @"
class C
{
    void M(int[,] a1, int[,] a2, int? i1, int i2, int? j1, int j2, int result)
    /*<bind>*/{
        result = (a1 ?? a2)[i1 ?? i2, j1 ?? j2];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,67119,74522);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2] [4] [6]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'result')
              Value: 
                IParameterReferenceOperation: result (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'result')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
                  Value: 
                    IParameterReferenceOperation: a1 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'a1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1')

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'a2')
              Value: 
                IParameterReferenceOperation: a2 (OperationKind.ParameterReference, Type: System.Int32[,]) (Syntax: 'a2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i1')
                      Arguments(0)

            Next (Regular) Block[B8]
                Leaving: {R3}
                Entering: {R4}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i2')
              Value: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i2')

        Next (Regular) Block[B8]
            Entering: {R4}

    .locals {R4}
    {
        CaptureIds: [5]
        Block[B8] - Block
            Predecessors: [B6] [B7]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j1')
                  Value: 
                    IParameterReferenceOperation: j1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'j1')

            Jump if True (Regular) to Block[B10]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'j1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'j1')
                Leaving: {R4}

            Next (Regular) Block[B9]
        Block[B9] - Block
            Predecessors: [B8]
            Statements (1)
                IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'j1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'j1')
                      Arguments(0)

            Next (Regular) Block[B11]
                Leaving: {R4}
    }

    Block[B10] - Block
        Predecessors: [B8]
        Statements (1)
            IFlowCaptureOperation: 6 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j2')
              Value: 
                IParameterReferenceOperation: j2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j2')

        Next (Regular) Block[B11]
    Block[B11] - Block
        Predecessors: [B9] [B10]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'result = (a ...  j1 ?? j2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'result = (a ... , j1 ?? j2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'result')
                  Right: 
                    IArrayElementReferenceOperation (OperationKind.ArrayElementReference, Type: System.Int32) (Syntax: '(a1 ?? a2)[ ... , j1 ?? j2]')
                      Array reference: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32[,], IsImplicit) (Syntax: 'a1 ?? a2')
                      Indices(2):
                          IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                          IFlowCaptureReferenceOperation: 6 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j1 ?? j2')

        Next (Regular) Block[B12]
            Leaving: {R1}
}

Block[B12] - Exit
    Predecessors: [B11]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,74536,74589);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22007,74605,74703);

f_22007_74605_74702(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22007,66710,74714);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22007,66710,74714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22007,66710,74714);
}
		}

int
f_22007_1356_1479(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 1356, 1479);
return 0;
}


int
f_22007_2380_2503(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 2380, 2503);
return 0;
}


int
f_22007_3617_3740(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 3617, 3740);
return 0;
}


int
f_22007_4724_4847(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 4724, 4847);
return 0;
}


int
f_22007_5872_5995(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 5872, 5995);
return 0;
}


int
f_22007_7259_7382(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 7259, 7382);
return 0;
}


int
f_22007_8530_8653(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 8530, 8653);
return 0;
}


int
f_22007_10097_10220(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 10097, 10220);
return 0;
}


int
f_22007_11759_11882(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 11759, 11882);
return 0;
}


int
f_22007_13085_13208(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 13085, 13208);
return 0;
}


int
f_22007_14418_14541(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 14418, 14541);
return 0;
}


int
f_22007_15900_16023(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 15900, 16023);
return 0;
}


int
f_22007_17385_17508(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 17385, 17508);
return 0;
}


int
f_22007_18876_18999(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 18876, 18999);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_20376_20427(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 20376, 20427);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_20376_20453(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 20376, 20453);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_20376_20473(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 20376, 20473);
return return_v;
}


int
f_22007_20505_20628(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 20505, 20628);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_22225_22280(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 22225, 22280);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_22225_22306(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 22225, 22306);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_22225_22326(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 22225, 22326);
return return_v;
}


int
f_22007_22358_22481(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 22358, 22481);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_23438_23484(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 23438, 23484);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_23438_23503(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 23438, 23503);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_23438_23523(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 23438, 23523);
return return_v;
}


int
f_22007_23555_23678(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 23555, 23678);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_24682_24726(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 24682, 24726);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_24682_24746(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 24682, 24746);
return return_v;
}


int
f_22007_24778_24901(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 24778, 24901);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_25892_25937(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 25892, 25937);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_25892_25956(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 25892, 25956);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_25892_25976(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 25892, 25976);
return return_v;
}


int
f_22007_26008_26131(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 26008, 26131);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_27287_27340(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 27287, 27340);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_27287_27359(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 27287, 27359);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_27287_27379(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 27287, 27379);
return return_v;
}


int
f_22007_27411_27534(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 27411, 27534);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_28788_28832(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 28788, 28832);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_28788_28852(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 28788, 28852);
return return_v;
}


int
f_22007_28884_29007(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 28884, 29007);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_30014_30075(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 30014, 30075);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_30014_30108(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 30014, 30108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_30014_30128(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 30014, 30128);
return return_v;
}


int
f_22007_30160_30283(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 30160, 30283);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_31730_31791(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 31730, 31791);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_31730_31824(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 31730, 31824);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_31730_31844(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 31730, 31844);
return return_v;
}


int
f_22007_31876_31999(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 31876, 31999);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_33129_33173(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 33129, 33173);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_33129_33193(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 33129, 33193);
return return_v;
}


int
f_22007_33225_33348(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 33225, 33348);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_34288_34330(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 34288, 34330);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_34288_34354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 34288, 34354);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_34288_34374(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 34288, 34374);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_34531_34590(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 34531, 34590);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_34531_34609(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 34531, 34609);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_34531_34629(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 34531, 34629);
return return_v;
}


int
f_22007_34661_34784(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 34661, 34784);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_35823_35865(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 35823, 35865);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_35823_35889(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 35823, 35889);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_35823_35909(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 35823, 35909);
return return_v;
}


int
f_22007_35941_36064(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 35941, 36064);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_38253_38297(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 38253, 38297);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_38253_38317(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 38253, 38317);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_38468_38512(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 38468, 38512);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_38468_38532(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 38468, 38532);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_38683_38727(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 38683, 38727);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_38683_38747(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 38683, 38747);
return return_v;
}


int
f_22007_38779_38902(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 38779, 38902);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_39978_40042(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 39978, 40042);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_39978_40062(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 39978, 40062);
return return_v;
}


int
f_22007_40094_40217(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 40094, 40217);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41445_41490(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41445, 41490);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41445_41516(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41445, 41516);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41445_41536(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41445, 41536);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41696_41745(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41696, 41745);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41696_41764(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41696, 41764);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41696_41784(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41696, 41784);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41990_42036(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41990, 42036);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41990_42055(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41990, 42055);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_41990_42075(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 41990, 42075);
return return_v;
}


int
f_22007_42107_42230(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 42107, 42230);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_43426_43476(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 43426, 43476);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22007_43426_43496(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 43426, 43496);
return return_v;
}


int
f_22007_43528_43651(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 43528, 43651);
return 0;
}


int
f_22007_46322_46419(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 46322, 46419);
return 0;
}


int
f_22007_50237_50334(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 50237, 50334);
return 0;
}


int
f_22007_55215_55312(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 55215, 55312);
return 0;
}


int
f_22007_60048_60145(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 60048, 60145);
return 0;
}


int
f_22007_66589_66686(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 66589, 66686);
return 0;
}


int
f_22007_74605_74702(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22007, 74605, 74702);
return 0;
}

}
}
