// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.VisualBasic;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NoArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,628,1295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,746,881);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }
    static void M2() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,895,1080);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2()) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2()')
  Instance Receiver: 
    null
  Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,1094,1147);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,1163,1284);

f_22006_1163_1283(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,628,1295);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,628,1295);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,628,1295);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void PositionalArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,1307,3110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,1433,1591);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(1, 2.0)/*</bind>*/;
    }

    static void M2(int x, double y) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,1605,2895);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2(System.Int32 x, System.Double y)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1, 2.0)')
  Instance Receiver: 
    null
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: '2.0')
        ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 2) (Syntax: '2.0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,2909,2962);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,2978,3099);

f_22006_2978_3098(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,1307,3110);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,1307,3110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,1307,3110);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void PositionalArgumentWithDefaultValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,3122,4975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,3264,3423);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(1)/*</bind>*/;
    }

    static void M2(int x, double y = 0.0) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,3437,4760);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2(System.Int32 x, [System.Double y = 0])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1)')
  Instance Receiver: 
    null
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(1)')
        ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 0, IsImplicit) (Syntax: 'M2(1)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,4774,4827);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,4843,4964);

f_22006_4843_4963(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,3122,4975);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,3122,4975);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,3122,4975);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedArgumentListedInParameterOrder()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,4987,6839);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,5130,5300);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(x: 1, y: 9.9)/*</bind>*/;
    }

    static void M2(int x, double y = 0.0) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,5314,6624);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2(System.Int32 x, [System.Double y = 0])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(x: 1, y: 9.9)')
  Instance Receiver: 
    null
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x: 1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'y: 9.9')
        ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 9.9) (Syntax: '9.9')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,6638,6691);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,6707,6828);

f_22006_6707_6827(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,4987,6839);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,4987,6839);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,4987,6839);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedArgumentListedOutOfParameterOrder()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,6851,8706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,6997,7167);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(y: 9.9, x: 1)/*</bind>*/;
    }

    static void M2(int x, double y = 0.0) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,7181,8491);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2(System.Int32 x, [System.Double y = 0])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(y: 9.9, x: 1)')
  Instance Receiver: 
    null
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'y: 9.9')
        ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 9.9) (Syntax: '9.9')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x: 1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,8505,8558);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,8574,8695);

f_22006_8574_8694(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,6851,8706);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,6851,8706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,6851,8706);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedArgumentInParameterOrderWithDefaultValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,8718,11191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,8871,9049);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(y: 0, z: 2)/*</bind>*/;
    }

    static void M2(int x = 1, int y = 2, int z = 3) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,9063,10976);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2([System.Int32 x = 1], [System.Int32 y = 2], [System.Int32 z = 3])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(y: 0, z: 2)')
  Instance Receiver: 
    null
  Arguments(3):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'y: 0')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: z) (OperationKind.Argument, Type: null) (Syntax: 'z: 2')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(y: 0, z: 2)')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'M2(y: 0, z: 2)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,10990,11043);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,11059,11180);

f_22006_11059_11179(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,8718,11191);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,8718,11191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,8718,11191);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedArgumentOutOfParameterOrderWithDefaultValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,11203,13679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,11359,11537);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(z: 2, x: 9)/*</bind>*/;
    }

    static void M2(int x = 1, int y = 2, int z = 3) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,11551,13464);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2([System.Int32 x = 1], [System.Int32 y = 2], [System.Int32 z = 3])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(z: 2, x: 9)')
  Instance Receiver: 
    null
  Arguments(3):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: z) (OperationKind.Argument, Type: null) (Syntax: 'z: 2')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x: 9')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(z: 2, x: 9)')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'M2(z: 2, x: 9)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,13478,13531);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,13547,13668);

f_22006_13547_13667(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,11203,13679);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,11203,13679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,11203,13679);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedAndPositionalArgumentsWithDefaultValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,13691,16338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,13842,14018);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(9, z: 10);/*</bind>*/
    }

    static void M2(int x = 1, int y = 2, int z = 3) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,14032,16124);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(9, z: 10);')
  Expression: 
    IInvocationOperation (void P.M2([System.Int32 x = 1], [System.Int32 y = 2], [System.Int32 z = 3])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(9, z: 10)')
      Instance Receiver: 
        null
      Arguments(3):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '9')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 9) (Syntax: '9')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: z) (OperationKind.Argument, Type: null) (Syntax: 'z: 10')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(9, z: 10)')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'M2(9, z: 10)')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,16138,16191);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,16207,16327);

f_22006_16207_16326(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,13691,16338);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,13691,16338);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,13691,16338);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void PositionalRefAndOutArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,16350,18362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,16486,16685);

string 
source = @"
class P
{
    void M1()
    {
        int a = 1;
        int b;
        /*<bind>*/M2(ref a, out b)/*</bind>*/;
    }

    void M2(ref int x, out int y) { y = 10; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,16699,18147);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2(ref System.Int32 x, out System.Int32 y)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(ref a, out b)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'ref a')
        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'out b')
        ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,18161,18214);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,18230,18351);

f_22006_18230_18350(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,16350,18362);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,16350,18362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,16350,18362);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedRefAndOutArgumentsInParameterOrder()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,18374,20415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,18521,18726);

string 
source = @"
class P
{
    void M1()
    {
        int a = 1;
        int b;
        /*<bind>*/M2(x: ref a, y: out b)/*</bind>*/;
    }

    void M2(ref int x, out int y) { y = 10; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,18740,20200);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2(ref System.Int32 x, out System.Int32 y)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(x: ref a, y: out b)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x: ref a')
        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'y: out b')
        ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,20214,20267);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,20283,20404);

f_22006_20283_20403(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,18374,20415);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,18374,20415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,18374,20415);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedRefAndOutArgumentsOutOfParameterOrder()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,20427,22471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,20577,20782);

string 
source = @"
class P
{
    void M1()
    {
        int a = 1;
        int b;
        /*<bind>*/M2(y: out b, x: ref a)/*</bind>*/;
    }

    void M2(ref int x, out int y) { y = 10; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,20796,22256);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2(ref System.Int32 x, out System.Int32 y)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(y: out b, x: ref a)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'y: out b')
        ILocalReferenceOperation: b (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'b')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x: ref a')
        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,22270,22323);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,22339,22460);

f_22006_22339_22459(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,20427,22471);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,20427,22471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,20427,22471);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueOfNewStruct()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,22483,23893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,22614,22769);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }

    void M2(S sobj = new S()) { }
}

struct S { }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,22783,23678);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([S sobj = default(S)])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2()')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sobj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: S, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,23692,23745);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,23761,23882);

f_22006_23761_23881(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,22483,23893);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,22483,23893);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,22483,23893);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueOfDefaultStruct()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,23905,25322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,24040,24198);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }

    void M2(S sobj = default(S)) { }
}

struct S { }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,24212,25107);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([S sobj = default(S)])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2()')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sobj) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: S, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,25121,25174);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,25190,25311);

f_22006_25190_25310(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,23905,25322);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,23905,25322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,23905,25322);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueOfConstant()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,25334,26771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,25464,25629);

string 
source = @"
class P
{
    const double Pi = 3.14;
    void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }

    void M2(double s = Pi) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,25643,26556);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([System.Double s = 3.14])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2()')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 3.14, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,26570,26623);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,26639,26760);

f_22006_26639_26759(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,25334,26771);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,25334,26771);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,25334,26771);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void PositionalArgumentForExtensionMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,26783,29271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,26927,27139);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/this.E1(1, 2)/*</bind>*/;
    }
}

static class Extensions
{
    public static void E1(this P p, int x = 0, int y = 0)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,27153,29056);

string 
expectedOperationTree = @"
IInvocationOperation (void Extensions.E1(this P p, [System.Int32 x = 0], [System.Int32 y = 0])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'this.E1(1, 2)')
  Instance Receiver: 
    null
  Arguments(3):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this')
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: '2')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,29070,29123);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,29139,29260);

f_22006_29139_29259(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,26783,29271);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,26783,29271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,26783,29271);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedArgumentOutOfParameterOrderForExtensionMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,29283,31994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,29441,29659);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/this.E1(y: 1, x: 2);/*</bind>*/
    }
}

static class Extensions
{
    public static void E1(this P p, int x = 0, int y = 0)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,29673,31780);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'this.E1(y: 1, x: 2);')
  Expression: 
    IInvocationOperation (void Extensions.E1(this P p, [System.Int32 x = 0], [System.Int32 y = 0])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'this.E1(y: 1, x: 2)')
      Instance Receiver: 
        null
      Arguments(3):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this')
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'y: 1')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x: 2')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,31794,31847);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,31863,31983);

f_22006_31863_31982(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,29283,31994);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,29283,31994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,29283,31994);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedArgumentWithDefaultValueForExtensionMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,32006,34560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,32161,32373);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/this.E1(y: 1)/*</bind>*/;
    }
}

static class Extensions
{
    public static void E1(this P p, int x = 0, int y = 0)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,32387,34345);

string 
expectedOperationTree = @"
IInvocationOperation (void Extensions.E1(this P p, [System.Int32 x = 0], [System.Int32 y = 0])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'this.E1(y: 1)')
  Instance Receiver: 
    null
  Arguments(3):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: p) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this')
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: y) (OperationKind.Argument, Type: null) (Syntax: 'y: 1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this.E1(y: 1)')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'this.E1(y: 1)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,34359,34412);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,34428,34549);

f_22006_34428_34548(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,32006,34560);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,32006,34560);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,32006,34560);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ParamsArrayArgumentInNormalForm()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,34572,36568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,34711,34898);

string 
source = @"
class P
{
    void M1()
    {
        var a = new[] { 0.0 };
        /*<bind>*/M2(1, a)/*</bind>*/;
    }

    void M2(int x, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,34912,36353);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2(System.Int32 x, params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1, a)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: array) (OperationKind.Argument, Type: null) (Syntax: 'a')
        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Double[]) (Syntax: 'a')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,36367,36420);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,36436,36557);

f_22006_36436_36556(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,34572,36568);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,34572,36568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,34572,36568);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ParamsArrayArgumentInExpandedForm()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,36580,39193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,36721,36883);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2(1, 0.1, 0.2)/*</bind>*/;
    }

    void M2(int x, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,36897,38978);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2(System.Int32 x, params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1, 0.1, 0.2)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(1, 0.1, 0.2)')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Double[], IsImplicit) (Syntax: 'M2(1, 0.1, 0.2)')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'M2(1, 0.1, 0.2)')
          Initializer: 
            IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'M2(1, 0.1, 0.2)')
              Element Values(2):
                  ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 0.1) (Syntax: '0.1')
                  ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 0.2) (Syntax: '0.2')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,38992,39045);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,39061,39182);

f_22006_39061_39181(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,36580,39193);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,36580,39193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,36580,39193);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ParamsArrayArgumentInExpandedFormWithNoArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,39205,41545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,39360,39512);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2(1)/*</bind>*/;
    }

    void M2(int x, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,39526,41330);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2(System.Int32 x, params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(1)')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Double[], IsImplicit) (Syntax: 'M2(1)')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'M2(1)')
          Initializer: 
            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'M2(1)')
              Element Values(0)
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,41344,41397);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,41413,41534);

f_22006_41413_41533(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,39205,41545);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,39205,41545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,39205,41545);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueAndParamsArrayArgumentInExpandedFormWithNoArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,41557,43982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,41727,41914);

string 
source = @"
class P
{
    void M1()
    {
        var a = new[] { 0.0 };
        /*<bind>*/M2()/*</bind>*/;
    }

    void M2(int x = 0, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,41928,43767);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([System.Int32 x = 0], params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2()')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Double[], IsImplicit) (Syntax: 'M2()')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'M2()')
          Initializer: 
            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'M2()')
              Element Values(0)
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,43781,43834);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,43850,43971);

f_22006_43850_43970(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,41557,43982);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,41557,43982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,41557,43982);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueAndNamedParamsArrayArgumentInNormalForm()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,43994,46085);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,44153,44348);

string 
source = @"
class P
{
    void M1()
    {
        var a = new[] { 0.0 };
        /*<bind>*/M2(array: a)/*</bind>*/;
    }

    void M2(int x = 0, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,44362,45870);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([System.Int32 x = 0], params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(array: a)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: array) (OperationKind.Argument, Type: null) (Syntax: 'array: a')
        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Double[]) (Syntax: 'a')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(array: a)')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'M2(array: a)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,45884,45937);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,45953,46074);

f_22006_45953_46073(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,43994,46085);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,43994,46085);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,43994,46085);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueAndNamedParamsArrayArgumentInExpandedForm()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,46097,49008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,46258,46421);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2(array: 1)/*</bind>*/;
    }

    void M2(int x = 0, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,46435,48793);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([System.Int32 x = 0], params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(array: 1)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(array: 1)')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Double[], IsImplicit) (Syntax: 'M2(array: 1)')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'M2(array: 1)')
          Initializer: 
            IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'M2(array: 1)')
              Element Values(1):
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Double, Constant: 1, IsImplicit) (Syntax: '1')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(array: 1)')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'M2(array: 1)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,48807,48860);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,48876,48997);

f_22006_48876_48996(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,46097,49008);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,46097,49008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,46097,49008);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void PositionalArgumentAndNamedParamsArrayArgumentInNormalForm()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,49020,51073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,49185,49383);

string 
source = @"
class P
{
    void M1()
    {
        var a = new[] { 0.0 };
        /*<bind>*/M2(1, array: a)/*</bind>*/;
    }

    void M2(int x = 0, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,49397,50858);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([System.Int32 x = 0], params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1, array: a)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: array) (OperationKind.Argument, Type: null) (Syntax: 'array: a')
        ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Double[]) (Syntax: 'a')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,50872,50925);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,50941,51062);

f_22006_50941_51061(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,49020,51073);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,49020,51073);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,49020,51073);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void PositionalArgumentAndNamedParamsArrayArgumentInExpandedForm()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,51085,53970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,51252,51418);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2(1, array: 1)/*</bind>*/;
    }

    void M2(int x = 0, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,51432,53755);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([System.Int32 x = 0], params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1, array: 1)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(1, array: 1)')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Double[], IsImplicit) (Syntax: 'M2(1, array: 1)')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'M2(1, array: 1)')
          Initializer: 
            IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'M2(1, array: 1)')
              Element Values(1):
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Double, Constant: 1, IsImplicit) (Syntax: '1')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,53769,53822);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,53838,53959);

f_22006_53838_53958(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,51085,53970);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,51085,53970);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,51085,53970);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedArgumentAndNamedParamsArrayArgumentInNormalFormOutOfParameterOrder()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,53982,56232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,54161,54362);

string 
source = @"
class P
{
    void M1()
    {
        var a = new[] { 0.0 };
        /*<bind>*/M2(array: a, x: 1);/*</bind>*/
    }

