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
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void NoInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,574,1443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,762,848);

var 
source = @"
class C
{
    static int s1;
    int i1;
    int P1 { get; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,864,976);

var 
compilation = f_22066_882_975(source, options: TestOptions.ReleaseDll, parseOptions: TestOptions.Regular)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,992,1036);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,1050,1182);

var 
nodes = f_22066_1062_1181(f_22066_1062_1171(f_22066_1062_1094(f_22066_1062_1076(tree)), n => n is VariableDeclarationSyntax || n is PropertyDeclarationSyntax))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,1196,1226);

f_22066_1196_1225(3, f_22066_1212_1224(nodes));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,1242,1297);

var 
semanticModel = f_22066_1262_1296(compilation, tree)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,1311,1432);
foreach(var node in f_22066_1332_1337_I(nodes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(22066,1311,1432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,1371,1417);

f_22066_1371_1416(f_22066_1383_1415(semanticModel, node));
DynAbs.Tracing.TraceSender.TraceExitCondition(22066,1311,1432);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(22066,1,122);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(22066,1,122);
}DynAbs.Tracing.TraceSender.TraceExitMethod(22066,574,1443);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,574,1443);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,574,1443);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void ConstantInitializers_StaticField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,1455,2494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,1661,1743);

string 
source = @"
class C
{
    static int s1 /*<bind>*/= 1/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,1757,2002);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Int32 C.s1) (OperationKind.FieldInitializer, Type: null) (Syntax: '= 1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,2016,2349);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_2238_2333(f_22066_2238_2313(f_22066_2238_2291(ErrorCode.WRN_UnreferencedFieldAssg, "s1"), "C.s1"), 4, 16)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,2365,2483);

f_22066_2365_2482(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,1455,2494);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,1455,2494);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,1455,2494);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void ConstantInitializers_InstanceField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,2506,3812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,2714,2797);

string 
source = @"
class C
{
    int i1 = 1, i2 /*<bind>*/= 2/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,2811,3056);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Int32 C.i2) (OperationKind.FieldInitializer, Type: null) (Syntax: '= 2')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,3070,3667);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_3293_3388(f_22066_3293_3368(f_22066_3293_3346(ErrorCode.WRN_UnreferencedFieldAssg, "i2"), "C.i2"), 4, 17),
f_22066_3557_3651(f_22066_3557_3632(f_22066_3557_3610(ErrorCode.WRN_UnreferencedFieldAssg, "i1"), "C.i1"), 4, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,3683,3801);

f_22066_3683_3800(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,2506,3812);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,2506,3812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,2506,3812);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void ConstantInitializers_Property()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,3824,4600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,4027,4111);

string 
source = @"
class C
{
    int P1 { get; } /*<bind>*/= 1/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,4125,4388);

string 
expectedOperationTree = @"
IPropertyInitializerOperation (Property: System.Int32 C.P1 { get; }) (OperationKind.PropertyInitializer, Type: null) (Syntax: '= 1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,4402,4455);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,4471,4589);

f_22066_4471_4588(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,3824,4600);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,3824,4600);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,3824,4600);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void ConstantInitializers_DefaultValueParameter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,4612,5720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,4828,4938);

string 
source = @"
class C
{
    void M(int p1 /*<bind>*/= 0/*</bind>*/, params int[] p2 = null) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,4952,5213);

string 
expectedOperationTree = @"
IParameterInitializerOperation (Parameter: [System.Int32 p1 = 0]) (OperationKind.ParameterInitializer, Type: null) (Syntax: '= 0')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,5227,5575);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_5473_5559(f_22066_5473_5539(ErrorCode.ERR_DefaultValueForParamsParameter, "params"), 4, 45)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,5591,5709);

f_22066_5591_5708(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,4612,5720);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,4612,5720);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,4612,5720);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void ConstantInitializers_DefaultValueParamsArray()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,5732,7159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,5950,6060);

string 
source = @"
class C
{
    void M(int p1 = 0, params int[] p2 /*<bind>*/= null/*</bind>*/) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,6074,6652);

string 
expectedOperationTree = @"
IParameterInitializerOperation (Parameter: params System.Int32[] p2) (OperationKind.ParameterInitializer, Type: null) (Syntax: '= null')
  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32[], Constant: null, IsImplicit) (Syntax: 'null')
    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
    Operand: 
      ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,6666,7014);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_6912_6998(f_22066_6912_6978(ErrorCode.ERR_DefaultValueForParamsParameter, "params"), 4, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,7030,7148);

f_22066_7030_7147(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,5732,7159);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,5732,7159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,5732,7159);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void ExpressionInitializers_StaticField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,7171,8296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,7379,7503);

string 
source = @"
class C
{
    static int s1 /*<bind>*/= 1 + F()/*</bind>*/;

    static int F() { return 1; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,7517,8084);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Int32 C.s1) (OperationKind.FieldInitializer, Type: null) (Syntax: '= 1 + F()')
  IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: '1 + F()')
    Left: 
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
    Right: 
      IInvocationOperation (System.Int32 C.F()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'F()')
        Instance Receiver: 
          null
        Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,8098,8151);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,8167,8285);

