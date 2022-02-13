// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
[CompilerTrait(CompilerFeature.IOperation)]
    public partial class IOperationTests : SemanticModelTestBase
{
[Fact]
        public void ConstructorBody_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,593,1595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,666,719);

string 
source = @"
class C
{
    public C()
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,733,777);

var 
compilation = f_22019_751_776(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,793,1301);

f_22019_793_1300(
            compilation, f_22019_936_1003(f_22019_936_983(ErrorCode.ERR_SemicolonExpected, ""), 4, 15), f_22019_1188_1281(f_22019_1188_1261(f_22019_1188_1238(ErrorCode.ERR_ConcreteMissingBody, "C"), "C.C()"), 4, 12));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,1317,1361);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,1375,1422);

var 
model = f_22019_1387_1421(compilation, tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,1438,1531);

var 
node1 = f_22019_1450_1530(f_22019_1450_1521(f_22019_1450_1482(f_22019_1450_1464(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,1545,1584);

f_22019_1545_1583(f_22019_1557_1582(model, node1));
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,593,1595);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,593,1595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,593,1595);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,1607,4244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,1789,1851);

string 
source = @"
class C
{
    public C() : base()
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,1865,1909);

var 
compilation = f_22019_1883_1908(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,1925,2437);

f_22019_1925_2436(
            compilation, f_22019_2070_2137(f_22019_2070_2117(ErrorCode.ERR_SemicolonExpected, ""), 4, 24), f_22019_2324_2417(f_22019_2324_2397(f_22019_2324_2374(ErrorCode.ERR_ConcreteMissingBody, "C"), "C.C()"), 4, 12));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,2453,2497);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,2511,2604);

var 
node1 = f_22019_2523_2603(f_22019_2523_2594(f_22019_2523_2555(f_22019_2523_2537(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,2620,3391);

f_22019_2620_3390(
            compilation, node1, expectedOperationTree:
@"
IConstructorBodyOperation (OperationKind.ConstructorBody, Type: null, IsInvalid) (Syntax: 'public C() : base()')
  Initializer: 
    IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: ': base()')
      Expression: 
        IInvocationOperation ( System.Object..ctor()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: ': base()')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: ': base()')
          Arguments(0)
  BlockBody: 
    null
  ExpressionBody: 
    null
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,3405,4233);

f_22019_3405_4232(compilation, node1, expectedFlowGraph:
@"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: ': base()')
          Expression: 
            IInvocationOperation ( System.Object..ctor()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: ': base()')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: ': base()')
              Arguments(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,1607,4244);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,1607,4244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,1607,4244);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,4256,7592);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,4441,4524);

string 
source = @"
class C
{
    public C() : base()
    { throw null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,4538,4582);

var 
compilation = f_22019_4556_4581(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,4598,4630);

f_22019_4598_4629(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,4646,4690);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,4704,4797);

var 
node1 = f_22019_4716_4796(f_22019_4716_4787(f_22019_4716_4748(f_22019_4716_4730(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,4813,6214);

f_22019_4813_6213(
            compilation, node1, expectedOperationTree:
@"
    IConstructorBodyOperation (OperationKind.ConstructorBody, Type: null) (Syntax: 'public C()  ... row null; }')
      Initializer: 
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: ': base()')
          Expression: 
            IInvocationOperation ( System.Object..ctor()) (OperationKind.Invocation, Type: System.Void) (Syntax: ': base()')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object, IsImplicit) (Syntax: ': base()')
              Arguments(0)
      BlockBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ throw null; }')
          IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null;')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
      ExpressionBody: 
        null
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,6230,7581);

f_22019_6230_7580(compilation, node1, expectedFlowGraph:
@"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: ': base()')
              Expression: 
                IInvocationOperation ( System.Object..ctor()) (OperationKind.Invocation, Type: System.Void) (Syntax: ': base()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object, IsImplicit) (Syntax: ': base()')
                  Arguments(0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B2] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,4256,7592);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,4256,7592);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,4256,7592);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,7604,11111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,7794,7876);

string 
source = @"
class C
{
    public C() : base()
    => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,7890,7934);

var 
compilation = f_22019_7908_7933(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,7950,7982);

f_22019_7950_7981(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,7998,8042);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,8056,8149);