    void M2(int x = 0, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,54376,56018);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(array: a, x: 1);')
  Expression: 
    IInvocationOperation ( void P.M2([System.Int32 x = 0], params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(array: a, x: 1)')
      Instance Receiver: 
        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
      Arguments(2):
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: array) (OperationKind.Argument, Type: null) (Syntax: 'array: a')
            ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Double[]) (Syntax: 'a')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x: 1')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,56032,56085);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,56101,56221);

f_22006_56101_56220(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,53982,56232);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,53982,56232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,53982,56232);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NamedArgumentAndNamedParamsArrayArgumentInExpandedFormOutOfParameterOrder()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,56244,59173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,56425,56595);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2(array: 1, x: 10)/*</bind>*/;
    }

    void M2(int x = 0, params double[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,56609,58958);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([System.Int32 x = 0], params System.Double[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(array: 1, x: 10)')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(2):
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(array: 1, x: 10)')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Double[], IsImplicit) (Syntax: 'M2(array: 1, x: 10)')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'M2(array: 1, x: 10)')
          Initializer: 
            IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'M2(array: 1, x: 10)')
              Element Values(1):
                  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Double, Constant: 1, IsImplicit) (Syntax: '1')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'x: 10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,58972,59025);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,59041,59162);

f_22006_59041_59161(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,56244,59173);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,56244,59173);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,56244,59173);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void CallerInfoAttributesInvokedInMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,59185,62096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,59328,59661);

string 
source = @"
using System.Runtime.CompilerServices;

class P
{
    void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }

    void M2(
        [CallerMemberName] string memberName = null,
        [CallerFilePath] string sourceFilePath = null,
        [CallerLineNumber] int sourceLineNumber = 0)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,59675,61853);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M2([System.String memberName = null], [System.String sourceFilePath = null], [System.Int32 sourceLineNumber = 0])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2()')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(3):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: memberName) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""M1"", IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sourceFilePath) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""file.cs"", IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sourceLineNumber) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 8, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,61867,61920);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,61936,62085);

f_22006_61936_62084(source, expectedOperationTree, TargetFramework.Mscorlib46, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,59185,62096);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,59185,62096);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,59185,62096);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void CallerInfoAttributesInvokedInProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,62108,65040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,62253,62592);

string 
source = @"
using System.Runtime.CompilerServices;

class P
{
    bool M1 => /*<bind>*/M2()/*</bind>*/;

    bool M2(
        [CallerMemberName] string memberName = null,
        [CallerFilePath] string sourceFilePath = null,
        [CallerLineNumber] int sourceLineNumber = 0)
    { 
        return true;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,62606,64797);

string 
expectedOperationTree = @"
IInvocationOperation ( System.Boolean P.M2([System.String memberName = null], [System.String sourceFilePath = null], [System.Int32 sourceLineNumber = 0])) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'M2()')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'M2')
  Arguments(3):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: memberName) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""M1"", IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sourceFilePath) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""file.cs"", IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sourceLineNumber) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,64811,64864);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,64880,65029);

f_22006_64880_65028(source, expectedOperationTree, TargetFramework.Mscorlib46, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,62108,65040);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,62108,65040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,62108,65040);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void CallerInfoAttributesInvokedInFieldInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,65052,67869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,65205,65552);

string 
source = @"
using System.Runtime.CompilerServices;

class P
{
    bool field = /*<bind>*/M2()/*</bind>*/;

    static bool M2(
        [CallerMemberName] string memberName = null,
        [CallerFilePath] string sourceFilePath = null,
        [CallerLineNumber] int sourceLineNumber = 0)
    {
        return true;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,65566,67626);

string 
expectedOperationTree = @"
IInvocationOperation (System.Boolean P.M2([System.String memberName = null], [System.String sourceFilePath = null], [System.Int32 sourceLineNumber = 0])) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'M2()')
  Instance Receiver: 
    null
  Arguments(3):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: memberName) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""field"", IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sourceFilePath) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""file.cs"", IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sourceLineNumber) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,67640,67693);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,67709,67858);

f_22006_67709_67857(source, expectedOperationTree, TargetFramework.Mscorlib46, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,65052,67869);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,65052,67869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,65052,67869);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void CallerInfoAttributesInvokedInEventMethods()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,67881,70854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,68030,68534);

string 
source = @"
using System;
using System.Runtime.CompilerServices;

class P
{
    public event EventHandler MyEvent
    {
        add
        {
            /*<bind>*/M2()/*</bind>*/;
        }

        remove
        {
            M2();
        }
    }

    static bool M2(
        [CallerMemberName] string memberName = null,
        [CallerFilePath] string sourceFilePath = null,
        [CallerLineNumber] int sourceLineNumber = 0)
    {
        return true;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,68548,70611);

string 
expectedOperationTree = @"
IInvocationOperation (System.Boolean P.M2([System.String memberName = null], [System.String sourceFilePath = null], [System.Int32 sourceLineNumber = 0])) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'M2()')
  Instance Receiver: 
    null
  Arguments(3):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: memberName) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""MyEvent"", IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sourceFilePath) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""file.cs"", IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: sourceLineNumber) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 11, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,70625,70678);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,70694,70843);

f_22006_70694_70842(source, expectedOperationTree, TargetFramework.Mscorlib46, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,67881,70854);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,67881,70854);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,67881,70854);
}
		}

[Fact]
        public void DefaultArgument_CallerInfo_BadParameterType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,70866,74137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,70964,71126);

var 
source0 = @"
using System.Runtime.CompilerServices;

public class C0
{
    public static void M0([CallerLineNumber] string s = ""hello"") { } // 1
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,71142,71272);

var 
source1 = @"
public class C1
{
    public static void M1()
    {
        /*<bind>*/C0.M0()/*</bind>*/; // 2
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,71286,72436);

var 
expectedOperationTree = @"
IInvocationOperation (void C0.M0([System.String s = ""hello""])) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'C0.M0()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'C0.M0()')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsInvalid, IsImplicit) (Syntax: 'C0.M0()')
          Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 6, IsInvalid, IsImplicit) (Syntax: 'C0.M0()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,72450,73199);

var 
expectedDiagnostics0And1 = new[]
            {
f_22006_72774_72907(f_22006_72774_72887(f_22006_72774_72856(ErrorCode.ERR_NoConversionForCallerLineNumberParam, "CallerLineNumber"), "int", "string"), 6, 28),
f_22006_73080_73182(f_22006_73080_73162(f_22006_73080_73131(ErrorCode.ERR_NoImplicitConv, "C0.M0()"), "int", "string"), 6, 19),
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,73215,73380);

f_22006_73215_73379(f_22006_73284_73329(new[] { source1, source0 }), expectedOperationTree, expectedDiagnostics0And1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,73396,73733);

var 
expectedDiagnostics1 = new[]
            {
f_22006_73615_73717(f_22006_73615_73697(f_22006_73615_73666(ErrorCode.ERR_NoImplicitConv, "C0.M0()"), "int", "string"), 6, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,73747,73807);

var 
lib0 = f_22006_73758_73806(f_22006_73758_73784(source0))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,73821,74001);

f_22006_73821_74000(f_22006_73890_73954(new[] { source1 }, references: new[] { lib0 }), expectedOperationTree, expectedDiagnostics1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,74017,74126);

f_22006_74017_74125(f_22006_74017_74081(new[] { source1 }, references: new[] { lib0 }), expectedDiagnostics1);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,70866,74137);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,70866,74137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,70866,74137);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ExtraArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,74149,75236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,74270,74411);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2(1, 2)/*</bind>*/;
    }

    void M2(int x = 0)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,74425,74764);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'M2(1, 2)')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,74778,75088);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_74984_75072(f_22006_74984_75052(f_22006_74984_75027(ErrorCode.ERR_BadArgCount, "M2"), "M2", "2"), 6, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,75104,75225);

f_22006_75104_75224(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,74149,75236);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,74149,75236);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,74149,75236);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestOmittedArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,75248,76352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,75375,75521);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2(1,)/*</bind>*/;
    }

    void M2(int y, int x = 0)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,75535,75882);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'M2(1,)')
  Children(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
        Children(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,75896,76204);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_76103_76188(f_22006_76103_76168(f_22006_76103_76149(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 6, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,76220,76341);

f_22006_76220_76340(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,75248,76352);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,75248,76352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,75248,76352);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void WrongArgumentType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,76364,77408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,76489,76627);

string 
source = @"
class P
{
    void M1()
    {
        /*<bind>*/M2(1)/*</bind>*/;
    }

    void M2(string x )
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,76641,76892);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'M2(1)')
  Children(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,76906,77260);

var 
expectedDiagnostics = new DiagnosticDescription[]
            {
f_22006_77147_77244(f_22006_77147_77224(f_22006_77147_77188(ErrorCode.ERR_BadArgType, "1"), "1", "int", "string"), 6, 22)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,77276,77397);

f_22006_77276_77396(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,76364,77408);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,76364,77408);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,76364,77408);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VarArgsCall()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,77420,82959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,77539,77724);

string 
source = @"
using System;

public class P
{
    void M()
    {
        /*<bind>*/Console.Write(""{0} {1} {2} {3} {4}"", 1, 2, 3, 4, __arglist(5))/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,77738,82716);

string 
expectedOperationTree = @"
IInvocationOperation (void System.Console.Write(System.String format, System.Object arg0, System.Object arg1, System.Object arg2, System.Object arg3, __arglist)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'Console.Wri ... arglist(5))')
  Instance Receiver: 
    null
  Arguments(6):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: format) (OperationKind.Argument, Type: null) (Syntax: '""{0} {1} {2} {3} {4}""')
        ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""{0} {1} {2} {3} {4}"") (Syntax: '""{0} {1} {2} {3} {4}""')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg0) (OperationKind.Argument, Type: null) (Syntax: '1')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '1')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg1) (OperationKind.Argument, Type: null) (Syntax: '2')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '2')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg2) (OperationKind.Argument, Type: null) (Syntax: '3')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '3')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: arg3) (OperationKind.Argument, Type: null) (Syntax: '4')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Object, IsImplicit) (Syntax: '4')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: null) (OperationKind.Argument, Type: null) (Syntax: '__arglist(5)')
        IOperation:  (OperationKind.None, Type: null) (Syntax: '__arglist(5)')
          Children(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,82730,82783);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,82799,82948);

f_22006_82799_82947(source, expectedOperationTree, TargetFramework.Mscorlib45, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,77420,82959);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,77420,82959);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,77420,82959);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void InvalidConversionForDefaultArgument_InSource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,83164,86250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,83316,83415);

var 
source0 = @"
public class C0
{
    public static void M0(int x = ""string"") { } // 1
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,83429,83554);

var 
source1 = @"
public class C1
{
    public static void M1()
    {
        /*<bind>*/C0.M0()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,84250,85063);

var 
expectedOperationTree0And1 = @"
IInvocationOperation (void C0.M0([System.Int32 x = default(System.Int32)])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'C0.M0()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'C0.M0()')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'C0.M0()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,85077,85523);

var 
expectedDiagnostics0 = new DiagnosticDescription[]
            {
f_22006_85398_85507(f_22006_85398_85487(f_22006_85398_85456(ErrorCode.ERR_NoConversionForDefaultParam, "x"), "string", "int"), 4, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,85539,85596);

var 
comp = f_22006_85550_85595(new[] { source1, source0 })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,85610,85735);

f_22006_85610_85734(comp, expectedOperationTree0And1, expectedDiagnostics0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,85749,85798);

f_22006_85749_85797(            comp, expectedDiagnostics0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,85814,85853);

var 
comp0 = f_22006_85826_85852(source0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,85867,85917);

f_22006_85867_85916(            comp0, expectedDiagnostics0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,85933,86023);

var 
comp1 = f_22006_85945_86022(source1, references: new[] { f_22006_85992_86019(comp0)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,86037,86169);

f_22006_86037_86168(comp1, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,86183,86239);

f_22006_86183_86238(            comp1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,83164,86250);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,83164,86250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,83164,86250);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ValidConversionForDefaultArgument_DateTime()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,86262,88294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,86412,86645);

var 
source0 = @"
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class C0
{
    public static void M0([Optional, DateTimeConstant(634953547672667479L)] DateTime x) { } 
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,86659,86784);

var 
source1 = @"
public class C1
{
    public static void M1()
    {
        /*<bind>*/C0.M0()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,86798,87601);

var 
expectedOperationTree0And1 = @"
IInvocationOperation (void C0.M0([System.DateTime x])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'C0.M0()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'C0.M0()')
        ILiteralOperation (OperationKind.Literal, Type: System.DateTime, Constant: 02/01/2013 22:32:47, IsImplicit) (Syntax: 'C0.M0()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,87617,87674);

var 
comp = f_22006_87628_87673(new[] { source1, source0 })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,87688,87819);

f_22006_87688_87818(comp, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,87833,87862);

f_22006_87833_87861(            comp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,87878,87917);

var 
comp0 = f_22006_87890_87916(source0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,87931,87961);

f_22006_87931_87960(            comp0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,87977,88067);

var 
comp1 = f_22006_87989_88066(source1, references: new[] { f_22006_88036_88063(comp0)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,88081,88213);

f_22006_88081_88212(comp1, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,88227,88283);

f_22006_88227_88282(            comp1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,86262,88294);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,86262,88294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,86262,88294);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void InvalidConversionForDefaultArgument_DateTime()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,88306,90442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,88458,88674);

var 
source0 = @"
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class C0
{
    public static void M0([Optional, DateTimeConstant(634953547672667479L)] string x) { } 
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,88688,88813);

var 
source1 = @"
public class C1
{
    public static void M1()
    {
        /*<bind>*/C0.M0()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,88955,89749);

var 
expectedOperationTree0And1 = @"
IInvocationOperation (void C0.M0([System.String x])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'C0.M0()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'C0.M0()')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.String, Constant: null, IsImplicit) (Syntax: 'C0.M0()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,89765,89822);

var 
comp = f_22006_89776_89821(new[] { source1, source0 })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,89836,89967);

f_22006_89836_89966(comp, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,89981,90010);

f_22006_89981_90009(            comp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,90026,90065);

var 
comp0 = f_22006_90038_90064(source0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,90079,90109);

f_22006_90079_90108(            comp0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,90125,90215);

var 
comp1 = f_22006_90137_90214(source1, references: new[] { f_22006_90184_90211(comp0)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,90229,90361);

f_22006_90229_90360(comp1, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,90375,90431);

f_22006_90375_90430(            comp1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,88306,90442);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,88306,90442);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,88306,90442);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ValidConversionForDefaultArgument_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,90454,92449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,90603,90814);

var 
source0 = @"
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class C0
{
    public static void M0([Optional, DecimalConstant(0, 0, 0, 0, 50)] decimal x) { } 
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,90828,90953);