f_22066_8167_8284(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,7171,8296);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,7171,8296);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,7171,8296);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void ExpressionInitializers_InstanceField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,8308,9490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,8518,8697);

string 
source = @"
class C
{
    static int s1 /*<bind>*/= 1 + F()/*</bind>*/;
    int i1 = 1 + F();
    int P1 { get; } = 1 + F();

    static int F() { return 1; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,8711,9278);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Int32 C.s1) (OperationKind.FieldInitializer, Type: null) (Syntax: '= 1 + F()')
  IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: '1 + F()')
    Left: 
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
    Right: 
      IInvocationOperation (System.Int32 C.F()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'F()')
        Instance Receiver: 
          null
        Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,9292,9345);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,9361,9479);

f_22066_9361_9478(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,8308,9490);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,8308,9490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,8308,9490);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void ExpressionInitializers_Property()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,9502,10617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,9707,9824);

string 
source = @"
class C
{
    int i1 /*<bind>*/= 1 + F()/*</bind>*/;

    static int F() { return 1; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,9838,10405);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Int32 C.i1) (OperationKind.FieldInitializer, Type: null) (Syntax: '= 1 + F()')
  IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: '1 + F()')
    Left: 
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
    Right: 
      IInvocationOperation (System.Int32 C.F()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'F()')
        Instance Receiver: 
          null
        Arguments(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,10419,10472);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,10488,10606);

f_22066_10488_10605(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,9502,10617);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,9502,10617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,9502,10617);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void PartialClasses_StaticField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,10629,12465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,10829,11002);

string 
source = @"
partial class C
{
    static int s1 /*<bind>*/= 1/*</bind>*/;
    int i1 = 1;
}

partial class C
{
    static int s2 = 2;
    int i2 = 2;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,11016,11261);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Int32 C.s1) (OperationKind.FieldInitializer, Type: null) (Syntax: '= 1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,11275,12320);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_11469_11563(f_22066_11469_11544(f_22066_11469_11522(ErrorCode.WRN_UnreferencedFieldAssg, "i1"), "C.i1"), 5, 9),
f_22066_11710_11806(f_22066_11710_11785(f_22066_11710_11763(ErrorCode.WRN_UnreferencedFieldAssg, "s2"), "C.s2"), 10, 16),
f_22066_11974_12069(f_22066_11974_12049(f_22066_11974_12027(ErrorCode.WRN_UnreferencedFieldAssg, "s1"), "C.s1"), 4, 16),
f_22066_12209_12304(f_22066_12209_12284(f_22066_12209_12262(ErrorCode.WRN_UnreferencedFieldAssg, "i2"), "C.i2"), 11, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,12336,12454);

f_22066_12336_12453(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,10629,12465);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,10629,12465);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,10629,12465);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void PartialClasses_InstanceField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,12477,14315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,12679,12852);

string 
source = @"
partial class C
{
    static int s1 = 1;
    int i1 = 1;
}

partial class C
{
    static int s2 = 2;
    int i2 /*<bind>*/= 2/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,12866,13111);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Int32 C.i2) (OperationKind.FieldInitializer, Type: null) (Syntax: '= 2')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,13125,14170);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_13326_13422(f_22066_13326_13401(f_22066_13326_13379(ErrorCode.WRN_UnreferencedFieldAssg, "s2"), "C.s2"), 10, 16),
f_22066_13583_13678(f_22066_13583_13658(f_22066_13583_13636(ErrorCode.WRN_UnreferencedFieldAssg, "i2"), "C.i2"), 11, 9),
f_22066_13825_13920(f_22066_13825_13900(f_22066_13825_13878(ErrorCode.WRN_UnreferencedFieldAssg, "s1"), "C.s1"), 4, 16),
f_22066_14060_14154(f_22066_14060_14135(f_22066_14060_14113(ErrorCode.WRN_UnreferencedFieldAssg, "i1"), "C.i1"), 5, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,14186,14304);

f_22066_14186_14303(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,12477,14315);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,12477,14315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,12477,14315);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void Events_StaticField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,14327,15820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,14519,14691);

string 
source = @"
class C
{
    static event System.Action e /*<bind>*/= MakeAction(1)/*</bind>*/;

    static System.Action MakeAction(int x) { return null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,14705,15608);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Action C.e) (OperationKind.FieldInitializer, Type: null) (Syntax: '= MakeAction(1)')
  IInvocationOperation (System.Action C.MakeAction(System.Int32 x)) (OperationKind.Invocation, Type: System.Action) (Syntax: 'MakeAction(1)')
    Instance Receiver: 
      null
    Arguments(1):
        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '1')
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,15622,15675);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,15691,15809);

f_22066_15691_15808(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,14327,15820);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,14327,15820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,14327,15820);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17595, "https://github.com/dotnet/roslyn/issues/17595")]
        public void Events_InstanceField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,15832,17320);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,16026,16191);

string 
source = @"
class C
{
    event System.Action f /*<bind>*/= MakeAction(2)/*</bind>*/;