var 
node1 = f_22019_8068_8148(f_22019_8068_8139(f_22019_8068_8100(f_22019_8068_8082(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,8165,9733);

f_22019_8165_9732(
            compilation, node1, expectedOperationTree:
@"
    IConstructorBodyOperation (OperationKind.ConstructorBody, Type: null) (Syntax: 'public C()  ... throw null;')
      Initializer: 
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: ': base()')
          Expression: 
            IInvocationOperation ( System.Object..ctor()) (OperationKind.Invocation, Type: System.Void) (Syntax: ': base()')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object, IsImplicit) (Syntax: ': base()')
              Arguments(0)
      BlockBody: 
        null
      ExpressionBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> throw null')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'throw null')
            Expression: 
              IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,9749,11100);

f_22019_9749_11099(compilation, node1, expectedFlowGraph:
@"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: ': base()')
              Expression: 
                IInvocationOperation ( System.Object..ctor()) (OperationKind.Invocation, Type: System.Void) (Syntax: ': base()')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object, IsImplicit) (Syntax: ': base()')
                  Arguments(0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B2] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,7604,11111);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,7604,11111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,7604,11111);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,11123,13409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,11290,11364);

string 
source = @"
class C
{
    public C()
    { throw null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,11378,11422);

var 
compilation = f_22019_11396_11421(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,11438,11470);

f_22019_11438_11469(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,11486,11530);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,11544,11637);

var 
node1 = f_22019_11556_11636(f_22019_11556_11627(f_22019_11556_11588(f_22019_11556_11570(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,11653,12561);

f_22019_11653_12560(
            compilation, node1, expectedOperationTree:
@"
    IConstructorBodyOperation (OperationKind.ConstructorBody, Type: null) (Syntax: 'public C() ... row null; }')
      Initializer: 
        null
      BlockBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ throw null; }')
          IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null;')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
      ExpressionBody: 
        null
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,12577,13398);

f_22019_12577_13397(compilation, node1, expectedFlowGraph:
@"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B2] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,11123,13409);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,11123,13409);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,11123,13409);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,13421,15878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,13593,13666);

string 
source = @"
class C
{
    public C()
    => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,13680,13724);

var 
compilation = f_22019_13698_13723(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,13740,13772);

f_22019_13740_13771(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,13788,13832);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,13846,13939);

var 
node1 = f_22019_13858_13938(f_22019_13858_13929(f_22019_13858_13890(f_22019_13858_13872(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,13955,15030);

f_22019_13955_15029(
            compilation, node1, expectedOperationTree:
@"
    IConstructorBodyOperation (OperationKind.ConstructorBody, Type: null) (Syntax: 'public C() ... throw null;')
      Initializer: 
        null
      BlockBody: 
        null
      ExpressionBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> throw null')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'throw null')
            Expression: 
              IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,15046,15867);

f_22019_15046_15866(compilation, node1, expectedFlowGraph:
@"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B2] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,13421,15878);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,13421,15878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,13421,15878);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,15890,20128);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,16072,16166);

string 
source = @"
class C
{
    public C()
    { throw null; }
    => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,16180,16224);

var 
compilation = f_22019_16198_16223(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,16240,16571);

f_22019_16240_16570(
            compilation, f_22019_16424_16551(f_22019_16424_16532(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public C()
    { throw null; }
    => throw null;"), 4, 5));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,16587,16631);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,16645,16738);

var 
node1 = f_22019_16657_16737(f_22019_16657_16728(f_22019_16657_16689(f_22019_16657_16671(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,16754,18557);

f_22019_16754_18556(
            compilation, node1, expectedOperationTree:
@"
    IConstructorBodyOperation (OperationKind.ConstructorBody, Type: null, IsInvalid) (Syntax: 'public C() ... throw null;')
      Initializer: 
        null
      BlockBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ throw null; }')
          IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null;')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
      ExpressionBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> throw null')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw null')
            Expression: 
              IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,18573,20117);

f_22019_18573_20116(compilation, node1, expectedFlowGraph:
@"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    .erroneous body {R1}
    {
        Block[B2] - Block [UnReachable]
            Predecessors (0)
            Statements (0)
            Next (Throw) Block[null]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    }
    Block[B3] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,15890,20128);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,15890,20128);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,15890,20128);
}
		}

[Fact]
        public void ConstructorBody_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,20140,21003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,20253,20307);

string 
source = @"
class C
{
    public C();
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,20321,20365);

var 
compilation = f_22019_20339_20364(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,20381,20709);

f_22019_20381_20708(
            compilation, f_22019_20596_20689(f_22019_20596_20669(f_22019_20596_20646(ErrorCode.ERR_ConcreteMissingBody, "C"), "C.C()"), 4, 12));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,20725,20769);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,20783,20830);

var 
model = f_22019_20795_20829(compilation, tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,20846,20939);

var 
node1 = f_22019_20858_20938(f_22019_20858_20929(f_22019_20858_20890(f_22019_20858_20872(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,20953,20992);

f_22019_20953_20991(f_22019_20965_20990(model, node1));
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,20140,21003);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,20140,21003);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,20140,21003);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,21015,24199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,21215,21342);

string 
source = @"
class C
{
    public C(int i1, int i2, int j1, int j2) : base()
    { i1 = i2; }
    => j1 = j2;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,21356,21400);

var 
compilation = f_22019_21374_21399(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,21416,21801);

f_22019_21416_21800(
            compilation, f_22019_21639_21799(f_22019_21639_21780(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public C(int i1, int i2, int j1, int j2) : base()
    { i1 = i2; }
    => j1 = j2;"), 4, 5));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,21817,21861);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,21875,21968);

var 
node1 = f_22019_21887_21967(f_22019_21887_21958(f_22019_21887_21919(f_22019_21887_21901(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,21984,24188);

f_22019_21984_24187(compilation, node1, expectedFlowGraph:
@"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: ': base()')
          Expression: 
            IInvocationOperation ( System.Object..ctor()) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: ': base()')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object, IsInvalid, IsImplicit) (Syntax: ': base()')
              Arguments(0)

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'i1 = i2;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i1 = i2')
              Left: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
              Right: 
                IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i2')

    Next (Regular) Block[B3]

.erroneous body {R1}
{
    Block[B2] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'j1 = j2')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'j1 = j2')
                  Left: 
                    IParameterReferenceOperation: j1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'j1')
                  Right: 
                    IParameterReferenceOperation: j2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'j2')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,21015,24199);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,21015,24199);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,21015,24199);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,24211,26148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,24548,24638);