var 
source1 = @"
public class C1
{
    public static void M1()
    {
        /*<bind>*/C0.M0()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,90967,91756);

var 
expectedOperationTree0And1 = @"
IInvocationOperation (void C0.M0([System.Decimal x = 50])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'C0.M0()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'C0.M0()')
        ILiteralOperation (OperationKind.Literal, Type: System.Decimal, Constant: 50, IsImplicit) (Syntax: 'C0.M0()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,91772,91829);

var 
comp = f_22006_91783_91828(new[] { source1, source0 })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,91843,91974);

f_22006_91843_91973(comp, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,91988,92017);

f_22006_91988_92016(            comp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,92033,92072);

var 
comp0 = f_22006_92045_92071(source0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,92086,92116);

f_22006_92086_92115(            comp0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,92132,92222);

var 
comp1 = f_22006_92144_92221(source1, references: new[] { f_22006_92191_92218(comp0)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,92236,92368);

f_22006_92236_92367(comp1, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,92382,92438);

f_22006_92382_92437(            comp1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,90454,92449);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,90454,92449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,90454,92449);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void InvalidConversionForDefaultArgument_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,92461,94594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,92612,92822);

var 
source0 = @"
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class C0
{
    public static void M0([Optional, DecimalConstant(0, 0, 0, 0, 50)] string x) { } 
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,92836,92961);

var 
source1 = @"
public class C1
{
    public static void M1()
    {
        /*<bind>*/C0.M0()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,93102,93901);

var 
expectedOperationTree0And1 = @"
IInvocationOperation (void C0.M0([System.String x = 50])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'C0.M0()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'C0.M0()')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.String, Constant: null, IsImplicit) (Syntax: 'C0.M0()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,93917,93974);

var 
comp = f_22006_93928_93973(new[] { source1, source0 })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,93988,94119);

f_22006_93988_94118(comp, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,94133,94162);

f_22006_94133_94161(            comp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,94178,94217);

var 
comp0 = f_22006_94190_94216(source0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,94231,94261);

f_22006_94231_94260(            comp0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,94277,94367);

var 
comp1 = f_22006_94289_94366(source1, references: new[] { f_22006_94336_94363(comp0)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,94381,94513);

f_22006_94381_94512(comp1, expectedOperationTree0And1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,94527,94583);

f_22006_94527_94582(            comp1, DiagnosticDescription.None);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,92461,94594);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,92461,94594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,92461,94594);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AssigningToIndexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,94606,96197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,94732,94987);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int index]
    {
        get { return _number; }
        set { _number = value; }
    }

    void M1()
    {
        /*<bind>*/this[10]/*</bind>*/ = 9;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,95001,95908);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[System.Int32 index] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this[10]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: index) (OperationKind.Argument, Type: null) (Syntax: '10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,95922,95975);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,95991,96186);

f_22006_95991_96185(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,94606,96197);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,94606,96197);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,94606,96197);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ReadingFromIndexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,96209,97804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,96335,96594);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int index]
    {
        get { return _number; }
        set { _number = value; }
    }

    void M1()
    {
        var x = /*<bind>*/this[10]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,96608,97515);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[System.Int32 index] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this[10]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: index) (OperationKind.Argument, Type: null) (Syntax: '10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,97529,97582);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,97598,97793);

f_22006_97598_97792(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,96209,97804);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,96209,97804);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,96209,97804);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultArgumentForIndexerGetter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,97816,100040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,97955,98227);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int i = 1, int j = 2]
    {
        get { return _number; }
        set { _number = i + j; }
    }

    void M1()
    {
        var x = /*<bind>*/this[j:10]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,98241,99749);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[[System.Int32 i = 1], [System.Int32 j = 2]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this[j:10]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null) (Syntax: 'j:10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: i) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this[j:10]')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'this[j:10]')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,99765,99818);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,99834,100029);

f_22006_99834_100028(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,97816,100040);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,97816,100040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,97816,100040);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void ReadingFromWriteOnlyIndexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,100052,102022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,100187,100413);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int index]
    {
        set { _number = value; }
    }

    void M1()
    {
        var x = /*<bind>*/this[10]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,100427,101373);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[System.Int32 index] { set; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'this[10]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsInvalid) (Syntax: 'this')
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: index) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,101387,101800);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_101680_101784(f_22006_101680_101763(f_22006_101680_101734(ErrorCode.ERR_PropertyLacksGet, "this[10]"), "P.this[int]"), 12, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,101816,102011);

f_22006_101816_102010(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,100052,102022);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,100052,102022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,100052,102022);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AssigningToReadOnlyIndexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,102034,103968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,102168,102389);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int index]
    {
        get { return _number; }
    }

    void M1()
    {
        /*<bind>*/this[10]/*</bind>*/ = 9;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,102403,103349);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[System.Int32 index] { get; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid) (Syntax: 'this[10]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsInvalid) (Syntax: 'this')
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: index) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,103365,103746);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_103626_103730(f_22006_103626_103709(f_22006_103626_103680(ErrorCode.ERR_AssgReadonlyProp, "this[10]"), "P.this[int]"), 12, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,103762,103957);

f_22006_103762_103956(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,102034,103968);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,102034,103968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,102034,103968);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void OverridingIndexerWithDefaultArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,103980,106428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,104124,104551);

string 
source = @"
class Base
{
    public virtual int this[int x = 0, int y = 1]
    {
        set { }
        get { System.Console.Write(y); return 0; }
    }
}

class Derived : Base
{
    public override int this[int x = 8, int y = 9]
    {
        set { }
    }
}

internal class P
{
    static void Main()
    {
        var d = new Derived();
        var x = /*<bind>*/d[0]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,104565,106011);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 Derived.this[[System.Int32 x = 8], [System.Int32 y = 9]] { set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'd[0]')
  Instance Receiver: 
    ILocalReferenceOperation: d (OperationKind.LocalReference, Type: Derived) (Syntax: 'd')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'd[0]')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'd[0]')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,106025,106078);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,106094,106123);

string 
expectedOutput = @"1"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,106139,106334);

f_22006_106139_106333(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,106350,106417);

f_22006_106350_106416(this, new[] { source }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,103980,106428);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,103980,106428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,103980,106428);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void OmittedParamArrayArgumentInIndexerAccess()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,106440,108941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,106588,106807);

string 
source = @"
class P
{
    public int this[int x, params int[] y]
    {
        set { }
        get { return 0; }
    }

    public void M()
    {
        /*<bind>*/this[0]/*</bind>*/ = 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,106821,108652);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[System.Int32 x, params System.Int32[] y] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this[0]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: y) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this[0]')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'this[0]')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsImplicit) (Syntax: 'this[0]')
          Initializer: 
            IArrayInitializerOperation (0 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'this[0]')
              Element Values(0)
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,108666,108719);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,108735,108930);

f_22006_108735_108929(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,106440,108941);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,106440,108941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,106440,108941);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AssigningToReturnsByRefIndexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,108953,110472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,109091,109275);

string 
source = @"
class P
{
    ref int this[int x]
    {
        get => throw null;
    }

    public void M()
    {
        /*<bind>*/this[0]/*</bind>*/ = 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,109289,110183);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: ref System.Int32 P.this[System.Int32 x] { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this[0]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(1):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,110197,110250);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,110266,110461);

f_22006_110266_110460(source, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,108953,110472);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,108953,110472);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,108953,110472);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [ClrOnlyFact(ClrOnlyReason.Ilasm)]
        public void AssigningToIndexer_UsingDefaultArgumentFromSetter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,110484,115520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,110669,113418);

var 
il = @"
.class public auto ansi beforefieldinit P
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) 
           = {string('Item')}

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method P::.ctor

  .method public hidebysig specialname instance int32 
          get_Item([opt] int32 i,
                   [opt] int32 j) cil managed
  {
    .param [1] = int32(0x00000001)
    .param [2] = int32(0x00000002)
    // Code size       35 (0x23)
    .maxstack  3
    .locals init ([0] int32 V_0)
    IL_0000:  nop
    IL_0001:  ldstr      ""{0} {1}""
    IL_0006:  ldarg.1
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  ldarg.2
    IL_000d:  box        [mscorlib]System.Int32
    IL_0012:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_0017:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001c:  nop
    IL_001d:  ldc.i4.0
    IL_001e:  stloc.0
    IL_001f:  br.s       IL_0021
    IL_0021:  ldloc.0
    IL_0022:  ret
  } // end of method P::get_Item

  .method public hidebysig specialname instance void
          set_Item([opt] int32 i,
                   [opt] int32 j,
                   int32 'value') cil managed
  {
    .param [1] = int32(0x00000003)
    .param [2] = int32(0x00000004)
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      ""{0} {1}""
    IL_0006:  ldarg.1
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  ldarg.2
    IL_000d:  box        [mscorlib]System.Int32
    IL_0012:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_0017:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001c:  nop
    IL_001d:  ret
  } // end of method P::set_Item


  .property instance int32 Item(int32,
                                int32)
  {
    .get instance int32 P::get_Item(int32,
                                    int32)
    .set instance void P::set_Item(int32,
                                   int32,
                                   int32)
  } // end of property P::Item
} // end of class P
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,113434,113593);

var 
csharp = @"
class C
{
    public static void Main(string[] args)
    {
         P p = new P();
         /*<bind>*/p[10]/*</bind>*/ = 9;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,113607,115052);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[[System.Int32 i = 3], [System.Int32 j = 4]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'p[10]')
  Instance Receiver: 
    ILocalReferenceOperation: p (OperationKind.LocalReference, Type: P) (Syntax: 'p')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: j) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'p[10]')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4, IsImplicit) (Syntax: 'p[10]')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,115066,115119);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,115133,115164);

var 
expectedOutput = @"10 4
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,115180,115403);

var 
ilReference = f_22006_115198_115402(csharp, il, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,115419,115509);

f_22006_115419_115508(this, new[] { csharp }, new[] { ilReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,110484,115520);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,110484,115520);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,110484,115520);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [ClrOnlyFact(ClrOnlyReason.Ilasm)]
        public void ReadFromIndexer_UsingDefaultArgumentFromGetter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,115532,120571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,115714,118463);

var 
il = @"
.class public auto ansi beforefieldinit P
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) 
           = {string('Item')}

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method P::.ctor

  .method public hidebysig specialname instance int32 
          get_Item([opt] int32 i,
                   [opt] int32 j) cil managed
  {
    .param [1] = int32(0x00000001)
    .param [2] = int32(0x00000002)
    // Code size       35 (0x23)
    .maxstack  3
    .locals init ([0] int32 V_0)
    IL_0000:  nop
    IL_0001:  ldstr      ""{0} {1}""
    IL_0006:  ldarg.1
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  ldarg.2
    IL_000d:  box        [mscorlib]System.Int32
    IL_0012:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_0017:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001c:  nop
    IL_001d:  ldc.i4.0
    IL_001e:  stloc.0
    IL_001f:  br.s       IL_0021
    IL_0021:  ldloc.0
    IL_0022:  ret
  } // end of method P::get_Item

  .method public hidebysig specialname instance void
          set_Item([opt] int32 i,
                   [opt] int32 j,
                   int32 'value') cil managed
  {
    .param [1] = int32(0x00000003)
    .param [2] = int32(0x00000004)
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      ""{0} {1}""
    IL_0006:  ldarg.1
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  ldarg.2
    IL_000d:  box        [mscorlib]System.Int32
    IL_0012:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_0017:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001c:  nop
    IL_001d:  ret
  } // end of method P::set_Item


  .property instance int32 Item(int32,
                                int32)
  {
    .get instance int32 P::get_Item(int32,
                                    int32)
    .set instance void P::set_Item(int32,
                                   int32,
                                   int32)
  } // end of property P::Item
} // end of class P
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,118479,118642);

var 
csharp = @"
class C
{
    public static void Main(string[] args)
    {
         P p = new P();
         var x = /*<bind>*/p[10]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,118656,120101);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[[System.Int32 i = 3], [System.Int32 j = 4]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'p[10]')
  Instance Receiver: 
    ILocalReferenceOperation: p (OperationKind.LocalReference, Type: P) (Syntax: 'p')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: j) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'p[10]')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'p[10]')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,120115,120168);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,120184,120215);

var 
expectedOutput = @"10 2
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,120231,120454);

var 
ilReference = f_22006_120249_120453(csharp, il, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,120470,120560);

f_22006_120470_120559(this, new[] { csharp }, new[] { ilReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,115532,120571);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,115532,120571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,115532,120571);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [ClrOnlyFact(ClrOnlyReason.Ilasm)]
        public void IndexerAccess_LHSOfCompoundAssignment()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,120583,125617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,120756,123505);

var 
il = @"
.class public auto ansi beforefieldinit P
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) 
           = {string('Item')}

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method P::.ctor

  .method public hidebysig specialname instance int32 
          get_Item([opt] int32 i,
                   [opt] int32 j) cil managed
  {
    .param [1] = int32(0x00000001)
    .param [2] = int32(0x00000002)
    // Code size       35 (0x23)
    .maxstack  3
    .locals init ([0] int32 V_0)
    IL_0000:  nop
    IL_0001:  ldstr      ""{0} {1}""
    IL_0006:  ldarg.1
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  ldarg.2
    IL_000d:  box        [mscorlib]System.Int32
    IL_0012:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_0017:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001c:  nop
    IL_001d:  ldc.i4.0
    IL_001e:  stloc.0
    IL_001f:  br.s       IL_0021
    IL_0021:  ldloc.0
    IL_0022:  ret
  } // end of method P::get_Item

  .method public hidebysig specialname instance void
          set_Item([opt] int32 i,
                   [opt] int32 j,
                   int32 'value') cil managed
  {
    .param [1] = int32(0x00000003)
    .param [2] = int32(0x00000004)
    // Code size       30 (0x1e)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      ""{0} {1}""
    IL_0006:  ldarg.1
    IL_0007:  box        [mscorlib]System.Int32
    IL_000c:  ldarg.2
    IL_000d:  box        [mscorlib]System.Int32
    IL_0012:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_0017:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_001c:  nop
    IL_001d:  ret
  } // end of method P::set_Item


  .property instance int32 Item(int32,
                                int32)
  {
    .get instance int32 P::get_Item(int32,
                                    int32)
    .set instance void P::set_Item(int32,
                                   int32,
                                   int32)
  } // end of property P::Item
} // end of class P
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,123521,123682);

var 
csharp = @"
class C
{
    public static void Main(string[] args)
    {
         P p = new P();
         /*<bind>*/p[10]/*</bind>*/ += 99;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,123696,125141);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[[System.Int32 i = 3], [System.Int32 j = 4]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'p[10]')
  Instance Receiver: 
    ILocalReferenceOperation: p (OperationKind.LocalReference, Type: P) (Syntax: 'p')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '10')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10) (Syntax: '10')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: j) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'p[10]')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'p[10]')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,125155,125208);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,125224,125261);