    static System.Action MakeAction(int x) { return null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,16205,17108);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Action C.f) (OperationKind.FieldInitializer, Type: null) (Syntax: '= MakeAction(2)')
  IInvocationOperation (System.Action C.MakeAction(System.Int32 x)) (OperationKind.Invocation, Type: System.Action) (Syntax: 'MakeAction(2)')
    Instance Receiver: 
      null
    Arguments(1):
        IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: '2')
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
          InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
          OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,17122,17175);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,17191,17309);

f_22066_17191_17308(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,15832,17320);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,15832,17320);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,15832,17320);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(7299, "https://github.com/dotnet/roslyn/issues/7299")]
        public void FieldInitializer_ConstantConversions_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,17332,19092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,17543,17629);

string 
source = @"
class C
{
    private float f /*<bind>*/= 0.0/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,17643,18234);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Single C.f) (OperationKind.FieldInitializer, Type: null, IsInvalid) (Syntax: '= 0.0')
  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Single, Constant: 0, IsInvalid, IsImplicit) (Syntax: '0.0')
    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    Operand: 
      ILiteralOperation (OperationKind.Literal, Type: System.Double, Constant: 0, IsInvalid) (Syntax: '0.0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,18248,18947);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_18553_18651(f_22066_18553_18631(f_22066_18553_18603(ErrorCode.ERR_LiteralDoubleCast, "0.0"), "F", "float"), 4, 33),
f_22066_18838_18931(f_22066_18838_18911(f_22066_18838_18890(ErrorCode.WRN_UnreferencedFieldAssg, "f"), "C.f"), 4, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,18963,19081);

f_22066_18963_19080(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,17332,19092);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,17332,19092);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,17332,19092);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(7299, "https://github.com/dotnet/roslyn/issues/7299")]
        public void FieldInitializer_ConstantConversions_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,19104,20471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,19315,19399);

string 
source = @"
class C
{
    private float f /*<bind>*/= 0/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,19413,19964);

string 
expectedOperationTree = @"
IFieldInitializerOperation (Field: System.Single C.f) (OperationKind.FieldInitializer, Type: null) (Syntax: '= 0')
  IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Single, Constant: 0, IsImplicit) (Syntax: '0')
    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: True, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
    Operand: 
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,19978,20326);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_20217_20310(f_22066_20217_20290(f_22066_20217_20269(ErrorCode.WRN_UnreferencedFieldAssg, "f"), "C.f"), 4, 19)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,20342,20460);

f_22066_20342_20459(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,19104,20471);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,19104,20471);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,19104,20471);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_ConstantInitializer_NonConstantField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,20483,21691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,20667,20756);

string 
source = @"
class C
{
    public static int s1 /*<bind>*/= 1/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,20770,21487);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= 1')
          Left: 
            IFieldReferenceOperation: System.Int32 C.s1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= 1')
              Instance Receiver: 
                null
          Right: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,21501,21554);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,21570,21680);

f_22066_21570_21679(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,20483,21691);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,20483,21691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,20483,21691);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_ConstantInitializer_ConstantField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,21703,22907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,21884,21972);

string 
source = @"
class C
{
    public const int c1 /*<bind>*/= 1/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,21986,22703);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= 1')
          Left: 
            IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= 1')
              Instance Receiver: 
                null
          Right: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,22717,22770);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,22786,22896);

f_22066_22786_22895(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,21703,22907);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,21703,22907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,21703,22907);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantInitializer_NonConstantStaticField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,22919,24386);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,23194,23346);

string 
source = @"
class C
{
    public static int s = 0, s1 /*<bind>*/= M()/*</bind>*/, s2;
    public static int M() { s2 = s; return s2; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,23360,24182);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M()')
          Left: 
            IFieldReferenceOperation: System.Int32 C.s1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= M()')
              Instance Receiver: 
                null
          Right: 
            IInvocationOperation (System.Int32 C.M()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M()')
              Instance Receiver: 
                null
              Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,24196,24249);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,24265,24375);

f_22066_24265_24374(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,22919,24386);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,22919,24386);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,22919,24386);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantInitializer_NonConstantInstanceField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,24398,25877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,24593,24710);

string 
source = @"
class C
{
    public int s1 /*<bind>*/= M()/*</bind>*/;
    public static int M() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,24724,25673);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M()')
          Left: 
            IFieldReferenceOperation: System.Int32 C.s1 (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= M()')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= M()')
          Right: 
            IInvocationOperation (System.Int32 C.M()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M()')
              Instance Receiver: 
                null
              Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,25687,25740);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,25756,25866);

f_22066_25756_25865(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,24398,25877);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,24398,25877);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,24398,25877);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantInitializer_ConstantField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,25889,27579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,26073,26196);

string 
source = @"
class C
{
    public const int c1 /*<bind>*/= M()/*</bind>*/;
    public static int M() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,26210,27065);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M()')
          Left: 
            IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M()')
              Instance Receiver: 
                null
          Right: 
            IInvocationOperation (System.Int32 C.M()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M()')
              Instance Receiver: 
                null
              Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,27079,27442);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_27330_27426(f_22066_27330_27406(f_22066_27330_27384(ErrorCode.ERR_NotConstantExpression, "M()"), "C.c1"), 4, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,27458,27568);