string 
source = @"
class C
{
    public C()
    { return; }
    => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,24652,24696);

var 
compilation = f_22019_24670_24695(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,24712,25035);

f_22019_24712_25034(
            compilation, f_22019_24896_25019(f_22019_24896_25000(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public C()
    { return; }
    => throw null;"), 4, 5));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,25051,25095);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,25109,25202);

var 
node1 = f_22019_25121_25201(f_22019_25121_25192(f_22019_25121_25153(f_22019_25121_25135(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,25218,26137);

f_22019_25218_26136(compilation, node1, expectedFlowGraph:
@"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B2]
    .erroneous body {R1}
    {
        Block[B1] - Block [UnReachable]
            Predecessors (0)
            Statements (0)
            Next (Throw) Block[null]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    }
    Block[B2] - Exit
        Predecessors: [B0]
        Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,24211,26148);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,24211,26148);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,24211,26148);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,26160,29104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,26342,26529);

string 
source = @"
class C : Base
{
    C(int p) : base(out var i)
    {
        p = i;
    }
}

class Base
{
    protected Base(out int i)
    {
        i = 1;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,26543,26587);

var 
compilation = f_22019_26561_26586(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,26603,26635);

f_22019_26603_26634(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,26651,26695);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,26709,26801);

var 
node1 = f_22019_26721_26800(f_22019_26721_26792(f_22019_26721_26753(f_22019_26721_26735(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,26817,29093);

f_22019_26817_29092(compilation, node1, expectedFlowGraph:
@"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: ': base(out var i)')
              Expression: 
                IInvocationOperation ( Base..ctor(out System.Int32 i)) (OperationKind.Invocation, Type: System.Void) (Syntax: ': base(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Base, IsImplicit) (Syntax: ': base(out var i)')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = i;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = i')
                  Left: 
                    IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
                  Right: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,26160,29104);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,26160,29104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,26160,29104);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,29116,32061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,29303,29475);

string 
source = @"
class C : Base
{
    C(int p) : base(out var i)
    => p = i;
}

class Base
{
    protected Base(out int i)
    {
        i = 1;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,29489,29533);

var 
compilation = f_22019_29507_29532(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,29549,29581);

f_22019_29549_29580(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,29597,29641);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,29655,29747);

var 
node1 = f_22019_29667_29746(f_22019_29667_29738(f_22019_29667_29699(f_22019_29667_29681(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,29763,32050);

f_22019_29763_32049(compilation, node1, expectedFlowGraph:
@"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: ': base(out var i)')
              Expression: 
                IInvocationOperation ( Base..ctor(out System.Int32 i)) (OperationKind.Invocation, Type: System.Void) (Syntax: ': base(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Base, IsImplicit) (Syntax: ': base(out var i)')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'p = i')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = i')
                  Left: 
                    IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
                  Right: 
                    ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,29116,32061);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,29116,32061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,29116,32061);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,32073,34932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,32252,32404);

string 
source = @"
class C : Base
{
    C() : base(out var i)
}

class Base
{
    protected Base(out int i)
    {
        i = 1;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,32418,32462);

var 
compilation = f_22019_32436_32461(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,32478,32974);

f_22019_32478_32973(
            compilation, f_22019_32625_32692(f_22019_32625_32672(ErrorCode.ERR_SemicolonExpected, ""), 4, 26), f_22019_32880_32972(f_22019_32880_32953(f_22019_32880_32930(ErrorCode.ERR_ConcreteMissingBody, "C"), "C.C()"), 4, 5));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,32990,33034);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,33048,33140);

var 
node1 = f_22019_33060_33139(f_22019_33060_33131(f_22019_33060_33092(f_22019_33060_33074(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,33156,34921);

f_22019_33156_34920(compilation, node1, expectedFlowGraph:
@"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: ': base(out var i)')
              Expression: 
                IInvocationOperation ( Base..ctor(out System.Int32 i)) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: ': base(out var i)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Base, IsInvalid, IsImplicit) (Syntax: ': base(out var i)')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var i')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
                          ILocalReferenceOperation: i (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,32073,34932);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,32073,34932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,32073,34932);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_14()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,34944,40163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,35141,35386);

string 
source = @"
class C : Base
{
    C(int j1, int j2) : base(out var i1, out var i2)
    { i1 = j1; }
    => j2 = i2;
}

class Base
{
    protected Base(out int i1, out int i2)
    {
        i1 = 1;
        i2 = 1;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,35400,35444);

var 
compilation = f_22019_35418_35443(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,35460,35843);

f_22019_35460_35842(
            compilation, f_22019_35682_35841(f_22019_35682_35822(ErrorCode.ERR_BlockBodyAndExpressionBody, @"C(int j1, int j2) : base(out var i1, out var i2)
    { i1 = j1; }
    => j2 = i2;"), 4, 5));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,35859,35903);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,35917,36009);

var 
node1 = f_22019_35929_36008(f_22019_35929_36000(f_22019_35929_35961(f_22019_35929_35943(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,36025,40152);

f_22019_36025_40151(compilation, node1, expectedFlowGraph:
@"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 i1] [System.Int32 i2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: ': base(out  ... out var i2)')
              Expression: 
                IInvocationOperation ( Base..ctor(out System.Int32 i1, out System.Int32 i2)) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: ': base(out  ... out var i2)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Base, IsInvalid, IsImplicit) (Syntax: ': base(out  ... out var i2)')
                  Arguments(2):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i1) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out var i1')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var i1')
                          ILocalReferenceOperation: i1 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i2) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out var i2')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var i2')
                          ILocalReferenceOperation: i2 (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'i2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'i1 = j1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i1 = j1')
                  Left: 
                    ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
                  Right: 
                    IParameterReferenceOperation: j1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'j1')

        Next (Regular) Block[B3]
            Leaving: {R1}

    .erroneous body {R2}
    {
        Block[B2] - Block [UnReachable]
            Predecessors (0)
            Statements (1)
                IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'j2 = i2')
                  Expression: 
                    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'j2 = i2')
                      Left: 
                        IParameterReferenceOperation: j2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'j2')
                      Right: 
                        ILocalReferenceOperation: i2 (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'i2')

            Next (Regular) Block[B3]
                Leaving: {R2} {R1}
    }
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,34944,40163);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,34944,40163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,34944,40163);
}
		}

[CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void ConstructorBody_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22019,40175,45274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,40375,40524);

string 
source = @"
class C
{
    C(int? i, int j, int k, int p) : this(i ?? j) 
    {
        p = k;
    }

    C(int i)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,40538,40582);

var 
compilation = f_22019_40556_40581(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,40598,40630);

f_22019_40598_40629(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,40646,40690);

var 
tree = compilation.SyntaxTrees.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,40704,40796);

var 
node1 = f_22019_40716_40795(f_22019_40716_40787(f_22019_40716_40748(f_22019_40716_40730(tree))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22019,40812,45263);

f_22019_40812_45262(compilation, node1, expectedFlowGraph:
@"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: ': this(i ?? j)')
              Value: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: ': this(i ?? j)')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                  Value: 
                    IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'i')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'i')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'i')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'i')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'i')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j')
              Value: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: ': this(i ?? j)')
              Expression: 
                IInvocationOperation ( C..ctor(System.Int32 i)) (OperationKind.Invocation, Type: System.Void) (Syntax: ': this(i ?? j)')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: ': this(i ?? j)')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'i ?? j')
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i ?? j')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Block
    Predecessors: [B5]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = k;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = k')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')
              Right: 
                IParameterReferenceOperation: k (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'k')

    Next (Regular) Block[B7]
Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
");
DynAbs.Tracing.TraceSender.TraceExitMethod(22019,40175,45274);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22019,40175,45274);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22019,40175,45274);
}
		}

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_751_776(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 751, 776);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_936_983(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 936, 983);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_936_1003(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 936, 1003);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_1188_1238(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1188, 1238);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_1188_1261(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1188, 1261);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_1188_1281(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1188, 1281);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_793_1300(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 793, 1300);
return return_v;
}