var 
expectedOutput = @"10 2
10 2
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,125277,125500);

var 
ilReference = f_22006_125295_125499(csharp, il, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier: IndexerAccessArgumentVerifier.Verify)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,125516,125606);

f_22006_125516_125605(this, new[] { csharp }, new[] { ilReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,120583,125617);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,120583,125617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,120583,125617);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [ClrOnlyFact(ClrOnlyReason.Ilasm)]
        public void InvalidConversionForDefaultArgument_InIL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,125629,128382);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,125805,126469);

var 
il = @"
.class public auto ansi beforefieldinit P
       extends [mscorlib]System.Object
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method P::.ctor

  .method public hidebysig instance void  M1([opt] int32 s) cil managed
  {
    .param [1] = ""abc""
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000: nop
    IL_0001:  ret
  } // end of method P::M1
} // end of class P
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,126485,126619);

var 
csharp = @"
class C
{
    public void M2()
    {
         P p = new P();
         /*<bind>*/p.M1()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,126633,127873);

string 
expectedOperationTree = @"
IInvocationOperation ( void P.M1([System.Int32 s = ""abc""])) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'p.M1()')
  Instance Receiver: 
    ILocalReferenceOperation: p (OperationKind.LocalReference, Type: P, IsInvalid) (Syntax: 'p')
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'p.M1()')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'p.M1()')
          Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""abc"", IsInvalid, IsImplicit) (Syntax: 'p.M1()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,127887,128224);

var 
expectedDiagnostics = new[]
            {
f_22006_128107_128208(f_22006_128107_128188(f_22006_128107_128157(ErrorCode.ERR_NoImplicitConv, "p.M1()"), "string", "int"), 7, 20)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,128240,128371);

f_22006_128240_128370(csharp, il, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,125629,128382);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,125629,128382);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,125629,128382);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(20330, "https://github.com/dotnet/roslyn/issues/20330")]
        public void DefaultValueNonNullForNullableParameterTypeWithMissingNullableReference_Call()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,128394,132524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,128644,128805);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }

    static void M2(bool? x = true)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,128819,129998);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2([System.Boolean[missing]? x = true])) (OperationKind.Invocation, Type: System.Void[missing], IsInvalid) (Syntax: 'M2()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'M2()')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean[missing]?, IsInvalid, IsImplicit) (Syntax: 'M2()')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean[missing], Constant: True, IsInvalid, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,130014,132260);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_130227_130332(f_22006_130227_130312(f_22006_130227_130283(ErrorCode.ERR_PredefinedTypeNotFound, "void"), "System.Void"), 4, 12),
f_22006_130508_130616(f_22006_130508_130596(f_22006_130508_130564(ErrorCode.ERR_PredefinedTypeNotFound, "bool"), "System.Boolean"), 9, 20),
f_22006_130795_130907(f_22006_130795_130887(f_22006_130795_130852(ErrorCode.ERR_PredefinedTypeNotFound, "bool?"), "System.Nullable`1"), 9, 20),
f_22006_131080_131185(f_22006_131080_131165(f_22006_131080_131136(ErrorCode.ERR_PredefinedTypeNotFound, "void"), "System.Void"), 9, 12),
f_22006_131332_131435(f_22006_131332_131416(f_22006_131332_131385(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 2, 7),
f_22006_131611_131719(f_22006_131611_131699(f_22006_131611_131667(ErrorCode.ERR_PredefinedTypeNotFound, "true"), "System.Boolean"), 9, 30),
f_22006_131894_131999(f_22006_131894_131979(f_22006_131894_131948(ErrorCode.ERR_PredefinedTypeNotFound, "M2"), "System.Object"), 6, 19),
f_22006_132150_132244(f_22006_132150_132225(f_22006_132150_132196(ErrorCode.ERR_BadCtorArgCount, "P"), "object", "0"), 2, 7)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,132276,132373);

var 
compilation = f_22006_132294_132372(source, options: Test.Utilities.TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,132387,132513);

f_22006_132387_132512(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,128394,132524);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,128394,132524);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,128394,132524);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(20330, "https://github.com/dotnet/roslyn/issues/20330")]
        public void DefaultValueNonNullForNullableParameterTypeWithMissingNullableReference_ObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,132536,136671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,132796,132951);

string 
source = @"
class P
{
    static P M1()
    {
        return /*<bind>*/new P()/*</bind>*/;
    }

    P(bool? x = true)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,132965,134150);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: P..ctor([System.Boolean[missing]? x = true])) (OperationKind.ObjectCreation, Type: P, IsInvalid) (Syntax: 'new P()')
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'new P()')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Boolean[missing]?, IsInvalid, IsImplicit) (Syntax: 'new P()')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean[missing], Constant: True, IsInvalid, IsImplicit) (Syntax: 'new P()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,134166,136403);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_134378_134482(f_22006_134378_134462(f_22006_134378_134431(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 4, 12),
f_22006_134644_134751(f_22006_134644_134732(f_22006_134644_134700(ErrorCode.ERR_PredefinedTypeNotFound, "bool"), "System.Boolean"), 9, 7),
f_22006_134916_135027(f_22006_134916_135008(f_22006_134916_134973(ErrorCode.ERR_PredefinedTypeNotFound, "bool?"), "System.Nullable`1"), 9, 7),
f_22006_135186_135318(f_22006_135186_135299(f_22006_135186_135270(ErrorCode.ERR_PredefinedTypeNotFound, @"P(bool? x = true)
    {
    }"), "System.Void"), 9, 5),
f_22006_135465_135568(f_22006_135465_135549(f_22006_135465_135518(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 2, 7),
f_22006_135731_135839(f_22006_135731_135819(f_22006_135731_135787(ErrorCode.ERR_PredefinedTypeNotFound, "true"), "System.Boolean"), 9, 17),
f_22006_136024_136128(f_22006_136024_136108(f_22006_136024_136077(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 6, 30),
f_22006_136293_136387(f_22006_136293_136368(f_22006_136293_136339(ErrorCode.ERR_BadCtorArgCount, "P"), "object", "0"), 9, 5)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,136419,136516);

var 
compilation = f_22006_136437_136515(source, options: Test.Utilities.TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,136530,136660);

f_22006_136530_136659(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,132536,136671);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,132536,136671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,132536,136671);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(20330, "https://github.com/dotnet/roslyn/issues/20330")]
        public void DefaultValueNonNullForNullableParameterTypeWithMissingNullableReference_Indexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,136683,143089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,136936,137200);

string 
source = @"

class P
{
    private int _number = 0;
    public int this[int x, int? y = 5]
    {
        get { return _number; }
        set { _number = value; }
    }

    void M1()
    {
        /*<bind>*/this[0]/*</bind>*/ = 9;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,137214,139150);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32[missing] P.this[System.Int32[missing] x, [System.Int32[missing]? y = 5]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32[missing], IsInvalid) (Syntax: 'this[0]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '0')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32[missing], Constant: 0, IsInvalid) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: y) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'this[0]')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32[missing]?, IsInvalid, IsImplicit) (Syntax: 'this[0]')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32[missing], Constant: 5, IsInvalid, IsImplicit) (Syntax: 'this[0]')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,139166,142822);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_139388_139493(f_22006_139388_139473(f_22006_139388_139443(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 13),
f_22006_139671_139776(f_22006_139671_139756(f_22006_139671_139726(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 6, 12),
f_22006_139954_140059(f_22006_139954_140039(f_22006_139954_140009(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 6, 21),
f_22006_140237_140342(f_22006_140237_140322(f_22006_140237_140292(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 6, 28),
f_22006_140525_140636(f_22006_140525_140616(f_22006_140525_140581(ErrorCode.ERR_PredefinedTypeNotFound, "int?"), "System.Nullable`1"), 6, 28),
f_22006_140806_140930(f_22006_140806_140911(f_22006_140806_140882(ErrorCode.ERR_PredefinedTypeNotFound, "set { _number = value; }"), "System.Void"), 9, 9),
f_22006_141082_141187(f_22006_141082_141167(f_22006_141082_141138(ErrorCode.ERR_PredefinedTypeNotFound, "void"), "System.Void"), 12, 5),
f_22006_141334_141437(f_22006_141334_141418(f_22006_141334_141387(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 3, 7),
f_22006_141615_141718(f_22006_141615_141698(f_22006_141615_141668(ErrorCode.ERR_PredefinedTypeNotFound, "5"), "System.Int32"), 6, 37),
f_22006_141886_141989(f_22006_141886_141969(f_22006_141886_141939(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 5, 27),
f_22006_142171_142275(f_22006_142171_142254(f_22006_142171_142224(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 14, 24),
f_22006_142457_142561(f_22006_142457_142540(f_22006_142457_142510(ErrorCode.ERR_PredefinedTypeNotFound, "9"), "System.Int32"), 14, 40),
f_22006_142712_142806(f_22006_142712_142787(f_22006_142712_142758(ErrorCode.ERR_BadCtorArgCount, "P"), "object", "0"), 3, 7)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,142838,142935);

var 
compilation = f_22006_142856_142934(source, options: Test.Utilities.TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,142949,143078);

f_22006_142949_143077(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,136683,143089);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,136683,143089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,136683,143089);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(20330, "https://github.com/dotnet/roslyn/issues/20330")]
        public void DefaultValueNullForNullableParameterTypeWithMissingNullableReference_Call()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,143101,146602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,143348,143509);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }

    static void M2(bool? x = null)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,143523,144360);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2([System.Boolean[missing]? x = null])) (OperationKind.Invocation, Type: System.Void[missing], IsInvalid) (Syntax: 'M2()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'M2()')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Boolean[missing]?, IsInvalid, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,144376,146338);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_144589_144694(f_22006_144589_144674(f_22006_144589_144645(ErrorCode.ERR_PredefinedTypeNotFound, "void"), "System.Void"), 4, 12),
f_22006_144870_144978(f_22006_144870_144958(f_22006_144870_144926(ErrorCode.ERR_PredefinedTypeNotFound, "bool"), "System.Boolean"), 9, 20),
f_22006_145157_145269(f_22006_145157_145249(f_22006_145157_145214(ErrorCode.ERR_PredefinedTypeNotFound, "bool?"), "System.Nullable`1"), 9, 20),
f_22006_145442_145547(f_22006_145442_145527(f_22006_145442_145498(ErrorCode.ERR_PredefinedTypeNotFound, "void"), "System.Void"), 9, 12),
f_22006_145694_145797(f_22006_145694_145778(f_22006_145694_145747(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 2, 7),
f_22006_145972_146077(f_22006_145972_146057(f_22006_145972_146026(ErrorCode.ERR_PredefinedTypeNotFound, "M2"), "System.Object"), 6, 19),
f_22006_146228_146322(f_22006_146228_146303(f_22006_146228_146274(ErrorCode.ERR_BadCtorArgCount, "P"), "object", "0"), 2, 7)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,146354,146451);

var 
compilation = f_22006_146372_146450(source, options: Test.Utilities.TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,146465,146591);

f_22006_146465_146590(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,143101,146602);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,143101,146602);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,143101,146602);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(20330, "https://github.com/dotnet/roslyn/issues/20330")]
        public void DefaultValueNullForNullableParameterTypeWithMissingNullableReference_ObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,146614,150130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,146871,147026);

string 
source = @"
class P
{
    static P M1()
    {
        return /*<bind>*/new P()/*</bind>*/;
    }

    P(bool? x = null)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,147040,147880);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: P..ctor([System.Boolean[missing]? x = null])) (OperationKind.ObjectCreation, Type: P, IsInvalid) (Syntax: 'new P()')
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'new P()')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Boolean[missing]?, IsInvalid, IsImplicit) (Syntax: 'new P()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,147896,149862);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_148097_148200(f_22006_148097_148181(f_22006_148097_148150(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 2, 7),
f_22006_148358_148462(f_22006_148358_148442(f_22006_148358_148411(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 4, 12),
f_22006_148624_148731(f_22006_148624_148712(f_22006_148624_148680(ErrorCode.ERR_PredefinedTypeNotFound, "bool"), "System.Boolean"), 9, 7),
f_22006_148896_149007(f_22006_148896_148988(f_22006_148896_148953(ErrorCode.ERR_PredefinedTypeNotFound, "bool?"), "System.Nullable`1"), 9, 7),
f_22006_149166_149298(f_22006_149166_149279(f_22006_149166_149250(ErrorCode.ERR_PredefinedTypeNotFound, @"P(bool? x = null)
    {
    }"), "System.Void"), 9, 5),
f_22006_149483_149587(f_22006_149483_149567(f_22006_149483_149536(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 6, 30),
f_22006_149752_149846(f_22006_149752_149827(f_22006_149752_149798(ErrorCode.ERR_BadCtorArgCount, "P"), "object", "0"), 9, 5)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,149878,149975);

var 
compilation = f_22006_149896_149974(source, options: Test.Utilities.TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,149989,150119);

f_22006_149989_150118(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,146614,150130);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,146614,150130);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,146614,150130);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(20330, "https://github.com/dotnet/roslyn/issues/20330")]
        public void DefaultValueNullForNullableParameterTypeWithMissingNullableReference_Indexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,150142,156142);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,150392,150660);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int x, int? y = null]
    {
        get { return _number; }
        set { _number = value; }
    }

    void M1()
    {
        /*<bind>*/this[0]/*</bind>*/ = 9;
    }
}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,150674,152273);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32[missing] P.this[System.Int32[missing] x, [System.Int32[missing]? y = null]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32[missing], IsInvalid) (Syntax: 'this[0]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '0')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32[missing], Constant: 0, IsInvalid) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: y) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: 'this[0]')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32[missing]?, IsInvalid, IsImplicit) (Syntax: 'this[0]')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,152289,155875);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_152480_152542(f_22006_152480_152522(ErrorCode.ERR_EOFExpected, "}"), 16, 1),
f_22006_152710_152815(f_22006_152710_152795(f_22006_152710_152765(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 4, 13),
f_22006_152996_153101(f_22006_152996_153081(f_22006_152996_153051(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 12),
f_22006_153282_153387(f_22006_153282_153367(f_22006_153282_153337(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 21),
f_22006_153568_153673(f_22006_153568_153653(f_22006_153568_153623(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 28),
f_22006_153859_153970(f_22006_153859_153950(f_22006_153859_153915(ErrorCode.ERR_PredefinedTypeNotFound, "int?"), "System.Nullable`1"), 5, 28),
f_22006_154140_154264(f_22006_154140_154245(f_22006_154140_154216(ErrorCode.ERR_PredefinedTypeNotFound, "set { _number = value; }"), "System.Void"), 8, 9),
f_22006_154416_154521(f_22006_154416_154501(f_22006_154416_154472(ErrorCode.ERR_PredefinedTypeNotFound, "void"), "System.Void"), 11, 5),
f_22006_154668_154771(f_22006_154668_154752(f_22006_154668_154721(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 2, 7),
f_22006_154939_155042(f_22006_154939_155022(f_22006_154939_154992(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 4, 27),
f_22006_155224_155328(f_22006_155224_155307(f_22006_155224_155277(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 13, 24),
f_22006_155510_155614(f_22006_155510_155593(f_22006_155510_155563(ErrorCode.ERR_PredefinedTypeNotFound, "9"), "System.Int32"), 13, 40),
f_22006_155765_155859(f_22006_155765_155840(f_22006_155765_155811(ErrorCode.ERR_BadCtorArgCount, "P"), "object", "0"), 2, 7)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,155891,155988);

var 
compilation = f_22006_155909_155987(source, options: Test.Utilities.TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,156002,156131);

f_22006_156002_156130(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,150142,156142);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,150142,156142);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,150142,156142);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(20330, "https://github.com/dotnet/roslyn/issues/20330")]
        public void DefaultValueWithParameterErrorType_Call()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,156154,158856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,156367,156529);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(1)/*</bind>*/;
    }

    static void M2(int x, S s = 0)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,156543,157842);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2(System.Int32 x, [S s = null])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1)')
  Instance Receiver: 
    null
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(1)')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: S, IsImplicit) (Syntax: 'M2(1)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,157858,158632);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_158165_158257(f_22006_158165_158237(f_22006_158165_158218(ErrorCode.ERR_SingleTypeNameNotFound, "S"), "S"), 9, 27),
f_22006_158512_158616(f_22006_158512_158596(f_22006_158512_158570(ErrorCode.ERR_NoConversionForDefaultParam, "s"), "int", "S"), 9, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,158648,158685);

var 
comp = f_22006_158659_158684(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,158699,158783);

f_22006_158699_158782(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,158797,158845);

f_22006_158797_158844(            comp, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,156154,158856);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,156154,158856);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,156154,158856);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueWithParameterErrorType_ObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,158868,161462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,159025,159181);

string 
source = @"
class P
{
    static P M1()
    {
        return /*<bind>*/new P(1)/*</bind>*/;
    }

    P(int x, S s = 0)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,159195,160506);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: P..ctor(System.Int32 x, [S s = null])) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P(1)')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new P(1)')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: S, IsImplicit) (Syntax: 'new P(1)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,160522,161234);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_160798_160890(f_22006_160798_160870(f_22006_160798_160851(ErrorCode.ERR_SingleTypeNameNotFound, "S"), "S"), 9, 14),
f_22006_161114_161218(f_22006_161114_161198(f_22006_161114_161172(ErrorCode.ERR_NoConversionForDefaultParam, "s"), "int", "S"), 9, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,161250,161287);

var 
comp = f_22006_161261_161286(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,161301,161389);

f_22006_161301_161388(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,161403,161451);

f_22006_161403_161450(            comp, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,158868,161462);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,158868,161462);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,158868,161462);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueWithParameterErrorType_Indexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,161474,164366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,161624,161887);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int index, S s = 0]
    {
        get { return _number; }
        set { _number = value; }
    }

    void M1()
    {
        /*<bind>*/this[0]/*</bind>*/ = 9;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,161901,163375);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[System.Int32 index, [S s = null]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this[0]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: index) (OperationKind.Argument, Type: null) (Syntax: '0')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this[0]')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: S, IsImplicit) (Syntax: 'this[0]')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,163391,164139);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_163685_163777(f_22006_163685_163757(f_22006_163685_163738(ErrorCode.ERR_SingleTypeNameNotFound, "S"), "S"), 5, 32),
f_22006_164019_164123(f_22006_164019_164103(f_22006_164019_164077(ErrorCode.ERR_NoConversionForDefaultParam, "s"), "int", "S"), 5, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,164155,164192);

var 
comp = f_22006_164166_164191(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,164206,164293);

f_22006_164206_164292(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,164307,164355);

f_22006_164307_164354(            comp, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,161474,164366);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,161474,164366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,161474,164366);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(18722, "https://github.com/dotnet/roslyn/issues/18722")]
        public void DefaultValueForGenericWithUndefinedTypeArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,164378,166853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,164745,164933);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(1)/*</bind>*/;
    }

    static void M2(int x, G<S> s = null)
    {
    }
}