f_22066_27458_27567(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,25889,27579);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,25889,27579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,25889,27579);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantInitializer_FieldLikeEvent()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,27591,28968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,27776,27924);

string 
source = @"
class C
{
    static event System.Action e /*<bind>*/= M()/*</bind>*/;

    static System.Action M() { return null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,27938,28764);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action, IsImplicit) (Syntax: '= M()')
          Left: 
            IFieldReferenceOperation: System.Action C.e (Static) (OperationKind.FieldReference, Type: System.Action, IsImplicit) (Syntax: '= M()')
              Instance Receiver: 
                null
          Right: 
            IInvocationOperation (System.Action C.M()) (OperationKind.Invocation, Type: System.Action) (Syntax: 'M()')
              Instance Receiver: 
                null
              Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,28778,28831);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,28847,28957);

f_22066_28847_28956(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,27591,28968);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,27591,28968);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,27591,28968);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_ConstantInitializer_ConstantField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,28980,31381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,29159,29258);

string 
source = @"
class C
{
    public const int c1 /*<bind>*/= true ? 1 : 2/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,29272,31177);

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
        Statements (0)
        Jump if False (Regular) to Block[B3]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
    Block[B3] - Block [UnReachable]
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= true ? 1 : 2')
              Left: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= true ? 1 : 2')
                  Instance Receiver: 
                    null
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'true ? 1 : 2')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,31191,31244);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,31260,31370);

f_22066_31260_31369(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,28980,31381);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,28980,31381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,28980,31381);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantInitializer_NonConstantStaticField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,31393,34961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,31584,31751);

string 
source = @"
class C
{
    public static int s1 /*<bind>*/= M() ?? M2()/*</bind>*/;
    public static int? M() => 0;
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,31765,34757);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation (System.Int32? C.M()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'M()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'M()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'M()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M()')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M() ?? M2()')
              Left: 
                IFieldReferenceOperation: System.Int32 C.s1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= M() ?? M2()')
                  Instance Receiver: 
                    null
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'M() ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,34771,34824);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,34840,34950);

f_22066_34840_34949(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,31393,34961);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,31393,34961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,31393,34961);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantInitializer_NonConstantInstanceField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,34973,38671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,35166,35326);

string 
source = @"
class C
{
    public int s1 /*<bind>*/= M() ?? M2()/*</bind>*/;
    public static int? M() => 0;
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,35340,38467);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation (System.Int32? C.M()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'M()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'M()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'M()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M()')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M() ?? M2()')
              Left: 
                IFieldReferenceOperation: System.Int32 C.s1 (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= M() ?? M2()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= M() ?? M2()')
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'M() ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,38481,38534);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,38550,38660);

f_22066_38550_38659(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,34973,38671);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,34973,38671);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,34973,38671);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantInitializer_ConstantField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,38683,42699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,38865,39031);

string 
source = @"
class C
{
    public const int c1 /*<bind>*/= M() ?? M2()/*</bind>*/;
    public static int? M() => 0;
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,39045,42169);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation (System.Int32? C.M()) (OperationKind.Invocation, Type: System.Int32?, IsInvalid) (Syntax: 'M()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'M()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'M()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'M()')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M() ?? M2()')
              Left: 
                IFieldReferenceOperation: System.Int32 C.c1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M() ?? M2()')
                  Instance Receiver: 
                    null
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M() ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,42183,42562);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_42442_42546(f_22066_42442_42526(f_22066_42442_42504(ErrorCode.ERR_NotConstantExpression, "M() ?? M2()"), "C.c1"), 4, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,42578,42688);

f_22066_42578_42687(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,38683,42699);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,38683,42699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,38683,42699);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantFieldInitializerWithLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,42711,45261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,42896,43078);

string 
source = @"
class C
{
    public int s1 /*<bind>*/= M(out int local)/*</bind>*/;
    public static int M(out int x)
    {
        x = 0;
        return 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,43092,45057);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 local]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M(out int local)')
              Left: 
                IFieldReferenceOperation: System.Int32 C.s1 (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= M(out int local)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= M(out int local)')
              Right: 
                IInvocationOperation (System.Int32 C.M(out System.Int32 x)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M(out int local)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out int local')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int local')
                          ILocalReferenceOperation: local (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'local')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,45071,45124);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,45140,45250);

f_22066_45140_45249(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,42711,45261);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,42711,45261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,42711,45261);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantFieldInitializerWithLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,45273,50025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,45456,45681);