Microsoft.CodeAnalysis.SemanticModel
f_22019_1387_1421(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree)
{
var return_v = this_param.GetSemanticModel( syntaxTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1387, 1421);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_1450_1464(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1450, 1464);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_1450_1482(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1450, 1482);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_1450_1521(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1450, 1521);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_1450_1530(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1450, 1530);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_22019_1557_1582(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node)
{
var return_v = this_param.GetOperation( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1557, 1582);
return return_v;
}


int
f_22019_1545_1583(Microsoft.CodeAnalysis.IOperation?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1545, 1583);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_1883_1908(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1883, 1908);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_2070_2117(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2070, 2117);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_2070_2137(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2070, 2137);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_2324_2374(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2324, 2374);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_2324_2397(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2324, 2397);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_2324_2417(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2324, 2417);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_1925_2436(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 1925, 2436);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_2523_2537(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2523, 2537);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_2523_2555(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2523, 2555);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_2523_2594(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2523, 2594);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_2523_2603(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2523, 2603);
return return_v;
}


int
f_22019_2620_3390(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node,string
expectedOperationTree)
{
compilation.VerifyOperationTree( (Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree:expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 2620, 3390);
return 0;
}


int
f_22019_3405_4232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 3405, 4232);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_4556_4581(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 4556, 4581);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_4598_4629(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 4598, 4629);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_4716_4730(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 4716, 4730);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_4716_4748(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 4716, 4748);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_4716_4787(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 4716, 4787);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_4716_4796(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 4716, 4796);
return return_v;
}