class G<T>
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,164947,166268);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2(System.Int32 x, [G<S> s = null])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1)')
  Instance Receiver: 
    null
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(1)')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: G<S>, Constant: null, IsImplicit) (Syntax: 'M2(1)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,166284,166705);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_166597_166689(f_22006_166597_166669(f_22006_166597_166650(ErrorCode.ERR_SingleTypeNameNotFound, "S"), "S"), 9, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,166721,166842);

f_22006_166721_166841(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,164378,166853);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,164378,166853);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,164378,166853);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(18722, "https://github.com/dotnet/roslyn/issues/18722")]
        public void DefaultValueForNullableGenericWithUndefinedTypeArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,166865,169336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,167240,167430);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(1)/*</bind>*/;
    }

    static void M2(int x, G<S>? s = null)
    {
    }
}

struct G<T>
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,167444,168751);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2(System.Int32 x, [G<S>? s = null])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1)')
  Instance Receiver: 
    null
  Arguments(2):
      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(1)')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: G<S>?, IsImplicit) (Syntax: 'M2(1)')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,168767,169188);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_169080_169172(f_22006_169080_169152(f_22006_169080_169133(ErrorCode.ERR_SingleTypeNameNotFound, "S"), "S"), 9, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,169204,169325);

f_22006_169204_169324(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,166865,169336);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,166865,169336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,166865,169336);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void GettingInOutConversionFromCSharpArgumentShouldThrowException()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,169350,170252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,169518,169671);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(1)/*</bind>*/;
    }

    static void M2(int x)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,169685,169729);

var 
compilation = f_22006_169703_169728(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,169743,169843);

var (operation, syntaxNode) = f_22006_169773_169842(compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,169859,169908);

var 
invocation = (IInvocationOperation)operation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,169922,169961);

var 
argument = f_22006_169937_169957(invocation)[0]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,170092,170159);

f_22006_170092_170158(() => argument.GetInConversion());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,170173,170241);

f_22006_170173_170240(() => argument.GetOutConversion());
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,169350,170252);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,169350,170252);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,169350,170252);
}
		}

[Fact]
        public void DirectlyBindArgument_InvocationExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,170264,171262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,170360,170501);

string 
source = @"
class P
{
    static void M1()
    {
        M2(/*<bind>*/1/*</bind>*/);
    }
    static void M2(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,170515,171059);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,171073,171126);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,171142,171251);

f_22006_171142_171250(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,170264,171262);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,170264,171262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,170264,171262);
}
		}

[Fact]
        public void DirectlyBindRefArgument_InvocationExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,171274,172311);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,171373,171542);

string 
source = @"
class P
{
    static void M1()
    {
        int i = 0;
        M2(/*<bind>*/ref i/*</bind>*/);
    }
    static void M2(ref int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,171556,172108);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'ref i')
  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,172122,172175);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,172191,172300);

f_22006_172191_172299(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,171274,172311);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,171274,172311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,171274,172311);
}
		}

[Fact]
        public void DirectlyBindInArgument_InvocationExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,172323,173393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,172421,172619);

string 
source = @"
class P
{
    static void M1()
    {
        int i = 0;
        ref int refI = ref i;
        M2(/*<bind>*/refI/*</bind>*/);
    }
    static void M2(in int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,172633,173190);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'refI')
  ILocalReferenceOperation: refI (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'refI')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,173204,173257);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,173273,173382);

f_22006_173273_173381(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,172323,173393);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,172323,173393);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,172323,173393);
}
		}

[Fact]
        public void DirectlyBindOutArgument_InvocationExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,173405,174729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,173504,173673);

string 
source = @"
class P
{
    static void M1()
    {
        int i = 0;
        M2(/*<bind>*/out i/*</bind>*/);
    }
    static void M2(out int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,173687,174239);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out i')
  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,174253,174593);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_174491_174577(f_22006_174491_174557(f_22006_174491_174538(ErrorCode.ERR_ParamUnassigned, "M2"), "i"), 9, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,174609,174718);

f_22006_174609_174717(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,173405,174729);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,173405,174729);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,173405,174729);
}
		}

[Fact]
        public void DirectlyBindParamsArgument1_InvocationExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,174741,176626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,174844,174998);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(1);/*</bind>*/
    }
    static void M2(params int[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,175012,176412);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(1);')
  Expression: 
    IInvocationOperation (void P.M2(params System.Int32[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(1)')
      Instance Receiver: 
        null
      Arguments(1):
          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(1)')
            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'M2(1)')
              Dimension Sizes(1):
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'M2(1)')
              Initializer: 
                IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'M2(1)')
                  Element Values(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,176426,176479);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,176495,176615);

f_22006_176495_176614(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,174741,176626);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,174741,176626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,174741,176626);
}
		}

[Fact]
        public void DirectlyBindParamsArgument2_InvocationExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,176638,178656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,176741,176898);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(0, 1);/*</bind>*/
    }
    static void M2(params int[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,176912,178442);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M2(0, 1);')
  Expression: 
    IInvocationOperation (void P.M2(params System.Int32[] array)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(0, 1)')
      Instance Receiver: 
        null
      Arguments(1):
          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2(0, 1)')
            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'M2(0, 1)')
              Dimension Sizes(1):
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'M2(0, 1)')
              Initializer: 
                IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'M2(0, 1)')
                  Element Values(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,178456,178509);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,178525,178645);

f_22006_178525_178644(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,176638,178656);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,176638,178656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,176638,178656);
}
		}

[Fact]
        public void DirectlyBindNamedArgument1_InvocationExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,178668,179691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,178770,178927);

string 
source = @"
class P
{
    static void M1()
    {
        M2(/*<bind>*/j: 1/*</bind>*/, i: 1);
    }
    static void M2(int i, int j) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,178941,179488);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: j) (OperationKind.Argument, Type: null) (Syntax: 'j: 1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,179502,179555);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,179571,179680);

f_22006_179571_179679(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,178668,179691);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,178668,179691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,178668,179691);
}
		}

[Fact]
        public void DirectlyBindNamedArgument2_InvocationExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,179703,180726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,179805,179962);

string 
source = @"
class P
{
    static void M1()
    {
        M2(j: 1, /*<bind>*/i: 1/*</bind>*/);
    }
    static void M2(int i, int j) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,179976,180523);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i: 1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,180537,180590);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,180606,180715);

f_22006_180606_180714(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,179703,180726);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,179703,180726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,179703,180726);
}
		}

[Fact]
        public void DirectlyBindArgument_ObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,180738,181727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,180828,180966);

string 
source = @"
class P
{
    static void M1()
    {
        new P(/*<bind>*/1/*</bind>*/);
    }
    public P(int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,180980,181524);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,181538,181591);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,181607,181716);

f_22006_181607_181715(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,180738,181727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,180738,181727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,180738,181727);
}
		}

[Fact]
        public void DirectlyBindRefArgument_ObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,181739,182767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,181832,181998);

string 
source = @"
class P
{
    static void M1()
    {
        int i = 0;
        new P(/*<bind>*/ref i/*</bind>*/);
    }
    public P(ref int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,182012,182564);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'ref i')
  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,182578,182631);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,182647,182756);

f_22006_182647_182755(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,181739,182767);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,181739,182767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,181739,182767);
}
		}

[Fact]
        public void DirectlyBindOutArgument_ObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,182779,184087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,182872,183038);

string 
source = @"
class P
{
    static void M1()
    {
        int i = 0;
        new P(/*<bind>*/out i/*</bind>*/);
    }
    public P(out int i) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,183052,183604);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out i')
  ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,183618,183951);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_183850_183935(f_22006_183850_183915(f_22006_183850_183896(ErrorCode.ERR_ParamUnassigned, "P"), "i"), 9, 12)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,183967,184076);

f_22006_183967_184075(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,182779,184087);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,182779,184087);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,182779,184087);
}
		}

[Fact]
        public void DirectlyBindParamsArgument1_ObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,184099,185996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,184196,184347);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/new P(1);/*</bind>*/
    }
    public P(params int[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,184361,185782);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'new P(1);')
  Expression: 
    IObjectCreationOperation (Constructor: P..ctor(params System.Int32[] array)) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P(1)')
      Arguments(1):
          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new P(1)')
            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'new P(1)')
              Dimension Sizes(1):
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'new P(1)')
              Initializer: 
                IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'new P(1)')
                  Element Values(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Initializer: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,185796,185849);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,185865,185985);

f_22006_185865_185984(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,184099,185996);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,184099,185996);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,184099,185996);
}
		}

[Fact]
        public void DirectlyBindParamsArgument2_ObjectCreation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,186008,188038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,186105,186259);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/new P(0, 1);/*</bind>*/
    }
    public P(params int[] array) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,186273,187824);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'new P(0, 1);')
  Expression: 
    IObjectCreationOperation (Constructor: P..ctor(params System.Int32[] array)) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P(0, 1)')
      Arguments(1):
          IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'new P(0, 1)')
            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'new P(0, 1)')
              Dimension Sizes(1):
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'new P(0, 1)')
              Initializer: 
                IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'new P(0, 1)')
                  Element Values(2):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
      Initializer: 
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,187838,187891);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,187907,188027);

f_22006_187907_188026(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,186008,188038);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,186008,188038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,186008,188038);
}
		}

[Fact]
        public void DirectlyBindArgument_Indexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,188050,189041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,188133,188280);

string 
source = @"
class P
{
    void M1()
    {
        var v = this[/*<bind>*/1/*</bind>*/];
    }
    public int this[int i] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,188294,188838);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: '1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,188852,188905);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,188921,189030);

f_22006_188921_189029(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,188050,189041);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,188050,189041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,188050,189041);
}
		}

[Fact]
        public void DirectlyBindParamsArgument1_Indexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,189053,190931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,189143,189303);

string 
source = @"
class P
{
    void M1()
    {
        var v = /*<bind>*/this[1]/*</bind>*/;
    }
    public int this[params int[] array] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,189317,190713);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[params System.Int32[] array] { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this[1]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(1):
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this[1]')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'this[1]')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'this[1]')
          Initializer: 
            IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'this[1]')
              Element Values(1):
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,190727,190780);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,190796,190920);

f_22006_190796_190919(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,189053,190931);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,189053,190931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,189053,190931);
}
		}

[Fact]
        public void DirectlyBindParamsArgument2_Indexer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,190943,192947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,191033,191196);

string 
source = @"
class P
{
    void M1()
    {
        var v = /*<bind>*/this[0, 1]/*</bind>*/;
    }
    public int this[params int[] array] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,191210,192729);