string 
source = @"
class C
{
    public int s1 /*<bind>*/= M(out int local) ?? M2()/*</bind>*/;
    public static int? M(out int x)
    {
        x = 0;
        return 0;
    }
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,45695,49821);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32 local]
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M(out int local)')
                  Value: 
                    IInvocationOperation (System.Int32? C.M(out System.Int32 x)) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'M(out int local)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out int local')
                            IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int local')
                              ILocalReferenceOperation: local (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'local')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'M(out int local)')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M(out int local)')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M(out int local)')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'M(out int local)')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M(out int local)')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M(out int ... al) ?? M2()')
              Left: 
                IFieldReferenceOperation: System.Int32 C.s1 (OperationKind.FieldReference, Type: System.Int32, IsImplicit) (Syntax: '= M(out int ... al) ?? M2()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= M(out int ... al) ?? M2()')
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'M(out int local) ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,49835,49888);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,49904,50014);

f_22066_49904_50013(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,45273,50025);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,45273,50025);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,45273,50025);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_MissingFieldInitializerValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,50037,51694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,50213,50294);

string 
source = @"
class C
{
    public int s1 /*<bind>*/= /*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,50308,51229);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= /*</bind>*/')
          Left: 
            IFieldReferenceOperation: System.Int32 C.s1 (OperationKind.FieldReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= /*</bind>*/')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: '= /*</bind>*/')
          Right: 
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,51243,51557);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_51456_51541(f_22066_51456_51521(f_22066_51456_51502(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 4, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,51573,51683);

f_22066_51573_51682(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,50037,51694);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,50037,51694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,50037,51694);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_ConstantPropertyInitializer_StaticProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,51706,52944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,51896,51994);

string 
source = @"
class C
{
    public static int P1 { get; } /*<bind>*/= 1/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,52008,52740);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= 1')
          Left: 
            IPropertyReferenceOperation: System.Int32 C.P1 { get; } (Static) (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: '= 1')
              Instance Receiver: 
                null
          Right: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,52754,52807);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,52823,52933);

f_22066_52823_52932(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,51706,52944);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,51706,52944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,51706,52944);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_ConstantPropertyInitializer_InstanceProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,52956,54314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,53148,53239);

string 
source = @"
class C
{
    public int P1 { get; } /*<bind>*/= 1/*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,53253,54110);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= 1')
          Left: 
            IPropertyReferenceOperation: System.Int32 C.P1 { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: '= 1')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= 1')
          Right: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,54124,54177);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,54193,54303);

f_22066_54193_54302(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,52956,54314);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,52956,54314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,52956,54314);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantPropertyInitializer_StaticProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,54326,55707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,54519,54652);

string 
source = @"
class C
{
    public static int P1 { get; } /*<bind>*/= M()/*</bind>*/;
    public static int M() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,54666,55503);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M()')
          Left: 
            IPropertyReferenceOperation: System.Int32 C.P1 { get; } (Static) (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: '= M()')
              Instance Receiver: 
                null
          Right: 
            IInvocationOperation (System.Int32 C.M()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M()')
              Instance Receiver: 
                null
              Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,55517,55570);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,55586,55696);

f_22066_55586_55695(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,54326,55707);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,54326,55707);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,54326,55707);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantPropertyInitializer_InstanceProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,55719,57222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,55914,56040);

string 
source = @"
class C
{
    public int P1 { get; } /*<bind>*/= M()/*</bind>*/;
    public static int M() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,56054,57018);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M()')
          Left: 
            IPropertyReferenceOperation: System.Int32 C.P1 { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: '= M()')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= M()')
          Right: 
            IInvocationOperation (System.Int32 C.M()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M()')
              Instance Receiver: 
                null
              Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,57032,57085);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,57101,57211);

f_22066_57101_57210(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,55719,57222);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,55719,57222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,55719,57222);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantPropertyInitializer_StaticProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,57234,60826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,57425,57601);

string 
source = @"
class C
{
    public static int P1 { get; } /*<bind>*/= M() ?? M2()/*</bind>*/;
    public static int? M() => 0;
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,57615,60622);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation (System.Int32? C.M()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'M()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'M()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'M()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M()')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M() ?? M2()')
              Left: 
                IPropertyReferenceOperation: System.Int32 C.P1 { get; } (Static) (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: '= M() ?? M2()')
                  Instance Receiver: 
                    null
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'M() ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,60636,60689);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,60705,60815);

f_22066_60705_60814(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,57234,60826);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,57234,60826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,57234,60826);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantPropertyInitializer_InstanceProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,60838,64560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,61031,61200);

string 
source = @"
class C
{
    public int P1 { get; } /*<bind>*/= M() ?? M2()/*</bind>*/;
    public static int? M() => 0;
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,61214,64356);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation (System.Int32? C.M()) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'M()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'M()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M()')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'M()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M()')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M() ?? M2()')
              Left: 
                IPropertyReferenceOperation: System.Int32 C.P1 { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: '= M() ?? M2()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= M() ?? M2()')
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'M() ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,64370,64423);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,64439,64549);

f_22066_64439_64548(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,60838,64560);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,60838,64560);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,60838,64560);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantPropertyInitializerWithLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,64572,67149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,64760,64951);