int
f_22019_4813_6213(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node,string
expectedOperationTree)
{
compilation.VerifyOperationTree( (Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree:expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 4813, 6213);
return 0;
}


int
f_22019_6230_7580(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 6230, 7580);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_7908_7933(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 7908, 7933);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_7950_7981(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 7950, 7981);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_8068_8082(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 8068, 8082);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_8068_8100(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 8068, 8100);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_8068_8139(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 8068, 8139);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_8068_8148(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 8068, 8148);
return return_v;
}


int
f_22019_8165_9732(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node,string
expectedOperationTree)
{
compilation.VerifyOperationTree( (Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree:expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 8165, 9732);
return 0;
}


int
f_22019_9749_11099(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 9749, 11099);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_11396_11421(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 11396, 11421);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_11438_11469(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 11438, 11469);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_11556_11570(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 11556, 11570);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_11556_11588(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 11556, 11588);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_11556_11627(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 11556, 11627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_11556_11636(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 11556, 11636);
return return_v;
}


int
f_22019_11653_12560(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node,string
expectedOperationTree)
{
compilation.VerifyOperationTree( (Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree:expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 11653, 12560);
return 0;
}


int
f_22019_12577_13397(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 12577, 13397);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_13698_13723(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 13698, 13723);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_13740_13771(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 13740, 13771);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_13858_13872(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 13858, 13872);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_13858_13890(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 13858, 13890);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_13858_13929(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 13858, 13929);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_13858_13938(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 13858, 13938);
return return_v;
}


int
f_22019_13955_15029(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node,string
expectedOperationTree)
{
compilation.VerifyOperationTree( (Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree:expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 13955, 15029);
return 0;
}


int
f_22019_15046_15866(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 15046, 15866);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_16198_16223(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16198, 16223);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_16424_16532(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16424, 16532);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_16424_16551(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16424, 16551);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_16240_16570(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16240, 16570);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_16657_16671(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16657, 16671);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_16657_16689(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16657, 16689);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_16657_16728(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16657, 16728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_16657_16737(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16657, 16737);
return return_v;
}


int
f_22019_16754_18556(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node,string
expectedOperationTree)
{
compilation.VerifyOperationTree( (Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree:expectedOperationTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 16754, 18556);
return 0;
}


int
f_22019_18573_20116(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 18573, 20116);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_20339_20364(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20339, 20364);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_20596_20646(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20596, 20646);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_20596_20669(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20596, 20669);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_20596_20689(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20596, 20689);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_20381_20708(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20381, 20708);
return return_v;
}


Microsoft.CodeAnalysis.SemanticModel
f_22019_20795_20829(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree)
{
var return_v = this_param.GetSemanticModel( syntaxTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20795, 20829);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_20858_20872(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20858, 20872);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_20858_20890(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20858, 20890);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_20858_20929(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20858, 20929);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_20858_20938(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20858, 20938);
return return_v;
}


Microsoft.CodeAnalysis.IOperation?
f_22019_20965_20990(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node)
{
var return_v = this_param.GetOperation( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20965, 20990);
return return_v;
}


int
f_22019_20953_20991(Microsoft.CodeAnalysis.IOperation?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 20953, 20991);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_21374_21399(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21374, 21399);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_21639_21780(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21639, 21780);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_21639_21799(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21639, 21799);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_21416_21800(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21416, 21800);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_21887_21901(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21887, 21901);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_21887_21919(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21887, 21919);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_21887_21958(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21887, 21958);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_21887_21967(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21887, 21967);
return return_v;
}


int
f_22019_21984_24187(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 21984, 24187);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_24670_24695(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 24670, 24695);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_24896_25000(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 24896, 25000);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_24896_25019(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 24896, 25019);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_24712_25034(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 24712, 25034);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_25121_25135(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 25121, 25135);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_25121_25153(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 25121, 25153);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_25121_25192(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 25121, 25192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_25121_25201(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 25121, 25201);
return return_v;
}


int
f_22019_25218_26136(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 25218, 26136);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_26561_26586(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 26561, 26586);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_26603_26634(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 26603, 26634);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_26721_26735(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 26721, 26735);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_26721_26753(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 26721, 26753);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_26721_26792(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 26721, 26792);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_26721_26800(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 26721, 26800);
return return_v;
}