string 
expectedOperationTree = @"
IPropertyReferenceOperation: System.Int32 P.this[params System.Int32[] array] { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'this[0, 1]')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P) (Syntax: 'this')
  Arguments(1):
      IArgumentOperation (ArgumentKind.ParamArray, Matching Parameter: array) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'this[0, 1]')
        IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: 'this[0, 1]')
          Dimension Sizes(1):
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsImplicit) (Syntax: 'this[0, 1]')
          Initializer: 
            IArrayInitializerOperation (2 elements) (OperationKind.ArrayInitializer, Type: null, IsImplicit) (Syntax: 'this[0, 1]')
              Element Values(2):
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,192743,192796);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,192812,192936);

f_22006_192812_192935(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,190943,192947);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,190943,192947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,190943,192947);
}
		}

[Fact]
        public void DirectlyBindArgument_Attribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,192959,193601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,193044,193139);

string 
source = @"
[assembly: /*<bind>*/System.CLSCompliant(isCompliant: true)/*</bind>*/]
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,193153,193397);

string 
expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: 'System.CLSC ... iant: true)')
  Children(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,193411,193464);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,193480,193590);

f_22006_193480_193589(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,192959,193601);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,192959,193601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,192959,193601);
}
		}

[Fact]
        public void DirectlyBindArgument2_Attribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,193613,194536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,193699,193849);

string 
source = @"
[assembly: MyA(/*<bind>*/Prop = ""test""/*</bind>*/)]

class MyA : System.Attribute
{
    public string Prop {get;set;}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,193863,194324);

string 
expectedOperationTree = @"
ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 'Prop = ""test""')
  Left: 
    IPropertyReferenceOperation: System.String MyA.Prop { get; set; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Prop')
      Instance Receiver: 
        null
  Right: 
    ILiteralOperation (OperationKind.Literal, Type: System.String, Constant: ""test"") (Syntax: '""test""')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,194338,194391);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,194407,194525);

f_22006_194407_194524(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,193613,194536);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,193613,194536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,193613,194536);
}
		}

[Fact]
        public void DirectlyBindArgument_NonTrailingNamedArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,194548,195532);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,194648,194770);

string 
source = @"
class P
{
    void M1(int i, int i2)
    {
        M1(i: 0, /*<bind>*/2/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,194784,195329);

string 
expectedOperationTree = @"
IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null) (Syntax: '2')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,195343,195396);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,195412,195521);

f_22006_195412_195520(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,194548,195532);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,194548,195532);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,194548,195532);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NonNullDefaultValueForNullableParameterType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,195544,197193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,195695,195841);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }
    static void M2(int? x = 10) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,195855,196944);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2([System.Int32? x = 10])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32?, IsImplicit) (Syntax: 'M2()')
          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          Operand: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,196958,197011);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,197025,197182);

f_22006_197025_197181(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,195544,197193);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,195544,197193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,195544,197193);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Theory]
        [InlineData("null")]
        [InlineData("default")]
        [InlineData("default(int?)")]
        public void NullDefaultValueForNullableParameterType(string defaultValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,197205,198677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,197476,197641);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2()/*</bind>*/;
    }
    static void M2(int? x = " + defaultValue + @") { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,197655,198428);

string 
expectedOperationTree = @"
IInvocationOperation (void P.M2([System.Int32? x = null])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2()')
  Instance Receiver: 
    null
  Arguments(1):
      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M2()')
        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32?, IsImplicit) (Syntax: 'M2()')
        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,198442,198495);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,198509,198666);

f_22006_198509_198665(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,197205,198677);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,197205,198677);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,197205,198677);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void AssigningToReadOnlyIndexerInObjectCreationInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,198689,200539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,198850,199082);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int index]
    {
        get { return _number; }
    }

    P M1()
    {
        return /*<bind>*/new P() { [0] = 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,199096,199981);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P, IsInvalid) (Syntax: 'new P() { [0] = 1 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: P, IsInvalid) (Syntax: '{ [0] = 1 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: '[0] = 1')
            Left: 
              IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid) (Syntax: '[0]')
                Children(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,199997,200387);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_200272_200371(f_22006_200272_200350(f_22006_200272_200321(ErrorCode.ERR_AssgReadonlyProp, "[0]"), "P.this[int]"), 12, 36)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,200403,200528);

f_22006_200403_200527(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,198689,200539);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,198689,200539);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,198689,200539);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void WrongSignatureIndexerInObjectCreationInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,200551,202406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,200707,200975);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[string name]
    {
        get { return _number; }
        set { _number = value; }
    }

    P M1()
    {
        return /*<bind>*/new P() { [0] = 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,200989,201874);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P, IsInvalid) (Syntax: 'new P() { [0] = 1 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: P, IsInvalid) (Syntax: '{ [0] = 1 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: '[0] = 1')
            Left: 
              IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid) (Syntax: '[0]')
                Children(1):
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,201890,202254);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_202140_202238(f_22006_202140_202217(f_22006_202140_202181(ErrorCode.ERR_BadArgType, "0"), "1", "int", "string"), 13, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,202270,202395);

f_22006_202270_202394(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,200551,202406);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,200551,202406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,200551,202406);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueNonNullForNullableParameterTypeWithMissingNullableReference_IndexerInObjectCreationInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,202418,210244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,202632,202906);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int x, int? y = 0]
    {
        get { return _number; }
        set { _number = value; }
    }

    P M1()
    {
        return /*<bind>*/new P() { [0] = 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,202920,205674);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: P, IsInvalid) (Syntax: 'new P() { [0] = 1 }')
  Children(1):
      IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: P, IsInvalid) (Syntax: '{ [0] = 1 }')
        Initializers(1):
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[missing], IsInvalid) (Syntax: '[0] = 1')
              Left: 
                IPropertyReferenceOperation: System.Int32[missing] P.this[System.Int32[missing] x, [System.Int32[missing]? y = 0]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32[missing], IsInvalid) (Syntax: '[0]')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: P, IsInvalid, IsImplicit) (Syntax: '[0]')
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '0')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32[missing], Constant: 0, IsInvalid) (Syntax: '0')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: y) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: '[0]')
                        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32[missing]?, IsInvalid, IsImplicit) (Syntax: '[0]')
                          Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                          Operand: 
                            ILiteralOperation (OperationKind.Literal, Type: System.Int32[missing], Constant: 0, IsInvalid, IsImplicit) (Syntax: '[0]')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32[missing], Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,205690,209976);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_205912_206017(f_22006_205912_205997(f_22006_205912_205967(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 4, 13),
f_22006_206195_206300(f_22006_206195_206280(f_22006_206195_206250(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 12),
f_22006_206478_206583(f_22006_206478_206563(f_22006_206478_206533(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 21),
f_22006_206761_206866(f_22006_206761_206846(f_22006_206761_206816(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 28),
f_22006_207049_207160(f_22006_207049_207140(f_22006_207049_207105(ErrorCode.ERR_PredefinedTypeNotFound, "int?"), "System.Nullable`1"), 5, 28),
f_22006_207330_207454(f_22006_207330_207435(f_22006_207330_207406(ErrorCode.ERR_PredefinedTypeNotFound, "set { _number = value; }"), "System.Void"), 8, 9),
f_22006_207605_207709(f_22006_207605_207689(f_22006_207605_207658(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 11, 5),
f_22006_207856_207959(f_22006_207856_207940(f_22006_207856_207909(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 2, 7),
f_22006_208137_208240(f_22006_208137_208220(f_22006_208137_208190(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 5, 37),
f_22006_208408_208511(f_22006_208408_208491(f_22006_208408_208461(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 4, 27),
f_22006_208709_208814(f_22006_208709_208793(f_22006_208709_208762(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 13, 30),
f_22006_209011_209115(f_22006_209011_209094(f_22006_209011_209064(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 13, 37),
f_22006_209312_209416(f_22006_209312_209395(f_22006_209312_209365(ErrorCode.ERR_PredefinedTypeNotFound, "1"), "System.Int32"), 13, 42),
f_22006_209612_209715(f_22006_209612_209694(f_22006_209612_209665(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Void"), 13, 30),
f_22006_209866_209960(f_22006_209866_209941(f_22006_209866_209912(ErrorCode.ERR_BadCtorArgCount, "P"), "object", "0"), 2, 7)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,209992,210089);

var 
compilation = f_22006_210010_210088(source, options: Test.Utilities.TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,210103,210233);

f_22006_210103_210232(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,202418,210244);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,202418,210244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,202418,210244);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueNullForNullableParameterTypeWithMissingNullableReference_IndexerInObjectCreationInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,210256,217432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,210467,210744);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int x, int? y = null]
    {
        get { return _number; }
        set { _number = value; }
    }

    P M1()
    {
        return /*<bind>*/new P() { [0] = 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,210758,213131);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: P, IsInvalid) (Syntax: 'new P() { [0] = 1 }')
  Children(1):
      IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: P, IsInvalid) (Syntax: '{ [0] = 1 }')
        Initializers(1):
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32[missing], IsInvalid) (Syntax: '[0] = 1')
              Left: 
                IPropertyReferenceOperation: System.Int32[missing] P.this[System.Int32[missing] x, [System.Int32[missing]? y = null]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32[missing], IsInvalid) (Syntax: '[0]')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: P, IsInvalid, IsImplicit) (Syntax: '[0]')
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: '0')
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32[missing], Constant: 0, IsInvalid) (Syntax: '0')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: y) (OperationKind.Argument, Type: null, IsInvalid, IsImplicit) (Syntax: '[0]')
                        IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32[missing]?, IsInvalid, IsImplicit) (Syntax: '[0]')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32[missing], Constant: 1, IsInvalid) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,213147,217164);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_213369_213474(f_22006_213369_213454(f_22006_213369_213424(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 4, 13),
f_22006_213655_213760(f_22006_213655_213740(f_22006_213655_213710(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 12),
f_22006_213941_214046(f_22006_213941_214026(f_22006_213941_213996(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 21),
f_22006_214227_214332(f_22006_214227_214312(f_22006_214227_214282(ErrorCode.ERR_PredefinedTypeNotFound, "int"), "System.Int32"), 5, 28),
f_22006_214518_214629(f_22006_214518_214609(f_22006_214518_214574(ErrorCode.ERR_PredefinedTypeNotFound, "int?"), "System.Nullable`1"), 5, 28),
f_22006_214799_214923(f_22006_214799_214904(f_22006_214799_214875(ErrorCode.ERR_PredefinedTypeNotFound, "set { _number = value; }"), "System.Void"), 8, 9),
f_22006_215074_215178(f_22006_215074_215158(f_22006_215074_215127(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 11, 5),
f_22006_215325_215428(f_22006_215325_215409(f_22006_215325_215378(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 2, 7),
f_22006_215596_215699(f_22006_215596_215679(f_22006_215596_215649(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 4, 27),
f_22006_215897_216002(f_22006_215897_215981(f_22006_215897_215950(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Object"), 13, 30),
f_22006_216199_216303(f_22006_216199_216282(f_22006_216199_216252(ErrorCode.ERR_PredefinedTypeNotFound, "0"), "System.Int32"), 13, 37),
f_22006_216500_216604(f_22006_216500_216583(f_22006_216500_216553(ErrorCode.ERR_PredefinedTypeNotFound, "1"), "System.Int32"), 13, 42),
f_22006_216800_216903(f_22006_216800_216882(f_22006_216800_216853(ErrorCode.ERR_PredefinedTypeNotFound, "P"), "System.Void"), 13, 30),
f_22006_217054_217148(f_22006_217054_217129(f_22006_217054_217100(ErrorCode.ERR_BadCtorArgCount, "P"), "object", "0"), 2, 7)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,217180,217277);

var 
compilation = f_22006_217198_217276(source, options: Test.Utilities.TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,217291,217421);

f_22006_217291_217420(compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,210256,217432);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,210256,217432);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,210256,217432);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueWithParameterErrorType_IndexerInObjectCreationInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,217444,221077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,217621,217892);

string 
source = @"
class P
{
    private int _number = 0;
    public int this[int x, S s = 0]
    {
        get { return _number; }
        set { _number = value; }
    }

    P M1()
    {
        return /*<bind>*/new P() { [0] = 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,217906,220093);

string 
expectedOperationTree = @"
IObjectCreationOperation (Constructor: P..ctor()) (OperationKind.ObjectCreation, Type: P) (Syntax: 'new P() { [0] = 1 }')
  Arguments(0)
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: P) (Syntax: '{ [0] = 1 }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '[0] = 1')
            Left: 
              IPropertyReferenceOperation: System.Int32 P.this[System.Int32 x, [S s = null]] { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: '[0]')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: '[0]')
                Arguments(2):
                    IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '0')
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: '[0]')
                      IDefaultValueOperation (OperationKind.DefaultValue, Type: S, IsImplicit) (Syntax: '[0]')
                      InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Right: 
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,220109,220849);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_220399_220491(f_22006_220399_220471(f_22006_220399_220452(ErrorCode.ERR_SingleTypeNameNotFound, "S"), "S"), 5, 28),
f_22006_220729_220833(f_22006_220729_220813(f_22006_220729_220787(ErrorCode.ERR_NoConversionForDefaultParam, "s"), "int", "S"), 5, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,220865,220902);

var 
comp = f_22006_220876_220901(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,220916,221004);

f_22006_220916_221003(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,221018,221066);

f_22006_221018_221065(            comp, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,217444,221077);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,217444,221077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,217444,221077);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        [WorkItem(39868, "https://github.com/dotnet/roslyn/issues/39868")]
        public void BadNullableDefaultArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,221089,223222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,221299,221466);

string 
source = @"
public struct MyStruct
{
    static void M1(MyStruct? s = default(MyStruct)) { } // 1
    static void M2() { /*<bind>*/M1();/*</bind>*/ }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,221631,222548);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'M1();')
  Expression: 
    IInvocationOperation (void MyStruct.M1([MyStruct? s = null])) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M1()')
      Instance Receiver: 
        null
      Arguments(1):
          IArgumentOperation (ArgumentKind.DefaultValue, Matching Parameter: s) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'M1()')
            IDefaultValueOperation (OperationKind.DefaultValue, Type: MyStruct?, IsImplicit) (Syntax: 'M1()')
            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,222564,223009);

var 
expectedDiagnostics = new[]
            {
f_22006_222881_222993(f_22006_222881_222973(f_22006_222881_222942(ErrorCode.ERR_NoConversionForNubDefaultParam, "s"), "MyStruct", "s"), 4, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,223025,223062);

var 
comp = f_22006_223036_223061(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,223076,223149);

f_22006_223076_223148(comp, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,223163,223211);

f_22006_223163_223210(            comp, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,221089,223222);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,221089,223222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,221089,223222);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void UndefinedMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,223234,224453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,223357,223470);

string 
source = @"
class P
{
    static void M1()
    {
        /*<bind>*/M2(1, 2)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,223484,223918);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M2(1, 2)')
  Children(3):
      IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M2')
        Children(0)
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,223932,224269);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22006_224165_224253(f_22006_224165_224233(f_22006_224165_224213(ErrorCode.ERR_NameNotInContext, "M2"), "M2"), 6, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,224285,224442);

f_22006_224285_224441(source, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(22006,223234,224453);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,223234,224453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,223234,224453);
}
		}
private class IndexerAccessArgumentVerifier : OperationWalker
{
private readonly Compilation _compilation;

private IndexerAccessArgumentVerifier(Compilation compilation)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(22006,224609,224746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,224580,224592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,224704,224731);

_compilation = compilation;
DynAbs.Tracing.TraceSender.TraceExitConstructor(22006,224609,224746);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,224609,224746);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,224609,224746);
}
		}

public static void Verify(IOperation operation, Compilation compilation, SyntaxNode syntaxNode)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(22006,224762,224969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,224890,224954);

f_22006_224890_224953(f_22006_224890_224936(compilation), operation);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(22006,224762,224969);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,224762,224969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,224762,224969);
}
		}

public override void VisitPropertyReference(IPropertyReferenceOperation operation)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22006,224985,225723);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,225100,225240) || true) && (f_22006_225104_225137(operation, _compilation)||(DynAbs.Tracing.TraceSender.Expression_False(22006, 225104, 225172)||operation.Arguments.Length == 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(22006,225100,225240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,225214,225221);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(22006,225100,225240);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,225372,225411);

var 
indexerSymbol = f_22006_225392_225410(operation)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,225429,225708);
foreach(var argument in f_22006_225454_225473_I(f_22006_225454_225473(operation)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(22006,225429,225708);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,225515,225689) || true) && (!f_22006_225520_225552(argument, _compilation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(22006,225515,225689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22006,225602,225666);

f_22006_225602_225665(indexerSymbol, f_22006_225629_225664(f_22006_225629_225647(argument)));
DynAbs.Tracing.TraceSender.TraceExitCondition(22006,225515,225689);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(22006,225429,225708);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(22006,1,280);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(22006,1,280);
}DynAbs.Tracing.TraceSender.TraceExitMethod(22006,224985,225723);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22006,224985,225723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,224985,225723);
}
		}