string 
source = @"
class C
{
    public int P1 { get; } /*<bind>*/= M(out int local)/*</bind>*/;
    public static int M(out int x)
    {
        x = 0;
        return 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,64965,66945);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 local]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M(out int local)')
              Left: 
                IPropertyReferenceOperation: System.Int32 C.P1 { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: '= M(out int local)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= M(out int local)')
              Right: 
                IInvocationOperation (System.Int32 C.M(out System.Int32 x)) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M(out int local)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out int local')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int local')
                          ILocalReferenceOperation: local (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'local')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,66959,67012);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,67028,67138);

f_22066_67028_67137(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,64572,67149);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,64572,67149);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,64572,67149);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantPropertyInitializerWithLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,67161,71940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,67347,67581);

string 
source = @"
class C
{
    public int P1 { get; } /*<bind>*/= M(out int local) ?? M2()/*</bind>*/;
    public static int? M(out int x)
    {
        x = 0;
        return 0;
    }
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,67595,71736);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32 local]
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M(out int local)')
                  Value: 
                    IInvocationOperation (System.Int32? C.M(out System.Int32 x)) (OperationKind.Invocation, Type: System.Int32?) (Syntax: 'M(out int local)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out int local')
                            IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int local')
                              ILocalReferenceOperation: local (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'local')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'M(out int local)')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M(out int local)')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M(out int local)')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'M(out int local)')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'M(out int local)')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= M(out int ... al) ?? M2()')
              Left: 
                IPropertyReferenceOperation: System.Int32 C.P1 { get; } (OperationKind.PropertyReference, Type: System.Int32, IsImplicit) (Syntax: '= M(out int ... al) ?? M2()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '= M(out int ... al) ?? M2()')
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'M(out int local) ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,71750,71803);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,71819,71929);

f_22066_71819_71928(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,67161,71940);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,67161,71940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,67161,71940);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_MissingPropertyInitializerValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,71952,73645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,72131,72221);

string 
source = @"
class C
{
    public int P1 { get; } /*<bind>*/= /*</bind>*/;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,72235,73171);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= /*</bind>*/')
          Left: 
            IPropertyReferenceOperation: System.Int32 C.P1 { get; } (OperationKind.PropertyReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= /*</bind>*/')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: '= /*</bind>*/')
          Right: 
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,73185,73508);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_73407_73492(f_22066_73407_73472(f_22066_73407_73453(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 4, 51)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,73524,73634);

f_22066_73524_73633(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,71952,73645);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,71952,73645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,71952,73645);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_ConstantParameterInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,73657,74786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,73833,73925);

string 
source = @"
class C
{
    public void M(int x /*<bind>*/= 1/*</bind>*/) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,73939,74582);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: '= 1')
          Left: 
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsImplicit) (Syntax: '= 1')
          Right: 
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,74596,74649);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,74665,74775);

f_22066_74665_74774(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,73657,74786);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,73657,74786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,73657,74786);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantParameterInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,74798,76434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,74977,75106);

string 
source = @"
class C
{
    public void M(int x /*<bind>*/= M2()/*</bind>*/) { }
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,75120,75905);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M2()')
          Left: 
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M2()')
          Right: 
            IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2()')
              Instance Receiver: 
                null
              Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,75919,76297);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_76182_76281(f_22066_76182_76261(f_22066_76182_76242(ErrorCode.ERR_DefaultValueMustBeConstant, "M2()"), "x"), 4, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,76313,76423);

f_22066_76313_76422(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,74798,76434);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,74798,76434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,74798,76434);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantParameterInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,76446,80407);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,76623,76795);

string 
source = @"
class C
{
    public void M(int x /*<bind>*/= M1() ?? M2()/*</bind>*/) { }
    public static int? M1() => 0;
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,76809,79862);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M1()')
                  Value: 
                    IInvocationOperation (System.Int32? C.M1()) (OperationKind.Invocation, Type: System.Int32?, IsInvalid) (Syntax: 'M1()')
                      Instance Receiver: 
                        null
                      Arguments(0)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'M1()')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'M1()')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M1()')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M1()')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'M1()')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M1() ?? M2()')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M1() ?? M2()')
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M1() ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,79876,80270);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_80147_80254(f_22066_80147_80234(f_22066_80147_80215(ErrorCode.ERR_DefaultValueMustBeConstant, "M1() ?? M2()"), "x"), 4, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,80286,80396);

f_22066_80286_80395(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,76446,80407);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,76446,80407);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,76446,80407);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_NonConstantParameterInitializerWithLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,80419,83184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,80608,80802);

string 
source = @"
class C
{
    public void M(int x /*<bind>*/= M1(out int local)/*</bind>*/) { }
    public static int M1(out int x)
    {
        x = 0;
        return 0;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,80816,82629);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 local]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M1(out int local)')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M1(out int local)')
              Right: 
                IInvocationOperation (System.Int32 C.M1(out System.Int32 x)) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M1(out int local)')
                  Instance Receiver: 
                    null
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out int local')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'int local')
                          ILocalReferenceOperation: local (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'local')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,82643,83047);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_82919_83031(f_22066_82919_83011(f_22066_82919_82992(ErrorCode.ERR_DefaultValueMustBeConstant, "M1(out int local)"), "x"), 4, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,83063,83173);