int
f_22019_26817_29092(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 26817, 29092);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_29507_29532(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 29507, 29532);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_29549_29580(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 29549, 29580);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_29667_29681(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 29667, 29681);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_29667_29699(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 29667, 29699);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_29667_29738(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 29667, 29738);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_29667_29746(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 29667, 29746);
return return_v;
}


int
f_22019_29763_32049(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 29763, 32049);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_32436_32461(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 32436, 32461);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_32625_32672(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 32625, 32672);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_32625_32692(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 32625, 32692);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_32880_32930(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 32880, 32930);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_32880_32953(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 32880, 32953);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_32880_32972(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 32880, 32972);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_32478_32973(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 32478, 32973);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_33060_33074(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 33060, 33074);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_33060_33092(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 33060, 33092);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_33060_33131(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 33060, 33131);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_33060_33139(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 33060, 33139);
return return_v;
}


int
f_22019_33156_34920(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 33156, 34920);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_35418_35443(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 35418, 35443);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_35682_35822(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 35682, 35822);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22019_35682_35841(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 35682, 35841);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_35460_35842(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 35460, 35842);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_35929_35943(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 35929, 35943);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_35929_35961(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 35929, 35961);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_35929_36000(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 35929, 36000);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_35929_36008(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 35929, 36008);
return return_v;
}


int
f_22019_36025_40151(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 36025, 40151);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_40556_40581(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 40556, 40581);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22019_40598_40629(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 40598, 40629);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_22019_40716_40730(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.GetRoot();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 40716, 40730);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22019_40716_40748(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 40716, 40748);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
f_22019_40716_40787(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 40716, 40787);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_22019_40716_40795(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 40716, 40795);
return return_v;
}


int
f_22019_40812_45262(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntaxNode,string
expectedFlowGraph)
{
VerifyFlowGraph( compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph:expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22019, 40812, 45262);
return 0;
}

}
}