static IndexerAccessArgumentVerifier()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(22006,224465,225734);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(22006,224465,225734);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22006,224465,225734);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(22006,224465,225734);

static Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.IndexerAccessArgumentVerifier
f_22006_224890_224936(Microsoft.CodeAnalysis.Compilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.IndexerAccessArgumentVerifier( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 224890, 224936);
return return_v;
}


static int
f_22006_224890_224953(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests.IndexerAccessArgumentVerifier
this_param,Microsoft.CodeAnalysis.IOperation
operation)
{
this_param.Visit( operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 224890, 224953);
return 0;
}


bool
f_22006_225104_225137(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
operation,Microsoft.CodeAnalysis.Compilation
compilation)
{
var return_v = operation.HasErrors( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 225104, 225137);
return return_v;
}


Microsoft.CodeAnalysis.IPropertySymbol
f_22006_225392_225410(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
this_param)
{
var return_v = this_param.Property;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22006, 225392, 225410);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_22006_225454_225473(Microsoft.CodeAnalysis.Operations.IPropertyReferenceOperation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22006, 225454, 225473);
return return_v;
}


bool
f_22006_225520_225552(Microsoft.CodeAnalysis.Operations.IArgumentOperation
operation,Microsoft.CodeAnalysis.Compilation
compilation)
{
var return_v = operation.HasErrors( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 225520, 225552);
return return_v;
}


Microsoft.CodeAnalysis.IParameterSymbol?
f_22006_225629_225647(Microsoft.CodeAnalysis.Operations.IArgumentOperation
this_param)
{
var return_v = this_param.Parameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22006, 225629, 225647);
return return_v;
}


Microsoft.CodeAnalysis.ISymbol
f_22006_225629_225664(Microsoft.CodeAnalysis.IParameterSymbol?
this_param)
{
var return_v = this_param.ContainingSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22006, 225629, 225664);
return return_v;
}


int
f_22006_225602_225665(Microsoft.CodeAnalysis.IPropertySymbol
expected,Microsoft.CodeAnalysis.ISymbol
actual)
{
Assert.Same( (object)expected, (object)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 225602, 225665);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_22006_225454_225473_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 225454, 225473);
return return_v;
}

}

int
f_22006_1163_1283(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 1163, 1283);
return 0;
}


int
f_22006_2978_3098(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 2978, 3098);
return 0;
}


int
f_22006_4843_4963(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 4843, 4963);
return 0;
}


int
f_22006_6707_6827(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 6707, 6827);
return 0;
}


int
f_22006_8574_8694(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 8574, 8694);
return 0;
}


int
f_22006_11059_11179(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 11059, 11179);
return 0;
}


int
f_22006_13547_13667(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 13547, 13667);
return 0;
}


int
f_22006_16207_16326(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 16207, 16326);
return 0;
}


int
f_22006_18230_18350(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 18230, 18350);
return 0;
}


int
f_22006_20283_20403(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 20283, 20403);
return 0;
}


int
f_22006_22339_22459(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 22339, 22459);
return 0;
}


int
f_22006_23761_23881(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 23761, 23881);
return 0;
}


int
f_22006_25190_25310(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 25190, 25310);
return 0;
}


int
f_22006_26639_26759(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 26639, 26759);
return 0;
}


int
f_22006_29139_29259(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 29139, 29259);
return 0;
}


int
f_22006_31863_31982(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 31863, 31982);
return 0;
}


int
f_22006_34428_34548(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 34428, 34548);
return 0;
}


int
f_22006_36436_36556(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 36436, 36556);
return 0;
}


int
f_22006_39061_39181(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 39061, 39181);
return 0;
}


int
f_22006_41413_41533(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 41413, 41533);
return 0;
}


int
f_22006_43850_43970(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 43850, 43970);
return 0;
}


int
f_22006_45953_46073(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 45953, 46073);
return 0;
}


int
f_22006_48876_48996(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 48876, 48996);
return 0;
}


int
f_22006_50941_51061(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 50941, 51061);
return 0;
}


int
f_22006_53838_53958(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 53838, 53958);
return 0;
}


int
f_22006_56101_56220(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 56101, 56220);
return 0;
}


int
f_22006_59041_59161(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 59041, 59161);
return 0;
}


int
f_22006_61936_62084(string
testSrc,string
expectedOperationTree,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, targetFramework, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 61936, 62084);
return 0;
}


int
f_22006_64880_65028(string
testSrc,string
expectedOperationTree,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, targetFramework, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 64880, 65028);
return 0;
}


int
f_22006_67709_67857(string
testSrc,string
expectedOperationTree,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, targetFramework, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 67709, 67857);
return 0;
}


int
f_22006_70694_70842(string
testSrc,string
expectedOperationTree,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, targetFramework, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 70694, 70842);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_72774_72856(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 72774, 72856);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_72774_72887(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 72774, 72887);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_72774_72907(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 72774, 72907);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_73080_73131(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73080, 73131);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_73080_73162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73080, 73162);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_73080_73182(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73080, 73182);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_73284_73329(string[]
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73284, 73329);
return return_v;
}


int
f_22006_73215_73379(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73215, 73379);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_73615_73666(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73615, 73666);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_73615_73697(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73615, 73697);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_73615_73717(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73615, 73717);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_73758_73784(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73758, 73784);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_22006_73758_73806(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73758, 73806);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_73890_73954(string[]
source,Microsoft.CodeAnalysis.CompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73890, 73954);
return return_v;
}


int
f_22006_73821_74000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 73821, 74000);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_74017_74081(string[]
source,Microsoft.CodeAnalysis.CompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 74017, 74081);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_74017_74125(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 74017, 74125);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_74984_75027(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 74984, 75027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_74984_75052(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 74984, 75052);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_74984_75072(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 74984, 75072);
return return_v;
}


int
f_22006_75104_75224(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 75104, 75224);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_76103_76149(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 76103, 76149);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_76103_76168(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 76103, 76168);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_76103_76188(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 76103, 76188);
return return_v;
}


int
f_22006_76220_76340(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 76220, 76340);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_77147_77188(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 77147, 77188);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_77147_77224(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 77147, 77224);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_77147_77244(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 77147, 77244);
return return_v;
}


int
f_22006_77276_77396(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 77276, 77396);
return 0;
}


int
f_22006_82799_82947(string
testSrc,string
expectedOperationTree,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, targetFramework, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 82799, 82947);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_85398_85456(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85398, 85456);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_85398_85487(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85398, 85487);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_85398_85507(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85398, 85507);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_85550_85595(string[]
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85550, 85595);
return return_v;
}


int
f_22006_85610_85734(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85610, 85734);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_85749_85797(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85749, 85797);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_85826_85852(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85826, 85852);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_85867_85916(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85867, 85916);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_22006_85992_86019(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85992, 86019);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_85945_86022(string
source,Microsoft.CodeAnalysis.CompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 85945, 86022);
return return_v;
}


int
f_22006_86037_86168(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 86037, 86168);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_86183_86238(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 86183, 86238);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_87628_87673(string[]
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 87628, 87673);
return return_v;
}


int
f_22006_87688_87818(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 87688, 87818);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_87833_87861(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 87833, 87861);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_87890_87916(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 87890, 87916);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_87931_87960(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 87931, 87960);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_22006_88036_88063(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 88036, 88063);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_87989_88066(string
source,Microsoft.CodeAnalysis.CompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 87989, 88066);
return return_v;
}


int
f_22006_88081_88212(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 88081, 88212);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_88227_88282(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 88227, 88282);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_89776_89821(string[]
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 89776, 89821);
return return_v;
}


int
f_22006_89836_89966(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 89836, 89966);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_89981_90009(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 89981, 90009);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_90038_90064(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 90038, 90064);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_90079_90108(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 90079, 90108);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_22006_90184_90211(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 90184, 90211);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_90137_90214(string
source,Microsoft.CodeAnalysis.CompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 90137, 90214);
return return_v;
}


int
f_22006_90229_90360(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 90229, 90360);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_90375_90430(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 90375, 90430);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_91783_91828(string[]
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 91783, 91828);
return return_v;
}


int
f_22006_91843_91973(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 91843, 91973);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_91988_92016(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 91988, 92016);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_92045_92071(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 92045, 92071);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_92086_92115(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 92086, 92115);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_22006_92191_92218(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 92191, 92218);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_92144_92221(string
source,Microsoft.CodeAnalysis.CompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 92144, 92221);
return return_v;
}


int
f_22006_92236_92367(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 92236, 92367);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_92382_92437(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 92382, 92437);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_93928_93973(string[]
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 93928, 93973);
return return_v;
}


int
f_22006_93988_94118(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 93988, 94118);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_94133_94161(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 94133, 94161);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_94190_94216(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 94190, 94216);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_94231_94260(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 94231, 94260);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_22006_94336_94363(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 94336, 94363);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_94289_94366(string
source,Microsoft.CodeAnalysis.CompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 94289, 94366);
return return_v;
}


int
f_22006_94381_94512(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 94381, 94512);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_94527_94582(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 94527, 94582);
return return_v;
}


int
f_22006_95991_96185(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 95991, 96185);
return 0;
}


int
f_22006_97598_97792(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 97598, 97792);
return 0;
}


int
f_22006_99834_100028(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 99834, 100028);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_101680_101734(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 101680, 101734);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_101680_101763(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 101680, 101763);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_101680_101784(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 101680, 101784);
return return_v;
}


int
f_22006_101816_102010(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 101816, 102010);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_103626_103680(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 103626, 103680);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_103626_103709(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 103626, 103709);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_103626_103730(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 103626, 103730);
return return_v;
}


int
f_22006_103762_103956(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 103762, 103956);
return 0;
}


int
f_22006_106139_106333(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 106139, 106333);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22006_106350_106416(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,string[]
source,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 106350, 106416);
return return_v;
}


int
f_22006_108735_108929(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 108735, 108929);
return 0;
}