f_22066_83063_83172(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,80419,83184);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,80419,83184);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,80419,83184);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void ControlFlow_NonConstantParameterInitializerWithLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,83196,88276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,83383,83620);

string 
source = @"
class C
{
    public void M(int x /*<bind>*/= M1(out int local) ?? M2()/*</bind>*/) { }
    public static int? M1(out int x)
    {
        x = 0;
        return 0;
    }
    public static int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,83634,87705);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1} {R2}

.locals {R1}
{
    Locals: [System.Int32 local]
    CaptureIds: [1]
    .locals {R2}
    {
        CaptureIds: [0]
        Block[B1] - Block
            Predecessors: [B0]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M1(out int local)')
                  Value: 
                    IInvocationOperation (System.Int32? C.M1(out System.Int32 x)) (OperationKind.Invocation, Type: System.Int32?, IsInvalid) (Syntax: 'M1(out int local)')
                      Instance Receiver: 
                        null
                      Arguments(1):
                          IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out int local')
                            IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'int local')
                              ILocalReferenceOperation: local (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'local')
                            InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                            OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Jump if True (Regular) to Block[B3]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsInvalid, IsImplicit) (Syntax: 'M1(out int local)')
                  Operand: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'M1(out int local)')
                Leaving: {R2}

            Next (Regular) Block[B2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M1(out int local)')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M1(out int local)')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsInvalid, IsImplicit) (Syntax: 'M1(out int local)')
                      Arguments(0)

            Next (Regular) Block[B4]
                Leaving: {R2}
    }

    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsInvalid, IsImplicit) (Syntax: 'M2()')
              Value: 
                IInvocationOperation (System.Int32 C.M2()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2()')
                  Instance Receiver: 
                    null
                  Arguments(0)

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M1(out in ... al) ?? M2()')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= M1(out in ... al) ?? M2()')
              Right: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'M1(out int  ... al) ?? M2()')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,87719,88139);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_88003_88123(f_22066_88003_88103(f_22066_88003_88084(ErrorCode.ERR_DefaultValueMustBeConstant, "M1(out int local) ?? M2()"), "x"), 4, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,88155,88265);

f_22066_88155_88264(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,83196,88276);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,83196,88276);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,83196,88276);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoControlFlow_MissingParameterInitializerValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22066,88288,89749);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,88468,88559);

string 
source = @"
class C
{
    public void M(int x /*<bind>*/= /*</bind>*/) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,88573,89274);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= /*</bind>*/')
          Left: 
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= /*</bind>*/')
          Right: 
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,89288,89612);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22066_89511_89596(f_22066_89511_89576(f_22066_89511_89557(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 4, 48)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22066,89628,89738);

f_22066_89628_89737(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22066,88288,89749);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22066,88288,89749);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22066,88288,89749);
}
		}

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22066_882_975(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 882, 975);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22066_1062_1076(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1062, 1076);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22066_1062_1094(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1062, 1094);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22066_1062_1171(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source,System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
predicate)
{
var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1062, 1171);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode[]
f_22066_1062_1181(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxNode>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1062, 1181);
return return_v;
}


int
f_22066_1212_1224(Microsoft.CodeAnalysis.SyntaxNode[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22066, 1212, 1224);
return return_v;
}


int
f_22066_1196_1225(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1196, 1225);
return 0;
}


Microsoft.CodeAnalysis.SemanticModel
f_22066_1262_1296(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree)
{
var return_v = this_param.GetSemanticModel( syntaxTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1262, 1296);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_22066_1383_1415(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = this_param.GetOperation( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1383, 1415);
return return_v;
}


int
f_22066_1371_1416(Microsoft.CodeAnalysis.IOperation?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1371, 1416);
return 0;
}


Microsoft.CodeAnalysis.SyntaxNode[]
f_22066_1332_1337_I(Microsoft.CodeAnalysis.SyntaxNode[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 1332, 1337);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_2238_2291(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 2238, 2291);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_2238_2313(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 2238, 2313);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_2238_2333(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 2238, 2333);
return return_v;
}


int
f_22066_2365_2482(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 2365, 2482);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_3293_3346(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 3293, 3346);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_3293_3368(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 3293, 3368);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_3293_3388(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 3293, 3388);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_3557_3610(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 3557, 3610);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_3557_3632(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 3557, 3632);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_3557_3651(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 3557, 3651);
return return_v;
}


int
f_22066_3683_3800(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 3683, 3800);
return 0;
}


int
f_22066_4471_4588(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 4471, 4588);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_5473_5539(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 5473, 5539);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_5473_5559(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 5473, 5559);
return return_v;
}


int
f_22066_5591_5708(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 5591, 5708);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_6912_6978(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 6912, 6978);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_6912_6998(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 6912, 6998);
return return_v;
}


int
f_22066_7030_7147(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 7030, 7147);
return 0;
}


int
f_22066_8167_8284(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 8167, 8284);
return 0;
}


int
f_22066_9361_9478(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 9361, 9478);
return 0;
}