int
f_22006_110266_110460(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 110266, 110460);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_22006_115198_115402(string
testSrc,string
ilSource,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
var return_v = VerifyOperationTreeAndDiagnosticsForTestWithIL<ElementAccessExpressionSyntax>( testSrc, ilSource, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 115198, 115402);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22006_115419_115508(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,string[]
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 115419, 115508);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22006_120249_120453(string
testSrc,string
ilSource,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
var return_v = VerifyOperationTreeAndDiagnosticsForTestWithIL<ElementAccessExpressionSyntax>( testSrc, ilSource, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 120249, 120453);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22006_120470_120559(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,string[]
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 120470, 120559);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22006_125295_125499(string
testSrc,string
ilSource,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,System.Action<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.SyntaxNode>
additionalOperationTreeVerifier)
{
var return_v = VerifyOperationTreeAndDiagnosticsForTestWithIL<ElementAccessExpressionSyntax>( testSrc, ilSource, expectedOperationTree, expectedDiagnostics, additionalOperationTreeVerifier:additionalOperationTreeVerifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 125295, 125499);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22006_125516_125605(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,string[]
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 125516, 125605);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_128107_128157(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 128107, 128157);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_128107_128188(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 128107, 128188);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_128107_128208(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 128107, 128208);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22006_128240_128370(string
testSrc,string
ilSource,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
var return_v = VerifyOperationTreeAndDiagnosticsForTestWithIL<InvocationExpressionSyntax>( testSrc, ilSource, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 128240, 128370);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130227_130283(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130227, 130283);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130227_130312(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130227, 130312);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130227_130332(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130227, 130332);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130508_130564(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130508, 130564);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130508_130596(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130508, 130596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130508_130616(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130508, 130616);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130795_130852(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130795, 130852);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130795_130887(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130795, 130887);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_130795_130907(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 130795, 130907);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131080_131136(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131080, 131136);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131080_131165(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131080, 131165);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131080_131185(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131080, 131185);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131332_131385(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131332, 131385);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131332_131416(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131332, 131416);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131332_131435(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131332, 131435);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131611_131667(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131611, 131667);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131611_131699(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131611, 131699);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131611_131719(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131611, 131719);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131894_131948(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131894, 131948);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131894_131979(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131894, 131979);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_131894_131999(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 131894, 131999);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_132150_132196(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 132150, 132196);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_132150_132225(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 132150, 132225);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_132150_132244(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 132150, 132244);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_132294_132372(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 132294, 132372);
return return_v;
}


int
f_22006_132387_132512(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 132387, 132512);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134378_134431(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134378, 134431);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134378_134462(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134378, 134462);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134378_134482(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134378, 134482);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134644_134700(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134644, 134700);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134644_134732(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134644, 134732);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134644_134751(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134644, 134751);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134916_134973(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134916, 134973);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134916_135008(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134916, 135008);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_134916_135027(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 134916, 135027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135186_135270(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135186, 135270);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135186_135299(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135186, 135299);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135186_135318(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135186, 135318);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135465_135518(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135465, 135518);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135465_135549(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135465, 135549);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135465_135568(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135465, 135568);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135731_135787(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135731, 135787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135731_135819(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135731, 135819);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_135731_135839(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 135731, 135839);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_136024_136077(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 136024, 136077);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_136024_136108(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 136024, 136108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_136024_136128(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 136024, 136128);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_136293_136339(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 136293, 136339);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_136293_136368(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 136293, 136368);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_136293_136387(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 136293, 136387);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_136437_136515(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 136437, 136515);
return return_v;
}


int
f_22006_136530_136659(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 136530, 136659);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139388_139443(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139388, 139443);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139388_139473(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139388, 139473);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139388_139493(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139388, 139493);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139671_139726(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139671, 139726);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139671_139756(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139671, 139756);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139671_139776(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139671, 139776);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139954_140009(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139954, 140009);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139954_140039(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139954, 140039);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_139954_140059(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 139954, 140059);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140237_140292(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140237, 140292);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140237_140322(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140237, 140322);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140237_140342(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140237, 140342);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140525_140581(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140525, 140581);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140525_140616(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140525, 140616);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140525_140636(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140525, 140636);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140806_140882(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140806, 140882);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140806_140911(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140806, 140911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_140806_140930(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 140806, 140930);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141082_141138(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141082, 141138);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141082_141167(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141082, 141167);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141082_141187(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141082, 141187);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141334_141387(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141334, 141387);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141334_141418(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141334, 141418);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141334_141437(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141334, 141437);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141615_141668(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141615, 141668);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141615_141698(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141615, 141698);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141615_141718(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141615, 141718);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141886_141939(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141886, 141939);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141886_141969(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141886, 141969);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_141886_141989(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 141886, 141989);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142171_142224(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142171, 142224);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142171_142254(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142171, 142254);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142171_142275(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142171, 142275);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142457_142510(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142457, 142510);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142457_142540(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142457, 142540);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142457_142561(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142457, 142561);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142712_142758(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142712, 142758);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142712_142787(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142712, 142787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_142712_142806(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142712, 142806);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_142856_142934(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142856, 142934);
return return_v;
}


int
f_22006_142949_143077(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 142949, 143077);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_144589_144645(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 144589, 144645);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_144589_144674(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 144589, 144674);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_144589_144694(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 144589, 144694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_144870_144926(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 144870, 144926);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_144870_144958(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 144870, 144958);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_144870_144978(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 144870, 144978);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145157_145214(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145157, 145214);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145157_145249(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145157, 145249);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145157_145269(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145157, 145269);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145442_145498(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145442, 145498);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145442_145527(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145442, 145527);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145442_145547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145442, 145547);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145694_145747(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145694, 145747);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145694_145778(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145694, 145778);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145694_145797(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145694, 145797);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145972_146026(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145972, 146026);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145972_146057(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145972, 146057);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_145972_146077(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 145972, 146077);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_146228_146274(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 146228, 146274);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_146228_146303(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 146228, 146303);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_146228_146322(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 146228, 146322);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_146372_146450(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 146372, 146450);
return return_v;
}


int
f_22006_146465_146590(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 146465, 146590);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148097_148150(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148097, 148150);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148097_148181(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148097, 148181);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148097_148200(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148097, 148200);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148358_148411(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148358, 148411);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148358_148442(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148358, 148442);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148358_148462(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148358, 148462);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148624_148680(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148624, 148680);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148624_148712(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148624, 148712);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148624_148731(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148624, 148731);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148896_148953(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148896, 148953);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148896_148988(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148896, 148988);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_148896_149007(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 148896, 149007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149166_149250(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149166, 149250);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149166_149279(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149166, 149279);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149166_149298(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149166, 149298);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149483_149536(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149483, 149536);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149483_149567(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149483, 149567);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149483_149587(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149483, 149587);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149752_149798(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149752, 149798);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149752_149827(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149752, 149827);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_149752_149846(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149752, 149846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_149896_149974(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149896, 149974);
return return_v;
}


int
f_22006_149989_150118(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 149989, 150118);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_152480_152522(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 152480, 152522);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_152480_152542(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 152480, 152542);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_152710_152765(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 152710, 152765);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_152710_152795(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 152710, 152795);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_152710_152815(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 152710, 152815);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_152996_153051(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 152996, 153051);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_152996_153081(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 152996, 153081);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_152996_153101(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 152996, 153101);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153282_153337(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153282, 153337);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153282_153367(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153282, 153367);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153282_153387(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153282, 153387);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153568_153623(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153568, 153623);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153568_153653(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153568, 153653);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153568_153673(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153568, 153673);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153859_153915(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153859, 153915);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153859_153950(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153859, 153950);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_153859_153970(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 153859, 153970);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154140_154216(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154140, 154216);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154140_154245(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154140, 154245);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154140_154264(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154140, 154264);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154416_154472(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154416, 154472);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154416_154501(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154416, 154501);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154416_154521(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154416, 154521);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154668_154721(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154668, 154721);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154668_154752(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154668, 154752);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154668_154771(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154668, 154771);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154939_154992(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154939, 154992);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154939_155022(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154939, 155022);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_154939_155042(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 154939, 155042);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155224_155277(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155224, 155277);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155224_155307(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155224, 155307);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155224_155328(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155224, 155328);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155510_155563(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155510, 155563);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155510_155593(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155510, 155593);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155510_155614(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155510, 155614);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155765_155811(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155765, 155811);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155765_155840(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155765, 155840);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_155765_155859(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155765, 155859);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_155909_155987(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 155909, 155987);
return return_v;
}


int
f_22006_156002_156130(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 156002, 156130);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_158165_158218(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158165, 158218);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_158165_158237(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158165, 158237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_158165_158257(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158165, 158257);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_158512_158570(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158512, 158570);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_158512_158596(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158512, 158596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_158512_158616(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158512, 158616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_158659_158684(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158659, 158684);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22006_158699_158782(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<InvocationExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158699, 158782);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_158797_158844(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 158797, 158844);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_160798_160851(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 160798, 160851);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_160798_160870(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 160798, 160870);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_160798_160890(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 160798, 160890);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_161114_161172(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 161114, 161172);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_161114_161198(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 161114, 161198);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_161114_161218(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 161114, 161218);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_161261_161286(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 161261, 161286);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22006_161301_161388(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 161301, 161388);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_161403_161450(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 161403, 161450);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_163685_163738(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 163685, 163738);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_163685_163757(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 163685, 163757);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_163685_163777(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 163685, 163777);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_164019_164077(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 164019, 164077);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_164019_164103(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 164019, 164103);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_164019_164123(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 164019, 164123);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_164166_164191(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 164166, 164191);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22006_164206_164292(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<ElementAccessExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 164206, 164292);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_164307_164354(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 164307, 164354);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_166597_166650(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 166597, 166650);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_166597_166669(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 166597, 166669);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_166597_166689(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 166597, 166689);
return return_v;
}


int
f_22006_166721_166841(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 166721, 166841);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_169080_169133(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 169080, 169133);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_169080_169152(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 169080, 169152);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_169080_169172(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 169080, 169172);
return return_v;
}


int
f_22006_169204_169324(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 169204, 169324);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_169703_169728(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 169703, 169728);
return return_v;
}


(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
f_22006_169773_169842(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = GetOperationAndSyntaxForTest<InvocationExpressionSyntax>( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 169773, 169842);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_22006_169937_169957(Microsoft.CodeAnalysis.Operations.IInvocationOperation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22006, 169937, 169957);
return return_v;
}


System.ArgumentException
f_22006_170092_170158(System.Func<object>
testCode)
{
var return_v = Assert.Throws<ArgumentException>( testCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 170092, 170158);
return return_v;
}


System.ArgumentException
f_22006_170173_170240(System.Func<object>
testCode)
{
var return_v = Assert.Throws<ArgumentException>( testCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 170173, 170240);
return return_v;
}


int
f_22006_171142_171250(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 171142, 171250);
return 0;
}


int
f_22006_172191_172299(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 172191, 172299);
return 0;
}


int
f_22006_173273_173381(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 173273, 173381);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_174491_174538(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 174491, 174538);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_174491_174557(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 174491, 174557);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_174491_174577(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 174491, 174577);
return return_v;
}


int
f_22006_174609_174717(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 174609, 174717);
return 0;
}


int
f_22006_176495_176614(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 176495, 176614);
return 0;
}


int
f_22006_178525_178644(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 178525, 178644);
return 0;
}


int
f_22006_179571_179679(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 179571, 179679);
return 0;
}


int
f_22006_180606_180714(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 180606, 180714);
return 0;
}


int
f_22006_181607_181715(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 181607, 181715);
return 0;
}


int
f_22006_182647_182755(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 182647, 182755);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_183850_183896(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 183850, 183896);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_183850_183915(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 183850, 183915);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_183850_183935(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 183850, 183935);
return return_v;
}


int
f_22006_183967_184075(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 183967, 184075);
return 0;
}


int
f_22006_185865_185984(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 185865, 185984);
return 0;
}


int
f_22006_187907_188026(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 187907, 188026);
return 0;
}


int
f_22006_188921_189029(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 188921, 189029);
return 0;
}


int
f_22006_190796_190919(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 190796, 190919);
return 0;
}


int
f_22006_192812_192935(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 192812, 192935);
return 0;
}


int
f_22006_193480_193589(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AttributeSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 193480, 193589);
return 0;
}


int
f_22006_194407_194524(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<AttributeArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 194407, 194524);
return 0;
}


int
f_22006_195412_195520(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ArgumentSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 195412, 195520);
return 0;
}


int
f_22006_197025_197181(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 197025, 197181);
return 0;
}


int
f_22006_198509_198665(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 198509, 198665);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_200272_200321(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 200272, 200321);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_200272_200350(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 200272, 200350);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_200272_200371(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 200272, 200371);
return return_v;
}


int
f_22006_200403_200527(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 200403, 200527);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_202140_202181(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 202140, 202181);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_202140_202217(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 202140, 202217);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_202140_202238(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 202140, 202238);
return return_v;
}


int
f_22006_202270_202394(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 202270, 202394);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_205912_205967(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 205912, 205967);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_205912_205997(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 205912, 205997);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_205912_206017(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 205912, 206017);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206195_206250(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206195, 206250);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206195_206280(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206195, 206280);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206195_206300(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206195, 206300);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206478_206533(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206478, 206533);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206478_206563(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206478, 206563);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206478_206583(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206478, 206583);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206761_206816(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206761, 206816);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206761_206846(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206761, 206846);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_206761_206866(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 206761, 206866);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207049_207105(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207049, 207105);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207049_207140(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207049, 207140);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207049_207160(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207049, 207160);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207330_207406(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207330, 207406);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207330_207435(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207330, 207435);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207330_207454(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207330, 207454);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207605_207658(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207605, 207658);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207605_207689(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207605, 207689);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207605_207709(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207605, 207709);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207856_207909(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207856, 207909);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207856_207940(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207856, 207940);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_207856_207959(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 207856, 207959);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208137_208190(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208137, 208190);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208137_208220(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208137, 208220);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208137_208240(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208137, 208240);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208408_208461(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208408, 208461);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208408_208491(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208408, 208491);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208408_208511(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208408, 208511);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208709_208762(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208709, 208762);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208709_208793(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208709, 208793);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_208709_208814(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 208709, 208814);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209011_209064(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209011, 209064);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209011_209094(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209011, 209094);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209011_209115(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209011, 209115);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209312_209365(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209312, 209365);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209312_209395(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209312, 209395);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209312_209416(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209312, 209416);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209612_209665(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209612, 209665);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209612_209694(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209612, 209694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209612_209715(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209612, 209715);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209866_209912(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209866, 209912);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209866_209941(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209866, 209941);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_209866_209960(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 209866, 209960);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_210010_210088(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 210010, 210088);
return return_v;
}


int
f_22006_210103_210232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 210103, 210232);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213369_213424(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213369, 213424);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213369_213454(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213369, 213454);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213369_213474(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213369, 213474);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213655_213710(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213655, 213710);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213655_213740(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213655, 213740);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213655_213760(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213655, 213760);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213941_213996(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213941, 213996);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213941_214026(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213941, 214026);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_213941_214046(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 213941, 214046);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214227_214282(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214227, 214282);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214227_214312(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214227, 214312);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214227_214332(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214227, 214332);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214518_214574(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214518, 214574);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214518_214609(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214518, 214609);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214518_214629(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214518, 214629);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214799_214875(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214799, 214875);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214799_214904(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214799, 214904);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_214799_214923(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 214799, 214923);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215074_215127(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215074, 215127);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215074_215158(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215074, 215158);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215074_215178(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215074, 215178);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215325_215378(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215325, 215378);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215325_215409(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215325, 215409);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215325_215428(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215325, 215428);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215596_215649(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215596, 215649);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215596_215679(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215596, 215679);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215596_215699(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215596, 215699);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215897_215950(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215897, 215950);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215897_215981(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215897, 215981);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_215897_216002(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 215897, 216002);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216199_216252(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216199, 216252);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216199_216282(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216199, 216282);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216199_216303(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216199, 216303);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216500_216553(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216500, 216553);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216500_216583(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216500, 216583);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216500_216604(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216500, 216604);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216800_216853(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216800, 216853);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216800_216882(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216800, 216882);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_216800_216903(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 216800, 216903);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_217054_217100(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 217054, 217100);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_217054_217129(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 217054, 217129);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_217054_217148(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 217054, 217148);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_217198_217276(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 217198, 217276);
return return_v;
}


int
f_22006_217291_217420(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 217291, 217420);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_220399_220452(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 220399, 220452);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_220399_220471(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 220399, 220471);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_220399_220491(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 220399, 220491);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_220729_220787(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 220729, 220787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_220729_220813(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 220729, 220813);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_220729_220833(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 220729, 220833);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_220876_220901(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 220876, 220901);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22006_220916_221003(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<ObjectCreationExpressionSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 220916, 221003);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_221018_221065(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 221018, 221065);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_222881_222942(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 222881, 222942);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_222881_222973(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 222881, 222973);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_222881_222993(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 222881, 222993);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_223036_223061(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 223036, 223061);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22006_223076_223148(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOperationTree)
{
var return_v = VerifyOperationTreeForTest<StatementSyntax>( compilation, expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 223076, 223148);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22006_223163_223210(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 223163, 223210);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_224165_224213(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 224165, 224213);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_224165_224233(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 224165, 224233);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22006_224165_224253(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 224165, 224253);
return return_v;
}


int
f_22006_224285_224441(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,bool
useLatestFrameworkReferences)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, useLatestFrameworkReferences:useLatestFrameworkReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22006, 224285, 224441);
return 0;
}

}
}