int
f_22066_10488_10605(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 10488, 10605);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11469_11522(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11469, 11522);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11469_11544(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11469, 11544);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11469_11563(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11469, 11563);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11710_11763(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11710, 11763);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11710_11785(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11710, 11785);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11710_11806(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11710, 11806);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11974_12027(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11974, 12027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11974_12049(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11974, 12049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_11974_12069(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 11974, 12069);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_12209_12262(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 12209, 12262);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_12209_12284(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 12209, 12284);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_12209_12304(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 12209, 12304);
return return_v;
}


int
f_22066_12336_12453(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 12336, 12453);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13326_13379(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13326, 13379);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13326_13401(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13326, 13401);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13326_13422(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13326, 13422);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13583_13636(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13583, 13636);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13583_13658(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13583, 13658);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13583_13678(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13583, 13678);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13825_13878(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13825, 13878);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13825_13900(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13825, 13900);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_13825_13920(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 13825, 13920);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_14060_14113(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 14060, 14113);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_14060_14135(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 14060, 14135);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_14060_14154(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 14060, 14154);
return return_v;
}


int
f_22066_14186_14303(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 14186, 14303);
return 0;
}


int
f_22066_15691_15808(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 15691, 15808);
return 0;
}


int
f_22066_17191_17308(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 17191, 17308);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_18553_18603(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 18553, 18603);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_18553_18631(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 18553, 18631);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_18553_18651(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 18553, 18651);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_18838_18890(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 18838, 18890);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_18838_18911(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 18838, 18911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_18838_18931(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 18838, 18931);
return return_v;
}


int
f_22066_18963_19080(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 18963, 19080);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_20217_20269(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 20217, 20269);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_20217_20290(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 20217, 20290);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_20217_20310(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 20217, 20310);
return return_v;
}


int
f_22066_20342_20459(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 20342, 20459);
return 0;
}


int
f_22066_21570_21679(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 21570, 21679);
return 0;
}


int
f_22066_22786_22895(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 22786, 22895);
return 0;
}


int
f_22066_24265_24374(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 24265, 24374);
return 0;
}


int
f_22066_25756_25865(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 25756, 25865);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_27330_27384(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 27330, 27384);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_27330_27406(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 27330, 27406);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_27330_27426(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 27330, 27426);
return return_v;
}


int
f_22066_27458_27567(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 27458, 27567);
return 0;
}


int
f_22066_28847_28956(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 28847, 28956);
return 0;
}


int
f_22066_31260_31369(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 31260, 31369);
return 0;
}


int
f_22066_34840_34949(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 34840, 34949);
return 0;
}


int
f_22066_38550_38659(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 38550, 38659);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_42442_42504(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 42442, 42504);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_42442_42526(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 42442, 42526);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_42442_42546(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 42442, 42546);
return return_v;
}


int
f_22066_42578_42687(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 42578, 42687);
return 0;
}


int
f_22066_45140_45249(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 45140, 45249);
return 0;
}


int
f_22066_49904_50013(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 49904, 50013);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_51456_51502(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 51456, 51502);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_51456_51521(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 51456, 51521);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_51456_51541(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 51456, 51541);
return return_v;
}


int
f_22066_51573_51682(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 51573, 51682);
return 0;
}


int
f_22066_52823_52932(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 52823, 52932);
return 0;
}


int
f_22066_54193_54302(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 54193, 54302);
return 0;
}


int
f_22066_55586_55695(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 55586, 55695);
return 0;
}


int
f_22066_57101_57210(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 57101, 57210);
return 0;
}


int
f_22066_60705_60814(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 60705, 60814);
return 0;
}


int
f_22066_64439_64548(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 64439, 64548);
return 0;
}


int
f_22066_67028_67137(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 67028, 67137);
return 0;
}


int
f_22066_71819_71928(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 71819, 71928);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_73407_73453(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 73407, 73453);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_73407_73472(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 73407, 73472);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_73407_73492(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 73407, 73492);
return return_v;
}


int
f_22066_73524_73633(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 73524, 73633);
return 0;
}


int
f_22066_74665_74774(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 74665, 74774);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_76182_76242(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 76182, 76242);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_76182_76261(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 76182, 76261);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_76182_76281(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 76182, 76281);
return return_v;
}


int
f_22066_76313_76422(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 76313, 76422);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_80147_80215(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 80147, 80215);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_80147_80234(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 80147, 80234);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_80147_80254(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 80147, 80254);
return return_v;
}


int
f_22066_80286_80395(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 80286, 80395);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_82919_82992(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 82919, 82992);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_82919_83011(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 82919, 83011);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_82919_83031(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 82919, 83031);
return return_v;
}


int
f_22066_83063_83172(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 83063, 83172);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_88003_88084(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 88003, 88084);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_88003_88103(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 88003, 88103);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_88003_88123(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 88003, 88123);
return return_v;
}


int
f_22066_88155_88264(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 88155, 88264);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_89511_89557(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 89511, 89557);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_89511_89576(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 89511, 89576);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22066_89511_89596(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 89511, 89596);
return return_v;
}


int
f_22066_89628_89737(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22066, 89628, 89737);
return 0;
}

}
}
